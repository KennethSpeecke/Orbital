using FreshMvvm;
using Imi.Project.Mobile.Domain.Interfaces;
using Imi.Project.Mobile.ViewModels.SpaceObjects;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.ViewModels.ObjectTracker
{
    public class ObjectTrackerListViewModel : FreshBasePageModel
    {
        #region Fields

        private readonly ISpaceItemService<SpaceBaseItemViewModel<Guid>> _spaceItemService;
        //Add user service here to show user favorites in diffrent controll.

        #endregion Fields

        #region Constructors

        public ObjectTrackerListViewModel(ISpaceItemService<SpaceBaseItemViewModel<Guid>> spaceItemService)
        {
            _spaceItemService = spaceItemService;
        }

        #endregion Constructors

        private bool isBusy;

        private ObservableCollection<SpaceBaseItemViewModel<Guid>> spaceItems;

        public bool IsBusy
        {
            get { return isBusy; }
            set
            {
                isBusy = value;
                RaisePropertyChanged();
            }
        }

        public ObservableCollection<SpaceBaseItemViewModel<Guid>> SpaceItems
        {
            get { return spaceItems; }
            set
            {
                spaceItems = value;
                RaisePropertyChanged();
            }
        }

        protected override async void ViewIsAppearing(object sender, EventArgs e)
        {
            base.ViewIsAppearing(sender, e);
            //await ShowSpaceItems();
        }

        private async Task ShowSpaceItems()
        {
            IsBusy = true;

            try
            {
                var spaceItems = await _spaceItemService.GetAllTrackableAsync();
                SpaceItems = null;
                SpaceItems = new ObservableCollection<SpaceBaseItemViewModel<Guid>>(spaceItems.OrderBy(si => si.SpaceType));
            }
            catch (Exception ex)
            {
                await CoreMethods.DisplayAlert("Error", $"{ex.Message}", "Ok");
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}