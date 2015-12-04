using System;
using System.Configuration;
using System.Diagnostics;
using System.Windows.Forms;
using NightBits.Updater;
using NightBits.Updater.Configuration;
using NightBits.Updater.Interfaces;
using NightBitsLibrary.MathOperations;

namespace WinformsExample.NightBitsUpdater
{
    public partial class AutoNightBitsUpdater : Form, INightBitsUpdater
    {
        private readonly string _localLocation = ConfigurationManager.AppSettings["LocalUpdateInformation"];
        private readonly string _updateLocation = ConfigurationManager.AppSettings["RemoteUpdateInformation"];
        private UpdateFile _updateFileInformation = new UpdateFile();
        private NightBits.Updater.Services.NightBitsUpdater _updater;

        public AutoNightBitsUpdater()
        {
            InitializeComponent();
        }

        public Product ProductInformation
        {
            set
            {
                if (value != null)
                {
                    applicationVersionLabel.Text = value.ApplicationVersion;
                    updateVersionLabel.Text = value.UpdateVersion;
                    productURLLabel.Text = value.ProductURL;
                    webBrowser.Url = new Uri(value.ProductURL);
                }
                else
                {
                    applicationVersionLabel.Text = string.Empty;
                }
                applicationVersionLabel.Refresh();
            }
        }

        public UpdateFile UpdateFileInformation
        {
            set
            {
                if (value != null)
                {
                    if (value.MoreInfoURL != _updateFileInformation.MoreInfoURL)
                    {
                        webBrowser.Url = string.IsNullOrEmpty(value.MoreInfoURL) ? null : new Uri(value.MoreInfoURL);
                    }
                    _updateFileInformation = value;
                    fileInformationLabel.Text = _updateFileInformation.FileName;
                    fileDescriptionInformationLabel.Text = _updateFileInformation.ShortDescription;
                }
                else
                {
                    fileInformationLabel.Text = string.Empty;
                }

                fileInformationLabel.Refresh();
            }
        }

        public int ProgressPercentage
        {
            set
            {
                percentageLabel.Text = value + @"%";
                percentageLabel.Refresh();
                progressBar.Value = value;
            }
        }

        public long BytesReceived
        {
            set
            {
                receivedLabel.Text = MathOperations.BytesToHumanreadableString(value);
                receivedLabel.Refresh();
            }
        }

        public long TotalBytesToReceive
        {
            set
            {
                totalSizeLabel.Text = MathOperations.BytesToHumanreadableString(value) + @" total";
                totalSizeLabel.Refresh();
            }
        }

        private void ProgressView_Load(object sender, EventArgs e)
        {
            _updater = new NightBits.Updater.Services.NightBitsUpdater(_localLocation, _updateLocation, this, "password2");

            _updater.UpdateMessagesEvents -= UpdaterUpdateMessageEvents;
            _updater.UpdateMessagesEvents += UpdaterUpdateMessageEvents;

            _updater.FilesDownloadCompleted -= UpdaterFilesCompleted;
            _updater.FilesDownloadCompleted += UpdaterFilesCompleted;

            _updater.NoUpdatesAvailable -= NoUpdatesAvailable;
            _updater.NoUpdatesAvailable += NoUpdatesAvailable;

            _updater.UpdateCompleted -= UpdaterCompleted;
            _updater.UpdateCompleted += UpdaterCompleted;

            _updater.UpdateFailed -= UpdaterHasFailed;
            _updater.UpdateFailed += UpdaterHasFailed;

            _updater.UpdateInformationRetrieved -= UpdaterInformationRetrieved;
            _updater.UpdateInformationRetrieved += UpdaterInformationRetrieved;
        }

        private void ClearAllFields()
        {
            fileInformationLabel.Text = string.Empty;
            fileInformationLabel.Refresh();

            percentageLabel.Text = string.Empty;
            percentageLabel.Refresh();

            receivedLabel.Text = string.Empty;
            receivedLabel.Refresh();

            totalSizeLabel.Text = string.Empty;
            totalSizeLabel.Refresh();

            updateInformationLabel.Text = string.Empty;
            updateInformationLabel.Refresh();

            errorLabel.Text = string.Empty;
            errorLabel.Refresh();

            fileDescriptionInformationLabel.Text = string.Empty;
            fileDescriptionInformationLabel.Refresh();
        }

        private static void UpdaterFilesCompleted(object sender, EventArgs e)
        {
            ShowMessage(@"Files downloaded");
        }

        private void UpdaterInformationRetrieved(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show(@"Would you like to update the application?", @"Update available", MessageBoxButtons.YesNo);

            switch (dialogResult)
            {
                case DialogResult.Yes:
                    _updater.Update();
                    ClearAllFields();
                    SetAbortable();
                    break;

                case DialogResult.No:
                    Console.WriteLine(@"Do nothing");
                    break;
            }
        }

        private void NoUpdatesAvailable(object sender, EventArgs e)
        {
            ShowMessage(@"You have the latest version");
            ClearAllFields();
        }

        private void UpdaterCompleted(object sender, EventArgs e)
        {
            ShowMessage(@"Update completed!");
            SetUpdateable();
        }

        private void UpdaterHasFailed(object sender, EventArgs e)
        {
            ClearAllFields();
            ShowMessage(@"Update has failed");
        }

        private static void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void UpdaterUpdateMessageEvents(object sender, EventArgs e)
        {
            var updatesEventArguments = e as UpdatesEventArgs;

            if (updatesEventArguments != null && updatesEventArguments.InfoType == MessageType.Error)
            {
                errorLabel.Text = updatesEventArguments.Message;
            }
            else
            {
                if (updatesEventArguments != null)
                {
                    updateInformationLabel.Text = updatesEventArguments.Message;
                }
            }

            updateInformationLabel.Refresh();
            errorLabel.Refresh();
        }

        private void CancelUpdate(object sender, EventArgs e)
        {
            if (_updater.Cancel())
            {
                SetUpdateable();
            }
        }

        private void SetAbortable()
        {
            updateButton.Click -= button1_Click;
            updateButton.Click += CancelUpdate;
            updateButton.Text = @"Abort update";
        }

        private void SetUpdateable()
        {
            updateButton.Click -= CancelUpdate;
            updateButton.Click += button1_Click;
            updateButton.Text = @"Check for updates";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorLabel.Visible = updateInformationLabel.Visible = true;
            errorLabel.Text = updateInformationLabel.Text = string.Empty;

            if (_updater.AreUpdatesAvailable())
            {
                _updater.GetUpdateInformation();
            }
        }

        private void lnkInfo_Click(object sender, EventArgs e)
        {
            Process.Start(productURLLabel.Text);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new InternalUpdater();
        }
    }
}