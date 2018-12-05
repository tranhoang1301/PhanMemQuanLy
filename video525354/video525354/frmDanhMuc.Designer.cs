namespace video525354
{
    partial class frmDanhMuc
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstDsDM = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaDM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenDm = new System.Windows.Forms.TextBox();
            this.btnXoaDM = new System.Windows.Forms.Button();
            this.btnLuuDM = new System.Windows.Forms.Button();
            this.btnDongDM = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 221);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstDsDM);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(238, 221);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách danh mục";
            // 
            // lstDsDM
            // 
            this.lstDsDM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstDsDM.FormattingEnabled = true;
            this.lstDsDM.ItemHeight = 25;
            this.lstDsDM.Location = new System.Drawing.Point(6, 29);
            this.lstDsDM.Name = "lstDsDM";
            this.lstDsDM.Size = new System.Drawing.Size(226, 186);
            this.lstDsDM.TabIndex = 0;
            this.lstDsDM.SelectedIndexChanged += new System.EventHandler(this.lstDsDM_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã DM";
            // 
            // txtMaDM
            // 
            this.txtMaDM.Location = new System.Drawing.Point(374, 34);
            this.txtMaDM.Margin = new System.Windows.Forms.Padding(6);
            this.txtMaDM.Name = "txtMaDM";
            this.txtMaDM.Size = new System.Drawing.Size(196, 30);
            this.txtMaDM.TabIndex = 2;
            this.txtMaDM.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên DM";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtTenDm
            // 
            this.txtTenDm.Location = new System.Drawing.Point(374, 97);
            this.txtTenDm.Margin = new System.Windows.Forms.Padding(6);
            this.txtTenDm.Name = "txtTenDm";
            this.txtTenDm.Size = new System.Drawing.Size(190, 30);
            this.txtTenDm.TabIndex = 4;
            // 
            // btnXoaDM
            // 
            this.btnXoaDM.Location = new System.Drawing.Point(391, 168);
            this.btnXoaDM.Name = "btnXoaDM";
            this.btnXoaDM.Size = new System.Drawing.Size(97, 36);
            this.btnXoaDM.TabIndex = 5;
            this.btnXoaDM.Text = "Xóa";
            this.btnXoaDM.UseVisualStyleBackColor = true;
            this.btnXoaDM.Click += new System.EventHandler(this.btnXoaDM_Click);
            // 
            // btnLuuDM
            // 
            this.btnLuuDM.Location = new System.Drawing.Point(263, 168);
            this.btnLuuDM.Name = "btnLuuDM";
            this.btnLuuDM.Size = new System.Drawing.Size(97, 36);
            this.btnLuuDM.TabIndex = 5;
            this.btnLuuDM.Text = "Lưu";
            this.btnLuuDM.UseVisualStyleBackColor = true;
            this.btnLuuDM.Click += new System.EventHandler(this.btnLuuDM_Click);
            // 
            // btnDongDM
            // 
            this.btnDongDM.Location = new System.Drawing.Point(516, 168);
            this.btnDongDM.Name = "btnDongDM";
            this.btnDongDM.Size = new System.Drawing.Size(82, 36);
            this.btnDongDM.TabIndex = 6;
            this.btnDongDM.Text = "Đóng";
            this.btnDongDM.UseVisualStyleBackColor = true;
            this.btnDongDM.Click += new System.EventHandler(this.btnDongDM_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmDanhMuc
            // 
            this.AcceptButton = this.btnLuuDM;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnDongDM;
            this.ClientSize = new System.Drawing.Size(616, 221);
            this.Controls.Add(this.btnDongDM);
            this.Controls.Add(this.btnLuuDM);
            this.Controls.Add(this.btnXoaDM);
            this.Controls.Add(this.txtTenDm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaDM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmDanhMuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmDanhMuc";
            this.Load += new System.EventHandler(this.frmDanhMuc_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaDM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenDm;
        private System.Windows.Forms.Button btnXoaDM;
        private System.Windows.Forms.Button btnLuuDM;
        private System.Windows.Forms.Button btnDongDM;
        private System.Windows.Forms.ListBox lstDsDM;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}