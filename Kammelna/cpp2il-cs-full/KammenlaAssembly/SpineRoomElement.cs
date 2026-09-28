using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Spine;
using Spine.Unity;
using UnityEngine;

public class SpineRoomElement : AnimatedRoomElement
{
	private SkeletonGraphic <spineAnimator>k__BackingField;

	private SkeletonGraphic spineAnimator
	{
		get
		{
			return <spineAnimator>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 80;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	protected override void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0100: Expected O, but got I4
		//IL_00ae: Expected O, but got I4
		//IL_014f: Expected O, but got I4
		//IL_0158: Expected O, but got I4
		//IL_0222: Expected O, but got I4
		//IL_022b: Expected O, but got I4
		//IL_01d2: Expected O, but got I4
		//IL_026f: Expected O, but got I
		//IL_049d: Expected O, but got I4
		//IL_02cf: Expected O, but got I
		//IL_02d8: Expected O, but got I4
		//IL_03ee: Expected O, but got I
		//IL_040b: Expected O, but got I4
		//IL_0419: Expected O, but got I4
		//IL_0394: Expected O, but got I
		//IL_03ac: Expected O, but got I4
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Expected O, but got Unknown
		//IL_0456: Expected O, but got I4
		//IL_03c8: Expected O, but got I4
		//IL_02fe: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E791A]");
		object obj2 = (nint)0 & (nint)1;
		Object obj3;
		Object obj5;
		if (obj2 != null)
		{
			obj3 = <spineAnimator>k__BackingField;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v16+E4]");
			bool flag = (nint)0 == 0;
			obj5 = <spineAnimator>k__BackingField;
			if (!flag)
			{
				goto IL_0088;
			}
		}
		else
		{
			_ = 1;
			obj3 = <spineAnimator>k__BackingField;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v16+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			obj5 = <spineAnimator>k__BackingField;
			if (obj6 != null)
			{
				goto IL_0088;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj5 == null;
		bool flag4 = !flag3;
		object obj7 = !flag4;
		object obj8 = 0;
		Object obj9 = null;
		if (obj7 == null)
		{
			goto IL_016b;
		}
		return;
		IL_016b:
		SkeletonGraphic skeletonGraphic = <spineAnimator>k__BackingField;
		object obj10 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v5+E4]");
		object obj11;
		Object obj12;
		if ((nint)0 != 0)
		{
			bool flag5 = skeletonGraphic.skeletonDataAsset == null;
			bool flag6 = !flag5;
			obj11 = 0;
			obj12 = null;
			if (!flag6)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag7 = skeletonGraphic.skeletonDataAsset == null;
			bool flag8 = !flag7;
			object obj13 = !flag8;
			obj11 = 0;
			obj12 = null;
			if (obj13 != null)
			{
				return;
			}
		}
		SkeletonGraphic skeletonGraphic2 = <spineAnimator>k__BackingField;
		Object skeletonDataAsset = skeletonGraphic2.skeletonDataAsset;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X19_v4 (UnityEngine.Object)+18]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X19_v4 (UnityEngine.Object)+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X22_v2+18]");
			if ((nint)0 >= (nint)1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X19_v4 (UnityEngine.Object)+18]");
				object obj15 = (nint)0 + (nint)32;
				object obj16 = 0;
				object obj17 = obj11;
				Object obj18 = obj12;
				bool flag14;
				do
				{
					object obj19 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X0_v13+E4]");
					object obj20;
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X24_v4+v241 @ X23_v5*8]");
						bool flag9 = (Object)0 != null;
						bool flag10 = !flag9;
						obj17 = 0;
						obj18 = null;
						if (flag10)
						{
							goto IL_0310;
						}
						obj20 = 0;
						Object obj21 = null;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X24_v4+v241 @ X23_v5*8]");
						bool flag11 = (Object)0 != null;
						bool flag12 = !flag11;
						obj17 = 0;
						obj18 = null;
						obj20 = 0;
						Object obj21 = null;
						if (flag12)
						{
							goto IL_0310;
						}
					}
					object obj22 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X0_v15+E4]");
					bool flag13 = (nint)0 == 0;
					object obj23 = !flag13;
					if (obj23 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X24_v4+v241 @ X23_v5*8]");
					Object.Destroy((Object)0);
					obj17 = obj20;
					obj18 = null;
					goto IL_0310;
					IL_0310:
					obj16++;
					object obj24 = obj16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X22_v2+18]");
					flag14 = (nint)obj24 >= 0;
					obj11 = obj17;
					obj12 = obj18;
				}
				while (!flag14);
			}
		}
		object obj25 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X0_v8+E4]");
		bool flag15 = (nint)0 == 0;
		object obj26 = !flag15;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Object.Destroy(skeletonDataAsset);
		return;
		IL_0088:
		bool flag16 = obj3 == null;
		bool flag17 = !flag16;
		obj8 = 0;
		obj9 = null;
		if (!flag17)
		{
			return;
		}
		goto IL_016b;
	}

	public void Setup(SkeletonDataAsset skeletonAsset)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_0040: Expected O, but got I4
		//IL_0050: Expected O, but got I
		//IL_0060: Expected O, but got I
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_00a4: Expected O, but got I4
		object obj = <spineAnimator>k__BackingField + 216;
		obj = skeletonAsset;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		SkeletonGraphic skeletonGraphic = <spineAnimator>k__BackingField;
		object obj2 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X9_v3+90]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X9_v4+B8]");
		object startingAnimation = 0;
		skeletonGraphic.startingAnimation = (string)startingAnimation;
		object obj4 = skeletonGraphic + 280;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		SkeletonGraphic skeletonGraphic2 = <spineAnimator>k__BackingField;
		object obj5 = loopCount + 1;
		bool startingLoop = obj5 == null;
		skeletonGraphic2.startingLoop = startingLoop;
		skeletonGraphic2.raycastTarget = false;
		<spineAnimator>k__BackingField.Initialize(overwrite: true);
	}

	public override void Prepare()
	{
	}

	public override void Play()
	{
		//IL_0029: Expected O, but got I4
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_0140: Expected O, but got I4
		//IL_00df: Expected O, but got I4
		Spine.AnimationState animationState = <spineAnimator>k__BackingField.AnimationState;
		object obj = loopCount + 1;
		bool loop = obj == null;
		TrackEntry trackEntry = animationState.SetAnimation(0, base.<ElementName>k__BackingField, loop);
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		AudioClip clip = audioSource.clip;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v5+E4]");
		if ((nint)0 != 0)
		{
			if (!clip)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag = clip;
			bool flag2 = !flag;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				return;
			}
		}
		object obj5 = loopCount + 1;
		bool loop2 = obj5 == null;
		audioSource.loop = loop2;
		audioSource.Play();
	}
}
