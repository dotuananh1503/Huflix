using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Huflix.Areas.Admin.Models
{
    public class Receipt
    {
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("Ngày")]
        [Required(ErrorMessage = "Not null")]
        public DateTime Date { get; set; }

        public Customer Customer { get; set; }
        [DisplayName("Mã KH")]
        [Required(ErrorMessage = "Not null")]
        public int CustomerId { get; set; }


        [DisplayName("Tổng tiền")]
        [Required(ErrorMessage = "Not null")]
        public int TotalCost { get; set; }

        [DisplayName("Điểm tích lũy")]
        [Required(ErrorMessage = "Not null")]
        public int Point { get; set; }

        [DisplayName("Ghi chú")]
        public string Note { get; set; }
    }
}
