using System.ComponentModel.DataAnnotations;

namespace EVEndustry.Models.ItemModels;

public abstract class Item
{
    [Key]
    public int TypeId { get; set; } = 0;
    public string Name { get; set; } = string.Empty;
}
