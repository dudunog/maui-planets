using MauiPlanets.Services;

namespace MauiPlanets.Views;

public partial class PlanetsPage : ContentPage
{
	public PlanetsPage()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();

        lstPopularPlanets.ItemsSource = PlanetsService.GetFeaturedPlanets();
        lstAllPlanets.ItemsSource = PlanetsService.GetAllPlanets();
    }

    async void Planets_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {

    }

    private void lstPopularPlanets_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {

    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {

    }

    async void GridArea_Tapped(object sender, EventArgs e)
    {
    }
}