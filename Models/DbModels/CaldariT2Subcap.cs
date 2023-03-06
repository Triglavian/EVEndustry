using System.ComponentModel.DataAnnotations;

namespace EVEndustry.Models.ItemModels;

public class CaldariT2Subcap : T2Starship
{
    //Components
    [Display(Name = "Magpulse Thruster")]
    public int Thruster { get; set; } = 0;
    [Display(Name = "Gravimetric Sensor Cluster")]
    public int SensorCluster { get; set; } = 0;
    [Display(Name = "Quantum Microprocessor")]
    public int Microprocessor { get; set; } = 0;
    [Display(Name = "Titanium Diborite Armor Plate")]
    public int ArmorPlate { get; set; } = 0;
    [Display(Name = "Graviton Reactor Unit")]
    public int ReactorUnit { get; set; } = 0;
    [Display(Name = "Scalar Capacitor Unit")]
    public int CapacitorUnit { get; set; } = 0;
    [Display(Name = "Sustained Shield Emitter")]
    public int ShieldEmitter { get; set; } = 0;

    //Base ships
    public int Condor { get; set; } = 0;
    public int Merlin { get; set; } = 0;
    public int Heron { get; set; } = 0;
    public int Griffin { get; set; } = 0;
    public int Bantam { get; set; } = 0;
    public int Corax { get; set; } = 0;
    public int Cormorant { get; set; } = 0;
    public int Osprey { get; set; } = 0;
    public int Caracal { get; set; } = 0;
    public int Moa { get; set; } = 0;
    public int Blackbird { get; set; } = 0;
    public int Ferox { get; set; } = 0;
    public int Drake { get; set; } = 0;
    public int Raven { get; set; } = 0;
    public int Scorpion { get; set; } = 0;
    public int Badger { get; set; } = 0;
    public int Tayra { get; set; } = 0;
}
