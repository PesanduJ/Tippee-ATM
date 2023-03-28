namespace Tippee_ATM
{
    partial class Settings
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.lbl_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_oldPin = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_retypeNewPin = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_newPin = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_updatePin = new Guna.UI2.WinForms.Guna2Button();
            this.pb_primaryFingerprint = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btn_updateprimaryFingerprint = new Guna.UI2.WinForms.Guna2Button();
            this.btn_updatesecondaryFingerprint = new Guna.UI2.WinForms.Guna2Button();
            this.pb_secondaryFingerprint = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2VSeparator2 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_primaryFingerprint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_secondaryFingerprint)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2Panel1.Controls.Add(this.lbl_date);
            this.guna2Panel1.Controls.Add(this.lbl_time);
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Location = new System.Drawing.Point(-2, -1);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1029, 134);
            this.guna2Panel1.TabIndex = 5;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_date.Location = new System.Drawing.Point(793, 77);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(223, 20);
            this.lbl_date.TabIndex = 12;
            this.lbl_date.Text = "Monday, 7th November 2023";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_time.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_time.Location = new System.Drawing.Point(877, 42);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(139, 35);
            this.lbl_time.TabIndex = 11;
            this.lbl_time.Text = "10:10 AM";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.guna2Panel2.BackgroundImage = global::Tippee_ATM.Properties.Resources.Tippee_Logo_Header;
            this.guna2Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2Panel2.Location = new System.Drawing.Point(-2, -1);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(239, 134);
            this.guna2Panel2.TabIndex = 5;
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.guna2VSeparator1.FillThickness = 2;
            this.guna2VSeparator1.Location = new System.Drawing.Point(350, 165);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 359);
            this.guna2VSeparator1.TabIndex = 6;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft YaHei", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_name.Location = new System.Drawing.Point(79, 154);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(181, 36);
            this.lbl_name.TabIndex = 10;
            this.lbl_name.Text = "UPDATE PIN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(536, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 36);
            this.label1.TabIndex = 11;
            this.label1.Text = "UPDATE FINGERPRINTS";
            // 
            // txt_oldPin
            // 
            this.txt_oldPin.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_oldPin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_oldPin.DefaultText = "";
            this.txt_oldPin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_oldPin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_oldPin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_oldPin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_oldPin.FillColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_oldPin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_oldPin.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_oldPin.ForeColor = System.Drawing.Color.Black;
            this.txt_oldPin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_oldPin.Location = new System.Drawing.Point(40, 247);
            this.txt_oldPin.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_oldPin.Name = "txt_oldPin";
            this.txt_oldPin.PasswordChar = '\0';
            this.txt_oldPin.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_oldPin.PlaceholderText = "OLD PIN";
            this.txt_oldPin.SelectedText = "";
            this.txt_oldPin.Size = new System.Drawing.Size(259, 37);
            this.txt_oldPin.TabIndex = 12;
            this.txt_oldPin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_retypeNewPin
            // 
            this.txt_retypeNewPin.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_retypeNewPin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_retypeNewPin.DefaultText = "";
            this.txt_retypeNewPin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_retypeNewPin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_retypeNewPin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_retypeNewPin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_retypeNewPin.FillColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_retypeNewPin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_retypeNewPin.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_retypeNewPin.ForeColor = System.Drawing.Color.Black;
            this.txt_retypeNewPin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_retypeNewPin.Location = new System.Drawing.Point(40, 369);
            this.txt_retypeNewPin.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_retypeNewPin.Name = "txt_retypeNewPin";
            this.txt_retypeNewPin.PasswordChar = '\0';
            this.txt_retypeNewPin.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_retypeNewPin.PlaceholderText = "RE-TYPE NEW PIN";
            this.txt_retypeNewPin.SelectedText = "";
            this.txt_retypeNewPin.Size = new System.Drawing.Size(259, 37);
            this.txt_retypeNewPin.TabIndex = 13;
            this.txt_retypeNewPin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_newPin
            // 
            this.txt_newPin.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_newPin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_newPin.DefaultText = "";
            this.txt_newPin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_newPin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_newPin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_newPin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_newPin.FillColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_newPin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_newPin.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_newPin.ForeColor = System.Drawing.Color.Black;
            this.txt_newPin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_newPin.Location = new System.Drawing.Point(40, 308);
            this.txt_newPin.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txt_newPin.Name = "txt_newPin";
            this.txt_newPin.PasswordChar = '\0';
            this.txt_newPin.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_newPin.PlaceholderText = "NEW PIN";
            this.txt_newPin.SelectedText = "";
            this.txt_newPin.Size = new System.Drawing.Size(259, 37);
            this.txt_newPin.TabIndex = 14;
            this.txt_newPin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_updatePin
            // 
            this.btn_updatePin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_updatePin.Animated = true;
            this.btn_updatePin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_updatePin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_updatePin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_updatePin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_updatePin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_updatePin.FillColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_updatePin.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updatePin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.btn_updatePin.Location = new System.Drawing.Point(69, 463);
            this.btn_updatePin.Name = "btn_updatePin";
            this.btn_updatePin.Size = new System.Drawing.Size(201, 37);
            this.btn_updatePin.TabIndex = 15;
            this.btn_updatePin.Text = "UPDATE PIN";
            // 
            // pb_primaryFingerprint
            // 
            this.pb_primaryFingerprint.ImageRotate = 0F;
            this.pb_primaryFingerprint.Location = new System.Drawing.Point(435, 249);
            this.pb_primaryFingerprint.Name = "pb_primaryFingerprint";
            this.pb_primaryFingerprint.Size = new System.Drawing.Size(150, 150);
            this.pb_primaryFingerprint.TabIndex = 21;
            this.pb_primaryFingerprint.TabStop = false;
            // 
            // btn_updateprimaryFingerprint
            // 
            this.btn_updateprimaryFingerprint.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_updateprimaryFingerprint.Animated = true;
            this.btn_updateprimaryFingerprint.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_updateprimaryFingerprint.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_updateprimaryFingerprint.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_updateprimaryFingerprint.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_updateprimaryFingerprint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_updateprimaryFingerprint.FillColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_updateprimaryFingerprint.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updateprimaryFingerprint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.btn_updateprimaryFingerprint.Location = new System.Drawing.Point(410, 463);
            this.btn_updateprimaryFingerprint.Name = "btn_updateprimaryFingerprint";
            this.btn_updateprimaryFingerprint.Size = new System.Drawing.Size(201, 37);
            this.btn_updateprimaryFingerprint.TabIndex = 23;
            this.btn_updateprimaryFingerprint.Text = "UPDATE FINGERPINT";
            // 
            // btn_updatesecondaryFingerprint
            // 
            this.btn_updatesecondaryFingerprint.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_updatesecondaryFingerprint.Animated = true;
            this.btn_updatesecondaryFingerprint.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_updatesecondaryFingerprint.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_updatesecondaryFingerprint.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_updatesecondaryFingerprint.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_updatesecondaryFingerprint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_updatesecondaryFingerprint.FillColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_updatesecondaryFingerprint.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updatesecondaryFingerprint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.btn_updatesecondaryFingerprint.Location = new System.Drawing.Point(777, 463);
            this.btn_updatesecondaryFingerprint.Name = "btn_updatesecondaryFingerprint";
            this.btn_updatesecondaryFingerprint.Size = new System.Drawing.Size(201, 37);
            this.btn_updatesecondaryFingerprint.TabIndex = 25;
            this.btn_updatesecondaryFingerprint.Text = "UPDATE FINGERPINT";
            // 
            // pb_secondaryFingerprint
            // 
            this.pb_secondaryFingerprint.ImageRotate = 0F;
            this.pb_secondaryFingerprint.Location = new System.Drawing.Point(802, 249);
            this.pb_secondaryFingerprint.Name = "pb_secondaryFingerprint";
            this.pb_secondaryFingerprint.Size = new System.Drawing.Size(150, 150);
            this.pb_secondaryFingerprint.TabIndex = 24;
            this.pb_secondaryFingerprint.TabStop = false;
            // 
            // guna2VSeparator2
            // 
            this.guna2VSeparator2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.guna2VSeparator2.FillThickness = 2;
            this.guna2VSeparator2.Location = new System.Drawing.Point(690, 227);
            this.guna2VSeparator2.Name = "guna2VSeparator2";
            this.guna2VSeparator2.Size = new System.Drawing.Size(10, 297);
            this.guna2VSeparator2.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(414, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 21);
            this.label2.TabIndex = 27;
            this.label2.Text = "PRIMARY FINGERPRINT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(768, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 21);
            this.label3.TabIndex = 28;
            this.label3.Text = "SECONDARY FINGERPRINT";
            // 
            // guna2Button3
            // 
            this.guna2Button3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.guna2Button3.Animated = true;
            this.guna2Button3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(100)))));
            this.guna2Button3.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(48)))));
            this.guna2Button3.Location = new System.Drawing.Point(854, 560);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(207, 49);
            this.guna2Button3.TabIndex = 29;
            this.guna2Button3.Text = "BACK";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(1026, 610);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2VSeparator2);
            this.Controls.Add(this.btn_updatesecondaryFingerprint);
            this.Controls.Add(this.pb_secondaryFingerprint);
            this.Controls.Add(this.btn_updateprimaryFingerprint);
            this.Controls.Add(this.pb_primaryFingerprint);
            this.Controls.Add(this.btn_updatePin);
            this.Controls.Add(this.txt_newPin);
            this.Controls.Add(this.txt_retypeNewPin);
            this.Controls.Add(this.txt_oldPin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.guna2VSeparator1);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_primaryFingerprint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_secondaryFingerprint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_time;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txt_oldPin;
        private Guna.UI2.WinForms.Guna2TextBox txt_retypeNewPin;
        private Guna.UI2.WinForms.Guna2TextBox txt_newPin;
        private Guna.UI2.WinForms.Guna2Button btn_updatePin;
        private Guna.UI2.WinForms.Guna2PictureBox pb_primaryFingerprint;
        private Guna.UI2.WinForms.Guna2Button btn_updateprimaryFingerprint;
        private Guna.UI2.WinForms.Guna2Button btn_updatesecondaryFingerprint;
        private Guna.UI2.WinForms.Guna2PictureBox pb_secondaryFingerprint;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
    }
}