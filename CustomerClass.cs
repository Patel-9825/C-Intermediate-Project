/* 
 * Author: Dhruv Patel
 * Date: July 11, 2021
 * Title: Lab 4 for NETD class.
 * Sub-Title:  CustomerClass Class Definition for lab4
 * Description: This file stores the properties and constructors as public and are 
 *              implemented in main lab4 file.
 * */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectDhruvP
{
    class CustomerClass
    {
        #region Properties

        // Properties are called here in CustomerClass which is made in separate file.
        public int Count { get; set; }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAdress { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime Date { get; set; }
        public Boolean ContactStatus { get; set; }

        #endregion

        #region Constructors

        // Constructors are made here for every textboxes and other tools used.
        public CustomerClass()
        {
            Count += 1;
            Id = Count;
        }

        // Parameterised Constructor
        public CustomerClass(int id, String firstName, String lastName, String emailAddress, String phoneNumber,
                             DateTime date, Boolean contactStatus)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            EmailAdress = emailAddress;
            PhoneNumber = phoneNumber;
            Date = date;
            ContactStatus = contactStatus;
        }

        #endregion



    }
}
