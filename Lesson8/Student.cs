using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    /// <summary>
    /// This is the student class
    /// </summary>
     public class Student : Person
    {
        // PRIVATE INSTANCE VARIABLES(FIELDS)
        private string _studentID;
        // PUBLIC PROPERTIES
        public string studentID
        {
            get
            {
                return this._studentID = studentID;
            }
            set
            {
                this._studentID = studentID;
            }
        }

        //CONSTRUCTORS----------------------
        /// <summary>
        /// This is the constructor for the student class.It takes three arguments
        /// name(string) - age(int) and studentID(string)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="studentID"></param>
        public Student(string name,int age, string studentID)
            :base(name,age)
        {
            this._studentID = studentID;
        }
        //PUBLIC METHODS ------------------
        /// <summary>
        /// This is the studies method
        /// </summary>
        public void Studies()
        {
            Console.WriteLine(this.Name + "is studying!");
        }
        
    }
}
