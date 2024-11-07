using System.ComponentModel.DataAnnotations;

namespace Kreata.Backend.Datas.Entities
{
    public class Admin
    {
        public Admin(Guid id, string a_firstname, string a_lastname, DateTime a_bday, bool rendszergazda)
        {
            Id = id;
            A_Firstname = a_firstname;
            A_Lastname = a_lastname;
            A_Bday = a_bday;
            Rendszergazda = rendszergazda;
        }

        public Admin()
        {
            Id = new Guid();
            A_Firstname = string.Empty;
            A_Lastname = string.Empty;
            A_Bday = new DateTime();
            Rendszergazda = false;
        }
        [Key]
        public Guid Id { get; set; }
        public string A_Firstname { get; set; }
        public string A_Lastname { get; set; }
        public DateTime A_Bday { get; set; }
        public bool Rendszergazda { get; set; }

        public override string ToString()
        {
            return $"Adminisztrátor neve: {A_Firstname} {A_Lastname} \n Szuletesi ideje: {A_Bday}";
        }
    }
}
