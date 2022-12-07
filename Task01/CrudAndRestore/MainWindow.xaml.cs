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

namespace CrudAndRestore
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
		InitializeComponent();
		}

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if (!listbox1.Items.Contains(textBox1.Text))
            {
                String s = textBox1.Text;
                String s2 = s.Trim();

                listbox1.Items.Add(s2);
                textBox1.Clear();
            }
            else
                MessageBox.Show("The name is already present in the list.");


        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            if (listbox1.SelectedItems.Count != 0)
            {
                while (listbox1.SelectedIndex != -1)
                {
                    listbox2.Items.Add(listbox1.SelectedItem);
                    listbox1.Items.Remove(listbox1.SelectedItem);

                }
            }
            else
                listbox1.Items.Clear();


        }
        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            if (listbox2.SelectedItems.Count != 0)
            {
                while (listbox2.SelectedIndex != -1)
                {
                    listbox1.Items.Add(listbox2.SelectedItem);
                    listbox2.Items.Remove(listbox2.SelectedItem);

                }
            }
            else
                listbox1.Items.Clear();


        }

        private void textBox1_TextChanging(object sender, RoutedEventArgs e)
        {

        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {

            listbox2.Items.Clear();

        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

		private void textBox1_TextChanged_1(object sender, TextChangedEventArgs e)
		{

		}
	}
}
	

