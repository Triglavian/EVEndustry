using System.ComponentModel.DataAnnotations;

namespace EVEndustry.Models.ItemModels;

public class MinmatarT2Subcap : T2Starship
{
    //Components
    [Display(Name = "Plasma Thruster")]
    public int Thruster { get; set; } = 0;
    [Display(Name = "Ladar Sensor Cluster")]
    public int SensorCluster { get; set; } = 0;
    [Display(Name = "Nanomechanical Microprocessor")]
    public int Microprocessor { get; set; } = 0;
    [Display(Name = "Fernite Carbide Composite Armor Plate")]
    public int ArmorPlate { get; set; } = 0;
    [Display(Name = "Nuclear Reactor Unit")]
    public int ReactorUnit { get; set; } = 0;
    [Display(Name = "Electrolytic Capacitor Unit")]
    public int CapacitorUnit { get; set; } = 0;
    [Display(Name = "Deflection Shield Emitter")]
    public int ShieldEmitter { get; set; } = 0;

    //Base ships
    public int Slasher { get; set; } = 0;
    public int Probe { get; set; } = 0;
    public int Rifter { get; set; } = 0;
    public int Breacher { get; set; } = 0;
    public int Burst { get; set; } = 0;
    public int Vigil { get; set; } = 0;
    public int Talwar { get; set; } = 0;
    public int Thrasher { get; set; } = 0;
    public int Rupture { get; set; } = 0;
    public int Scythe { get; set; } = 0;
    public int Stabber { get; set; } = 0;
    public int Bellicose { get; set; } = 0;
    public int Cyclone { get; set; } = 0;
    public int Hurricane { get; set; } = 0;
    public int Tempest { get; set; } = 0;
    public int Typhoon { get; set; } = 0;
    public int Mammoth { get; set; } = 0;
    public int Wreathe { get; set; } = 0;
}
