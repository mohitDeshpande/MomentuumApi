using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using MomentuumApi.Model;

namespace MomentuumApi.Utils
{
    /// <summary>
    /// Static class for JWT helper methods
    /// </summary>
    public class JwtHelper
    {
        public JwtHelper()
        {
        }

        /// <summary>
        /// Gets the username from the given collection of claims.
        /// If the user is not found in the claim then a KeyNotFoundException is thrown. Should be handled by the caller!
        /// </summary>
        ///
        /// <returns>The username</returns>
        /// <param name="claims">Jwt Token Claims</param>
        public static string GetUser(IEnumerable<Claim> claims)
        {
            string user = claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value;

            if (user == null)
            {
                throw new KeyNotFoundException("Username does not exist in the claim");
            }

            return user;
        }
        
    }
}