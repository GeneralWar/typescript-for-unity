#if UNITY_IPHONE
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineiOSCalendarUnit
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.iOS.CalendarUnit> instance = space.DeclareEnum<UnityEngine.iOS.CalendarUnit>();
			instance.SetValue("Era", (long)UnityEngine.iOS.CalendarUnit.Era);
			instance.SetValue("Year", (long)UnityEngine.iOS.CalendarUnit.Year);
			instance.SetValue("Month", (long)UnityEngine.iOS.CalendarUnit.Month);
			instance.SetValue("Day", (long)UnityEngine.iOS.CalendarUnit.Day);
			instance.SetValue("Hour", (long)UnityEngine.iOS.CalendarUnit.Hour);
			instance.SetValue("Minute", (long)UnityEngine.iOS.CalendarUnit.Minute);
			instance.SetValue("Second", (long)UnityEngine.iOS.CalendarUnit.Second);
			instance.SetValue("Week", (long)UnityEngine.iOS.CalendarUnit.Week);
			instance.SetValue("Weekday", (long)UnityEngine.iOS.CalendarUnit.Weekday);
			instance.SetValue("WeekdayOrdinal", (long)UnityEngine.iOS.CalendarUnit.WeekdayOrdinal);
			instance.SetValue("Quarter", (long)UnityEngine.iOS.CalendarUnit.Quarter);
		}
	}
}
#endif
