using Balter.Rpc.Shared;

namespace Balter.Shinami.Net.WalletApi;

public class ShinamiWalletClient : IShinamiWalletClient
{
    private readonly IRpcClient _rpc;

    public ShinamiWalletClient(string rpcUrl, string accessToken)
    {
        _rpc = new JsonRpcClient(rpcUrl + accessToken);
    }

    public Task<Response<string>?> CreateWalletAsync(CreateWalletRequest request)
    {
        const string method = "shinami_wal_createWallet";
        return _rpc.SendRequestAsync<string>(method, request);
    }

    public Task<Response<string>?> GetWalletAsync(GetWalletRequest request)
    {
        const string method = "shinami_wal_getWallet";
        return _rpc.SendRequestAsync<string>(method, request);
    }
}
