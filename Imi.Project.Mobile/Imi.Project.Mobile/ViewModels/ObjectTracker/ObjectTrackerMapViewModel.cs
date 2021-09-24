using FreshMvvm;
using Imi.Project.Mobile.Domain.Interfaces;
using Imi.Project.Mobile.Domain.Models.Application;
using Imi.Project.Mobile.Domain.Models.Base;
using System;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Imi.Project.Mobile.ViewModels.ObjectTracker
{
    public class ObjectTrackerMapViewModel : FreshBasePageModel
    {
        #region Fields

        private readonly IGeoLocation _geoLocation;
        private readonly IZayraLocationService _zayraLocationService;
        private Location currentIssLocation;
        private BaseSpaceItemModel<Guid> currentSpaceItem;
        private ApplicationUser currentUser;

        #endregion Fields

        #region Constructors

        public ObjectTrackerMapViewModel(IGeoLocation geoLocation, IZayraLocationService zayraLocationService)
        {
            _geoLocation = geoLocation;
            _zayraLocationService = zayraLocationService;
        }

        #endregion Constructors

        #region Properties

        public Location CurrentIssLocation
        {
            get { return currentIssLocation; }
            set
            {
                currentIssLocation = value;
                RaisePropertyChanged();
            }
        }

        public BaseSpaceItemModel<Guid> CurrentSpaceItem
        {
            get { return currentSpaceItem; }
            set
            {
                currentSpaceItem = value;
                RaisePropertyChanged();
            }
        }

        public ApplicationUser CurrentUser
        {
            get { return currentUser; }
            set
            {
                currentUser = value;
                RaisePropertyChanged();
            }
        }

        #endregion Properties

        #region Methods

        public override void Init(object initData)
        {
            base.Init(initData);
        }

        protected override async void ViewIsAppearing(object sender, EventArgs e)
        {
            base.ViewIsAppearing(sender, e);

            Device.StartTimer(TimeSpan.FromSeconds(10), () =>
            {
                Device.BeginInvokeOnMainThread(async () => CurrentIssLocation = await _zayraLocationService.GetCurrentIssLocation());
                Device.BeginInvokeOnMainThread(async () => CurrentUser = new ApplicationUser() { GeoLocation = await _geoLocation.GetUserLocation() });
                return true;
            });

            var test = CurrentUser;
        }

        protected override void ViewIsDisappearing(object sender, EventArgs e)
        {
            //Cancel the Geolocation service from running here with the cts provided in User Model
            base.ViewIsDisappearing(sender, e);
        }

        #endregion Methods
    }
}