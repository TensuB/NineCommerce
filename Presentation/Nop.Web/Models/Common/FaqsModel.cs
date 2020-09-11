using Nop.Web.Framework.Models;
using Nop.Web.Framework.Mvc.ModelBinding;

namespace Nop.Web.Models.Common
{
    public partial class FaqsModel : BaseNopModel
    {
        #region Ctor

        public FaqsModel()
        {
        }

        #endregion

        #region Properties

        [NopResourceDisplayName("Account.VendorLegal.Description")]
        public string Description { get; set; }

        [NopResourceDisplayName("Account.VendorLegal.Summary")]
        public string Summary { get; set; }       

        #endregion
    }
}