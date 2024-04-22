
namespace ServiceReference1
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IMathService")]
    public interface IMathService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMathService/Add", ReplyAction="http://tempuri.org/IMathService/AddResponse")]
        System.Threading.Tasks.Task<double> AddAsync(double operand1, double operand2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMathService/Subtract", ReplyAction="http://tempuri.org/IMathService/SubtractResponse")]
        System.Threading.Tasks.Task<double> SubtractAsync(double operand1, double operand2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMathService/Multiply", ReplyAction="http://tempuri.org/IMathService/MultiplyResponse")]
        System.Threading.Tasks.Task<double> MultiplyAsync(double operand1, double operand2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMathService/Divide", ReplyAction="http://tempuri.org/IMathService/DivideResponse")]
        System.Threading.Tasks.Task<double> DivideAsync(double operand1, double operand2);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    public interface IMathServiceChannel : ServiceReference1.IMathService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    public partial class MathServiceClient : System.ServiceModel.ClientBase<ServiceReference1.IMathService>, ServiceReference1.IMathService
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public MathServiceClient() : 
                base(MathServiceClient.GetDefaultBinding(), MathServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IMathService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MathServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(MathServiceClient.GetBindingForEndpoint(endpointConfiguration), MathServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MathServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(MathServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MathServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(MathServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MathServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<double> AddAsync(double operand1, double operand2)
        {
            return base.Channel.AddAsync(operand1, operand2);
        }
        
        public System.Threading.Tasks.Task<double> SubtractAsync(double operand1, double operand2)
        {
            return base.Channel.SubtractAsync(operand1, operand2);
        }
        
        public System.Threading.Tasks.Task<double> MultiplyAsync(double operand1, double operand2)
        {
            return base.Channel.MultiplyAsync(operand1, operand2);
        }
        
        public System.Threading.Tasks.Task<double> DivideAsync(double operand1, double operand2)
        {
            return base.Channel.DivideAsync(operand1, operand2);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IMathService))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IMathService))
            {
                return new System.ServiceModel.EndpointAddress("https://localhost:7193/service.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return MathServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IMathService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return MathServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IMathService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IMathService,
        }
    }
}
