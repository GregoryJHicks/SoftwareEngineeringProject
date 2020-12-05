using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareEngineeringProject.Models
{
    //Takes the Json and turns it into a String that is then parsed into objects to be put into a linked list. This linked list then gets pushed to MenuItem
    public class FullMenu
    {
        public int Length { get; set; }
        private int LengthToBe { get; set; }

        public LinkedListNode<MenuItem> List;

        public bool Processing = false;

        public FullMenu()
        {
            Length = 3;
        }

        public FullMenu(int RandomThing)
        {
            Length = 0;
            //take in Json file
            //parse Json into string
            //determine how many objects are in Json file
            LengthToBe = 3; //temp value

            //Set first item in linked list to first item
            List.Value = new MenuItem("First Item");
            Length++;

            //Checks that there are still more items to be created, if not processing will stay false so the loop will never happen
            if (Length < LengthToBe)
            {
                Processing = true;
            }

            //Think maybe do for loop but unsure
        }
    }
}
