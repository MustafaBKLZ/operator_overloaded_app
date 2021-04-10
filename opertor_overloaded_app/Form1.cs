using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace opertor_overloaded_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Kasiyer kasiyer_Mustafa = new Kasiyer("Mustafa", 500);
            Kasiyer kasiyer_Ahmet = new Kasiyer("Ahmet", 800);
            Kasiyer kasiyer_Ayşe = new Kasiyer("Ayşe", 1200);
            MessageBox.Show(kasiyer_Mustafa.ToString());
            //MessageBox.Show(kasiyer_Ahmet);
            //MessageBox.Show(kasiyer_Ayşe);

            Kasiyer ksyr_toplam_Satis = kasiyer_Mustafa + kasiyer_Ahmet + kasiyer_Ayşe;
            MessageBox.Show(ksyr_toplam_Satis.ToString());

        }
    }
}
