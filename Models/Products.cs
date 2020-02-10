using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Perfume.Models
{
    public class Products
    {
        [Key]
        
        public int Id { get; set; }
        [StringLength (50)]
        [Required]
        public string Name { get; set; }
        [StringLength(10)]
        [Required]
        public string Gender { get; set; }
        [StringLength(100)]
        [Required]
        public string  Brand { get; set; }
        [StringLength(50)]
        [Required]
        public string Producer { get; set; }
        [Required]
       
        public double Price { get; set; }
        
        [Required]
        public double Sale { get; set; }
        [Required]
        
        public int Amount { get; set; }
        public string Image { get; set; }
    }
}