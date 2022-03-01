using BankCurrencyService.Common.Constants;
using System.ComponentModel.DataAnnotations;

namespace BankCurrencyService.Domain
{
    public abstract class EntityBase<TKey> : IEntity<TKey>
    {
        public TKey Key { get; set; } = default!;

        public Guid? CreatorKey { get; set; }

        [StringLength(ValidationConstants.FullNameMaxLength)]
        public string? Creator { get; set; }
        
        [StringLength(ValidationConstants.UserName)]
        public string? CreatorUserName { get; set; }

        public DateTime CreatedDate { get; set; }

        public Guid? LastUpdaterKey { get; set; }

        [StringLength(ValidationConstants.FullNameMaxLength)]
        public string? LastUpdater { get; set; }

        [StringLength(ValidationConstants.UserName)]
        public string? LastUpdaterUserName { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
    }
}
