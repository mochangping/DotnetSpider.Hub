﻿using System;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace DotnetSpider.Enterprise.Core.Configuration
{
	public class CommonConfiguration : ICommonConfiguration
	{
		public IConfigurationRoot AppConfiguration { get; set; }

		public CommonConfiguration()
		{
			if (File.Exists(Path.Combine(AppContext.BaseDirectory, "domain")))
			{
				HostUrl = File.ReadAllLines("domain")[0];
			}
		}

		public string MsSqlConnectionString
		{
			get
			{
				var connectionStrings = AppConfiguration.GetSection("ConnectionStrings");
				return connectionStrings.GetValue<string>(DotnetSpiderConsts.ConnectionName);
			}
		}

		public string MySqlConnectionString
		{
			get
			{
				var connectionStrings = AppConfiguration.GetSection("ConnectionStrings");
				return connectionStrings.GetValue<string>(DotnetSpiderConsts.MySqlConnectionName);
			}
		}

		public string LogMongoConnectionString
		{
			get
			{
				var logMongoConnectionString = AppConfiguration.GetSection("ConnectionStrings");
				return logMongoConnectionString.GetValue<string>(DotnetSpiderConsts.LogMongoConnectionName);
			}
		}

		public string SchedulerUrl
		{
			get
			{
				var section = AppConfiguration.GetSection(DotnetSpiderConsts.DefaultSetting);
				return section.GetValue<string>(DotnetSpiderConsts.SchedulerUrl);
			}
		}

		public string SchedulerCallbackHost
		{
			get
			{
				var section = AppConfiguration.GetSection(DotnetSpiderConsts.DefaultSetting);
				return section.GetValue<string>(DotnetSpiderConsts.SchedulerCallbackHost);
			}
		}

		public string HostUrl { get; set; }

		public byte[] SqlEncryptKey { get; set; }
		
		public string[] Tokens { get; set; }
	}
}
