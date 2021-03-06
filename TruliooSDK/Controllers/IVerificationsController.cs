using System.Threading.Tasks;
using TruliooSDK.Models;

namespace TruliooSDK.Controllers
{
    public interface IVerificationsController
    {

        /// <summary>
        /// Calling this method will perform a verification. If your account includes address cleansing set the CleansedAddress flag to get
        /// additional address information in the result.  You can query configuration to get what fields are available to you in each country.
        /// It is also possible to get sample requests from the customer portal. If you are configured for a sandbox account make sure to call Get Test Entities to get test data for a country you want to try. Sandbox accounts only use these test entities and so trying to verify with any other data will result in no matches being found.
        /// </summary>
        /// <param name="body">Required parameter: Example: </param>
        /// <return>Returns the Models.VerifyResult response from the API call</return>
        Task<VerifyResult> CreateVerifyAsync(VerifyRequest body);

        /// <summary>
        /// This method is used to retrieve the request and results of a verification performed using the verify method. 
        /// The response for this method includes the same information as verify method's response, along with data present in the input fields of the verify request.
        /// </summary>
        /// <param name="id">Required parameter: The TransactionRecordID from the Verify response, this will be a GUID</param>
        /// <return>Returns the Models.TransactionRecordResult response from the API call</return>
        Task<TransactionRecordResult> GetTransactionRecordAsync(string id);

    }
} 
