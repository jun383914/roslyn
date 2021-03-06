﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

namespace Microsoft.CodeAnalysis.LanguageServerIndexFormat.Generator.Graph
{
    /// <summary>
    /// Represents the document vertex that contains all the <see cref="Range"/>s. See https://github.com/Microsoft/language-server-protocol/blob/master/indexFormat/specification.md#ranges for examples.
    /// </summary>
    internal sealed class Document : Vertex
    {
        public Uri Uri { get; }
        public string LanguageId { get; }

        public Document(Uri uri, string languageId, IdFactory idFactory)
            : base(label: "document", idFactory)
        {
            this.Uri = uri;
            this.LanguageId = languageId;
        }
    }
}
