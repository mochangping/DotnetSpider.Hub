﻿using AutoMapper;
using DotnetSpider.Enterprise.Application.Node.Dto;
using DotnetSpider.Enterprise.Application.Task.Dtos;
using DotnetSpider.Enterprise.Domain;
using DotnetSpider.Enterprise.Domain.Entities;

namespace DotnetSpider.Enterprise.Application
{
	public class AutoMapperConfiguration
	{
		public static void CreateMap()
		{
			Mapper.Initialize((config) =>
			{
				config.CreateMap<TaskDto, Domain.Entities.Task>();
				config.CreateMap<Domain.Entities.Task, TaskDto>();
				config.CreateMap<NodeHeartbeatInputDto, NodeHeartbeat>();
				config.CreateMap<MessageHistory, Domain.Entities.Message>();
				config.CreateMap<Domain.Entities.Node, NodeOutputDto>();
				//config.CreateMap<BuildLog, BuildLogDto>();
				//config.CreateMap<NodeStatus, NodeStatusDto>();
				//config.CreateMap<TaskLog, TaskLogDto>();
				//config.CreateMap<ExecuteLog, ExecuteLogDto>();
			});
		}
	}
}
