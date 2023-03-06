using System.ComponentModel.DataAnnotations;

namespace EVEndustry.Models.ItemModels;

public class GallenteT2Subcap : T2Starship
{
    //Components
    [Display(Name = "Ion Thruster")]
    public int Thruster { get; set; } = 0;
    [Display(Name = "Magnetometric Sensor Cluster")]
    public int SensorCluster { get; set; } = 0;
    [Display(Name = "Photon Microprocessor")]
    public int Microprocessor { get; set; } = 0;
    [Display(Name = "Crystalline Carbonide Armor Plate")]
    public int ArmorPlate { get; set; } = 0;
    [Display(Name = "Fusion Reactor Unit")]
    public int ReactorUnit { get; set; } = 0;
    [Display(Name = "Oscillator Capacitor Unit")]
    public int CapacitorUnit { get; set; } = 0;
    [Display(Name = "Pulse Shield Emitter")]
    public int ShieldEmitter { get; set; } = 0;

    //Base ships
    public int Navitas { get; set; } = 0;
    public int Tristan { get; set; } = 0;
    public int Incursus { get; set; } = 0;
    public int Imicus { get; set; } = 0;
    public int Atron { get; set; } = 0;
    public int Maulus { get; set; } = 0;
    public int Algos { get; set; } = 0;
    public int Catalyst { get; set; } = 0;
    public int Thorax { get; set; } = 0;
    public int Vexor { get; set; } = 0;
    public int Celestis { get; set; } = 0;
    public int Exequror { get; set; } = 0;
    public int Brutix { get; set; } = 0;
    public int Myrmidon { get; set; } = 0;
    public int Megathron { get; set; } = 0;
    public int Dominix { get; set; } = 0;
    public int Nereus { get; set; } = 0;
    public int Epithal { get; set; } = 0;
}
