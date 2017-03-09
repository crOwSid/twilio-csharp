using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Api.V2010.Account.Usage 
{

    /// <summary>
    /// Retrieve a list of usage-records belonging to the account used to make the request
    /// </summary>
    public class ReadRecordOptions : ReadOptions<RecordResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// Only include usage of a given category
        /// </summary>
        public RecordResource.CategoryEnum Category { get; set; }
        /// <summary>
        /// Filter by start date
        /// </summary>
        public DateTime? StartDate { get; set; }
        /// <summary>
        /// Filter by end date
        /// </summary>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Category != null)
            {
                p.Add(new KeyValuePair<string, string>("Category", Category.ToString()));
            }

            if (StartDate != null)
            {
                p.Add(new KeyValuePair<string, string>("StartDate", StartDate.Value.ToString("yyyy-MM-dd")));
            }

            if (EndDate != null)
            {
                p.Add(new KeyValuePair<string, string>("EndDate", EndDate.Value.ToString("yyyy-MM-dd")));
            }

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

}