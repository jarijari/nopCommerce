﻿using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Nop.Plugin.Payments.Payrexx.Domain
{
    /// <summary>
    /// Represents request to get invoice
    /// </summary>
    public class GetInvoiceRequest : Request
    {
        /// <summary>
        /// Gets or sets the identifier of the invoice to retrieve
        /// </summary>
        [JsonIgnore]
        public string Id { get; set; }

        /// <summary>
        /// Get a request path
        /// </summary>
        public override string Path => $"Invoice/{Id}/";

        /// <summary>
        /// Get a request method
        /// </summary>
        public override string Method => HttpMethods.Get;
    }
}