using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Threading;
using System.IO;
using System.IO.Compression;

namespace Launcher
{
    public partial class Form : System.Windows.Forms.Form
    {
        int mm = 0;
        int mov;
        int movX;
        int movY;
        String PlayDirectory;

        public Form()
        {
            InitializeComponent();
            ServerPanel.Visible = false;
            InformationsPanel.Visible = false;

            if(File.Exists(Application.StartupPath + "/" + "settings.txt"))
            {
                SettingsButton.Visible = false;
            }

            else
            {
                SettingsButton.Visible = true;
            }
        }

        private void Form_Load(object sender, EventArgs e)
        {
            client = new WebClient();
            client.DownloadProgressChanged += Client_DownloadProgressChanged;
            client.DownloadFileCompleted += Client_DownloadFileComplete;
        }

        private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            Invoke(new MethodInvoker(delegate ()
            {
                progressBar.Minimum = 0;
                double receive = double.Parse(e.BytesReceived.ToString());
                double total = double.Parse(e.TotalBytesToReceive.ToString());
                double percentage = receive / total * 100;
                lblStatus.Text = $"Téléchargé {string.Format("{0:0.##}", percentage)}%";
                progressBar.Value = int.Parse(Math.Truncate(percentage).ToString());
            }));
            
        }

        private void Client_DownloadFileComplete(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Téléchargement terminé vous pouvez enfin débarquer de l'avion et commencer votre nouvelle vie à Reward of City and Department.", "Panneau d'information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Menu_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void Menu_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void Menu_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void ExitMenu_Paint(object sender, PaintEventArgs e)
        {
            Graphics z = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(230, 179, 70));
            z.DrawLine(pen, 7, 7, 19, 19);
            z.DrawLine(pen, 7, 19, 19, 7);
            z.DrawLine(pen, 8, 7, 20, 19);
            z.DrawLine(pen, 8, 19, 20, 7);
        }

        private void MinMenu_Paint(object sender, PaintEventArgs e)
        {
            Graphics z = e.Graphics;
            Color myColor = Color.FromArgb(230, 179, 70);
            SolidBrush myBrush = new SolidBrush(myColor);
            Pen pen = new Pen(Color.FromArgb(230, 179, 70));
            z.DrawRectangle(pen, 7, 16, 12, 4);
            z.FillRectangle(myBrush, 7, 16, 12, 4);
        }

        private void ExitMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinMenu_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void WelcomeButton_Click(object sender, EventArgs e)
        {
            WelcomeActiveTab.Visible = true;
            ServerActiveTabPanel.Visible = false;
            InformationActiveTab.Visible = false;
            WelcomePanel.Visible = true;
            ServerPanel.Visible = false;
            InformationsPanel.Visible = false;
            WelcomePanel.Visible = true;
            DiscordPanel.Visible = false;
            ReglementPanel1.Visible = false;
            ChainePanel.Visible = false;
            SocialPanel.Visible = false;
            SettingsPanel.Visible = false;
            HomePanel.Visible = true;
            DonnationPanel.Visible = false;

            if (File.Exists(Application.StartupPath + "/" + "settings.txt"))
            {
                SettingsButton.Visible = false;
            }

            else
            {
                SettingsButton.Visible = true;
            }
        }

        private void ReglementButton_Click(object sender, EventArgs e)
        {
            if (ReglementPanel1.Visible == true)
            {
                ReglementPanel1.Visible = false;
                HomePanel.Visible = true;
            }
            else
            {
                ReglementPanel1.Visible = true;
                DiscordPanel.Visible = false;
                ChainePanel.Visible = false;
                SocialPanel.Visible = false;
                HomePanel.Visible = false;
                SettingsPanel.Visible = false;
                ReglementPanel2.Visible = false;
                ReglementPanel3.Visible = false;
                ReglementPanel4.Visible = false;
                ReglementPanel5.Visible = false;
                DonnationPanel.Visible = false;
            }
        }

        private void NextPanel2_Click(object sender, EventArgs e)
        {
            ReglementPanel1.Visible = false;
            ReglementPanel2.Visible = true;
        }

        private void NextPanell3_Click(object sender, EventArgs e)
        {
            ReglementPanel2.Visible = false;
            ReglementPanel3.Visible = true;
        }

        private void NextPanel4_Click_1(object sender, EventArgs e)
        {
            ReglementPanel3.Visible = false;
            ReglementPanel4.Visible = true;
        }

        private void NextPanel5_Click(object sender, EventArgs e)
        {
            ReglementPanel4.Visible = false;
            ReglementPanel5.Visible = true;
        }

        private void BackPanel1_Click(object sender, EventArgs e)
        {
            ReglementPanel1.Visible = true;
            ReglementPanel2.Visible = false;
        }

        private void BackPanel2_Click_1(object sender, EventArgs e)
        {
            ReglementPanel2.Visible = true;
            ReglementPanel3.Visible = false;
        }

        private void BackPanel3_Click(object sender, EventArgs e)
        {
            ReglementPanel3.Visible = true;
            ReglementPanel4.Visible = false;
        }

        private void BackPanel4_Click(object sender, EventArgs e)
        {
            ReglementPanel4.Visible = true;
            ReglementPanel5.Visible = false;
        }

        private void DiscordButton_Click(object sender, EventArgs e)
        {
            if (DiscordPanel.Visible == true)
            {
                DiscordPanel.Visible = false;
                HomePanel.Visible = true;
            }
            else
            {
                DiscordPanel.Visible = true;
                ReglementPanel1.Visible = false;
                ChainePanel.Visible = false;
                SocialPanel.Visible = false;
                HomePanel.Visible = false;
                SettingsPanel.Visible = false;
                ReglementPanel1.Visible = false;
                ReglementPanel2.Visible = false;
                ReglementPanel3.Visible = false;
                ReglementPanel4.Visible = false;
                ReglementPanel5.Visible = false;
                DonnationPanel.Visible = false;
            }
        }

        private void DiscordJoinButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/AQmMpaa");
        }

        private void ChaineButton_Click(object sender, EventArgs e)
        {
            if (ChainePanel.Visible == true)
            {
                ChainePanel.Visible = false;
                HomePanel.Visible = true;
            }
            else
            {
                DiscordPanel.Visible = false;
                ReglementPanel1.Visible = false;
                ChainePanel.Visible = true;
                SocialPanel.Visible = false;
                HomePanel.Visible = false;
                SettingsPanel.Visible = false;
                ReglementPanel1.Visible = false;
                ReglementPanel2.Visible = false;
                ReglementPanel3.Visible = false;
                ReglementPanel4.Visible = false;
                ReglementPanel5.Visible = false;
                DonnationPanel.Visible = false;
            }
        }

        private void ChaineLinkButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCG5a7Sh6JKk3iads6HlF6rA?view_as=subscriber");
        }

        private void SocialButton_Click(object sender, EventArgs e)
        {
            if (SocialPanel.Visible == true)
            {
                SocialPanel.Visible = false;
                HomePanel.Visible = true;
            }
            else
            {
                DiscordPanel.Visible = false;
                ReglementPanel1.Visible = false;
                ChainePanel.Visible = false;
                SocialPanel.Visible = true;
                HomePanel.Visible = false;
                SettingsPanel.Visible = false;
                ReglementPanel1.Visible = false;
                ReglementPanel2.Visible = false;
                ReglementPanel3.Visible = false;
                ReglementPanel4.Visible = false;
                ReglementPanel5.Visible = false;
                DonnationPanel.Visible = false;
            }
        }

        private void TwitterButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/Reward81580854");
        }

        private void SettingsButton_Click_1(object sender, EventArgs e)
        {
            if (SettingsPanel.Visible == true)
            {
                SettingsPanel.Visible = false;
                HomePanel.Visible = true;
            }
            else
            {
                DiscordPanel.Visible = false;
                ReglementPanel1.Visible = false;
                ChainePanel.Visible = false;
                SocialPanel.Visible = false;
                HomePanel.Visible = false;
                SettingsPanel.Visible = true;
                ReglementPanel1.Visible = false;
                ReglementPanel2.Visible = false;
                ReglementPanel3.Visible = false;
                ReglementPanel4.Visible = false;
                ReglementPanel5.Visible = false;
                DonnationPanel.Visible = false;
            }
        }

        private void FolderBrowseGTAVButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vous devez fournir le dossier Grand Theft Auto V", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FolderBrowserDialog.SelectedPath = FolderGTAVTextBox.Text;
            DialogResult res = FolderBrowserDialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                FolderGTAVTextBox.Text = FolderBrowserDialog.SelectedPath;
            }
        }

        private void FolderBrowseFiveMButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vous devez fournir le dossier FiveM", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FolderBrowserDialog.SelectedPath = FolderFiveMTextBox.Text;
            DialogResult res = FolderBrowserDialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                FolderFiveMTextBox.Text = FolderBrowserDialog.SelectedPath;
            }
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(FolderGTAVTextBox.Text + "/GTA5.exe"))
            {
                StreamWriter file = new StreamWriter(Application.StartupPath + "/" + "settings.txt");
                file.Write(FolderGTAVTextBox.Text + "\n" + FolderFiveMTextBox.Text);
                file.Close();
                MessageBox.Show("Le chemin d'accès à bien étais enregistré vous pouvez maintenant aller dans jouer pour effectué la mise à jour", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Le chemin d'accès est incorrect, vous devez fournir le dossier Grand Theft Auto V aussi non vous ne pourrez pas jouer", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.IO.File.Delete(Application.StartupPath + "/" + "settings.txt");
            }
        }

        private void DonationButton_Click(object sender, EventArgs e)
        {
            if (DonnationPanel.Visible == true)
            {
               DonnationPanel.Visible = false;
                HomePanel.Visible = true;
            }
            else
            {
                DiscordPanel.Visible = false;
                ReglementPanel1.Visible = false;
                ChainePanel.Visible = false;
                SocialPanel.Visible = false;
                HomePanel.Visible = false;
                SettingsPanel.Visible = false;
                ReglementPanel1.Visible = false;
                ReglementPanel2.Visible = false;
                ReglementPanel3.Visible = false;
                ReglementPanel4.Visible = false;
                ReglementPanel5.Visible = false;
                DonnationPanel.Visible = true;
            }
        }

        private void DonnationFinishButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=FKFXD8D23TNJE");
        }

        private void ServerButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(Application.StartupPath + "/" + "settings.txt"))
            {
                ServerPanel.Visible = true;
                WelcomeActiveTab.Visible = false;
                ServerActiveTabPanel.Visible = true;
                InformationActiveTab.Visible = false;
                WelcomePanel.Visible = false;
                InformationsPanel.Visible = false;
                WelcomePanel.Visible = false;
                ReglementPanel1.Visible = false;
                ReglementPanel2.Visible = false;
                ReglementPanel3.Visible = false;
                ReglementPanel4.Visible = false;
                ReglementPanel5.Visible = false;
                DiscordPanel.Visible = false;
                ReglementPanel1.Visible = false;
                ChainePanel.Visible = false;
                SocialPanel.Visible = false;
                HomePanel.Visible = false;
                SettingsPanel.Visible = false;

                string GetLine(string fileName, int line)
                {
                    using (var sr = new StreamReader(fileName))
                    {
                        for (int i = 1; i < line; i++)
                            sr.ReadLine();
                        return sr.ReadLine();
                    }
                }

                PlayDirectory = GetLine(Application.StartupPath + "/" + "settings.txt", 1);

                if (File.Exists(PlayDirectory + "/update/x64/dlcpacks/patchday15ng/" + "backup_dlc.rpf"))
                {
                    UpdateButton.Visible = false;
                    progressBar.Visible = false;
                    lblStatus.Visible = false;
                    PlayButton.Visible = true;
                }
                else
                {
                    UpdateButton.Visible = true;
                    progressBar.Visible = true;
                    lblStatus.Visible = true;
                    PlayButton.Visible = false;
                }
            }
            else
            {
                ServerPanel.Visible = false;
                MessageBox.Show("Vous ne pouver pas encore y accéder, aller dans paramètre pour configurer le chemin d'accès.", "Alerte", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FinalButon_Click(object sender, EventArgs e)
        {
            FinalButon.Visible = false;
            progressBar.Visible = false;
            lblStatus.Visible = false;
            PlayButton.Visible = true;
        }

        private void UninstallButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(PlayDirectory + "/update/x64/dlcpacks/patchday15ng/" + "backup_dlc.rpf"))
            {
                System.IO.File.Delete(PlayDirectory + "/update/x64/dlcpacks/patchday15ng/" + "dlc.rpf");
                System.IO.File.Move(PlayDirectory + "/update/x64/dlcpacks/patchday15ng/" + "backup_dlc.rpf", PlayDirectory + "/update/x64/dlcpacks/patchday15ng/" + "dlc.rpf");
                MessageBox.Show("La désinstallation est terminé.", "Panneau d'information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Vous ne pouvez pas désinstaller si vous ne possedé pas les fichiers encore.", "Alerte", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("fivem://connect/86.105.212.151:30121");
        }

        private void VoteButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Attention vous allez arriver sur la page d'accueil de FiveM il vous suffira juste d'attendre un petit moment pour que la connexion automatique se lance, bon jeu à vous.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            System.Diagnostics.Process.Start("https://gta.top-serveurs.net/vote/reward-of-city-and-departements/");
        }

        WebClient client;

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string url = ("https://fs7.transfernow.net/download/5b3ba2ad3f757/master/dlc.rpf");
            if (!string.IsNullOrEmpty(url))
            {
                UpdateButton.Visible = false;
                FinalButon.Visible = true;
                if(File.Exists(PlayDirectory + "/update/x64/dlcpacks/patchday15ng/" + "dlc.rpf"))
                {
                    System.IO.File.Move(PlayDirectory + "/update/x64/dlcpacks/patchday15ng/" + "dlc.rpf", PlayDirectory + "/update/x64/dlcpacks/patchday15ng/" + "backup_dlc.rpf");
                    Thread thread = new Thread(() =>
                    {
                        Uri uri = new Uri(url);
                        string filename = System.IO.Path.GetFileName(uri.AbsolutePath);
                        client.DownloadFileAsync(uri, PlayDirectory + "/update/x64/dlcpacks/patchday15ng/" + filename);
                    });
                    thread.Start();
                }
                else
                {
                    Thread thread = new Thread(() =>
                    {
                        Uri uri = new Uri(url);
                        string filename = System.IO.Path.GetFileName(uri.AbsolutePath);
                        client.DownloadFileAsync(uri, PlayDirectory + "/update/x64/dlcpacks/patchday15ng/" + filename);
                    });
                    thread.Start();
                }
            }
        }

        private void InformationsButton_Click(object sender, EventArgs e)
        {
            WelcomeActiveTab.Visible = false;
            ServerActiveTabPanel.Visible = false;
            InformationActiveTab.Visible = true;
            InformationsPanel.Visible = true;
            WelcomePanel.Visible = false;
            ServerPanel.Visible = false;
            SettingsPanel.Visible = false;
        }
    }
}
