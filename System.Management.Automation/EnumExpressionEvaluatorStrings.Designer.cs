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
    public class EnumExpressionEvaluatorStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal EnumExpressionEvaluatorStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("System.Management.Automation.EnumExpressionEvaluatorStrings", typeof(EnumExpressionEvaluatorStrings).Assembly);
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
        ///   Looks up a localized string similar to The input expression must not be empty. Specify at least one identifier name in each input expression. .
        /// </summary>
        public static string EmptyInputString {
            get {
                return ResourceManager.GetString("EmptyInputString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to match an empty identifier name to a valid enumerator name. Specify one of the following enumerator names and retry: {0}..
        /// </summary>
        public static string EmptyTokenString {
            get {
                return ResourceManager.GetString("EmptyTokenString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The generic type specified for the expression must represent an enum. Specify a valid enum type. .
        /// </summary>
        public static string InvalidGenericType {
            get {
                return ResourceManager.GetString("InvalidGenericType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The identifier name {0} cannot be processed due to the inability to differentiate between the following enumerator names: {1}. Try a more specific identifier name..
        /// </summary>
        public static string MultipleEnumNameMatch {
            get {
                return ResourceManager.GetString("MultipleEnumNameMatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to match the identifier name {0} to a valid enumerator name.  Specify one of the following enumerator names and try again: {1}.
        /// </summary>
        public static string NoEnumNameMatch {
            get {
                return ResourceManager.GetString("NoEnumNameMatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use of parentheses is not valid in the expression because identifier grouping is not allowed. Try removing the parentheses, or if a subexpression is enclosed, try expanding the expression..
        /// </summary>
        public static string NoIdentifierGroupingAllowed {
            get {
                return ResourceManager.GetString("NoIdentifierGroupingAllowed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to parse the expression due to an unexpected token. Only an OR (,) operator or AND (+) operator is expected after an identifier name..
        /// </summary>
        public static string SyntaxErrorBinaryOperatorExpected {
            get {
                return ResourceManager.GetString("SyntaxErrorBinaryOperatorExpected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to parse the expression due to an unexpected token after a NOT (!) operator. An identifier name is expected after a NOT (!) operator..
        /// </summary>
        public static string SyntaxErrorIdentifierExpected {
            get {
                return ResourceManager.GetString("SyntaxErrorIdentifierExpected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to parse the expression due to an unexpected token. An identifier name or a NOT (!) operator is expected at the start of the expression, or after an OR (,) operator or an AND (+) operator. Also, an expression must not end with an OR (,), AND (+) or NOT (!) operator..
        /// </summary>
        public static string SyntaxErrorUnexpectedBinaryOperator {
            get {
                return ResourceManager.GetString("SyntaxErrorUnexpectedBinaryOperator", resourceCulture);
            }
        }
    }
}