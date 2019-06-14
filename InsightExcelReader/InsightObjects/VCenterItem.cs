using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsightExcelReader.InsightObjects
{
    public class VCenterItem
    {
        public int Id { get; set; }
        public object Name { get; set; }
        public object Zustand { get; set; }
        public object Status { get; set; }
        public object Verwaltet_von { get; set; }
        public object Host { get; set; }
        public object Bereitgesteller_Speicherplatz { get; set; }
        public object Verwendeter_Speicherplatz { get; set; }
        public object Gastbetriebssystem { get; set; }
        public object Kompatibilität { get; set; }
        public object Arbeitsspeichergroesse { get; set; }
        public object Reservierung { get; set; }
        public object CPUs { get; set; }
        public object Netzwerkkarten { get; set; }
        public object Betriebssystem { get; set; }
        public object Betriebszeit { get; set; }
        public object IPAddress { get; set; }
        public object VersionsstatusVonVMWareTools { get; set; }
        public object AusfuehrungsStatusVonVMWareTools { get; set; }
        public object DNSName { get; set; }
        public object EVC_Mode { get; set; }
        public object UUID { get; set; }
        public object Hinweise { get; set; }
        public object Alarmaktionen { get; set; }
        public object HA_SCHUTZ { get; set; }
        public object KonsolidierungErforderlich { get; set; }
        public object EinhaltungDerVMSpeicherrichtlinien { get; set; }
        public object Verschluesselung { get; set; }
        public object TPM { get; set; }
        public object VBS { get; set; }
        public object HOST_CPU { get; set; }
        public object Hostarbeitsspeicher { get; set; }
        public object GastarbeitsspeicherPercent { get; set; }


    }
}
