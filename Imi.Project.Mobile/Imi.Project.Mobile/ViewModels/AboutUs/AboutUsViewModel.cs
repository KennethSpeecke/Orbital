using FreshMvvm;
using Imi.Project.Mobile.Domain.Models.AboutUs;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace Imi.Project.Mobile.ViewModels.AboutUs
{
    /// <summary>
    /// ViewModel of AboutUs templates.
    /// </summary>
    [Preserve(AllMembers = true)]
    public class AboutUsViewModel : FreshBasePageModel
    {
        #region Fields

        private string cardsTopImage;
        private string productDescription;

        private string productIcon;
        private string productVersion;

        #endregion Fields

        #region Constructor

        /// <summary>
        /// Initializes a new instance for the <see cref="T:Imi.Project.Mobile.ViewModels.AboutUs.AboutUsViewModel"/> class.
        /// </summary>
        public AboutUsViewModel()
        {
            this.productDescription = "Orbital is an application that can display information about the Stuff In Space." +
                "The user can find out through the application where objects are located from their point of view.";

            this.productIcon = App.BaseImageUrl + "Icon.png";
            this.productVersion = "0.0.1";
            this.cardsTopImage = App.BaseImageUrl + "Mask.png";

            this.EmployeeDetails = new ObservableCollection<AboutUsModel>
            {
                new AboutUsModel
                {
                    EmployeeName = "Open-Notify Api",
                    Image = "",
                    Designation = "Iss Location Tracking"
                },
                new AboutUsModel
                {
                    EmployeeName = "Nasa Space",
                    Image = "",
                    Designation = "General information of space"
                },
                new AboutUsModel
                {
                    EmployeeName = "Space-Track.org",
                    Image = "",
                    Designation = "Object Location Tracking"
                },
            };

            this.ItemSelectedCommand = new Command(this.ItemSelected);
        }

        #endregion Constructor

        #region Properties

        /// <summary>
        /// Gets or sets the top image source of the About us with cards view.
        /// </summary>
        /// <value>Image source location.</value>
        public string CardsTopImage
        {
            get
            {
                return this.cardsTopImage;
            }

            set
            {
                this.cardsTopImage = value;
                RaisePropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the employee details.
        /// </summary>
        /// <value>The employee details.</value>
        public ObservableCollection<AboutUsModel> EmployeeDetails { get; set; }

        /// <summary>
        /// Gets or sets the command that will be executed when an item is selected.
        /// </summary>
        public Command ItemSelectedCommand { get; set; }

        /// <summary>
        /// Gets or sets the description of a product or a company.
        /// </summary>
        /// <value>The product description.</value>
        public string ProductDescription
        {
            get
            {
                return this.productDescription;
            }

            set
            {
                this.productDescription = value;
                RaisePropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the product icon.
        /// </summary>
        /// <value>The product icon.</value>
        public string ProductIcon
        {
            get
            {
                return this.productIcon;
            }

            set
            {
                this.productIcon = value;
                RaisePropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the product version.
        /// </summary>
        /// <value>The product version.</value>
        public string ProductVersion
        {
            get
            {
                return this.productVersion;
            }

            set
            {
                this.productVersion = value;
                RaisePropertyChanged();
            }
        }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Invoked when an item is selected.
        /// </summary>
        private void ItemSelected(object selectedItem)
        {
            // Do something
        }

        #endregion Methods
    }
}