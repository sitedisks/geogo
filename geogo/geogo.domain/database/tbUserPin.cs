namespace geogo.domain.database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("geogo.tbUserPin")]
    public partial class tbUserPin
    {
        public long Id { get; set; }

        public long? UserId { get; set; }

        public long PinId { get; set; }

        [Column(TypeName = "tinytext")]
        [StringLength(255)]
        public string MobileNumber { get; set; }

        [Column(TypeName = "bit")]
        public bool? IsInviteSent { get; set; }

        public DateTime? DateInviteSent { get; set; }

        public int? InviteSentCounter { get; set; }

        public virtual tbPin tbPin { get; set; }

        public virtual tbUser tbUser { get; set; }
    }
}
