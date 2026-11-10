using Avalonia;
using SWalter.Core.Avalonia.AppBuilderImplementations;
using SWalter.Core.Avalonia.DummyAppMvvm.DependencyInjection;

namespace SWalter.Core.Avalonia.DummyAppMvvm;

// ReSharper disable once ClassNeverInstantiated.Global
internal class Program
{
    // Initialization code. Don't use any Avalonia, third-party APIs or any
    // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
    // yet and stuff might break.
    [STAThread]
    public static void Main(string[] args) =>
        BuildAvaloniaApp()
            .StartWithClassicDesktopLifetime(args);

    // ReSharper disable once MemberCanBePrivate.Global
    public static AppBuilder BuildAvaloniaApp() =>
        new AppBuilderImplementationToUseReactiveUIWithMicrosoftDependencyResolver<App>()
            .ValueFor(serviceCollection => { serviceCollection.AddDummyAppMvvmServiceCollection(); });
}