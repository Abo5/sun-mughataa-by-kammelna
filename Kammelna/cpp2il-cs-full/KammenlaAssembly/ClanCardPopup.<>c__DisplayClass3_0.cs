using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using GoogleMobileAds.Ump.Api;
using UnityEngine;

public class ClanCardPopup : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<ClanModel> <>9__2_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(CardUtils.<>c) + 504;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <Show>b__2_0(ClanModel model)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			if (model != null)
			{
				object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1136;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
				if ((nint)0 != 0)
				{
					Show(model);
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Show(model);
			}
		}
	}

	private sealed class <>c__DisplayClass3_0
	{
		public ClanModel model;

		internal void <Show>b__0(ClanCardPopup c)
		{
			//IL_0011: Expected O, but got I
			object obj = (nint)0 + (nint)4008;
			c.card.Initialize(model);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
			PopupUI popupUI = default(PopupUI);
			popupUI.PopFromCenter();
		}
	}

	private static readonly AddressReference<ClanCardPopup> Address;

	private ClanCard card;

	public static void Show(int clanId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_023c: Expected O, but got I
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected O, but got Unknown
		//IL_010a: Expected O, but got I4
		//IL_0078: Expected O, but got I
		//IL_0088: Expected O, but got I
		//IL_0152: Expected O, but got I
		//IL_0162: Expected O, but got I
		//IL_0184: Expected O, but got I4
		//IL_01bc: Expected O, but got I4
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected O, but got Unknown
		//IL_02a7: Expected O, but got I
		//IL_02b8: Expected I, but got O
		//IL_02d6: Expected O, but got I
		//IL_020b: Expected O, but got I4
		//IL_01ec: Expected O, but got I
		object obj = typeof(Queue<string>) + 728;
		object obj2 = (nint)0 + (nint)1976;
		object obj3 = typeof(CardUtils.<>c) + 504;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2+E4]");
		ClanServerConnector clanServerConnector;
		ClanServerConnector clanServerConnector3;
		object obj5;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			ClanServerConnector clanServerConnector2 = default(ClanServerConnector);
			clanServerConnector = clanServerConnector2;
			object obj6 = obj5;
			clanServerConnector3 = clanServerConnector2;
			if (!flag)
			{
				goto IL_0068;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X0_v5+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			ClanServerConnector clanServerConnector4 = default(ClanServerConnector);
			clanServerConnector = clanServerConnector4;
			object obj6 = obj5;
			clanServerConnector3 = clanServerConnector4;
			if (obj7 != null)
			{
				goto IL_0068;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X0_v5+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v6+8]");
		Action<ClanModel> callback = (Action<ClanModel>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v6+8]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		clanServerConnector = clanServerConnector3;
		if (obj9 != null)
		{
			goto IL_00b5;
		}
		goto IL_019a;
		IL_00b5:
		clanServerConnector.GetClan(clanId, callback);
		return;
		IL_019a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X0_v5+E4]");
		bool flag4 = (nint)0 == 0;
		object obj10 = !flag4;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj11 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v12+B8]");
			obj8 = 0;
		}
		object obj12 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1552;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj13 = (nint)0 + (nint)3368;
		Action<object> action = default(Action<object>);
		action..ctor(obj8, (IntPtr)obj13);
		object obj14 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v11+B8]");
		object obj15 = (nint)0 + (nint)8;
		obj15 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool flag5 = (object)clanServerConnector3 == null;
		object obj16 = !flag5;
		clanServerConnector = clanServerConnector3;
		callback = action;
		if (obj16 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00b5;
		IL_0068:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X0_v5+B8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v6+8]");
		callback = (Action<ClanModel>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v6+8]");
		bool flag6 = (nint)0 == 0;
		clanServerConnector3 = clanServerConnector;
		if (!flag6)
		{
			goto IL_00b5;
		}
		goto IL_019a;
	}

	public static void Show(ClanModel model)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004d: Expected O, but got I
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_00ab: Expected O, but got I4
		//IL_010e: Expected O, but got I
		//IL_011e: Expected O, but got I
		//IL_0139: Expected I, but got O
		//IL_0163: Expected O, but got I4
		object obj = typeof(CardUtils.<>c) + 512;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1136;
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1440;
		object obj5 = (nint)0 + (nint)3376;
		object obj6 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj7 = obj2 + 16;
		obj7 = model;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v9+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = obj3;
		}
		object obj10 = (nint)0 + (nint)1896;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v9+B8]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj5);
		object obj12 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v12+E4]");
		bool flag2 = (nint)0 == 0;
		object obj13 = !flag2;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80C64");
	}

	public void Initialize(ClanModel model)
	{
		//IL_0011: Expected O, but got I
		object obj = (nint)0 + (nint)4008;
		ClanModel clan = default(ClanModel);
		card.Initialize(clan);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		PopupUI popupUI = default(PopupUI);
		popupUI.PopFromCenter();
	}

	static ClanCardPopup()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		object obj = "Cannot populate JSON object onto type '{0}'." + 2856;
		object obj2 = typeof(ConsentForm.<Show>c__AnonStorey2.<Show>c__AnonStorey3) + 3016;
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1136;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4933C3C");
		object obj4 = obj3;
		object obj6 = default(object);
		object obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
