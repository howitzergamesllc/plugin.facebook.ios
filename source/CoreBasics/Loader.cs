using System;

namespace Facebook.CoreBasics
{
	public class Loader
	{
		static Loader ()
		{
			Facebook.CoreBasics.Loader.ForceLoad ();
		}

		public static void ForceLoad () { }
	}
}

namespace ApiDefinition
{
	partial class CoreBasics
	{
		static CoreBasics ()
		{
			Facebook.CoreBasics.Loader.ForceLoad ();
		}
	}
}
