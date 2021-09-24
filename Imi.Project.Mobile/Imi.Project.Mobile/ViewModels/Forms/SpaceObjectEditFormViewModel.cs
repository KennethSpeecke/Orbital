using FreshMvvm;
using Imi.Project.Mobile.Domain.Interfaces;
using Imi.Project.Mobile.Domain.Models.Enums;
using Imi.Project.Mobile.ViewModels.SpaceObjects;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Imi.Project.Mobile.ViewModels.Forms
{
    public class SpaceObjectEditFormViewModel : FreshBasePageModel
    {
        #region Fields

        private readonly ISpaceItemService<SpaceBaseItemViewModel<Guid>> _spaceItemService;
        private SpaceBaseItemViewModel<Guid> currentSpaceObject;

        #endregion Fields

        #region Constructors

        public SpaceObjectEditFormViewModel(ISpaceItemService<SpaceBaseItemViewModel<Guid>> spaceItemService)
        {
            _spaceItemService = spaceItemService;
        }

        #endregion Constructors

        #region Properties

        public ICommand CancelSpaceObjectEditorCommand => new Command(async () => await CancelEditor());

        public SpaceBaseItemViewModel<Guid> CurrentSpaceObject
        {
            get { return currentSpaceObject; }
            set
            {
                currentSpaceObject = value;
                RaisePropertyChanged();
            }
        }

        public ICommand SaveSpaceObjectEditorCommand => new Command(async () => await SaveCurrentSpaceItem());
        public SpaceItemTypes SpaceItemTypes { get; private set; }

        public List<string> SpaceItemTypesList { get; } = new List<string>() { SpaceItemTypes.UNMANNEDCRAFT.ToString(), SpaceItemTypes.PLANETOID.ToString(), SpaceItemTypes.DEBRIS.ToString(), SpaceItemTypes.MANNEDCRAFT.ToString() };

        private async Task CancelEditor()
        {
            await CoreMethods.PushPageModel<MainViewModel>();
        }

        #endregion Properties

        #region Methods

        public override void Init(object initData)
        {
            base.Init(initData);
            CurrentSpaceObject = (SpaceBaseItemViewModel<Guid>)initData;
        }

        private async Task<bool> SaveCurrentSpaceItem()
        {
            if (!CurrentSpaceObject.Equals(null))
            {
                await _spaceItemService.UpdateAsync(CurrentSpaceObject);
                return true;
            }
            return await Task.FromResult(false);
        }

        #endregion Methods
    }
}