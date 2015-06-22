﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Geodesy.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Geodesy.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to A coordinate array must have exactly two elements..
        /// </summary>
        internal static string COORD_ARRAY_MUST_BE_2DIM {
            get {
                return ResourceManager.GetString("COORD_ARRAY_MUST_BE_2DIM", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A geodetic path must have at least two points..
        /// </summary>
        internal static string GEODETIC_PATH_MIN_2 {
            get {
                return ResourceManager.GetString("GEODETIC_PATH_MIN_2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The UTM grids 32X,34X and 36X are not assigned..
        /// </summary>
        internal static string GRID_EXCEPTION {
            get {
                return ResourceManager.GetString("GRID_EXCEPTION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid UTMBand specified..
        /// </summary>
        internal static string INVALID_BAND {
            get {
                return ResourceManager.GetString("INVALID_BAND", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The UTM projection ownly allows latitudes from -80° to +84°.
        /// </summary>
        internal static string INVALID_LATITUDE {
            get {
                return ResourceManager.GetString("INVALID_LATITUDE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The ordinal number of the Grid is invalid..
        /// </summary>
        internal static string INVALID_ORDINAL {
            get {
                return ResourceManager.GetString("INVALID_ORDINAL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid UTM Zone specified.
        /// </summary>
        internal static string INVALID_ZONE {
            get {
                return ResourceManager.GetString("INVALID_ZONE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The mesh size must be at least 1 meter..
        /// </summary>
        internal static string MESHSIZE_MIN_VIOLATION {
            get {
                return ResourceManager.GetString("MESHSIZE_MIN_VIOLATION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The mesh size is to big, it doesn&apos;t divide all UTMGrids into multiple cells..
        /// </summary>
        internal static string MESHSIZE_TOO_BIG {
            get {
                return ResourceManager.GetString("MESHSIZE_TOO_BIG", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Minutes or seconds must have a value between 0 and 60..
        /// </summary>
        internal static string MINSEC_0_TO_60 {
            get {
                return ResourceManager.GetString("MINSEC_0_TO_60", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The coordinate must be an _UtmCoordinate..
        /// </summary>
        internal static string NO_UTM_COORDINATE {
            get {
                return ResourceManager.GetString("NO_UTM_COORDINATE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The euclidian coordinate does not belong to this projection..
        /// </summary>
        internal static string POINT_NOT_OWNED {
            get {
                return ResourceManager.GetString("POINT_NOT_OWNED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The euclidian coordinates do not belong to the same projection.
        /// </summary>
        internal static string POINT_NOT_SAME_PROJECTION {
            get {
                return ResourceManager.GetString("POINT_NOT_SAME_PROJECTION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The projection argument must not be null..
        /// </summary>
        internal static string PROJECTION_NULL {
            get {
                return ResourceManager.GetString("PROJECTION_NULL", resourceCulture);
            }
        }
    }
}
