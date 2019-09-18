#if UNITY_WSA
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineWSAFolder
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.WSA.Folder> instance = space.DeclareEnum<UnityEngine.WSA.Folder>();
			instance.SetValue("Installation", (long)UnityEngine.WSA.Folder.Installation);
			instance.SetValue("Temporary", (long)UnityEngine.WSA.Folder.Temporary);
			instance.SetValue("Local", (long)UnityEngine.WSA.Folder.Local);
			instance.SetValue("Roaming", (long)UnityEngine.WSA.Folder.Roaming);
			instance.SetValue("CameraRoll", (long)UnityEngine.WSA.Folder.CameraRoll);
			instance.SetValue("DocumentsLibrary", (long)UnityEngine.WSA.Folder.DocumentsLibrary);
			instance.SetValue("HomeGroup", (long)UnityEngine.WSA.Folder.HomeGroup);
			instance.SetValue("MediaServerDevices", (long)UnityEngine.WSA.Folder.MediaServerDevices);
			instance.SetValue("MusicLibrary", (long)UnityEngine.WSA.Folder.MusicLibrary);
			instance.SetValue("PicturesLibrary", (long)UnityEngine.WSA.Folder.PicturesLibrary);
			instance.SetValue("Playlists", (long)UnityEngine.WSA.Folder.Playlists);
			instance.SetValue("RemovableDevices", (long)UnityEngine.WSA.Folder.RemovableDevices);
			instance.SetValue("SavedPictures", (long)UnityEngine.WSA.Folder.SavedPictures);
			instance.SetValue("VideosLibrary", (long)UnityEngine.WSA.Folder.VideosLibrary);
		}
	}
}
#endif
