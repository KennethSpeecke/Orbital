namespace Imi.Project.Api.Core.Dtos.Bases
{
    public class BaseDto<TKey>
    {
        #region Properties

        public TKey Id { get; set; }

        #endregion Properties
    }
}