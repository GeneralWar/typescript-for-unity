using System;
using System.Collections.Generic;
using System.Reflection;

namespace General.Typescript
{
	abstract internal class ClassBinder : BinderBase
	{
		protected Type mType = null;

		protected string mCondition = string.Empty;
		internal override string Condition { get { return mCondition; } }

		protected SortedList<string, ClassBinder> mNestedClassed = new SortedList<string, ClassBinder>();

		internal ClassBinder(Type type, BinderBase parent) : base(type.Name, parent, type.Name + "Binder", type.FullName.Replace(".", "").Replace("+", ""))
		{
			mType = type;
			if (mType.IsNested)
			{
				mFullname = mType.FullName.Replace('+', '.');
			}
		}

		protected string checkCondition()
		{
			mCondition = "";
			if (mType.FullName.Contains("Android"))
			{
				mCondition = "#if UNITY_ANDROID";
			}
			else if (mType.FullName.Contains("iPhone") || mType.FullName.Contains("iOS"))
			{
				mCondition = "#if UNITY_IPHONE";
			}
			else if (mType.FullName.Contains("Touch"))
			{
				mCondition = "#if !UNITY_STANDALONE";
			}
			else if (mType.FullName.Contains("FullScreenMovieScalingMode") || mType.FullName.Contains("FullScreenMovieControlMode"))
			{
				mCondition = "#if !UNITY_STANDALONE_WIN && !UNITY_IPHONE";
			}
			else if (mType.FullName.Contains("TextureCompressionQuality"))
			{
				mCondition = "#if !UNITY_STANDALONE_WIN && !UNITY_IPHONE && !UNITY_ANDROID";
			}
			else if (mType.FullName.Contains("tvOS"))
			{
				mCondition = "#if UNITY_TVOS";
			}
			else if (mType.FullName.Contains("WSA"))
			{
				mCondition = "#if UNITY_WSA";
			}
			else if (mType.FullName.Contains("Windows"))
			{
				mCondition = "#if UNITY_STANDALONE_WIN";
			}
			return mCondition;
		}

		public override string ToString()
		{
			return mType.FullName;
		}

		internal ClassBinder DeclareClass(Type type)
		{
			ClassBinder binder = ClassBinder.Create(type, this);
			if (null != binder)
			{
				mNestedClassed.Add(binder.Name, binder);
			}
			return binder;
		}

		static internal ClassBinder Create(Type type, BinderBase parent)
		{
			if (Utils.IsSupported(type))
			{
				return type.IsEnum ? EnumClassBinder.Create(type, parent) as ClassBinder : TypeClassBinder.Create(type, parent) as ClassBinder;
			}
			return null;
		}
	}
}
