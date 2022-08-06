using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApp.Models.SurveyAggregate
{
    public class SurveyResponse
    {
        public int Id { get; set; }
        public string Response { get; set; } = string.Empty;
        public Survey? Survey { get; set; }
        public DateTime SurveyResponseDate { get; set; }
    }
}
