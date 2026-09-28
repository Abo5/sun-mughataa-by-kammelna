using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected;
using DataTracking;
using Kammelna.Server.Models.Clans;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.TextCore;

public class ClansDiscoveryPage : MonoBehaviour
{
	public void LoadDiscoveryPage()
	{
		//IL_000c: Expected O, but got I
		//IL_0031: Expected O, but got I4
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected O, but got Unknown
		//IL_01d4: Expected O, but got I
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected O, but got Unknown
		//IL_0212: Expected O, but got I4
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected O, but got Unknown
		//IL_024f: Expected O, but got I
		//IL_0283: Expected O, but got I4
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_0072: Expected O, but got I4
		//IL_00f6: Expected O, but got I
		//IL_02c6: Expected I, but got O
		//IL_0113: Expected O, but got I
		//IL_008a: Expected O, but got I4
		//IL_009f: Expected O, but got I
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_014e: Expected O, but got I
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected O, but got Unknown
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected O, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected O, but got Unknown
		object obj = (nint)0 + (nint)824;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D31D00");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3+18]");
		bool flag = (nint)0 < (nint)1;
		object obj3 = 1;
		if (!flag)
		{
			object obj4 = typeof(System.IOAsyncCallback) + 2176;
			object obj6 = default(object);
			object obj5 = obj6 + 32;
			object obj7 = obj;
			object obj8 = 0;
			bool flag2;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X24_v4+v100 @ X22_v8*8]");
				object obj9 = 0;
				object obj10 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v11+12E]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v11+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0077;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v11+B0]");
				object obj12 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X10_v8-8]");
					if (0 == (nint)obj4)
					{
						break;
					}
					obj12 += 16;
					obj11--;
					if ((nint)obj11 != 1)
					{
						continue;
					}
					goto IL_0077;
				}
				object obj13 = obj10 + obj12;
				object obj14 = obj13 + 312;
				goto IL_008f;
				IL_008f:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X0_v22+8]");
				obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v319 @ X0_v22] (should have been resolved before IL gen)");
				obj8++;
				object obj15 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3+18]");
				flag2 = (nint)obj15 >= 0;
				obj2 = obj7;
				continue;
				IL_0077:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				obj7 = 0;
				goto IL_008f;
			}
			while (!flag2);
		}
		object obj16 = typeof(Queue<string>) + 728;
		object obj17 = (nint)0 + (nint)1976;
		object obj18 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		object obj19 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X0_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj20 = !flag3;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj21 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1504;
		object obj22 = (nint)0 + (nint)1752;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj23 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X0_v11+E4]");
		bool flag4 = (nint)0 == 0;
		object obj24 = !flag4;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Games currentGame = Preferences.CurrentGame;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj22);
		ClanServerConnector clanServerConnector = default(ClanServerConnector);
		clanServerConnector.GetClanLanding(currentGame, action);
	}

	private void OnLandingLoaded(ClanLandingResponseModel landing)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00ea: Expected O, but got I4
		//IL_0099: Expected O, but got I4
		//IL_00a2: Expected O, but got I4
		//IL_0157: Expected O, but got I4
		//IL_012a: Expected O, but got I4
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected O, but got Unknown
		//IL_01ac: Expected O, but got I4
		//IL_0350: Expected O, but got I
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected O, but got Unknown
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected O, but got Unknown
		//IL_0219: Expected O, but got I4
		//IL_027c: Expected O, but got I
		//IL_0299: Expected O, but got I
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Expected O, but got Unknown
		//IL_02d4: Expected O, but got I
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Expected O, but got Unknown
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Expected O, but got Unknown
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Expected O, but got Unknown
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E861B]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v20+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v20+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = this == null;
		bool flag3 = landing == null;
		object obj5 = 0;
		UnityEngine.Object obj6 = null;
		if (!flag3)
		{
			goto IL_013d;
		}
		return;
		IL_013d:
		bool flag4 = !flag2;
		object obj7 = !flag4;
		if (obj7 != null)
		{
			return;
		}
		ITrackEvent trackEvent = TrackerLibrary.ClanLandingViewed();
		object obj8 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v6+E4]");
		bool flag5 = (nint)0 == 0;
		object obj10 = !flag5;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tracker.DesignEvent(trackEvent);
		object obj11 = (nint)0 + (nint)816;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D31D00");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v7+18]");
		if ((nint)0 < (nint)1)
		{
			return;
		}
		object obj13 = default(object);
		object obj12 = obj13 + 32;
		object obj14 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 1536;
		object obj15 = 0;
		object obj22;
		do
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X23_v4+v250 @ X22_v7*8]");
			object obj16 = 0;
			object obj17 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X8_v12+12E]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X8_v12+12E]");
			if ((nint)0 == 0)
			{
				goto IL_021e;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X8_v12+B0]");
			object obj19 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X10_v8-8]");
				if (0 == (nint)obj14)
				{
					break;
				}
				obj19 += 16;
				obj18--;
				if ((nint)obj18 != 1)
				{
					continue;
				}
				goto IL_021e;
			}
			object obj20 = obj17 + obj19;
			object obj21 = obj20 + 312;
			goto IL_022d;
			IL_022d:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v320 @ X0_v12] (should have been resolved before IL gen)");
			obj15++;
			obj22 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v7+18]");
			continue;
			IL_021e:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_022d;
		}
		while ((nint)obj22 < 0);
		return;
		IL_0074:
		flag2 = this == null;
		bool flag6 = landing == null;
		object obj23 = !flag6;
		obj5 = 0;
		obj6 = null;
		if (obj23 == null)
		{
			return;
		}
		goto IL_013d;
	}
}
