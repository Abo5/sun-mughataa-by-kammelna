using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using UnityEngine;

public class GiftAnimationDataModel
{
	private Texture2D <SpriteSheet>k__BackingField;

	private AudioClip <SoundEffect>k__BackingField;

	private SpriteSheetGiftData <AnimationData>k__BackingField;

	public Texture2D SpriteSheet
	{
		get
		{
			return <SpriteSheet>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 16;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public AudioClip SoundEffect
	{
		get
		{
			return <SoundEffect>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 24;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public SpriteSheetGiftData AnimationData
	{
		get
		{
			return <AnimationData>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 32;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public bool IsValid()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0100: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		//IL_00bd: Expected O, but got I4
		//IL_0152: Expected O, but got I4
		//IL_0233: Expected O, but got I4
		//IL_023c: Expected O, but got I4
		//IL_01b0: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6B58]");
		object obj3 = (nint)0 & (nint)1;
		Object obj5;
		Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v17+E4]");
			bool flag = (nint)0 == 0;
			obj5 = <SpriteSheet>k__BackingField;
			obj6 = <SpriteSheet>k__BackingField;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v17+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = <SpriteSheet>k__BackingField;
			obj6 = <SpriteSheet>k__BackingField;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		object obj8 = 0;
		if (!flag4)
		{
			goto IL_0160;
		}
		goto IL_024a;
		IL_01be:
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v9+E4]");
		if ((nint)0 != 0)
		{
			return <AnimationData>k__BackingField;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		return <AnimationData>k__BackingField;
		IL_024a:
		return false;
		IL_0160:
		object obj10 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v4+E4]");
		if ((nint)0 != 0)
		{
			bool flag5 = <SoundEffect>k__BackingField;
			bool flag6 = !flag5;
			object obj11 = 0;
			if (!flag6)
			{
				goto IL_01be;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag7 = <SoundEffect>k__BackingField;
			bool flag8 = !flag7;
			object obj12 = !flag8;
			object obj11 = 0;
			if (obj12 != null)
			{
				goto IL_01be;
			}
		}
		goto IL_024a;
		IL_0091:
		bool flag9 = obj5;
		bool flag10 = !flag9;
		object obj13 = !flag10;
		obj8 = 0;
		if (obj13 != null)
		{
			goto IL_0160;
		}
		goto IL_024a;
	}
}
