namespace NguyenDucTien_2280603224.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sinh_Vien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sinh_Vien()
        {
            Users = new HashSet<User>();
        }

        [Key]
        [StringLength(10)]
        public string Ma_Sinh_Vien { get; set; }

        [Required]
        [StringLength(50)]
        public string Khoa { get; set; }

        public DateTime Ngay_Nhap_Hoc { get; set; }

        public int Trang_Thai_Hoc_Tap { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> Users { get; set; }
    }
}
