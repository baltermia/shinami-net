using Balter.Rpc.Shared;

namespace Shinami.Net.KeyApi;

public interface IShinamiKeyApi
{
    public Task<Response<string>?> CreateSessionAsync(CreateSessionRequest request);
}
