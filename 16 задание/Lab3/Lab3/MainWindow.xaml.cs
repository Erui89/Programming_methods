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

namespace Lab3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnTasks_Click(object sender, RoutedEventArgs e)
        {
            int N = Convert.ToInt32(textBox1.Text);

            int[] array = new int[N];
            Random random = new Random();
            listBox1.SelectionMode = System.Windows.Controls.SelectionMode.Multiple;
            listBox1.SelectedIndex = -1;
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox1.Items.Add(" ");
            for (int indexArray = 0; indexArray < 1; indexArray++)
            {
                array[indexArray] = 5 + random.Next(30);
                listBox1.Items.Add(array[indexArray]);
            }
            
            listBox2.Items.Add("Задание 16");
            Random rand = new Random();
            int loss = 0;
            for (int indexArray = 0; indexArray < N - 1; indexArray++)
            {
                listBox2.Items.Add("Исходное число: " + array[indexArray]);
                loss = 5 + rand.Next(10);
                listBox2.Items.Add("Ущерб: " + loss);
                array[indexArray + 1] = array[indexArray] - loss;
                listBox2.Items.Add("Ответ: " + array[indexArray + 1]);
            }
            listBox2.Items.Add("*************************************************");


        }
    }
}
