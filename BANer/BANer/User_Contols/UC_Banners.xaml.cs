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
    /// Логика взаимодействия для UC_Banners.xaml
    /// </summary>
    public partial class UC_Banners : UserControl
    {
        BANerEntities _context = new BANerEntities();
        public UC_Banners()
        {
            InitializeComponent();
            UpdateData();
            if (RoleStorage.role == 2 || RoleStorage.role == 4)
            {
                var parentControl = New_User.Parent as Panel;
                if (parentControl!=null)
                {
                    parentControl.Children.Remove(New_User);
                }
            }
        }

        private void New_User_Click(object sender, RoutedEventArgs e)
        {
            New_Banner newpage = new New_Banner(_context, this);
            newpage.ShowDialog();
        }
        public void UpdateData()
        {
            if (Filt_Post.SelectedItem == null)
            {
                Filt_Post.Items.Add("Любой");
                Filt_Post.Items.Add("Арендован");
                Filt_Post.Items.Add("Не арендован");
                Filt_Post.SelectedIndex = 0;
            }
            if (Sort_Name.SelectedItem == null)
            {
                Sort_Name.Items.Add("Стоимости");
                Sort_Name.Items.Add("Удаленности");
                Sort_Name.SelectedIndex = 0;
            }
            if (value.SelectedItem == null)
            {
                value.Items.Add("по убыванию");
                value.Items.Add("по возрастанию");
                value.SelectedIndex = 0;
            }
            var banners = _context.Banner.ToList();
            if (Filt_Post.SelectedIndex==0)
            {
                if (Sort_Name.SelectedIndex==0)
                {
                    if (value.SelectedIndex==0)
                    {
                        banners = banners.OrderByDescending(b => b.price).ToList();
                    }
                    else
                    {
                        banners = banners.OrderBy(b => b.price).ToList();
                    }
                }
                else
                {
                    if (value.SelectedIndex == 0)
                    {
                        banners = banners.OrderByDescending(b => b.lenght).ToList();
                    }
                    else
                    {
                        banners = banners.OrderBy(b => b.lenght).ToList();
                    }
                }
            }
            else
            {
                banners = banners.Where(b => b.status == Filt_Post.SelectedValue.ToString()).ToList();
                if (Sort_Name.SelectedIndex == 0)
                {
                    if (value.SelectedIndex == 0)
                    {
                        banners = banners.OrderByDescending(b => b.price).ToList();
                    }
                    else
                    {
                        banners = banners.OrderBy(b => b.price).ToList();
                    }
                }
                else
                {
                    if (value.SelectedIndex == 0)
                    {
                        banners = banners.OrderByDescending(b => b.lenght).ToList();
                    }
                    else
                    {
                        banners = banners.OrderBy(b => b.lenght).ToList();
                    }
                }
            }
            LV_Users.ItemsSource = banners;
        }
        private void Filt_Post_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateData();
        }

        private void Sort_Name_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateData();
        }

        private void value_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateData();
        }
        private void Edit_del_Order_Click(object sender, RoutedEventArgs e)
        {
            if (RoleStorage.role == 2)
            {
                MessageBox.Show("Недостаточно доступа");
            }
            else
            {
                Edit_Banner edit = new Edit_Banner(_context, this, sender);
                edit.ShowDialog();
            }
           
        }
    }
}
