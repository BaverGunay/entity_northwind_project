namespace entity_northwind_project
{
    partial class FRMMUSTERI
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
            this.btnSIL = new System.Windows.Forms.Button();
            this.btnYENI = new System.Windows.Forms.Button();
            this.btnEKLE = new System.Windows.Forms.Button();
            this.btnLIST = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtULKE = new System.Windows.Forms.TextBox();
            this.txtSEHIR = new System.Windows.Forms.TextBox();
            this.txtADRES = new System.Windows.Forms.TextBox();
            this.txtYTKL = new System.Windows.Forms.TextBox();
            this.txtAD = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSIL
            // 
            this.btnSIL.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSIL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSIL.Location = new System.Drawing.Point(329, 95);
            this.btnSIL.Name = "btnSIL";
            this.btnSIL.Size = new System.Drawing.Size(93, 55);
            this.btnSIL.TabIndex = 29;
            this.btnSIL.Text = "SIL";
            this.btnSIL.UseVisualStyleBackColor = false;
            this.btnSIL.Click += new System.EventHandler(this.btnSIL_Click);
            // 
            // btnYENI
            // 
            this.btnYENI.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnYENI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYENI.Location = new System.Drawing.Point(329, 184);
            this.btnYENI.Name = "btnYENI";
            this.btnYENI.Size = new System.Drawing.Size(93, 55);
            this.btnYENI.TabIndex = 28;
            this.btnYENI.Text = "YENI";
            this.btnYENI.UseVisualStyleBackColor = false;
            this.btnYENI.Click += new System.EventHandler(this.btnYENI_Click);
            // 
            // btnEKLE
            // 
            this.btnEKLE.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnEKLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEKLE.Location = new System.Drawing.Point(329, 11);
            this.btnEKLE.Name = "btnEKLE";
            this.btnEKLE.Size = new System.Drawing.Size(93, 55);
            this.btnEKLE.TabIndex = 27;
            this.btnEKLE.Text = "EKLE";
            this.btnEKLE.UseVisualStyleBackColor = false;
            this.btnEKLE.Click += new System.EventHandler(this.btnEKLE_Click);
            // 
            // btnLIST
            // 
            this.btnLIST.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnLIST.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLIST.Location = new System.Drawing.Point(626, 184);
            this.btnLIST.Name = "btnLIST";
            this.btnLIST.Size = new System.Drawing.Size(89, 55);
            this.btnLIST.TabIndex = 26;
            this.btnLIST.Text = "LISTELE";
            this.btnLIST.UseVisualStyleBackColor = false;
            this.btnLIST.Click += new System.EventHandler(this.btnLIST_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(50, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "ULKE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(50, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "SEHIR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(50, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "ADRES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(50, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "YETKILI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(50, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "MUSTERI ADI";
            // 
            // txtULKE
            // 
            this.txtULKE.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtULKE.Location = new System.Drawing.Point(168, 215);
            this.txtULKE.Name = "txtULKE";
            this.txtULKE.Size = new System.Drawing.Size(100, 20);
            this.txtULKE.TabIndex = 20;
            // 
            // txtSEHIR
            // 
            this.txtSEHIR.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtSEHIR.Location = new System.Drawing.Point(168, 164);
            this.txtSEHIR.Name = "txtSEHIR";
            this.txtSEHIR.Size = new System.Drawing.Size(100, 20);
            this.txtSEHIR.TabIndex = 19;
            // 
            // txtADRES
            // 
            this.txtADRES.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtADRES.Location = new System.Drawing.Point(168, 114);
            this.txtADRES.Name = "txtADRES";
            this.txtADRES.Size = new System.Drawing.Size(100, 20);
            this.txtADRES.TabIndex = 18;
            // 
            // txtYTKL
            // 
            this.txtYTKL.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtYTKL.Location = new System.Drawing.Point(168, 64);
            this.txtYTKL.Name = "txtYTKL";
            this.txtYTKL.Size = new System.Drawing.Size(100, 20);
            this.txtYTKL.TabIndex = 17;
            // 
            // txtAD
            // 
            this.txtAD.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtAD.Location = new System.Drawing.Point(168, 11);
            this.txtAD.Name = "txtAD";
            this.txtAD.Size = new System.Drawing.Size(100, 20);
            this.txtAD.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 284);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 166);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // FRMMUSTERI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSIL);
            this.Controls.Add(this.btnYENI);
            this.Controls.Add(this.btnEKLE);
            this.Controls.Add(this.btnLIST);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtULKE);
            this.Controls.Add(this.txtSEHIR);
            this.Controls.Add(this.txtADRES);
            this.Controls.Add(this.txtYTKL);
            this.Controls.Add(this.txtAD);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FRMMUSTERI";
            this.Text = "Musteriler";
            this.Load += new System.EventHandler(this.Form49_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSIL;
        private System.Windows.Forms.Button btnYENI;
        private System.Windows.Forms.Button btnEKLE;
        private System.Windows.Forms.Button btnLIST;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtULKE;
        private System.Windows.Forms.TextBox txtSEHIR;
        private System.Windows.Forms.TextBox txtADRES;
        private System.Windows.Forms.TextBox txtYTKL;
        private System.Windows.Forms.TextBox txtAD;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}