using System.ComponentModel.DataAnnotations;

namespace Kreata.Backend.Datas.Entities
{
    public class Parent
    {
        public Parent(Guid id, string sz1_firstName, string sz1_lastName, DateTime sz1_bday, string sz1_cim, string sz1_nem, Guid sz2_id, string sz2_firstName, string sz2_lastName, DateTime sz2_bday, string sz2_cim, string sz2_nem)
        {
            Id = id;
            Sz1_FirstName = sz1_firstName;
            Sz1_LastName = sz1_lastName;
            Sz1_Bday = sz1_bday;
            Sz1_Cim = sz1_cim;
            Sz1_Nem = sz1_nem;
        }

        public Parent()
        {
            Id = new Guid();
            Sz1_FirstName = string.Empty;
            Sz1_LastName = string.Empty;
            Sz1_Bday = new DateTime();
            Sz1_Cim = string.Empty;
            Sz1_Nem = string.Empty;

        }

        [Key]
        public Guid Id { get; set; }
        public string Sz1_FirstName { get; set; }
        public string Sz1_LastName { get; set; }
        public DateTime Sz1_Bday { get; set; }
        public string Sz1_Cim { get; set; }
        public string Sz1_Nem { get; set; }

        public override string ToString()
        {
            return $"Szülő: {Sz1_FirstName} {Sz1_LastName}";
        }
    }
}