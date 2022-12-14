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
    /// <summary> The Extras service client. </summary>
    public partial class ExtrasClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal ExtrasRestClient RestClient { get; }

        /// <summary> Initializes a new instance of ExtrasClient for mocking. </summary>
        protected ExtrasClient()
        {
        }

        /// <summary> Initializes a new instance of ExtrasClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/> or <paramref name="pipeline"/> is null. </exception>
        internal ExtrasClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            RestClient = new ExtrasRestClient(clientDiagnostics, pipeline, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Extras Single Image Api. </summary>
        /// <param name="body"> The ExtrasSingleImageRequest to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<object>> SingleImageApiSdapiV1ExtraSingleImagePostAsync(ExtrasSingleImageRequest body, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExtrasClient.SingleImageApiSdapiV1ExtraSingleImagePost");
            scope.Start();
            try
            {
                return await RestClient.SingleImageApiSdapiV1ExtraSingleImagePostAsync(body, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Extras Single Image Api. </summary>
        /// <param name="body"> The ExtrasSingleImageRequest to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<object> SingleImageApiSdapiV1ExtraSingleImagePost(ExtrasSingleImageRequest body, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExtrasClient.SingleImageApiSdapiV1ExtraSingleImagePost");
            scope.Start();
            try
            {
                return RestClient.SingleImageApiSdapiV1ExtraSingleImagePost(body, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Extras Batch Images Api. </summary>
        /// <param name="body"> The ExtrasBatchImagesRequest to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<object>> BatchImagesApiSdapiV1ExtraBatchImagesPostAsync(ExtrasBatchImagesRequest body, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExtrasClient.BatchImagesApiSdapiV1ExtraBatchImagesPost");
            scope.Start();
            try
            {
                return await RestClient.BatchImagesApiSdapiV1ExtraBatchImagesPostAsync(body, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Extras Batch Images Api. </summary>
        /// <param name="body"> The ExtrasBatchImagesRequest to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<object> BatchImagesApiSdapiV1ExtraBatchImagesPost(ExtrasBatchImagesRequest body, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExtrasClient.BatchImagesApiSdapiV1ExtraBatchImagesPost");
            scope.Start();
            try
            {
                return RestClient.BatchImagesApiSdapiV1ExtraBatchImagesPost(body, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
