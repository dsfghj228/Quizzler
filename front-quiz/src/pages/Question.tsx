import { useEffect, useState } from "react";
import toast, { Toaster } from "react-hot-toast";
import { useParams } from "react-router-dom";
import { getCurrentQuestion } from "../api/api";
import QuestionBg from "../assets/images/QuestionBg.svg";
import { quizResponse } from "../types/quiz.types";

function Question() {
  const { sessionId, questionIndex } = useParams();
  const [question, setQuestion] = useState<quizResponse>();
  const [selectedOptionId, setSelectedOptionId] = useState<string>();

  useEffect(() => {
    if (!sessionId) {
      toast.error("Couldn't get session id");
      return;
    }

    const fetchQuestion = async () => {
      try {
        const data = await getCurrentQuestion(sessionId);
        setQuestion(data);
        console.log(data);
      } catch (error: any) {
        toast(error || "Something went wrong");
      }
    };

    fetchQuestion();
  });

  return (
    <div
      className="flex items-center justify-center bg-center bg-no-repeat bg-cover h-screen w-screen"
      style={{ backgroundImage: `url(${QuestionBg})` }}
    >
      <Toaster position="top-center" />
      <div className="flex flex-col items-center">
        <div className="flex flex-col items-center font-semibold text-3xl pb-[40px]">
          <h1 className="pb-[40px]">Question {questionIndex}</h1>
          <p className="pb-[40px]">{question?.question.text}</p>
          <div className="w-[200px] border-b-[2px] border-black" />
        </div>
        <div className="flex flex-col items-center">
          {question?.question.options.map((q, index) => {
            return (
              <button
                className={`w-[700px] h-[80px] bg-white mb-[20px] flex items-center py-[20px] px-[50px] rounded-[10px]
                    ${
                      selectedOptionId !== q.id
                        ? "bg-white] text-black"
                        : "bg-[#FE909D] text-white"
                    }`}
                onClick={() => setSelectedOptionId(q.id)}
              >
                <div
                  className={`flex items-center justify-center w-[50px] h-[50px] rounded-full bg-[#FFECDB] text-[#FF475D] font-semibold text-3xl mr-[50px]
                    ${
                      selectedOptionId !== q.id
                        ? "bg-[#FFECDB] text-[#FF475D]"
                        : "bg-[#FF475D] text-[#FFECDB]"
                    }`}
                >
                  {index}
                </div>

                <p className="font-medium text-xl">{q.text}</p>
              </button>
            );
          })}
        </div>
        <button className="w-[150px] h-[75px] rounded-[10px] mt-[30px] bg-[#FFB0BA] text-[#FF475D] font-semibold text-3xl">
          Next
        </button>
      </div>
    </div>
  );
}

export default Question;
