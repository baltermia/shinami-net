using Balter.Rpc.Shared;

namespace Shinami.Net.WalletApi;

public class ShinamiWalletClient : ApiClientBase, IShinamiWalletClient
{
    public ShinamiWalletClient(string rpcUrl, string accessToken)
        : base(rpcUrl + accessToken)
    { }

    public Task<Response<string>?> CreateWalletAsync(CreateWalletRequest request)
    {
        const string method = "shinami_wal_createWallet";
        return _rpc.GetFromJsonAsync<string>(method, request);
    }

    public Task<Response<string>?> GetWalletAsync(GetWalletRequest request)
    {
        const string method = "shinami_wal_getWallet";
        return _rpc.GetFromJsonAsync<string>(method, request);
    }
}
