using System.Net.Http.Json;
using System.Numerics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Shinami.Net.Rpc;

public interface IJsonRpcClient 
{
    public Task<Response<TResponse>?> GetFromJsonAsync<TResponse>(string method, IRequestParams data);
}

public class JsonRpcClient : IJsonRpcClient
{
    private readonly HttpClient _client;

    private static readonly JsonSerializerOptions s_serializerOptions = new()
    {
        Converters = { new BigIntegerConverter() }
    };

    public JsonRpcClient(string rpcUrl)
    {
        _client = new()
        {
            BaseAddress = new Uri(rpcUrl),
        };
    }

    public async Task<Response<TResponse>?> GetFromJsonAsync<TResponse>(string method, IRequestParams data)
    {
        string guid = Guid.NewGuid().ToString();
            
        Request request = new(method, guid)
        {
            Params = data.Params,
        };

        HttpResponseMessage httpResponse = await _client.PostAsJsonAsync(default(string?), request);

        Response<TResponse>? response = await httpResponse.Content.ReadFromJsonAsync<Response<TResponse>>(s_serializerOptions);

        return response;
    }
}

public class BigIntegerConverter : JsonConverter<BigInteger>
{
    public override BigInteger Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.String)
        {
            string? stringValue = reader.GetString();
            if (BigInteger.TryParse(stringValue, out var value))
                return value;
        }

        throw new JsonException($"Unable to convert \"{reader.GetString()}\" to {typeToConvert}.");
    }

    public override void Write(Utf8JsonWriter writer, BigInteger value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString());
    }
}

