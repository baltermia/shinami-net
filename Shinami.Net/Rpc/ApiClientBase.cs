namespace Shinami.Net.Rpc;

public abstract class ApiClientBase : IDisposable
{
    protected readonly JsonRpcClient _rpc;

    public ApiClientBase(string rpcUrl, string accessToken)
    {
        _rpc = new JsonRpcClient(rpcUrl + accessToken);
    }

    public void Dispose()
    {
        _rpc.Dispose();
    }
}
