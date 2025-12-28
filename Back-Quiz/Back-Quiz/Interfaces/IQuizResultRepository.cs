using Back_Quiz.Models;

namespace Back_Quiz.Interfaces;

public interface IQuizResultRepository
{
    Task<List<QuizResult>> GetQuizResults(string userId);
    Task<QuizResult> GetQuizResultById(string userId, Guid quizId);
}