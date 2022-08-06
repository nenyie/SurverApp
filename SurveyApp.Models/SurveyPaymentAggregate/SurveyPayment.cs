using SurveyApp.Models.SurveyUserAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApp.Models.SurveyPaymentAggregate
{
    public class SurveyPayment
    {
        public int Id { get; set; }
        public TransactionStatus TransactionStatus { get; set; }
        public string ReferenceId { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public SurveyUser? SurveyUser { get; set; }
        public DateTime Created { get; set; }
    }

    public enum TransactionStatus
    {

    }
}
