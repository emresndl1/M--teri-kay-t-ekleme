using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme
{
    public partial class Form1 : Form
    {
        private List<Müşteri> müşteriListesi;
        public Form1()
        {
            InitializeComponent();
            müşteriListesi = new List<Müşteri>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Müşteri Başarıyla eklendi Yeni bir müşteri eklemek istermisiniz ?" ,
                "Müşteri Eklendi",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
  
            if (res==DialogResult.Yes)
            {
                    Müşteri yeniMüşteri = new Müşteri
                    {
                isim = txtAdı.Text,
                soyisim = txtSoyad.Text,
                telefon = txtNo.Text,
                email = txtMail.Text,
                adres = richtxtaadres.Text,
                
                    };
                müşteriListesi.Add(yeniMüşteri);

            }

            txtAdı.Text = "";
            txtSoyad.Text = "";
            txtNo.Text = "";
            txtMail.Text = "";
            richtxtaadres.Text = "";



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(müşteriListesi);
            //form2.ShowDialog(); // form 2 açar 
            form2.Show();
        }
    }
}
