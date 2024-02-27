using System.Diagnostics;

namespace ReproLoadedUnloaded
{
	public partial class CollectionViewPage : ContentPage
	{
		public CollectionViewPage()
		{
			Debug.WriteLine($"CollectionViewPage..ctor: instantiating instance {Id}");
			InitializeComponent();
		}

		private void GC_Clicked(object sender, EventArgs e)
		{
			GC.Collect();
			GC.WaitForPendingFinalizers();
		}

		~CollectionViewPage()
		{
			Debug.WriteLine($"CollectionViewPage finalizer: instance {Id} was collected");
		}
	}
}