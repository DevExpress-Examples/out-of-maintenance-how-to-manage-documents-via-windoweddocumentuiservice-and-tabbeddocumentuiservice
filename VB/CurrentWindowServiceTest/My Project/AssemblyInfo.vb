' Developer Express Code Central Example:
' How to: Manage documents via WindowedDocumentUIService and TabbedDocumentUIService
' 
' The WindowedDocumentUIService provides methods to create and show documents as
' windows.
' The TabbedDocumentUIService provides methods to create and show
' documents as tabs.
' The CurrentWindowService provides methods to close the
' current window.
' 
' The following example demonstrates how to use the above
' services in a View Model.
' 
' If you wish to perform some actions when the
' document is about to close or wish to prevent a document from being closed,
' implement the IDocumentViewModel interface for the view model that represents a
' document. The IDocumentViewModel.Close method will be called before the document
' closure.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E4861

Imports System.Reflection
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows

' General Information about an assembly is controlled through the following 
' set of attributes. Change these attribute values to modify the information
' associated with an assembly.
<Assembly: AssemblyTitle("CurrentWindowServiceTest")>
<Assembly: AssemblyDescription("")>
<Assembly: AssemblyConfiguration("")>
<Assembly: AssemblyCompany("")>
<Assembly: AssemblyProduct("CurrentWindowServiceTest")>
<Assembly: AssemblyCopyright("Copyright ©  2013")>
<Assembly: AssemblyTrademark("")>
<Assembly: AssemblyCulture("")>

' Setting ComVisible to false makes the types in this assembly not visible 
' to COM components.  If you need to access a type in this assembly from 
' COM, set the ComVisible attribute to true on that type.
<Assembly: ComVisible(False)>

'In order to begin building localizable applications, set 
'<UICulture>CultureYouAreCodingWith</UICulture> in your .csproj file
'inside a <PropertyGroup>.  For example, if you are using US english
'in your source files, set the <UICulture> to en-US.  Then uncomment
'the NeutralResourceLanguage attribute below.  Update the "en-US" in
'the line below to match the UICulture setting in the project file.

'[assembly: NeutralResourcesLanguage("en-US", UltimateResourceFallbackLocation.Satellite)]


<Assembly: ThemeInfo(ResourceDictionaryLocation.None, ResourceDictionaryLocation.SourceAssembly)> 'where the generic resource dictionary is located - where theme specific resource dictionaries are located
    '(used if a resource is not found in the page, 
    ' or application resource dictionaries)
    '(used if a resource is not found in the page, 
    ' app, or any theme specific resource dictionaries)


' Version information for an assembly consists of the following four values:
'
'      Major Version
'      Minor Version 
'      Build Number
'      Revision
'
' You can specify all the values or you can default the Build and Revision Numbers 
' by using the '*' as shown below:
' [assembly: AssemblyVersion("1.0.*")]
<Assembly: AssemblyVersion("1.0.0.0")>
<Assembly: AssemblyFileVersion("1.0.0.0")>
