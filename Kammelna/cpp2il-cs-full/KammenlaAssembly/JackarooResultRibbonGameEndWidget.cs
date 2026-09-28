using System;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;

public class JackarooResultRibbonGameEndWidget : GameEndWidget
{
	private sealed class <>c__DisplayClass4_0
	{
		public JackarooResultRibbonGameEndWidget <>4__this;

		public CardGameEndScores rankReport;

		internal void <AnimatedPopulate>b__0()
		{
			//IL_0021: Expected I, but got O
			//IL_0031: Expected O, but got I
			//IL_0041: Expected O, but got I
			JackarooResultRibbonGameEndWidget jackarooResultRibbonGameEndWidget = <>4__this;
			CardGameEndScores cardGameEndScores = rankReport;
			nint num = (nint)jackarooResultRibbonGameEndWidget;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ X8_v2 (Il2CppClass<JackarooResultRibbonGameEndWidget>)+188]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ X8_v2 (Il2CppClass<JackarooResultRibbonGameEndWidget>)+190]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v6 @ X3_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	private GameObject _wonScore;

	private GameObject _lostScore;

	public override void PrepareAnimation(CardGameEndScores rankReport)
	{
		GameObject gameObject = _wonScore.gameObject;
		gameObject.SetActive(value: false);
		GameObject gameObject2 = _lostScore.gameObject;
		gameObject2.SetActive(value: false);
		GameObject gameObject3 = base.gameObject;
		gameObject3.SetActive(value: true);
	}

	public override void Populate(CardGameEndScores gameEnd)
	{
		//IL_007b: Expected O, but got I4
		//IL_008b: Expected O, but got I
		//IL_00a8: Expected O, but got I4
		//IL_00b8: Expected O, but got I
		//IL_00da: Expected O, but got I4
		CardGame cardGame = base.game;
		int myTeamIndex = cardGame.MyTeamIndex;
		GameObject gameObject;
		if (gameEnd.<WinnerTeamIndex>k__BackingField != myTeamIndex)
		{
			CardGame cardGame2 = base.game;
			if (!cardGame2.IsSpectator)
			{
				object obj = 48;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (JackarooResultRibbonGameEndWidget)+v18 @ X8_v4]");
				gameObject = (GameObject)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (JackarooResultRibbonGameEndWidget)+v18 @ X8_v4]");
				bool flag = (nint)0 == 0;
				object obj2 = !flag;
				if (obj2 == null)
				{
					throw new NullReferenceException();
				}
				goto IL_0090;
			}
		}
		object obj3 = 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (JackarooResultRibbonGameEndWidget)+v20 @ X8_v3]");
		gameObject = (GameObject)0;
		goto IL_0090;
		IL_0090:
		gameObject.SetActive(value: true);
	}

	public override Sequence AnimatedPopulate(CardGameEndScores rankReport)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004d: Expected O, but got I
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_00b9: Expected O, but got I4
		//IL_00ff: Expected I, but got O
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 864;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
			object obj4 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
			object obj5 = (nint)0 + (nint)2360;
			object obj6 = obj2 + 16;
			obj6 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj7 = obj2 + 24;
			obj7 = rankReport;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj8 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			object obj9 = !flag;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Sequence sequence = DOTween.Sequence();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			TweenCallback tweenCallback = default(TweenCallback);
			tweenCallback..ctor(obj2, (IntPtr)obj5);
			Sequence sequence2 = TweenSettingsExtensions.AppendCallback(sequence, tweenCallback);
			Sequence sequence3 = TweenSettingsExtensions.AppendInterval(sequence, 1.2f);
			return sequence;
		}
		return (Sequence)(object)new NullReferenceException();
	}

	public override bool ShouldShow(CardGameEndScores rankReport)
	{
		return true;
	}
}
