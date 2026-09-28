using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.UI;

public class ChallengeVsTitleSwitcher : MonoBehaviour
{
	private List<Sprite> spritesLeveled;

	private Image challengeImage;

	private GameEventsChannel events;

	private KGame game;

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_008d: Expected O, but got I
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_00ad: Expected O, but got I
		//IL_00d7: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_006c: Expected I, but got O
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)136;
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)3584;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj7 = this + 56;
		object obj8 = default(object);
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj4);
		events.OnShowAnimation += action;
	}

	private void AnimationStarted()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0050: Expected O, but got I
		//IL_0103: Expected O, but got I4
		//IL_00c0: Expected O, but got I4
		//IL_0205: Expected O, but got I4
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Expected I4, but got Unknown
		//IL_0263: Expected O, but got I4
		//IL_02cb: Expected O, but got I4
		//IL_01b4: Expected I, but got O
		//IL_01c4: Expected O, but got I
		//IL_01d4: Expected O, but got I
		Room room = game.Room;
		int friendlyChallengeLevel = SFSKammelnaRoomExtensions.GetFriendlyChallengeLevel(room);
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF144]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X0_v11+E4]");
			if ((nint)0 != 0)
			{
				goto IL_009a;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_009a;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		List<object> list = (List<object>)(object)spritesLeveled;
		goto IL_012a;
		IL_01de:
		throw new NullReferenceException();
		IL_012a:
		int num = ((friendlyChallengeLevel >= 0) ? friendlyChallengeLevel : (-friendlyChallengeLevel));
		int num2 = list._size - 1;
		object obj5 = num - num2;
		bool flag2 = (nint)obj5 < 0;
		int num3 = num ^ num2;
		int num4 = num ^ obj5;
		int num5 = num3 & num4;
		bool flag3 = num5 < 0;
		bool flag4 = flag2 == flag3;
		object obj6 = !flag4;
		object obj7 = ~obj6;
		if (obj7 == null)
		{
			num2 = num;
		}
		bool flag5 = num < 0;
		int num6 = num ^ num;
		int num7 = num & num6;
		bool flag6 = num7 < 0;
		bool flag7 = flag5 == flag6;
		object obj8 = !flag7;
		object obj9 = ~obj8;
		int index = ((obj9 != null) ? num2 : 0);
		object sprite = list.get_Item(index);
		challengeImage.sprite = (Sprite)sprite;
		Image image = challengeImage;
		nint num8 = (nint)image;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v8 (Il2CppClass<UnityEngine.UI.Image>)+408]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v8 (Il2CppClass<UnityEngine.UI.Image>)+410]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v123 @ X2_v4 (should have been resolved before IL gen)");
		goto IL_01de;
		IL_009a:
		list = (List<object>)(object)spritesLeveled;
		bool flag8 = spritesLeveled == null;
		object obj12 = !flag8;
		if (obj12 != null)
		{
			goto IL_012a;
		}
		goto IL_01de;
	}
}
