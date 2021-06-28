using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppPeople
{
    /// <summary>
    /// Tips, prop + tabtab gives property
    /// ctor + tabtab gives constructor
    /// </summary>
    public class Person
    {
        static int idCounter = 0;
        public static int Counter { get { return idCounter; } }

        public readonly int id;
        //firstName, lastName and age is private
        string firstName;
        string lastName;    //Default start is null
        int age; //Default start is 0

        //We don't need to test these two because visual studio does that automaticlly
        //We made these to just Properties because they don't need to be protected
        public Gender Gender { get; set; } //Default start is the first value in the enum aka Gender.Other in this case
        public bool IsVaccinated { get; set; } //Default start is false

        //The other three fields needs some sort of checks against certain alterations,
        //thus they are private with properties that contain those checks.
        public string FirstName 
        {
            get { return firstName; }
            set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Empty or only whitespace is not allowed.");
                }

                firstName = value;
            }
        }
        public string LastName
        {
            get { return lastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Empty or only whitespace is not allowed.");
                }

                lastName = value;
            }
        }
        public string FullName { get { return firstName + ' ' + lastName;  } }
        public int Age 
        { 
            get { return age; } 
            set
            {
                if(value > -1 && value < 140)
                {
                    age = value;
                }
                else
                {
                    throw new ArithmeticException();
                }
            }
        }

        public Person(string firstName, string lastName)
        {
            id = idCounter++;
            //Gender = Gender.Other;
            //IsVaccinated = false;

            //We use the properties of first and last name to ensure the safeguards are used
            //Otherwise the constructor would be a explote to bypass them
            FirstName = firstName;
            LastName = lastName;
        }

        public Person(
            string firstName, 
            string lastName, 
            int age, 
            Gender gender, 
            bool isVaccinated
            ) : this(firstName, lastName)
        {
            Age = age;
            Gender = gender;
            IsVaccinated = isVaccinated;
        }

        public string Details()
        {
            return $"Name: {FullName}\nAge: {Age}\nGender: {Gender}\nVaccinated: {(IsVaccinated ? "Yes" : "No" )}" ;
        }

        public int resetIdCounter()
        {
            idCounter = 0;

            return idCounter;
        }
    }
}
