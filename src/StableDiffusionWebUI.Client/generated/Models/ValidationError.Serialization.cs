// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace StableDiffusionWebUI.Client.Models
{
    public partial class ValidationError
    {
        internal static ValidationError DeserializeValidationError(JsonElement element)
        {
            IReadOnlyList<ValidationErrorLocItem> loc = default;
            string msg = default;
            string type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("loc"))
                {
                    List<ValidationErrorLocItem> array = new List<ValidationErrorLocItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ValidationErrorLocItem.DeserializeValidationErrorLocItem(item));
                    }
                    loc = array;
                    continue;
                }
                if (property.NameEquals("msg"))
                {
                    msg = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
            }
            return new ValidationError(loc, msg, type);
        }
    }
}
