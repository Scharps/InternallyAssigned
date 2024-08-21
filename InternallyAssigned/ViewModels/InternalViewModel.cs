using CommunityToolkit.Mvvm.ComponentModel;

namespace InternallyAssigned.ViewModels;

public partial class InternalViewModel : ObservableObject
{
    [ObservableProperty]
    private string _internalViewModelText = "Internal ViewModel Text";
}