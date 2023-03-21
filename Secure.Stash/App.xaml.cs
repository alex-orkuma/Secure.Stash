using System.Diagnostics;

namespace Secure.Stash;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}

    protected override Window CreateWindow(IActivationState activationState)
    {
		Window window = base.CreateWindow(activationState);
		window.Created += (s, e) =>
		{
			Debug.WriteLine("Secure.Stash.App: 1. Created event");
		};

		window.Activated += (s, e) =>
		{
			Debug.WriteLine("Secure.Stash.App: 2. Activated event");
		};
		window.Deactivated += (s, e) =>
		{
			Debug.WriteLine("Secure.Stash.App: 3. Deactivated event");
		};

		window.Stopped += (s, e) =>
		{
			Debug.WriteLine("Secure.Stash.App: 3. Stopped event");
		};
		window.Destroying += (s, e) =>
		{
			Debug.WriteLine("Secure.Stash.App: 3. Destroying event");
		};

		return window;
    }
}
