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
    /// <summary> The Favicon service client. </summary>
    public partial class FaviconClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal FaviconRestClient RestClient { get; }

        /// <summary> Initializes a new instance of FaviconClient for mocking. </summary>
        protected FaviconClient()
        {
        }

        /// <summary> Initializes a new instance of FaviconClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/> or <paramref name="pipeline"/> is null. </exception>
        internal FaviconClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            RestClient = new FaviconRestClient(clientDiagnostics, pipeline, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Favicon. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<object>> FaviconIcoGetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FaviconClient.FaviconIcoGet");
            scope.Start();
            try
            {
                return await RestClient.FaviconIcoGetAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Favicon. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<object> FaviconIcoGet(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FaviconClient.FaviconIcoGet");
            scope.Start();
            try
            {
                return RestClient.FaviconIcoGet(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
