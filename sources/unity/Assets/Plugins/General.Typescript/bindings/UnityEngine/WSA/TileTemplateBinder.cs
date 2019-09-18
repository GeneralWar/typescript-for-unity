#if UNITY_WSA
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineWSATileTemplate
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.WSA.TileTemplate> instance = space.DeclareEnum<UnityEngine.WSA.TileTemplate>();
			instance.SetValue("TileSquare150x150Image", (long)UnityEngine.WSA.TileTemplate.TileSquare150x150Image);
			instance.SetValue("TileSquare150x150Block", (long)UnityEngine.WSA.TileTemplate.TileSquare150x150Block);
			instance.SetValue("TileSquare150x150Text01", (long)UnityEngine.WSA.TileTemplate.TileSquare150x150Text01);
			instance.SetValue("TileSquare150x150Text02", (long)UnityEngine.WSA.TileTemplate.TileSquare150x150Text02);
			instance.SetValue("TileSquare150x150Text03", (long)UnityEngine.WSA.TileTemplate.TileSquare150x150Text03);
			instance.SetValue("TileSquare150x150Text04", (long)UnityEngine.WSA.TileTemplate.TileSquare150x150Text04);
			instance.SetValue("TileSquare150x150PeekImageAndText01", (long)UnityEngine.WSA.TileTemplate.TileSquare150x150PeekImageAndText01);
			instance.SetValue("TileSquare150x150PeekImageAndText02", (long)UnityEngine.WSA.TileTemplate.TileSquare150x150PeekImageAndText02);
			instance.SetValue("TileSquare150x150PeekImageAndText03", (long)UnityEngine.WSA.TileTemplate.TileSquare150x150PeekImageAndText03);
			instance.SetValue("TileSquare150x150PeekImageAndText04", (long)UnityEngine.WSA.TileTemplate.TileSquare150x150PeekImageAndText04);
			instance.SetValue("TileWide310x150Image", (long)UnityEngine.WSA.TileTemplate.TileWide310x150Image);
			instance.SetValue("TileWide310x150ImageCollection", (long)UnityEngine.WSA.TileTemplate.TileWide310x150ImageCollection);
			instance.SetValue("TileWide310x150ImageAndText01", (long)UnityEngine.WSA.TileTemplate.TileWide310x150ImageAndText01);
			instance.SetValue("TileWide310x150ImageAndText02", (long)UnityEngine.WSA.TileTemplate.TileWide310x150ImageAndText02);
			instance.SetValue("TileWide310x150BlockAndText01", (long)UnityEngine.WSA.TileTemplate.TileWide310x150BlockAndText01);
			instance.SetValue("TileWide310x150BlockAndText02", (long)UnityEngine.WSA.TileTemplate.TileWide310x150BlockAndText02);
			instance.SetValue("TileWide310x150PeekImageCollection01", (long)UnityEngine.WSA.TileTemplate.TileWide310x150PeekImageCollection01);
			instance.SetValue("TileWide310x150PeekImageCollection02", (long)UnityEngine.WSA.TileTemplate.TileWide310x150PeekImageCollection02);
			instance.SetValue("TileWide310x150PeekImageCollection03", (long)UnityEngine.WSA.TileTemplate.TileWide310x150PeekImageCollection03);
			instance.SetValue("TileWide310x150PeekImageCollection04", (long)UnityEngine.WSA.TileTemplate.TileWide310x150PeekImageCollection04);
			instance.SetValue("TileWide310x150PeekImageCollection05", (long)UnityEngine.WSA.TileTemplate.TileWide310x150PeekImageCollection05);
			instance.SetValue("TileWide310x150PeekImageCollection06", (long)UnityEngine.WSA.TileTemplate.TileWide310x150PeekImageCollection06);
			instance.SetValue("TileWide310x150PeekImageAndText01", (long)UnityEngine.WSA.TileTemplate.TileWide310x150PeekImageAndText01);
			instance.SetValue("TileWide310x150PeekImageAndText02", (long)UnityEngine.WSA.TileTemplate.TileWide310x150PeekImageAndText02);
			instance.SetValue("TileWide310x150PeekImage01", (long)UnityEngine.WSA.TileTemplate.TileWide310x150PeekImage01);
			instance.SetValue("TileWide310x150PeekImage02", (long)UnityEngine.WSA.TileTemplate.TileWide310x150PeekImage02);
			instance.SetValue("TileWide310x150PeekImage03", (long)UnityEngine.WSA.TileTemplate.TileWide310x150PeekImage03);
			instance.SetValue("TileWide310x150PeekImage04", (long)UnityEngine.WSA.TileTemplate.TileWide310x150PeekImage04);
			instance.SetValue("TileWide310x150PeekImage05", (long)UnityEngine.WSA.TileTemplate.TileWide310x150PeekImage05);
			instance.SetValue("TileWide310x150PeekImage06", (long)UnityEngine.WSA.TileTemplate.TileWide310x150PeekImage06);
			instance.SetValue("TileWide310x150SmallImageAndText01", (long)UnityEngine.WSA.TileTemplate.TileWide310x150SmallImageAndText01);
			instance.SetValue("TileWide310x150SmallImageAndText02", (long)UnityEngine.WSA.TileTemplate.TileWide310x150SmallImageAndText02);
			instance.SetValue("TileWide310x150SmallImageAndText03", (long)UnityEngine.WSA.TileTemplate.TileWide310x150SmallImageAndText03);
			instance.SetValue("TileWide310x150SmallImageAndText04", (long)UnityEngine.WSA.TileTemplate.TileWide310x150SmallImageAndText04);
			instance.SetValue("TileWide310x150SmallImageAndText05", (long)UnityEngine.WSA.TileTemplate.TileWide310x150SmallImageAndText05);
			instance.SetValue("TileWide310x150Text01", (long)UnityEngine.WSA.TileTemplate.TileWide310x150Text01);
			instance.SetValue("TileWide310x150Text02", (long)UnityEngine.WSA.TileTemplate.TileWide310x150Text02);
			instance.SetValue("TileWide310x150Text03", (long)UnityEngine.WSA.TileTemplate.TileWide310x150Text03);
			instance.SetValue("TileWide310x150Text04", (long)UnityEngine.WSA.TileTemplate.TileWide310x150Text04);
			instance.SetValue("TileWide310x150Text05", (long)UnityEngine.WSA.TileTemplate.TileWide310x150Text05);
			instance.SetValue("TileWide310x150Text06", (long)UnityEngine.WSA.TileTemplate.TileWide310x150Text06);
			instance.SetValue("TileWide310x150Text07", (long)UnityEngine.WSA.TileTemplate.TileWide310x150Text07);
			instance.SetValue("TileWide310x150Text08", (long)UnityEngine.WSA.TileTemplate.TileWide310x150Text08);
			instance.SetValue("TileWide310x150Text09", (long)UnityEngine.WSA.TileTemplate.TileWide310x150Text09);
			instance.SetValue("TileWide310x150Text10", (long)UnityEngine.WSA.TileTemplate.TileWide310x150Text10);
			instance.SetValue("TileWide310x150Text11", (long)UnityEngine.WSA.TileTemplate.TileWide310x150Text11);
			instance.SetValue("TileSquare310x310BlockAndText01", (long)UnityEngine.WSA.TileTemplate.TileSquare310x310BlockAndText01);
			instance.SetValue("TileSquare310x310BlockAndText02", (long)UnityEngine.WSA.TileTemplate.TileSquare310x310BlockAndText02);
			instance.SetValue("TileSquare310x310Image", (long)UnityEngine.WSA.TileTemplate.TileSquare310x310Image);
			instance.SetValue("TileSquare310x310ImageAndText01", (long)UnityEngine.WSA.TileTemplate.TileSquare310x310ImageAndText01);
			instance.SetValue("TileSquare310x310ImageAndText02", (long)UnityEngine.WSA.TileTemplate.TileSquare310x310ImageAndText02);
			instance.SetValue("TileSquare310x310ImageAndTextOverlay01", (long)UnityEngine.WSA.TileTemplate.TileSquare310x310ImageAndTextOverlay01);
			instance.SetValue("TileSquare310x310ImageAndTextOverlay02", (long)UnityEngine.WSA.TileTemplate.TileSquare310x310ImageAndTextOverlay02);
			instance.SetValue("TileSquare310x310ImageAndTextOverlay03", (long)UnityEngine.WSA.TileTemplate.TileSquare310x310ImageAndTextOverlay03);
			instance.SetValue("TileSquare310x310ImageCollectionAndText01", (long)UnityEngine.WSA.TileTemplate.TileSquare310x310ImageCollectionAndText01);
			instance.SetValue("TileSquare310x310ImageCollectionAndText02", (long)UnityEngine.WSA.TileTemplate.TileSquare310x310ImageCollectionAndText02);
			instance.SetValue("TileSquare310x310ImageCollection", (long)UnityEngine.WSA.TileTemplate.TileSquare310x310ImageCollection);
			instance.SetValue("TileSquare310x310SmallImagesAndTextList01", (long)UnityEngine.WSA.TileTemplate.TileSquare310x310SmallImagesAndTextList01);
			instance.SetValue("TileSquare310x310SmallImagesAndTextList02", (long)UnityEngine.WSA.TileTemplate.TileSquare310x310SmallImagesAndTextList02);
			instance.SetValue("TileSquare310x310SmallImagesAndTextList03", (long)UnityEngine.WSA.TileTemplate.TileSquare310x310SmallImagesAndTextList03);
			instance.SetValue("TileSquare310x310SmallImagesAndTextList04", (long)UnityEngine.WSA.TileTemplate.TileSquare310x310SmallImagesAndTextList04);
			instance.SetValue("TileSquare310x310Text01", (long)UnityEngine.WSA.TileTemplate.TileSquare310x310Text01);
			instance.SetValue("TileSquare310x310Text02", (long)UnityEngine.WSA.TileTemplate.TileSquare310x310Text02);
			instance.SetValue("TileSquare310x310Text03", (long)UnityEngine.WSA.TileTemplate.TileSquare310x310Text03);
			instance.SetValue("TileSquare310x310Text04", (long)UnityEngine.WSA.TileTemplate.TileSquare310x310Text04);
			instance.SetValue("TileSquare310x310Text05", (long)UnityEngine.WSA.TileTemplate.TileSquare310x310Text05);
			instance.SetValue("TileSquare310x310Text06", (long)UnityEngine.WSA.TileTemplate.TileSquare310x310Text06);
			instance.SetValue("TileSquare310x310Text07", (long)UnityEngine.WSA.TileTemplate.TileSquare310x310Text07);
			instance.SetValue("TileSquare310x310Text08", (long)UnityEngine.WSA.TileTemplate.TileSquare310x310Text08);
			instance.SetValue("TileSquare310x310TextList01", (long)UnityEngine.WSA.TileTemplate.TileSquare310x310TextList01);
			instance.SetValue("TileSquare310x310TextList02", (long)UnityEngine.WSA.TileTemplate.TileSquare310x310TextList02);
			instance.SetValue("TileSquare310x310TextList03", (long)UnityEngine.WSA.TileTemplate.TileSquare310x310TextList03);
			instance.SetValue("TileSquare310x310SmallImageAndText01", (long)UnityEngine.WSA.TileTemplate.TileSquare310x310SmallImageAndText01);
			instance.SetValue("TileSquare310x310SmallImagesAndTextList05", (long)UnityEngine.WSA.TileTemplate.TileSquare310x310SmallImagesAndTextList05);
			instance.SetValue("TileSquare310x310Text09", (long)UnityEngine.WSA.TileTemplate.TileSquare310x310Text09);
			instance.SetValue("TileSquare71x71IconWithBadge", (long)UnityEngine.WSA.TileTemplate.TileSquare71x71IconWithBadge);
			instance.SetValue("TileSquare150x150IconWithBadge", (long)UnityEngine.WSA.TileTemplate.TileSquare150x150IconWithBadge);
			instance.SetValue("TileWide310x150IconWithBadgeAndText", (long)UnityEngine.WSA.TileTemplate.TileWide310x150IconWithBadgeAndText);
			instance.SetValue("TileSquare71x71Image", (long)UnityEngine.WSA.TileTemplate.TileSquare71x71Image);
			instance.SetValue("TileTall150x310Image", (long)UnityEngine.WSA.TileTemplate.TileTall150x310Image);
			instance.SetValue("TileSquare99x99IconWithBadge", (long)UnityEngine.WSA.TileTemplate.TileSquare99x99IconWithBadge);
			instance.SetValue("TileSquare210x210IconWithBadge", (long)UnityEngine.WSA.TileTemplate.TileSquare210x210IconWithBadge);
			instance.SetValue("TileWide432x210IconWithBadgeAndText", (long)UnityEngine.WSA.TileTemplate.TileWide432x210IconWithBadgeAndText);
		}
	}
}
#endif
