using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Degordian_Workload_2.Services.Model
{
    [DataContract]
    public class Table
    {
        [DataMember(Name="id")]
        public string Id { get; set; }
        [DataMember(Name="day")]
        public string Day { get; set; }
        [DataMember(Name="month")]
        public string Month { get; set; }
        [DataMember(Name="year")]
        public string Year { get; set; }
        [DataMember(Name="people")]
        public string People { get; set; }
        [DataMember(Name = "hours")]
        public string Hours { get; set; }
        [DataMember(Name = "department")]
        public string Department { get; set; }
        [DataMember(Name = "declient")]
        public string Klijent { get; set; }
        [DataMember(Name = "project")]
        public string Project { get; set; }
        [DataMember(Name = "detask")]
        public string DeTask { get; set; }
        [DataMember(Name = "accountManager")]
        public string AccountManager { get; set; }
        [DataMember(Name = "projectManager")]
        public string ProjectManager { get; set; }
        [DataMember(Name = "comment")]
        public string Comment { get; set; } 
    }
}
