using PersonalLibrary.Domain.Enums;

namespace PersonalLibrary.Domain.Dtos
{
    public class ItemDto
    {
        public Guid? Id { get; set; }
        public string Title { get; set; }
        public TypeEnum Type { get; set; }
        public string Author_Platform { get; set; }
        public string ImageUrl { get; set; }
        public int CurrentProgress { get; set; }
        public int TotalProgress { get; set; }
    }
}
