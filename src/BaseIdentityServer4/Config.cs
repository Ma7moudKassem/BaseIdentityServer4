// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4.Models;
using BaseIdentityServer4.Constants;
using System.Collections.Generic;

namespace BaseIdentityServer4
{
    public static class Config
    {
        public static IEnumerable<IdentityResource> IdentityResources =>
            new IdentityResource[]
            { 
                new IdentityResources.OpenId()
            };

        public static IEnumerable<ApiScope> ApiScopes =>
            new ApiScope[]
            {
                new ApiScope(CONSTANT_API_SCOPE.ECOMMERCE,"ECommerce Api"),
                new ApiScope(CONSTANT_API_SCOPE.MOBILE,"Mobile Api"),
                new ApiScope(CONSTANT_API_SCOPE.ADMIN_DASHBOARD,"Admin Dashboard Api"),
            };

        public static IEnumerable<Client> Clients =>
            new Client[] 
            {
                new Client
                {
                    ClientId = CONSTANT_CLIENT_IDS.ECOMMERCE,
                    ClientSecrets = { new Secret(CONSTANT_CLIENT_SECRET.ECOMMERCE.Sha256()),},
                    AllowedScopes = { CONSTANT_API_SCOPE.ECOMMERCE },
                },
                new Client
                {
                    ClientId = CONSTANT_CLIENT_IDS.MOBILE,
                    ClientSecrets = { new Secret(CONSTANT_CLIENT_SECRET.MOBILE.Sha256()),},
                    AllowedScopes = { CONSTANT_API_SCOPE.MOBILE },
                },
                new Client
                {
                    ClientId = CONSTANT_CLIENT_IDS.ADMIN_DASHBOARD,
                    ClientSecrets = { new Secret(CONSTANT_CLIENT_SECRET.ADMIN_DASHBOARD.Sha256()),},
                    AllowedScopes = { CONSTANT_API_SCOPE.ADMIN_DASHBOARD },
                },
            };
    }
}