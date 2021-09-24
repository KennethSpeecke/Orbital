using FreshMvvm;

namespace Imi.Project.Mobile.ViewModels.Forms
{
    public class SpaceObjectDeleteWarningViewModel : FreshBasePageModel
    {
        #region Fields

        private object itemToDelete;

        #endregion Fields

        #region Properties

        public object ItemToDelete
        {
            get { return itemToDelete; }
            set { itemToDelete = value; }
        }

        #endregion Properties
    }
}