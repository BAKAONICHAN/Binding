using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace BindingLesson
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Train_ticket> tickets;
        public MainWindow()
        {
            InitializeComponent();
            tickets = new ObservableCollection<Train_ticket>
            {
                new Train_ticket{
                    Id=1,
                 Number="13",
                 Price=10200,
                 From="Astana",
                 To="Almaty",
                 ArrivalTime=DateTime.Now,
                 DepartureTime=DateTime.Now.AddDays(12)

                },
       
            new Train_ticket {
                Id = 3,
                Number = "14",
                Price = 11000,
                From = "Astana",
                To = "Almaty",
                ArrivalTime = DateTime.Now,
                DepartureTime = DateTime.Now.AddDays(12)
            },
                  new Train_ticket{
                  Id=2,
                 Number="17",
                 Price=2000,
                 From="Astana",
                 To="Almaty",
                 ArrivalTime=DateTime.Now,
                 DepartureTime=DateTime.Now.AddDays(12)
                  }
            };
            DataContiner.ItemsSource = tickets;
        }
        private void DataContiner_AddingNewItem(object sender, AddingNewItemEventArgs e)
        {
            
        }
    }
}
