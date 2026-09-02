using System;

namespace Facebook.AEM
{
	public class Loader
	{
		static Loader ()
		{
			Facebook.AEM.Loader.ForceLoad ();
		}

		public static void ForceLoad () { }
	}
}

namespace ApiDefinition
{
	partial class AEM
	{
		static AEM ()
		{
			Facebook.AEM.Loader.ForceLoad ();
		}
	}
}
