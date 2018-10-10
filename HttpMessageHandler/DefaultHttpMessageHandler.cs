using System.Diagnostics;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace dotnet_typed_httpclient.HttpMessageHandler
{
    public class DefaultHttpMessageHandler : DelegatingHandler
    {
        protected async override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var stopwatch = Stopwatch.StartNew();

            System.Console.WriteLine($"Sending HTTP request {request.Method} {request.RequestUri}");
            var response = await base.SendAsync(request, cancellationToken);
            System.Console.WriteLine($"Received HTTP response after {stopwatch.ElapsedMilliseconds}ms - {response.StatusCode}");

            return response;
        }
    }
}