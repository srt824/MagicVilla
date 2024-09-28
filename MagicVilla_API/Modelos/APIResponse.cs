using System.Net;

namespace MagicVilla_API.Modelos
{
    public class APIResponse
    {
        public HttpStatusCode statusCode { get; set; }
        public bool IsSuccesfull { get; set; }
        public List<string> ErrorMessages { get; set; }
        public object Result { get; set; }
    }
}
