using Syncfusion.Maui.DataGrid;

namespace SfDataGridSample
{
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
}