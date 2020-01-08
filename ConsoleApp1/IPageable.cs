using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	public struct PageData {
		public string title;
		public string author;
	}
	public interface IPageable
	{
		// whoever implemnts this interface has a property called MyData that will get and set some PageData
		PageData MyData { get; set; }
		// how we are going to input our item
		IPageable Input();

		// How to output
		void Output();
	}
}
