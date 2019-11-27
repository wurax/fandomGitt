﻿using System;
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

namespace WpfApp3
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

        //inserted
        // Configure the message box to be displayed
        string messageBoxText = "Do you want to delete the product?";
        string caption = "Word Processor";
        MessageBoxButton button = MessageBoxButton.YesNo;
        MessageBoxImage icon = MessageBoxImage.Warning;
        //inserted close

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TabControl_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            myTabControl.SelectedItem = editProductTab;
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            myTabControl.SelectedItem = productMenuTab;

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            myTabControl.SelectedItem = createProductTab;

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            myTabControl.SelectedItem = searchProductTab;

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            myTabControl.SelectedItem = productMenuTab;

        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            myTabControl.SelectedItem = productMenuTab;

        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            myTabControl.SelectedItem = mainMenuTab;

        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(messageBoxText, caption, button, icon);
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            myTabControl.SelectedItem = searchProductTab;
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            myTabControl.SelectedItem = searchProductTab;

        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            myTabControl.SelectedItem = productMenuTab;

        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            myTabControl.SelectedItem = productMenuTab;
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            myTabControl.SelectedItem = invetoryListTab;
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            myTabControl.SelectedItem = productMenuTab;
        }
    }
}
