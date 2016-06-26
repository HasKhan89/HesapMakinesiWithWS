﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TodoListWinApp.TodoListServiceRef {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Gorev", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Gorev : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdField;
        
        private System.DateTime CreatedDateField;
        
        private System.Nullable<System.DateTime> UpdatedDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TaskField;
        
        private bool IsCompletedField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=1)]
        public System.DateTime CreatedDate {
            get {
                return this.CreatedDateField;
            }
            set {
                if ((this.CreatedDateField.Equals(value) != true)) {
                    this.CreatedDateField = value;
                    this.RaisePropertyChanged("CreatedDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public System.Nullable<System.DateTime> UpdatedDate {
            get {
                return this.UpdatedDateField;
            }
            set {
                if ((this.UpdatedDateField.Equals(value) != true)) {
                    this.UpdatedDateField = value;
                    this.RaisePropertyChanged("UpdatedDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string Task {
            get {
                return this.TaskField;
            }
            set {
                if ((object.ReferenceEquals(this.TaskField, value) != true)) {
                    this.TaskField = value;
                    this.RaisePropertyChanged("Task");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public bool IsCompleted {
            get {
                return this.IsCompletedField;
            }
            set {
                if ((this.IsCompletedField.Equals(value) != true)) {
                    this.IsCompletedField = value;
                    this.RaisePropertyChanged("IsCompleted");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="IslemSonuc", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class IslemSonuc : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private bool SonucField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MesajField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public bool Sonuc {
            get {
                return this.SonucField;
            }
            set {
                if ((this.SonucField.Equals(value) != true)) {
                    this.SonucField = value;
                    this.RaisePropertyChanged("Sonuc");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Mesaj {
            get {
                return this.MesajField;
            }
            set {
                if ((object.ReferenceEquals(this.MesajField, value) != true)) {
                    this.MesajField = value;
                    this.RaisePropertyChanged("Mesaj");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TodoListServiceRef.TodoListServiceSoap")]
    public interface TodoListServiceSoap {
        
        // CODEGEN: Generating message contract since element name ListResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/List", ReplyAction="*")]
        TodoListWinApp.TodoListServiceRef.ListResponse List(TodoListWinApp.TodoListServiceRef.ListRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/List", ReplyAction="*")]
        System.Threading.Tasks.Task<TodoListWinApp.TodoListServiceRef.ListResponse> ListAsync(TodoListWinApp.TodoListServiceRef.ListRequest request);
        
        // CODEGEN: Generating message contract since element name gorevMetni from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        TodoListWinApp.TodoListServiceRef.AddResponse Add(TodoListWinApp.TodoListServiceRef.AddRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        System.Threading.Tasks.Task<TodoListWinApp.TodoListServiceRef.AddResponse> AddAsync(TodoListWinApp.TodoListServiceRef.AddRequest request);
        
        // CODEGEN: Generating message contract since element name gorev from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Update", ReplyAction="*")]
        TodoListWinApp.TodoListServiceRef.UpdateResponse Update(TodoListWinApp.TodoListServiceRef.UpdateRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Update", ReplyAction="*")]
        System.Threading.Tasks.Task<TodoListWinApp.TodoListServiceRef.UpdateResponse> UpdateAsync(TodoListWinApp.TodoListServiceRef.UpdateRequest request);
        
        // CODEGEN: Generating message contract since element name DeleteResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Delete", ReplyAction="*")]
        TodoListWinApp.TodoListServiceRef.DeleteResponse Delete(TodoListWinApp.TodoListServiceRef.DeleteRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Delete", ReplyAction="*")]
        System.Threading.Tasks.Task<TodoListWinApp.TodoListServiceRef.DeleteResponse> DeleteAsync(TodoListWinApp.TodoListServiceRef.DeleteRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="List", Namespace="http://tempuri.org/", Order=0)]
        public TodoListWinApp.TodoListServiceRef.ListRequestBody Body;
        
        public ListRequest() {
        }
        
        public ListRequest(TodoListWinApp.TodoListServiceRef.ListRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class ListRequestBody {
        
        public ListRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListResponse", Namespace="http://tempuri.org/", Order=0)]
        public TodoListWinApp.TodoListServiceRef.ListResponseBody Body;
        
        public ListResponse() {
        }
        
        public ListResponse(TodoListWinApp.TodoListServiceRef.ListResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ListResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public TodoListWinApp.TodoListServiceRef.Gorev[] ListResult;
        
        public ListResponseBody() {
        }
        
        public ListResponseBody(TodoListWinApp.TodoListServiceRef.Gorev[] ListResult) {
            this.ListResult = ListResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Add", Namespace="http://tempuri.org/", Order=0)]
        public TodoListWinApp.TodoListServiceRef.AddRequestBody Body;
        
        public AddRequest() {
        }
        
        public AddRequest(TodoListWinApp.TodoListServiceRef.AddRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AddRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string gorevMetni;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public bool tamamlandiMi;
        
        public AddRequestBody() {
        }
        
        public AddRequestBody(string gorevMetni, bool tamamlandiMi) {
            this.gorevMetni = gorevMetni;
            this.tamamlandiMi = tamamlandiMi;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddResponse", Namespace="http://tempuri.org/", Order=0)]
        public TodoListWinApp.TodoListServiceRef.AddResponseBody Body;
        
        public AddResponse() {
        }
        
        public AddResponse(TodoListWinApp.TodoListServiceRef.AddResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AddResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public TodoListWinApp.TodoListServiceRef.IslemSonuc AddResult;
        
        public AddResponseBody() {
        }
        
        public AddResponseBody(TodoListWinApp.TodoListServiceRef.IslemSonuc AddResult) {
            this.AddResult = AddResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Update", Namespace="http://tempuri.org/", Order=0)]
        public TodoListWinApp.TodoListServiceRef.UpdateRequestBody Body;
        
        public UpdateRequest() {
        }
        
        public UpdateRequest(TodoListWinApp.TodoListServiceRef.UpdateRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class UpdateRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public TodoListWinApp.TodoListServiceRef.Gorev gorev;
        
        public UpdateRequestBody() {
        }
        
        public UpdateRequestBody(TodoListWinApp.TodoListServiceRef.Gorev gorev) {
            this.gorev = gorev;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UpdateResponse", Namespace="http://tempuri.org/", Order=0)]
        public TodoListWinApp.TodoListServiceRef.UpdateResponseBody Body;
        
        public UpdateResponse() {
        }
        
        public UpdateResponse(TodoListWinApp.TodoListServiceRef.UpdateResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class UpdateResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public TodoListWinApp.TodoListServiceRef.IslemSonuc UpdateResult;
        
        public UpdateResponseBody() {
        }
        
        public UpdateResponseBody(TodoListWinApp.TodoListServiceRef.IslemSonuc UpdateResult) {
            this.UpdateResult = UpdateResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DeleteRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Delete", Namespace="http://tempuri.org/", Order=0)]
        public TodoListWinApp.TodoListServiceRef.DeleteRequestBody Body;
        
        public DeleteRequest() {
        }
        
        public DeleteRequest(TodoListWinApp.TodoListServiceRef.DeleteRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class DeleteRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int gorevId;
        
        public DeleteRequestBody() {
        }
        
        public DeleteRequestBody(int gorevId) {
            this.gorevId = gorevId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DeleteResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DeleteResponse", Namespace="http://tempuri.org/", Order=0)]
        public TodoListWinApp.TodoListServiceRef.DeleteResponseBody Body;
        
        public DeleteResponse() {
        }
        
        public DeleteResponse(TodoListWinApp.TodoListServiceRef.DeleteResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class DeleteResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public TodoListWinApp.TodoListServiceRef.IslemSonuc DeleteResult;
        
        public DeleteResponseBody() {
        }
        
        public DeleteResponseBody(TodoListWinApp.TodoListServiceRef.IslemSonuc DeleteResult) {
            this.DeleteResult = DeleteResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface TodoListServiceSoapChannel : TodoListWinApp.TodoListServiceRef.TodoListServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TodoListServiceSoapClient : System.ServiceModel.ClientBase<TodoListWinApp.TodoListServiceRef.TodoListServiceSoap>, TodoListWinApp.TodoListServiceRef.TodoListServiceSoap {
        
        public TodoListServiceSoapClient() {
        }
        
        public TodoListServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TodoListServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TodoListServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TodoListServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TodoListWinApp.TodoListServiceRef.ListResponse TodoListWinApp.TodoListServiceRef.TodoListServiceSoap.List(TodoListWinApp.TodoListServiceRef.ListRequest request) {
            return base.Channel.List(request);
        }
        
        public TodoListWinApp.TodoListServiceRef.Gorev[] List() {
            TodoListWinApp.TodoListServiceRef.ListRequest inValue = new TodoListWinApp.TodoListServiceRef.ListRequest();
            inValue.Body = new TodoListWinApp.TodoListServiceRef.ListRequestBody();
            TodoListWinApp.TodoListServiceRef.ListResponse retVal = ((TodoListWinApp.TodoListServiceRef.TodoListServiceSoap)(this)).List(inValue);
            return retVal.Body.ListResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TodoListWinApp.TodoListServiceRef.ListResponse> TodoListWinApp.TodoListServiceRef.TodoListServiceSoap.ListAsync(TodoListWinApp.TodoListServiceRef.ListRequest request) {
            return base.Channel.ListAsync(request);
        }
        
        public System.Threading.Tasks.Task<TodoListWinApp.TodoListServiceRef.ListResponse> ListAsync() {
            TodoListWinApp.TodoListServiceRef.ListRequest inValue = new TodoListWinApp.TodoListServiceRef.ListRequest();
            inValue.Body = new TodoListWinApp.TodoListServiceRef.ListRequestBody();
            return ((TodoListWinApp.TodoListServiceRef.TodoListServiceSoap)(this)).ListAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TodoListWinApp.TodoListServiceRef.AddResponse TodoListWinApp.TodoListServiceRef.TodoListServiceSoap.Add(TodoListWinApp.TodoListServiceRef.AddRequest request) {
            return base.Channel.Add(request);
        }
        
        public TodoListWinApp.TodoListServiceRef.IslemSonuc Add(string gorevMetni, bool tamamlandiMi) {
            TodoListWinApp.TodoListServiceRef.AddRequest inValue = new TodoListWinApp.TodoListServiceRef.AddRequest();
            inValue.Body = new TodoListWinApp.TodoListServiceRef.AddRequestBody();
            inValue.Body.gorevMetni = gorevMetni;
            inValue.Body.tamamlandiMi = tamamlandiMi;
            TodoListWinApp.TodoListServiceRef.AddResponse retVal = ((TodoListWinApp.TodoListServiceRef.TodoListServiceSoap)(this)).Add(inValue);
            return retVal.Body.AddResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TodoListWinApp.TodoListServiceRef.AddResponse> TodoListWinApp.TodoListServiceRef.TodoListServiceSoap.AddAsync(TodoListWinApp.TodoListServiceRef.AddRequest request) {
            return base.Channel.AddAsync(request);
        }
        
        public System.Threading.Tasks.Task<TodoListWinApp.TodoListServiceRef.AddResponse> AddAsync(string gorevMetni, bool tamamlandiMi) {
            TodoListWinApp.TodoListServiceRef.AddRequest inValue = new TodoListWinApp.TodoListServiceRef.AddRequest();
            inValue.Body = new TodoListWinApp.TodoListServiceRef.AddRequestBody();
            inValue.Body.gorevMetni = gorevMetni;
            inValue.Body.tamamlandiMi = tamamlandiMi;
            return ((TodoListWinApp.TodoListServiceRef.TodoListServiceSoap)(this)).AddAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TodoListWinApp.TodoListServiceRef.UpdateResponse TodoListWinApp.TodoListServiceRef.TodoListServiceSoap.Update(TodoListWinApp.TodoListServiceRef.UpdateRequest request) {
            return base.Channel.Update(request);
        }
        
        public TodoListWinApp.TodoListServiceRef.IslemSonuc Update(TodoListWinApp.TodoListServiceRef.Gorev gorev) {
            TodoListWinApp.TodoListServiceRef.UpdateRequest inValue = new TodoListWinApp.TodoListServiceRef.UpdateRequest();
            inValue.Body = new TodoListWinApp.TodoListServiceRef.UpdateRequestBody();
            inValue.Body.gorev = gorev;
            TodoListWinApp.TodoListServiceRef.UpdateResponse retVal = ((TodoListWinApp.TodoListServiceRef.TodoListServiceSoap)(this)).Update(inValue);
            return retVal.Body.UpdateResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TodoListWinApp.TodoListServiceRef.UpdateResponse> TodoListWinApp.TodoListServiceRef.TodoListServiceSoap.UpdateAsync(TodoListWinApp.TodoListServiceRef.UpdateRequest request) {
            return base.Channel.UpdateAsync(request);
        }
        
        public System.Threading.Tasks.Task<TodoListWinApp.TodoListServiceRef.UpdateResponse> UpdateAsync(TodoListWinApp.TodoListServiceRef.Gorev gorev) {
            TodoListWinApp.TodoListServiceRef.UpdateRequest inValue = new TodoListWinApp.TodoListServiceRef.UpdateRequest();
            inValue.Body = new TodoListWinApp.TodoListServiceRef.UpdateRequestBody();
            inValue.Body.gorev = gorev;
            return ((TodoListWinApp.TodoListServiceRef.TodoListServiceSoap)(this)).UpdateAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TodoListWinApp.TodoListServiceRef.DeleteResponse TodoListWinApp.TodoListServiceRef.TodoListServiceSoap.Delete(TodoListWinApp.TodoListServiceRef.DeleteRequest request) {
            return base.Channel.Delete(request);
        }
        
        public TodoListWinApp.TodoListServiceRef.IslemSonuc Delete(int gorevId) {
            TodoListWinApp.TodoListServiceRef.DeleteRequest inValue = new TodoListWinApp.TodoListServiceRef.DeleteRequest();
            inValue.Body = new TodoListWinApp.TodoListServiceRef.DeleteRequestBody();
            inValue.Body.gorevId = gorevId;
            TodoListWinApp.TodoListServiceRef.DeleteResponse retVal = ((TodoListWinApp.TodoListServiceRef.TodoListServiceSoap)(this)).Delete(inValue);
            return retVal.Body.DeleteResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TodoListWinApp.TodoListServiceRef.DeleteResponse> TodoListWinApp.TodoListServiceRef.TodoListServiceSoap.DeleteAsync(TodoListWinApp.TodoListServiceRef.DeleteRequest request) {
            return base.Channel.DeleteAsync(request);
        }
        
        public System.Threading.Tasks.Task<TodoListWinApp.TodoListServiceRef.DeleteResponse> DeleteAsync(int gorevId) {
            TodoListWinApp.TodoListServiceRef.DeleteRequest inValue = new TodoListWinApp.TodoListServiceRef.DeleteRequest();
            inValue.Body = new TodoListWinApp.TodoListServiceRef.DeleteRequestBody();
            inValue.Body.gorevId = gorevId;
            return ((TodoListWinApp.TodoListServiceRef.TodoListServiceSoap)(this)).DeleteAsync(inValue);
        }
    }
}
