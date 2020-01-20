﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Resgrid.Model;
using Microsoft.AspNet.Identity.EntityFramework6;

namespace Resgrid.Web.Areas.User.Models.Calls
{
	public class NewCallView : BaseUserModel
	{
		public Department Department { get; set; }
		public IdentityUser User { get; set; }
		public Call Call { get; set; }
		public string Message { get; set; }
		public List<DepartmentGroup> Groups { get; set; }
		public List<IdentityUser> UnGroupedUsers { get; set; }
		public CallPriority CallPriority { get; set; }
		public SelectList CallPriorities { get; set; }
		public SelectList CallTypes { get; set; }
		public string Latitude { get; set; }
		public string Longitude { get; set; }
		public Coordinates CenterCoordinates { get; set; }
		public W3W What3Words { get; set; }
		public string What3Word { get; set; }
		public string MapCenterLatitude { get; set; }
		public string MapCenterLongitude { get; set; }
		public bool ReCalcuateCallNumbers { get; set; }
		public List<Unit> Units { get; set; }
		public List<UnitState> UnitStates { get; set; }
		public List<CustomState> UnitStatuses { get; set; }
		public SelectList CallTemplates { get; set; }
		public int CallTemplateId { get; set; }

		public NewCallView()
		{
			What3Words = new W3W();
		}
	}
}
