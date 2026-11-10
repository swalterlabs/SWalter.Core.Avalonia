using System.Runtime.InteropServices;
using Avalonia.Interactivity;
using SWalter.Core.Avalonia.Controls;
using FluentAvalonia.UI.Controls;
using FluentAvalonia.UI.Windowing;

namespace SWalter.Core.Avalonia.DummyApp;

/// <inheritdoc />
public partial class MainWindow : FAAppWindow
{
    /// <summary>
    ///     Constructor
    /// </summary>
    public MainWindow()
    {
        InitializeComponent();

        ArchitectureInformation.Text = $"{RuntimeInformation.FrameworkDescription} ({RuntimeInformation.ProcessArchitecture} on {RuntimeInformation.OSArchitecture})".ToLower();
    }

    // ReSharper disable UnusedParameter.Local
    // ReSharper disable once UnusedMember.Local
    private void ShowMessage(object sender, RoutedEventArgs e)
        // ReSharper restore UnusedParameter.Local
    {
        _ = RunDialogAsync(ShowMessageAsync, exception => MessageBoxResult.Text = exception.Message);
    }

    private async Task ShowMessageAsync()
    {
        var contentDialog = new FAContentDialog
                            {
                                Title = "Title with maaaaaaaaaaaaaany signs",
                                Content = DateTime.Now.ToString("R"),
                                PrimaryButtonText = "Yes",
                                SecondaryButtonText = "No"
                            };
        var result = await contentDialog.ShowAsync();
        MessageBoxResult.Text = result.ToString();
    }

    // ReSharper disable UnusedParameter.Local
    // ReSharper disable once UnusedMember.Local
    private void ShowWarning(object sender, RoutedEventArgs e)
        // ReSharper restore UnusedParameter.Local
    {
        _ = RunDialogAsync(ShowWarningAsync, exception => MessageBoxResult.Text = exception.Message);
    }

    private async Task ShowWarningAsync()
    {
        var taskDialog = new FATaskDialog
                         {
                             Title = "This is a warning message",
                             Content = DateTime.Now.ToString("R"),
                             IconSource = new FASymbolIconSource { Symbol = FASymbol.AlertFilled },
                             Buttons =
                             {
                                 FATaskDialogButton.OKButton,
                             },
                             XamlRoot = this
                         };
        var result = await taskDialog.ShowAsync();
        MessageBoxResult.Text = result.ToString();
    }

    // ReSharper disable UnusedParameter.Local
    // ReSharper disable once UnusedMember.Local
    private void ShowError(object sender, RoutedEventArgs e)
        // ReSharper restore UnusedParameter.Local
    {
        _ = RunDialogAsync(ShowErrorAsync, exception => MessageBoxResult.Text = exception.Message);
    }

    private async Task ShowErrorAsync()
    {
        var taskDialog = new FATaskDialog
                         {
                             Title = "Running out of coffee Exception occurred!",
                             Content = DateTime.Now.ToString("R"),
                             IconSource = new FASymbolIconSource { Symbol = FASymbol.Cancel },
                             Buttons =
                             {
                                 FATaskDialogButton.OKButton,
                             },
                             XamlRoot = this
                         };
        var result = await taskDialog.ShowAsync();
        MessageBoxResult.Text = result.ToString();
    }

    // ReSharper disable UnusedParameter.Local
    // ReSharper disable once UnusedMember.Local
    private void ShowDialogBox(object sender, RoutedEventArgs e)
        // ReSharper restore UnusedParameter.Local
    {
        _ = RunDialogAsync(ShowDialogBoxAsync, exception => DialogBoxResult.Text = exception.Message);
    }

    private async Task ShowDialogBoxAsync()
    {
        var dialog = new FAContentDialog
                     {
                         Title = "Enter the new directory name",
                         PrimaryButtonText = "Ok",
                         CloseButtonText = "Cancel"
                     };

        var input = new ContentDialogInput
                    {
                        CaptionText = "Enter the new directory name"
                    };
        dialog.Content = input;

        var result = await dialog.ShowAsync();

        if (result == FAContentDialogResult.Primary && !string.IsNullOrWhiteSpace(input.ResultText))
        {
            DialogBoxResult.Text = input.ResultText;
        }
    }

    private async Task RunDialogAsync(Func<Task> showDialogAsync, Action<Exception> showError)
    {
        try
        {
            await showDialogAsync();
        }
        catch (Exception exception)
        {
            showError(exception);
        }
    }
}