
using Promee_Homepage.Model;

namespace Promee_Homepage;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		
		MainPage = new AppShell();  
    }
}
