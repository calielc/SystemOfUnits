﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 15.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace SystemOfUnitsGenerator.GeneratorsCurrency.Templates
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Users\calie\code\SystemOfUnits\src\SystemOfUnitsGenerator\GeneratorsCurrency\Templates\CodeClassTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class CodeClassTemplate : CodeClassTemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            
            #line 6 "C:\Users\calie\code\SystemOfUnits\src\SystemOfUnitsGenerator\GeneratorsCurrency\Templates\CodeClassTemplate.tt"
 foreach (var usingNamespace in UsingNamespaces) { 
            
            #line default
            #line hidden
            this.Write("using ");
            
            #line 7 "C:\Users\calie\code\SystemOfUnits\src\SystemOfUnitsGenerator\GeneratorsCurrency\Templates\CodeClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(usingNamespace.Name));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 8 "C:\Users\calie\code\SystemOfUnits\src\SystemOfUnitsGenerator\GeneratorsCurrency\Templates\CodeClassTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\nnamespace ");
            
            #line 10 "C:\Users\calie\code\SystemOfUnits\src\SystemOfUnitsGenerator\GeneratorsCurrency\Templates\CodeClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write(" {\r\n");
            
            #line 11 "C:\Users\calie\code\SystemOfUnits\src\SystemOfUnitsGenerator\GeneratorsCurrency\Templates\CodeClassTemplate.tt"
 if (XmlDoc != null) { 
            
            #line default
            #line hidden
            this.Write("    /// <summary>\r\n");
            
            #line 13 "C:\Users\calie\code\SystemOfUnits\src\SystemOfUnitsGenerator\GeneratorsCurrency\Templates\CodeClassTemplate.tt"
 foreach (var line in XmlDoc.Summary) { 
            
            #line default
            #line hidden
            this.Write("    /// ");
            
            #line 14 "C:\Users\calie\code\SystemOfUnits\src\SystemOfUnitsGenerator\GeneratorsCurrency\Templates\CodeClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(line));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 15 "C:\Users\calie\code\SystemOfUnits\src\SystemOfUnitsGenerator\GeneratorsCurrency\Templates\CodeClassTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("    /// </summary>\r\n");
            
            #line 17 "C:\Users\calie\code\SystemOfUnits\src\SystemOfUnitsGenerator\GeneratorsCurrency\Templates\CodeClassTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("    [Serializable]\r\n    [JsonConverter(typeof(CurrencyJsonConverter ))]\r\n    [Deb" +
                    "uggerDisplay(\"");
            
            #line 20 "C:\Users\calie\code\SystemOfUnits\src\SystemOfUnitsGenerator\GeneratorsCurrency\Templates\CodeClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Symbol));
            
            #line default
            #line hidden
            this.Write(" {Value}\")]\r\n    public readonly partial struct ");
            
            #line 21 "C:\Users\calie\code\SystemOfUnits\src\SystemOfUnitsGenerator\GeneratorsCurrency\Templates\CodeClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" : ICurrency, IEquatable<");
            
            #line 21 "C:\Users\calie\code\SystemOfUnits\src\SystemOfUnitsGenerator\GeneratorsCurrency\Templates\CodeClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(">, IComparable<");
            
            #line 21 "C:\Users\calie\code\SystemOfUnits\src\SystemOfUnitsGenerator\GeneratorsCurrency\Templates\CodeClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write("> {\r\n        private readonly decimal _value;\r\n\r\n        public const string Symb" +
                    "ol = \"");
            
            #line 24 "C:\Users\calie\code\SystemOfUnits\src\SystemOfUnitsGenerator\GeneratorsCurrency\Templates\CodeClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Symbol));
            
            #line default
            #line hidden
            this.Write("\";\r\n\r\n        public ");
            
            #line 26 "C:\Users\calie\code\SystemOfUnits\src\SystemOfUnitsGenerator\GeneratorsCurrency\Templates\CodeClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write("(decimal value) {\r\n            _value = value;\r\n        }\r\n\r\n        public decim" +
                    "al Value => _value;\r\n\r\n        public ");
            
            #line 32 "C:\Users\calie\code\SystemOfUnits\src\SystemOfUnitsGenerator\GeneratorsCurrency\Templates\CodeClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" Ceiling() => new ");
            
            #line 32 "C:\Users\calie\code\SystemOfUnits\src\SystemOfUnitsGenerator\GeneratorsCurrency\Templates\CodeClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write("(Math.Ceiling(_value));\r\n\r\n        public ");
            
            #line 34 "C:\Users\calie\code\SystemOfUnits\src\SystemOfUnitsGenerator\GeneratorsCurrency\Templates\CodeClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" Round() => new ");
            
            #line 34 "C:\Users\calie\code\SystemOfUnits\src\SystemOfUnitsGenerator\GeneratorsCurrency\Templates\CodeClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write("(Math.Round(_value));\r\n        public ");
            
            #line 35 "C:\Users\calie\code\SystemOfUnits\src\SystemOfUnitsGenerator\GeneratorsCurrency\Templates\CodeClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" Round(int digits) => new ");
            
            #line 35 "C:\Users\calie\code\SystemOfUnits\src\SystemOfUnitsGenerator\GeneratorsCurrency\Templates\CodeClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write("(Math.Round(_value, digits));\r\n        public ");
            
            #line 36 "C:\Users\calie\code\SystemOfUnits\src\SystemOfUnitsGenerator\GeneratorsCurrency\Templates\CodeClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" Round(MidpointRounding mode) => new ");
            
            #line 36 "C:\Users\calie\code\SystemOfUnits\src\SystemOfUnitsGenerator\GeneratorsCurrency\Templates\CodeClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write("(Math.Round(_value, mode));\r\n\r\n        public ");
            
            #line 38 "C:\Users\calie\code\SystemOfUnits\src\SystemOfUnitsGenerator\GeneratorsCurrency\Templates\CodeClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" Floor() => new ");
            
            #line 38 "C:\Users\calie\code\SystemOfUnits\src\SystemOfUnitsGenerator\GeneratorsCurrency\Templates\CodeClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write("(Math.Floor(_value));\r\n\r\n        public ");
            
            #line 40 "C:\Users\calie\code\SystemOfUnits\src\SystemOfUnitsGenerator\GeneratorsCurrency\Templates\CodeClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" Truncate() => new ");
            
            #line 40 "C:\Users\calie\code\SystemOfUnits\src\SystemOfUnitsGenerator\GeneratorsCurrency\Templates\CodeClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write("(Math.Truncate(_value));\r\n\r\n        public ");
            
            #line 42 "C:\Users\calie\code\SystemOfUnits\src\SystemOfUnitsGenerator\GeneratorsCurrency\Templates\CodeClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" Abs() => new ");
            
            #line 42 "C:\Users\calie\code\SystemOfUnits\src\SystemOfUnitsGenerator\GeneratorsCurrency\Templates\CodeClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write("(Math.Abs(_value));\r\n\r\n        public bool Equals(");
            
            #line 44 "C:\Users\calie\code\SystemOfUnits\src\SystemOfUnitsGenerator\GeneratorsCurrency\Templates\CodeClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" other) => this._value == other._value;\r\n\r\n        public int CompareTo(");
            
            #line 46 "C:\Users\calie\code\SystemOfUnits\src\SystemOfUnitsGenerator\GeneratorsCurrency\Templates\CodeClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" other) => this._value.CompareTo(other._value);\r\n\r\n        public int CompareTo(o" +
                    "bject obj) {\r\n            switch (obj) {\r\n                case null:\r\n          " +
                    "          return 1;\r\n\r\n                case ");
            
            #line 53 "C:\Users\calie\code\SystemOfUnits\src\SystemOfUnitsGenerator\GeneratorsCurrency\Templates\CodeClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" other:\r\n                    return CompareTo(other);\r\n\r\n                default:" +
                    "\r\n                    throw new ArgumentException($\"Object must be of type {name" +
                    "of(");
            
            #line 57 "C:\Users\calie\code\SystemOfUnits\src\SystemOfUnitsGenerator\GeneratorsCurrency\Templates\CodeClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(")}\");\r\n            }\r\n        }\r\n\r\n        public string ToString(string format, " +
                    "IFormatProvider formatProvider)\r\n            => string.Format(format ?? \"");
            
            #line 62 "C:\Users\calie\code\SystemOfUnits\src\SystemOfUnitsGenerator\GeneratorsCurrency\Templates\CodeClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Symbol));
            
            #line default
            #line hidden
            this.Write(" {0}\", _value, formatProvider);\r\n\r\n        public override bool Equals(object obj" +
                    ") {\r\n            if (obj is null) {\r\n                return false;\r\n            " +
                    "}\r\n            return obj is ");
            
            #line 68 "C:\Users\calie\code\SystemOfUnits\src\SystemOfUnitsGenerator\GeneratorsCurrency\Templates\CodeClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" other && Equals(other);\r\n        }\r\n\r\n        public override int GetHashCode() " +
                    "=> _value.GetHashCode();\r\n\r\n        public override string ToString() => $\"");
            
            #line 73 "C:\Users\calie\code\SystemOfUnits\src\SystemOfUnitsGenerator\GeneratorsCurrency\Templates\CodeClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Symbol));
            
            #line default
            #line hidden
            this.Write(" {_value:#,##0.00}\";\r\n\r\n        string ICurrency.Symbol => Symbol;\r\n\r\n        pub" +
                    "lic static bool operator ==(");
            
            #line 77 "C:\Users\calie\code\SystemOfUnits\src\SystemOfUnitsGenerator\GeneratorsCurrency\Templates\CodeClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" self, ");
            
            #line 77 "C:\Users\calie\code\SystemOfUnits\src\SystemOfUnitsGenerator\GeneratorsCurrency\Templates\CodeClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" other) => self.Equals(other);\r\n        public static bool operator !=(");
            
            #line 78 "C:\Users\calie\code\SystemOfUnits\src\SystemOfUnitsGenerator\GeneratorsCurrency\Templates\CodeClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" self, ");
            
            #line 78 "C:\Users\calie\code\SystemOfUnits\src\SystemOfUnitsGenerator\GeneratorsCurrency\Templates\CodeClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" other) => !self.Equals(other);\r\n\r\n        public static bool operator <(");
            
            #line 80 "C:\Users\calie\code\SystemOfUnits\src\SystemOfUnitsGenerator\GeneratorsCurrency\Templates\CodeClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" self, ");
            
            #line 80 "C:\Users\calie\code\SystemOfUnits\src\SystemOfUnitsGenerator\GeneratorsCurrency\Templates\CodeClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" other) => self.CompareTo(other) < 0;\r\n        public static bool operator >(");
            
            #line 81 "C:\Users\calie\code\SystemOfUnits\src\SystemOfUnitsGenerator\GeneratorsCurrency\Templates\CodeClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" self, ");
            
            #line 81 "C:\Users\calie\code\SystemOfUnits\src\SystemOfUnitsGenerator\GeneratorsCurrency\Templates\CodeClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" other) => self.CompareTo(other) > 0;\r\n        public static bool operator <=(");
            
            #line 82 "C:\Users\calie\code\SystemOfUnits\src\SystemOfUnitsGenerator\GeneratorsCurrency\Templates\CodeClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" self, ");
            
            #line 82 "C:\Users\calie\code\SystemOfUnits\src\SystemOfUnitsGenerator\GeneratorsCurrency\Templates\CodeClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" other) => self.CompareTo(other) <= 0;\r\n        public static bool operator >=(");
            
            #line 83 "C:\Users\calie\code\SystemOfUnits\src\SystemOfUnitsGenerator\GeneratorsCurrency\Templates\CodeClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" self, ");
            
            #line 83 "C:\Users\calie\code\SystemOfUnits\src\SystemOfUnitsGenerator\GeneratorsCurrency\Templates\CodeClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" other) => self.CompareTo(other) >= 0;\r\n\r\n        public static ");
            
            #line 85 "C:\Users\calie\code\SystemOfUnits\src\SystemOfUnitsGenerator\GeneratorsCurrency\Templates\CodeClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" operator +(");
            
            #line 85 "C:\Users\calie\code\SystemOfUnits\src\SystemOfUnitsGenerator\GeneratorsCurrency\Templates\CodeClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" self, ");
            
            #line 85 "C:\Users\calie\code\SystemOfUnits\src\SystemOfUnitsGenerator\GeneratorsCurrency\Templates\CodeClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" other) => new ");
            
            #line 85 "C:\Users\calie\code\SystemOfUnits\src\SystemOfUnitsGenerator\GeneratorsCurrency\Templates\CodeClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write("(self._value + other._value);\r\n        public static ");
            
            #line 86 "C:\Users\calie\code\SystemOfUnits\src\SystemOfUnitsGenerator\GeneratorsCurrency\Templates\CodeClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" operator -(");
            
            #line 86 "C:\Users\calie\code\SystemOfUnits\src\SystemOfUnitsGenerator\GeneratorsCurrency\Templates\CodeClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" self, ");
            
            #line 86 "C:\Users\calie\code\SystemOfUnits\src\SystemOfUnitsGenerator\GeneratorsCurrency\Templates\CodeClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" other) => new ");
            
            #line 86 "C:\Users\calie\code\SystemOfUnits\src\SystemOfUnitsGenerator\GeneratorsCurrency\Templates\CodeClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write("(self._value - other._value);\r\n\r\n        public static ");
            
            #line 88 "C:\Users\calie\code\SystemOfUnits\src\SystemOfUnitsGenerator\GeneratorsCurrency\Templates\CodeClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" operator *(");
            
            #line 88 "C:\Users\calie\code\SystemOfUnits\src\SystemOfUnitsGenerator\GeneratorsCurrency\Templates\CodeClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" self, decimal other) => new ");
            
            #line 88 "C:\Users\calie\code\SystemOfUnits\src\SystemOfUnitsGenerator\GeneratorsCurrency\Templates\CodeClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write("(self._value * other);\r\n        public static ");
            
            #line 89 "C:\Users\calie\code\SystemOfUnits\src\SystemOfUnitsGenerator\GeneratorsCurrency\Templates\CodeClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" operator *(decimal self, ");
            
            #line 89 "C:\Users\calie\code\SystemOfUnits\src\SystemOfUnitsGenerator\GeneratorsCurrency\Templates\CodeClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" other) => new ");
            
            #line 89 "C:\Users\calie\code\SystemOfUnits\src\SystemOfUnitsGenerator\GeneratorsCurrency\Templates\CodeClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write("(self * other._value);\r\n\r\n        public static ");
            
            #line 91 "C:\Users\calie\code\SystemOfUnits\src\SystemOfUnitsGenerator\GeneratorsCurrency\Templates\CodeClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" operator /(");
            
            #line 91 "C:\Users\calie\code\SystemOfUnits\src\SystemOfUnitsGenerator\GeneratorsCurrency\Templates\CodeClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" self, decimal other) => new ");
            
            #line 91 "C:\Users\calie\code\SystemOfUnits\src\SystemOfUnitsGenerator\GeneratorsCurrency\Templates\CodeClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write("(self._value / other);\r\n\r\n        public static explicit operator decimal(");
            
            #line 93 "C:\Users\calie\code\SystemOfUnits\src\SystemOfUnitsGenerator\GeneratorsCurrency\Templates\CodeClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" self) => self._value;\r\n        public static explicit operator ");
            
            #line 94 "C:\Users\calie\code\SystemOfUnits\src\SystemOfUnitsGenerator\GeneratorsCurrency\Templates\CodeClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write("(decimal self) => new ");
            
            #line 94 "C:\Users\calie\code\SystemOfUnits\src\SystemOfUnitsGenerator\GeneratorsCurrency\Templates\CodeClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write("(self);\r\n    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public class CodeClassTemplateBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
