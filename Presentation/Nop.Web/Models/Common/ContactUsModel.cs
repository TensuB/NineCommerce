using System.ComponentModel.DataAnnotations;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Models;
using System.Collections;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Nop.Web.Models.Common
{
    public partial class ContactUsModel : BaseNopModel
    {
                
        [DataType(DataType.EmailAddress)]
        [NopResourceDisplayName("ContactUs.Email")]
        public string Email { get; set; }
        
        [NopResourceDisplayName("ContactUs.Subject")]
        public string Subject { get; set; }

        public bool SubjectEnabled { get; set; }

        [NopResourceDisplayName("ContactUs.Enquiry")]
        public string Enquiry { get; set; }

        [NopResourceDisplayName("ContactUs.FullName")]
        public string FullName { get; set; }

        [NopResourceDisplayName("ContactUs.FirstName")]
        public string FirstName { get; set; }

        [NopResourceDisplayName("ContactUs.LastName")]
        public string LastName { get; set; }

        public bool SuccessfullySent { get; set; }
        public string Result { get; set; }

        public bool DisplayCaptcha { get; set; }

        public IList<SelectListItem> SubjectAreaList { 
            get { return new List<SelectListItem>() 
                 {
                  new SelectListItem(){ Text ="Select subject ...", Value="Select subject ...", Selected = true },
                  new SelectListItem(){ Text ="Plant-based Blueprint", Value="Plant-based Blueprint" },
                  new SelectListItem(){ Text ="Writing", Value="Writing" },
                  new SelectListItem(){ Text ="speaking - Media apperances", Value="speaking - Media apperances" },
                  new SelectListItem(){ Text ="speaking - Lectures and presentations", Value="speaking - Lectures and presentations" },
                  new SelectListItem(){ Text ="Submit recipes", Value="Submit recipes" },
                  new SelectListItem(){ Text ="General query", Value="General query" },
            }; }
        }
    }
}