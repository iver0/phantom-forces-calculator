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

namespace Phantom_Forces_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int rank = 0;
        int credits = 0;
        int cost = 1400;
        int rankUpReward = 205;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Calculate(object sender, RoutedEventArgs e)
        {
            rank = Convert.ToInt32(CurrentRank.Text);
            credits = Convert.ToInt32(CurrentCredits.Text);
            cost = Convert.ToInt32(CurrentCost.Text);
            rankUpReward = ((rank + 1) * 5) + 200;

            if (credits >= cost)
            {
                MessageBox.Show("You already have enough money to buy this weapon!");
            } else
            {
                for (int i = rank; i >= 0; ++i)
                {
                    rank = i + 1;
                    credits += rankUpReward;
                    cost -= 140;
                    rankUpReward += 5;

                    if (credits >= cost)
                    {
                        MessageBox.Show($"You will be able to buy this weapon at {rank} rank!");
                        break;
                    }
                    else if ((cost <= 840) && (credits < cost))
                    {
                        MessageBox.Show($"You will get this weapon at {rank} rank!");
                        break;
                    }
                }
            }
        }
    }
}
