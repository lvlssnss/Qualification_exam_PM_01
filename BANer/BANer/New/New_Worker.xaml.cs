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

namespace BANer.New
{
    /// <summary>
    /// Логика взаимодействия для New_Worker.xaml
    /// </summary>
    public partial class New_Worker : Window
    {
        private BANerEntities _context;
        private UC_Workers UC_Workers;
        public New_Worker(BANerEntities context,UC_Workers uC_Workers)
        {
            InitializeComponent();
            this._context = context;
            this.UC_Workers = uC_Workers;
            var roles= _context.Role.Where(r=>r.id!=1).ToList();
            if (_context.worker.Where(t=>t.role_id==2).ToList().Count==1)
            {
                roles = roles.Where(r => r.id != 2).ToList();
            }
            foreach (var role in roles)
            {
                Post.Items.Add($"{role.name}");
            }
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

        private void Post_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(LFMnamefield.Text)|| string.IsNullOrEmpty(Login.Text)|| string.IsNullOrEmpty(Password.Text) || Post.SelectedValue==null)
            {
                MessageBox.Show("Вы ввели не все данные");
            }
            else
            {
                if (_context.worker.FirstOrDefault(w=>w.login==Login.Text && w.password==Password.Text)!=null)
                {
                    System.Windows.MessageBox.Show($"Пользователь с таким логином уже зарегистрирован, поменяйте логин или пароль");
                }
                else
                {
                    if ((MessageBox.Show("Вы уверены, что хотите добавить пользователя?", "Добавление", MessageBoxButton.YesNo, MessageBoxImage.Warning)) == MessageBoxResult.Yes)
                    {
                        int role_id = _context.Role.FirstOrDefault(r => r.name == Post.SelectedValue.ToString()).id;
                        _context.worker.Add(new worker()
                        {
                            login = Login.Text,
                            password = Password.Text,
                            role_id = role_id,
                            FIO = $"{LFMnamefield.Text}"
                        });
                        _context.SaveChanges();
                        UC_Workers.UpdateData();
                        this.Close();
                    }
                }
            }
        }
    }
}
