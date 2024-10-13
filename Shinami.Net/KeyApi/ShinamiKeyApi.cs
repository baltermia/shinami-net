using Shinami.Net.Rpc;

namespace Shinami.Net.KeyApi;

public class ShinamiKeyApi : IShinamiKeyApi
{
    private readonly JsonRpcClient _rpc;

    public ShinamiKeyApi(string rpcUrl, string accessToken)
    {
        _rpc = new JsonRpcClient(rpcUrl + accessToken);
    }

    public Task<Response<string>?> CreateSessionAsync(CreateSessionRequest request)
    {
        const string method = "shinami_key_createSession";
        return _rpc.GetFromJsonAsync<string>(method, request);
    }

}
