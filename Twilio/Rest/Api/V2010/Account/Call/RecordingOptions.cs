using System;
using System.Collections.Generic;
using Twilio.Base;

namespace Twilio.Rest.Api.V2010.Account.Call 
{

    public class FetchRecordingOptions : IOptions<RecordingResource> 
    {
        public string AccountSid { get; set; }
        public string CallSid { get; }
        public string Sid { get; }
    
        /// <summary>
        /// Construct a new FetchRecordingOptions
        /// </summary>
        ///
        /// <param name="callSid"> The call_sid </param>
        /// <param name="sid"> The sid </param>
        public FetchRecordingOptions(string callSid, string sid)
        {
            CallSid = callSid;
            Sid = sid;
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

    public class DeleteRecordingOptions : IOptions<RecordingResource> 
    {
        public string AccountSid { get; set; }
        public string CallSid { get; }
        public string Sid { get; }
    
        /// <summary>
        /// Construct a new DeleteRecordingOptions
        /// </summary>
        ///
        /// <param name="callSid"> The call_sid </param>
        /// <param name="sid"> The sid </param>
        public DeleteRecordingOptions(string callSid, string sid)
        {
            CallSid = callSid;
            Sid = sid;
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

    public class ReadRecordingOptions : ReadOptions<RecordingResource> 
    {
        public string AccountSid { get; set; }
        public string CallSid { get; }
        public string DateCreated { get; set; }
    
        /// <summary>
        /// Construct a new ReadRecordingOptions
        /// </summary>
        ///
        /// <param name="callSid"> The call_sid </param>
        public ReadRecordingOptions(string callSid)
        {
            CallSid = callSid;
        }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (DateCreated != null)
            {
                p.Add(new KeyValuePair<string, string>("DateCreated", DateCreated));
            }
            
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            
            return p;
        }
    }

}