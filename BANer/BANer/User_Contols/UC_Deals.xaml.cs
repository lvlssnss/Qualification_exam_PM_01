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
    public partial class UC_Deals : UserControl
    {
        BANerEntities _context = new BANerEntities();
        public UC_Deals()
        {
            InitializeComponent();
            UpdateData();
        }
        public void UpdateData()
        {
            if (Filt_Post.SelectedItem == null)
            {
                Filt_Post.Items.Add("Любой");
                Filt_Post.Items.Add("Открыта");
                Filt_Post.Items.Add("Закрыта");
                Filt_Post.SelectedIndex = 0;
            }
            if (Sort_Name.SelectedItem == null)
            {
                Sort_Name.Items.Add("по убыванию");
                Sort_Name.Items.Add("по возрастанию");
                Sort_Name.SelectedIndex = 0;
            }
            var users = _context.Deal.ToList();
            if (Filt_Post.SelectedIndex == 0)
            {
                if (Sort_Name.SelectedIndex == 0)
                {
                    users = (List<Deal>)users.OrderByDescending(d=>d.price).ToList();
                }
                else
                {
                    users = (List<Deal>)users.OrderBy(d => d.price).ToList();
                }
            }
            else
            {
                users = users.Where(d => d.status == Filt_Post.SelectedValue.ToString()).ToList();
                if (Sort_Name.SelectedIndex == 0)
                {
                    users = (List<Deal>)users.OrderByDescending(d => d.price).ToList();
                }
                else
                {
                    users = (List<Deal>)users.OrderBy(d => d.price).ToList();
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
            New_Deal newpage = new New_Deal(_context, this);
            newpage.ShowDialog();
        }

        private void Edit_del_Order_Click(object sender, RoutedEventArgs e)
        {
            Edit_Deal edit = new Edit_Deal(_context, this, sender);
            edit.ShowDialog();
        }
    }
}
