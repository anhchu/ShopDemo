using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Model.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [MaxLength(256)]
        public string Name { get; set; }

        [Required]
        public float Price { get; set; }

        public Boolean Status { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }  


    }
}