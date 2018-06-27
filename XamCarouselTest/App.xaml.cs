using System;
using Prism;
using Prism.Ioc;
using Prism.Unity;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamCarouselTest.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XamCarouselTest
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();
            NavigationService.NavigateAsync("MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MainPage>();
        }

        //public App()
        //{
        //    InitializeComponent();

        //    MainPage = new MainPage();
        //}


    }
}
