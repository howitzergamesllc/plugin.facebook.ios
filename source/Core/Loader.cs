using System;

namespace Facebook.Core
{
	public class Loader
	{
		static Loader ()
		{
			Facebook.Core.Loader.ForceLoad ();
		}

		public static void ForceLoad () { }
	}
}

namespace ApiDefinition
{
	partial class Core
	{
		static Core ()
		{
			Facebook.Core.Loader.ForceLoad ();
		}
	}
}
