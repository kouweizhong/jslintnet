﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JSLintNet.Console.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("JSLintNet.Console.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error encountered: {0}.
        /// </summary>
        internal static string ErrorEncounteredFormat {
            get {
                return ResourceManager.GetString("ErrorEncounteredFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} ({1} errors).
        /// </summary>
        internal static string ErrorFileSummaryFormat {
            get {
                return ResourceManager.GetString("ErrorFileSummaryFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} (line {1} character {2}).
        /// </summary>
        internal static string ErrorItemFormat {
            get {
                return ResourceManager.GetString("ErrorItemFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error linting file: {0}.
        /// </summary>
        internal static string ExceptionFileFormat {
            get {
                return ResourceManager.GetString("ExceptionFileFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid or missing report file argument..
        /// </summary>
        internal static string ExceptionInvalidReportFileArgument {
            get {
                return ResourceManager.GetString("ExceptionInvalidReportFileArgument", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid or missing settings file argument..
        /// </summary>
        internal static string ExceptionInvalidSettingsFileArgument {
            get {
                return ResourceManager.GetString("ExceptionInvalidSettingsFileArgument", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid or missing source directory argument..
        /// </summary>
        internal static string ExceptionInvalidSourceDirectoryArgument {
            get {
                return ResourceManager.GetString("ExceptionInvalidSourceDirectoryArgument", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unrecognised argument..
        /// </summary>
        internal static string ExceptionUnrecognizedArgument {
            get {
                return ResourceManager.GetString("ExceptionUnrecognizedArgument", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specifies the JSON settings file to create or edit. A .json extension is required or it will be treated as sourcedirectory (see below)..
        /// </summary>
        internal static string HelpEditSettingsFileDescription {
            get {
                return ResourceManager.GetString("HelpEditSettingsFileDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to editsettingsfile.
        /// </summary>
        internal static string HelpEditSettingsFileOption {
            get {
                return ResourceManager.GetString("HelpEditSettingsFileOption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Displays this help text..
        /// </summary>
        internal static string HelpHelpDescription {
            get {
                return ResourceManager.GetString("HelpHelpDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /?.
        /// </summary>
        internal static string HelpHelpOption {
            get {
                return ResourceManager.GetString("HelpHelpOption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specifies the console log level:.
        /// </summary>
        internal static string HelpLogLevelDescription {
            get {
                return ResourceManager.GetString("HelpLogLevelDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Normal  |  0: Logs a final summary to the console..
        /// </summary>
        internal static string HelpLogLevelNormal {
            get {
                return ResourceManager.GetString("HelpLogLevelNormal", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /l loglevel.
        /// </summary>
        internal static string HelpLogLevelOption {
            get {
                return ResourceManager.GetString("HelpLogLevelOption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Silent  | -1: No logging to the console..
        /// </summary>
        internal static string HelpLogLevelSilent {
            get {
                return ResourceManager.GetString("HelpLogLevelSilent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Verbose |  1: Logs every error to the console..
        /// </summary>
        internal static string HelpLogLevelVerbose {
            get {
                return ResourceManager.GetString("HelpLogLevelVerbose", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Options:.
        /// </summary>
        internal static string HelpOptionsHeading {
            get {
                return ResourceManager.GetString("HelpOptionsHeading", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specifies the path to an HTML report file to be written..
        /// </summary>
        internal static string HelpReportFileDescription {
            get {
                return ResourceManager.GetString("HelpReportFileDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /r reportfile.
        /// </summary>
        internal static string HelpReportFileOption {
            get {
                return ResourceManager.GetString("HelpReportFileOption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -----.
        /// </summary>
        internal static string HelpSectionDivider {
            get {
                return ResourceManager.GetString("HelpSectionDivider", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specifies the path to a custom settings file if a {0} file in the source directory should not be used..
        /// </summary>
        internal static string HelpSettingsFileDescriptionFormat {
            get {
                return ResourceManager.GetString("HelpSettingsFileDescriptionFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /s settingsfile.
        /// </summary>
        internal static string HelpSettingsFileOption {
            get {
                return ResourceManager.GetString("HelpSettingsFileOption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specifies the directory to scan with JSLint..
        /// </summary>
        internal static string HelpSourceDirectoryDescription {
            get {
                return ResourceManager.GetString("HelpSourceDirectoryDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to sourcedirectory.
        /// </summary>
        internal static string HelpSourceDirectoryOption {
            get {
                return ResourceManager.GetString("HelpSourceDirectoryOption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} /? | editsettingsfile | sourcedirectory [/s settingsfile] [/r reportfile] [/l loglevel].
        /// </summary>
        internal static string HelpSyntaxFormat {
            get {
                return ResourceManager.GetString("HelpSyntaxFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Syntax:.
        /// </summary>
        internal static string HelpSyntaxHeading {
            get {
                return ResourceManager.GetString("HelpSyntaxHeading", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Settings editor canceled without saving..
        /// </summary>
        internal static string SettingsEditorCanceled {
            get {
                return ResourceManager.GetString("SettingsEditorCanceled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CLOSING THIS CONSOLE WINDOW WILL EXIT THE EDITOR WITHOUT SAVING..
        /// </summary>
        internal static string SettingsEditorCloseWarning {
            get {
                return ResourceManager.GetString("SettingsEditorCloseWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Launching the JSLint.NET settings editor..
        /// </summary>
        internal static string SettingsEditorLaunching {
            get {
                return ResourceManager.GetString("SettingsEditorLaunching", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Settings saved to &quot;{0}&quot;..
        /// </summary>
        internal static string SettingsEditorSavedFormat {
            get {
                return ResourceManager.GetString("SettingsEditorSavedFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Total Warnings: {0}.
        /// </summary>
        internal static string SummaryErrorCountFormat {
            get {
                return ResourceManager.GetString("SummaryErrorCountFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Files with Warnings: {0}.
        /// </summary>
        internal static string SummaryErrorFileCountFormat {
            get {
                return ResourceManager.GetString("SummaryErrorFileCountFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Processed Files: {0}.
        /// </summary>
        internal static string SummaryProcessedFileCountFormat {
            get {
                return ResourceManager.GetString("SummaryProcessedFileCountFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Settings File: {0}.
        /// </summary>
        internal static string SummarySettingsFileFormat {
            get {
                return ResourceManager.GetString("SummarySettingsFileFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Source Directory: {0}.
        /// </summary>
        internal static string SummarySourceDirectoryFormat {
            get {
                return ResourceManager.GetString("SummarySourceDirectoryFormat", resourceCulture);
            }
        }
    }
}
