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
            var boundary = HeaderUtilities.RemoveQuotes(
                MediaTypeHeaderValue.Parse(request.Content.Headers.ContentType.ToString()).Boundary).Value;

            if (string.IsNullOrWhiteSpace(boundary) ||
                (boundary.Length > new FormOptions().MultipartBoundaryLengthLimit))
            {
                throw new InvalidDataException("boundry is shot");
            }

            return new MultipartReader(boundary, await request.Content.ReadAsStreamAsync());  
        }
    }

   
}