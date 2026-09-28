using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using Cpp2ILInjected;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class OptionListPopup : PopupUI
{
	private const string DELETE_MEMBER_TITLE_KEY = "clan_remove_from_clan";

	private const string DELETE_MEMBER_CONFIRMATION_KEY = "clan_delete_member_confirmation";

	private Button permissionsButton;

	private Button deleteMemberButton;

	private ComponentReference<ClanAdminPermissionsEdit> clanUserPermissionsPopup;

	private ClanUserModel _user;

	public override void Awake()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		//IL_006f: Expected O, but got I
		//IL_0087: Expected I, but got O
		base.Awake();
		Button button = permissionsButton;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)2240;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		button.m_OnClick.AddListener(unityAction);
		Button button2 = deleteMemberButton;
		object obj3 = (nint)0 + (nint)2224;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction2 = default(UnityAction);
		unityAction2..ctor(this, (IntPtr)obj3);
		button2.m_OnClick.AddListener(unityAction2);
	}

	private void OnDestroy()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		//IL_006f: Expected O, but got I
		//IL_0087: Expected I, but got O
		Button button = permissionsButton;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)2240;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		button.m_OnClick.RemoveListener(unityAction);
		Button button2 = deleteMemberButton;
		object obj3 = (nint)0 + (nint)2224;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction2 = default(UnityAction);
		unityAction2..ctor(this, (IntPtr)obj3);
		button2.m_OnClick.RemoveListener(unityAction2);
	}

	public void Initialize(ClanUserModel user)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		object obj = this + 144;
		obj = user;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public void ShowClanUserPermissionsPopup()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_005f: Expected O, but got I
		//IL_0077: Expected I, but got O
		//IL_00a1: Expected O, but got I4
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1424;
		object obj2 = (nint)0 + (nint)2216;
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj4 = (nint)0 + (nint)1880;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80CF4");
	}

	private void ConfirmDeleteMember()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0030: Expected O, but got I
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_033f: Expected I, but got O
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Expected O, but got Unknown
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Expected O, but got Unknown
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Expected O, but got Unknown
		//IL_031d: Expected O, but got I
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected I, but got Unknown
		//IL_008c: Expected O, but got I
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		//IL_00d8: Expected I, but got O
		//IL_00e8: Expected O, but got I
		//IL_0123: Expected O, but got I
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected O, but got Unknown
		//IL_01c1: Expected I, but got O
		//IL_01d1: Expected O, but got I
		//IL_026f: Expected O, but got I
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected O, but got Unknown
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected I, but got Unknown
		//IL_02b8: Expected O, but got I4
		//IL_020c: Expected O, but got I
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected O, but got Unknown
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Expected O, but got Unknown
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8605]");
		nint num = 0;
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)2232;
		object confirmText = "WhiteSmoke" + 1504;
		object cancelText = "COORDINATE_TYPE_GCJ_02" + 1864;
		Action action = default(Action);
		object obj6 = default(object);
		object obj7 = default(object);
		NullReferenceException ex = default(NullReferenceException);
		object obj14 = default(object);
		IntPtr intPtr = default(IntPtr);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			action..ctor(this, (IntPtr)obj2);
			PopupWindowBuilder popupWindowBuilder = PopupWindowBuilder.CreateNegativeConfirm(action, (string)confirmText, (string)cancelText);
			nint num2;
			if (popupWindowBuilder != null)
			{
				num = (nint)("because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3912);
				IPopupWindowBuilderNeedsBody popupWindowBuilderNeedsBody = popupWindowBuilder.Titled((string)num);
				if (popupWindowBuilderNeedsBody != null)
				{
					object obj3 = typeof(System.IOAsyncCallback) + 384;
					object obj4 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3504;
					num2 = (nint)popupWindowBuilderNeedsBody;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X8_v11 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+12E]");
					object obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X8_v11 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_016c;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X8_v11 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+B0]");
					obj6 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X10_v12-8]");
						if (0 == (nint)obj3)
						{
							break;
						}
						obj7 = obj6 + 16;
						obj5--;
						bool flag = (nint)obj5 != 1;
						obj6 = obj7;
						if (flag)
						{
							continue;
						}
						goto IL_016c;
					}
					goto IL_0279;
				}
			}
			goto IL_02ce;
			IL_02ce:
			ex = new NullReferenceException();
			goto IL_02dc;
			IL_02dc:
			object obj8 = obj7 + 9;
			object obj9 = num + obj8;
			object obj10 = obj9 + 312;
			object obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X8_v5+8]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v197 @ X2_v4 (should have been resolved before IL gen)");
			continue;
			IL_024d:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj13 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X0_v11+8]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v247 @ X2_v9 (should have been resolved before IL gen)");
			goto IL_0279;
			IL_0279:
			object obj16 = num2 + obj6;
			num = (nint)(obj16 + 312);
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v188 @ X8_v3 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
			bool flag2 = ex == null;
			object obj17 = !flag2;
			obj7 = obj6;
			if (obj17 != null)
			{
				goto IL_01a5;
			}
			goto IL_02ce;
			IL_016c:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v284 @ X0_v13 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
			bool flag3 = ex == null;
			num = intPtr;
			if (!flag3)
			{
				goto IL_01a5;
			}
			goto IL_02ce;
			IL_01a5:
			object obj18 = typeof(System.IOAsyncCallback) + 368;
			num = (nint)ex;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+12E]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+12E]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+B0]");
				obj7 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X10_v9-8]");
					if (0 == (nint)obj18)
					{
						break;
					}
					obj7 += 16;
					obj19--;
					if ((nint)obj19 != 1)
					{
						continue;
					}
					goto IL_024d;
				}
				goto IL_02dc;
			}
			goto IL_024d;
		}
	}

	private void DeleteMember()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_004f: Expected O, but got I4
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_00a5: Expected O, but got I
		//IL_00bd: Expected I, but got O
		if (_user != null)
		{
			object obj = typeof(Queue<string>) + 728;
			object obj2 = (nint)0 + (nint)1976;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			ClanUserModel user = _user;
			object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
			object obj6 = (nint)0 + (nint)2208;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action<bool> action = default(Action<bool>);
			action..ctor((object)this, (IntPtr)obj6);
			ClanServerConnector clanServerConnector = default(ClanServerConnector);
			clanServerConnector.KickClanMember(user.UserId, action);
		}
	}

	private void <ShowClanUserPermissionsPopup>b__9_0(ClanAdminPermissionsEdit c)
	{
		//IL_0011: Expected O, but got I
		base.HidePopup();
		object obj = (nint)0 + (nint)1144;
		c.Initialize(_user);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D321D8");
		object obj2 = default(object);
		if (obj2 != null)
		{
			SlideAnimationHelper slideAnimationHelper = default(SlideAnimationHelper);
			slideAnimationHelper.SlideIn();
		}
	}

	private void <DeleteMember>b__11_0(bool success)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_0081: Expected O, but got I4
		//IL_000a: Expected I, but got O
		//IL_001a: Expected O, but got I
		//IL_002a: Expected O, but got I
		if (success)
		{
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v6 (Il2CppClass<OptionListPopup>)+198]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v6 (Il2CppClass<OptionListPopup>)+1A0]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v51 @ X2_v2 (should have been resolved before IL gen)");
		}
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object message = "Index = {0} position = {1}" + 1736;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.ShowError((string)message);
	}
}
