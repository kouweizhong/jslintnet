﻿using System;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using JSLintNet;

[assembly: AssemblyTitle("JSLint.NET for Visual Studio")]
[assembly: AssemblyCompany(AssemblyInfo.Company)]
[assembly: AssemblyProduct(AssemblyInfo.Product)]
[assembly: AssemblyCopyright(AssemblyInfo.Copyright)]
[assembly: AssemblyVersion(AssemblyInfo.Version)]
[assembly: AssemblyInformationalVersion(AssemblyInfo.InformationalVersion)]

[assembly: ComVisible(false)]
[assembly: CLSCompliant(false)]
[assembly: NeutralResourcesLanguage("en-US")]

[assembly: InternalsVisibleTo("JSLintNet.Specifications, PublicKey=" + AssemblyInfo.PublicKey)]
[assembly: InternalsVisibleTo("JSLintNet.VisualStudio.Specifications, PublicKey=" + AssemblyInfo.PublicKey)]
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2, PublicKey=" + AssemblyInfo.DynamicPublicKey)]
