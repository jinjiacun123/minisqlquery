﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MiniSqlQuery.Core.Properties {
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
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MiniSqlQuery.Core.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///
        ///&lt;DbConnectionDefinitionList xmlns:xsi=&quot;http://www.w3.org/2001/XMLSchema-instance&quot; xmlns:xsd=&quot;http://www.w3.org/2001/XMLSchema&quot;&gt;
        ///	&lt;Definitions&gt;
        ///		&lt;DbConnectionDefinition&gt;
        ///			&lt;Name&gt;Default - MSSQL Master@localhost&lt;/Name&gt;
        ///			&lt;ProviderName&gt;System.Data.SqlClient&lt;/ProviderName&gt;
        ///			&lt;ConnectionString&gt;Server=.; Database=master; Integrated Security=SSPI&lt;/ConnectionString&gt;
        ///		&lt;/DbConnectionDefinition&gt;
        ///		&lt;DbConnectionDefinition&gt;
        ///			&lt;Name&gt;Sample MSSQL Northwind SQL Expres [rest of string was truncated]&quot;;.
        /// </summary>
        public static string DefaultConnectionDefinitionFile {
            get {
                return ResourceManager.GetString("DefaultConnectionDefinitionFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mini SQLQuery.
        /// </summary>
        public static string FriendlyAppTitle {
            get {
                return ResourceManager.GetString("FriendlyAppTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MiniSqlQuery.
        /// </summary>
        public static string ShortAppTitle {
            get {
                return ResourceManager.GetString("ShortAppTitle", resourceCulture);
            }
        }
    }
}
