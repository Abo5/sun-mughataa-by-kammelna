using System;
using System.Data;
using System.Data.SqlTypes;
using System.Globalization;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Features.GameReplay;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using UnityEngine;

public class DatePickerManager : ScriptableObject
{
	private GameObject kDateTimePrefab;

	private GameObject kTimeOnlyPrefab;

	private InputFieldTMProUGUI _inputField;

	private GameObject picker;

	public void PickDateTime(InputFieldTMProUGUI inputField, DateTime defaultTime, IPicker.PickerMode mode = IPicker.PickerMode.Normal)
	{
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected O, but got Unknown
		//IL_01d0: Expected O, but got I4
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		//IL_01fa: Expected O, but got I
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_0149: Expected O, but got I4
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_007b: Expected O, but got I
		//IL_00b2: Expected O, but got I4
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_0195: Expected O, but got I4
		object obj = this + 40;
		InputFieldTMProUGUI inputFieldTMProUGUI = default(InputFieldTMProUGUI);
		obj = inputFieldTMProUGUI;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = 152989696;
		object obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7627]");
		object obj4 = (nint)0 & (nint)1;
		object obj5;
		object caller;
		if (obj4 != null)
		{
			obj5 = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 2848;
			object obj6 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			caller = obj5;
			if (!flag)
			{
				goto IL_0049;
			}
		}
		else
		{
			_ = 1;
			obj5 = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 2848;
			object obj6 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			caller = obj5;
			if (obj7 != null)
			{
				goto IL_0049;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		GameObject secondaryCanvas = KUtil.GetSecondaryCanvas((string)caller);
		bool flag3 = (object)secondaryCanvas == null;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_005b;
		IL_0049:
		secondaryCanvas = KUtil.GetSecondaryCanvas((string)obj5);
		goto IL_005b;
		IL_005b:
		object obj9 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj10 = (nint)0 + (nint)544;
		Transform transform = secondaryCanvas.transform;
		object obj11 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v19+E4]");
		bool flag4 = (nint)0 == 0;
		object obj12 = !flag4;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
		object obj13 = this + 48;
		object obj14 = default(object);
		obj13 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		StartThePicker(defaultTime, mode);
	}

	public void PickFromHours(InputFieldTMProUGUI inputField, DateTime defaultTime, IPicker.PickerMode mode)
	{
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected O, but got Unknown
		//IL_01d0: Expected O, but got I4
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		//IL_01fa: Expected O, but got I
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_0149: Expected O, but got I4
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_007b: Expected O, but got I
		//IL_00b2: Expected O, but got I4
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_0195: Expected O, but got I4
		object obj = this + 40;
		InputFieldTMProUGUI inputFieldTMProUGUI = default(InputFieldTMProUGUI);
		obj = inputFieldTMProUGUI;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = 152989696;
		object obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7627]");
		object obj4 = (nint)0 & (nint)1;
		object obj5;
		object caller;
		if (obj4 != null)
		{
			obj5 = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 2848;
			object obj6 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			caller = obj5;
			if (!flag)
			{
				goto IL_0049;
			}
		}
		else
		{
			_ = 1;
			obj5 = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 2848;
			object obj6 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			caller = obj5;
			if (obj7 != null)
			{
				goto IL_0049;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		GameObject secondaryCanvas = KUtil.GetSecondaryCanvas((string)caller);
		bool flag3 = (object)secondaryCanvas == null;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_005b;
		IL_0049:
		secondaryCanvas = KUtil.GetSecondaryCanvas((string)obj5);
		goto IL_005b;
		IL_005b:
		object obj9 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj10 = (nint)0 + (nint)544;
		Transform transform = secondaryCanvas.transform;
		object obj11 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v19+E4]");
		bool flag4 = (nint)0 == 0;
		object obj12 = !flag4;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
		object obj13 = this + 48;
		object obj14 = default(object);
		obj13 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		StartThePicker(defaultTime, mode);
	}

	private static Transform GetPopupsCanvas()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_010f: Expected O, but got I4
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_015b: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7627]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object caller;
		if (obj3 != null)
		{
			obj4 = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 2848;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			caller = obj4;
			if (!flag)
			{
				goto IL_0094;
			}
		}
		else
		{
			_ = 1;
			obj4 = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 2848;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			caller = obj4;
			if (obj6 != null)
			{
				goto IL_0094;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		GameObject secondaryCanvas = KUtil.GetSecondaryCanvas((string)caller);
		bool flag3 = (object)secondaryCanvas == null;
		object obj7 = !flag3;
		if (obj7 != null)
		{
			goto IL_00be;
		}
		goto IL_0169;
		IL_00be:
		return secondaryCanvas.transform;
		IL_0169:
		return (Transform)(object)new NullReferenceException();
		IL_0094:
		secondaryCanvas = KUtil.GetSecondaryCanvas((string)obj4);
		if ((object)secondaryCanvas != null)
		{
			goto IL_00be;
		}
		goto IL_0169;
	}

	private void StartThePicker(DateTime defaultTime, IPicker.PickerMode mode)
	{
		//IL_0026: Expected O, but got I
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_0061: Expected O, but got I
		//IL_00f7: Expected O, but got I
		//IL_0127: Expected O, but got I4
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected O, but got Unknown
		//IL_019e: Expected O, but got I
		//IL_009c: Expected O, but got I
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected O, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_0165: Expected O, but got I
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_038a: Expected O, but got I4
		//IL_0297: Expected O, but got I
		//IL_0256: Expected O, but got I4
		//IL_03d0: Expected O, but got I
		//IL_02d2: Expected O, but got I
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Expected O, but got Unknown
		//IL_0346: Unknown result type (might be due to invalid IL or missing references)
		//IL_034b: Expected O, but got Unknown
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Expected O, but got Unknown
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Expected O, but got Unknown
		picker.SetActive(value: false);
		object obj = (nint)0 + (nint)1288;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
		object obj2 = typeof(System.IOAsyncCallback) + 248;
		object obj4 = default(object);
		object obj3 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v4+12E]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v4+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00dd;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v4+B0]");
		object obj6 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X10_v12-8]");
			if (0 == (nint)obj2)
			{
				break;
			}
			obj6 += 16;
			obj5--;
			if ((nint)obj5 != 1)
			{
				continue;
			}
			goto IL_00dd;
		}
		object obj7 = obj3 + obj6;
		object obj8 = obj7 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v19+8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v147 @ X8_v19] (should have been resolved before IL gen)");
		GameObject gameObject = picker;
		goto IL_017e;
		IL_017e:
		object obj10 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 1952;
		object obj11 = (nint)0 + (nint)3680;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X22_v6+8]");
		_ = 0;
		object obj14 = default(object);
		object obj13 = obj14 + 32;
		obj13 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18CC");
		object obj15 = default(object);
		if (obj15 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X22_v6+52]");
			if ((nint)0 == 1)
			{
				object obj16 = 35885056 + 3676;
				goto IL_037b;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X0_v10+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X0_v10+20]");
		_ = 0;
		goto IL_037b;
		IL_0313:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_03b8;
		IL_037b:
		object obj17 = 35885056 + 3592;
		object obj19 = default(object);
		object obj18 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X8_v10+12E]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X8_v10+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0313;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X8_v10+B0]");
		object obj21 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X10_v7-8]");
			if (0 == (nint)obj2)
			{
				break;
			}
			obj21 += 16;
			obj20--;
			if ((nint)obj20 != 1)
			{
				continue;
			}
			goto IL_0313;
		}
		object obj22 = obj21 + 2;
		object obj23 = obj18 + obj22;
		object obj24 = obj23 + 312;
		goto IL_03b8;
		IL_03b8:
		object obj25 = obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X0_v15+8]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v170 @ X3_v3 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
		IL_00dd:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X0_v20+8]");
		obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v237 @ X0_v20] (should have been resolved before IL gen)");
		gameObject = picker;
		bool flag = (object)picker == null;
		object obj27 = !flag;
		if (obj27 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_017e;
	}

	private void PickDateTimeEnded(DateTime t)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Expected O, but got Unknown
		//IL_034d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Expected O, but got Unknown
		//IL_037c: Expected O, but got I4
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_006a: Expected O, but got I4
		//IL_00bf: Expected O, but got I
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		//IL_00df: Expected O, but got I
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_0399: Expected O, but got I4
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected O, but got Unknown
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected O, but got Unknown
		//IL_01f4: Expected O, but got I
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected O, but got Unknown
		//IL_0220: Expected O, but got I
		//IL_0197: Expected O, but got I4
		//IL_03fa: Expected I, but got O
		//IL_025b: Expected O, but got I
		//IL_0303: Expected O, but got I4
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Expected O, but got Unknown
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Expected O, but got Unknown
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Expected O, but got Unknown
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected O, but got Unknown
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3632;
		object obj2 = typeof(DataRelation) + 712;
		object obj3 = this + 40;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj6 = "utf-32" + 2808;
		CultureInfo invariantCulture = CultureInfo.InvariantCulture;
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime dateTime = default(DateTime);
		string text = dateTime.ToString((string)obj6, invariantCulture);
		((InputFieldTMProUGUI)obj3).Text = text;
		object obj9 = (nint)0 + (nint)1288;
		object obj10 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 1952;
		object obj11 = (nint)0 + (nint)3680;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X23_v6+8]");
		_ = 0;
		object obj14 = default(object);
		object obj13 = obj14 + 32;
		obj13 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18CC");
		object obj15 = default(object);
		if (obj15 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X23_v6+52]");
			if ((nint)0 == 1)
			{
				object obj16 = 35885056 + 3676;
				goto IL_038a;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X0_v16+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X0_v16+20]");
		_ = 0;
		goto IL_038a;
		IL_029c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_03c7;
		IL_038a:
		object obj17 = 35885056 + 3592;
		object obj18 = typeof(System.IOAsyncCallback) + 248;
		object obj19 = typeof(SqlSingle[]) + 2376;
		object obj20 = (nint)0 + (nint)3672;
		object obj21 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		object obj23 = default(object);
		object obj22 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v14+12E]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v14+12E]");
		if ((nint)0 == 0)
		{
			goto IL_029c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v14+B0]");
		object obj25 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X10_v5-8]");
			if (0 == (nint)obj18)
			{
				break;
			}
			obj25 += 16;
			obj24--;
			if ((nint)obj24 != 1)
			{
				continue;
			}
			goto IL_029c;
		}
		object obj26 = obj25 + 3;
		object obj27 = obj22 + obj26;
		object obj28 = obj27 + 312;
		goto IL_03c7;
		IL_03c7:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v327 @ X0_v21] (should have been resolved before IL gen)");
		_inputField = null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj20);
		object obj29 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X0_v28+E4]");
		bool flag3 = (nint)0 == 0;
		object obj30 = !flag3;
		if (obj30 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Coroutine coroutine = CoroutineDummy.WaitForSeconds(0.8f, action);
	}

	private void <PickDateTimeEnded>b__8_0()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00c2: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7586]");
		object obj2 = (nint)0 & (nint)1;
		UnityEngine.Object obj4;
		UnityEngine.Object obj5;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			obj4 = picker;
			obj5 = picker;
			if (!flag)
			{
				goto IL_0088;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v1+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			obj4 = picker;
			obj5 = picker;
			if (obj6 != null)
			{
				goto IL_0088;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object.Destroy(obj5);
		return;
		IL_0088:
		UnityEngine.Object.Destroy(obj4);
	}
}
