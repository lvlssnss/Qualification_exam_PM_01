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
    public partial class New_Banner : Window
    {
        private BANerEntities _context;
        private UC_Banners UC_Workers;
        public New_Banner(BANerEntities context, UC_Banners uC_Workers)
        {
            InitializeComponent();
            this._context = context;
            this.UC_Workers = uC_Workers;
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

            if (targetElement.Name== "Login")
            {
                // Разрешен ввод только букв, цифр и символа Backspace
                if (!((e.Key >= Key.D0 && e.Key <= Key.D9) || (e.Key >= Key.A && e.Key <= Key.Z) || e.Key == Key.Back))
                {
                    e.Handled = true; // Отменяем ввод символа
                    return;
                }
            }
           else if ((targetElement.Name == "Password"|| targetElement.Name == "price") && !(e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key == Key.Back))
            {
                // разрешаем ввод цифр для объекта с именем "price","Count"
                e.Handled = true;
                return;
            }
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ( string.IsNullOrEmpty(Login.Text)|| string.IsNullOrEmpty(Password.Text) || string.IsNullOrEmpty(price.Text))
            {
                MessageBox.Show("Вы ввели не все данные");
            }
            else
            {
                int lenght = int.Parse(Password.Text);
                int _price = int.Parse(price.Text);
                if (_context.Banner.FirstOrDefault(w => w.hightway_name == Login.Text && w.lenght ==lenght)!=null)
                {
                    System.Windows.MessageBox.Show($"На трассе {Login.Text} уже есть банер с такой удалённостью");
                }
                else
                {
                    if ((MessageBox.Show("Вы уверены, что хотите добавить банер?", "Добавление", MessageBoxButton.YesNo, MessageBoxImage.Warning)) == MessageBoxResult.Yes)
                    {
                        _context.Banner.Add(new Banner()
                        {
                            hightway_name = Login.Text,
                            lenght = lenght,
                            price = _price,
                            status=status.Text
                        });
                        _context.SaveChanges();
                        UC_Workers.UpdateData();
                        this.Close();
                    }
                }
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
