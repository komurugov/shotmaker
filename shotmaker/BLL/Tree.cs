using System.Collections.Generic;

namespace ScreenshotMaker.BLL
{
	public class Tree<T> : List<Tree<T>>
	{
		public T Value { get; set; }
	}
}