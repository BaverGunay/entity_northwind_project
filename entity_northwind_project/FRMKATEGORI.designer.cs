namespace entity_northwind_project
{
    partial class FRMKATEGORI
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKTGRAD = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSIL
            // 
            this.btnSIL.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSIL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSIL.Location = new System.Drawing.Point(338, 109);
            this.btnSIL.Name = "btnSIL";
            this.btnSIL.Size = new System.Drawing.Size(117, 71);
            this.btnSIL.TabIndex = 33;
            this.btnSIL.Text = "SIL";
            this.btnSIL.UseVisualStyleBackColor = false;
            this.btnSIL.Click += new System.EventHandler(this.btnSIL_Click);
            // 
            // btnYENI
            // 
            this.btnYENI.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnYENI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYENI.Location = new System.Drawing.Point(473, 109);
            this.btnYENI.Name = "btnYENI";
            this.btnYENI.Size = new System.Drawing.Size(117, 71);
            this.btnYENI.TabIndex = 32;
            this.btnYENI.Text = "YENI";
            this.btnYENI.UseVisualStyleBackColor = false;
            this.btnYENI.Click += new System.EventHandler(this.btnYENI_Click);
            // 
            // btnEKLE
            // 
            this.btnEKLE.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnEKLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEKLE.Location = new System.Drawing.Point(167, 109);
            this.btnEKLE.Name = "btnEKLE";
            this.btnEKLE.Size = new System.Drawing.Size(117, 71);
            this.btnEKLE.TabIndex = 31;
            this.btnEKLE.Text = "EKLE";
            this.btnEKLE.UseVisualStyleBackColor = false;
            this.btnEKLE.Click += new System.EventHandler(this.btnEKLE_Click);
            // 
            // btnLIST
            // 
            this.btnLIST.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnLIST.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLIST.Location = new System.Drawing.Point(338, 208);
            this.btnLIST.Name = "btnLIST";
            this.btnLIST.Size = new System.Drawing.Size(117, 69);
            this.btnLIST.TabIndex = 30;
            this.btnLIST.Text = "LISTELE";
            this.btnLIST.UseVisualStyleBackColor = false;
            this.btnLIST.Click += new System.EventHandler(this.btnLIST_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 284);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 166);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "KATEGORİ ADI";
            // 
            // txtKTGRAD
            // 
            this.txtKTGRAD.Location = new System.Drawing.Point(411, 34);
            this.txtKTGRAD.Name = "txtKTGRAD";
            this.txtKTGRAD.Size = new System.Drawing.Size(100, 20);
            this.txtKTGRAD.TabIndex = 36;
            // 
            // FRMKATEGORI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtKTGRAD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSIL);
            this.Controls.Add(this.btnYENI);
            this.Controls.Add(this.btnEKLE);
            this.Controls.Add(this.btnLIST);
            this.Name = "FRMKATEGORI";
            this.Text = "Kategori";
            this.Load += new System.EventHandler(this.Form50_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSIL;
        private System.Windows.Forms.Button btnYENI;
        private System.Windows.Forms.Button btnEKLE;
        private System.Windows.Forms.Button btnLIST;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKTGRAD;
    }
}