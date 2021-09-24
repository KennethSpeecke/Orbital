using FreshMvvm;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace Imi.Project.Mobile.ViewModels.Forms
{
    /// <summary>
    /// ViewModel for reset password page.
    /// </summary>
    [Preserve(AllMembers = true)]
    public class ResetPasswordViewModel : FreshBasePageModel
    {
        #region Fields

        private string confirmPassword;
        private string newPassword;

        #endregion Fields

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="ResetPasswordViewModel" /> class.
        /// </summary>
        public ResetPasswordViewModel()
        {
            this.SubmitCommand = new Command(this.SubmitClicked);
            this.SignUpCommand = new Command(this.SignUpClicked);
        }

        #endregion Constructor

        #region Command

        /// <summary>
        /// Gets or sets the command that is executed when the Sign Up button is clicked.
        /// </summary>
        public Command SignUpCommand { get; set; }

        /// <summary>
        /// Gets or sets the command that is executed when the Submit button is clicked.
        /// </summary>
        public Command SubmitCommand { get; set; }

        #endregion Command

        #region Public property

        /// <summary>
        /// Gets or sets the property that bounds with an entry that gets the new password confirmation from the user in the reset password page.
        /// </summary>
        public string ConfirmPassword
        {
            get
            {
                return this.confirmPassword;
            }

            set
            {
                if (this.confirmPassword == value)
                {
                    return;
                }

                this.confirmPassword = value;
                RaisePropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the property that bounds with an entry that gets the new password from user in the reset password page.
        /// </summary>
        public string NewPassword
        {
            get
            {
                return this.newPassword;
            }

            set
            {
                if (this.newPassword == value)
                {
                    return;
                }

                this.newPassword = value;
                RaisePropertyChanged();
            }
        }

        #endregion Public property

        #region Methods

        /// <summary>
        /// Invoked when the Sign Up button is clicked.
        /// </summary>
        /// <param name="obj">The Object</param>
        private void SignUpClicked(object obj)
        {
            // Do something
        }

        /// <summary>
        /// Invoked when the Submit button is clicked.
        /// </summary>
        /// <param name="obj">The Object</param>
        private void SubmitClicked(object obj)
        {
            // Do something
        }

        #endregion Methods
    }
}