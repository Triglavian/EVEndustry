using System.ComponentModel.DataAnnotations;

namespace EVEndustry.Models.ItemModels;

public abstract class T2Starship : Item
{
    /*
    //Caldari
    public int MagpulseThruster { get; set; } = 0;
    public int GravimetricSensorCluster { get; set; } = 0;
    public int QuantumMicroprocessor { get; set; } = 0;
    public int TitaniumDiboriteArmorPlate { get; set; } = 0;
    public int GravitonReactorUnit { get; set; } = 0;
    public int ScalarCapacitorUnit { get; set; } = 0;
    public int SustainedShieldEmitter { get; set; } = 0;
    */

    /*
    //Gallente
    public int IonThruster { get; set; } = 0;
    public int MagnetometricSensorCluster { get; set; } = 0;
    public int PhotonMicroprocessor { get; set; } = 0;
    public int CrystallineCarbonideArmorPlate { get; set; } = 0;
    public int FusionReactorUnit { get; set; } = 0;
    public int OscillatorCapacitorUnit { get; set; } = 0;
    public int PulseShieldEmitter { get; set; } = 0;
    */
    /*
    //Minmatar
    public int PlasmaThruster { get; set; } = 0;
    public int LadarSensorCluster { get; set; } = 0;
    public int NanomechanicalMicroprocessor { get; set; } = 0;
    public int FerniteCarbideCompositeArmorPlate { get; set; } = 0;
    public int NuclearReactorUnit { get; set; } = 0;
    public int ElectrolyticCapacitorUnit { get; set; } = 0;
    public int DeflectionShieldEmitter { get; set; } = 0;
    */
    /*
    //Amarr
    [Display(Name = "Fusion Thruster")]
    public int FusionThruster { get; set; } = 0;
    [Display(Name = "Radar Sensor Cluster")]
    public int RadarSensorCluster { get; set; } = 0;
    [Display(Name = "Nanoelectrical Microprocessor")]
    public int NanoelectricalMicroprocessor { get; set; } = 0;
    [Display(Name = "Tungsten Carbide Armor Plate")]
    public int TungstenCarbideArmorPlate { get; set; } = 0;
    [Display(Name = "Antimatter Reactor Unit")]
    public int AntimatterReactorUnit { get; set; } = 0;
    [Display(Name = "Tesseract Capacitor Unit")]
    public int TesseractCapacitorUnit { get; set; } = 0;
    [Display(Name = "Linear Shield Emitter")]
    public int LinearShieldEmitter { get; set; } = 0;
    */
    //ETC
    public int Morphite { get; set; } = 0;
    [Display(Name = "Construction Blocks")]
    public int ConstructionBlocks { get; set; } = 0;
    [Display(Name = "R.A.M.- Starship Tech")]
    public int RAMStarshipTech { get; set; } = 0;
}
