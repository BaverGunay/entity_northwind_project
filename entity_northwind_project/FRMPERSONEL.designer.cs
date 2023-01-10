namespace entity_northwind_project
{
    partial class FRMPERSONEL
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
            this.TxtDGYR = new System.Windows.Forms.TextBox();
            this.BtnTMZL = new System.Windows.Forms.Button();
            this.BtnSIL = new System.Windows.Forms.Button();
            this.BtnEKLE = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ComCINSIYET = new System.Windows.Forms.ComboBox();
            this.TxtSOYAD = new System.Windows.Forms.TextBox();
            this.TxtAD = new System.Windows.Forms.TextBox();
            this.TxtTCKN = new System.Windows.Forms.TextBox();
            this.BtnList = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtDGYR
            // 
            this.TxtDGYR.Location = new System.Drawing.Point(132, 173);
            this.TxtDGYR.Name = "TxtDGYR";
            this.TxtDGYR.Size = new System.Drawing.Size(100, 20);
            this.TxtDGYR.TabIndex = 30;
            // 
            // BtnTMZL
            // 
            this.BtnTMZL.BackColor = System.Drawing.Color.Azure;
            this.BtnTMZL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTMZL.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnTMZL.Location = new System.Drawing.Point(325, 170);
            this.BtnTMZL.Name = "BtnTMZL";
            this.BtnTMZL.Size = new System.Drawing.Size(117, 44);
            this.BtnTMZL.TabIndex = 29;
            this.BtnTMZL.Text = "YENI";
            this.BtnTMZL.UseVisualStyleBackColor = false;
            this.BtnTMZL.Click += new System.EventHandler(this.BtnTMZL_Click);
            // 
            // BtnSIL
            // 
            this.BtnSIL.BackColor = System.Drawing.Color.Azure;
            this.BtnSIL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSIL.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnSIL.Location = new System.Drawing.Point(325, 92);
            this.BtnSIL.Name = "BtnSIL";
            this.BtnSIL.Size = new System.Drawing.Size(117, 44);
            this.BtnSIL.TabIndex = 28;
            this.BtnSIL.Text = "SIL";
            this.BtnSIL.UseVisualStyleBackColor = false;
            this.BtnSIL.Click += new System.EventHandler(this.BtnSIL_Click);
            // 
            // BtnEKLE
            // 
            this.BtnEKLE.BackColor = System.Drawing.Color.Azure;
            this.BtnEKLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEKLE.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnEKLE.Location = new System.Drawing.Point(325, 13);
            this.BtnEKLE.Name = "BtnEKLE";
            this.BtnEKLE.Size = new System.Drawing.Size(117, 44);
            this.BtnEKLE.TabIndex = 27;
            this.BtnEKLE.Text = "EKLE";
            this.BtnEKLE.UseVisualStyleBackColor = false;
            this.BtnEKLE.Click += new System.EventHandler(this.BtnEKLE_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "DOGUM YERI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "CINSIYET";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "SOYAD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "AD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "TCKN";
            // 
            // ComCINSIYET
            // 
            this.ComCINSIYET.FormattingEnabled = true;
            this.ComCINSIYET.Items.AddRange(new object[] {
            "E",
            "K"});
            this.ComCINSIYET.Location = new System.Drawing.Point(132, 120);
            this.ComCINSIYET.Name = "ComCINSIYET";
            this.ComCINSIYET.Size = new System.Drawing.Size(121, 21);
            this.ComCINSIYET.TabIndex = 21;
            // 
            // TxtSOYAD
            // 
            this.TxtSOYAD.Location = new System.Drawing.Point(132, 77);
            this.TxtSOYAD.Name = "TxtSOYAD";
            this.TxtSOYAD.Size = new System.Drawing.Size(100, 20);
            this.TxtSOYAD.TabIndex = 20;
            // 
            // TxtAD
            // 
            this.TxtAD.Location = new System.Drawing.Point(132, 41);
            this.TxtAD.Name = "TxtAD";
            this.TxtAD.Size = new System.Drawing.Size(100, 20);
            this.TxtAD.TabIndex = 19;
            // 
            // TxtTCKN
            // 
            this.TxtTCKN.Location = new System.Drawing.Point(132, 6);
            this.TxtTCKN.Name = "TxtTCKN";
            this.TxtTCKN.Size = new System.Drawing.Size(100, 20);
            this.TxtTCKN.TabIndex = 18;
            // 
            // BtnList
            // 
            this.BtnList.BackColor = System.Drawing.Color.Azure;
            this.BtnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnList.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnList.Location = new System.Drawing.Point(650, 170);
            this.BtnList.Name = "BtnList";
            this.BtnList.Size = new System.Drawing.Size(117, 44);
            this.BtnList.TabIndex = 17;
            this.BtnList.Text = "LISTELE";
            this.BtnList.UseVisualStyleBackColor = false;
            this.BtnList.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 249);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 201);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // FRMPERSONEL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtDGYR);
            this.Controls.Add(this.BtnTMZL);
            this.Controls.Add(this.BtnSIL);
            this.Controls.Add(this.BtnEKLE);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComCINSIYET);
            this.Controls.Add(this.TxtSOYAD);
            this.Controls.Add(this.TxtAD);
            this.Controls.Add(this.TxtTCKN);
            this.Controls.Add(this.BtnList);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FRMPERSONEL";
            this.Text = "Personeller";
            this.Load += new System.EventHandler(this.Form48_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtDGYR;
        private System.Windows.Forms.Button BtnTMZL;
        private System.Windows.Forms.Button BtnSIL;
        private System.Windows.Forms.Button BtnEKLE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComCINSIYET;
        private System.Windows.Forms.TextBox TxtSOYAD;
        private System.Windows.Forms.TextBox TxtAD;
        private System.Windows.Forms.TextBox TxtTCKN;
        private System.Windows.Forms.Button BtnList;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}