using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApp.Models.SurveyAggregate
{
    public class Survey
    {
        public int Id { get; set; }
        public string Question { get; set; } = string.Empty;
        public Options options { get; set; }
        public DateTimeOffset SurveyDate { get; set; }
        public DateTimeOffset SurveyUpdate { get; set; }


    }

    public enum Options
    {

    }
}
