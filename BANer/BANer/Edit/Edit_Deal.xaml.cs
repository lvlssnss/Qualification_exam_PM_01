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

namespace BANer.Edit
{
    /// <summary>
    /// Логика взаимодействия для New_Worker.xaml
    /// </summary>
    public partial class Edit_Deal : Window
    {
        private BANerEntities _context;
        private UC_Deals UC_Workers;
        private Deal worker;
        public Edit_Deal(BANerEntities context,UC_Deals uC_Workers, object o)
        {
            InitializeComponent();
            this._context = context;
            this.UC_Workers = uC_Workers;
            worker = (o as Button).DataContext as Deal;
            var banners = _context.Banner.Where(t => t.status == "Не арендован").ToList();
            Banner.Items.Add($"{worker.Banner.Fullname}");
            Banner.SelectedItem = worker.Banner.Fullname;
            foreach (var banner in banners)
            {
                if (Banner.SelectedItem!=banner.Fullname)
                {
                    Banner.Items.Add($"{banner.Fullname}");
                }
            }
            var clients = _context.Client.ToList();
            foreach (var client in clients)
            {
                Client.Items.Add($"{client.FIO}");
                if (client.id == worker.Client_id)
                {
                    Client.SelectedItem = client.FIO;
                }
            }
            var workers = _context.worker.Where(w=>w.role_id==4).ToList();
            foreach (var worker1 in workers)
            {
                Worker.Items.Add($"{worker1.FIO}");
                if (worker1.id == worker.Worker_id)
                {
                    Worker.SelectedItem = worker1.FIO;
                }
            }
            Period.Text = worker.period.ToString();
            Status.Items.Add("Открыта");
            Status.Items.Add("Закрыта");
            Status.SelectedItem = worker.status;
            Banner.PreviewMouseLeftButtonDown += OffCombobox;
            Client.PreviewMouseLeftButtonDown += OffCombobox;
            Worker.PreviewMouseLeftButtonDown += OffCombobox;
            Status.PreviewMouseLeftButtonDown += OffCombobox;
            Period.IsReadOnly = true;
            itogo.Text = $"{worker.ITOGO}";
        }
        private void OffCombobox(object sender, MouseButtonEventArgs e)
        {
            e.Handled = true;
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }
        private void uPreviewKeyDown(object sender, KeyEventArgs e)
        {
            var targetElement = e.OriginalSource as FrameworkElement;
            if (targetElement != null)
            {
                if ((targetElement.Name == "Period") && !(e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key == Key.Back))
                {
                    // разрешаем ввод цифр для объекта с именем "price","Count"
                    e.Handled = true;
                    return;
                }
            }
            if ((e.Key >= Key.D0 && e.Key <= Key.D9) || (e.Key >= Key.A && e.Key <= Key.Z) || (e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9) || (e.Key == Key.OemQuestion || e.Key == Key.OemPlus || e.Key == Key.OemMinus || e.Key == Key.OemOpenBrackets || e.Key == Key.OemCloseBrackets || e.Key == Key.OemPipe || e.Key == Key.OemSemicolon || e.Key == Key.OemQuotes || e.Key == Key.OemComma || e.Key == Key.OemPeriod || e.Key == Key.OemBackslash || e.Key == Key.Oem3 || e.Key == Key.Add || e.Key == Key.Subtract || e.Key == Key.Multiply || e.Key == Key.Divide) || e.Key == Key.Back)
            {
                if (e.Key == Key.LeftAlt)
                {
                    // "Alt" нажата, проверяем, нажата ли еще клавиша в сочетании
                    if (Keyboard.Modifiers.HasFlag(ModifierKeys.Alt) && e.Key != Key.System)
                    {
                        // Клавиша в сочетании, отменяем ввод символа
                        e.Handled = true;
                    }
                }
            }
            else
            {
                e.Handled = true;
            }
        }



        private void DeleteUser_Click(object sender, RoutedEventArgs e)
        {
            if ((MessageBox.Show("Вы уверены, что хотите удалить сделку?", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Warning)) == MessageBoxResult.Yes)
            {
                _context.Deal.Remove(worker);
                _context.Banner.FirstOrDefault(p => p.id == worker.Banner_id).status = "Не арендован";
                _context.SaveChanges();
                UC_Workers.UpdateData();
                this.Close();
            }
        }

        private void MakeChanges_Click(object sender, RoutedEventArgs e)
        {
            if ((MessageBox.Show("Вы уверены, что хотите изменить информацию?", "Изменение", MessageBoxButton.YesNo, MessageBoxImage.Warning)) == MessageBoxResult.Yes)
            {
                // Изменяем нужные поля
                var worker1 = _context.worker.Where(r=>r.role_id==4).ToList().FirstOrDefault(p=>p.FIO==Worker.SelectedValue.ToString());
                worker.Worker_id = worker1.id;
                worker.status = Status.SelectedValue.ToString();
                if (Status.SelectedValue== "Закрыта")
                {
                    var b = _context.Banner.FirstOrDefault(p => p.id == worker.Banner_id).status = "Не арендован";
                }
                else
                {
                    var b = _context.Banner.FirstOrDefault(p => p.id == worker.Banner_id).status = "Арендован";
                }
                _context.SaveChanges();
                UC_Workers.UpdateData();
                this.Close();
            }
        }

        private void EditUser_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Для изменения информации выберите новые значения статуса и сотрудника");
            EditUser.Visibility = Visibility.Hidden;
            Status.PreviewMouseLeftButtonDown -= OffCombobox;
            Worker.PreviewMouseLeftButtonDown -= OffCombobox;
        }
        private void Period_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (int.TryParse(Period.Text, out int period))
            {
                string name = Banner.SelectedValue.ToString().Split()[0].ToString();
                int km = int.Parse(Banner.SelectedValue.ToString().Split()[1].Substring(0, Banner.SelectedValue.ToString().Split()[1].Length - 2));
                var existbanner = _context.Banner.FirstOrDefault(b => b.hightway_name == name && b.lenght == km);
                if (existbanner != null)
                {
                    itogo.Text = $"{existbanner.price * period} РУБЛЕЙ";
                }
            }
            else
            {
                itogo.Text = $"0 РУБЛЕЙ";
            }
        }
        private void Password_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (e.Text == "0" && textBox.SelectionStart == 0)
            {
                e.Handled = true;
            }
        }
    }
}
