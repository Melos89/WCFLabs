﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LABB1Client.Lab1Service3 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Lab1Service3.Lab1Service3Soap")]
    public interface Lab1Service3Soap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddThreeNumbers", ReplyAction="*")]
        int AddThreeNumbers(int nr1, int nr2, int nr3);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddThreeNumbers", ReplyAction="*")]
        System.Threading.Tasks.Task<int> AddThreeNumbersAsync(int nr1, int nr2, int nr3);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface Lab1Service3SoapChannel : LABB1Client.Lab1Service3.Lab1Service3Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Lab1Service3SoapClient : System.ServiceModel.ClientBase<LABB1Client.Lab1Service3.Lab1Service3Soap>, LABB1Client.Lab1Service3.Lab1Service3Soap {
        
        public Lab1Service3SoapClient() {
        }
        
        public Lab1Service3SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Lab1Service3SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Lab1Service3SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Lab1Service3SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int AddThreeNumbers(int nr1, int nr2, int nr3) {
            return base.Channel.AddThreeNumbers(nr1, nr2, nr3);
        }
        
        public System.Threading.Tasks.Task<int> AddThreeNumbersAsync(int nr1, int nr2, int nr3) {
            return base.Channel.AddThreeNumbersAsync(nr1, nr2, nr3);
        }
    }
}