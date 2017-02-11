using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using Xamarin.UITest.Android;

namespace BikeSharing.Tests.Droid
{
    [TestFixture]
    public class Tests
    {
        AndroidApp app;

        [SetUp]
        public void BeforeEachTest()
        {
            // TODO: If the Android app being tested is included in the solution then open
            // the Unit Tests window, right click Test Apps, select Add App Project
            // and select the app projects that should be tested.
            app = ConfigureApp
                .Android
                // TODO: Update this path to point to your Android app and uncomment the
                // code if the app is not included in the solution.
                //.ApkFile ("../../../Android/bin/Debug/UITestsAndroid.apk")
                .StartApp();
        }

        [Test]
        public void AppLaunches()
        {
            app.Screenshot("First screen.");
        }

        [Test]
        public void NewTest()
        {
            app.Tap(x => x.Marked("username"));
            app.EnterText(x => x.Marked("username"), "scottgu");
            app.Tap(x => x.Marked("password"));
            app.EnterText(x => x.Marked("password"), "test");
            app.Tap(x => x.Marked("signin"));
            app.Tap(x => x.Id("button1"));
        }

        [Test]
        public void NewTest1()
        {
            app.Tap(x => x.Marked("username"));
            app.EnterText(x => x.Marked("username"), "larar");
            app.Tap(x => x.Marked("password"));
            app.Tap(x => x.Marked("signin"));
            app.Screenshot("Tapped on view with class: AppCompatButton marked: signin");
        }
    }
}

