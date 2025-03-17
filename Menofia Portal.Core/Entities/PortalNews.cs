namespace Menofia_Portal.Core.Entities
{
    public class PortalNews
    {
        public int News_Id { get; set; }
        public DateTime Date { get; set; }

        public string Image { get; set; }

        public Guid OwnerId { get; set; }

        public ICollection<NewsTranslation?> Translations { get; set; } = [];
    }
}
