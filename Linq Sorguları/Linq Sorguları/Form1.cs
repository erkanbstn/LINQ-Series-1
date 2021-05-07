using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linq_Sorguları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DBSınavEntityEntities db = new DBSınavEntityEntities();   
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                //SINAV 1 < 50

                var s = db.TblNotlar.Where(p => p.Sınav1 < 50);
                dataGridView1.DataSource = s.ToList();
            }
            if (radioButton2.Checked == true)
            {
                // Adı Ali Olanlar

                var s = db.TblÖğrenci.Where(p => p.Ad == "Ali");
                dataGridView1.DataSource = s.ToList();
            }
            if (radioButton3.Checked == true)
            {
                // Adı Veya Soyadı Textten Al

                var s = db.TblÖğrenci.Where(p => p.Ad == textBox1.Text || p.Soyad == textBox2.Text);
                dataGridView1.DataSource = s.ToList();
            }
            if (radioButton4.Checked == true)
            {
                // Öğrenci Soyadları 

                //var s = db.TblÖğrenci.Select(x => x.Soyad) -> Bu işlem sadece kelime uzunluğunu verir.
                var s = db.TblÖğrenci.Select(x => new { Soyad = x.Soyad});  // Anonymus Type sayesinde isimleri getirebiliriz.
                dataGridView1.DataSource = s.ToList();
            }
            if (radioButton5.Checked == true)
            {
                // Adı Büyük Soyad Küçük 

                var s = db.TblÖğrenci.Select(x => new { Ad = x.Ad.ToUpper(), Soyad = x.Soyad.ToLower() });
                dataGridView1.DataSource = s.ToList();
            }
            if (radioButton6.Checked == true)
            {
                // Şartlı Seçim 

                var s = db.TblÖğrenci.Select(x => new { Ad = x.Ad.ToUpper(), Soyad = x.Soyad.ToLower() }).Where(x=>x.Ad!="Ali");
                dataGridView1.DataSource = s.ToList();
            }
            if (radioButton7.Checked == true)
            {
                // Geçti Kaldı

                var s = db.TblNotlar.Select(x => 
                new {
                    Ad = x.Ogr,Ortalama = x.Ortalama, Durum = x.Durum==true ? "Geçti" : "Kaldı"
                });
                dataGridView1.DataSource = s.ToList(); 
            }
            if (radioButton8.Checked == true)
            {
                // Birleştir

                var s = db.TblNotlar.SelectMany(x =>
                db.TblÖğrenci.Where(y => y.ID == x.Ogr),(x,y)=> new
                {

                    y.Ad,
                    x.Ortalama,
                    Durum = x.Durum==true ? "Geçti":"Kaldı"

                }  );
                dataGridView1.DataSource = s.ToList(); 
            }
            if (radioButton9.Checked == true)
            {
                // İlk 3 Değer 

                var s = db.TblÖğrenci.OrderBy(x => x.ID).Take(3);
                dataGridView1.DataSource = s.ToList();
            }
            if (radioButton10.Checked == true)
            {
                // Son 3 Değer 

                var s = db.TblÖğrenci.OrderByDescending(x => x.ID).Take(3);
                dataGridView1.DataSource = s.ToList();
            }

            if (radioButton11.Checked == true)
            {
                // Ada Göre Ad Sırala
                var s = db.TblÖğrenci.OrderBy(x => x.Ad).Select(c => new { Adı = c.Ad });
                dataGridView1.DataSource = s.ToList();
            }
            if (radioButton12.Checked == true)
            {
                // İlk 5 Değeri Atla 

                var s = db.TblÖğrenci.OrderBy(x => x.ID).Skip(5);
                dataGridView1.DataSource = s.ToList();
            }
            if (radioButton13.Checked == true)
            {
                // Gruplandır

          
            }
            
        }
    }
}
