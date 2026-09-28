using System;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using Features.GameReplay;
using Kammelna.Server.Models.Clans;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class GameScoreGameEndWidget : GameEndWidget
{
	private sealed class <>c__DisplayClass6_0
	{
		public AbstractEndGameScore score;

		public int team1;

		public int team2;

		public CardGameEndScores gameEnd;

		internal void <Populate>b__0()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_006e: Expected O, but got I4
			//IL_0041: Expected O, but got I4
			//IL_00be: Expected O, but got I4
			//IL_00b0: Expected O, but got I4
			//IL_00cb: Expected I, but got O
			object obj = typeof(TypeConverter<ushort, char>) + 3048;
			AbstractEndGameScore abstractEndGameScore = score;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			CardGameEndScores cardGameEndScores = gameEnd;
			if (team1 == 1)
			{
				if (gameEnd == null)
				{
					goto IL_00d5;
				}
				object obj2 = 20;
			}
			else
			{
				if (gameEnd == null)
				{
					goto IL_00d5;
				}
				object obj2 = 24;
			}
			object obj3 = default(object);
			if (obj3 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v3 (CardGameEndScores)+v87 @ X9_v2]");
				_ = 0;
				if (team2 == 1)
				{
					object obj4 = 20;
				}
				else
				{
					object obj4 = 24;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v3 (CardGameEndScores)+v88 @ X9_v6]");
				_ = 0;
				if ((object)score != null)
				{
					nint num = (nint)abstractEndGameScore;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v149 @ X8_v5 (Il2CppClass<AbstractEndGameScore>)+188] (should have been resolved before IL gen)");
				}
			}
			goto IL_00d5;
			IL_00d5:
			NullReferenceException ex = new NullReferenceException();
			throw new IndexOutOfRangeException();
		}

		internal int <Populate>g__GetTeamScore|1(int team)
		{
			//IL_00a2: Expected I4, but got O
			//IL_0087: Expected O, but got I4
			//IL_0052: Expected O, but got I4
			CardGameEndScores cardGameEndScores = gameEnd;
			if (team == 1)
			{
				if (gameEnd != null)
				{
					object obj = 20;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6 @ X8_v1 (CardGameEndScores)+v21 @ X9_v2]");
					return 0;
				}
			}
			else if (gameEnd != null)
			{
				object obj2 = 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6 @ X8_v1 (CardGameEndScores)+v41 @ X9_v1]");
				return 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	private sealed class <>c__DisplayClass7_0
	{
		public GameScoreGameEndWidget <>4__this;

		public CardGameEndScores rankReport;

		internal void <AnimatedPopulate>g__pop|0()
		{
			//IL_0021: Expected I, but got O
			//IL_0031: Expected O, but got I
			//IL_0041: Expected O, but got I
			GameScoreGameEndWidget gameScoreGameEndWidget = <>4__this;
			CardGameEndScores cardGameEndScores = rankReport;
			nint num = (nint)gameScoreGameEndWidget;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ X8_v2 (Il2CppClass<GameScoreGameEndWidget>)+188]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ X8_v2 (Il2CppClass<GameScoreGameEndWidget>)+190]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v6 @ X3_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	private LayoutElement _layoutElement;

	private float widgetHeight;

	private float animateDelay = 1f;

	private AbstractEndGameScore WonScore;

	private AbstractEndGameScore LostScore;

	public override void PrepareAnimation(CardGameEndScores gameEnd)
	{
		GameObject gameObject = WonScore.gameObject;
		gameObject.SetActive(value: false);
		GameObject gameObject2 = LostScore.gameObject;
		gameObject2.SetActive(value: false);
		GameObject gameObject3 = base.gameObject;
		gameObject3.SetActive(value: true);
	}

	public override void Populate(CardGameEndScores gameEnd)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0545: Unknown result type (might be due to invalid IL or missing references)
		//IL_054a: Expected O, but got Unknown
		//IL_056c: Expected O, but got I4
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_0089: Expected O, but got I4
		//IL_05c9: Expected O, but got I4
		//IL_0110: Expected O, but got I4
		//IL_00b2: Expected O, but got I
		//IL_01c9: Expected O, but got I4
		//IL_0583: Unknown result type (might be due to invalid IL or missing references)
		//IL_0588: Expected O, but got Unknown
		//IL_0598: Expected O, but got I
		//IL_01f7: Expected O, but got I4
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_0158: Expected O, but got I4
		//IL_01e9: Expected O, but got I4
		//IL_0181: Expected O, but got I
		//IL_05f9: Expected O, but got I4
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Expected O, but got Unknown
		//IL_025f: Expected O, but got I4
		//IL_0629: Expected O, but got I4
		//IL_02eb: Expected O, but got I
		//IL_030d: Expected O, but got I4
		//IL_0288: Expected O, but got I
		//IL_0409: Unknown result type (might be due to invalid IL or missing references)
		//IL_040e: Expected O, but got Unknown
		//IL_041d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0422: Expected O, but got Unknown
		//IL_042e: Expected O, but got I
		//IL_046a: Expected O, but got I4
		//IL_04f0: Expected O, but got I
		//IL_0512: Expected O, but got I4
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Expected O, but got Unknown
		//IL_0363: Expected O, but got I4
		//IL_03f5: Expected O, but got I
		//IL_038c: Expected O, but got I
		//IL_04c3: Expected I, but got O
		object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 104;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 32;
		obj3 = gameEnd;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj3;
		object obj5 = this + 32;
		CardGame cardGame = (CardGame)obj5;
		bool flag = obj5 == null;
		object obj6 = !flag;
		if (obj6 == null)
		{
			object obj7 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X0_v86+E4]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj10 = (nint)0 + (nint)24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
			obj5 = cardGame;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		int myTeamIndex = cardGame.MyTeamIndex;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v4+34]");
		if ((nint)0 == myTeamIndex)
		{
			object obj11 = 56;
		}
		else
		{
			KGame kGame = (KGame)obj5;
			bool flag3 = obj5 == null;
			object obj12 = !flag3;
			if (obj12 == null)
			{
				object obj13 = typeof(MemberAchievementClanFeedData) + 2976;
				object obj14 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X0_v72+E4]");
				bool flag4 = (nint)0 == 0;
				object obj15 = !flag4;
				if (obj15 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj16 = (nint)0 + (nint)24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
				obj5 = kGame;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
			bool isSpectator = kGame.IsSpectator;
			bool flag5 = !isSpectator;
			object obj17 = !flag5;
			object obj18 = ~obj17;
			if (obj18 == null)
			{
				object obj11 = 56;
			}
			else
			{
				object obj11 = 64;
			}
		}
		object obj19 = obj2 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (GameScoreGameEndWidget)+v165 @ X8_v8]");
		obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		GameObject gameObject = ((Component)obj19).gameObject;
		gameObject.SetActive(value: true);
		KGame kGame2 = (KGame)obj5;
		bool flag6 = obj5 == null;
		object obj20 = !flag6;
		if (obj20 == null)
		{
			object obj21 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj22 = obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X0_v54+E4]");
			bool flag7 = (nint)0 == 0;
			object obj23 = !flag7;
			if (obj23 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj24 = (nint)0 + (nint)24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
			obj5 = kGame2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		object obj25;
		if (kGame2.IsSpectator)
		{
			_ = 1;
			_ = 2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3 (System.Object)+10]");
			obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3 (System.Object)+10]");
			bool flag8 = (nint)0 == 0;
			object obj26 = !flag8;
			if (obj26 == null)
			{
				goto IL_0520;
			}
		}
		else
		{
			CardGame cardGame2 = (CardGame)obj5;
			bool flag9 = obj5 == null;
			object obj27 = !flag9;
			if (obj27 == null)
			{
				object obj28 = typeof(MemberAchievementClanFeedData) + 2976;
				object obj29 = obj28;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X0_v39+E4]");
				bool flag10 = (nint)0 == 0;
				object obj30 = !flag10;
				if (obj30 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj31 = (nint)0 + (nint)24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
				obj5 = cardGame2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
			int myTeamIndex2 = cardGame2.MyTeamIndex;
			if (myTeamIndex2 == 1)
			{
				_ = 2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3 (System.Object)+10]");
				obj25 = 0;
			}
			else
			{
				_ = 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3 (System.Object)+10]");
				obj25 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3 (System.Object)+10]");
				bool flag11 = (nint)0 == 0;
				object obj32 = !flag11;
				if (obj32 == null)
				{
					goto IL_0520;
				}
			}
		}
		object obj33 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj34 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		object obj35 = (nint)0 + (nint)1896;
		object obj36 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v369 @ X8_v12+178] (should have been resolved before IL gen)");
		object obj37 = obj33;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X0_v23+E4]");
		bool flag12 = (nint)0 == 0;
		object obj38 = !flag12;
		if (obj38 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Sequence s = DOTween.Sequence();
		Sequence sequence = TweenSettingsExtensions.AppendInterval(s, animateDelay);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(obj2, (IntPtr)obj35);
		Sequence sequence2 = TweenSettingsExtensions.AppendCallback(s, tweenCallback);
		return;
		IL_0520:
		throw new NullReferenceException();
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
		object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 112;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
			object obj4 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
			object obj5 = (nint)0 + (nint)1904;
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
