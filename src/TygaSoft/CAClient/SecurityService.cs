﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.1
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace TygaSoft.Model.WcfModel
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ListModel", Namespace="http://schemas.datacontract.org/2004/07/TygaSoft.Model.WcfModel")]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(string[]))]
    public partial class ListModel : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string KeywordField;
        
        private int PageIndexField;
        
        private int PageSizeField;
        
        private object ParentIdField;
        
        private string TypeNameField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Keyword
        {
            get
            {
                return this.KeywordField;
            }
            set
            {
                this.KeywordField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PageIndex
        {
            get
            {
                return this.PageIndexField;
            }
            set
            {
                this.PageIndexField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PageSize
        {
            get
            {
                return this.PageSizeField;
            }
            set
            {
                this.PageSizeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public object ParentId
        {
            get
            {
                return this.ParentIdField;
            }
            set
            {
                this.ParentIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TypeName
        {
            get
            {
                return this.TypeNameField;
            }
            set
            {
                this.TypeNameField = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace="http://TygaSoft.Services.SecurityService", ConfigurationName="ISecurity")]
public interface ISecurity
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://TygaSoft.Services.SecurityService/ISecurity/ValidateUser", ReplyAction="http://TygaSoft.Services.SecurityService/ISecurity/ValidateUserResponse")]
    string ValidateUser(string username, string password);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://TygaSoft.Services.SecurityService/ISecurity/CreateRole", ReplyAction="http://TygaSoft.Services.SecurityService/ISecurity/CreateRoleResponse")]
    string CreateRole(string roleName);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://TygaSoft.Services.SecurityService/ISecurity/SaveUser", ReplyAction="http://TygaSoft.Services.SecurityService/ISecurity/SaveUserResponse")]
    string SaveUser(string username, string password, string email, bool isApproved);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://TygaSoft.Services.SecurityService/ISecurity/SaveUserInRole", ReplyAction="http://TygaSoft.Services.SecurityService/ISecurity/SaveUserInRoleResponse")]
    string SaveUserInRole(string userName, string roleName, bool isInRole);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://TygaSoft.Services.SecurityService/ISecurity/SaveIsLockedOut", ReplyAction="http://TygaSoft.Services.SecurityService/ISecurity/SaveIsLockedOutResponse")]
    string SaveIsLockedOut(string userName);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://TygaSoft.Services.SecurityService/ISecurity/SaveIsApproved", ReplyAction="http://TygaSoft.Services.SecurityService/ISecurity/SaveIsApprovedResponse")]
    string SaveIsApproved(string userName);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://TygaSoft.Services.SecurityService/ISecurity/AddUsersToRoles", ReplyAction="http://TygaSoft.Services.SecurityService/ISecurity/AddUsersToRolesResponse")]
    string AddUsersToRoles(string[] usernames, string[] roleNames);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://TygaSoft.Services.SecurityService/ISecurity/GetAllRoles", ReplyAction="http://TygaSoft.Services.SecurityService/ISecurity/GetAllRolesResponse")]
    string GetAllRoles();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://TygaSoft.Services.SecurityService/ISecurity/GetUserList", ReplyAction="http://TygaSoft.Services.SecurityService/ISecurity/GetUserListResponse")]
    string GetUserList(TygaSoft.Model.WcfModel.ListModel model);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://TygaSoft.Services.SecurityService/ISecurity/GetRolesForUser", ReplyAction="http://TygaSoft.Services.SecurityService/ISecurity/GetRolesForUserResponse")]
    string GetRolesForUser(string userName);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://TygaSoft.Services.SecurityService/ISecurity/GetUsersInRole", ReplyAction="http://TygaSoft.Services.SecurityService/ISecurity/GetUsersInRoleResponse")]
    string GetUsersInRole(string roleName);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://TygaSoft.Services.SecurityService/ISecurity/FindUsersInRole", ReplyAction="http://TygaSoft.Services.SecurityService/ISecurity/FindUsersInRoleResponse")]
    string FindUsersInRole(string roleName, string usernameToMatch);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://TygaSoft.Services.SecurityService/ISecurity/RoleExists", ReplyAction="http://TygaSoft.Services.SecurityService/ISecurity/RoleExistsResponse")]
    string RoleExists(string roleName);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://TygaSoft.Services.SecurityService/ISecurity/IsUserInRole", ReplyAction="http://TygaSoft.Services.SecurityService/ISecurity/IsUserInRoleResponse")]
    string IsUserInRole(string username, string roleName);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://TygaSoft.Services.SecurityService/ISecurity/DeleteUser", ReplyAction="http://TygaSoft.Services.SecurityService/ISecurity/DeleteUserResponse")]
    string DeleteUser(string userName);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://TygaSoft.Services.SecurityService/ISecurity/DeleteRole", ReplyAction="http://TygaSoft.Services.SecurityService/ISecurity/DeleteRoleResponse")]
    string DeleteRole(string roleName, bool throwOnPopulatedRole);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://TygaSoft.Services.SecurityService/ISecurity/RemoveUsersFromRoles", ReplyAction="http://TygaSoft.Services.SecurityService/ISecurity/RemoveUsersFromRolesResponse")]
    string RemoveUsersFromRoles(string[] usernames, string[] roleNames);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://TygaSoft.Services.SecurityService/ISecurity/ResetPassword", ReplyAction="http://TygaSoft.Services.SecurityService/ISecurity/ResetPasswordResponse")]
    string ResetPassword(string username);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://TygaSoft.Services.SecurityService/ISecurity/CheckUserName", ReplyAction="http://TygaSoft.Services.SecurityService/ISecurity/CheckUserNameResponse")]
    string CheckUserName(string userName);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://TygaSoft.Services.SecurityService/ISecurity/ChangePassword", ReplyAction="http://TygaSoft.Services.SecurityService/ISecurity/ChangePasswordResponse")]
    string ChangePassword(string username, string oldPassword, string password);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface ISecurityChannel : ISecurity, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class SecurityClient : System.ServiceModel.ClientBase<ISecurity>, ISecurity
{
    
    public SecurityClient()
    {
    }
    
    public SecurityClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public SecurityClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public SecurityClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public SecurityClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public string ValidateUser(string username, string password)
    {
        return base.Channel.ValidateUser(username, password);
    }
    
    public string CreateRole(string roleName)
    {
        return base.Channel.CreateRole(roleName);
    }
    
    public string SaveUser(string username, string password, string email, bool isApproved)
    {
        return base.Channel.SaveUser(username, password, email, isApproved);
    }
    
    public string SaveUserInRole(string userName, string roleName, bool isInRole)
    {
        return base.Channel.SaveUserInRole(userName, roleName, isInRole);
    }
    
    public string SaveIsLockedOut(string userName)
    {
        return base.Channel.SaveIsLockedOut(userName);
    }
    
    public string SaveIsApproved(string userName)
    {
        return base.Channel.SaveIsApproved(userName);
    }
    
    public string AddUsersToRoles(string[] usernames, string[] roleNames)
    {
        return base.Channel.AddUsersToRoles(usernames, roleNames);
    }
    
    public string GetAllRoles()
    {
        return base.Channel.GetAllRoles();
    }
    
    public string GetUserList(TygaSoft.Model.WcfModel.ListModel model)
    {
        return base.Channel.GetUserList(model);
    }
    
    public string GetRolesForUser(string userName)
    {
        return base.Channel.GetRolesForUser(userName);
    }
    
    public string GetUsersInRole(string roleName)
    {
        return base.Channel.GetUsersInRole(roleName);
    }
    
    public string FindUsersInRole(string roleName, string usernameToMatch)
    {
        return base.Channel.FindUsersInRole(roleName, usernameToMatch);
    }
    
    public string RoleExists(string roleName)
    {
        return base.Channel.RoleExists(roleName);
    }
    
    public string IsUserInRole(string username, string roleName)
    {
        return base.Channel.IsUserInRole(username, roleName);
    }
    
    public string DeleteUser(string userName)
    {
        return base.Channel.DeleteUser(userName);
    }
    
    public string DeleteRole(string roleName, bool throwOnPopulatedRole)
    {
        return base.Channel.DeleteRole(roleName, throwOnPopulatedRole);
    }
    
    public string RemoveUsersFromRoles(string[] usernames, string[] roleNames)
    {
        return base.Channel.RemoveUsersFromRoles(usernames, roleNames);
    }
    
    public string ResetPassword(string username)
    {
        return base.Channel.ResetPassword(username);
    }
    
    public string CheckUserName(string userName)
    {
        return base.Channel.CheckUserName(userName);
    }
    
    public string ChangePassword(string username, string oldPassword, string password)
    {
        return base.Channel.ChangePassword(username, oldPassword, password);
    }
}
