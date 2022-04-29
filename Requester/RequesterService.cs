using MediatR;
using Models;

namespace Requester
{
    public class RequesterService
    {
        private readonly IMediator _medaitor; 

        public RequesterService(IMediator medaitor)
        {
            _medaitor = medaitor;
        }

        public async Task<string> GetValueAsync(string key)
        {
            var request = new RequestModel
            {
                Request = key
            };
            var response = await _medaitor.Send(request);
            return response.Response;
        }
    }
}