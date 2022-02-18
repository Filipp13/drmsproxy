using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Net.Http.Headers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Mime;
using System.Text;
using System.Text.RegularExpressions;

namespace CRM.HttpClient
{
    public static class MutipartMixedHelper
    {
        public static async Task<MultipartReader> ParseMultipartMixedRequestAsync(HttpResponseMessage request)
        {
            // Extract, sanitize and validate boundry
            var boundary = HeaderUtilities.RemoveQuotes(
                MediaTypeHeaderValue.Parse(request.Content.Headers.ContentType.ToString()).Boundary).Value;

            if (string.IsNullOrWhiteSpace(boundary) ||
                (boundary.Length > new FormOptions().MultipartBoundaryLengthLimit))
            {
                throw new InvalidDataException("boundry is shot");
            }

            // Create a new reader based on that boundry
            return new MultipartReader(boundary, await request.Content.ReadAsStreamAsync());

           
        }
    }

    public sealed class ParsedSection
    {
        public bool IsJson { get; set; }
        public bool IsXml { get; set; }
        public string Name { get; set; }
        public string Data { get; set; }
        public Encoding Encoding { get; set; }
    }
}