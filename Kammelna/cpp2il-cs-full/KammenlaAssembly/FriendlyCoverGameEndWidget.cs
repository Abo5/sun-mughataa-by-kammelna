using System;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.UI;

public class FriendlyCoverGameEndWidget : GameEndWidget
{
	private LayoutElement _layoutElement;

	public override void PrepareAnimation(CardGameEndScores rankReport)
	{
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: true);
	}

	public override void Populate(CardGameEndScores rankReport)
	{
	}

	public override Sequence AnimatedPopulate(CardGameEndScores rankReport)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00b2: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6764]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v1+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		return DOTween.Sequence();
		IL_0074:
		return DOTween.Sequence();
	}

	public override bool ShouldShow(CardGameEndScores rankReport)
	{
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Expected O, but got Unknown
		//IL_01f4: Expected O, but got I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0043: Expected O, but got I4
		//IL_006c: Expected O, but got I
		//IL_0229: Expected O, but got I4
		//IL_01c7: Expected I4, but got O
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0132: Expected O, but got I4
		//IL_015b: Expected O, but got I
		object obj = this + 32;
		KGame kGame = (KGame)obj;
		bool flag = obj == null;
		object obj2 = !flag;
		if (obj2 == null)
		{
			object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v29+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj6 = (nint)0 + (nint)24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
			obj = kGame;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			if ((object)kGame == null)
			{
				goto IL_01b9;
			}
		}
		Room room = kGame.Room;
		GameType gameType = SFSKammelnaRoomExtensions.GetGameType(room);
		bool flag3 = GameTypeExtensions.IsFriendly(gameType);
		if (flag3)
		{
			KGame kGame2 = (KGame)obj;
			bool flag4 = obj == null;
			object obj7 = !flag4;
			if (obj7 == null)
			{
				object obj8 = typeof(MemberAchievementClanFeedData) + 2976;
				object obj9 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v15+E4]");
				bool flag5 = (nint)0 == 0;
				object obj10 = !flag5;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj11 = (nint)0 + (nint)24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
				obj = kGame2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				if ((object)kGame2 == null)
				{
					goto IL_01b9;
				}
			}
			bool isSpectator = kGame2.IsSpectator;
			flag3 = (byte)((isSpectator ? 1u : 0u) ^ 1u) != 0;
		}
		return flag3;
		IL_01b9:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}
}
