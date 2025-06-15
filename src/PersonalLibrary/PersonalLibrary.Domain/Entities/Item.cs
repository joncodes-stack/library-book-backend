using PersonalLibrary.Domain.Entities;
using PersonalLibrary.Domain.Enums;

namespace PersonalLibrary.Domain.Entities
{
    public class Item : BaseEntity
    {
        public Item()
        {
            
        }

        public Item(string title, TypeEnum type, string author_Platform, string imageUrl, int currentProgress, int totalProgress, float progress, DateTime createdAt, DateTime updatedAt)
        {
            Title = title;
            Type = type;
            Author_Platform = author_Platform;
            ImageUrl = imageUrl;
            CurrentProgress = currentProgress;
            TotalProgress = totalProgress;
            Progress = progress;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }

        public string Title { get; set; }
        public TypeEnum Type { get; set; }
        public string Author_Platform { get; set; }
        public string ImageUrl { get; set; }
        public int CurrentProgress { get; set; }
        public int TotalProgress { get; set; }
        public float Progress { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Status Status { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual User User { get; set; }

    }
}
