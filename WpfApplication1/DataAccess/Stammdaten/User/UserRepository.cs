﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.ServiceModel.Security;
using System.Text;
using System.Windows;
using BL.Service.Stammdaten.User;
using Controls;
using FrontEnd.Data.Channel;
using Views;
using Views.Security.Connection;
using Views.Stammdaten.User;
using  BL.Service;

namespace FrontEnd.DataAccess.Stammdaten.User {
    public class UserRepository
    {
       
        /*
        private FuncUser<List<IUserView>> UserFunction; 
        */     
        private IConnection<IUserService> _usrServiceConnection;
        private IUserService _usrService;
        private List<UserView> _userList;

       public IConnection<IUserService> Connection {
            get {
                if (_usrServiceConnection == null) {
                    _usrServiceConnection =
                    ConnectionFactory<IUserService>.CreateConnection("UserService", "net.tcp://localhost:2526/Service/Stammdaten/User");
                }
                if (_usrServiceConnection.ChannelFactory.Credentials != null) {
                    _usrServiceConnection.ChannelFactory.Credentials.UserName.UserName = Session.Username;
                    _usrServiceConnection.ChannelFactory.Credentials.UserName.Password = Session.Password;
                }
                if (_usrServiceConnection.ChannelFactory.State != CommunicationState.Opened)
                    _usrServiceConnection.ChannelFactory.Open();
                return _usrServiceConnection;
            }
        }

        public IUserService Service {
            get { return _usrService ?? (_usrService = Connection.ChannelFactory.CreateChannel()); }
        }

        // Funktioniert noch nicht. Bin gerade am Versuch Async umzusetzen. 
        public List<UserView> GetAllUsers {
            get { return Service.AllUsers().Rows; }
        }
            /*    UserFunction = () => _userList = _usrServiceConnection.AllUsers().Rows;

            AsyncCallback getUserEndedAsyncEnd = (result) => {
                                                     if (result != null && !result.IsCompleted)
                                                         throw new Exception("getUserEndedAsyncEnd" + result.ToString());
                                                     
                                                 };

           UserFunction.BeginInvoke(getUserEndedAsyncEnd, null);
            
            return _userList;*/

        

        public IUserView AddUser {
            set { Service.AddUser(value); }
        }


        public Boolean TestConnection {
            get { return Service != null && Service.TestConnection(); }
        }

        public void OnGetAllUsers() {
             
        }














    }
}
