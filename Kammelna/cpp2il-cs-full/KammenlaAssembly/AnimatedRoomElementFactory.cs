using System;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Spine.Unity;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;

public class AnimatedRoomElementFactory : ScriptableObject
{
	private Material spineDefaultMaterial;

	private SpineRoomElement spineRoomElementTemplate;

	private SpriteSheetRoomElement spriteSheetRoomElementTemplate;

	public unsafe SpineRoomElement CreateSpineRoomElement(SpineRoomElementData data, Transform parent)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		//IL_0089: Expected O, but got I
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_013b: Expected O, but got I4
		//IL_018e: Expected O, but got Ref
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 176;
		object obj2 = typeof(SqlSingle[]) + 240;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TextAsset textAsset = default(TextAsset);
		textAsset..ctor(data.<AtlasJson>k__BackingField);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		Texture2D[] array = default(Texture2D[]);
		if (array != null)
		{
			if (array.Length == 0)
			{
				goto IL_01e7;
			}
			object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj4 = (nint)0 + (nint)672;
			object obj5 = array + 32;
			obj5 = data.<Image>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			SpineAtlasAsset atlasAsset = SpineAtlasAsset.CreateRuntimeInstance(textAsset, array, spineDefaultMaterial, initialize: true);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			TextAsset textAsset2 = default(TextAsset);
			textAsset2..ctor(data.<AnimationJson>k__BackingField);
			SkeletonDataAsset skeletonAsset = SkeletonDataAsset.CreateRuntimeInstance(textAsset2, atlasAsset, initialize: true);
			object obj6 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X0_v19+E4]");
			bool flag = (nint)0 == 0;
			object obj7 = !flag;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
			SpineRoomElement spineRoomElement = default(SpineRoomElement);
			if ((object)spineRoomElement != null)
			{
				AnimatedRoomElementInfo animatedRoomElementInfo = default(AnimatedRoomElementInfo);
				spineRoomElement.ApplyRoomSetup((AnimatedRoomElementInfo)(&animatedRoomElementInfo));
				spineRoomElement.Setup(skeletonAsset);
				if ((object)((AnimatedRoomElement)spineRoomElement).audioSource != null)
				{
					((AnimatedRoomElement)spineRoomElement).audioSource.clip = data.<AudioClip>k__BackingField;
					return spineRoomElement;
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_01e7;
		IL_01e7:
		return (SpineRoomElement)(object)new IndexOutOfRangeException();
	}

	public unsafe SpriteSheetRoomElement CreateSpriteSheetRoomElement(AnimatedRoomElementInfo info, Texture2D image, Transform parent)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00ee: Expected O, but got I
		//IL_0122: Expected O, but got I4
		//IL_00c9: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_0180: Expected I, but got O
		//IL_018d: Expected O, but got Ref
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected O, but got Unknown
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected O, but got Unknown
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7902]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)688;
			SpriteSheetRoomElement spriteSheetRoomElement = spriteSheetRoomElementTemplate;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v12+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj4;
			SpriteSheetRoomElement spriteSheetRoomElement2 = spriteSheetRoomElementTemplate;
			if (!flag)
			{
				goto IL_00a5;
			}
		}
		else
		{
			_ = 1;
			object obj4 = (nint)0 + (nint)688;
			SpriteSheetRoomElement spriteSheetRoomElement = spriteSheetRoomElementTemplate;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v12+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			SpriteSheetRoomElement spriteSheetRoomElement2 = spriteSheetRoomElementTemplate;
			if (obj7 != null)
			{
				goto IL_00a5;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
		SpriteSheetRoomElement spriteSheetRoomElement3 = default(SpriteSheetRoomElement);
		if ((object)spriteSheetRoomElement3 != null)
		{
			goto IL_0178;
		}
		goto IL_0226;
		IL_0226:
		return (SpriteSheetRoomElement)(object)new NullReferenceException();
		IL_0178:
		nint num = (nint)spriteSheetRoomElement3;
		AnimatedRoomElementType animatedRoomElementType = default(AnimatedRoomElementType);
		spriteSheetRoomElement3.ApplyRoomSetup((AnimatedRoomElementInfo)(&animatedRoomElementType));
		SpriteSheetPlayer player = spriteSheetRoomElement3.player;
		if ((object)spriteSheetRoomElement3.player != null)
		{
			object obj8 = spriteSheetRoomElement3.player + 48;
			obj8 = image;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Sprite[] array = SpriteExensions.CreateSprites((Texture2D)obj8, player.gridSize);
			object obj9 = spriteSheetRoomElement3.player + 96;
			obj9 = array;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return spriteSheetRoomElement3;
		}
		goto IL_0226;
		IL_00a5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
		bool flag3 = (object)spriteSheetRoomElement3 == null;
		object obj10 = !flag3;
		if (obj10 != null)
		{
			goto IL_0178;
		}
		goto IL_0226;
	}
}
