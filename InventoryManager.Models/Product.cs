using InventoryManager.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public Size Size { get; set; }

        [Required]
        public decimal SinglePrice { get; set; }

        public string Description { get; set; }

        [Required]
        public string CreatorId { get; set; }

        public virtual User Creator { get; set; }

    }
}
