using Newtonsoft.Json;

namespace KoenZomers.UniFi.Api.Responses

{
    /// <summary>
    /// Site stats base object
    /// </summary>
    public class SiteState : BaseResponse
    {
        /// <summary>
        /// Identifier
        /// </summary>
        [JsonProperty(PropertyName = "_id")]
        public string Identifier { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [JsonProperty(PropertyName = "desc")]
        public string Description { get; set; }

        /// <summary>
        /// Collection of health stats for subsystems
        /// </summary>
        [JsonProperty(PropertyName = "health")]
        public Health[] Health { get; set; }

        /// <summary>
        /// Number of new alarms
        /// </summary>
        [JsonProperty(PropertyName = "num_new_alarms")]
        public int NewAlarms { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class Health
    {
        /// <summary>
        /// Name of the subsystem
        /// </summary>
        [JsonProperty(PropertyName = "subsystem")]
        public string SubsystemName { get; set; }

        /// <summary>
        /// Status of the subsystem
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }
    }
}