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
    public partial class New_Deal : Window
    {
        private BANerEntities _context;
        private UC_Deals UC_Workers;
        public New_Deal(BANerEntities context, UC_Deals uC_Workers)
        {
            InitializeComponent();
            this._context = context;
            this.UC_Workers = uC_Workers;
            var delsids = _context.Deal.Select(b => b.Banner_id).ToList();
            var banners = _context.Banner.Where(t=>t.status == "Не арендован" && !delsids.Contains(t.id)).ToList();
            foreach (var banner in banners)
            {
                Banner.Items.Add($"{banner.Fullname}");
            }
            Worker.ItemsSource = _context.worker.Where(t=>t.role_id==4).Select(t => t.FIO).ToList();
            Client.ItemsSource = _context.Client.Select(t=>t.FIO).ToList();

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
           
        private void Password_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (e.Text == "0" && textBox.SelectionStart == 0)
            {
                e.Handled = true;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Period.Text)||Banner.SelectedItem==null|| Client.SelectedItem==null||Worker.SelectedItem==null)
            {
                MessageBox.Show("Вы ввели не все данные");
            }
            else
            {
                string name = Banner.SelectedValue.ToString().Split()[0].ToString();
                int km = int.Parse(Banner.SelectedValue.ToString().Split()[1].Substring(0, Banner.SelectedValue.ToString().Split()[1].Length - 2));
                var existbanner = _context.Banner.FirstOrDefault(b => b.hightway_name == name && b.lenght == km);
                int existworker = _context.worker.FirstOrDefault(b => b.FIO==Worker.SelectedValue.ToString()).id;
                int existclient = _context.Client.FirstOrDefault(b => b.FIO == Client.SelectedValue.ToString()).id;
                int period = int.Parse(Period.Text);
                if ((MessageBox.Show("Вы уверены, что хотите добавить сделку?", "Добавление", MessageBoxButton.YesNo, MessageBoxImage.Warning)) == MessageBoxResult.Yes)
                {
                    _context.Deal.Add(new Deal()
                    {
                        Banner_id=existbanner.id,
                        Client_id=existclient,
                        Worker_id=existworker,
                        period=period,
                        status = "Открыта"
                    });
                    existbanner.status = "Арендован";
                    _context.SaveChanges();
                    UC_Workers.UpdateData();
                    this.Close();
                }
            }
        }
        private void updateprice()
        {
            if (int.TryParse(Period.Text, out int period))
            {
                if (Banner.SelectedItem != null)
                {
                    string name = Banner.SelectedValue.ToString().Split()[0].ToString();
                    int km = int.Parse(Banner.SelectedValue.ToString().Split()[1].Substring(0, Banner.SelectedValue.ToString().Split()[1].Length - 2));
                    var existbanner = _context.Banner.FirstOrDefault(b => b.hightway_name == name && b.lenght == km);
                    if (existbanner != null)
                    {
                        itogo.Text = $"{existbanner.price * period} руб.";
                    }
                }
            }
            else
            {
                itogo.Text = $"0 руб.";
            }
        }
        private void Period_TextChanged(object sender, TextChangedEventArgs e)
        {
            updateprice();
        }
        private void SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            updateprice();
        }
    }
}
