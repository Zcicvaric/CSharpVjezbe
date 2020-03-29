using System;
using System.Collections;

namespace Labs
{
	/// <summary>
	/// Summary description for DataModell.
	/// </summary>
	public class DataModel
	{
		private static ArrayList ALL_ELEMENTS;

		public DataModel()
		{
			ALL_ELEMENTS=new ArrayList();

		}

		public static double getNewXPos()
		{
			if(ALL_ELEMENTS.Count==0)
			{
				return 1;
			}
			else
			{			
				Shape lastShapeInList = (Shape)ALL_ELEMENTS[ALL_ELEMENTS.Count-1];
				return lastShapeInList.getXPos()+1;				
			}
		}

		public static double getNewYPos()
		{
			if(ALL_ELEMENTS.Count==0)
			{
				return 1;
			}
			else
			{			
				Shape lastShapeInList = (Shape)ALL_ELEMENTS[ALL_ELEMENTS.Count-1];
				return lastShapeInList.getYPos()+2;
			}
		}

		public static ArrayList getAllElementsList()
		{
			return ALL_ELEMENTS;
		}

		public static double getTotalArea()
		{
			double totalArea=0;

			foreach(Shape shape in ALL_ELEMENTS)
			{
				totalArea+=shape.getArea();
			}

			return totalArea;
		}


		public static double getTotalPerimeter()
		{
			double totalPerimeter=0;

			foreach(Shape shape in ALL_ELEMENTS)
			{
				totalPerimeter+=shape.getPerimeter();
			}

			return totalPerimeter;
		}

		public delegate void CircleAddedHandler(String args);
		public static event CircleAddedHandler CircleAdded;

		public static void PublishCircleAdded(Shape newCircle)
		{
			string message = "x: " + newCircle.getXPos().ToString() + " y: " + newCircle.getYPos().ToString();
			
			CircleAdded(message);
		}

		public static void OnCircleAdded(Shape shape)
		{
			if (shape is Circle)
			{
				PublishCircleAdded(shape);
			}
			ALL_ELEMENTS.Add(shape);
		}
	}
}
