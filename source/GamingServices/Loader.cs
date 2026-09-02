using System;

namespace Facebook.GamingServices
{
	public class Loader
	{
		static Loader ()
		{
			Facebook.GamingServices.Loader.ForceLoad ();
		}

		public static void ForceLoad () { }
	}
}

namespace ApiDefinition
{
	partial class GamingServices
	{
		static GamingServices ()
		{
			Facebook.GamingServices.Loader.ForceLoad ();
		}
	}
}
