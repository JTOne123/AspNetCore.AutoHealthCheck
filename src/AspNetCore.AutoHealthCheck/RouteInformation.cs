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
using System.Collections.Generic;

namespace AspNetCore.AutoHealthCheck
{
    /// <summary>
    ///     Route information for a single endpoint
    /// </summary>
    internal sealed class RouteInformation : IRouteInformation
    {
        /// <summary>
        ///     Http method needed to be consumed
        /// </summary>
        public string HttpMethod { get; set; } = "GET";

        /// <summary>
        ///     Route needed to be consumed
        /// </summary>
        public string Path { get; set; } = "";

        /// <summary>
        ///     Route template definition
        /// </summary>
        public string RouteTemplate { get; set; }

        /// <summary>
        ///     Route params key and type for url replacing
        /// </summary>
        public Dictionary<string, Type> RouteParams { get; set; } = new Dictionary<string, Type>();

        /// <summary>
        ///     Body params key and type
        ///     Just 1 for now will be supported
        /// </summary>
        public Dictionary<string, Type> BodyParams { get; set; } = new Dictionary<string, Type>();
    }
}