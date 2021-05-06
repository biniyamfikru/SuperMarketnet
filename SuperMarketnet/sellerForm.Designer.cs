
namespace SuperMarketnet
{
    partial class sellerForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sellerPassTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.sellerDGV = new Guna.UI.WinForms.GunaDataGridView();
            this.delBt = new System.Windows.Forms.Button();
            this.editBt = new System.Windows.Forms.Button();
            this.addBt = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.sellerPhoneTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.sellerAgeTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.sellerNameTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.sellerIdTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sellBt = new System.Windows.Forms.Button();
            this.catBt = new System.Windows.Forms.Button();
            this.prodBt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sellerDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Controls.Add(this.sellerPassTb);
            this.panel1.Controls.Add(this.sellerDGV);
            this.panel1.Controls.Add(this.delBt);
            this.panel1.Controls.Add(this.editBt);
            this.panel1.Controls.Add(this.addBt);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.sellerPhoneTb);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.sellerAgeTb);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.sellerNameTb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.sellerIdTb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(100, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 380);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // sellerPassTb
            // 
            this.sellerPassTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sellerPassTb.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellerPassTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sellerPassTb.HintForeColor = System.Drawing.Color.Empty;
            this.sellerPassTb.HintText = "";
            this.sellerPassTb.isPassword = false;
            this.sellerPassTb.LineFocusedColor = System.Drawing.Color.DarkSlateGray;
            this.sellerPassTb.LineIdleColor = System.Drawing.Color.White;
            this.sellerPassTb.LineMouseHoverColor = System.Drawing.Color.DarkSlateGray;
            this.sellerPassTb.LineThickness = 4;
            this.sellerPassTb.Location = new System.Drawing.Point(118, 247);
            this.sellerPassTb.Margin = new System.Windows.Forms.Padding(4);
            this.sellerPassTb.Name = "sellerPassTb";
            this.sellerPassTb.Size = new System.Drawing.Size(176, 29);
            this.sellerPassTb.TabIndex = 14;
            this.sellerPassTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // sellerDGV
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.sellerDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.sellerDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sellerDGV.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.sellerDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sellerDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.sellerDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sellerDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.sellerDGV.ColumnHeadersHeight = 4;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.sellerDGV.DefaultCellStyle = dataGridViewCellStyle9;
            this.sellerDGV.EnableHeadersVisualStyles = false;
            this.sellerDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.sellerDGV.Location = new System.Drawing.Point(326, 77);
            this.sellerDGV.Name = "sellerDGV";
            this.sellerDGV.ReadOnly = true;
            this.sellerDGV.RowHeadersVisible = false;
            this.sellerDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sellerDGV.Size = new System.Drawing.Size(350, 234);
            this.sellerDGV.TabIndex = 13;
            this.sellerDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.sellerDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.sellerDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.sellerDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.sellerDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.sellerDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.sellerDGV.ThemeStyle.BackColor = System.Drawing.Color.DarkSlateGray;
            this.sellerDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.sellerDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.sellerDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.sellerDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.sellerDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.sellerDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.sellerDGV.ThemeStyle.HeaderStyle.Height = 4;
            this.sellerDGV.ThemeStyle.ReadOnly = true;
            this.sellerDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.sellerDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.sellerDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.sellerDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.sellerDGV.ThemeStyle.RowsStyle.Height = 22;
            this.sellerDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.sellerDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.sellerDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sellerDGV_CellContentClick);
            // 
            // delBt
            // 
            this.delBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delBt.Location = new System.Drawing.Point(242, 317);
            this.delBt.Name = "delBt";
            this.delBt.Size = new System.Drawing.Size(95, 29);
            this.delBt.TabIndex = 12;
            this.delBt.Text = "Delete";
            this.delBt.UseVisualStyleBackColor = true;
            this.delBt.Click += new System.EventHandler(this.delBt_Click);
            // 
            // editBt
            // 
            this.editBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBt.Location = new System.Drawing.Point(132, 317);
            this.editBt.Name = "editBt";
            this.editBt.Size = new System.Drawing.Size(95, 29);
            this.editBt.TabIndex = 11;
            this.editBt.Text = "Edit";
            this.editBt.UseVisualStyleBackColor = true;
            this.editBt.Click += new System.EventHandler(this.editBt_Click);
            // 
            // addBt
            // 
            this.addBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBt.Location = new System.Drawing.Point(15, 317);
            this.addBt.Name = "addBt";
            this.addBt.Size = new System.Drawing.Size(95, 29);
            this.addBt.TabIndex = 4;
            this.addBt.Text = "Add";
            this.addBt.UseVisualStyleBackColor = true;
            this.addBt.Click += new System.EventHandler(this.addBt_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Password";
            // 
            // sellerPhoneTb
            // 
            this.sellerPhoneTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sellerPhoneTb.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellerPhoneTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sellerPhoneTb.HintForeColor = System.Drawing.Color.Empty;
            this.sellerPhoneTb.HintText = "";
            this.sellerPhoneTb.isPassword = false;
            this.sellerPhoneTb.LineFocusedColor = System.Drawing.Color.DarkSlateGray;
            this.sellerPhoneTb.LineIdleColor = System.Drawing.Color.White;
            this.sellerPhoneTb.LineMouseHoverColor = System.Drawing.Color.DarkSlateGray;
            this.sellerPhoneTb.LineThickness = 4;
            this.sellerPhoneTb.Location = new System.Drawing.Point(118, 201);
            this.sellerPhoneTb.Margin = new System.Windows.Forms.Padding(4);
            this.sellerPhoneTb.Name = "sellerPhoneTb";
            this.sellerPhoneTb.Size = new System.Drawing.Size(176, 29);
            this.sellerPhoneTb.TabIndex = 8;
            this.sellerPhoneTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Phone";
            // 
            // sellerAgeTb
            // 
            this.sellerAgeTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sellerAgeTb.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellerAgeTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sellerAgeTb.HintForeColor = System.Drawing.Color.Empty;
            this.sellerAgeTb.HintText = "";
            this.sellerAgeTb.isPassword = false;
            this.sellerAgeTb.LineFocusedColor = System.Drawing.Color.DarkSlateGray;
            this.sellerAgeTb.LineIdleColor = System.Drawing.Color.White;
            this.sellerAgeTb.LineMouseHoverColor = System.Drawing.Color.DarkSlateGray;
            this.sellerAgeTb.LineThickness = 4;
            this.sellerAgeTb.Location = new System.Drawing.Point(118, 157);
            this.sellerAgeTb.Margin = new System.Windows.Forms.Padding(4);
            this.sellerAgeTb.Name = "sellerAgeTb";
            this.sellerAgeTb.Size = new System.Drawing.Size(176, 29);
            this.sellerAgeTb.TabIndex = 6;
            this.sellerAgeTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Age";
            // 
            // sellerNameTb
            // 
            this.sellerNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sellerNameTb.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellerNameTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sellerNameTb.HintForeColor = System.Drawing.Color.Empty;
            this.sellerNameTb.HintText = "";
            this.sellerNameTb.isPassword = false;
            this.sellerNameTb.LineFocusedColor = System.Drawing.Color.DarkSlateGray;
            this.sellerNameTb.LineIdleColor = System.Drawing.Color.White;
            this.sellerNameTb.LineMouseHoverColor = System.Drawing.Color.DarkSlateGray;
            this.sellerNameTb.LineThickness = 4;
            this.sellerNameTb.Location = new System.Drawing.Point(118, 110);
            this.sellerNameTb.Margin = new System.Windows.Forms.Padding(4);
            this.sellerNameTb.Name = "sellerNameTb";
            this.sellerNameTb.Size = new System.Drawing.Size(176, 29);
            this.sellerNameTb.TabIndex = 4;
            this.sellerNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name";
            // 
            // sellerIdTb
            // 
            this.sellerIdTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sellerIdTb.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellerIdTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sellerIdTb.HintForeColor = System.Drawing.Color.Empty;
            this.sellerIdTb.HintText = "";
            this.sellerIdTb.isPassword = false;
            this.sellerIdTb.LineFocusedColor = System.Drawing.Color.DarkSlateGray;
            this.sellerIdTb.LineIdleColor = System.Drawing.Color.White;
            this.sellerIdTb.LineMouseHoverColor = System.Drawing.Color.DarkSlateGray;
            this.sellerIdTb.LineThickness = 4;
            this.sellerIdTb.Location = new System.Drawing.Point(118, 58);
            this.sellerIdTb.Margin = new System.Windows.Forms.Padding(6);
            this.sellerIdTb.Name = "sellerIdTb";
            this.sellerIdTb.Size = new System.Drawing.Size(176, 30);
            this.sellerIdTb.TabIndex = 2;
            this.sellerIdTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(236, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Sellers";
            // 
            // sellBt
            // 
            this.sellBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellBt.Location = new System.Drawing.Point(2, 192);
            this.sellBt.Name = "sellBt";
            this.sellBt.Size = new System.Drawing.Size(95, 29);
            this.sellBt.TabIndex = 6;
            this.sellBt.Text = "Selling";
            this.sellBt.UseVisualStyleBackColor = true;
            // 
            // catBt
            // 
            this.catBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catBt.Location = new System.Drawing.Point(2, 146);
            this.catBt.Name = "catBt";
            this.catBt.Size = new System.Drawing.Size(95, 29);
            this.catBt.TabIndex = 5;
            this.catBt.Text = "Categories";
            this.catBt.UseVisualStyleBackColor = true;
            // 
            // prodBt
            // 
            this.prodBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodBt.Location = new System.Drawing.Point(2, 99);
            this.prodBt.Name = "prodBt";
            this.prodBt.Size = new System.Drawing.Size(95, 29);
            this.prodBt.TabIndex = 4;
            this.prodBt.Text = "Products";
            this.prodBt.UseVisualStyleBackColor = true;
            this.prodBt.Click += new System.EventHandler(this.prodBt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(772, -3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "x";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // sellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sellBt);
            this.Controls.Add(this.catBt);
            this.Controls.Add(this.prodBt);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "sellerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sellerForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sellerDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaDataGridView sellerDGV;
        private System.Windows.Forms.Button delBt;
        private System.Windows.Forms.Button editBt;
        private System.Windows.Forms.Button addBt;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox sellerPhoneTb;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox sellerAgeTb;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox sellerNameTb;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox sellerIdTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sellBt;
        private System.Windows.Forms.Button catBt;
        private System.Windows.Forms.Button prodBt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox sellerPassTb;
        private System.Windows.Forms.Label label2;
    }
}