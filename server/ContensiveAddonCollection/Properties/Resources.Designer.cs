﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Contensive.Addons.AddonSamples.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Contensive.Addons.AddonSamples.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to &lt;div class=&quot;designBlockContainer blockSample {{outerContainerClass}}&quot; style=&quot;{{styleHeight}}{{styleBackgroundImage}}&quot;&gt;
        ///    &lt;div class=&quot;{{contentContainerClass}}&quot;&gt;
        ///        &lt;div class=&quot;blockTileInner&quot;&gt;
        ///            {{#ImageUrl}}
        ///            &lt;div class=&quot;blockTileImage&quot;&gt;
        ///                {{#manageAspectRatio}}
        ///                &lt;div class=&quot;blockTileImageInner {{styleAspectRatio}}&quot; style=&quot;background-image: url(&apos;{{ImageUrl}}&apos;);background-position:center;&quot;&gt;&lt;/div&gt;
        ///                {{/manageAspectRatio}}
        ///         [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SampleLayout {
            get {
                return ResourceManager.GetString("SampleLayout", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to select top 1 m.name as personName, o.organizationName 
        ///from ccmembers m left join organizations o on o.id=m.organizationId
        ///where o.id={organizationId}.
        /// </summary>
        internal static string sampleSql {
            get {
                return ResourceManager.GetString("sampleSql", resourceCulture);
            }
        }
    }
}
