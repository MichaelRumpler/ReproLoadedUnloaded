using System.Diagnostics;

namespace ReproLoadedUnloaded
{
	public partial class ListViewPage : ContentPage
	{
		public ListViewPage()
		{
			Debug.WriteLine($"ListViewPage..ctor: instantiating instance {Id}");
			InitializeComponent();
		}

		private void GC_Clicked(object sender, EventArgs e)
		{
			GC.Collect();
			GC.WaitForPendingFinalizers();
		}

		~ListViewPage()
		{
			Debug.WriteLine($"ListViewPage finalizer: instance {Id} was collected");
		}
	}
}