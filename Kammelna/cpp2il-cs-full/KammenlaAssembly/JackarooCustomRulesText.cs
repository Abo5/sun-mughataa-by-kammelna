using System;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using TMPro;
using UnityEngine;

public class JackarooCustomRulesText : MonoBehaviour
{
	private TextMeshProUGUI _textMeshPro;

	private const string RuleText = "قواعد";

	private const string KammelnaText = "كملنا";

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_00ce: Expected I, but got O
		//IL_00f8: Expected O, but got I4
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 520;
		object obj2 = (nint)0 + (nint)664;
		object obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 184;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<int, object> action = default(Action<int, object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		JackarooCustomRules.OnJackarooCustomRuleChanged += action;
		int currentJackarooCustomRuleIndex = JackarooCustomRules.CurrentJackarooCustomRuleIndex;
		string currentJackarooCustomRuleName = JackarooCustomRules.CurrentJackarooCustomRuleName;
		string text2;
		if (currentJackarooCustomRuleIndex != 0)
		{
			object obj6 = "{0} color encoding is currently unsupported for outputting to HDR." + 2336;
			string text = (string)obj6 + currentJackarooCustomRuleName;
			text2 = text;
		}
		else
		{
			object obj7 = "{0} color encoding is currently unsupported for outputting to HDR." + 2344;
			text2 = (string)obj7;
		}
		TextMeshProExtensions.FixArabic(_textMeshPro, text2);
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_006a: Expected I, but got O
		//IL_0094: Expected O, but got I4
		object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 520;
		object obj2 = (nint)0 + (nint)664;
		object obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 184;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<int, object> action = default(Action<int, object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		JackarooCustomRules.OnJackarooCustomRuleChanged -= action;
	}

	private void OnCustomRulesChange(int preferredRulesIndex, string preferredRulesName)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		if (preferredRulesIndex != 0)
		{
			object obj = "{0} color encoding is currently unsupported for outputting to HDR." + 2336;
			string text = (string)obj + preferredRulesName;
			TextMeshProExtensions.FixArabic(_textMeshPro, text);
		}
		else
		{
			object text2 = "{0} color encoding is currently unsupported for outputting to HDR." + 2344;
			TextMeshProExtensions.FixArabic(_textMeshPro, (string)text2);
		}
	}
}
