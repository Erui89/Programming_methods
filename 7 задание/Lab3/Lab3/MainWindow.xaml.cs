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
            double count = 0;
            double summa = 0;
            double sr = 0;
            double summa_otklon = 0;
            double sr_otkl = 0;
            double[] array = new double[N];
            Random random = new Random();
            listBox1.SelectionMode = System.Windows.Controls.SelectionMode.Multiple;
            listBox1.SelectedIndex = -1;
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox1.Items.Add(" ");
            for (int indexArray = 0; indexArray < N; indexArray++)
            {
                array[indexArray] = 5 + random.Next(30);
                listBox1.Items.Add(array[indexArray]);
            }
            for (int indexArray = 1; indexArray < N - 1; indexArray++)
            {
                if (array[indexArray] > array[indexArray - 1] && array[indexArray] > array[indexArray + 1])
                {
                    count++;
                }
            }
           
            listBox2.Items.Add("Задание 7");
            for (int indexArray = 0; indexArray < N; indexArray++)
            {
                summa = array[indexArray] + summa;
            }
            listBox2.Items.Add("Среднее значение элементов: ");
            sr = summa / N;
            listBox2.Items.Add(sr);
            listBox2.Items.Add("****************************************************");
            for (int indexArray = 0; indexArray < N; indexArray++)
            {
                summa_otklon = summa_otklon + (Math.Abs(array[indexArray] - sr));
            }
            sr_otkl = summa_otklon / N;
            listBox2.Items.Add("Среднее значение отклонения от среднего: ");
            listBox2.Items.Add(sr_otkl);
            listBox2.Items.Add("****************************************************");
            for (int indexArray = 0; indexArray < N; indexArray++)
            {
                if (Math.Abs(array[indexArray] - sr) > sr_otkl / 2)
                {
                    array[indexArray] = sr;
                }
                listBox2.Items.Add(array[indexArray]);
            }
            listBox2.Items.Add("****************************************************");
        }

        

    }
}
