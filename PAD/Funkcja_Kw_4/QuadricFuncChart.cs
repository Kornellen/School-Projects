using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Input;

public class QuadricFuncChartView : INotifyPropertyChanged
{
    // Deklaracja pól przechowywujących dane f. kwadratowej
    // Pola (Fields) te nie są dostępne z poziomu innego niż samego obiektu
    private double a = 0;
    private double b = 0;
    private double c = 0;
    private string vertex = string.Empty;
    private string zeros = string.Empty;
    private string _delta = string.Empty;

    // Tworzenie getterów/setterów umożliwiających działanie na polach prywatnych
    // Gettery i Settery to innymi słowy właściwości (Properties). Jak wspomniane powyżej - umożliwiają dostęp do pola prywatnego
    // Są one bezpieczeniejsze niż zwykły dostęp przez public, gdyż mogą one przeprowadzać także walidację danych wprowadzanych przez programistę
    public double A { get => a; set { a = value; OnPropertyChanged(); } }
    public double B { get => b; set { b = value; OnPropertyChanged(); } }
    public double C { get => c; set { c = value; OnPropertyChanged(); } }

    public string DeltaResult { get => _delta; set { _delta = value; OnPropertyChanged(); } }
    public string Vertex { get => vertex; set { vertex = value; OnPropertyChanged(); } }
    public string Zeros { get => zeros; set { zeros = value; OnPropertyChanged(); } }


    public PlotModel PlotModel { get; set; }
    public ICommand CalculateCommand { get; }

    public ICommand ClearCommand { get; }

    private LineSeries series;

    public QuadricFuncChartView()
    {
        // Podstawowe informacje o wykresie jak tytuł, czy kolor tła
        PlotModel = new PlotModel() { Title = "f(x) = ax² + bx + c" };
        series = new LineSeries() { Title = "f(x)" };
        PlotModel.Series.Add(series);

        PlotModel.Background = OxyColor.FromRgb(255, 255, 255);

        LinearAxis xAxis = new LinearAxis()
        {
            Position = AxisPosition.Bottom,
            Title = "X",
            MajorGridlineColor = OxyColor.FromRgb(0, 0, 0),
            MajorGridlineStyle = LineStyle.Solid,
            MinorGridlineStyle = LineStyle.Dot,
            PositionAtZeroCrossing = true
        };


        LinearAxis yAxis = new LinearAxis()
        {
            Position = AxisPosition.Left,
            Title = "Y",
            MajorGridlineColor = OxyColor.FromRgb(0, 0, 0),
            MajorGridlineStyle = LineStyle.Solid,
            MinorGridlineStyle = LineStyle.Dot,
            PositionAtZeroCrossing = true
        };

        PlotModel.Axes.Add(xAxis);
        PlotModel.Axes.Add(yAxis);

        CalculateCommand = new Command(UpdatePlot);
        ClearCommand = new Command(ClearInput);
    }

    private double CalculteQuadric(double x) => A * Math.Pow(x, 2) + B * x + C;

    public void ClearInput()
    {
        A = 0;
        B = 0;
        C = 0;
        PlotModel.Series.Clear();
        PlotModel.InvalidatePlot(true);
        Vertex = "";
        Zeros = "";
        DeltaResult = "";
    }

    public void UpdatePlot()
    {
        try
        {
            // Sprawdzanie, czy podana funkcja jest na pewno Funkcją Kwadratową
            if (A == 0) throw new Exception("Funkcja nie jest f. kwadratową");

            // Czyszczenie wykresu
            series.Points.Clear();
            PlotModel.Title = $"{A}x² + {B}x + {C}";

            // Czyszczenie poprzednich odpowiedzi
            DeltaResult = string.Empty;
            Vertex = string.Empty;
            Zeros = string.Empty;

            // Ustalanie wierzchołka paraboli
            double x0 = -B / (2 * A);
            double yVertex = CalculteQuadric(x0);

            Debug.WriteLine($"Wierzchołek: ({x0}; {yVertex})");

            Vertex = $"Wierzchołek: ({x0}; {yVertex})";

            // Liczenie Δ
            double delta = Math.Pow(B, 2) - 4 * A * C;

            DeltaResult = $"Delta: {delta}";

            Debug.WriteLine($"Delta: {delta}");

            // Sprawdzanie ilości miejsc zerowych f. kwadratowej i ich obliczanie
            if (delta < 0)
                Zeros = "Brak miejsc zerowych";

            else if (delta == 0)
                Zeros = $"Wierzchołek to miejsce zerowe: ({x0}; {yVertex})";

            else
            {
                double x1 = (-B - Math.Sqrt(delta)) / 2 * A, x2 = (-B + Math.Sqrt(delta)) / 2 * A;

                Zeros = $"Miejsca zerowe to: ({x1}; {CalculteQuadric(x1)}) i ({x2}; {CalculteQuadric(x2)})";
            }

            Debug.WriteLine(Zeros);

            // Konfiguracja wykresu (ustalanie jego zakresu, skali, liczby wyświetlanych punktów oraz kroków)
            double scale = Math.Max(Math.Abs(A), 0.1);
            double range = 10 / scale;

            /* 
             * Konfiguracja maksymalnego przedziału paraboli (żeby nie powodować, przepełnienia pamięci RAM)
             ! Przy wartościach ustawionych statycznie, jak np. Infinity program się wiesza lub zapełnia dostępną pamięć operacyjną.
             * Dla max Double, program zaczyna zapełniać dostępną pamięć RAM 
            */
            double startX = x0 - range;
            double endX = x0 + range;

            double chartPoints = 400;
            double step = (endX - startX) / chartPoints;

            // Rysowanie punktów na wykresie
            for (double x = startX; x <= endX; x += step)
            {
                double y = CalculteQuadric(x);

                //Debug.WriteLine($"({x};{y})");


                series.Points.Add(new DataPoint(x, y));
            }

            PlotModel.InvalidatePlot(true);
        }
        catch (Exception ex)
        {
            // Obsługa błędów
            Debug.WriteLine(ex.Message);
            DeltaResult = ex.Message;

            Vertex = "";
            Zeros = "";
        }

    }

    // Metody wynikające z dziedziczenia po Interface INotifyPropertyChanged
    public event PropertyChangedEventHandler PropertyChanged;
    public void OnPropertyChanged([CallerMemberName] string name = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}