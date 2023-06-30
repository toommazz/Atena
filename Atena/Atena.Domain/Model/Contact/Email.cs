
using Atena.Domain.Core.Model;

namespace Atena.Domain.Model
{
    public  class Email : Entity
    {
        public Email(Guid? id):base(id) { }
        public string EmailAddress { get; set; }
        public Guid? EmailTypeId { get; set; }
        public virtual Client ClientId { get; set; }

    }

}
