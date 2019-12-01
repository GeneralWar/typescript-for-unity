using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace General.Typescript
{
    internal partial class NamespaceBinder : BinderBase
	{
		private const string UNITY_BINDER_TEMPLATE =
			   @"using System;

namespace General.Typescript
{{
    public class {0}Binder
    {{
        static public void Initialize()
        {{
            Namespace self = Entry.DeclareNamespace(""{0}"");

{1}
        }}
    }}
}}";
		private const string CHILD_BINDER_TEMPLATE =
			   @"using System;

namespace General.Typescript
{{
    public class {0}Binder
    {{
        static public void Bind(Namespace parent)
        {{
            Namespace self = parent.DeclareNamespace(""{0}"");

{1}
        }}
    }}
}}";

		private SortedList<string, ClassBinder> mClasses = new SortedList<string, ClassBinder>();
        private SortedList<string, NamespaceBinder> mSpaces = new SortedList<string, NamespaceBinder>();

        private NamespaceBinder(string name, NamespaceBinder parent = null) : base(name.Contains(".") ? name.Substring(name.LastIndexOf('.') + 1) : name, parent)
        {
            sSpaces.Add(mFullname, this);
        }

		protected override void addChild(BinderBase child)
		{
			base.addChild(child);
			if (child is NamespaceBinder)
			{
				mSpaces.Add(child.Name, child as NamespaceBinder);
			}
		}

		protected override byte[] generateBinder()
        {
			if (0 == mChildren.Count)
			{
				return null;
			}

            Dictionary<string, List<string>> binders = new Dictionary<string, List<string>>();
			List<string> normalBinders = new List<string>();
			binders.Add("", normalBinders);

			foreach (NamespaceBinder binder in mSpaces.Values)
			{
				if (binder.GenerateBinder())
				{
					normalBinders.Add(binder.BinderName);
				}
			}

            foreach (ClassBinder binder in mClasses.Values)
            {
				if (binder.GenerateBinder())
				{
					List<string> list = null;
					if (!binders.TryGetValue(binder.Condition, out list))
					{
						binders.Add(binder.Condition, list = new List<string>());
					}
					list.Add(binder.BinderName);
				}
            }

            List<string> lines = new List<string>();
            foreach (KeyValuePair<string, List<string>> pair in binders)
            {
                if (!string.IsNullOrEmpty(pair.Key))
                {
                    lines.Add(pair.Key);
                }
                lines.Add(string.Join(Environment.NewLine, pair.Value.ConvertAll<string>(binder => string.Format("\t\t\t{0}.Bind(self);", binder))));
                if (!string.IsNullOrEmpty(pair.Key))
                {
                    lines.Add("#endif");
                }
            }

            return 0 == lines.Count ? null : Encoding.UTF8.GetBytes(string.Format(null == mParent ? UNITY_BINDER_TEMPLATE : CHILD_BINDER_TEMPLATE, mName, string.Join(Environment.NewLine, lines)));
        }

        protected override byte[] generateLibrary()
        {
            foreach (NamespaceBinder binder in mSpaces.Values)
            {
                if (binder.GenerateLibrary())
                {

                }
            }
            foreach (ClassBinder binder in mClasses.Values)
            {
                if (binder.GenerateLibrary())
                {

                }
            }
            return null;
        }

        internal ClassBinder DeclareClass(Type type)
        {
            ClassBinder binder = ClassBinder.Create(type, this);
            if (null != binder)
            {
                mClasses.Add(binder.Name, binder);
            }
            return binder;
        }
    }
}
