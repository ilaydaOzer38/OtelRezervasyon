using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelRezervasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDurumTanimlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Tanımlamalar.FrmDurum fr = new Formlar.Tanımlamalar.FrmDurum();
            fr.Show();
        }

        //private void btnAnaForm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    Formlar.AnaForm.FrmAnaForm fr = new Formlar.AnaForm.FrmAnaForm();
        //    fr.MdiParent = this;
        //    fr.Show();
        //}

        //private void btnMisafirListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    Formlar.Misafir.FrmMisafirListesi fr = new Formlar.Misafir.FrmMisafirListesi();
        //    fr.MdiParent = this;
        //    fr.Show();
        //}

        //private void btnYeniMisafirKarti_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    Formlar.Misafir.FrmMisafirKarti fr = new Formlar.Misafir.FrmMisafirKarti();
        //    fr.Show();
        //}

        //private void btnPersonelListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    Formlar.Personel.FrmPersoneListesi fr = new Formlar.Personel.FrmPersoneListesi();
        //    fr.MdiParent = this;
        //    fr.Show();
        //}

        //private void btnPersonelKarti_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    Formlar.Personel.FrmPersonelKarti fr = new Formlar.Personel.FrmPersonelKarti();
        //    fr.Show();
        //}

        //private void btnUrunListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    Formlar.Urun.FrmUrunListesi fr = new Formlar.Urun.FrmUrunListesi();
        //    fr.MdiParent = this;
        //    fr.Show();
        //}

        //private void btnUrunKarti_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    Formlar.Urun.FrmUrunKarti fr = new Formlar.Urun.FrmUrunKarti();
        //    fr.Show();
        //}


    }
}
