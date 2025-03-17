using Menofia_Portal.Core.Entities;

namespace Menofia_Portal.Core.Specification
{
    public class NewsWithTranslationSpecification : BaseSpecification<PortalNews>
    {
        public NewsWithTranslationSpecification(DateTime? dateTime) : base(N => !dateTime.HasValue || N.Date == dateTime)
        {
            Includes.Add(N => N.Translations);
        }
    }
}
