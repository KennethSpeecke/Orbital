namespace Imi.Project.Mobile.Extensions
{
    public static class BoolToAdverbialConverterExtension
    {
        #region Fields

        private const string adverbialNo = "No";
        private const string adverbialUnknown = "NotFound";
        private const string adverbialYes = "Yes";

        #endregion Fields

        #region Methods

        public static string ConvertBoolToString(bool toConvert)
        {
            switch (toConvert)
            {
                case true:
                    return adverbialYes;

                case false:
                    return adverbialNo;

                default:
                    return adverbialUnknown;
            }
        }

        public static bool ConvertStringAdverbialToBool(string adverbialValue)
        {
            switch (adverbialValue)
            {
                case adverbialYes:
                    return true;

                case adverbialNo:
                    return false;

                default:
                    return false;
            }
        }

        #endregion Methods
    }
}