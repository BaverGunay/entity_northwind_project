namespace entity_northwind_project
{
    partial class FRM_SIPARIS_DETAY
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
            this.label1 = new System.Windows.Forms.Label();
            this.comSIP = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comURUN = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtADET = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SEC = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.URUN_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.URUN_AD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIYAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADET = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.buttonTMZL = new System.Windows.Forms.Button();
            this.buttonLIST = new System.Windows.Forms.Button();
            this.buttonDETAYSIL = new System.Windows.Forms.Button();
            this.buttonEXCEL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SIPARIS";
            // 
            // comSIP
            // 
            this.comSIP.FormattingEnabled = true;
            this.comSIP.Location = new System.Drawing.Point(83, 38);
            this.comSIP.Name = "comSIP";
            this.comSIP.Size = new System.Drawing.Size(121, 21);
            this.comSIP.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "URUN";
            // 
            // comURUN
            // 
            this.comURUN.FormattingEnabled = true;
            this.comURUN.Location = new System.Drawing.Point(83, 84);
            this.comURUN.Name = "comURUN";
            this.comURUN.Size = new System.Drawing.Size(121, 21);
            this.comURUN.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ADET";
            // 
            // txtADET
            // 
            this.txtADET.Location = new System.Drawing.Point(83, 141);
            this.txtADET.Name = "txtADET";
            this.txtADET.Size = new System.Drawing.Size(121, 20);
            this.txtADET.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SEC,
            this.URUN_ID,
            this.URUN_AD,
            this.FIYAT,
            this.ADET});
            this.dataGridView1.Location = new System.Drawing.Point(244, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 144);
            this.dataGridView1.TabIndex = 6;
            // 
            // SEC
            // 
            this.SEC.HeaderText = "SEC";
            this.SEC.Name = "SEC";
            // 
            // URUN_ID
            // 
            this.URUN_ID.HeaderText = "URUN_ID";
            this.URUN_ID.Name = "URUN_ID";
            // 
            // URUN_AD
            // 
            this.URUN_AD.HeaderText = "URUN_AD";
            this.URUN_AD.Name = "URUN_AD";
            // 
            // FIYAT
            // 
            this.FIYAT.HeaderText = "FIYAT";
            this.FIYAT.Name = "FIYAT";
            // 
            // ADET
            // 
            this.ADET.HeaderText = "ADET";
            this.ADET.Name = "ADET";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(414, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "SIPARIS DETAY";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(134, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "SEPETE EKLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(684, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 46);
            this.button2.TabIndex = 9;
            this.button2.Text = "SIPARIS VER";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView2.Location = new System.Drawing.Point(0, 300);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(800, 150);
            this.dataGridView2.TabIndex = 10;
            // 
            // buttonTMZL
            // 
            this.buttonTMZL.Location = new System.Drawing.Point(15, 181);
            this.buttonTMZL.Name = "buttonTMZL";
            this.buttonTMZL.Size = new System.Drawing.Size(81, 35);
            this.buttonTMZL.TabIndex = 11;
            this.buttonTMZL.Text = "TEMIZLE";
            this.buttonTMZL.UseVisualStyleBackColor = true;
            this.buttonTMZL.Click += new System.EventHandler(this.buttonTMZL_Click);
            // 
            // buttonLIST
            // 
            this.buttonLIST.Location = new System.Drawing.Point(15, 222);
            this.buttonLIST.Name = "buttonLIST";
            this.buttonLIST.Size = new System.Drawing.Size(81, 34);
            this.buttonLIST.TabIndex = 12;
            this.buttonLIST.Text = "LISTELE";
            this.buttonLIST.UseVisualStyleBackColor = true;
            this.buttonLIST.Click += new System.EventHandler(this.buttonLIST_Click);
            // 
            // buttonDETAYSIL
            // 
            this.buttonDETAYSIL.Location = new System.Drawing.Point(558, 196);
            this.buttonDETAYSIL.Name = "buttonDETAYSIL";
            this.buttonDETAYSIL.Size = new System.Drawing.Size(98, 46);
            this.buttonDETAYSIL.TabIndex = 13;
            this.buttonDETAYSIL.Text = "SIPARIS DETAY SIL";
            this.buttonDETAYSIL.UseVisualStyleBackColor = true;
            this.buttonDETAYSIL.Click += new System.EventHandler(this.buttonDETAYSIL_Click);
            // 
            // buttonEXCEL
            // 
            //this.buttonEXCEL.Location = new System.Drawing.Point(15, 262);
            //this.buttonEXCEL.Name = "buttonEXCEL";
            //this.buttonEXCEL.Size = new System.Drawing.Size(81, 32);
            //this.buttonEXCEL.TabIndex = 14;
            //this.buttonEXCEL.Text = "EXCEL";
            //this.buttonEXCEL.UseVisualStyleBackColor = true;
            //this.buttonEXCEL.Click += new System.EventHandler(this.buttonEXCEL_Click);
            // 
            // FRM_SIPARIS_DETAY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonEXCEL);
            this.Controls.Add(this.buttonDETAYSIL);
            this.Controls.Add(this.buttonLIST);
            this.Controls.Add(this.buttonTMZL);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtADET);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comURUN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comSIP);
            this.Controls.Add(this.label1);
            this.Name = "FRM_SIPARIS_DETAY";
            this.Text = "FRM_SIPARIS_DETAY";
            this.Load += new System.EventHandler(this.FRM_SIPARIS_DETAY_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comSIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comURUN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtADET;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SEC;
        private System.Windows.Forms.DataGridViewTextBoxColumn URUN_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn URUN_AD;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIYAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADET;
        private System.Windows.Forms.Button buttonTMZL;
        private System.Windows.Forms.Button buttonLIST;
        private System.Windows.Forms.Button buttonDETAYSIL;
        private System.Windows.Forms.Button buttonEXCEL;
    }
}