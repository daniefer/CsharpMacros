﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CsharpMacros.Test.Macros.Range {
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
    internal class TestCases {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal TestCases() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CsharpMacros.Test.Macros.Range.TestCases", typeof(TestCases).Assembly);
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
        ///   Looks up a localized string similar to using System.
        ///namespace CsharpMacros.Test.Macros.Properties.TestData
        ///{
        ///    class _001_ObjectWithOwnMethods
        ///    {
        ///        public void DoSth()
        ///        {
        ///            //[|macros.range(10, 15)|]
        ///            //Console.WriteLine(&quot;Value ${index} from range [${from} - ${to}&quot;];
        ///        }
        ///    }
        ///}
        ///.
        /// </summary>
        internal static string _001_SimpleRange {
            get {
                return ResourceManager.GetString("_001_SimpleRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System.
        ///namespace CsharpMacros.Test.Macros.Properties.TestData
        ///{
        ///    class _001_ObjectWithOwnMethods
        ///    {
        ///        public void DoSth()
        ///        {
        ///            Console.WriteLine(&quot;Value 10 from range [10 - 15&quot;];
        ///            Console.WriteLine(&quot;Value 11 from range [10 - 15&quot;];
        ///            Console.WriteLine(&quot;Value 12 from range [10 - 15&quot;];
        ///            Console.WriteLine(&quot;Value 13 from range [10 - 15&quot;];
        ///            Console.WriteLine(&quot;Value 14 from range [10 - 15&quot;];
        ///            Console.WriteLine(&quot;Val [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string _001_SimpleRange_FIXED {
            get {
                return ResourceManager.GetString("_001_SimpleRange_FIXED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System.
        ///namespace CsharpMacros.Test.Macros.Properties.TestData
        ///{
        ///    class _001_ObjectWithOwnMethods
        ///    {
        ///        public void DoSth()
        ///        {
        ///            //[|macros.range(10, 20, 2)|]
        ///            //Console.WriteLine(&quot;Value ${index} from range [${from} - ${to} - ${step}&quot;];
        ///        }
        ///    }
        ///}
        ///.
        /// </summary>
        internal static string _002_SimpleRangeStep {
            get {
                return ResourceManager.GetString("_002_SimpleRangeStep", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System.
        ///namespace CsharpMacros.Test.Macros.Properties.TestData
        ///{
        ///    class _001_ObjectWithOwnMethods
        ///    {
        ///        public void DoSth()
        ///        {
        ///            Console.WriteLine(&quot;Value 10 from range [10 - 20 - 2&quot;];
        ///            Console.WriteLine(&quot;Value 12 from range [10 - 20 - 2&quot;];
        ///            Console.WriteLine(&quot;Value 14 from range [10 - 20 - 2&quot;];
        ///            Console.WriteLine(&quot;Value 16 from range [10 - 20 - 2&quot;];
        ///            Console.WriteLine(&quot;Value 18 from range [10 - 20 - 2&quot;];
        ///            Co [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string _002_SimpleRangeStep_FIXED {
            get {
                return ResourceManager.GetString("_002_SimpleRangeStep_FIXED", resourceCulture);
            }
        }
    }
}
