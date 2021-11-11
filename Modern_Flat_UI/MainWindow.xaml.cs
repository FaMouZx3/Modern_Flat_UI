using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Drawing;
using LiveChartsCore.SkiaSharpView.Drawing.Geometries;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace Modern_Flat_UI
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private string percent = "0";
        public string Percent
        {
            get
            {
                return percent;
            }

            set
            {
                if (percent != value)
                {
                    percent = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private double progress;
        public double Progress
        {
            get
            {
                return progress;
            }

            set
            {
                if (progress != value)
                {
                    progress = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private readonly Random _r = new Random();

        public List<ISeries> Series { get; set; } = new List<ISeries>
        {
            // use the second argument type to specify the geometry to draw for every point
            // there are already many predefined geometries in the
            // LiveChartsCore.SkiaSharpView.Drawing.Geometries namespace
            new LineSeries<double, RoundedRectangleGeometry>
            {
                Values = new List<double> { 3, 3, -3, -2, -4, -3, -1, -6, 0, 2, -3, 7, 12, 4, -10 },
                Fill = null,
                Stroke = new SolidColorPaint(SKColors.DarkSeaGreen, 3),
                LineSmoothness = 1,
                GeometryStroke = new SolidColorPaint(SKColors.Transparent),
                GeometryFill = new SolidColorPaint(SKColors.DarkSeaGreen),
                GeometrySize = 0,
                Name = "Pokemon"
            },

            // you can also define your own SVG geometry
            new LineSeries<double, OvalGeometry>
            {
                Values = new List<double> { -2, 2, 1, 3, -1, 4, 3, 10, 7, 10, 7, 9, 2, 5, 8 },

                Stroke = new SolidColorPaint(SKColors.DarkBlue, 3),
                Fill = null,
                LineSmoothness = 1,
                GeometryStroke = new SolidColorPaint(SKColors.Transparent),
                GeometryFill = new SolidColorPaint(SKColors.DarkTurquoise),
                GeometrySize = 0,
                Name = "Yu-Gi-Oh"
            },

            new LineSeries<double, OvalGeometry>
            {
                Values = new List<double> { 1, 2, 4, 10, 20, 15, 9, -5, -12, 3, 6, 15, -1, 0, 4 },

                Stroke = new SolidColorPaint(SKColors.DarkGray, 3),
                Fill = null,
                LineSmoothness = 1,
                GeometryStroke = new SolidColorPaint(SKColors.Transparent),
                GeometryFill = new SolidColorPaint(SKColors.DarkGray),
                GeometrySize = 0,
                Name = "Magic"
            }
        };

        public MainWindow()
        {
            this.DataContext = this;
            InitializeComponent();
            btn_Dashboard.Focus();
            Progress = 67 * 3.6;
            Percent = "67";
        }

        private void Close_App(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void ReloadGraph(object sender, RoutedEventArgs e)
        {
            foreach (var item in Series)
            {
                if (item.Values is List<double>)
                {
                    List<double> values = (List<double>)item.Values;
                    List<double> newValues = new List<double>();

                    foreach (var val in values)
                    {
                        newValues.Add(Convert.ToDouble(_r.Next(-20, 20)));
                    }

                    item.Values = newValues;
                }
            }
        }
    }
}
