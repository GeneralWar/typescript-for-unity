using UnityEngine;

namespace General.Typescript
{
	public class UnityEnginePing
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Ping> self = space.DeclareClass<UnityEngine.Ping>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("DestroyPing", DestroyPing);
			self.BindInstanceProperty("isDone", get_isDone, null);
			self.BindInstanceProperty("time", get_time, null);
			self.BindInstanceProperty("ip", get_ip, null);
		}

		static private UnityEngine.Ping Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return new UnityEngine.Ping(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Ping.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Ping.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Ping);
		}

		static private void DestroyPing(UnityEngine.Ping instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.DestroyPing();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Ping.DestroyPing has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private System.Boolean get_isDone(UnityEngine.Ping instance)
		{
			return instance.isDone;
		}

		static private System.Int32 get_time(UnityEngine.Ping instance)
		{
			return instance.time;
		}

		static private System.String get_ip(UnityEngine.Ping instance)
		{
			return instance.ip;
		}

	}
}
