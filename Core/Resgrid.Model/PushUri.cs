﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNet.Identity.EntityFramework6;
using ProtoBuf;

namespace Resgrid.Model
{
	[ProtoContract]
	[Table("PushUris")]
	public class PushUri : IEntity
	{
		private string _pushLocation;

		[Key]
		[Required]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[ProtoMember(1)]
		public int PushUriId { get; set; }

		[Required]
		[ProtoMember(2)]
		public string UserId { get; set; }

		[ForeignKey("UserId")]
		public virtual IdentityUser User { get; set; }

		[Required]
		[ProtoMember(3)]
		public int PlatformType { get; set; }

		[MaxLength(500)]
		[ProtoMember(4)]
		public string DeviceId { get; set; }

		[Required]
		public string PushLocation
		{
			get { return _pushLocation; }
			set
			{
				if (_pushLocation != value)
				{
					_pushLocation = value;

					if (((Platforms)PlatformType) == Platforms.Windows8 || ((Platforms)PlatformType) == Platforms.WindowsPhone7 || ((Platforms)PlatformType) == Platforms.WindowsPhone8 || ((Platforms)PlatformType) == Platforms.UnitWin)
						ChannelUri = new Uri(_pushLocation, UriKind.Absolute);
				}
			}
		}

		[ProtoMember(5)]
		public int? UnitId { get; set; }

		[NotMapped]
		public Uri ChannelUri { get; private set; }

		[NotMapped]
		[ProtoMember(8)]
		public string Uuid { get; set; }

		[NotMapped]
		[ProtoMember(7)]
		public int DepartmentId { get; set; }

		[Required]
		[ProtoMember(6)]
		public DateTime CreatedOn { get; set; }

		[NotMapped]
		public object Id
		{
			get { return PushUriId; }
			set { PushUriId = (int)value; }
		}
	}
}
