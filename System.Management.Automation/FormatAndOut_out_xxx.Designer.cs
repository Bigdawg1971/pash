﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System.Management.Automation {
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
    public class FormatAndOut_out_xxx {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal FormatAndOut_out_xxx() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("System.Management.Automation.FormatAndOut_out_xxx", typeof(FormatAndOut_out_xxx).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;SPACE&gt; next page; &lt;CR&gt; next line; Q quit.
        /// </summary>
        public static string ConsoleLineOutput_PagingPrompt {
            get {
                return ResourceManager.GetString("ConsoleLineOutput_PagingPrompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Output to File.
        /// </summary>
        public static string OutFile_Action {
            get {
                return ResourceManager.GetString("OutFile_Action", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot open file &quot;{0}&quot;..
        /// </summary>
        public static string OutFile_FileOpenFailure {
            get {
                return ResourceManager.GetString("OutFile_FileOpenFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unexpected lineOutput type {0}; LineOutput expects type {1}..
        /// </summary>
        public static string OutLineOutput_InvalidLineOutputParameterType {
            get {
                return ResourceManager.GetString("OutLineOutput_InvalidLineOutputParameterType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to LineOutput should not be null..
        /// </summary>
        public static string OutLineOutput_NullLineOutputParameter {
            get {
                return ResourceManager.GetString("OutLineOutput_NullLineOutputParameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The object of type &quot;{0}&quot; is not valid or not in the correct sequence. This is likely caused by a user-specified &quot;{1}&quot; command which is conflicting with the default formatting..
        /// </summary>
        public static string OutLineOutput_OutOfSequencePacket {
            get {
                return ResourceManager.GetString("OutLineOutput_OutOfSequencePacket", resourceCulture);
            }
        }
    }
}
