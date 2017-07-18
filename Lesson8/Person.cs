using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    /// <summary>
    /// This is the Person super class
    /// </summary>
   public  class Person
    {
        // PRIVATE INSTANCE VARIABLES (FIELDS)
        private string _name;
        private int _age;
        // PUBLIC PROPERTIES -----------------------------------------------
        public string Name
        {
            get
            {
                return this._name;
            }

            set
            {
                this._name = value;
            }
        }
        public int Age
        {
            get
            {
                return this._age;
            }
            set
            {
                this._age = value;
            }
        }
        // CONSTRUCTORS-------------------------
        /// <summary>
        /// This is the constructor for the Person class. The constructor 
        /// requires two arguments - name (string) and age (int).
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        public Person(string name,int age)
        {
            this._name = name;
            this._age = age;
        }
        // PUBLIC METHODS--------------------------
        /// <summary>
        /// This method enables the Person to talk
        /// </summary>
        public void Talks()
        {
            Console.WriteLine(this._name + " is talking!");
        }
    }
}

