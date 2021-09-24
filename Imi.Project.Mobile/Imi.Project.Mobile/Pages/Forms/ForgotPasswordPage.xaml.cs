using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace Imi.Project.Mobile.Pages.Forms
{
    /// <summary>
    /// Page to retrieve the password forgotten.
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ForgotPasswordPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ForgotPasswordPage" /> class.
        /// </summary>
        public ForgotPasswordPage()
        {
            InitializeComponent();
        }

        private void SignUp_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new SignUpPage());
        }

        private void SendPassword_Clicked(object sender, System.EventArgs e)
        {

        }
    }
}