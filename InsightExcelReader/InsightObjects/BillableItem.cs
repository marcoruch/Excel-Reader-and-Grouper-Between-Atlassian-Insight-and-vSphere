using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsightExcelReader.InsightObjects
{
    public class BillableItem : ICloneable
    {
        public int Id { get; set; }
        public object Key { get; set; }
        public object Name { get; set; }
        public object Status { get; set; }
        public object Betriebssystem { get; set; }
        public object Beschreibung { get; set; }
        public object Firma { get; set; }
        public object Applikation { get; set; }
        public object IPAdresse { get; set; }
        public object VirtuellPhysisch { get; set; }
        public object IPAMerfasst { get; set; }
        public object PasswoerterinKeePass { get; set; }
        public object VMWare { get; set; }
        public object ActiveDirectory { get; set; }
        public object InOUverschoben { get; set; }
        public object PRTGStandard { get; set; }
        public object BACKUP_konfiguriert { get; set; }
        public object BACKUP_Intervall { get; set; }
        public object BACKUP_Kontrolle { get; set; }
        public object REBOOT_eingerichtet { get; set; }
        public object REBOOT_Intervall { get; set; }
        public object Virenschutz { get; set; }
        public object Art_des_Virenschutzes { get; set; }
        public object Realtime_Protection { get; set; }
        public object CONFLUENCE { get; set; }
        public object Lokales_Adminpasswort { get; set; }
        public object Updated { get; set; }
        public object Created { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}


