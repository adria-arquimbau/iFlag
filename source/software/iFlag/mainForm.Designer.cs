﻿namespace iFlag
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.optionsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.initiateBoardMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectorTopMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectorLeftMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectorRightMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectorBottomMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modulesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flagsModuleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spotterOverlayModuleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proximityOverlayModuleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startLightsModuleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incidentOverlayModuleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incidentStyleMapMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incidentStyleMapSmallMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incidentStyleMapBigMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incidentStyleMapExplodedMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pitExitBlueModuleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closedPitsOverlayModuleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repairsOverlayModuleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pitSpeedLimitModuleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pitSpeedMapMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pitSpeedMapSafeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pitSpeedMapWideMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pitSpeedMapNarrowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pitSpeedMapAggressiveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brightnessMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullBrightnessMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highBrightnessMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumBrightnessMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lowBrightnessMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.demoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alwaysOnTopMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsMenuSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.appMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forumThreadMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatesEnabledMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatesExperimentalMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsButton = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.commLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.hardwareLight = new System.Windows.Forms.Label();
            this.timeoutTimer = new System.Windows.Forms.Timer(this.components);
            this.connectTimer = new System.Windows.Forms.Timer(this.components);
            this.simLight = new System.Windows.Forms.Label();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.demoTimer = new System.Windows.Forms.Timer(this.components);
            this.flagLabel = new System.Windows.Forms.Label();
            this.overlayLabel = new System.Windows.Forms.Label();
            this.initiationTimer = new System.Windows.Forms.Timer(this.components);
            this.clearTimer = new System.Windows.Forms.Timer(this.components);
            this.incidentTimer = new System.Windows.Forms.Timer(this.components);
            this.durationTimer = new System.Windows.Forms.Timer(this.components);
            this.updateLinkLabel = new System.Windows.Forms.LinkLabel();
            this.multiFlagMessage = new System.Windows.Forms.Panel();
            this.multiFlagMessageLabel = new System.Windows.Forms.Label();
            this.multiFlagMessageDismissButton = new System.Windows.Forms.Button();
            this.optionsMenu.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.multiFlagMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // optionsMenu
            // 
            this.optionsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.initiateBoardMenuItem,
            this.connectorMenuItem,
            this.modulesMenuItem,
            this.brightnessMenuItem,
            this.demoMenuItem,
            this.alwaysOnTopMenuItem,
            this.optionsMenuSeparator,
            this.appMenuItem,
            this.gitMenuItem,
            this.forumThreadMenuItem,
            this.donateToolStripMenuItem,
            this.updatesMenuItem});
            this.optionsMenu.Name = "optionsMenu";
            this.optionsMenu.Size = new System.Drawing.Size(180, 274);
            // 
            // initiateBoardMenuItem
            // 
            this.initiateBoardMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.initiateBoardMenuItem.Name = "initiateBoardMenuItem";
            this.initiateBoardMenuItem.Size = new System.Drawing.Size(179, 22);
            this.initiateBoardMenuItem.Text = "Initialize Board at ";
            this.initiateBoardMenuItem.Visible = false;
            this.initiateBoardMenuItem.Click += new System.EventHandler(this.initiateBoardMenuItem_Click);
            // 
            // connectorMenuItem
            // 
            this.connectorMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectorTopMenuItem,
            this.connectorLeftMenuItem,
            this.connectorRightMenuItem,
            this.connectorBottomMenuItem});
            this.connectorMenuItem.Name = "connectorMenuItem";
            this.connectorMenuItem.Size = new System.Drawing.Size(179, 22);
            this.connectorMenuItem.Text = "USB Connector";
            // 
            // connectorTopMenuItem
            // 
            this.connectorTopMenuItem.CheckOnClick = true;
            this.connectorTopMenuItem.Name = "connectorTopMenuItem";
            this.connectorTopMenuItem.Size = new System.Drawing.Size(105, 22);
            this.connectorTopMenuItem.Text = "Up";
            this.connectorTopMenuItem.ToolTipText = "Choose when the USB connector of your Arduino faces UP";
            this.connectorTopMenuItem.Click += new System.EventHandler(this.connectorMenuItem_Click);
            // 
            // connectorLeftMenuItem
            // 
            this.connectorLeftMenuItem.CheckOnClick = true;
            this.connectorLeftMenuItem.Name = "connectorLeftMenuItem";
            this.connectorLeftMenuItem.Size = new System.Drawing.Size(105, 22);
            this.connectorLeftMenuItem.Text = "Left";
            this.connectorLeftMenuItem.ToolTipText = "Choose when the USB connector of your Arduino faces LEFT";
            this.connectorLeftMenuItem.Click += new System.EventHandler(this.connectorMenuItem_Click);
            // 
            // connectorRightMenuItem
            // 
            this.connectorRightMenuItem.CheckOnClick = true;
            this.connectorRightMenuItem.Name = "connectorRightMenuItem";
            this.connectorRightMenuItem.Size = new System.Drawing.Size(105, 22);
            this.connectorRightMenuItem.Text = "Right";
            this.connectorRightMenuItem.ToolTipText = "Choose when the USB connector of your Arduino faces RIGHT";
            this.connectorRightMenuItem.Click += new System.EventHandler(this.connectorMenuItem_Click);
            // 
            // connectorBottomMenuItem
            // 
            this.connectorBottomMenuItem.CheckOnClick = true;
            this.connectorBottomMenuItem.Name = "connectorBottomMenuItem";
            this.connectorBottomMenuItem.Size = new System.Drawing.Size(105, 22);
            this.connectorBottomMenuItem.Text = "Down";
            this.connectorBottomMenuItem.ToolTipText = "Choose when the USB connector of your Arduino faces DOWN";
            this.connectorBottomMenuItem.Click += new System.EventHandler(this.connectorMenuItem_Click);
            // 
            // modulesMenuItem
            // 
            this.modulesMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flagsModuleMenuItem,
            this.spotterOverlayModuleMenuItem,
            this.proximityOverlayModuleMenuItem,
            this.startLightsModuleMenuItem,
            this.incidentOverlayModuleMenuItem,
            this.pitExitBlueModuleMenuItem,
            this.closedPitsOverlayModuleMenuItem,
            this.repairsOverlayModuleMenuItem,
            this.pitSpeedLimitModuleMenuItem});
            this.modulesMenuItem.Name = "modulesMenuItem";
            this.modulesMenuItem.Size = new System.Drawing.Size(179, 22);
            this.modulesMenuItem.Text = "Modules";
            // 
            // flagsModuleMenuItem
            // 
            this.flagsModuleMenuItem.Checked = true;
            this.flagsModuleMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.flagsModuleMenuItem.Enabled = false;
            this.flagsModuleMenuItem.Name = "flagsModuleMenuItem";
            this.flagsModuleMenuItem.Size = new System.Drawing.Size(153, 22);
            this.flagsModuleMenuItem.Text = "Racing Flags";
            this.flagsModuleMenuItem.ToolTipText = "Show racing flags. Mandatory";
            // 
            // spotterOverlayModuleMenuItem
            // 
            this.spotterOverlayModuleMenuItem.CheckOnClick = true;
            this.spotterOverlayModuleMenuItem.Name = "spotterOverlayModuleMenuItem";
            this.spotterOverlayModuleMenuItem.Size = new System.Drawing.Size(153, 22);
            this.spotterOverlayModuleMenuItem.Text = "Spotter";
            this.spotterOverlayModuleMenuItem.ToolTipText = "Show spotter\'s traffic calls";
            // 
            // proximityOverlayModuleMenuItem
            // 
            this.proximityOverlayModuleMenuItem.CheckOnClick = true;
            this.proximityOverlayModuleMenuItem.Name = "proximityOverlayModuleMenuItem";
            this.proximityOverlayModuleMenuItem.Size = new System.Drawing.Size(153, 22);
            this.proximityOverlayModuleMenuItem.Text = "Proximity";
            this.proximityOverlayModuleMenuItem.ToolTipText = "Show distance to car behind";
            // 
            // startLightsModuleMenuItem
            // 
            this.startLightsModuleMenuItem.CheckOnClick = true;
            this.startLightsModuleMenuItem.Name = "startLightsModuleMenuItem";
            this.startLightsModuleMenuItem.Size = new System.Drawing.Size(153, 22);
            this.startLightsModuleMenuItem.Text = "Start Lights";
            this.startLightsModuleMenuItem.ToolTipText = "Show start lights during start of a race";
            // 
            // incidentOverlayModuleMenuItem
            // 
            this.incidentOverlayModuleMenuItem.CheckOnClick = true;
            this.incidentOverlayModuleMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incidentStyleMapMenuItem});
            this.incidentOverlayModuleMenuItem.Name = "incidentOverlayModuleMenuItem";
            this.incidentOverlayModuleMenuItem.Size = new System.Drawing.Size(153, 22);
            this.incidentOverlayModuleMenuItem.Text = "Incidents";
            this.incidentOverlayModuleMenuItem.ToolTipText = "Show a signal on number of incidents increase";
            // 
            // incidentStyleMapMenuItem
            // 
            this.incidentStyleMapMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incidentStyleMapSmallMenuItem,
            this.incidentStyleMapBigMenuItem,
            this.incidentStyleMapExplodedMenuItem});
            this.incidentStyleMapMenuItem.Name = "incidentStyleMapMenuItem";
            this.incidentStyleMapMenuItem.Size = new System.Drawing.Size(102, 22);
            this.incidentStyleMapMenuItem.Text = "Style";
            // 
            // incidentStyleMapSmallMenuItem
            // 
            this.incidentStyleMapSmallMenuItem.CheckOnClick = true;
            this.incidentStyleMapSmallMenuItem.Name = "incidentStyleMapSmallMenuItem";
            this.incidentStyleMapSmallMenuItem.Size = new System.Drawing.Size(152, 22);
            this.incidentStyleMapSmallMenuItem.Text = "Small";
            this.incidentStyleMapSmallMenuItem.ToolTipText = "Small letter X signal";
            this.incidentStyleMapSmallMenuItem.Click += new System.EventHandler(this.incidentStyleMapMenuItem_Click);
            // 
            // incidentStyleMapBigMenuItem
            // 
            this.incidentStyleMapBigMenuItem.CheckOnClick = true;
            this.incidentStyleMapBigMenuItem.Name = "incidentStyleMapBigMenuItem";
            this.incidentStyleMapBigMenuItem.Size = new System.Drawing.Size(152, 22);
            this.incidentStyleMapBigMenuItem.Text = "Big";
            this.incidentStyleMapBigMenuItem.ToolTipText = "Big letter X signal";
            this.incidentStyleMapBigMenuItem.Click += new System.EventHandler(this.incidentStyleMapMenuItem_Click);
            // 
            // incidentStyleMapExplodedMenuItem
            // 
            this.incidentStyleMapExplodedMenuItem.CheckOnClick = true;
            this.incidentStyleMapExplodedMenuItem.Name = "incidentStyleMapExplodedMenuItem";
            this.incidentStyleMapExplodedMenuItem.Size = new System.Drawing.Size(152, 22);
            this.incidentStyleMapExplodedMenuItem.Text = "Exploded";
            this.incidentStyleMapExplodedMenuItem.ToolTipText = "Exploded letter X signal";
            this.incidentStyleMapExplodedMenuItem.Click += new System.EventHandler(this.incidentStyleMapMenuItem_Click);
            // 
            // pitExitBlueModuleMenuItem
            // 
            this.pitExitBlueModuleMenuItem.CheckOnClick = true;
            this.pitExitBlueModuleMenuItem.Name = "pitExitBlueModuleMenuItem";
            this.pitExitBlueModuleMenuItem.Size = new System.Drawing.Size(153, 22);
            this.pitExitBlueModuleMenuItem.Text = "Pit Exit Blue";
            this.pitExitBlueModuleMenuItem.ToolTipText = "Show blue flag on pit exit with fast car within 100 meters behind";
            // 
            // closedPitsOverlayModuleMenuItem
            // 
            this.closedPitsOverlayModuleMenuItem.CheckOnClick = true;
            this.closedPitsOverlayModuleMenuItem.Name = "closedPitsOverlayModuleMenuItem";
            this.closedPitsOverlayModuleMenuItem.Size = new System.Drawing.Size(153, 22);
            this.closedPitsOverlayModuleMenuItem.Text = "Pits Closed";
            this.closedPitsOverlayModuleMenuItem.ToolTipText = "Show signal when pits are closed";
            // 
            // repairsOverlayModuleMenuItem
            // 
            this.repairsOverlayModuleMenuItem.CheckOnClick = true;
            this.repairsOverlayModuleMenuItem.Name = "repairsOverlayModuleMenuItem";
            this.repairsOverlayModuleMenuItem.Size = new System.Drawing.Size(153, 22);
            this.repairsOverlayModuleMenuItem.Text = "Repairs Progress";
            this.repairsOverlayModuleMenuItem.ToolTipText = "Show signals reflecting progress of repairs in pits";
            // 
            // pitSpeedLimitModuleMenuItem
            // 
            this.pitSpeedLimitModuleMenuItem.CheckOnClick = true;
            this.pitSpeedLimitModuleMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pitSpeedMapMenuItem});
            this.pitSpeedLimitModuleMenuItem.Name = "pitSpeedLimitModuleMenuItem";
            this.pitSpeedLimitModuleMenuItem.Size = new System.Drawing.Size(153, 22);
            this.pitSpeedLimitModuleMenuItem.Text = "Pit Speed Limit";
            this.pitSpeedLimitModuleMenuItem.ToolTipText = "Show pit speed limit assistant signals";
            // 
            // pitSpeedMapMenuItem
            // 
            this.pitSpeedMapMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pitSpeedMapSafeMenuItem,
            this.pitSpeedMapWideMenuItem,
            this.pitSpeedMapNarrowMenuItem,
            this.pitSpeedMapAggressiveMenuItem});
            this.pitSpeedMapMenuItem.Name = "pitSpeedMapMenuItem";
            this.pitSpeedMapMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pitSpeedMapMenuItem.Text = "Tolerance";
            this.pitSpeedMapMenuItem.ToolTipText = "Adjust the signaling tolerance";
            // 
            // pitSpeedMapSafeMenuItem
            // 
            this.pitSpeedMapSafeMenuItem.CheckOnClick = true;
            this.pitSpeedMapSafeMenuItem.Name = "pitSpeedMapSafeMenuItem";
            this.pitSpeedMapSafeMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pitSpeedMapSafeMenuItem.Text = "Safe";
            this.pitSpeedMapSafeMenuItem.ToolTipText = "Inside -1 to +0 kph range";
            this.pitSpeedMapSafeMenuItem.Click += new System.EventHandler(this.pitSpeedMapMenuItem_Click);
            // 
            // pitSpeedMapWideMenuItem
            // 
            this.pitSpeedMapWideMenuItem.CheckOnClick = true;
            this.pitSpeedMapWideMenuItem.Name = "pitSpeedMapWideMenuItem";
            this.pitSpeedMapWideMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pitSpeedMapWideMenuItem.Text = "Wide";
            this.pitSpeedMapWideMenuItem.ToolTipText = "Inside -1 to +1 kph range";
            this.pitSpeedMapWideMenuItem.Click += new System.EventHandler(this.pitSpeedMapMenuItem_Click);
            // 
            // pitSpeedMapNarrowMenuItem
            // 
            this.pitSpeedMapNarrowMenuItem.CheckOnClick = true;
            this.pitSpeedMapNarrowMenuItem.Name = "pitSpeedMapNarrowMenuItem";
            this.pitSpeedMapNarrowMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pitSpeedMapNarrowMenuItem.Text = "Narrow";
            this.pitSpeedMapNarrowMenuItem.ToolTipText = "Inside -0.5 to +0.5 kph range";
            this.pitSpeedMapNarrowMenuItem.Click += new System.EventHandler(this.pitSpeedMapMenuItem_Click);
            // 
            // pitSpeedMapAggressiveMenuItem
            // 
            this.pitSpeedMapAggressiveMenuItem.CheckOnClick = true;
            this.pitSpeedMapAggressiveMenuItem.Name = "pitSpeedMapAggressiveMenuItem";
            this.pitSpeedMapAggressiveMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pitSpeedMapAggressiveMenuItem.Text = "Aggressive";
            this.pitSpeedMapAggressiveMenuItem.ToolTipText = "Inside -0 and +1 kph range";
            this.pitSpeedMapAggressiveMenuItem.Click += new System.EventHandler(this.pitSpeedMapMenuItem_Click);
            // 
            // brightnessMenuItem
            // 
            this.brightnessMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fullBrightnessMenuItem,
            this.highBrightnessMenuItem,
            this.mediumBrightnessMenuItem,
            this.lowBrightnessMenuItem});
            this.brightnessMenuItem.Name = "brightnessMenuItem";
            this.brightnessMenuItem.Size = new System.Drawing.Size(179, 22);
            this.brightnessMenuItem.Text = "Brightness";
            // 
            // fullBrightnessMenuItem
            // 
            this.fullBrightnessMenuItem.CheckOnClick = true;
            this.fullBrightnessMenuItem.Name = "fullBrightnessMenuItem";
            this.fullBrightnessMenuItem.Size = new System.Drawing.Size(119, 22);
            this.fullBrightnessMenuItem.Text = "Full";
            this.fullBrightnessMenuItem.Click += new System.EventHandler(this.brightnessMenuItem_Click);
            // 
            // highBrightnessMenuItem
            // 
            this.highBrightnessMenuItem.CheckOnClick = true;
            this.highBrightnessMenuItem.Name = "highBrightnessMenuItem";
            this.highBrightnessMenuItem.Size = new System.Drawing.Size(119, 22);
            this.highBrightnessMenuItem.Text = "High";
            this.highBrightnessMenuItem.Click += new System.EventHandler(this.brightnessMenuItem_Click);
            // 
            // mediumBrightnessMenuItem
            // 
            this.mediumBrightnessMenuItem.CheckOnClick = true;
            this.mediumBrightnessMenuItem.Name = "mediumBrightnessMenuItem";
            this.mediumBrightnessMenuItem.Size = new System.Drawing.Size(119, 22);
            this.mediumBrightnessMenuItem.Text = "Medium";
            this.mediumBrightnessMenuItem.Click += new System.EventHandler(this.brightnessMenuItem_Click);
            // 
            // lowBrightnessMenuItem
            // 
            this.lowBrightnessMenuItem.CheckOnClick = true;
            this.lowBrightnessMenuItem.Name = "lowBrightnessMenuItem";
            this.lowBrightnessMenuItem.Size = new System.Drawing.Size(119, 22);
            this.lowBrightnessMenuItem.Text = "Low";
            this.lowBrightnessMenuItem.Click += new System.EventHandler(this.brightnessMenuItem_Click);
            // 
            // demoMenuItem
            // 
            this.demoMenuItem.Checked = true;
            this.demoMenuItem.CheckOnClick = true;
            this.demoMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.demoMenuItem.Name = "demoMenuItem";
            this.demoMenuItem.Size = new System.Drawing.Size(179, 22);
            this.demoMenuItem.Text = "Demo Mode";
            this.demoMenuItem.ToolTipText = "Only when not in iRacing session. Cycles some of the flags for amusement";
            this.demoMenuItem.CheckStateChanged += new System.EventHandler(this.demoMenuItem_CheckStateChanged);
            // 
            // alwaysOnTopMenuItem
            // 
            this.alwaysOnTopMenuItem.Checked = true;
            this.alwaysOnTopMenuItem.CheckOnClick = true;
            this.alwaysOnTopMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.alwaysOnTopMenuItem.Name = "alwaysOnTopMenuItem";
            this.alwaysOnTopMenuItem.Size = new System.Drawing.Size(179, 22);
            this.alwaysOnTopMenuItem.Text = "Always on Top";
            this.alwaysOnTopMenuItem.ToolTipText = "Keep this window on top of other windows";
            this.alwaysOnTopMenuItem.CheckStateChanged += new System.EventHandler(this.alwaysOnTopMenuItem_CheckStateChanged);
            // 
            // optionsMenuSeparator
            // 
            this.optionsMenuSeparator.Name = "optionsMenuSeparator";
            this.optionsMenuSeparator.Size = new System.Drawing.Size(176, 6);
            // 
            // appMenuItem
            // 
            this.appMenuItem.Enabled = false;
            this.appMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.appMenuItem.Name = "appMenuItem";
            this.appMenuItem.Size = new System.Drawing.Size(179, 22);
            this.appMenuItem.Text = "iFLAG vX.Y";
            // 
            // gitMenuItem
            // 
            this.gitMenuItem.Image = global::iFlag.Properties.Resources.githubLogo;
            this.gitMenuItem.Name = "gitMenuItem";
            this.gitMenuItem.Size = new System.Drawing.Size(179, 22);
            this.gitMenuItem.Text = "a Free Open Source.";
            this.gitMenuItem.ToolTipText = "Suggest, collaborate, improve!";
            this.gitMenuItem.Click += new System.EventHandler(this.gitMenuItem_Click);
            // 
            // forumThreadMenuItem
            // 
            this.forumThreadMenuItem.Image = global::iFlag.Properties.Resources.iRacingLogo;
            this.forumThreadMenuItem.Name = "forumThreadMenuItem";
            this.forumThreadMenuItem.Size = new System.Drawing.Size(179, 22);
            this.forumThreadMenuItem.Text = "Forum Thread";
            this.forumThreadMenuItem.ToolTipText = "Place to discuss";
            this.forumThreadMenuItem.Click += new System.EventHandler(this.forumThreadMenuItem_Click);
            // 
            // donateToolStripMenuItem
            // 
            this.donateToolStripMenuItem.Image = global::iFlag.Properties.Resources.paypalLogo;
            this.donateToolStripMenuItem.Name = "donateToolStripMenuItem";
            this.donateToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.donateToolStripMenuItem.Text = "Donate! Thank you.";
            this.donateToolStripMenuItem.ToolTipText = "Support iFLAG via PayPal";
            this.donateToolStripMenuItem.Click += new System.EventHandler(this.donateToolStripMenuItem_Click);
            // 
            // updatesMenuItem
            // 
            this.updatesMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updatesEnabledMenuItem,
            this.updatesExperimentalMenuItem});
            this.updatesMenuItem.Name = "updatesMenuItem";
            this.updatesMenuItem.Size = new System.Drawing.Size(179, 22);
            this.updatesMenuItem.Text = "Updates";
            this.updatesMenuItem.ToolTipText = "Check for app version updates on startup";
            // 
            // updatesEnabledMenuItem
            // 
            this.updatesEnabledMenuItem.Name = "updatesEnabledMenuItem";
            this.updatesEnabledMenuItem.Size = new System.Drawing.Size(142, 22);
            this.updatesEnabledMenuItem.Text = "Enabled";
            this.updatesEnabledMenuItem.Click += new System.EventHandler(this.updatesEnabledMenuItem_Click);
            // 
            // updatesExperimentalMenuItem
            // 
            this.updatesExperimentalMenuItem.Name = "updatesExperimentalMenuItem";
            this.updatesExperimentalMenuItem.Size = new System.Drawing.Size(142, 22);
            this.updatesExperimentalMenuItem.Text = "Experimental";
            this.updatesExperimentalMenuItem.ToolTipText = "At your own risk!";
            this.updatesExperimentalMenuItem.Click += new System.EventHandler(this.updatesExperimentalMenuItem_Click);
            // 
            // optionsButton
            // 
            this.optionsButton.Location = new System.Drawing.Point(0, 0);
            this.optionsButton.Name = "optionsButton";
            this.optionsButton.Size = new System.Drawing.Size(55, 55);
            this.optionsButton.TabIndex = 1;
            this.optionsButton.Text = "Options";
            this.optionsButton.UseVisualStyleBackColor = true;
            this.optionsButton.Click += new System.EventHandler(this.optionsButton_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 54);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip.Size = new System.Drawing.Size(281, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip";
            // 
            // commLabel
            // 
            this.commLabel.Margin = new System.Windows.Forms.Padding(53, 3, 0, 2);
            this.commLabel.Name = "commLabel";
            this.commLabel.Size = new System.Drawing.Size(78, 17);
            this.commLabel.Text = "Connecting...";
            // 
            // hardwareLight
            // 
            this.hardwareLight.BackColor = System.Drawing.Color.Red;
            this.hardwareLight.ForeColor = System.Drawing.Color.White;
            this.hardwareLight.Location = new System.Drawing.Point(1, 55);
            this.hardwareLight.Name = "hardwareLight";
            this.hardwareLight.Size = new System.Drawing.Size(53, 20);
            this.hardwareLight.TabIndex = 3;
            this.hardwareLight.Text = "iFLAG";
            this.hardwareLight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeoutTimer
            // 
            this.timeoutTimer.Interval = 5000;
            this.timeoutTimer.Tick += new System.EventHandler(this.timeoutTimer_Tick);
            // 
            // connectTimer
            // 
            this.connectTimer.Enabled = true;
            this.connectTimer.Interval = 1000;
            this.connectTimer.Tick += new System.EventHandler(this.connectTimer_Tick);
            // 
            // simLight
            // 
            this.simLight.BackColor = System.Drawing.Color.Red;
            this.simLight.ForeColor = System.Drawing.Color.White;
            this.simLight.Location = new System.Drawing.Point(227, 55);
            this.simLight.Name = "simLight";
            this.simLight.Size = new System.Drawing.Size(53, 20);
            this.simLight.TabIndex = 4;
            this.simLight.Text = "iRacing";
            this.simLight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // updateTimer
            // 
            this.updateTimer.Interval = 50;
            this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
            // 
            // demoTimer
            // 
            this.demoTimer.Interval = 5000;
            this.demoTimer.Tick += new System.EventHandler(this.demoTimer_Tick);
            // 
            // flagLabel
            // 
            this.flagLabel.AutoSize = true;
            this.flagLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.flagLabel.Location = new System.Drawing.Point(61, 18);
            this.flagLabel.Name = "flagLabel";
            this.flagLabel.Size = new System.Drawing.Size(49, 18);
            this.flagLabel.TabIndex = 5;
            this.flagLabel.Text = "iFLAG";
            // 
            // overlayLabel
            // 
            this.overlayLabel.AutoSize = true;
            this.overlayLabel.BackColor = System.Drawing.Color.Transparent;
            this.overlayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.overlayLabel.Location = new System.Drawing.Point(61, 31);
            this.overlayLabel.Name = "overlayLabel";
            this.overlayLabel.Size = new System.Drawing.Size(16, 13);
            this.overlayLabel.TabIndex = 8;
            this.overlayLabel.Text = "---";
            this.overlayLabel.Visible = false;
            // 
            // initiationTimer
            // 
            this.initiationTimer.Enabled = true;
            this.initiationTimer.Interval = 30000;
            this.initiationTimer.Tick += new System.EventHandler(this.initiationTimer_Tick);
            // 
            // clearTimer
            // 
            this.clearTimer.Interval = 3000;
            this.clearTimer.Tick += new System.EventHandler(this.clearTimer_Tick);
            // 
            // incidentTimer
            // 
            this.incidentTimer.Interval = 3000;
            this.incidentTimer.Tick += new System.EventHandler(this.incidentTimer_Tick);
            // 
            // durationTimer
            // 
            this.durationTimer.Interval = 2000;
            this.durationTimer.Tick += new System.EventHandler(this.durationTimer_Tick);
            // 
            // updateLinkLabel
            // 
            this.updateLinkLabel.AutoSize = true;
            this.updateLinkLabel.BackColor = System.Drawing.Color.Black;
            this.updateLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.updateLinkLabel.LinkColor = System.Drawing.Color.Gold;
            this.updateLinkLabel.Location = new System.Drawing.Point(226, -1);
            this.updateLinkLabel.Name = "updateLinkLabel";
            this.updateLinkLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.updateLinkLabel.Size = new System.Drawing.Size(56, 14);
            this.updateLinkLabel.TabIndex = 6;
            this.updateLinkLabel.TabStop = true;
            this.updateLinkLabel.Text = "Updates...";
            this.updateLinkLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.updateLinkLabel.Visible = false;
            this.updateLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.updateLinkLabel_LinkClicked);
            // 
            // multiFlagMessage
            // 
            this.multiFlagMessage.BackColor = System.Drawing.Color.SteelBlue;
            this.multiFlagMessage.Controls.Add(this.multiFlagMessageDismissButton);
            this.multiFlagMessage.Controls.Add(this.multiFlagMessageLabel);
            this.multiFlagMessage.Location = new System.Drawing.Point(0, 0);
            this.multiFlagMessage.Name = "multiFlagMessage";
            this.multiFlagMessage.Size = new System.Drawing.Size(282, 76);
            this.multiFlagMessage.TabIndex = 7;
            this.multiFlagMessage.Visible = false;
            // 
            // multiFlagMessageLabel
            // 
            this.multiFlagMessageLabel.BackColor = System.Drawing.Color.Transparent;
            this.multiFlagMessageLabel.ForeColor = System.Drawing.Color.White;
            this.multiFlagMessageLabel.Location = new System.Drawing.Point(4, 1);
            this.multiFlagMessageLabel.Name = "multiFlagMessageLabel";
            this.multiFlagMessageLabel.Size = new System.Drawing.Size(166, 73);
            this.multiFlagMessageLabel.TabIndex = 0;
            this.multiFlagMessageLabel.Text = "Are you seriously about to run more than 1 iFLAG at once?\r\nAt your own risk?";
            this.multiFlagMessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // multiFlagMessageDismissButton
            // 
            this.multiFlagMessageDismissButton.Location = new System.Drawing.Point(176, 19);
            this.multiFlagMessageDismissButton.Name = "multiFlagMessageDismissButton";
            this.multiFlagMessageDismissButton.Size = new System.Drawing.Size(93, 39);
            this.multiFlagMessageDismissButton.TabIndex = 1;
            this.multiFlagMessageDismissButton.Text = "YES! Exactly what I want :)";
            this.multiFlagMessageDismissButton.UseVisualStyleBackColor = true;
            this.multiFlagMessageDismissButton.Click += new System.EventHandler(this.multiFlagMessageDismissButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 76);
            this.Controls.Add(this.multiFlagMessage);
            this.Controls.Add(this.updateLinkLabel);
            this.Controls.Add(this.flagLabel);
            this.Controls.Add(this.overlayLabel);
            this.Controls.Add(this.simLight);
            this.Controls.Add(this.hardwareLight);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.optionsButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "iFLAG";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.Move += new System.EventHandler(this.mainForm_Move);
            this.optionsMenu.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.multiFlagMessage.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip optionsMenu;
        private System.Windows.Forms.ToolStripMenuItem alwaysOnTopMenuItem;
        private System.Windows.Forms.Button optionsButton;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel commLabel;
        private System.Windows.Forms.Label hardwareLight;
        private System.Windows.Forms.Timer timeoutTimer;
        private System.Windows.Forms.Timer connectTimer;
        private System.Windows.Forms.Label simLight;
        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.Timer demoTimer;
        private System.Windows.Forms.ToolStripMenuItem demoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectorMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectorTopMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectorLeftMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectorRightMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectorBottomMenuItem;
        private System.Windows.Forms.Label flagLabel;
        private System.Windows.Forms.Label overlayLabel;
        private System.Windows.Forms.ToolStripMenuItem appMenuItem;
        private System.Windows.Forms.ToolStripSeparator optionsMenuSeparator;
        private System.Windows.Forms.ToolStripMenuItem forumThreadMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modulesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flagsModuleMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startLightsModuleMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spotterOverlayModuleMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proximityOverlayModuleMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incidentOverlayModuleMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incidentStyleMapMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incidentStyleMapSmallMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incidentStyleMapBigMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incidentStyleMapExplodedMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pitExitBlueModuleMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closedPitsOverlayModuleMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repairsOverlayModuleMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pitSpeedLimitModuleMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pitSpeedMapMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pitSpeedMapSafeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pitSpeedMapWideMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pitSpeedMapNarrowMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pitSpeedMapAggressiveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem initiateBoardMenuItem;
        private System.Windows.Forms.Timer initiationTimer;
        private System.Windows.Forms.Timer clearTimer;
        private System.Windows.Forms.Timer durationTimer;
        private System.Windows.Forms.Timer incidentTimer;
        private System.Windows.Forms.ToolStripMenuItem brightnessMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediumBrightnessMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullBrightnessMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highBrightnessMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lowBrightnessMenuItem;
        private System.Windows.Forms.LinkLabel updateLinkLabel;
        private System.Windows.Forms.ToolStripMenuItem updatesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updatesEnabledMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updatesExperimentalMenuItem;
        private System.Windows.Forms.Panel multiFlagMessage;
        private System.Windows.Forms.Label multiFlagMessageLabel;
        private System.Windows.Forms.Button multiFlagMessageDismissButton;
    }
}

