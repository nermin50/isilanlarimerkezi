using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace Job_Offers_Website.Models
{
    public class Job
    {
        public int Id { get; set; }
        [DisplayName("Job title")]
        public string JobTitle { get; set; }
        [DisplayName("Job Content")]
        [AllowHtml]
        public string JobContent { get; set; }
        [DisplayName("İmage")]
        public string JobImage { get; set; }

        [DisplayName("Job category")]
        public int CategoryId { get; set; }

        public string UserID { get; set; }

        public virtual Category Category { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}