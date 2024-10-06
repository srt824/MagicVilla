using System.Net;

namespace MagicVilla_Web.Models
{
    public class APIResponse
    {
        public HttpStatusCode statusCode { get; set; }
        public bool IsSuccesfull { get; set; }
        public List<string> ErrorMessages { get; set; }
        public object Result { get; set; }
    }
}
