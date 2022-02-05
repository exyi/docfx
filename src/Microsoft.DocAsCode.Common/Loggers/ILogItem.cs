// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace Microsoft.DocAsCode.Common
{
    public interface ILogItem
    {
        LogLevel LogLevel { get; }
        string Message { get; }
        string Phase { get; }
        string File { get; }
        string Line { get; }
        string Code { get; }
        string CorrelationId { get; }
        Exception Exception { get; }
    }
}
