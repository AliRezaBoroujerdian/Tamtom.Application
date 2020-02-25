using System;
using System.Collections.Generic;
using System.Text;

namespace Tamtom.Application
{
    /// <summary>
    /// UniformResourceIdentifier
    /// </summary>
    public static class URI
    {
        private static string protocol;
        private static string domain;

        /// <summary>
        /// UniformResourceLocator
        /// </summary>
        public static string URL { get; private set; }

        /// <summary>
        /// Initialize static url
        /// </summary>
        /// <param name="protocol">http, https or ftp</param>
        /// <param name="domain">www.mysite.com</param>
        public static void Initialize(string protocol, string domain)
        {
            if (!(protocol.ToLower() == "http" | protocol.ToLower() == "https" | protocol.ToLower() == "ftp"))
                throw new ArgumentOutOfRangeException("Protocol", protocol, "http, https or ftp");

            URI.protocol = protocol.ToLower();
            URI.domain = domain.ToLower();

            URL = URI.protocol + "://" + URI.domain;
        }
    }
}