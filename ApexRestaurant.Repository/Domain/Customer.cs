using System;

namespace ApexRestaurant.Repository.Domain
{
    public class Customer
    {
        public int Customer_ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string PhoneRes { get; set; }

        public string PhoneMob { get; set; }

        public DateTime EnrollDate { get; set; }

        public bool IsActive { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedOn { get; set; }

        public string UpdatedBy { get; set; }

        public DateTime UpdatedOn { get; set; }

    }
}