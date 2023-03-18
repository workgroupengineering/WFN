﻿using CommunityToolkit.Mvvm.ComponentModel;

using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Media.Imaging;

using Wokhan.ComponentModel.Extensions;
using Wokhan.WindowsFirewallNotifier.Common.IO.Files;
using Wokhan.WindowsFirewallNotifier.Common.Logging;
using Wokhan.WindowsFirewallNotifier.Common.Net.DNS;

namespace Wokhan.WindowsFirewallNotifier.Common.UI.ViewModels;

public class ConnectionBaseInfo : ObservableObject
{
    public DateTime CreationTime { get; init; }

    public uint Pid { get; protected set; }

    public string? IconPath { get; protected set; }

    protected BitmapSource? _icon;
    public BitmapSource? Icon
    {
        get => this.GetOrSetValueAsync(() => IconHelper.GetIconAsync(IconPath ?? Path), ref _icon, OnPropertyChanged);
        set => this.SetValue(ref _icon, value, OnPropertyChanged);
    }

    public string? Path { get; protected set; }
    public string? FileName { get; protected set; }


    protected string? description;
    public string? Description
    {
        get => this.GetOrSetValueAsync(() => SetFileInformation(nameof(description)), ref description, OnPropertyChanged);
        protected set => this.SetValue(ref description, value, OnPropertyChanged);
    }

    protected string? productName;
    public string? ProductName
    {
        get => this.GetOrSetValueAsync(() => SetFileInformation(nameof(productName)), ref productName, OnPropertyChanged);
        protected set => this.SetValue(ref productName, value, OnPropertyChanged);
    }

    protected string? company;
    public string? Company
    {
        get => this.GetOrSetValueAsync(() => SetFileInformation(nameof(company)), ref company, OnPropertyChanged);
        protected set => this.SetValue(ref company, value, OnPropertyChanged);
    }

    public string? ServiceName { get; protected set; }
    public string? SourceIP { get; protected set; }
    public string? SourcePort { get; set; }
    public string? TargetIP { get; protected set; }
    public string? TargetPort { get; protected set; }

    private string? _targetHostName;
    public string? TargetHostName
    {
        get => this.GetOrSetValueAsync(() => ResolvedIPInformation.ResolveIpAddressAsync(TargetIP), ref _targetHostName, OnPropertyChanged);
        protected set => this.SetValue(ref _targetHostName, value, OnPropertyChanged);
    }

    public int RawProtocol { get; protected set; }
    public string? Protocol { get; protected set; }
    public string? Direction { get; protected set; }

    private bool fileInfoResolutionTriggered;

    private string? SetFileInformation(string fieldName)
    {
        if (fileInfoResolutionTriggered)
        {
            return null;
        }

        fileInfoResolutionTriggered = true;

        if (Path == "System")
        {
            description = "System";
            productName = "System";
            company = String.Empty;
        }
        else if (File.Exists(Path))
        {
            try
            {
                var fileinfo = FileVersionInfo.GetVersionInfo(Path);

                productName = fileinfo.ProductName ?? String.Empty;
                company = fileinfo.CompanyName ?? String.Empty;

                if (string.IsNullOrWhiteSpace(fileinfo.FileDescription))
                {
                    description = FileName;
                }
                else
                {
                    description = fileinfo.FileDescription;
                }
            }
            catch (Exception exc)
            {
                LogHelper.Error("Unable to check the file description.", exc);
                description = Path;
                productName = "?";
                company = "?";
            }
        }
        else
        {
            // TODO: this happens when accessing system32 files from a x86 application i.e. File.Exists always returns false; solution would be to target AnyCPU
            description = Path;
            productName = "?";
            company = "?";
        }

        return fieldName switch
        {
            nameof(description) => description,
            nameof(productName) => productName,
            nameof(company) => company,
            _ => String.Empty,
        };
    }
}
