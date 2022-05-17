﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExpressTeknikServis.Formlar
{
    public partial class FrmUrunSatis : Form
    {
        public FrmUrunSatis()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db=new DbTeknikServisEntities();
        private void btnSatisYap_Click(object sender, EventArgs e)
        {
            TBLURUNHAREKET t=new TBLURUNHAREKET();
            t.URUN = int.Parse(txtId.Text);
            t.MUSTERI=int.Parse(txtMusteri.Text);
            t.PERSONEL=short.Parse(txtPersonel.Text);
            t.TARIH=DateTime.Parse(txtTarih.Text);
            t.ADET=short.Parse(txtAdet.Text);
            t.FIYAT=decimal.Parse(txtFiyat.Text);
            t.URUNSERINO = txtSeriNo.Text;
            db.TBLURUNHAREKET.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün Satışı gerçekleştirildi.");

        }
    }
}
