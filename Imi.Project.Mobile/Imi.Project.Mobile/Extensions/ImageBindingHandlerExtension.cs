using System;

namespace Imi.Project.Mobile.Extensions
{
    public static class ImageBindingHandlerExtension
    {
        #region Fields

        private static string baseApiUri = "http://192.168.0.245:5000/Images/SpaceObjects/"; //Orbital api base image url with path to image root.
        private static string baseImageUri = "http://192.168.0.245:5000/Images/Application/default.png"; //OrbitlApi Default Image Fetch URL NOSLL NOT SECURE!!! Change when going live

        #endregion Fields

        #region Methods

        public static Uri CheckIfImageIsValid(string imageUrl)
        {
            try
            {
                if (imageUrl == null)
                    return new Uri(baseImageUri);
                if (imageUrl.Contains("default"))
                    return new Uri(baseImageUri);
                else
                    return new Uri($"{baseApiUri}{imageUrl}");
            }
            catch
            {
                return new Uri(baseImageUri);
            }
        }

        #endregion Methods
    }
}