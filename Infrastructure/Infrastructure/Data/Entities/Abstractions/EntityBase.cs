namespace Recreate.Infrastructure.Data.Entities.Abstractions
{
    public abstract class EntityBase : IEntity
    {
        public DateTime? Created { get; set; }
        public DateTime? Modified { get; set; }
        public int Id { get; set; }
    }
}
