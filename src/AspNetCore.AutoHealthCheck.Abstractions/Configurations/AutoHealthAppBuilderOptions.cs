﻿//MIT License
//Copyright(c) 2017 David Revoledo

//Permission is hereby granted, free of charge, to any person obtaining a copy
//of this software and associated documentation files (the "Software"), to deal
//in the Software without restriction, including without limitation the rights
//to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//copies of the Software, and to permit persons to whom the Software is
//furnished to do so, subject to the following conditions:

//The above copyright notice and this permission notice shall be included in all
//copies or substantial portions of the Software.

//THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//SOFTWARE.
// Project Lead - David Revoledo davidrevoledo@d-genix.com

using System;
using Microsoft.AspNetCore.Http;

namespace AspNetCore.AutoHealthCheck
{
    /// <summary>
    ///     Options for auto health check middleware
    /// </summary>
    public sealed class AutoHealthAppBuilderOptions
    {
        /// <summary>
        ///     Gets or sets a route prefix for accessing the auto health check endpoint
        /// </summary>
        public string RoutePrefix { get; set; } = "api/autoHealthCheck";

        /// <summary>
        ///     SecurityHandler for the health check request.
        /// </summary>
        public Func<HttpRequest, bool> SecurityHandler { get; set; }
    }
}