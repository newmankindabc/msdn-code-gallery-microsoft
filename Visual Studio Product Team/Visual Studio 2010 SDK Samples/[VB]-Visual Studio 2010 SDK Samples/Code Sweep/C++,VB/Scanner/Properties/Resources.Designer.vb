'**************************************************************************

'Copyright (c) Microsoft Corporation. All rights reserved.
'This code is licensed under the Visual Studio SDK license terms.
'THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF
'ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY
'IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR
'PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.

'**************************************************************************
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.31
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------


Imports Microsoft.VisualBasic
Imports System
Namespace Microsoft.Samples.VisualStudio.CodeSweep.Scanner.Properties

    ' This class was auto-generated by the StronglyTypedResourceBuilder
    ' class via a tool like ResGen or Visual Studio.
    ' To add or remove a member, edit your .ResX file then rerun ResGen
    ' with the /str option, or rebuild your VS project.
    ''' <summary>
    '''   A strongly-typed resource class, for looking up localized strings, etc.
    ''' </summary>

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0"), Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()> _
    Friend Class Resources

        Private Shared resourceMan As Global.System.Resources.ResourceManager

        Private Shared resourceCulture As Global.System.Globalization.CultureInfo

        <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")> _
        Friend Sub New()
        End Sub

        ''' <summary>
        '''   Returns the cached ResourceManager instance used by this class.
        ''' </summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Friend Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As New Global.System.Resources.ResourceManager("Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property

        ''' <summary>
        '''   Overrides the current thread's CurrentUICulture property for all
        '''   resource lookups using this strongly typed resource class.
        ''' </summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Friend Shared Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set(ByVal value As Global.System.Globalization.CultureInfo)
                resourceCulture = value
            End Set
        End Property

        ''' <summary>
        '''   Looks up a localized string similar to Error: the term &apos;{0}&apos; was specified in multiple term tables: {1}.  Using the last matching term table for that term&apos;s results..
        ''' </summary>
        Friend Shared ReadOnly Property DuplicateTermWarning() As String
            Get
                Return ResourceManager.GetString("DuplicateTermWarning", resourceCulture)
            End Get
        End Property
    End Class
End Namespace
