namespace Back_Quiz.Dtos.Quiz;

public class QuizResultDto
{
    public Guid ResultId { get; set; }
    public string UserId { get; set; }
    public string SessionId { get; set; }
    public int CorrectAnswers { get; set; }
    public int TotalQuestions { get; set; }
    public DateTime CompletedAt { get; set; }
    
}