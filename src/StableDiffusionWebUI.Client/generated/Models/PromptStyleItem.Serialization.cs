// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace StableDiffusionWebUI.Client.Models
{
    public partial class PromptStyleItem
    {
        internal static PromptStyleItem DeserializePromptStyleItem(JsonElement element)
        {
            string name = default;
            Optional<string> prompt = default;
            Optional<string> negativePrompt = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("prompt"))
                {
                    prompt = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("negative_prompt"))
                {
                    negativePrompt = property.Value.GetString();
                    continue;
                }
            }
            return new PromptStyleItem(name, prompt.Value, negativePrompt.Value);
        }
    }
}
