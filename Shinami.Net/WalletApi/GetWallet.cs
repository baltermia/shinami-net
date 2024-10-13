using Shinami.Net.Rpc;

namespace Shinami.Net.WalletApi;

public class GetWalletRequest : IRequestParams
{
    public required string WalletId { get; set; }

    public object[] Params => [WalletId];
}
