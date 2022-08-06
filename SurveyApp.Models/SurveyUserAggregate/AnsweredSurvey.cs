using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApp.Models.SurveyUserAggregate
{
    public class AnsweredSurvey
    {
        public int Id { get; set; }
        public SurveyUser? SurveyUser { get; set; }
    }
}
