using System;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using DG.Tweening;
using Kammelna.Server.Models.Clans;
using TMPro;
using UnityEngine;

public class EndGameScore : AbstractEndGameScore
{
	public TextMeshProUGUI team1Score;

	public TextMeshProUGUI team2Score;

	public void SetupScore(int t1, int t2)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0241: Expected O, but got I4
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00c8: Expected O, but got I4
		//IL_02e6: Expected O, but got I4
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Expected O, but got Unknown
		//IL_035e: Expected O, but got I4
		//IL_0367: Expected O, but got I4
		//IL_0375: Expected I, but got O
		//IL_0387: Expected F4, but got I4
		//IL_0398: Expected O, but got I4
		//IL_03bc: Expected F4, but got I4
		//IL_018a: Expected O, but got I4
		//IL_040e: Expected O, but got I4
		//IL_043f: Expected O, but got I4
		//IL_01c2: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6755]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v13+E4]");
			bool flag = (nint)0 == 0;
			obj5 = team1Score;
			obj6 = team1Score;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = team1Score;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v13+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = team1Score;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj8 = typeof(SqlSingle[]) + 3912;
		bool flag3 = obj6;
		bool flag4 = !flag3;
		int num = 0;
		int num2 = 0;
		object obj9 = obj8;
		if (flag4)
		{
			goto IL_00f0;
		}
		goto IL_02bc;
		IL_03dc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object obj10;
		bool flag5 = obj10;
		bool flag6 = !flag5;
		object obj11 = !flag6;
		object obj13;
		object obj12 = obj13;
		bool flag8;
		bool flag7 = flag8;
		bool flag9;
		nint num3 = (flag9 ? 1 : 0);
		bool flag10;
		int num4 = (flag10 ? 1 : 0);
		float num6;
		float num5 = num6;
		object obj14 = 0;
		obj8 = obj9;
		if (obj11 == null)
		{
			return;
		}
		goto IL_0198;
		IL_00f0:
		object obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v2+E4]");
		bool flag11 = (nint)0 == 0;
		num4 = t2;
		UnityEngine.Object obj16 = team2Score;
		obj13 = obj12;
		flag8 = flag7;
		flag9 = (byte)num3 != 0;
		flag10 = (byte)t2 != 0;
		num6 = num5;
		obj9 = obj8;
		obj10 = team2Score;
		if (!flag11)
		{
			goto IL_0169;
		}
		goto IL_03dc;
		IL_0169:
		bool flag12 = obj16;
		bool flag13 = !flag12;
		obj14 = 0;
		if (!flag13)
		{
			goto IL_0198;
		}
		return;
		IL_0091:
		obj8 = typeof(SqlSingle[]) + 3912;
		bool flag14 = obj5;
		bool flag15 = !flag14;
		object obj17 = !flag15;
		num = 0;
		num2 = 0;
		obj9 = obj8;
		if (obj17 == null)
		{
			goto IL_00f0;
		}
		goto IL_02bc;
		IL_02bc:
		object obj18 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X0_v7+E4]");
		bool flag16 = (nint)0 == 0;
		object obj19 = !flag16;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tweener tweener = AnimationExtensions.DONumber(team1Score, t1, 0.6f);
		obj16 = team2Score;
		obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v2+E4]");
		bool flag17 = (nint)0 == 0;
		object obj20 = !flag17;
		obj12 = 0;
		flag7 = false;
		num3 = unchecked((nint)null);
		num4 = 0;
		num5 = 1.0586423E+09f;
		obj8 = obj9;
		obj13 = 0;
		flag8 = false;
		flag9 = false;
		flag10 = false;
		num6 = 1.0586423E+09f;
		num = t1;
		obj10 = team2Score;
		if (obj20 != null)
		{
			goto IL_0169;
		}
		goto IL_03dc;
		IL_0198:
		object obj21 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X0_v25+E4]");
		bool flag18 = (nint)0 == 0;
		object obj22 = !flag18;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tweener tweener2 = AnimationExtensions.DONumber(team2Score, t2, 0.6f);
	}

	public override void ResetScore()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0184: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		//IL_01e2: Expected O, but got I
		//IL_022d: Expected O, but got I4
		//IL_013a: Expected O, but got I
		//IL_0277: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6756]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			obj5 = team1Score;
			obj6 = team1Score;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = team1Score;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v11+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = team1Score;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		string text = null;
		if (flag4)
		{
			goto IL_00c7;
		}
		goto IL_01d6;
		IL_012e:
		object text2 = (nint)0 + (nint)2000;
		team2Score.SetText((string)text2);
		return;
		IL_0108:
		UnityEngine.Object obj8;
		if ((bool)obj8)
		{
			goto IL_012e;
		}
		return;
		IL_0245:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object obj9;
		bool flag5 = obj9;
		bool flag6 = !flag5;
		object obj10 = !flag6;
		if (obj10 == null)
		{
			return;
		}
		goto IL_012e;
		IL_0091:
		bool flag7 = obj5;
		bool flag8 = !flag7;
		object obj11 = !flag8;
		text = null;
		if (obj11 == null)
		{
			goto IL_00c7;
		}
		goto IL_01d6;
		IL_01d6:
		object obj12 = (nint)0 + (nint)2000;
		text = (string)obj12;
		team1Score.SetText((string)obj12);
		obj8 = team2Score;
		object obj13 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v4+E4]");
		bool flag9 = (nint)0 == 0;
		object obj14 = !flag9;
		obj9 = team2Score;
		if (obj14 != null)
		{
			goto IL_0108;
		}
		goto IL_0245;
		IL_00c7:
		obj13 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v4+E4]");
		bool flag10 = (nint)0 == 0;
		obj8 = team2Score;
		obj9 = team2Score;
		if (!flag10)
		{
			goto IL_0108;
		}
		goto IL_0245;
	}

	public override void SetupScore(int[] scores)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0215: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Expected O, but got Unknown
		//IL_02cf: Expected O, but got I4
		//IL_0351: Expected O, but got I4
		//IL_035a: Expected O, but got I4
		//IL_0371: Expected I, but got O
		//IL_037a: Expected F4, but got I4
		//IL_0383: Expected O, but got I4
		//IL_03a7: Expected F4, but got I4
		//IL_0403: Expected O, but got I4
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected O, but got Unknown
		//IL_01be: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6757]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v17+E4]");
			bool flag = (nint)0 == 0;
			obj5 = team1Score;
			obj6 = team1Score;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = team1Score;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v17+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = team1Score;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		int num = 0;
		int num2 = 0;
		if (flag4)
		{
			goto IL_00d4;
		}
		goto IL_0274;
		IL_03d1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object obj8;
		bool flag5 = obj8;
		bool flag6 = !flag5;
		object obj9 = !flag6;
		object obj11;
		object obj10 = obj11;
		bool flag8;
		bool flag7 = flag8;
		bool flag10;
		bool flag9 = flag10;
		bool flag11;
		nint num3 = (flag11 ? 1 : 0);
		float num5;
		float num4 = num5;
		if (obj9 == null)
		{
			return;
		}
		goto IL_0163;
		IL_00d4:
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v6+E4]");
		bool flag12 = (nint)0 == 0;
		UnityEngine.Object obj13 = team2Score;
		obj11 = obj10;
		flag8 = flag7;
		flag10 = flag9;
		flag11 = (byte)num3 != 0;
		num5 = num4;
		obj8 = team2Score;
		if (!flag12)
		{
			goto IL_013d;
		}
		goto IL_03d1;
		IL_0163:
		if (scores != null)
		{
			object obj14 = typeof(SqlSingle[]) + 3912;
			object obj15 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v21+E4]");
			bool flag13 = (nint)0 == 0;
			object obj16 = !flag13;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Tweener tweener = AnimationExtensions.DONumber(team2Score, scores[1], 0.6f);
			return;
		}
		goto IL_043a;
		IL_0091:
		bool flag14 = obj5;
		bool flag15 = !flag14;
		object obj17 = !flag15;
		num = 0;
		num2 = 0;
		if (obj17 == null)
		{
			goto IL_00d4;
		}
		goto IL_0274;
		IL_0274:
		if (scores != null)
		{
			object obj18 = typeof(SqlSingle[]) + 3912;
			object obj19 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X0_v11+E4]");
			bool flag16 = (nint)0 == 0;
			object obj20 = !flag16;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Tweener tweener2 = AnimationExtensions.DONumber(team1Score, scores[0], 0.6f);
			obj13 = team2Score;
			obj12 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v6+E4]");
			bool flag17 = (nint)0 == 0;
			object obj21 = !flag17;
			obj10 = 0;
			flag7 = false;
			flag9 = false;
			num3 = unchecked((nint)null);
			num4 = 1.0586423E+09f;
			obj11 = 0;
			flag8 = false;
			flag10 = false;
			flag11 = false;
			num5 = 1.0586423E+09f;
			num = scores[0];
			obj8 = team2Score;
			if (obj21 != null)
			{
				goto IL_013d;
			}
			goto IL_03d1;
		}
		goto IL_043a;
		IL_013d:
		if ((bool)obj13)
		{
			goto IL_0163;
		}
		return;
		IL_043a:
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
	}
}
