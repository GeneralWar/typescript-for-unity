using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineEventsPersistentListenerMode
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.Events.PersistentListenerMode> instance = space.DeclareEnum<UnityEngine.Events.PersistentListenerMode>();
			instance.SetValue("EventDefined", (long)UnityEngine.Events.PersistentListenerMode.EventDefined);
			instance.SetValue("Void", (long)UnityEngine.Events.PersistentListenerMode.Void);
			instance.SetValue("Object", (long)UnityEngine.Events.PersistentListenerMode.Object);
			instance.SetValue("Int", (long)UnityEngine.Events.PersistentListenerMode.Int);
			instance.SetValue("Float", (long)UnityEngine.Events.PersistentListenerMode.Float);
			instance.SetValue("String", (long)UnityEngine.Events.PersistentListenerMode.String);
			instance.SetValue("Bool", (long)UnityEngine.Events.PersistentListenerMode.Bool);
		}
	}
}
