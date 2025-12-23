using Back_Quiz.Enums;
using Back_Quiz.Models;
using Back_Quiz.Quiz;

namespace Back_Quiz.Interfaces;

public interface IQuizService
{
    Task<StartQuizResponse> CreateQuizAsync(string Category, Difficulty Difficulty, int NumberOfQuestions, string UserId);
    Task<StartQuizResponse> GetCurrentQuestionAsync(string sessionId, string userId);
    Task<StartQuizResponse> MakeMoveAsync(string sessionId, string userId, Guid selectedOptionId);
}