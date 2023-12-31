/*
 * Openfort API
 *
 * Complete Openfort API references and guides can be found at: https://openfort.xyz/docs
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: founders@openfort.xyz
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mime;
using Openfort.SDK.Client;
using Openfort.SDK.Model;

namespace Openfort.SDK.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IGoogleAuthenticationApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get the google oauth signin url.
        /// </summary>
        /// <exception cref="Openfort.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>GetSigninUrlResponse</returns>
        GetSigninUrlResponse GetSigninUrl();

        /// <summary>
        /// Get the google oauth signin url.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Openfort.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of GetSigninUrlResponse</returns>
        ApiResponse<GetSigninUrlResponse> GetSigninUrlWithHttpInfo();
        /// <summary>
        /// Get the google oauth token.
        /// </summary>
        /// <exception cref="Openfort.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="key">Specifies the oauth key.</param>
        /// <returns>AuthResponse</returns>
        AuthResponse GetToken(string key);

        /// <summary>
        /// Get the google oauth token.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Openfort.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="key">Specifies the oauth key.</param>
        /// <returns>ApiResponse of AuthResponse</returns>
        ApiResponse<AuthResponse> GetTokenWithHttpInfo(string key);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IGoogleAuthenticationApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get the google oauth signin url.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Openfort.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of GetSigninUrlResponse</returns>
        System.Threading.Tasks.Task<GetSigninUrlResponse> GetSigninUrlAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get the google oauth signin url.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Openfort.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (GetSigninUrlResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<GetSigninUrlResponse>> GetSigninUrlWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get the google oauth token.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Openfort.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="key">Specifies the oauth key.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AuthResponse</returns>
        System.Threading.Tasks.Task<AuthResponse> GetTokenAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get the google oauth token.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Openfort.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="key">Specifies the oauth key.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AuthResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AuthResponse>> GetTokenWithHttpInfoAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IGoogleAuthenticationApi : IGoogleAuthenticationApiSync, IGoogleAuthenticationApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class GoogleAuthenticationApi : IDisposable, IGoogleAuthenticationApi
    {
        private Openfort.SDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleAuthenticationApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public GoogleAuthenticationApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleAuthenticationApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public GoogleAuthenticationApi(string basePath)
        {
            this.Configuration = Openfort.SDK.Client.Configuration.MergeConfigurations(
                Openfort.SDK.Client.GlobalConfiguration.Instance,
                new Openfort.SDK.Client.Configuration { BasePath = basePath }
            );
            this.ApiClient = new Openfort.SDK.Client.ApiClient(this.Configuration.BasePath);
            this.Client =  this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            this.ExceptionFactory = Openfort.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleAuthenticationApi"/> class using Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public GoogleAuthenticationApi(Openfort.SDK.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Openfort.SDK.Client.Configuration.MergeConfigurations(
                Openfort.SDK.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.ApiClient = new Openfort.SDK.Client.ApiClient(this.Configuration.BasePath);
            this.Client = this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            ExceptionFactory = Openfort.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleAuthenticationApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public GoogleAuthenticationApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleAuthenticationApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public GoogleAuthenticationApi(HttpClient client, string basePath, HttpClientHandler handler = null)
        {
            if (client == null) throw new ArgumentNullException("client");

            this.Configuration = Openfort.SDK.Client.Configuration.MergeConfigurations(
                Openfort.SDK.Client.GlobalConfiguration.Instance,
                new Openfort.SDK.Client.Configuration { BasePath = basePath }
            );
            this.ApiClient = new Openfort.SDK.Client.ApiClient(client, this.Configuration.BasePath, handler);
            this.Client =  this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            this.ExceptionFactory = Openfort.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleAuthenticationApi"/> class using Configuration object.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public GoogleAuthenticationApi(HttpClient client, Openfort.SDK.Client.Configuration configuration, HttpClientHandler handler = null)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");
            if (client == null) throw new ArgumentNullException("client");

            this.Configuration = Openfort.SDK.Client.Configuration.MergeConfigurations(
                Openfort.SDK.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.ApiClient = new Openfort.SDK.Client.ApiClient(client, this.Configuration.BasePath, handler);
            this.Client = this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            ExceptionFactory = Openfort.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleAuthenticationApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public GoogleAuthenticationApi(Openfort.SDK.Client.ISynchronousClient client, Openfort.SDK.Client.IAsynchronousClient asyncClient, Openfort.SDK.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Openfort.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Disposes resources if they were created by us
        /// </summary>
        public void Dispose()
        {
            this.ApiClient?.Dispose();
        }

        /// <summary>
        /// Holds the ApiClient if created
        /// </summary>
        public Openfort.SDK.Client.ApiClient ApiClient { get; set; } = null;

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Openfort.SDK.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Openfort.SDK.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Openfort.SDK.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Openfort.SDK.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Get the google oauth signin url. 
        /// </summary>
        /// <exception cref="Openfort.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>GetSigninUrlResponse</returns>
        public GetSigninUrlResponse GetSigninUrl()
        {
            Openfort.SDK.Client.ApiResponse<GetSigninUrlResponse> localVarResponse = GetSigninUrlWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the google oauth signin url. 
        /// </summary>
        /// <exception cref="Openfort.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of GetSigninUrlResponse</returns>
        public Openfort.SDK.Client.ApiResponse<GetSigninUrlResponse> GetSigninUrlWithHttpInfo()
        {
            Openfort.SDK.Client.RequestOptions localVarRequestOptions = new Openfort.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Openfort.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Openfort.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (pk) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<GetSigninUrlResponse>("/iam/v1/oauth/google/signin_url", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetSigninUrl", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the google oauth signin url. 
        /// </summary>
        /// <exception cref="Openfort.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of GetSigninUrlResponse</returns>
        public async System.Threading.Tasks.Task<GetSigninUrlResponse> GetSigninUrlAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Openfort.SDK.Client.ApiResponse<GetSigninUrlResponse> localVarResponse = await GetSigninUrlWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the google oauth signin url. 
        /// </summary>
        /// <exception cref="Openfort.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (GetSigninUrlResponse)</returns>
        public async System.Threading.Tasks.Task<Openfort.SDK.Client.ApiResponse<GetSigninUrlResponse>> GetSigninUrlWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Openfort.SDK.Client.RequestOptions localVarRequestOptions = new Openfort.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Openfort.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Openfort.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (pk) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<GetSigninUrlResponse>("/iam/v1/oauth/google/signin_url", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetSigninUrl", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the google oauth token. 
        /// </summary>
        /// <exception cref="Openfort.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="key">Specifies the oauth key.</param>
        /// <returns>AuthResponse</returns>
        public AuthResponse GetToken(string key)
        {
            Openfort.SDK.Client.ApiResponse<AuthResponse> localVarResponse = GetTokenWithHttpInfo(key);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the google oauth token. 
        /// </summary>
        /// <exception cref="Openfort.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="key">Specifies the oauth key.</param>
        /// <returns>ApiResponse of AuthResponse</returns>
        public Openfort.SDK.Client.ApiResponse<AuthResponse> GetTokenWithHttpInfo(string key)
        {
            // verify the required parameter 'key' is set
            if (key == null)
                throw new Openfort.SDK.Client.ApiException(400, "Missing required parameter 'key' when calling GoogleAuthenticationApi->GetToken");

            Openfort.SDK.Client.RequestOptions localVarRequestOptions = new Openfort.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Openfort.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Openfort.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(Openfort.SDK.Client.ClientUtils.ParameterToMultiMap("", "key", key));

            // authentication (pk) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<AuthResponse>("/iam/v1/oauth/google/token", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetToken", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the google oauth token. 
        /// </summary>
        /// <exception cref="Openfort.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="key">Specifies the oauth key.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AuthResponse</returns>
        public async System.Threading.Tasks.Task<AuthResponse> GetTokenAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Openfort.SDK.Client.ApiResponse<AuthResponse> localVarResponse = await GetTokenWithHttpInfoAsync(key, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the google oauth token. 
        /// </summary>
        /// <exception cref="Openfort.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="key">Specifies the oauth key.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AuthResponse)</returns>
        public async System.Threading.Tasks.Task<Openfort.SDK.Client.ApiResponse<AuthResponse>> GetTokenWithHttpInfoAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'key' is set
            if (key == null)
                throw new Openfort.SDK.Client.ApiException(400, "Missing required parameter 'key' when calling GoogleAuthenticationApi->GetToken");


            Openfort.SDK.Client.RequestOptions localVarRequestOptions = new Openfort.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Openfort.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Openfort.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(Openfort.SDK.Client.ClientUtils.ParameterToMultiMap("", "key", key));

            // authentication (pk) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<AuthResponse>("/iam/v1/oauth/google/token", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetToken", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
