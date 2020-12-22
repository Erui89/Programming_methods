﻿using System;

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
            double Z = Convert.ToInt32(textBox3.Text);
            int N = Convert.ToInt32(textBox1.Text);
            
            double summa = 0;
            double sr = 0;
            double percent = Convert.ToInt32(textBox2.Text);

            double summa_otkl = 0;
            double sr_otkl = 0;
            double L_sr_otkl = 0;

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
            listBox2.Items.Add("Задание 9 ");
            for (int indexArray = 0; indexArray < N; indexArray++)
            {
                summa = array[indexArray] + summa;
            }
            sr = summa / N;
            listBox2.Items.Add("Среднее значение элементов: ");
            listBox2.Items.Add(sr);
            listBox2.Items.Add("***************************************************");
            for (int indexArray = 0; indexArray < N; indexArray++)
            {
                summa_otkl = summa_otkl + (Math.Abs(array[indexArray] - sr));
            }
            sr_otkl = summa_otkl / N;
            listBox2.Items.Add("Среднее значение отклонения: ");
            listBox2.Items.Add(sr_otkl);
            listBox2.Items.Add("***************************************************");
            L_sr_otkl = ((sr_otkl / 100) * percent);
            for (int indexArray = 0; indexArray < N; indexArray++)
            {
                if (Math.Abs(array[indexArray] - sr) > L_sr_otkl)
                {
                    array[indexArray] = Z;
                }
                listBox2.Items.Add(array[indexArray]);
            }
            listBox2.Items.Add("***************************************************");
        }

    }
}
