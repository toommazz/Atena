using Atena.Domain.Model.Pessoa;

namespace Atena.Domain.Model.Contato
{
    public class Phone : Entity
    {
        public Phone(Guid? id) : base(id)
        {
        }
        public PhoneType PhoneType { get; set; }
        public string Ddd { get; set; }
        public string Number { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public virtual Participant ParticipantId { get; set; }
    }
 
}
