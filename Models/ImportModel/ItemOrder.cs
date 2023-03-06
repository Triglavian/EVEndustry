using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EVEndustry.Models.ImportModel;

public class ItemOrder
{

    //Left order duration
    int Duration { get; set; } = 0;
    //Order type flag
    bool IsBuyOrder { get; set; } = false;
    //Issued unix time
    string issued { get; set; } = string.Empty;
    //Location id that order is bidded
    long LocationId { get; set; } = 0;
    //Min volume that buyer require per trade, Jita 4-4 id is 
    int MinVolume { get; set; } = 0;
    //Order id
    long OrderId { get; set; } = 0;
    //Order price
    double Price { get; set; } = 0;
    //Order acception range
    string Range { get; set; } = string.Empty;
    //System id that order is bidded, Jita id is 
    int SystemId { get; set; } = 0;
    //Item type id
    int TypeId { get; set; } = 0;
    //Remain volume of order
    int VolumeRemain { get; set; } = 0;
    //Total volume of order
    int VolumeTotal { get; set; } = 0;
}
