using Balter.Rpc.Shared;
using Balter.Shinami.Net.WalletApi.Requests;

namespace Balter.Shinami.Net.WalletApi;

public class ShinamiWalletClient : IShinamiWalletClient
{
    private readonly IRpcClient _rpc;

    public ShinamiWalletClient(string rpcUrl)
    {
        _rpc = new JsonRpcClient(rpcUrl);
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

    public Task<Response<ExecuteGaslessTransactionBlockResponse>?> ExecuteGaslessTransactionBlockAsync(ExecuteGaslessTransactionBlockRequest request)
    {
        const string method = "shinami_wal_executeGaslessTransactionBlock";
        return _rpc.SendRequestAsync<ExecuteGaslessTransactionBlockResponse>(method, request);
    }
}
