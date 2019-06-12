using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Shop.Model.Models
{
    [Table("Foods")]
    public class Food
    {
        [Key]
        public int FoodID { set; get; }
        [Required]
        [Column(TypeName ="nvarchar")]
        [MaxLength(256)]
        public string FoodName { set; get; }

    }
}
