using System.Windows.Media;

namespace CaliburnMicroSpike
{
	public class ColorEvent
	{
		public ColorEvent(SolidColorBrush color)
		{
			Color = color;
		}

		public SolidColorBrush Color { get; private set; }
	}
}