using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Launcher
{
    public partial class Form : System.Windows.Forms.Form
    {
        int mm = 0;
        int mov;
        int movX;
        int movY;

        public Form()
        {
            InitializeComponent();
            ServerPanel.Visible = false;
            InformationsPanel.Visible = false;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            this.Location = Screen.AllScreens[1].WorkingArea.Location;
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

        private void ExitClick_Menu(object sender, EventArgs e)
        {
            //Fail de ma part pour la création de cette fonction à supprimer plus tard dans la racine du code non pas ici
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
        }

        private void ReglementButton_Click(object sender, EventArgs e)
        {
            if(ReglementPanel1.Visible == true)
            {
                ReglementPanel1.Visible = false;
                vScrollBar1.Visible = false;
                HomePanel.Visible = true;
            }
            else
            {
                ReglementPanel1.Visible = true;
                vScrollBar1.Visible = true;
                DiscordPanel.Visible = false;
                ChainePanel.Visible = false;
                SocialPanel.Visible = false;
                HomePanel.Visible = false;
                SettingsPanel.Visible = false;
                ReglementPanel2.Visible = false;
                ReglementPanel3.Visible = false;
                ReglementPanel4.Visible = false;
                ReglementPanel5.Visible = false;
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
                vScrollBar1.Visible = false;
                ChainePanel.Visible = false;
                SocialPanel.Visible = false;
                HomePanel.Visible = false;
                SettingsPanel.Visible = false;
                ReglementPanel1.Visible = false;
                ReglementPanel2.Visible = false;
                ReglementPanel3.Visible = false;
                ReglementPanel4.Visible = false;
                ReglementPanel5.Visible = false;
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
                vScrollBar1.Visible = false;
                ChainePanel.Visible = true;
                SocialPanel.Visible = false;
                HomePanel.Visible = false;
                SettingsPanel.Visible = false;
                ReglementPanel1.Visible = false;
                ReglementPanel2.Visible = false;
                ReglementPanel3.Visible = false;
                ReglementPanel4.Visible = false;
                ReglementPanel5.Visible = false;
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
                vScrollBar1.Visible = false;
                ChainePanel.Visible = false;
                SocialPanel.Visible = true;
                HomePanel.Visible = false;
                SettingsPanel.Visible = false;
                ReglementPanel1.Visible = false;
                ReglementPanel2.Visible = false;
                ReglementPanel3.Visible = false;
                ReglementPanel4.Visible = false;
                ReglementPanel5.Visible = false;
            }
        }

        private void TwitterButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/Reward81580854");
        }

        private void SettingsButton_Click(object sender, EventArgs e)
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
                vScrollBar1.Visible = false;
                ChainePanel.Visible = false;
                SocialPanel.Visible = false;
                HomePanel.Visible = false;
                SettingsPanel.Visible = true;
                ReglementPanel1.Visible = false;
                ReglementPanel2.Visible = false;
                ReglementPanel3.Visible = false;
                ReglementPanel4.Visible = false;
                ReglementPanel5.Visible = false;
            }
        }

        private void ServerButton_Click(object sender, EventArgs e)
        {
            WelcomeActiveTab.Visible = false;
            ServerActiveTabPanel.Visible = true;
            InformationActiveTab.Visible = false;
            WelcomePanel.Visible = false;
            ServerPanel.Visible = true;
            InformationsPanel.Visible = false;
            WelcomePanel.Visible = false;
            ReglementPanel1.Visible = false;
            ReglementPanel2.Visible = false;
            ReglementPanel3.Visible = false;
            ReglementPanel4.Visible = false;
            ReglementPanel5.Visible = false;
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("fivem://connect/86.105.212.151:30121");
        }

        private void InformationsButton_Click(object sender, EventArgs e)
        {
            WelcomeActiveTab.Visible = false;
            ServerActiveTabPanel.Visible = false;
            InformationActiveTab.Visible = true;
            WelcomePanel.Visible = false;
            ServerPanel.Visible = false;
            InformationsPanel.Visible = true;
            WelcomePanel.Visible = false;
            ReglementPanel1.Visible = false;
            ReglementPanel2.Visible = false;
            ReglementPanel3.Visible = false;
            ReglementPanel4.Visible = false;
            ReglementPanel5.Visible = false;
        }
    }
}
