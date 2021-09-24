using FreshMvvm;
using Imi.Project.Mobile.Domain.Models.Enums;
using Imi.Project.Mobile.ViewModels.AboutUs;
using Imi.Project.Mobile.ViewModels.ObjectTracker;
using Imi.Project.Mobile.ViewModels.UserProfile;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Imi.Project.Mobile.ViewModels.SpaceObjects
{
    public class MainViewModel : FreshBasePageModel
    {
        #region Properties

        private bool isLoggedIn;

        public bool IsLoggedIn
        {
            get { return isLoggedIn; }
            set
            {
                isLoggedIn = value;
                RaisePropertyChanged();
            }
        }

        public ICommand OpenAboutUsPageCommand => new Command(async () => { await CoreMethods.PushPageModel<AboutUsViewModel>(); });
        public ICommand OpenDebrisPageCommand => new Command(async () => { await CoreMethods.PushPageModel<SpaceObjectViewModel>(SpaceItemTypes.DEBRIS); });

        public ICommand OpenLoggedInUsersProfilePageCommand => new Command(async () => { await CoreMethods.PushPageModel<ProfileViewModel>(); }); //Add object data to send current user with navigation stack.
        public ICommand OpenMannedCraftsPageCommand => new Command(async () => { await CoreMethods.PushPageModel<SpaceObjectViewModel>(SpaceItemTypes.MANNEDCRAFT); });

        public ICommand OpenPlanetoidsPageCommand => new Command(async () => { await CoreMethods.PushPageModel<SpaceObjectViewModel>(SpaceItemTypes.PLANETOID); });

        public ICommand OpenTrackerPageCommand => new Command(async () => { await CreateTrackerNavigationAsync(); });

        public ICommand OpenUnmannedCraftsPageCommand => new Command(async () => { await CoreMethods.PushPageModel<SpaceObjectViewModel>(SpaceItemTypes.UNMANNEDCRAFT); });

        #endregion Properties

        #region Methods

        private async Task CreateTrackerNavigationAsync()
        {
            var tabbedNavigation = new FreshTabbedNavigationContainer("TrackerNavPage");
            tabbedNavigation.AddTab<ObjectTrackerListViewModel>("Trackable Objects", "", null);
            tabbedNavigation.AddTab<ObjectTrackerMapViewModel>("Map View", "", null);
            await CoreMethods.PushNewNavigationServiceModal(tabbedNavigation);
        }

        #endregion Methods
    }
}