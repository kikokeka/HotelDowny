using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    
    public class Account
    {
        public static Account logged;
        private string tk, mk;
        private int cap;
        public int Cap { get => cap; set => cap = value; }
        public string Tk { get => tk; set => tk = value; }
        public string Mk { get => mk; set => mk = value; }

        public Account() { }
        public Account(DataRow row)
        {
            this.Tk = row["tk"].ToString().Trim();
            this.Mk = row["mk"].ToString().Trim();
            this.Cap = (int)row["cap"];
        }
    }
}
