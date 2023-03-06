using System.ComponentModel.DataAnnotations;

namespace EVEndustry.Models.ItemModels;

public class AmarrT2Subcap : T2Starship
{
    //Components
    [Display(Name = "Fusion Thruster")]
    public int Thruster { get; set; } = 0;
    [Display(Name = "Radar Sensor Cluster")]
    public int SensorCluster { get; set; } = 0;
    [Display(Name = "Nanoelectrical Microprocessor")]
    public int Microprocessor { get; set; } = 0;
    [Display(Name = "Tungsten Carbide Armor Plate")]
    public int ArmorPlate { get; set; } = 0;
    [Display(Name = "Antimatter Reactor Unit")]
    public int ReactorUnit { get; set; } = 0;
    [Display(Name = "Tesseract Capacitor Unit")]
    public int CapacitorUnit { get; set; } = 0;
    [Display(Name = "Linear Shield Emitter")]
    public int ShieldEmitter { get; set; } = 0;

    //Base ships
    public int Executioner { get; set; } = 0;
    public int Punisher { get; set; } = 0;
    public int Magnate { get; set; } = 0;
    public int Crucifier { get; set; } = 0;
    public int Inquisitor { get; set; } = 0;
    public int Dragoon { get; set; } = 0;
    public int Coercer { get; set; } = 0;
    public int Augoror { get; set; } = 0;
    public int Omen { get; set; } = 0;
    public int Maller { get; set; } = 0;
    public int Arbitrator { get; set; } = 0;
    public int Prophecy { get; set; } = 0;
    public int Harbinger { get; set; } = 0;
    public int Apocalypse { get; set; } = 0;
    public int Armageddon { get; set; } = 0;
    public int Bestower { get; set; } = 0;
    public int Sigil { get; set; } = 0;
}
