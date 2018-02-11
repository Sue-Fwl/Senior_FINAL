﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SeniorServer.DBPr {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DBPr.IDBFunctions")]
    public interface IDBFunctions {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBFunctions/AddGameFrame", ReplyAction="http://tempuri.org/IDBFunctions/AddGameFrameResponse")]
        int AddGameFrame(SeniorDBServer.GameFrameModel gf);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBFunctions/AddGameFrame", ReplyAction="http://tempuri.org/IDBFunctions/AddGameFrameResponse")]
        System.Threading.Tasks.Task<int> AddGameFrameAsync(SeniorDBServer.GameFrameModel gf);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBFunctions/DeleteGameFrame", ReplyAction="http://tempuri.org/IDBFunctions/DeleteGameFrameResponse")]
        int DeleteGameFrame(string T);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBFunctions/DeleteGameFrame", ReplyAction="http://tempuri.org/IDBFunctions/DeleteGameFrameResponse")]
        System.Threading.Tasks.Task<int> DeleteGameFrameAsync(string T);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBFunctions/RetreiveGameFrame", ReplyAction="http://tempuri.org/IDBFunctions/RetreiveGameFrameResponse")]
        SeniorDBServer.GameFrameModel RetreiveGameFrame(string T);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBFunctions/RetreiveGameFrame", ReplyAction="http://tempuri.org/IDBFunctions/RetreiveGameFrameResponse")]
        System.Threading.Tasks.Task<SeniorDBServer.GameFrameModel> RetreiveGameFrameAsync(string T);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBFunctions/UpdateGameFrame", ReplyAction="http://tempuri.org/IDBFunctions/UpdateGameFrameResponse")]
        int UpdateGameFrame(int gfid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBFunctions/UpdateGameFrame", ReplyAction="http://tempuri.org/IDBFunctions/UpdateGameFrameResponse")]
        System.Threading.Tasks.Task<int> UpdateGameFrameAsync(int gfid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBFunctions/AddUser", ReplyAction="http://tempuri.org/IDBFunctions/AddUserResponse")]
        int AddUser(SeniorDBServer.UserModel user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBFunctions/AddUser", ReplyAction="http://tempuri.org/IDBFunctions/AddUserResponse")]
        System.Threading.Tasks.Task<int> AddUserAsync(SeniorDBServer.UserModel user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBFunctions/DeleteUser", ReplyAction="http://tempuri.org/IDBFunctions/DeleteUserResponse")]
        int DeleteUser(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBFunctions/DeleteUser", ReplyAction="http://tempuri.org/IDBFunctions/DeleteUserResponse")]
        System.Threading.Tasks.Task<int> DeleteUserAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBFunctions/RetreiveUser", ReplyAction="http://tempuri.org/IDBFunctions/RetreiveUserResponse")]
        SeniorDBServer.UserModel RetreiveUser(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBFunctions/RetreiveUser", ReplyAction="http://tempuri.org/IDBFunctions/RetreiveUserResponse")]
        System.Threading.Tasks.Task<SeniorDBServer.UserModel> RetreiveUserAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBFunctions/AddGamePlayer", ReplyAction="http://tempuri.org/IDBFunctions/AddGamePlayerResponse")]
        int AddGamePlayer(SeniorDBServer.GamePlayerModel player);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBFunctions/AddGamePlayer", ReplyAction="http://tempuri.org/IDBFunctions/AddGamePlayerResponse")]
        System.Threading.Tasks.Task<int> AddGamePlayerAsync(SeniorDBServer.GamePlayerModel player);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBFunctions/DeleteGamePlayer", ReplyAction="http://tempuri.org/IDBFunctions/DeleteGamePlayerResponse")]
        int DeleteGamePlayer(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBFunctions/DeleteGamePlayer", ReplyAction="http://tempuri.org/IDBFunctions/DeleteGamePlayerResponse")]
        System.Threading.Tasks.Task<int> DeleteGamePlayerAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBFunctions/RetreiveGamePlayer", ReplyAction="http://tempuri.org/IDBFunctions/RetreiveGamePlayerResponse")]
        SeniorDBServer.GamePlayerModel RetreiveGamePlayer(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBFunctions/RetreiveGamePlayer", ReplyAction="http://tempuri.org/IDBFunctions/RetreiveGamePlayerResponse")]
        System.Threading.Tasks.Task<SeniorDBServer.GamePlayerModel> RetreiveGamePlayerAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBFunctions/UpdateGamePlayer", ReplyAction="http://tempuri.org/IDBFunctions/UpdateGamePlayerResponse")]
        int UpdateGamePlayer(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBFunctions/UpdateGamePlayer", ReplyAction="http://tempuri.org/IDBFunctions/UpdateGamePlayerResponse")]
        System.Threading.Tasks.Task<int> UpdateGamePlayerAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBFunctions/AddGame", ReplyAction="http://tempuri.org/IDBFunctions/AddGameResponse")]
        int AddGame(SeniorDBServer.GameModel game);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBFunctions/AddGame", ReplyAction="http://tempuri.org/IDBFunctions/AddGameResponse")]
        System.Threading.Tasks.Task<int> AddGameAsync(SeniorDBServer.GameModel game);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBFunctions/DeleteGame", ReplyAction="http://tempuri.org/IDBFunctions/DeleteGameResponse")]
        int DeleteGame(int gameid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBFunctions/DeleteGame", ReplyAction="http://tempuri.org/IDBFunctions/DeleteGameResponse")]
        System.Threading.Tasks.Task<int> DeleteGameAsync(int gameid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBFunctions/RetreiveGame", ReplyAction="http://tempuri.org/IDBFunctions/RetreiveGameResponse")]
        SeniorDBServer.GameModel RetreiveGame(int gameid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBFunctions/RetreiveGame", ReplyAction="http://tempuri.org/IDBFunctions/RetreiveGameResponse")]
        System.Threading.Tasks.Task<SeniorDBServer.GameModel> RetreiveGameAsync(int gameid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBFunctions/UpdateGame", ReplyAction="http://tempuri.org/IDBFunctions/UpdateGameResponse")]
        int UpdateGame(int gameid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBFunctions/UpdateGame", ReplyAction="http://tempuri.org/IDBFunctions/UpdateGameResponse")]
        System.Threading.Tasks.Task<int> UpdateGameAsync(int gameid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBFunctions/AddGFStrategy", ReplyAction="http://tempuri.org/IDBFunctions/AddGFStrategyResponse")]
        int AddGFStrategy(SeniorDBServer.GFStrategyModel gfstrategy);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBFunctions/AddGFStrategy", ReplyAction="http://tempuri.org/IDBFunctions/AddGFStrategyResponse")]
        System.Threading.Tasks.Task<int> AddGFStrategyAsync(SeniorDBServer.GFStrategyModel gfstrategy);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBFunctions/DeleteGFStrategy", ReplyAction="http://tempuri.org/IDBFunctions/DeleteGFStrategyResponse")]
        int DeleteGFStrategy(int gstrategy);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBFunctions/DeleteGFStrategy", ReplyAction="http://tempuri.org/IDBFunctions/DeleteGFStrategyResponse")]
        System.Threading.Tasks.Task<int> DeleteGFStrategyAsync(int gstrategy);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBFunctions/RetreiveGFStrategy", ReplyAction="http://tempuri.org/IDBFunctions/RetreiveGFStrategyResponse")]
        SeniorDBServer.GFStrategyModel RetreiveGFStrategy(int gfstrategyid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBFunctions/RetreiveGFStrategy", ReplyAction="http://tempuri.org/IDBFunctions/RetreiveGFStrategyResponse")]
        System.Threading.Tasks.Task<SeniorDBServer.GFStrategyModel> RetreiveGFStrategyAsync(int gfstrategyid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBFunctions/UpdateGFStrategy", ReplyAction="http://tempuri.org/IDBFunctions/UpdateGFStrategyResponse")]
        int UpdateGFStrategy(int gfstrategyid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBFunctions/UpdateGFStrategy", ReplyAction="http://tempuri.org/IDBFunctions/UpdateGFStrategyResponse")]
        System.Threading.Tasks.Task<int> UpdateGFStrategyAsync(int gfstrategyid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBFunctions/AddNPStrategy", ReplyAction="http://tempuri.org/IDBFunctions/AddNPStrategyResponse")]
        int AddNPStrategy(SeniorDBServer.NPStrategyModel npstrategy);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBFunctions/AddNPStrategy", ReplyAction="http://tempuri.org/IDBFunctions/AddNPStrategyResponse")]
        System.Threading.Tasks.Task<int> AddNPStrategyAsync(SeniorDBServer.NPStrategyModel npstrategy);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBFunctions/DeleteNPStrategy", ReplyAction="http://tempuri.org/IDBFunctions/DeleteNPStrategyResponse")]
        int DeleteNPStrategy(int nptrategy, string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBFunctions/DeleteNPStrategy", ReplyAction="http://tempuri.org/IDBFunctions/DeleteNPStrategyResponse")]
        System.Threading.Tasks.Task<int> DeleteNPStrategyAsync(int nptrategy, string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBFunctions/RetreiveNPStrategy", ReplyAction="http://tempuri.org/IDBFunctions/RetreiveNPStrategyResponse")]
        SeniorDBServer.NPStrategyModel RetreiveNPStrategy(int npstrategyid, string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBFunctions/RetreiveNPStrategy", ReplyAction="http://tempuri.org/IDBFunctions/RetreiveNPStrategyResponse")]
        System.Threading.Tasks.Task<SeniorDBServer.NPStrategyModel> RetreiveNPStrategyAsync(int npstrategyid, string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBFunctions/UpdateNPStrategy", ReplyAction="http://tempuri.org/IDBFunctions/UpdateNPStrategyResponse")]
        int UpdateNPStrategy(int npstrategyid, string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBFunctions/UpdateNPStrategy", ReplyAction="http://tempuri.org/IDBFunctions/UpdateNPStrategyResponse")]
        System.Threading.Tasks.Task<int> UpdateNPStrategyAsync(int npstrategyid, string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBFunctions/AddNashPointProfile", ReplyAction="http://tempuri.org/IDBFunctions/AddNashPointProfileResponse")]
        int AddNashPointProfile(SeniorDBServer.NashPointProfileModel NP);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBFunctions/AddNashPointProfile", ReplyAction="http://tempuri.org/IDBFunctions/AddNashPointProfileResponse")]
        System.Threading.Tasks.Task<int> AddNashPointProfileAsync(SeniorDBServer.NashPointProfileModel NP);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBFunctions/DeleteNashPointProfile", ReplyAction="http://tempuri.org/IDBFunctions/DeleteNashPointProfileResponse")]
        int DeleteNashPointProfile(int NPID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBFunctions/DeleteNashPointProfile", ReplyAction="http://tempuri.org/IDBFunctions/DeleteNashPointProfileResponse")]
        System.Threading.Tasks.Task<int> DeleteNashPointProfileAsync(int NPID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBFunctions/RetreiveNashPointProfile", ReplyAction="http://tempuri.org/IDBFunctions/RetreiveNashPointProfileResponse")]
        SeniorDBServer.NashPointProfileModel RetreiveNashPointProfile(int NPID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBFunctions/RetreiveNashPointProfile", ReplyAction="http://tempuri.org/IDBFunctions/RetreiveNashPointProfileResponse")]
        System.Threading.Tasks.Task<SeniorDBServer.NashPointProfileModel> RetreiveNashPointProfileAsync(int NPID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBFunctions/UpdateNashPointProfile", ReplyAction="http://tempuri.org/IDBFunctions/UpdateNashPointProfileResponse")]
        int UpdateNashPointProfile(int NPID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBFunctions/UpdateNashPointProfile", ReplyAction="http://tempuri.org/IDBFunctions/UpdateNashPointProfileResponse")]
        System.Threading.Tasks.Task<int> UpdateNashPointProfileAsync(int NPID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBFunctions/AddNPPayoff", ReplyAction="http://tempuri.org/IDBFunctions/AddNPPayoffResponse")]
        int AddNPPayoff(SeniorDBServer.NPPayoffModel payoff);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBFunctions/AddNPPayoff", ReplyAction="http://tempuri.org/IDBFunctions/AddNPPayoffResponse")]
        System.Threading.Tasks.Task<int> AddNPPayoffAsync(SeniorDBServer.NPPayoffModel payoff);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBFunctions/DeleteNPPayoff", ReplyAction="http://tempuri.org/IDBFunctions/DeleteNPPayoffResponse")]
        int DeleteNPPayoff(int payoffid, string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBFunctions/DeleteNPPayoff", ReplyAction="http://tempuri.org/IDBFunctions/DeleteNPPayoffResponse")]
        System.Threading.Tasks.Task<int> DeleteNPPayoffAsync(int payoffid, string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBFunctions/RetreiveNPPayoff", ReplyAction="http://tempuri.org/IDBFunctions/RetreiveNPPayoffResponse")]
        SeniorDBServer.NPPayoffModel RetreiveNPPayoff(int payoffid, string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBFunctions/RetreiveNPPayoff", ReplyAction="http://tempuri.org/IDBFunctions/RetreiveNPPayoffResponse")]
        System.Threading.Tasks.Task<SeniorDBServer.NPPayoffModel> RetreiveNPPayoffAsync(int payoffid, string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBFunctions/UpdateNPPayoff", ReplyAction="http://tempuri.org/IDBFunctions/UpdateNPPayoffResponse")]
        int UpdateNPPayoff(int payoffid, string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDBFunctions/UpdateNPPayoff", ReplyAction="http://tempuri.org/IDBFunctions/UpdateNPPayoffResponse")]
        System.Threading.Tasks.Task<int> UpdateNPPayoffAsync(int payoffid, string username);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDBFunctionsChannel : SeniorServer.DBPr.IDBFunctions, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DBFunctionsClient : System.ServiceModel.ClientBase<SeniorServer.DBPr.IDBFunctions>, SeniorServer.DBPr.IDBFunctions {
        
        public DBFunctionsClient() {
        }
        
        public DBFunctionsClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DBFunctionsClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DBFunctionsClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DBFunctionsClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int AddGameFrame(SeniorDBServer.GameFrameModel gf) {
            return base.Channel.AddGameFrame(gf);
        }
        
        public System.Threading.Tasks.Task<int> AddGameFrameAsync(SeniorDBServer.GameFrameModel gf) {
            return base.Channel.AddGameFrameAsync(gf);
        }
        
        public int DeleteGameFrame(string T) {
            return base.Channel.DeleteGameFrame(T);
        }
        
        public System.Threading.Tasks.Task<int> DeleteGameFrameAsync(string T) {
            return base.Channel.DeleteGameFrameAsync(T);
        }
        
        public SeniorDBServer.GameFrameModel RetreiveGameFrame(string T) {
            return base.Channel.RetreiveGameFrame(T);
        }
        
        public System.Threading.Tasks.Task<SeniorDBServer.GameFrameModel> RetreiveGameFrameAsync(string T) {
            return base.Channel.RetreiveGameFrameAsync(T);
        }
        
        public int UpdateGameFrame(int gfid) {
            return base.Channel.UpdateGameFrame(gfid);
        }
        
        public System.Threading.Tasks.Task<int> UpdateGameFrameAsync(int gfid) {
            return base.Channel.UpdateGameFrameAsync(gfid);
        }
        
        public int AddUser(SeniorDBServer.UserModel user) {
            return base.Channel.AddUser(user);
        }
        
        public System.Threading.Tasks.Task<int> AddUserAsync(SeniorDBServer.UserModel user) {
            return base.Channel.AddUserAsync(user);
        }
        
        public int DeleteUser(string username) {
            return base.Channel.DeleteUser(username);
        }
        
        public System.Threading.Tasks.Task<int> DeleteUserAsync(string username) {
            return base.Channel.DeleteUserAsync(username);
        }
        
        public SeniorDBServer.UserModel RetreiveUser(string username, string password) {
            return base.Channel.RetreiveUser(username, password);
        }
        
        public System.Threading.Tasks.Task<SeniorDBServer.UserModel> RetreiveUserAsync(string username, string password) {
            return base.Channel.RetreiveUserAsync(username, password);
        }
        
        public int AddGamePlayer(SeniorDBServer.GamePlayerModel player) {
            return base.Channel.AddGamePlayer(player);
        }
        
        public System.Threading.Tasks.Task<int> AddGamePlayerAsync(SeniorDBServer.GamePlayerModel player) {
            return base.Channel.AddGamePlayerAsync(player);
        }
        
        public int DeleteGamePlayer(string username) {
            return base.Channel.DeleteGamePlayer(username);
        }
        
        public System.Threading.Tasks.Task<int> DeleteGamePlayerAsync(string username) {
            return base.Channel.DeleteGamePlayerAsync(username);
        }
        
        public SeniorDBServer.GamePlayerModel RetreiveGamePlayer(string username) {
            return base.Channel.RetreiveGamePlayer(username);
        }
        
        public System.Threading.Tasks.Task<SeniorDBServer.GamePlayerModel> RetreiveGamePlayerAsync(string username) {
            return base.Channel.RetreiveGamePlayerAsync(username);
        }
        
        public int UpdateGamePlayer(string username) {
            return base.Channel.UpdateGamePlayer(username);
        }
        
        public System.Threading.Tasks.Task<int> UpdateGamePlayerAsync(string username) {
            return base.Channel.UpdateGamePlayerAsync(username);
        }
        
        public int AddGame(SeniorDBServer.GameModel game) {
            return base.Channel.AddGame(game);
        }
        
        public System.Threading.Tasks.Task<int> AddGameAsync(SeniorDBServer.GameModel game) {
            return base.Channel.AddGameAsync(game);
        }
        
        public int DeleteGame(int gameid) {
            return base.Channel.DeleteGame(gameid);
        }
        
        public System.Threading.Tasks.Task<int> DeleteGameAsync(int gameid) {
            return base.Channel.DeleteGameAsync(gameid);
        }
        
        public SeniorDBServer.GameModel RetreiveGame(int gameid) {
            return base.Channel.RetreiveGame(gameid);
        }
        
        public System.Threading.Tasks.Task<SeniorDBServer.GameModel> RetreiveGameAsync(int gameid) {
            return base.Channel.RetreiveGameAsync(gameid);
        }
        
        public int UpdateGame(int gameid) {
            return base.Channel.UpdateGame(gameid);
        }
        
        public System.Threading.Tasks.Task<int> UpdateGameAsync(int gameid) {
            return base.Channel.UpdateGameAsync(gameid);
        }
        
        public int AddGFStrategy(SeniorDBServer.GFStrategyModel gfstrategy) {
            return base.Channel.AddGFStrategy(gfstrategy);
        }
        
        public System.Threading.Tasks.Task<int> AddGFStrategyAsync(SeniorDBServer.GFStrategyModel gfstrategy) {
            return base.Channel.AddGFStrategyAsync(gfstrategy);
        }
        
        public int DeleteGFStrategy(int gstrategy) {
            return base.Channel.DeleteGFStrategy(gstrategy);
        }
        
        public System.Threading.Tasks.Task<int> DeleteGFStrategyAsync(int gstrategy) {
            return base.Channel.DeleteGFStrategyAsync(gstrategy);
        }
        
        public SeniorDBServer.GFStrategyModel RetreiveGFStrategy(int gfstrategyid) {
            return base.Channel.RetreiveGFStrategy(gfstrategyid);
        }
        
        public System.Threading.Tasks.Task<SeniorDBServer.GFStrategyModel> RetreiveGFStrategyAsync(int gfstrategyid) {
            return base.Channel.RetreiveGFStrategyAsync(gfstrategyid);
        }
        
        public int UpdateGFStrategy(int gfstrategyid) {
            return base.Channel.UpdateGFStrategy(gfstrategyid);
        }
        
        public System.Threading.Tasks.Task<int> UpdateGFStrategyAsync(int gfstrategyid) {
            return base.Channel.UpdateGFStrategyAsync(gfstrategyid);
        }
        
        public int AddNPStrategy(SeniorDBServer.NPStrategyModel npstrategy) {
            return base.Channel.AddNPStrategy(npstrategy);
        }
        
        public System.Threading.Tasks.Task<int> AddNPStrategyAsync(SeniorDBServer.NPStrategyModel npstrategy) {
            return base.Channel.AddNPStrategyAsync(npstrategy);
        }
        
        public int DeleteNPStrategy(int nptrategy, string username) {
            return base.Channel.DeleteNPStrategy(nptrategy, username);
        }
        
        public System.Threading.Tasks.Task<int> DeleteNPStrategyAsync(int nptrategy, string username) {
            return base.Channel.DeleteNPStrategyAsync(nptrategy, username);
        }
        
        public SeniorDBServer.NPStrategyModel RetreiveNPStrategy(int npstrategyid, string username) {
            return base.Channel.RetreiveNPStrategy(npstrategyid, username);
        }
        
        public System.Threading.Tasks.Task<SeniorDBServer.NPStrategyModel> RetreiveNPStrategyAsync(int npstrategyid, string username) {
            return base.Channel.RetreiveNPStrategyAsync(npstrategyid, username);
        }
        
        public int UpdateNPStrategy(int npstrategyid, string username) {
            return base.Channel.UpdateNPStrategy(npstrategyid, username);
        }
        
        public System.Threading.Tasks.Task<int> UpdateNPStrategyAsync(int npstrategyid, string username) {
            return base.Channel.UpdateNPStrategyAsync(npstrategyid, username);
        }
        
        public int AddNashPointProfile(SeniorDBServer.NashPointProfileModel NP) {
            return base.Channel.AddNashPointProfile(NP);
        }
        
        public System.Threading.Tasks.Task<int> AddNashPointProfileAsync(SeniorDBServer.NashPointProfileModel NP) {
            return base.Channel.AddNashPointProfileAsync(NP);
        }
        
        public int DeleteNashPointProfile(int NPID) {
            return base.Channel.DeleteNashPointProfile(NPID);
        }
        
        public System.Threading.Tasks.Task<int> DeleteNashPointProfileAsync(int NPID) {
            return base.Channel.DeleteNashPointProfileAsync(NPID);
        }
        
        public SeniorDBServer.NashPointProfileModel RetreiveNashPointProfile(int NPID) {
            return base.Channel.RetreiveNashPointProfile(NPID);
        }
        
        public System.Threading.Tasks.Task<SeniorDBServer.NashPointProfileModel> RetreiveNashPointProfileAsync(int NPID) {
            return base.Channel.RetreiveNashPointProfileAsync(NPID);
        }
        
        public int UpdateNashPointProfile(int NPID) {
            return base.Channel.UpdateNashPointProfile(NPID);
        }
        
        public System.Threading.Tasks.Task<int> UpdateNashPointProfileAsync(int NPID) {
            return base.Channel.UpdateNashPointProfileAsync(NPID);
        }
        
        public int AddNPPayoff(SeniorDBServer.NPPayoffModel payoff) {
            return base.Channel.AddNPPayoff(payoff);
        }
        
        public System.Threading.Tasks.Task<int> AddNPPayoffAsync(SeniorDBServer.NPPayoffModel payoff) {
            return base.Channel.AddNPPayoffAsync(payoff);
        }
        
        public int DeleteNPPayoff(int payoffid, string username) {
            return base.Channel.DeleteNPPayoff(payoffid, username);
        }
        
        public System.Threading.Tasks.Task<int> DeleteNPPayoffAsync(int payoffid, string username) {
            return base.Channel.DeleteNPPayoffAsync(payoffid, username);
        }
        
        public SeniorDBServer.NPPayoffModel RetreiveNPPayoff(int payoffid, string username) {
            return base.Channel.RetreiveNPPayoff(payoffid, username);
        }
        
        public System.Threading.Tasks.Task<SeniorDBServer.NPPayoffModel> RetreiveNPPayoffAsync(int payoffid, string username) {
            return base.Channel.RetreiveNPPayoffAsync(payoffid, username);
        }
        
        public int UpdateNPPayoff(int payoffid, string username) {
            return base.Channel.UpdateNPPayoff(payoffid, username);
        }
        
        public System.Threading.Tasks.Task<int> UpdateNPPayoffAsync(int payoffid, string username) {
            return base.Channel.UpdateNPPayoffAsync(payoffid, username);
        }
    }
}