using System;
using System.Windows;

namespace CryptoApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string radioButtonState = "";
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string encodeStr = textBox1.Text;
            switch (radioButtonState)
            {
                case "Caesar":
                    
                    int key = Convert.ToInt32(keyTextBox.Text);
                    string decodeStr = Caesar.Decipher(encodeStr, key);
                    textBox2.Text = decodeStr;
                    break;

                case "Atbash":
                    string decode = Atbash.Decode(encodeStr);
                    textBox2.Text = decode;
                    break;

                case "Viziner":
                    string keyViziner = keyTextBox.Text;
                    string decodeViziner = Viziner.Decipher(encodeStr, keyViziner);
                    textBox2.Text = decodeViziner;
                    break;
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            this.radioButtonState = "Atbash";
            this.keyLabel.Visibility = Visibility.Hidden;
            this.keyTextBox.Visibility = Visibility.Hidden;
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            this.radioButtonState = "Caesar";
            this.keyLabel.Visibility = Visibility.Visible;
            this.keyTextBox.Visibility = Visibility.Visible;
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            this.radioButtonState = "Viziner";
            this.keyLabel.Visibility = Visibility.Visible;
            this.keyTextBox.Visibility = Visibility.Visible;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string encodeStr = textBox1.Text;
            switch (radioButtonState)
            {
                case "Atbash":
                    MessageBox.Show("Atbash");
                    textBox2.Text = Atbash.Encode(encodeStr);
                    break;
                case "Caesar":
                    MessageBox.Show("Caesar");
                    int key = Convert.ToInt32(keyTextBox.Text);
                    textBox2.Text = Caesar.Encipher(encodeStr, key);
                    break;
                case "Viziner":
                    MessageBox.Show("Viziner");
                    string keyViziner = keyTextBox.Text;
                    textBox2.Text = Viziner.Encipher(encodeStr, keyViziner);
                    break;
            }
        }
    }
}