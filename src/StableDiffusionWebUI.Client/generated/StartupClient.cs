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
    /// <summary> The Startup service client. </summary>
    public partial class StartupClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal StartupRestClient RestClient { get; }

        /// <summary> Initializes a new instance of StartupClient for mocking. </summary>
        protected StartupClient()
        {
        }

        /// <summary> Initializes a new instance of StartupClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/> or <paramref name="pipeline"/> is null. </exception>
        internal StartupClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            RestClient = new StartupRestClient(clientDiagnostics, pipeline, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Startup Events. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<object>> EventsStartupEventsGetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("StartupClient.EventsStartupEventsGet");
            scope.Start();
            try
            {
                return await RestClient.EventsStartupEventsGetAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Startup Events. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<object> EventsStartupEventsGet(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("StartupClient.EventsStartupEventsGet");
            scope.Start();
            try
            {
                return RestClient.EventsStartupEventsGet(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
