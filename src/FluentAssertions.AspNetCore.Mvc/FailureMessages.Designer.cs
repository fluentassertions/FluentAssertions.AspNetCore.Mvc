﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FluentAssertions.AspNetCore.Mvc {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class FailureMessages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal FailureMessages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("FluentAssertions.AspNetCore.Mvc.FailureMessages", typeof(FailureMessages).Assembly);
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
        ///   Looks up a localized string similar to Expected {0} to be &apos;{1}&apos; but found &apos;{2}&apos;.
        /// </summary>
        internal static string CommonFailMessage {
            get {
                return ResourceManager.GetString("CommonFailMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expected {context} to be {0}{reason} but found {1}..
        /// </summary>
        internal static string CommonFailMessage2 {
            get {
                return ResourceManager.GetString("CommonFailMessage2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expected {0} to be of type {1}, but no {0} was supplied..
        /// </summary>
        internal static string CommonNullWasSuppliedFailMessage {
            get {
                return ResourceManager.GetString("CommonNullWasSuppliedFailMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expected {0} to be of type &apos;{1}&apos; but was &apos;{2}&apos;.
        /// </summary>
        internal static string CommonTypeFailMessage {
            get {
                return ResourceManager.GetString("CommonTypeFailMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expected &quot;FileContentResult.FileContents&quot; to have {0} byte(s), but found {1}..
        /// </summary>
        internal static string FileContentResult_WithFileContents_LengthFail {
            get {
                return ResourceManager.GetString("FileContentResult_WithFileContents_LengthFail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expected &quot;FileContentResult.FileContents[{0}]&quot; to be {1:x2}, but found {2:x2}..
        /// </summary>
        internal static string FileContentResult_WithFileContents_MatchFail {
            get {
                return ResourceManager.GetString("FileContentResult_WithFileContents_MatchFail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to RedirectToActionResult.RouteValues does not contain key {0}..
        /// </summary>
        internal static string RedirectToActionResult_RouteValues_ContainsKey {
            get {
                return ResourceManager.GetString("RedirectToActionResult_RouteValues_ContainsKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expected RedirectToActionResult.RouteValues[{0}] to have value {1}, but found {2}..
        /// </summary>
        internal static string RedirectToActionResult_RouteValues_HaveValue {
            get {
                return ResourceManager.GetString("RedirectToActionResult_RouteValues_HaveValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to RouteData.DataTokens does not contain key {0}..
        /// </summary>
        internal static string RouteData_DataTokens_ContainsKey {
            get {
                return ResourceManager.GetString("RouteData_DataTokens_ContainsKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expected RouteData.DataTokens[{0}] to have value {1}, but found {2}..
        /// </summary>
        internal static string RouteData_DataTokens_HaveValue {
            get {
                return ResourceManager.GetString("RouteData_DataTokens_HaveValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to RouteData.Values does not contain key {0}..
        /// </summary>
        internal static string RouteData_Values_ContainsKey {
            get {
                return ResourceManager.GetString("RouteData_Values_ContainsKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expected RouteData.Values[{0}] to have value {1}, but found {2}..
        /// </summary>
        internal static string RouteData_Values_HaveValue {
            get {
                return ResourceManager.GetString("RouteData_Values_HaveValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expected status code to be {0} but found {1}..
        /// </summary>
        internal static string StatusCodeResultBase_WithStatusCode {
            get {
                return ResourceManager.GetString("StatusCodeResultBase_WithStatusCode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expected MasterName to be {0} but found {1}..
        /// </summary>
        internal static string ViewResult_MasterName {
            get {
                return ResourceManager.GetString("ViewResult_MasterName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expected Model to be of type {0}, but no Model was supplied..
        /// </summary>
        internal static string ViewResultBase_NullModel {
            get {
                return ResourceManager.GetString("ViewResultBase_NullModel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ViewData does not contain key of {0}..
        /// </summary>
        internal static string ViewResultBase_ViewData_ContainsKey {
            get {
                return ResourceManager.GetString("ViewResultBase_ViewData_ContainsKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expected ViewData[{0}] to have value {1}, but found {2}..
        /// </summary>
        internal static string ViewResultBase_ViewData_HaveValue {
            get {
                return ResourceManager.GetString("ViewResultBase_ViewData_HaveValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expected ViewName to be {0} but found {1}..
        /// </summary>
        internal static string ViewResultBase_ViewName {
            get {
                return ResourceManager.GetString("ViewResultBase_ViewName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expected default view, but view {0} was rendered..
        /// </summary>
        internal static string ViewResultBase_WithDefaultViewName {
            get {
                return ResourceManager.GetString("ViewResultBase_WithDefaultViewName", resourceCulture);
            }
        }
    }
}
