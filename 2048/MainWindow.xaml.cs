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

namespace _2048
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Button button1 = new Button();

        private Button[,] blocks = new Button[4, 4];
        public MainWindow()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(_keyboardEvent);
        }

        private void _keyboardEvent(object sender, KeyEventArgs e)
        {
            switch (e.Key.ToString())
            {

                case "Right":

                    for (int i = 0; i < 4; i++)
                    {
                        
                    }

                    

                    break;

            }
        }
    }
}
