using System;
using System.Collections.Generic;
using Twilio.Base;

namespace Twilio.Rest.Preview.Sync.Service.SyncMap 
{

    public class FetchSyncMapItemOptions : IOptions<SyncMapItemResource> 
    {
        public string ServiceSid { get; }
        public string MapSid { get; }
        public string Key { get; }
    
        /// <summary>
        /// Construct a new FetchSyncMapItemOptions
        /// </summary>
        ///
        /// <param name="serviceSid"> The service_sid </param>
        /// <param name="mapSid"> The map_sid </param>
        /// <param name="key"> The key </param>
        public FetchSyncMapItemOptions(string serviceSid, string mapSid, string key)
        {
            ServiceSid = serviceSid;
            MapSid = mapSid;
            Key = key;
        }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    public class DeleteSyncMapItemOptions : IOptions<SyncMapItemResource> 
    {
        public string ServiceSid { get; }
        public string MapSid { get; }
        public string Key { get; }
    
        /// <summary>
        /// Construct a new DeleteSyncMapItemOptions
        /// </summary>
        ///
        /// <param name="serviceSid"> The service_sid </param>
        /// <param name="mapSid"> The map_sid </param>
        /// <param name="key"> The key </param>
        public DeleteSyncMapItemOptions(string serviceSid, string mapSid, string key)
        {
            ServiceSid = serviceSid;
            MapSid = mapSid;
            Key = key;
        }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    public class CreateSyncMapItemOptions : IOptions<SyncMapItemResource> 
    {
        public string ServiceSid { get; }
        public string MapSid { get; }
        public string Key { get; }
        public Object Data { get; }
    
        /// <summary>
        /// Construct a new CreateSyncMapItemOptions
        /// </summary>
        ///
        /// <param name="serviceSid"> The service_sid </param>
        /// <param name="mapSid"> The map_sid </param>
        /// <param name="key"> The key </param>
        /// <param name="data"> The data </param>
        public CreateSyncMapItemOptions(string serviceSid, string mapSid, string key, Object data)
        {
            ServiceSid = serviceSid;
            MapSid = mapSid;
            Key = key;
            Data = data;
        }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Key != null)
            {
                p.Add(new KeyValuePair<string, string>("Key", Key));
            }
            
            if (Data != null)
            {
                p.Add(new KeyValuePair<string, string>("Data", Data.ToString()));
            }
            
            return p;
        }
    }

    public class ReadSyncMapItemOptions : ReadOptions<SyncMapItemResource> 
    {
        public string ServiceSid { get; }
        public string MapSid { get; }
        public SyncMapItemResource.QueryResultOrderEnum Order { get; set; }
        public string From { get; set; }
        public SyncMapItemResource.QueryFromBoundTypeEnum Bounds { get; set; }
    
        /// <summary>
        /// Construct a new ReadSyncMapItemOptions
        /// </summary>
        ///
        /// <param name="serviceSid"> The service_sid </param>
        /// <param name="mapSid"> The map_sid </param>
        public ReadSyncMapItemOptions(string serviceSid, string mapSid)
        {
            ServiceSid = serviceSid;
            MapSid = mapSid;
        }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Order != null)
            {
                p.Add(new KeyValuePair<string, string>("Order", Order.ToString()));
            }
            
            if (From != null)
            {
                p.Add(new KeyValuePair<string, string>("From", From));
            }
            
            if (Bounds != null)
            {
                p.Add(new KeyValuePair<string, string>("Bounds", Bounds.ToString()));
            }
            
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            
            return p;
        }
    }

    public class UpdateSyncMapItemOptions : IOptions<SyncMapItemResource> 
    {
        public string ServiceSid { get; }
        public string MapSid { get; }
        public string Key { get; }
        public Object Data { get; }
    
        /// <summary>
        /// Construct a new UpdateSyncMapItemOptions
        /// </summary>
        ///
        /// <param name="serviceSid"> The service_sid </param>
        /// <param name="mapSid"> The map_sid </param>
        /// <param name="key"> The key </param>
        /// <param name="data"> The data </param>
        public UpdateSyncMapItemOptions(string serviceSid, string mapSid, string key, Object data)
        {
            ServiceSid = serviceSid;
            MapSid = mapSid;
            Key = key;
            Data = data;
        }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Data != null)
            {
                p.Add(new KeyValuePair<string, string>("Data", Data.ToString()));
            }
            
            return p;
        }
    }

}