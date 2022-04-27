using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Triton.Model.LeaveManagement.Tables;
using Triton.Model.TritonBlobs.Tables;
using Triton.Model.TritonDrivecam.Tables;
using Triton.Model.TritonOps.Custom;
using Triton.Model.TritonOps.Tables;
using Triton.Model.TritonSecurity.Tables;

namespace Triton.Model.TritonOps.Views
{
    public class vw_Drivecam
    {
        [Dapper.Contrib.Extensions.Key]
        public long DrivecamID { get; set; }

        public int EmployeeID { get; set; }

        public string Driver { get; set; }

        public int BranchID { get; set; }
        public string Vehicle { get; set; }
        public int VehicleID { get; set; }
        public string Behaviours { get; set; }
        public int RecordID { get; set; }

        public Int64 WorkID { get; set; }

        [ForeignKey("WorkFlowID")]
        public int WorkFlowID { get; set; }

        [DisplayName("Event Date")]
        [DisplayFormat(DataFormatString = "{dddd, MMMM d, yyyy}")]
        public DateTime EventDateStamp { get; set; }

        [DisplayName("Event Time")]
        public string EventTime { get; set; }

        [Required]
        [DisplayName("Event Number")]
        public string EventNumber { get; set; }

        [DisplayName("Event URL")]
        public string EventURL { get; set; }

        [DisplayName("Event Score")]
        public string EventScore { get; set; }

        [DisplayName("Branch Name")]
        public string BranchName { get; set; }

        public string Collision { get; set; }
        public string Excluded { get; set; }

        [DisplayName("Work Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM/dd}")]
        public DateTime WorkDate { get; set; }

        [DisplayName("Alternate Branch Name")]
        public string AlternateBranchName { get; set; }
        public int StageID { get; set; }
        public bool Mark { get; set; }
        public string View { get; set; }
        public int AccidentID { get; set; }
        public string Location { get; set; }
        public string Counselled { get; set; }
        public string Reason { get; set; }

        [DisplayName("WorkFlow Stage")]
        public string WorkFlowStage { get; set; }

        [DisplayName("WorkFlow Task")]
        public string WorkFlowTask { get; set; }

        [DisplayName("Created By")]
        public string Name { get; set; }

        public string Comments { get; set; }
        public long VideoBlobID { get; set; }
        public string Note { get; set; }

        [DisplayName("Accident Case Number")]
        public string AccidentCaseNo { get; set; }

        [DisplayName("Note Created By ID")]
        public int NoteCreatedByID { get; set; }

        [DisplayName("Note Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM/dd}")]
        public DateTime NoteDate { get; set; }

        public int IsMail { get; set; }
        public long NotificationID { get; set; }

        [DisplayName("Note Type ID")]
        public int NoteTypeID { get; set; }

        [DisplayName("Image Name")]
        public string ImgName { get; set; }

        [DisplayName("Image Content Type")]
        public string ImgContentType { get; set; }

        [DisplayName("Image Length")]
        public string ImgLength { get; set; }

        [DisplayName("Image Data")]
        public byte[] ImgData { get; set; }

        public Blobs Blobs { get; set; }
        public SendEmailModel SendEmailModel { get; set; }
        public List<Branches> Branches { get; set; }
        public List<TritonGroup.Tables.WorkFlowManager> WorkFlowManager { get; set; }

        public List<DrivecamNotes> DrivecamNotes { get; set; }
        public List<Employees> Employees { get; set; }

        [DisplayName("New Driver")]
        public int NewDriver { get; set; }
        public string PostBackType { get; set; }


    }
}
