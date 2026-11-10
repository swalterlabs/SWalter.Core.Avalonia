using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using SWalter.Core.Avalonia.DependencyInjection;
using SWalter.Core.Avalonia.DummyAppMvvm.ViewModels;
using SWalter.Core.Avalonia.DummyAppMvvm.Views;
using SWalter.Core.Avalonia.Lifetime;

namespace SWalter.Core.Avalonia.DummyAppMvvm;

/// <inheritdoc />
public class App : ApplicationWithSplash
{
    /// <inheritdoc />
    public override void Initialize() => AvaloniaXamlLoader.Load(this);

    /// <inheritdoc />
    protected override bool ResizeWithBorder400 => true;

    /// <inheritdoc />
    protected override void PreMainWindowCreation()
    {
        ApplicationServices.AppName = Current?.Name;
    }

    /// <inheritdoc />
    protected override Window CreateMainWindow() => new MainWindow
                                                    {
                                                        DataContext = ApplicationServices.GetRequiredService<MainWindowViewModel>()
                                                    };
}