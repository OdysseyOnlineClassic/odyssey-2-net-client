using System.Reflection;
using System.Runtime.InteropServices;

[assembly: AssemblyTitle("Odyssey.Client")]
[assembly: AssemblyProduct("Odyssey Online")]

#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif

[assembly: AssemblyDescription("The Odyssey Online Client")]
[assembly: AssemblyCompany("OdysseyOnline")]
[assembly: AssemblyCopyright("Copyright ©  2018")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

[assembly: ComVisible(false)]

[assembly: Guid("e7aa48cf-8168-435f-81fb-3f50fdffe4f7")]

[assembly: AssemblyVersion("0.1.*")]
