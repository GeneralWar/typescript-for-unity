using UnityEngine;

namespace General.Typescript
{
	public class UnityEnginePlayablesNotification
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Playables.Notification> self = space.DeclareClass<UnityEngine.Playables.Notification>();
			self.BindConstructor(Constructor);
			self.BindInstanceProperty("id", get_id, null);
		}

		static private UnityEngine.Playables.Notification Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return new UnityEngine.Playables.Notification(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Playables.Notification.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Playables.Notification.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Playables.Notification);
		}

		static private UnityEngine.PropertyName get_id(UnityEngine.Playables.Notification instance)
		{
			return instance.id;
		}

	}
}
