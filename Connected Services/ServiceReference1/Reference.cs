﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication3.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="InsertUser", Namespace="http://schemas.datacontract.org/2004/07/WcfService3")]
    [System.SerializableAttribute()]
    public partial class InsertUser : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="gettestdata", Namespace="http://schemas.datacontract.org/2004/07/WcfService3")]
    [System.SerializableAttribute()]
    public partial class gettestdata : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Data.DataTable usertabField;
        
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
        public System.Data.DataTable usertab {
            get {
                return this.usertabField;
            }
            set {
                if ((object.ReferenceEquals(this.usertabField, value) != true)) {
                    this.usertabField = value;
                    this.RaisePropertyChanged("usertab");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="UpdateUser", Namespace="http://schemas.datacontract.org/2004/07/WcfService3")]
    [System.SerializableAttribute()]
    public partial class UpdateUser : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UIDField;
        
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
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UID {
            get {
                return this.UIDField;
            }
            set {
                if ((this.UIDField.Equals(value) != true)) {
                    this.UIDField = value;
                    this.RaisePropertyChanged("UID");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="DeleteUser", Namespace="http://schemas.datacontract.org/2004/07/WcfService3")]
    [System.SerializableAttribute()]
    public partial class DeleteUser : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UIDField;
        
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
        public int UID {
            get {
                return this.UIDField;
            }
            set {
                if ((this.UIDField.Equals(value) != true)) {
                    this.UIDField = value;
                    this.RaisePropertyChanged("UID");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Insert", ReplyAction="http://tempuri.org/IService1/InsertResponse")]
        string Insert(WebApplication3.ServiceReference1.InsertUser user);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IService1/Insert", ReplyAction="http://tempuri.org/IService1/InsertResponse")]
        System.IAsyncResult BeginInsert(WebApplication3.ServiceReference1.InsertUser user, System.AsyncCallback callback, object asyncState);
        
        string EndInsert(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetInfo", ReplyAction="http://tempuri.org/IService1/GetInfoResponse")]
        WebApplication3.ServiceReference1.gettestdata GetInfo();
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IService1/GetInfo", ReplyAction="http://tempuri.org/IService1/GetInfoResponse")]
        System.IAsyncResult BeginGetInfo(System.AsyncCallback callback, object asyncState);
        
        WebApplication3.ServiceReference1.gettestdata EndGetInfo(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Update", ReplyAction="http://tempuri.org/IService1/UpdateResponse")]
        string Update(WebApplication3.ServiceReference1.UpdateUser u);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IService1/Update", ReplyAction="http://tempuri.org/IService1/UpdateResponse")]
        System.IAsyncResult BeginUpdate(WebApplication3.ServiceReference1.UpdateUser u, System.AsyncCallback callback, object asyncState);
        
        string EndUpdate(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Delete", ReplyAction="http://tempuri.org/IService1/DeleteResponse")]
        string Delete(WebApplication3.ServiceReference1.DeleteUser d);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IService1/Delete", ReplyAction="http://tempuri.org/IService1/DeleteResponse")]
        System.IAsyncResult BeginDelete(WebApplication3.ServiceReference1.DeleteUser d, System.AsyncCallback callback, object asyncState);
        
        string EndDelete(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WebApplication3.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class InsertCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public InsertCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetInfoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetInfoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public WebApplication3.ServiceReference1.gettestdata Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((WebApplication3.ServiceReference1.gettestdata)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UpdateCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public UpdateCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DeleteCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public DeleteCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WebApplication3.ServiceReference1.IService1>, WebApplication3.ServiceReference1.IService1 {
        
        private BeginOperationDelegate onBeginInsertDelegate;
        
        private EndOperationDelegate onEndInsertDelegate;
        
        private System.Threading.SendOrPostCallback onInsertCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetInfoDelegate;
        
        private EndOperationDelegate onEndGetInfoDelegate;
        
        private System.Threading.SendOrPostCallback onGetInfoCompletedDelegate;
        
        private BeginOperationDelegate onBeginUpdateDelegate;
        
        private EndOperationDelegate onEndUpdateDelegate;
        
        private System.Threading.SendOrPostCallback onUpdateCompletedDelegate;
        
        private BeginOperationDelegate onBeginDeleteDelegate;
        
        private EndOperationDelegate onEndDeleteDelegate;
        
        private System.Threading.SendOrPostCallback onDeleteCompletedDelegate;
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public event System.EventHandler<InsertCompletedEventArgs> InsertCompleted;
        
        public event System.EventHandler<GetInfoCompletedEventArgs> GetInfoCompleted;
        
        public event System.EventHandler<UpdateCompletedEventArgs> UpdateCompleted;
        
        public event System.EventHandler<DeleteCompletedEventArgs> DeleteCompleted;
        
        public string Insert(WebApplication3.ServiceReference1.InsertUser user) {
            return base.Channel.Insert(user);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginInsert(WebApplication3.ServiceReference1.InsertUser user, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginInsert(user, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public string EndInsert(System.IAsyncResult result) {
            return base.Channel.EndInsert(result);
        }
        
        private System.IAsyncResult OnBeginInsert(object[] inValues, System.AsyncCallback callback, object asyncState) {
            WebApplication3.ServiceReference1.InsertUser user = ((WebApplication3.ServiceReference1.InsertUser)(inValues[0]));
            return this.BeginInsert(user, callback, asyncState);
        }
        
        private object[] OnEndInsert(System.IAsyncResult result) {
            string retVal = this.EndInsert(result);
            return new object[] {
                    retVal};
        }
        
        private void OnInsertCompleted(object state) {
            if ((this.InsertCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.InsertCompleted(this, new InsertCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void InsertAsync(WebApplication3.ServiceReference1.InsertUser user) {
            this.InsertAsync(user, null);
        }
        
        public void InsertAsync(WebApplication3.ServiceReference1.InsertUser user, object userState) {
            if ((this.onBeginInsertDelegate == null)) {
                this.onBeginInsertDelegate = new BeginOperationDelegate(this.OnBeginInsert);
            }
            if ((this.onEndInsertDelegate == null)) {
                this.onEndInsertDelegate = new EndOperationDelegate(this.OnEndInsert);
            }
            if ((this.onInsertCompletedDelegate == null)) {
                this.onInsertCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnInsertCompleted);
            }
            base.InvokeAsync(this.onBeginInsertDelegate, new object[] {
                        user}, this.onEndInsertDelegate, this.onInsertCompletedDelegate, userState);
        }
        
        public WebApplication3.ServiceReference1.gettestdata GetInfo() {
            return base.Channel.GetInfo();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetInfo(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetInfo(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public WebApplication3.ServiceReference1.gettestdata EndGetInfo(System.IAsyncResult result) {
            return base.Channel.EndGetInfo(result);
        }
        
        private System.IAsyncResult OnBeginGetInfo(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return this.BeginGetInfo(callback, asyncState);
        }
        
        private object[] OnEndGetInfo(System.IAsyncResult result) {
            WebApplication3.ServiceReference1.gettestdata retVal = this.EndGetInfo(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetInfoCompleted(object state) {
            if ((this.GetInfoCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetInfoCompleted(this, new GetInfoCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetInfoAsync() {
            this.GetInfoAsync(null);
        }
        
        public void GetInfoAsync(object userState) {
            if ((this.onBeginGetInfoDelegate == null)) {
                this.onBeginGetInfoDelegate = new BeginOperationDelegate(this.OnBeginGetInfo);
            }
            if ((this.onEndGetInfoDelegate == null)) {
                this.onEndGetInfoDelegate = new EndOperationDelegate(this.OnEndGetInfo);
            }
            if ((this.onGetInfoCompletedDelegate == null)) {
                this.onGetInfoCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetInfoCompleted);
            }
            base.InvokeAsync(this.onBeginGetInfoDelegate, null, this.onEndGetInfoDelegate, this.onGetInfoCompletedDelegate, userState);
        }
        
        public string Update(WebApplication3.ServiceReference1.UpdateUser u) {
            return base.Channel.Update(u);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginUpdate(WebApplication3.ServiceReference1.UpdateUser u, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginUpdate(u, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public string EndUpdate(System.IAsyncResult result) {
            return base.Channel.EndUpdate(result);
        }
        
        private System.IAsyncResult OnBeginUpdate(object[] inValues, System.AsyncCallback callback, object asyncState) {
            WebApplication3.ServiceReference1.UpdateUser u = ((WebApplication3.ServiceReference1.UpdateUser)(inValues[0]));
            return this.BeginUpdate(u, callback, asyncState);
        }
        
        private object[] OnEndUpdate(System.IAsyncResult result) {
            string retVal = this.EndUpdate(result);
            return new object[] {
                    retVal};
        }
        
        private void OnUpdateCompleted(object state) {
            if ((this.UpdateCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.UpdateCompleted(this, new UpdateCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void UpdateAsync(WebApplication3.ServiceReference1.UpdateUser u) {
            this.UpdateAsync(u, null);
        }
        
        public void UpdateAsync(WebApplication3.ServiceReference1.UpdateUser u, object userState) {
            if ((this.onBeginUpdateDelegate == null)) {
                this.onBeginUpdateDelegate = new BeginOperationDelegate(this.OnBeginUpdate);
            }
            if ((this.onEndUpdateDelegate == null)) {
                this.onEndUpdateDelegate = new EndOperationDelegate(this.OnEndUpdate);
            }
            if ((this.onUpdateCompletedDelegate == null)) {
                this.onUpdateCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnUpdateCompleted);
            }
            base.InvokeAsync(this.onBeginUpdateDelegate, new object[] {
                        u}, this.onEndUpdateDelegate, this.onUpdateCompletedDelegate, userState);
        }
        
        public string Delete(WebApplication3.ServiceReference1.DeleteUser d) {
            return base.Channel.Delete(d);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginDelete(WebApplication3.ServiceReference1.DeleteUser d, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginDelete(d, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public string EndDelete(System.IAsyncResult result) {
            return base.Channel.EndDelete(result);
        }
        
        private System.IAsyncResult OnBeginDelete(object[] inValues, System.AsyncCallback callback, object asyncState) {
            WebApplication3.ServiceReference1.DeleteUser d = ((WebApplication3.ServiceReference1.DeleteUser)(inValues[0]));
            return this.BeginDelete(d, callback, asyncState);
        }
        
        private object[] OnEndDelete(System.IAsyncResult result) {
            string retVal = this.EndDelete(result);
            return new object[] {
                    retVal};
        }
        
        private void OnDeleteCompleted(object state) {
            if ((this.DeleteCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.DeleteCompleted(this, new DeleteCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void DeleteAsync(WebApplication3.ServiceReference1.DeleteUser d) {
            this.DeleteAsync(d, null);
        }
        
        public void DeleteAsync(WebApplication3.ServiceReference1.DeleteUser d, object userState) {
            if ((this.onBeginDeleteDelegate == null)) {
                this.onBeginDeleteDelegate = new BeginOperationDelegate(this.OnBeginDelete);
            }
            if ((this.onEndDeleteDelegate == null)) {
                this.onEndDeleteDelegate = new EndOperationDelegate(this.OnEndDelete);
            }
            if ((this.onDeleteCompletedDelegate == null)) {
                this.onDeleteCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnDeleteCompleted);
            }
            base.InvokeAsync(this.onBeginDeleteDelegate, new object[] {
                        d}, this.onEndDeleteDelegate, this.onDeleteCompletedDelegate, userState);
        }
    }
}
