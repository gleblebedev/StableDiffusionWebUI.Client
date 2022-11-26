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
    /// <summary> The Text2Imgapi service client. </summary>
    public partial class Text2ImgapiClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal Text2ImgapiRestClient RestClient { get; }

        /// <summary> Initializes a new instance of Text2ImgapiClient for mocking. </summary>
        protected Text2ImgapiClient()
        {
        }

        /// <summary> Initializes a new instance of Text2ImgapiClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/> or <paramref name="pipeline"/> is null. </exception>
        internal Text2ImgapiClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            RestClient = new Text2ImgapiRestClient(clientDiagnostics, pipeline, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Text2Imgapi. </summary>
        /// <param name="body"> The StableDiffusionProcessingTxt2Img to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<object>> SdapiV1Txt2ImgPostAsync(StableDiffusionProcessingTxt2Img body, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("Text2ImgapiClient.SdapiV1Txt2ImgPost");
            scope.Start();
            try
            {
                return await RestClient.SdapiV1Txt2ImgPostAsync(body, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Text2Imgapi. </summary>
        /// <param name="body"> The StableDiffusionProcessingTxt2Img to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<object> SdapiV1Txt2ImgPost(StableDiffusionProcessingTxt2Img body, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("Text2ImgapiClient.SdapiV1Txt2ImgPost");
            scope.Start();
            try
            {
                return RestClient.SdapiV1Txt2ImgPost(body, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}