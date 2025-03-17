namespace Monofia_Portal.Services.DTOs
{
    public class NewsDto
    {
        public DateTime Date { get; set; }

        public string Image { get; set; }
        public IReadOnlyList<string> Header { get; set; }

        public IReadOnlyList<string> Abbreviation { get; set; }

    }
}
