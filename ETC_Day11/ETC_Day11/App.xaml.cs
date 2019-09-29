using System;
using Com.OneSignal;
using DLToolkit.Forms.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ETC_Day11.Services;
using ETC_Day11.Views;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using FormsControls.Base;

namespace ETC_Day11
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            FlowListView.Init();
            DependencyService.Register<MockDataStore>();
            AppCenter.Start("android=62bfa4f6-9a9b-4edd-a54e-a753978fffa1;" +
                            "uwp={Your UWP App secret here};" +
                            "ios={Your iOS App secret here}",
                typeof(Analytics), typeof(Crashes));

            //OneSignal.Current.StartInit("84d64a7b-0150-43f1-92c2-567c31830e50").EndInit();
            //MainPage = new AnimationNavigationPage(new Page1());
            MainPage = new MainPage();
        }
        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
