﻿namespace TMS.ApplicationLayer
{
    partial class TrainRoute
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainRoute));
            this.pnlButtonList = new System.Windows.Forms.Panel();
            this.pnlUserControlList = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnUserProfile = new System.Windows.Forms.Button();
            this.btnPurchaseHistory = new System.Windows.Forms.Button();
            this.btnTrainRoute = new System.Windows.Forms.Button();
            this.btnFareQuery = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pnlGridView = new System.Windows.Forms.Panel();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.dgvTrainList = new System.Windows.Forms.DataGridView();
            this.trainno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.offday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departurestation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departuretime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalstation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivaltime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routetype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bogey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.standard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceperstandard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.economy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricepereconomy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstclass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceperfirstclass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bogeyinfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnlButtonList.SuspendLayout();
            this.pnlGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButtonList
            // 
            this.pnlButtonList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlButtonList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pnlButtonList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlButtonList.Controls.Add(this.pnlUserControlList);
            this.pnlButtonList.Controls.Add(this.btnExit);
            this.pnlButtonList.Controls.Add(this.btnSignOut);
            this.pnlButtonList.Controls.Add(this.btnUserProfile);
            this.pnlButtonList.Controls.Add(this.btnPurchaseHistory);
            this.pnlButtonList.Controls.Add(this.btnTrainRoute);
            this.pnlButtonList.Controls.Add(this.btnFareQuery);
            this.pnlButtonList.Controls.Add(this.btnDashboard);
            this.pnlButtonList.Location = new System.Drawing.Point(8, 10);
            this.pnlButtonList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlButtonList.Name = "pnlButtonList";
            this.pnlButtonList.Size = new System.Drawing.Size(150, 510);
            this.pnlButtonList.TabIndex = 4;
            // 
            // pnlUserControlList
            // 
            this.pnlUserControlList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pnlUserControlList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUserControlList.Location = new System.Drawing.Point(178, 2);
            this.pnlUserControlList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlUserControlList.Name = "pnlUserControlList";
            this.pnlUserControlList.Size = new System.Drawing.Size(830, 492);
            this.pnlUserControlList.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(3, 430);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(140, 58);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSignOut.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.Location = new System.Drawing.Point(3, 358);
            this.btnSignOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(140, 66);
            this.btnSignOut.TabIndex = 5;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.BtnSignOut_Click);
            // 
            // btnUserProfile
            // 
            this.btnUserProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnUserProfile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserProfile.Location = new System.Drawing.Point(3, 287);
            this.btnUserProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUserProfile.Name = "btnUserProfile";
            this.btnUserProfile.Size = new System.Drawing.Size(140, 66);
            this.btnUserProfile.TabIndex = 4;
            this.btnUserProfile.Text = "Change Password";
            this.btnUserProfile.UseVisualStyleBackColor = false;
            this.btnUserProfile.Click += new System.EventHandler(this.BtnUserProfile_Click);
            // 
            // btnPurchaseHistory
            // 
            this.btnPurchaseHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPurchaseHistory.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchaseHistory.Location = new System.Drawing.Point(3, 216);
            this.btnPurchaseHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPurchaseHistory.Name = "btnPurchaseHistory";
            this.btnPurchaseHistory.Size = new System.Drawing.Size(140, 66);
            this.btnPurchaseHistory.TabIndex = 3;
            this.btnPurchaseHistory.Text = "Purchase History";
            this.btnPurchaseHistory.UseVisualStyleBackColor = false;
            this.btnPurchaseHistory.Click += new System.EventHandler(this.BtnPurchaseHistory_Click);
            // 
            // btnTrainRoute
            // 
            this.btnTrainRoute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTrainRoute.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrainRoute.Location = new System.Drawing.Point(-1, 145);
            this.btnTrainRoute.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTrainRoute.Name = "btnTrainRoute";
            this.btnTrainRoute.Size = new System.Drawing.Size(140, 66);
            this.btnTrainRoute.TabIndex = 2;
            this.btnTrainRoute.Text = "Train Route";
            this.btnTrainRoute.UseVisualStyleBackColor = false;
            this.btnTrainRoute.Click += new System.EventHandler(this.BtnTrainRoute_Click);
            // 
            // btnFareQuery
            // 
            this.btnFareQuery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnFareQuery.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFareQuery.Location = new System.Drawing.Point(3, 74);
            this.btnFareQuery.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFareQuery.Name = "btnFareQuery";
            this.btnFareQuery.Size = new System.Drawing.Size(140, 66);
            this.btnFareQuery.TabIndex = 1;
            this.btnFareQuery.Text = "Fare Query";
            this.btnFareQuery.UseVisualStyleBackColor = false;
            this.btnFareQuery.Click += new System.EventHandler(this.BtnFareQuery_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDashboard.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Location = new System.Drawing.Point(3, 2);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(140, 66);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            // 
            // pnlGridView
            // 
            this.pnlGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGridView.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlGridView.Controls.Add(this.btnSearch);
            this.pnlGridView.Controls.Add(this.txtSearch);
            this.pnlGridView.Controls.Add(this.dgvTrainList);
            this.pnlGridView.Location = new System.Drawing.Point(187, 10);
            this.pnlGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlGridView.Name = "pnlGridView";
            this.pnlGridView.Size = new System.Drawing.Size(1128, 510);
            this.pnlGridView.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(934, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(152, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseSelectable = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(829, 1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(15, 21);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "Please search your route by train name or departure station  or arrival station";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(851, 23);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Please search your route by train name or departure station  or arrival station";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // dgvTrainList
            // 
            this.dgvTrainList.AllowUserToAddRows = false;
            this.dgvTrainList.AllowUserToDeleteRows = false;
            this.dgvTrainList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTrainList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrainList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.trainno,
            this.name,
            this.offday,
            this.departurestation,
            this.departuretime,
            this.arrivalstation,
            this.arrivaltime,
            this.routetype,
            this.capacity,
            this.bogey,
            this.standard,
            this.priceperstandard,
            this.economy,
            this.pricepereconomy,
            this.firstclass,
            this.priceperfirstclass,
            this.bogeyinfo});
            this.dgvTrainList.Location = new System.Drawing.Point(4, 63);
            this.dgvTrainList.Name = "dgvTrainList";
            this.dgvTrainList.ReadOnly = true;
            this.dgvTrainList.RowHeadersWidth = 51;
            this.dgvTrainList.RowTemplate.Height = 24;
            this.dgvTrainList.Size = new System.Drawing.Size(1121, 444);
            this.dgvTrainList.TabIndex = 0;
            // 
            // trainno
            // 
            this.trainno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.trainno.DataPropertyName = "trainno";
            this.trainno.HeaderText = "Train Number";
            this.trainno.MinimumWidth = 100;
            this.trainno.Name = "trainno";
            this.trainno.ReadOnly = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 150;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // offday
            // 
            this.offday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.offday.DataPropertyName = "offday";
            this.offday.HeaderText = "Off Day";
            this.offday.MinimumWidth = 100;
            this.offday.Name = "offday";
            this.offday.ReadOnly = true;
            // 
            // departurestation
            // 
            this.departurestation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.departurestation.DataPropertyName = "departurestation";
            this.departurestation.HeaderText = "Departure Station";
            this.departurestation.MinimumWidth = 100;
            this.departurestation.Name = "departurestation";
            this.departurestation.ReadOnly = true;
            // 
            // departuretime
            // 
            this.departuretime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.departuretime.DataPropertyName = "departuretime";
            this.departuretime.HeaderText = "Departure Time";
            this.departuretime.MinimumWidth = 100;
            this.departuretime.Name = "departuretime";
            this.departuretime.ReadOnly = true;
            // 
            // arrivalstation
            // 
            this.arrivalstation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.arrivalstation.DataPropertyName = "arrivalstation";
            this.arrivalstation.HeaderText = "Arrival Station";
            this.arrivalstation.MinimumWidth = 100;
            this.arrivalstation.Name = "arrivalstation";
            this.arrivalstation.ReadOnly = true;
            // 
            // arrivaltime
            // 
            this.arrivaltime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.arrivaltime.DataPropertyName = "arrivaltime";
            this.arrivaltime.HeaderText = "Arrival Time";
            this.arrivaltime.MinimumWidth = 100;
            this.arrivaltime.Name = "arrivaltime";
            this.arrivaltime.ReadOnly = true;
            // 
            // routetype
            // 
            this.routetype.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.routetype.DataPropertyName = "routetype";
            this.routetype.HeaderText = "Route Type";
            this.routetype.MinimumWidth = 250;
            this.routetype.Name = "routetype";
            this.routetype.ReadOnly = true;
            // 
            // capacity
            // 
            this.capacity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.capacity.DataPropertyName = "capacity";
            this.capacity.HeaderText = "Total Capacity";
            this.capacity.MinimumWidth = 100;
            this.capacity.Name = "capacity";
            this.capacity.ReadOnly = true;
            // 
            // bogey
            // 
            this.bogey.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bogey.DataPropertyName = "bogey";
            this.bogey.HeaderText = "Total Bogye";
            this.bogey.MinimumWidth = 100;
            this.bogey.Name = "bogey";
            this.bogey.ReadOnly = true;
            // 
            // standard
            // 
            this.standard.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.standard.DataPropertyName = "standard";
            this.standard.HeaderText = "Standard(AC Couch)";
            this.standard.MinimumWidth = 100;
            this.standard.Name = "standard";
            this.standard.ReadOnly = true;
            // 
            // priceperstandard
            // 
            this.priceperstandard.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.priceperstandard.DataPropertyName = "priceperstandard";
            this.priceperstandard.HeaderText = "Price/Standard(BDT)";
            this.priceperstandard.MinimumWidth = 100;
            this.priceperstandard.Name = "priceperstandard";
            this.priceperstandard.ReadOnly = true;
            // 
            // economy
            // 
            this.economy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.economy.DataPropertyName = "economy";
            this.economy.HeaderText = "Economy (Non AC)";
            this.economy.MinimumWidth = 100;
            this.economy.Name = "economy";
            this.economy.ReadOnly = true;
            // 
            // pricepereconomy
            // 
            this.pricepereconomy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pricepereconomy.DataPropertyName = "pricepereconomy";
            this.pricepereconomy.HeaderText = "Price/Economy(BDT)";
            this.pricepereconomy.MinimumWidth = 100;
            this.pricepereconomy.Name = "pricepereconomy";
            this.pricepereconomy.ReadOnly = true;
            // 
            // firstclass
            // 
            this.firstclass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firstclass.DataPropertyName = "firstclass";
            this.firstclass.HeaderText = "Firstclass (Cabin)";
            this.firstclass.MinimumWidth = 100;
            this.firstclass.Name = "firstclass";
            this.firstclass.ReadOnly = true;
            // 
            // priceperfirstclass
            // 
            this.priceperfirstclass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.priceperfirstclass.DataPropertyName = "priceperfirstclass";
            this.priceperfirstclass.HeaderText = "Price/Firstclass(BDT)";
            this.priceperfirstclass.MinimumWidth = 100;
            this.priceperfirstclass.Name = "priceperfirstclass";
            this.priceperfirstclass.ReadOnly = true;
            // 
            // bogeyinfo
            // 
            this.bogeyinfo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bogeyinfo.DataPropertyName = "bogeyinfo";
            this.bogeyinfo.HeaderText = "Bogey Info";
            this.bogeyinfo.MinimumWidth = 1200;
            this.bogeyinfo.Name = "bogeyinfo";
            this.bogeyinfo.ReadOnly = true;
            // 
            // TrainRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1325, 545);
            this.Controls.Add(this.pnlButtonList);
            this.Controls.Add(this.pnlGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "TrainRoute";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Train Route";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FareQuery_FormClosed);
            this.pnlButtonList.ResumeLayout(false);
            this.pnlGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlButtonList;
        private System.Windows.Forms.Panel pnlUserControlList;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Button btnUserProfile;
        private System.Windows.Forms.Button btnPurchaseHistory;
        private System.Windows.Forms.Button btnTrainRoute;
        private System.Windows.Forms.Button btnFareQuery;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel pnlGridView;
        private System.Windows.Forms.DataGridView dgvTrainList;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroButton btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainno;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn offday;
        private System.Windows.Forms.DataGridViewTextBoxColumn departurestation;
        private System.Windows.Forms.DataGridViewTextBoxColumn departuretime;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalstation;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivaltime;
        private System.Windows.Forms.DataGridViewTextBoxColumn routetype;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn bogey;
        private System.Windows.Forms.DataGridViewTextBoxColumn standard;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceperstandard;
        private System.Windows.Forms.DataGridViewTextBoxColumn economy;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricepereconomy;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstclass;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceperfirstclass;
        private System.Windows.Forms.DataGridViewTextBoxColumn bogeyinfo;
    }
}