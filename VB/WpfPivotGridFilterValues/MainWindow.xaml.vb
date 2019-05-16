Imports DevExpress.Xpf.PivotGrid

Namespace WpfPivotGridFilterValues
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits DevExpress.Xpf.Core.ThemedWindow

		Public Sub New()
			InitializeComponent()

			fieldCountry.SetFilterValues(New String() { "UK" }, FieldFilterType.Included, True)
			fieldCategoryName.SetFilterValues(New String() { "Beverages", "Condiments", "Seafood", "Produce" }, FieldFilterType.Included, True)
		End Sub
	End Class
End Namespace
