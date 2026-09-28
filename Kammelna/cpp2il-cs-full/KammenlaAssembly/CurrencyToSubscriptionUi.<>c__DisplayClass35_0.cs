using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using DataTracking;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models;
using Sfs2X.Entities;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class CurrencyToSubscriptionUi : MonoBehaviour, IInitializable
{
	private sealed class <>c__DisplayClass35_0
	{
		public CurrencyToSubscriptionUi <>4__this;

		public int days;

		internal void <AssignOptions>b__0()
		{
			<>4__this.ChangingDays(days);
		}
	}

	private sealed class <>c__DisplayClass49_0
	{
		public int coins;

		public CurrencyToSubscriptionUi <>4__this;

		internal void <SubmitTransaction>b__0(KammelnaResponseModel<bool> request)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00db: Expected O, but got I4
			//IL_0098: Expected O, but got I4
			//IL_010e: Expected O, but got I
			//IL_015e: Expected O, but got I4
			//IL_018f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0194: Expected O, but got Unknown
			//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b2: Expected O, but got Unknown
			//IL_02c8: Expected O, but got I
			//IL_02e2: Expected O, but got I4
			//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d5: Expected O, but got Unknown
			//IL_01eb: Expected O, but got I
			//IL_0328: Expected O, but got I4
			//IL_0260: Expected O, but got I4
			//IL_036c: Expected O, but got I
			//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_03af: Expected O, but got Unknown
			//IL_03d9: Expected O, but got I4
			//IL_042c: Expected F8, but got I4
			//IL_043b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0440: Expected O, but got Unknown
			//IL_044c: Expected O, but got I
			//IL_045f: Expected I8, but got I4
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E698F]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v38+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v38+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			PopupWindow.SetLoading(loading: false);
			goto IL_0102;
			IL_0460:
			throw new NullReferenceException();
			IL_0210:
			object obj6;
			object obj5 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v22+E4]");
			if ((nint)0 != 0)
			{
				goto IL_023d;
			}
			goto IL_0336;
			IL_0336:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			RemoteConfigModel current = RemoteConfig.Current;
			goto IL_034e;
			IL_0074:
			PopupWindow.SetLoading(loading: false);
			bool flag2 = request == null;
			object obj7 = !flag2;
			if (obj7 != null)
			{
				goto IL_0102;
			}
			goto IL_0460;
			IL_0102:
			object obj8 = (nint)0 + (nint)1048;
			if (request.Succeeded)
			{
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X0_v8+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PopupWindow.DismissMessage();
				object obj11 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3664;
				object obj12 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X0_v11+E4]");
				object obj14;
				if ((nint)0 != 0)
				{
					obj6 = typeof(RegisteredWaitHandle) + 56;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6984]");
					object obj13 = (nint)0 & (nint)1;
					bool flag4 = obj13 == null;
					obj14 = obj6;
					if (!flag4)
					{
						goto IL_0210;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj6 = typeof(RegisteredWaitHandle) + 56;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6984]");
					object obj15 = (nint)0 & (nint)1;
					bool flag5 = obj15 == null;
					object obj16 = !flag5;
					obj14 = obj6;
					if (obj16 != null)
					{
						goto IL_0210;
					}
				}
				_ = 1;
				obj5 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v22+E4]");
				bool flag6 = (nint)0 == 0;
				object obj17 = !flag6;
				if (obj17 != null)
				{
					goto IL_023d;
				}
				goto IL_0336;
			}
			CurrencyToSubscriptionUi errorMessage = (CurrencyToSubscriptionUi)(object)request.ErrorMessage;
			errorMessage.ShowError((string)(object)errorMessage);
			return;
			IL_023d:
			current = RemoteConfig.Current;
			bool flag7 = current == null;
			object obj18 = !flag7;
			if (obj18 != null)
			{
				goto IL_034e;
			}
			goto IL_0460;
			IL_034e:
			EconomyConfig <Economy>k__BackingField = current.<Economy>k__BackingField;
			object obj19 = (nint)0 + (nint)3136;
			int value = coins / <Economy>k__BackingField.<SubscriptionDayPrice>k__BackingField;
			int? days = value;
			Subscription.ShowUpdatedSubscriptionPopup(days);
			object obj20 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj21 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X0_v15+E4]");
			bool flag8 = (nint)0 == 0;
			object obj22 = !flag8;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string itemId = Tracker.ItemId(ResourceItemId.Subscription);
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
			Tracker.ResourceEvent(ResourceFlowType.Sink, ResourceItemType.Access, itemId, coins, ResourceCurrency.Aces);
			object action = "Complete" + 1472;
			object itemName = (nint)0 + (nint)2000;
			FirebaseTrack.CurrencyEvent((string)action, (string)itemName, coins);
		}
	}

	private const string ConfirmConvertMessage = "confirm_convert_message";

	private const string ConvertMessage = "{0} for {1}";

	private SlideAnimationHelper popup;

	private TextMeshProUGUI daysText;

	private TextMeshProUGUI acesText;

	private Button Option1;

	private Button Option2;

	private Button Option3;

	private InputFieldTMProUGUI daysInput;

	private InputFieldTMProUGUI coinsInput;

	private Button subtractButton;

	private Button addButton;

	private TextMeshProUGUI convertText;

	private Button submitButton;

	private static readonly int[] daysOptions;

	private const int MaxNumOfDays = 10000;

	private int Days;

	private int Coins;

	private static int SubscriptionDayPrice
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00da: Expected O, but got I4
			//IL_0097: Expected O, but got I4
			//IL_0164: Expected I4, but got O
			object obj = typeof(RegisteredWaitHandle) + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6984]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v5+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v5+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			RemoteConfigModel current = RemoteConfig.Current;
			if (current != null)
			{
				goto IL_011d;
			}
			goto IL_0156;
			IL_0156:
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
			IL_011d:
			EconomyConfig <Economy>k__BackingField = current.<Economy>k__BackingField;
			if (current.<Economy>k__BackingField != null)
			{
				return <Economy>k__BackingField.<SubscriptionDayPrice>k__BackingField;
			}
			goto IL_0156;
			IL_0074:
			current = RemoteConfig.Current;
			bool flag2 = current == null;
			object obj5 = !flag2;
			if (obj5 != null)
			{
				goto IL_011d;
			}
			goto IL_0156;
		}
	}

	private static int MinSubscriptionDays
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00da: Expected O, but got I4
			//IL_0097: Expected O, but got I4
			//IL_0228: Expected I4, but got O
			//IL_0198: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6903]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v11+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v11+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			RemoteConfigModel current = RemoteConfig.Current;
			if (current != null)
			{
				goto IL_011d;
			}
			goto IL_021a;
			IL_021a:
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
			IL_011d:
			EconomyConfig <Economy>k__BackingField = current.<Economy>k__BackingField;
			if (current.<Economy>k__BackingField != null)
			{
				if (<Economy>k__BackingField.<MinCurrencySubscriptionDays>k__BackingField < 1)
				{
					return 1;
				}
				object obj5 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v5+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				RemoteConfigModel current2 = RemoteConfig.Current;
				if (current2 != null)
				{
					EconomyConfig <Economy>k__BackingField2 = current2.<Economy>k__BackingField;
					if (current2.<Economy>k__BackingField != null)
					{
						return <Economy>k__BackingField2.<MinCurrencySubscriptionDays>k__BackingField;
					}
				}
			}
			goto IL_021a;
			IL_0074:
			current = RemoteConfig.Current;
			bool flag3 = current == null;
			object obj7 = !flag3;
			if (obj7 != null)
			{
				goto IL_011d;
			}
			goto IL_021a;
		}
	}

	private static int MinCost
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_0156: Expected O, but got I4
			//IL_0083: Unknown result type (might be due to invalid IL or missing references)
			//IL_0088: Expected O, but got Unknown
			//IL_009e: Expected O, but got I
			//IL_01f8: Expected O, but got I4
			//IL_017d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0182: Expected O, but got Unknown
			//IL_0198: Expected O, but got I
			//IL_01b2: Expected O, but got I4
			//IL_0113: Expected O, but got I4
			//IL_0298: Expected I4, but got O
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3664;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6985]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v15+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v15+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj5 = typeof(RegisteredWaitHandle) + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6984]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			object obj8 = obj5;
			if (obj7 != null)
			{
				goto IL_00c3;
			}
			goto IL_01c8;
			IL_028a:
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
			IL_023b:
			RemoteConfigModel current;
			EconomyConfig <Economy>k__BackingField = current.<Economy>k__BackingField;
			if (current.<Economy>k__BackingField != null)
			{
				int minSubscriptionDays = MinSubscriptionDays;
				return minSubscriptionDays * <Economy>k__BackingField.<SubscriptionDayPrice>k__BackingField;
			}
			goto IL_028a;
			IL_00f0:
			current = RemoteConfig.Current;
			bool flag3 = current == null;
			object obj9 = !flag3;
			if (obj9 != null)
			{
				goto IL_023b;
			}
			goto IL_028a;
			IL_0074:
			obj5 = typeof(RegisteredWaitHandle) + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6984]");
			object obj10 = (nint)0 & (nint)1;
			bool flag4 = obj10 == null;
			obj8 = obj5;
			if (!flag4)
			{
				goto IL_00c3;
			}
			goto IL_01c8;
			IL_01c8:
			_ = 1;
			object obj11 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v6+E4]");
			bool flag5 = (nint)0 == 0;
			object obj12 = !flag5;
			if (obj12 != null)
			{
				goto IL_00f0;
			}
			goto IL_0206;
			IL_00c3:
			obj11 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v6+E4]");
			if ((nint)0 != 0)
			{
				goto IL_00f0;
			}
			goto IL_0206;
			IL_0206:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			current = RemoteConfig.Current;
			if (current != null)
			{
				goto IL_023b;
			}
			goto IL_028a;
		}
	}

	private static int MaxPrice
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_0156: Expected O, but got I4
			//IL_0083: Unknown result type (might be due to invalid IL or missing references)
			//IL_0088: Expected O, but got Unknown
			//IL_009e: Expected O, but got I
			//IL_01f8: Expected O, but got I4
			//IL_017d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0182: Expected O, but got Unknown
			//IL_0198: Expected O, but got I
			//IL_01b2: Expected O, but got I4
			//IL_0113: Expected O, but got I4
			//IL_0290: Expected I4, but got O
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3664;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6986]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v14+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v14+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj5 = typeof(RegisteredWaitHandle) + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6984]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			object obj8 = obj5;
			if (obj7 != null)
			{
				goto IL_00c3;
			}
			goto IL_01c8;
			IL_0282:
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
			IL_023b:
			RemoteConfigModel current;
			EconomyConfig <Economy>k__BackingField = current.<Economy>k__BackingField;
			if (current.<Economy>k__BackingField != null)
			{
				return <Economy>k__BackingField.<SubscriptionDayPrice>k__BackingField * 10000;
			}
			goto IL_0282;
			IL_00f0:
			current = RemoteConfig.Current;
			bool flag3 = current == null;
			object obj9 = !flag3;
			if (obj9 != null)
			{
				goto IL_023b;
			}
			goto IL_0282;
			IL_0074:
			obj5 = typeof(RegisteredWaitHandle) + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6984]");
			object obj10 = (nint)0 & (nint)1;
			bool flag4 = obj10 == null;
			obj8 = obj5;
			if (!flag4)
			{
				goto IL_00c3;
			}
			goto IL_01c8;
			IL_01c8:
			_ = 1;
			object obj11 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v5+E4]");
			bool flag5 = (nint)0 == 0;
			object obj12 = !flag5;
			if (obj12 != null)
			{
				goto IL_00f0;
			}
			goto IL_0206;
			IL_00c3:
			obj11 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v5+E4]");
			if ((nint)0 != 0)
			{
				goto IL_00f0;
			}
			goto IL_0206;
			IL_0206:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			current = RemoteConfig.Current;
			if (current != null)
			{
				goto IL_023b;
			}
			goto IL_0282;
		}
	}

	public void Initialize()
	{
		popup.SlideIn();
	}

	public void Show()
	{
		popup.SlideIn();
	}

	private void Start()
	{
		//IL_002c: Expected O, but got I
		SetupLabels();
		AssignDaysOptions();
		UpdateSubmitButton();
		UpdateTransactionText();
		IntPtr intPtr = default(IntPtr);
		CoinsInputEndEdit((string)(nint)intPtr);
		RegisterEventListeners();
	}

	private void OnDestroy()
	{
		UnRegisterEventListeners();
	}

	private void RegisterEventListeners()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_01a5: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_005d: Expected I, but got O
		//IL_006e: Expected O, but got I
		//IL_009a: Expected I, but got O
		//IL_00ab: Expected O, but got I
		//IL_00d7: Expected I, but got O
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_00fc: Expected O, but got I
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected O, but got Unknown
		//IL_013c: Expected I, but got O
		//IL_0166: Expected O, but got I4
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj2 = (nint)0 + (nint)1184;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj3 = (nint)0 + (nint)1168;
		daysInput.OnValueChanged += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj3);
		object obj4 = (nint)0 + (nint)1192;
		coinsInput.OnValueChanged += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action3 = default(Action<object>);
		action3..ctor((object)this, (IntPtr)obj4);
		object obj5 = (nint)0 + (nint)1176;
		daysInput.OnEndEdit += action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action4 = default(Action<object>);
		action4..ctor((object)this, (IntPtr)obj5);
		object obj6 = typeof(SqlSingle[]) + 2376;
		object obj7 = (nint)0 + (nint)1200;
		object obj8 = typeof(RegisteredWaitHandle) + 56;
		coinsInput.OnEndEdit += action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action5 = default(Action);
		action5..ctor(this, (IntPtr)obj7);
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v18+E4]");
		bool flag = (nint)0 == 0;
		object obj10 = !flag;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RemoteConfig.OnChanged += action5;
	}

	private void UnRegisterEventListeners()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_006a: Expected I, but got O
		//IL_0094: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)1200;
		object obj3 = typeof(RegisteredWaitHandle) + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RemoteConfig.OnChanged -= action;
	}

	private void OnConfigChanged()
	{
		//IL_002c: Expected O, but got I
		SetupLabels();
		AssignDaysOptions();
		UpdateSubmitButton();
		UpdateTransactionText();
		IntPtr intPtr = default(IntPtr);
		CoinsInputEndEdit((string)(nint)intPtr);
	}

	private unsafe void SetupLabels()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0195: Expected O, but got I4
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00bb: Expected O, but got I
		//IL_0249: Expected O, but got I4
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected O, but got Unknown
		//IL_01e1: Expected O, but got I
		//IL_01fb: Expected O, but got I4
		//IL_0148: Expected O, but got I4
		//IL_02f1: Expected I, but got O
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Expected O, but got Unknown
		//IL_031b: Expected I, but got O
		//IL_032b: Expected O, but got I
		//IL_035f: Expected O, but got I4
		//IL_03bb: Expected I, but got O
		//IL_0433: Unknown result type (might be due to invalid IL or missing references)
		//IL_0438: Expected O, but got Unknown
		//IL_0441: Unknown result type (might be due to invalid IL or missing references)
		//IL_0446: Expected O, but got Unknown
		//IL_04aa: Expected O, but got I4
		//IL_0567: Expected O, but got I4
		//IL_04f5: Expected I, but got O
		//IL_0527: Expected O, but got I4
		//IL_058e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0593: Expected O, but got Unknown
		//IL_05d5: Expected O, but got I4
		//IL_05e2: Expected I, but got O
		//IL_0623: Expected O, but got I
		//IL_06e9: Expected O, but got I4
		//IL_0690: Expected O, but got I4
		//IL_0760: Expected O, but got I4
		//IL_076d: Expected I, but got O
		//IL_06a7: Expected O, but got I4
		//IL_06b4: Expected I, but got O
		//IL_0727: Expected O, but got I4
		//IL_0734: Expected I, but got O
		//IL_07b5: Expected O, but got I4
		//IL_07bf: Expected I, but got O
		//IL_0811: Expected O, but got I4
		//IL_081b: Expected I, but got O
		//IL_084e: Expected O, but got I
		//IL_0914: Expected O, but got I4
		//IL_08bb: Expected O, but got I4
		//IL_098b: Expected O, but got I4
		//IL_0998: Expected I, but got O
		//IL_08d2: Expected O, but got I4
		//IL_08df: Expected I, but got O
		//IL_0952: Expected O, but got I4
		//IL_095f: Expected I, but got O
		//IL_09dc: Expected O, but got I4
		//IL_09e6: Expected I, but got O
		object obj = 152985600;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3664;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6987]");
		object obj3 = (nint)0 & (nint)1;
		TextMeshProUGUI textMeshProUGUI;
		TextMeshProUGUI textMeshProUGUI2;
		if (obj3 != null)
		{
			textMeshProUGUI = acesText;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v87+E4]");
			bool flag = (nint)0 == 0;
			textMeshProUGUI2 = acesText;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			textMeshProUGUI = acesText;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v87+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			textMeshProUGUI2 = acesText;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj6 = typeof(RegisteredWaitHandle) + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6984]");
		object obj7 = (nint)0 & (nint)1;
		bool flag3 = obj7 == null;
		object obj8 = !flag3;
		textMeshProUGUI = textMeshProUGUI2;
		object obj9 = obj6;
		if (obj8 != null)
		{
			goto IL_00e8;
		}
		goto IL_0219;
		IL_0a12:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_0a20;
		IL_0a20:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_096d:
		RemoteConfigModel current;
		bool flag4 = current.<Economy>k__BackingField == null;
		object obj10 = 0;
		object[] array = null;
		string text;
		nint num = (nint)text;
		int num2 = default(int);
		if (!flag4)
		{
			int minSubscriptionDays = MinSubscriptionDays;
			string text2 = num2.ToString();
			bool flag5 = (object)coinsInput == null;
			obj10 = 0;
			array = null;
			num = unchecked((nint)null);
			if (!flag5)
			{
				coinsInput.Text = text2;
				return;
			}
		}
		goto IL_0a04;
		IL_0091:
		obj6 = typeof(RegisteredWaitHandle) + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6984]");
		object obj11 = (nint)0 & (nint)1;
		bool flag6 = obj11 == null;
		obj9 = obj6;
		textMeshProUGUI2 = textMeshProUGUI;
		if (!flag6)
		{
			goto IL_00e8;
		}
		goto IL_0219;
		IL_0219:
		_ = 1;
		object obj12 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v78+E4]");
		bool flag7 = (nint)0 == 0;
		object obj13 = !flag7;
		obj6 = obj9;
		textMeshProUGUI = textMeshProUGUI2;
		if (obj13 != null)
		{
			goto IL_0125;
		}
		goto IL_0267;
		IL_00e8:
		obj12 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v78+E4]");
		bool flag8 = (nint)0 == 0;
		obj9 = obj6;
		textMeshProUGUI2 = textMeshProUGUI;
		if (!flag8)
		{
			goto IL_0125;
		}
		goto IL_0267;
		IL_0267:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		RemoteConfigModel current2 = RemoteConfig.Current;
		bool flag9 = current2 == null;
		obj6 = obj9;
		textMeshProUGUI = textMeshProUGUI2;
		if (!flag9)
		{
			goto IL_02ac;
		}
		goto IL_0a04;
		IL_0125:
		current2 = RemoteConfig.Current;
		bool flag10 = current2 == null;
		object obj14 = !flag10;
		if (obj14 != null)
		{
			goto IL_02ac;
		}
		goto IL_0a04;
		IL_02ac:
		LocalizableText localizableText;
		RemoteConfigModel current3;
		if (current2.<Economy>k__BackingField != null)
		{
			string text3 = num2.ToString();
			bool flag11 = (object)textMeshProUGUI == null;
			num = unchecked((nint)null);
			if (!flag11)
			{
				object obj15 = typeof(TypeConverter<ushort, char>) + 3400;
				nint num3 = (nint)textMeshProUGUI;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X8_v8 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
				array = (object[])0;
				textMeshProUGUI.text = text3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
				int minSubscriptionDays2 = MinSubscriptionDays;
				object obj16 = 153100288 + 1024;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				object[] array2 = default(object[]);
				bool flag12 = array2 == null;
				int num4 = default(int);
				num = (nint)(&num4);
				if (!flag12)
				{
					object obj17 = default(object);
					bool flag13 = obj17 == null;
					nint num5 = (nint)(&num4);
					if (!flag13)
					{
						nint num6 = (nint)array2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X8_v33 (Il2CppClass<System.Object[]>)+40]");
						num5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag14 = ex == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X8_v33 (Il2CppClass<System.Object[]>)+40]");
						num = 0;
						if (flag14)
						{
							goto IL_0a20;
						}
					}
					bool flag15 = array2.Length == 0;
					num = num5;
					if (flag15)
					{
						goto IL_0a12;
					}
					object text4 = "DNQUALIFIER" + 1456;
					object obj18 = array2 + 32;
					obj18 = obj17;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					TextMeshProExtensions.Localize(daysText, (string)text4, array2);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
					int minSubscriptionDays3 = MinSubscriptionDays;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
					object[] array3 = default(object[]);
					bool flag16 = array3 == null;
					obj10 = 0;
					array = array2;
					int num7 = default(int);
					num = (nint)(&num7);
					if (!flag16)
					{
						object obj19 = default(object);
						bool flag17 = obj19 == null;
						nint num8 = (nint)(&num7);
						if (!flag17)
						{
							nint num9 = (nint)array3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X8_v32 (Il2CppClass<System.Object[]>)+40]");
							num8 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
							bool flag18 = ex == null;
							obj10 = 0;
							array = array2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X8_v32 (Il2CppClass<System.Object[]>)+40]");
							num = 0;
							if (flag18)
							{
								goto IL_0a20;
							}
						}
						bool flag19 = array3.Length == 0;
						obj10 = 0;
						array = array2;
						num = num8;
						if (flag19)
						{
							goto IL_0a12;
						}
						object obj20 = array3 + 32;
						obj20 = obj19;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						localizableText = TextMeshProExtensions.LocalizeWith((string)text4, array3);
						bool flag20 = (object)daysInput == null;
						obj10 = 0;
						array = null;
						num = (nint)array3;
						if (!flag20)
						{
							daysInput.SetPlaceholder(localizableText);
							int minSubscriptionDays4 = MinSubscriptionDays;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6984]");
							object obj21 = (nint)0 & (nint)1;
							if (obj21 != null)
							{
								object obj22 = obj6;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X0_v62+E4]");
								if ((nint)0 != 0)
								{
									goto IL_066d;
								}
							}
							else
							{
								_ = 1;
								object obj22 = obj6;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X0_v62+E4]");
								bool flag21 = (nint)0 == 0;
								object obj23 = !flag21;
								if (obj23 != null)
								{
									goto IL_066d;
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							current3 = RemoteConfig.Current;
							bool flag22 = current3 == null;
							obj10 = 0;
							array = null;
							num = (nint)localizableText;
							if (!flag22)
							{
								goto IL_0742;
							}
						}
					}
				}
			}
		}
		goto IL_0a04;
		IL_0742:
		bool flag23 = current3.<Economy>k__BackingField == null;
		obj10 = 0;
		array = null;
		num = (nint)localizableText;
		if (!flag23)
		{
			string text5 = num2.ToString();
			LocalizableText placeholder = TextMeshProExtensions.FixOnly(text5);
			bool flag24 = (object)coinsInput == null;
			obj10 = 0;
			array = null;
			num = unchecked((nint)null);
			if (!flag24)
			{
				coinsInput.SetPlaceholder(placeholder);
				int minSubscriptionDays5 = MinSubscriptionDays;
				text = num2.ToString();
				bool flag25 = (object)daysInput == null;
				obj10 = 0;
				array = null;
				num = unchecked((nint)null);
				if (!flag25)
				{
					daysInput.Text = text;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6984]");
					object obj24 = (nint)0 & (nint)1;
					if (obj24 != null)
					{
						object obj25 = obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X0_v50+E4]");
						if ((nint)0 != 0)
						{
							goto IL_0898;
						}
					}
					else
					{
						_ = 1;
						object obj25 = obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X0_v50+E4]");
						bool flag26 = (nint)0 == 0;
						object obj26 = !flag26;
						if (obj26 != null)
						{
							goto IL_0898;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					current = RemoteConfig.Current;
					bool flag27 = current == null;
					obj10 = 0;
					array = null;
					num = (nint)text;
					if (!flag27)
					{
						goto IL_096d;
					}
				}
			}
		}
		goto IL_0a04;
		IL_066d:
		current3 = RemoteConfig.Current;
		bool flag28 = current3 == null;
		object obj27 = !flag28;
		if (obj27 != null)
		{
			goto IL_0742;
		}
		obj10 = 0;
		array = null;
		num = (nint)localizableText;
		goto IL_0a04;
		IL_0898:
		current = RemoteConfig.Current;
		bool flag29 = current == null;
		object obj28 = !flag29;
		if (obj28 != null)
		{
			goto IL_096d;
		}
		obj10 = 0;
		array = null;
		num = (nint)text;
		goto IL_0a04;
		IL_0a04:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0a12;
	}

	private void AssignDaysOptions()
	{
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_00d6: Expected O, but got I4
		//IL_013b: Expected O, but got I4
		//IL_0144: Expected O, but got I4
		//IL_014d: Expected O, but got I4
		//IL_0594: Expected O, but got I
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected O, but got Unknown
		//IL_01d9: Expected O, but got I4
		//IL_024f: Expected O, but got I4
		//IL_0209: Expected O, but got I
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Expected O, but got Unknown
		//IL_02cf: Expected O, but got I4
		//IL_0375: Expected O, but got I4
		//IL_05c9: Expected O, but got I
		//IL_03bb: Expected O, but got I4
		//IL_0406: Expected O, but got I
		//IL_04d5: Expected O, but got I4
		//IL_05fe: Expected O, but got I
		//IL_051b: Expected O, but got I4
		object obj;
		object obj6;
		object obj7;
		object obj8;
		object obj4;
		if ((object)Option2 != null)
		{
			GameObject gameObject = Option2.gameObject;
			if ((object)gameObject != null)
			{
				gameObject.SetActive(value: false);
				if ((object)Option3 != null)
				{
					GameObject gameObject2 = Option3.gameObject;
					if ((object)gameObject2 != null)
					{
						obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3664;
						gameObject2.SetActive(value: false);
						object obj2 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X0_v11+E4]");
						bool flag = (nint)0 == 0;
						object obj3 = !flag;
						if (obj3 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						int minSubscriptionDays = MinSubscriptionDays;
						AssignOptions(Option1, minSubscriptionDays);
						obj4 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X0_v35+E4]");
						bool flag2 = (nint)0 == 0;
						object obj5 = !flag2;
						obj6 = 1;
						obj7 = 1;
						obj8 = obj4;
						if (obj5 == null)
						{
							goto IL_0163;
						}
						goto IL_0584;
					}
				}
			}
		}
		goto IL_0550;
		IL_0550:
		NullReferenceException ex = new NullReferenceException();
		goto IL_055e;
		IL_0163:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj8 = obj;
		obj7 = obj6;
		goto IL_0584;
		IL_0584:
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X0_v17+B8]");
			object obj9 = 0;
			object obj10 = obj9;
			if (obj9 == null)
			{
				break;
			}
			object obj11 = obj7 - 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v11+18]");
			if ((nint)obj11 >= 0)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X0_v17+E4]");
			bool flag3 = (nint)0 == 0;
			object obj12 = !flag3;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj13 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X8_v26+B8]");
				object obj14 = 0;
				obj10 = obj14;
				if (obj14 == null)
				{
					break;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v11+18]");
			bool flag4 = (nint)obj11 < 0;
			object obj15 = !flag4;
			if (obj15 == null)
			{
				object obj16 = obj10 + obj11;
				int minSubscriptionDays2 = MinSubscriptionDays;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X8_v12+20]");
				if ((nint)0 <= (nint)minSubscriptionDays2)
				{
					obj7++;
					obj8 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X0_v17+E4]");
					bool flag5 = (nint)0 == 0;
					object obj17 = !flag5;
					if (obj17 != null)
					{
						continue;
					}
					goto IL_02dd;
				}
				if ((object)Option2 == null)
				{
					break;
				}
				GameObject gameObject3 = Option2.gameObject;
				if ((object)gameObject3 == null)
				{
					break;
				}
				gameObject3.SetActive(value: true);
				object obj18 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X0_v22+E4]");
				bool flag6 = (nint)0 == 0;
				object obj19 = !flag6;
				if (obj19 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj18 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X0_v22+B8]");
				object obj20 = 0;
				object obj21 = obj20;
				if (obj20 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v15+18]");
				bool flag7 = (nint)obj11 < 0;
				object obj22 = !flag7;
				if (obj22 == null)
				{
					object obj23 = obj20 + obj11;
					Button option = Option2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X8_v16+20]");
					AssignOptions(option, 0);
					object obj24 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X8_v17+B8]");
					object obj25 = 0;
					object obj26 = obj25;
					if (obj25 == null)
					{
						break;
					}
					object obj27 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v19+18]");
					if ((nint)obj27 >= 0)
					{
						return;
					}
					if ((object)Option3 == null)
					{
						break;
					}
					GameObject gameObject4 = Option3.gameObject;
					if ((object)gameObject4 == null)
					{
						break;
					}
					gameObject4.SetActive(value: true);
					object obj28 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v27+E4]");
					bool flag8 = (nint)0 == 0;
					object obj29 = !flag8;
					if (obj29 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj28 = obj;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v27+B8]");
					object obj30 = 0;
					object obj31 = obj30;
					if (obj30 == null)
					{
						break;
					}
					object obj32 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v23+18]");
					bool flag9 = (nint)obj32 < 0;
					object obj33 = !flag9;
					if (obj33 == null)
					{
						object obj34 = obj30 + obj7;
						Button option2 = Option3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X8_v24+20]");
						AssignOptions(option2, 0);
						return;
					}
				}
			}
			goto IL_055e;
		}
		goto IL_0550;
		IL_02dd:
		obj6 = obj7;
		obj4 = obj8;
		goto IL_0163;
		IL_055e:
		throw new IndexOutOfRangeException();
	}

	private unsafe void AssignOptions(Button button, int days)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		//IL_00a4: Expected O, but got I
		//IL_00d2: Expected I, but got O
		//IL_00eb: Expected I, but got O
		//IL_00f3: Expected I4, but got O
		//IL_0115: Expected O, but got I
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_0164: Expected O, but got I4
		//IL_0187: Expected I, but got O
		//IL_0198: Expected O, but got Ref
		//IL_01bd: Expected O, but got Ref
		//IL_023e: Expected I, but got O
		//IL_01d3: Expected I, but got O
		//IL_01e3: Expected O, but got I
		//IL_0201: Expected I, but got O
		//IL_021a: Expected O, but got I
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Expected O, but got Unknown
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Expected O, but got Unknown
		object obj = typeof(CardUtils.<>c) + 2960;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		bool flag = obj2 == null;
		CurrencyToSubscriptionUi currencyToSubscriptionUi = null;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		if (!flag)
		{
			object obj3 = obj2 + 16;
			obj3 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			bool flag2 = (object)button == null;
			currencyToSubscriptionUi = this;
			if (!flag2)
			{
				bool flag3 = button.m_OnClick == null;
				currencyToSubscriptionUi = this;
				if (!flag3)
				{
					object obj4 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
					object obj5 = (nint)0 + (nint)4024;
					button.m_OnClick.RemoveAllListeners();
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					UnityAction unityAction = default(UnityAction);
					unityAction..ctor(obj2, (IntPtr)obj5);
					bool flag4 = button.m_OnClick == null;
					nint num = unchecked((nint)null);
					int num2 = (int)obj5;
					currencyToSubscriptionUi = (CurrencyToSubscriptionUi)obj2;
					if (!flag4)
					{
						object obj6 = (nint)0 + (nint)288;
						object obj7 = typeof(TypeConverter<ushort, char>) + 3400;
						button.m_OnClick.AddListener(unityAction);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3120C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
						object obj8 = 153100288 + 1024;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
						object[] array = default(object[]);
						bool flag5 = array == null;
						num = unchecked((nint)null);
						num2 = 0;
						object obj9 = default(object);
						currencyToSubscriptionUi = (CurrencyToSubscriptionUi)(&obj9);
						if (!flag5)
						{
							object obj10 = default(object);
							bool flag6 = obj10 == null;
							CurrencyToSubscriptionUi currencyToSubscriptionUi2 = (CurrencyToSubscriptionUi)(&obj9);
							if (!flag6)
							{
								nint num3 = (nint)array;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v11 (Il2CppClass<System.Object[]>)+40]");
								currencyToSubscriptionUi2 = (CurrencyToSubscriptionUi)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
								bool flag7 = ex == null;
								num = unchecked((nint)null);
								num2 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v11 (Il2CppClass<System.Object[]>)+40]");
								currencyToSubscriptionUi = (CurrencyToSubscriptionUi)0;
								if (flag7)
								{
									goto IL_02bf;
								}
							}
							bool flag8 = array.Length == 0;
							num = unchecked((nint)null);
							num2 = 0;
							currencyToSubscriptionUi = currencyToSubscriptionUi2;
							if (!flag8)
							{
								object text = "DNQUALIFIER" + 1456;
								object obj11 = array + 32;
								obj11 = obj10;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								TextMeshProUGUI textMesh = default(TextMeshProUGUI);
								TextMeshProExtensions.Localize(textMesh, (string)text, array);
								return;
							}
							goto IL_02b1;
						}
					}
				}
			}
		}
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_02b1;
		IL_02bf:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_02b1:
		ex = new IndexOutOfRangeException();
		goto IL_02bf;
	}

	private void CoinsInputChanged(string _)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0198: Expected O, but got I4
		//IL_0040: Expected F8, but got I4
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_00f6: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3664;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int maxPrice = MaxPrice;
		UIExtensions.EnsureNumeric(coinsInput, maxPrice);
		object obj4 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		string text = coinsInput.Text;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v5+E4]");
		if ((nint)0 != 0)
		{
			if (StringsExtensions.IsNullOrEmpty(text))
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag2 = StringsExtensions.IsNullOrEmpty(text);
			bool flag3 = !flag2;
			object obj6 = !flag3;
			if (obj6 != null)
			{
				return;
			}
		}
		string text2 = coinsInput.Text;
		int coins = int.Parse(text2);
		Coins = coins;
		UpdateDaysDisplayed();
		UpdateDaysInputButtons();
		coinsInput.AnimateValueChange(Coins, 0.3f);
		UpdateTransactionText();
		UpdateSubmitButton();
	}

	private void DaysInputChanged(string _)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00b6: Expected O, but got I4
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Expected O, but got Unknown
		//IL_0216: Expected O, but got I
		//IL_0230: Expected O, but got I4
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_015a: Expected O, but got I
		//IL_0276: Expected O, but got I4
		//IL_01cf: Expected O, but got I4
		UIExtensions.EnsureNumeric(daysInput, 10000.0);
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		string text = daysInput.Text;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v6+E4]");
		if ((nint)0 != 0)
		{
			if (StringsExtensions.IsNullOrEmpty(text))
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag = StringsExtensions.IsNullOrEmpty(text);
			bool flag2 = !flag;
			object obj3 = !flag2;
			if (obj3 != null)
			{
				return;
			}
		}
		string text2 = daysInput.Text;
		int num = (Days = int.Parse(text2));
		object obj4 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3664;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X0_v11+E4]");
		object obj6;
		object obj8;
		if ((nint)0 != 0)
		{
			obj6 = typeof(RegisteredWaitHandle) + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6984]");
			object obj7 = (nint)0 & (nint)1;
			bool flag3 = obj7 == null;
			obj8 = obj6;
			if (!flag3)
			{
				goto IL_017f;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj6 = typeof(RegisteredWaitHandle) + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6984]");
			object obj9 = (nint)0 & (nint)1;
			bool flag4 = obj9 == null;
			object obj10 = !flag4;
			obj8 = obj6;
			if (obj10 != null)
			{
				goto IL_017f;
			}
		}
		int num2 = 1;
		object obj11 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X0_v18+E4]");
		bool flag5 = (nint)0 == 0;
		object obj12 = !flag5;
		if (obj12 != null)
		{
			goto IL_01ac;
		}
		goto IL_0284;
		IL_017f:
		obj11 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X0_v18+E4]");
		if ((nint)0 != 0)
		{
			goto IL_01ac;
		}
		goto IL_0284;
		IL_0284:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		RemoteConfigModel current = RemoteConfig.Current;
		goto IL_029c;
		IL_01ac:
		current = RemoteConfig.Current;
		bool flag6 = current == null;
		object obj13 = !flag6;
		if (obj13 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_029c;
		IL_029c:
		EconomyConfig <Economy>k__BackingField = current.<Economy>k__BackingField;
		int coins = <Economy>k__BackingField.<SubscriptionDayPrice>k__BackingField * num;
		Coins = coins;
		UpdateDaysDisplayed();
		UpdateDaysInputButtons();
		coinsInput.AnimateValueChange(Coins, 0.3f);
		UpdateTransactionText();
		UpdateSubmitButton();
	}

	private unsafe void DaysInputEndEdit(string _)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00b6: Expected O, but got I4
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		//IL_0123: Expected O, but got I4
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected I4, but got Unknown
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected O, but got Unknown
		//IL_01a6: Expected O, but got I
		//IL_025e: Expected O, but got I4
		//IL_0213: Expected O, but got I4
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Expected O, but got Unknown
		//IL_033c: Expected O, but got I4
		UIExtensions.EnsureNumeric(daysInput, 10000.0);
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		string text = daysInput.Text;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v6+E4]");
		if ((nint)0 != 0)
		{
			if (StringsExtensions.IsNullOrEmpty(text))
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag = StringsExtensions.IsNullOrEmpty(text);
			bool flag2 = !flag;
			object obj3 = !flag2;
			if (obj3 != null)
			{
				return;
			}
		}
		string text2 = daysInput.Text;
		int num = int.Parse(text2);
		object obj4 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3664;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X0_v12+E4]");
		bool flag3 = (nint)0 == 0;
		object obj6 = !flag3;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int minSubscriptionDays = MinSubscriptionDays;
		int num2 = FloatExtensions.EnsureRange(num, minSubscriptionDays, 10000);
		int num3 = this + 128;
		((int*)num3)->m_value = num2;
		object obj7 = typeof(RegisteredWaitHandle) + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6984]");
		object obj8 = (nint)0 & (nint)1;
		if (obj8 != null)
		{
			object obj9 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X0_v32+E4]");
			if ((nint)0 != 0)
			{
				goto IL_01f0;
			}
		}
		else
		{
			int num4 = 1;
			object obj9 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X0_v32+E4]");
			bool flag4 = (nint)0 == 0;
			object obj10 = !flag4;
			if (obj10 != null)
			{
				goto IL_01f0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		RemoteConfigModel current = RemoteConfig.Current;
		CurrencyToSubscriptionUi currencyToSubscriptionUi = (CurrencyToSubscriptionUi)(object)current;
		goto IL_0291;
		IL_0291:
		IntPtr cachedPtr = ((UnityEngine.Object)currencyToSubscriptionUi).m_CachedPtr;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X8_v12 (System.IntPtr)+14]");
		int coins = (int)((nint)0 * (nint)num2);
		Coins = coins;
		if (num != Days)
		{
			currencyToSubscriptionUi.ErrorFeedback();
			RectTransform rect = UIExtensions.rectTransform(daysInput);
			object obj11 = typeof(SqlSingle[]) + 3912;
			object obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v21+E4]");
			bool flag5 = (nint)0 == 0;
			object obj13 = !flag5;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			AnimationExtensions.ErrorFeedback(rect);
			string text3 = ((int*)num3)->ToString();
			daysInput.Text = text3;
		}
		UpdateDaysDisplayed();
		UpdateDaysInputButtons();
		coinsInput.AnimateValueChange(Coins, 0.3f);
		UpdateTransactionText();
		UpdateSubmitButton();
		return;
		IL_01f0:
		RemoteConfigModel current2 = RemoteConfig.Current;
		bool flag6 = current2 == null;
		object obj14 = !flag6;
		currencyToSubscriptionUi = (CurrencyToSubscriptionUi)(object)current2;
		if (obj14 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0291;
	}

	private unsafe void CoinsInputEndEdit(string _ = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_059a: Expected O, but got I4
		//IL_0040: Expected F8, but got I4
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_00f6: Expected O, but got I4
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected O, but got Unknown
		//IL_0240: Expected O, but got I
		//IL_025a: Expected O, but got I4
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected O, but got Unknown
		//IL_017c: Expected O, but got I
		//IL_02a0: Expected O, but got I4
		//IL_01f9: Expected O, but got I4
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Expected I4, but got Unknown
		//IL_0362: Expected O, but got I
		//IL_041a: Expected O, but got I4
		//IL_03cf: Expected O, but got I4
		//IL_04c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ce: Expected O, but got Unknown
		//IL_04f8: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3664;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int maxPrice = MaxPrice;
		UIExtensions.EnsureNumeric(coinsInput, maxPrice);
		object obj4 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		string text = coinsInput.Text;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v5+E4]");
		if ((nint)0 != 0)
		{
			if (StringsExtensions.IsNullOrEmpty(text))
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag2 = StringsExtensions.IsNullOrEmpty(text);
			bool flag3 = !flag2;
			object obj6 = !flag3;
			if (obj6 != null)
			{
				return;
			}
		}
		string text2 = coinsInput.Text;
		int num = int.Parse(text2);
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X0_v14+E4]");
		object obj8;
		object obj10;
		if ((nint)0 != 0)
		{
			obj8 = typeof(RegisteredWaitHandle) + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6984]");
			object obj9 = (nint)0 & (nint)1;
			bool flag4 = obj9 == null;
			obj10 = obj8;
			if (!flag4)
			{
				goto IL_01a1;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = typeof(RegisteredWaitHandle) + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6984]");
			object obj11 = (nint)0 & (nint)1;
			bool flag5 = obj11 == null;
			object obj12 = !flag5;
			obj10 = obj8;
			if (obj12 != null)
			{
				goto IL_01a1;
			}
		}
		int num5 = 1;
		object obj13 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X0_v50+E4]");
		bool flag6 = (nint)0 == 0;
		object obj14 = !flag6;
		obj8 = obj10;
		if (obj14 != null)
		{
			goto IL_01d6;
		}
		goto IL_02b6;
		IL_01a1:
		obj13 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X0_v50+E4]");
		bool flag7 = (nint)0 == 0;
		obj10 = obj8;
		if (!flag7)
		{
			goto IL_01d6;
		}
		goto IL_02b6;
		IL_0569:
		throw new NullReferenceException();
		IL_02db:
		RemoteConfigModel current;
		EconomyConfig <Economy>k__BackingField = current.<Economy>k__BackingField;
		int num2 = IntegerExtensions.FloorTo(num, <Economy>k__BackingField.<SubscriptionDayPrice>k__BackingField);
		int minCost = MinCost;
		int maxPrice2 = MaxPrice;
		int num3 = FloatExtensions.EnsureRange(num2, minCost, maxPrice2);
		int num4 = this + 132;
		((int*)num4)->m_value = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6984]");
		object obj15 = (nint)0 & (nint)1;
		if (obj15 != null)
		{
			object obj16 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X0_v38+E4]");
			if ((nint)0 != 0)
			{
				goto IL_03ac;
			}
		}
		else
		{
			int num6 = 1;
			object obj16 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X0_v38+E4]");
			bool flag8 = (nint)0 == 0;
			object obj17 = !flag8;
			if (obj17 != null)
			{
				goto IL_03ac;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		RemoteConfigModel current2 = RemoteConfig.Current;
		CurrencyToSubscriptionUi currencyToSubscriptionUi = (CurrencyToSubscriptionUi)(object)current2;
		goto IL_044d;
		IL_01d6:
		current = RemoteConfig.Current;
		bool flag9 = current == null;
		object obj18 = !flag9;
		if (obj18 != null)
		{
			goto IL_02db;
		}
		goto IL_0569;
		IL_02b6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		current = RemoteConfig.Current;
		obj8 = obj10;
		goto IL_02db;
		IL_03ac:
		RemoteConfigModel current3 = RemoteConfig.Current;
		bool flag10 = current3 == null;
		object obj19 = !flag10;
		currencyToSubscriptionUi = (CurrencyToSubscriptionUi)(object)current3;
		if (obj19 != null)
		{
			goto IL_044d;
		}
		goto IL_0569;
		IL_044d:
		IntPtr cachedPtr = ((UnityEngine.Object)currencyToSubscriptionUi).m_CachedPtr;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v11 (System.IntPtr)+14]");
		int days = (int)((nint)num3 / (nint)0);
		Days = days;
		if (num != Coins)
		{
			currencyToSubscriptionUi.ErrorFeedback();
			RectTransform rect = UIExtensions.rectTransform(coinsInput);
			object obj20 = typeof(SqlSingle[]) + 3912;
			object obj21 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v20+E4]");
			bool flag11 = (nint)0 == 0;
			object obj22 = !flag11;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			AnimationExtensions.ErrorFeedback(rect);
			string text3 = ((int*)num4)->ToString();
			coinsInput.Text = text3;
		}
		UpdateDaysDisplayed();
		UpdateDaysInputButtons();
		coinsInput.AnimateValueChange(Coins, 0.3f);
		UpdateTransactionText();
		UpdateSubmitButton();
	}

	private void UpdateUI()
	{
		UpdateDaysDisplayed();
		UpdateDaysInputButtons();
		coinsInput.AnimateValueChange(Coins, 0.3f);
		UpdateTransactionText();
		UpdateSubmitButton();
	}

	private void ErrorFeedback()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0156: Expected O, but got I4
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_009e: Expected O, but got I
		//IL_01f8: Expected O, but got I4
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected O, but got Unknown
		//IL_0198: Expected O, but got I
		//IL_01b2: Expected O, but got I4
		//IL_0113: Expected O, but got I4
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected O, but got Unknown
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Expected O, but got Unknown
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected O, but got Unknown
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Expected O, but got Unknown
		//IL_02da: Expected O, but got I4
		//IL_0309: Expected I8, but got I4
		//IL_0328: Expected I8, but got I4
		//IL_0353: Expected O, but got I4
		//IL_0402: Expected O, but got I4
		//IL_0398: Expected I, but got O
		//IL_03ca: Expected O, but got I4
		//IL_0421: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Expected O, but got Unknown
		//IL_044f: Expected I, but got O
		//IL_04c9: Expected O, but got I8
		//IL_04e1: Expected O, but got I4
		//IL_0465: Expected I, but got O
		//IL_0497: Expected O, but got I4
		//IL_0501: Unknown result type (might be due to invalid IL or missing references)
		//IL_0506: Expected O, but got Unknown
		//IL_0515: Unknown result type (might be due to invalid IL or missing references)
		//IL_051a: Expected O, but got Unknown
		//IL_0523: Unknown result type (might be due to invalid IL or missing references)
		//IL_0528: Expected O, but got Unknown
		//IL_057a: Expected O, but got I4
		//IL_05dc: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3664;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E698B]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v46+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v46+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj5 = typeof(RegisteredWaitHandle) + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6984]");
		object obj6 = (nint)0 & (nint)1;
		bool flag2 = obj6 == null;
		object obj7 = !flag2;
		object obj8 = obj5;
		if (obj7 != null)
		{
			goto IL_00c3;
		}
		goto IL_01c8;
		IL_05b3:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_05a5:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_05b3;
		IL_0597:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_05a5;
		IL_0074:
		obj5 = typeof(RegisteredWaitHandle) + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6984]");
		object obj9 = (nint)0 & (nint)1;
		bool flag3 = obj9 == null;
		obj8 = obj5;
		if (!flag3)
		{
			goto IL_00c3;
		}
		goto IL_01c8;
		IL_01c8:
		_ = 1;
		object obj10 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v37+E4]");
		bool flag4 = (nint)0 == 0;
		object obj11 = !flag4;
		if (obj11 != null)
		{
			goto IL_00f0;
		}
		goto IL_0206;
		IL_00c3:
		obj10 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v37+E4]");
		if ((nint)0 != 0)
		{
			goto IL_00f0;
		}
		goto IL_0206;
		IL_0206:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		RemoteConfigModel current = RemoteConfig.Current;
		if (current != null)
		{
			goto IL_023b;
		}
		goto IL_0597;
		IL_00f0:
		current = RemoteConfig.Current;
		bool flag5 = current == null;
		object obj12 = !flag5;
		if (obj12 != null)
		{
			goto IL_023b;
		}
		goto IL_0597;
		IL_023b:
		EconomyConfig <Economy>k__BackingField = current.<Economy>k__BackingField;
		if (current.<Economy>k__BackingField != null)
		{
			object obj13 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
			object input = "AvailableVoices" + 3920;
			object input2 = "DNQUALIFIER" + 1456;
			object obj14 = typeof(TypeConverter<ushort, char>) + 3400;
			object obj15 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X0_v9+E4]");
			bool flag6 = (nint)0 == 0;
			object obj16 = !flag6;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string text = LocalizationUtil.Localize((string)input, <Economy>k__BackingField.<SubscriptionDayPrice>k__BackingField);
			int minSubscriptionDays = MinSubscriptionDays;
			string text2 = LocalizationUtil.Localize((string)input2, minSubscriptionDays);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			object[] array = default(object[]);
			bool flag7 = array == null;
			object obj17 = 0;
			nint num = 2;
			if (!flag7)
			{
				bool flag8 = text == null;
				nint num2 = 2;
				if (!flag8)
				{
					nint num3 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v15 (Il2CppClass<System.Object[]>)+40]");
					num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag9 = ex == null;
					obj17 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v15 (Il2CppClass<System.Object[]>)+40]");
					num = 0;
					if (flag9)
					{
						goto IL_05b3;
					}
				}
				bool flag10 = array.Length == 0;
				obj17 = 0;
				num = num2;
				if (!flag10)
				{
					object obj18 = array + 32;
					obj18 = text;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					bool flag11 = text2 == null;
					nint num4 = (nint)text;
					if (!flag11)
					{
						nint num5 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v14 (Il2CppClass<System.Object[]>)+40]");
						num4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag12 = ex == null;
						obj17 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v14 (Il2CppClass<System.Object[]>)+40]");
						num = 0;
						if (flag12)
						{
							goto IL_05b3;
						}
					}
					object obj19 = array.Length & 0xFFFFFFFEL;
					bool flag13 = obj19 == null;
					obj17 = 0;
					num = num4;
					if (!flag13)
					{
						object text3 = "com.unity.services.authentication.profile" + 2592;
						object obj20 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
						object obj21 = array + 40;
						obj21 = text2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						LocalizableText text4 = TextMeshProExtensions.LocalizeWith((string)text3, array);
						object obj22 = obj20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X8_v13+E4]");
						bool flag14 = (nint)0 == 0;
						object obj23 = !flag14;
						if (obj23 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Toast.Show(text4, (Vector2)0, 0f);
						return;
					}
				}
				goto IL_05a5;
			}
		}
		goto IL_0597;
	}

	private void UpdateCoinsDisplayed()
	{
		coinsInput.AnimateValueChange(Coins, 0.3f);
	}

	private unsafe void UpdateDaysDisplayed()
	{
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected I4, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0047: Expected O, but got I4
		//IL_0069: Expected O, but got I4
		//IL_0071: Expected O, but got Ref
		//IL_0096: Expected O, but got Ref
		//IL_0116: Expected O, but got I4
		//IL_00ac: Expected I, but got O
		//IL_00bc: Expected O, but got I
		//IL_00de: Expected O, but got I4
		//IL_00ee: Expected O, but got I
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected O, but got Unknown
		//IL_018b: Expected O, but got I4
		int num = this + 128;
		string text = ((int*)num)->ToString();
		bool flag = (object)daysInput == null;
		object[] array = null;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		if (!flag)
		{
			object obj = typeof(TypeConverter<ushort, char>) + 3400;
			daysInput.Text = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			object obj2 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object[] array2 = default(object[]);
			bool flag2 = array2 == null;
			object obj3 = 0;
			int num2 = default(int);
			array = (object[])(&num2);
			if (!flag2)
			{
				object obj4 = default(object);
				bool flag3 = obj4 == null;
				object[] array3 = (object[])(&num2);
				if (!flag3)
				{
					nint num3 = (nint)array2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v11 (Il2CppClass<System.Object[]>)+40]");
					array3 = (object[])0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag4 = ex == null;
					obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v11 (Il2CppClass<System.Object[]>)+40]");
					array = (object[])0;
					if (flag4)
					{
						goto IL_01cd;
					}
				}
				bool flag5 = array2.Length == 0;
				obj3 = 0;
				array = array3;
				if (flag5)
				{
					goto IL_01bf;
				}
				object text2 = "DNQUALIFIER" + 1456;
				object obj5 = array2 + 32;
				obj5 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				LocalizableText localizableText = TextMeshProExtensions.LocalizeWith((string)text2, array2);
				bool flag6 = (object)daysInput == null;
				obj3 = 0;
				array = array2;
				if (!flag6)
				{
					daysInput.Mask(localizableText);
					return;
				}
			}
		}
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_01bf;
		IL_01bf:
		ex = new IndexOutOfRangeException();
		goto IL_01cd;
		IL_01cd:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
	}

	private void UpdateTransactionText()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_018d: Expected O, but got I4
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00bb: Expected O, but got I
		//IL_0241: Expected O, but got I4
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected O, but got Unknown
		//IL_01d9: Expected O, but got I
		//IL_01f3: Expected O, but got I4
		//IL_0140: Expected O, but got I4
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a8: Expected O, but got Unknown
		//IL_03d2: Expected O, but got I4
		//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fe: Expected O, but got Unknown
		//IL_040d: Expected I8, but got I4
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0420: Expected O, but got Unknown
		//IL_042f: Expected I8, but got I4
		//IL_0447: Unknown result type (might be due to invalid IL or missing references)
		//IL_044c: Expected O, but got Unknown
		//IL_046e: Expected O, but got I4
		//IL_051d: Expected O, but got I4
		//IL_04b3: Expected I, but got O
		//IL_04e5: Expected O, but got I4
		//IL_053c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0541: Expected O, but got Unknown
		//IL_056a: Expected I, but got O
		//IL_05e4: Expected O, but got I8
		//IL_05fc: Expected O, but got I4
		//IL_0580: Expected I, but got O
		//IL_05b2: Expected O, but got I4
		//IL_061b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0620: Expected O, but got Unknown
		//IL_063c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0641: Expected O, but got Unknown
		object obj = 152985600;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3664;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E698C]");
		object obj3 = (nint)0 & (nint)1;
		int num;
		int num2;
		if (obj3 != null)
		{
			num = Days;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v47+E4]");
			bool flag = (nint)0 == 0;
			num2 = Days;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			num = Days;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v47+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			num2 = Days;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj6 = typeof(RegisteredWaitHandle) + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6984]");
		object obj7 = (nint)0 & (nint)1;
		bool flag3 = obj7 == null;
		object obj8 = !flag3;
		num = num2;
		object obj9 = obj6;
		if (obj8 != null)
		{
			goto IL_00e8;
		}
		goto IL_0211;
		IL_0676:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_0668:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_0676;
		IL_065a:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0668;
		IL_0091:
		obj6 = typeof(RegisteredWaitHandle) + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6984]");
		object obj10 = (nint)0 & (nint)1;
		bool flag4 = obj10 == null;
		obj9 = obj6;
		num2 = num;
		if (!flag4)
		{
			goto IL_00e8;
		}
		goto IL_0211;
		IL_0211:
		_ = 1;
		object obj11 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v38+E4]");
		bool flag5 = (nint)0 == 0;
		object obj12 = !flag5;
		num = num2;
		if (obj12 != null)
		{
			goto IL_011d;
		}
		goto IL_0257;
		IL_00e8:
		obj11 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v38+E4]");
		bool flag6 = (nint)0 == 0;
		num2 = num;
		if (!flag6)
		{
			goto IL_011d;
		}
		goto IL_0257;
		IL_0257:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		RemoteConfigModel current = RemoteConfig.Current;
		bool flag7 = current == null;
		num = num2;
		if (!flag7)
		{
			goto IL_0294;
		}
		goto IL_065a;
		IL_011d:
		current = RemoteConfig.Current;
		bool flag8 = current == null;
		object obj13 = !flag8;
		if (obj13 != null)
		{
			goto IL_0294;
		}
		goto IL_065a;
		IL_0294:
		EconomyConfig <Economy>k__BackingField = current.<Economy>k__BackingField;
		if (current.<Economy>k__BackingField != null)
		{
			int coins = <Economy>k__BackingField.<SubscriptionDayPrice>k__BackingField * num;
			Coins = coins;
			int minSubscriptionDays = MinSubscriptionDays;
			if (Days < minSubscriptionDays)
			{
				return;
			}
			object obj14 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X0_v11+E4]");
			if ((nint)0 != 0)
			{
				int minCost = MinCost;
				if (Coins < minCost)
				{
					return;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				int minCost2 = MinCost;
				if (Coins < minCost2)
				{
					return;
				}
			}
			object obj15 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
			object obj16 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X0_v13+E4]");
			bool flag9 = (nint)0 == 0;
			object obj17 = !flag9;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object input = "AvailableVoices" + 3920;
			string text = LocalizationUtil.Localize((string)input, Coins);
			object input2 = "SERVICE_DISABLED" + 1344;
			string text2 = LocalizationUtil.Localize((string)input2, Days);
			object obj18 = typeof(TypeConverter<ushort, char>) + 3400;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			object[] array = default(object[]);
			bool flag10 = array == null;
			object obj19 = 0;
			nint num3 = 2;
			if (!flag10)
			{
				bool flag11 = text2 == null;
				nint num4 = 2;
				if (!flag11)
				{
					nint num5 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X8_v27 (Il2CppClass<System.Object[]>)+40]");
					num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag12 = ex == null;
					obj19 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X8_v27 (Il2CppClass<System.Object[]>)+40]");
					num3 = 0;
					if (flag12)
					{
						goto IL_0676;
					}
				}
				bool flag13 = array.Length == 0;
				obj19 = 0;
				num3 = num4;
				if (!flag13)
				{
					object obj20 = array + 32;
					obj20 = text2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					bool flag14 = text == null;
					nint num6 = (nint)text2;
					if (!flag14)
					{
						nint num7 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X8_v26 (Il2CppClass<System.Object[]>)+40]");
						num6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag15 = ex == null;
						obj19 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X8_v26 (Il2CppClass<System.Object[]>)+40]");
						num3 = 0;
						if (flag15)
						{
							goto IL_0676;
						}
					}
					object obj21 = array.Length & 0xFFFFFFFEL;
					bool flag16 = obj21 == null;
					obj19 = 0;
					num3 = num6;
					if (!flag16)
					{
						object obj22 = array + 40;
						obj22 = text;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						object text3 = "{0} color encoding is currently unsupported for outputting to HDR." + 64;
						TextMeshProExtensions.Localize(convertText, (string)text3, array);
						return;
					}
				}
				goto IL_0668;
			}
		}
		goto IL_065a;
	}

	private void UpdateDaysInputButtons()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_012f: Expected O, but got I4
		//IL_00d0: Expected O, but got I4
		//IL_0193: Expected O, but got I4
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected I4, but got Unknown
		//IL_0200: Expected O, but got I4
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected I4, but got Unknown
		//IL_022f: Expected O, but got I4
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected I4, but got Unknown
		object obj = 152985600;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3664;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E690A]");
		object obj3 = (nint)0 & (nint)1;
		Button button;
		int num;
		int days;
		Button button2;
		if (obj3 != null)
		{
			button = subtractButton;
			num = Days;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v13+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj4;
			days = Days;
			button2 = subtractButton;
			if (!flag)
			{
				goto IL_00ad;
			}
		}
		else
		{
			_ = 1;
			button = subtractButton;
			num = Days;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v13+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			days = Days;
			button2 = subtractButton;
			if (obj6 != null)
			{
				goto IL_00ad;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		int minSubscriptionDays = MinSubscriptionDays;
		num = days;
		Selectable selectable = button2;
		goto IL_0186;
		IL_0186:
		object obj7 = num - minSubscriptionDays;
		bool flag3 = (nint)obj7 < 0;
		bool flag4 = obj7 == null;
		int num2 = num ^ minSubscriptionDays;
		int num3 = num ^ obj7;
		int num4 = num2 & num3;
		bool flag5 = num4 < 0;
		bool flag6 = flag3 == flag5;
		object obj8 = !flag4;
		bool interactable = (byte)((flag6 & obj8) ? 1 : 0) != 0;
		selectable.interactable = interactable;
		object obj9 = Days - 10000;
		bool flag7 = (nint)obj9 < 0;
		int num5 = Days ^ 0x2710;
		int num6 = Days ^ obj9;
		int num7 = num5 & num6;
		bool flag8 = num7 < 0;
		bool flag9 = flag7 == flag8;
		bool interactable2 = !flag9;
		addButton.interactable = interactable2;
		return;
		IL_00ad:
		minSubscriptionDays = MinSubscriptionDays;
		bool flag10 = (object)button == null;
		object obj10 = !flag10;
		selectable = button;
		if (obj10 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0186;
	}

	private void UpdateSubmitButton()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0126: Expected O, but got I4
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected O, but got Unknown
		//IL_029f: Expected O, but got I
		//IL_02b9: Expected O, but got I4
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Expected O, but got Unknown
		//IL_01e3: Expected O, but got I
		//IL_02ff: Expected O, but got I4
		//IL_0258: Expected O, but got I4
		//IL_035d: Expected O, but got I4
		//IL_0457: Expected O, but got I4
		//IL_0480: Unknown result type (might be due to invalid IL or missing references)
		//IL_0485: Expected I4, but got Unknown
		//IL_04d4: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3664;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E698D]");
		object obj3 = (nint)0 & (nint)1;
		Button button;
		int coins;
		int coins2;
		Button button2;
		if (obj3 != null)
		{
			button = submitButton;
			coins = Coins;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v36+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj4;
			coins2 = Coins;
			button2 = submitButton;
			if (!flag)
			{
				goto IL_00ad;
			}
		}
		else
		{
			_ = 1;
			button = submitButton;
			coins = Coins;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v36+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			coins2 = Coins;
			button2 = submitButton;
			if (obj6 != null)
			{
				goto IL_00ad;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		int minCost = MinCost;
		bool flag3 = coins2 < minCost;
		button = button2;
		if (!flag3)
		{
			goto IL_018c;
		}
		goto IL_03e5;
		IL_0325:
		RemoteConfigModel current;
		EconomyConfig <Economy>k__BackingField = current.<Economy>k__BackingField;
		int num = Coins / <Economy>k__BackingField.<SubscriptionDayPrice>k__BackingField;
		object obj7 = num * <Economy>k__BackingField.<SubscriptionDayPrice>k__BackingField;
		bool flag4 = Coins != (nint)obj7;
		button2 = button;
		if (flag4)
		{
			goto IL_03e5;
		}
		object obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X0_v9+E4]");
		if ((nint)0 != 0)
		{
			int minSubscriptionDays = MinSubscriptionDays;
			bool flag5 = Days >= minSubscriptionDays;
			button2 = button;
			if (!flag5)
			{
				goto IL_03e5;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			int minSubscriptionDays2 = MinSubscriptionDays;
			bool flag6 = Days < minSubscriptionDays2;
			button2 = button;
			if (flag6)
			{
				goto IL_03e5;
			}
		}
		object obj9 = Days - 10001;
		bool flag7 = (nint)obj9 < 0;
		int num2 = Days ^ 0x2711;
		int num3 = Days ^ obj9;
		int num4 = num2 & num3;
		bool flag8 = num4 < 0;
		bool flag9 = flag7 == flag8;
		bool flag10 = !flag9;
		bool flag11 = (object)button == null;
		object obj10 = !flag11;
		bool interactable = flag10;
		Selectable selectable = button;
		if (obj10 != null)
		{
			goto IL_03fb;
		}
		goto IL_04f2;
		IL_0235:
		current = RemoteConfig.Current;
		bool flag12 = current == null;
		object obj11 = !flag12;
		if (obj11 != null)
		{
			goto IL_0325;
		}
		goto IL_04f2;
		IL_030d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		current = RemoteConfig.Current;
		goto IL_0325;
		IL_00ad:
		int minCost2 = MinCost;
		if (coins >= minCost2)
		{
			goto IL_018c;
		}
		button2 = button;
		goto IL_03e5;
		IL_018c:
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X0_v7+E4]");
		object obj13;
		object obj15;
		if ((nint)0 != 0)
		{
			obj13 = typeof(RegisteredWaitHandle) + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6984]");
			object obj14 = (nint)0 & (nint)1;
			bool flag13 = obj14 == null;
			obj15 = obj13;
			if (!flag13)
			{
				goto IL_0208;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj13 = typeof(RegisteredWaitHandle) + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6984]");
			object obj16 = (nint)0 & (nint)1;
			bool flag14 = obj16 == null;
			object obj17 = !flag14;
			obj15 = obj13;
			if (obj17 != null)
			{
				goto IL_0208;
			}
		}
		_ = 1;
		object obj18 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X0_v14+E4]");
		bool flag15 = (nint)0 == 0;
		object obj19 = !flag15;
		if (obj19 != null)
		{
			goto IL_0235;
		}
		goto IL_030d;
		IL_04f2:
		throw new NullReferenceException();
		IL_03e5:
		interactable = false;
		selectable = button2;
		goto IL_03fb;
		IL_03fb:
		selectable.interactable = interactable;
		return;
		IL_0208:
		obj18 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X0_v14+E4]");
		if ((nint)0 != 0)
		{
			goto IL_0235;
		}
		goto IL_030d;
	}

	private void ChangingDays(int days)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_017b: Expected O, but got I4
		//IL_01d9: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3664;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E690B]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v22+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj4;
			if (!flag)
			{
				goto IL_0085;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v22+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			if (obj6 != null)
			{
				goto IL_0085;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		int minSubscriptionDays = MinSubscriptionDays;
		if (days >= minSubscriptionDays)
		{
			goto IL_00aa;
		}
		goto IL_0151;
		IL_00c6:
		InputFieldTMProUGUI inputFieldTMProUGUI;
		string text;
		inputFieldTMProUGUI.Text = text;
		return;
		IL_00aa:
		inputFieldTMProUGUI = daysInput;
		int num = default(int);
		text = num.ToString();
		goto IL_00c6;
		IL_0151:
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v5+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int minSubscriptionDays2 = MinSubscriptionDays;
		inputFieldTMProUGUI = daysInput;
		text = num.ToString();
		bool flag4 = (object)daysInput == null;
		object obj9 = !flag4;
		if (obj9 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00c6;
		IL_0085:
		int minSubscriptionDays3 = MinSubscriptionDays;
		if (days >= minSubscriptionDays3)
		{
			goto IL_00aa;
		}
		goto IL_0151;
	}

	public void Submit()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0193: Expected O, but got I
		//IL_01b5: Expected O, but got I4
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00bb: Expected O, but got I
		//IL_0257: Expected O, but got I
		//IL_0279: Expected O, but got I4
		//IL_0291: Expected O, but got I
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected O, but got Unknown
		//IL_0201: Expected O, but got I
		//IL_021b: Expected O, but got I4
		//IL_0160: Expected O, but got I4
		//IL_0100: Expected O, but got I
		//IL_0127: Expected O, but got I
		//IL_098d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0992: Expected O, but got Unknown
		//IL_09a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ad: Expected O, but got Unknown
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Expected O, but got Unknown
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Expected O, but got Unknown
		//IL_0340: Unknown result type (might be due to invalid IL or missing references)
		//IL_0345: Expected O, but got Unknown
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Expected O, but got Unknown
		//IL_0365: Expected O, but got I
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Expected O, but got Unknown
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Expected O, but got Unknown
		//IL_0395: Expected I8, but got I4
		//IL_039f: Expected I4, but got I8
		//IL_03b7: Expected O, but got I
		//IL_03d9: Expected O, but got I4
		//IL_0aad: Expected O, but got I
		//IL_0416: Expected I8, but got I4
		//IL_0437: Expected I, but got O
		//IL_0469: Expected O, but got I4
		//IL_0486: Unknown result type (might be due to invalid IL or missing references)
		//IL_048b: Expected O, but got Unknown
		//IL_049a: Unknown result type (might be due to invalid IL or missing references)
		//IL_049f: Expected O, but got Unknown
		//IL_04a7: Expected I, but got O
		//IL_04b7: Expected O, but got I
		//IL_0a2e: Expected O, but got I4
		//IL_04f2: Expected O, but got I
		//IL_0592: Expected O, but got I4
		//IL_055a: Unknown result type (might be due to invalid IL or missing references)
		//IL_055f: Expected O, but got Unknown
		//IL_0568: Unknown result type (might be due to invalid IL or missing references)
		//IL_056d: Expected O, but got Unknown
		//IL_0500: Unknown result type (might be due to invalid IL or missing references)
		//IL_0505: Expected O, but got Unknown
		//IL_050e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0513: Expected O, but got Unknown
		//IL_05a8: Expected I, but got O
		//IL_05b8: Expected O, but got I
		//IL_05e1: Expected O, but got I
		//IL_0617: Unknown result type (might be due to invalid IL or missing references)
		//IL_061c: Expected O, but got Unknown
		//IL_06ac: Expected O, but got I4
		//IL_06c0: Expected O, but got I8
		//IL_065b: Expected I, but got O
		//IL_066b: Expected O, but got I
		//IL_0694: Expected O, but got I
		//IL_06e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ec: Expected O, but got Unknown
		//IL_06f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fa: Expected O, but got Unknown
		//IL_073a: Expected O, but got I4
		//IL_0757: Unknown result type (might be due to invalid IL or missing references)
		//IL_075c: Expected O, but got Unknown
		//IL_0774: Expected O, but got I
		//IL_082c: Expected O, but got I4
		//IL_07af: Expected O, but got I
		//IL_0849: Unknown result type (might be due to invalid IL or missing references)
		//IL_084e: Expected O, but got Unknown
		//IL_0856: Expected I, but got O
		//IL_0866: Expected O, but got I
		//IL_08f5: Expected O, but got I4
		//IL_090b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0910: Expected O, but got Unknown
		//IL_0926: Unknown result type (might be due to invalid IL or missing references)
		//IL_092b: Expected O, but got Unknown
		//IL_0957: Expected O, but got I4
		//IL_0968: Expected O, but got I4
		//IL_08a1: Expected O, but got I
		//IL_07bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c2: Expected O, but got Unknown
		//IL_07cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d0: Expected O, but got Unknown
		//IL_0a7f: Expected O, but got I4
		//IL_0a87: Expected O, but got I
		//IL_08af: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b4: Expected O, but got Unknown
		//IL_08bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c2: Expected O, but got Unknown
		object obj = 152985600;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3664;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E698E]");
		object obj3 = (nint)0 & (nint)1;
		int num;
		int num2;
		if (obj3 != null)
		{
			num = Days;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v61+E4]");
			bool flag = (nint)0 == 0;
			num2 = Days;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			num = Days;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6000]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v61+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			num2 = Days;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj6 = typeof(RegisteredWaitHandle) + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6984]");
		object obj7 = (nint)0 & (nint)1;
		bool flag3 = obj7 == null;
		object obj8 = !flag3;
		num = num2;
		object obj9 = obj6;
		if (obj8 != null)
		{
			goto IL_00e8;
		}
		goto IL_0239;
		IL_053b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		EconomyConfig economyConfig2 = default(EconomyConfig);
		EconomyConfig economyConfig = economyConfig2;
		goto IL_0a02;
		IL_0976:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0984;
		IL_0a95:
		object obj11;
		object obj10 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X8_v2+8]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v378 @ X2_v2 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Warning: Method ends with non empty stack (-50), the output could be wrong!");
		/*Error: End of method reached without returning.*/;
		IL_0091:
		obj6 = typeof(RegisteredWaitHandle) + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6984]");
		object obj13 = (nint)0 & (nint)1;
		bool flag4 = obj13 == null;
		obj9 = obj6;
		num2 = num;
		if (!flag4)
		{
			goto IL_00e8;
		}
		goto IL_0239;
		IL_0239:
		_ = 1;
		object obj14 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v52+E4]");
		economyConfig = (EconomyConfig)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v52+E4]");
		bool flag5 = (nint)0 == 0;
		object obj15 = !flag5;
		num = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v52+E4]");
		EconomyConfig economyConfig3 = (EconomyConfig)0;
		if (obj15 != null)
		{
			goto IL_013d;
		}
		goto IL_029f;
		IL_00e8:
		obj14 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v52+E4]");
		economyConfig = (EconomyConfig)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v52+E4]");
		bool flag6 = (nint)0 == 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v52+E4]");
		economyConfig3 = (EconomyConfig)0;
		num2 = num;
		if (!flag6)
		{
			goto IL_013d;
		}
		goto IL_029f;
		IL_029f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		RemoteConfigModel current = RemoteConfig.Current;
		bool flag7 = current == null;
		num = num2;
		economyConfig = economyConfig3;
		if (!flag7)
		{
			goto IL_02e4;
		}
		goto IL_0976;
		IL_013d:
		current = RemoteConfig.Current;
		bool flag8 = current == null;
		object obj16 = !flag8;
		if (obj16 != null)
		{
			goto IL_02e4;
		}
		goto IL_0976;
		IL_02e4:
		economyConfig = current.<Economy>k__BackingField;
		string text;
		string text2;
		object obj27 = default(object);
		object obj22;
		if (current.<Economy>k__BackingField != null)
		{
			object obj17 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
			object input = "AvailableVoices" + 3920;
			object input2 = "SERVICE_DISABLED" + 1344;
			object obj18 = typeof(SqlSingle[]) + 2376;
			object obj19 = (nint)0 + (nint)1160;
			object confirmText = "Complete" + 256;
			object cancelText = "COORDINATE_TYPE_GCJ_02" + 1864;
			long num3 = economyConfig.<SubscriptionDayPrice>k__BackingField * num;
			Coins = (int)num3;
			object obj20 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X0_v6+E4]");
			economyConfig = (EconomyConfig)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X0_v6+E4]");
			bool flag9 = (nint)0 == 0;
			object obj21 = !flag9;
			if (obj21 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			text = LocalizationUtil.Localize((string)input, num3);
			text2 = LocalizationUtil.Localize((string)input2, Days);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action action = default(Action);
			action..ctor(this, (IntPtr)obj19);
			IPopupWindowBuilderNeedsTitle popupWindowBuilderNeedsTitle = PopupWindowBuilder.CreateConfirm(action, (string)confirmText, (string)cancelText);
			bool flag10 = popupWindowBuilderNeedsTitle == null;
			obj22 = 0;
			if (!flag10)
			{
				object obj23 = typeof(System.IOAsyncCallback) + 392;
				object obj24 = typeof(TypeConverter<ushort, char>) + 3400;
				nint num4 = (nint)popupWindowBuilderNeedsTitle;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X8_v13 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
				object obj25 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X8_v13 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_053b;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X8_v13 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+B0]");
				object obj26 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X10_v19-8]");
					if (0 == (nint)obj23)
					{
						break;
					}
					obj27 = obj26 + 16;
					obj25--;
					bool flag11 = (nint)obj25 != 1;
					obj26 = obj27;
					if (flag11)
					{
						continue;
					}
					goto IL_053b;
				}
				object obj28 = num4 + obj26;
				economyConfig = (EconomyConfig)(obj28 + 312);
				obj27 = obj26;
				goto IL_0a02;
			}
		}
		goto IL_0976;
		IL_0a02:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v319 @ X8_v3 (Server.Models.EconomyConfig)] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object[] array = default(object[]);
		bool flag12 = array == null;
		obj22 = 0;
		if (flag12)
		{
			goto IL_0976;
		}
		bool flag13 = text == null;
		string text3 = (string)2;
		IndexOutOfRangeException ex2 = default(IndexOutOfRangeException);
		string text4;
		if (!flag13)
		{
			nint num5 = (nint)array;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ X8_v33 (Il2CppClass<System.Object[]>)+40]");
			text3 = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			bool flag14 = ex2 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ X8_v33 (Il2CppClass<System.Object[]>)+40]");
			text4 = (string)0;
			if (flag14)
			{
				goto IL_09c8;
			}
		}
		if (array.Length != 0)
		{
			object obj29 = array + 32;
			obj29 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			bool flag15 = text2 == null;
			text3 = text;
			if (!flag15)
			{
				nint num6 = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ X8_v32 (Il2CppClass<System.Object[]>)+40]");
				text3 = (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag16 = ex2 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ X8_v32 (Il2CppClass<System.Object[]>)+40]");
				text4 = (string)0;
				if (flag16)
				{
					goto IL_09c8;
				}
			}
			economyConfig = (EconomyConfig)array.Length;
			object obj30 = array.Length & 0xFFFFFFFEL;
			if (obj30 != null)
			{
				object text5 = "com.unity.services.authentication.profile" + 496;
				object obj31 = array + 40;
				obj31 = text2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				LocalizableText localizableText = TextMeshProExtensions.LocalizeWith((string)text5, array);
				object obj32 = default(object);
				bool flag17 = obj32 == null;
				obj22 = 0;
				if (!flag17)
				{
					object obj33 = typeof(System.IOAsyncCallback) + 384;
					object obj34 = obj32;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X8_v23+12E]");
					object obj35 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X8_v23+12E]");
					if ((nint)0 == 0)
					{
						goto IL_07f8;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X8_v23+B0]");
					object obj36 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X10_v14-8]");
						if (0 == (nint)obj33)
						{
							break;
						}
						obj27 = obj36 + 16;
						obj35--;
						bool flag18 = (nint)obj35 != 1;
						obj36 = obj27;
						if (flag18)
						{
							continue;
						}
						goto IL_07f8;
					}
					object obj37 = obj36 + 1;
					object obj38 = obj34 + obj37;
					object obj39 = obj38 + 312;
					economyConfig = (EconomyConfig)obj39;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v605 @ X0_v42] (should have been resolved before IL gen)");
					bool flag19 = ex == null;
					object obj40 = !flag19;
					obj27 = obj36;
					obj22 = 0;
					if (obj40 != null)
					{
						goto IL_083a;
					}
				}
				goto IL_0976;
			}
		}
		ex2 = new IndexOutOfRangeException();
		text4 = text3;
		goto IL_09c8;
		IL_0984:
		object obj41 = obj27 + 9;
		object obj42 = (object)economyConfig + obj41;
		obj11 = obj42 + 312;
		goto IL_0a95;
		IL_07f8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj43 = default(object);
		economyConfig = (EconomyConfig)obj43;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v589 @ X0_v39] (should have been resolved before IL gen)");
		bool flag20 = ex == null;
		obj22 = 0;
		if (!flag20)
		{
			goto IL_083a;
		}
		goto IL_0976;
		IL_09c8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_083a:
		object obj44 = typeof(System.IOAsyncCallback) + 368;
		nint num7 = (nint)ex;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X8_v27 (Il2CppClass<System.NullReferenceException>)+12E]");
		object obj45 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X8_v27 (Il2CppClass<System.NullReferenceException>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_08e2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X8_v27 (Il2CppClass<System.NullReferenceException>)+B0]");
		obj27 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X10_v11-8]");
			bool flag21 = 0 == (nint)obj44;
			obj22 = 0;
			economyConfig = (EconomyConfig)num7;
			if (flag21)
			{
				break;
			}
			obj27 += 16;
			obj45--;
			if ((nint)obj45 != 1)
			{
				continue;
			}
			goto IL_08e2;
		}
		goto IL_0984;
		IL_08e2:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj22 = 0;
		object obj46 = default(object);
		obj11 = obj46;
		goto IL_0a95;
	}

	private void SubmitTransaction(int coins)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		//IL_00ad: Expected O, but got I4
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_0103: Expected O, but got I
		//IL_0114: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 2968;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 24;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X22_v4-8]");
		if (ValidateInput(0))
		{
			object obj4 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v9+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PopupWindow.SetLoading(loading: true);
			object obj7 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj8 = (nint)0 + (nint)4032;
			Action<object> action = default(Action<object>);
			action..ctor(obj2, (IntPtr)obj8);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3 (System.Object)+10]");
			KammelnaRequests.ConvertCoinsToSubscription(0, action);
		}
	}

	private bool ValidateInput(int value)
	{
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_004f: Expected O, but got I4
		//IL_020d: Expected I4, but got O
		//IL_00fb: Expected O, but got I4
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected O, but got Unknown
		//IL_019c: Expected O, but got I4
		//IL_01c6: Expected I8, but got I4
		if (value > 0)
		{
			object obj = typeof(Queue<string>) + 848;
			object obj2 = (nint)0 + (nint)2200;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel = default(SessionModel);
			if ((object)sessionModel != null)
			{
				User localUser = sessionModel.LocalUser;
				int aces = SFSKammelnaUserExtensions.GetAces(localUser);
				if (value <= aces)
				{
					return true;
				}
				object obj5 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X0_v12+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				SessionModel sessionModel2 = default(SessionModel);
				if ((object)sessionModel2 != null)
				{
					User localUser2 = sessionModel2.LocalUser;
					int aces2 = SFSKammelnaUserExtensions.GetAces(localUser2);
					object obj7 = typeof(MemberAchievementClanFeedData) + 2608;
					object obj8 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X0_v18+E4]");
					bool flag3 = (nint)0 == 0;
					object obj9 = !flag3;
					if (obj9 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					long remaining = value - aces2;
					NotEnoughAcesPopup.ShowNotEnoughAces(remaining, TrackingFeature.CurrencyToSub);
					return false;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
		object errorMsg = "Picking audio files is not supported on iOS" + 576;
		ShowError((string)errorMsg);
		return false;
	}

	private void ShowError(string errorMsg)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		//IL_00d1: Expected O, but got I
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_010f: Expected O, but got I4
		//IL_0053: Expected I, but got O
		//IL_007d: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object obj2 = typeof(SqlSingle[]) + 2376;
		object obj3 = (nint)0 + (nint)1512;
		object obj4 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.SetError(errorMsg);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(null, (IntPtr)obj3);
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Coroutine coroutine = CoroutineDummy.WaitForSeconds(3f, action);
	}

	static CurrencyToSubscriptionUi()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		object obj = typeof(TypeConverter<ushort, char>) + 3048;
		object fldHandle = (nint)0 + (nint)1880;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3664;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		Array array = default(Array);
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)fldHandle);
		object obj3 = obj2;
		object obj4 = array;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private void <Submit>b__48_0()
	{
		SubmitTransaction(Coins);
	}
}
