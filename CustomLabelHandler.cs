#if WINDOWS
using Microsoft.UI.Xaml.Controls;
#elif ANDROID
using AndroidX.AppCompat.Widget;
#elif IOS
using Microsoft.Maui.Platform;
#endif

using System.Diagnostics;

namespace ReproLoadedUnloaded
{
	public partial class CustomLabelHandler : Microsoft.Maui.Handlers.LabelHandler
	{
		public CustomLabelHandler()
		{
			Debug.WriteLine($"CustomLabelHandler..ctor");
		}

#if WINDOWS
		protected override void ConnectHandler(TextBlock platformView)
		{
			Debug.WriteLine($"In ConnectHandler of {VirtualView.Text}");
			base.ConnectHandler(platformView);
		}

		protected override void DisconnectHandler(TextBlock platformView)
		{
			Debug.WriteLine($"In DisconnectHandler of {VirtualView.Text}");
			base.DisconnectHandler(platformView);
		}

#elif ANDROID
		protected override void ConnectHandler(AppCompatTextView platformView)
		{
			Debug.WriteLine($"In ConnectHandler of {VirtualView.Text}");
			base.ConnectHandler(platformView);
		}

		protected override void DisconnectHandler(AppCompatTextView platformView)
		{
			Debug.WriteLine($"In DisconnectHandler of {VirtualView.Text}");
			base.DisconnectHandler(platformView);
		}
#elif IOS
		protected override void ConnectHandler(MauiLabel platformView)
		{
			Debug.WriteLine($"In ConnectHandler of {VirtualView.Text}");
			base.ConnectHandler(platformView);
		}

		protected override void DisconnectHandler(MauiLabel platformView)
		{
			Debug.WriteLine($"In DisconnectHandler of {VirtualView.Text}");
			base.DisconnectHandler(platformView);
		}
#endif

		~CustomLabelHandler()
		{
			Debug.WriteLine($"CustomLabelHandler finalizer");
		}
	}
}
