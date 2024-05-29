using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Setup
    {
        public string name {  get; set; }
        public string location { get; set; }
        public string sdt {  get; set; }
        public Setup() { }
        public Setup(DataRow row)
        {
            this.name = (string)row["name"];
            this.location = (string)row["location"];
            this.sdt = (string)row["sdt"];
        }
    }
}
