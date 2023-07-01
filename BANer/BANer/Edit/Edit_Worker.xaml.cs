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
    public partial class Edit_Worker : Window
    {
        private BANerEntities _context;
        private UC_Workers UC_Workers;
        private worker worker;
        public Edit_Worker(BANerEntities context,UC_Workers uC_Workers, object o)
        {
            InitializeComponent();
            this._context = context;
            this.UC_Workers = uC_Workers;
            worker = (o as Button).DataContext as worker;
            Login.Text = worker.login;
            Password.Text = worker.password;
            LFMnamefield.Text = worker.FIO;
            var roles = _context.Role.Where(r=>r.id!=1);
            foreach (var role in roles)
            {
                Post.Items.Add(role.name);
                if (role.id == worker.role_id)
                {
                    Post.SelectedItem = role.name;
                }
            }
            Post.PreviewMouseLeftButtonDown += OffCombobox;
            Login.IsReadOnly = Password.IsReadOnly = LFMnamefield.IsReadOnly = Post.IsReadOnly = true;

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
            if (targetElement != null && targetElement.Name == "LFMnamefield")
            {
                // Если элемент имеет имя "LFMnamefield"
                if (e.Key >= Key.D0 && e.Key <= Key.D9)
                {
                    // Запрещаем ввод цифр
                    e.Handled = true;
                }
                else if (e.Key == Key.End || e.Key == Key.PageUp || e.Key == Key.PageDown || e.Key == Key.Insert)
                {
                    // Запрещаем ввод End, Page Up, Page Down и Insert
                    e.Handled = true;
                }
            }
            else
            {
                // Для остальных элементов применяем остальные условия проверки
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
        }



        private void DeleteUser_Click(object sender, RoutedEventArgs e)
        {
            if (_context.Deal.Where(o=>o.Worker_id==worker.id).ToList().Count!=0)
            {
                var z = _context.Deal.Where(u => u.Worker_id == worker.id).Select(p => p.id).ToList();
                MessageBox.Show($"Данный сотрудник является ответсвтвенным за заказы, где идентификатор заказа {string.Join("содержит", string.Join(" ,", z))}\nСначала удалите эти заказы");
            }
            else
            {
                if ((MessageBox.Show("Вы уверены, что хотите удалить сотрудника?", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Warning)) == MessageBoxResult.Yes)
                {
                    _context.worker.Remove(worker);
                    _context.SaveChanges();
                    UC_Workers.UpdateData();
                    this.Close();
                }
            }
        }

        private void MakeChanges_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(LFMnamefield.Text) || string.IsNullOrEmpty(Login.Text) || string.IsNullOrEmpty(Password.Text) || Post.SelectedValue == null)
            {
                MessageBox.Show("Вы ввели не все данные");
            }
            else
            {
                int role_id = _context.Role.FirstOrDefault(r => r.name == Post.SelectedValue.ToString()).id;
                if (_context.worker.FirstOrDefault(w=>w.login== Login.Text && w.password== Password.Text && w.FIO== LFMnamefield.Text && w.role_id==role_id) !=null )
                {
                    MessageBox.Show("У каждого сотрудника индивидуальный логин,  пароль, должность. Измените существующего сотрудника, если его данные изменились или добавьте нового индивидуального сотрудника");
                }
                else
                {
                    if ((MessageBox.Show("Вы уверены, что хотите изменить информацию?", "Изменение", MessageBoxButton.YesNo, MessageBoxImage.Warning)) == MessageBoxResult.Yes)
                    {
                        // Изменяем нужные поля
                       worker.login = Login.Text;
                       worker.password = Password.Text;
                       worker.role_id = role_id;
                       worker.FIO = LFMnamefield.Text;
                        _context.SaveChanges();
                        UC_Workers.UpdateData();
                        this.Close();
                    }
                }
            }
        }

        private void EditUser_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Для изменения информации введите новые значения");
            EditUser.Visibility = Visibility.Hidden;
            Login.IsReadOnly = Password.IsReadOnly = LFMnamefield.IsReadOnly = false;
            Post.PreviewMouseLeftButtonDown -= OffCombobox;
        }
    }
}
