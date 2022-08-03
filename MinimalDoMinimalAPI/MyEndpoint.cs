using FastEndpoints;

namespace MinimalDoMinimalAPI
{
    public class MyEndpoint : EndpointWithoutRequest
    {
        public override void Configure()
        {
            Verbs(Http.GET);
            Routes("/endzinho");
            AllowAnonymous();
        }

        public override async Task HandleAsync(CancellationToken ct)
        {
            await SendAsync(new { message = "OláFastEndpoint" });
        }
    }
}
