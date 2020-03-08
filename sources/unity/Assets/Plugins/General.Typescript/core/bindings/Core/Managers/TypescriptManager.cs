using General.Typescript;
using UnityEngine;

namespace General
{
    public partial class TypescriptManager : MonoBehaviour
    {
        private void Awake()
        {
            if (sInstance)
            {
                Entry.LogError("There is already an instance of TypescriptManager!");
                return;
            }
            sInstance = this;
        }
    }
}
