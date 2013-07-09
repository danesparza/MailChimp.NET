using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using MailChimp.Errors;
using MailChimp.Helper;
using ServiceStack.Text;

namespace MailChimp
{
    /// <summary>
    /// .NET API Wrapper for the Mailchimp v2.0 API.  
    /// More information here: http://apidocs.mailchimp.com/api/2.0/
    /// </summary>
    public class MailChimp
    {
        #region Fields and properties
        
        /// <summary>
        /// The HTTPS endpoint for the API.  
        /// See http://apidocs.mailchimp.com/api/2.0/#api-endpoints for more information
        /// </summary>
        private string _httpsUrl = "https://{0}.api.mailchimp.com/2.0/{1}.json";

        /// <summary>
        /// The datacenter prefix.  This will be automatically determined
        /// based on your API key
        /// </summary>
        private string _dataCenterPrefix = string.Empty; 

        #endregion

        #region Constructors and API key

        //  Default constructor
        public MailChimp()
        {

        }

        /// <summary>
        /// Get the datacenter prefix based on the API key passed
        /// </summary>
        /// <param name="apiKey">v2.0 Mailchimp API key</param>
        /// <returns></returns>
        private string GetDatacenterPrefix(string apiKey)
        {
            //  The key should contain a '-'.  If it doesn't, throw an exception:
            if(!apiKey.Contains('-'))
            {
                throw new ArgumentException("API key is not valid.  Must be a valid v2.0 Mailchimp API key.");
            }

            return apiKey.Split('-')[1];
        }

        /// <summary>
        /// Create an instance of the wrappper with your API key
        /// </summary>
        /// <param name="apiKey">The MailChimp API key to use</param>
        public MailChimp(string apiKey)
            : this()
        {
            this.APIKey = apiKey;
            this._dataCenterPrefix = GetDatacenterPrefix(apiKey);
        }

        /// <summary>
        /// Gets / sets your API key for all operations.  
        /// For help getting your API key, please see 
        /// http://kb.mailchimp.com/article/where-can-i-find-my-api-key
        /// </summary>
        public string APIKey
        {
            get;
            set;
        } 

        #endregion

        #region API: Helper
        
        /// <summary>
        /// Retrieve lots of account information including payments made, plan info, 
        /// some account stats, installed modules, contact info, and more. No private 
        /// information like Credit Card numbers is available.
        /// More information: http://apidocs.mailchimp.com/api/2.0/helper/account-details.php
        /// </summary>
        /// <param name="exclude">Allows controlling which extra arrays are returned since they can 
        /// slow down calls. Valid keys are "modules", "orders", "rewards-credits", 
        /// "rewards-inspections", "rewards-referrals", "rewards-applied", "integrations". 
        /// Hint: "rewards-referrals" is typically the culprit. To avoid confusion, 
        /// if data is excluded, the corresponding key will not be returned at all.</param>
        /// <returns></returns>
        public AccountDetails GetAccountDetails(string[] exclude = null)
        {
            //  Our api action:
            string apiAction = "helper/account-details";

            //  Create our arguments object:
            object args = new
            {
                apikey = this.APIKey,
                exclude = exclude
            };

            //  Make the call:
            return MakeAPICall<AccountDetails>(apiAction, args);
        }

        /// <summary>
        /// Retrieve minimal data for all Campaigns a member was sent
        /// </summary>
        /// <param name="emailParam">An object a with one fo the following keys: email, euid, leid. Failing to provide anything will produce an error relating to the email address</param>
        /// <param name="filterListId">A list_id to limit the campaigns to</param>
        /// <returns>an array of structs containing campaign data for each matching campaign</returns>
        public List<CampaignForEmail> GetCampaignsForEmail(EmailParameter emailParam, string filterListId = "")
        {
            //  Our api action:
            string apiAction = "helper/campaigns-for-email";

            //  Create our arguments object:
            object args = new
            {
                apikey = this.APIKey,
                email = emailParam,
                options = new
                {
                    list_id = filterListId
                }
            };

            //  Make the call:
            return MakeAPICall<List<CampaignForEmail>>(apiAction, args);
        }

        /// <summary>
        /// Retrieve minimal List data for all lists a member is subscribed to.
        /// </summary>
        /// <param name="emailParam">An object a with one fo the following keys: email, euid, leid. Failing to provide anything will produce an error relating to the email address</param>
        /// <returns></returns>
        public List<ListForEmail> GetListsForEmail(EmailParameter emailParam)
        {
            //  Our api action:
            string apiAction = "helper/lists-for-email";

            //  Create our arguments object:
            object args = new
            {
                apikey = this.APIKey,
                email = emailParam
            };

            //  Make the call:
            return MakeAPICall<List<ListForEmail>>(apiAction, args);
        }

        /// <summary>
        /// Return the current Chimp Chatter messages for an account.
        /// </summary>
        /// <returns></returns>
        public List<ChimpChatterMessage> GetChimpChatter()
        {
            //  Our api action:
            string apiAction = "helper/chimp-chatter";

            //  Create our arguments object:
            object args = new
            {
                apikey = this.APIKey
            };

            //  Make the call:
            return MakeAPICall<List<ChimpChatterMessage>>(apiAction, args);
        }

        /// <summary>
        /// "Ping" the MailChimp API - a simple method you can call that will 
        /// return a constant value as long as everything is good. Note than unlike 
        /// most all of our methods, we don't throw an Exception if we are having 
        /// issues. You will simply receive a different string back that will explain 
        /// our view on what is going on.
        /// </summary>
        /// <returns></returns>
        public PingMessage Ping()
        {
            //  Our api action:
            string apiAction = "helper/ping";

            //  Create our arguments object:
            object args = new
            {
                apikey = this.APIKey
            };

            //  Make the call:
            return MakeAPICall<PingMessage>(apiAction, args);
        }

        #endregion

        #region Generic API calling method
        
        /// <summary>
        /// Generic API call.  Expects to be able to serialize the results
        /// to the specified type
        /// </summary>
        /// <typeparam name="T">The specified results type</typeparam>
        /// <param name="apiAction">The API action.  Example: helper/account-details</param>
        /// <param name="args">The object that will be serialized as the JSON parameters to the API call</param>
        /// <returns></returns>
        private T MakeAPICall<T>(string apiAction, object args)
        {
            //  First, make sure the datacenter prefix is set properly.  
            //  If it's not, throw an exception:
            if(string.IsNullOrEmpty(_dataCenterPrefix))
                throw new ApplicationException("API key not valid (datacenter not specified)");

            //  Next, construct the full url based on the passed apiAction:
            string fullUrl = string.Format(_httpsUrl, _dataCenterPrefix, apiAction);

            //  Initialize the results to return:
            T results = default(T);

            try
            {
                //  Call the API with the passed arguments:
                results = fullUrl.PostJsonToUrl(args).FromJson<T>();
            }
            catch(Exception ex)
            {
                var knownError = ex.IsBadRequest()
                || ex.IsNotFound()
                || ex.IsUnauthorized()
                || ex.IsForbidden()
                || ex.IsInternalServerError();

                var isAnyRedirectionError = ex.IsAny300();
                var isAnyClientError = ex.IsAny400();
                var isAnyServerError = ex.IsAny500();

                HttpStatusCode? errorStatus = ex.GetStatus();
                string errorBody = ex.GetResponseBody();

                //  Serialize the error information:
                ApiError apiError = errorBody.FromJson<ApiError>();

                //  Throw a new exception based on this information:
                throw new MailChimpAPIException(apiError.Error, ex, apiError);
            }

            //  Return the results
            return results;
        } 

        #endregion

    }
}
