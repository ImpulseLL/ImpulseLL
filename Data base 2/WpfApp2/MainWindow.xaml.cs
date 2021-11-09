﻿using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new HotelsPage());
            Manager.MainFrame = MainFrame;

            ImportTours();
        }
        private void ImportTours()
        {
            var fileData = File.ReadAllLines(@"\\192.168.1.1\студенты\185\Аносов\Новая папка(4)\Лист Microsoft Excel(4).txt");
            var images = Directory.GetFiles(@"C:\Users\Администратор\Pictures\Новая папка\rila-324966_960_720.jpg");

            foreach (var line in fileData)
            {
                var data = line.Split('\t');

                var tempTour = new Tour
                {
                    Name = data[0].Replace("\"", ""),
                    TicketCount = int.Parse(data[2]),
                    Price = decimal.Parse(data[3]),
                    IsActual = (data[4] == "0") ? false : true
                };

                foreach (var tourType in data[5].Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries))
                {
                    var currentType = ToursBaseEntities.GetContext().Type.ToList().FirstOrDefault(p => p.Name == tourType);
                    if (currentType != null)
                        tempTour.Type.Add(currentType);
                }
                try
                {
                    tempTour.ImagePreview = File.ReadAllBytes(images.FirstOrDefault(p => p.Contains(tempTour.Name)));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                ToursBaseEntities.GetContext().Tour.Add(tempTour);
                ToursBaseEntities.GetContext().SaveChanges();

            }
        }
    }
}