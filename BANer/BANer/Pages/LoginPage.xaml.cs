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
using BANer.Pages;

namespace BANer
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 
    public static class RoleStorage
    {
        public static int role { get; set; }
        public static int userid { get; set; }
    }
    public partial class LoginPage : Window
    {
        BANerEntities _context = new BANerEntities();
        public LoginPage()
        {
            InitializeComponent();
           
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
        private void еPreviewKeyDown(object sender, KeyEventArgs e) //запрета ввода пробела
        {
            if ((e.Key >= Key.D0 && e.Key <= Key.D9) || (e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9) || (e.Key >= Key.A && e.Key <= Key.Z) || (e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9) || (e.Key == Key.OemQuestion || e.Key == Key.OemPlus || e.Key == Key.OemMinus || e.Key == Key.OemOpenBrackets || e.Key == Key.OemCloseBrackets || e.Key == Key.OemPipe || e.Key == Key.OemSemicolon || e.Key == Key.OemQuotes || e.Key == Key.OemComma || e.Key == Key.OemPeriod || e.Key == Key.OemBackslash || e.Key == Key.Oem3 || e.Key == Key.Add || e.Key == Key.Subtract || e.Key == Key.Multiply || e.Key == Key.Divide) || e.Key == Key.Back)
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
        private void Auth_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(login.Text) || string.IsNullOrEmpty(passwd.Password.ToString()))
            {
                MessageBox.Show($"Ошибка. Вы не ввели логин или пароль");
            }
            else
            {
                worker worker = _context.worker.FirstOrDefault(w => w.login == login.Text && w.password == passwd.Password.ToString());
                if (worker!=null)
                {
                    RoleStorage.role = worker.role_id;
                    RoleStorage.userid = worker.id;
                    MessageBox.Show($"Успешная авторизация");
                    MessageBox.Show($"Приветствую вас, {worker.Role.name}");
                    MainPage mainPage = new MainPage();
                    this.Close();
                    mainPage.ShowDialog();

                }
            }
        }
    }
}
