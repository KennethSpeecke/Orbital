using FreshMvvm;
using Imi.Project.Mobile.Domain.Interfaces;
using Imi.Project.Mobile.Domain.Models.Application;
using Imi.Project.Mobile.ViewModels.SpaceObjects;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace Imi.Project.Mobile.ViewModels.ObjectTracker
{
    public class ObjectTrackerMainViewModel : FreshBasePageModel
    {
        #region Fields

        private readonly ISpaceItemService<SpaceBaseItemViewModel<Guid>> _spaceItemService;

        #endregion Fields

        #region Constructors

        public ObjectTrackerMainViewModel(ISpaceItemService<SpaceBaseItemViewModel<Guid>> spaceItemService)
        {
            _spaceItemService = spaceItemService;
        }

        #endregion Constructors

        #region Properties

        private ApplicationUser currentApplicationUser;
        private SpaceBaseItemViewModel<Guid> selectedSpaceItem;

        public ApplicationUser CurrentApplicationUser
        {
            get { return currentApplicationUser; }
            set
            {
                currentApplicationUser = value;
                RaisePropertyChanged();
            }
        }

        public ICommand OpenTrackableObjectListCommand => new Command(async () => { await CoreMethods.PushPageModel<ObjectTrackerListViewModel>(true); });

        public ICommand OpenTrackMapCommand => new Command(async () => { await CoreMethods.PushPageModel<ObjectTrackerMapViewModel>(CurrentApplicationUser, false, true); });

        public SpaceBaseItemViewModel<Guid> SelectedSpaceItem
        {
            get { return selectedSpaceItem; }
            set
            {
                selectedSpaceItem = value;
                RaisePropertyChanged();
            }
        }

        #endregion Properties

        #region Methods

        public override void Init(object initData)
        {
            base.Init(initData);
        }

        #endregion Methods
    }
}