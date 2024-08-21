using CommunityToolkit.Mvvm.ComponentModel;

namespace InternallyAssigned.ViewModels;

public partial class MainWindowViewModel : ObservableObject
{
    [ObservableProperty]
    private string _textFromMainWindowViewModel = "TextFromMainWindowViewModel";
}