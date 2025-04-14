using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_dziedziczenie 
{
	internal class Driver : Employee
	{
		public string? drivingLicense = "";

		public Driver() { }

		public Driver(string _drivingLicense)
		{
			drivingLicense= _drivingLicense;
		}
		public enum drivingLicenseCategories { a,b,c,d};

		List<drivingLicenseCategories> drivingLicenseCategory = new List<drivingLicenseCategories>();

		public Driver(string firstName, string lastName, float height, float weight, string workplace, float ratePerHour, ushort numberOfWorkHours, drivingLicenseCategories drivingLicenseCategory) 
		{
			this.drivingLicenseCategory.Add(drivingLicenseCategory);
		}

		public string showDrivingLicenses()
		{
			string licenses = "";

			foreach (drivingLicenseCategories license in drivingLicenseCategory)
			{
				licenses += license;
			}
			return licenses
		}

		public new string info()
		{
			return base.Info()+ ", kategoria prawa jazdy: " + showDrivingLicenses();
		}
	}
}
