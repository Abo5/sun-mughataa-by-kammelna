using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Threading;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using Server.Models;
using TMPro;
using Unity.Properties;
using UnityEngine;

public class ClanRulesHelpPopup : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<ClanTierConfig, int> <>9__6_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(CardUtils.<>c) + 1280;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal int <ApplyConfig>b__6_0(ClanTierConfig tier)
		{
			//IL_0035: Expected I4, but got O
			if (tier != null)
			{
				return tier.MaxMembers;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	private TextMeshProUGUI subscriptionBodyText;

	private TextMeshProUGUI membersBodyText;

	private PopupUI popup;

	private void Awake()
	{
		//IL_000c: Expected O, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_002c: Expected O, but got I
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		//IL_0053: Expected I, but got O
		//IL_007d: Expected O, but got I4
		object obj = (nint)0 + (nint)4008;
		object obj2 = typeof(SqlSingle[]) + 2376;
		object obj3 = (nint)0 + (nint)1552;
		object obj4 = typeof(RegisteredWaitHandle) + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj5 = this + 48;
		object obj6 = default(object);
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj3);
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v9+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RemoteConfig.OnChanged += action;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_006a: Expected I, but got O
		//IL_0094: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)1552;
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

	public void Show()
	{
		ApplyConfig();
		popup.SlideFromBottom();
	}

	private unsafe void ApplyConfig()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00da: Expected O, but got I4
		//IL_0097: Expected O, but got I4
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_017a: Expected O, but got I4
		//IL_01db: Expected I, but got O
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected O, but got Unknown
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Expected O, but got Unknown
		//IL_0389: Expected O, but got I4
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Expected O, but got Unknown
		//IL_03b9: Expected O, but got I
		//IL_03c9: Expected O, but got I
		//IL_03eb: Expected O, but got I4
		//IL_03f4: Expected O, but got I4
		//IL_04a9: Expected I, but got O
		//IL_0465: Expected O, but got I
		//IL_0332: Expected O, but got I
		//IL_0342: Expected O, but got I
		//IL_0364: Expected O, but got I4
		//IL_036d: Expected O, but got I4
		//IL_0521: Unknown result type (might be due to invalid IL or missing references)
		//IL_0526: Expected O, but got Unknown
		//IL_052f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0534: Expected O, but got Unknown
		//IL_0424: Expected O, but got I4
		//IL_05d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05de: Expected O, but got Unknown
		//IL_05f4: Expected O, but got I
		//IL_0605: Expected I, but got O
		//IL_0623: Expected O, but got I
		//IL_063e: Expected O, but got I4
		//IL_0454: Expected O, but got I
		object obj = typeof(RegisteredWaitHandle) + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8623]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v47+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v47+E4]");
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
		goto IL_055f;
		IL_056d:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_057b;
		IL_0402:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X0_v35+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		object obj7;
		object obj8;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj6 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X8_v27+B8]");
			obj8 = 0;
		}
		object obj9 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 736;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj10 = (nint)0 + (nint)504;
		Func<object, int> func = default(Func<object, int>);
		func..ctor(obj8, (IntPtr)obj10);
		object obj11 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ X8_v26+B8]");
		object obj12 = (nint)0 + (nint)8;
		obj12 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj13 = 0;
		Func<object, int> func2 = func;
		goto IL_0459;
		IL_057b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_0074:
		current = RemoteConfig.Current;
		bool flag3 = current == null;
		object obj14 = !flag3;
		if (obj14 != null)
		{
			goto IL_011d;
		}
		goto IL_055f;
		IL_011d:
		ClanConfigsResponse <Clans>k__BackingField = current.<Clans>k__BackingField;
		if (current.<Clans>k__BackingField == null)
		{
			return;
		}
		object obj15 = typeof(TypeConverter<ushort, char>) + 3400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj16 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object[] array = default(object[]);
		bool flag4 = array == null;
		int num2 = default(int);
		nint num = (nint)(&num2);
		if (flag4)
		{
			goto IL_055f;
		}
		object obj17 = default(object);
		bool flag5 = obj17 == null;
		nint num3 = (nint)(&num2);
		if (!flag5)
		{
			nint num4 = (nint)array;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v31 (Il2CppClass<System.Object[]>)+40]");
			num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			bool flag6 = ex == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v31 (Il2CppClass<System.Object[]>)+40]");
			num = 0;
			if (flag6)
			{
				goto IL_057b;
			}
		}
		bool flag7 = array.Length == 0;
		num = num3;
		if (flag7)
		{
			goto IL_056d;
		}
		object text = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3968;
		object obj18 = array + 32;
		obj18 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		TextMeshProExtensions.Localize(subscriptionBodyText, (string)text, array);
		List<ClanTierConfig> tiers = <Clans>k__BackingField.Tiers;
		if (<Clans>k__BackingField.Tiers != null && tiers._size >= 1)
		{
			obj7 = typeof(CardUtils.<>c) + 1280;
			object obj19 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X0_v35+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X0_v35+B8]");
				obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X8_v21+8]");
				func2 = (Func<object, int>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X8_v21+8]");
				bool flag8 = (nint)0 == 0;
				object obj20 = !flag8;
				obj13 = 0;
				if (obj20 == null)
				{
					goto IL_0402;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj19 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X0_v35+B8]");
				obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X8_v21+8]");
				func2 = (Func<object, int>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X8_v21+8]");
				bool flag9 = (nint)0 == 0;
				object obj21 = !flag9;
				obj13 = 0;
				if (obj21 == null)
				{
					goto IL_0402;
				}
			}
			goto IL_0459;
		}
		obj13 = 0;
		object[] array2 = array;
		goto IL_0591;
		IL_055f:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_056d;
		IL_0459:
		object obj22 = (nint)0 + (nint)1856;
		array2 = (object[])obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DCAA68");
		goto IL_0591;
		IL_0591:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object[] array3 = default(object[]);
		bool flag10 = array3 == null;
		object obj23 = default(object);
		num = (nint)(&obj23);
		if (flag10)
		{
			goto IL_055f;
		}
		object obj24 = default(object);
		bool flag11 = obj24 == null;
		nint num5 = (nint)(&obj23);
		if (!flag11)
		{
			nint num6 = (nint)array3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v13 (Il2CppClass<System.Object[]>)+40]");
			num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			bool flag12 = ex == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v13 (Il2CppClass<System.Object[]>)+40]");
			num = 0;
			if (flag12)
			{
				goto IL_057b;
			}
		}
		bool flag13 = array3.Length == 0;
		num = num5;
		if (!flag13)
		{
			object text2 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3960;
			object obj25 = array3 + 32;
			obj25 = obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			TextMeshProExtensions.Localize(membersBodyText, (string)text2, array3);
			return;
		}
		goto IL_056d;
	}
}
