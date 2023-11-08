using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_list_proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> karakterler=new List<string>();
            karakterler.Add("mazhara");
            karakterler.Add("ruhsar");
            karakterler.Add("menkıbe");
            karakterler.Add("müfit");
            karakterler.Add("reyhan");
            karakterler.Add("firdevs");
            karakterler.Remove("müfit");
            foreach(string s in karakterler)
            {
                listBox1.Items.Add(s);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi;
            sayi=Convert.ToInt32(textBox1.Text);
            if (textBox1.Text == "")
            {
                MessageBox.Show("Lütfen değer giriniz");
            }
            else
            {
                MessageBox.Show("5in katı sayılar listeye eklenmiştir!");
                List<int> sayilar = new List<int>();
                sayilar.Add(45);
                sayilar.Add(74);
                sayilar.Add(25);
                sayilar.Add(33);
                sayilar.Add(22);
                sayilar.Add(15);
                sayilar.Add(14);
                
                

                
                if (sayilar.Contains(sayi))
                {
                    MessageBox.Show(sayi+" sayısı var");


                }
                else
                {
                    sayilar.Add(sayi);
                    MessageBox.Show("sayı listeye başarı ile eklenmiştir! ");
                    foreach (int k in sayilar)
                    {
                        if (k % 5 == 0)
                        {
                            listBox2.Items.Add(k);
                        }
                    }
                }

            }
           


        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<kisiler>kisi=new List<kisiler>();
            kisi.Add(new kisiler()
            {
                adi = "ali",
                soyadi = "çınar",
                mesleki = "öğretmen"
            });
            foreach(kisiler k in kisi)
            {
                listBox3.Items.Add(k.adi+" "+k.soyadi+" "+k.mesleki);
            }
        }
    }
}
