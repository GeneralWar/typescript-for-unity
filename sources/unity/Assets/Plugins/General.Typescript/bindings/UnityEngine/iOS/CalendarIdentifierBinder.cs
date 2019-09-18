#if UNITY_IPHONE
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineiOSCalendarIdentifier
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.iOS.CalendarIdentifier> instance = space.DeclareEnum<UnityEngine.iOS.CalendarIdentifier>();
			instance.SetValue("GregorianCalendar", (long)UnityEngine.iOS.CalendarIdentifier.GregorianCalendar);
			instance.SetValue("BuddhistCalendar", (long)UnityEngine.iOS.CalendarIdentifier.BuddhistCalendar);
			instance.SetValue("ChineseCalendar", (long)UnityEngine.iOS.CalendarIdentifier.ChineseCalendar);
			instance.SetValue("HebrewCalendar", (long)UnityEngine.iOS.CalendarIdentifier.HebrewCalendar);
			instance.SetValue("IslamicCalendar", (long)UnityEngine.iOS.CalendarIdentifier.IslamicCalendar);
			instance.SetValue("IslamicCivilCalendar", (long)UnityEngine.iOS.CalendarIdentifier.IslamicCivilCalendar);
			instance.SetValue("JapaneseCalendar", (long)UnityEngine.iOS.CalendarIdentifier.JapaneseCalendar);
			instance.SetValue("RepublicOfChinaCalendar", (long)UnityEngine.iOS.CalendarIdentifier.RepublicOfChinaCalendar);
			instance.SetValue("PersianCalendar", (long)UnityEngine.iOS.CalendarIdentifier.PersianCalendar);
			instance.SetValue("IndianCalendar", (long)UnityEngine.iOS.CalendarIdentifier.IndianCalendar);
			instance.SetValue("ISO8601Calendar", (long)UnityEngine.iOS.CalendarIdentifier.ISO8601Calendar);
		}
	}
}
#endif
