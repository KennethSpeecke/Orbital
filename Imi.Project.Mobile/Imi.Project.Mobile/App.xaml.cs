using FreshMvvm;
using Imi.Project.Mobile.Domain.Interfaces;
using Imi.Project.Mobile.Domain.Models.Application;
using Imi.Project.Mobile.Domain.Services;
using Imi.Project.Mobile.Domain.Services.Locations;
using Imi.Project.Mobile.Domain.Services.OrbitalApi;
using Imi.Project.Mobile.ViewModels.Forms;
using Imi.Project.Mobile.ViewModels.SpaceObjects;
using System;
using System.Net;
using Xamarin.Forms;

namespace Imi.Project.Mobile
{
    public partial class App : Application
    {
        #region Constructors

        public App()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NDEwMjIxQDMxMzgyZTM0MmUzMEpDcmJHditBOWMvZnlIcWsrUDE3MmpvTHhMRnZkTDJNcXhDS0pFaHBlOGc9"); //Make sure to hide this one when going live

            ServicePointManager.ServerCertificateValidationCallback +=
                (sender, cert, chain, sslPolicyErrors) =>
                true;
            InitializeComponent();

            //IOC Registers
            FreshIOC.Container.Register<ISpaceItemService<SpaceBaseItemViewModel<Guid>>>(new SpaceItemService()); //Space Item Service For The Orbital Api
            FreshIOC.Container.Register<IApplicationUserService<ApplicationUser, Guid>>(new ApplicationUserService());// User service in conjunction with the orbital api.
            FreshIOC.Container.Register<IGeoLocation>(new GeoLocationService()); //Registers all geolocation services
            FreshIOC.Container.Register<IZayraLocationService>(new IssLocationService()); //Registers location service for iss

            MainPage = new FreshNavigationContainer(FreshPageModelResolver.ResolvePageModel<LoginWithSocialIconViewModel>()); /*new NavigationPage(new LoginWithSocialIconPage());*/
        }

        #endregion Constructors

        #region Properties

        public static string BaseImageUrl { get; } = "https://cdn.syncfusion.com/essential-ui-kit-for-xamarin.forms/common/uikitimages/";

        #endregion Properties

        #region Methods

        protected override void OnResume()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnStart()
        {
        }

        #endregion Methods
    }
}