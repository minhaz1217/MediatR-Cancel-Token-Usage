using MediatR;
using Models;

namespace Requester
{
    public class RequesterService
    {
        private readonly IMediator _medaitor;
        static CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
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
            cancellationTokenSource = new CancellationTokenSource(); ;
            var response = await _medaitor.Send(request, cancellationTokenSource.Token);
            return response.Response;
        }

        public bool CancelOperation()
        {
            cancellationTokenSource.Cancel();
            return cancellationTokenSource.IsCancellationRequested;
        }
    }
}