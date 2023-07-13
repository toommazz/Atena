namespace Atena.Service.ViewModels
{
    public class CompanyViewModel
    {
        public CompanyViewModel(Guid? id, 
            string companyName,
            string corporateName,
            string cnpj,
            DateTime included,
            DateTime updated,
            string status)
        {
            Id = id;
            CompanyName = companyName;
            CorporateName = companyName;
            CNPJ = cnpj;
            Included = included;
            Updated = updated;
            Status = status;
        }

        public Guid? Id { get; set; }
        public string CompanyName { get; set; }
        public string CorporateName { get; set; }
        public string CNPJ { get; set; }
        public DateTime Included { get; protected set; }
        public DateTime Updated { get; protected set; }
        public string Status { get; protected set; } = "1";
    }
}
