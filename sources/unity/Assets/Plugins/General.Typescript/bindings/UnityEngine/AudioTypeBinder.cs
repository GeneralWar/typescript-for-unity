using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineAudioType
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.AudioType> instance = space.DeclareEnum<UnityEngine.AudioType>();
			instance.SetValue("UNKNOWN", (long)UnityEngine.AudioType.UNKNOWN);
			instance.SetValue("ACC", (long)UnityEngine.AudioType.ACC);
			instance.SetValue("AIFF", (long)UnityEngine.AudioType.AIFF);
			instance.SetValue("IT", (long)UnityEngine.AudioType.IT);
			instance.SetValue("MOD", (long)UnityEngine.AudioType.MOD);
			instance.SetValue("MPEG", (long)UnityEngine.AudioType.MPEG);
			instance.SetValue("OGGVORBIS", (long)UnityEngine.AudioType.OGGVORBIS);
			instance.SetValue("S3M", (long)UnityEngine.AudioType.S3M);
			instance.SetValue("WAV", (long)UnityEngine.AudioType.WAV);
			instance.SetValue("XM", (long)UnityEngine.AudioType.XM);
			instance.SetValue("XMA", (long)UnityEngine.AudioType.XMA);
			instance.SetValue("VAG", (long)UnityEngine.AudioType.VAG);
			instance.SetValue("AUDIOQUEUE", (long)UnityEngine.AudioType.AUDIOQUEUE);
		}
	}
}
