using UnityEngine;

namespace General.Typescript
{
	public class SystemNetSocketsSelectMode
	{
		static public void Bind(Namespace space)
		{
			Enum<System.Net.Sockets.SelectMode> instance = space.DeclareEnum<System.Net.Sockets.SelectMode>();
			instance.SetValue("SelectRead", (long)System.Net.Sockets.SelectMode.SelectRead);
			instance.SetValue("SelectWrite", (long)System.Net.Sockets.SelectMode.SelectWrite);
			instance.SetValue("SelectError", (long)System.Net.Sockets.SelectMode.SelectError);
		}
	}
}
