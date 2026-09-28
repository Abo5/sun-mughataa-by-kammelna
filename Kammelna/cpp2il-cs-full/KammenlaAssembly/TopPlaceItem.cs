using System;
using System.ComponentModel;
using Cpp2ILInjected;
using DataTracking;
using Kammelna.Server.Models.Clans;
using TMPro;
using UnityEngine;

public class TopPlaceItem : MonoBehaviour
{
	private AvatarInitializer avatar;

	private TextMeshProUGUI pointsText;

	private LeaderBoardPlayer _player;

	public unsafe void Populate(LeaderBoardPlayer player)
	{
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0043: Expected O, but got I4
		//IL_006e: Expected I8, but got I4
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected O, but got Unknown
		//IL_0151: Expected O, but got I4
		//IL_0172: Expected O, but got I4
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected O, but got Unknown
		//IL_01ec: Expected O, but got I4
		//IL_01f4: Expected O, but got I4
		//IL_00dd: Expected O, but got I4
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Expected I4, but got Unknown
		//IL_0296: Expected O, but got I4
		object obj = this + 48;
		obj = player;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = FriendsManager.IsBlocked(player.Id);
		LeaderBoardPlayer player2 = _player;
		UnityEngine.Object obj8;
		UnityEngine.Object obj10;
		if (flag2)
		{
			int num;
			if (_player != null)
			{
				num = player2.Points;
				bool flag3 = (object)avatar == null;
				object obj5 = !flag3;
				if (obj5 == null)
				{
					throw new NullReferenceException();
				}
			}
			else
			{
				num = 0;
			}
			avatar.InitializeBlockedUser(num);
			object obj6 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v13+E4]");
			bool flag4 = (nint)0 == 0;
			obj8 = pointsText;
			object obj9 = 0;
			AvatarData avatarData = (AvatarData)num;
			obj10 = pointsText;
			if (!flag4)
			{
				goto IL_020c;
			}
		}
		else
		{
			AvatarData avatarData2 = _player;
			avatar.Initialize(avatarData2);
			object obj11 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj7 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v13+E4]");
			bool flag5 = (nint)0 == 0;
			object obj12 = !flag5;
			obj8 = pointsText;
			if (obj12 != null)
			{
				goto IL_020c;
			}
			object obj9 = 0;
			AvatarData avatarData = avatarData2;
			obj10 = pointsText;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag6 = obj10;
		bool flag7 = !flag6;
		object obj13 = !flag7;
		if (obj13 == null)
		{
			return;
		}
		goto IL_0232;
		IL_0232:
		int num2 = _player + 16;
		string text = ((int*)num2)->ToString();
		pointsText.SetText(text);
		return;
		IL_020c:
		if ((bool)obj8)
		{
			goto IL_0232;
		}
	}

	private void ShowBlockedView()
	{
		//IL_0067: Expected O, but got I4
		LeaderBoardPlayer player = _player;
		int points;
		if (_player != null)
		{
			points = player.Points;
		}
		else
		{
			bool flag = (object)avatar == null;
			object obj = !flag;
			points = 0;
			if (obj == null)
			{
				throw new NullReferenceException();
			}
		}
		avatar.InitializeBlockedUser(points);
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
			MiniProfilePopup.Show(dbId, TrackingPlacement.LeaderboardTop3);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		MiniProfilePopup.Show(dbId, TrackingPlacement.LeaderboardTop3);
	}
}
