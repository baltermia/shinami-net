using Balter.Rpc.Shared;

namespace Balter.Shinami.Net.WalletApi.Requests;

public class GetWalletRequest : IRequestParams
{
    public required string WalletId { get; set; }

    public object[] Params => [WalletId];
}
