using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Models;

namespace Nop.Web.Models.Vendors
{
    public class VendorLegalModel : BaseNopModel
    {
        public VendorLegalModel()
        {
            VendorAttributes = new List<VendorAttributeModel>();
        }

        [NopResourceDisplayName("Account.VendorLegal.Description")]
        public string Description { get; set; }

        [NopResourceDisplayName("Account.VendorLegal.Summary")]
        public string Summary { get; set; }

        public IList<VendorAttributeModel> VendorAttributes { get; set; }

    }
}