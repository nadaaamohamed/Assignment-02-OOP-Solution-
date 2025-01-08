using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_02_OOP
{
    internal struct Person
    {
        #region Attrbuites
        private string name;
        private int age;
        #endregion
        #region Constructor
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        #endregion

        #region Properties

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Name : {name} , Age : {age}";
        } 

        
        #endregion


    }
}