namespace ReproLoadedUnloaded
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		private async void OpenListViewPage_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new ListViewPage() { BindingContext = new[] {"One", "Two", "Three"} });
		}

		private async void OpenCollectionViewPage_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new CollectionViewPage() { BindingContext = new[] { "One", "Two", "Three" } });
		}

		private void GC_Clicked(object sender, EventArgs e)
		{
			GC.Collect();
			GC.WaitForPendingFinalizers();
		}
	}
}
