using System;
using System.Runtime.Serialization;

namespace Contacts {
   
    [DataContract]
    internal class Contact {
        string firstName;
        string lastName;
        string secondName;
        string city;
       string street;
       
        [DataMember]
        public string FirstName { get=>firstName; set {
                firstName = string.Concat(value[0].ToString().ToUpper(), value.AsSpan(1));
            } }
        [DataMember]
        public string LastName {
            get => lastName; set {
                if (value != "") lastName = string.Concat(value[0].ToString().ToUpper(), value.AsSpan(1));
                else lastName = value; 
            }
        }
        [DataMember]
        public string SecondName { get => secondName; set {
                if (value != "") secondName = string.Concat(value[0].ToString().ToUpper(), value.AsSpan(1));
                else secondName = value;
            }
        }
        [DataMember]
        public string Phone { get; set; }
        [DataMember]
        public string City { get=> city; set {
                if (value != "") city = string.Concat(value[0].ToString().ToUpper(), value.AsSpan(1));
                else city = value;
            } 
        }
        [DataMember]
        public string Street { get=> street; set {
                if (value != "") street = string.Concat(value[0].ToString().ToUpper(), value.AsSpan(1));
                else street = value;
            } 
        }
        [DataMember]
        public string? HouseNum { get; set; }
        [DataMember]
        public string? Apartment { get; set; }

        public Contact(string firstName, string lastName = "", string secondName = "", string phone = "",
               string city = "", string street = "", string houseNum = "", string apartment = "") {
               FirstName = firstName;
               LastName = lastName;
               SecondName = secondName; 
               Phone = phone;
               City = city;
               Street = street; 
               HouseNum = houseNum;
               Apartment = apartment;
        }
        public override string ToString() {
            return $"{FirstName} {SecondName} {LastName} ";
        }
       
    }
}
