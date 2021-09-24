using Syncfusion.XForms.Buttons;
using System;
using Xamarin.Forms;

namespace Imi.Project.Mobile.Pages.SpaceObjects
{
    public partial class MainPage : ContentPage
    {
        #region Constructors

        public MainPage()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region Methods

        protected override bool OnBackButtonPressed()
        {
            return true;
        }

        #endregion Methods
    }
}