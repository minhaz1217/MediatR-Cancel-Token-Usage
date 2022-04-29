using MediatR;
using Responder.handlers.models;

namespace Models
{
    public class RequestModel : IRequest<ResponseModel>
    {
        public string Request { get; set; } = string.Empty;
    }
}