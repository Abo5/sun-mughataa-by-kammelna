using System;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Threading;
using Cpp2ILInjected;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Server.Models;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;

public class ClickersDetector : MonoBehaviour
{
	private TimeSpan clicksPeriod;

	private int maxAllowedClicksPerPeriod;

	private bool deleteCredentials;

	private DateTime touchNextPeriod;

	private int touchAccumulator;

	private int maxTouches;

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00cc: Expected O, but got I
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		//IL_0114: Expected O, but got I4
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected O, but got Unknown
		//IL_014a: Expected O, but got I
		//IL_016b: Expected I, but got O
		//IL_005a: Expected O, but got I4
		//IL_009d: Expected I, but got O
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = typeof(SqlSingle[]) + 2376;
		object obj3 = (nint)0 + (nint)1904;
		object obj4 = typeof(RegisteredWaitHandle) + 56;
		GameObject gameObject = base.gameObject;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		UnityEngine.Object target = gameObject;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			target = gameObject;
		}
		object obj7 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2592;
		object obj8 = (nint)0 + (nint)1896;
		UnityEngine.Object.DontDestroyOnLoad(target);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj3);
		object obj9 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj10 = !flag2;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RemoteConfig.OnChanged += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<System.Int32Enum> action2 = default(Action<System.Int32Enum>);
		action2..ctor((object)this, (IntPtr)obj8);
		SfsConnectionManager.OnConnectionStateChange += (Action<LoginStatus>)(object)action2;
	}

	private void Update()
	{
		UpdateTouchesPerSecond();
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_009d: Expected O, but got I
		//IL_00b5: Expected I, but got O
		//IL_00df: Expected O, but got I4
		//IL_006e: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)1904;
		object obj3 = typeof(RegisteredWaitHandle) + 56;
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2592;
		object obj5 = (nint)0 + (nint)1896;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RemoteConfig.OnChanged -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<System.Int32Enum> action2 = default(Action<System.Int32Enum>);
		action2..ctor((object)this, (IntPtr)obj5);
		SfsConnectionManager.OnConnectionStateChange -= (Action<LoginStatus>)(object)action2;
	}

	private unsafe void UpdateTouchesPerSecond()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0145: Expected O, but got I4
		//IL_008a: Expected O, but got I
		//IL_01cb: Expected O, but got I4
		//IL_0173: Expected O, but got I
		//IL_018d: Expected O, but got I4
		//IL_00ec: Expected O, but got I
		//IL_0203: Expected O, but got I
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Expected O, but got Unknown
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected O, but got Unknown
		//IL_02b2: Expected O, but got I4
		//IL_06d5: Expected O, but got I
		//IL_06e7: Expected O, but got I8
		//IL_0705: Expected O, but got I4
		//IL_02f6: Expected O, but got I4
		//IL_03be: Expected O, but got I4
		//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f7: Expected I4, but got Unknown
		//IL_042c: Expected O, but got I4
		//IL_0434: Unknown result type (might be due to invalid IL or missing references)
		//IL_0439: Expected O, but got Unknown
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Expected O, but got Unknown
		//IL_073b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0740: Expected O, but got Unknown
		//IL_076a: Expected O, but got I4
		//IL_04df: Expected I4, but got O
		//IL_067c: Expected O, but got I4
		//IL_0513: Expected I4, but got O
		//IL_054b: Expected O, but got I4
		//IL_0596: Invalid comparison between F8 and I8
		//IL_05c7: Expected I4, but got F8
		//IL_07b4: Expected O, but got I4
		//IL_07c1: Expected O, but got I8
		//IL_05ba: Expected I4, but got I8
		//IL_05db: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e0: Expected O, but got Unknown
		//IL_060a: Expected O, but got I4
		//IL_0635: Expected O, but got I4
		//IL_0642: Expected O, but got I8
		object obj = typeof(RegisteredWaitHandle) + 3136;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E70DE]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v52+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v52+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4588]");
		object obj5 = (nint)0 & (nint)1;
		bool flag2 = obj5 == null;
		object obj6 = !flag2;
		if (obj6 != null)
		{
			goto IL_00a7;
		}
		goto IL_019b;
		IL_04c2:
		bool flag3 = touchAccumulator <= maxTouches;
		DateTime dateTime;
		int num = (int)dateTime;
		object obj8;
		TimeSpan timeSpan;
		int clicksCommitted;
		if (!flag3)
		{
			maxTouches = touchAccumulator;
			bool flag4 = touchAccumulator < maxAllowedClicksPerPeriod;
			num = (int)dateTime;
			if (!flag4)
			{
				object obj7 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X0_v18+E4]");
				bool flag5 = (nint)0 == 0;
				object obj9 = !flag5;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				double totalSeconds = ((TimeSpan*)timeSpan)->TotalSeconds;
				num = maxAllowedClicksPerPeriod;
				clicksCommitted = maxTouches;
				int num2 = (int)((totalSeconds != 9.218868437227405E+18) ? ((int)totalSeconds) : 2147483648L);
				SFS.SendIAmAutoClicker(num2, num, clicksCommitted, deleteCredentials);
				bool flag6 = !deleteCredentials;
				object obj10 = 0;
				object obj11 = 9218868437227405312L;
				if (!flag6)
				{
					object obj12 = typeof(UsageHint) + 72;
					object obj13 = obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ X0_v22+E4]");
					bool flag7 = (nint)0 == 0;
					object obj14 = !flag7;
					if (obj14 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					UserInfo.ClearCredentials();
					obj10 = 0;
					obj11 = 9218868437227405312L;
				}
			}
		}
		touchAccumulator = 0;
		object obj16;
		object obj15 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X0_v12+E4]");
		bool flag8 = (nint)0 == 0;
		object obj17 = !flag8;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime now = DateTime.Now;
		DateTime dateTime2 = now + clicksPeriod;
		touchNextPeriod = dateTime2;
		return;
		IL_034d:
		DateTime now2 = DateTime.Now;
		dateTime = touchNextPeriod;
		if (!(now2 > touchNextPeriod))
		{
			return;
		}
		clicksCommitted = 0;
		object obj18;
		obj16 = obj18;
		goto IL_04c2;
		IL_0228:
		if (!SFS.IsConnected || maxAllowedClicksPerPeriod < 1)
		{
			return;
		}
		timeSpan = (TimeSpan)(this + 32);
		obj8 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
		object obj19 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X0_v5+E4]");
		bool flag9 = (nint)0 == 0;
		object obj20 = !flag9;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj19 = obj8;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X0_v5+B8]");
		object obj21 = 0;
		bool flag10 = (TimeSpan)timeSpan._ticks <= (TimeSpan)obj21;
		bool flag11 = !flag10;
		object obj22 = !flag11;
		if (obj22 != null)
		{
			return;
		}
		bool pointerPressedThisFrame = InputUtil.PointerPressedThisFrame;
		bool flag12 = !pointerPressedThisFrame;
		object obj23 = !flag12;
		if (obj23 == null)
		{
			obj18 = typeof(DataRelation) + 712;
			object obj24 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X0_v29+E4]");
			bool flag13 = (nint)0 == 0;
			obj16 = obj18;
			if (!flag13)
			{
				goto IL_034d;
			}
		}
		else
		{
			int activeTouchCount = InputUtil.ActiveTouchCount;
			object obj25 = activeTouchCount - 1;
			bool flag14 = (nint)obj25 < 0;
			bool flag15 = obj25 == null;
			int num3 = activeTouchCount ^ 1;
			int num4 = activeTouchCount ^ obj25;
			int num5 = num3 & num4;
			bool flag16 = num5 < 0;
			bool flag17 = flag14 == flag16;
			object obj26 = !flag15;
			object obj27 = flag17 & obj26;
			object obj28 = ~obj27;
			int num6 = ((obj28 != null) ? 1 : activeTouchCount);
			int num7 = num6 + touchAccumulator;
			touchAccumulator = num7;
			obj18 = typeof(DataRelation) + 712;
			object obj24 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X0_v29+E4]");
			bool flag18 = (nint)0 == 0;
			object obj29 = !flag18;
			obj16 = obj18;
			if (obj29 != null)
			{
				goto IL_034d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		DateTime now3 = DateTime.Now;
		dateTime = touchNextPeriod;
		bool flag19 = now3 > touchNextPeriod;
		bool flag20 = !flag19;
		clicksCommitted = 0;
		if (flag20)
		{
			return;
		}
		goto IL_04c2;
		IL_0074:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4588]");
		object obj30 = (nint)0 & (nint)1;
		if (obj30 != null)
		{
			goto IL_00a7;
		}
		goto IL_019b;
		IL_019b:
		_ = 1;
		object obj31 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v68+E4]");
		bool flag21 = (nint)0 == 0;
		object obj32 = !flag21;
		object obj33 = obj31;
		if (obj32 != null)
		{
			goto IL_00dc;
		}
		goto IL_01e1;
		IL_00a7:
		obj31 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v68+E4]");
		bool flag22 = (nint)0 == 0;
		obj33 = obj31;
		if (!flag22)
		{
			goto IL_00dc;
		}
		goto IL_01e1;
		IL_01e1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj34 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X0_v46+B8]");
		object obj35 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v25+18]");
		if ((nint)0 == 4)
		{
			return;
		}
		goto IL_0228;
		IL_00dc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v68+B8]");
		object obj36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v36+18]");
		if ((nint)0 == 4)
		{
			return;
		}
		goto IL_0228;
	}

	private void UpdateClickingThreshold()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00e2: Expected O, but got I4
		//IL_009f: Expected O, but got I4
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected O, but got Unknown
		//IL_0160: Expected O, but got I4
		//IL_018b: Expected F8, but got I4
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected O, but got Unknown
		//IL_0287: Expected O, but got I4
		object obj = typeof(RegisteredWaitHandle) + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7217]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v31+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = obj3;
			if (!flag)
			{
				goto IL_007c;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v31+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			object obj4 = obj3;
			if (obj5 != null)
			{
				goto IL_007c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		RemoteConfigModel current = RemoteConfig.Current;
		goto IL_0110;
		IL_0110:
		AutoClickersConfig <AutoClickers>k__BackingField = current.<AutoClickers>k__BackingField;
		object obj6 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v4+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		TimeSpan timeSpan = TimeSpan.FromSeconds(<AutoClickers>k__BackingField.<ClicksPeriod>k__BackingField);
		clicksPeriod = timeSpan;
		RemoteConfigModel current2 = RemoteConfig.Current;
		AutoClickersConfig <AutoClickers>k__BackingField2 = current2.<AutoClickers>k__BackingField;
		maxAllowedClicksPerPeriod = <AutoClickers>k__BackingField2.<MaxAllowedClicksPerPeriod>k__BackingField;
		RemoteConfigModel current3 = RemoteConfig.Current;
		AutoClickersConfig <AutoClickers>k__BackingField3 = current3.<AutoClickers>k__BackingField;
		deleteCredentials = <AutoClickers>k__BackingField3.<DeleteCredentials>k__BackingField;
		object obj9 = typeof(DataRelation) + 712;
		maxTouches = 0;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v11+E4]");
		bool flag4 = (nint)0 == 0;
		object obj11 = !flag4;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime now = DateTime.Now;
		DateTime dateTime = now + clicksPeriod;
		touchNextPeriod = dateTime;
		return;
		IL_007c:
		current = RemoteConfig.Current;
		bool flag5 = current == null;
		object obj12 = !flag5;
		if (obj12 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0110;
	}

	private void OnConnectionStateChange(LoginStatus loginStatus)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_00b4: Expected O, but got I4
		if (LoginStatusExtensions.IsFailingStatus(loginStatus))
		{
			object obj = typeof(DataRelation) + 712;
			maxTouches = 0;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime now = DateTime.Now;
			DateTime dateTime = now + clicksPeriod;
			touchNextPeriod = dateTime;
		}
	}

	private void ResetData()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0089: Expected O, but got I4
		object obj = typeof(DataRelation) + 712;
		maxTouches = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime now = DateTime.Now;
		DateTime dateTime = now + clicksPeriod;
		touchNextPeriod = dateTime;
	}
}
