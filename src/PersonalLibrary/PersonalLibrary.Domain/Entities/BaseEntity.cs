namespace PersonalLibrary.Domain.Entities
{
    public class BaseEntity
    {
        protected BaseEntity()
        {
            Id = Guid.NewGuid();
            Created_At= DateTime.Now;
        }

        public Guid Id { get; set; }
        public DateTime Created_At { get; set; }

    }
}
