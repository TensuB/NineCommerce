using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Models;

namespace Nop.Web.Models.Vendors
{
    public class VendorConditionsOfUseModel : BaseNopModel
    {
        public VendorConditionsOfUseModel()
        {
            VendorAttributes = new List<VendorAttributeModel>();
        }

        [NopResourceDisplayName("Account.ConditionsOfUse.Description")]
        public string Description { get; set; }

        [NopResourceDisplayName("Account.ConditionsOfUse.Summary")]
        public string Summary { get; set; }

        public IList<VendorAttributeModel> VendorAttributes { get; set; }

    }
}