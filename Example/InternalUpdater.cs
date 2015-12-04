using System.Configuration;

namespace WinformsExample.NightBitsUpdater
{
    public class InternalUpdater
    {
        private static readonly string LocalLocation = ConfigurationManager.AppSettings["LocalUpdateInformation"];
        private static readonly string UpdateLocation = ConfigurationManager.AppSettings["RemoteUpdateInformation"];

        private readonly NightBits.Updater.Services.NightBitsUpdater _updater = new NightBits.Updater.Services.NightBitsUpdater(LocalLocation, UpdateLocation, null, "Update");

        public InternalUpdater()
        {
            _updater.AreUpdatesAvailable();
        }
    }
}