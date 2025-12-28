using Back_Quiz.Data;
using Back_Quiz.Exceptions;
using Back_Quiz.Interfaces;
using Back_Quiz.Models;
using Microsoft.EntityFrameworkCore;

namespace Back_Quiz.Repositories;

public class QuizResultRepository : IQuizResultRepository
{
    private readonly ApplicationDbContext _context;
    
    public QuizResultRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public async Task<List<QuizResult>> GetQuizResults(string userId)
    {
        var results = await _context.QuizResults
            .Where(q => q.UserId == userId)
            .AsNoTracking()
            .ToListAsync();
        
        return results;
    }

    public async Task<QuizResult> GetQuizResultById(string userId, Guid quizId)
    {
        var result = await _context.QuizResults
            .Where(q => q.UserId == userId && q.Id == quizId)
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (result == null)
        {
            throw new CustomExceptions.ResultNotFoundException();
        }
        
        return result;
    }
}