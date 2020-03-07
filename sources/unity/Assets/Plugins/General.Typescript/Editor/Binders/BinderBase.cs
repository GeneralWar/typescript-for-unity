using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace General.Typescript
{
    internal abstract partial class BinderBase
    {
        protected string mName = string.Empty;
        internal string Name { get { return mName; } }

        protected string mFullname = string.Empty;
        internal string Fullname { get { return mFullname; } }

        protected string mBinderName = string.Empty;
        public string BinderName { get { return mBinderName; } }

        internal abstract string Condition { get; }

        protected string mFilename = string.Empty;

        protected BinderBase mParent = null;
        protected SortedList<string, BinderBase> mChildren = new SortedList<string, BinderBase>();

        internal BinderBase(string name, BinderBase parent) : this(name, parent, name + "Binder", name + "Binder")
        {

        }

        internal BinderBase(string name, BinderBase parent, string filename, string bindername)
        {
            mName = name;
            mParent = parent;
            mFilename = filename;
            mBinderName = bindername;
            if (null == mParent)
            {
                mFullname = mName;
            }
            else
            {
                mFullname = mParent.Fullname + "." + mName;
                mParent.addChild(this);
            }
        }

        protected virtual void addChild(BinderBase child)
        {
            if (mChildren.ContainsKey(child.Name))
            {
                BinderBase exist = mChildren[child.Name];
                Entry.Log(exist.Fullname);
                Entry.LogError("There is already a child named {0} in {1}!", child.Name, mName);
            }
            else
            {
                mChildren.Add(child.Name, child);
            }
        }

        internal bool GenerateBinder(List<Type> delegates, bool writeToFile)
        {
            byte[] content = this.generateBinder(delegates);
            if (writeToFile && null != content && content.Length > 0)
            {
                string[] nameParts = mFullname.Split('.', '+');
                string outputPath = Path.Combine(sBinderOutputPath, string.Join(Path.DirectorySeparatorChar.ToString(), nameParts.Take(nameParts.Length - 1).ToArray()));
                if (!Directory.Exists(outputPath))
                {
                    Utility.CreateDirectory(outputPath);
                }
                try
                {
                    File.WriteAllBytes(Path.Combine(outputPath, string.Concat(mFilename, ".cs")), content);
                }
                catch (Exception e)
                {
                    Entry.LogError(e);
                    return false;
                }
                return true;
            }
            return false;
        }

        abstract protected byte[] generateBinder(List<Type> delegates);

        internal bool GenerateSnippets(bool writeToFile)
        {
            byte[] content = this.generateSnippets();
            if (writeToFile && null != content && content.Length > 0)
            {
                string[] nameParts = mFullname.Split('.');
                string outputPath = Path.Combine(sLibraryOutputPath, string.Join(Path.DirectorySeparatorChar.ToString(), nameParts.Take(nameParts.Length - 1).ToArray()));
                if (!Directory.Exists(outputPath))
                {
                    Utility.CreateDirectory(outputPath);
                }
                try
                {
                    File.WriteAllBytes(Path.Combine(outputPath, string.Concat(mName, ".d.ts")), content);
                }
                catch (Exception e)
                {
                    Entry.Log(mFullname + "Binder");
                    Entry.LogError(e);
                    return false;
                }
                return true;
            }
            return false;
        }

        internal string BracketAsNamespace(out int levels)
        {
            string content = string.Empty;
            if (null == mParent)
            {
                levels = 0;
                content = string.Format("declare namespace {0}\n{{", mName);
            }
            else
            {
                string parent = mParent.BracketAsNamespace(out levels);
                ++levels;
                string indent = string.Join("", Enumerable.Repeat("\t", levels).ToArray());
                content = string.Concat(parent, string.Format("\n{0}", indent), string.Format("declare namespace {0}\n{1}{{", mName, indent));
            }
            return content;
        }

        abstract protected byte[] generateSnippets();

        public override string ToString()
        {
            return mName;
        }
    }
}
