using Microsoft.AspNetCore.Mvc;
using Nop.Core.Domain.Customers;
using Nop.Web.Factories;
using Nop.Web.Framework.Components;

namespace Nop.Web.Components
{
    public class EbookDownloadBoxViewComponent : NopViewComponent
    {
        private readonly CustomerSettings _customerSettings;
        private readonly IEbookDownloadModelFactory _ebookDownloadModelFactory;

        public EbookDownloadBoxViewComponent(CustomerSettings customerSettings, IEbookDownloadModelFactory ebookDownloadModelFactory)
        {
            _customerSettings = customerSettings;
            _ebookDownloadModelFactory = ebookDownloadModelFactory;
        }

        public IViewComponentResult Invoke()
        {
            if (_customerSettings.HideNewsletterBlock)
                return Content("");

            var model = _ebookDownloadModelFactory.PrepareEbookDownloadBoxModel();
            return View(model);
        }
    }
}
