using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
namespace WpfApp16;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        RedSlider.ValueChanged += (s, e) => Newcolor();
        GreenSlider.ValueChanged += (s, e) => Newcolor();
        BlueSlider.ValueChanged += (s, e) => Newcolor();
    }
    private void Newcolor()
    {
        byte red = (byte)RedSlider.Value;
        byte green = (byte)GreenSlider.Value;
        byte blue = (byte)BlueSlider.Value;
        Палитра.Background = new SolidColorBrush(Color.FromRgb(red, green, blue));
    }
}