﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SeniorTester.ConTester {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserModel", Namespace="http://schemas.datacontract.org/2004/07/SeniorDBServer")]
    [System.SerializableAttribute()]
    public partial class UserModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private char AdminFlagField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;
        
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
        public char AdminFlag {
            get {
                return this.AdminFlagField;
            }
            set {
                if ((this.AdminFlagField.Equals(value) != true)) {
                    this.AdminFlagField = value;
                    this.RaisePropertyChanged("AdminFlag");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="GameFrameModel", Namespace="http://schemas.datacontract.org/2004/07/SeniorDBServer")]
    [System.SerializableAttribute()]
    public partial class GameFrameModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MaxPlayersField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MaxStrategiesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MinPlayersField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MinStrategiesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
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
        public int MaxPlayers {
            get {
                return this.MaxPlayersField;
            }
            set {
                if ((this.MaxPlayersField.Equals(value) != true)) {
                    this.MaxPlayersField = value;
                    this.RaisePropertyChanged("MaxPlayers");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MaxStrategies {
            get {
                return this.MaxStrategiesField;
            }
            set {
                if ((this.MaxStrategiesField.Equals(value) != true)) {
                    this.MaxStrategiesField = value;
                    this.RaisePropertyChanged("MaxStrategies");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MinPlayers {
            get {
                return this.MinPlayersField;
            }
            set {
                if ((this.MinPlayersField.Equals(value) != true)) {
                    this.MinPlayersField = value;
                    this.RaisePropertyChanged("MinPlayers");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MinStrategies {
            get {
                return this.MinStrategiesField;
            }
            set {
                if ((this.MinStrategiesField.Equals(value) != true)) {
                    this.MinStrategiesField = value;
                    this.RaisePropertyChanged("MinStrategies");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ConTester.INsashServices")]
    public interface INsashServices {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INsashServices/NPlayerWrapper", ReplyAction="http://tempuri.org/INsashServices/NPlayerWrapperResponse")]
        string[] NPlayerWrapper();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INsashServices/NPlayerWrapper", ReplyAction="http://tempuri.org/INsashServices/NPlayerWrapperResponse")]
        System.Threading.Tasks.Task<string[]> NPlayerWrapperAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INsashServices/Two_PlayerWrapper", ReplyAction="http://tempuri.org/INsashServices/Two_PlayerWrapperResponse")]
        int[] Two_PlayerWrapper();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INsashServices/Two_PlayerWrapper", ReplyAction="http://tempuri.org/INsashServices/Two_PlayerWrapperResponse")]
        System.Threading.Tasks.Task<int[]> Two_PlayerWrapperAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INsashServices/Three_PlayerWrapper", ReplyAction="http://tempuri.org/INsashServices/Three_PlayerWrapperResponse")]
        int[] Three_PlayerWrapper();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INsashServices/Three_PlayerWrapper", ReplyAction="http://tempuri.org/INsashServices/Three_PlayerWrapperResponse")]
        System.Threading.Tasks.Task<int[]> Three_PlayerWrapperAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INsashServices/SignIn", ReplyAction="http://tempuri.org/INsashServices/SignInResponse")]
        SeniorTester.ConTester.UserModel SignIn(SeniorTester.ConTester.UserModel s);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INsashServices/SignIn", ReplyAction="http://tempuri.org/INsashServices/SignInResponse")]
        System.Threading.Tasks.Task<SeniorTester.ConTester.UserModel> SignInAsync(SeniorTester.ConTester.UserModel s);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INsashServices/Register", ReplyAction="http://tempuri.org/INsashServices/RegisterResponse")]
        string Register(SeniorTester.ConTester.UserModel usermodel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INsashServices/Register", ReplyAction="http://tempuri.org/INsashServices/RegisterResponse")]
        System.Threading.Tasks.Task<string> RegisterAsync(SeniorTester.ConTester.UserModel usermodel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INsashServices/ChooseGame", ReplyAction="http://tempuri.org/INsashServices/ChooseGameResponse")]
        SeniorTester.ConTester.GameFrameModel[] ChooseGame(int nop);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INsashServices/ChooseGame", ReplyAction="http://tempuri.org/INsashServices/ChooseGameResponse")]
        System.Threading.Tasks.Task<SeniorTester.ConTester.GameFrameModel[]> ChooseGameAsync(int nop);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INsashServices/CheckGameStatus", ReplyAction="http://tempuri.org/INsashServices/CheckGameStatusResponse")]
        int CheckGameStatus(string desiredgame, string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INsashServices/CheckGameStatus", ReplyAction="http://tempuri.org/INsashServices/CheckGameStatusResponse")]
        System.Threading.Tasks.Task<int> CheckGameStatusAsync(string desiredgame, string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INsashServices/JoinGame", ReplyAction="http://tempuri.org/INsashServices/JoinGameResponse")]
        int JoinGame(string desiredgame, string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INsashServices/JoinGame", ReplyAction="http://tempuri.org/INsashServices/JoinGameResponse")]
        System.Threading.Tasks.Task<int> JoinGameAsync(string desiredgame, string username);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface INsashServicesChannel : SeniorTester.ConTester.INsashServices, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class NsashServicesClient : System.ServiceModel.ClientBase<SeniorTester.ConTester.INsashServices>, SeniorTester.ConTester.INsashServices {
        
        public NsashServicesClient() {
        }
        
        public NsashServicesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public NsashServicesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NsashServicesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NsashServicesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string[] NPlayerWrapper() {
            return base.Channel.NPlayerWrapper();
        }
        
        public System.Threading.Tasks.Task<string[]> NPlayerWrapperAsync() {
            return base.Channel.NPlayerWrapperAsync();
        }
        
        public int[] Two_PlayerWrapper() {
            return base.Channel.Two_PlayerWrapper();
        }
        
        public System.Threading.Tasks.Task<int[]> Two_PlayerWrapperAsync() {
            return base.Channel.Two_PlayerWrapperAsync();
        }
        
        public int[] Three_PlayerWrapper() {
            return base.Channel.Three_PlayerWrapper();
        }
        
        public System.Threading.Tasks.Task<int[]> Three_PlayerWrapperAsync() {
            return base.Channel.Three_PlayerWrapperAsync();
        }
        
        public SeniorTester.ConTester.UserModel SignIn(SeniorTester.ConTester.UserModel s) {
            return base.Channel.SignIn(s);
        }
        
        public System.Threading.Tasks.Task<SeniorTester.ConTester.UserModel> SignInAsync(SeniorTester.ConTester.UserModel s) {
            return base.Channel.SignInAsync(s);
        }
        
        public string Register(SeniorTester.ConTester.UserModel usermodel) {
            return base.Channel.Register(usermodel);
        }
        
        public System.Threading.Tasks.Task<string> RegisterAsync(SeniorTester.ConTester.UserModel usermodel) {
            return base.Channel.RegisterAsync(usermodel);
        }
        
        public SeniorTester.ConTester.GameFrameModel[] ChooseGame(int nop) {
            return base.Channel.ChooseGame(nop);
        }
        
        public System.Threading.Tasks.Task<SeniorTester.ConTester.GameFrameModel[]> ChooseGameAsync(int nop) {
            return base.Channel.ChooseGameAsync(nop);
        }
        
        public int CheckGameStatus(string desiredgame, string username) {
            return base.Channel.CheckGameStatus(desiredgame, username);
        }
        
        public System.Threading.Tasks.Task<int> CheckGameStatusAsync(string desiredgame, string username) {
            return base.Channel.CheckGameStatusAsync(desiredgame, username);
        }
        
        public int JoinGame(string desiredgame, string username) {
            return base.Channel.JoinGame(desiredgame, username);
        }
        
        public System.Threading.Tasks.Task<int> JoinGameAsync(string desiredgame, string username) {
            return base.Channel.JoinGameAsync(desiredgame, username);
        }
    }
}
