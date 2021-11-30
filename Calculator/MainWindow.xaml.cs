using System;
using StringMath;
using System.Windows;
namespace Calculator;

/// <summary>
/// Interaction logic for Calculator
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    private void bExit_Click(object sender, RoutedEventArgs e)
    {
        Application.Current.Shutdown();
    }

    private void bNumZero_Click(object sender, RoutedEventArgs e)
    {
        tboxExample.Text += "0";
    }
    private void bNumOne_Click(object sender, RoutedEventArgs e)
    {
        tboxExample.Text += "1";
    }
    private void bNumTwo_Click(object sender, RoutedEventArgs e)
    {
        tboxExample.Text += "2";
    }
    private void bNumThree_Click(object sender, RoutedEventArgs e)
    {
        tboxExample.Text += "3";
    }
    private void bNumFour_Click(object sender, RoutedEventArgs e)
    {
        tboxExample.Text += "4";
    }
    private void bNumFive_Click(object sender, RoutedEventArgs e)
    {
        tboxExample.Text += "5";
    }
    private void bNumSix_Click(object sender, RoutedEventArgs e)
    {
        tboxExample.Text += "6";
    }
    private void bNumSeven_Click(object sender, RoutedEventArgs e)
    {
        tboxExample.Text += "7";
    }
    private void bNumEight_Click(object sender, RoutedEventArgs e)
    {
        tboxExample.Text += "8";
    }
    private void bNumNine_Click(object sender, RoutedEventArgs e)
    {
        tboxExample.Text += "9";
    }

    private void bActPlus_Click(object sender, RoutedEventArgs e)
    {
        tboxExample.Text += "+";
    }
    private void bActMinus_Click(object sender, RoutedEventArgs e)
    {
        tboxExample.Text += "-";
    }
    private void bActMultiply_Click(object sender, RoutedEventArgs e)
    {
        tboxExample.Text += "*";
    }
    private void bActDivide_Click(object sender, RoutedEventArgs e)
    {
        tboxExample.Text += "/";
    }
    private void bActPoint_Click(object sender, RoutedEventArgs e)
    {
        tboxExample.Text += ".";
    }
    private void bActOpenBracket_Click(object sender, RoutedEventArgs e)
    {
        tboxExample.Text += "(";
    }
    private void bActCloseBracket_Click(object sender, RoutedEventArgs e)
    {
        tboxExample.Text += ")";
    }
    private void bActInPower_Click(object sender, RoutedEventArgs e)
    {
        tboxExample.Text += "^";
    }

    private void bEquals_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            double result = SMath.Evaluate(tboxExample.Text);
            textResult.Text = result.ToString();
        }
        catch (Exception)
        {
            textResult.Text = "Wrong example!";
        }
    }
}