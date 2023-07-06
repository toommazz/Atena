namespace Atena.Service.Controller
{
    public class BadRequestResponse
    {
        public bool Sucess { get { return false; } }

        public IEnumerable<string> Errors { get; }

        public BadRequestResponse(IEnumerable<string> errros)
        {
            Errors = errros;
        }
    }
}
