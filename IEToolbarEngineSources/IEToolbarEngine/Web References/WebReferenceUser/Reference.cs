﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18408
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

// 
// 此源代码是由 Microsoft.VSDesigner 4.0.30319.18408 版自动生成。
// 
#pragma warning disable 1591

namespace IEToolbarEngine.WebReferenceUser {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="userWebServiceSoapBinding", Namespace="http://impl.cxf.qianye.com/")]
    public partial class userWebService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback getUsersBySimpleNameOperationCompleted;
        
        private System.Threading.SendOrPostCallback getUsersOperationCompleted;
        
        private System.Threading.SendOrPostCallback addUserOperationCompleted;
        
        private System.Threading.SendOrPostCallback getUsersByDeptIdOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public userWebService() {
            this.Url = global::IEToolbarEngine.Properties.Settings.Default.IEToolbar_WebReferenceUser_userWebService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event getUsersBySimpleNameCompletedEventHandler getUsersBySimpleNameCompleted;
        
        /// <remarks/>
        public event getUsersCompletedEventHandler getUsersCompleted;
        
        /// <remarks/>
        public event addUserCompletedEventHandler addUserCompleted;
        
        /// <remarks/>
        public event getUsersByDeptIdCompletedEventHandler getUsersByDeptIdCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://services.cxf.qianye.com/", ResponseNamespace="http://services.cxf.qianye.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string getUsersBySimpleName([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string simpleName) {
            object[] results = this.Invoke("getUsersBySimpleName", new object[] {
                        simpleName});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getUsersBySimpleNameAsync(string simpleName) {
            this.getUsersBySimpleNameAsync(simpleName, null);
        }
        
        /// <remarks/>
        public void getUsersBySimpleNameAsync(string simpleName, object userState) {
            if ((this.getUsersBySimpleNameOperationCompleted == null)) {
                this.getUsersBySimpleNameOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetUsersBySimpleNameOperationCompleted);
            }
            this.InvokeAsync("getUsersBySimpleName", new object[] {
                        simpleName}, this.getUsersBySimpleNameOperationCompleted, userState);
        }
        
        private void OngetUsersBySimpleNameOperationCompleted(object arg) {
            if ((this.getUsersBySimpleNameCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getUsersBySimpleNameCompleted(this, new getUsersBySimpleNameCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://services.cxf.qianye.com/", ResponseNamespace="http://services.cxf.qianye.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string getUsers() {
            object[] results = this.Invoke("getUsers", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getUsersAsync() {
            this.getUsersAsync(null);
        }
        
        /// <remarks/>
        public void getUsersAsync(object userState) {
            if ((this.getUsersOperationCompleted == null)) {
                this.getUsersOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetUsersOperationCompleted);
            }
            this.InvokeAsync("getUsers", new object[0], this.getUsersOperationCompleted, userState);
        }
        
        private void OngetUsersOperationCompleted(object arg) {
            if ((this.getUsersCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getUsersCompleted(this, new getUsersCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://services.cxf.qianye.com/", ResponseNamespace="http://services.cxf.qianye.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string addUser([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string userName, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string phone, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string simpleName) {
            object[] results = this.Invoke("addUser", new object[] {
                        userName,
                        phone,
                        simpleName});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void addUserAsync(string userName, string phone, string simpleName) {
            this.addUserAsync(userName, phone, simpleName, null);
        }
        
        /// <remarks/>
        public void addUserAsync(string userName, string phone, string simpleName, object userState) {
            if ((this.addUserOperationCompleted == null)) {
                this.addUserOperationCompleted = new System.Threading.SendOrPostCallback(this.OnaddUserOperationCompleted);
            }
            this.InvokeAsync("addUser", new object[] {
                        userName,
                        phone,
                        simpleName}, this.addUserOperationCompleted, userState);
        }
        
        private void OnaddUserOperationCompleted(object arg) {
            if ((this.addUserCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.addUserCompleted(this, new addUserCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://services.cxf.qianye.com/", ResponseNamespace="http://services.cxf.qianye.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string getUsersByDeptId([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] int deptId) {
            object[] results = this.Invoke("getUsersByDeptId", new object[] {
                        deptId});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getUsersByDeptIdAsync(int deptId) {
            this.getUsersByDeptIdAsync(deptId, null);
        }
        
        /// <remarks/>
        public void getUsersByDeptIdAsync(int deptId, object userState) {
            if ((this.getUsersByDeptIdOperationCompleted == null)) {
                this.getUsersByDeptIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetUsersByDeptIdOperationCompleted);
            }
            this.InvokeAsync("getUsersByDeptId", new object[] {
                        deptId}, this.getUsersByDeptIdOperationCompleted, userState);
        }
        
        private void OngetUsersByDeptIdOperationCompleted(object arg) {
            if ((this.getUsersByDeptIdCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getUsersByDeptIdCompleted(this, new getUsersByDeptIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void getUsersBySimpleNameCompletedEventHandler(object sender, getUsersBySimpleNameCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getUsersBySimpleNameCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getUsersBySimpleNameCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void getUsersCompletedEventHandler(object sender, getUsersCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getUsersCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getUsersCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void addUserCompletedEventHandler(object sender, addUserCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class addUserCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal addUserCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void getUsersByDeptIdCompletedEventHandler(object sender, getUsersByDeptIdCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getUsersByDeptIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getUsersByDeptIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591