using Balter.Rpc.Shared;

namespace Shinami.Net.KeyApi;

public class ShinamiKeyApi : ApiClientBase, IShinamiKeyApi
{
    public ShinamiKeyApi(string rpcUrl, string accessToken)
        : base(rpcUrl + accessToken)
    { }

    public Task<Response<string>?> CreateSessionAsync(CreateSessionRequest request)
    {
        const string method = "shinami_key_createSession";
        return _rpc.GetFromJsonAsync<string>(method, request);
    }

}
