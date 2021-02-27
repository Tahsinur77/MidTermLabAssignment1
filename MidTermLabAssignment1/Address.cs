using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermLabAssignment1
{
    class Address
    {
        private string roadNo;
        private string houseNo;
        private string city;
        private string country;

        public Address(string roadNo,string houseNo,string city,string country)
        {
            this.roadNo = roadNo;
            this.houseNo = houseNo;
            this.city = city;
            this.country = country;
        }
       

        public string RoadNo
        {
            set { this.roadNo = value; }
            get { return this.roadNo; }
        }
        public string HouseNo
        {
            set { this.houseNo = value; }
            get { return this.houseNo; }
        }
        public string City
        {
            set { this.city = value; }
            get { return this.city; }
        }
        public string Country
        {
            set { this.country = value; }
            get { return this.country; }
        }

        public string GetAddress()
        {
            // Console.WriteLine("Address =>");
            // Console.WriteLine("\tRoad No. : {0} \n\tHouse No. : {1}\n\tCity : {2}\n\tCountry : {3}",roadNo,houseNo,city,country);
            string x = "\t\t||\tAddress : \n\t\t||\t\tRoad no.: "+roadNo + "\n\t\t||\t\tHouse no.: " + houseNo + "\n\t\t||\t\tCity: " + city + "\n\t\t||\t\tCountry: " + country;
            return x;
        }
    }
}
