using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using entity_northwind_project;
using entity_northwind_project.service;

namespace entity_northwind_project
{
    public partial class FRMURUNLER : Form
    {
        public FRMURUNLER()
        {
            InitializeComponent();
        }

        private void Form52_Load(object sender, EventArgs e)
        {
            TEMIZLE();
            LISTELE();
       

        }

        private void TEMIZLE()
        {
            txtAD.Text = String.Empty;
            comTED.Text = String.Empty;
            comKAT.Text = String.Empty;
            txtFIYAT.Text = String.Empty;
            txtSTOK.Text = String.Empty;
            ID = 0;


        }
        int ID = 0; 


        private void LISTELE()
        {
            dataGridView1.DataSource = uruncs.LISTELE();


            comTED.DataSource = tedarikcics.LISTELECOM();
            comTED.DisplayMember = "AD";
            comTED.ValueMember = "ID";


           
            comKAT.DataSource = kategorics.LISTELEKAT();
            comKAT.DisplayMember = "AD";
            comKAT.ValueMember = "ID";

        }

        private void btnYENI_Click(object sender, EventArgs e)
        {
            TEMIZLE();
        }

        private void btnLIST_Click(object sender, EventArgs e)
        {
            TEMIZLE();
            LISTELE();
        }

        private void btnSIL_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {

                DialogResult giriskontrol = MessageBox.Show("Silme Yapılsın Mı?", "SİLME İSLEMİ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (giriskontrol == DialogResult.Yes)
                {

                    URUNLER Urunler = new URUNLER();
                    Urunler.ID = ID;

                    try
                    {
                        uruncs.SIL(Urunler);
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


        private bool KONTROLET()
        {
            bool DON = true;


            if (txtAD.Text == string.Empty)
            {
                MessageBox.Show("AD bilgisi eksik!!!!!!");
                DON = false;

                return DON;
            }




            if (comTED.Text == string.Empty)
            {
                MessageBox.Show("Tedarikci bilgisi eksik!!!!!!");
                DON = false;

                return DON;
            }




            if (comKAT.Text == string.Empty)
            {
                MessageBox.Show("Kategori bilgisi eksik!!!!!!");
                DON = false;

                return DON;
            }


            if (txtFIYAT.Text == string.Empty)
            {
                MessageBox.Show("Fiyat bilgisi eksik!!!!!!");
                DON = false;

                return DON;
            }


            if (txtSTOK.Text == string.Empty)
            {
                MessageBox.Show("AD bilgisi eksik!!!!!!");
                DON = false;

                return DON;
            }
            return DON;
        }

        private void btnEKLE_Click(object sender, EventArgs e)
        {

            if (KONTROLET())
            {

                URUNLER Urunler = new URUNLER();

                Urunler.ID = ID;
                Urunler.AD = txtAD.Text;
                Urunler.TEDARIKCID =Convert.ToInt32(comTED.SelectedValue);
                Urunler.KATEGORID= Convert.ToInt32( comKAT.SelectedValue);
                Urunler.FIYAT =Convert.ToInt32( txtFIYAT.Text);
                Urunler.STOK =Convert.ToInt16( txtSTOK.Text);
                Urunler.CREATEDATE=DateTime.Now;
                Urunler.IS_FLAG = 1;


                if (ID != 0)
                {
                    DialogResult giriskontrol = MessageBox.Show("Update Yapılsın Mı?", "UPDATE İSLEMİ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (giriskontrol == DialogResult.Yes)
                    {
                        try
                        {
                            uruncs.Update(Urunler);
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
                        uruncs.Insert(Urunler);
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

        private void comTED_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            ID = (int)dataGridView1.CurrentRow.Cells["ID"].Value;
            txtAD.Text = dataGridView1.CurrentRow.Cells["URUN_AD"].Value.ToString();
            comTED.SelectedValue = dataGridView1.CurrentRow.Cells["TEDARIKCID"].Value;
            comKAT.SelectedValue = dataGridView1.CurrentRow.Cells["KATEGORID"].Value;
            txtFIYAT.Text = dataGridView1.CurrentRow.Cells["FIYAT"].Value.ToString();
            txtSTOK.Text = dataGridView1.CurrentRow.Cells["STOK"].Value.ToString();

        }
       
    }
}
