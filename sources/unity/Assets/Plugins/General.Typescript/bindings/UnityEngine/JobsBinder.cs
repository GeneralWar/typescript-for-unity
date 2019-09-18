using System;

namespace General.Typescript
{
    public class JobsBinder
    {
        static public void Bind(Namespace parent)
        {
            Namespace self = parent.DeclareNamespace("Jobs");

			UnityEngineJobsTransformAccess.Bind(self);
			UnityEngineJobsTransformAccessArray.Bind(self);
        }
    }
}