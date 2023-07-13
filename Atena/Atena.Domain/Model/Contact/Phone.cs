
using Atena.Domain.Core.Model;

namespace Atena.Domain.Model
{
    public class Phone : Entity
    {
        public Phone(Guid? id) : base(id) { }
        public Guid? PhoneTypeId { get; set; }
        public string Ddd { get; set; }
        public string Number { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public virtual Client ClientId { get; set; }
    }
 
}
