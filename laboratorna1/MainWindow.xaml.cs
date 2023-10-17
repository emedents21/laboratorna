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

namespace laboratorna1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Tree tr;

            string nname = name.Text;
            int aage;
            double hheight;
     

            if (int.TryParse(age.Text, out aage) && double.TryParse(height.Text, out hheight))
            {
                if (aage < 0 || hheight < 0)
                {
                    result.Text = $"Неправильно ти подав данi!";

                }
                else if (name.Text == "")
                {
                    result.Text = $"Неправильно ти подав данi!!!!!!!!";

                }
                else
                {
                    tr = new Tree(nname, hheight, aage);
                    double averageGrowth = tr.CalculateAverageGrowthPerYear();
                    result.Text = $"Середній приріст деревини в рік: {averageGrowth} см/рок";
                }
            }
            else if(int.TryParse(age.Text, out aage))
            {
                if (aage < 0)
                {
                    result.Text = $"Неправильно ти подав данi!";
                }
                else
                {
                    tr = new Tree(nname, aage);
                    result.Text = $"Упс, певно ви забили ввести висоту дерева!";
                }
            }
            else if(double.TryParse(height.Text, out hheight))
            {
                if (hheight < 0)
                {
                    result.Text = $"Неправильно ти подав данi!";

                }
                else
                {
                    tr = new Tree(nname, hheight);
                    result.Text = $"Упс, певно ви забили ввести вiк дерева!";
                }
            }
            else
            {
                result.Text = "Помилка: Невірний формат введених даних.";
            }


         
        }
    }
}
