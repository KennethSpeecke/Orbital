namespace Imi.Project.Api.Core.Entities.Bases
{
    public abstract class BaseEntity<TKey>
    {
        #region Properties

        public TKey Id { get; set; }

        #endregion Properties
    }
}