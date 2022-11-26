// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace StableDiffusionWebUI.Client.Models
{
    public partial class UpscalerItem
    {
        internal static UpscalerItem DeserializeUpscalerItem(JsonElement element)
        {
            string name = default;
            Optional<string> modelName = default;
            Optional<string> modelPath = default;
            Optional<string> modelUrl = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("model_name"))
                {
                    modelName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("model_path"))
                {
                    modelPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("model_url"))
                {
                    modelUrl = property.Value.GetString();
                    continue;
                }
            }
            return new UpscalerItem(name, modelName.Value, modelPath.Value, modelUrl.Value);
        }
    }
}