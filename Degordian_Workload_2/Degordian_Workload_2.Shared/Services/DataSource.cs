using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Degordian_Workload_2.Services.Model;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Linq;
using System.IO;
using Windows.Data.Json;
using Windows.UI.Popups;
using System.Windows;


namespace Degordian_Workload_2.Services
{


    [DataContract]
    public class TablePayload
    {
        [DataMember(Name="tables")]
        public List<Table> Table { get; private set; }
    }
    public sealed class DataSource
    {
        private static DataSource _dataSource = new DataSource();

        private ObservableCollection<Table> _table = new ObservableCollection<Table>();

        public ObservableCollection<Table> Table
        {
            get { return this._table; }
        }

        public static async Task<IEnumerable<Table>> GetTablesAsync()
        {
            await _dataSource.GetDataAsync();
            return _dataSource.Table;
        }

        public static async Task<Table> GetTableAsync(string id)
        {
            await _dataSource.GetDataAsync();
            var matches = _dataSource.Table.Where((table) => table.Id.Equals(id));
            if (matches.Count() == 1) return matches.First();
            return null;
        }
        //TODO

        private bool IsJsonNull(JsonObject jObject)
        {
            if (jObject == null)
            {
                return false;

            }

            return true;
        }

        private async Task GetDataAsync()
        {
            //if (this._table.Count != 0) return;

            this.Table.Clear();
            var jsonObject = await DownloadSpreadsheet.GetJson();
            for (int row = 0; row < jsonObject["rows"].Count(); row++)
            {
                try
                {
                    Table table = new Table();

                    table.Day = jsonObject["rows"][row]["c"][0]["f"].ToString();

                    table.Month = jsonObject["rows"][row]["c"][1]["v"].ToString();
                    table.Year = jsonObject["rows"][row]["c"][2]["v"].ToString();
                    table.People = jsonObject["rows"][row]["c"][4]["v"].ToString();
                    table.Hours = jsonObject["rows"][row]["c"][5]["v"].ToString();
                    table.Department = jsonObject["rows"][row]["c"][8]["v"].ToString();
                    table.Klijent = jsonObject["rows"][row]["c"][9]["v"].ToString();
                    table.Project = jsonObject["rows"][row]["c"][10]["v"].ToString();
                    table.DeTask = jsonObject["rows"][row]["c"][11]["v"].ToString();
                    table.AccountManager = jsonObject["rows"][row]["c"][12]["v"].ToString();
                    table.ProjectManager = jsonObject["rows"][row]["c"][13]["v"].ToString();
                    if (!jsonObject["rows"][row]["c"][16].HasValues)
                    {
                        table.Comment = "prazni string";
                    }
                    else
                    {
                        table.Comment = jsonObject["rows"][row]["c"][16]["v"].ToString();
                    }
                    

                    this.Table.Add(table);

                }
                catch (Exception ex)
                {
                    
                }

                
            }
            
        }
               
    }
}
