using System.Windows;
using System;
using DevExpress.Xpf.PivotGrid;
using System.Collections.Generic;

namespace WpfPivotGridFilterValues
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Filters values in the Country field using the created method.
            FilterFieldValues(fieldCountry, new string[] { "UK" }, FieldFilterType.Included);

            // Filters values in the Category field using the created method.
            FilterFieldValues(fieldCategory, new string[] { "Beverages", "Condiments", "Seafood", "Produce" }, 
                FieldFilterType.Included);
        }

        // Creates a new method that allows filtering field values.
        private object[] FilterFieldValues(PivotGridField field, object[] filterValues, 
            FieldFilterType filterType)
        {
            // Locks the control to prevent its excessive updates when multiple properties are modified.
            pivotGridControl1.BeginUpdate();
            try
            {
                // Clears the filter value collection and adds object items to it.
                field.FilterValues.Clear();
                foreach (object filterValue in filterValues)
                    field.FilterValues.Add(filterValue);
            }
            finally
            {
                // Specifies that the control should only display records 
                // which contain the specified values in the field.
                field.FilterValues.FilterType = filterType;

                // Unlocks the control.
                pivotGridControl1.EndUpdate();
            }
            return filterValues;
        }
    }
}
