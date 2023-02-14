using eTickets.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Producer:IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Ảnh đại diện")]
        [Required(ErrorMessage = "Ảnh đại diện là bắt buộc nhập")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Họ và tên nhà sản xuất  ")]
        [Required(ErrorMessage = "Họ và tên nhà sản xuất là bắt buộc nhập")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Họ và Tên phải có từ 3 đến 50 ký tự")]
        public string FullName { get; set; }

        [Display(Name = "Tiểu sử")]
        [Required(ErrorMessage = "Tiểu sử là bắt buộc nhập")]
        public string Bio { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
