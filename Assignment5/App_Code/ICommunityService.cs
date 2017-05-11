﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICommunityService" in both code and config file together.
[ServiceContract]
public interface ICommunityService
{
    [OperationContract]
    int Login(string user, string password);

    [OperationContract]
    bool RegisterUser(string lastname, string firstname, string email, string password,
    string Apartment, string Street, string City, string State, string Zipcode,
    string HomePhone, string WorkPhone);

    
    [OperationContract]
    List<GrantRequestInfo> GetRequestGrantAmount( );
}

[DataContract]
public class GrantRequestInfo
{
    [DataMember]
    public string GrantRequestDate { get; set; }

    [DataMember]
    public string GrantRequestExplanation { get; set; }

    [DataMember]
    public string GrantRequestAmount { get; set; }

    [DataMember]
    public string GrantRequestStatus { get; set; }
}