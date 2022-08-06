using SurveyApp.Api.Infrastructure;
using SurveyApp.Models.SurveyAggregate;

namespace SurveyApp.Api.Services
{
    public class SurveyRepository : ISurveyRepository
    {
        private readonly SurveyContext _surveyContext;
        public SurveyRepository(SurveyContext surveyContext)
        {
            _surveyContext = surveyContext;
        }
        public Task<Survey> AddSurvey(Survey survey)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteSurvey(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Survey>> GetSurvey()
        {
            throw new NotImplementedException();
        }

        public Task<Survey> GetSurveyById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Survey> UpdateSurvey(Survey survey)
        {
            throw new NotImplementedException();
        }
    }
}
