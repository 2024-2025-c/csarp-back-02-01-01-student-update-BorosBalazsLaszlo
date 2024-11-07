using System.ComponentModel.DataAnnotations;

namespace Kreata.Backend.Datas.Entities
{
    public class Rendeles
    {
        public Rendeles(Guid id, string cegnev, bool torekeny, DateTime r_datum, string description)
        {
            Id = id;
            Cegnev = cegnev;
            Torekeny = torekeny;
            R_Datum = r_datum;
            Description = description;
        }

        public Rendeles()
        {
            Id = new Guid();
            Cegnev = string.Empty;
            Torekeny = false;
            R_Datum = new DateTime();
            Description = string.Empty;
        }
        [Key]
        public Guid Id { get; set; }
        public string Cegnev { get; set; }
        public bool Torekeny { get; set; }
        public DateTime R_Datum { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"Cég neve: {Cegnev} \n Rendelés dátuma: {R_Datum} \n Törékeny-e?: {Torekeny} \n Rendelési azonosító: {Id}";
        }
    }
}