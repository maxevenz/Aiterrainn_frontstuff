namespace Aiterrainn;

public partial class ModelsPage : ContentPage
{
	public ModelsPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new CreatePage());
    }
}