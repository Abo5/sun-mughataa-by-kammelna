using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities;
using UnityEngine;

public abstract class BaseTournamentMatchScores : MonoBehaviour
{
	protected CardGame game;

	protected TournamentMatchInfo tournamentInfo
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6CF8]");
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

	protected int MyTeamIndex
	{
		get
		{
			//IL_0092: Expected I4, but got O
			if ((object)game != null)
			{
				if (game.IsSpectator)
				{
					return 1;
				}
				if ((object)game != null)
				{
					return game.MyTeamIndex;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	protected int OurScore
	{
		get
		{
			//IL_044a: Expected I4, but got O
			//IL_0048: Expected O, but got I4
			//IL_0051: Expected O, but got I4
			//IL_00cc: Expected O, but got I
			//IL_0182: Unknown result type (might be due to invalid IL or missing references)
			//IL_0187: Expected O, but got Unknown
			//IL_01b1: Expected O, but got I4
			//IL_0136: Expected O, but got I
			//IL_015a: Expected O, but got I4
			//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fd: Expected O, but got Unknown
			//IL_0210: Expected O, but got I4
			//IL_021a: Unknown result type (might be due to invalid IL or missing references)
			//IL_021f: Expected O, but got Unknown
			//IL_0228: Unknown result type (might be due to invalid IL or missing references)
			//IL_022d: Expected O, but got Unknown
			//IL_0247: Expected O, but got I4
			//IL_01d5: Expected O, but got I
			//IL_00a8: Expected O, but got I4
			//IL_0464: Expected O, but got I
			//IL_0294: Expected O, but got I4
			//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a8: Expected O, but got Unknown
			//IL_02be: Expected O, but got I
			//IL_0276: Expected O, but got I4
			//IL_03bb: Expected O, but got I
			//IL_03e5: Expected O, but got I4
			//IL_02e7: Expected O, but got I
			//IL_0352: Expected O, but got I4
			//IL_035c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0361: Expected O, but got Unknown
			//IL_036a: Unknown result type (might be due to invalid IL or missing references)
			//IL_036f: Expected O, but got Unknown
			//IL_042e: Expected O, but got I4
			object obj10 = default(object);
			if ((object)game != null)
			{
				bool isSpectator = game.IsSpectator;
				bool flag = !isSpectator;
				object obj = !flag;
				object obj2 = 0;
				if (obj != null)
				{
					goto IL_00b6;
				}
				if ((object)game != null)
				{
					int myTeamIndex = game.MyTeamIndex;
					bool flag2 = myTeamIndex != 1;
					obj2 = 0;
					if (!flag2)
					{
						goto IL_00b6;
					}
					object obj3 = 152985600;
					object obj4 = typeof(Queue<string>) + 872;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6CF8]");
					object obj5 = (nint)0 & (nint)1;
					if (obj5 != null)
					{
						object obj6 = (nint)0 + (nint)2248;
						object obj7 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X0_v30+E4]");
						bool flag3 = (nint)0 == 0;
						object obj8 = obj6;
						if (!flag3)
						{
							goto IL_031c;
						}
					}
					else
					{
						_ = 1;
						object obj6 = (nint)0 + (nint)2248;
						object obj7 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X0_v30+E4]");
						bool flag4 = (nint)0 == 0;
						object obj9 = !flag4;
						object obj8 = obj6;
						if (obj9 != null)
						{
							goto IL_031c;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
					bool flag5 = obj10 == null;
					object obj11 = !flag5;
					if (obj11 != null)
					{
						goto IL_0343;
					}
				}
			}
			goto IL_043c;
			IL_0343:
			object obj12 = 152985600 + 3323;
			object obj13 = "utf-32" + 1112;
			object obj14 = obj12 & 1;
			bool flag6 = obj14 == null;
			object obj15 = obj10;
			if (flag6)
			{
				goto IL_026d;
			}
			object varName = obj13;
			object obj16 = obj10;
			goto IL_044a;
			IL_0201:
			obj12 = 152985600 + 3322;
			obj13 = "utf-32" + 1104;
			object obj17 = obj12 & 1;
			bool flag7 = obj17 == null;
			object obj18 = !flag7;
			object obj19 = default(object);
			obj15 = obj19;
			varName = obj13;
			obj16 = obj19;
			if (obj18 == null)
			{
				goto IL_026d;
			}
			goto IL_044a;
			IL_00b6:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6CF8]");
			object obj20 = (nint)0 & (nint)1;
			if (obj20 != null)
			{
				object obj21 = typeof(Queue<string>) + 872;
				object obj22 = obj21;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v13+E4]");
				if ((nint)0 != 0)
				{
					goto IL_012a;
				}
			}
			else
			{
				_ = 1;
				object obj23 = typeof(Queue<string>) + 872;
				object obj22 = obj23;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v13+E4]");
				bool flag8 = (nint)0 == 0;
				object obj24 = !flag8;
				if (obj24 != null)
				{
					goto IL_012a;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj25 = (nint)0 + (nint)2248;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			if (obj19 != null)
			{
				goto IL_0201;
			}
			goto IL_043c;
			IL_043c:
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
			IL_012a:
			object obj26 = (nint)0 + (nint)2248;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			bool flag9 = obj19 == null;
			object obj27 = !flag9;
			if (obj27 != null)
			{
				goto IL_0201;
			}
			goto IL_043c;
			IL_026d:
			obj12 = 1;
			varName = obj13;
			obj16 = obj15;
			goto IL_044a;
			IL_044a:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X19_v3+20]");
			return SFSExtensions.GetVariable((Room)0, (string)varName, 0);
			IL_031c:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			if (obj10 != null)
			{
				goto IL_0343;
			}
			goto IL_043c;
		}
	}

	protected int TheirScore
	{
		get
		{
			//IL_044a: Expected I4, but got O
			//IL_0048: Expected O, but got I4
			//IL_0051: Expected O, but got I4
			//IL_00cc: Expected O, but got I
			//IL_0182: Unknown result type (might be due to invalid IL or missing references)
			//IL_0187: Expected O, but got Unknown
			//IL_01b1: Expected O, but got I4
			//IL_0136: Expected O, but got I
			//IL_015a: Expected O, but got I4
			//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fd: Expected O, but got Unknown
			//IL_0210: Expected O, but got I4
			//IL_021a: Unknown result type (might be due to invalid IL or missing references)
			//IL_021f: Expected O, but got Unknown
			//IL_0228: Unknown result type (might be due to invalid IL or missing references)
			//IL_022d: Expected O, but got Unknown
			//IL_0247: Expected O, but got I4
			//IL_01d5: Expected O, but got I
			//IL_00a8: Expected O, but got I4
			//IL_0464: Expected O, but got I
			//IL_0294: Expected O, but got I4
			//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a8: Expected O, but got Unknown
			//IL_02be: Expected O, but got I
			//IL_0276: Expected O, but got I4
			//IL_03bb: Expected O, but got I
			//IL_03e5: Expected O, but got I4
			//IL_02e7: Expected O, but got I
			//IL_0352: Expected O, but got I4
			//IL_035c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0361: Expected O, but got Unknown
			//IL_036a: Unknown result type (might be due to invalid IL or missing references)
			//IL_036f: Expected O, but got Unknown
			//IL_042e: Expected O, but got I4
			object obj10 = default(object);
			if ((object)game != null)
			{
				bool isSpectator = game.IsSpectator;
				bool flag = !isSpectator;
				object obj = !flag;
				object obj2 = 0;
				if (obj != null)
				{
					goto IL_00b6;
				}
				if ((object)game != null)
				{
					int myTeamIndex = game.MyTeamIndex;
					bool flag2 = myTeamIndex != 1;
					obj2 = 0;
					if (!flag2)
					{
						goto IL_00b6;
					}
					object obj3 = 152985600;
					object obj4 = typeof(Queue<string>) + 872;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6CF8]");
					object obj5 = (nint)0 & (nint)1;
					if (obj5 != null)
					{
						object obj6 = (nint)0 + (nint)2248;
						object obj7 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X0_v30+E4]");
						bool flag3 = (nint)0 == 0;
						object obj8 = obj6;
						if (!flag3)
						{
							goto IL_031c;
						}
					}
					else
					{
						_ = 1;
						object obj6 = (nint)0 + (nint)2248;
						object obj7 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X0_v30+E4]");
						bool flag4 = (nint)0 == 0;
						object obj9 = !flag4;
						object obj8 = obj6;
						if (obj9 != null)
						{
							goto IL_031c;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
					bool flag5 = obj10 == null;
					object obj11 = !flag5;
					if (obj11 != null)
					{
						goto IL_0343;
					}
				}
			}
			goto IL_043c;
			IL_0343:
			object obj12 = 152985600 + 3322;
			object obj13 = "utf-32" + 1104;
			object obj14 = obj12 & 1;
			bool flag6 = obj14 == null;
			object obj15 = obj10;
			if (flag6)
			{
				goto IL_026d;
			}
			object varName = obj13;
			object obj16 = obj10;
			goto IL_044a;
			IL_0201:
			obj12 = 152985600 + 3323;
			obj13 = "utf-32" + 1112;
			object obj17 = obj12 & 1;
			bool flag7 = obj17 == null;
			object obj18 = !flag7;
			object obj19 = default(object);
			obj15 = obj19;
			varName = obj13;
			obj16 = obj19;
			if (obj18 == null)
			{
				goto IL_026d;
			}
			goto IL_044a;
			IL_00b6:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6CF8]");
			object obj20 = (nint)0 & (nint)1;
			if (obj20 != null)
			{
				object obj21 = typeof(Queue<string>) + 872;
				object obj22 = obj21;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v13+E4]");
				if ((nint)0 != 0)
				{
					goto IL_012a;
				}
			}
			else
			{
				_ = 1;
				object obj23 = typeof(Queue<string>) + 872;
				object obj22 = obj23;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v13+E4]");
				bool flag8 = (nint)0 == 0;
				object obj24 = !flag8;
				if (obj24 != null)
				{
					goto IL_012a;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj25 = (nint)0 + (nint)2248;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			if (obj19 != null)
			{
				goto IL_0201;
			}
			goto IL_043c;
			IL_043c:
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
			IL_012a:
			object obj26 = (nint)0 + (nint)2248;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			bool flag9 = obj19 == null;
			object obj27 = !flag9;
			if (obj27 != null)
			{
				goto IL_0201;
			}
			goto IL_043c;
			IL_026d:
			obj12 = 1;
			varName = obj13;
			obj16 = obj15;
			goto IL_044a;
			IL_044a:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X19_v3+20]");
			return SFSExtensions.GetVariable((Room)0, (string)varName, 0);
			IL_031c:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			if (obj10 != null)
			{
				goto IL_0343;
			}
			goto IL_043c;
		}
	}

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_021c: Expected O, but got I
		//IL_0246: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0085: Expected I, but got O
		//IL_01c7: Expected O, but got I
		//IL_01d7: Expected O, but got I
		//IL_01e6: Expected I, but got O
		//IL_01f6: Expected O, but got I
		//IL_0206: Expected O, but got I
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_0260: Expected O, but got I
		//IL_028a: Expected O, but got I4
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_0103: Expected I, but got O
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Expected O, but got Unknown
		//IL_01a4: Expected O, but got I4
		//IL_01ac: Expected I, but got O
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj6 = default(object);
		Action action = default(Action);
		object obj13 = default(object);
		Delegate obj16 = default(Delegate);
		while (true)
		{
			object obj2 = (nint)0 + (nint)24;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
			object obj5 = this + 32;
			obj5 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Room room = ((KGame)obj5).Room;
			GameType gameType = SFSKammelnaRoomExtensions.GetGameType(room);
			bool flag2 = GameTypeExtensions.IsTournament(gameType);
			nint num = (nint)this;
			if (flag2)
			{
				Init();
				object obj7 = typeof(Queue<string>) + 872;
				object obj8 = (nint)0 + (nint)2248;
				object obj9 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X0_v19+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				object obj11 = typeof(SqlSingle[]) + 2376;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				nint num2 = (nint)this;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v10 (Il2CppClass<BaseTournamentMatchScores>)+1A0]");
				action..ctor(this, (IntPtr)0);
				object obj12 = obj13 + 48;
				Delegate obj14 = (Delegate)obj12;
				bool flag4;
				do
				{
					Delegate obj15 = Delegate.Combine(obj14, action);
					if ((object)obj15 == null || obj15 == obj11)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
						flag4 = (object)obj16 == obj14;
						obj14 = obj16;
						continue;
					}
					object obj17 = 0;
					num = (nint)obj15;
					throw new InvalidCastException();
				}
				while (!flag4);
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v6 (Il2CppClass<BaseTournamentMatchScores>)+188]");
				object obj18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v6 (Il2CppClass<BaseTournamentMatchScores>)+190]");
				object obj19 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v143 @ X2_v3 (should have been resolved before IL gen)");
			}
			nint num3 = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v15 (Il2CppClass<BaseTournamentMatchScores>)+198]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v15 (Il2CppClass<BaseTournamentMatchScores>)+1A0]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v144 @ X2_v8 (should have been resolved before IL gen)");
		}
	}

	protected abstract void Init();

	protected abstract void InitNotTournament();

	protected abstract void OnScoresUpdated();
}
