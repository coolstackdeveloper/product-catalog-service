﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProductCatalogService.Application {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ProductCatalogService.Application.Resource", typeof(Resource).Assembly);
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
        ///   Looks up a localized string similar to Invalid command argument.
        /// </summary>
        internal static string CommandArgumentIsInvalid {
            get {
                return ResourceManager.GetString("CommandArgumentIsInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to create product.
        /// </summary>
        internal static string ProductCouldNotBeCreated {
            get {
                return ResourceManager.GetString("ProductCouldNotBeCreated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to delete product.
        /// </summary>
        internal static string ProductCouldNotBeDeleted {
            get {
                return ResourceManager.GetString("ProductCouldNotBeDeleted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to get product.
        /// </summary>
        internal static string ProductCouldNotBeRetrieved {
            get {
                return ResourceManager.GetString("ProductCouldNotBeRetrieved", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to update product.
        /// </summary>
        internal static string ProductCouldNotBeUpdated {
            get {
                return ResourceManager.GetString("ProductCouldNotBeUpdated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid product list provided.
        /// </summary>
        internal static string ProductListIsInvalid {
            get {
                return ResourceManager.GetString("ProductListIsInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to create product option.
        /// </summary>
        internal static string ProductOptionCouldNotBeCreated {
            get {
                return ResourceManager.GetString("ProductOptionCouldNotBeCreated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to delete product option.
        /// </summary>
        internal static string ProductOptionCouldNotBeDeleted {
            get {
                return ResourceManager.GetString("ProductOptionCouldNotBeDeleted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to retrieve product option(s).
        /// </summary>
        internal static string ProductOptionCouldNotBeRetrieved {
            get {
                return ResourceManager.GetString("ProductOptionCouldNotBeRetrieved", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to update product option.
        /// </summary>
        internal static string ProductOptionCouldNotBeUpdated {
            get {
                return ResourceManager.GetString("ProductOptionCouldNotBeUpdated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid product options provided.
        /// </summary>
        internal static string ProductOptionListIsInvalid {
            get {
                return ResourceManager.GetString("ProductOptionListIsInvalid", resourceCulture);
            }
        }
    }
}