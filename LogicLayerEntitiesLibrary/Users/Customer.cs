using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayerEntitiesLibrary.Users
{
    public class Customer : User
    {
        private string? city, street, zipCode, shippingCity, shippingStreet, shippingZipCode, cardNumber, cardHolder;
        private DateTime? cardExpirationDate;
        private int? ccv;

        public string? City { get { return city; } private set { city = value; } }
        public string? Street { get { return city; } private set { city = value; } }
        public string? ZipCode { get { return city; } private set { city = value; } }
        public string? ShippingCity { get { return shippingCity; } private set { shippingCity = value; } }
        public string? ShippingStreet { get { return shippingStreet; } private set { shippingStreet = value; } }
        public string? ShippingZipCode { get { return shippingZipCode; } private set { shippingZipCode = value; } }
        public string? CardNumber { get { return cardNumber; } private set { cardNumber = value; } }
        public string? CardHolder { get { return cardHolder; } private set { cardHolder = value; } }
        public int? CCV { get { return ccv; } private set { ccv = value; } }
        public DateTime? ExpirationDate { get { return cardExpirationDate; } private set { cardExpirationDate = value; } }


        public Customer(string fName, string lName, string email, string password) : base(fName, lName, email, password)
        {
        }

        public Customer(int id, string fName, string lName, string email, string password) : base(id, fName, lName, email, password)
        {
        }

        public void AddAdressInformation(string? city, string? street, string? zipCode, string? shippingCity, string? shippingStreet, string? shippingZipCode) 
        {
            City = city;
            Street = street;
            ZipCode = zipCode;
            ShippingCity = shippingCity;
            ShippingStreet = shippingStreet;
            ShippingZipCode = shippingZipCode;
        }

        public void AddPaymentInformation(string? cardNumber, string? cardHolder, int? ccv, DateTime? expirationDate) 
        {
            CardNumber = cardNumber;
            CardHolder = cardHolder;
            CCV = ccv;
            ExpirationDate = expirationDate;
        }
    }
}
