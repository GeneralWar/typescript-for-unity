using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineCrashReport
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.CrashReport> self = space.DeclareClass<UnityEngine.CrashReport>();
			self.BindConstructor();
			self.BindStaticFunction("RemoveAll", RemoveAll);
			self.BindInstanceFunction("Remove", Remove);
			self.BindStaticProperty("reports", get_reports, null);
			self.BindStaticProperty("lastReport", get_lastReport, null);
		}

		static private void RemoveAll(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				UnityEngine.CrashReport.RemoveAll();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.CrashReport.RemoveAll has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void Remove(UnityEngine.CrashReport instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Remove();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.CrashReport.Remove has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private UnityEngine.CrashReport[] get_reports()
		{
			return UnityEngine.CrashReport.reports;
		}

		static private UnityEngine.CrashReport get_lastReport()
		{
			return UnityEngine.CrashReport.lastReport;
		}

	}
}
