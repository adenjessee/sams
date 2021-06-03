using System.ComponentModel.DataAnnotations;

namespace Sams.Data.DataModels
{
    public class ListItem : BaseEntity
    {
        [StringLength(20)] [Required] public string ListTypeName { get; set; }

        [StringLength(50, MinimumLength = 2)]
        [Required]
        public string DisplayValue { get; set; }

        [StringLength(20)] [Required] public string Value { get; set; }
        [Required] public string HintText { get; set; }
        [Required] public string Description { get; set; }

        public ListItem()
        {
            HintText = string.Empty;
            Description = string.Empty;
        }
    }
}
