using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace API_Ecommerce.Model;

public class Product
{
    [Key]
    public int ProductId { get; set; }
    
    [Required]
    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    [Range(0, double.MaxValue)]
    [Column(TypeName = "decimal(18,2)")]
    public decimal Price { get; set; }

    public string ImageUrl { get; set; } = string.Empty;

    [Required]
    public string SKU { get; set; } = string.Empty;

    [Range(0, int.MaxValue)]
    public int Stock { get; set; }
    
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime? UpdateAt { get; set; } = null;

    //Relationships 
    public int CategoryId { get; set;}
    [ForeignKey("CategoryId")]

    [Required]
    public Category? Category { get; set; }

}
