﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LABB1Client.Lab1ExtrasService3 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Lab1ExtrasService3.Extras3ServiceSoap")]
    public interface Extras3ServiceSoap {
        
        // CODEGEN: Generating message contract since element name Month from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FindDeadPeopleByMonth", ReplyAction="*")]
        LABB1Client.Lab1ExtrasService3.FindDeadPeopleByMonthResponse FindDeadPeopleByMonth(LABB1Client.Lab1ExtrasService3.FindDeadPeopleByMonthRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FindDeadPeopleByMonth", ReplyAction="*")]
        System.Threading.Tasks.Task<LABB1Client.Lab1ExtrasService3.FindDeadPeopleByMonthResponse> FindDeadPeopleByMonthAsync(LABB1Client.Lab1ExtrasService3.FindDeadPeopleByMonthRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class FindDeadPeopleByMonthRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="FindDeadPeopleByMonth", Namespace="http://tempuri.org/", Order=0)]
        public LABB1Client.Lab1ExtrasService3.FindDeadPeopleByMonthRequestBody Body;
        
        public FindDeadPeopleByMonthRequest() {
        }
        
        public FindDeadPeopleByMonthRequest(LABB1Client.Lab1ExtrasService3.FindDeadPeopleByMonthRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class FindDeadPeopleByMonthRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Month;
        
        public FindDeadPeopleByMonthRequestBody() {
        }
        
        public FindDeadPeopleByMonthRequestBody(string Month) {
            this.Month = Month;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class FindDeadPeopleByMonthResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="FindDeadPeopleByMonthResponse", Namespace="http://tempuri.org/", Order=0)]
        public LABB1Client.Lab1ExtrasService3.FindDeadPeopleByMonthResponseBody Body;
        
        public FindDeadPeopleByMonthResponse() {
        }
        
        public FindDeadPeopleByMonthResponse(LABB1Client.Lab1ExtrasService3.FindDeadPeopleByMonthResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class FindDeadPeopleByMonthResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string FindDeadPeopleByMonthResult;
        
        public FindDeadPeopleByMonthResponseBody() {
        }
        
        public FindDeadPeopleByMonthResponseBody(string FindDeadPeopleByMonthResult) {
            this.FindDeadPeopleByMonthResult = FindDeadPeopleByMonthResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface Extras3ServiceSoapChannel : LABB1Client.Lab1ExtrasService3.Extras3ServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Extras3ServiceSoapClient : System.ServiceModel.ClientBase<LABB1Client.Lab1ExtrasService3.Extras3ServiceSoap>, LABB1Client.Lab1ExtrasService3.Extras3ServiceSoap {
        
        public Extras3ServiceSoapClient() {
        }
        
        public Extras3ServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Extras3ServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Extras3ServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Extras3ServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LABB1Client.Lab1ExtrasService3.FindDeadPeopleByMonthResponse LABB1Client.Lab1ExtrasService3.Extras3ServiceSoap.FindDeadPeopleByMonth(LABB1Client.Lab1ExtrasService3.FindDeadPeopleByMonthRequest request) {
            return base.Channel.FindDeadPeopleByMonth(request);
        }
        
        public string FindDeadPeopleByMonth(string Month) {
            LABB1Client.Lab1ExtrasService3.FindDeadPeopleByMonthRequest inValue = new LABB1Client.Lab1ExtrasService3.FindDeadPeopleByMonthRequest();
            inValue.Body = new LABB1Client.Lab1ExtrasService3.FindDeadPeopleByMonthRequestBody();
            inValue.Body.Month = Month;
            LABB1Client.Lab1ExtrasService3.FindDeadPeopleByMonthResponse retVal = ((LABB1Client.Lab1ExtrasService3.Extras3ServiceSoap)(this)).FindDeadPeopleByMonth(inValue);
            return retVal.Body.FindDeadPeopleByMonthResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LABB1Client.Lab1ExtrasService3.FindDeadPeopleByMonthResponse> LABB1Client.Lab1ExtrasService3.Extras3ServiceSoap.FindDeadPeopleByMonthAsync(LABB1Client.Lab1ExtrasService3.FindDeadPeopleByMonthRequest request) {
            return base.Channel.FindDeadPeopleByMonthAsync(request);
        }
        
        public System.Threading.Tasks.Task<LABB1Client.Lab1ExtrasService3.FindDeadPeopleByMonthResponse> FindDeadPeopleByMonthAsync(string Month) {
            LABB1Client.Lab1ExtrasService3.FindDeadPeopleByMonthRequest inValue = new LABB1Client.Lab1ExtrasService3.FindDeadPeopleByMonthRequest();
            inValue.Body = new LABB1Client.Lab1ExtrasService3.FindDeadPeopleByMonthRequestBody();
            inValue.Body.Month = Month;
            return ((LABB1Client.Lab1ExtrasService3.Extras3ServiceSoap)(this)).FindDeadPeopleByMonthAsync(inValue);
        }
    }
}