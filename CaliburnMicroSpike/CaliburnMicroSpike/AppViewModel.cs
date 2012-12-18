using Caliburn.Micro;

namespace CaliburnMicroSpike
{
	public class AppViewModel : PropertyChangedBase
	{
		private int _count = 50;

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
	}
}