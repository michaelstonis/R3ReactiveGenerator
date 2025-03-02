using ReactiveUI;

namespace ReactiveGeneratorDemo.ViewModels;

public partial class Car : ReactiveObject
{
    [Reactive]
    public partial string? Make { get; set; }

    [Reactive]
    public partial string? UniqueId { get; init; }
}
