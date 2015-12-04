using System;
using System.Configuration;
using System.Windows.Forms;
using NightBits.Updater.Services;

namespace NightBitsUpdaterExe
{
    public partial class NightBitsUpdaterExe : Form
    {
        private static readonly string LocalLocation = ConfigurationManager.AppSettings["LocalUpdateInformation"];
        private static readonly string UpdateLocation = ConfigurationManager.AppSettings["RemoteUpdateInformation"];

        private readonly NightBitsUpdater _updater = new NightBitsUpdater(LocalLocation, UpdateLocation);

        public NightBitsUpdaterExe()
        {
            InitializeComponent();

            NightBitsUpdaterTrayIcon.ContextMenuStrip = contextMenuStrip1;
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;

            _updater.UpdateCompleted -= UpdateCompleted;
            _updater.UpdateCompleted += UpdateCompleted;

            _updater.UpdateFailed -= UpdateFailed;
            _updater.UpdateFailed += UpdateFailed;

            _updater.NoUpdatesAvailable -= NoUpdatesAvailable;
            _updater.NoUpdatesAvailable += NoUpdatesAvailable;
            _updater.AreUpdatesAvailable();
        }

        private void UpdateCompleted(object sender, EventArgs e)
        {
            Shutdown();
        }

        private void NoUpdatesAvailable(object sender, EventArgs e)
        {
            Shutdown();
        }

        private static void Shutdown()
        {
            Environment.Exit(0);
        }

        private void UpdateFailed(object sender, EventArgs e)
        {
            Shutdown();
        }

        protected override void SetVisibleCore(bool value)
        {
            if (!IsHandleCreated)
            {
                CreateHandle();
            }
            base.SetVisibleCore(false);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}