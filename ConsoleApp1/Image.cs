using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Image : IPageable
    {
        // create field of PageData in the image class
        private PageData myData; // myData is the field
        // we need a way for image class to hold some string of characters that reps the image
        // create a string field
        private string asciiImage;
        
        public IPageable Input()
        {
            throw new NotImplementedException();
        }

        public void Output()
        {
            throw new NotImplementedException();
        }

        public PageData MyData
        {
            get
            {
                return myData;
            }

            set
            {
                myData = value; // value reps what is coming in
            }
        }
    }
}
