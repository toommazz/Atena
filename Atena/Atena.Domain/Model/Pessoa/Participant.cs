using Atena.Domain.Core.Model;

namespace Atena.Domain.Model.Pessoa
{
    public class Participant : Entity
    {
        public Participant(Guid? id) : base(id)
        {
        }
        public ParticipantStatus ParticipantStatusId { get; set; }
        public string Name { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Username { get; set; }
        public GenderType? Gender { get; set; }
        public MaritalStatusType MaritalStatusId { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? DateFirstAccess { get; set; }
        public PersonType? PersonType { get; set; }


    }
}
