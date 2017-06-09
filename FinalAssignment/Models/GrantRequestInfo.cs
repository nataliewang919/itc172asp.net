using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalAssignment.Models
{
    public class GrantRequestInfo
    {
        public string GrantRequestDate { get; set; }
        public string GrantRequestExplanation { get; set; }
        public string GrantRequestAmount { get; set; }
        public string GrantRequestStatus { get; set; }
        public string GrantAllocationAmount { get; set; }
        public string GrantReviewDate { get; set; }
    }
}