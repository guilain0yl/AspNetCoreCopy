﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.AspNetCore.Components.Analyzers {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
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
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.AspNetCore.Components.Analyzers.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   重写当前线程的 CurrentUICulture 属性
        ///   重写当前线程的 CurrentUICulture 属性。
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
        ///   查找类似 Component parameters with CaptureUnmatchedValues must be a correct type. 的本地化字符串。
        /// </summary>
        internal static string ComponentParameterCaptureUnmatchedValuesHasWrongType_Description {
            get {
                return ResourceManager.GetString("ComponentParameterCaptureUnmatchedValuesHasWrongType_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Component parameter &apos;{0}&apos; defines CaptureUnmatchedValues but has an unsupported type &apos;{1}&apos;. Use a type assignable from &apos;{2}&apos;. 的本地化字符串。
        /// </summary>
        internal static string ComponentParameterCaptureUnmatchedValuesHasWrongType_Format {
            get {
                return ResourceManager.GetString("ComponentParameterCaptureUnmatchedValuesHasWrongType_Format", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Component parameter with CaptureUnmatchedValues has the wrong type 的本地化字符串。
        /// </summary>
        internal static string ComponentParameterCaptureUnmatchedValuesHasWrongType_Title {
            get {
                return ResourceManager.GetString("ComponentParameterCaptureUnmatchedValuesHasWrongType_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Components may only define a single parameter with CaptureUnmatchedValues. 的本地化字符串。
        /// </summary>
        internal static string ComponentParameterCaptureUnmatchedValuesMustBeUnique_Description {
            get {
                return ResourceManager.GetString("ComponentParameterCaptureUnmatchedValuesMustBeUnique_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Component type &apos;{0}&apos; defines properties multiple parameters with CaptureUnmatchedValues. Properties: {1}{2} 的本地化字符串。
        /// </summary>
        internal static string ComponentParameterCaptureUnmatchedValuesMustBeUnique_Format {
            get {
                return ResourceManager.GetString("ComponentParameterCaptureUnmatchedValuesMustBeUnique_Format", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Component has multiple CaptureUnmatchedValues parameters 的本地化字符串。
        /// </summary>
        internal static string ComponentParameterCaptureUnmatchedValuesMustBeUnique_Title {
            get {
                return ResourceManager.GetString("ComponentParameterCaptureUnmatchedValuesMustBeUnique_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Component parameters should have public setters. 的本地化字符串。
        /// </summary>
        internal static string ComponentParameterSettersShouldBePublic_Description {
            get {
                return ResourceManager.GetString("ComponentParameterSettersShouldBePublic_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Component parameter &apos;{0}&apos; should have a public setter. 的本地化字符串。
        /// </summary>
        internal static string ComponentParameterSettersShouldBePublic_Format {
            get {
                return ResourceManager.GetString("ComponentParameterSettersShouldBePublic_Format", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Component parameter should have public setters. 的本地化字符串。
        /// </summary>
        internal static string ComponentParameterSettersShouldBePublic_Title {
            get {
                return ResourceManager.GetString("ComponentParameterSettersShouldBePublic_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Component parameter &apos;{0}&apos; should be public. 的本地化字符串。
        /// </summary>
        internal static string ComponentParameterShouldBePublic_Format {
            get {
                return ResourceManager.GetString("ComponentParameterShouldBePublic_Format", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Component parameter should be public. 的本地化字符串。
        /// </summary>
        internal static string ComponentParameterShouldBePublic_Title {
            get {
                return ResourceManager.GetString("ComponentParameterShouldBePublic_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Component parameters should not be set outside of their declared component. Doing so may result in unexpected behavior at runtime. 的本地化字符串。
        /// </summary>
        internal static string ComponentParameterShouldNotBeSetOutsideOfTheirDeclaredComponent_Description {
            get {
                return ResourceManager.GetString("ComponentParameterShouldNotBeSetOutsideOfTheirDeclaredComponent_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Component parameter &apos;{0}&apos; should not be set outside of its component. 的本地化字符串。
        /// </summary>
        internal static string ComponentParameterShouldNotBeSetOutsideOfTheirDeclaredComponent_Format {
            get {
                return ResourceManager.GetString("ComponentParameterShouldNotBeSetOutsideOfTheirDeclaredComponent_Format", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Component parameter should not be set outside of its component. 的本地化字符串。
        /// </summary>
        internal static string ComponentParameterShouldNotBeSetOutsideOfTheirDeclaredComponent_Title {
            get {
                return ResourceManager.GetString("ComponentParameterShouldNotBeSetOutsideOfTheirDeclaredComponent_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Component parameters should be public. 的本地化字符串。
        /// </summary>
        internal static string ComponentParametersShouldBePublic_Description {
            get {
                return ResourceManager.GetString("ComponentParametersShouldBePublic_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Make component parameters public. 的本地化字符串。
        /// </summary>
        internal static string ComponentParametersShouldBePublic_FixTitle {
            get {
                return ResourceManager.GetString("ComponentParametersShouldBePublic_FixTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The types in &apos;Microsoft.AspNetCore.Components.RenderTree&apos; are not recommended for use outside of the Blazor framework. These  type definitions will change in future releases. 的本地化字符串。
        /// </summary>
        internal static string DoNotUseRenderTreeTypes_Description {
            get {
                return ResourceManager.GetString("DoNotUseRenderTreeTypes_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The type or member {0} is is not recommended for use outside of the Blazor frameworks. Types defined in &apos;Microsoft.AspNetCore.Components.RenderTree&apos; will change in future releases. 的本地化字符串。
        /// </summary>
        internal static string DoNotUseRenderTreeTypes_Format {
            get {
                return ResourceManager.GetString("DoNotUseRenderTreeTypes_Format", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Do not use RenderTree types 的本地化字符串。
        /// </summary>
        internal static string DoNotUseRenderTreeTypes_Title {
            get {
                return ResourceManager.GetString("DoNotUseRenderTreeTypes_Title", resourceCulture);
            }
        }
    }
}
