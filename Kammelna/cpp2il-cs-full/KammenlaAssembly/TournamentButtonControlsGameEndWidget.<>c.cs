using System;
using System.Diagnostics;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Server.Models;
using Sfs2X.Entities.Data;
using Spine;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class TournamentButtonControlsGameEndWidget : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<Button> <>9__6_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(SkeletonBinary.SkeletonInput) + 3440;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <Init>b__6_0(Button b)
		{
			GameObject gameObject = b.gameObject;
			gameObject.SetActive(value: false);
		}
	}

	private Button backButton;

	private Button continueMatchButton;

	private Button continueTournamentButton;

	private Button[] allbutts;

	private CardGame game;

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0403: Expected O, but got I
		//IL_0412: Unknown result type (might be due to invalid IL or missing references)
		//IL_0417: Expected O, but got Unknown
		//IL_0441: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0076: Expected O, but got I4
		//IL_00a4: Expected O, but got I4
		//IL_00ca: Expected O, but got I
		//IL_00f3: Expected O, but got I
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_0144: Expected O, but got I
		//IL_016f: Expected O, but got I
		//IL_01e6: Expected O, but got I8
		//IL_0195: Expected O, but got I
		//IL_01be: Expected O, but got I
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Expected O, but got Unknown
		//IL_02bf: Expected O, but got I4
		//IL_02d5: Expected O, but got I
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Expected O, but got Unknown
		//IL_0266: Expected O, but got I
		//IL_028f: Expected O, but got I
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Expected O, but got Unknown
		//IL_0328: Expected O, but got I
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Expected O, but got Unknown
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Expected O, but got Unknown
		//IL_0384: Expected I, but got O
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)24;
		object obj3 = typeof(TypeConverter<ushort, char>) + 1840;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj6 = this + 64;
		object obj7 = default(object);
		obj6 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj8 = default(object);
		bool flag2 = obj8 == null;
		object obj9 = 3;
		NullReferenceException ex = default(NullReferenceException);
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X21_v5-20]");
			bool flag3 = (nint)0 == 0;
			object obj10 = 3;
			if (!flag3)
			{
				object obj11 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v15+40]");
				obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag4 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v15+40]");
				obj9 = 0;
				if (flag4)
				{
					goto IL_03e1;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v9+18]");
			if ((nint)0 != 0)
			{
				object obj12 = obj8 + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X21_v5-20]");
				obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				bool flag5 = (object)continueMatchButton == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X21_v5-20]");
				obj10 = 0;
				if (!flag5)
				{
					object obj13 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v14+40]");
					obj10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag6 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v14+40]");
					obj9 = 0;
					if (flag6)
					{
						goto IL_03e1;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v9+18]");
				object obj14 = 0 & 0xFFFFFFFEL;
				if (obj14 != null)
				{
					object obj15 = obj8 + 40;
					obj15 = continueMatchButton;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					bool flag7 = (object)continueTournamentButton == null;
					obj10 = continueMatchButton;
					if (!flag7)
					{
						object obj16 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v13+40]");
						obj10 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag8 = ex == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v13+40]");
						obj9 = 0;
						if (flag8)
						{
							goto IL_03e1;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v9+18]");
					bool flag9 = (nint)0 < (nint)2;
					object obj17 = !flag9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v9+18]");
					object obj18 = -2;
					bool flag10 = obj18 == null;
					object obj19 = ~obj17;
					object obj20 = obj19 | flag10;
					if (obj20 == null)
					{
						object obj21 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2360;
						object obj22 = (nint)0 + (nint)568;
						object obj23 = obj8 + 48;
						obj23 = continueTournamentButton;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						object obj24 = this + 56;
						obj24 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						Action<object> action = default(Action<object>);
						action..ctor((object)this, (IntPtr)obj22);
						bool flag11 = (object)game == null;
						obj9 = this;
						if (!flag11)
						{
							game.OnGameEnd += action;
							return;
						}
						goto IL_03d3;
					}
				}
			}
			IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
			obj9 = obj10;
		}
		goto IL_03d3;
		IL_03e1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_03d3:
		ex = new NullReferenceException();
		goto IL_03e1;
	}

	private void Init(ISFSObject data)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_00d3: Expected O, but got I
		//IL_00e3: Expected O, but got I
		//IL_0105: Expected O, but got I4
		//IL_009d: Expected O, but got I4
		//IL_003e: Expected O, but got I
		//IL_004e: Expected O, but got I
		//IL_0136: Expected O, but got I4
		//IL_0268: Expected O, but got I4
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Expected O, but got Unknown
		//IL_0320: Expected O, but got I
		//IL_0331: Expected I, but got O
		//IL_034f: Expected O, but got I
		//IL_01c8: Expected O, but got I4
		//IL_0166: Expected O, but got I
		//IL_022f: Expected O, but got I4
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1536;
		object obj2 = typeof(SkeletonBinary.SkeletonInput) + 3440;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TournamentEndGameReport tournamentEndGameReport = default(TournamentEndGameReport);
		tournamentEndGameReport..ctor(data);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v18+E4]");
		object obj4;
		Action<object> action;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v18+B8]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X8_v9+8]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X8_v9+8]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v18+B8]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X8_v9+8]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X8_v9+8]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v18+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v15+B8]");
			obj4 = 0;
		}
		object obj8 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1320;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj9 = (nint)0 + (nint)3656;
		Action<object> action2 = default(Action<object>);
		action2..ctor(obj4, (IntPtr)obj9);
		object obj10 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v14+B8]");
		object obj11 = (nint)0 + (nint)8;
		obj11 = action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		ArraysExtensions.ForEach(allbutts, action2);
		goto IL_017f;
		IL_017f:
		Component component;
		if (tournamentEndGameReport.IsMatchOver)
		{
			bool flag3 = !tournamentEndGameReport.isFinalMatch;
			object obj12 = !flag3;
			if (obj12 == null)
			{
				int myTeamIndex = game.MyTeamIndex;
				if (tournamentEndGameReport.gameWinner == myTeamIndex)
				{
					component = continueTournamentButton;
					bool flag4 = (object)continueTournamentButton == null;
					object obj13 = !flag4;
					if (obj13 != null)
					{
						goto IL_028a;
					}
					goto IL_02ab;
				}
			}
			component = backButton;
		}
		else
		{
			component = continueMatchButton;
			bool flag5 = (object)continueMatchButton == null;
			object obj14 = !flag5;
			if (obj14 == null)
			{
				goto IL_02ab;
			}
		}
		goto IL_028a;
		IL_0074:
		ArraysExtensions.ForEach(allbutts, action);
		bool flag6 = tournamentEndGameReport == null;
		object obj15 = !flag6;
		if (obj15 != null)
		{
			goto IL_017f;
		}
		goto IL_02ab;
		IL_02ab:
		throw new NullReferenceException();
		IL_028a:
		GameObject gameObject = component.gameObject;
		gameObject.SetActive(value: true);
	}

	public TournamentButtonControlsGameEndWidget()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		object obj = typeof(TypeConverter<ushort, char>) + 1840;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj2 = this + 56;
		object obj3 = default(object);
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}
}
