using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	// this class implements IPageable interface
	class TextualMessage : IPageable
	{
		// PageData field for returning page data
		// used protected because only this class and whichever class inherits from textual message will gain access to this particula field
		protected PageData myData; // myData field is associated with MyData property
		protected string message; // message field

		/*
		all textual messages have some page data and a message
		they can input and output things because they implement the IPageable Interface
		and then they have a property that can get pagedata and set pagedata
		*/
		
        // if you want an inherited class to be able to input something differently
        // you needd to add the virtual keyword, so they can override how they implement that method later on
        // any class that derives from TextualMessage should be able to input things their own way using the override keyword
		public virtual IPageable Input()
		{
			throw new NotImplementedException();
		}

		public void Output()
		{
			throw new NotImplementedException();
		}

		public PageData MyData
		{
			get {
				return myData;
			}

			set
			{
				myData = value; // value reps what is coming in
			}
		}

	}
}
