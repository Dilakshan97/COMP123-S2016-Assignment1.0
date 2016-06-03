/*
 *Author: Dilakshan Packiyanathan
 *Last Modified on June 3rd 2016
 *Program Description: Create a Hero class with strength, speed, health and name properties. Assign a random 
 *                     number between 1 and 100 to the abilities.
 *                     determine the damage if hero hits the target and display appropriate messages to the 
 *                     console. 

 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Assignment1._0
{
    class Hero
    {
        //PRIVATE INSTANCE VARIABLES+++++++++++++++++++++++++++++++++++++++++++++++
        private int _streanth;
        private int _speed;
        private int _health;
        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }

        }


        //ABILITIES GENERATED++++++++++++++++++++++++++++++++++++++++++++++++++
        private void _generateAblities()
        {
            Random random = new Random();
            _streanth = random.Next(1, 101);
            _speed = random.Next(1, 101);
            _health = random.Next(1, 101);
        }
    }
}
