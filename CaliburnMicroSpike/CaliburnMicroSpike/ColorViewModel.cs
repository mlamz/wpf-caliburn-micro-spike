using System.ComponentModel.Composition;
using System.Windows.Media;
using Caliburn.Micro;

namespace CaliburnMicroSpike
{
	[Export(typeof(ColorViewModel))]
	public class ColorViewModel: PropertyChangedBase
	{
		private readonly IEventAggregator _events;

		[ImportingConstructor]
		public ColorViewModel(IEventAggregator events)
		{
			_events = events;
		}

		public void Red()
		{
			_events.Publish(new ColorEvent(new SolidColorBrush(Colors.Red)));
		}

		public void Green()
		{
			_events.Publish(new ColorEvent(new SolidColorBrush(Colors.Green)));
		}

		public void Blue()
		{
			_events.Publish(new ColorEvent(new SolidColorBrush(Colors.Blue)));
		}
	}
}