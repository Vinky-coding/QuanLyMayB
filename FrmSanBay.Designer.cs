namespace QuanLiSanBay
{
    partial class FrmSanBay
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
            this.dgvMaybay = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMamb = new System.Windows.Forms.TextBox();
            this.txtTenmb = new System.Windows.Forms.TextBox();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.txtSogio = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaybay)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMaybay
            // 
            this.dgvMaybay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaybay.Location = new System.Drawing.Point(12, 24);
            this.dgvMaybay.Name = "dgvMaybay";
            this.dgvMaybay.RowHeadersWidth = 51;
            this.dgvMaybay.RowTemplate.Height = 24;
            this.dgvMaybay.Size = new System.Drawing.Size(878, 339);
            this.dgvMaybay.TabIndex = 0;
            this.dgvMaybay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(771, 525);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Lam moi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = " Ma may bay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 476);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = " Ten may bay";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(532, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = " Nam san xuat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(532, 476);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = " So gio bay";
            // 
            // txtMamb
            // 
            this.txtMamb.Location = new System.Drawing.Point(159, 416);
            this.txtMamb.Name = "txtMamb";
            this.txtMamb.Size = new System.Drawing.Size(214, 22);
            this.txtMamb.TabIndex = 6;
            // 
            // txtTenmb
            // 
            this.txtTenmb.Location = new System.Drawing.Point(159, 470);
            this.txtTenmb.Name = "txtTenmb";
            this.txtTenmb.Size = new System.Drawing.Size(210, 22);
            this.txtTenmb.TabIndex = 7;
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(657, 410);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(189, 22);
            this.txtNam.TabIndex = 8;
            // 
            // txtSogio
            // 
            this.txtSogio.Location = new System.Drawing.Point(657, 476);
            this.txtSogio.Name = "txtSogio";
            this.txtSogio.Size = new System.Drawing.Size(189, 22);
            this.txtSogio.TabIndex = 9;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(74, 525);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(140, 26);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Them";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 573);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtSogio);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.txtTenmb);
            this.Controls.Add(this.txtMamb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvMaybay);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaybay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMaybay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMamb;
        private System.Windows.Forms.TextBox txtTenmb;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.TextBox txtSogio;
        private System.Windows.Forms.Button btnThem;
    }
}

