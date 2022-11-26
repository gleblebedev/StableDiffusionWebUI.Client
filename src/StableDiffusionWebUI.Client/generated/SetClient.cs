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
    /// <summary> The Set service client. </summary>
    public partial class SetClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal SetRestClient RestClient { get; }

        /// <summary> Initializes a new instance of SetClient for mocking. </summary>
        protected SetClient()
        {
        }

        /// <summary> Initializes a new instance of SetClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/> or <paramref name="pipeline"/> is null. </exception>
        internal SetClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            RestClient = new SetRestClient(clientDiagnostics, pipeline, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Set Config. </summary>
        /// <param name="body"> The AnyObject to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<object>> ConfigSdapiV1OptionsPostAsync(object body, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SetClient.ConfigSdapiV1OptionsPost");
            scope.Start();
            try
            {
                return await RestClient.ConfigSdapiV1OptionsPostAsync(body, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Set Config. </summary>
        /// <param name="body"> The AnyObject to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<object> ConfigSdapiV1OptionsPost(object body, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SetClient.ConfigSdapiV1OptionsPost");
            scope.Start();
            try
            {
                return RestClient.ConfigSdapiV1OptionsPost(body, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
