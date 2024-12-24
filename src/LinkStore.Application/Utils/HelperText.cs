using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkStore.Utils
{
    public static class HelperText
    {   
        // This method checks if the original-url sting is long enough and valid url 
        public static bool IsValidUrl(string urlString)
        {
            if (urlString.Length < 100) return false;

            try
            {
                var url = new Uri(urlString);
                return (url.Scheme == Uri.UriSchemeHttp || url.Scheme == Uri.UriSchemeHttps || url.Scheme == Uri.UriSchemeFtp) && !string.IsNullOrEmpty(url.Host);
            }
            catch
            {
                return false;
            }
        }

        // This method generates a unique 7 characters long id for the short-url 
        public static string GenerateUniqueShortId() => Convert.ToString(Guid.NewGuid()).Substring(0, 7);
    }
}
