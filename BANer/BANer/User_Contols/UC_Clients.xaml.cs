using BANer.Edit;
using BANer.New;
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

namespace BANer.User_Contols
{
    /// <summary>
    /// Логика взаимодействия для UC_Clients.xaml
    /// </summary>
    public partial class UC_Clients : UserControl
    {
        BANerEntities _context = new BANerEntities();
        public UC_Clients()
        {
            InitializeComponent();
            UpdateData();
            if (RoleStorage.role == 2 || RoleStorage.role == 4)
            {
                var parentControl = New_User.Parent as Panel;
                if (parentControl != null)
                {
                    parentControl.Children.Remove(New_User);
                }
            }
        }
        public void UpdateData()
        {
            if (Filt_Post.SelectedItem == null)
            {
                Filt_Post.Items.Add("Сортировка от А до Я");
                Filt_Post.Items.Add("Сортировка от Я до А");
                Filt_Post.SelectedIndex = 0;
            }
            var clients = _context.Client.ToList();
            if (Filt_Post.SelectedIndex == 0)
            {
                clients = clients.OrderBy(c => c.FIO).ToList();
            }
            else
            {
                clients = clients.OrderByDescending(c => c.FIO).ToList();
            }
            LV_Users.ItemsSource = clients;
        }

        private void New_User_Click(object sender, RoutedEventArgs e)
        {
            New_Client newpage = new New_Client(_context, this);
            newpage.ShowDialog();
        }
        private void Edit_del_Order_Click(object sender, RoutedEventArgs e)
        {
            if (RoleStorage.role == 2)
            {
                MessageBox.Show("Недостаточно доступа");
            }
            else
            { 
                Edit_Client edit = new Edit_Client(_context, this, sender);
                edit.ShowDialog();
            }
        }

        private void Filt_Post_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateData();
        }
    }
}
