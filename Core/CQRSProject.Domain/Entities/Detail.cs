using CQRSProject.Domain.Common;

namespace CQRSProject.Domain.Entities
{
    public class Detail : EntityBase
    {
        public Detail()
        {
        }

        public Detail(string title, string description, int categoryId, Category category)
        {
            Title = title;
            Description = description;
            CategoryId = categoryId;
            Category = category;
        }

        public required string Title { get; set; }
        public required string Description { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
