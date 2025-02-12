# How do you freeze the first and last columns in .NET MAUI DataGrid (SfDataGrid) ?
In this article, we will show you how to freeze the first and last columns in [.NET MAUI DataGrid](https://www.syncfusion.com/maui-controls/maui-datagrid).

## xaml
The code below demonstrates how to freeze the first and last columns in DataGrid.
```
 <Grid>
     <Grid.ColumnDefinitions>
         <ColumnDefinition Width="*" />
         <ColumnDefinition Width="100" />
     </Grid.ColumnDefinitions>

     <syncfusion:SfDataGrid x:Name="sfGrid"
                            Grid.Column="0"
                            VerticalScrollBarVisibility="Never"
                            FrozenColumnCount="1"
                            GridLinesVisibility="Both"
                            HeaderGridLinesVisibility="Both"
                            ColumnWidthMode="Auto"
                            AutoGeneratingColumn="sfGrid1_AutoGeneratingColumn"
                            ItemsSource="{Binding Employees}">

     </syncfusion:SfDataGrid>
     <syncfusion:SfDataGrid x:Name="sfGrid1"
                            Grid.Column="1"
                            GridLinesVisibility="Both"
                            HeaderGridLinesVisibility="Both"
                            ColumnWidthMode="Auto"
                            AutoGenerateColumnsMode="None"
                            ItemsSource="{Binding Employees}">

         <syncfusion:SfDataGrid.Columns>
             <syncfusion:DataGridTextColumn MappingName="EmployeeID"
                                            Format="#"
                                            HeaderText="Employee ID" />
         </syncfusion:SfDataGrid.Columns>

     </syncfusion:SfDataGrid> 
 </Grid>
``` 

## Xaml.cs
```
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            sfGrid.GetVisualContainer().ScrollOwner.Scrolled += ScrollOwner_Scrolled;
            sfGrid1.GetVisualContainer().ScrollOwner.Scrolled += ScrollOwner_Scrolled1;
        }

        private async void ScrollOwner_Scrolled(object? sender, ScrolledEventArgs e)
        {
            var scrollView = sfGrid1.GetVisualContainer().ScrollOwner;
            if (scrollView != null)
            {
                await scrollView.ScrollToAsync(scrollView.ScrollX, e.ScrollY, false);
            }
        }

        private async void ScrollOwner_Scrolled1(object? sender, ScrolledEventArgs e)
        {
            var scrollView = sfGrid.GetVisualContainer().ScrollOwner;
            if (scrollView != null)
            {
                await scrollView.ScrollToAsync(scrollView.ScrollX, e.ScrollY, false);
            }
        }

        private void sfGrid1_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            if (e.Column.MappingName == "EmployeeID")
            {
                e.Cancel = true;
            }
        }
    }
```

<img src="https://support.syncfusion.com/kb/agent/attachment/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjM1NzU3Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.-YUecgnELj3Xclci9PqzZhC5RjTVto9LHCbpqZDZAW4" width=700 />

[View sample in GitHub](https://github.com/SyncfusionExamples/How-to-freeze-first-and-last-column-in-.NET-MAUI-DataGrid--SfDataGrid-)

Take a moment to explore this [documentation](https://help.syncfusion.com/maui/datagrid/overview), where you can find more information about Syncfusion .NET MAUI DataGrid (SfDataGrid) with code examples. Please refer to this [link](https://www.syncfusion.com/maui-controls/maui-datagrid) to learn about the essential features of Syncfusion .NET MAUI DataGrid (SfDataGrid).
 
##### Conclusion
 
I hope you enjoyed learning about how to freeze the first and last columns in the .NET MAUI DataGrid (SfDataGrid).
 
You can refer to our [.NET MAUI DataGrid’s feature tour](https://www.syncfusion.com/maui-controls/maui-datagrid) page to learn about its other groundbreaking feature representations. You can also explore our [.NET MAUI DataGrid Documentation](https://help.syncfusion.com/maui/datagrid/getting-started) to understand how to present and manipulate data. 
For current customers, you can check out our .NET MAUI components on the [License and Downloads](https://www.syncfusion.com/sales/teamlicense) page. If you are new to Syncfusion, you can try our 30-day [free trial](https://www.syncfusion.com/downloads/maui) to explore our .NET MAUI DataGrid and other .NET MAUI components.
 
If you have any queries or require clarifications, please let us know in the comments below. You can also contact us through our [support forums](https://www.syncfusion.com/forums), [Direct-Trac](https://support.syncfusion.com/create) or [feedback portal](https://www.syncfusion.com/feedback/maui?control=sfdatagrid), or the feedback portal. We are always happy to assist you!