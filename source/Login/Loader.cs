using System;

namespace Facebook.Login
{
	public class Loader
	{
		static Loader ()
		{
			Facebook.Login.Loader.ForceLoad ();
		}

		public static void ForceLoad () { }
	}
}

namespace ApiDefinition
{
	partial class Login
	{
		static Login ()
		{
			Facebook.Login.Loader.ForceLoad ();
		}
	}
}
