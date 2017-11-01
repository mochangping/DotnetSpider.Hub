﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace DotnetSpider.Enterprise.Web.Configuration
{
    public class AuthConfigure
    {
		public const string AuthenticationScheme = "DotnetSpiderEnterpriseSchema";

		/// <summary>
		/// Configures the specified application.
		/// </summary>
		/// <param name="app">The application.</param>
		/// <param name="configuration">The configuration.</param>
		public static void Configure(IApplicationBuilder app, IConfiguration configuration)
		{
			//app.ConfigureApplicationCookie(new CookieAuthenticationOptions()
			//{
			//	AuthenticationScheme = AuthenticationScheme,
			//	LoginPath = new PathString("/Account/Login/"),
			//	AccessDeniedPath = new PathString("/Error/E403"),
			//	AutomaticAuthenticate = true,
			//	AutomaticChallenge = true
			//});

			//if (bool.Parse(configuration["Authentication:Microsoft:IsEnabled"]))
			//{
			//	app.UseMicrosoftAccountAuthentication(CreateMicrosoftAuthOptions(configuration));
			//}

			//if (bool.Parse(configuration["Authentication:Google:IsEnabled"]))
			//{
			//	app.UseGoogleAuthentication(CreateGoogleAuthOptions(configuration));
			//}

			//if (bool.Parse(configuration["Authentication:Twitter:IsEnabled"]))
			//{
			//	app.UseTwitterAuthentication(CreateTwitterAuthOptions(configuration));
			//}

			//if (bool.Parse(configuration["Authentication:Facebook:IsEnabled"]))
			//{
			//	app.UseFacebookAuthentication(CreateFacebookAuthOptions(configuration));
			//}

			//if (bool.Parse(configuration["Authentication:JwtBearer:IsEnabled"]))
			//{
			//	ConfigureJwtBearerAuthentication(app, configuration);
			//}
		}
	}

}

