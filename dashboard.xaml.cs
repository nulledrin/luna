using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for dashboard.xaml
    /// </summary>
    public partial class dashboard : Page
    {

        public dashboard()
        {
            InitializeComponent();
        }

    }
    public class PolarChartModel
    {
        public string Label { get; set; }

        public double Weed { get; set; }

        public double Flower { get; set; }

        public double Tree { get; set; }
    }

    public class PolarChartViewModel
    {
        public ObservableCollection<PolarChartModel> PlantDetails { get; set; }
        public PolarChartViewModel()
        {
            this.PlantDetails = new ObservableCollection<PolarChartModel>();
            this.PlantDetails.Add(new PolarChartModel() { Label = "CWE-311", Weed = 63, Flower = 42, Tree = 80 });
            this.PlantDetails.Add(new PolarChartModel() { Label = "CWE-22", Weed = 47, Flower = 20, Tree = 78 });
            this.PlantDetails.Add(new PolarChartModel() { Label = "3", Weed = 65, Flower = 45, Tree = 83 });
            this.PlantDetails.Add(new PolarChartModel() { Label = "4", Weed = 58, Flower = 40, Tree = 79 });
            this.PlantDetails.Add(new PolarChartModel() { Label = "CWE-120", Weed = 73, Flower = 28, Tree = 88 });
        }


    }
}
