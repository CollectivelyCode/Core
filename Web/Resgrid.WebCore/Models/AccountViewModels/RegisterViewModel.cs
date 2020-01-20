﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Resgrid.Web.Models.AccountViewModels
{
	public class RegisterViewModel
	{
		[Required]
		[Display(Name = "FirstName")]
		public string FirstName { get; set; }

		[Required]
		[Display(Name = "LastName")]
		public string LastName { get; set; }

		[Required]
		[Display(Name = "Username")]
		public string Username { get; set; }
		
		[Required]
		[Display(Name = "Department Name")]
		public string DepartmentName { get; set; }

		[Display(Name = "Department Type")]
		public string DepartmentType { get; set; }

		[Required]
		[EmailAddress]
		[Display(Name = "Email")]
		public string Email { get; set; }

		[Required]
		[StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
		[DataType(DataType.Password)]
		[Display(Name = "Password")]
		public string Password { get; set; }

		[DataType(DataType.Password)]
		[Display(Name = "Confirm password")]
		[Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
		public string ConfirmPassword { get; set; }

		public IEnumerable<string> DepartmentTypes = new List<string>() { "Volunteer Fire", "Career Fire", "Search and Rescue", "HAZMAT", "EMS", "CERT", "Public Safety", "Disaster Response", "Relief Org", "Security", "Repair Services", "Delivery Services", "Oil and Gas", "Power", "Chemical", "Nuclear", "Other Industrial", "Other Private", "Other Public", "Other" };
	}
}
