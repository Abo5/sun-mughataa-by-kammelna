using System;
using System.ComponentModel;
using Cpp2ILInjected;
using DataTracking;
using Kammelna.Server.Models.Clans;
using ListView;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NormalPlaceItem : ListViewItem<LeaderBoardPlayerHolder, int>
{
	private TextMeshProUGUI placeText;

	private AvatarInitializer avatar;

	private Image diffIcon;

	private TextMeshProUGUI pointsText;

	private GameObject userRank;

	private NumberFormatter numberFormatter;

	private Sprite upRank;

	private Sprite sameRank;

	private Sprite downRank;

	private Graphic highlight;

	private Color[] highlightColors;

	private LeaderBoardPlayer _player;

	public unsafe override void Setup(LeaderBoardPlayerHolder datum, bool firstTime)
	{
		//IL_0015: Expected O, but got Ref
		//IL_0027: Expected O, but got I
		int num = default(int);
		bool firstTime2 = default(bool);
		base.Setup((LeaderBoardPlayerHolder)(&num), firstTime2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (NormalPlaceItem)+50]");
		Populate((LeaderBoardPlayer)0);
	}

	public unsafe void Populate(LeaderBoardPlayer player)
	{
		//IL_0870: Unknown result type (might be due to invalid IL or missing references)
		//IL_0875: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00cd: Expected I8, but got I4
		//IL_00ec: Expected O, but got I4
		//IL_0054: Expected I8, but got I4
		//IL_089c: Expected O, but got I
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected I4, but got Unknown
		//IL_00a2: Expected O, but got I4
		//IL_01ce: Expected O, but got I
		//IL_01e3: Expected I, but got O
		//IL_01f3: Expected O, but got I
		//IL_01a7: Expected O, but got I4
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected O, but got Unknown
		//IL_047d: Expected O, but got I4
		//IL_02af: Expected O, but got I4
		//IL_04f9: Expected O, but got I4
		//IL_052c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0531: Expected I4, but got Unknown
		//IL_058d: Expected O, but got I4
		//IL_08da: Expected O, but got I4
		//IL_057f: Expected O, but got I4
		//IL_0332: Expected O, but got I4
		//IL_0908: Expected O, but got I
		//IL_059b: Expected O, but got I4
		//IL_0614: Expected O, but got I4
		//IL_061d: Expected O, but got I4
		//IL_0626: Expected O, but got I4
		//IL_03b5: Expected O, but got I4
		//IL_0724: Expected O, but got I4
		//IL_072d: Expected O, but got I4
		//IL_0736: Expected O, but got I4
		//IL_0800: Expected O, but got I4
		//IL_0809: Expected O, but got I4
		//IL_0853: Expected O, but got I4
		object obj = this + 232;
		obj = player;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v6+E4]");
		if ((nint)0 != 0)
		{
			if (!FriendsManager.IsBlocked(player.Id))
			{
				goto IL_00fa;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag = FriendsManager.IsBlocked(player.Id);
			bool flag2 = !flag;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				goto IL_00fa;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (NormalPlaceItem)+50]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (NormalPlaceItem)+50]");
		int points;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X8_v54+38]");
			points = 0;
			bool flag3 = (object)avatar == null;
			object obj6 = !flag3;
			if (obj6 == null)
			{
				goto IL_0863;
			}
		}
		else
		{
			points = 0;
		}
		avatar.InitializeBlockedUser(points);
		goto IL_0144;
		IL_0863:
		throw new NullReferenceException();
		IL_03cc:
		UnityEngine.Object obj7 = highlight;
		object obj9;
		object obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v572 @ X8_v13+E4]");
		bool flag4 = (nint)0 == 0;
		UnityEngine.Object obj10 = highlight;
		if (!flag4)
		{
			goto IL_040d;
		}
		goto IL_0821;
		IL_00fa:
		AvatarData avatarData = _player;
		avatar.Initialize(avatarData);
		goto IL_0144;
		IL_0821:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag5 = obj10;
		bool flag6 = !flag5;
		object obj11 = !flag6;
		if (obj11 == null)
		{
			return;
		}
		goto IL_0434;
		IL_0646:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object obj12;
		bool flag7 = obj12;
		bool flag8 = !flag7;
		object obj14;
		object obj13 = obj14;
		bool flag9 = false;
		if (flag8)
		{
			goto IL_0349;
		}
		goto IL_068c;
		IL_02c6:
		object obj15 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X0_v34+E4]");
		bool flag10 = (nint)0 == 0;
		UnityEngine.Object obj16 = pointsText;
		obj14 = obj13;
		obj12 = pointsText;
		if (!flag10)
		{
			goto IL_030f;
		}
		goto IL_0646;
		IL_0434:
		UpdateHighlight();
		return;
		IL_0144:
		TextMeshProUGUI textMeshProUGUI = placeText;
		int num = _player + 20;
		string text2;
		if (((int*)num)->m_value != 0)
		{
			string text = ((int*)num)->ToString();
			bool flag11 = (object)textMeshProUGUI == null;
			object obj17 = !flag11;
			text2 = text;
			if (obj17 == null)
			{
				goto IL_0863;
			}
		}
		else
		{
			object obj18 = (nint)0 + (nint)3488;
			text2 = (string)obj18;
		}
		nint num2 = (nint)textMeshProUGUI;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X8_v10 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
		obj13 = 0;
		textMeshProUGUI.text = text2;
		AssignPoints();
		LeaderBoardPlayer player2 = _player;
		obj9 = typeof(MemberAchievementClanFeedData) + 2976;
		UnityEngine.Object obj19;
		UnityEngine.Object obj21;
		if (player2.SecondLastRank != 0)
		{
			obj19 = diffIcon;
			object obj20 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X8_v36+E4]");
			bool flag12 = (nint)0 == 0;
			obj21 = diffIcon;
			if (!flag12)
			{
				goto IL_028c;
			}
		}
		else
		{
			player2.SecondLastRank = 2147483647;
			obj19 = diffIcon;
			object obj20 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X8_v36+E4]");
			bool flag13 = (nint)0 == 0;
			object obj22 = !flag13;
			obj21 = diffIcon;
			if (obj22 != null)
			{
				goto IL_028c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag14 = obj21;
		bool flag15 = !flag14;
		bool flag16 = false;
		if (flag15)
		{
			goto IL_02c6;
		}
		goto IL_04d3;
		IL_0349:
		UnityEngine.Object obj23 = userRank;
		object obj24 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X8_v17+E4]");
		bool flag17 = (nint)0 == 0;
		object obj25 = obj13;
		UnityEngine.Object obj26 = userRank;
		if (!flag17)
		{
			goto IL_0392;
		}
		goto IL_0756;
		IL_068c:
		Transform transform = pointsText.transform;
		Transform parent = transform.parent;
		GameObject gameObject = parent.gameObject;
		object obj27 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v19+1C]");
		bool flag18 = (nint)0 == 0;
		gameObject.SetActive(flag18);
		obj23 = userRank;
		obj24 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X8_v17+E4]");
		bool flag19 = (nint)0 == 0;
		object obj28 = !flag19;
		obj13 = 0;
		obj25 = 0;
		flag9 = flag18;
		obj26 = userRank;
		if (obj28 != null)
		{
			goto IL_0392;
		}
		goto IL_0756;
		IL_030f:
		bool flag20 = obj16;
		bool flag21 = !flag20;
		object obj29 = !flag21;
		flag9 = false;
		if (obj29 == null)
		{
			goto IL_0349;
		}
		goto IL_068c;
		IL_079c:
		LeaderBoardPlayer player3 = _player;
		bool isOverall = player3.IsOverall;
		userRank.SetActive(player3.IsOverall);
		obj7 = highlight;
		obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v572 @ X8_v13+E4]");
		bool flag22 = (nint)0 == 0;
		object obj30 = !flag22;
		obj13 = 0;
		obj10 = highlight;
		if (obj30 != null)
		{
			goto IL_040d;
		}
		goto IL_0821;
		IL_0392:
		bool flag23 = obj23;
		bool flag24 = !flag23;
		object obj31 = !flag24;
		isOverall = false;
		if (obj31 == null)
		{
			goto IL_03cc;
		}
		goto IL_079c;
		IL_0756:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag25 = obj26;
		bool flag26 = !flag25;
		obj13 = obj25;
		isOverall = false;
		if (flag26)
		{
			goto IL_03cc;
		}
		goto IL_079c;
		IL_028c:
		bool flag27 = obj19;
		bool flag28 = !flag27;
		object obj32 = !flag28;
		flag16 = false;
		if (obj32 == null)
		{
			goto IL_02c6;
		}
		goto IL_04d3;
		IL_04d3:
		LeaderBoardPlayer player4 = _player;
		object obj33 = player4.LastRank - player4.SecondLastRank;
		bool flag29 = (nint)obj33 < 0;
		int num3 = player4.LastRank ^ player4.SecondLastRank;
		int num4 = player4.LastRank ^ obj33;
		int num5 = num3 & num4;
		bool flag30 = num5 < 0;
		if (player4.LastRank == player4.SecondLastRank)
		{
			object obj34 = 200;
		}
		else
		{
			object obj34 = 208;
		}
		bool flag31 = flag29 == flag30;
		object obj35 = !flag31;
		object obj36 = ~obj35;
		if (obj36 == null)
		{
			object obj34 = 192;
		}
		Image image = diffIcon;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (NormalPlaceItem)+v186 @ X8_v28]");
		image.sprite = (Sprite)0;
		GameObject gameObject2 = diffIcon.gameObject;
		object obj37 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v29+1C]");
		bool flag32 = (nint)0 == 0;
		gameObject2.SetActive(flag32);
		obj16 = pointsText;
		obj15 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X0_v34+E4]");
		bool flag33 = (nint)0 == 0;
		object obj38 = !flag33;
		obj13 = 0;
		obj14 = 0;
		flag16 = flag32;
		obj12 = pointsText;
		if (obj38 != null)
		{
			goto IL_030f;
		}
		goto IL_0646;
		IL_040d:
		if ((bool)obj7)
		{
			goto IL_0434;
		}
	}

	private void ShowBlockedView()
	{
		//IL_0074: Expected O, but got I
		//IL_0046: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (NormalPlaceItem)+50]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (NormalPlaceItem)+50]");
		int points;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+38]");
			points = 0;
		}
		else
		{
			bool flag = (object)avatar == null;
			object obj2 = !flag;
			points = 0;
			if (obj2 == null)
			{
				throw new NullReferenceException();
			}
		}
		avatar.InitializeBlockedUser(points);
	}

	private void UpdateHighlight()
	{
		//IL_006c: Expected O, but got I4
		//IL_00f0: Expected O, but got I
		//IL_0100: Expected O, but got I
		//IL_0110: Expected O, but got I
		//IL_0120: Expected O, but got I
		//IL_0128: Expected I, but got O
		//IL_0138: Expected O, but got I
		//IL_0148: Expected O, but got I
		GameObject gameObject = highlight.gameObject;
		LeaderBoardPlayer player = _player;
		bool flag = player.RankTier == 0;
		bool active = !flag;
		gameObject.SetActive(active);
		LeaderBoardPlayer player2 = _player;
		object obj = player2.RankTier - 1;
		if (player2.RankTier >= 1)
		{
			Color[] array = highlightColors;
			if (player2.RankTier <= array.Length)
			{
				Graphic graphic = highlight;
				object obj2 = (object)array + obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v6+28]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v6+2C]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v6+20]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v6+24]");
				object obj6 = 0;
				nint num = (nint)graphic;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v7 (Il2CppClass<UnityEngine.UI.Graphic>)+2A8]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v7 (Il2CppClass<UnityEngine.UI.Graphic>)+2B0]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v123 @ X2_v3 (should have been resolved before IL gen)");
				/*Error: End of method reached without returning.*/;
			}
		}
	}

	private void AssignPoints()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_014e: Expected O, but got I4
		//IL_01a2: Expected O, but got I4
		//IL_00f4: Expected I, but got O
		//IL_0104: Expected O, but got I
		//IL_0114: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6233]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 == null)
		{
			goto IL_011e;
		}
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		UnityEngine.Object obj5 = pointsText;
		UnityEngine.Object obj6 = pointsText;
		if (!flag)
		{
			goto IL_0091;
		}
		goto IL_0170;
		IL_0170:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = obj6;
		bool flag3 = !flag2;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			return;
		}
		goto IL_00b7;
		IL_0091:
		if ((bool)obj5)
		{
			goto IL_00b7;
		}
		return;
		IL_00b7:
		LeaderBoardPlayer player = _player;
		NumberFormatter numberFormatter = this.numberFormatter;
		TextMeshProUGUI textMeshProUGUI = pointsText;
		int lastPoints = player.LastPoints;
		nint num = (nint)numberFormatter;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v8 (Il2CppClass<NumberFormatter>)+178]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v8 (Il2CppClass<NumberFormatter>)+180]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v98 @ X4_v1 (should have been resolved before IL gen)");
		goto IL_011e;
		IL_011e:
		_ = 1;
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag4 = (nint)0 == 0;
		object obj10 = !flag4;
		obj5 = pointsText;
		obj6 = pointsText;
		if (obj10 != null)
		{
			goto IL_0091;
		}
		goto IL_0170;
	}

	public unsafe void ShowPlayerProfile()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected I4, but got Unknown
		object obj = typeof(MemberAchievementClanFeedData) + 840;
		int num = _player + 44;
		string dbId = ((int*)num)->ToString();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v4+E4]");
		if ((nint)0 != 0)
		{
			MiniProfilePopup.Show(dbId, TrackingPlacement.Leaderboard);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		MiniProfilePopup.Show(dbId, TrackingPlacement.Leaderboard);
	}
}
