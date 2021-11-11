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

namespace Modern_Flat_UI
{
    /// <summary>
    /// Interaction logic for RadialProgressbar.xaml
    /// </summary>
    public partial class RadialProgressbar : UserControl
    {
        public static readonly DependencyProperty ProgressProperty = DependencyProperty.Register("Progress", typeof(double), typeof(RadialProgressbar), new FrameworkPropertyMetadata(0.0));
        public double Progress
        {
            get
            {
                return (double)GetValue(ProgressProperty);
            }

            set
            {
                SetValue(ProgressProperty, value);
            }
        }

        public static readonly DependencyProperty PercentContentProperty = DependencyProperty.Register("PercentContent", typeof(string), typeof(RadialProgressbar), new FrameworkPropertyMetadata(string.Empty));
        public string PercentContent
        {
            get
            {
                return (string)GetValue(PercentContentProperty);
            }

            set
            {
                SetValue(PercentContentProperty, value);
            }
        }

        public static readonly DependencyProperty FillProperty = DependencyProperty.Register("Fill", typeof(Brush), typeof(RadialProgressbar), new FrameworkPropertyMetadata(new SolidColorBrush(Colors.Red)));
        public Brush Fill
        {
            get
            {
                return (Brush)GetValue(FillProperty);
            }

            set
            {
                SetValue(FillProperty, value);
            }
        }

        public static readonly DependencyProperty ThicknessProperty = DependencyProperty.Register("Thickness", typeof(double), typeof(RadialProgressbar), new FrameworkPropertyMetadata(0.0));
        public double Thickness
        {
            get
            {
                return (double)GetValue(ThicknessProperty);
            }

            set
            {
                SetValue(ThicknessProperty, value);
            }
        }

        public static readonly DependencyProperty CenterBackgroundProperty = DependencyProperty.Register("CenterBackground", typeof(Brush), typeof(RadialProgressbar), new FrameworkPropertyMetadata(new SolidColorBrush((Color)ColorConverter.ConvertFromString("#222"))));
        public Brush CenterBackground
        {
            get
            {
                return (Brush)GetValue(CenterBackgroundProperty);
            }

            set
            {
                SetValue(CenterBackgroundProperty, value);
            }
        }

        public static readonly DependencyProperty ContentForegroundProperty = DependencyProperty.Register("ContentForeground", typeof(Brush), typeof(RadialProgressbar), new FrameworkPropertyMetadata(new SolidColorBrush((Color)ColorConverter.ConvertFromString("#fff"))));
        public Brush ContentForeground
        {
            get
            {
                return (Brush)GetValue(ContentForegroundProperty);
            }

            set
            {
                SetValue(ContentForegroundProperty, value);
            }
        }

        public static readonly DependencyProperty PercentUnitContentProperty = DependencyProperty.Register("PercentUnitContent", typeof(string), typeof(RadialProgressbar), new FrameworkPropertyMetadata(string.Empty));
        public string PercentUnitContent
        {
            get
            {
                return (string)GetValue(PercentUnitContentProperty);
            }

            set
            {
                SetValue(PercentUnitContentProperty, value);
            }
        }


        public RadialProgressbar()
        {
            InitializeComponent();
        }
    }
}
