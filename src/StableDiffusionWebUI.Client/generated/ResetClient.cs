// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using StableDiffusionWebUI.Client.Models;

namespace StableDiffusionWebUI.Client
{
    /// <summary> The Reset service client. </summary>
    public partial class ResetClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal ResetRestClient RestClient { get; }

        /// <summary> Initializes a new instance of ResetClient for mocking. </summary>
        protected ResetClient()
        {
        }

        /// <summary> Initializes a new instance of ResetClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/> or <paramref name="pipeline"/> is null. </exception>
        internal ResetClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            RestClient = new ResetRestClient(clientDiagnostics, pipeline, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Reset Iterator. </summary>
        /// <param name="body"> The ResetBody to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<object>> IteratorResetPostAsync(ResetBody body, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ResetClient.IteratorResetPost");
            scope.Start();
            try
            {
                return await RestClient.IteratorResetPostAsync(body, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Reset Iterator. </summary>
        /// <param name="body"> The ResetBody to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<object> IteratorResetPost(ResetBody body, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ResetClient.IteratorResetPost");
            scope.Start();
            try
            {
                return RestClient.IteratorResetPost(body, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
