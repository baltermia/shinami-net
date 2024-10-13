using Shinami.Net.Rpc;

namespace Shinami.Net.WalletApi;

public class CreateWalletRequest : IRequestParams
{
    public required string WalletId { get; set; }
    public required string SessionToken { get; set; }

    public object[] Params => [WalletId, SessionToken];
}

// no response needed, the rpc directly returns the address

