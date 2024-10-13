using Balter.Rpc.Shared;

namespace Balter.Shinami.Net.KeyApi;

public class CreateSessionRequest : IRequestParams
{
    public required string Secret { get; set; }

    public object[] Params => [Secret];
}

// no response, the rpc directly returns the session id as string
