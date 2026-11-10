using Avalonia;
using ReactiveUI.Builder;

namespace SWalter.Core.Avalonia.AppBuilderImplementations;

/// <inheritdoc />
// ReSharper disable once InconsistentNaming
public interface IAppBuilderImplementationToUseReactiveUI : IValueFor<Action<ReactiveUIBuilder>, AppBuilder>;