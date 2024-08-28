using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme
{
    public partial class Form2 : Form
    {
        private List<Müşteri> müşteriListesi;

        public Form2(List<Müşteri> müşteriler)
        {
            InitializeComponent();
            müşteriListesi = müşteriler;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (var müşteri in müşteriListesi)
            {
                comboBox1.Items.Add($"{müşteri.isim} {müşteri.soyisim}");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBox1.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < müşteriListesi.Count)
            {
                Müşteri seçilenMüşteri = müşteriListesi[selectedIndex];
                txtAdi.Text = seçilenMüşteri.isim;
                txtSoyadii.Text = seçilenMüşteri.soyisim;
                txtMail.Text = seçilenMüşteri.email;
                txtTel.Text = seçilenMüşteri.telefon;
                rictxtAdres.Text = seçilenMüşteri.adres;

            }

           

        }
    }
}
