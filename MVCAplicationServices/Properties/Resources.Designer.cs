﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCAplicationServices.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MVCAplicationServices.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Не удалось найти радиомаяк по идентификатору {0}..
        /// </summary>
        internal static string BeaconNotFoundMessage {
            get {
                return ResourceManager.GetString("BeaconNotFoundMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Сообщение от радиомаяка должно состоять из 4 частей, разделенных &quot;;
        ///&quot;. Передана строка: {0}..
        /// </summary>
        internal static string EventShouldContainFourParts {
            get {
                return ResourceManager.GetString("EventShouldContainFourParts", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Неправильный идентификатор радиомаяка {0}..
        /// </summary>
        internal static string InvalidBeaconId {
            get {
                return ResourceManager.GetString("InvalidBeaconId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Неправильное значение широты {0}..
        /// </summary>
        internal static string InvalidLatitudeId {
            get {
                return ResourceManager.GetString("InvalidLatitudeId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Неправильное значение долготы {0}..
        /// </summary>
        internal static string InvalidLongtitudeId {
            get {
                return ResourceManager.GetString("InvalidLongtitudeId", resourceCulture);
            }
        }
    }
}
