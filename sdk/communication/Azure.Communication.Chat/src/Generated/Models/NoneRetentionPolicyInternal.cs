// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.Chat
{
    /// <summary> No thread retention policy. </summary>
    internal partial class NoneRetentionPolicyInternal : ChatRetentionPolicyInternal
    {
        /// <summary> Initializes a new instance of <see cref="NoneRetentionPolicyInternal"/>. </summary>
        public NoneRetentionPolicyInternal()
        {
            Kind = RetentionPolicyKind.None;
        }

        /// <summary> Initializes a new instance of <see cref="NoneRetentionPolicyInternal"/>. </summary>
        /// <param name="kind"> Retention Policy Type. </param>
        internal NoneRetentionPolicyInternal(RetentionPolicyKind kind) : base(kind)
        {
            Kind = kind;
        }
    }
}
