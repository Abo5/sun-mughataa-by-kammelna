using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using GoogleMobileAds.Api.AdManager;
using HuaweiMobileServices.Location.Location;
using Server.Models;
using TMPro;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;

public class AnnouncementTimingsLabel : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<AppAnnouncementTimingViewModel, DateTime> <>9__5_0;

		public static Func<AppAnnouncementTimingViewModel, bool> <>9__5_1;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1400;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal DateTime <Refresh>b__5_0(AppAnnouncementTimingViewModel t)
		{
			return (DateTime)(((object?)t?.<DateTime>k__BackingField) ?? ((object)new NullReferenceException()));
		}

		internal bool <Refresh>b__5_1(AppAnnouncementTimingViewModel t)
		{
			//IL_0097: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0043: Expected O, but got I4
			if (t != null)
			{
				object obj = typeof(DataRelation) + 712;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v3+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				DateTime now = DateTime.Now;
				return t.<DateTime>k__BackingField > now;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private GameObject container;

	private TextMeshProUGUI dateLabel;

	private DateTimeText dateText;

	private AppAnnouncementModel _model;

	public void Populate(AppAnnouncementModel announcement)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		object obj = this + 56;
		obj = announcement;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Refresh();
	}

	private void Refresh()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00cd: Expected O, but got I
		//IL_00dd: Expected O, but got I
		//IL_00ed: Expected O, but got I
		//IL_010f: Expected O, but got I4
		//IL_0052: Expected O, but got I
		//IL_0062: Expected O, but got I
		//IL_0072: Expected O, but got I
		//IL_0094: Expected O, but got I4
		//IL_0246: Expected O, but got I
		//IL_0256: Expected O, but got I
		//IL_0266: Expected O, but got I
		//IL_0288: Expected O, but got I4
		//IL_0147: Expected O, but got I4
		//IL_01cb: Expected O, but got I
		//IL_01db: Expected O, but got I
		//IL_01eb: Expected O, but got I
		//IL_020d: Expected O, but got I4
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Expected O, but got Unknown
		//IL_03c0: Expected O, but got I
		//IL_03d1: Expected I, but got O
		//IL_03ef: Expected O, but got I
		//IL_02c0: Expected O, but got I4
		//IL_0177: Expected O, but got I
		//IL_034a: Expected O, but got I
		//IL_0425: Unknown result type (might be due to invalid IL or missing references)
		//IL_042a: Expected O, but got Unknown
		//IL_0440: Expected O, but got I
		//IL_0451: Expected I, but got O
		//IL_046f: Expected O, but got I
		//IL_0366: Expected O, but got I
		//IL_02f0: Expected O, but got I
		AppAnnouncementModel model = _model;
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1400;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v26+E4]");
		object obj4;
		Func<object, DateTime> keySelector;
		object obj6;
		object obj3;
		if ((nint)0 != 0)
		{
			obj3 = (nint)0 + (nint)2032;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v26+B8]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v21+8]");
			keySelector = (Func<object, DateTime>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v21+8]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				obj6 = obj3;
				goto IL_0125;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
			obj6 = (nint)0 + (nint)2032;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v26+B8]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v21+8]");
			keySelector = (Func<object, DateTime>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v21+8]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj3 = obj6;
			if (obj7 == null)
			{
				goto IL_0125;
			}
		}
		goto IL_017c;
		IL_029e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X0_v16+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		object obj10;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v16+B8]");
			obj10 = 0;
		}
		object obj11 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 136;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj12 = (nint)0 + (nint)3800;
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj10, (IntPtr)obj12);
		object obj13 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v15+B8]");
		object obj14 = (nint)0 + (nint)16;
		obj14 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Func<object, bool> predicate = func;
		object obj16;
		object obj15 = obj16;
		goto IL_02f5;
		IL_02f5:
		IOrderedEnumerable<object> source;
		object obj17 = Enumerable.FirstOrDefault(source, predicate);
		if (obj17 != null)
		{
			container.SetActive(value: true);
			TextMeshProUGUI textMesh = dateLabel;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v11 (System.Object)+10]");
			TextMeshProExtensions.FixArabic(textMesh, (string)0);
			DateTimeText dateTimeText = dateText;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v11 (System.Object)+18]");
			dateTimeText.SetDate((DateTime)0);
			ScheduleNextRefresh((AppAnnouncementTimingViewModel)obj17);
		}
		else
		{
			container.SetActive(value: false);
		}
		return;
		IL_017c:
		source = Enumerable.OrderBy(model.<AnnouncementTimings>k__BackingField, keySelector);
		object obj18 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X0_v16+E4]");
		if ((nint)0 != 0)
		{
			obj15 = (nint)0 + (nint)616;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X0_v16+B8]");
			obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v10+10]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v10+10]");
			bool flag4 = (nint)0 == 0;
			object obj19 = !flag4;
			if (obj19 == null)
			{
				obj16 = obj15;
				goto IL_029e;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj18 = obj;
			obj16 = (nint)0 + (nint)616;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X0_v16+B8]");
			obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v10+10]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v10+10]");
			bool flag5 = (nint)0 == 0;
			object obj20 = !flag5;
			obj15 = obj16;
			if (obj20 == null)
			{
				goto IL_029e;
			}
		}
		goto IL_02f5;
		IL_0125:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v26+E4]");
		bool flag6 = (nint)0 == 0;
		object obj21 = !flag6;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj22 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v27+B8]");
			obj4 = 0;
		}
		object obj23 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 144;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj24 = (nint)0 + (nint)3792;
		Func<object, DateTime> func2 = default(Func<object, DateTime>);
		func2..ctor(obj4, (IntPtr)obj24);
		object obj25 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v26+B8]");
		object obj26 = (nint)0 + (nint)8;
		obj26 = func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		keySelector = func2;
		obj3 = obj6;
		goto IL_017c;
	}

	private void ScheduleNextRefresh(AppAnnouncementTimingViewModel timing)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0057: Expected O, but got I4
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_0094: Expected O, but got I
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00f6: Expected O, but got I4
		//IL_013d: Expected I, but got O
		//IL_0167: Expected O, but got I4
		object obj = typeof(DataRelation) + 712;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5 = typeof(SqlSingle[]) + 2376;
		object obj6 = (nint)0 + (nint)2184;
		object obj7 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		DateTime now = DateTime.Now;
		TimeSpan timeSpan = timing.<DateTime>k__BackingField - now;
		object obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v9+E4]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		TimeSpan timeSpan2 = default(TimeSpan);
		double totalSeconds = timeSpan2.TotalSeconds;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj6);
		object obj10 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v14+E4]");
		bool flag3 = (nint)0 == 0;
		object obj11 = !flag3;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		double num = totalSeconds + 1.0;
		Coroutine coroutine = CoroutineDummy.WaitForSecondsRealtime((float)num, action);
	}
}
