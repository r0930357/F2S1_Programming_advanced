namespace OefeningPublishers;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
    protected override void OnSleep()
    {
        MessagingCenter.Unsubscribe<InstellingenViewModel>(this, "ThemeChanged");
    }

}
