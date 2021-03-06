/*
* sones GraphDB - Community Edition - http://www.sones.com
* Copyright (C) 2007-2011 sones GmbH
*
* This file is part of sones GraphDB Community Edition.
*
* sones GraphDB is free software: you can redistribute it and/or modify
* it under the terms of the GNU Affero General Public License as published by
* the Free Software Foundation, version 3 of the License.
* 
* sones GraphDB is distributed in the hope that it will be useful,
* but WITHOUT ANY WARRANTY; without even the implied warranty of
* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
* GNU Affero General Public License for more details.
*
* You should have received a copy of the GNU Affero General Public License
* along with sones GraphDB. If not, see <http://www.gnu.org/licenses/>.
* 
*/

namespace SchemaToClassesGenerator {
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SingleEdgeView))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HyperEdgeView))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://sones.com/QueryResultSchema.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://sones.com/QueryResultSchema.xsd", IsNullable=true)]
    public abstract partial class EdgeView {
        
        private string nameField;
        
        private Property[] propertiesField;
        
        /// <remarks/>
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public Property[] Properties {
            get {
                return this.propertiesField;
            }
            set {
                this.propertiesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://sones.com/QueryResultSchema.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://sones.com/QueryResultSchema.xsd", IsNullable=true)]
    public partial class Property {
        
        private string idField;
        
        private string typeField;
        
        private string valueField;
        
        /// <remarks/>
        public string ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public string Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://sones.com/QueryResultSchema.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://sones.com/QueryResultSchema.xsd", IsNullable=true)]
    public partial class VertexView {
        
        private Property[] propertiesField;
        
        private BinaryData[] binaryPropertiesField;
        
        private EdgeView[] edgesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public Property[] Properties {
            get {
                return this.propertiesField;
            }
            set {
                this.propertiesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("BinaryProperty", IsNullable=false)]
        public BinaryData[] BinaryProperties {
            get {
                return this.binaryPropertiesField;
            }
            set {
                this.binaryPropertiesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Edge", IsNullable=false)]
        public EdgeView[] Edges {
            get {
                return this.edgesField;
            }
            set {
                this.edgesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://sones.com/QueryResultSchema.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://sones.com/QueryResultSchema.xsd", IsNullable=true)]
    public partial class BinaryData {
        
        private string idField;
        
        private byte[] contentField;
        
        /// <remarks/>
        public string ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="hexBinary")]
        public byte[] Content {
            get {
                return this.contentField;
            }
            set {
                this.contentField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://sones.com/QueryResultSchema.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://sones.com/QueryResultSchema.xsd", IsNullable=true)]
    public partial class HyperEdgeView : EdgeView {
        
        private SingleEdgeView[] singleEdgeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SingleEdge")]
        public SingleEdgeView[] SingleEdge {
            get {
                return this.singleEdgeField;
            }
            set {
                this.singleEdgeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://sones.com/QueryResultSchema.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://sones.com/QueryResultSchema.xsd", IsNullable=true)]
    public partial class SingleEdgeView : EdgeView {
        
        private VertexView targetVertexField;
        
        /// <remarks/>
        public VertexView TargetVertex {
            get {
                return this.targetVertexField;
            }
            set {
                this.targetVertexField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://sones.com/QueryResultSchema.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://sones.com/QueryResultSchema.xsd", IsNullable=false)]
    public partial class Query {
        
        private string languageField;
        
        private string valueField;
        
        private string resultTypeField;
        
        private string errorField;
        
        private ulong durationField;
        
        private long verticesCountField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Language {
            get {
                return this.languageField;
            }
            set {
                this.languageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResultType {
            get {
                return this.resultTypeField;
            }
            set {
                this.resultTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Error {
            get {
                return this.errorField;
            }
            set {
                this.errorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong Duration {
            get {
                return this.durationField;
            }
            set {
                this.durationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public long VerticesCount {
            get {
                return this.verticesCountField;
            }
            set {
                this.verticesCountField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://sones.com/QueryResultSchema.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://sones.com/QueryResultSchema.xsd", IsNullable=false)]
    public partial class Name {
        
        private string name1Field;
        
        private bool isHyperEdgeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("Name")]
        public string Name1 {
            get {
                return this.name1Field;
            }
            set {
                this.name1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IsHyperEdge {
            get {
                return this.isHyperEdgeField;
            }
            set {
                this.isHyperEdgeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://sones.com/QueryResultSchema.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://sones.com/QueryResultSchema.xsd", IsNullable=false)]
    public partial class Result {
        
        private Query queryField;
        
        private VertexView[] vertexViewsField;
        
        private string versionField;
        
        /// <remarks/>
        public Query Query {
            get {
                return this.queryField;
            }
            set {
                this.queryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public VertexView[] VertexViews {
            get {
                return this.vertexViewsField;
            }
            set {
                this.vertexViewsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
    }
}
