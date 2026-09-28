using System;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using UnityEngine;

public class WatcherGameEndWidget : GameEndWidget
{
	private AvatarInitializer winner1;

	private AvatarInitializer winner2;

	private AvatarInitializer loser1;

	private AvatarInitializer loser2;

	public override void PrepareAnimation(CardGameEndScores rankReport)
	{
		int num = ((rankReport.<WinnerTeamIndex>k__BackingField != 1) ? 1 : (1 + 1));
		CardGame cardGame = base.game;
		KPlayer playerByIndex = cardGame.GetPlayerByIndex(rankReport.<WinnerTeamIndex>k__BackingField);
		winner1.Initialize(playerByIndex);
		CardGame cardGame2 = base.game;
		int index = rankReport.<WinnerTeamIndex>k__BackingField + 2;
		KPlayer playerByIndex2 = cardGame2.GetPlayerByIndex(index);
		winner2.Initialize(playerByIndex2);
		CardGame cardGame3 = base.game;
		KPlayer playerByIndex3 = cardGame3.GetPlayerByIndex(num);
		loser1.Initialize(playerByIndex3);
		CardGame cardGame4 = base.game;
		int index2 = num + 2;
		KPlayer playerByIndex4 = cardGame4.GetPlayerByIndex(index2);
		loser2.Initialize(playerByIndex4);
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E67C9]");
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
		//IL_0047: Expected I4, but got O
		CardGame cardGame = base.game;
		if ((object)cardGame != null)
		{
			return cardGame.IsSpectator;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}
}
