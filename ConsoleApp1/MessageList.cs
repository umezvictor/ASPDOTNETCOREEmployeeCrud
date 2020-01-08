using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    // this class is a child of textualmessage class
    class MessageList : TextualMessage
    {
        // create enum to hold the bullet types needed
        private enum BulletType { Dashed, Numbered, Star } // only accessible by this class
        private BulletType bulletType; // a field of type BulletType, defines if the bullet type will be dashed, start, etc

        // override Input method in textualmessage -- virtual method
        public override IPageable Input()
        {
            return this;
        }

    }
}
