using Balter.Rpc.Shared;

namespace Shinami.Net.WalletApi;

public interface IShinamiWalletClient
{
    public Task<Response<string>?> CreateWalletAsync(CreateWalletRequest request);
    public Task<Response<string>?> GetWalletAsync(GetWalletRequest request);
}

