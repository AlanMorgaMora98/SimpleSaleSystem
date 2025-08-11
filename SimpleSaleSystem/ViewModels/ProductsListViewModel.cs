using System.Collections.ObjectModel;

using CommunityToolkit.Mvvm.ComponentModel;

using SimpleSaleSystem.Contracts.ViewModels;
using SimpleSaleSystem.Core.Contracts.Services;
using SimpleSaleSystem.Core.Models;

namespace SimpleSaleSystem.ViewModels;

public partial class ProductsListViewModel : ObservableRecipient, INavigationAware
{
    private readonly ISampleDataService _sampleDataService;

    public ObservableCollection<SampleOrder> Source { get; } = new ObservableCollection<SampleOrder>();

    public ProductsListViewModel(ISampleDataService sampleDataService)
    {
        _sampleDataService = sampleDataService;
    }

    public async void OnNavigatedTo(object parameter)
    {
        Source.Clear();

        // TODO: Replace with real data.
        var data = await _sampleDataService.GetGridDataAsync();

        foreach (var item in data)
        {
            Source.Add(item);
        }
    }

    public void OnNavigatedFrom()
    {
    }
}
