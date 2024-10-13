﻿using Balter.Rpc.Shared;
using Balter.Shinami.Net.WalletApi.Requests;

namespace Balter.Shinami.Net.WalletApi;

public interface IShinamiWalletClient
{
    public Task<Response<string>?> CreateWalletAsync(CreateWalletRequest request);
    public Task<Response<string>?> GetWalletAsync(GetWalletRequest request);
}

