using System.ComponentModel.DataAnnotations;

namespace Kreata.Backend.Datas.Entities
{
    public class Dolgozo
    {
        public Dolgozo(Guid d_id, string d_firstname, string d_lastname, DateTime d_bday, bool osztalyvezeto)
        {
            D_Id = d_id;
            D_Firstname = d_firstname;
            D_Lastname = d_lastname;
            D_Bday = d_bday;
            Osztalyvezeto = osztalyvezeto;
        }

        public Dolgozo()
        {
            D_Id = new Guid();
            D_Firstname = string.Empty;
            D_Lastname = string.Empty;
            D_Bday = new DateTime();
            Osztalyvezeto = false;
        }
        [Key]
        public Guid D_Id { get; set; }
        public string D_Firstname { get; set; }
        public string D_Lastname { get; set; }
        public DateTime D_Bday { get; set; }
        public bool Osztalyvezeto { get; set; }

        public override string ToString()
        {
            return $"Dolgozo neve: {D_Firstname} {D_Lastname} \n Szuletesi ideje: {D_Bday}";
        }
    }
}
