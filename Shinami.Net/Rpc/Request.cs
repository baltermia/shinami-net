using System.Text.Json.Serialization;

namespace Shinami.Net.Rpc;

public class Request(string Method, string Id)
{
    [JsonPropertyName("jsonrpc")]
    public string JsonRpc => "2.0";

    [JsonPropertyName("params")]
    public object[]? Params { get; set; }

    [JsonPropertyName("method")]
    public string Method { get; set; } = Method;

    [JsonPropertyName("id")]
    public string Id { get; set; } = Id;
}

public class Request<TParams>(string Method, string Id)
{
    [JsonPropertyName("jsonrpc")]
    public string JsonRpc => "2.0";

    [JsonInclude]
    [JsonPropertyName("params")]
    public TParams? Params { get; set; }

    [JsonPropertyName("method")]
    public string Method { get; set; } = Method;

    [JsonPropertyName("id")]
    public string Id { get; set; } = Id;
}

public interface IRequestParams
{
    public object[] Params { get; }
}
