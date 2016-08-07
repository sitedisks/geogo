namespace geogo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("geogo.tbPin")]
    public partial class tbPin
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbPin()
        {
            tbPinComments = new HashSet<tbPinComment>();
            tbUserPins = new HashSet<tbUserPin>();
        }

        public long Id { get; set; }

        public long UserId { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public double? MaxDistance { get; set; }

        [StringLength(45)]
        public string ImageUri { get; set; }

        [Column(TypeName = "tinytext")]
        [StringLength(255)]
        public string Text { get; set; }

        [Column(TypeName = "bit")]
        public bool IsPrivate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedDateTime { get; set; }

        [Column(TypeName = "bit")]
        public bool IsDeleted { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbPinComment> tbPinComments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbUserPin> tbUserPins { get; set; }

        public virtual tbUser tbUser { get; set; }
    }
}
