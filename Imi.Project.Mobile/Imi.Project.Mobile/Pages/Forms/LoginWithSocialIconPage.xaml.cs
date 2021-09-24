using Imi.Project.Mobile.Domain.Interfaces;
using Imi.Project.Mobile.Domain.Models.Application;
using Imi.Project.Mobile.Domain.Services.Mocking;
using Imi.Project.Mobile.ViewModels.SpaceObjects;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace Imi.Project.Mobile.Pages.Forms
{
    /// <summary>
    /// Page to login with user name and password
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginWithSocialIconPage : ContentPage
    {
        #region Fields

        private readonly IApplicationUserService<ApplicationUser, Guid> _applicationUserService;
        private readonly ISpaceItemService<SpaceBaseItemViewModel<Guid>> _spaceItemService;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginWithSocialIconPage" /> class.
        /// </summary>
        public LoginWithSocialIconPage()
        {
            InitializeComponent();
            _spaceItemService = new MockSpaceItemService<SpaceBaseItemViewModel<Guid>>();
            _applicationUserService = new MockApplicationUserService(_spaceItemService);
        }

        #endregion Constructors

        #region Methods

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        #endregion Methods
    }
}