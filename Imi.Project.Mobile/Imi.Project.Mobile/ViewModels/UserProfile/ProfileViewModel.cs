using FreshMvvm;
using Imi.Project.Mobile.ViewModels.Settings;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace Imi.Project.Mobile.ViewModels.UserProfile
{
    /// <summary>
    /// ViewModel for Article profile page
    /// </summary>
    [Preserve(AllMembers = true)]
    public class ProfileViewModel : FreshBasePageModel
    {
        #region Fields

        private string email;
        private string profileImage;

        private string profileName;

        #endregion Fields

        #region Constructor

        /// <summary>
        /// Initializes a new instance for the <see cref="ProfileViewModel" /> class.
        /// </summary>
        public ProfileViewModel()
        {
            this.profileImage = "http://via.placeholder.com/50x50";
            this.profileName = "John Deo";
            this.email = "johndoe@JaneDoe.com";

            this.EditProfileCommand = new Command(this.EditButtonClicked);
            this.MyFavoritesCommand = new Command(this.FavoritesClicked);
            this.MyCommentsCommand = new Command(this.CommentsClicked);
        }

        #endregion Constructor

        #region Public properties

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        public string Email
        {
            get
            {
                return this.email;
            }

            set
            {
                if (this.email != value)
                {
                    this.email = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>
        /// Gets or sets the profile image.
        /// </summary>
        public string ProfileImage
        {
            get
            {
                return this.profileImage;
            }

            set
            {
                if (this.profileImage != value)
                {
                    this.profileImage = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>
        /// Gets or sets the profile name.
        /// </summary>
        public string ProfileName
        {
            get
            {
                return this.profileName;
            }

            set
            {
                if (this.profileName != value)
                {
                    this.profileName = value;
                    RaisePropertyChanged();
                }
            }
        }

        #endregion Public properties

        #region Command

        /// <summary>
        /// Gets or sets the command that is executed when the edit button is clicked.
        /// </summary>
        public Command EditProfileCommand { get; set; }

        /// <summary>
        /// Gets or sets the command that is executed when the settings option is clicked.
        /// </summary>
        public Command MyCommentsCommand { get; set; }

        /// <summary>
        /// Gets or sets the command that is executed when the Text size option is clicked.
        /// </summary>
        public Command MyFavoritesCommand { get; set; }

        #endregion Command

        #region Methods

        /// <summary>
        /// Invoked when the edit button is clicked.
        /// </summary>
        /// <param name="obj">The object</param>
        private async void EditButtonClicked(object obj)
        {
            await CoreMethods.PushPageModel<SettingViewModel>(); //Send user profile with navigation as object here.
        }

        /// <summary>
        /// Invoked when the settings option is clicked.
        /// </summary>
        /// <param name="obj">The object</param>
        private async void CommentsClicked(object obj)
        {
            var grid = obj as Grid;
            Application.Current.Resources.TryGetValue("Gray-100", out var retVal);
            grid.BackgroundColor = (Color)retVal;

            // To make the selected item color changes for 100 milliseconds.
            await Task.Delay(100);
            Application.Current.Resources.TryGetValue("Gray-White", out var retValue);
            grid.BackgroundColor = (Color)retValue;
        }

        /// <summary>
        /// Invoked when the text size option is clicked.
        /// </summary>
        /// <param name="obj">The object</param>
        private async void FavoritesClicked(object obj)
        {
            var grid = obj as Grid;
            Application.Current.Resources.TryGetValue("Gray-100", out var retVal);
            grid.BackgroundColor = (Color)retVal;

            // To make the selected item color changes for 100 milliseconds.
            await Task.Delay(100);
            Application.Current.Resources.TryGetValue("Gray-White", out var retValue);
            grid.BackgroundColor = (Color)retValue;
        }

        #endregion Methods
    }
}