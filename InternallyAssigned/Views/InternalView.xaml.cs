using System.Windows;
using System.Windows.Controls;

namespace InternallyAssigned.Views;

public partial class InternalView : UserControl
{
    public InternalView()
    {
        InitializeComponent();
    }
    
    
    public static readonly DependencyProperty InternalTextProperty =
        DependencyProperty.Register(nameof(InternalText), typeof(string), typeof(InternalView), new PropertyMetadata(default(string)));

    public string InternalText
    {
        get => (string)GetValue(InternalTextProperty);
        set => SetValue(InternalTextProperty, value);
    }
}