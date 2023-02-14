using eTickets.Data;
using eTickets.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class NewMovieVM
    {
        public int Id { get; set; }

        [Display(Name = "Tên bộ phim")]
        [Required(ErrorMessage = "Tên bộ phim là bắt buộc nhập")]
        public string Name { get; set; }

        [Display(Name = "Tóm Tắt bộ phim")]
        [Required(ErrorMessage = "Tóm Tắt bộ phim là bắt buộc nhập")]
        public string Description { get; set; }

        [Display(Name = "Giá tiền")]
        [Required(ErrorMessage = "Giá tiền bắt buộc nhập")]
        public double Price { get; set; }

        [Display(Name = "Link Ảnh bộ phim" )]
        [Required(ErrorMessage = "Link anh là bắt buộc nhập")]
        public string ImageURL { get; set; }

        [Display(Name = "Ngày bắt đầu ")]
        [Required(ErrorMessage = "Ngày bắt đầu bắt buộc nhập ")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Ngày kết thúc")]
        [Required(ErrorMessage = "Ngày kết thúc bắt buộc nhập")]
        public DateTime EndDate { get; set; }

        [Display(Name = "thể loại phim ")]
        [Required(ErrorMessage = "thể loại phim bắt buộc nhập")]
        public MovieCategory MovieCategory { get; set; }

        //Relationships
        [Display(Name = "Diễn viên ")]
        [Required(ErrorMessage = "Diễn viên bắt buộc nhập ")]
        public List<int> ActorIds { get; set; }

        [Display(Name = "chọn rạp chiếp phim ")]
        [Required(ErrorMessage = "chọn rạp chiếp phim là bắt buộc nhập")]
        public int CinemaId { get; set; }

        [Display(Name = "Chọn nhà sản xuất")]
        [Required(ErrorMessage = "Chọn nhà sản xuất là bắt buộc nhập")]
        public int ProducerId { get; set; }
    }
}
