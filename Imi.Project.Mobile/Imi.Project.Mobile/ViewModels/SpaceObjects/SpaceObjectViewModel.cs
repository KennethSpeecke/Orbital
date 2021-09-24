using FreshMvvm;
using Imi.Project.Mobile.Domain.Interfaces;
using Imi.Project.Mobile.Domain.Models.Enums;
using Imi.Project.Mobile.ViewModels.Forms;
using Syncfusion.XForms.Buttons;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Imi.Project.Mobile.ViewModels.SpaceObjects
{
    public class SpaceObjectViewModel : FreshBasePageModel
    {
        #region Fields

        private readonly ISpaceItemService<SpaceBaseItemViewModel<Guid>> _spaceItemService;
        private int cardHeightRequest;
        private Guid currentSpaceObjectId;
        private Guid currentUserId;
        private bool isAuthenticatedAsAdmin;
        private bool isBusyWithAsyncTask = true;
        private bool isDebrisType;
        private bool isMannedCraft;
        private bool isPlanetoidType;
        private bool isUnmannedCraft;
        private string pageStateTitle;
        private SpaceItemTypes selectedSpaceType;
        private ObservableCollection<SpaceBaseItemViewModel<Guid>> spaceItems;
        private int spaceObjectTypeName;

        #endregion Fields

        #region Constructors

        public SpaceObjectViewModel(ISpaceItemService<SpaceBaseItemViewModel<Guid>> spaceItemService)
        {
            _spaceItemService = spaceItemService;
        }

        #endregion Constructors

        #region Properties

        public int CardHeightRequest
        {
            get { return cardHeightRequest; }
            set
            {
                cardHeightRequest = value;
                RaisePropertyChanged();
            }
        }

        public Guid CurrentSpaceObjectId
        {
            get { return currentSpaceObjectId; }
            set
            {
                currentSpaceObjectId = value;
                RaisePropertyChanged();
            }
        }

        public Guid CurrentUserId
        {
            get { return currentUserId; }
            set
            {
                currentUserId = value;
                RaisePropertyChanged();
            }
        }

        public bool IsAuthenticatedAsAdmin
        {
            get { return isAuthenticatedAsAdmin; }
            set
            {
                isAuthenticatedAsAdmin = value;
                RaisePropertyChanged();
            }
        }

        public bool IsBusyWithAsyncTask
        {
            get { return isBusyWithAsyncTask; }
            set
            {
                isBusyWithAsyncTask = value;
                RaisePropertyChanged();
            }
        }

        public bool IsDebrisType
        {
            get { return isDebrisType; }
            set
            {
                isDebrisType = value;
                RaisePropertyChanged();
            }
        }

        public bool IsMannedCraft
        {
            get { return isMannedCraft; }
            set
            {
                isMannedCraft = value;
                RaisePropertyChanged();
            }
        }

        public bool IsPlanetoidType
        {
            get { return isPlanetoidType; }
            set
            {
                isPlanetoidType = value;
                RaisePropertyChanged();
            }
        }

        public bool IsUnmmanedCraft
        {
            get { return isUnmannedCraft; }
            set
            {
                isUnmannedCraft = value;
                RaisePropertyChanged();
            }
        }

        public ICommand OpenDeleteSpaceObjectPageCommand => new Command(async () => { await CoreMethods.PushPageModel<SpaceObjectDeleteWarningViewModel>(); });
        public ICommand OpenEditSpaceObjectPageCommand => new Command(EditCommandClicked);
        public ICommand OpenFavoriteCurrentObjectCommand => new Command(async () => { await AddObjectToCurrentUserFavorites(CurrentSpaceObjectId, CurrentUserId); });
        public ICommand OpenSpaceObjectCommentSectionCommand => new Command(async () => { await CoreMethods.PushPageModel<SpaceObjectEditFormViewModel>(); });

        public string PageStateTitle
        {
            get { return pageStateTitle; }
            set
            {
                pageStateTitle = value;
                RaisePropertyChanged();
            }
        }

        public SpaceItemTypes SelectedSpaceType
        {
            get { return selectedSpaceType; }
            set { selectedSpaceType = value; }
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

        public int SpaceObjectTypeName
        {
            get { return spaceObjectTypeName; }
            set
            {
                spaceObjectTypeName = value;
                RaisePropertyChanged();
            }
        }

        #endregion Properties

        #region Methods

        public override void Init(object initData)
        {
            SelectedSpaceType = (SpaceItemTypes)initData;
            base.Init(initData);
        }

        protected override async void ViewIsAppearing(object sender, EventArgs e)
        {
            if (IsBusyWithAsyncTask.Equals(true))
            {
                PageStateTitle = "Loading...";
                ResetBasicControlls();
                await DisplaySpaceItemsByType();
                IsBusyWithAsyncTask = false;
                PageStateTitle = $"All registerd {SelectedSpaceType.ToString().ToLower()} objects.";
            }

            base.ViewIsAppearing(sender, e);
        }

        private Task AddObjectToCurrentUserFavorites(Guid objectId, Guid userId)
        {
            throw new NotImplementedException();
        }

        private async Task DisplaySpaceItemsByType()
        {
            IsBusyWithAsyncTask = true;
            switch (selectedSpaceType)
            {
                case SpaceItemTypes.DEBRIS:
                    CardHeightRequest = 700;
                    IsDebrisType = true;
                    break;

                case SpaceItemTypes.PLANETOID:
                    CardHeightRequest = 740;
                    IsPlanetoidType = true;
                    break;

                case SpaceItemTypes.MANNEDCRAFT:
                    CardHeightRequest = 760;
                    IsMannedCraft = true;
                    break;

                case SpaceItemTypes.UNMANNEDCRAFT:
                    CardHeightRequest = 650;
                    IsUnmmanedCraft = true;
                    break;

                default:
                    Debug.WriteLine("Type selection failed. Type does not exist.");
                    ResetBasicControlls();
                    break;
            }

            SpaceItems = new ObservableCollection<SpaceBaseItemViewModel<Guid>>(await _spaceItemService.GetSpaceItemsByType(SelectedSpaceType));
        }

        private async void EditCommandClicked(object sender)
        {
            var itemToEdit = await _spaceItemService.GetByIdAsync(Guid.Parse(((SfButton)sender).ClassId), SelectedSpaceType);
            itemToEdit.SpaceType = selectedSpaceType.ToString();
            await CoreMethods.PushPageModel<SpaceObjectEditFormViewModel>(itemToEdit);
        }

        private void ResetBasicControlls()
        {
            IsDebrisType = false;
            IsMannedCraft = false;
            IsPlanetoidType = false;
            IsUnmmanedCraft = false;
#if DEBUG
            IsAuthenticatedAsAdmin = true; //When debugging we set this to true FOR NOW CHANGE THIS WHEN THE REAL AUTHENTICATION FUNCTIONS ARE IN PLACE
#endif
        }

        #endregion Methods
    }
}