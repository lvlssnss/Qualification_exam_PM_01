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
    public partial class Edit_Client : Window
    {
        private BANerEntities _context;
        private UC_Clients UC_Workers;
        private Client worker;
        public Edit_Client(BANerEntities context,UC_Clients uC_Workers, object o)
        {
            InitializeComponent();
            this._context = context;
            this.UC_Workers = uC_Workers;
            worker = (o as Button).DataContext as Client;
            Login.Text = worker.number;
            LFMnamefield.Text = worker.FIO;
          
            Login.IsReadOnly =  LFMnamefield.IsReadOnly = true;

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
            if ((targetElement.Name == "Login") && !(e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key == Key.Back))
            {
                // разрешаем ввод цифр для объекта с именем "Login"
                e.Handled = true;
                return;
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
            if (_context.Deal.Where(o=>o.Client_id==worker.id).ToList().Count!=0)
            {
                var z = _context.Deal.Where(u => u.Client_id == worker.id).Select(p => p.id).ToList();
                MessageBox.Show($"Данный клиент является ответсвтвенным за заказы, где идентификатор заказа {string.Join("содержит", string.Join(" ,", z))}\nСначала удалите эти заказы");
            }
            else
            {
                if ((MessageBox.Show("Вы уверены, что хотите удалить клиента?", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Warning)) == MessageBoxResult.Yes)
                {
                    _context.Client.Remove(worker);
                    _context.SaveChanges();
                    UC_Workers.UpdateData();
                    this.Close();
                }
            }
        }

        private void MakeChanges_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(LFMnamefield.Text) || string.IsNullOrEmpty(Login.Text))
            {
                MessageBox.Show("Вы ввели не все данные");
            }
            else
            {
                if (_context.Client.FirstOrDefault(w=>w.number== Login.Text && w.id!=worker.id) !=null )
                {
                    MessageBox.Show("У каждого клиента индивидуальный номер телефона. Измените существующего клиента, если его данные изменились или добавьте нового индивидуального клиента");
                }
                else
                {
                    if ((MessageBox.Show("Вы уверены, что хотите изменить информацию?", "Изменение", MessageBoxButton.YesNo, MessageBoxImage.Warning)) == MessageBoxResult.Yes)
                    {
                        // Изменяем нужные поля
                       worker.number = Login.Text;
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
            Login.IsReadOnly = LFMnamefield.IsReadOnly = false;
        }
        private void Login_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            TextBox loginTextBox = (TextBox)sender;
            if (loginTextBox.Text.Length == 0 && e.Text != "8")
            {
                e.Handled = true; // Отменяем ввод символа
                loginTextBox.Text = "8" + e.Text;
                loginTextBox.CaretIndex = 2; // Устанавливаем позицию курсора после префикса "8"
            }
        }
    }
}
