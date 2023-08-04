using Atena.Domain.Model;

namespace Atena.Service.ViewModels
{
    public class PeopleViewModel
    {
        public Guid? Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public Guid GenderTypeId { get; set; }

        public GenderType GenderType { get; set; }
        public Guid PersonTypeId { get; set; }
        public Guid MaritalStatusTypeId { get; set; }
        public DateTime Included { get; set; }
        public DateTime Updated { get; set; }
        public string Status { get; set; } = "1";
    }
}
