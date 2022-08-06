using SurveyApp.Models.SurveyAggregate;

namespace SurveyApp.Api.Services
{
    public interface ISurveyRepository
    {
        Task<IEnumerable<Survey>> GetSurvey();
        Task<Survey> GetSurveyById(int id);
        Task<bool> DeleteSurvey(int id);
        Task<Survey> AddSurvey(Survey survey);
        Task<Survey> UpdateSurvey(Survey survey);
    }
}
