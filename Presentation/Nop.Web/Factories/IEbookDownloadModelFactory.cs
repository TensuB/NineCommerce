using Nop.Web.Models.EbookDownload;

namespace Nop.Web.Factories
{
    /// <summary>
    /// Represents the interface of the newsletter model factory
    /// </summary>
    public partial interface IEbookDownloadModelFactory
    {
        /// <summary>
        /// Prepare the Ebook Download box model
        /// </summary>
        /// <returns>Ebook Download box model</returns>
        EbookDownloadBoxModel PrepareEbookDownloadBoxModel();

        /// <summary>
        /// Prepare the subscription activation model
        /// </summary>
        /// <param name="active">Whether the subscription has been activated</param>
        /// <returns>Subscription activation model</returns>
        //SubscriptionActivationModel PrepareSubscriptionActivationModel(bool active);
    }
}
