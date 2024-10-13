﻿using Balter.Rpc.Shared;
using Balter.Shinami.Net.KeyApi.Requests;

namespace Balter.Shinami.Net.KeyApi;

public class ShinamiKeyApi : IShinamiKeyApi
{
    private readonly IRpcClient _rpc;

    public ShinamiKeyApi(string rpcUrl)
    { 
        _rpc = new JsonRpcClient(rpcUrl);
    }

    public Task<Response<string>?> CreateSessionAsync(CreateSessionRequest request)
    {
        const string method = "shinami_key_createSession";
        return _rpc.SendRequestAsync<string>(method, request);
    }

}
