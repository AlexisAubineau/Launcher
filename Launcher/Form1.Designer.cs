namespace Launcher
{
    partial class Form
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.paramètresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emplacementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miseÀJourForcéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenu = new System.Windows.Forms.Panel();
            this.MinMaxMenu = new System.Windows.Forms.Panel();
            this.MinMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ServerLabel = new System.Windows.Forms.Label();
            this.InformationsLabel = new System.Windows.Forms.Label();
            this.DashboardLabel = new System.Windows.Forms.Label();
            this.WelcomeTab = new System.Windows.Forms.Panel();
            this.ServerTab = new System.Windows.Forms.Panel();
            this.InformationsTab = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.FooterPanel = new System.Windows.Forms.Panel();
            this.ServerPanel = new System.Windows.Forms.Panel();
            this.DashboardPanel = new System.Windows.Forms.Panel();
            this.CopyrightLabel = new System.Windows.Forms.Label();
            this.SettingsButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SocialButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ChaineButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.DiscordButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ReglementButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.idleTab = new System.Windows.Forms.Panel();
            this.version01ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyrighrt2018RoCaDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rewardOfCityAndDepartementsAllRightReservedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Menu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.ServerPanel.SuspendLayout();
            this.DashboardPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paramètresToolStripMenuItem,
            this.infosToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Padding = new System.Windows.Forms.Padding(6, 7, 0, 5);
            this.Menu.Size = new System.Drawing.Size(1091, 31);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "menuStrip1";
            this.Menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ExitClick_Menu);
            this.Menu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseDown);
            this.Menu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseMove);
            this.Menu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseUp);
            // 
            // paramètresToolStripMenuItem
            // 
            this.paramètresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emplacementToolStripMenuItem,
            this.miseÀJourForcéToolStripMenuItem});
            this.paramètresToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.paramètresToolStripMenuItem.Name = "paramètresToolStripMenuItem";
            this.paramètresToolStripMenuItem.Size = new System.Drawing.Size(78, 19);
            this.paramètresToolStripMenuItem.Text = "Paramètres";
            // 
            // emplacementToolStripMenuItem
            // 
            this.emplacementToolStripMenuItem.Name = "emplacementToolStripMenuItem";
            this.emplacementToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.emplacementToolStripMenuItem.Text = "Emplacement";
            // 
            // miseÀJourForcéToolStripMenuItem
            // 
            this.miseÀJourForcéToolStripMenuItem.Name = "miseÀJourForcéToolStripMenuItem";
            this.miseÀJourForcéToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.miseÀJourForcéToolStripMenuItem.Text = "Mise à jour forcé";
            // 
            // infosToolStripMenuItem
            // 
            this.infosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aideToolStripMenuItem,
            this.versionToolStripMenuItem});
            this.infosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.infosToolStripMenuItem.Name = "infosToolStripMenuItem";
            this.infosToolStripMenuItem.Size = new System.Drawing.Size(45, 19);
            this.infosToolStripMenuItem.Text = "Infos";
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.version01ToolStripMenuItem,
            this.copyrighrt2018RoCaDToolStripMenuItem,
            this.rewardOfCityAndDepartementsAllRightReservedToolStripMenuItem});
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.versionToolStripMenuItem.Text = "Version";
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aideToolStripMenuItem.Text = "Aide";
            // 
            // ExitMenu
            // 
            this.ExitMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ExitMenu.Location = new System.Drawing.Point(1061, 0);
            this.ExitMenu.Name = "ExitMenu";
            this.ExitMenu.Size = new System.Drawing.Size(30, 30);
            this.ExitMenu.TabIndex = 1;
            this.ExitMenu.Click += new System.EventHandler(this.ExitMenu_Click);
            this.ExitMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.ExitMenu_Paint);
            // 
            // MinMaxMenu
            // 
            this.MinMaxMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinMaxMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.MinMaxMenu.Location = new System.Drawing.Point(1031, 0);
            this.MinMaxMenu.Name = "MinMaxMenu";
            this.MinMaxMenu.Size = new System.Drawing.Size(30, 30);
            this.MinMaxMenu.TabIndex = 2;
            this.MinMaxMenu.Click += new System.EventHandler(this.MinMaxMenu_Click);
            this.MinMaxMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.MinMaxMenu_Paint);
            // 
            // MinMenu
            // 
            this.MinMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.MinMenu.Location = new System.Drawing.Point(1001, 0);
            this.MinMenu.Name = "MinMenu";
            this.MinMenu.Size = new System.Drawing.Size(30, 30);
            this.MinMenu.TabIndex = 3;
            this.MinMenu.Click += new System.EventHandler(this.MinMenu_Click);
            this.MinMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.MinMenu_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.ServerLabel);
            this.panel1.Controls.Add(this.InformationsLabel);
            this.panel1.Controls.Add(this.DashboardLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1091, 52);
            this.panel1.TabIndex = 4;
            // 
            // ServerLabel
            // 
            this.ServerLabel.AutoSize = true;
            this.ServerLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerLabel.ForeColor = System.Drawing.Color.White;
            this.ServerLabel.Location = new System.Drawing.Point(283, 18);
            this.ServerLabel.Name = "ServerLabel";
            this.ServerLabel.Size = new System.Drawing.Size(68, 21);
            this.ServerLabel.TabIndex = 2;
            this.ServerLabel.Text = "Serveur";
            // 
            // InformationsLabel
            // 
            this.InformationsLabel.AutoSize = true;
            this.InformationsLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InformationsLabel.ForeColor = System.Drawing.Color.White;
            this.InformationsLabel.Location = new System.Drawing.Point(463, 18);
            this.InformationsLabel.Name = "InformationsLabel";
            this.InformationsLabel.Size = new System.Drawing.Size(107, 21);
            this.InformationsLabel.TabIndex = 1;
            this.InformationsLabel.Text = "Informations";
            // 
            // DashboardLabel
            // 
            this.DashboardLabel.AutoSize = true;
            this.DashboardLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardLabel.ForeColor = System.Drawing.Color.White;
            this.DashboardLabel.Location = new System.Drawing.Point(53, 18);
            this.DashboardLabel.Name = "DashboardLabel";
            this.DashboardLabel.Size = new System.Drawing.Size(92, 21);
            this.DashboardLabel.TabIndex = 0;
            this.DashboardLabel.Text = "Bienvenue";
            // 
            // WelcomeTab
            // 
            this.WelcomeTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(179)))), ((int)(((byte)(70)))));
            this.WelcomeTab.Location = new System.Drawing.Point(0, 83);
            this.WelcomeTab.Name = "WelcomeTab";
            this.WelcomeTab.Size = new System.Drawing.Size(208, 7);
            this.WelcomeTab.TabIndex = 5;
            // 
            // ServerTab
            // 
            this.ServerTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ServerTab.Location = new System.Drawing.Point(208, 83);
            this.ServerTab.Name = "ServerTab";
            this.ServerTab.Size = new System.Drawing.Size(208, 7);
            this.ServerTab.TabIndex = 6;
            // 
            // InformationsTab
            // 
            this.InformationsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.InformationsTab.Location = new System.Drawing.Point(416, 83);
            this.InformationsTab.Name = "InformationsTab";
            this.InformationsTab.Size = new System.Drawing.Size(208, 7);
            this.InformationsTab.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.FooterPanel);
            this.panel2.Controls.Add(this.ServerPanel);
            this.panel2.Controls.Add(this.DashboardPanel);
            this.panel2.Location = new System.Drawing.Point(0, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1091, 514);
            this.panel2.TabIndex = 0;
            // 
            // FooterPanel
            // 
            this.FooterPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(179)))), ((int)(((byte)(70)))));
            this.FooterPanel.Location = new System.Drawing.Point(208, 465);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.Size = new System.Drawing.Size(883, 49);
            this.FooterPanel.TabIndex = 0;
            // 
            // ServerPanel
            // 
            this.ServerPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ServerPanel.AutoSize = true;
            this.ServerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.ServerPanel.Controls.Add(this.panel3);
            this.ServerPanel.Location = new System.Drawing.Point(208, 0);
            this.ServerPanel.Name = "ServerPanel";
            this.ServerPanel.Size = new System.Drawing.Size(883, 466);
            this.ServerPanel.TabIndex = 0;
            // 
            // DashboardPanel
            // 
            this.DashboardPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DashboardPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.DashboardPanel.Controls.Add(this.CopyrightLabel);
            this.DashboardPanel.Controls.Add(this.SettingsButton);
            this.DashboardPanel.Controls.Add(this.SocialButton);
            this.DashboardPanel.Controls.Add(this.ChaineButton);
            this.DashboardPanel.Controls.Add(this.DiscordButton);
            this.DashboardPanel.Controls.Add(this.ReglementButton);
            this.DashboardPanel.Location = new System.Drawing.Point(0, 0);
            this.DashboardPanel.Name = "DashboardPanel";
            this.DashboardPanel.Size = new System.Drawing.Size(208, 514);
            this.DashboardPanel.TabIndex = 0;
            // 
            // CopyrightLabel
            // 
            this.CopyrightLabel.AutoSize = true;
            this.CopyrightLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyrightLabel.ForeColor = System.Drawing.Color.White;
            this.CopyrightLabel.Location = new System.Drawing.Point(33, 489);
            this.CopyrightLabel.Name = "CopyrightLabel";
            this.CopyrightLabel.Size = new System.Drawing.Size(147, 16);
            this.CopyrightLabel.TabIndex = 5;
            this.CopyrightLabel.Text = "Copyright 2018 - RoCaD";
            // 
            // SettingsButton
            // 
            this.SettingsButton.Active = false;
            this.SettingsButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.SettingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.SettingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SettingsButton.BorderRadius = 0;
            this.SettingsButton.ButtonText = "PARAMETRE";
            this.SettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingsButton.DisabledColor = System.Drawing.Color.Gray;
            this.SettingsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingsButton.Iconcolor = System.Drawing.Color.Transparent;
            this.SettingsButton.Iconimage = null;
            this.SettingsButton.Iconimage_right = null;
            this.SettingsButton.Iconimage_right_Selected = null;
            this.SettingsButton.Iconimage_Selected = null;
            this.SettingsButton.IconMarginLeft = 0;
            this.SettingsButton.IconMarginRight = 0;
            this.SettingsButton.IconRightVisible = true;
            this.SettingsButton.IconRightZoom = 0D;
            this.SettingsButton.IconVisible = true;
            this.SettingsButton.IconZoom = 90D;
            this.SettingsButton.IsTab = false;
            this.SettingsButton.Location = new System.Drawing.Point(0, 228);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.SettingsButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.SettingsButton.OnHoverTextColor = System.Drawing.Color.White;
            this.SettingsButton.selected = false;
            this.SettingsButton.Size = new System.Drawing.Size(208, 57);
            this.SettingsButton.TabIndex = 4;
            this.SettingsButton.Text = "PARAMETRE";
            this.SettingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SettingsButton.Textcolor = System.Drawing.Color.White;
            this.SettingsButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // SocialButton
            // 
            this.SocialButton.Active = false;
            this.SocialButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.SocialButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.SocialButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SocialButton.BorderRadius = 0;
            this.SocialButton.ButtonText = "RESEAUX SOCIAUX";
            this.SocialButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SocialButton.DisabledColor = System.Drawing.Color.Gray;
            this.SocialButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SocialButton.Iconcolor = System.Drawing.Color.Transparent;
            this.SocialButton.Iconimage = null;
            this.SocialButton.Iconimage_right = null;
            this.SocialButton.Iconimage_right_Selected = null;
            this.SocialButton.Iconimage_Selected = null;
            this.SocialButton.IconMarginLeft = 0;
            this.SocialButton.IconMarginRight = 0;
            this.SocialButton.IconRightVisible = true;
            this.SocialButton.IconRightZoom = 0D;
            this.SocialButton.IconVisible = true;
            this.SocialButton.IconZoom = 90D;
            this.SocialButton.IsTab = false;
            this.SocialButton.Location = new System.Drawing.Point(0, 171);
            this.SocialButton.Name = "SocialButton";
            this.SocialButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.SocialButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.SocialButton.OnHoverTextColor = System.Drawing.Color.White;
            this.SocialButton.selected = false;
            this.SocialButton.Size = new System.Drawing.Size(208, 57);
            this.SocialButton.TabIndex = 3;
            this.SocialButton.Text = "RESEAUX SOCIAUX";
            this.SocialButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SocialButton.Textcolor = System.Drawing.Color.White;
            this.SocialButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // ChaineButton
            // 
            this.ChaineButton.Active = false;
            this.ChaineButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ChaineButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ChaineButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ChaineButton.BorderRadius = 0;
            this.ChaineButton.ButtonText = "YOUTUBE / TWITCH";
            this.ChaineButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChaineButton.DisabledColor = System.Drawing.Color.Gray;
            this.ChaineButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ChaineButton.Iconcolor = System.Drawing.Color.Transparent;
            this.ChaineButton.Iconimage = null;
            this.ChaineButton.Iconimage_right = null;
            this.ChaineButton.Iconimage_right_Selected = null;
            this.ChaineButton.Iconimage_Selected = null;
            this.ChaineButton.IconMarginLeft = 0;
            this.ChaineButton.IconMarginRight = 0;
            this.ChaineButton.IconRightVisible = true;
            this.ChaineButton.IconRightZoom = 0D;
            this.ChaineButton.IconVisible = true;
            this.ChaineButton.IconZoom = 90D;
            this.ChaineButton.IsTab = false;
            this.ChaineButton.Location = new System.Drawing.Point(0, 114);
            this.ChaineButton.Name = "ChaineButton";
            this.ChaineButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ChaineButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ChaineButton.OnHoverTextColor = System.Drawing.Color.White;
            this.ChaineButton.selected = false;
            this.ChaineButton.Size = new System.Drawing.Size(208, 57);
            this.ChaineButton.TabIndex = 2;
            this.ChaineButton.Text = "YOUTUBE / TWITCH";
            this.ChaineButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ChaineButton.Textcolor = System.Drawing.Color.White;
            this.ChaineButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // DiscordButton
            // 
            this.DiscordButton.Active = false;
            this.DiscordButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.DiscordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.DiscordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DiscordButton.BorderRadius = 0;
            this.DiscordButton.ButtonText = "DISCORD";
            this.DiscordButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DiscordButton.DisabledColor = System.Drawing.Color.Gray;
            this.DiscordButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.DiscordButton.Iconcolor = System.Drawing.Color.Transparent;
            this.DiscordButton.Iconimage = null;
            this.DiscordButton.Iconimage_right = null;
            this.DiscordButton.Iconimage_right_Selected = null;
            this.DiscordButton.Iconimage_Selected = null;
            this.DiscordButton.IconMarginLeft = 0;
            this.DiscordButton.IconMarginRight = 0;
            this.DiscordButton.IconRightVisible = true;
            this.DiscordButton.IconRightZoom = 0D;
            this.DiscordButton.IconVisible = true;
            this.DiscordButton.IconZoom = 90D;
            this.DiscordButton.IsTab = false;
            this.DiscordButton.Location = new System.Drawing.Point(0, 57);
            this.DiscordButton.Name = "DiscordButton";
            this.DiscordButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.DiscordButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.DiscordButton.OnHoverTextColor = System.Drawing.Color.White;
            this.DiscordButton.selected = false;
            this.DiscordButton.Size = new System.Drawing.Size(208, 57);
            this.DiscordButton.TabIndex = 1;
            this.DiscordButton.Text = "DISCORD";
            this.DiscordButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DiscordButton.Textcolor = System.Drawing.Color.White;
            this.DiscordButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // ReglementButton
            // 
            this.ReglementButton.Active = false;
            this.ReglementButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ReglementButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ReglementButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReglementButton.BorderRadius = 0;
            this.ReglementButton.ButtonText = "REGLEMENT";
            this.ReglementButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReglementButton.DisabledColor = System.Drawing.Color.Gray;
            this.ReglementButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ReglementButton.Iconcolor = System.Drawing.Color.Transparent;
            this.ReglementButton.Iconimage = null;
            this.ReglementButton.Iconimage_right = null;
            this.ReglementButton.Iconimage_right_Selected = null;
            this.ReglementButton.Iconimage_Selected = null;
            this.ReglementButton.IconMarginLeft = 0;
            this.ReglementButton.IconMarginRight = 0;
            this.ReglementButton.IconRightVisible = true;
            this.ReglementButton.IconRightZoom = 0D;
            this.ReglementButton.IconVisible = true;
            this.ReglementButton.IconZoom = 90D;
            this.ReglementButton.IsTab = false;
            this.ReglementButton.Location = new System.Drawing.Point(0, 0);
            this.ReglementButton.Name = "ReglementButton";
            this.ReglementButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ReglementButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ReglementButton.OnHoverTextColor = System.Drawing.Color.White;
            this.ReglementButton.selected = false;
            this.ReglementButton.Size = new System.Drawing.Size(208, 57);
            this.ReglementButton.TabIndex = 0;
            this.ReglementButton.Text = "REGLEMENT";
            this.ReglementButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ReglementButton.Textcolor = System.Drawing.Color.White;
            this.ReglementButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // idleTab
            // 
            this.idleTab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.idleTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.idleTab.Location = new System.Drawing.Point(624, 83);
            this.idleTab.Name = "idleTab";
            this.idleTab.Size = new System.Drawing.Size(467, 7);
            this.idleTab.TabIndex = 8;
            // 
            // version01ToolStripMenuItem
            // 
            this.version01ToolStripMenuItem.Name = "version01ToolStripMenuItem";
            this.version01ToolStripMenuItem.Size = new System.Drawing.Size(357, 22);
            this.version01ToolStripMenuItem.Text = "Version 0.1";
            // 
            // copyrighrt2018RoCaDToolStripMenuItem
            // 
            this.copyrighrt2018RoCaDToolStripMenuItem.Name = "copyrighrt2018RoCaDToolStripMenuItem";
            this.copyrighrt2018RoCaDToolStripMenuItem.Size = new System.Drawing.Size(357, 22);
            this.copyrighrt2018RoCaDToolStripMenuItem.Text = "Copyrighrt 2018 - RoCaD";
            // 
            // rewardOfCityAndDepartementsAllRightReservedToolStripMenuItem
            // 
            this.rewardOfCityAndDepartementsAllRightReservedToolStripMenuItem.Name = "rewardOfCityAndDepartementsAllRightReservedToolStripMenuItem";
            this.rewardOfCityAndDepartementsAllRightReservedToolStripMenuItem.Size = new System.Drawing.Size(357, 22);
            this.rewardOfCityAndDepartementsAllRightReservedToolStripMenuItem.Text = "Reward of City and Departements - All Right Reserved";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel3.Location = new System.Drawing.Point(56, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 200);
            this.panel3.TabIndex = 0;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1091, 604);
            this.Controls.Add(this.idleTab);
            this.Controls.Add(this.InformationsTab);
            this.Controls.Add(this.ServerTab);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.WelcomeTab);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MinMenu);
            this.Controls.Add(this.MinMaxMenu);
            this.Controls.Add(this.ExitMenu);
            this.Controls.Add(this.Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form";
            this.Text = "Reward of City and Departments";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ServerPanel.ResumeLayout(false);
            this.DashboardPanel.ResumeLayout(false);
            this.DashboardPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem paramètresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emplacementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miseÀJourForcéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.Panel ExitMenu;
        private System.Windows.Forms.Panel MinMaxMenu;
        private System.Windows.Forms.Panel MinMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel WelcomeTab;
        private System.Windows.Forms.Panel ServerTab;
        private System.Windows.Forms.Panel InformationsTab;
        private System.Windows.Forms.Label DashboardLabel;
        private System.Windows.Forms.Label ServerLabel;
        private System.Windows.Forms.Label InformationsLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel idleTab;
        private System.Windows.Forms.Panel DashboardPanel;
        private System.Windows.Forms.Panel ServerPanel;
        private System.Windows.Forms.Panel FooterPanel;
        private Bunifu.Framework.UI.BunifuFlatButton ReglementButton;
        private Bunifu.Framework.UI.BunifuFlatButton ChaineButton;
        private Bunifu.Framework.UI.BunifuFlatButton DiscordButton;
        private Bunifu.Framework.UI.BunifuFlatButton SettingsButton;
        private Bunifu.Framework.UI.BunifuFlatButton SocialButton;
        private System.Windows.Forms.Label CopyrightLabel;
        private System.Windows.Forms.ToolStripMenuItem version01ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyrighrt2018RoCaDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rewardOfCityAndDepartementsAllRightReservedToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
    }
}

