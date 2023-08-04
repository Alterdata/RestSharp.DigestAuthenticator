namespace RestSharp.Authenticators.Digest;

internal static class RestClientOptionsExtensions
{
    internal static RestClientOptions Clone(this RestClientOptions options)
    {
        return new RestClientOptions
        {
            Proxy = options.Proxy,
            AllowMultipleDefaultParametersWithSameName = options.AllowMultipleDefaultParametersWithSameName,
            AutomaticDecompression = options.AutomaticDecompression,
            BaseHost = options.BaseHost,
            BaseUrl = options.BaseUrl,
            CachePolicy = options.CachePolicy,
            CalculateResponseStatus = options.CalculateResponseStatus,
            ClientCertificates = options.ClientCertificates,
            ConfigureMessageHandler = options.ConfigureMessageHandler,
            CookieContainer = options.CookieContainer,
            DisableCharset = options.DisableCharset,
            Encode = options.Encode,
            EncodeQuery = options.EncodeQuery,
            Encoding = options.Encoding,
            Expect100Continue = options.Expect100Continue,
            FailOnDeserializationError = options.FailOnDeserializationError,
            FollowRedirects = options.FollowRedirects,
            MaxRedirects = options.MaxRedirects,
            MaxTimeout = options.MaxTimeout,
            RemoteCertificateValidationCallback = options.RemoteCertificateValidationCallback
        };
    }
}
