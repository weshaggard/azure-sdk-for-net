// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Resources;

/// <summary>
/// The child information of a management group.
/// </summary>
public partial class ManagementGroupChildInfo : ProvisionableConstruct
{
    /// <summary>
    /// The fully qualified resource type which includes provider namespace
    /// (e.g. Microsoft.Management/managementGroups).
    /// </summary>
    public BicepValue<ManagementGroupChildType> ChildType { get => _childType; }
    private readonly BicepValue<ManagementGroupChildType> _childType;

    /// <summary>
    /// The fully qualified ID for the child resource (management group or
    /// subscription).  For example,
    /// /providers/Microsoft.Management/managementGroups/0000000-0000-0000-0000-000000000000.
    /// </summary>
    public BicepValue<string> Id { get => _id; }
    private readonly BicepValue<string> _id;

    /// <summary>
    /// The name of the child entity.
    /// </summary>
    public BicepValue<string> Name { get => _name; }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// The friendly name of the child resource.
    /// </summary>
    public BicepValue<string> DisplayName { get => _displayName; }
    private readonly BicepValue<string> _displayName;

    /// <summary>
    /// The list of children.
    /// </summary>
    public BicepList<ManagementGroupChildInfo> Children { get => _children; }
    private readonly BicepList<ManagementGroupChildInfo> _children;

    /// <summary>
    /// Creates a new ManagementGroupChildInfo.
    /// </summary>
    public ManagementGroupChildInfo()
    {
        _childType = BicepValue<ManagementGroupChildType>.DefineProperty(this, "ChildType", ["type"], isOutput: true);
        _id = BicepValue<string>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isOutput: true);
        _displayName = BicepValue<string>.DefineProperty(this, "DisplayName", ["displayName"], isOutput: true);
        _children = BicepList<ManagementGroupChildInfo>.DefineProperty(this, "Children", ["children"], isOutput: true);
    }
}
