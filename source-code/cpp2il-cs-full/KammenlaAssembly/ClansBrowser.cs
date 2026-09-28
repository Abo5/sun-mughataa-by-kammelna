using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DataTracking;
using Kammelna.Server.Models.Clans;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Newtonsoft.Json.Linq.JsonPath;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Purchasing.Telemetry;

public class ClansBrowser : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<ClanCardModel, int, ClanCardDataHolder> <>9__5_1;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(CardUtils.<>c) + 1600;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal ClanCardDataHolder <Refresh>b__5_1(ClanCardModel c, int i)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Expected O, but got Unknown
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1128;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj2 + 24;
			obj3 = c;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return (ClanCardDataHolder)obj2;
		}
	}

	private ClansListView listView;

	private SlideAnimationHelper slideAnimationHelper;

	private InputFieldTMProUGUI searchInput;

	public void Initialize()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_00b5: Expected I, but got O
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0080: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)1736;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		slideAnimationHelper.SlideIn(action);
		ITrackEvent trackEvent = TrackerLibrary.ClanBrowserViewed();
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tracker.DesignEvent(trackEvent);
		Refresh(null);
	}

	public void Refresh()
	{
		Refresh(null);
	}

	public void Refresh(string query)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_0056: Expected O, but got I
		//IL_00a8: Expected O, but got I4
		//IL_00d7: Expected I, but got O
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 296;
		object obj3 = (nint)0 + (nint)1744;
		bool flag = string.IsNullOrEmpty(query);
		bool hasQuery = (byte)((flag ? 1u : 0u) ^ 1u) != 0;
		ITrackEvent trackEvent = TrackerLibrary.ClanSearchPerformed(hasQuery);
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v3+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tracker.DesignEvent(trackEvent);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj3);
		KammelnaRequests.GetClans(query, action);
	}

	private void <Initialize>b__3_0()
	{
		searchInput.ShowKeyboard();
	}

	private void <Refresh>b__5_0(KammelnaResponseModel<List<ClanCardModel>> response)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00df: Expected O, but got I4
		//IL_0097: Expected O, but got I4
		//IL_0121: Expected O, but got I4
		//IL_012a: Expected O, but got I4
		//IL_01da: Expected O, but got I4
		//IL_01e3: Expected O, but got I4
		//IL_0192: Expected O, but got I4
		//IL_01fd: Expected O, but got I
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Expected O, but got Unknown
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Expected O, but got Unknown
		//IL_03b8: Expected O, but got I4
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Expected O, but got Unknown
		//IL_026f: Expected O, but got I4
		//IL_0482: Expected O, but got I
		//IL_0492: Expected O, but got I
		//IL_04b4: Expected O, but got I4
		//IL_03f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f9: Expected O, but got Unknown
		//IL_0423: Expected O, but got I4
		//IL_0584: Unknown result type (might be due to invalid IL or missing references)
		//IL_0589: Expected O, but got Unknown
		//IL_031d: Expected I, but got O
		//IL_032d: Expected O, but got I
		//IL_033d: Expected O, but got I
		//IL_02b6: Expected O, but got I4
		//IL_0448: Expected I, but got O
		//IL_0458: Expected O, but got I
		//IL_0468: Expected O, but got I
		//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d6: Expected O, but got Unknown
		//IL_04ec: Expected O, but got I
		//IL_04fd: Expected I, but got O
		//IL_051b: Expected O, but got I
		//IL_02e6: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8664]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v48+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v48+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = this == null;
		bool flag3 = !flag2;
		object obj5 = !flag3;
		object obj6 = 0;
		UnityEngine.Object obj7 = null;
		if (obj5 == null)
		{
			goto IL_013d;
		}
		return;
		IL_0472:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X0_v28+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v29+8]");
		Func<object, int, object> selector = (Func<object, int, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v29+8]");
		bool flag4 = (nint)0 == 0;
		object obj9 = !flag4;
		object obj12 = default(object);
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X0_v28+E4]");
			bool flag5 = (nint)0 == 0;
			object obj10 = !flag5;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj11 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X8_v35+B8]");
				obj8 = 0;
			}
			object obj13 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 680;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj14 = (nint)0 + (nint)864;
			Func<object, int, object> func = default(Func<object, int, object>);
			func..ctor(obj8, (IntPtr)obj14);
			object obj15 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X8_v34+B8]");
			object obj16 = (nint)0 + (nint)8;
			obj16 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			selector = func;
		}
		IEnumerable<object> source = Enumerable.Select(response.<Model>k__BackingField, selector);
		List<object> list = Enumerable.ToList(source);
		ClansListView clansListView = default(ClansListView);
		nint num = (nint)clansListView;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v28 (Il2CppClass<ClansListView>)+2A8]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v28 (Il2CppClass<ClansListView>)+2B0]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v117 @ X3_v4 (should have been resolved before IL gen)");
		goto IL_0347;
		IL_0347:
		string errorMessage = ((KammelnaResponseModel<object>)(object)response).ErrorMessage;
		object obj19 = "WhiteSmoke" + 2912;
		string text = (string)obj19 + errorMessage;
		object obj20 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
		object obj21 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v12+E4]");
		bool flag6 = (nint)0 == 0;
		object obj22 = !flag6;
		object obj23 = text;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj23 = text;
		}
		KLogger.LogWarning(obj23);
		string errorMessage2 = ((KammelnaResponseModel<object>)(object)response).ErrorMessage;
		ITrackEvent trackEvent = TrackerLibrary.ClanListLoadError(errorMessage2);
		object obj24 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj25 = obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X8_v15+E4]");
		bool flag7 = (nint)0 == 0;
		object obj26 = !flag7;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tracker.DesignEvent(trackEvent);
		ClansListView clansListView2 = listView;
		object obj27 = typeof(List<AdaptivePerformanceScaler>) + 520;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list2 = default(List<object>);
		list2..ctor();
		nint num2 = (nint)clansListView2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v20 (Il2CppClass<ClansListView>)+2A8]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v20 (Il2CppClass<ClansListView>)+2B0]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v118 @ X3_v2 (should have been resolved before IL gen)");
		goto IL_0472;
		IL_013d:
		object obj30 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v3+E4]");
		if ((nint)0 != 0)
		{
			bool flag8 = listView == null;
			bool flag9 = !flag8;
			object obj31 = 0;
			if (!flag9)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag10 = listView == null;
			bool flag11 = !flag10;
			object obj32 = !flag11;
			object obj31 = 0;
			if (obj32 != null)
			{
				return;
			}
		}
		object obj33 = (nint)0 + (nint)552;
		if (!((KammelnaResponseModel<object>)(object)response).Succeeded)
		{
			goto IL_0347;
		}
		clansListView = listView;
		obj12 = typeof(CardUtils.<>c) + 1600;
		object obj34 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X0_v28+E4]");
		bool flag12 = (nint)0 == 0;
		object obj35 = !flag12;
		if (obj35 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj34 = obj12;
		}
		goto IL_0472;
		IL_0074:
		bool flag13 = this == null;
		bool flag14 = !flag13;
		obj6 = 0;
		obj7 = null;
		if (!flag14)
		{
			return;
		}
		goto IL_013d;
	}
}
