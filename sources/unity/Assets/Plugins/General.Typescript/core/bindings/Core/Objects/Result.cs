using System;

namespace General.Typescript
{
	public class Result : Object
	{
		private int mResultIndex = -1;

		internal Result(int persistent)
		{
			mResultIndex = persistent;
		}

		public double ToNumber()
		{
			return Entry.Result.ToNumber(mResultIndex);
		}

		protected override void Release()
		{
			if (-1 != mResultIndex)
			{
				Entry.Result.Release(mResultIndex);
				mResultIndex = -1;
			}
		}
	}
}
