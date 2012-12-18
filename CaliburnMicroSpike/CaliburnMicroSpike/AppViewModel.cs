using System.ComponentModel.Composition;
using System.Windows.Media;
using Caliburn.Micro;

namespace CaliburnMicroSpike
{
	[Export(typeof(AppViewModel))]
	public class AppViewModel : PropertyChangedBase, IHandle<ColorEvent>
	{

		[ImportingConstructor]
		public AppViewModel(ColorViewModel colorViewModel, IEventAggregator events)
		{
			ColorViewModel = colorViewModel;
			events.Subscribe(this);
		}
		
		private int _count = 50;
		private SolidColorBrush _color;

		public SolidColorBrush Color
		{
			get { return _color; }
			set
			{
				_color = value;
				NotifyOfPropertyChange(() => Color);
			}
		}

		public ColorViewModel ColorViewModel { get; private set; }

		public int Count
		{
			get { return _count; }
			set 
			{ 
				_count = value;
				NotifyOfPropertyChange(() => Count);
				NotifyOfPropertyChange(() => CanIncrementCount);
			}
		}

		public void IncrementCount(int delta)
		{
			Count += delta;
		}

		public bool CanIncrementCount
		{
			get { return Count < 1000; }
		}

		public void Handle(ColorEvent message)
		{
			Color = message.Color;
		}
	}
}