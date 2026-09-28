using System;
using System.Buffers.Text;
using Cpp2ILInjected;
using Features.GameReplay;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class GamesHubItem : MonoBehaviour
{
	private sealed class <>c__DisplayClass7_0
	{
		public Action<Games> onSelected;

		public GamesHubItem <>4__this;

		internal void <Populate>b__0()
		{
			//IL_003b: Expected O, but got I
			//IL_004b: Expected O, but got I
			//IL_005b: Expected O, but got I
			GamesHubItem gamesHubItem = <>4__this;
			Action<Games> action = onSelected;
			Games game = gamesHubItem.game;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ X9_v2 (System.Action`1<Games>)+18]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ X9_v2 (System.Action`1<Games>)+40]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ X9_v2 (System.Action`1<Games>)+28]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v31 @ X3_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	private Games game;

	private Button goToButton;

	private GameObject backButton;

	public Games Game => game;

	public bool IsCurrent
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_0109: Expected O, but got I4
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8CC9]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Games currentGame = Preferences.CurrentGame;
			if (currentGame == game)
			{
				goto IL_009e;
			}
			goto IL_014d;
			IL_009e:
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v12+E4]");
			if ((nint)0 != 0)
			{
				return Preferences.HasPreferredGame;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			return Preferences.HasPreferredGame;
			IL_014d:
			return false;
			IL_0074:
			Games currentGame2 = Preferences.CurrentGame;
			if (currentGame2 == game)
			{
				goto IL_009e;
			}
			goto IL_014d;
		}
	}

	public void Populate(Action<Games> onSelected)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0085: Expected O, but got I
		//IL_0186: Expected O, but got I4
		//IL_0123: Expected O, but got I4
		//IL_0211: Expected O, but got I
		//IL_0318: Expected O, but got I4
		//IL_02af: Expected O, but got I4
		//IL_0395: Unknown result type (might be due to invalid IL or missing references)
		//IL_039a: Expected O, but got Unknown
		//IL_03a6: Expected O, but got I
		//IL_03c1: Expected I, but got O
		object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 152;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = onSelected;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 24;
		obj4 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8CC9]");
		object obj6 = (nint)0 & (nint)1;
		if (obj6 != null)
		{
			object obj7 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v41+E4]");
			if ((nint)0 != 0)
			{
				goto IL_00cf;
			}
		}
		else
		{
			_ = 1;
			object obj7 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v41+E4]");
			bool flag = (nint)0 == 0;
			object obj8 = !flag;
			if (obj8 != null)
			{
				goto IL_00cf;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Games currentGame = Preferences.CurrentGame;
		if (currentGame == game)
		{
			goto IL_00f9;
		}
		goto IL_01ca;
		IL_0285:
		object obj9 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X0_v31+E4]");
		bool flag2 = (nint)0 == 0;
		object obj10 = !flag2;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool hasPreferredGame = Preferences.HasPreferredGame;
		bool active = (byte)((hasPreferredGame ? 1u : 0u) ^ 1u) != 0;
		goto IL_036a;
		IL_036a:
		GameObject gameObject;
		gameObject.SetActive(active);
		Button button = goToButton;
		object obj11 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj12 = (nint)0 + (nint)1960;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(obj2, (IntPtr)obj12);
		button.m_OnClick.AddListener(unityAction);
		return;
		IL_01d8:
		bool active2;
		backButton.SetActive(active2);
		gameObject = goToButton.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8CC9]");
		object obj13 = (nint)0 & (nint)1;
		if (obj13 != null)
		{
			object obj14 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X0_v22+E4]");
			if ((nint)0 != 0)
			{
				goto IL_025b;
			}
		}
		else
		{
			_ = 1;
			object obj14 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X0_v22+E4]");
			bool flag3 = (nint)0 == 0;
			object obj15 = !flag3;
			if (obj15 != null)
			{
				goto IL_025b;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Games currentGame2 = Preferences.CurrentGame;
		if (currentGame2 == game)
		{
			goto IL_0285;
		}
		goto IL_035c;
		IL_00cf:
		Games currentGame3 = Preferences.CurrentGame;
		if (currentGame3 == game)
		{
			goto IL_00f9;
		}
		goto IL_01ca;
		IL_01ca:
		active2 = false;
		goto IL_01d8;
		IL_00f9:
		object obj16 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X0_v50+E4]");
		bool flag4 = (nint)0 == 0;
		object obj17 = !flag4;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool hasPreferredGame2 = Preferences.HasPreferredGame;
		active2 = hasPreferredGame2;
		goto IL_01d8;
		IL_025b:
		Games currentGame4 = Preferences.CurrentGame;
		if (currentGame4 == game)
		{
			goto IL_0285;
		}
		goto IL_035c;
		IL_035c:
		active = true;
		goto IL_036a;
	}
}
