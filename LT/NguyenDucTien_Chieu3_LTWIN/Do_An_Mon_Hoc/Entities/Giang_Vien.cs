namespace NguyenDucTien_2280603224.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Giang_Vien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Giang_Vien()
        {
            Users = new HashSet<User>();
        }

        [Key]
        [StringLength(10)]
        public string Ma_Giang_Vien { get; set; }

        [Required]
        [StringLength(50)]
        public string Chuc_Vu { get; set; }

        [Required]
        [StringLength(50)]
        public string Trinh_Do { get; set; }

        [Required]
        [StringLength(50)]
        public string Khoa { get; set; }

        public int Trang_Thai_Lam_Viec { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> Users { get; set; }
    }
}
