namespace Core.Entities.Base
{
    public abstract class ByPassBase : EntityBaseGuid
    {
        public virtual bool IsComplete { get; set; }
    }
}
