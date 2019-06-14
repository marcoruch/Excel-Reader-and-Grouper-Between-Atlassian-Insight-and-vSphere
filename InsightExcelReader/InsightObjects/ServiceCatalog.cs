using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsightExcelReader.InsightObjects
{
    public class ServiceCatalog
    {
        public List<CatalogItem> CatalogItems { get; set; } = new List<CatalogItem>
        {
            new CatalogItem {Identifier = "CPU", PricePerPiece = 18.00},
            new CatalogItem {Identifier = "RAM", PricePerPiece = 15.00},
            new CatalogItem {Identifier = "Speicher", PricePerPiece = 0.30},
            new CatalogItem {Identifier = "Lizenzen", PricePerPiece = 22.45},
            new CatalogItem {Identifier = "Unkosten", PricePerPiece = 51.60},
            new CatalogItem {Identifier = "Server Management", PricePerPiece = 130.00},
            new CatalogItem {Identifier = "Backup Daten", PricePerPiece = 0.55},
            new CatalogItem {Identifier = "Backup VM", PricePerPiece = 0.55},
            new CatalogItem {Identifier = "Grundkonfiguration", PricePerPiece =   200.00},
            new CatalogItem {Identifier = "Speicher", PricePerPiece =     0.30},
            new CatalogItem {Identifier = "Backup", PricePerPiece =   0.55},
            new CatalogItem {Identifier = "Speicher (Fass Steiger)", PricePerPiece =  0.30},
            new CatalogItem {Identifier = "Backup (Fass Steiger)", PricePerPiece =    0.55},
            new CatalogItem {Identifier = "Domain Account", PricePerPiece =   26.75},
            new CatalogItem {Identifier = "Postfach (Exchange)", PricePerPiece =  7.50},
            new CatalogItem {Identifier = "OWA", PricePerPiece =  2.50},
            new CatalogItem {Identifier = "ActivSync", PricePerPiece =    2.50},
            new CatalogItem {Identifier = "Grösseres Postfach (je 250MB)", PricePerPiece =    0.20},
            new CatalogItem {Identifier = "Grössere Homelaufwerke", PricePerPiece =   0.85},
            new CatalogItem {Identifier = "VoiceRecorder (Speicher)", PricePerPiece =     0.85},
            new CatalogItem {Identifier = "StreamServe - Projekte/Dienste", PricePerPiece =         12.05},
            new CatalogItem {Identifier = "Speicher Archiv (pro GB)", PricePerPiece =         0.30},
            new CatalogItem {Identifier = "Visual Crone - Projekte/Dienste", PricePerPiece =        0.30},
            new CatalogItem {Identifier = "Citrix User", PricePerPiece =          31.00},
            new CatalogItem {Identifier = "Office", PricePerPiece =         16.50},
            new CatalogItem {Identifier = "CAG", PricePerPiece =        9.90},
        };
    }

    public class CatalogItem
    {
        public string Identifier { get; set; }
        public double PricePerPiece { get; set; }
    }
}
