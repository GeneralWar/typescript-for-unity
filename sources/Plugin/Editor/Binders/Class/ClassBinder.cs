using System;
namespace General.Typescript
{
    abstract internal class ClassBinder : BinderBase
    {
        protected Type mType = null;

        protected string mCondition = string.Empty;
        internal string Condition { get { return mCondition; } }

        internal ClassBinder(Type type, BinderBase parent) : base(type.Name, parent)
        {
            mType = type;
			if (mType.IsSubType())
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

        static internal ClassBinder Create(Type type, NamespaceBinder parent)
        {
            if (type.IsPublic && type.IsStillInUse() && !type.IsGenericType && !type.Name.Contains("PlayerConnection"))

			{
                return type.IsEnum ? EnumClassBinder.Create(type, parent) as ClassBinder : TypeClassBinder.Create(type, parent) as ClassBinder;
            }
            return null;
        }
    }
}
