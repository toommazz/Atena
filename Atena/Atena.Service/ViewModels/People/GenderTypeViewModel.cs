namespace Atena.Service.ViewModels
{
    public class GenderTypeViewModel
    {
        public GenderTypeViewModel(Guid? id, string name, string description, DateTime included, DateTime updated, string status)
        {
            Id = id;
            Name = name;
            Description = description;
            Included = included;
            Updated = updated;
            Status = status;
        }

        public Guid? Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Included { get; protected set; }
        public DateTime Updated { get; protected set; }
        public string Status { get; protected set; } = "1";
    }
}
