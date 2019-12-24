using System;
using UnityEngine;

namespace General.Typescript
{
	public class SystemNetSocketsLingerOption
	{
		static public void Bind(Namespace space)
		{
			Class<System.Net.Sockets.LingerOption> self = space.DeclareClass<System.Net.Sockets.LingerOption>();
			self.BindConstructor(Constructor);
			self.BindInstanceProperty("Enabled", get_Enabled, set_Enabled);
			self.BindInstanceProperty("LingerTime", get_LingerTime, set_LingerTime);
		}

		static private System.Net.Sockets.LingerOption Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Boolean, System.Int32>())
			{
				return new System.Net.Sockets.LingerOption(parameters[0].ToObject<System.Boolean>(), parameters[1].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.Sockets.LingerOption.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.LingerOption.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Net.Sockets.LingerOption);
		}

		static private System.Boolean get_Enabled(System.Net.Sockets.LingerOption instance, string name)
		{
			return instance.Enabled;
		}

		static private void set_Enabled(System.Net.Sockets.LingerOption instance, string name, System.Boolean value)
		{
			instance.Enabled = value;
		}

		static private System.Int32 get_LingerTime(System.Net.Sockets.LingerOption instance, string name)
		{
			return instance.LingerTime;
		}

		static private void set_LingerTime(System.Net.Sockets.LingerOption instance, string name, System.Int32 value)
		{
			instance.LingerTime = value;
		}

	}
}
