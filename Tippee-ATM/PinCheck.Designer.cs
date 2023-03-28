namespace Tippee_ATM
{
    partial class PinCheck
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
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_pin = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Franklin Gothic Medium", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(293, 273);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(440, 83);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "Enter Your Pin :";
            // 
            // txt_pin
            // 
            this.txt_pin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_pin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_pin.BorderColor = System.Drawing.Color.Black;
            this.txt_pin.BorderThickness = 3;
            this.txt_pin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_pin.DefaultText = "";
            this.txt_pin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_pin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_pin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_pin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_pin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_pin.Font = new System.Drawing.Font("Franklin Gothic Medium", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_pin.Location = new System.Drawing.Point(213, 430);
            this.txt_pin.Margin = new System.Windows.Forms.Padding(9);
            this.txt_pin.Name = "txt_pin";
            this.txt_pin.PasswordChar = '\0';
            this.txt_pin.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_pin.PlaceholderText = "";
            this.txt_pin.SelectedText = "";
            this.txt_pin.Size = new System.Drawing.Size(600, 103);
            this.txt_pin.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_pin.TabIndex = 1;
            this.txt_pin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_pin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_pin_KeyDown);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(240)))), ((int)(((byte)(223)))));
            this.guna2Panel1.BackgroundImage = global::Tippee_ATM.Properties.Resources.Tippee_Logo_Header;
            this.guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2Panel1.Location = new System.Drawing.Point(-2, -1);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1029, 134);
            this.guna2Panel1.TabIndex = 5;
            // 
            // PinCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(239)))), ((int)(((byte)(221)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1026, 610);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.txt_pin);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PinCheck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PinCheck";
            this.Load += new System.EventHandler(this.PinCheck_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txt_pin;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}