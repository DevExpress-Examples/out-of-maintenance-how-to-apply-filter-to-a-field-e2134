Imports System.Windows
Imports System
Imports DevExpress.Xpf.PivotGrid
Imports System.Collections.Generic

Namespace WpfPivotGridFilterValues
    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()

            ' Filters values in the Country field using the created method.
            FilterFieldValues(fieldCountry,
                  New String() {"UK"}, FieldFilterType.Included)

            ' Filters values in the Category field using the created method.
            FilterFieldValues(fieldCategory,
                  New String() {"Beverages", "Condiments", "Seafood", "Produce"}, FieldFilterType.Included)
        End Sub

        ' Creates a new method that allows filtering field values.
        Private Function FilterFieldValues(ByVal field As PivotGridField,
                                           ByVal filterValues() As Object,
                                           ByVal filterType As FieldFilterType) As Object()
            ' Locks the control to prevent its excessive updates when multiple properties are modified.
            pivotGridControl1.BeginUpdate()
            Try
                ' Clears the filter value collection and adds object items to it.
                field.FilterValues.Clear()
                For Each filterValue As Object In filterValues
                    field.FilterValues.Add(filterValue)
                Next filterValue
            Finally
                ' Specifies that the control should only display records 
                ' which contain the specified values in the field.
                field.FilterValues.FilterType = filterType

                ' Unlocks the control.
                pivotGridControl1.EndUpdate()
            End Try
            Return filterValues
        End Function
    End Class
End Namespace
