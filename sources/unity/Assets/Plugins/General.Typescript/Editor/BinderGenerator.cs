using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace General.Typescript
{
    static public partial class BinderGenerator
    {
        //public const string BINDER_OUTPUT_PATH = "../BinderTest/Assets/Plugins/General.Typescript/bindings/";
        public const string TABLE = "\t";

        ///// <summary>
        ///// 获取绑定的类型列表。
        ///// <para>
        ///// Get the list of types which binded to general.typescript.
        ///// </para>
        ///// </summary>
        ///// <param name="subset">
        ///// 是否为用户自定义的子集
        ///// <para>
        ///// Is the list a subset that user set in the config file?
        ///// </para>
        ///// </param>
        ///// <returns></returns>
        //static public List<Type> GetBindedTypes(bool subset)
        //{
        //	List<Type> types = new List<Type>();
        //	List<Type> full = pickTypes(subset);

        //	NamespaceBinder.Clear();
        //	foreach (Type type in full)
        //	{
        //		if (!type.FullName.Contains("."))
        //		{
        //			continue;
        //		}
        //		try
        //		{
        //			NamespaceBinder space = NamespaceBinder.GetNamespace(type.FullName.Substring(0, type.FullName.LastIndexOf(".")));
        //			if (null != space)
        //			{
        //				ClassBinder binder = space.DeclareClass(type);
        //				if (null != binder)
        //				{
        //					types.Add(type);
        //				}
        //			}
        //		}
        //		catch (Exception e)
        //		{
        //			Entry.LogError(e);
        //			Entry.LogError(type);
        //		}
        //	}
        //	NamespaceBinder.Clear();
        //	return types;
        //}

        //static private List<Type> pickTypes()
        //{
        //	List<Type> types = new List<Type>();
        //	Assembly coreAssembly = Assembly.Load("UnityEngine.CoreModule");
        //	Assembly physicsAssembly = Assembly.Load("UnityEngine.PhysicsModule");
        //	Assembly uiAssembly = Assembly.Load("UnityEngine.UI");
        //	Assembly uiModuleAssembly = Assembly.Load("UnityEngine.UIModule");
        //	Assembly animationAssembly = Assembly.Load("UnityEngine.AnimationModule");
        //	types.AddRange(coreAssembly.GetTypes());
        //	types.AddRange(physicsAssembly.GetTypes());
        //	types.AddRange(uiAssembly.GetTypes());
        //	types.AddRange(uiModuleAssembly.GetTypes());
        //	types.AddRange(animationAssembly.GetTypes());
        //	return types;
        //}

        [MenuItem("General/Typescript/Initialize")]
        static private void Initialize()
        {
            Entry.Log("Try to initialize General.Typescript.");
            Configuration configuration = AssetDatabase.LoadAssetAtPath<Configuration>(Utility.CONFIGURATION_PATH);
            if (null == configuration)
            {
                configuration = ScriptableObject.CreateInstance<Configuration>();
                AssetDatabase.CreateAsset(configuration, Utility.CONFIGURATION_PATH);
            }

            //if (Utility.ASSETS_DIRECTORIES.Any(d => !Utility.DirectoryContainsFiles(d)))
            //{
            //	foreach (string directory in Utility.ASSETS_DIRECTORIES)
            //	{
            //		try
            //		{
            //			Utility.DeleteDirectory(directory, true);
            //		}
            //		catch (Exception e)
            //		{
            //			Entry.LogError(e);
            //			Entry.LogError("Cannot remove directory to decompress assets for General.Typescript, please restart Unity and try again!");
            //			return;
            //		}
            //	}

            //	WebResponse response = null;
            //	long timestamp = DateTime.Now.Ticks;
            //	HttpWebRequest request = WebRequest.CreateHttp(string.Format("http://typescript.soulfire.store/assets.gzp?timestamp={0}", timestamp));
            //	try
            //	{
            //		response = request.GetResponse();
            //	}
            //	catch (Exception)
            //	{
            //		request = WebRequest.CreateHttp(string.Format("https://typescript-1256214505.cos.ap-shanghai.myqcloud.com/assets.gzp?timestamp={0}", timestamp));
            //		try
            //		{
            //			response = request.GetResponse();
            //		}
            //		catch (Exception e)
            //		{
            //			Entry.LogError(e);
            //		}
            //	}
            //	if (null == response)
            //	{
            //		Entry.LogError("Cannot download asset for General.Typescript, please concat author to resolve!");
            //		return;
            //	}
            //	else
            //	{
            //		using (MemoryStream memory = new MemoryStream())
            //		{
            //			using (Stream responseStream = response.GetResponseStream())
            //			{

            //				using (GZipStream stream = new GZipStream(responseStream, CompressionMode.Decompress, false))
            //				{
            //					stream.CopyTo(memory);
            //					stream.Close();
            //				}
            //				response.Close();
            //			}

            //			memory.Position = 0;
            //			using (BinaryReader reader = new BinaryReader(memory))
            //			{
            //				while (memory.Position < memory.Length)
            //				{
            //					ushort nameLength = reader.ReadUInt16();
            //					string filename = Encoding.UTF8.GetString(reader.ReadBytes(nameLength));
            //					Utility.CreateDirectory(Path.GetDirectoryName(filename));
            //					int bufferLength = reader.ReadInt32();
            //					using (FileStream file = File.OpenWrite(filename))
            //					{
            //						file.Write(reader.ReadBytes(bufferLength), 0, bufferLength);
            //						file.Close();
            //					}
            //				}
            //			}
            //			memory.Close();
            //		}
            //	}
            //}
            AssetDatabase.Refresh();
            Entry.Log("Initialize General.Typescript successfully!");
        }

        static private void generateBinder(Type type)
        {
            if (!type.FullName.Contains("."))
            {
                return;
            }
            try
            {
                NamespaceBinder space = NamespaceBinder.GetNamespace(type.FullName.Substring(0, type.FullName.LastIndexOf(".")));
                if (null != space)
                {
                    space.DeclareClass(type);
                }
            }
            catch (Exception e)
            {
                Entry.LogError(e);
                Entry.LogError(type);
            }
        }

        static private void generateBinders(IEnumerable<Type> types, List<Type> delegates)
        {
            Configuration configuration = Utility.GetConfiguration();
            if (null != configuration)
            {
                BinderBase.SetBinderOutputPath(configuration.bindersOutputPath);
            }
            NamespaceBinder.Clear();

            List<Type> nestedTypes = new List<Type>();
            foreach (Type type in types)
            {
                if (type.IsNested)
                {
                    nestedTypes.Add(type);
                    continue;
                }
                generateBinder(type);
            }
            foreach (Type type in nestedTypes)
            {
                generateBinder(type);
            }

            foreach (NamespaceBinder space in NamespaceBinder.Spaces)
            {
                space.GenerateBinder(delegates, true);
            }

            AssetDatabase.Refresh();
            Entry.Log("General.Typescript binders generate successfully!");
        }

        static public void GenerateBinders(IEnumerable<Type> allTypes, IEnumerable<Type> bindedTypes)
        {
            List<Type> delegates = new List<Type>();
            generateBinders(bindedTypes, delegates);
            generateDelegatesBinder(delegates);
            generateTypeTable(allTypes);
        }

        static private List<Type> filterDelegates(List<Type> delegates)
        {
            delegates = delegates.Distinct().ToList();
            delegates.RemoveAll(d =>
            {
                Type[] arguments = d.GetGenericArguments();
                if (arguments.Any(a => a.IsSubclassOf(typeof(System.IAsyncResult)) || typeof(System.IAsyncResult) == a))
                {
                    return true;
                }
                MethodInfo invoke = d.GetMethod("Invoke", BindingFlags.Public | BindingFlags.Instance);
                if (null == invoke)
                {
                    return true;
                }
                ParameterInfo[] parameters = invoke.GetParameters();
                if (parameters.Any(a => a.ParameterType.IsSubclassOf(typeof(System.IAsyncResult)) || typeof(System.IAsyncResult) == a.ParameterType))
                {
                    return true;
                }
                return false;
            });
            return delegates;
        }

        static private void generateDelegatesBinder(List<Type> delegates)
        {
            delegates = filterDelegates(delegates);
            string contentBeforeInitialize =
            #region content before initialize
                @"using System;
using System.Collections.Generic;

namespace General.Typescript
{
	public class DelegatesBinder : Binder, Parameters.IParameterDelegateConverter
	{
		private Dictionary<Type, Func<IntPtr, Delegate>> sTypedDelegatesMap = new Dictionary<Type, Func<IntPtr, Delegate>>();

		static public void Initialize()
		{
			General.Typescript.Parameters.SetDelegateConverter<DelegatesBinder>();
		}

		public Delegate ToDelegate(IntPtr parameter, Type type)
		{
			try
			{
				Func<IntPtr, Delegate> record = null;
				if (sTypedDelegatesMap.TryGetValue(type, out record))
				{
					return record(parameter);
				}
			}
			catch (Exception e)
			{
				Entry.LogError(e);
			}
			return null;
		}

		public void InitializeDelegates()
		{";
            #endregion

            int contentStart = 3;
            Configuration configuration = Utility.GetConfiguration();
            using (FileStream stream = new FileStream(Path.Combine(configuration.bindersOutputPath, "DelegatesBinder.cs"), FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.Write(contentBeforeInitialize);
                    writer.WriteLine();
                    foreach (Type type in delegates)
                    {
                        string fullname = type.GetSafeFullName();
                        writer.WriteLine(contentStart, "sTypedDelegatesMap.Add(typeof({0}), to{1});", fullname, fullname.Replace(".", "").Replace("<", "").Replace(">", ""));
                    }
                    writer.WriteRegionEnd(contentStart - 1);
                    foreach (Type type in delegates)
                    {
                        writer.WriteLine();
                        string fullname = type.GetSafeFullName();
                        writer.WriteRegionBegin(contentStart - 1, "static private {0} to{1}(IntPtr parameter)", fullname, fullname.Replace(".", "").Replace("<", "").Replace(">", ""));

                        MethodInfo invoke = type.GetMethod("Invoke", BindingFlags.Public | BindingFlags.Instance);
                        ParameterInfo[] parameters = invoke.GetParameters();
                        if (0 == parameters.Length)
                        {
                            writer.WriteRegionBegin(contentStart, "return new {0}(() =>", fullname);
                            writer.WriteLine(contentStart + 1, "Entry.Object.CallAsFunction(parameter);");
                        }
                        else
                        {
                            writer.WriteRegionBegin(contentStart, "return new {0}(({1}) =>", fullname, string.Join(", ", Array.ConvertAll(parameters, p => string.Format("{0} {1}", p.ParameterType.GetSafeFullName(), p.Name))));
                            writer.WriteLine(contentStart + 1, "Entry.Object.CallAsFunction(parameter, {0});", string.Join(", ", Array.ConvertAll(parameters, p => p.Name)));
                        }
                        writer.WriteLine(contentStart, "});");
                        writer.WriteRegionEnd(contentStart - 1);
                    }
                    while (--contentStart > 0)
                    {
                        writer.WriteRegionEnd(contentStart - 1);
                    }
                }
            }
        }

        static private void generateTypeTable(IEnumerable<Type> types)
        {
            string contentBeforeInitialize =
            #region content before initialize
                @"using System;
using System.Collections.Generic;

namespace General.Typescript
{
	public class TypeTable : Binder, BinderUtility.ITypeTable
	{
		private Dictionary<string, Type> mTypeDictionary = new Dictionary<string, Type>();

		static public void Initialize()
		{
			BinderUtility.SetTypeTable(typeof(TypeTable));
		}

		public Type GetType(string fullname)
		{
			Type type = null;
			mTypeDictionary.TryGetValue(fullname, out type);
			return type;
		}

		public void InitializeTypes()
		{";
            #endregion

            int contentStart = 3;
            Configuration configuration = Utility.GetConfiguration();
            using (FileStream stream = new FileStream(Path.Combine(configuration.bindersOutputPath, "TypeTable.cs"), FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.Write(contentBeforeInitialize);
                    writer.WriteLine();
                    writer.WriteLine("#if UNITY_IOS");
                    foreach (Type type in types)
                    {
                        if (!type.IsPublic || type.IsGenericType || null != type.GetCustomAttribute(typeof(ObsoleteAttribute))) continue;

                        string fullname = type.GetSafeFullName();
                        if (fullname.StartsWith("UnityEditorInternal") || "System.Void" == fullname || "System.SpanExtensions" == fullname || "System.Collections.Generic.KeyValuePair" == fullname
                        || "System.Reflection.Metadata.AssemblyExtensions" == fullname || "System.Runtime.Versioning.CompatibilitySwitch" == fullname
                        || "System.Runtime.CompilerServices.AsyncMethodBuilderAttribute" == fullname || "System.Buffers.IRetainable" == fullname
                        || "System.Buffers.MemoryHandle" == fullname || "System.Buffers.Binary.BinaryPrimitives" == fullname
                        || "System.Collections.Generic.CollectionExtensions" == fullname || "System.Collections.Generic.KeyValuePair" == fullname
                        || "System.Diagnostics.Tracing.EventCounter" == fullname || "System.Net.Sockets.SocketClientAccessPolicyProtocol" == fullname || "UnityEngine.AnimationInfo" == fullname || "UnityEngine.LightmappingMode" == fullname || "UnityEngine.RPCMode" == fullname || "UnityEngine.ConnectionTesterStatus" == fullname || "UnityEngine.NetworkConnectionError" == fullname || "UnityEngine.NetworkDisconnection" == fullname || "UnityEngine.MasterServerEvent" == fullname || "UnityEngine.NetworkStateSynchronization" == fullname || "UnityEngine.NetworkPeerType" == fullname || "UnityEngine.NetworkLogLevel" == fullname || "UnityEngine.NetworkPlayer" == fullname || "UnityEngine.NetworkViewID" == fullname || "UnityEngine.NetworkView" == fullname || "UnityEngine.Network" == fullname || "UnityEngine.BitStream" == fullname || "UnityEngine.RPC" == fullname || "UnityEngine.HostData" == fullname || "UnityEngine.MasterServer" == fullname || "UnityEngine.NetworkMessageInfo" == fullname
                        || "UnityEngine.iPhoneScreenOrientation" == fullname || "UnityEngine.iPhoneNetworkReachability" == fullname || "UnityEngine.iPhoneGeneration" == fullname || "UnityEngine.iPhoneSettings" == fullname || "UnityEngine.iPhoneTouchPhase" == fullname || "UnityEngine.iPhoneTouch" == fullname || "UnityEngine.iPhoneMovieControlMode" == fullname || "UnityEngine.iPhoneMovieScalingMode" == fullname || "UnityEngine.iPhoneUtils" == fullname || "UnityEngine.iPhoneKeyboardType" == fullname || "UnityEngine.iPhoneKeyboard" == fullname || "UnityEngine.iPhoneAccelerationEvent" == fullname || "UnityEngine.iPhoneOrientation" == fullname || "UnityEngine.iPhoneInput" == fullname || "UnityEngine.iPhone" == fullname || "UnityEngine.iOSActivityIndicatorStyle" == fullname || "UnityEngine.CalendarIdentifier" == fullname || "UnityEngine.CalendarUnit" == fullname || "UnityEngine.LocalNotification" == fullname || "UnityEngine.RemoteNotification" == fullname || "UnityEngine.RemoteNotificationType" == fullname || "UnityEngine.NotificationServices" == fullname || "UnityEngine.ADBannerView" == fullname || "UnityEngine.ADInterstitialAd" == fullname || "UnityEngine.iOS.ADBannerView" == fullname || "UnityEngine.iOS.ADInterstitialAd" == fullname
                        || "UnityEngine.Apple.TV.Remote" == fullname || "UnityEngine.UI.IMask" == fullname || "UnityEngine.UI.BaseVertexEffect" == fullname || "UnityEngine.UI.IVertexModifier" == fullname)
                        {
                            continue;
                        }
                        if (fullname == type.Name || fullname.StartsWith("General.Typescript") || fullname.Contains("Win32")) continue;

                        writer.WriteLine(contentStart, "mTypeDictionary.Add(\"{0}\", typeof({1}));", fullname, fullname);
                    }
                    writer.WriteLine("#endif");
                    while (contentStart > 0)
                    {
                        writer.WriteRegionEnd(--contentStart);
                    }
                }
            }
        }

        //[MenuItem("General /Typescript/Generate Binders")]
        //static private void GenerateBinders()
        //{
        //	generateBinders(pickTypes());
        //}

        //[MenuItem("General/Typescript/Generate Binders Subset")]
        //static private void GenerateBindersSubset()
        //{
        //	generateBinders(pickTypes(true));
        //}

        static private void generateSnippet(Type type)
        {
            try
            {
                NamespaceBinder space = NamespaceBinder.GetNamespace(type.FullName.Substring(0, type.FullName.LastIndexOf(".")));
                if (null != space)
                {
                    space.DeclareClass(type);
                }
            }
            catch (Exception e)
            {
                Entry.LogError(e);
                Entry.LogWarning(type);
            }
        }

        static private void generateSnippets(IEnumerable<Type> types)
        {
            Configuration configuration = Utility.GetConfiguration();
            if (null != configuration)
            {
                BinderBase.SetLibraryOutputPath(configuration.snippetsOutputPath);
            }
            NamespaceBinder.Clear();

            List<Type> nestedTypes = new List<Type>();
            foreach (Type type in types)
            {
                if (type.IsNested)
                {
                    nestedTypes.Add(type);
                    continue;
                }
                generateSnippet(type);
            }
            foreach (Type type in nestedTypes)
            {
                generateSnippet(type);
            }

            foreach (NamespaceBinder space in NamespaceBinder.Spaces)
            {
                space.GenerateSnippets(true);
            }
            Entry.Log("General.Typescript snippets generate successfully!");
        }

        static public void GenerateSnippets(IEnumerable<Type> types)
        {
            generateSnippets(types);
        }

        //[MenuItem("General/Typescript/Generate Snippets")]
        //static private void GenerateSnippets()
        //{
        //	generateSnippets(pickTypes());
        //}

        //[MenuItem("General/Typescript/Generate Snippets Subset")]
        //static private void GenerateSnippetsSubset()
        //{
        //	generateSnippets(pickTypes(true));
        //}
    }
}
