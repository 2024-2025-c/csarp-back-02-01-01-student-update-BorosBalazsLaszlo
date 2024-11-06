namespace Kreata.Backend.Datas.Entities
{
    public class Parents
    {
        public Parents(Guid sz1_id, string sz1_firstName, string sz1_lastName, DateTime sz1_bday, string sz1_cim, string sz1_nem, Guid sz2_id, string sz2_firstName, string sz2_lastName, DateTime sz2_bday, string sz2_cim, string sz2_nem)
        {
            Sz1_Id = sz1_id;
            Sz1_FirstName = sz1_firstName;
            Sz1_LastName = sz1_lastName;
            Sz1_Bday = sz1_bday;
            Sz1_Cim = sz1_cim;
            Sz1_Nem = sz1_nem;

            Sz2_Id = sz2_id;
            Sz2_FirstName = sz2_firstName;
            Sz2_LastName = sz2_lastName;
            Sz2_Bday = sz2_bday;
            Sz2_Cim = sz2_cim;
            Sz2_Nem = sz2_nem;
        }

        public Parents()
        {
            Sz1_Id = new Guid();
            Sz1_FirstName = string.Empty;
            Sz1_LastName = string.Empty;
            Sz1_Bday = new DateTime();
            Sz1_Cim = string.Empty;
            Sz1_Nem = string.Empty;

            Sz2_Id = new Guid();
            Sz2_FirstName = string.Empty;
            Sz2_LastName = string.Empty;
            Sz2_Bday = new DateTime();
            Sz2_Cim = string.Empty;
            Sz2_Nem = string.Empty;
        }

        public Guid Sz1_Id { get; set; }
        public string Sz1_FirstName { get; set; }
        public string Sz1_LastName { get; set; }
        public DateTime Sz1_Bday { get; set; }
        public string Sz1_Cim { get; set; }
        public string Sz1_Nem { get; set; }
        public Guid Sz2_Id { get; set; }
        public string Sz2_FirstName { get; set; }
        public string Sz2_LastName { get; set; }
        public DateTime Sz2_Bday { get; set; }
        public string Sz2_Cim { get; set; }
        public string Sz2_Nem { get; set; }

        public override string ToString()
        {
            return $"Első szülő: {Sz1_FirstName} {Sz1_LastName} \n Második szülő: {Sz2_FirstName} {Sz2_LastName}";
        }
    }
}