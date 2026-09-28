using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using DataTracking;
using Features.GameReplay;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Server.Models;
using TMPro;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Rendering;
using UnityEngine.TextCore;
using UnityEngine.UI;

public class GrandGameModesArea : MonoBehaviour
{
	private class Item
	{
		public readonly int Id;

		public Toggle Toggle;

		public Button Button;

		public AnnouncementTimingsLabel Timer;

		public TextMeshProUGUI Name;

		public Item(int id)
		{
			Id = id;
		}

		public void Destroy()
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_01c1: Expected O, but got I4
			//IL_00b5: Expected O, but got I4
			//IL_00be: Expected O, but got I4
			//IL_00cc: Expected O, but got I4
			//IL_0269: Expected O, but got I4
			//IL_0337: Expected O, but got I4
			//IL_0214: Expected O, but got I4
			//IL_0222: Expected O, but got I4
			//IL_013d: Expected O, but got I4
			//IL_02c9: Expected O, but got I4
			//IL_02d2: Expected O, but got I4
			object obj = 152993792;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E859D]");
			object obj3 = (nint)0 & (nint)1;
			UnityEngine.Object button;
			UnityEngine.Object button2;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v16+E4]");
				bool flag = (nint)0 == 0;
				button = Button;
				button2 = Button;
				if (!flag)
				{
					goto IL_0091;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v16+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				button = Button;
				button2 = Button;
				if (obj5 != null)
				{
					goto IL_0091;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = button2 != null;
			bool flag4 = !flag3;
			object obj6 = 0;
			UnityEngine.Object obj7 = null;
			object obj8 = 0;
			if (flag4)
			{
				goto IL_00da;
			}
			goto IL_0230;
			IL_0296:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			UnityEngine.Object toggle;
			bool flag5 = toggle != null;
			bool flag6 = !flag5;
			object obj9 = !flag6;
			object obj10 = 0;
			if (obj9 == null)
			{
				return;
			}
			goto IL_014b;
			IL_00da:
			object obj11 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X0_v4+E4]");
			bool flag7 = (nint)0 == 0;
			UnityEngine.Object toggle2 = Toggle;
			toggle = Toggle;
			if (!flag7)
			{
				goto IL_011b;
			}
			goto IL_0296;
			IL_011b:
			bool flag8 = toggle2 != null;
			bool flag9 = !flag8;
			obj10 = 0;
			if (!flag9)
			{
				goto IL_014b;
			}
			return;
			IL_0091:
			bool flag10 = button != null;
			bool flag11 = !flag10;
			object obj12 = !flag11;
			obj6 = 0;
			obj7 = null;
			obj8 = 0;
			if (obj12 == null)
			{
				goto IL_00da;
			}
			goto IL_0230;
			IL_0230:
			GameObject gameObject = Button.gameObject;
			object obj13 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X8_v6+E4]");
			bool flag12 = (nint)0 == 0;
			object obj14 = !flag12;
			UnityEngine.Object obj15 = gameObject;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj15 = gameObject;
			}
			UnityEngine.Object.Destroy(obj15);
			toggle2 = Toggle;
			obj11 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X0_v4+E4]");
			bool flag13 = (nint)0 == 0;
			object obj16 = !flag13;
			obj6 = obj8;
			obj7 = null;
			toggle = Toggle;
			if (obj16 != null)
			{
				goto IL_011b;
			}
			goto IL_0296;
			IL_014b:
			GameObject gameObject2 = Toggle.gameObject;
			object obj17 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v12+E4]");
			if ((nint)0 != 0)
			{
				UnityEngine.Object.Destroy(gameObject2);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			UnityEngine.Object.Destroy(gameObject2);
		}
	}

	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<AppAnnouncementModel, bool> <>9__9_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 824;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <Repopulate>b__9_0(AppAnnouncementModel a)
		{
			//IL_003d: Expected I4, but got O
			if (a != null)
			{
				return a.IsActive();
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass10_0
	{
		public GrandGameModesArea <>4__this;

		public AppAnnouncementModel announcement;

		internal void <CreateNew>b__0()
		{
			AppAnnouncementModel appAnnouncementModel = announcement;
			<>4__this.OnButtonClick(appAnnouncementModel.<Id>k__BackingField);
		}
	}

	private sealed class <>c__DisplayClass11_0
	{
		public int announcementId;

		internal bool <OnButtonClick>b__0(AppAnnouncementModel model)
		{
			//IL_0053: Expected I4, but got O
			//IL_0031: Expected O, but got I4
			if (model != null)
			{
				object obj = model.<Id>k__BackingField - announcementId;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass12_0
	{
		public Item item;

		internal bool <RemoveExpiredAnnouncements>b__2(AppAnnouncementModel model)
		{
			//IL_007f: Expected I4, but got O
			//IL_005d: Expected O, but got I4
			Item item = this.item;
			if (this.item != null && model != null)
			{
				object obj = item.Id - model.<Id>k__BackingField;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass9_0
	{
		public AppAnnouncementModel announcement;

		internal bool <Repopulate>b__1(Item item)
		{
			//IL_007f: Expected I4, but got O
			//IL_005d: Expected O, but got I4
			if (item != null)
			{
				AppAnnouncementModel appAnnouncementModel = announcement;
				if (announcement != null)
				{
					object obj = item.Id - appAnnouncementModel.<Id>k__BackingField;
					return obj == null;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private Transform viewParent;

	private Button gameButtonPrefab;

	private TabsUI tabs;

	private Toggle tabPrefab;

	private readonly List<Item> _items;

	private List<AppAnnouncementModel> _appAnnouncementModels;

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_00b5: Expected O, but got I
		//IL_00cd: Expected I, but got O
		//IL_0063: Expected O, but got I4
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 712;
		object obj2 = (nint)0 + (nint)3832;
		object obj3 = typeof(Queue<string>) + 768;
		object obj4 = (nint)0 + (nint)2056;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		InAppAnnouncementsManager.OnAnnouncementsReceived += action;
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		InAppAnnouncementsManager inAppAnnouncementsManager = default(InAppAnnouncementsManager);
		IEnumerable<AppAnnouncementModel> activeGrandGameModes = inAppAnnouncementsManager.ActiveGrandGameModes;
		Repopulate(null);
	}

	private void OnEnable()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00cc: Expected O, but got I
		//IL_00f6: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_013f: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(Queue<string>) + 768;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E792B]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2056;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj4;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = (nint)0 + (nint)2056;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		InAppAnnouncementsManager inAppAnnouncementsManager = default(InAppAnnouncementsManager);
		bool flag3 = (object)inAppAnnouncementsManager == null;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00a0;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_00a0;
		IL_00a0:
		IEnumerable<AppAnnouncementModel> activeGrandGameModes = inAppAnnouncementsManager.ActiveGrandGameModes;
		Repopulate(null);
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_003e: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 712;
		object obj2 = (nint)0 + (nint)3832;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		InAppAnnouncementsManager.OnAnnouncementsReceived -= action;
	}

	private unsafe void Repopulate(IEnumerable<AppAnnouncementModel> appAnnouncementModels)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_010c: Expected O, but got I
		//IL_0124: Expected O, but got I
		//IL_0146: Expected O, but got I4
		//IL_014f: Expected O, but got I4
		//IL_0158: Expected O, but got I4
		//IL_0168: Expected O, but got I
		//IL_00e7: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_0074: Expected O, but got I
		//IL_0094: Expected O, but got I4
		//IL_009d: Expected O, but got I4
		//IL_00ad: Expected O, but got I
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected O, but got Unknown
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected O, but got Unknown
		//IL_0220: Expected I, but got O
		//IL_032e: Expected I, but got O
		//IL_033a: Expected O, but got I
		//IL_035a: Expected O, but got I
		//IL_037c: Expected O, but got I4
		//IL_0384: Expected O, but got I
		//IL_0394: Expected O, but got I
		//IL_02be: Expected I, but got O
		//IL_02e9: Expected O, but got I4
		//IL_0251: Expected O, but got I
		//IL_0271: Expected O, but got I
		//IL_0290: Expected O, but got I
		//IL_02a8: Expected O, but got I
		//IL_0478: Unknown result type (might be due to invalid IL or missing references)
		//IL_047d: Expected O, but got Unknown
		//IL_0485: Expected I, but got O
		//IL_0495: Expected O, but got I
		//IL_03b2: Expected O, but got I
		//IL_03d4: Expected O, but got I4
		//IL_0587: Expected O, but got I
		//IL_05ab: Expected O, but got I4
		//IL_05bc: Expected O, but got I4
		//IL_05c1: Expected I, but got O
		//IL_0307: Expected I, but got O
		//IL_13ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_13ef: Expected O, but got Unknown
		//IL_1405: Expected O, but got I
		//IL_1416: Expected I, but got O
		//IL_1434: Expected O, but got I
		//IL_06e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e7: Expected O, but got Unknown
		//IL_06f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fb: Expected O, but got Unknown
		//IL_070a: Unknown result type (might be due to invalid IL or missing references)
		//IL_070f: Expected O, but got Unknown
		//IL_071b: Expected O, but got I
		//IL_0727: Expected O, but got I
		//IL_0411: Expected I, but got O
		//IL_043a: Expected O, but got I4
		//IL_044b: Expected O, but got I4
		//IL_0453: Expected I, but got O
		//IL_03f4: Expected I, but got O
		//IL_0404: Expected O, but got I
		//IL_081c: Expected O, but got I
		//IL_05f0: Expected O, but got I4
		//IL_05fd: Expected I, but got O
		//IL_145b: Expected O, but got I
		//IL_147c: Expected O, but got I4
		//IL_148c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1491: Expected O, but got Unknown
		//IL_0903: Expected I, but got O
		//IL_1144: Expected O, but got I4
		//IL_0624: Expected O, but got I
		//IL_062d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0632: Expected O, but got Unknown
		//IL_064a: Expected O, but got I
		//IL_0674: Expected O, but got I4
		//IL_069c: Expected O, but got I
		//IL_06ad: Expected O, but got I4
		//IL_1541: Expected O, but got I
		//IL_1554: Unknown result type (might be due to invalid IL or missing references)
		//IL_1559: Expected O, but got Unknown
		//IL_04f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f9: Expected O, but got Unknown
		//IL_0513: Expected O, but got I4
		//IL_051c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Expected O, but got Unknown
		//IL_0d51: Expected O, but got I4
		//IL_0d72: Expected O, but got I4
		//IL_0d8b: Expected O, but got I4
		//IL_0dcc: Expected O, but got I4
		//IL_14ca: Expected O, but got I
		//IL_14eb: Expected O, but got I4
		//IL_14fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1500: Expected O, but got Unknown
		//IL_162e: Expected O, but got I4
		//IL_0959: Unknown result type (might be due to invalid IL or missing references)
		//IL_095e: Expected O, but got Unknown
		//IL_0915: Expected O, but got I4
		//IL_0922: Unknown result type (might be due to invalid IL or missing references)
		//IL_0927: Expected O, but got Unknown
		//IL_0930: Unknown result type (might be due to invalid IL or missing references)
		//IL_0935: Expected O, but got Unknown
		//IL_0de9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dee: Expected O, but got Unknown
		//IL_0e06: Expected O, but got I
		//IL_0888: Expected O, but got I
		//IL_08a2: Expected O, but got I4
		//IL_08ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b0: Expected O, but got Unknown
		//IL_0ea1: Expected I, but got O
		//IL_0f3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f41: Expected O, but got Unknown
		//IL_16e0: Expected O, but got I
		//IL_09ab: Expected O, but got I
		//IL_0f1f: Expected O, but got I4
		//IL_16a4: Expected O, but got I
		//IL_0a92: Expected I, but got O
		//IL_130f: Expected O, but got I4
		//IL_1318: Expected O, but got I4
		//IL_0f97: Expected O, but got I4
		//IL_0eb3: Expected O, but got I4
		//IL_0ec0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec5: Expected O, but got Unknown
		//IL_0ece: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed3: Expected O, but got Unknown
		//IL_15ed: Expected I4, but got O
		//IL_110f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1114: Expected O, but got Unknown
		//IL_0e6a: Expected O, but got I
		//IL_1586: Expected O, but got I
		//IL_15a7: Expected O, but got I4
		//IL_15b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_15bc: Expected O, but got Unknown
		//IL_1347: Expected O, but got I4
		//IL_0ae2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae7: Expected O, but got Unknown
		//IL_0aa4: Expected O, but got I4
		//IL_0ab1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab6: Expected O, but got Unknown
		//IL_0abf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac4: Expected O, but got Unknown
		//IL_0b19: Expected I, but got O
		//IL_0b21: Expected I, but got O
		//IL_0a17: Expected O, but got I
		//IL_0a31: Expected O, but got I4
		//IL_0a3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3f: Expected O, but got Unknown
		//IL_1214: Expected O, but got I4
		//IL_0c11: Expected O, but got I
		//IL_125b: Expected O, but got I4
		//IL_127b: Expected O, but got I4
		//IL_0b99: Expected O, but got I
		//IL_0bbc: Expected O, but got I
		//IL_0c7f: Expected O, but got I4
		//IL_0c9f: Expected O, but got I4
		//IL_0cb3: Expected O, but got I4
		//IL_07a5: Expected O, but got I4
		//IL_07de: Expected O, but got I4
		//IL_0d07: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d0c: Expected O, but got Unknown
		//IL_0d15: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d1a: Expected O, but got Unknown
		object obj = 152989696;
		object obj2 = typeof(Queue<string>) + 768;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E792D]");
		object obj3 = (nint)0 & (nint)1;
		object obj6;
		List<Item> list2;
		List<Item> list;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2056;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v100+E4]");
			list = (List<Item>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v100+E4]");
			bool flag = (nint)0 == 0;
			obj6 = 0;
			obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v100+E4]");
			list2 = (List<Item>)0;
			object obj7 = obj4;
			if (!flag)
			{
				goto IL_00c3;
			}
		}
		else
		{
			_ = 1;
			object obj4 = (nint)0 + (nint)2056;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v100+E4]");
			list = (List<Item>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v100+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			obj6 = 0;
			obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v100+E4]");
			list2 = (List<Item>)0;
			object obj7 = obj4;
			if (obj8 != null)
			{
				goto IL_00c3;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		InAppAnnouncementsManager inAppAnnouncementsManager = default(InAppAnnouncementsManager);
		bool flag3 = (object)inAppAnnouncementsManager == null;
		list = list2;
		if (!flag3)
		{
			goto IL_01bc;
		}
		goto IL_13d0;
		IL_11ea:
		NullReferenceException ex = new NullReferenceException();
		object obj10 = default(object);
		object obj9 = obj10;
		int num2;
		int num = num2;
		int num4 = default(int);
		int num3 = num4;
		object obj11 = 0;
		object obj13;
		object obj12 = obj13;
		Item item;
		IEnumerable<AppAnnouncementModel> enumerable = (IEnumerable<AppAnnouncementModel>)item;
		Func<object, bool> func2 = default(Func<object, bool>);
		Func<object, bool> func = func2;
		goto IL_1280;
		IL_1149:
		NullReferenceException ex2 = new NullReferenceException();
		obj9 = obj10;
		num = num2;
		num3 = num4;
		object obj14 = default(object);
		obj11 = obj14;
		nint num6;
		nint num5 = num6;
		obj12 = obj13;
		IEnumerable<AppAnnouncementModel> enumerable2 = default(IEnumerable<AppAnnouncementModel>);
		enumerable = enumerable2;
		Func<object, bool> func3;
		func = func3;
		object obj15 = default(object);
		list = (List<Item>)obj15;
		goto IL_1280;
		IL_1231:
		NullReferenceException ex3 = new NullReferenceException();
		obj9 = obj10;
		num = num2;
		num3 = num4;
		obj11 = 0;
		obj12 = obj13;
		enumerable = (IEnumerable<AppAnnouncementModel>)(object)func2;
		func = func2;
		int num7;
		list = (List<Item>)num7;
		goto IL_1280;
		IL_00c3:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag4 = (object)inAppAnnouncementsManager == null;
		object obj16 = !flag4;
		if (obj16 != null)
		{
			goto IL_01bc;
		}
		goto IL_13d0;
		IL_01bc:
		func = (Func<object, bool>)(typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 824);
		IEnumerable<AppAnnouncementModel> activeGrandGameModes = inAppAnnouncementsManager.ActiveGrandGameModes;
		List<object> list3 = Enumerable.ToList((IEnumerable<object>)activeGrandGameModes);
		object obj17 = this + 72;
		obj17 = list3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		RemoveExpiredAnnouncements();
		nint num8 = (nint)func;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X0_v39 (Il2CppClass<System.Func`2<System.Object, System.Boolean>>)+E4]");
		Func<object, bool> func4;
		List<Item> list4;
		if ((nint)0 != 0)
		{
			obj12 = (nint)0 + (nint)3240;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X0_v39 (Il2CppClass<System.Func`2<System.Object, System.Boolean>>)+B8]");
			nint num9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X8_v63 (Il2CppStaticFields<System.Func`2<System.Object, System.Boolean>>)+8]");
			func4 = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X8_v63 (Il2CppStaticFields<System.Func`2<System.Object, System.Boolean>>)+8]");
			bool flag5 = (nint)0 == 0;
			list = (List<Item>)num9;
			obj13 = obj12;
			nint num10 = num8;
			list4 = (List<Item>)num9;
			if (!flag5)
			{
				goto IL_02b6;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			nint num10 = (nint)func;
			obj12 = (nint)0 + (nint)3240;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X0_v85 (Il2CppClass<System.Func`2<System.Object, System.Boolean>>)+B8]");
			nint num11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v61 (Il2CppStaticFields<System.Func`2<System.Object, System.Boolean>>)+8]");
			func4 = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v61 (Il2CppStaticFields<System.Func`2<System.Object, System.Boolean>>)+8]");
			bool flag6 = (nint)0 == 0;
			object obj18 = !flag6;
			list = (List<Item>)num11;
			obj13 = obj12;
			list4 = (List<Item>)num11;
			if (obj18 != null)
			{
				goto IL_02b6;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X0_v85 (Il2CppClass<System.Func`2<System.Object, System.Boolean>>)+E4]");
		object[] array = (object[])0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X0_v85 (Il2CppClass<System.Func`2<System.Object, System.Boolean>>)+E4]");
		bool flag7 = (nint)0 == 0;
		object obj19 = !flag7;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			nint num12 = (nint)func;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X8_v59 (Il2CppClass<System.Func`2<System.Object, System.Boolean>>)+B8]");
			list4 = (List<Item>)0;
		}
		object obj20 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 120;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj21 = (nint)0 + (nint)2976;
		Func<object, bool> func5 = default(Func<object, bool>);
		func5..ctor((object)list4, (IntPtr)obj21);
		list = (List<Item>)(object)func;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v2 (System.Collections.Generic.List`1<GrandGameModesArea+Item>)+B8]");
		object obj22 = (nint)0 + (nint)8;
		obj22 = func5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		num6 = (nint)obj13;
		IEnumerable<object> enumerable3 = Enumerable.Where((IEnumerable<object>)obj17, func5);
		bool flag8 = enumerable3 == null;
		obj11 = 0;
		obj12 = obj13;
		obj14 = 0;
		num5 = (nint)obj13;
		enumerable = (IEnumerable<AppAnnouncementModel>)(object)func5;
		if (!flag8)
		{
			goto IL_0469;
		}
		goto IL_13d0;
		IL_119f:
		NullReferenceException ex4 = new NullReferenceException();
		obj9 = obj10;
		num = num2;
		num3 = num4;
		obj11 = obj14;
		num5 = num6;
		obj12 = obj13;
		enumerable = null;
		func = func3;
		goto IL_1280;
		IL_1105:
		object methodName = "Read object reference Id '{0}' for {1}." + 2288;
		CancelInvoke((string)methodName);
		Invoke((string)methodName, 60f);
		return;
		IL_0e92:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num6 = unchecked((nint)null);
		goto IL_16c8;
		IL_0dda:
		object obj23 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
		object obj25;
		object obj24 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X8_v15+12E]");
		array = (object[])0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X8_v15+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0e92;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X8_v15+B0]");
		int num13 = (int)((nint)0 + (nint)8);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v595 @ X10_v9 (System.Int32)-8]");
			obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v595 @ X10_v9 (System.Int32)-8]");
			if (0 == (nint)obj23)
			{
				break;
			}
			num4 = num13 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X8_v15+12E]");
			array = (object[])(-1);
			bool flag9 = (nint)array != 1;
			num13 = num4;
			if (flag9)
			{
				continue;
			}
			goto IL_0e92;
		}
		array = (object[])((int*)num13)->m_value;
		object obj26 = obj24 + ((int*)num13)->m_value;
		object obj27 = obj26 + 312;
		num4 = num13;
		num6 = num5;
		goto IL_16c8;
		IL_1614:
		object obj28;
		object obj30;
		object obj32;
		object obj34;
		object obj36;
		object obj38;
		int num14;
		object obj39;
		object obj40;
		object obj41;
		object obj42 = default(object);
		object obj44;
		object obj46;
		object obj31;
		object obj33;
		object obj35;
		object obj37;
		object obj45;
		while (true)
		{
			bool flag10 = obj28 == null;
			object obj29 = !flag10;
			obj10 = obj30;
			obj31 = obj32;
			obj33 = obj34;
			obj35 = obj36;
			obj37 = obj38;
			num = num2;
			num4 = num14;
			obj14 = obj39;
			num5 = num6;
			obj13 = obj40;
			func = func3;
			if (obj29 != null)
			{
				OutOfMemoryException ex5 = new OutOfMemoryException();
				if ((nint)enumerable == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
					obj41 = obj42;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
					bool flag11 = obj6 == null;
					object obj43 = !flag11;
					obj44 = 0;
					obj45 = obj42;
					obj25 = obj6;
					if (obj43 == null)
					{
						obj30 = obj10;
						obj46 = 0;
						obj32 = obj31;
						obj34 = obj33;
						obj36 = obj35;
						obj38 = obj37;
						num2 = num;
						obj45 = obj42;
						num14 = num4;
						obj39 = obj14;
						num6 = num5;
						obj40 = obj13;
						func3 = func;
						obj28 = obj42;
						continue;
					}
					goto IL_0dda;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
				return;
			}
			break;
		}
		if ((nint)obj46 != 6)
		{
			bool flag12 = obj46 == null;
			object obj47 = !flag12;
			if (obj47 != null)
			{
				return;
			}
		}
		object obj48 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj49 = obj48;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v647 @ X0_v3+E4]");
		if ((nint)0 != 0)
		{
			bool flag13 = tabs;
			bool flag14 = !flag13;
			object obj50 = !flag14;
			enumerable = null;
			if (obj50 != null)
			{
				goto IL_0fef;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag15 = tabs;
			bool flag16 = !flag15;
			enumerable = null;
			if (!flag16)
			{
				goto IL_0fef;
			}
		}
		goto IL_1105;
		IL_02b6:
		num6 = (nint)obj12;
		enumerable3 = Enumerable.Where((IEnumerable<object>)obj17, func4);
		bool flag17 = enumerable3 == null;
		object obj51 = !flag17;
		obj11 = obj14;
		if (obj51 != null)
		{
			goto IL_0469;
		}
		num5 = (nint)obj12;
		obj13 = obj12;
		enumerable = (IEnumerable<AppAnnouncementModel>)(object)func4;
		goto IL_13d0;
		IL_0469:
		object obj52 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2896;
		nint num15 = (nint)enumerable3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X8_v24 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
		object obj53 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X8_v24 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0565;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X8_v24 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+B0]");
		num3 = (int)((nint)0 + (nint)8);
		bool flag19 = default(bool);
		bool flag18 = flag19;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X10_v11 (System.Int32)-8]");
			obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X10_v11 (System.Int32)-8]");
			bool flag20 = 0 < (nint)obj52;
			object obj54 = !flag20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X10_v11 (System.Int32)-8]");
			object obj55 = 0 - obj52;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X10_v11 (System.Int32)-8]");
			if (0 == (nint)obj52)
			{
				break;
			}
			num4 = num3 + 16;
			obj53--;
			bool flag21 = (nint)obj53 < 1;
			obj54 = !flag21;
			obj55 = obj53 - 1;
			bool flag22 = obj55 == null;
			flag19 = (nint)obj53 != 1;
			flag18 = flag19;
			num3 = num4;
			if (flag19)
			{
				continue;
			}
			goto IL_0565;
		}
		object obj56 = num15 + ((int*)num3)->m_value;
		object obj57 = obj56 + 312;
		array = (object[])obj57;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ X8_v50+8]");
		enumerable = (IEnumerable<AppAnnouncementModel>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v660 @ X8_v50] (should have been resolved before IL gen)");
		object obj58 = default(object);
		bool flag23 = obj58 == null;
		num2 = (int)(&obj6);
		obj45 = 0;
		flag19 = flag18;
		num4 = num3;
		obj6 = obj58;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X10_v11 (System.Int32)-8]");
		obj9 = 0;
		num = (int)(&obj6);
		obj45 = 0;
		num5 = num6;
		obj6 = obj58;
		num7 = (int)(&obj6);
		if (!flag23)
		{
			goto IL_06d3;
		}
		goto IL_1133;
		IL_1133:
		NullReferenceException ex6 = new NullReferenceException();
		list = (List<Item>)num7;
		goto IL_1280;
		IL_0fef:
		list = _items;
		bool flag24 = _items == null;
		obj10 = obj30;
		obj31 = obj32;
		obj33 = obj34;
		obj35 = obj36;
		obj37 = obj38;
		num = num2;
		num4 = num14;
		obj14 = obj39;
		num5 = num6;
		obj13 = obj40;
		func = func3;
		if (!flag24)
		{
			bool flag25 = (object)tabs == null;
			obj10 = obj30;
			obj31 = obj32;
			obj33 = obj34;
			obj35 = obj36;
			obj37 = obj38;
			num = num2;
			num4 = num14;
			obj14 = obj39;
			num5 = num6;
			obj13 = obj40;
			func = func3;
			if (!flag25)
			{
				tabs.Activate(list._size);
				goto IL_1105;
			}
		}
		goto IL_13d0;
		IL_13d0:
		throw new NullReferenceException();
		IL_1280:
		obj10 = obj9;
		num4 = num3;
		obj14 = obj11;
		obj13 = obj12;
		goto IL_13d0;
		IL_0565:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj59 = default(object);
		array = (object[])obj59;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v576 @ X0_v81+8]");
		enumerable = (IEnumerable<AppAnnouncementModel>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v576 @ X0_v81] (should have been resolved before IL gen)");
		bool flag26 = obj58 == null;
		object obj60 = !flag26;
		num2 = (int)(&obj6);
		obj45 = 0;
		num6 = unchecked((nint)null);
		obj6 = obj58;
		if (obj60 != null)
		{
			goto IL_06d3;
		}
		obj9 = obj10;
		num = (int)(&obj6);
		obj45 = 0;
		num3 = num4;
		num5 = unchecked((nint)null);
		obj6 = obj58;
		num7 = (int)(&obj6);
		goto IL_1133;
		IL_06d3:
		obj13 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
		obj37 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 232;
		obj35 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 416;
		obj33 = (nint)0 + (nint)3008;
		obj31 = (nint)0 + (nint)1456;
		obj14 = obj11;
		func3 = func;
		object obj61 = obj58;
		object obj64 = default(object);
		<>c__DisplayClass9_0 <>c__DisplayClass9_ = default(<>c__DisplayClass9_0);
		object obj73 = default(object);
		while (true)
		{
			object obj62 = obj61;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v783 @ X8_v29+12E]");
			array = (object[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v783 @ X8_v29+12E]");
			if ((nint)0 == 0)
			{
				goto IL_08f4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v783 @ X8_v29+B0]");
			int num16 = (int)((nint)0 + (nint)8);
			bool flag27 = flag19;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v872 @ X10_v27 (System.Int32)-8]");
				obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v872 @ X10_v27 (System.Int32)-8]");
				bool flag28 = 0 < (nint)obj13;
				object obj54 = !flag28;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v872 @ X10_v27 (System.Int32)-8]");
				object obj55 = 0 - obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v872 @ X10_v27 (System.Int32)-8]");
				if (0 == (nint)obj13)
				{
					break;
				}
				num4 = num16 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v783 @ X8_v29+12E]");
				array = (object[])(-1);
				bool flag29 = (nint)array < 1;
				obj54 = !flag29;
				obj55 = array - 1;
				bool flag22 = obj55 == null;
				flag19 = (nint)array != 1;
				flag27 = flag19;
				num16 = num4;
				if (flag19)
				{
					continue;
				}
				goto IL_08f4;
			}
			array = (object[])((int*)num16)->m_value;
			object obj63 = obj62 + ((int*)num16)->m_value;
			obj64 = obj63 + 312;
			flag19 = flag27;
			num4 = num16;
			goto IL_1529;
			IL_15e5:
			num7 = (int)obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v973 @ X0_v52] (should have been resolved before IL gen)");
			if (<>c__DisplayClass9_ == null)
			{
				goto IL_1149;
			}
			object obj65 = <>c__DisplayClass9_ + 16;
			obj65 = enumerable2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			func2..ctor((object)<>c__DisplayClass9_, (IntPtr)obj33);
			num5 = (nint)obj31;
			object obj66 = Enumerable.FirstOrDefault(_items, func2);
			object obj67;
			if (obj66 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v986 @ X0_v61 (System.Object)+28]");
				if ((nint)0 != 0)
				{
					obj67 = obj65;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v986 @ X0_v61 (System.Object)+28]");
					object obj68 = (nint)0 + (nint)56;
					obj68 = obj65;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v986 @ X0_v61 (System.Object)+28]");
					((AnnouncementTimingsLabel)0).Refresh();
					goto IL_078d;
				}
				goto IL_1231;
			}
			item = CreateNew((AppAnnouncementModel)obj65);
			List<object> items = (List<object>)(object)_items;
			bool flag30 = _items == null;
			list = (List<Item>)obj15;
			if (!flag30)
			{
				object obj69 = (nint)0 + (nint)2408;
				list = (List<Item>)obj69;
				int version = items._version + 1;
				items._version = version;
				array = items._items;
				if (items._items != null)
				{
					num4 = items._size;
					obj10 = array.Length;
					bool flag31 = items._size < array.Length;
					object obj54 = !flag31;
					object obj55 = items._size - array.Length;
					bool flag22 = obj55 == null;
					if (obj54 != null)
					{
						object syncRoot = list._syncRoot;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1024 @ X8_v42 (System.Object)+C0]");
						num7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v757 @ X8_v26 (System.Int32)+70]");
						num5 = 0;
						((List<object>)(object)_items).AddWithResize((object)item);
						obj67 = item;
					}
					else
					{
						num7 = ++items._size;
						object obj70 = items._items + items._size;
						object obj71 = obj70 + 32;
						obj71 = item;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						obj67 = item;
					}
					goto IL_078d;
				}
			}
			goto IL_11ea;
			IL_078d:
			bool flag32 = obj6 == null;
			obj14 = 0;
			num6 = num5;
			func3 = func2;
			obj61 = obj6;
			obj9 = obj10;
			num = num2;
			num3 = num4;
			obj11 = 0;
			obj12 = obj13;
			enumerable = (IEnumerable<AppAnnouncementModel>)obj67;
			func = func2;
			if (!flag32)
			{
				continue;
			}
			goto IL_1133;
			IL_0a83:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num6 = unchecked((nint)null);
			goto IL_15e5;
			IL_08f4:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num6 = unchecked((nint)null);
			goto IL_1529;
			IL_1529:
			list = (List<Item>)obj64;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v901 @ X0_v46+8]");
			enumerable = (IEnumerable<AppAnnouncementModel>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v901 @ X0_v46] (should have been resolved before IL gen)");
			object obj72 = obj73 & 1;
			if (obj72 == null)
			{
				break;
			}
			list = (List<Item>)(typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 856);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			<>c__DisplayClass9_..ctor();
			if (obj6 == null)
			{
				goto IL_119f;
			}
			object obj74 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v916 @ X8_v34+12E]");
			array = (object[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v916 @ X8_v34+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0a83;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v916 @ X8_v34+B0]");
			int num17 = (int)((nint)0 + (nint)8);
			bool flag33 = flag19;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v958 @ X10_v22 (System.Int32)-8]");
				obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v958 @ X10_v22 (System.Int32)-8]");
				bool flag34 = 0 < (nint)obj37;
				object obj54 = !flag34;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v958 @ X10_v22 (System.Int32)-8]");
				object obj55 = 0 - obj37;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v958 @ X10_v22 (System.Int32)-8]");
				if (0 == (nint)obj37)
				{
					break;
				}
				num4 = num17 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v916 @ X8_v34+12E]");
				array = (object[])(-1);
				bool flag35 = (nint)array < 1;
				obj54 = !flag35;
				obj55 = array - 1;
				bool flag22 = obj55 == null;
				flag19 = (nint)array != 1;
				flag33 = flag19;
				num17 = num4;
				if (flag19)
				{
					continue;
				}
				goto IL_0a83;
			}
			array = (object[])((int*)num17)->m_value;
			object obj75 = obj74 + ((int*)num17)->m_value;
			obj15 = obj75 + 312;
			flag19 = flag33;
			num4 = num17;
			goto IL_15e5;
		}
		bool flag36 = obj6 == null;
		obj44 = 6;
		num = num2;
		num5 = num6;
		func = func3;
		obj41 = 0;
		obj25 = obj6;
		obj30 = obj10;
		obj46 = 6;
		obj32 = obj31;
		obj34 = obj33;
		obj36 = obj35;
		obj38 = obj37;
		num14 = num4;
		obj39 = obj14;
		obj40 = obj13;
		obj28 = 0;
		if (!flag36)
		{
			goto IL_0dda;
		}
		goto IL_1614;
		IL_16c8:
		list = (List<Item>)obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v654 @ X0_v27+8]");
		enumerable = (IEnumerable<AppAnnouncementModel>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v654 @ X0_v27] (should have been resolved before IL gen)");
		obj30 = obj10;
		obj46 = obj44;
		obj32 = obj31;
		obj34 = obj33;
		obj36 = obj35;
		obj38 = obj37;
		num2 = num;
		num14 = num4;
		obj39 = obj14;
		obj40 = obj13;
		func3 = func;
		obj28 = obj41;
		goto IL_1614;
	}

	private Item CreateNew(AppAnnouncementModel announcement)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00b4: Expected O, but got I
		//IL_0102: Expected O, but got I4
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected O, but got Unknown
		//IL_018f: Expected O, but got I
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected O, but got Unknown
		//IL_01ce: Expected O, but got I
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected O, but got Unknown
		//IL_0213: Expected O, but got I
		//IL_022e: Expected I, but got O
		//IL_026d: Expected O, but got I
		//IL_02d2: Expected O, but got I4
		//IL_038a: Expected O, but got I4
		//IL_0337: Expected O, but got I4
		//IL_034e: Expected O, but got I4
		//IL_0621: Unknown result type (might be due to invalid IL or missing references)
		//IL_0626: Expected O, but got Unknown
		//IL_041c: Expected O, but got I4
		//IL_06ea: Expected O, but got I
		//IL_06fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0702: Expected O, but got Unknown
		//IL_049a: Expected O, but got I
		//IL_04ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b2: Expected O, but got Unknown
		//IL_0503: Expected O, but got I
		//IL_0590: Expected O, but got I
		//IL_0599: Expected O, but got I4
		object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 832;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass10_0 <>c__DisplayClass10_ = default(<>c__DisplayClass10_0);
		<>c__DisplayClass10_..ctor();
		object obj3;
		object obj6;
		Item item = default(Item);
		object obj10;
		object obj13;
		if (<>c__DisplayClass10_ != null)
		{
			object obj2 = <>c__DisplayClass10_ + 16;
			obj2 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj3 = <>c__DisplayClass10_ + 24;
			obj3 = announcement;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj4 = obj3;
			if (obj3 != null)
			{
				object obj5 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 864;
				obj6 = typeof(MemberAchievementClanFeedData) + 2976;
				object obj7 = (nint)0 + (nint)888;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v4+10]");
				item..ctor(0);
				object obj8 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X0_v13+E4]");
				bool flag = (nint)0 == 0;
				object obj9 = !flag;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9DE4");
				if (item != null)
				{
					obj10 = item + 32;
					object obj11 = default(object);
					obj10 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					if (obj10 != null)
					{
						object obj12 = (nint)0 + (nint)304;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D31418");
						obj13 = item + 40;
						object obj14 = default(object);
						obj13 = obj14;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X22_v7-8]");
						object obj15 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X22_v7-8]");
						if ((nint)0 != 0)
						{
							object obj16 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
							object obj17 = (nint)0 + (nint)2984;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							UnityAction unityAction = default(UnityAction);
							unityAction..ctor(<>c__DisplayClass10_, (IntPtr)obj17);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v8+100]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v8+100]");
								((UnityEvent)0).AddListener(unityAction);
								if (obj10 != null)
								{
									Image image = ((Selectable)obj10).image;
									UIExtensions.LoadAppAnnouncementImage(image, (AppAnnouncementModel)obj3);
									bool flag2 = tabs;
									bool flag3 = !flag2;
									object obj18 = 0;
									GameObject gameObject = null;
									if (!flag3)
									{
										object obj19 = obj6;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v10+E4]");
										if ((nint)0 != 0)
										{
											bool flag4 = tabPrefab;
											bool flag5 = !flag4;
											object obj20 = !flag5;
											if (obj20 != null)
											{
												goto IL_039d;
											}
											obj18 = 0;
											gameObject = null;
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											bool flag6 = tabPrefab;
											bool flag7 = !flag6;
											obj18 = 0;
											gameObject = null;
											if (!flag7)
											{
												goto IL_039d;
											}
										}
									}
									goto IL_05a6;
								}
							}
						}
					}
				}
			}
		}
		goto IL_06a0;
		IL_05a6:
		if (obj13 != null)
		{
			GameObject gameObject2 = ((Component)obj13).gameObject;
			if ((object)gameObject2 != null)
			{
				gameObject2.SetActive(value: false);
				if (obj13 != null)
				{
					object obj21 = obj13 + 56;
					obj21 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					((AnnouncementTimingsLabel)obj13).Refresh();
					if (obj13 != null)
					{
						GameObject gameObject3 = ((Component)obj13).gameObject;
						if ((object)gameObject3 != null)
						{
							gameObject3.SetActive(value: true);
							return item;
						}
					}
				}
			}
		}
		goto IL_06a0;
		IL_06a0:
		return (Item)(object)new NullReferenceException();
		IL_039d:
		if (obj10 != null)
		{
			GameObject gameObject4 = ((Component)obj10).gameObject;
			if ((object)gameObject4 != null)
			{
				gameObject4.SetActive(value: false);
				object obj22 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X8_v11+E4]");
				bool flag8 = (nint)0 == 0;
				object obj23 = !flag8;
				if (obj23 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj24 = (nint)0 + (nint)1056;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9DE4");
				object obj25 = item + 24;
				object obj26 = default(object);
				obj25 = obj26;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				if (obj25 != null)
				{
					GameObject gameObject5 = ((Component)obj25).gameObject;
					if ((object)gameObject5 != null)
					{
						gameObject5.SetActive(value: true);
						if (obj25 != null)
						{
							object obj27 = (nint)0 + (nint)384;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D31418");
							object obj28 = item + 48;
							object obj29 = default(object);
							obj28 = obj29;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							object obj30 = obj3;
							if (obj3 != null)
							{
								object textMesh = obj28;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v16+18]");
								TextMeshProExtensions.FixArabic((TextMeshProUGUI)textMesh, (string)0);
								object obj31 = obj3;
								if (obj3 != null && obj10 != null)
								{
									GameObject gameObject6 = ((Component)obj10).gameObject;
									if ((object)tabs != null)
									{
										TabsUI tabsUI = tabs;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X8_v17+18]");
										tabsUI.AddTab((string)0, (Toggle)obj25, gameObject6);
										object obj18 = 0;
										GameObject gameObject = gameObject6;
										goto IL_05a6;
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_06a0;
	}

	private void OnButtonClick(int announcementId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0045: Expected O, but got I
		//IL_006d: Expected I, but got O
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_00dc: Expected O, but got I4
		//IL_011b: Expected O, but got I4
		//IL_011b: Expected O, but got I
		object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 840;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass11_0 <>c__DisplayClass11_ = default(<>c__DisplayClass11_0);
		<>c__DisplayClass11_..ctor();
		object obj2 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 120;
		object obj3 = (nint)0 + (nint)2992;
		object obj4 = (nint)0 + (nint)512;
		<>c__DisplayClass11_.announcementId = announcementId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor((object)<>c__DisplayClass11_, (IntPtr)obj3);
		object obj5 = Enumerable.Single(_appAnnouncementModels, func);
		object obj6 = typeof(RegisteredWaitHandle) + 1552;
		object obj7 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v10+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v9 (System.Object)+58]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v9 (System.Object)+60]");
		RoutingManager.Route((RoutingCommand)num, (string)0, (Games?)(object)0);
		ITrackEvent trackEvent = TrackerLibrary.MenuAnnouncementButtonClicked(<>c__DisplayClass11_.announcementId);
		object obj10 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v9+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
	}

	private void RemoveExpiredAnnouncements()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002c: Expected O, but got I
		//IL_0038: Expected O, but got I
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_0058: Expected O, but got I
		//IL_00b3: Expected I, but got O
		//IL_0087: Expected I, but got O
		object obj = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 416;
		object obj2 = (nint)0 + (nint)3816;
		object obj3 = (nint)0 + (nint)3912;
		object obj4 = (nint)0 + (nint)2912;
		object obj5 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 32;
		object obj6 = (nint)0 + (nint)3824;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor((object)this, (IntPtr)obj2);
		IEnumerable<object> source = Enumerable.Where(_items, func);
		List<object> list = Enumerable.ToList(source);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj6);
		list.ForEach(action);
	}

	public GrandGameModesArea()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		object obj = typeof(List<Tween>) + 872;
		object obj2 = typeof(List<AdaptivePerformanceScaler>) + 88;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj3 = this + 64;
		obj3 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list2 = default(List<object>);
		list2..ctor();
		object obj4 = this + 72;
		obj4 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}

	private bool <RemoveExpiredAnnouncements>b__12_0(Item item)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00e3: Expected I4, but got O
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_007a: Expected I, but got O
		object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass12_0 <>c__DisplayClass12_ = default(<>c__DisplayClass12_0);
		<>c__DisplayClass12_..ctor();
		if (<>c__DisplayClass12_ != null)
		{
			object obj2 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 120;
			object obj3 = (nint)0 + (nint)3000;
			object obj4 = <>c__DisplayClass12_ + 16;
			obj4 = item;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor((object)<>c__DisplayClass12_, (IntPtr)obj3);
			object obj5 = Enumerable.FirstOrDefault(_appAnnouncementModels, func);
			if (obj5 != null)
			{
				bool flag = ((AppAnnouncementModel)obj5).IsActive();
				return (byte)((flag ? 1u : 0u) ^ 1u) != 0;
			}
			return true;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private void <RemoveExpiredAnnouncements>b__12_1(Item item)
	{
		item.Destroy();
		bool flag = ((List<object>)(object)_items).Remove((object)item);
	}
}
