using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;

namespace Twilio.Rest.Notify.V1.Service 
{

    public class NotificationResource : Resource 
    {
        public sealed class PriorityEnum : StringEnum 
        {
            private PriorityEnum(string value) : base(value) {}
            public PriorityEnum() {}
        
            public static readonly PriorityEnum High = new PriorityEnum("high");
            public static readonly PriorityEnum Low = new PriorityEnum("low");
        }
    
        private static Request BuildCreateRequest(CreateNotificationOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Notify,
                "/v1/Services/" + options.ServiceSid + "/Notifications",
                client.Region,
                postParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// create
        /// </summary>
        public static NotificationResource Create(CreateNotificationOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
    
        #if NET40
        public static async System.Threading.Tasks.Task<NotificationResource> CreateAsync(CreateNotificationOptions options, ITwilioRestClient client)
        {
            var response = await System.Threading.Tasks.Task.FromResult(Create(options, client));
            return response;
        }
        #endif
    
        /// <summary>
        /// create
        /// </summary>
        public static NotificationResource Create(string serviceSid, List<string> identity = null, List<string> tag = null, string body = null, NotificationResource.PriorityEnum priority = null, int? ttl = null, string title = null, string sound = null, string action = null, string data = null, string apn = null, string gcm = null, string sms = null, Object facebookMessenger = null, ITwilioRestClient client = null)
        {
            var options = new CreateNotificationOptions(serviceSid){Identity = identity, Tag = tag, Body = body, Priority = priority, Ttl = ttl, Title = title, Sound = sound, Action = action, Data = data, Apn = apn, Gcm = gcm, Sms = sms, FacebookMessenger = facebookMessenger};
            return Create(options, client);
        }
    
        #if NET40
        public static async System.Threading.Tasks.Task<NotificationResource> CreateAsync(string serviceSid, List<string> identity = null, List<string> tag = null, string body = null, NotificationResource.PriorityEnum priority = null, int? ttl = null, string title = null, string sound = null, string action = null, string data = null, string apn = null, string gcm = null, string sms = null, Object facebookMessenger = null, ITwilioRestClient client = null)
        {
            var options = new CreateNotificationOptions(serviceSid){Identity = identity, Tag = tag, Body = body, Priority = priority, Ttl = ttl, Title = title, Sound = sound, Action = action, Data = data, Apn = apn, Gcm = gcm, Sms = sms, FacebookMessenger = facebookMessenger};
            var response = await System.Threading.Tasks.Task.FromResult(Create(options, client));
            return response;
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a NotificationResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> NotificationResource object represented by the provided JSON </returns> 
        public static NotificationResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<NotificationResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }
    
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        [JsonProperty("service_sid")]
        public string ServiceSid { get; private set; }
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        [JsonProperty("identities")]
        public List<string> Identities { get; private set; }
        [JsonProperty("tags")]
        public List<string> Tags { get; private set; }
        [JsonProperty("priority")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NotificationResource.PriorityEnum Priority { get; private set; }
        [JsonProperty("ttl")]
        public int? Ttl { get; private set; }
        [JsonProperty("title")]
        public string Title { get; private set; }
        [JsonProperty("body")]
        public string Body { get; private set; }
        [JsonProperty("sound")]
        public string Sound { get; private set; }
        [JsonProperty("action")]
        public string Action { get; private set; }
        [JsonProperty("data")]
        public Object Data { get; private set; }
        [JsonProperty("apn")]
        public Object Apn { get; private set; }
        [JsonProperty("gcm")]
        public Object Gcm { get; private set; }
        [JsonProperty("sms")]
        public Object Sms { get; private set; }
        [JsonProperty("facebook_messenger")]
        public Object FacebookMessenger { get; private set; }
    
        private NotificationResource()
        {
        
        }
    }

}