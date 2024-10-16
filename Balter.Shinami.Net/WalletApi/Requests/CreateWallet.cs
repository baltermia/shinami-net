﻿using Balter.Rpc.Shared;

namespace Balter.Shinami.Net.WalletApi.Requests;

public class CreateWalletRequest : IRequestParams
{
    public required string WalletId { get; set; }
    public required string SessionToken { get; set; }

    public object[] Params => [WalletId, SessionToken];
}

// no response needed, the rpc directly returns the address

