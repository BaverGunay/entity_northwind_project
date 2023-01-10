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
    public partial class FRM_SIPARIS_DETAY : Form
    {
        public FRM_SIPARIS_DETAY()
        {
            InitializeComponent();
        }

        private void LISTELE()
        {
            dataGridView2.DataSource = siparis_detaycs.LISTELE();


            comSIP.DataSource = sipariscs.LISTELESIPP();
            comSIP.DisplayMember = "ID";
            comSIP.ValueMember = "SIPARIS_ID";



            comURUN.DataSource = uruncs.LISTELEURUN();
            comURUN.DisplayMember = "URUN_AD";
            comURUN.ValueMember = "URUNLER_ID";
        }

        private void TEMIZLE()
        {
            comSIP.Text = String.Empty;
            comURUN.Text = String.Empty;
            txtADET.Text = String.Empty;
            
        }

        

        private void FRM_SIPARIS_DETAY_Load(object sender, EventArgs e)
        {
            TEMIZLE();
            LISTELE();
        }

        private void button1_Click(object sender, EventArgs e)
        {//sepete ekle
            if(KONTROL_ET())
            {
                string[] FIYAT = uruncs.FIYAT_GETIR(comURUN.SelectedValue.ToString()).Split(',');

                string STOK = uruncs.STOK_GETIR(comURUN.SelectedValue.ToString());
                int STOK_INT = Convert.ToInt32(STOK);
                int Adet_int = Convert.ToInt32(txtADET.Text);
                if (STOK_INT<Adet_int)
                {
                    MessageBox.Show("Stok miktarı: " + STOK_INT + "  Stok miktarı Yeterli Değil");
                    return;
                }
                dataGridView1.Rows.Add(true, comURUN.SelectedValue.ToString(), comURUN.Text, FIYAT[0], txtADET.Text);
            }
        }

        private bool KONTROL_ET()
        {
            bool DON = true;

            if (comSIP.Text == string.Empty)
            {
                MessageBox.Show("SIPARIS BILGISI eksik!!!!!!");
                DON = false;

                return DON;
            }


            if (comURUN.Text == string.Empty)
            {
                MessageBox.Show("URUN BILGISI eksik!!!!!!");
                DON = false;

                return DON;
            }

            if (txtADET.Text == string.Empty)
            {
                MessageBox.Show("ADET BILGISI eksik!!!!!!");
                DON = false;

                return DON;
            }
            return DON;
        }

        private void buttonTMZL_Click(object sender, EventArgs e)
        {
            TEMIZLE();
        }

        private void buttonLIST_Click(object sender, EventArgs e)
        {
            LISTELE();
        }

        private void buttonDETAYSIL_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult giriskontrol = MessageBox.Show("Sİpariş Yapılsın Mı?", "SİPARİŞ İSLEMİ",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (giriskontrol ==DialogResult.Yes)
            {   List<SIPARIS_DETAY>siparis_detay_list=new List<SIPARIS_DETAY>();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["SEC"].Value !=null)
                    {
                        if ((Boolean)row.Cells["SEC"].Value==true)
                        {
                            if (row.Cells["URUN_ID"].Value !=null
                                && row.Cells["URUN_ID"].Value.ToString() !=string.Empty) 
                            {
                               SIPARIS_DETAY siparisDetay = new SIPARIS_DETAY();
                                siparisDetay.SIPARIS_ID =Convert.ToInt32( comSIP.SelectedValue);
                                siparisDetay.URUN_ID =Convert.ToInt32( row.Cells["URUN_ID"].Value);
                                siparisDetay.FIYAT =Convert.ToDecimal( row.Cells["FIYAT"].Value);
                                siparisDetay.ADET =Convert.ToInt16( row.Cells["ADET"].Value);
                                siparisDetay.CREATEDATE=DateTime.Now;
                                siparisDetay.IS_FLAG = 1;
                                siparis_detay_list.Add(siparisDetay);

                            }
                        }
                    }
                }
                if (siparis_detay_list.Count>0)
                {
                    siparis_detaycs.Insert(siparis_detay_list);
                }
                LISTELE();
            }
        }

    }
}
