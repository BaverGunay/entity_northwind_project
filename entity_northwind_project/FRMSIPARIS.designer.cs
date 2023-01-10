namespace entity_northwind_project
{
    partial class FRMSIPARIS
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comMUS = new System.Windows.Forms.ComboBox();
            this.comPER = new System.Windows.Forms.ComboBox();
            this.btnSIL = new System.Windows.Forms.Button();
            this.btnYENI = new System.Windows.Forms.Button();
            this.btnEKLE = new System.Windows.Forms.Button();
            this.btnLIST = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 279);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 171);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "PERSONEL ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "MUSTERI ID";
            // 
            // comMUS
            // 
            this.comMUS.FormattingEnabled = true;
            this.comMUS.Location = new System.Drawing.Point(155, 31);
            this.comMUS.Name = "comMUS";
            this.comMUS.Size = new System.Drawing.Size(121, 21);
            this.comMUS.TabIndex = 3;
            // 
            // comPER
            // 
            this.comPER.FormattingEnabled = true;
            this.comPER.Location = new System.Drawing.Point(155, 88);
            this.comPER.Name = "comPER";
            this.comPER.Size = new System.Drawing.Size(121, 21);
            this.comPER.TabIndex = 4;
            // 
            // btnSIL
            // 
            this.btnSIL.BackColor = System.Drawing.Color.Gray;
            this.btnSIL.Location = new System.Drawing.Point(346, 154);
            this.btnSIL.Name = "btnSIL";
            this.btnSIL.Size = new System.Drawing.Size(93, 46);
            this.btnSIL.TabIndex = 18;
            this.btnSIL.Text = "SIL";
            this.btnSIL.UseVisualStyleBackColor = false;
            this.btnSIL.Click += new System.EventHandler(this.btnSIL_Click);
            // 
            // btnYENI
            // 
            this.btnYENI.BackColor = System.Drawing.Color.Gray;
            this.btnYENI.Location = new System.Drawing.Point(346, 91);
            this.btnYENI.Name = "btnYENI";
            this.btnYENI.Size = new System.Drawing.Size(93, 39);
            this.btnYENI.TabIndex = 17;
            this.btnYENI.Text = "YENI";
            this.btnYENI.UseVisualStyleBackColor = false;
            this.btnYENI.Click += new System.EventHandler(this.btnYENI_Click);
            // 
            // btnEKLE
            // 
            this.btnEKLE.BackColor = System.Drawing.Color.Gray;
            this.btnEKLE.Location = new System.Drawing.Point(346, 19);
            this.btnEKLE.Name = "btnEKLE";
            this.btnEKLE.Size = new System.Drawing.Size(93, 42);
            this.btnEKLE.TabIndex = 16;
            this.btnEKLE.Text = "EKLE";
            this.btnEKLE.UseVisualStyleBackColor = false;
            this.btnEKLE.Click += new System.EventHandler(this.btnEKLE_Click);
            // 
            // btnLIST
            // 
            this.btnLIST.BackColor = System.Drawing.Color.Gray;
            this.btnLIST.Location = new System.Drawing.Point(562, 154);
            this.btnLIST.Name = "btnLIST";
            this.btnLIST.Size = new System.Drawing.Size(93, 46);
            this.btnLIST.TabIndex = 15;
            this.btnLIST.Text = "LISTELE";
            this.btnLIST.UseVisualStyleBackColor = false;
            this.btnLIST.Click += new System.EventHandler(this.btnLIST_Click);
            // 
            // FRMSIPARIS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSIL);
            this.Controls.Add(this.btnYENI);
            this.Controls.Add(this.btnEKLE);
            this.Controls.Add(this.btnLIST);
            this.Controls.Add(this.comPER);
            this.Controls.Add(this.comMUS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FRMSIPARIS";
            this.Text = "FRMSIPARIS";
            this.Load += new System.EventHandler(this.FRMSIPARIS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comMUS;
        private System.Windows.Forms.ComboBox comPER;
        private System.Windows.Forms.Button btnSIL;
        private System.Windows.Forms.Button btnYENI;
        private System.Windows.Forms.Button btnEKLE;
        private System.Windows.Forms.Button btnLIST;
    }
}