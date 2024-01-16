using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static Guna.UI2.Native.WinApi;

namespace fly_control
{
    public partial class Form1 : Form
    {
        Bitmap trafikresim;
        int aci = 0;
        int durum1 = 0; //timer içinde kullanmaktayım 
        int varis; //illeri seçmek için kullanıyoruz button içinde 
        string[] iller;

        string[] varisArray = new string[]
            {
            "Ankara -> Esenboğa Havalimanı",
            "İzmir -> Adnan Menderes Havalimanı",
            "Kayseri -> Kayseri Havalimanı",
            "Adana -> Adana Şakirpaşa Havalimanı",
            "Adıyaman -> Gölbaşı Havalimanı",
            "Afyon -> Afyon Zafer Havalimanı",
            "Ağrı -> Ahmed-i Hani Havalimanı",
            "Uşak -> Uşak Havalimanı",
            "Amasya -> Merzifon Havalimanı",
            "Antalya -> Antalya Havalimanı",
            "Ardahan -> Artvin Hopa Havalimanı",
            "Artvin -> Artvin Hopa Havalimanı",
            "Aydın -> Çıldır Havalimanı",
            "Balıkesir -> Balıkesir Koca Seyit Havalimanı",
            "Bartın -> Bartın Çaycuma Havalimanı",
            "Batman -> Batman Havalimanı",
            "Bingöl -> Bingöl Havalimanı",
            "Denizli -> Denizli Çardak Havalimanı",
            "Diyarbakır -> Diyarbakır Havalimanı",
            "Elazığ -> Elazığ Havalimanı",
            "Erzincan -> Erzincan Havalimanı",
            "Erzurum -> Erzurum Havalimanı",
            "Gaziantep -> Oğuzeli Havalimanı",
            "Hakkari -> Hakkari Yüksekova Selahaddin Eyyubi Havalimanı",
            "Hatay -> Antakya Havalimanı",
            "Isparta -> Süleyman Demirel Havalimanı",
            "Iğdır -> Iğdır Havalimanı",
            "Kahramanmaraş -> Kahramanmaraş Havalimanı",
            "Kars -> Kars Harakani Havalimanı",
            "Kastamonu -> Kastamonu Havalimanı",
            "Konya -> Konya Havalimanı",
            "Kütahya -> Kütahya Zafer Havalimanı",
            "Malatya -> Malatya Turgut Özal Havalimanı",
            "Mardin -> Mardin Havalimanı",
            "Muğla -> Dalaman Havalimanı",
            "Muş -> Muş Havalimanı",
            "Nevşehir -> Kapadokya Havalimanı",
            "Ordu -> Ordu-Giresun Havalimanı",
            "Rize -> Rize-Artvin Havalimanı",
            "Samsun -> Çarşamba Havalimanı",
            "Siirt -> Siirt Havalimanı",
            "Sinop -> Sinop Havalimanı",
            "Sivas -> Nuri Demirağ Havalimanı",
            "Tokat -> Tokat Havalimanı",
            "Trabzon -> Trabzon Havalimanı",
            "Van -> Ferit Melen Havalimanı",
            "Şanlıurfa -> GAP Havalimanı",
            "Zonguldak -> Çaycuma Havalimanı",
            "Şırnak -> Şerafettin Elçi Havalimanı"
        };

        public List<(int X, int Y)> GetPointList()
        {
            return new List<(int X, int Y)>
        {
            (200, 90),
            (15, 140),
            (315, 140),
            (300, 190),
            (390, 180),
            (120, 140),
            (560, 90),
            (100, 140),
            (300, 60),
            (145, 205),
            (550, 20),
            (505, 10),
            (55, 170),
            (55, 90),
            (200, 15),
            (490, 180),
            (470, 130),
            (90, 180),
            (455, 165),
            (430, 145),
            (430, 95),
            (490, 65),
            (355, 215),
            (595, 185),
            (320, 245),
            (140, 170),
            (580, 75),
            (345, 170),
            (540, 55),
            (240, 10),
            (205, 175),
            (100, 110),
            (375, 145),
            (465, 200),
            (60, 210),
            (500, 120),
            (275, 135),
            (365, 45),
            (475, 35),
            (325, 32),
            (515, 165),
            (280, 5),
            (345, 90),
            (335, 60),
            (445, 45),
            (565, 150),
            (405, 215),
            (180, 25),
            (515, 200)
        };
        }

        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            //resimleri birbirine parent(butunleştirme) yaptım ve resimleri arka planla tumleşik olması için transparanlaştırdım .
            pictureboxcubuk.Parent = pictureboxhalka;
            pictureBoxnokta.Parent = pictureboxcubuk;
            pictureBoxnoktaharita.Parent = pictureBoxturiyeharistası;
            pictureBoxharitanoktavaris.Parent = pictureBoxturiyeharistası;
            pictureboxhalka.BackColor = Color.Transparent;
            pictureboxcubuk.BackColor = Color.Transparent;

            pictureboxcubuk.Location = new Point(0, 0);
            pictureBoxnoktaharita.Location = new Point(90, 25);
            pictureBoxharitanoktavaris.Location = new Point(90, 25);



            trafikresim = new Bitmap(fly_control.Properties.Resources.cubuk);
            timer1.Start();
            //combobox içindeki seçilebilecek varış noktalarını barındıran iler ve illerin combobox a yazılmış hali.
            iller = new string[]{ "Ankara" , "İzmir" , "Kayseri", "Adana" , "Adıyaman", "Afyon","Ağrı", "Uşak", "Amasya", "Antalya", "Ardahan" , "Artvin" , "Aydin" , "Balıkesir" , "Bartin" ,
"Batman","Bingöl","Denizli","Diyarbakır","Elazığ","Erzincan","Erzurum","Gaziantep","Hakkari","Hatay","Isparta","Iğdır","Kahramanmaraş",
            "Kars","Kastamonu","Konya","Kütahya","Malatya","Mardin", "Muğla" ,"Muş","Nevşehir","Ordu","Rize","Samsun","Siirt","Sinop",
            "Sivas","Tokat","Trabzon","Van","Şanlıurfa","Zonguldak","Sirnak","*","*","*","*"};


            for (int i = 0; i < iller.Length; i++)
            {

                ComboBoxvaris.Items.Add(iller[i]);

            }

        }
        private Bitmap dondur(Bitmap eskiresim, float acı)
        {
            Bitmap yeniresim = new Bitmap(eskiresim.Width, eskiresim.Height);
            using (Graphics g = Graphics.FromImage(yeniresim))
            {
                g.TranslateTransform(eskiresim.Width / 2, eskiresim.Height / 2);
                g.RotateTransform(acı);
                g.TranslateTransform(-eskiresim.Width / 2, -eskiresim.Height / 2);
                g.DrawImage(eskiresim, new Point(0, 0));
            }
            return yeniresim;
        }


        private void timer1_Tick_1(object sender, EventArgs e) //Navigasyon görselini Timer kullanarak  6 derece döndürüyoruz her 1 saniye içerisinde . 
        {
            int i = 0;
            if (i == 360)
            {
                aci = 0;
            }
            else
            {
                aci += 6;
            }
            pictureboxcubuk.Image = dondur(trafikresim, aci);

        }

        private string Havadurumu(string path)  // hava durumu verilerini işlediğim fonksyon (Api den verilerin alındığı Fonksyon)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://api.weatherapi.com");
                    var result = client.GetAsync(path).Result;
                    string sonc = result.Content.ReadAsStringAsync().Result;
                    JObject jsonObject = JsonConvert.DeserializeObject<JObject>(sonc);
                    string havadurumu = jsonObject["current"]["condition"]["text"].ToString();
                    return turkceyeCevir(havadurumu);

                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private string turkceyeCevir(string havadurumu)
        {
            string turkce;
            //MessageBox.Show(havadurumu.ToLower());       //hava durumu koşullarını tespit etmek için kullandık .

            switch (havadurumu.ToLower())
            {
                case "clear":
                    turkce = "Açık  = Uçuşa uygun ";
                    break;
                case "freezing fog":
                    turkce = "Dondurucu sis = Uçuşa uygun değil !!!";
                    break;
                case "sunny":
                    turkce = "Güneşli  = Uçuşa uygun";
                    break;

                case "cloudy":
                    turkce = "Bulutlu  = Uçuşa uygun";
                    break;
                case "overcast":
                    turkce = "Bulutlu  = Uçuşa uygun";
                    break;

                case "partly cloudy":
                    turkce = "Parçalı Bulutlu  = Uçuşa uygun";
                    break;

                case "light sleet":
                    turkce = "Hafif karla karışık yağmurlu = Uçuşa uygun ";
                    break;

                case "rainy":
                    turkce = "Yağmurlu  = Uçuşa uygun";
                    break;

                case "snowy":
                    turkce = "Karlı  = Uçuşa uygun";
                    break;

                case "stormy":
                    turkce = "Fırtınalı  = Uçuşa uygun değil !!!";
                    break;

                case "light freezing rain":
                    turkce = "Hafif dondurucu yağmur  = Uçuşa uygun";
                    break;

                case "light rain":
                    turkce = "Hafif Yağmurlu  = Uçuşa uygun";
                    break;

                case "fog":
                    turkce = "Sisli  = Uçuşa uygun değil !!!";
                    break;

                case "light snow":
                    turkce = "Hafif Karlı  = Uçuşa uygun";
                    break;

                case "mist":
                    turkce = "Sisli  = Uçuşa uygun değil !!!";
                    break;
                case "patchy light snow":
                    turkce = "Düzensiz hafif kar  = Uçuşa uygun";
                    break;

                case "patchy rain possible":
                    turkce = "Yer yer yağmur mümkün  = Uçuşa uygun";
                    break;

                default:
                    turkce = "Bilinmeyen Hava Durumu";
                    break;
            }

            return turkce;
        }

        private async void btnucusbelirle_Click(object sender, EventArgs e)
        {
            buttonkalkısonay.Enabled = true;
            btnUcusBelirle.Enabled = false;
            /* if (acı == 360) acı = 0;
           else acı += 6;
           pictureboxcubuk.Image = donder(trafikresim, acı);*/
            if (durum1 == 0) //timer çalıştırma ve durdurma işlevi .
            {
                btnUcusBelirle.Text = "Rota belirlendi ve kalkışa hazırlanıldı ";
                durum1 = 1;
                timer1.Start();
            }
            else if (durum1 == 1)
            {
                btnUcusBelirle.Text = "Kalkış gerçekleşti";
                durum1 = 0;
                timer1.Stop();
            }
            string path = "/v1/current.json?key=68e944eb338c4ab1bba104856232612&q=" + iller[varis].ToLower();  // illerin hava durumunu dinamik bir şekilde almamızı sağlar .
            string hava = Havadurumu(path);
            Point location = konumDondur(ComboBoxvaris.SelectedIndex);
            pictureBoxharitanoktavaris.Location = new Point(location.X, location.Y);
            listBox1.Items.Add("KALKIŞ : İstanbul -> Sabiha Gökçen Havalimanı / VARIŞ : " + varisArray[ComboBoxvaris.SelectedIndex] + " Hava Durumu : " + hava);
            MessageBox.Show(hava);
            // MessageBox.Show("Hava durumu :" + hava, "hava durumu ");
        }



        private void buttonkalkısonay_Click_1(object sender, EventArgs e) //uçuş süresi "Api uzerinden alınsaydı daha kısa yazılabilirdi". 
        {
            buttonkalkısonay.Enabled = false;
            btnUcusBelirle.Enabled = true;
            if (varis == 0) { 
                MessageBox.Show("  varış süresi  1 sa 10d", "Uçuş bilgileri");
            }
            if (varis == 1)
            {
                MessageBox.Show("  varış süresi  1 sa 10d", "Uçuş bilgileri");
            }
            if (varis == 2)
            {
                MessageBox.Show("  varış süresi  1 sa 25d", "Uçuş bilgileri");
            }
            if (varis == 3)
            {
                MessageBox.Show("  varış süresi  1 sa 30d", " Uçuş bilgileri");
            }
            if (varis == 4)
            {
                MessageBox.Show("  varış süresi  1 sa 50d", "Uçuş bilgileri");
            }
            if (varis == 5)
            {
                MessageBox.Show("  varış süresi  1 sa 20d", "Uçuş bilgileri");
            }
            if (varis == 6)
            {
                MessageBox.Show("  varış süresi  2s 5d", "Uçuş bilgileri");
            }
            if (varis == 7)
            {
                MessageBox.Show("  varış süresi  1 sa 10d", "Uçuş bilgileri");
            }
            if (varis == 8)
            {
                MessageBox.Show("  varış süresi  1 sa 25d", "Uçuş bilgileri");
            }
            if (varis == 9)
            {
                MessageBox.Show("  varış süresi  1 sa 20d", "Uçuş bilgileri");
            }
            if (varis == 10)
            {
                MessageBox.Show("  varış süresi  2s 5d", "Uçuş bilgileri");
            }
            if (varis == 11)
            {
                MessageBox.Show("  varış süresi  1 sa 50d", "Uçuş bilgileri");
            }
            if (varis == 12)
            {
                MessageBox.Show("  varış süresi  1 sa 10d", "Uçuş bilgileri");
            }
            if (varis == 13)
            {
                MessageBox.Show("  varış süresi  1 sa 5d", "Uçuş bilgileri");
            }
            if (varis == 14)
            {
                MessageBox.Show("  varış süresi  1 sa 5d", "Uçuş bilgileri");
            }
            if (varis == 15)
            {
                MessageBox.Show("  varış süresi  2s 0d", "Uçuş bilgileri");
            }
            if (varis == 16)
            {
                MessageBox.Show("  varış süresi 2s 5d", "Uçuş bilgileri");
            }
            if (varis == 17)
            {
                MessageBox.Show("  varış süresi  1 sa 5d", "Uçuş bilgileri");
            }
            if (varis == 18)
            {
                MessageBox.Show("  varış süresi  1 sa 55d", "Uçuş bilgileri");
            }
            if (varis == 19)
            {
                MessageBox.Show("  varış süresi  1 sa 50d", "Uçuş bilgileri");
            }
            if (varis == 20)
            {
                MessageBox.Show("  varış süresi  1 sa 50d", "Uçuş bilgileri");
            }
            if (varis == 21)
            {
                MessageBox.Show("  varış süresi  1 sa 55d", "Uçuş bilgileri");
            }
            if (varis == 22)
            {
                MessageBox.Show("  varış süresi  1 sa 45d", "Uçuş bilgileri");
            }
            if (varis == 23)
            {
                MessageBox.Show("  varış süresi 2s 20d", "Uçuş bilgileri");
            }
            if (varis == 24)
            {
                MessageBox.Show("  varış süresi  1 sa 45d", "Uçuş bilgileri");
            }
            if (varis == 25)
            {
                MessageBox.Show("  varış süresi  1 sa 15d", "Uçuş bilgileri");
            }
            if (varis == 26)
            {
                MessageBox.Show("  varış süresi  2s 10d", "Uçuş bilgileri");
            }
            if (varis == 27)
            {
                MessageBox.Show("  varış süresi  1 sa 45d", "Uçuş bilgileri");
            }
            if (varis == 28)
            {
                MessageBox.Show("  varış süresi  2s 5d", "Uçuş bilgileri");
            }
            if (varis == 29)
            {
                MessageBox.Show("  varış süresi  1 sa 20d", "Uçuş bilgileri");
            }
            if (varis == 30)
            {
                MessageBox.Show("  varış süresi  1 sa 20d", "Uçuş bilgileri");
            }
            if (varis == 31)
            {
                MessageBox.Show("  varış süresi  1 sa 5d", "Uçuş bilgileri");
            }
            if (varis == 32)
            {
                MessageBox.Show("  varış süresi  1 sa 45d", "Uçuş bilgileri");
            }
            if (varis == 33)
            {
                MessageBox.Show("  varış süresi  2s 0d", "Uçuş bilgileri");
            }
            if (varis == 34)
            {
                MessageBox.Show("  varış süresi  1 sa 15d", "Uçuş bilgileri");
            }
            if (varis == 35)
            {
                MessageBox.Show("  varış süresi  2s 5d", "Uçuş bilgileri");
            }
            if (varis == 36)
            {
                MessageBox.Show("  varış süresi  1 sa 20d", "Uçuş bilgileri");
            }
            if (varis == 37)
            {
                MessageBox.Show("  varış süresi  1 sa 40d", "Uçuş bilgileri");
            }
            if (varis == 38)
            {
                MessageBox.Show("  varış süresi  1 sa 50d", "Uçuş bilgileri");
            }
            if (varis == 39)
            {
                MessageBox.Show("  varış süresi  1 sa 30d", "Uçuş bilgileri");
            }
            if (varis == 40)
            {
                MessageBox.Show("  varış süresi  2s 5d", "Uçuş bilgileri");
            }
            if (varis ==41)
            {
                MessageBox.Show("  varış süresi  1 sa 25d", "Uçuş bilgileri");
            }
            if (varis == 42)
            {
                MessageBox.Show("  varış süresi  1 sa 30d", "Uçuş bilgileri");
            }
            if (varis == 43)
            {
                MessageBox.Show("  varış süresi  1 sa 30d", "Uçuş bilgileri");
            }
            if (varis == 44)
            {
                MessageBox.Show("  varış süresi  1 sa 45d", "Uçuş bilgileri");
            }
            if (varis == 45)
            {
                MessageBox.Show("  varış süresi  2s 10d", "Uçuş bilgileri");
            }
            if (varis == 46)
            {
                MessageBox.Show("  varış süresi  1 sa 45d", "Uçuş bilgileri");
            }
            if (varis == 47)
            {
                MessageBox.Show("  varış süresi  1 sa 5d ", "Uçuş bilgileri");
            }
            if (varis == 48)
            {
                MessageBox.Show("  varış süresi  2s 15d", "Uçuş bilgileri");
            }
            
        }

        private void ComboBoxvaris_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            varis = ComboBoxvaris.SelectedIndex;
        }


        /*illerin kordinat verileri ve hava alanı isimleri ile noktayı taşıma */


        static Point konumDondur(int il)
        {
            List<(int X, int Y)> GetPointList()
            {
                return new List<(int X, int Y)>
        {
            (200, 90),
            (15, 140),
            (315, 140),
            (300, 190),
            (390, 180),
            (120, 140),
            (560, 90),
            (100, 140),
            (300, 60),
            (145, 205),
            (550, 20),
            (505, 10),
            (55, 170),
            (55, 90),
            (200, 15),
            (490, 180),
            (470, 130),
            (90, 180),
            (455, 165),
            (430, 145),
            (430, 95),
            (490, 65),
            (355, 215),
            (595, 185),
            (320, 245),
            (140, 170),
            (580, 75),
            (345, 170),
            (540, 55),
            (240, 10),
            (205, 175),
            (100, 110),
            (375, 145),
            (465, 200),
            (60, 210),
            (500, 120),
            (275, 135),
            (365, 45),
            (475, 35),
            (325, 32),
            (515, 165),
            (280, 5),
            (345, 90),
            (335, 60),
            (445, 45),
            (565, 150),
            (405, 215),
            (180, 25),
            (515, 200)
        };
            }

            List<(int X, int Y)> pointList = GetPointList();

            return new Point(pointList[il].X, pointList[il].Y);
        }





    }




}
