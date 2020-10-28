using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SixWolfMedia.DB.Models
{
    public class Merchant
    {
        [JsonProperty("merchantId")]
        public int Id { get; set; }

        public string PartitionKey { get; set; }

        [JsonProperty("is_company")]
        public string IsCompany { get; set; }

        [JsonProperty("company_name")]
        public string CompanyName { get; set; }

        [JsonProperty("prefix")]
        public string Prefix { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("middle_initial")]
        public string MiddleInitial { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("suffix")]
        public string Suffix { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("mobile_phone")]
        public string MobilePhone { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("fax")]
        public string Fax { get; set; }

        [JsonProperty("send_email")]
        public string SendEmail { get; set; }

        [JsonProperty("email_category")]
        public string EmailCategory { get; set; }

        [JsonProperty("pref_language")]
        public string PrefLanguage { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("bill_addr_name")]
        public string BillAddrName { get; set; }

        [JsonProperty("pay_terms")]
        public string PayTerms { get; set; }

        [JsonProperty("inactive")]
        public string Inactive { get; set; }

        [JsonProperty("inactive_date")]
        public string InactiveDate { get; set; }

        [JsonProperty("enroll_date")]
        public string EnrollDate { get; set; }

        [JsonProperty("customer_ship")]
        public string CustomerShip { get; set; }

        [JsonProperty("track_equipment")]
        public string TrackEquipment { get; set; }

        [JsonProperty("track_history")]
        public string TrackHistory { get; set; }

        [JsonProperty("created_on")]
        public string CreatedOn { get; set; }

        [JsonProperty("created_by")]
        public string CreatedBy { get; set; }

        [JsonProperty("modified_on")]
        public string ModifiedOn { get; set; }

        [JsonProperty("modified_by")]
        public string ModifiedBy { get; set; }

        [JsonProperty("facilities")]
        public ICollection<Facility> Facilities { get; set; }

        public Merchant() { }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}