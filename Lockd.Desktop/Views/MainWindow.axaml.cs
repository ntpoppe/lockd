using System;
using Avalonia.Controls;
using Lockd.Desktop.ViewModels;

namespace Lockd.Desktop.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        this.Opened += OnOpened;
    }

    private async void OnOpened(object? sender, EventArgs e)
    {
        if (DataContext is MainViewModel vm)
            await vm.InitializeAsync();
    }
}
