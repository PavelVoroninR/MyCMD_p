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
using System.IO;

namespace MyCMD
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private string pathToFile = Environment.GetEnvironmentVariable("USERPROFILE");
		public MainWindow()
		{
			InitializeComponent();
		}
		private void Window_load(object sender, RoutedEventHandler e) {
			textBox.Text = pathToFile;
		}

		private void button_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				label.Content = pathToFile;
				var dir = new List<string>(Directory.GetDirectories(pathToFile));
				string temp = "";
				foreach (string dirone in dir)
				{
					temp += dirone + "\n";
				}
				label.Content = temp;


			}
			catch (System.IO.IOException err) {
				MessageBox.Show(err.Message);
			}


			


		}

		private void textBox_TextChanged(object sender, TextChangedEventArgs e)
		{
			pathToFile = textBox.Text;
		}
	}
}
