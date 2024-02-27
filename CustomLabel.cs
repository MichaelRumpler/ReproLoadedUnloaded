using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReproLoadedUnloaded
{
	public class CustomLabel : Label
	{
        public CustomLabel()
        {
            Debug.WriteLine($"CustomLabel..ctor: instantiating instance {Id}");

            Text = $"CustomLabel #{Id}";

			Loaded += Element_Loaded;
			Unloaded += Element_Unloaded;
		}

		public void Element_Loaded(object? sender, EventArgs e)
		{
			Debug.WriteLine($"{Text} was loaded, ContainerView={(Handler?.ContainerView)}, PlatformView={Handler?.PlatformView}");
		}

		public void Element_Unloaded(object? sender, EventArgs e)
		{
			Debug.WriteLine($"{Text} was unloaded");
		}

		~CustomLabel()
        {
			Debug.WriteLine($"CustomLabel finalizer: instance {Id} was collected");
		}
	}
}
