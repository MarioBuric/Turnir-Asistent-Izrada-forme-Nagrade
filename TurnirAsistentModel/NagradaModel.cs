using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnirAsistentModel
{
    public class NagradaModel
    {
        /// <summary>
        /// mjesto koja je ekipa osvojila
        /// </summary>
        public int OsvojenoMjesto { get; set; }
        /// <summary>
        /// naziv mjesta u kojoj je ekipa sudjelovala
        /// </summary>
        public string NazivMjesta { get; set; }
        /// <summary>
        /// Kolicina nagrade koju ce ekipa dobiti
        /// </summary>
        public decimal IznosNagrade { get; set; }
        /// <summary>
        /// postotak nagrade koju ce ekipa osvojiti
        /// </summary>
        public double PostotakNagrade { get; set; }
        public int Id { get; internal set; }
    }
}
