using Avalonia.Controls;
using Avalonia.Interactivity;

namespace okno;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Przycisk_Click(object? sender, RoutedEventArgs e)
    {
        Podpis.Text = "Kliknięto przycisk!";
    }
}