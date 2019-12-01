using System;

namespace General.Typescript
{
	public abstract class Object
	{
		internal Object() { }

		~Object()
		{
			this.Release();
		}

		protected abstract void Release();
	}
}
