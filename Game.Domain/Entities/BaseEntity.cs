namespace Game.Domain.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; } 
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public EntityStatus EntityStatus { get; set; } = EntityStatus.Active;
    }
}
