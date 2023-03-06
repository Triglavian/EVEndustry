using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EVEndustry.Models.ItemModels;

public class T1Production : Item
{
    int Tritanium { get; set; } = 0; 
    int Pyerite { get; set; } = 0;
    int Mexallon { get; set; } = 0;
    int Isogen { get; set; } = 0;
    int Nocxium { get; set; } = 0;
    int Zydrine { get; set; } = 0;
    int Megacyte { get; set; } = 0;

    int CrystallineIsogen10 { get; set; } = 0;
    int ZeroPointCondensate { get; set; } = 0;
    
    int AutoIntegrityPreservationSeal { get; set; } = 0;
    int LifeSupportBackupUnit { get; set; } = 0;
    int CoreTemperatureRegulator { get; set; } = 0;
    int ROTriggerNeurolinkConduit { get; set; } = 0;
    int SRTriggerNeurolinkConduit { get; set; } = 0;
    int GOTriggerNeurolinkConduit { get; set; } = 0;
    int UCTriggerNeurolinkConduit { get; set; } = 0;
}
