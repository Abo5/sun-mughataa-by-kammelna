using System;
using System.Buffers.Text;
using System.Diagnostics;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Kammelna.Server.Models.Clans;
using TMPro;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class HintText : MonoBehaviour
{
	private TextMeshProUGUI textMesh;

	private void Start()
	{
		//IL_000c: Expected O, but got I
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		object obj = (nint)0 + (nint)152;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj2 = this + 32;
		object obj3 = default(object);
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		UIExtensions.SetAlpha((Graphic)obj2, 0f);
		LoadRandomHint();
	}

	public void LoadRandomHint()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00f7: Expected O, but got I4
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
		//IL_0174: Expected O, but got I
		//IL_0180: Expected O, but got I
		//IL_01ce: Expected I, but got O
		//IL_0146: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7A1C]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v10+E4]");
			bool flag = (nint)0 == 0;
			obj5 = textMesh;
			obj6 = textMesh;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = textMesh;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v10+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = textMesh;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6 == null;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 != null)
		{
			return;
		}
		goto IL_0154;
		IL_0154:
		object obj9 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		object obj10 = (nint)0 + (nint)1480;
		object obj11 = (nint)0 + (nint)2456;
		int num = ShortcutExtensions.DOKill(textMesh);
		TweenerCore<Color, Color, ColorOptions> tweenerCore = ShortcutExtensionsTMPText.DOFade(textMesh, 0f, 0.5f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(this, (IntPtr)obj10);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
		return;
		IL_0091:
		if (obj5 == null)
		{
			return;
		}
		goto IL_0154;
	}

	private void SetHintText(string text)
	{
		TextMeshProExtensions.FixArabic(textMesh, text);
		TweenerCore<Color, Color, ColorOptions> tweenerCore = ShortcutExtensionsTMPText.DOFade(textMesh, 1f, 0.5f);
	}

	private void <LoadRandomHint>b__2_0()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_007a: Expected O, but got I
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_009a: Expected O, but got I
		//IL_00c4: Expected O, but got I4
		//IL_005b: Expected I, but got O
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		object obj2 = (nint)0 + (nint)2744;
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj4 = (nint)0 + (nint)1488;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Games currentGame = Preferences.CurrentGame;
		System.Int32Enum? game = (System.Int32Enum)currentGame;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj4);
		TipManager.RequestLoadingTip((Games?)game, action);
	}
}
