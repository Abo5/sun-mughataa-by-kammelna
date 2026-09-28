using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected;
using Jackaroo;
using UnityEngine;

public class JackarooCustomRulesPreview : MonoBehaviour
{
	private List<JackarooCustomRuleUI> _jackarooCustomRulesUis;

	private PopupUI popup;

	private bool isSetup;

	private void Setup()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_0026: Expected O, but got I
		//IL_0049: Expected I, but got O
		if (!isSetup)
		{
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2456;
			object obj2 = (nint)0 + (nint)656;
			isSetup = true;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action<object> action = default(Action<object>);
			action..ctor((object)this, (IntPtr)obj2);
			((List<object>)(object)_jackarooCustomRulesUis).ForEach(action);
		}
	}

	public void Populate(JackarooAllowedRules jackarooAllowedRules)
	{
		Setup();
		LoadRules(_jackarooCustomRulesUis, jackarooAllowedRules);
		popup.PopFromParent(1f);
	}

	private static void LoadRules(List<JackarooCustomRuleUI> jackarooCustomRulesUis, JackarooAllowedRules rules)
	{
		//IL_0018: Expected O, but got I4
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected I4, but got Unknown
		//IL_01aa: Expected O, but got I
		//IL_01cf: Expected O, but got I
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		//IL_02e2: Expected O, but got I
		//IL_0238: Expected O, but got I
		//IL_033a: Expected O, but got I
		//IL_035c: Expected O, but got I4
		//IL_00f8: Expected O, but got I4
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected I4, but got Unknown
		//IL_0283: Expected O, but got I
		//IL_02b7: Expected O, but got I
		//IL_02cd: Expected O, but got I
		List<int> activeRulesIndices = JackarooAllowedRulesExtensions.GetActiveRulesIndices(rules);
		if (jackarooCustomRulesUis != null)
		{
			object obj = jackarooCustomRulesUis._size - 1;
			bool flag = (nint)obj < 0;
			int num = jackarooCustomRulesUis._size ^ 1;
			int num2 = jackarooCustomRulesUis._size ^ obj;
			int num3 = num & num2;
			bool flag2 = num3 < 0;
			if (activeRulesIndices == null)
			{
				if (flag != flag2)
				{
					return;
				}
				object obj2 = ((List<object>)(object)jackarooCustomRulesUis).get_Item(0);
				throw new NullReferenceException();
			}
			if (jackarooCustomRulesUis._size < 1)
			{
				return;
			}
			int num4 = 0;
			int num5 = 0;
			while (true)
			{
				object obj3 = ((List<object>)(object)jackarooCustomRulesUis).get_Item(num4);
				if (obj3 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v13 (System.Object)+2C]");
				object obj4 = -1;
				flag = (nint)obj4 < 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v13 (System.Object)+2C]");
				object obj5 = (nint)0 ^ (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v13 (System.Object)+2C]");
				object obj6 = 0 ^ obj4;
				object obj7 = obj5 & obj6;
				flag2 = (nint)obj7 < 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v13 (System.Object)+2C]");
				TwinSlidedKDropMenu twinSlidedKDropMenu;
				if ((nint)0 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v13 (System.Object)+58]");
					twinSlidedKDropMenu = (TwinSlidedKDropMenu)0;
					int selectedIndex = activeRulesIndices.get_Item(num5);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v13 (System.Object)+58]");
					if ((nint)0 == 0)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v13 (System.Object)+58]");
					((TwinSlidedKDropMenu)0).SetSelectedIndex(selectedIndex);
					num5++;
					int selectedIndex2 = activeRulesIndices.get_Item(num5);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v13 (System.Object)+58]");
					((TwinSlidedKDropMenu)0).SetSelectedIndex2(selectedIndex2);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v13 (System.Object)+58]");
					((TwinSlidedKDropMenu)0).ResetClicks();
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v13 (System.Object)+50]");
					object obj8 = 0;
					int num6 = activeRulesIndices.get_Item(num5);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v13 (System.Object)+50]");
					if ((nint)0 == 0)
					{
						break;
					}
					object obj9 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v154 @ X8_v11+1E8] (should have been resolved before IL gen)");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v13 (System.Object)+50]");
					twinSlidedKDropMenu = (TwinSlidedKDropMenu)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v13 (System.Object)+50]");
					bool flag3 = (nint)0 == 0;
					object obj10 = !flag3;
					if (obj10 == null)
					{
						break;
					}
				}
				((BaseDropMenu<object>)(object)twinSlidedKDropMenu).Hide();
				num5++;
				num4++;
				object obj11 = num4 - jackarooCustomRulesUis._size;
				flag = (nint)obj11 < 0;
				int num7 = num4 ^ jackarooCustomRulesUis._size;
				int num8 = num4 ^ obj11;
				int num9 = num7 & num8;
				flag2 = num9 < 0;
				if (num4 < jackarooCustomRulesUis._size)
				{
					continue;
				}
				return;
			}
		}
		throw new NullReferenceException();
	}

	private void <Setup>b__3_0(JackarooCustomRuleUI rules)
	{
		rules.Initialize(_jackarooCustomRulesUis);
	}
}
