using System;

namespace Facebook.Share
{
	public class Loader
	{
		static Loader ()
		{
			Facebook.Share.Loader.ForceLoad ();
		}

		public static void ForceLoad () { }
	}
}

namespace ApiDefinition
{
	partial class Share
	{
		static Share ()
		{
			Facebook.Share.Loader.ForceLoad ();
		}
	}
}
