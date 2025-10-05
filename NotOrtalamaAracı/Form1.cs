using System.Linq.Expressions;

namespace NotOrtalamaAracı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOrtalamaHesaplama_Click(object sender, EventArgs e)
        {
            string isim = textBoxOgrencıAdı.Text;
            int matematik = Convert.ToInt32(textBoxMatematikNotu.Text);
            int fizik = Convert .ToInt32(textBoxFizikNotu.Text);
            int türkçe = Convert.ToInt32(textBoxTürkçeNotu.Text);
            int kimya = Convert .ToInt32(textBoxKimyaNotu.Text);
            int felsefe = Convert.ToInt32(textBoxFelsefeNotu.Text);
            int biyoloji = Convert.ToInt32(textBoxBiyolojiNotu.Text);
            int tarih = Convert.ToInt32(textBoxTarihNotu.Text);
            int coğrafya = Convert.ToInt32(textBoxCografyaNotu.Text);
            int DinKültürü = Convert.ToInt32(textBoxDinKültürüNotu.Text);
            int YabancıDil = Convert.ToInt32(textBoxYabancıDilNotu.Text);


            float ortalama = (matematik + fizik + türkçe + kimya + felsefe +biyoloji + tarih + coğrafya + DinKültürü + YabancıDil) / 3f;
            string geçtiMi = "";
            if (ortalama >= 50)
            {
                geçtiMi = "Geçti";
            }
            else
            {
                geçtiMi = "Kaldı";
            }
            label4.Text = $"{isim} adlı öğrencinin not ortalaması: {ortalama} ve geçme durumu: {geçtiMi}";  
            

        }
    }
}
