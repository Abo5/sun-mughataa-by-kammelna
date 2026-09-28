using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected;
using DG.Tweening;
using Server.Models;
using Spine;
using Unity.Properties;

public class TournamentGameEndWidgetSwitch : GameEndWidget
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<GameEndWidget> <>9__10_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(SkeletonBinary.SkeletonInput) + 3568;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <Disable>b__10_0(GameEndWidget w)
		{
			//IL_0008: Expected I, but got O
			//IL_0018: Expected O, but got I
			//IL_0028: Expected O, but got I
			nint num = (nint)w;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ X8_v1 (Il2CppClass<GameEndWidget>)+1B8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ X8_v1 (Il2CppClass<GameEndWidget>)+1C0]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v3 @ X2_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	private GameEndWidget scoresWidget;

	private GameEndWidget acesRewardWidget;

	private GameEndWidget tournamentPointsRewardWidget;

	private GameEndWidget massPointsRewardWidget;

	private GameEndWidget monthlyTournamentRewardWidget;

	private GameEndWidget genericTournamentEndWidget;

	private TournamentMatchInfo matchInfo
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00b2: Expected O, but got I
			//IL_00dc: Expected O, but got I4
			//IL_005c: Expected O, but got I
			object obj = 152985600;
			object obj2 = typeof(Queue<string>) + 872;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6843]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = (nint)0 + (nint)2248;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v1+E4]");
				bool flag = (nint)0 == 0;
				object obj6 = obj4;
				if (!flag)
				{
					goto IL_0091;
				}
			}
			else
			{
				_ = 1;
				object obj4 = (nint)0 + (nint)2248;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v1+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				object obj6 = obj4;
				if (obj7 != null)
				{
					goto IL_0091;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			TournamentMatchInfo result = default(TournamentMatchInfo);
			return result;
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			TournamentMatchInfo result2 = default(TournamentMatchInfo);
			return result2;
		}
	}

	private GameEndWidget[] widgets
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0033: Expected O, but got I4
			//IL_0049: Expected I, but got O
			//IL_0059: Expected O, but got I
			//IL_0082: Expected O, but got I
			//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bd: Expected O, but got Unknown
			//IL_015d: Expected O, but got I8
			//IL_0102: Expected I, but got O
			//IL_0112: Expected O, but got I
			//IL_013b: Expected O, but got I
			//IL_0183: Unknown result type (might be due to invalid IL or missing references)
			//IL_0188: Expected O, but got Unknown
			//IL_0230: Expected O, but got I4
			//IL_0240: Expected O, but got I4
			//IL_0260: Unknown result type (might be due to invalid IL or missing references)
			//IL_0265: Expected O, but got Unknown
			//IL_01cd: Expected I, but got O
			//IL_01dd: Expected O, but got I
			//IL_0206: Expected O, but got I
			//IL_027c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0281: Expected O, but got Unknown
			//IL_0321: Expected O, but got I8
			//IL_02c6: Expected I, but got O
			//IL_02d6: Expected O, but got I
			//IL_02ff: Expected O, but got I
			//IL_0347: Unknown result type (might be due to invalid IL or missing references)
			//IL_034c: Expected O, but got Unknown
			//IL_03f4: Expected O, but got I4
			//IL_0404: Expected O, but got I4
			//IL_0424: Unknown result type (might be due to invalid IL or missing references)
			//IL_0429: Expected O, but got Unknown
			//IL_0391: Expected I, but got O
			//IL_03a1: Expected O, but got I
			//IL_03ca: Expected O, but got I
			//IL_0440: Unknown result type (might be due to invalid IL or missing references)
			//IL_0445: Expected O, but got Unknown
			//IL_04ed: Expected O, but got I4
			//IL_04fd: Expected O, but got I4
			//IL_051d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0522: Expected O, but got Unknown
			//IL_048a: Expected I, but got O
			//IL_049a: Expected O, but got I
			//IL_04c3: Expected O, but got I
			//IL_0539: Unknown result type (might be due to invalid IL or missing references)
			//IL_053e: Expected O, but got Unknown
			object obj = typeof(TypeConverter<ushort, char>) + 2560;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			GameEndWidget[] array = default(GameEndWidget[]);
			if (array != null)
			{
				bool flag = (object)scoresWidget == null;
				GameEndWidget gameEndWidget = (GameEndWidget)6;
				IndexOutOfRangeException ex = default(IndexOutOfRangeException);
				GameEndWidget gameEndWidget2;
				if (!flag)
				{
					nint num = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v23 (Il2CppClass<GameEndWidget[]>)+40]");
					gameEndWidget = (GameEndWidget)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag2 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v23 (Il2CppClass<GameEndWidget[]>)+40]");
					gameEndWidget2 = (GameEndWidget)0;
					if (flag2)
					{
						goto IL_056d;
					}
				}
				if (array.Length != 0)
				{
					object obj2 = array + 32;
					obj2 = scoresWidget;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					bool flag3 = (object)acesRewardWidget == null;
					gameEndWidget = scoresWidget;
					if (!flag3)
					{
						nint num2 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X8_v22 (Il2CppClass<GameEndWidget[]>)+40]");
						gameEndWidget = (GameEndWidget)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag4 = ex == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X8_v22 (Il2CppClass<GameEndWidget[]>)+40]");
						gameEndWidget2 = (GameEndWidget)0;
						if (flag4)
						{
							goto IL_056d;
						}
					}
					object obj3 = array.Length & 0xFFFFFFFEL;
					if (obj3 != null)
					{
						object obj4 = array + 40;
						obj4 = acesRewardWidget;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						bool flag5 = (object)tournamentPointsRewardWidget == null;
						gameEndWidget = acesRewardWidget;
						if (!flag5)
						{
							nint num3 = (nint)array;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X8_v21 (Il2CppClass<GameEndWidget[]>)+40]");
							gameEndWidget = (GameEndWidget)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
							bool flag6 = ex == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X8_v21 (Il2CppClass<GameEndWidget[]>)+40]");
							gameEndWidget2 = (GameEndWidget)0;
							if (flag6)
							{
								goto IL_056d;
							}
						}
						bool flag7 = array.Length < 2;
						object obj5 = !flag7;
						object obj6 = array.Length - 2;
						bool flag8 = obj6 == null;
						object obj7 = ~obj5;
						object obj8 = obj7 | flag8;
						if (obj8 == null)
						{
							object obj9 = array + 48;
							obj9 = tournamentPointsRewardWidget;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							bool flag9 = (object)massPointsRewardWidget == null;
							gameEndWidget = tournamentPointsRewardWidget;
							if (!flag9)
							{
								nint num4 = (nint)array;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v20 (Il2CppClass<GameEndWidget[]>)+40]");
								gameEndWidget = (GameEndWidget)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
								bool flag10 = ex == null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v20 (Il2CppClass<GameEndWidget[]>)+40]");
								gameEndWidget2 = (GameEndWidget)0;
								if (flag10)
								{
									goto IL_056d;
								}
							}
							object obj10 = array.Length & 0xFFFFFFFCL;
							if (obj10 != null)
							{
								object obj11 = array + 56;
								obj11 = massPointsRewardWidget;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								bool flag11 = (object)monthlyTournamentRewardWidget == null;
								gameEndWidget = massPointsRewardWidget;
								if (!flag11)
								{
									nint num5 = (nint)array;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v19 (Il2CppClass<GameEndWidget[]>)+40]");
									gameEndWidget = (GameEndWidget)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
									bool flag12 = ex == null;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v19 (Il2CppClass<GameEndWidget[]>)+40]");
									gameEndWidget2 = (GameEndWidget)0;
									if (flag12)
									{
										goto IL_056d;
									}
								}
								bool flag13 = array.Length < 4;
								object obj12 = !flag13;
								object obj13 = array.Length - 4;
								bool flag14 = obj13 == null;
								object obj14 = ~obj12;
								object obj15 = obj14 | flag14;
								if (obj15 == null)
								{
									object obj16 = array + 64;
									obj16 = monthlyTournamentRewardWidget;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									bool flag15 = (object)genericTournamentEndWidget == null;
									gameEndWidget = monthlyTournamentRewardWidget;
									if (!flag15)
									{
										nint num6 = (nint)array;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X8_v18 (Il2CppClass<GameEndWidget[]>)+40]");
										gameEndWidget = (GameEndWidget)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
										bool flag16 = ex == null;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X8_v18 (Il2CppClass<GameEndWidget[]>)+40]");
										gameEndWidget2 = (GameEndWidget)0;
										if (flag16)
										{
											goto IL_056d;
										}
									}
									bool flag17 = array.Length < 5;
									object obj17 = !flag17;
									object obj18 = array.Length - 5;
									bool flag18 = obj18 == null;
									object obj19 = ~obj17;
									object obj20 = obj19 | flag18;
									if (obj20 == null)
									{
										object obj21 = array + 72;
										obj21 = genericTournamentEndWidget;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
										return array;
									}
								}
							}
						}
					}
				}
				ex = new IndexOutOfRangeException();
				gameEndWidget2 = gameEndWidget;
				goto IL_056d;
			}
			goto IL_0585;
			IL_056d:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
			OutOfMemoryException ex2 = new OutOfMemoryException();
			goto IL_0585;
			IL_0585:
			return (GameEndWidget[])(object)new NullReferenceException();
		}
	}

	public override void Disable()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_014a: Expected O, but got I4
		//IL_00ab: Expected O, but got I
		//IL_00bb: Expected O, but got I
		//IL_00cb: Expected O, but got I
		//IL_00ed: Expected O, but got I4
		//IL_018e: Expected O, but got I
		//IL_019e: Expected O, but got I
		//IL_01ae: Expected O, but got I
		//IL_01d0: Expected O, but got I4
		//IL_0210: Expected O, but got I4
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Expected O, but got Unknown
		//IL_027d: Expected O, but got I
		//IL_028e: Expected I, but got O
		//IL_02ac: Expected O, but got I
		//IL_0240: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(SkeletonBinary.SkeletonInput) + 3568;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E67C4]");
		object obj3 = (nint)0 & (nint)1;
		GameEndWidget[] array2;
		GameEndWidget[] array3;
		object obj4;
		if (obj3 != null)
		{
			GameEndWidget[] array = widgets;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			array2 = array;
			object obj5 = obj4;
			array3 = array;
			if (!flag)
			{
				goto IL_009f;
			}
		}
		else
		{
			_ = 1;
			GameEndWidget[] array4 = widgets;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			array2 = array4;
			object obj5 = obj4;
			array3 = array4;
			if (obj6 != null)
			{
				goto IL_009f;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		object obj7 = (nint)0 + (nint)2152;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v3+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v4+8]");
		Action<object> action = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v4+8]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		object obj10 = obj7;
		array2 = array3;
		if (obj9 == null)
		{
			goto IL_01ee;
		}
		goto IL_0245;
		IL_01ee:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v3+E4]");
		bool flag4 = (nint)0 == 0;
		object obj11 = !flag4;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj12 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X8_v10+B8]");
			obj8 = 0;
		}
		object obj13 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2072;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj14 = (nint)0 + (nint)3880;
		Action<object> action2 = default(Action<object>);
		action2..ctor(obj8, (IntPtr)obj14);
		object obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v9+B8]");
		object obj16 = (nint)0 + (nint)8;
		obj16 = action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		action = action2;
		obj10 = obj7;
		array2 = array3;
		goto IL_0245;
		IL_0245:
		ArraysExtensions.ForEach(array2, action);
		return;
		IL_009f:
		obj10 = (nint)0 + (nint)2152;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v3+B8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v4+8]");
		action = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v4+8]");
		bool flag5 = (nint)0 == 0;
		object obj17 = !flag5;
		if (obj17 == null)
		{
			obj7 = obj10;
			array3 = array2;
			goto IL_01ee;
		}
		goto IL_0245;
	}

	private GameEndWidget GetWidget(CardGameEndScores endScores)
	{
		//IL_0081: Expected O, but got I4
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_00ab: Expected O, but got I
		//IL_0152: Expected O, but got I
		//IL_017c: Expected O, but got I4
		//IL_0073: Expected O, but got I4
		//IL_012d: Expected O, but got I4
		//IL_00d4: Expected O, but got I
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected O, but got Unknown
		//IL_03b1: Expected O, but got I4
		//IL_065b: Expected O, but got I
		//IL_03bf: Expected O, but got I4
		//IL_03cc: Expected O, but got I
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Expected O, but got Unknown
		//IL_02b5: Expected O, but got I4
		//IL_02e3: Expected O, but got I4
		//IL_05bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c2: Expected O, but got Unknown
		//IL_05dc: Expected O, but got I4
		//IL_02d5: Expected O, but got I4
		//IL_02f1: Expected O, but got I4
		//IL_0307: Expected O, but got I
		//IL_03e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e6: Expected O, but got Unknown
		//IL_0410: Expected O, but got I4
		//IL_0371: Expected O, but got I
		//IL_0395: Expected O, but got I4
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Expected O, but got Unknown
		//IL_0434: Expected O, but got I
		//IL_0547: Expected O, but got I4
		//IL_0539: Expected O, but got I4
		//IL_04eb: Expected O, but got I4
		//IL_04dd: Expected O, but got I4
		//IL_064e: Expected O, but got I
		//IL_0555: Expected O, but got I4
		//IL_061c: Expected O, but got I
		//IL_04f9: Expected O, but got I4
		TournamentEndGameReport <tournamentReport>k__BackingField;
		object obj;
		TournamentMatchInfo tournamentMatchInfo = default(TournamentMatchInfo);
		if (endScores != null)
		{
			<tournamentReport>k__BackingField = endScores.<tournamentReport>k__BackingField;
			CardGame cardGame = base.game;
			if ((object)cardGame != null)
			{
				int myTeamIndex = cardGame.MyTeamIndex;
				if (endScores.<WinnerTeamIndex>k__BackingField == myTeamIndex)
				{
					obj = 0;
					goto IL_0592;
				}
				object obj2 = 152985600;
				object obj3 = typeof(Queue<string>) + 872;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6843]");
				object obj4 = (nint)0 & (nint)1;
				if (obj4 != null)
				{
					object obj5 = (nint)0 + (nint)2248;
					object obj6 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X0_v37+E4]");
					bool flag = (nint)0 == 0;
					object obj7 = obj5;
					if (!flag)
					{
						goto IL_0109;
					}
				}
				else
				{
					_ = 1;
					object obj5 = (nint)0 + (nint)2248;
					object obj6 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X0_v37+E4]");
					bool flag2 = (nint)0 == 0;
					object obj8 = !flag2;
					object obj7 = obj5;
					if (obj8 != null)
					{
						goto IL_0109;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				if ((object)tournamentMatchInfo != null)
				{
					goto IL_01c8;
				}
			}
		}
		goto IL_0567;
		IL_01c8:
		TournamentData tournament = tournamentMatchInfo.Tournament;
		if (tournament == null)
		{
			goto IL_0567;
		}
		obj = (??)tournament.<SecondPrize>k__BackingField ^ 1;
		goto IL_0592;
		IL_0365:
		object obj9 = (nint)0 + (nint)2248;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		TournamentMatchInfo tournamentMatchInfo2 = default(TournamentMatchInfo);
		bool flag3 = (object)tournamentMatchInfo2 == null;
		object obj10 = !flag3;
		if (obj10 != null)
		{
			goto IL_0460;
		}
		goto IL_0567;
		IL_0592:
		if (endScores.<tournamentReport>k__BackingField != null)
		{
			if (!<tournamentReport>k__BackingField.isFinalMatch)
			{
				object obj11 = 40;
				goto IL_064e;
			}
			if (!endScores.<tournamentReport>k__BackingField.IsMatchOver)
			{
				object obj12 = 40;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TournamentGameEndWidgetSwitch)+v220 @ X8_v8]");
				return (GameEndWidget)0;
			}
			CardGame cardGame2 = base.game;
			if ((object)cardGame2 != null)
			{
				bool isSpectator = cardGame2.IsSpectator;
				object obj13 = isSpectator | obj;
				bool flag4 = !isSpectator;
				object obj14 = !flag4;
				object obj15 = ~obj14;
				if (obj15 == null)
				{
					object obj11 = 80;
				}
				else
				{
					object obj11 = 40;
				}
				object obj16 = obj13 & 1;
				bool flag5 = obj16 == null;
				object obj17 = !flag5;
				if (obj17 != null)
				{
					goto IL_064e;
				}
				object obj18 = 152985600;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6843]");
				object obj19 = (nint)0 & (nint)1;
				if (obj19 != null)
				{
					object obj20 = typeof(Queue<string>) + 872;
					object obj21 = obj20;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X0_v20+E4]");
					if ((nint)0 != 0)
					{
						goto IL_0365;
					}
				}
				else
				{
					_ = 1;
					object obj22 = typeof(Queue<string>) + 872;
					object obj21 = obj22;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X0_v20+E4]");
					bool flag6 = (nint)0 == 0;
					object obj23 = !flag6;
					if (obj23 != null)
					{
						goto IL_0365;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj24 = (nint)0 + (nint)2248;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				if ((object)tournamentMatchInfo2 != null)
				{
					goto IL_0460;
				}
			}
		}
		goto IL_0567;
		IL_064e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TournamentGameEndWidgetSwitch)+v219 @ X8_v6]");
		return (GameEndWidget)0;
		IL_0460:
		TournamentData tournament2 = tournamentMatchInfo2.Tournament;
		if (tournament2 != null)
		{
			if (tournament2.<PrizeType>k__BackingField <= TournamentPrizeType.MassEventPoints)
			{
				object obj25 = ((tournament2.<PrizeType>k__BackingField != TournamentPrizeType.MassEventPoints) ? ((object)80) : ((object)64));
				if (tournament2.<PrizeType>k__BackingField == TournamentPrizeType.Aces)
				{
					object obj26 = 48;
				}
				else
				{
					object obj26 = obj25;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TournamentGameEndWidgetSwitch)+v222 @ X8_v15]");
				return (GameEndWidget)0;
			}
			object obj27 = ((tournament2.<PrizeType>k__BackingField != TournamentPrizeType.MonthlyPrize) ? ((object)80) : ((object)72));
			if (tournament2.<PrizeType>k__BackingField == TournamentPrizeType.TournamentPoints)
			{
				object obj28 = 56;
			}
			else
			{
				object obj28 = obj27;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TournamentGameEndWidgetSwitch)+v221 @ X8_v19]");
			return (GameEndWidget)0;
		}
		goto IL_0567;
		IL_0567:
		return (GameEndWidget)(object)new NullReferenceException();
		IL_0109:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag7 = (object)tournamentMatchInfo == null;
		object obj29 = !flag7;
		if (obj29 != null)
		{
			goto IL_01c8;
		}
		goto IL_0567;
	}

	public override void PrepareAnimation(CardGameEndScores rankReport)
	{
		//IL_001b: Expected I, but got O
		//IL_002b: Expected O, but got I
		//IL_003b: Expected O, but got I
		GameEndWidget widget = GetWidget(rankReport);
		nint num = (nint)widget;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X8_v1 (Il2CppClass<GameEndWidget>)+178]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X8_v1 (Il2CppClass<GameEndWidget>)+180]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v17 @ X3_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public override void Populate(CardGameEndScores rankReport)
	{
		//IL_001b: Expected I, but got O
		//IL_002b: Expected O, but got I
		//IL_003b: Expected O, but got I
		GameEndWidget widget = GetWidget(rankReport);
		nint num = (nint)widget;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X8_v1 (Il2CppClass<GameEndWidget>)+188]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X8_v1 (Il2CppClass<GameEndWidget>)+190]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v17 @ X3_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public override DG.Tweening.Sequence AnimatedPopulate(CardGameEndScores rankReport)
	{
		//IL_0033: Expected I, but got O
		//IL_0043: Expected O, but got I
		//IL_0053: Expected O, but got I
		GameEndWidget widget = GetWidget(rankReport);
		if ((object)widget != null)
		{
			nint num = (nint)widget;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X8_v1 (Il2CppClass<GameEndWidget>)+198]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X8_v1 (Il2CppClass<GameEndWidget>)+1A0]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v17 @ X3_v1 (should have been resolved before IL gen)");
		}
		return (DG.Tweening.Sequence)(object)new NullReferenceException();
	}

	public override bool ShouldShow(CardGameEndScores rankReport)
	{
		//IL_004f: Expected I4, but got O
		if (rankReport != null)
		{
			bool flag = rankReport.<tournamentReport>k__BackingField == null;
			return !flag;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}
}
