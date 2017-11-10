﻿using DotnetSpider.Enterprise.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DotnetSpider.Enterprise.Domain.Entities
{
	public class NodeHeartbeat : AuditedEntity<long>
	{
		[Required]
		[StringLength(50)]
		public virtual string NodeId { get; set; }
		[StringLength(50)]
		public virtual string Ip { get; set; }
		public virtual int CpuLoad { get; set; }
		public virtual long FreeMemory { get; set; }
		public virtual long TotalMemory { get; set; }
		public virtual int ProcessCount { get; set; }
		[StringLength(50)]
		public virtual string Os { get; set; }
		[StringLength(50)]
		public virtual string Version { get; set; }
	}
}
