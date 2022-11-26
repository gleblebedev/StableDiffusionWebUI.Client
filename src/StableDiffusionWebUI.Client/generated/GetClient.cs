// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using StableDiffusionWebUI.Client.Models;

namespace StableDiffusionWebUI.Client
{
    /// <summary> The Get service client. </summary>
    public partial class GetClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal GetRestClient RestClient { get; }

        /// <summary> Initializes a new instance of GetClient for mocking. </summary>
        protected GetClient()
        {
        }

        /// <summary> Initializes a new instance of GetClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/> or <paramref name="pipeline"/> is null. </exception>
        internal GetClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            RestClient = new GetRestClient(clientDiagnostics, pipeline, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Get Current User. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<object>> CurrentUserGetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GetClient.CurrentUserGet");
            scope.Start();
            try
            {
                return await RestClient.CurrentUserGetAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get Current User. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<object> CurrentUserGet(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GetClient.CurrentUserGet");
            scope.Start();
            try
            {
                return RestClient.CurrentUserGet(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get Current User. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<object>> CurrentUserUserGetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GetClient.CurrentUserUserGet");
            scope.Start();
            try
            {
                return await RestClient.CurrentUserUserGetAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get Current User. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<object> CurrentUserUserGet(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GetClient.CurrentUserUserGet");
            scope.Start();
            try
            {
                return RestClient.CurrentUserUserGet(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get Token. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<object>> TokenGetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GetClient.TokenGet");
            scope.Start();
            try
            {
                return await RestClient.TokenGetAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get Token. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<object> TokenGet(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GetClient.TokenGet");
            scope.Start();
            try
            {
                return RestClient.TokenGet(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get Token. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<object>> TokenTokenGetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GetClient.TokenTokenGet");
            scope.Start();
            try
            {
                return await RestClient.TokenTokenGetAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get Token. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<object> TokenTokenGet(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GetClient.TokenTokenGet");
            scope.Start();
            try
            {
                return RestClient.TokenTokenGet(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get Config. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<object>> ConfigGetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GetClient.ConfigGet");
            scope.Start();
            try
            {
                return await RestClient.ConfigGetAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get Config. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<object> ConfigGet(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GetClient.ConfigGet");
            scope.Start();
            try
            {
                return RestClient.ConfigGet(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get Config. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<object>> ConfigConfigGetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GetClient.ConfigConfigGet");
            scope.Start();
            try
            {
                return await RestClient.ConfigConfigGetAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get Config. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<object> ConfigConfigGet(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GetClient.ConfigConfigGet");
            scope.Start();
            try
            {
                return RestClient.ConfigConfigGet(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get Queue Status. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Estimation>> QueueStatusGetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GetClient.QueueStatusGet");
            scope.Start();
            try
            {
                return await RestClient.QueueStatusGetAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get Queue Status. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Estimation> QueueStatusGet(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GetClient.QueueStatusGet");
            scope.Start();
            try
            {
                return RestClient.QueueStatusGet(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get Config. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Options>> ConfigSdapiV1OptionsGetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GetClient.ConfigSdapiV1OptionsGet");
            scope.Start();
            try
            {
                return await RestClient.ConfigSdapiV1OptionsGetAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get Config. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Options> ConfigSdapiV1OptionsGet(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GetClient.ConfigSdapiV1OptionsGet");
            scope.Start();
            try
            {
                return RestClient.ConfigSdapiV1OptionsGet(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get Cmd Flags. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Flags>> CmdFlagsSdapiV1CmdFlagsGetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GetClient.CmdFlagsSdapiV1CmdFlagsGet");
            scope.Start();
            try
            {
                return await RestClient.CmdFlagsSdapiV1CmdFlagsGetAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get Cmd Flags. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Flags> CmdFlagsSdapiV1CmdFlagsGet(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GetClient.CmdFlagsSdapiV1CmdFlagsGet");
            scope.Start();
            try
            {
                return RestClient.CmdFlagsSdapiV1CmdFlagsGet(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get Samplers. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<IReadOnlyList<SamplerItem>>> SamplersSdapiV1SamplersGetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GetClient.SamplersSdapiV1SamplersGet");
            scope.Start();
            try
            {
                return await RestClient.SamplersSdapiV1SamplersGetAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get Samplers. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<IReadOnlyList<SamplerItem>> SamplersSdapiV1SamplersGet(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GetClient.SamplersSdapiV1SamplersGet");
            scope.Start();
            try
            {
                return RestClient.SamplersSdapiV1SamplersGet(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get Upscalers. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<IReadOnlyList<UpscalerItem>>> UpscalersSdapiV1UpscalersGetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GetClient.UpscalersSdapiV1UpscalersGet");
            scope.Start();
            try
            {
                return await RestClient.UpscalersSdapiV1UpscalersGetAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get Upscalers. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<IReadOnlyList<UpscalerItem>> UpscalersSdapiV1UpscalersGet(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GetClient.UpscalersSdapiV1UpscalersGet");
            scope.Start();
            try
            {
                return RestClient.UpscalersSdapiV1UpscalersGet(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get Sd Models. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<IReadOnlyList<SDModelItem>>> SdModelsSdapiV1SdModelsGetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GetClient.SdModelsSdapiV1SdModelsGet");
            scope.Start();
            try
            {
                return await RestClient.SdModelsSdapiV1SdModelsGetAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get Sd Models. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<IReadOnlyList<SDModelItem>> SdModelsSdapiV1SdModelsGet(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GetClient.SdModelsSdapiV1SdModelsGet");
            scope.Start();
            try
            {
                return RestClient.SdModelsSdapiV1SdModelsGet(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get Hypernetworks. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<IReadOnlyList<HypernetworkItem>>> HypernetworksSdapiV1HypernetworksGetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GetClient.HypernetworksSdapiV1HypernetworksGet");
            scope.Start();
            try
            {
                return await RestClient.HypernetworksSdapiV1HypernetworksGetAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get Hypernetworks. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<IReadOnlyList<HypernetworkItem>> HypernetworksSdapiV1HypernetworksGet(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GetClient.HypernetworksSdapiV1HypernetworksGet");
            scope.Start();
            try
            {
                return RestClient.HypernetworksSdapiV1HypernetworksGet(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get Face Restorers. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<IReadOnlyList<FaceRestorerItem>>> FaceRestorersSdapiV1FaceRestorersGetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GetClient.FaceRestorersSdapiV1FaceRestorersGet");
            scope.Start();
            try
            {
                return await RestClient.FaceRestorersSdapiV1FaceRestorersGetAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get Face Restorers. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<IReadOnlyList<FaceRestorerItem>> FaceRestorersSdapiV1FaceRestorersGet(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GetClient.FaceRestorersSdapiV1FaceRestorersGet");
            scope.Start();
            try
            {
                return RestClient.FaceRestorersSdapiV1FaceRestorersGet(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get Realesrgan Models. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<IReadOnlyList<RealesrganItem>>> RealesrganModelsSdapiV1RealesrganModelsGetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GetClient.RealesrganModelsSdapiV1RealesrganModelsGet");
            scope.Start();
            try
            {
                return await RestClient.RealesrganModelsSdapiV1RealesrganModelsGetAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get Realesrgan Models. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<IReadOnlyList<RealesrganItem>> RealesrganModelsSdapiV1RealesrganModelsGet(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GetClient.RealesrganModelsSdapiV1RealesrganModelsGet");
            scope.Start();
            try
            {
                return RestClient.RealesrganModelsSdapiV1RealesrganModelsGet(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get Promp Styles. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<IReadOnlyList<PromptStyleItem>>> PrompStylesSdapiV1PromptStylesGetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GetClient.PrompStylesSdapiV1PromptStylesGet");
            scope.Start();
            try
            {
                return await RestClient.PrompStylesSdapiV1PromptStylesGetAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get Promp Styles. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<IReadOnlyList<PromptStyleItem>> PrompStylesSdapiV1PromptStylesGet(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GetClient.PrompStylesSdapiV1PromptStylesGet");
            scope.Start();
            try
            {
                return RestClient.PrompStylesSdapiV1PromptStylesGet(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get Artists Categories. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<IReadOnlyList<string>>> ArtistsCategoriesSdapiV1ArtistCategoriesGetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GetClient.ArtistsCategoriesSdapiV1ArtistCategoriesGet");
            scope.Start();
            try
            {
                return await RestClient.ArtistsCategoriesSdapiV1ArtistCategoriesGetAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get Artists Categories. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<IReadOnlyList<string>> ArtistsCategoriesSdapiV1ArtistCategoriesGet(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GetClient.ArtistsCategoriesSdapiV1ArtistCategoriesGet");
            scope.Start();
            try
            {
                return RestClient.ArtistsCategoriesSdapiV1ArtistCategoriesGet(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get Artists. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<IReadOnlyList<ArtistItem>>> ArtistsSdapiV1ArtistsGetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GetClient.ArtistsSdapiV1ArtistsGet");
            scope.Start();
            try
            {
                return await RestClient.ArtistsSdapiV1ArtistsGetAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get Artists. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<IReadOnlyList<ArtistItem>> ArtistsSdapiV1ArtistsGet(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GetClient.ArtistsSdapiV1ArtistsGet");
            scope.Start();
            try
            {
                return RestClient.ArtistsSdapiV1ArtistsGet(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}