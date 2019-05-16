using DevExpress.Xpf.PivotGrid;

namespace WpfPivotGridFilterValues
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : DevExpress.Xpf.Core.ThemedWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            fieldCountry.SetFilterValues(new string[] { "UK" }, FieldFilterType.Included, true);
            fieldCategoryName.SetFilterValues(new string[] { "Beverages", "Condiments", "Seafood", "Produce" }, FieldFilterType.Included, true);
        }
    }
}
