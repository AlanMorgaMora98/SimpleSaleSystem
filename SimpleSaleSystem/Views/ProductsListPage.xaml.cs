using Microsoft.UI.Xaml.Controls;

using SimpleSaleSystem.ViewModels;

namespace SimpleSaleSystem.Views;

// TODO: Change the grid as appropriate for your app. Adjust the column definitions on DataGridPage.xaml.
// For more details, see the documentation at https://docs.microsoft.com/windows/communitytoolkit/controls/datagrid.
public sealed partial class ProductsListPage : Page
{
    public ProductsListViewModel ViewModel
    {
        get;
    }

    public ProductsListPage()
    {
        ViewModel = App.GetService<ProductsListViewModel>();
        InitializeComponent();
    }
}
