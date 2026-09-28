using System;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;

public static class LeaveClanPopups
{
	private const string LEAVE_TITLE_KEY = "leave_clan_title";

	private const string MEMBER_CONFIRM_BODY_KEY = "leave_clan_member_body";

	private const string SOLO_OWNER_CONFIRM_BODY_KEY = "leave_clan_solo_owner_body";

	private const string LEAVE_CONFIRM_BUTTON_KEY = "leave_clan_confirm_button";

	private const string LEAVE_FAILED_CONTENT_KEY = "leave_clan_failed_content";

	public static void ShowMemberConfirm(Action onConfirm)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object bodyKey = "java.io.FileOutputStream" + 2080;
		ShowLeaveConfirm((string)bodyKey, onConfirm);
	}

	public static void ShowSoloOwnerConfirm(Action onConfirm)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object bodyKey = "java.io.FileOutputStream" + 2096;
		ShowLeaveConfirm((string)bodyKey, onConfirm);
	}

	public static void ShowFailure(KammelnaError error)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_00fc: Expected O, but got I4
		//IL_0066: Expected O, but got I4
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected O, but got Unknown
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected O, but got Unknown
		//IL_0171: Expected O, but got I4
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1176;
		object format = "WhiteSmoke" + 3336;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
		object obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj4 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		object arg2 = default(object);
		string text = string.Format((string)format, arg, arg2);
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		object obj7 = text;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj7 = text;
		}
		object input = "java.io.FileOutputStream" + 2104;
		object input2 = "java.io.FileOutputStream" + 2064;
		KLogger.LogError(obj7);
		object obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v9+E4]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string title = LocalizationUtil.Localize((string)input);
		string content = LocalizationUtil.Localize((string)input2);
		PopupWindowBuilder.ShowError(title, content);
	}

	private static void ShowLeaveConfirm(string bodyKey, Action onConfirm)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Expected O, but got Unknown
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Expected O, but got Unknown
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Expected O, but got Unknown
		//IL_03a1: Expected O, but got I4
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Expected O, but got Unknown
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Expected O, but got Unknown
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Expected O, but got Unknown
		//IL_0330: Expected O, but got I
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		//IL_00d5: Expected I, but got O
		//IL_00e5: Expected O, but got I
		//IL_017b: Expected I, but got O
		//IL_0120: Expected O, but got I
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected O, but got Unknown
		//IL_01be: Expected I, but got O
		//IL_01ce: Expected O, but got I
		//IL_026c: Expected O, but got I
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Expected O, but got Unknown
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected O, but got Unknown
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected O, but got Unknown
		//IL_02a7: Expected I, but got O
		//IL_02cb: Expected O, but got I4
		//IL_0209: Expected O, but got I
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected O, but got Unknown
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected O, but got Unknown
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected O, but got Unknown
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected O, but got Unknown
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
		object obj6 = default(object);
		object obj7 = default(object);
		NullReferenceException ex = default(NullReferenceException);
		object obj10 = default(object);
		object obj17 = default(object);
		while (true)
		{
			object input = "java.io.FileOutputStream" + 2056;
			object cancelText = "COORDINATE_TYPE_GCJ_02" + 1864;
			object text = "java.io.FileOutputStream" + 2104;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string confirmText = LocalizationUtil.Localize((string)input);
			PopupWindowBuilder popupWindowBuilder = PopupWindowBuilder.CreateNegativeConfirm(onConfirm, confirmText, (string)cancelText);
			LocalizableText title = TextMeshProExtensions.Localize((string)text);
			nint num2;
			if (popupWindowBuilder != null)
			{
				IPopupWindowBuilderNeedsBody popupWindowBuilderNeedsBody = popupWindowBuilder.Titled(title);
				LocalizableText localizableText = TextMeshProExtensions.Localize(bodyKey);
				if (popupWindowBuilderNeedsBody != null)
				{
					object obj4 = typeof(System.IOAsyncCallback) + 384;
					num2 = (nint)popupWindowBuilderNeedsBody;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X8_v10 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+12E]");
					object obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X8_v10 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0169;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X8_v10 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+B0]");
					obj6 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X10_v12-8]");
						if (0 == (nint)obj4)
						{
							break;
						}
						obj7 = obj6 + 16;
						obj5--;
						bool flag2 = (nint)obj5 != 1;
						obj6 = obj7;
						if (flag2)
						{
							continue;
						}
						goto IL_0169;
					}
					goto IL_0276;
				}
			}
			goto IL_02e1;
			IL_01a2:
			object obj8 = typeof(System.IOAsyncCallback) + 368;
			num = (nint)ex;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+12E]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+12E]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+B0]");
				obj7 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X10_v9-8]");
					if (0 == (nint)obj8)
					{
						break;
					}
					obj7 += 16;
					obj9--;
					if ((nint)obj9 != 1)
					{
						continue;
					}
					goto IL_024a;
				}
				goto IL_02ef;
			}
			goto IL_024a;
			IL_0169:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num = (nint)obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v285 @ X0_v21] (should have been resolved before IL gen)");
			if (ex != null)
			{
				goto IL_01a2;
			}
			goto IL_02e1;
			IL_02e1:
			ex = new NullReferenceException();
			goto IL_02ef;
			IL_02ef:
			object obj11 = obj7 + 9;
			object obj12 = num + obj11;
			object obj13 = obj12 + 312;
			object obj14 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v6+8]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v205 @ X2_v3 (should have been resolved before IL gen)");
			continue;
			IL_024a:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj16 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X0_v18+8]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v246 @ X2_v8 (should have been resolved before IL gen)");
			goto IL_0276;
			IL_0276:
			object obj19 = obj6 + 1;
			object obj20 = num2 + obj19;
			object obj21 = obj20 + 312;
			num = (nint)obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v301 @ X0_v24] (should have been resolved before IL gen)");
			bool flag3 = ex == null;
			object obj22 = !flag3;
			obj7 = obj6;
			if (obj22 != null)
			{
				goto IL_01a2;
			}
			goto IL_02e1;
		}
	}
}
