using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using entity_northwind_project.service;
using entity_northwind_project;

namespace entity_northwind_project
{
    public partial class FRMTEDARIKCI : Form
    {
        public FRMTEDARIKCI()
        {
            InitializeComponent();
        }

        private void btnLIST_Click(object sender, EventArgs e)
        {
            TEMIZLE();
            LISTELE();
        }

        private void TEMIZLE()
        {
            txtAD.Text = String.Empty;
            txtYTKL.Text = String.Empty;
            txtADRES.Text = String.Empty;
            txtSEHIR.Text = String.Empty;
            txtULKE.Text = String.Empty;
            ID = 0;
        }
        int ID = 0;


        private void LISTELE()
        {
            dataGridView1.DataSource = tedarikcics.LISTELE();
        }

        private void Form51_Load(object sender, EventArgs e)
        {
            TEMIZLE();
            LISTELE();
        }

        private void btnYENI_Click(object sender, EventArgs e)
        {
            TEMIZLE();
        }

        private void btnSIL_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {

                DialogResult giriskontrol = MessageBox.Show("Silme Yapılsın Mı?", "SİLME İSLEMİ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (giriskontrol == DialogResult.Yes)
                {

                    TEDARIKCILER Tedarikci = new TEDARIKCILER();
                    Tedarikci.ID = ID;

                    try
                    {
                        tedarikcics.SIL(Tedarikci);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("HATA: " + ex);

                    }
                    TEMIZLE();
                    LISTELE();

                }
            }
        }

        private void btnEKLE_Click(object sender, EventArgs e)
        {
            if (KONTROLET())
            {

                TEDARIKCILER Tedarikci = new TEDARIKCILER();

                Tedarikci.ID = ID;
                Tedarikci.AD = txtAD.Text;
                Tedarikci.YETKILI = txtYTKL.Text;
                Tedarikci.ADRES = txtADRES.Text;
                Tedarikci.SEHIR = txtSEHIR.Text;
                Tedarikci.ULKE = txtULKE.Text;
                Tedarikci.CREATEDATE = DateTime.Now;
                Tedarikci.IS_FLAG = 1;


                if (ID != 0)
                {
                    DialogResult giriskontrol = MessageBox.Show("Update Yapılsın Mı?", "UPDATE İSLEMİ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (giriskontrol == DialogResult.Yes)
                    {
                        try
                        {
                          tedarikcics.Update(Tedarikci);
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show("HATA : " + ex);
                        }

                    }
                }
                else
                {
                    try
                    {
                        tedarikcics.Insert(Tedarikci);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("HATA : " + ex);
                    }
                }
                TEMIZLE();
                LISTELE();
            }
        }


        private bool KONTROLET()
        {
            bool DON = true;


            if (txtAD.Text == string.Empty)
            {
                MessageBox.Show("AD bilgisi eksik!!!!!!");
                DON = false;

                return DON;
            }



            if (txtYTKL.Text == string.Empty)
            {
                MessageBox.Show("Yetkili bilgisi eksik!!!!!!");
                DON = false;

                return DON;
            }



            if (txtADRES.Text == string.Empty)
            {
                MessageBox.Show("ADRES bilgisi eksik!!!!!");
                DON = false;

                return DON;
            }


            if (txtSEHIR.Text == string.Empty)
            {
                MessageBox.Show("SEHIR bilgisi eksik!!!!!!");
                DON = false;

                return DON;
            }




            if (txtULKE.Text == string.Empty)
            {
                MessageBox.Show("ULKE bilgisi eksik");
                DON = false;

                return DON;
            }

            return DON;

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            ID = (int)dataGridView1.CurrentRow.Cells[0].Value;
            txtAD.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtYTKL.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtADRES.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtSEHIR.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtULKE.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
