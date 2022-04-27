using System;
using System.Collections.Generic;
using System.Text;

namespace Triton.Service.Model.CRM.Custom
{
    public class CustomerMeetingAndCallModel
    {
        public string LoggedBy { get; set; }
        public DateTime DateOfMeeting { get; set; }
        public DateTime LoggedOn { get; set; }
        public string TimeOfMeeting { get; set; }
        public int PurposeOfMeeting { get; set; }
        public int TritonAttendees { get; set; }
        public string Minutes { get; set; }
        public int ActionBy { get; set; }
        public int Whom { get; set; }
        public DateTime ByWhen { get; set; }
        public string GenralComments { get; set; }


        public int Reception_ImpressionPolitenessLCID { get; set; }
        public int Reception_ResponseAnswertimeLCID { get; set; }
        public int Reception_CallAnsweredCorrectlyAnsweredLCID { get; set; }

        public int CS_ImpressionAndPolitenessLCID { get; set; }
        public int CS_FeedbackAndResponseTimeLCID { get; set; }
        public int CS_QueryProblemSolvingLCID { get; set; }

        public int Inhouse_ImpressionAndPolitenessLCID { get; set; }
        public int Inhouse_PunctualityLCID { get; set; }
        public int Inhouse_SkillLevelLCID { get; set; }
        public int Inhouse_QueryProblemSolvingLCID { get; set; }
        public int Inhouse_ValueAddedLCID { get; set; }

        public int Operations_CollectionComplianceLCID { get; set; }
        public int Operations_DeliveryComplianceLCID { get; set; }
        public int Operations_DriverImpressionsLCID { get; set; }
        public int Operations_VehicleImpressionsLCID { get; set; }
        public int Operations_DamagesDescrepanciesLCID { get; set; }

        public int AFSC_ImpressionPolitenessLCID { get; set; }
        public int AFSC_PuncatualityProfessionalismLCID { get; set; }
        public int AFSC_FeedbackAndResponseTimeLCID { get; set; }
        public int AFSC_QueryProblemSolvingLCID { get; set; }


        public int Admin_InvoiceStatementCorrectLCID { get; set; }
        public int Admin_PODAvailableLCID { get; set; }
        public int Admin_AccountResponseTimeLCID { get; set; }
        public int Admin_CliamsResponseTimeLCID { get; set; }
    }
}
