// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;

namespace StableDiffusionWebUI.Client
{
    /// <summary> The Login service client. </summary>
    public partial class LoginClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal LoginRestClient RestClient { get; }

        /// <summary> Initializes a new instance of LoginClient for mocking. </summary>
        protected LoginClient()
        {
        }

        /// <summary> Initializes a new instance of LoginClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/> or <paramref name="pipeline"/> is null. </exception>
        internal LoginClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            RestClient = new LoginRestClient(clientDiagnostics, pipeline, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Login Check. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<object>> CheckLoginCheckGetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LoginClient.CheckLoginCheckGet");
            scope.Start();
            try
            {
                return await RestClient.CheckLoginCheckGetAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Login Check. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<object> CheckLoginCheckGet(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LoginClient.CheckLoginCheckGet");
            scope.Start();
            try
            {
                return RestClient.CheckLoginCheckGet(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Login. </summary>
        /// <param name="username"> The String to use. </param>
        /// <param name="password"> The String to use. </param>
        /// <param name="grantType"> The String to use. </param>
        /// <param name="scope"> The String to use. </param>
        /// <param name="clientId"> The String to use. </param>
        /// <param name="clientSecret"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<object>> LoginPostAsync(string username, string password, string grantType = null, string scope = null, string clientId = null, string clientSecret = null, CancellationToken cancellationToken = default)
        {
            using var scope0 = _clientDiagnostics.CreateScope("LoginClient.LoginPost");
            scope0.Start();
            try
            {
                return await RestClient.LoginPostAsync(username, password, grantType, scope, clientId, clientSecret, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }

        /// <summary> Login. </summary>
        /// <param name="username"> The String to use. </param>
        /// <param name="password"> The String to use. </param>
        /// <param name="grantType"> The String to use. </param>
        /// <param name="scope"> The String to use. </param>
        /// <param name="clientId"> The String to use. </param>
        /// <param name="clientSecret"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<object> LoginPost(string username, string password, string grantType = null, string scope = null, string clientId = null, string clientSecret = null, CancellationToken cancellationToken = default)
        {
            using var scope0 = _clientDiagnostics.CreateScope("LoginClient.LoginPost");
            scope0.Start();
            try
            {
                return RestClient.LoginPost(username, password, grantType, scope, clientId, clientSecret, cancellationToken);
            }
            catch (Exception e)
            {
                scope0.Failed(e);
                throw;
            }
        }
    }
}