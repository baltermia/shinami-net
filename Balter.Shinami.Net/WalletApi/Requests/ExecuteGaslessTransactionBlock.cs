using Balter.Rpc.Shared;

namespace Balter.Shinami.Net.WalletApi.Requests;

public class ExecuteGaslessTransactionBlockRequest : IRequestParams
{
    public required string WalletId { get; set; }
    public required string SessionToken { get; set; }
    public required string TxBytes { get; set; }

    public object[] Params => [
        WalletId, 
        SessionToken, 
        TxBytes,
    ];
}

public class ExecuteGaslessTransactionBlockResponse
{
    public string Digest { get; set; } = string.Empty;

    public bool ConfirmedLocalExecution { get; set; }
}
