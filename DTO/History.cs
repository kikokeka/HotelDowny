using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{

    public class History
    {
        private int id;
        private string tk;
        private DateTime checkin;
        private DateTime? checkout;

        public DateTime? Checkout { get => checkout; set => checkout = value; }
        public string Tk { get => tk; set => tk = value; }
        public DateTime Checkin { get => checkin; set => checkin = value; }
        public int Id { get => id; set => id = value; }

        public History() { }
        public History(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Tk = row["tk"].ToString();
            this.Checkin = (DateTime)row["checkin"];
            var checkout = row["checkout"];
            if (checkout.ToString() != "")
                this.Checkout = (DateTime)checkout;
        } 
    }
}
