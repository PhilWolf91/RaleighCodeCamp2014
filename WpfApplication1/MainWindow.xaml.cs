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
using NLog;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Person person = new Person();
        Logger logger = LogManager.GetLogger("MainWindow");

        public MainWindow()
        {
            InitializeComponent();
            DataContext = person;
        }

        private void enterNum1_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                person.Num1 = Convert.ToInt32(enterNum1.Text);
            }
            catch(FormatException FormatEx)
            {
                logger.Error("Format Exception,  unable to format a NULL value" + Environment.NewLine + FormatEx.ToString());
            }
        }

        public void enterNum2_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                person.Num2 = Convert.ToInt32(enterNum2.Text);
            }
            catch(FormatException FormatEx)
            {
                logger.Error("Format Exception,  unable to format a NULL value" + Environment.NewLine + FormatEx.ToString());
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            person.MagicNumber = person.Num1 + person.Num2 + 5;
            person.PersonName = enterFullName.Text;
            person.NumsAdded = person.Num1 + person.Num2;
            person.NumsMultiplied = person.Num1 * person.Num2;

        }

        private void enterFullName_TextChanged(object sender, TextChangedEventArgs e)
        {
                //person.PersonName = enterFullName.Text;
        }
    }
}
