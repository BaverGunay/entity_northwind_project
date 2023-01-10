using entity_northwind_project;
using entity_northwind_project.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace entity_northwind_project
{
    public partial class FRMPERSONEL : Form
    {
        public FRMPERSONEL()
        {
            InitializeComponent();
        }

        private void Form48_Load(object sender, EventArgs e)
        {
            TEMIZLE();
            LISTELE();
        }

        private void LISTELE()
        {
            dataGridView1.DataSource = Personelcs.LISTELE();
        }

        private void TEMIZLE()
        {
            TxtTCKN.Text = String.Empty;
            TxtAD.Text = String.Empty;
            TxtSOYAD.Text = String.Empty;
            ComCINSIYET.Text = String.Empty;
            TxtDGYR.Text = String.Empty;
            ID = 0;
        }
        int ID = 0;

        private void BtnList_Click(object sender, EventArgs e)
        {
            TEMIZLE();
            LISTELE();
        }





        private void BtnTMZL_Click(object sender, EventArgs e)
        {
            TEMIZLE();
        }

        private void BtnEKLE_Click(object sender, EventArgs e)
        {
            if (KONTROL_ET())
            {
                PERSONELLER Personel = new PERSONELLER();

                Personel.ID = ID;
                Personel.TCKN = TxtTCKN.Text;
                Personel.AD = TxtAD.Text;
                Personel.SOYAD = TxtSOYAD.Text;
                Personel.CINSIYET = ComCINSIYET.Text;
                Personel.DOGUM_YERI = TxtDGYR.Text;
                Personel.CREATEDATE=DateTime.Now;
                Personel.IS_FLAG = 1;

                if (ID != 0)
                {
                    DialogResult giriskontrol = MessageBox.Show("Update Yapılsın Mı?", "UPDATE İSLEMİ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (giriskontrol == DialogResult.Yes)
                    {
                        try
                        {
                            Personelcs.Update(Personel);
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
                        Personelcs.Insert(Personel);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("HATA : " + ex);
                    }
                }

            }
        }


        private bool KONTROL_ET()
        {
            bool DON = true;


            if (TxtTCKN.Text == String.Empty)
            {
                MessageBox.Show("TCKN BILGISI EKSIK!!!");
                DON = false;

                return DON;
            }
            else if (TxtTCKN.Text.Length.ToString() != "11")
            {

                MessageBox.Show("TCKN BILGISI 11 HANE DEGIL!!!");
                DON = false;

                return DON;
            }
            else
            {
                try
                {
                    Convert.ToUInt64(TxtTCKN.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("TCKN BILGISI SAYISAL DEGIL!!!");
                    DON = false;

                    return DON;
                }
            }




            if (TxtAD.Text == String.Empty)
            {
                MessageBox.Show("AD BILGISI EKSIK!!!");
                DON = false;

                return DON;
            }




            if (TxtSOYAD.Text == String.Empty)
            {
                MessageBox.Show("SOYAD BILGISI EKSIK!!!");
                DON = false;

                return DON;
            }




            if (ComCINSIYET.Text == String.Empty)
            {
                MessageBox.Show("CINSIYET BILGISI EKSIK!!!");
                DON = false;

                return DON;
            }
            else if (!(ComCINSIYET.Text == "E" || ComCINSIYET.Text == "K"))
            {
                MessageBox.Show("CINSIYET BILGISI E VEYA K DEGIL!!!");
                DON = false;

                return DON;
            }




            if (TxtDGYR.Text == String.Empty)
            {
                MessageBox.Show("DOGUM TARIHI BILGISI EKSIK!!!");
                DON = false;

                return DON;
            }


            return DON;
        }

        private void BtnSIL_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {

                DialogResult giriskontrol = MessageBox.Show("Silme Yapılsın Mı?", "SİLME İSLEMİ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (giriskontrol == DialogResult.Yes)
                {

                    PERSONELLER Personel = new PERSONELLER();
                    Personel.ID = ID;

                    try
                    {
                        Personelcs.SIL(Personel);
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

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            ID = (int)dataGridView1.CurrentRow.Cells[0].Value; //seçilen değerin IDsini tutuyor.
            TxtTCKN.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            TxtAD.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            TxtSOYAD.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            ComCINSIYET.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            TxtDGYR.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }
    }
}