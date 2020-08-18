using System.ComponentModel.DataAnnotations;
using Nop.Web.Framework.Models;

namespace Nop.Web.Models.EbookDownload
{
    public partial class EbookDownloadBoxModel : BaseNopModel
    {
        [DataType(DataType.EmailAddress)]
        public string EbookDownloadEmail { get; set; }
        public string EbookDownloadName { get; set; }
        public bool AllowToUnsubscribe { get; set; }
    }
}
