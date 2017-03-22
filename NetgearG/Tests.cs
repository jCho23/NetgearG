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

			app.Tap("benefits_dialog_yes_btn");

			app.Tap("local_access_continue_withoutlogin");

			app.Tap("main_toolbar_leftbtn");

			app.Tap("main_functionitem_ico");
			app.Screenshot("Next we Tapped on the 'MyMedia' Button");

			app.Tap("listItemTitle");
			app.Screenshot("Then we Tapped on the 'Local Media Server' Button");




			app.Tap("user_info_support_txt");
			app.Screenshot("Then we Tapped the Hamburger Icon");






		}

	}
}
