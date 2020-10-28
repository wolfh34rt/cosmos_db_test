using System;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace SixWolfMedia.DB.Models
{
    [Owned]
    public class Facility
    {
        [JsonProperty("facility_id")]
        public int Id { get; set; }

        [JsonProperty("merchant_id")]
        public int MerchantId { get; set; }

        [JsonProperty("facility_name")]
        public string FacilityName { get; set; }

        [JsonProperty("partition_key")]
        public string PartitionKey { get; set; }


        public Facility(int facilityId, int merchantId, string facilityName, string partitionKey) => 
            (Id,MerchantId,FacilityName,PartitionKey) = (facilityId,merchantId,facilityName,partitionKey);

        public Facility(){}

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}