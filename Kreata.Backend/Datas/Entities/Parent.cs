using System.ComponentModel.DataAnnotations;

namespace Kreata.Backend.Datas.Entities
{
    public class Parent
    {
        public Parent(Guid id, string sz_firstName, string sz_lastName, DateTime sz_bday, string sz_cim, string sz_nem, Guid sz2_id, string sz2_firstName, string sz2_lastName, DateTime sz2_bday, string sz2_cim, string sz2_nem)
        {
            Id = id;
            sz_FirstName = sz_firstName;
            sz_LastName = sz_lastName;
            sz_Bday = sz_bday;
            sz_Cim = sz_cim;
            sz_Nem = sz_nem;
        }

        public Parent()
        {
            Id = new Guid();
            sz_FirstName = string.Empty;
            sz_LastName = string.Empty;
            sz_Bday = new DateTime();
            sz_Cim = string.Empty;
            sz_Nem = string.Empty;

        }

        [Key]
        public Guid Id { get; set; }
        public string sz_FirstName { get; set; }
        public string sz_LastName { get; set; }
        public DateTime sz_Bday { get; set; }
        public string sz_Cim { get; set; }
        public string sz_Nem { get; set; }

        public override string ToString()
        {
            return $"Szülő: {sz_FirstName} {sz_LastName}";
        }
    }
}