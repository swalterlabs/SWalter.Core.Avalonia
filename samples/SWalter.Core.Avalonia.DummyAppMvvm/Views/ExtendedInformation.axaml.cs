using AvaloniaEdit.TextMate;
using SWalter.Core.Avalonia.DependencyInjection;
using SWalter.Core.Avalonia.DummyAppMvvm.ViewModels;
using SWalter.Core.Avalonia.Themes;
using FluentAvalonia.UI.Windowing;
using Microsoft.Extensions.DependencyInjection;
using TextMateSharp.Grammars;

namespace SWalter.Core.Avalonia.DummyAppMvvm.Views;

/// <inheritdoc />
public partial class ExtendedInformation : FAAppWindow
{
    /// <summary>
    ///     Constructor
    /// </summary>
    public ExtendedInformation()
    {
        InitializeComponent();

        var registryOptions = new RegistryOptions(ThemeName.DarkPlus);

        var textMateInstallation = Output.InstallTextMate(registryOptions);
        textMateInstallation.SetGrammar(registryOptions.GetScopeByLanguageId(registryOptions.GetLanguageByExtension(".json").Id));

        DataContext = ApplicationServices.ServiceProvider.GetRequiredService<ExtendedInformationViewModel>();

        ThemeEngine.ApplyThemeToWindow(this, false);
    }
}