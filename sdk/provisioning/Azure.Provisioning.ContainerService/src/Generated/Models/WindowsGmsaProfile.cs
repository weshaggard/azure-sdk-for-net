// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.ContainerService;

/// <summary>
/// Windows gMSA Profile in the managed cluster.
/// </summary>
public partial class WindowsGmsaProfile : ProvisionableConstruct
{
    /// <summary>
    /// Specifies whether to enable Windows gMSA in the managed cluster.
    /// </summary>
    public BicepValue<bool> IsEnabled 
    {
        get { Initialize(); return _isEnabled!; }
        set { Initialize(); _isEnabled!.Assign(value); }
    }
    private BicepValue<bool>? _isEnabled;

    /// <summary>
    /// Specifies the DNS server for Windows gMSA. &lt;br&gt;&lt;br&gt; Set it
    /// to empty if you have configured the DNS server in the vnet which is
    /// used to create the managed cluster.
    /// </summary>
    public BicepValue<string> DnsServer 
    {
        get { Initialize(); return _dnsServer!; }
        set { Initialize(); _dnsServer!.Assign(value); }
    }
    private BicepValue<string>? _dnsServer;

    /// <summary>
    /// Specifies the root domain name for Windows gMSA. &lt;br&gt;&lt;br&gt;
    /// Set it to empty if you have configured the DNS server in the vnet
    /// which is used to create the managed cluster.
    /// </summary>
    public BicepValue<string> RootDomainName 
    {
        get { Initialize(); return _rootDomainName!; }
        set { Initialize(); _rootDomainName!.Assign(value); }
    }
    private BicepValue<string>? _rootDomainName;

    /// <summary>
    /// Creates a new WindowsGmsaProfile.
    /// </summary>
    public WindowsGmsaProfile()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of WindowsGmsaProfile.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _isEnabled = DefineProperty<bool>("IsEnabled", ["enabled"]);
        _dnsServer = DefineProperty<string>("DnsServer", ["dnsServer"]);
        _rootDomainName = DefineProperty<string>("RootDomainName", ["rootDomainName"]);
    }
}
