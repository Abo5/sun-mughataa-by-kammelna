using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Threading;
using Cpp2ILInjected;
using Kammelna.Server;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models;
using Sfs2X.Entities;
using Sfs2X.Entities.Data;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;
using Util;

public class MassModerationWidget : MassWidget
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<ISFSObject> <>9__3_1;

		public static Action<ISFSObject> <>9__10_1;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 2944;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <OnExtendStageSubmit>b__3_1(ISFSObject response)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ab: Expected O, but got Unknown
			//IL_00d5: Expected O, but got I4
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Expected O, but got Unknown
			//IL_0066: Expected O, but got I4
			//IL_0096: Expected O, but got I4
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object message = "Picking audio files is not supported on iOS" + 320;
			PopupWindow.DismissMessage();
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v5+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Toast.Show((string)message, (Vector2)0, 0f);
		}

		internal void <OnFindTournamentSubmit>b__10_1(ISFSObject response)
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b8: Expected O, but got Unknown
			//IL_00e2: Expected O, but got I4
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Expected O, but got Unknown
			object obj = 152989696;
			object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7799]");
			object obj3 = (nint)0 & (nint)1;
			object obj4;
			object msgBody;
			if (obj3 != null)
			{
				obj4 = "LAK" + 2136;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v1+E4]");
				bool flag = (nint)0 == 0;
				msgBody = obj4;
				if (!flag)
				{
					goto IL_0094;
				}
			}
			else
			{
				_ = 1;
				obj4 = "LAK" + 2136;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v1+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				msgBody = obj4;
				if (obj6 != null)
				{
					goto IL_0094;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			PopupWindow.ShowLoading((string)msgBody, dismissible: false);
			return;
			IL_0094:
			PopupWindow.ShowLoading((string)obj4, dismissible: false);
		}
	}

	private sealed class <>c__DisplayClass10_0
	{
		public string tournamentName;

		internal void <OnFindTournamentSubmit>b__0(ISFSObject param)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			//IL_0042: Expected I, but got O
			//IL_0052: Expected O, but got I
			//IL_0147: Expected O, but got I
			//IL_008d: Expected O, but got I
			//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00eb: Expected O, but got Unknown
			//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f8: Expected O, but got Unknown
			//IL_0101: Unknown result type (might be due to invalid IL or missing references)
			//IL_0106: Expected O, but got Unknown
			//IL_009b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a0: Expected O, but got Unknown
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ae: Expected O, but got Unknown
			object obj = typeof(System.IOAsyncCallback) + 976;
			object obj2 = "startPosition" + 3448;
			string text = tournamentName;
			object obj3 = obj2;
			nint num = (nint)param;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00ce;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
			object obj5 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X10_v5-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj5 += 16;
				obj4--;
				if ((nint)obj4 != 1)
				{
					continue;
				}
				goto IL_00ce;
			}
			object obj6 = obj5 + 39;
			object obj7 = num + obj6;
			object obj8 = obj7 + 312;
			goto IL_012f;
			IL_00ce:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_012f;
			IL_012f:
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X0_v3+8]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v126 @ X4_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	private sealed class <>c__DisplayClass11_0
	{
		public Action<ISFSObject> onSuccess;

		internal void <SendMassRequest>b__0(ISFSObject response)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			//IL_0030: Expected I, but got O
			//IL_0040: Expected O, but got I
			//IL_007b: Expected O, but got I
			//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fc: Expected O, but got Unknown
			//IL_0120: Unknown result type (might be due to invalid IL or missing references)
			//IL_0125: Expected O, but got Unknown
			//IL_01f1: Expected O, but got I
			//IL_0201: Expected O, but got I
			//IL_0211: Expected O, but got I
			//IL_0166: Unknown result type (might be due to invalid IL or missing references)
			//IL_016b: Expected O, but got Unknown
			//IL_0173: Unknown result type (might be due to invalid IL or missing references)
			//IL_0178: Expected O, but got Unknown
			//IL_0181: Unknown result type (might be due to invalid IL or missing references)
			//IL_0186: Expected O, but got Unknown
			//IL_01aa: Expected O, but got I4
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_008e: Expected O, but got Unknown
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Expected O, but got Unknown
			object obj = typeof(System.IOAsyncCallback) + 976;
			object varName = "destinationTimeZone" + 2696;
			nint num = (nint)response;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00bc;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
			object obj3 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X10_v6-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj3 += 16;
				obj2--;
				if ((nint)obj2 != 1)
				{
					continue;
				}
				goto IL_00bc;
			}
			object obj4 = obj3 + 1;
			object obj5 = num + obj4;
			object obj6 = obj5 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v225 @ X0_v15] (should have been resolved before IL gen)");
			object obj7 = default(object);
			bool flag = obj7 == null;
			object obj8 = !flag;
			if (obj8 != null)
			{
				goto IL_00ed;
			}
			goto IL_01b8;
			IL_00bc:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v100 @ X0_v12] (should have been resolved before IL gen)");
			object obj9 = default(object);
			if (obj9 != null)
			{
				goto IL_00ed;
			}
			goto IL_01b8;
			IL_01b8:
			Action<ISFSObject> action = onSuccess;
			if (onSuccess != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v7 (System.Action`1<Sfs2X.Entities.Data.ISFSObject>)+18]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v7 (System.Action`1<Sfs2X.Entities.Data.ISFSObject>)+40]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v7 (System.Action`1<Sfs2X.Entities.Data.ISFSObject>)+28]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v140 @ X3_v1 (should have been resolved before IL gen)");
				goto IL_021b;
			}
			return;
			IL_021b:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			string message = default(string);
			PopupWindow.ShowError(message);
			return;
			IL_00ed:
			object defaultValue = "UInt16" + 3176;
			message = SFSExtensions.Get(response, (string)varName, (string)defaultValue);
			object obj13 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			object obj14 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v13+E4]");
			if ((nint)0 != 0)
			{
				PopupWindow.ShowError(message);
				return;
			}
			goto IL_021b;
		}
	}

	private sealed class <>c__DisplayClass3_0
	{
		public int minutes;

		internal void <OnExtendStageSubmit>b__0(ISFSObject param)
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "destinationTimeZone" + 1888;
			SFSExtensions.Put(param, (string)key, minutes);
		}
	}

	private sealed class <>c__DisplayClass7_0
	{
		public MassModerationWidget <>4__this;

		public int clusterAction;

		internal void <ConfirmClusterAction>b__0()
		{
			<>4__this.OnClusterAction(clusterAction);
		}
	}

	private sealed class <>c__DisplayClass8_0
	{
		public int clusterAction;

		internal void <OnClusterAction>b__0(ISFSObject param)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			//IL_0042: Expected I, but got O
			//IL_0052: Expected O, but got I
			//IL_0147: Expected O, but got I
			//IL_008d: Expected O, but got I
			//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00eb: Expected O, but got Unknown
			//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f8: Expected O, but got Unknown
			//IL_0101: Unknown result type (might be due to invalid IL or missing references)
			//IL_0106: Expected O, but got Unknown
			//IL_009b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a0: Expected O, but got Unknown
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ae: Expected O, but got Unknown
			object obj = typeof(System.IOAsyncCallback) + 976;
			object obj2 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 2048;
			int num = clusterAction;
			object obj3 = obj2;
			nint num2 = (nint)param;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00ce;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
			object obj5 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X10_v5-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj5 += 16;
				obj4--;
				if ((nint)obj4 != 1)
				{
					continue;
				}
				goto IL_00ce;
			}
			object obj6 = obj5 + 35;
			object obj7 = num2 + obj6;
			object obj8 = obj7 + 312;
			goto IL_012f;
			IL_00ce:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_012f;
			IL_012f:
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X0_v3+8]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v126 @ X4_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}

		internal void <OnClusterAction>b__1(ISFSObject response)
		{
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Expected O, but got Unknown
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0082: Expected O, but got Unknown
			//IL_0091: Unknown result type (might be due to invalid IL or missing references)
			//IL_0096: Expected O, but got Unknown
			//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00aa: Expected O, but got Unknown
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			//IL_01a9: Expected O, but got I4
			//IL_01b2: Expected O, but got I4
			//IL_011b: Expected O, but got I4
			//IL_0144: Expected O, but got I4
			if (clusterAction == 1)
			{
				object obj = typeof(System.Buffers.Text.ParserHelpers) + 1432;
				object msgBody = "LAK" + 2136;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v13+E4]");
				if ((nint)0 != 0)
				{
					PopupWindow.ShowLoading((string)msgBody, dismissible: false);
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				PopupWindow.ShowLoading((string)msgBody, dismissible: false);
				return;
			}
			object obj3 = "Cannot populate JSON object onto type '{0}'." + 3376;
			object obj4 = "Cannot populate JSON object onto type '{0}'." + 3368;
			object obj5 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
			object obj6 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
			object input = ((clusterAction != 2) ? obj4 : obj3);
			object obj7 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X0_v2+E4]");
			string text;
			string text2;
			if ((nint)0 != 0)
			{
				text = LocalizationUtil.Localize((string)input);
				object obj8 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v6+E4]");
				bool flag = (nint)0 == 0;
				object obj9 = 0;
				text2 = text;
				if (!flag)
				{
					goto IL_0131;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				text = LocalizationUtil.Localize((string)input);
				object obj8 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v6+E4]");
				bool flag2 = (nint)0 == 0;
				object obj10 = !flag2;
				object obj9 = 0;
				text2 = text;
				if (obj10 != null)
				{
					goto IL_0131;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			text = text2;
			goto IL_0131;
			IL_0131:
			Toast.Show(text, (Vector2)0, 0f);
		}
	}

	private GameObject content;

	protected override void Initialize()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00ee: Expected O, but got I
		//IL_0122: Expected O, but got I4
		//IL_00c9: Expected O, but got I4
		//IL_005c: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E778F]");
		object obj3 = (nint)0 & (nint)1;
		GameObject gameObject;
		GameObject gameObject2;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			gameObject = content;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v7+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj4;
			gameObject2 = content;
			if (!flag)
			{
				goto IL_00a5;
			}
		}
		else
		{
			_ = 1;
			object obj4 = (nint)0 + (nint)2200;
			gameObject = content;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			gameObject2 = content;
			if (obj7 != null)
			{
				goto IL_00a5;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		gameObject = gameObject2;
		goto IL_0168;
		IL_0168:
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		bool active = SFSKammelnaUserExtensions.Can(localUser, UserPermission.ManageMassTournament);
		gameObject.SetActive(active);
		return;
		IL_00a5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag3 = (object)sessionModel == null;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0168;
	}

	public void ShowExtendStage()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0169: Expected I, but got O
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0055: Expected I, but got O
		//IL_0065: Expected O, but got I
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected O, but got Unknown
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected O, but got Unknown
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected O, but got Unknown
		//IL_01f3: Expected O, but got I4
		//IL_00a0: Expected O, but got I
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj2 = (nint)0 + (nint)3168;
		IPopupWindowBuilderInput popupWindowBuilderInput = PopupInput.OfType(InputField.ContentType.IntegerNumber);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj3 = typeof(System.IOAsyncCallback) + 376;
		object obj4 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		nint num = (nint)popupWindowBuilderInput;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v5 (Il2CppClass<IPopupWindowBuilderInput>)+12E]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v5 (Il2CppClass<IPopupWindowBuilderInput>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00e1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v5 (Il2CppClass<IPopupWindowBuilderInput>)+B0]");
		object obj6 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X10_v5-8]");
			if (0 == (nint)obj3)
			{
				break;
			}
			obj6 += 16;
			obj5--;
			if ((nint)obj5 != 1)
			{
				continue;
			}
			goto IL_00e1;
		}
		object obj7 = obj6 + 3;
		object obj8 = num + obj7;
		object obj9 = obj8 + 312;
		goto IL_0192;
		IL_00e1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0192;
		IL_0192:
		object msgTitle = "Error reading data from socket: " + 1992;
		object msgBody = "Error reading data from socket: " + 2040;
		object primaryText = "Network Authentication Required" + 3128;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v210 @ X0_v7] (should have been resolved before IL gen)");
		object obj10 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v10+E4]");
		bool flag = (nint)0 == 0;
		object obj11 = !flag;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		IPopupWindowBuilderInput inputData = default(IPopupWindowBuilderInput);
		PopupWindow.ShowPrompt((string)msgTitle, (string)msgBody, inputData, (string)primaryText);
	}

	private unsafe void OnExtendStageSubmit(string minutesStr)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected Ref, but got Unknown
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected O, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected O, but got Unknown
		//IL_01a0: Expected O, but got I4
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_00a3: Expected O, but got I
		//IL_00b4: Expected I, but got O
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		//IL_01ea: Expected O, but got I
		//IL_01fa: Expected O, but got I
		//IL_021c: Expected O, but got I4
		//IL_010a: Expected O, but got I
		//IL_011a: Expected O, but got I
		//IL_024c: Expected O, but got I4
		//IL_02e3: Expected O, but got I
		//IL_02f4: Expected I, but got O
		//IL_0312: Expected O, but got I
		//IL_0298: Expected O, but got I4
		//IL_027c: Expected O, but got I
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 2968;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		Action<object> action = default(Action<object>);
		Action<ISFSObject> onSuccess;
		if (int.TryParse(minutesStr, out *(int*)(obj2 + 16)))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3 (System.Object)+10]");
			if ((nint)0 > (nint)0)
			{
				object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2360;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj4 = (nint)0 + (nint)744;
				action..ctor(obj2, (IntPtr)obj4);
				object obj5 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 2944;
				object obj6 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X0_v15+E4]");
				object obj7;
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X0_v15+B8]");
					obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v13+8]");
					onSuccess = (Action<ISFSObject>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v13+8]");
					if ((nint)0 != 0)
					{
						goto IL_013f;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj6 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X0_v15+B8]");
					obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v13+8]");
					onSuccess = (Action<ISFSObject>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v13+8]");
					bool flag = (nint)0 == 0;
					object obj8 = !flag;
					if (obj8 != null)
					{
						goto IL_013f;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X0_v15+E4]");
				bool flag2 = (nint)0 == 0;
				object obj9 = !flag2;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj10 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v17+B8]");
					obj7 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj11 = (nint)0 + (nint)712;
				Action<object> action2 = default(Action<object>);
				action2..ctor(obj7, (IntPtr)obj11);
				object obj12 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v16+B8]");
				object obj13 = (nint)0 + (nint)8;
				obj13 = action2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				bool flag3 = (object)this == null;
				object obj14 = !flag3;
				onSuccess = action2;
				if (obj14 == null)
				{
					throw new NullReferenceException();
				}
				goto IL_013f;
			}
		}
		object obj15 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object message = "Drop Menu Toggle" + 304;
		object obj16 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X0_v8+E4]");
		bool flag4 = (nint)0 == 0;
		object obj17 = !flag4;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.ShowError((string)message);
		return;
		IL_013f:
		SendMassRequest(1, action, onSuccess);
	}

	public void EnterCluster()
	{
		OnClusterAction(1);
	}

	public void ForceStartCluster()
	{
		ConfirmClusterAction(2);
	}

	public void CancelCluster()
	{
		ConfirmClusterAction(3);
	}

	private void ConfirmClusterAction(int clusterAction)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_00ad: Expected I, but got O
		//IL_00d7: Expected O, but got I4
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)752;
		object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object msgTitle = "Complete" + 256;
		object msgBody = "Added Tournament Prizes And Features" + 2208;
		object obj6 = obj2 + 16;
		obj6 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj4);
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v10+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.ShowConfirm((string)msgTitle, (string)msgBody, action);
	}

	private void OnClusterAction(int clusterAction)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0045: Expected O, but got I
		//IL_0065: Expected I, but got O
		//IL_0085: Expected I, but got O
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 2984;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2360;
		object obj4 = (nint)0 + (nint)760;
		object obj5 = (nint)0 + (nint)768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor(obj2, (IntPtr)obj5);
		SendMassRequest(2, action, action2);
	}

	public void ShowFindTournament()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0169: Expected I, but got O
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0055: Expected I, but got O
		//IL_0065: Expected O, but got I
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected O, but got Unknown
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected O, but got Unknown
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected O, but got Unknown
		//IL_01f3: Expected O, but got I4
		//IL_00a0: Expected O, but got I
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj2 = (nint)0 + (nint)3176;
		IPopupWindowBuilderInput popupWindowBuilderInput = PopupInput.OfType(InputField.ContentType.Alphanumeric);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj3 = typeof(System.IOAsyncCallback) + 376;
		object obj4 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		nint num = (nint)popupWindowBuilderInput;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v5 (Il2CppClass<IPopupWindowBuilderInput>)+12E]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v5 (Il2CppClass<IPopupWindowBuilderInput>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00e1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v5 (Il2CppClass<IPopupWindowBuilderInput>)+B0]");
		object obj6 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X10_v5-8]");
			if (0 == (nint)obj3)
			{
				break;
			}
			obj6 += 16;
			obj5--;
			if ((nint)obj5 != 1)
			{
				continue;
			}
			goto IL_00e1;
		}
		object obj7 = obj6 + 3;
		object obj8 = num + obj7;
		object obj9 = obj8 + 312;
		goto IL_0192;
		IL_00e1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0192;
		IL_0192:
		object msgTitle = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 48;
		object msgBody = "ThisIsFakeReceiptData" + 1312;
		object primaryText = "Network Authentication Required" + 3128;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v210 @ X0_v7] (should have been resolved before IL gen)");
		object obj10 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v10+E4]");
		bool flag = (nint)0 == 0;
		object obj11 = !flag;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		IPopupWindowBuilderInput inputData = default(IPopupWindowBuilderInput);
		PopupWindow.ShowPrompt((string)msgTitle, (string)msgBody, inputData, (string)primaryText);
	}

	private void OnFindTournamentSubmit(string tournamentName)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_0119: Expected O, but got I
		//IL_012a: Expected I, but got O
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected O, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_00b8: Expected O, but got I4
		//IL_01eb: Expected O, but got I
		//IL_01fb: Expected O, but got I
		//IL_021d: Expected O, but got I4
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_0180: Expected O, but got I
		//IL_0190: Expected O, but got I
		//IL_024d: Expected O, but got I4
		//IL_031c: Expected O, but got I
		//IL_032d: Expected I, but got O
		//IL_034b: Expected O, but got I
		//IL_0299: Expected O, but got I4
		//IL_027d: Expected O, but got I
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 2952;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = tournamentName;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		string text2;
		if (obj3 != null)
		{
			string text = ((string)obj3).Trim();
			text2 = text;
		}
		else
		{
			text2 = null;
		}
		obj3 = text2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if (string.IsNullOrEmpty((string)obj3))
		{
			object obj4 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v30+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object message = "Index = {0} position = {1}" + 2368;
			PopupWindow.ShowError((string)message);
			return;
		}
		object obj7 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj8 = (nint)0 + (nint)728;
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj8);
		object obj9 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 2944;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X0_v17+E4]");
		object obj11;
		Action<ISFSObject> onSuccess;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X0_v17+B8]");
			obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v8+10]");
			onSuccess = (Action<ISFSObject>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v8+10]");
			if ((nint)0 != 0)
			{
				goto IL_01b5;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X0_v17+B8]");
			obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v8+10]");
			onSuccess = (Action<ISFSObject>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v8+10]");
			bool flag2 = (nint)0 == 0;
			object obj12 = !flag2;
			if (obj12 != null)
			{
				goto IL_01b5;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X0_v17+E4]");
		bool flag3 = (nint)0 == 0;
		object obj13 = !flag3;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj14 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v12+B8]");
			obj11 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj15 = (nint)0 + (nint)720;
		Action<object> action2 = default(Action<object>);
		action2..ctor(obj11, (IntPtr)obj15);
		object obj16 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v11+B8]");
		object obj17 = (nint)0 + (nint)16;
		obj17 = action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool flag4 = (object)this == null;
		object obj18 = !flag4;
		onSuccess = action2;
		if (obj18 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_01b5;
		IL_01b5:
		SendMassRequest(3, action, onSuccess);
	}

	private void SendMassRequest(int action, Action<ISFSObject> configureParams, Action<ISFSObject> onSuccess = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_009a: Expected O, but got I4
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected O, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		//IL_010d: Expected I, but got O
		//IL_011d: Expected O, but got I
		//IL_01b3: Expected O, but got I
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected O, but got Unknown
		//IL_01e2: Expected O, but got I
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected O, but got Unknown
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected O, but got Unknown
		//IL_0158: Expected O, but got I
		//IL_0239: Expected I, but got O
		//IL_0263: Expected O, but got I4
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Expected O, but got Unknown
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Expected O, but got Unknown
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Expected O, but got Unknown
		//IL_02d4: Expected O, but got I
		//IL_02f8: Expected O, but got I4
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected O, but got Unknown
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 2960;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object msgBody = "LAK" + 2136;
		object obj4 = typeof(RegisteredWaitHandle) + 2040;
		object obj5 = obj2 + 16;
		obj5 = onSuccess;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X0_v9+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.ShowLoading((string)msgBody);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		object obj8 = typeof(System.IOAsyncCallback) + 976;
		object obj9 = "___# Content push apply failed [{0}]: {1}" + 3144;
		nint num = (nint)sFSObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0199;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
		object obj11 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X10_v6-8]");
			if (0 == (nint)obj8)
			{
				break;
			}
			obj11 += 16;
			obj10--;
			if ((nint)obj10 != 1)
			{
				continue;
			}
			goto IL_0199;
		}
		object obj12 = obj11 + 35;
		object obj13 = num + obj12;
		object obj14 = obj13 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X0_v29+8]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v282 @ X0_v29] (should have been resolved before IL gen)");
		bool flag2 = configureParams == null;
		object obj16 = !flag2;
		if (obj16 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_01c2;
		IL_0199:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X0_v26+8]");
		obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v266 @ X0_v26] (should have been resolved before IL gen)");
		goto IL_01c2;
		IL_01c2:
		object obj17 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2360;
		object obj18 = (nint)0 + (nint)736;
		object obj19 = typeof(System.Formats.Asn1.SetOfValueComparer) + 72;
		object command = "m_StencilDeferredPS" + 2128;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [configureParams @ X2 (System.Action`1<Sfs2X.Entities.Data.ISFSObject>)+18] (should have been resolved before IL gen)");
		GameObject go = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor(obj2, (IntPtr)obj18);
		object obj20 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X0_v21+E4]");
		bool flag3 = (nint)0 == 0;
		object obj21 = !flag3;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		SfsRequestListener.SendRoomRequest(go, (string)command, sFSObject, keepListening: false, action2);
	}
}
