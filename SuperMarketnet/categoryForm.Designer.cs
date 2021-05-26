
namespace SuperMarketnet
{
    partial class categoryForm
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
            this.CatDGV = new Guna.UI.WinForms.GunaDataGridView();
            this.CatDelBt = new System.Windows.Forms.Button();
            this.CatEditBt = new System.Windows.Forms.Button();
            this.CatAddBt = new System.Windows.Forms.Button();
            this.CatDescTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.CatNameTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.CatIdTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CatDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Controls.Add(this.CatDGV);
            this.panel1.Controls.Add(this.CatDelBt);
            this.panel1.Controls.Add(this.CatEditBt);
            this.panel1.Controls.Add(this.CatAddBt);
            this.panel1.Controls.Add(this.CatDescTb);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.CatNameTb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.CatIdTb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(100, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 380);
            this.panel1.TabIndex = 2;
            // 
            // CatDGV
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.CatDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.CatDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CatDGV.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.CatDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CatDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CatDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CatDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.CatDGV.ColumnHeadersHeight = 30;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CatDGV.DefaultCellStyle = dataGridViewCellStyle9;
            this.CatDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.CatDGV.EnableHeadersVisualStyles = false;
            this.CatDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CatDGV.Location = new System.Drawing.Point(326, 77);
            this.CatDGV.Name = "CatDGV";
            this.CatDGV.ReadOnly = true;
            this.CatDGV.RowHeadersVisible = false;
            this.CatDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CatDGV.Size = new System.Drawing.Size(350, 234);
            this.CatDGV.TabIndex = 13;
            this.CatDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.CatDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.CatDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.CatDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.CatDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.CatDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.CatDGV.ThemeStyle.BackColor = System.Drawing.Color.DarkSlateGray;
            this.CatDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CatDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Green;
            this.CatDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CatDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CatDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.CatDGV.ThemeStyle.HeaderStyle.Height = 30;
            this.CatDGV.ThemeStyle.ReadOnly = true;
            this.CatDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CatDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CatDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.CatDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CatDGV.ThemeStyle.RowsStyle.Height = 22;
            this.CatDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CatDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CatDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CatDGV_CellContentClick);
            // 
            // CatDelBt
            // 
            this.CatDelBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatDelBt.Location = new System.Drawing.Point(213, 215);
            this.CatDelBt.Name = "CatDelBt";
            this.CatDelBt.Size = new System.Drawing.Size(95, 29);
            this.CatDelBt.TabIndex = 12;
            this.CatDelBt.Text = "Delete";
            this.CatDelBt.UseVisualStyleBackColor = true;
            this.CatDelBt.Click += new System.EventHandler(this.CatDelBt_Click);
            // 
            // CatEditBt
            // 
            this.CatEditBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatEditBt.Location = new System.Drawing.Point(112, 215);
            this.CatEditBt.Name = "CatEditBt";
            this.CatEditBt.Size = new System.Drawing.Size(95, 29);
            this.CatEditBt.TabIndex = 11;
            this.CatEditBt.Text = "Edit";
            this.CatEditBt.UseVisualStyleBackColor = true;
            this.CatEditBt.Click += new System.EventHandler(this.CatEditBt_Click);
            // 
            // CatAddBt
            // 
            this.CatAddBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatAddBt.Location = new System.Drawing.Point(11, 215);
            this.CatAddBt.Name = "CatAddBt";
            this.CatAddBt.Size = new System.Drawing.Size(95, 29);
            this.CatAddBt.TabIndex = 4;
            this.CatAddBt.Text = "Add";
            this.CatAddBt.UseVisualStyleBackColor = true;
            this.CatAddBt.Click += new System.EventHandler(this.CatAddBt_Click);
            // 
            // CatDescTb
            // 
            this.CatDescTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CatDescTb.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatDescTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CatDescTb.HintForeColor = System.Drawing.Color.Empty;
            this.CatDescTb.HintText = "";
            this.CatDescTb.isPassword = false;
            this.CatDescTb.LineFocusedColor = System.Drawing.Color.DarkSlateGray;
            this.CatDescTb.LineIdleColor = System.Drawing.Color.White;
            this.CatDescTb.LineMouseHoverColor = System.Drawing.Color.DarkSlateGray;
            this.CatDescTb.LineThickness = 4;
            this.CatDescTb.Location = new System.Drawing.Point(132, 157);
            this.CatDescTb.Margin = new System.Windows.Forms.Padding(4);
            this.CatDescTb.Name = "CatDescTb";
            this.CatDescTb.Size = new System.Drawing.Size(176, 29);
            this.CatDescTb.TabIndex = 6;
            this.CatDescTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Description";
            // 
            // CatNameTb
            // 
            this.CatNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CatNameTb.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatNameTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CatNameTb.HintForeColor = System.Drawing.Color.Empty;
            this.CatNameTb.HintText = "";
            this.CatNameTb.isPassword = false;
            this.CatNameTb.LineFocusedColor = System.Drawing.Color.DarkSlateGray;
            this.CatNameTb.LineIdleColor = System.Drawing.Color.White;
            this.CatNameTb.LineMouseHoverColor = System.Drawing.Color.DarkSlateGray;
            this.CatNameTb.LineThickness = 4;
            this.CatNameTb.Location = new System.Drawing.Point(132, 110);
            this.CatNameTb.Margin = new System.Windows.Forms.Padding(4);
            this.CatNameTb.Name = "CatNameTb";
            this.CatNameTb.Size = new System.Drawing.Size(176, 29);
            this.CatNameTb.TabIndex = 4;
            this.CatNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            // CatIdTb
            // 
            this.CatIdTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CatIdTb.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatIdTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CatIdTb.HintForeColor = System.Drawing.Color.Empty;
            this.CatIdTb.HintText = "";
            this.CatIdTb.isPassword = false;
            this.CatIdTb.LineFocusedColor = System.Drawing.Color.DarkSlateGray;
            this.CatIdTb.LineIdleColor = System.Drawing.Color.White;
            this.CatIdTb.LineMouseHoverColor = System.Drawing.Color.DarkSlateGray;
            this.CatIdTb.LineThickness = 4;
            this.CatIdTb.Location = new System.Drawing.Point(132, 58);
            this.CatIdTb.Margin = new System.Windows.Forms.Padding(6);
            this.CatIdTb.Name = "CatIdTb";
            this.CatIdTb.Size = new System.Drawing.Size(176, 30);
            this.CatIdTb.TabIndex = 2;
            this.CatIdTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.label1.Size = new System.Drawing.Size(285, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Categories";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(773, -4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "x";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(-1, 146);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 29);
            this.button2.TabIndex = 15;
            this.button2.Text = "Products";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(-1, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 29);
            this.button1.TabIndex = 14;
            this.button1.Text = "Seller";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(35, 400);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 39;
            this.label6.Text = "Logout";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // categoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "categoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "categoryForm";
            this.Load += new System.EventHandler(this.categoryForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CatDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaDataGridView CatDGV;
        private System.Windows.Forms.Button CatDelBt;
        private System.Windows.Forms.Button CatEditBt;
        private System.Windows.Forms.Button CatAddBt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CatDescTb;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CatNameTb;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CatIdTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
    }
}