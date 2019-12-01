using UnityEngine;

namespace General.Typescript
{
	public class SystemNetWebClient
	{
		static public void Bind(Namespace space)
		{
			Class<System.Net.WebClient> self = space.DeclareClass<System.Net.WebClient>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("CancelAsync", CancelAsync);
			self.BindInstanceFunction("DownloadData", DownloadData);
			self.BindInstanceFunction("DownloadDataAsync", DownloadDataAsync);
			self.BindInstanceFunction("DownloadFile", DownloadFile);
			self.BindInstanceFunction("DownloadFileAsync", DownloadFileAsync);
			self.BindInstanceFunction("DownloadFileTaskAsync", DownloadFileTaskAsync);
			self.BindInstanceFunction("DownloadString", DownloadString);
			self.BindInstanceFunction("DownloadStringAsync", DownloadStringAsync);
			self.BindInstanceFunction("OpenRead", OpenRead);
			self.BindInstanceFunction("OpenReadAsync", OpenReadAsync);
			self.BindInstanceFunction("OpenWrite", OpenWrite);
			self.BindInstanceFunction("OpenWriteAsync", OpenWriteAsync);
			self.BindInstanceFunction("UploadData", UploadData);
			self.BindInstanceFunction("UploadDataAsync", UploadDataAsync);
			self.BindInstanceFunction("UploadFile", UploadFile);
			self.BindInstanceFunction("UploadFileAsync", UploadFileAsync);
			self.BindInstanceFunction("UploadString", UploadString);
			self.BindInstanceFunction("UploadStringAsync", UploadStringAsync);
			self.BindInstanceFunction("UploadValues", UploadValues);
			self.BindInstanceFunction("UploadValuesAsync", UploadValuesAsync);
			self.BindInstanceProperty("Encoding", get_Encoding, set_Encoding);
			self.BindInstanceProperty("BaseAddress", get_BaseAddress, set_BaseAddress);
			self.BindInstanceProperty("Credentials", get_Credentials, set_Credentials);
			self.BindInstanceProperty("UseDefaultCredentials", get_UseDefaultCredentials, set_UseDefaultCredentials);
			self.BindInstanceProperty("Headers", get_Headers, set_Headers);
			self.BindInstanceProperty("QueryString", get_QueryString, set_QueryString);
			self.BindInstanceProperty("ResponseHeaders", get_ResponseHeaders, null);
			self.BindInstanceProperty("Proxy", get_Proxy, set_Proxy);
			self.BindInstanceProperty("CachePolicy", get_CachePolicy, set_CachePolicy);
			self.BindInstanceProperty("IsBusy", get_IsBusy, null);
		}

		static private System.Net.WebClient Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new System.Net.WebClient();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.Net.WebClient.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Net.WebClient);
		}

		static private void CancelAsync(System.Net.WebClient instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.CancelAsync();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.Net.WebClient.CancelAsync has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private System.Byte[] DownloadData(System.Net.WebClient instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return instance.DownloadData(parameters[0].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.Uri>())
			{
				return instance.DownloadData(parameters[0].ToObject<System.Uri>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.WebClient.DownloadData has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.WebClient.DownloadData has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private void DownloadDataAsync(System.Net.WebClient instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Uri>())
			{
				instance.DownloadDataAsync(parameters[0].ToObject<System.Uri>());
				return;
			}
			if (parameters.CheckTypes<System.Uri, System.Object>())
			{
				instance.DownloadDataAsync(parameters[0].ToObject<System.Uri>(), parameters[1].ToObject<System.Object>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.WebClient.DownloadDataAsync has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.WebClient.DownloadDataAsync has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void DownloadFile(System.Net.WebClient instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, System.String>())
			{
				instance.DownloadFile(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.String>());
				return;
			}
			if (parameters.CheckTypes<System.Uri, System.String>())
			{
				instance.DownloadFile(parameters[0].ToObject<System.Uri>(), parameters[1].ToObject<System.String>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.WebClient.DownloadFile has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.WebClient.DownloadFile has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void DownloadFileAsync(System.Net.WebClient instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Uri, System.String>())
			{
				instance.DownloadFileAsync(parameters[0].ToObject<System.Uri>(), parameters[1].ToObject<System.String>());
				return;
			}
			if (parameters.CheckTypes<System.Uri, System.String, System.Object>())
			{
				instance.DownloadFileAsync(parameters[0].ToObject<System.Uri>(), parameters[1].ToObject<System.String>(), parameters[2].ToObject<System.Object>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.WebClient.DownloadFileAsync has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.WebClient.DownloadFileAsync has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Threading.Tasks.Task DownloadFileTaskAsync(System.Net.WebClient instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, System.String>())
			{
				return instance.DownloadFileTaskAsync(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.Uri, System.String>())
			{
				return instance.DownloadFileTaskAsync(parameters[0].ToObject<System.Uri>(), parameters[1].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.WebClient.DownloadFileTaskAsync has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.WebClient.DownloadFileTaskAsync has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.String DownloadString(System.Net.WebClient instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return instance.DownloadString(parameters[0].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.Uri>())
			{
				return instance.DownloadString(parameters[0].ToObject<System.Uri>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.WebClient.DownloadString has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.WebClient.DownloadString has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private void DownloadStringAsync(System.Net.WebClient instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Uri>())
			{
				instance.DownloadStringAsync(parameters[0].ToObject<System.Uri>());
				return;
			}
			if (parameters.CheckTypes<System.Uri, System.Object>())
			{
				instance.DownloadStringAsync(parameters[0].ToObject<System.Uri>(), parameters[1].ToObject<System.Object>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.WebClient.DownloadStringAsync has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.WebClient.DownloadStringAsync has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.IO.Stream OpenRead(System.Net.WebClient instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return instance.OpenRead(parameters[0].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.Uri>())
			{
				return instance.OpenRead(parameters[0].ToObject<System.Uri>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.WebClient.OpenRead has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.WebClient.OpenRead has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private void OpenReadAsync(System.Net.WebClient instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Uri>())
			{
				instance.OpenReadAsync(parameters[0].ToObject<System.Uri>());
				return;
			}
			if (parameters.CheckTypes<System.Uri, System.Object>())
			{
				instance.OpenReadAsync(parameters[0].ToObject<System.Uri>(), parameters[1].ToObject<System.Object>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.WebClient.OpenReadAsync has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.WebClient.OpenReadAsync has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.IO.Stream OpenWrite(System.Net.WebClient instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return instance.OpenWrite(parameters[0].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.Uri>())
			{
				return instance.OpenWrite(parameters[0].ToObject<System.Uri>());
			}
			if (parameters.CheckTypes<System.String, System.String>())
			{
				return instance.OpenWrite(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.Uri, System.String>())
			{
				return instance.OpenWrite(parameters[0].ToObject<System.Uri>(), parameters[1].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.WebClient.OpenWrite has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.WebClient.OpenWrite has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private void OpenWriteAsync(System.Net.WebClient instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Uri>())
			{
				instance.OpenWriteAsync(parameters[0].ToObject<System.Uri>());
				return;
			}
			if (parameters.CheckTypes<System.Uri, System.String>())
			{
				instance.OpenWriteAsync(parameters[0].ToObject<System.Uri>(), parameters[1].ToObject<System.String>());
				return;
			}
			if (parameters.CheckTypes<System.Uri, System.String, System.Object>())
			{
				instance.OpenWriteAsync(parameters[0].ToObject<System.Uri>(), parameters[1].ToObject<System.String>(), parameters[2].ToObject<System.Object>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.WebClient.OpenWriteAsync has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.WebClient.OpenWriteAsync has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Byte[] UploadData(System.Net.WebClient instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, System.Byte[]>())
			{
				return instance.UploadData(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Byte[]>());
			}
			if (parameters.CheckTypes<System.Uri, System.Byte[]>())
			{
				return instance.UploadData(parameters[0].ToObject<System.Uri>(), parameters[1].ToObject<System.Byte[]>());
			}
			if (parameters.CheckTypes<System.String, System.String, System.Byte[]>())
			{
				return instance.UploadData(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.String>(), parameters[2].ToObject<System.Byte[]>());
			}
			if (parameters.CheckTypes<System.Uri, System.String, System.Byte[]>())
			{
				return instance.UploadData(parameters[0].ToObject<System.Uri>(), parameters[1].ToObject<System.String>(), parameters[2].ToObject<System.Byte[]>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.WebClient.UploadData has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.WebClient.UploadData has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private void UploadDataAsync(System.Net.WebClient instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Uri, System.Byte[]>())
			{
				instance.UploadDataAsync(parameters[0].ToObject<System.Uri>(), parameters[1].ToObject<System.Byte[]>());
				return;
			}
			if (parameters.CheckTypes<System.Uri, System.String, System.Byte[]>())
			{
				instance.UploadDataAsync(parameters[0].ToObject<System.Uri>(), parameters[1].ToObject<System.String>(), parameters[2].ToObject<System.Byte[]>());
				return;
			}
			if (parameters.CheckTypes<System.Uri, System.String, System.Byte[], System.Object>())
			{
				instance.UploadDataAsync(parameters[0].ToObject<System.Uri>(), parameters[1].ToObject<System.String>(), parameters[2].ToObject<System.Byte[]>(), parameters[3].ToObject<System.Object>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.WebClient.UploadDataAsync has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.WebClient.UploadDataAsync has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Byte[] UploadFile(System.Net.WebClient instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, System.String>())
			{
				return instance.UploadFile(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.Uri, System.String>())
			{
				return instance.UploadFile(parameters[0].ToObject<System.Uri>(), parameters[1].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.String, System.String, System.String>())
			{
				return instance.UploadFile(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.String>(), parameters[2].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.Uri, System.String, System.String>())
			{
				return instance.UploadFile(parameters[0].ToObject<System.Uri>(), parameters[1].ToObject<System.String>(), parameters[2].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.WebClient.UploadFile has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.WebClient.UploadFile has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private void UploadFileAsync(System.Net.WebClient instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Uri, System.String>())
			{
				instance.UploadFileAsync(parameters[0].ToObject<System.Uri>(), parameters[1].ToObject<System.String>());
				return;
			}
			if (parameters.CheckTypes<System.Uri, System.String, System.String>())
			{
				instance.UploadFileAsync(parameters[0].ToObject<System.Uri>(), parameters[1].ToObject<System.String>(), parameters[2].ToObject<System.String>());
				return;
			}
			if (parameters.CheckTypes<System.Uri, System.String, System.String, System.Object>())
			{
				instance.UploadFileAsync(parameters[0].ToObject<System.Uri>(), parameters[1].ToObject<System.String>(), parameters[2].ToObject<System.String>(), parameters[3].ToObject<System.Object>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.WebClient.UploadFileAsync has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.WebClient.UploadFileAsync has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.String UploadString(System.Net.WebClient instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, System.String>())
			{
				return instance.UploadString(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.Uri, System.String>())
			{
				return instance.UploadString(parameters[0].ToObject<System.Uri>(), parameters[1].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.String, System.String, System.String>())
			{
				return instance.UploadString(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.String>(), parameters[2].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.Uri, System.String, System.String>())
			{
				return instance.UploadString(parameters[0].ToObject<System.Uri>(), parameters[1].ToObject<System.String>(), parameters[2].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.WebClient.UploadString has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.WebClient.UploadString has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private void UploadStringAsync(System.Net.WebClient instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Uri, System.String>())
			{
				instance.UploadStringAsync(parameters[0].ToObject<System.Uri>(), parameters[1].ToObject<System.String>());
				return;
			}
			if (parameters.CheckTypes<System.Uri, System.String, System.String>())
			{
				instance.UploadStringAsync(parameters[0].ToObject<System.Uri>(), parameters[1].ToObject<System.String>(), parameters[2].ToObject<System.String>());
				return;
			}
			if (parameters.CheckTypes<System.Uri, System.String, System.String, System.Object>())
			{
				instance.UploadStringAsync(parameters[0].ToObject<System.Uri>(), parameters[1].ToObject<System.String>(), parameters[2].ToObject<System.String>(), parameters[3].ToObject<System.Object>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.WebClient.UploadStringAsync has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.WebClient.UploadStringAsync has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Byte[] UploadValues(System.Net.WebClient instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, System.Collections.Specialized.NameValueCollection>())
			{
				return instance.UploadValues(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Collections.Specialized.NameValueCollection>());
			}
			if (parameters.CheckTypes<System.Uri, System.Collections.Specialized.NameValueCollection>())
			{
				return instance.UploadValues(parameters[0].ToObject<System.Uri>(), parameters[1].ToObject<System.Collections.Specialized.NameValueCollection>());
			}
			if (parameters.CheckTypes<System.String, System.String, System.Collections.Specialized.NameValueCollection>())
			{
				return instance.UploadValues(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.String>(), parameters[2].ToObject<System.Collections.Specialized.NameValueCollection>());
			}
			if (parameters.CheckTypes<System.Uri, System.String, System.Collections.Specialized.NameValueCollection>())
			{
				return instance.UploadValues(parameters[0].ToObject<System.Uri>(), parameters[1].ToObject<System.String>(), parameters[2].ToObject<System.Collections.Specialized.NameValueCollection>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.WebClient.UploadValues has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.WebClient.UploadValues has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private void UploadValuesAsync(System.Net.WebClient instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Uri, System.Collections.Specialized.NameValueCollection>())
			{
				instance.UploadValuesAsync(parameters[0].ToObject<System.Uri>(), parameters[1].ToObject<System.Collections.Specialized.NameValueCollection>());
				return;
			}
			if (parameters.CheckTypes<System.Uri, System.String, System.Collections.Specialized.NameValueCollection>())
			{
				instance.UploadValuesAsync(parameters[0].ToObject<System.Uri>(), parameters[1].ToObject<System.String>(), parameters[2].ToObject<System.Collections.Specialized.NameValueCollection>());
				return;
			}
			if (parameters.CheckTypes<System.Uri, System.String, System.Collections.Specialized.NameValueCollection, System.Object>())
			{
				instance.UploadValuesAsync(parameters[0].ToObject<System.Uri>(), parameters[1].ToObject<System.String>(), parameters[2].ToObject<System.Collections.Specialized.NameValueCollection>(), parameters[3].ToObject<System.Object>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.WebClient.UploadValuesAsync has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.WebClient.UploadValuesAsync has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Text.Encoding get_Encoding(System.Net.WebClient instance)
		{
			return instance.Encoding;
		}

		static private void set_Encoding(System.Net.WebClient instance, System.Text.Encoding value)
		{
			instance.Encoding = value;
		}

		static private System.String get_BaseAddress(System.Net.WebClient instance)
		{
			return instance.BaseAddress;
		}

		static private void set_BaseAddress(System.Net.WebClient instance, System.String value)
		{
			instance.BaseAddress = value;
		}

		static private System.Net.ICredentials get_Credentials(System.Net.WebClient instance)
		{
			return instance.Credentials;
		}

		static private void set_Credentials(System.Net.WebClient instance, System.Net.ICredentials value)
		{
			instance.Credentials = value;
		}

		static private System.Boolean get_UseDefaultCredentials(System.Net.WebClient instance)
		{
			return instance.UseDefaultCredentials;
		}

		static private void set_UseDefaultCredentials(System.Net.WebClient instance, System.Boolean value)
		{
			instance.UseDefaultCredentials = value;
		}

		static private System.Net.WebHeaderCollection get_Headers(System.Net.WebClient instance)
		{
			return instance.Headers;
		}

		static private void set_Headers(System.Net.WebClient instance, System.Net.WebHeaderCollection value)
		{
			instance.Headers = value;
		}

		static private System.Collections.Specialized.NameValueCollection get_QueryString(System.Net.WebClient instance)
		{
			return instance.QueryString;
		}

		static private void set_QueryString(System.Net.WebClient instance, System.Collections.Specialized.NameValueCollection value)
		{
			instance.QueryString = value;
		}

		static private System.Net.WebHeaderCollection get_ResponseHeaders(System.Net.WebClient instance)
		{
			return instance.ResponseHeaders;
		}

		static private System.Net.IWebProxy get_Proxy(System.Net.WebClient instance)
		{
			return instance.Proxy;
		}

		static private void set_Proxy(System.Net.WebClient instance, System.Net.IWebProxy value)
		{
			instance.Proxy = value;
		}

		static private System.Net.Cache.RequestCachePolicy get_CachePolicy(System.Net.WebClient instance)
		{
			return instance.CachePolicy;
		}

		static private void set_CachePolicy(System.Net.WebClient instance, System.Net.Cache.RequestCachePolicy value)
		{
			instance.CachePolicy = value;
		}

		static private System.Boolean get_IsBusy(System.Net.WebClient instance)
		{
			return instance.IsBusy;
		}

	}
}
