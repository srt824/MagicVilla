using System.Net;

namespace MagicVilla_API.Modelos
{
    public class APIResponse
    {
        public APIResponse()
        {
            ErrorMessages = new List<string>();
        }
        public HttpStatusCode statusCode { get; set; }
        public bool IsSuccesfull { get; set; } = true;
        public List<string> ErrorMessages { get; set; }
        public object Result { get; set; }

        public int TotalPages { get; set; }
    }
}
