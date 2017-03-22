using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace NetgearG
{
	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]
	public class Tests
	{
		IApp app;
		Platform platform;

		public Tests(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);

		}

		[Test]
		public void Repl()
		{
			app.Repl();
		}

		[Test]
		public void FirstTest()
		{
			app.Tap("SKIP");
			app.Screenshot("Let's start by Tapping on the 'Skip' Button");

			app.Tap("benefits_dialog_yes_btn");
			app.Screenshot("Then we Tapped the Yes Button");

			app.Tap("local_access_continue_withoutlogin");
			app.Screenshot("Next we Tapped the 'Continue without login' Button ");

			app.Tap("main_functionitem_ico");
			app.Screenshot("Next we Tapped on the 'MyMedia' Button");

			app.Tap("listItemTitle");
			app.Screenshot("Then we Tapped on the 'Local Media Server' Button");

			app.Tap("Images");

			app.Tap("common_toolbar_rightbtn");

			app.Back();

			app.Back();

			app.Tap("Audios");

			app.Tap("PLAYER");
			app.Screenshot("Then we Tapped 'Player'");
		}

	}
}
