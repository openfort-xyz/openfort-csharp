![Illustration_05 1-min](https://github.com/user-attachments/assets/56778295-55e6-47a9-a3ee-7971f2fdba0e)

<div align="center">
  <h4>
    <a href="https://www.openfort.io/">
      Website
    </a>
    <span> | </span>
    <a href="https://www.openfort.io/docs">
      Documentation
    </a>
    <span> | </span>
    <a href="https://x.com/openfortxyz">
      Twitter
    </a>
  </h4>
</div>

# Openfort C# Library

The Openfort SDK library provides convenient access to the Openfort API from the server-side code of your applications.

## Installation

.NET CLI
```shell
dotnet add package Openfort.SDK
```

Package Manager
```shell
NuGet\Install-Package Openfort.SDK
```

PackageReference
```xml
<PackageReference Include="Openfort.SDK" />
```

## Usage

The package needs to be configured with your account's secret key, which is
available in the [Openfort Dashboard][api-keys]. Require it with the key's
value:

```cs
var client = new Openfort.SDK.OpenfortClient("sk_test_XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXXX");
var players = await client.Players.List();
Console.WriteLine(players.Data.Count);
```

## Support

New features and bug fixes are released on the latest major version of the `openfort` package. If you are on an older major version, we recommend that you upgrade to the latest in order to use the new features and bug fixes including those for security vulnerabilities. Older major versions of the package will continue to be available for use, but will not be receiving any updates.

[api-keys]: https://dashboard.openfort.io/api-keys

<!--
# vim: set tw=79:
-->
