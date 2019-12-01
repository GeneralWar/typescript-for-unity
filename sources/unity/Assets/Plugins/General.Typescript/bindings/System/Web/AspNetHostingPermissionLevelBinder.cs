using UnityEngine;

namespace General.Typescript
{
	public class SystemWebAspNetHostingPermissionLevel
	{
		static public void Bind(Namespace space)
		{
			Enum<System.Web.AspNetHostingPermissionLevel> instance = space.DeclareEnum<System.Web.AspNetHostingPermissionLevel>();
			instance.SetValue("None", (long)System.Web.AspNetHostingPermissionLevel.None);
			instance.SetValue("Minimal", (long)System.Web.AspNetHostingPermissionLevel.Minimal);
			instance.SetValue("Low", (long)System.Web.AspNetHostingPermissionLevel.Low);
			instance.SetValue("Medium", (long)System.Web.AspNetHostingPermissionLevel.Medium);
			instance.SetValue("High", (long)System.Web.AspNetHostingPermissionLevel.High);
			instance.SetValue("Unrestricted", (long)System.Web.AspNetHostingPermissionLevel.Unrestricted);
		}
	}
}
