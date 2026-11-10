using ReactiveUI.Primitives;

namespace SWalter.Core.Avalonia.Mvvm.Command;

/// <inheritdoc cref="IRun" />
/// <inheritdoc cref="IInitReactiveCommand{TParam,TResult}" />
public interface IReactiveCommandRun<TParam> : IInitReactiveCommand<TParam, RxVoid>, IRun;