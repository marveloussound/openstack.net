﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OpenStackNetTests.Unit.Simulator.IdentityService {
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
    internal class IdentityServiceResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal IdentityServiceResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("OpenStackNetTests.Unit.Simulator.IdentityService.IdentityServiceResources", typeof(IdentityServiceResources).Assembly);
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
        ///   Looks up a localized string similar to {
        ///  &quot;access&quot;: {
        ///    &quot;token&quot;: {
        ///      &quot;issued_at&quot;: &quot;{issued_at}&quot;,
        ///      &quot;expires&quot;: &quot;{expires}&quot;,
        ///      &quot;id&quot;: &quot;{tokenId}&quot;,
        ///      &quot;tenant&quot;: {
        ///        &quot;description&quot;: &quot;Auto created account&quot;,
        ///        &quot;enabled&quot;: true,
        ///        &quot;id&quot;: &quot;{tenantId}&quot;,
        ///        &quot;name&quot;: &quot;{tenantName}&quot;
        ///      }
        ///    },
        ///    &quot;serviceCatalog&quot;: [
        ///      {
        ///        &quot;endpoints&quot;: [
        ///          {
        ///            &quot;adminURL&quot;: &quot;http://10.100.0.222:8774/v2/c6aa8049133644d288a6cfc9ae21d55d&quot;,
        ///            &quot;region&quot;: &quot;RegionOne&quot;,
        ///            &quot;intern [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string AuthenticateResponseTemplate {
            get {
                return ResourceManager.GetString("AuthenticateResponseTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///  &quot;access&quot;: {
        ///    &quot;token&quot;: {
        ///      &quot;issued_at&quot;: &quot;{issued_at}&quot;,
        ///      &quot;expires&quot;: &quot;{expires}&quot;,
        ///      &quot;id&quot;: &quot;{tokenId}&quot;
        ///    },
        ///    &quot;serviceCatalog&quot;: [],
        ///    &quot;user&quot;: {
        ///      &quot;username&quot;: &quot;{username}&quot;,
        ///      &quot;roles_links&quot;: [],
        ///      &quot;id&quot;: &quot;{userId}&quot;,
        ///      &quot;roles&quot;: [],
        ///      &quot;name&quot;: &quot;{userFullName}&quot;
        ///    },
        ///    &quot;metadata&quot;: {
        ///      &quot;is_admin&quot;: 0,
        ///      &quot;roles&quot;: []
        ///    }
        ///  }
        ///}
        ///.
        /// </summary>
        internal static string AuthenticateWithoutTenantResponseTemplate {
            get {
                return ResourceManager.GetString("AuthenticateWithoutTenantResponseTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///  &quot;versions&quot;: {
        ///    &quot;values&quot;: [
        ///      {
        ///        &quot;status&quot;: &quot;stable&quot;,
        ///        &quot;updated&quot;: &quot;2013-03-06T00:00:00Z&quot;,
        ///        &quot;media-types&quot;: [
        ///          {
        ///            &quot;base&quot;: &quot;application/json&quot;,
        ///            &quot;type&quot;: &quot;application/vnd.openstack.identity-v3+json&quot;
        ///          },
        ///          {
        ///            &quot;base&quot;: &quot;application/xml&quot;,
        ///            &quot;type&quot;: &quot;application/vnd.openstack.identity-v3+xml&quot;
        ///          }
        ///        ],
        ///        &quot;id&quot;: &quot;v3.0&quot;,
        ///        &quot;links&quot;: [
        ///          {
        ///            &quot;href&quot;: &quot;http://localh [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ListApiVersionsResponse {
            get {
                return ResourceManager.GetString("ListApiVersionsResponse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///  &quot;extensions&quot;: {
        ///    &quot;values&quot;: [
        ///      {
        ///        &quot;updated&quot;: &quot;2013-12-17T12:00:0-00:00&quot;,
        ///        &quot;name&quot;: &quot;OpenStack Federation APIs&quot;,
        ///        &quot;links&quot;: [
        ///          {
        ///            &quot;href&quot;: &quot;https://github.com/openstack/identity-api&quot;,
        ///            &quot;type&quot;: &quot;text/html&quot;,
        ///            &quot;rel&quot;: &quot;describedby&quot;
        ///          }
        ///        ],
        ///        &quot;namespace&quot;: &quot;http://docs.openstack.org/identity/api/ext/OS-FEDERATION/v1.0&quot;,
        ///        &quot;alias&quot;: &quot;OS-FEDERATION&quot;,
        ///        &quot;description&quot;: &quot;OpenStack Identity Providers Mec [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ListExtensionsResponse {
            get {
                return ResourceManager.GetString("ListExtensionsResponse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///  &quot;tenants&quot;: [
        ///    {
        ///      &quot;description&quot;: &quot;Auto created account&quot;,
        ///      &quot;enabled&quot;: true,
        ///      &quot;id&quot;: &quot;{tenantId}&quot;,
        ///      &quot;name&quot;: &quot;{tenantName}&quot;
        ///    }
        ///  ],
        ///  &quot;tenants_links&quot;: []
        ///}
        ///
        ///.
        /// </summary>
        internal static string ListTenantsResponseTemplate {
            get {
                return ResourceManager.GetString("ListTenantsResponseTemplate", resourceCulture);
            }
        }
    }
}
