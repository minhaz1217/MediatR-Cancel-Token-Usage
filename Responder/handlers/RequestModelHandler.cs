using MediatR;
using Models;
using Responder.handlers.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responder.handlers
{
    public class RequestModelHandler : IRequestHandler<RequestModel, ResponseModel>
    {
        public async Task<ResponseModel> Handle(RequestModel request, CancellationToken cancellationToken)
        {
            var response = new ResponseModel();

            switch (request.Request.ToLower())
            {
                case "name":
                    response.Response = "Minhaz";
                    break;
                case "job":
                    response.Response = "Software Engineer";
                    break;
                case "hobby":
                    response.Response = "Learning new things";
                    break;
                default:
                    response.Response = "Hello There!!!";
                    break;
            }
            await Task.Delay(5000, cancellationToken);
            return response;
        }
    }
}
