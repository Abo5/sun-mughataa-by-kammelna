using System;
using System.Buffers.Text;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DataTracking;
using GoogleMobileAds.Ump.Api;
using Server.Models;
using TMPro;
using UI.Popups;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;

public class CurrencyBombSuccessfullyClaimedPopup : MonoBehaviour
{
	private sealed class <>c__DisplayClass6_0
	{
		public BombClaimedFeedData giftBomb;

		internal void <Show>b__0(CurrencyBombSuccessfullyClaimedPopup instance)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected O, but got Unknown
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Expected O, but got Unknown
			//IL_0078: Expected O, but got I
			//IL_008c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0091: Expected O, but got Unknown
			//IL_009d: Expected O, but got I
			//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Expected O, but got Unknown
			//IL_00c2: Expected O, but got I
			//IL_00e6: Expected I, but got O
			//IL_0110: Expected O, but got I4
			object obj = typeof(CardUtils.<>c) + 2952;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj2 + 24;
			obj3 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj4 = obj2 + 16;
			obj4 = instance;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v4+20]");
			object obj6 = 0;
			object obj7 = typeof(SqlSingle[]) + 2376;
			object obj8 = (nint)0 + (nint)4016;
			object obj9 = typeof(System.Buffers.Text.ParserHelpers) + 1424;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v5+28]");
			GameObject gameObject = ((Component)0).gameObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action action = default(Action);
			action..ctor(obj2, (IntPtr)obj8);
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v15+E4]");
			bool flag = (nint)0 == 0;
			object obj11 = !flag;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PopupStack.Push(gameObject, action);
		}
	}

	private sealed class <>c__DisplayClass6_1
	{
		public CurrencyBombSuccessfullyClaimedPopup instance;

		public <>c__DisplayClass6_0 CS$<>8__locals1;

		internal void <Show>b__1()
		{
			<>c__DisplayClass6_0 cS$<>8__locals = CS$<>8__locals1;
			instance.Populate(cS$<>8__locals.giftBomb);
		}
	}

	private static readonly AddressReference<CurrencyBombSuccessfullyClaimedPopup> Address;

	private PopupUI popup;

	private PlayerProfileControls profile;

	private TextMeshProUGUI aces;

	private TextMeshProUGUI bomberMessage;

	private string _userDbId;

	public static void Show(BombClaimedFeedData giftBomb)
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
		object obj = typeof(CardUtils.<>c) + 2944;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3648;
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1760;
		object obj5 = (nint)0 + (nint)4008;
		object obj6 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj7 = obj2 + 16;
		obj7 = giftBomb;
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
		object obj10 = (nint)0 + (nint)2024;
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

	private unsafe void Populate(BombClaimedFeedData giftBomb)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0505: Expected O, but got I4
		//IL_0029: Expected O, but got I4
		//IL_004a: Expected O, but got Ref
		//IL_006f: Expected O, but got Ref
		//IL_0085: Expected I, but got O
		//IL_0095: Expected O, but got I
		//IL_00be: Expected O, but got I
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_0293: Expected O, but got I4
		//IL_01e0: Expected O, but got I4
		//IL_01e8: Expected I, but got O
		//IL_02cd: Expected O, but got I4
		//IL_02d5: Expected I, but got O
		//IL_021b: Expected O, but got I4
		//IL_0223: Expected I, but got O
		//IL_0310: Expected O, but got I4
		//IL_0318: Expected I, but got O
		//IL_0249: Expected I, but got O
		//IL_0352: Expected I, but got O
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected O, but got Unknown
		//IL_03a7: Expected O, but got I4
		//IL_03df: Expected O, but got I
		//IL_03f9: Expected O, but got I4
		//IL_03fe: Expected I, but got O
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0420: Expected O, but got Unknown
		//IL_0455: Expected O, but got I4
		//IL_04ab: Expected F8, but got I4
		object obj = typeof(TypeConverter<ushort, char>) + 3400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		bool flag = giftBomb == null;
		string text = (string)1;
		object[] array = default(object[]);
		Component component;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		object obj8;
		nint num3;
		if (!flag)
		{
			object obj2 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			bool flag2 = array == null;
			int num = default(int);
			text = (string)(&num);
			if (!flag2)
			{
				object obj3 = default(object);
				bool flag3 = obj3 == null;
				string text2 = (string)(&num);
				if (!flag3)
				{
					nint num2 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v19 (Il2CppClass<System.Object[]>)+40]");
					text2 = (string)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag4 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v19 (Il2CppClass<System.Object[]>)+40]");
					text = (string)0;
					if (flag4)
					{
						goto IL_04cd;
					}
				}
				bool flag5 = array.Length == 0;
				text = text2;
				if (flag5)
				{
					goto IL_04bf;
				}
				object text3 = "WhiteSmoke" + 1888;
				object obj4 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
				object obj5 = array + 32;
				obj5 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				TextMeshProExtensions.Localize(aces, (string)text3, array);
				object obj6 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v11+E4]");
				string text4;
				Component component2;
				if ((nint)0 != 0)
				{
					bool flag6 = StringsExtensions.IsNullOrEmpty(giftBomb.<Message>k__BackingField);
					component = bomberMessage;
					bool flag7 = !flag6;
					text = null;
					text4 = null;
					component2 = bomberMessage;
					if (!flag7)
					{
						goto IL_01c8;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					bool flag8 = StringsExtensions.IsNullOrEmpty(giftBomb.<Message>k__BackingField);
					component = bomberMessage;
					bool flag9 = !flag8;
					object obj7 = !flag9;
					text = null;
					text4 = null;
					component2 = bomberMessage;
					if (obj7 != null)
					{
						goto IL_01c8;
					}
				}
				bool flag10 = (object)component2 == null;
				obj8 = 0;
				num3 = (nint)array;
				text = text4;
				if (!flag10)
				{
					GameObject gameObject = component2.gameObject;
					bool flag11 = (object)gameObject == null;
					obj8 = 0;
					num3 = (nint)array;
					text = null;
					if (!flag11)
					{
						gameObject.SetActive(value: true);
						TextMeshProExtensions.FixArabic(bomberMessage, giftBomb.<Message>k__BackingField);
						num3 = unchecked((nint)null);
						goto IL_0357;
					}
				}
			}
		}
		goto IL_04b1;
		IL_04bf:
		ex = new IndexOutOfRangeException();
		goto IL_04cd;
		IL_04b1:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_04bf;
		IL_0357:
		long num4 = default(long);
		string text5 = num4.ToString();
		object obj9 = this + 64;
		obj9 = text5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X21_v8-18]");
		bool flag12 = (nint)0 == 0;
		obj8 = 0;
		text = text5;
		if (!flag12)
		{
			text = _userDbId;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X21_v8-18]");
			((PlayerProfileControls)0).Populate(_userDbId);
			bool flag13 = (object)popup == null;
			obj8 = 0;
			num3 = unchecked((nint)null);
			if (!flag13)
			{
				object obj10 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
				popup.PopFromCenter();
				object obj11 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X0_v26+E4]");
				bool flag14 = (nint)0 == 0;
				object obj12 = !flag14;
				if (obj12 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				string itemId = Tracker.ItemId(ResourceItemId.BombClaim);
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
				Tracker.ResourceEvent(ResourceFlowType.Source, ResourceItemType.Reward, itemId, giftBomb.<Amount>k__BackingField, ResourceCurrency.Aces);
				return;
			}
		}
		goto IL_04b1;
		IL_01c8:
		bool flag15 = (object)component == null;
		obj8 = 0;
		num3 = (nint)array;
		if (!flag15)
		{
			GameObject gameObject2 = component.gameObject;
			bool flag16 = (object)gameObject2 == null;
			obj8 = 0;
			num3 = (nint)array;
			text = null;
			if (!flag16)
			{
				gameObject2.SetActive(value: false);
				num3 = unchecked((nint)null);
				goto IL_0357;
			}
		}
		goto IL_04b1;
		IL_04cd:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
	}

	public void ShowFullProfile()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_004e: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1040;
		popup.ShrinkToParent();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayerProfile.ShowDetailProfile(_userDbId, TrackingPlacement.ChatTopBombers);
	}

	public void Hide()
	{
		popup.ShrinkToParent();
	}

	static CurrencyBombSuccessfullyClaimedPopup()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		object obj = "Complete" + 3416;
		object obj2 = typeof(ConsentForm.<Show>c__AnonStorey2.<Show>c__AnonStorey3) + 3024;
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3648;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4933C3C");
		object obj4 = obj3;
		object obj6 = default(object);
		object obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
