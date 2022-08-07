using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SurveyApp.Models.SurveyAggregate;

namespace SurveyApp.Api.Infrastructure.EntityConfiguration
{
    public class SurveyEntityTypeConfiguration : IEntityTypeConfiguration<Survey>
    {
        public void Configure(EntityTypeBuilder<Survey> builder)
        {
            throw new NotImplementedException();
        }
    }
}
