using System;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using UnityEngine;

public class TeamInvitesPanel : MonoBehaviour
{
	private TeamInviteUi invitationTemplate;

	private TeamInviteUi notificationTemplate;

	private RectTransform layout;

	private void Start()
	{
		Transform transform = base.transform;
		UIExtensions.AttachToCanvas(transform, CanvasLayer.SecondaryCanvas);
	}

	public void ShowInvite(QueuePlayer invitePlayer)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0064: Expected O, but got I
		//IL_008e: Expected O, but got I4
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)752;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
		object message = "startPosition" + 3992;
		TeamInviteUi teamInviteUi = default(TeamInviteUi);
		teamInviteUi.Populate(invitePlayer, (string)message);
	}

	public void ShowCancelled(QueuePlayer queuePlayer)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object message = "startPosition" + 3968;
		QueuePlayer player = default(QueuePlayer);
		ShowNotification(player, (string)message, overrideExisting: true);
	}

	public void ShowAccepted(QueuePlayer queuePlayer)
	{
		//IL_0009: Expected O, but got I4
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_002e: Expected O, but got I
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected O, but got Unknown
		//IL_0174: Expected O, but got I
		//IL_018e: Expected O, but got I4
		//IL_00b6: Expected O, but got I
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_007d: Expected O, but got I
		//IL_01be: Expected O, but got I
		//IL_01fc: Expected O, but got I4
		//IL_0261: Expected O, but got I4
		object obj = 152985600;
		object obj2 = "startPosition" + 3960;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6DF0]");
		object obj3 = (nint)0 & (nint)1;
		string text;
		object obj4;
		object obj6;
		string text2;
		if (obj3 != null)
		{
			text = (string)obj2;
			obj4 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6DF4]");
			object obj5 = (nint)0 & (nint)1;
			bool flag = obj5 == null;
			obj6 = obj4;
			text2 = (string)obj2;
			if (!flag)
			{
				goto IL_00aa;
			}
		}
		else
		{
			_ = 1;
			text = (string)obj2;
			obj4 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6DF4]");
			object obj7 = (nint)0 & (nint)1;
			bool flag2 = obj7 == null;
			object obj8 = !flag2;
			obj6 = obj4;
			text2 = (string)obj2;
			if (obj8 != null)
			{
				goto IL_00aa;
			}
		}
		_ = 1;
		object obj9 = (nint)0 + (nint)752;
		TeamInviteUi teamInviteUi = notificationTemplate;
		RectTransform rectTransform = layout;
		object obj10 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v3+E4]");
		bool flag3 = (nint)0 == 0;
		object obj11 = !flag3;
		text = text2;
		object obj12 = obj9;
		TeamInviteUi teamInviteUi2 = notificationTemplate;
		RectTransform rectTransform2 = layout;
		if (obj11 != null)
		{
			goto IL_011b;
		}
		goto IL_022e;
		IL_011b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
		goto IL_012a;
		IL_012a:
		TeamInviteUi teamInviteUi3 = default(TeamInviteUi);
		teamInviteUi3.Populate(queuePlayer, text);
		return;
		IL_022e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
		bool flag4 = (object)teamInviteUi3 == null;
		object obj13 = !flag4;
		text = text2;
		if (obj13 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_012a;
		IL_00aa:
		obj9 = (nint)0 + (nint)752;
		teamInviteUi = notificationTemplate;
		rectTransform = layout;
		obj10 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v3+E4]");
		bool flag5 = (nint)0 == 0;
		obj12 = obj9;
		teamInviteUi2 = notificationTemplate;
		text2 = text;
		rectTransform2 = layout;
		if (!flag5)
		{
			goto IL_011b;
		}
		goto IL_022e;
	}

	public void ShowRejected(QueuePlayer queuePlayer)
	{
		//IL_0009: Expected O, but got I4
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_002e: Expected O, but got I
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected O, but got Unknown
		//IL_0174: Expected O, but got I
		//IL_018e: Expected O, but got I4
		//IL_00b6: Expected O, but got I
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_007d: Expected O, but got I
		//IL_01be: Expected O, but got I
		//IL_01fc: Expected O, but got I4
		//IL_0261: Expected O, but got I4
		object obj = 152985600;
		object obj2 = "startPosition" + 4032;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6DF1]");
		object obj3 = (nint)0 & (nint)1;
		string text;
		object obj4;
		object obj6;
		string text2;
		if (obj3 != null)
		{
			text = (string)obj2;
			obj4 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6DF4]");
			object obj5 = (nint)0 & (nint)1;
			bool flag = obj5 == null;
			obj6 = obj4;
			text2 = (string)obj2;
			if (!flag)
			{
				goto IL_00aa;
			}
		}
		else
		{
			_ = 1;
			text = (string)obj2;
			obj4 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6DF4]");
			object obj7 = (nint)0 & (nint)1;
			bool flag2 = obj7 == null;
			object obj8 = !flag2;
			obj6 = obj4;
			text2 = (string)obj2;
			if (obj8 != null)
			{
				goto IL_00aa;
			}
		}
		_ = 1;
		object obj9 = (nint)0 + (nint)752;
		TeamInviteUi teamInviteUi = notificationTemplate;
		RectTransform rectTransform = layout;
		object obj10 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v3+E4]");
		bool flag3 = (nint)0 == 0;
		object obj11 = !flag3;
		text = text2;
		object obj12 = obj9;
		TeamInviteUi teamInviteUi2 = notificationTemplate;
		RectTransform rectTransform2 = layout;
		if (obj11 != null)
		{
			goto IL_011b;
		}
		goto IL_022e;
		IL_011b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
		goto IL_012a;
		IL_012a:
		TeamInviteUi teamInviteUi3 = default(TeamInviteUi);
		teamInviteUi3.Populate(queuePlayer, text);
		return;
		IL_022e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
		bool flag4 = (object)teamInviteUi3 == null;
		object obj13 = !flag4;
		text = text2;
		if (obj13 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_012a;
		IL_00aa:
		obj9 = (nint)0 + (nint)752;
		teamInviteUi = notificationTemplate;
		rectTransform = layout;
		obj10 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v3+E4]");
		bool flag5 = (nint)0 == 0;
		obj12 = obj9;
		teamInviteUi2 = notificationTemplate;
		text2 = text;
		rectTransform2 = layout;
		if (!flag5)
		{
			goto IL_011b;
		}
		goto IL_022e;
	}

	public void ShowAlreadySeated(QueuePlayer queuePlayer)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object message = "startPosition" + 4016;
		QueuePlayer player = default(QueuePlayer);
		ShowNotification(player, (string)message, overrideExisting: true);
	}

	public void ShowUnavailable(QueuePlayer queuePlayer)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object message = "startPosition" + 4024;
		QueuePlayer player = default(QueuePlayer);
		ShowNotification(player, (string)message, overrideExisting: true);
	}

	private void ShowNotification(QueuePlayer player, string message, bool overrideExisting = false)
	{
		//IL_00d3: Expected I4, but got O
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_0058: Expected O, but got I
		//IL_0082: Expected O, but got I4
		bool flag = !overrideExisting;
		int num = (int)player;
		if (!flag)
		{
			PlayerInfo <info>k__BackingField = player.<info>k__BackingField;
			num = <info>k__BackingField.<DBID>k__BackingField;
			RemoveExisting(<info>k__BackingField.<DBID>k__BackingField);
		}
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)752;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v5+E4]");
		bool flag2 = (nint)0 == 0;
		object obj4 = !flag2;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
		TeamInviteUi teamInviteUi = default(TeamInviteUi);
		teamInviteUi.Populate(player, message);
	}

	private void RemoveExisting(int playerId)
	{
		//IL_0011: Expected O, but got I
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_005b: Expected O, but got I4
		//IL_00b0: Expected O, but got I
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_0124: Expected O, but got I4
		//IL_0151: Expected O, but got I4
		object obj = (nint)0 + (nint)752;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D31C20");
		TeamInviteUi teamInviteUi = default(TeamInviteUi);
		if ((nint)((MonoBehaviour)teamInviteUi).m_CancellationTokenSource < 1)
		{
			return;
		}
		object obj2 = teamInviteUi + 32;
		object obj3 = 0;
		object obj8 = default(object);
		do
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X26_v4+v85 @ X25_v5*8]");
			TeamInviteUi teamInviteUi2 = (TeamInviteUi)0;
			QueuePlayer player = teamInviteUi2._player;
			if (teamInviteUi2._player != null)
			{
				PlayerInfo <info>k__BackingField = player.<info>k__BackingField;
				if (player.<info>k__BackingField != null)
				{
					int? num = <info>k__BackingField.<DBID>k__BackingField;
					object obj4 = (??)num & 1;
					bool flag = obj4 == null;
					object obj5 = !flag;
					object obj6 = ~obj5;
					object obj7 = ((obj6 != null) ? ((object)(-1)) : obj8);
					if ((nint)obj7 == playerId)
					{
						goto IL_0060;
					}
					goto IL_006e;
				}
			}
			if (4294967295L == playerId)
			{
				goto IL_0060;
			}
			goto IL_006e;
			IL_006e:
			obj3++;
			continue;
			IL_0060:
			teamInviteUi2.Close();
			goto IL_006e;
		}
		while (obj3 < ((MonoBehaviour)teamInviteUi).m_CancellationTokenSource);
	}
}
