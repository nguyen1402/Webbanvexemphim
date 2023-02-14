using eTickets.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Cinema:IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Logo của rạp chiếp phim")]
        [Required(ErrorMessage = "Logo của rạp chiếp phim là bắt buộc nhập")]
        public string Logo { get; set; }

        [Display(Name = "Tên rạp chiếu phim")]
        [Required(ErrorMessage = "Tên rạp chiếu phim là bắt buộc nhập")]
        public string Name { get; set; }

        [Display(Name = "Mô tả về rạp chiếu phim ")]
        [Required(ErrorMessage = "Mô tả về rạp chiếu phim là bắt buộc nhập")]
        public string Description { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
