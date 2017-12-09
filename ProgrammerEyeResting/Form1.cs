using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace ProgrammerEyeResting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int statdakika, statsaniye;
        int dakika, saniye;
        bool aftimi =false,durum,gorunurluk,flag,ilk =true,baslaflag =true,durdurflag =false;
        int index;
        String m1, m2, m3, m4, m5, m6;
        SoundPlayer ply;

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {

                notifyIcon1.Visible = true;
                gorunurluk = true;
                this.Show();
  
        }

        private void btn_basla_Click(object sender, EventArgs e)
        {
            btn_basla.Enabled = false;
            btndurdur.Enabled = true;

            



            if (ilk==true)
            {
                statdakika = Int32.Parse(txtdk.Text);
                statsaniye = Int32.Parse(txtsn.Text);
                metingirisi();
                ilk = false;
            }
            else {
                
                metingirisi();
            }


            timer1.Enabled = true;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            notifyIcon1.Visible = true;
            gorunurluk = true;
            this.Hide();
        }

        private void rbaftif_CheckedChanged(object sender, EventArgs e)
        {
            button_changed();
        }

        private void rbdeaktif_CheckedChanged(object sender, EventArgs e)
        {
            button_changed();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            m1 = "Avuç içinde saklama : \n\n\n Rahat bir şekilde oturduğunuzdan emin olun, kollarınızı düz bir zeminde dinlendirin, gözlerinizi kapatın \n ve daha sonra avuç içlerinizi gözlerinizin üzerine koyun.  Ellerinizin altından hiç ışık sızmaması gerekiyor. \n Bir ya da iki dakika boyunca yavaşça ve istemli bir şekilde nefes alıp verin. \n Bunu yaptıktan sonra, ellerinizi gözlerinizden yavaşça çekin ve gözlerinizi yeniden açın";
            m2 = "Dört yön egzersizi : \n\n\n Bir tabureye oturun ve başınızı düz tutun.Daha sonra olabildiğince her bir yönde iki üç saniye kalacak  şekilde dört yöne \n bakın: yukarıya, aşağıya, sola ve sonra sağa. Bunu üç kez tekrar edin.Önemli not: sadece gözlerinizi  hareket ettirin,\n başınızı değil.";
            m3 = "Göz çukuru masajı : \n\n\n Yumuşak bir masaj gözler için çok rahatlatıcıdır.Baş parmaklarınızın uçlarını kullanarak, kaşlarınızın aşağısındaki bölgeye \n masaj yapın – burnunuzun üstünden başlayıp göz kapaklarınızın ucuna kadar – dairesel hareketler ile.";
            m4 = "Göz rahatlatıcı egzersiz: \n\n\n Dik oturun ve kolunuzun birini baş parmağınız yukarıyı gösterecek şekilde burnunuzun önüne doğru uzatın. Şimdi beş tane \n nesne seçin: burnunuzun ucu, uzattığınız kolunuz, baş parmağınız ve odanın içinde daha ileride duran iki nesne. \n Dönüşümlü olarak her birine bakın, her bir nesneye birkaç nefes alıp verişiniz süresince bakın.Son olarak, iki \n gözünüzü de kullanın ve bakışlarınızı burnunuzun ucunda, kolunuzda, baş parmağınızda ve diğer iki nesnede \n dolaştırın ve uzakta boşluğa bakarak bitirin. ";
            m5 = "Uyum egzersizi : \n\n\n İşaret parmağınızı gözünüzün seviyesinde tutun - aşağı yukarı gözünüzden yarım kol kadar uzaklıkta bir mesafede. \n Sol işaret parmağınızı bunun 15 santimetre kadar arkasında tutun. Sabit bir tempoyla önce parmaklarınızdan birine sonra \n diğerine bakın.Bunu bir dakika boyunca yapın. ";
            m6 = "Kelebek egzersizi (kuru gözleri önlemek için) : \n\n\n Başınızı düz tutarak ileriye doğru bakın ve yüz kaslarınızı ve alt çenenizi serbest bırakın. 20 kez gözlerinizi kapatıp açın.\n Tüm bu süre boyunca kaslarınızı serbest bırakın – göz kapaklarınız bir kelebeğin kanatları gibi kibarca ve rahatça\n hareket etmeli.";
            lbl.Text = m1;
            timer1.Interval = 1000;
            index = 0;
            btndurdur.Enabled = false;

          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            index++;
            if (index > 5)
                index = 0;

            settext(getindex());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            index--;
            if (index < 0)
                index = 5;

            settext(getindex());
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            if (saniye == 0)
            {
                if (dakika == 0)
                {
                    
                    flag = true;
                }
                else
                {
                    dakika--;
                    saniye = 60;
                    settime();
                }
            }
            else
            {
                saniye--;
                settime();

            }

            if (dakika == 0 && saniye == 0 && rbaftif.Checked ==true)
            {
                this.Visible = true;
                timer1.Stop();
                sescal();
                btn_basla.Enabled = false;
                btndurdur.Enabled = false;
            }
        }

        private void btndurdur_Click(object sender, EventArgs e)
        {
            btn_basla.Enabled = true;
            btndurdur.Enabled = false;
            timer1.Enabled = false;
        }

        private void btnsifirla_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            btn_basla.Enabled = true;
            btndurdur.Enabled = false;
            dakika = statdakika;
            saniye = statsaniye;
            settime();
            if (durum == true)
                ply.Stop();
        }
        private void metingirisi()
        {
            try
            {
                dakika = Int32.Parse(txtdk.Text);
                saniye = Int32.Parse(txtsn.Text);


                if (saniye > 60)
                {
                    MessageBox.Show("Saniyeyi 60 dan küçük girin ", "Hatalı rakam girişi");
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Rakam giriniz","Hatalı veri girişi");

            }

        }
        private void settime()
        {
            txtdk.Text = dakika.ToString();
            txtsn.Text = saniye.ToString();
        }
        private String getindex()
        {
            if (index == 0)
                return m1;
            else if (index == 1)
                return m2;
            else if (index == 2)
                return m3;
            else if (index == 3)
                return m4;
            else if (index == 4)
                return m5;
            else
                return m6;


        }
        private void settext(String text)
        {
            lbl.Text = text;
        }

        private void button_changed()
        {
            if (rbaftif.Checked == true)
            {

            }
            else
            {

            }
        }
        private void sescal()
        {
            ply = new SoundPlayer();
            String dizin = "r.wav";
            ply.SoundLocation = dizin;
            ply.Play();
            durum = true;
        }

    }
}
