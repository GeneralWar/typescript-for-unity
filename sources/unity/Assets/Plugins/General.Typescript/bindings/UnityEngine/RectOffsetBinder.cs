using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRectOffset
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.RectOffset> self = space.DeclareClass<UnityEngine.RectOffset>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("Add", Add);
			self.BindInstanceFunction("Remove", Remove);
			self.BindInstanceFunction("ToString", ToString);
			self.BindInstanceProperty("left", get_left, set_left);
			self.BindInstanceProperty("right", get_right, set_right);
			self.BindInstanceProperty("top", get_top, set_top);
			self.BindInstanceProperty("bottom", get_bottom, set_bottom);
			self.BindInstanceProperty("horizontal", get_horizontal, null);
			self.BindInstanceProperty("vertical", get_vertical, null);
		}

		static private UnityEngine.RectOffset Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.RectOffset();
			}
			if (parameters.CheckTypes<System.Int32, System.Int32, System.Int32, System.Int32>())
			{
				return new UnityEngine.RectOffset(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<System.Int32>());
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.RectOffset.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.RectOffset);
		}

		static private UnityEngine.Rect Add(UnityEngine.RectOffset instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Rect>())
			{
				return instance.Add(parameters[0].ToObject<UnityEngine.Rect>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.RectOffset.Add has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.RectOffset.Add has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Rect);
		}

		static private UnityEngine.Rect Remove(UnityEngine.RectOffset instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Rect>())
			{
				return instance.Remove(parameters[0].ToObject<UnityEngine.Rect>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.RectOffset.Remove has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.RectOffset.Remove has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Rect);
		}

		static private System.String ToString(UnityEngine.RectOffset instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.ToString();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.RectOffset.ToString has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private System.Int32 get_left(UnityEngine.RectOffset instance)
		{
			return instance.left;
		}

		static private void set_left(UnityEngine.RectOffset instance, System.Int32 value)
		{
			instance.left = value;
		}

		static private System.Int32 get_right(UnityEngine.RectOffset instance)
		{
			return instance.right;
		}

		static private void set_right(UnityEngine.RectOffset instance, System.Int32 value)
		{
			instance.right = value;
		}

		static private System.Int32 get_top(UnityEngine.RectOffset instance)
		{
			return instance.top;
		}

		static private void set_top(UnityEngine.RectOffset instance, System.Int32 value)
		{
			instance.top = value;
		}

		static private System.Int32 get_bottom(UnityEngine.RectOffset instance)
		{
			return instance.bottom;
		}

		static private void set_bottom(UnityEngine.RectOffset instance, System.Int32 value)
		{
			instance.bottom = value;
		}

		static private System.Int32 get_horizontal(UnityEngine.RectOffset instance)
		{
			return instance.horizontal;
		}

		static private System.Int32 get_vertical(UnityEngine.RectOffset instance)
		{
			return instance.vertical;
		}

	}
}
