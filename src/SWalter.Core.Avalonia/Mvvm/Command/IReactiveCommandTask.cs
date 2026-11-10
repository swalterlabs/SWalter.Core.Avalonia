using ReactiveUI.Primitives;

namespace SWalter.Core.Avalonia.Mvvm.Command;

/// <inheritdoc cref="ITaskRun" />
/// <inheritdoc cref="IInitReactiveCommand{TParam,TResult}" />
public interface IReactiveCommandTask<TParam> : IInitReactiveCommand<TParam, RxVoid>, ITaskRun;