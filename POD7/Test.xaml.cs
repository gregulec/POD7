using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace POD7
{
    /// <summary>
    /// Logika interakcji dla klasy Test.xaml
    /// </summary>
    public partial class Test : Page
    {
        string tekst;
        public Test()
        {
            InitializeComponent();
        }

        public string testPojedynczychBitów()
        {
            int jedynki = 0;
            for (int i = 0; i < tekst.Length; i++)
            {
                if (tekst[i] == '1') jedynki = jedynki + 1;
            }
            string losowy;
            if (9725 < jedynki && jedynki < 10275) losowy = "Ciąg spełnia warunek testu pojedynczych bitów. Liczba jedynek "+jedynki;
            else losowy = "Ciąg nie spełnia warunku testu pojedynczych bitów. Liczba jedynek " + jedynki;
            return losowy;
        }

        public string testSerii()
        {
            int i = 0;
            string losowy;
            int l1 = 0, l0 = 0;
            int[] jedynki = new int[6];
            int[] zera = new int[6];
            for (int j = 0; j < 6; j++)
            {
                jedynki[j] = 0;
                zera[j] = 0;
            }
            while (i < tekst.Length)
            {
                if (tekst[i] == 1)
                {
                    l1++;
                    i++;
                }
                else
                {
                    l0++;
                    if (0 < l1 && l1 <= 6) jedynki[l1 - 1] = jedynki[l1 - 1] + 1;
                    else jedynki[5] = jedynki[5] + 1;
                    l1 = 0;
                    i++;
                    if (tekst[i] == 0)
                    {
                        l0++;
                        i++;
                    }
                    else
                    {
                        l1++;
                        if (0 < l0 && l0 <= 6) zera[l1 - 1] = zera[l1 - 1] + 1;
                        else zera[5] = zera[5] + 1;
                        l0 = 0;
                        i++;
                    }
                }
            }
            if (2315 <= jedynki[0] && jedynki[0] <= 2685) jedynki[0] = 1;
            else jedynki[0] = 0;
            if (2315 <= zera[0] && zera[0] <= 2685) zera[0] = 1;
            else zera[0] = 0;

            if (1114 <= jedynki[1] && jedynki[1] <= 1386) jedynki[1] = 1;
            else jedynki[1] = 0;
            if (1114 <= zera[1] && zera[1] <= 1386) zera[1] = 1;
            else zera[1] = 0;

            if (527 <= jedynki[2] && jedynki[2] <= 723) jedynki[2] = 1;
            else jedynki[2] = 0;
            if (527 <= zera[2] && zera[2] <= 723) zera[2] = 1;
            else zera[2] = 0;

            if (240 <= jedynki[3] && jedynki[3] <= 384) jedynki[3] = 1;
            else jedynki[3] = 0;
            if (240 <= zera[3] && zera[3] <= 384) zera[3] = 1;
            else zera[3] = 0;

            if (103 <= jedynki[4] && jedynki[4] <= 209) jedynki[4] = 1;
            else jedynki[4] = 0;
            if (103 <= zera[4] && zera[4] <= 209) zera[4] = 1;
            else zera[4] = 0;

            if (103 <= jedynki[5] && jedynki[5] <= 209) jedynki[5] = 1;
            else jedynki[5] = 0;
            if (103 <= zera[5] && zera[5] <= 209) zera[5] = 1;
            else zera[5] = 0;

            if (jedynki[0] == 1 && jedynki[1] == 1 && jedynki[2] == 1 && jedynki[3] == 1 && jedynki[4] == 1 && jedynki[5] == 1 && zera[0] == 1 && zera[1] == 1 && zera[2] == 1 && zera[3] == 1 && zera[4] == 1 && zera[5] == 1) losowy = "Ciąg spełnia warunek testu serii";
            else losowy = "Ciąg nie spełnia warunku testu serii";
            return losowy;
        }

        public string testDlugiejSerii()
        {
            int one = 0, zero = 0,seria=0;
            string losowy;
            for (int i = 0; i < tekst.Length; i++)
            {
                if (tekst[i] == '0') { one = 0; zero++; }
                else { zero = 0; one++; }
                if (one >= 26 || zero >= 26) seria++;
            }
            if (seria==0) losowy="Ciąg spełnia warunku testu długiej serii. Liczba serii "+seria;
            else losowy="Ciąg nie spełnia warunek testu długiej serii. Liczba serii "+seria;
            return losowy;
        }

        public string testPokerowy()
        {
            string[] bin = { "0000","0001","0010","0011","0100","0101","0110","0111"
                            ,"1000","1001","1010","1011","1100","1101","1110","1111"};
            double[] number = new double[16];
            string tmp;
            double sum = 0; ;

            for (int i = 0; i < tekst.Length; i += 4)
            {
                tmp = tekst.Substring(i, 4);
                for (int j = 0; j < 16; j++)
                {
                    if (tmp == bin[j]) number[j]++;
                }
            }
            for (int i = 0; i < 16; i++)
            {
                sum = sum + Math.Pow(number[i], 2.0);
            }
            double w = 0;
            w=0.0032 * sum - 5000;
            string losowy;
            if(2.16<w && w <46.17) losowy = "Ciąg spełnia warunek testu pokerowego. X= "+w;
            else losowy = "Ciąg nie spełnia waruneku testu pokerowego. X= "+w;
            return losowy;
        }

        private void test_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.DefaultExt = ".txt";
            dlg.ShowDialog();
            tekst = System.IO.File.ReadAllText(dlg.FileName);
            test1.Content = testPojedynczychBitów();
            test2.Content = testSerii();
            test3.Content = testDlugiejSerii();
            test4.Content = testPokerowy();
            string testy = "";
            testy = testy + test1.Content;
            testy = testy + test2.Content;
            testy = testy + test3.Content;
            testy = testy + test4.Content;
            System.IO.File.WriteAllText(@"C:\Users\Public\Wynik testu.txt", testy);
        }

        private void dok_Click(object sender, RoutedEventArgs e)
        {
            Dokumentacja nowa = new Dokumentacja();
            this.NavigationService.Navigate(nowa);        
        }
    }
}
