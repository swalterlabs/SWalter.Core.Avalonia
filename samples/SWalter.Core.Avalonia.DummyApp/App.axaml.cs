using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using SWalter.Core.Avalonia.Lifetime;

namespace SWalter.Core.Avalonia.DummyApp;

/// <inheritdoc />
public class App : ApplicationWithSplash
{
    /// <inheritdoc />
    public override void Initialize() => AvaloniaXamlLoader.Load(this);

    /// <inheritdoc />
    protected override Window CreateMainWindow() => new MainWindow();
}