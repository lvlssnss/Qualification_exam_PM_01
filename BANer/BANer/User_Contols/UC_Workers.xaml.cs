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
    /// Логика взаимодействия для UC_Workers.xaml
    /// </summary>
    public partial class UC_Workers : UserControl
    {
        BANerEntities _context = new BANerEntities();
        public UC_Workers()
        {
            InitializeComponent();
            UpdateData();
        }
        public void UpdateData()
        {
            if (Filt_Post.SelectedItem == null)
            {
                Filt_Post.Items.Add("Все должности");
                var posts = _context.Role.Where(p => p.id != 1).Select(p => p.name).ToList();
                foreach (var post in posts)
                {
                    Filt_Post.Items.Add(post);
                }
                Filt_Post.SelectedIndex = 0;
            }
            if (Sort_Name.SelectedItem == null)
            {
                Sort_Name.Items.Add("Сортировка от А до Я");
                Sort_Name.Items.Add("Сортировка от Я до А");
                Sort_Name.SelectedIndex = 0;
            }
            var users = _context.worker.Where(u => u.role_id != 1).ToList();
            if (Sort_Name.SelectedIndex == 0)
            {
                users = users.OrderBy(u => u.FIO).ToList();
                if (Filt_Post.SelectedIndex != 0)
                {
                    users = users.Where(p => p.Role.name == Filt_Post.SelectedItem.ToString()).ToList();
                }
            }
            else
            {
                users = users.OrderByDescending(u => u.FIO).ToList();
                if (Filt_Post.SelectedIndex != 0)
                {
                    users = users.Where(p => p.Role.name == Filt_Post.SelectedItem.ToString()).ToList();
                }
            }
            LV_Users.ItemsSource = users;
        }

        private void Filt_Post_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateData();
        }

        private void Sort_Name_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateData();
        }

        private void New_User_Click(object sender, RoutedEventArgs e)
        {
            New_Worker newpage = new New_Worker(_context,this);
            newpage.ShowDialog();
        }

        private void Edit_del_Order_Click(object sender, RoutedEventArgs e)
        {
            Edit_Worker edit = new Edit_Worker(_context, this, sender);
            edit.ShowDialog();
        }
    }
}
