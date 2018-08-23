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

namespace PracticaLineas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

          
            plnLinea.Points.Add(new Point(120, 220));
            plnLinea.Points.Add(new Point(300, 220));
            plnLinea.Points.Add(new Point(200, 120));
            plnLinea.Points.Add(new Point(120, 220));

            plnLinea2.Points.Add(new Point(125, 220));
            plnLinea2.Points.Add(new Point(125, 320));
            plnLinea2.Points.Add(new Point(290, 320));
            plnLinea2.Points.Add(new Point(290, 220));

            Ventana.Points.Add(new Point(200, 250));
            Ventana.Points.Add(new Point(200, 290));
            Ventana.Points.Add(new Point(240, 290));
            Ventana.Points.Add(new Point(240, 250));
            Ventana.Points.Add(new Point(200, 250));

            Puerta.Points.Add(new Point(150, 250));
            Puerta.Points.Add(new Point(150, 315));
            Puerta.Points.Add(new Point(190, 315));
            Puerta.Points.Add(new Point(190, 250));
            Puerta.Points.Add(new Point(150, 250));

            Tronco.Points.Add(new Point(450, 250));
            Tronco.Points.Add(new Point(450, 315));
            Tronco.Points.Add(new Point(480, 315));
            Tronco.Points.Add(new Point(480, 250));
            Tronco.Points.Add(new Point(450, 250));

            Hojas.Points.Add(new Point(450, 250));
            Hojas.Points.Add(new Point(400, 190));
            Hojas.Points.Add(new Point(450, 100));
            Hojas.Points.Add(new Point(510, 190));
            Hojas.Points.Add(new Point(480, 250));

            pasto1.Points.Add(new Point(320, 360));
            pasto1.Points.Add(new Point(310, 370));
            pasto1.Points.Add(new Point(300, 360));

            pasto2.Points.Add(new Point(120, 360));
            pasto2.Points.Add(new Point(110, 370));
            pasto2.Points.Add(new Point(100, 360));

            pasto3.Points.Add(new Point(520, 360));
            pasto3.Points.Add(new Point(510, 370));
            pasto3.Points.Add(new Point(500, 360));


        }
    }
}
