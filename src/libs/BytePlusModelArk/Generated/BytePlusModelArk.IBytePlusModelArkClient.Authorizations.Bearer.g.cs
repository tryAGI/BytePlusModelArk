
#nullable enable

namespace BytePlusModelArk
{
    public partial interface IBytePlusModelArkClient
    {
        /// <summary>
        /// Authorize using bearer authentication.
        /// </summary>
        /// <param name="apiKey"></param>

        public void AuthorizeUsingBearer(
            string apiKey);
    }
}