﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LABB1Client.Lab1Service4 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Lab1Service4.Lab1Service4Soap")]
    public interface Lab1Service4Soap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Subtract", ReplyAction="*")]
        int Subtract(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Subtract", ReplyAction="*")]
        System.Threading.Tasks.Task<int> SubtractAsync(int x, int y);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface Lab1Service4SoapChannel : LABB1Client.Lab1Service4.Lab1Service4Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Lab1Service4SoapClient : System.ServiceModel.ClientBase<LABB1Client.Lab1Service4.Lab1Service4Soap>, LABB1Client.Lab1Service4.Lab1Service4Soap {
        
        public Lab1Service4SoapClient() {
        }
        
        public Lab1Service4SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Lab1Service4SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Lab1Service4SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Lab1Service4SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Subtract(int x, int y) {
            return base.Channel.Subtract(x, y);
        }
        
        public System.Threading.Tasks.Task<int> SubtractAsync(int x, int y) {
            return base.Channel.SubtractAsync(x, y);
        }
    }
}
