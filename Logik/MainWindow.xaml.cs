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

namespace Logik
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Brush barva1;
        Brush barva2;
        Brush barva3;
        Brush barva4;
        public MainWindow()
        {
            InitializeComponent();
            NastavVariantu0();
        }

        private void Ellipse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Ellipse ellipse = (Ellipse)sender;

            if (ellipse.Fill.ToString() == "#FFD9D9D9")
            {
                ellipse.Fill = Brushes.Red;
            }
            else if (ellipse.Fill == Brushes.Red)
            {
                ellipse.Fill = Brushes.Green;
            }
            else if (ellipse.Fill == Brushes.Green)
            {
                ellipse.Fill = Brushes.Blue;
            }
            else if (ellipse.Fill == Brushes.Blue)
            {
                ellipse.Fill = Brushes.Yellow;
            }
            else if (ellipse.Fill == Brushes.Yellow)
            {
                ellipse.Fill = Brushes.Orange;
            }
            else if (ellipse.Fill == Brushes.Orange)
            {
                ellipse.Fill = Brushes.Purple;
            }
            else
            {
                ellipse.Fill = Brushes.Red;
            }
        }

      

        private void NastavElipsuEnabled(Ellipse ellipse)
        {
            ellipse.IsEnabled = true;
            ellipse.Fill = Brushes.LightGray;
            ellipse.Stroke = Brushes.Black;
            ellipse.Cursor = Cursors.Hand;
        }
        private void NastavElipsuDisabled(Ellipse ellipse)
        {
            ellipse.IsEnabled = false;
            ellipse.Fill = Brushes.White;
            ellipse.Stroke = Brushes.Gray;
        }
        private void NastavVariantu0()
        {
            NastavElipsuEnabled(Ellipse_0_0);
            NastavElipsuEnabled(Ellipse_0_1);
            NastavElipsuEnabled(Ellipse_0_2);
            NastavElipsuEnabled(Ellipse_0_3);

            NastavElipsuDisabled(Ellipse_1_0);
            NastavElipsuDisabled(Ellipse_1_1);
            NastavElipsuDisabled(Ellipse_1_2);
            NastavElipsuDisabled(Ellipse_1_3);

            NastavElipsuDisabled(Ellipse_2_0);
            NastavElipsuDisabled(Ellipse_2_1);
            NastavElipsuDisabled(Ellipse_2_2);
            NastavElipsuDisabled(Ellipse_2_3);

            NastavElipsuDisabled(Ellipse_3_0);
            NastavElipsuDisabled(Ellipse_3_1);
            NastavElipsuDisabled(Ellipse_3_2);
            NastavElipsuDisabled(Ellipse_3_3);

            NastavElipsuDisabled(Ellipse_4_0);
            NastavElipsuDisabled(Ellipse_4_1);
            NastavElipsuDisabled(Ellipse_4_2);
            NastavElipsuDisabled(Ellipse_4_3);

            NastavElipsuDisabled(Ellipse_5_0);
            NastavElipsuDisabled(Ellipse_5_1);
            NastavElipsuDisabled(Ellipse_5_2);
            NastavElipsuDisabled(Ellipse_5_3);

            NastavElipsuDisabled(Ellipse_6_0);
            NastavElipsuDisabled(Ellipse_6_1);
            NastavElipsuDisabled(Ellipse_6_2);
            NastavElipsuDisabled(Ellipse_6_3);

            NastavElipsuDisabled(Ellipse_7_0);
            NastavElipsuDisabled(Ellipse_7_1);
            NastavElipsuDisabled(Ellipse_7_2);
            NastavElipsuDisabled(Ellipse_7_3);

            NastavElipsuDisabled(Ellipse_8_0);
            NastavElipsuDisabled(Ellipse_8_1);
            NastavElipsuDisabled(Ellipse_8_2);
            NastavElipsuDisabled(Ellipse_8_3);

            
        }
        private void NastavbarvyPC()
        {
            Random random = new Random();
            int cislo = random.Next(1, 7);
            if(cislo == 1)
            {
                barva1 = Brushes.Red;
            }
            else if (cislo == 2)
            {
                barva1 = Brushes.Green;
            }
            else if (cislo == 3)
            {
                barva1 = Brushes.Blue;
            }
            else if (cislo == 4)
            {
                barva1 = Brushes.Yellow;
            }
            else if (cislo == 5)
            {
                barva1 = Brushes.Orange;
            }
            else if (cislo == 6)
            {
                barva1 = Brushes.Purple;
            }
        }   
    }
}
