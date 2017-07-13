using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name: Gabriel Norman
 * Date: July 11, 2017
 * Description: Lab 24 for Comp123
 * Version: 0.2 Created the Supervillian class and the IHasMaliceClass
 */
namespace COMP123_S2017_Lesson9B
{
    public class SuperVillian : SuperHuman, IHasMalice
    {
        //Private Instance Variables 

        private int _malice;

        // public properties
        public int Malice
        {
            
            get { return this._malice; } set { this._malice = value; }
        }

        //Constructor; 

        /// <summary>
        /// this is the constructor for the supervillian class
        /// </summary>
        /// <param name="power"></param>
        /// <param name="name"></param>
        public SuperVillian(string name, int malice)
        : base(name)
        {
            this.Malice = malice;

        }
    }

    
   
   
    

}
