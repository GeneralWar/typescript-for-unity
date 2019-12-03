using UnityEngine;

namespace General.Typescript
{
	public class SystemNetNetworkInformationGatewayIPAddressInformationCollection
	{
		static public void Bind(Namespace space)
		{
			Class<System.Net.NetworkInformation.GatewayIPAddressInformationCollection> self = space.DeclareClass<System.Net.NetworkInformation.GatewayIPAddressInformationCollection>();
			self.BindConstructor();
			self.BindInstanceFunction("Add", Add);
			self.BindInstanceFunction("Clear", Clear);
			self.BindInstanceFunction("Contains", Contains);
			self.BindInstanceFunction("CopyTo", CopyTo);
			self.BindInstanceFunction("Remove", Remove);
			self.BindInstanceProperty("Count", get_Count, null);
			self.BindInstanceProperty("IsReadOnly", get_IsReadOnly, null);
		}

		static private void Add(System.Net.NetworkInformation.GatewayIPAddressInformationCollection instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Net.NetworkInformation.GatewayIPAddressInformation>())
			{
				instance.Add(parameters[0].ToObject<System.Net.NetworkInformation.GatewayIPAddressInformation>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.NetworkInformation.GatewayIPAddressInformationCollection.Add has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.NetworkInformation.GatewayIPAddressInformationCollection.Add has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void Clear(System.Net.NetworkInformation.GatewayIPAddressInformationCollection instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Clear();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.Net.NetworkInformation.GatewayIPAddressInformationCollection.Clear has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private System.Boolean Contains(System.Net.NetworkInformation.GatewayIPAddressInformationCollection instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Net.NetworkInformation.GatewayIPAddressInformation>())
			{
				return instance.Contains(parameters[0].ToObject<System.Net.NetworkInformation.GatewayIPAddressInformation>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.NetworkInformation.GatewayIPAddressInformationCollection.Contains has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.NetworkInformation.GatewayIPAddressInformationCollection.Contains has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private void CopyTo(System.Net.NetworkInformation.GatewayIPAddressInformationCollection instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Net.NetworkInformation.GatewayIPAddressInformation[], System.Int32>())
			{
				instance.CopyTo(parameters[0].ToObject<System.Net.NetworkInformation.GatewayIPAddressInformation[]>(), parameters[1].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.NetworkInformation.GatewayIPAddressInformationCollection.CopyTo has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.NetworkInformation.GatewayIPAddressInformationCollection.CopyTo has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Boolean Remove(System.Net.NetworkInformation.GatewayIPAddressInformationCollection instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Net.NetworkInformation.GatewayIPAddressInformation>())
			{
				return instance.Remove(parameters[0].ToObject<System.Net.NetworkInformation.GatewayIPAddressInformation>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.NetworkInformation.GatewayIPAddressInformationCollection.Remove has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.NetworkInformation.GatewayIPAddressInformationCollection.Remove has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Int32 get_Count(System.Net.NetworkInformation.GatewayIPAddressInformationCollection instance)
		{
			return instance.Count;
		}

		static private System.Boolean get_IsReadOnly(System.Net.NetworkInformation.GatewayIPAddressInformationCollection instance)
		{
			return instance.IsReadOnly;
		}

	}
}