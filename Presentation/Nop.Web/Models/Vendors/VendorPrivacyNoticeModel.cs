using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Models;

namespace Nop.Web.Models.Vendors
{
    public class VendorPrivacyNoticeModel : BaseNopModel
    {
        public VendorPrivacyNoticeModel()
        {
            VendorAttributes = new List<VendorAttributeModel>();
        }

        [NopResourceDisplayName("Account.VendorPrivacyNotice.Description")]
        public string Description { get; set; }

        [NopResourceDisplayName("Account.VendorPrivacyNotice.Summary")]
        public string Summary { get; set; }

        public IList<VendorAttributeModel> VendorAttributes { get; set; }

    }
}