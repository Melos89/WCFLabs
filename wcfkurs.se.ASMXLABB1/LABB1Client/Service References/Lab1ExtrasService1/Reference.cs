﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LABB1Client.Lab1ExtrasService1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Lab1ExtrasService1.Extras1ServiceSoap")]
    public interface Extras1ServiceSoap {
        
        // CODEGEN: Generating message contract since element name year from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FindMovies", ReplyAction="*")]
        LABB1Client.Lab1ExtrasService1.FindMoviesResponse FindMovies(LABB1Client.Lab1ExtrasService1.FindMoviesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FindMovies", ReplyAction="*")]
        System.Threading.Tasks.Task<LABB1Client.Lab1ExtrasService1.FindMoviesResponse> FindMoviesAsync(LABB1Client.Lab1ExtrasService1.FindMoviesRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class FindMoviesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="FindMovies", Namespace="http://tempuri.org/", Order=0)]
        public LABB1Client.Lab1ExtrasService1.FindMoviesRequestBody Body;
        
        public FindMoviesRequest() {
        }
        
        public FindMoviesRequest(LABB1Client.Lab1ExtrasService1.FindMoviesRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class FindMoviesRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string year;
        
        public FindMoviesRequestBody() {
        }
        
        public FindMoviesRequestBody(string year) {
            this.year = year;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class FindMoviesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="FindMoviesResponse", Namespace="http://tempuri.org/", Order=0)]
        public LABB1Client.Lab1ExtrasService1.FindMoviesResponseBody Body;
        
        public FindMoviesResponse() {
        }
        
        public FindMoviesResponse(LABB1Client.Lab1ExtrasService1.FindMoviesResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class FindMoviesResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string FindMoviesResult;
        
        public FindMoviesResponseBody() {
        }
        
        public FindMoviesResponseBody(string FindMoviesResult) {
            this.FindMoviesResult = FindMoviesResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface Extras1ServiceSoapChannel : LABB1Client.Lab1ExtrasService1.Extras1ServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Extras1ServiceSoapClient : System.ServiceModel.ClientBase<LABB1Client.Lab1ExtrasService1.Extras1ServiceSoap>, LABB1Client.Lab1ExtrasService1.Extras1ServiceSoap {
        
        public Extras1ServiceSoapClient() {
        }
        
        public Extras1ServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Extras1ServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Extras1ServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Extras1ServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LABB1Client.Lab1ExtrasService1.FindMoviesResponse LABB1Client.Lab1ExtrasService1.Extras1ServiceSoap.FindMovies(LABB1Client.Lab1ExtrasService1.FindMoviesRequest request) {
            return base.Channel.FindMovies(request);
        }
        
        public string FindMovies(string year) {
            LABB1Client.Lab1ExtrasService1.FindMoviesRequest inValue = new LABB1Client.Lab1ExtrasService1.FindMoviesRequest();
            inValue.Body = new LABB1Client.Lab1ExtrasService1.FindMoviesRequestBody();
            inValue.Body.year = year;
            LABB1Client.Lab1ExtrasService1.FindMoviesResponse retVal = ((LABB1Client.Lab1ExtrasService1.Extras1ServiceSoap)(this)).FindMovies(inValue);
            return retVal.Body.FindMoviesResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LABB1Client.Lab1ExtrasService1.FindMoviesResponse> LABB1Client.Lab1ExtrasService1.Extras1ServiceSoap.FindMoviesAsync(LABB1Client.Lab1ExtrasService1.FindMoviesRequest request) {
            return base.Channel.FindMoviesAsync(request);
        }
        
        public System.Threading.Tasks.Task<LABB1Client.Lab1ExtrasService1.FindMoviesResponse> FindMoviesAsync(string year) {
            LABB1Client.Lab1ExtrasService1.FindMoviesRequest inValue = new LABB1Client.Lab1ExtrasService1.FindMoviesRequest();
            inValue.Body = new LABB1Client.Lab1ExtrasService1.FindMoviesRequestBody();
            inValue.Body.year = year;
            return ((LABB1Client.Lab1ExtrasService1.Extras1ServiceSoap)(this)).FindMoviesAsync(inValue);
        }
    }
}
