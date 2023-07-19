namespace Atena.Service.ViewModels
{
    public class ClientViewModel
    {
        public ClientViewModel(Guid? id,
            string name,
            string cpf,
            string rg,
            string userName,
            Guid? genderType,
            Guid maritalStatustype,
            DateTime? birthDate,
            DateTime? dateFirstAccess,
            Guid? personType,
            DateTime included,
            DateTime updated,
            string status)
        { 
            Id = id;
            Name= name;
            CPF= cpf;
            RG= rg;
            Username= userName;
            GenderTypeId= genderType;
            MaritalStatusTypeId = maritalStatustype;
            BirthDate= birthDate;
            DateFirstAccess= dateFirstAccess;
            PersonTypeId= personType;
            Included = included;
            Updated = updated;
            Status = status;
        }
        public Guid? Id { get; set; }
        public string Name { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Username { get; set; }
        public Guid? GenderTypeId { get; set; }
        public Guid? MaritalStatusTypeId { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? DateFirstAccess { get; set; }
        public Guid? PersonTypeId { get; set; }
        public DateTime Included { get; protected set; }
        public DateTime Updated { get; protected set; }
        public string Status { get; protected set; } = "1";
    }
}
