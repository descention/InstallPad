﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.42
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InstallPad.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("InstallPad.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to There were errors while downloading..
        /// </summary>
        internal static string ErrorDownloading {
            get {
                return ResourceManager.GetString("ErrorDownloading", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There were errors while installing..
        /// </summary>
        internal static string ErrorInstalling {
            get {
                return ResourceManager.GetString("ErrorInstalling", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This license governs use of the accompanying software. If you use the software, you accept this license. If you do not accept the license, do not use the software.
        ///
        ///1. Definitions
        ///The terms &quot;reproduce,&quot; &quot;reproduction&quot; and &quot;distribution&quot; have the same meaning here as under U.S. copyright law.
        ///&quot;You&quot; means the licensee of the software.
        ///&quot;Your company&quot; means the company you worked for when you downloaded the software.
        ///&quot;Personal use&quot; means use not within your company, and specifically excludes the right to  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string license {
            get {
                return ResourceManager.GetString("license", resourceCulture);
            }
        }
        
        internal static System.Drawing.Bitmap logo {
            get {
                object obj = ResourceManager.GetObject("logo", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        internal static System.Drawing.Bitmap logoBorder {
            get {
                object obj = ResourceManager.GetObject("logoBorder", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to View details..
        /// </summary>
        internal static string ViewDetails {
            get {
                return ResourceManager.GetString("ViewDetails", resourceCulture);
            }
        }
    }
}
