using Balter.Rpc.Shared;
using Balter.Shinami.Net.KeyApi.Requests;

namespace Balter.Shinami.Net.KeyApi;

public interface IShinamiKeyApi
{
    public Task<Response<string>?> CreateSessionAsync(CreateSessionRequest request);
}
