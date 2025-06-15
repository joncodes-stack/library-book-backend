namespace PersonalLibrary.Domain.Entities
{
    public class Status : BaseEntity
    {
        public Status(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
