using BANer.User_Contols;
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
using System.Windows.Shapes;

namespace BANer.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Window
    {
        BANerEntities _context = new BANerEntities();
        public MainPage()
        {
            InitializeComponent();
            if (RoleStorage.role != 1)
            {
                var parentControl = BtnUsers.Parent as Panel;
                if (parentControl!=null)
                {
                    if (RoleStorage.role==3 || RoleStorage.role == 4)
                    {
                        parentControl.Children.Remove(BtnUsers);
                        if (RoleStorage.role==4)
                        {
                            parentControl.Children.Remove(BtnOrders);
                        }
                    }
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }
        //свернуть приложение
        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
        //закрыть приложение
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
        private void RadioButton_Checked(object sender, RoutedEventArgs e) //сотрудники
        {
            MoveButtons();
            UC_Workers uc = new UC_Workers();
            LV_User_ControlPanel.Children.Add(uc);

        }
        private void RadioButton_Checked_1(object sender, RoutedEventArgs e) //Клиенты
        {
            MoveButtons();
            UC_Clients uc = new UC_Clients();
            LV_User_ControlPanel.Children.Add(uc);
        }
        private void RadioButton_Checked_2(object sender, RoutedEventArgs e) //Баннеры
        {
            MoveButtons();
            UC_Banners uc = new UC_Banners();
            LV_User_ControlPanel.Children.Add(uc);
        }
        private void RadioButton_Checked_3(object sender, RoutedEventArgs e) //Сделки
        {
            if (_context.Banner.ToList().Count==0 || _context.worker.Where(t=>t.role_id==4).ToList().Count==0||_context.Client.ToList().Count==0)
            {
                MessageBox.Show("Вы не можете создать сделку, пока у вас не создан клиент, работник Call-центра и баннер");
            }
            else
            {
                MoveButtons();
                UC_Deals uc = new UC_Deals();
                LV_User_ControlPanel.Children.Add(uc);
            }
        }
        private void MoveButtons()
        {
            Grid.SetRow(buttons, 0);
            Grid.SetColumn(buttons, 1);
            this.Width = 1280;
            LV_User_ControlPanel.Children.Clear();
        }
    }
}
