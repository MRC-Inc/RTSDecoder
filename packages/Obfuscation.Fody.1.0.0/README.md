# Obfuscation.Fody

[![.NET Build](https://github.com/VAllens/Obfuscation.Fody/actions/workflows/build.yml/badge.svg?branch=develop&event=push)](https://github.com/VAllens/Obfuscation.Fody/actions/workflows/build.yml) [![NuGet Publish](https://github.com/VAllens/Obfuscation.Fody/actions/workflows/publish.yml/badge.svg?branch=main&event=pull_request)](https://github.com/VAllens/Obfuscation.Fody/actions/workflows/publish.yml)

## This is a [Fody](https://github.com/Fody/Fody) extension to modify `ObfuscationAttribute`.

It will get the attribute target that contains `ObfuscationAttribute`, and filter out the attribute target whose `Exclude` property value is equal to `true`, and modify the eligible `Feature` property value. Other properties remain the same.

It has one configuration element:

```xml
<Obfuscation Feature="EXCLUDE:NECROBIT,STRINGENCRYPTION,ANTITAMP,CONTROLFLOW,SNREMOVAL;INCLUDE:OBFUSCATION" Append="true" />
```

The `Feature` configuration item will be used to modify the `Feature` property of the `ObfuscationAttribute`.
The `Feature` configuration item is required, otherwise the `Obfuscation.Fody` extension does not work.

The `Append` configuration item will decide whether to override the original `Feature` property value or append it.
The `Append` default value is `false`, it is optional.

[Attribute targets](https://docs.microsoft.com/en-us/dotnet/api/system.attributetargets) Support:

- Assembly
- Class
- Struct
- Enum
- Method
- Property
- Field
- Event
- Interface
- Parameter
- Delegate
- Record (a special class)
- Indexer (a special property)
- Destructor (a special method)
- Constructor parameters (The Constructor is a special method)