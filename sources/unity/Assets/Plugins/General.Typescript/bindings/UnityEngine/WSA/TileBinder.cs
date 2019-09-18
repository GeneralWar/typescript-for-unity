#if UNITY_WSA
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineWSATile
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.WSA.Tile> self = space.DeclareClass<UnityEngine.WSA.Tile>();
			self.BindConstructor();
			self.BindStaticFunction("CreateOrUpdateSecondary", CreateOrUpdateSecondary);
			self.BindStaticFunction("DeleteSecondary", DeleteSecondary);
			self.BindStaticFunction("Exists", Exists);
			self.BindStaticFunction("GetSecondaries", GetSecondaries);
			self.BindStaticFunction("GetSecondary", GetSecondary);
			self.BindStaticFunction("GetTemplate", GetTemplate);
			self.BindInstanceFunction("Delete", Delete);
			self.BindInstanceFunction("PeriodicBadgeUpdate", PeriodicBadgeUpdate);
			self.BindInstanceFunction("PeriodicUpdate", PeriodicUpdate);
			self.BindInstanceFunction("RemoveBadge", RemoveBadge);
			self.BindInstanceFunction("StopPeriodicBadgeUpdate", StopPeriodicBadgeUpdate);
			self.BindInstanceFunction("StopPeriodicUpdate", StopPeriodicUpdate);
			self.BindInstanceFunction("Update", Update);
			self.BindInstanceFunction("UpdateBadgeImage", UpdateBadgeImage);
			self.BindInstanceFunction("UpdateBadgeNumber", UpdateBadgeNumber);
			self.BindStaticProperty("main", get_main, null);
			self.BindInstanceProperty("id", get_id, null);
			self.BindInstanceProperty("hasUserConsent", get_hasUserConsent, null);
			self.BindInstanceProperty("exists", get_exists, null);
		}

		static private UnityEngine.WSA.Tile CreateOrUpdateSecondary(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.WSA.SecondaryTileData>())
			{
				return UnityEngine.WSA.Tile.CreateOrUpdateSecondary(parameters[0].ToObject<UnityEngine.WSA.SecondaryTileData>());
			}
			if (parameters.CheckTypes<UnityEngine.WSA.SecondaryTileData, UnityEngine.Vector2>())
			{
				return UnityEngine.WSA.Tile.CreateOrUpdateSecondary(parameters[0].ToObject<UnityEngine.WSA.SecondaryTileData>(), parameters[1].ToObject<UnityEngine.Vector2>());
			}
			if (parameters.CheckTypes<UnityEngine.WSA.SecondaryTileData, UnityEngine.Rect>())
			{
				return UnityEngine.WSA.Tile.CreateOrUpdateSecondary(parameters[0].ToObject<UnityEngine.WSA.SecondaryTileData>(), parameters[1].ToObject<UnityEngine.Rect>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.WSA.Tile.CreateOrUpdateSecondary has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.WSA.Tile.CreateOrUpdateSecondary has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private void DeleteSecondary(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				UnityEngine.WSA.Tile.DeleteSecondary(parameters[0].ToObject<System.String>());
				return;
			}
			if (parameters.CheckTypes<System.String, UnityEngine.Vector2>())
			{
				UnityEngine.WSA.Tile.DeleteSecondary(parameters[0].ToObject<System.String>(), parameters[1].ToObject<UnityEngine.Vector2>());
				return;
			}
			if (parameters.CheckTypes<System.String, UnityEngine.Rect>())
			{
				UnityEngine.WSA.Tile.DeleteSecondary(parameters[0].ToObject<System.String>(), parameters[1].ToObject<UnityEngine.Rect>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.WSA.Tile.DeleteSecondary has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.WSA.Tile.DeleteSecondary has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Boolean Exists(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return UnityEngine.WSA.Tile.Exists(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.WSA.Tile.Exists has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.WSA.Tile.Exists has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private UnityEngine.WSA.Tile[] GetSecondaries(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return UnityEngine.WSA.Tile.GetSecondaries();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.WSA.Tile.GetSecondaries has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private UnityEngine.WSA.Tile GetSecondary(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return UnityEngine.WSA.Tile.GetSecondary(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.WSA.Tile.GetSecondary has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.WSA.Tile.GetSecondary has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.String GetTemplate(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.WSA.TileTemplate>())
			{
				return UnityEngine.WSA.Tile.GetTemplate(parameters[0].ToObject<UnityEngine.WSA.TileTemplate>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.WSA.Tile.GetTemplate has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.WSA.Tile.GetTemplate has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private void Delete(UnityEngine.WSA.Tile instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Delete();
			}
			if (parameters.CheckTypes<UnityEngine.Vector2>())
			{
				instance.Delete(parameters[0].ToObject<UnityEngine.Vector2>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Rect>())
			{
				instance.Delete(parameters[0].ToObject<UnityEngine.Rect>());
				return;
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.WSA.Tile.Delete has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void PeriodicBadgeUpdate(UnityEngine.WSA.Tile instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, System.Single>())
			{
				instance.PeriodicBadgeUpdate(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Single>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.WSA.Tile.PeriodicBadgeUpdate has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.WSA.Tile.PeriodicBadgeUpdate has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void PeriodicUpdate(UnityEngine.WSA.Tile instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, System.Single>())
			{
				instance.PeriodicUpdate(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Single>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.WSA.Tile.PeriodicUpdate has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.WSA.Tile.PeriodicUpdate has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void RemoveBadge(UnityEngine.WSA.Tile instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.RemoveBadge();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.WSA.Tile.RemoveBadge has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void StopPeriodicBadgeUpdate(UnityEngine.WSA.Tile instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.StopPeriodicBadgeUpdate();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.WSA.Tile.StopPeriodicBadgeUpdate has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void StopPeriodicUpdate(UnityEngine.WSA.Tile instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.StopPeriodicUpdate();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.WSA.Tile.StopPeriodicUpdate has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void Update(UnityEngine.WSA.Tile instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				instance.Update(parameters[0].ToObject<System.String>());
				return;
			}
			if (parameters.CheckTypes<System.String, System.String, System.String, System.String>())
			{
				instance.Update(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.String>(), parameters[2].ToObject<System.String>(), parameters[3].ToObject<System.String>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.WSA.Tile.Update has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.WSA.Tile.Update has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void UpdateBadgeImage(UnityEngine.WSA.Tile instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				instance.UpdateBadgeImage(parameters[0].ToObject<System.String>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.WSA.Tile.UpdateBadgeImage has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.WSA.Tile.UpdateBadgeImage has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void UpdateBadgeNumber(UnityEngine.WSA.Tile instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single>())
			{
				instance.UpdateBadgeNumber(parameters[0].ToObject<System.Single>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.WSA.Tile.UpdateBadgeNumber has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.WSA.Tile.UpdateBadgeNumber has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private UnityEngine.WSA.Tile get_main()
		{
			return UnityEngine.WSA.Tile.main;
		}

		static private System.String get_id(UnityEngine.WSA.Tile instance)
		{
			return instance.id;
		}

		static private System.Boolean get_hasUserConsent(UnityEngine.WSA.Tile instance)
		{
			return instance.hasUserConsent;
		}

		static private System.Boolean get_exists(UnityEngine.WSA.Tile instance)
		{
			return instance.exists;
		}

	}
}
#endif
