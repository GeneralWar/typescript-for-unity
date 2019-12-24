using System;
using UnityEngine;

namespace General.Typescript
{
	public class SystemNetSocketsSendPacketsElement
	{
		static public void Bind(Namespace space)
		{
			Class<System.Net.Sockets.SendPacketsElement> self = space.DeclareClass<System.Net.Sockets.SendPacketsElement>();
			self.BindConstructor(Constructor);
			self.BindInstanceProperty("FilePath", get_FilePath, null);
			self.BindInstanceProperty("Buffer", get_Buffer, null);
			self.BindInstanceProperty("Count", get_Count, null);
			self.BindInstanceProperty("Offset", get_Offset, null);
			self.BindInstanceProperty("EndOfPacket", get_EndOfPacket, null);
		}

		static private System.Net.Sockets.SendPacketsElement Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return new System.Net.Sockets.SendPacketsElement(parameters[0].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.Byte[]>())
			{
				return new System.Net.Sockets.SendPacketsElement(parameters[0].ToObject<System.Byte[]>());
			}
			if (parameters.CheckTypes<System.String, System.Int32, System.Int32>())
			{
				return new System.Net.Sockets.SendPacketsElement(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<System.Byte[], System.Int32, System.Int32>())
			{
				return new System.Net.Sockets.SendPacketsElement(parameters[0].ToObject<System.Byte[]>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<System.String, System.Int32, System.Int32, System.Boolean>())
			{
				return new System.Net.Sockets.SendPacketsElement(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<System.Boolean>());
			}
			if (parameters.CheckTypes<System.Byte[], System.Int32, System.Int32, System.Boolean>())
			{
				return new System.Net.Sockets.SendPacketsElement(parameters[0].ToObject<System.Byte[]>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<System.Boolean>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.Sockets.SendPacketsElement.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.SendPacketsElement.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Net.Sockets.SendPacketsElement);
		}

		static private System.String get_FilePath(System.Net.Sockets.SendPacketsElement instance, string name)
		{
			return instance.FilePath;
		}

		static private System.Byte[] get_Buffer(System.Net.Sockets.SendPacketsElement instance, string name)
		{
			return instance.Buffer;
		}

		static private System.Int32 get_Count(System.Net.Sockets.SendPacketsElement instance, string name)
		{
			return instance.Count;
		}

		static private System.Int32 get_Offset(System.Net.Sockets.SendPacketsElement instance, string name)
		{
			return instance.Offset;
		}

		static private System.Boolean get_EndOfPacket(System.Net.Sockets.SendPacketsElement instance, string name)
		{
			return instance.EndOfPacket;
		}

	}
}
