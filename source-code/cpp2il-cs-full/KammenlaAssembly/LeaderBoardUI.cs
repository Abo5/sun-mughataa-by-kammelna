using System;
using System.Buffers.Text;
using System.Collections.Generic;
using Cpp2ILInjected;
using DataTracking;
using Kammelna.Server.Models.Clans;
using UnityEngine;

public class LeaderBoardUI : MonoBehaviour, IInitializable
{
	private List<ILeaderboardSource> leaderboardSources;

	private SlideAnimationHelper contentPopup;

	private TabsUI tabs;

	private bool instantiateLeaderboards = true;

	private TopPlayersList playersListPrefab;

	private List<TopPlayersList> playersLists;

	private bool isInitialized;

	public bool InstantiateLists => instantiateLeaderboards;

	public bool SourcesNotEqualLists
	{
		get
		{
			//IL_00aa: Expected O, but got I4
			//IL_00b3: Expected O, but got I4
			//IL_011d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0122: Expected O, but got Unknown
			//IL_00ca: Expected O, but got I4
			List<ILeaderboardSource> list = leaderboardSources;
			int? num;
			int? num3;
			int? num4;
			int? num5;
			if (leaderboardSources != null)
			{
				num = list._size;
				int? num2 = (int?)playersLists;
				bool flag = playersLists == null;
				num3 = num;
				num4 = num;
				num5 = (int?)playersLists;
				if (!flag)
				{
					goto IL_005a;
				}
			}
			else
			{
				int? num2 = (int?)playersLists;
				bool flag2 = playersLists == null;
				object obj = !flag2;
				num3 = (int?)(object)0;
				if (obj != null)
				{
					goto IL_005a;
				}
				num4 = (int?)(object)0;
				num5 = (int?)playersLists;
			}
			goto IL_0103;
			IL_005a:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v7 (System.Nullable`1<System.Int32>)+18]");
			num = 0;
			num4 = num3;
			num5 = num;
			goto IL_0103;
			IL_0103:
			object obj2 = (object?)num5 ^ (object?)num4;
			object obj3 = obj2 & -4294967295L;
			bool flag3 = obj3 == null;
			return !flag3;
		}
	}

	public bool TabsNeeded
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0102: Expected O, but got I4
			//IL_00b5: Expected O, but got I4
			//IL_0224: Expected I4, but got O
			//IL_018c: Expected O, but got I4
			//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cf: Expected I4, but got Unknown
			//IL_0204: Expected O, but got I4
			//IL_020c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0211: Expected I4, but got Unknown
			object obj = 152985600;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E622F]");
			object obj3 = (nint)0 & (nint)1;
			UnityEngine.Object obj5;
			UnityEngine.Object obj6;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v4+E4]");
				bool flag = (nint)0 == 0;
				obj5 = tabs;
				obj6 = tabs;
				if (!flag)
				{
					goto IL_0091;
				}
			}
			else
			{
				_ = 1;
				obj5 = tabs;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v4+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				obj6 = tabs;
				if (obj7 != null)
				{
					goto IL_0091;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = obj6 == null;
			if (!flag3)
			{
				goto IL_00c3;
			}
			goto IL_0150;
			IL_00c3:
			return flag3;
			IL_0150:
			List<ILeaderboardSource> list = leaderboardSources;
			if (leaderboardSources != null)
			{
				object obj8 = list._size - 1;
				bool flag4 = (nint)obj8 < 0;
				bool flag5 = obj8 == null;
				int num = list._size ^ 1;
				int num2 = list._size ^ obj8;
				int num3 = num & num2;
				bool flag6 = num3 < 0;
				bool flag7 = flag4 == flag6;
				object obj9 = !flag5;
				return (byte)((flag7 & obj9) ? 1 : 0) != 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0091:
			flag3 = obj5 == null;
			bool flag8 = !flag3;
			object obj10 = !flag8;
			if (obj10 == null)
			{
				goto IL_00c3;
			}
			goto IL_0150;
		}
	}

	private void LoadLeaderBoard()
	{
		//IL_03a0: Expected O, but got I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_006b: Expected O, but got I4
		//IL_00fd: Expected O, but got I
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected O, but got Unknown
		//IL_0157: Expected O, but got I4
		//IL_01fa: Expected O, but got I
		//IL_02b5: Expected O, but got I4
		bool flag = !isInitialized;
		object obj = !flag;
		if (obj != null)
		{
			return;
		}
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3+E4]");
		if ((nint)0 != 0)
		{
			bool flag2 = contentPopup;
			bool flag3 = !flag2;
			object obj4 = !flag3;
			if (obj4 == null)
			{
				goto IL_0079;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (!contentPopup)
			{
				goto IL_0079;
			}
		}
		contentPopup.DisableAll();
		SlideAnimationHelper slideAnimationHelper = contentPopup;
		object obj5 = (nint)0 + (nint)4040;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		RectTransform rectTransform = default(RectTransform);
		Rect rect = rectTransform.rect;
		object obj6 = typeof(System.Buffers.Text.ParserHelpers) + 3512;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X0_v34+E4]");
		bool flag4 = (nint)0 == 0;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num = default(float);
		slideAnimationHelper.slideDownDistance = num;
		bool flag5 = !instantiateLeaderboards;
		float num2 = num;
		if (!flag5)
		{
			goto IL_01ab;
		}
		goto IL_01df;
		IL_01df:
		List<ILeaderboardSource> list = leaderboardSources;
		object obj9 = (nint)0 + (nint)784;
		int num3 = 0;
		object obj12 = default(object);
		GameObject gameObject;
		while (num3 < list._size)
		{
			if (instantiateLeaderboards)
			{
				Transform transform = playersListPrefab.transform;
				Transform parent = transform.parent;
				object obj10 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v21+E4]");
				bool flag6 = (nint)0 == 0;
				object obj11 = !flag6;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
			}
			else
			{
				obj12 = ((List<object>)(object)playersLists).get_Item(num3);
			}
			object source = ((List<object>)(object)leaderboardSources).get_Item(num3);
			((TopPlayersList)obj12).SetSource((ILeaderboardSource)source);
			bool flag7 = (object)tabs == null;
			gameObject = null;
			if (!flag7)
			{
				GameObject gameObject2 = ((Component)obj12).gameObject;
				tabs.SetTabView(num3, gameObject2);
				gameObject = gameObject2;
			}
			num3++;
			list = leaderboardSources;
		}
		isInitialized = true;
		return;
		IL_0079:
		if (instantiateLeaderboards)
		{
			goto IL_01ab;
		}
		num2 = num;
		goto IL_01df;
		IL_01ab:
		GameObject gameObject3 = playersListPrefab.gameObject;
		gameObject3.SetActive(value: false);
		gameObject = null;
		num2 = num;
		goto IL_01df;
	}

	public void Initialize()
	{
		Show();
	}

	public void Show()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_018d: Expected O, but got I4
		//IL_00ba: Expected O, but got I4
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected O, but got Unknown
		//IL_0200: Expected O, but got I
		//IL_0226: Expected O, but got I4
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00e3: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6231]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			LoadLeaderBoard();
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			obj5 = contentPopup;
			obj6 = contentPopup;
			if (!flag)
			{
				goto IL_0097;
			}
		}
		else
		{
			_ = 1;
			LoadLeaderBoard();
			obj5 = contentPopup;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v5+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = contentPopup;
			if (obj7 != null)
			{
				goto IL_0097;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		if (!obj6)
		{
			goto IL_00c8;
		}
		goto IL_01da;
		IL_011c:
		TabsUI tabsUI;
		tabsUI.ActivateHome();
		object obj8;
		object type = obj8;
		object obj9;
		object action = obj9;
		goto IL_013a;
		IL_00c8:
		obj9 = "Unsupported map type" + 2864;
		obj8 = (nint)0 + (nint)2000;
		tabsUI = tabs;
		bool flag3 = (object)tabs == null;
		type = obj8;
		action = obj9;
		if (!flag3)
		{
			goto IL_011c;
		}
		goto IL_013a;
		IL_013a:
		FirebaseTrack.Event((string)action, (string)type);
		return;
		IL_0097:
		bool flag4 = obj5;
		bool flag5 = !flag4;
		object obj10 = !flag5;
		if (obj10 == null)
		{
			goto IL_00c8;
		}
		goto IL_01da;
		IL_01da:
		contentPopup.SlideIn();
		obj9 = "Unsupported map type" + 2864;
		obj8 = (nint)0 + (nint)2000;
		tabsUI = tabs;
		bool flag6 = (object)tabs == null;
		object obj11 = !flag6;
		if (obj11 != null)
		{
			goto IL_011c;
		}
		type = obj8;
		action = obj9;
		goto IL_013a;
	}
}
