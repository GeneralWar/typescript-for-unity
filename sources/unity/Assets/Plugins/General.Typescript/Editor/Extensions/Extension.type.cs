using System;

namespace General.Typescript
{
	static public partial class Extension
	{
		static internal bool IsSubType(this Type type)
		{
			try
			{
				return null == type ? false : (!type.IsGenericParameter && (null != type.DeclaringType || type.FullName.Contains("+")));
			}
			catch
			{
				return false;
			}
		}
	}
}
