﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlogManagermentTool.BlogManagermentServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CreateObjectInfo", Namespace="http://schemas.datacontract.org/2004/07/BlogManagermentService")]
    [System.SerializableAttribute()]
    public partial class CreateObjectInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ErrorCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short ObjectIdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ErrorCode {
            get {
                return this.ErrorCodeField;
            }
            set {
                if ((this.ErrorCodeField.Equals(value) != true)) {
                    this.ErrorCodeField = value;
                    this.RaisePropertyChanged("ErrorCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short ObjectId {
            get {
                return this.ObjectIdField;
            }
            set {
                if ((this.ObjectIdField.Equals(value) != true)) {
                    this.ObjectIdField = value;
                    this.RaisePropertyChanged("ObjectId");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="OverviewInfo", Namespace="http://schemas.datacontract.org/2004/07/BlogManagermentService")]
    [System.SerializableAttribute()]
    public partial class OverviewInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DisplayNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short KeyField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DisplayName {
            get {
                return this.DisplayNameField;
            }
            set {
                if ((object.ReferenceEquals(this.DisplayNameField, value) != true)) {
                    this.DisplayNameField = value;
                    this.RaisePropertyChanged("DisplayName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short Key {
            get {
                return this.KeyField;
            }
            set {
                if ((this.KeyField.Equals(value) != true)) {
                    this.KeyField = value;
                    this.RaisePropertyChanged("Key");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BlogManagermentServiceReference.IBlogAdminMangermentService")]
    public interface IBlogAdminMangermentService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBlogAdminMangermentService/DoWork", ReplyAction="http://tempuri.org/IBlogAdminMangermentService/DoWorkResponse")]
        void DoWork();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBlogAdminMangermentService/DoWork", ReplyAction="http://tempuri.org/IBlogAdminMangermentService/DoWorkResponse")]
        System.Threading.Tasks.Task DoWorkAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBlogAdminMangermentService/CreateNewCategory", ReplyAction="http://tempuri.org/IBlogAdminMangermentService/CreateNewCategoryResponse")]
        BlogManagermentTool.BlogManagermentServiceReference.CreateObjectInfo CreateNewCategory();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBlogAdminMangermentService/CreateNewCategory", ReplyAction="http://tempuri.org/IBlogAdminMangermentService/CreateNewCategoryResponse")]
        System.Threading.Tasks.Task<BlogManagermentTool.BlogManagermentServiceReference.CreateObjectInfo> CreateNewCategoryAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBlogAdminMangermentService/NumberCategories", ReplyAction="http://tempuri.org/IBlogAdminMangermentService/NumberCategoriesResponse")]
        int NumberCategories();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBlogAdminMangermentService/NumberCategories", ReplyAction="http://tempuri.org/IBlogAdminMangermentService/NumberCategoriesResponse")]
        System.Threading.Tasks.Task<int> NumberCategoriesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBlogAdminMangermentService/GetCategorybyIndex", ReplyAction="http://tempuri.org/IBlogAdminMangermentService/GetCategorybyIndexResponse")]
        BlogManagermentTool.BlogManagermentServiceReference.OverviewInfo GetCategorybyIndex(int index);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBlogAdminMangermentService/GetCategorybyIndex", ReplyAction="http://tempuri.org/IBlogAdminMangermentService/GetCategorybyIndexResponse")]
        System.Threading.Tasks.Task<BlogManagermentTool.BlogManagermentServiceReference.OverviewInfo> GetCategorybyIndexAsync(int index);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBlogAdminMangermentServiceChannel : BlogManagermentTool.BlogManagermentServiceReference.IBlogAdminMangermentService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BlogAdminMangermentServiceClient : System.ServiceModel.ClientBase<BlogManagermentTool.BlogManagermentServiceReference.IBlogAdminMangermentService>, BlogManagermentTool.BlogManagermentServiceReference.IBlogAdminMangermentService {
        
        public BlogAdminMangermentServiceClient() {
        }
        
        public BlogAdminMangermentServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BlogAdminMangermentServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BlogAdminMangermentServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BlogAdminMangermentServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void DoWork() {
            base.Channel.DoWork();
        }
        
        public System.Threading.Tasks.Task DoWorkAsync() {
            return base.Channel.DoWorkAsync();
        }
        
        public BlogManagermentTool.BlogManagermentServiceReference.CreateObjectInfo CreateNewCategory() {
            return base.Channel.CreateNewCategory();
        }
        
        public System.Threading.Tasks.Task<BlogManagermentTool.BlogManagermentServiceReference.CreateObjectInfo> CreateNewCategoryAsync() {
            return base.Channel.CreateNewCategoryAsync();
        }
        
        public int NumberCategories() {
            return base.Channel.NumberCategories();
        }
        
        public System.Threading.Tasks.Task<int> NumberCategoriesAsync() {
            return base.Channel.NumberCategoriesAsync();
        }
        
        public BlogManagermentTool.BlogManagermentServiceReference.OverviewInfo GetCategorybyIndex(int index) {
            return base.Channel.GetCategorybyIndex(index);
        }
        
        public System.Threading.Tasks.Task<BlogManagermentTool.BlogManagermentServiceReference.OverviewInfo> GetCategorybyIndexAsync(int index) {
            return base.Channel.GetCategorybyIndexAsync(index);
        }
    }
}