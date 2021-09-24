using Syncfusion.XForms.Buttons;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Imi.Project.Mobile.Pages.SpaceObjects
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SpaceObjectPage : ContentPage
    {
        #region Constructors

        public SpaceObjectPage()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region Methods

        private void EditObject_Clicked(object sender, System.EventArgs e)
        {
            var button = (SfButton)sender;
            var itemToEditId = button.ClassId;
        }

        #endregion Methods
    }
}