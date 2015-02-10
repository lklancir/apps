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

namespace Degordian_Workload_2.Services
{


    [DataContract]
    public class TablePayload
    {
        [DataMember(Name="apartments")]
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

        private async Task GetDataAsync()
        {
            //if (this._table.Count != 0) return;

            this.Table.Clear();
            var jsonObject = await DownloadSpreadsheet.GetJson();
            for (int row = 0; row < jsonObject["rows"].Count(); row++)
            {

                Table table = new Table();
                table.Day = int.Parse(jsonObject["rows"][row]["c"][0]["v"].ToString());
                table.Month = int.Parse(jsonObject["rows"][row]["c"][1]["v"].ToString());
                table.Year = int.Parse(jsonObject["rows"][row]["c"][2]["v"].ToString());
                table.People = jsonObject["rows"][row]["c"][4]["v"].ToString();

                this.Table.Add(table);
            }
            
        }
               
    }
}
