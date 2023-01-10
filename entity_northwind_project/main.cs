
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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }
        FRMPERSONEL fRMPERSONEL;
        private void personelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fRMPERSONEL == null || fRMPERSONEL.IsDisposed)
            {
                fRMPERSONEL = new FRMPERSONEL();
                fRMPERSONEL.MdiParent = this; //formun içinde açılcak
            }

            //FRMPERSONEL fRMPERSONEL = new FRMPERSONEL();
            fRMPERSONEL.Show();
        }
        FRMKATEGORI fRMKATEGORI;
        private void kategoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fRMKATEGORI == null || fRMKATEGORI.IsDisposed)
            {
                fRMKATEGORI = new FRMKATEGORI();
                fRMKATEGORI.MdiParent = this; //formun içinde açılcak
            }

            //FRMPERSONEL fRMPERSONEL = new FRMPERSONEL();
            fRMKATEGORI.Show();
        }
        FRMMUSTERI fRMMUSTERI;
        private void musteriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fRMMUSTERI == null || fRMMUSTERI.IsDisposed)
            {
                fRMMUSTERI = new FRMMUSTERI();
                fRMMUSTERI.MdiParent = this; //formun içinde açılcak
            }

            //FRMPERSONEL fRMPERSONEL = new FRMPERSONEL();
            fRMMUSTERI.Show();
        }
        FRMTEDARIKCI fRMTEDARIKCI;
        private void tedarikçiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fRMTEDARIKCI == null || fRMTEDARIKCI.IsDisposed)
            {
                fRMTEDARIKCI = new FRMTEDARIKCI();
                fRMTEDARIKCI.MdiParent = this; //formun içinde açılcak
            }

            //FRMPERSONEL fRMPERSONEL = new FRMPERSONEL();
            fRMTEDARIKCI.Show();
        }
        FRMURUNLER fRMURUNLER;
        private void urunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fRMURUNLER == null || fRMURUNLER.IsDisposed)
            {
                fRMURUNLER = new FRMURUNLER();
                fRMURUNLER.MdiParent = this; //formun içinde açılcak
            }

            //FRMPERSONEL fRMPERSONEL = new FRMPERSONEL();
            fRMURUNLER.Show();
        }
        FRMSIPARIS fRMSIPARIS;
        private void siparisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fRMSIPARIS == null || fRMSIPARIS.IsDisposed)
            {
                fRMSIPARIS = new FRMSIPARIS();
                fRMSIPARIS.MdiParent = this; //formun içinde açılcak
            }

            //FRMPERSONEL fRMPERSONEL = new FRMPERSONEL();
            fRMSIPARIS.Show();
        }
        FRM_SIPARIS_DETAY fRM_SIPARIS_DETAY;
        private void siparişDetayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fRM_SIPARIS_DETAY == null || fRM_SIPARIS_DETAY.IsDisposed)
            {
                fRM_SIPARIS_DETAY = new FRM_SIPARIS_DETAY();
                fRM_SIPARIS_DETAY.MdiParent = this; //formun içinde açılcak
            }

            //FRMPERSONEL fRMPERSONEL = new FRMPERSONEL();
            fRM_SIPARIS_DETAY.Show();
        }
    }
}
