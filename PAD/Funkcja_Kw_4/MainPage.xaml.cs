namespace Funkcja_Kw_4
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            // Podpięcie Kontekstu.
            // Chodzi o dodanie możliwości elementom GUI (Graphical User Interface) na komunikację z kodem, który jest ukryty.
            // Podobne do Clicked, jednakże Clicked funkcjonuje w pliku *.xaml.cs, a Binding - w innym pliku *.cs
            BindingContext = new QuadricFuncChartView();
        }
    }
}
