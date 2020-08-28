using System;
using System.Collections.Generic;
using System.Text;

namespace JediMindTricks
{
    class Person
    {
        #region Field

        private string name;
        private byte age;

        #endregion

        #region Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public byte Age
        {
            get { return age; }
            set { age = value; }
        }

        #endregion

        #region Constructor

        public Person()
        {

        }

        public Person(string name, byte age)
        {
            this.name = name;
            this.age = age;
        }
        #endregion



    }
}
