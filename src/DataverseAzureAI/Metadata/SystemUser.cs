using System.Diagnostics;
using System.Text.Json.Serialization;

namespace AP2.DataverseAzureAI.Metadata;

[DebuggerDisplay("{FullName}")]
public class SystemUser
{
    public string OwnerId { get; set; }
    public object address1_postofficebox { get; set; }
    public object yomimiddlename { get; set; }
    public object mobilealertemail { get; set; }
    public string address1_composite { get; set; }
    public string userpuid { get; set; }
    public int accessmode { get; set; }
    public string? InternalEmailAddress { get; set; }
    public int azurestate { get; set; }
    public string address1_addressid { get; set; }
    public object middlename { get; set; }
    public object photourl { get; set; }
    public object entityimage { get; set; }
    public object _mobileofflineprofileid_value { get; set; }
    public string organizationid { get; set; }
    public object homephone { get; set; }
    public object address1_upszone { get; set; }
    public object entityimage_url { get; set; }
    public string _createdby_value { get; set; }
    public string azureactivedirectoryobjectid { get; set; }
    public object yammeremailaddress { get; set; }
    public int? address1_shippingmethodcode { get; set; }
    public int caltype { get; set; }
    public object governmentid { get; set; }
    public object address2_upszone { get; set; }
    public string yomifullname { get; set; }
    public string _modifiedby_value { get; set; }
    public object applicationiduri { get; set; }
    public object nickname { get; set; }
    public int incomingemaildeliverymethod { get; set; }
    public bool? displayinserviceviews { get; set; }
    public string firstname { get; set; }
    public object personalemailaddress { get; set; }
    public bool setupuser { get; set; }
    public int? address1_addresstypecode { get; set; }
    public object salutation { get; set; }
    public object address2_city { get; set; }
    public object address2_longitude { get; set; }
    public object address1_line2 { get; set; }
    public int? address2_addresstypecode { get; set; }
    public object sharepointemailaddress { get; set; }
    public object stageid { get; set; }
    public object azuredeletedon { get; set; }
    public int? preferredphonecode { get; set; }
    public object address2_utcoffset { get; set; }
    public bool isdisabled { get; set; }
    public string _modifiedonbehalfby_value { get; set; }
    public string mobilephone { get; set; }
    public object entityimageid { get; set; }
    public object address1_name { get; set; }
    public int? address2_shippingmethodcode { get; set; }
    public string FullName { get; set; }
    public object processid { get; set; }
    public object address2_stateorprovince { get; set; }
    public object yomifirstname { get; set; }
    public object importsequencenumber { get; set; }
    public object _positionid_value { get; set; }
    public int invitestatuscode { get; set; }
    public object address2_line3 { get; set; }
    public DateTime modifiedon { get; set; }
    public string _calendarid_value { get; set; }
    public object address1_telephone3 { get; set; }
    public object address1_stateorprovince { get; set; }
    public string defaultodbfoldername { get; set; }
    public object address1_telephone2 { get; set; }
    public string address1_telephone1 { get; set; }
    public object utcconversiontimezonecode { get; set; }
    public int identityid { get; set; }
    public bool isemailaddressapprovedbyo365admin { get; set; }
    public object address2_latitude { get; set; }
    public string lastname { get; set; }
    public object address1_county { get; set; }
    public string address1_city { get; set; }
    public bool issyncwithdirectory { get; set; }
    public object address2_postofficebox { get; set; }
    public object address1_fax { get; set; }
    public object traversedpath { get; set; }
    public object _createdonbehalfby_value { get; set; }
    public int userlicensetype { get; set; }
    public object address2_line1 { get; set; }
    public bool islicensed { get; set; }
    public object _territoryid_value { get; set; }
    public object passportlo { get; set; }
    public object address1_utcoffset { get; set; }
    public object _parentsystemuserid_value { get; set; }
    public object address1_line3 { get; set; }
    public string _queueid_value { get; set; }
    public object _cdm_company_value { get; set; }
    public string _businessunitid_value { get; set; }
    public object yammeruserid { get; set; }
    public object address1_postalcode { get; set; }
    public object address1_country { get; set; }
    public int deletedstate { get; set; }
    public object applicationid { get; set; }
    public object skills { get; set; }
    public object address2_county { get; set; }
    public object address2_postalcode { get; set; }
    public object exchangerate { get; set; }
    public object passporthi { get; set; }
    public object address1_line1 { get; set; }
    public object yomilastname { get; set; }
    public object address2_country { get; set; }
    public object address2_name { get; set; }
    public bool defaultfilterspopulated { get; set; }
    public object timezoneruleversionnumber { get; set; }
    public string _defaultmailbox_value { get; set; }
    public Guid SystemUserId { get; set; }
    public string windowsliveid { get; set; }
    public object overriddencreatedon { get; set; }
    public object address2_fax { get; set; }
    public object employeeid { get; set; }
    public object _transactioncurrencyid_value { get; set; }
    public string address2_addressid { get; set; }
    public int emailrouteraccessapproval { get; set; }
    public int? preferredaddresscode { get; set; }
    public object address2_composite { get; set; }
    public int? preferredemailcode { get; set; }

    [JsonPropertyName("domainname")]
    public string DomainName { get; set; }
    public string title { get; set; }
    public object address2_telephone3 { get; set; }
    public object address2_telephone2 { get; set; }
    public object address2_telephone1 { get; set; }
    public object address1_latitude { get; set; }
    public object jobtitle { get; set; }
    public bool isintegrationuser { get; set; }
    public object address1_longitude { get; set; }
    public DateTime CreatedOn { get; set; }
    public int outgoingemaildeliverymethod { get; set; }
    public object address2_line2 { get; set; }
    public object entityimage_timestamp { get; set; }
    public long versionnumber { get; set; }
    public object disabledreason { get; set; }

    public override string ToString()
    {
        return FullName;
    }
}
