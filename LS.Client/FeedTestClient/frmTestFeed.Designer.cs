﻿namespace FeedTestClient
{
    partial class frmTestFeed
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
            this.btnConnectToLs = new System.Windows.Forms.Button();
            this.btnSubscribe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxSubscriptionItem = new System.Windows.Forms.TextBox();
            this.comboBoxSubscriptionMode = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridNotificaions = new System.Windows.Forms.DataGrid();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNotificaions)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnectToLs
            // 
            this.btnConnectToLs.Location = new System.Drawing.Point(37, 12);
            this.btnConnectToLs.Name = "btnConnectToLs";
            this.btnConnectToLs.Size = new System.Drawing.Size(219, 44);
            this.btnConnectToLs.TabIndex = 1;
            this.btnConnectToLs.Text = "Connect to LighStreamer";
            this.btnConnectToLs.UseVisualStyleBackColor = true;
            this.btnConnectToLs.Click += new System.EventHandler(this.btnGetNotificaions_Click);
            // 
            // btnSubscribe
            // 
            this.btnSubscribe.Location = new System.Drawing.Point(304, 12);
            this.btnSubscribe.Name = "btnSubscribe";
            this.btnSubscribe.Size = new System.Drawing.Size(194, 44);
            this.btnSubscribe.TabIndex = 2;
            this.btnSubscribe.Text = "Subscribe";
            this.btnSubscribe.UseVisualStyleBackColor = true;
            this.btnSubscribe.Click += new System.EventHandler(this.btnSubscribe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(568, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Subscription Item";
            // 
            // txtboxSubscriptionItem
            // 
            this.txtboxSubscriptionItem.Location = new System.Drawing.Point(693, 23);
            this.txtboxSubscriptionItem.Name = "txtboxSubscriptionItem";
            this.txtboxSubscriptionItem.Size = new System.Drawing.Size(204, 22);
            this.txtboxSubscriptionItem.TabIndex = 4;
            this.txtboxSubscriptionItem.Text = "Notify_User#1248";
            // 
            // comboBoxSubscriptionMode
            // 
            this.comboBoxSubscriptionMode.AutoCompleteCustomSource.AddRange(new string[] {
            "DISTINCT",
            "MERGE",
            "COMMAND",
            "RAW"});
            this.comboBoxSubscriptionMode.FormattingEnabled = true;
            this.comboBoxSubscriptionMode.Items.AddRange(new object[] {
            "DISTINCT",
            "MERGE",
            "COMMAND",
            "RAW"});
            this.comboBoxSubscriptionMode.Location = new System.Drawing.Point(1072, 23);
            this.comboBoxSubscriptionMode.Name = "comboBoxSubscriptionMode";
            this.comboBoxSubscriptionMode.Size = new System.Drawing.Size(187, 24);
            this.comboBoxSubscriptionMode.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(921, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Subscription Mode";
            // 
            // dataGridNotificaions
            // 
            this.dataGridNotificaions.DataMember = "";
            this.dataGridNotificaions.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGridNotificaions.Location = new System.Drawing.Point(26, 115);
            this.dataGridNotificaions.Name = "dataGridNotificaions";
            this.dataGridNotificaions.Size = new System.Drawing.Size(1233, 607);
            this.dataGridNotificaions.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1126, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 44);
            this.button1.TabIndex = 20;
            this.button1.Text = "UnSubscribe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmTestFeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 734);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridNotificaions);
            this.Controls.Add(this.comboBoxSubscriptionMode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtboxSubscriptionItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubscribe);
            this.Controls.Add(this.btnConnectToLs);
            this.Name = "frmTestFeed";
            this.Text = "Test Feed";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNotificaions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnectToLs;
        private System.Windows.Forms.Button btnSubscribe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxSubscriptionItem;
        private System.Windows.Forms.ComboBox comboBoxSubscriptionMode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGrid dataGridNotificaions;
        private System.Windows.Forms.Button button1;
    }
}

