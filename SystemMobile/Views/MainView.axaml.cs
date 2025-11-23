using Avalonia.Controls;
using System;

namespace SystemMobile.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
        LoadWebsite();

    }
    private void LoadWebsite()
    {
        try
        {
            string url = "https://test.alfatoora.com";
            //string url = "https://codeseven.github.io/toastr/demo.html";
            MyWebView.Address = url;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}