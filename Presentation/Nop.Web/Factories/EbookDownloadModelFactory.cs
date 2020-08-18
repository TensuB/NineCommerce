using Nop.Core.Domain.Customers;
using Nop.Services.Localization;
using Nop.Web.Models.Newsletter;
using Nop.Web.Models.EbookDownload;

namespace Nop.Web.Factories
{
    /// <summary>
    /// Represents the newsletter model factory
    /// </summary>
    public partial class EbookDownloadModelFactory : IEbookDownloadModelFactory
    {
        #region Fields

        private readonly CustomerSettings _customerSettings;
        private readonly ILocalizationService _localizationService;

        #endregion

        #region Ctor

        public EbookDownloadModelFactory(CustomerSettings customerSettings,
            ILocalizationService localizationService)
        {
            _customerSettings = customerSettings;
            _localizationService = localizationService;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Prepare the Ebook Download box model
        /// </summary>
        /// <returns>Ebook Download box model</returns>
        public virtual EbookDownloadBoxModel PrepareEbookDownloadBoxModel()
        {
            var model = new EbookDownloadBoxModel()
            {
                AllowToUnsubscribe = _customerSettings.NewsletterBlockAllowToUnsubscribe
            };
            return model;
        }

        /*
        /// <summary>
        /// Prepare the subscription activation model
        /// </summary>
        /// <param name="active">Whether the subscription has been activated</param>
        /// <returns>Subscription activation model</returns>
        public virtual SubscriptionActivationModel PrepareSubscriptionActivationModel(bool active)
        {
            var model = new SubscriptionActivationModel
            {
                Result = active
                ? _localizationService.GetResource("Newsletter.ResultActivated")
                : _localizationService.GetResource("Newsletter.ResultDeactivated")
            };

            return model;
        }
        */
        #endregion
    }
}
