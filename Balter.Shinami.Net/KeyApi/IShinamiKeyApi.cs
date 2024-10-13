using Balter.Rpc.Shared;

namespace Balter.Shinami.Net.KeyApi;

public interface IShinamiKeyApi
{
    public Task<Response<string>?> CreateSessionAsync(CreateSessionRequest request);
}
