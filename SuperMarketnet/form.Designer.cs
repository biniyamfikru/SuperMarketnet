
namespace SuperMarketnet
{
    partial class form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form));
            this.label1 = new System.Windows.Forms.Label();
            this.roleCb = new System.Windows.Forms.ComboBox();
            this.UNameTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.PassTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.loginBt = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(61, 91);
            this.label1.MinimumSize = new System.Drawing.Size(250, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 250);
            this.label1.TabIndex = 0;
            this.label1.Text = "Soonsan\r\nSuperMarket";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roleCb
            // 
            this.roleCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleCb.FormattingEnabled = true;
            this.roleCb.Items.AddRange(new object[] {
            "Admin",
            "Seller"});
            this.roleCb.Location = new System.Drawing.Point(452, 91);
            this.roleCb.Name = "roleCb";
            this.roleCb.Size = new System.Drawing.Size(208, 24);
            this.roleCb.TabIndex = 1;
            this.roleCb.Text = "Select Role";
            // 
            // UNameTb
            // 
            this.UNameTb.BackColor = System.Drawing.Color.White;
            this.UNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UNameTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.UNameTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UNameTb.HintForeColor = System.Drawing.Color.Empty;
            this.UNameTb.HintText = "";
            this.UNameTb.isPassword = false;
            this.UNameTb.LineFocusedColor = System.Drawing.Color.Blue;
            this.UNameTb.LineIdleColor = System.Drawing.Color.Black;
            this.UNameTb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.UNameTb.LineThickness = 3;
            this.UNameTb.Location = new System.Drawing.Point(504, 151);
            this.UNameTb.Margin = new System.Windows.Forms.Padding(4);
            this.UNameTb.Name = "UNameTb";
            this.UNameTb.Size = new System.Drawing.Size(268, 33);
            this.UNameTb.TabIndex = 2;
            this.UNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // PassTb
            // 
            this.PassTb.BackColor = System.Drawing.Color.White;
            this.PassTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PassTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.PassTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PassTb.HintForeColor = System.Drawing.Color.Empty;
            this.PassTb.HintText = "";
            this.PassTb.isPassword = true;
            this.PassTb.LineFocusedColor = System.Drawing.Color.Blue;
            this.PassTb.LineIdleColor = System.Drawing.Color.Black;
            this.PassTb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.PassTb.LineThickness = 3;
            this.PassTb.Location = new System.Drawing.Point(504, 220);
            this.PassTb.Margin = new System.Windows.Forms.Padding(4);
            this.PassTb.Name = "PassTb";
            this.PassTb.Size = new System.Drawing.Size(268, 33);
            this.PassTb.TabIndex = 3;
            this.PassTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSlateGray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(334, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSlateGray;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(334, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(769, -2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "x";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // loginBt
            // 
            this.loginBt.ActiveBorderThickness = 1;
            this.loginBt.ActiveCornerRadius = 20;
            this.loginBt.ActiveFillColor = System.Drawing.Color.White;
            this.loginBt.ActiveForecolor = System.Drawing.Color.SeaGreen;
            this.loginBt.ActiveLineColor = System.Drawing.Color.White;
            this.loginBt.BackColor = System.Drawing.Color.DarkSlateGray;
            this.loginBt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginBt.BackgroundImage")));
            this.loginBt.ButtonText = "Login";
            this.loginBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBt.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBt.ForeColor = System.Drawing.Color.White;
            this.loginBt.IdleBorderThickness = 1;
            this.loginBt.IdleCornerRadius = 20;
            this.loginBt.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.loginBt.IdleForecolor = System.Drawing.Color.White;
            this.loginBt.IdleLineColor = System.Drawing.Color.White;
            this.loginBt.Location = new System.Drawing.Point(440, 300);
            this.loginBt.Margin = new System.Windows.Forms.Padding(5);
            this.loginBt.Name = "loginBt";
            this.loginBt.Size = new System.Drawing.Size(208, 55);
            this.loginBt.TabIndex = 4;
            this.loginBt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginBt.Click += new System.EventHandler(this.loginBt_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(517, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Clear";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loginBt);
            this.Controls.Add(this.PassTb);
            this.Controls.Add(this.UNameTb);
            this.Controls.Add(this.roleCb);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Soonsan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox roleCb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox UNameTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PassTb;
        private Bunifu.Framework.UI.BunifuThinButton2 loginBt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

