export type option = {
  id: string;
  text: string;
  isCorrect: boolean;
};

export type question = {
  id: string;
  text: string;
  options: Array<option>;
};

export interface quizResponse {
  sessionId: string;
  question: question;
  questionNumber: number | null;
  totalQuestions: number | null;
}

export interface startQuizRequest {
  category: string;
  difficulty: number;
  numberOfQuestions: number;
}
