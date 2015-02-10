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
        public int Day { get; set; }
        [DataMember(Name="month")]
        public int Month { get; set; }
        [DataMember(Name="year")]
        public int Year { get; set; }
        [DataMember(Name="People")]
        public string People { get; set; }
    }
}
