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
using Lib_3;

namespace LabFirst_Varlamov
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Height += 25;
        }

        private void AboutProgram(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Практическая работа №1.\r\n" +
                "Разработчик: Варламов Артём ИСП-34.\r\n" +
                "Сгенерировать массив заполненный случайными вещественными числами, распределенных в диапазоне от -4 до 7.\r\n" +
                "Вычислить для чисел > 0 извлечь корень, а для чисел < 0 возвести в квадрат.\r\n" +
                "На экран необходимо выводить сгенерированные числа и результат расчета функции на разных строках.\r\n" +
                "В классе реализовать статический метод с именем SignSquare.");
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Generate(object sender, RoutedEventArgs e)
        {

        }
    }
}
