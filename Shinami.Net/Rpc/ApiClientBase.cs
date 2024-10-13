namespace Shinami.Net.Rpc;

public abstract class ApiClientBase
{
    protected readonly JsonRpcClient _rpc;

    public ApiClientBase(string rpcUrl, string accessToken)
    {
        _rpc = new JsonRpcClient(rpcUrl + accessToken);
    }
}
