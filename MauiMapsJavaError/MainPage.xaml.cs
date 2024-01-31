namespace MauiMapsJavaError;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        Loaded += MainPage_Loaded;
    }

    private async void MainPage_Loaded(object? sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new ContentPage()
        {
            Content = new Label()
            {
                Text = "Hello World",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            }
        });
    }
}
