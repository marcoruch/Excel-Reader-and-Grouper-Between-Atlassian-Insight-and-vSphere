using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InsightExcelReader.InsightObjects;
using Excel = Microsoft.Office.Interop.Excel;

namespace InsightExcelReader
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var shortNameCombos = GetCombosDictionary();
            var billableItems = GetBillableItems();
            var billableServers = GetBillableServers();
            var billableMergedInfos = new List<MergedServerInfo>();


            for (var billableItemIndex = 0; billableItemIndex < billableItems.Count; billableItemIndex++)
            {
                if (billableItems[billableItemIndex].Firma != null && (string)billableItems[billableItemIndex].Firma != "" && shortNameCombos.ContainsKey((string)billableItems[billableItemIndex].Firma))
                {

                    billableItems[billableItemIndex].Firma = shortNameCombos[(string)billableItems[billableItemIndex].Firma];
                }

                for (var billableServerIndex = 0; billableServerIndex < billableServers.Count; billableServerIndex++)
                {
                    if (billableItems[billableItemIndex].Name.Equals(billableServers[billableServerIndex].Name))
                    {
                        billableMergedInfos.Add(new MergedServerInfo()
                        {
                            BillableItem = billableItems[billableItemIndex],
                            VCenterItem = billableServers[billableServerIndex],
                        });
                    }
                }
            }

            var companyList = billableMergedInfos.GroupBy(info => info.BillableItem.Firma).ToList();

           companyList.ForEach(delegate(IGrouping<object, MergedServerInfo> infos)
           {
               Console.ForegroundColor = ConsoleColor.Green;
               Console.WriteLine(infos.First().BillableItem.Firma);
               foreach (var mergedServerInfo in infos)
               {
                   Console.WriteLine("Server: "+ mergedServerInfo.VCenterItem.Name + " - " + mergedServerInfo.VCenterItem.CPUs);
               }


                Console.WriteLine("====================================");
               Console.WriteLine();
           });

            Console.ReadLine();
        }

        private static List<BillableItem> GetBillableItems()
        {
            const string path = "C:\\Users\\mruch\\Desktop\\Excels\\";



            var items = new List<BillableItem>();
            var type = typeof(BillableItem);
            var counter = 0;


            var xlApp = new Excel.Application();
            var xlWorkbook = xlApp.Workbooks.Open(path + "INSIGHT.xlsx");
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            var xlRange = xlWorksheet.UsedRange;

            var rowCount = xlRange.Rows.Count;
            var colCount = xlRange.Columns.Count;

            for (var i = 2; i < rowCount; i++)
            {
                var billableItem = new BillableItem { Id = counter };

                for (var j = 1; j <= colCount; j++)
                {
                    type.GetProperties()[j].SetValue(billableItem, xlRange.Cells[i, j].Value2);

                }

                if (billableItem.Firma != null && ((string)billableItem.Firma).Contains("||"))
                {
                    ((string) billableItem.Firma).Replace("||","|").Split('|').ToList().ForEach(
                        company =>
                        {
                            var newBillable = (BillableItem)billableItem.Clone();
                            newBillable.Firma = company;
                            newBillable.Id = counter;
                            items.Add(newBillable);
                            counter++;
                        }
                    );


                }
                else
                {

                    items.Add(billableItem);
                    counter++;
                   
                }
            }

            return items;
        }


        private static List<VCenterItem> GetBillableServers()
        {
            const string path = "C:\\Users\\mruch\\Desktop\\Excels\\";


            var items = new List<VCenterItem>();
            var type = typeof(VCenterItem);
            var counter = 0;


            var xlApp = new Excel.Application();
            var xlWorkbook = xlApp.Workbooks.Open(path + "VCENTER.xlsx");
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            var xlRange = xlWorksheet.UsedRange;

            var rowCount = xlRange.Rows.Count;
            var colCount = xlRange.Columns.Count;

            for (var i = 2; i < rowCount; i++)
            {
                var server = new VCenterItem { Id = counter };

                for (var j = 1; j <= colCount; j++)
                {
                    type.GetProperties()[j].SetValue(server, xlRange.Cells[i, j].Value2);

                }
               
        
                items.Add(server);
                counter++;
            }

            return items;
        }


        public static Dictionary<string, string> GetCombosDictionary()
        {
            return new Dictionary<string, string>
            {
                {"XMPL", "EXAMPLE"},
            };

        }
    }
}