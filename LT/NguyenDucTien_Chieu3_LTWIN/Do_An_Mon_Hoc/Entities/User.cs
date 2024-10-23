namespace NguyenDucTien_2280603224.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [StringLength(10)]
        public string UserID { get; set; }

        [StringLength(10)]
        public string Ma_Sinh_Vien { get; set; }

        [StringLength(10)]
        public string Ma_Giang_Vien { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        [Required]
        [StringLength(50)]
        public string Ho { get; set; }

        [Required]
        [StringLength(20)]
        public string Ten { get; set; }

        public DateTime Ngay_Cap { get; set; }

        [Required]
        [StringLength(10)]
        public string So_Dien_Thoai { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        public bool? Gioi_Tinh { get; set; }

        public DateTime Ngay_Sinh { get; set; }

        public bool? Trang_Thai_Hoat_Dong { get; set; }

        [StringLength(255)]
        public string Dia_Chi { get; set; }

        public virtual Giang_Vien Giang_Vien { get; set; }

        public virtual Sinh_Vien Sinh_Vien { get; set; }
    }
}
