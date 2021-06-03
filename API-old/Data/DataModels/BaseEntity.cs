using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Sams.Data.DataModels
{
    public abstract class BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>
        /// The user who added the entity.
        /// </summary>
        [JsonIgnore]
        public DateTime CreatedUtc { get; set; }

        /// <summary>
        /// A value indicating when the entity was added to the data store.
        /// </summary>
        [MaxLength(320)]
        [JsonIgnore]
        public string CreatedBy { get; set; }

        /// <summary>
        /// A value indicating if the entity was deleted.
        /// </summary>>
        [NotMapped]
        public bool IsDeleted => DeletedAtUtc.HasValue && DeletedAtUtc.Value <= DateTime.UtcNow;

        /// <summary>
        /// A value indicating who deleted the entity.
        /// </summary>>
        [MaxLength(320)]
        [JsonIgnore]
        public string DeletedBy { get; set; }

        /// <summary>
        /// A value indicating the time at which the entity was deleted.
        /// </summary>>
        [JsonIgnore]
        public DateTime? DeletedAtUtc { get; set; }

        /// <summary>
        /// A value indicating the last time the entity was updated.
        /// </summary>
        [JsonIgnore]
        public DateTime UpdatedUtc { get; set; }

        /// <summary>
        /// The user who last updated the entity.
        /// </summary>
        [MaxLength(320)]
        [JsonIgnore]
        public string UpdatedBy { get; set; }
    }
}
