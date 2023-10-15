using Promee_Homepage.Model;

namespace Promee_Homepage;

public partial class MainPage : ContentPage
{


	public MainPage()
	{
		InitializeComponent();

        var items = new List<CollectionItem>
        {
            new CollectionItem {Title = "Welcome to Backlog", Description = "as"},
            new CollectionItem {Title = "Welcome to Doing", Description = "as"},
            new CollectionItem {Title = "Welcome to Done", Description = "as"}
        };
        CarView.ItemsSource = items;

        

    }

	
}

