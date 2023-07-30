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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            StackPanel sp1 = new StackPanel();
            Content = sp1;
            SizeToContent = SizeToContent.WidthAndHeight;

            Button btn1 = new Button();
            btn1.Content = "aaa";
            sp1.Children.Add(btn1);
            Button btn2 = new Button();
            btn2.Content = "bbb";
            sp1.Children.Add(btn2);
            TextBox tbox1 = new TextBox();
            tbox1.Text = "ccc";
            sp1.Children.Add(tbox1);
            TextBlock tblock1 = new TextBlock();
            tblock1.Text = "ddd";
            sp1.Children.Add(tblock1);

            ListBox lb1 = new ListBox();
            sp1.Children.Add(lb1);

            ListBoxItem lbi1 = new ListBoxItem();
            lbi1.Content = "eee";
            lb1.Items.Add((lbi1));

            ListBoxItem lbi2 = new ListBoxItem() { Content = "fff" };
            lb1.Items.Add(lbi2);

            lb1.Items.Add(new ListBoxItem() { Content = "ggg" });

            ComboBox cb1 = new ComboBox();
            sp1.Children.Add(cb1);

            ComboBoxItem cbi1 = new ComboBoxItem();
            cbi1.Content = "hhh";
            cb1.Items.Add(cbi1);
            cb1.SelectedIndex = 0;

            cb1.Items.Add(new ComboBoxItem { Content = "iii" });


        }

    }
}
