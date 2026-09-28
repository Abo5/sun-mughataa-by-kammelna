using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Unity.Properties;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Events;
using UnityEngine.InputSystem.UI;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class TransferOwnershipPanel : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<ClanUserModel, bool> <>9__22_0;

		public static Func<ClanUserModel, bool> <>9__23_0;

		public static Func<SelectableUser, bool> <>9__25_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(TrackedDeviceRaycaster.<>c) + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <PopulateMembers>b__22_0(ClanUserModel m)
		{
			//IL_0044: Expected I4, but got O
			if (m != null)
			{
				return !m.IsOwner;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <OwnerFirst>b__23_0(ClanUserModel m)
		{
			//IL_0035: Expected I4, but got O
			if (m != null)
			{
				return m.IsOwner;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <SelectFirstMember>b__25_0(SelectableUser item)
		{
			//IL_008b: Expected I4, but got O
			if ((object)item != null)
			{
				GameObject gameObject = item.gameObject;
				if ((object)gameObject != null)
				{
					if (gameObject.activeSelf)
					{
						return item.<IsSelectable>k__BackingField;
					}
					return false;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private const string OWNERSHIP_TRANSFERRED_KEY = "ownership_transferred";

	private const string TRANSFER_FAILED_TITLE_KEY = "transfer_ownership_failed_title";

	private const string TRANSFER_FAILED_CONTENT_KEY = "transfer_ownership_failed_content";

	private const string TRANSFER_CONFIRM_CONTENT_KEY = "transfer_ownership_confirm_content";

	private const string TRANSFER_CONFIRM_BUTTON_KEY = "transfer_ownership_confirm_button";

	private SelectableUser itemPrefab;

	private Transform layout;

	private ToggleGroup toggleGroup;

	private Button transferButton;

	private ElegantLoadingIndicator loader;

	private SlideAnimationHelper slideAnim;

	private GameObject noClanMemberMessage;

	private GameObject searchBox;

	private InputFieldTMProUGUI searchInput;

	private readonly List<SelectableUser> _spawned;

	private ClanUserModel _selected;

	private Action<ClanModel> _onTransferred;

	private void Awake()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		//IL_007b: Expected I, but got O
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_00a0: Expected O, but got I
		//IL_00cf: Expected I, but got O
		Button button = transferButton;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)1976;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		button.m_OnClick.RemoveListener(unityAction);
		Button button2 = transferButton;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction2 = default(UnityAction);
		unityAction2..ctor(this, (IntPtr)obj2);
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj4 = (nint)0 + (nint)1968;
		button2.m_OnClick.AddListener(unityAction2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj4);
		searchInput.OnValueChanged += action;
	}

	private void OnDestroy()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_0062: Expected O, but got I
		//IL_0091: Expected I, but got O
		Button button = transferButton;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)1976;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj4 = (nint)0 + (nint)1968;
		button.m_OnClick.RemoveListener(unityAction);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj4);
		searchInput.OnValueChanged -= action;
		ClearSpawned();
	}

	public void Initialize(Action<ClanModel> onTransferred = null)
	{
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected O, but got Unknown
		//IL_0016: Expected O, but got I
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0035: Expected O, but got I4
		//IL_005a: Expected O, but got I
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_007f: Expected O, but got I
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_009f: Expected O, but got I
		//IL_00d4: Expected O, but got I4
		//IL_0118: Expected I, but got O
		object obj = this + 120;
		Action<ClanModel> action = default(Action<ClanModel>);
		obj = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X20_v3-30]");
		((SlideAnimationHelper)0).SlideIn();
		ClearSpawned();
		object obj2 = this + 112;
		obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X20_v6-38]");
		((Selectable)0).interactable = false;
		object obj3 = typeof(Queue<string>) + 728;
		object obj4 = (nint)0 + (nint)1976;
		object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1552;
		object obj6 = (nint)0 + (nint)2000;
		searchInput.ClearInput();
		object obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v12+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj6);
		ClanServerConnector clanServerConnector = default(ClanServerConnector);
		clanServerConnector.GetMyClan(action2);
	}

	private void OnSearchChanged(string query)
	{
		//IL_0012: Expected O, but got I
		//IL_001e: Expected O, but got I
		//IL_00da: Expected O, but got I4
		object obj2 = default(object);
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		string text2 = default(string);
		if (_spawned != null)
		{
			object obj = (nint)0 + (nint)1080;
			obj2 = (nint)0 + (nint)1072;
			List<object>.Enumerator enumerator = ((List<object>)(object)_spawned).GetEnumerator();
			string text = (string)obj;
			if (!enumerator2.MoveNext())
			{
				enumerator2.Dispose();
				return;
			}
			Component component = null;
			NullReferenceException ex = new NullReferenceException();
			object obj3 = 0;
			text2 = text;
		}
		NullReferenceException ex2 = new NullReferenceException();
		bool flag = (nint)text2 != 1;
		OutOfMemoryException ex3 = (OutOfMemoryException)(object)ex2;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			text2 = (string)obj2;
			enumerator2.Dispose();
			object obj4 = default(object);
			if (obj4 == null)
			{
				return;
			}
			ex3 = new OutOfMemoryException();
			object obj3 = obj4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223D988");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	private void ResetSelection()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_001a: Expected O, but got I4
		//IL_003f: Expected O, but got I
		ClearSpawned();
		object obj = this + 112;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ X19_v2-38]");
		((Selectable)0).interactable = false;
	}

	private unsafe void PopulateMembers(ClanModel clan)
	{
		//IL_0011: Expected O, but got I
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0100: Expected O, but got I
		//IL_0110: Expected O, but got I
		//IL_0120: Expected O, but got I
		//IL_0142: Expected O, but got I4
		//IL_007d: Expected O, but got I
		//IL_008d: Expected O, but got I
		//IL_009d: Expected O, but got I
		//IL_00bf: Expected O, but got I4
		//IL_0182: Expected O, but got I4
		//IL_0236: Expected O, but got I4
		//IL_023e: Expected O, but got I4
		//IL_0422: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Expected O, but got Unknown
		//IL_043d: Expected O, but got I
		//IL_044e: Expected I, but got O
		//IL_046c: Expected O, but got I
		//IL_01b2: Expected O, but got I
		//IL_027b: Expected O, but got I4
		//IL_0283: Expected O, but got I4
		//IL_03a8: Expected O, but got I4
		//IL_02d2: Expected O, but got I4
		//IL_02e5: Expected O, but got I4
		//IL_02ee: Expected O, but got I4
		//IL_02f6: Expected O, but got Ref
		//IL_02fe: Expected O, but got Ref
		if (clan == null)
		{
			return;
		}
		object obj = (nint)0 + (nint)2000;
		object obj2 = typeof(TrackedDeviceRaycaster.<>c) + 40;
		IEnumerable<ClanUserModel> source = OwnerFirst(clan);
		List<object> list = Enumerable.ToList((IEnumerable<object>)source);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X0_v38+E4]");
		object obj4;
		Func<object, bool> func;
		object obj7;
		object obj8;
		object obj5;
		if ((nint)0 != 0)
		{
			obj4 = (nint)0 + (nint)2552;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X0_v38+B8]");
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v7+8]");
			func = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v7+8]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			if (obj6 == null)
			{
				obj7 = obj4;
				obj8 = obj5;
				goto IL_0160;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj2;
			obj7 = (nint)0 + (nint)2552;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X0_v38+B8]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v12+8]");
			func = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v12+8]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			obj4 = obj7;
			obj5 = obj8;
			if (obj9 == null)
			{
				goto IL_0160;
			}
		}
		goto IL_01b7;
		IL_0160:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X0_v38+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj11 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X8_v18+B8]");
			obj8 = 0;
		}
		object obj12 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 760;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj13 = (nint)0 + (nint)680;
		Func<object, bool> func2 = default(Func<object, bool>);
		func2..ctor(obj8, (IntPtr)obj13);
		obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v7+B8]");
		object obj14 = (nint)0 + (nint)8;
		obj14 = func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj4 = obj7;
		func = func2;
		goto IL_01b7;
		IL_034c:
		NullReferenceException ex = new NullReferenceException();
		Func<object, bool> func3;
		bool flag4 = (nint)func3 != 1;
		NullReferenceException ex2 = ex;
		bool flag5;
		List<object>.Enumerator enumerator = default(List<object>.Enumerator);
		if (!flag4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			func3 = (Func<object, bool>)((bool*)(flag5 ? 1 : 0))->m_value;
			enumerator.Dispose();
			object obj15 = default(object);
			bool flag6 = obj15 == null;
			object obj16 = obj15;
			if (flag6)
			{
				goto IL_0303;
			}
			OutOfMemoryException ex3 = new OutOfMemoryException();
			obj16 = obj15;
			ex2 = (NullReferenceException)(object)ex3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223D9C8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_0303:
		if ((object)searchInput != null)
		{
			string text = searchInput.Text;
			OnSearchChanged(text);
			SelectFirstMember();
			return;
		}
		goto IL_034c;
		IL_01b7:
		object obj17 = obj4;
		bool flag7 = Enumerable.Any(list, func);
		bool flag8 = (object)noClanMemberMessage == null;
		func3 = func;
		flag5 = flag7;
		if (!flag8)
		{
			bool flag9 = (byte)((flag7 ? 1u : 0u) ^ 1u) != 0;
			noClanMemberMessage.SetActive(flag9);
			bool flag10 = (object)searchBox == null;
			obj17 = 0;
			func3 = (Func<object, bool>)flag9;
			flag5 = flag7;
			if (!flag10)
			{
				searchBox.SetActive(flag7);
				bool flag11 = list == null;
				obj17 = 0;
				func3 = (Func<object, bool>)flag7;
				flag5 = flag7;
				if (!flag11)
				{
					flag5 = (byte)((nuint)0u + (nuint)8u) != 0;
					List<object>.Enumerator enumerator2 = list.GetEnumerator();
					while (enumerator.MoveNext())
					{
						SpawnMemberItem(null);
					}
					func3 = (Func<object, bool>)((bool*)(flag5 ? 1 : 0))->m_value;
					enumerator.Dispose();
					object obj16 = 0;
					obj17 = 0;
					obj2 = (object)(&enumerator);
					obj5 = (object)(&enumerator);
					goto IL_0303;
				}
			}
		}
		goto IL_034c;
	}

	private static IEnumerable<ClanUserModel> OwnerFirst(ClanModel clan)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00da: Expected O, but got I
		//IL_00ea: Expected O, but got I
		//IL_00fa: Expected O, but got I
		//IL_011c: Expected O, but got I4
		//IL_005f: Expected O, but got I
		//IL_006f: Expected O, but got I
		//IL_007f: Expected O, but got I
		//IL_00a1: Expected O, but got I4
		//IL_0154: Expected O, but got I4
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		//IL_01f4: Expected O, but got I
		//IL_0205: Expected I, but got O
		//IL_0223: Expected O, but got I
		//IL_0184: Expected O, but got I
		ClanModel clanModel = default(ClanModel);
		object obj;
		IEnumerable<ClanUserModel> getMembers;
		object obj4;
		Func<object, bool> keySelector;
		object obj6;
		object obj3;
		if (clanModel != null)
		{
			obj = typeof(TrackedDeviceRaycaster.<>c) + 40;
			getMembers = clanModel.GetMembers;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v8+E4]");
			if ((nint)0 != 0)
			{
				obj3 = (nint)0 + (nint)2384;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v8+B8]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v6+10]");
				keySelector = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v6+10]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 == null)
				{
					obj6 = obj3;
					goto IL_0132;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
				obj6 = (nint)0 + (nint)2384;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v8+B8]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v6+10]");
				keySelector = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v6+10]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				obj3 = obj6;
				if (obj7 == null)
				{
					goto IL_0132;
				}
			}
			goto IL_0189;
		}
		return (IEnumerable<ClanUserModel>)new NullReferenceException();
		IL_0189:
		return (IEnumerable<ClanUserModel>)Enumerable.OrderByDescending(getMembers, keySelector);
		IL_0132:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v8+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v12+B8]");
			obj4 = 0;
		}
		object obj10 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 760;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj11 = (nint)0 + (nint)672;
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj4, (IntPtr)obj11);
		object obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v11+B8]");
		object obj13 = (nint)0 + (nint)16;
		obj13 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj3 = obj6;
		keySelector = func;
		goto IL_0189;
	}

	private void SpawnMemberItem(ClanUserModel member)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0102: Expected O, but got I
		//IL_0140: Expected O, but got I4
		//IL_00dd: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected O, but got Unknown
		//IL_01fb: Expected O, but got I
		//IL_0239: Expected I, but got O
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Expected O, but got Unknown
		//IL_0247: Expected O, but got I4
		//IL_029e: Expected O, but got I4
		//IL_0326: Expected O, but got I4
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Expected O, but got Unknown
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Expected O, but got Unknown
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E86DF]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)656;
			SelectableUser selectableUser = itemPrefab;
			Transform transform = layout;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v28+E4]");
			bool flag = (nint)0 == 0;
			Transform transform2 = layout;
			object obj6 = obj4;
			SelectableUser selectableUser2 = itemPrefab;
			if (!flag)
			{
				goto IL_00b9;
			}
		}
		else
		{
			_ = 1;
			object obj4 = (nint)0 + (nint)656;
			SelectableUser selectableUser = itemPrefab;
			Transform transform = layout;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v28+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			Transform transform2 = layout;
			object obj6 = obj4;
			SelectableUser selectableUser2 = itemPrefab;
			if (obj7 != null)
			{
				goto IL_00b9;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
		goto IL_0183;
		IL_0183:
		bool <IsSelectable>k__BackingField = (byte)((member.IsOwner ? 1u : 0u) ^ 1u) != 0;
		SelectableUser selectableUser3 = default(SelectableUser);
		selectableUser3.<IsSelectable>k__BackingField = <IsSelectable>k__BackingField;
		selectableUser3.BindModel(member, toggleGroup);
		selectableUser3.SubscribeToggle();
		GameObject gameObject = selectableUser3.toggle.gameObject;
		object obj8 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3384;
		object obj9 = (nint)0 + (nint)1992;
		bool active = !member.IsOwner;
		gameObject.SetActive(active);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj9);
		object obj10 = selectableUser3 + 32;
		Delegate obj11 = (Delegate)obj10;
		object obj14 = default(object);
		bool flag4;
		Delegate obj17 = default(Delegate);
		do
		{
			Delegate obj12 = Delegate.Combine(obj11, action);
			Delegate obj16;
			if ((object)obj12 == null)
			{
				object obj13 = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag3 = obj14 == null;
				object obj15 = !flag3;
				object obj13 = obj14;
				if (obj15 == null)
				{
					obj16 = null;
					throw new InvalidCastException();
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
			flag4 = (object)obj17 == obj11;
			obj11 = obj17;
			obj16 = obj17;
		}
		while (!flag4);
		List<object> spawned = (List<object>)(object)_spawned;
		int version = spawned._version + 1;
		spawned._version = version;
		object[] items = spawned._items;
		bool flag5 = spawned._size < items.Length;
		object obj18 = !flag5;
		if (obj18 == null)
		{
			int size = spawned._size + 1;
			spawned._size = size;
			object obj19 = items + spawned._size;
			object obj20 = obj19 + 32;
			obj20 = selectableUser3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			spawned.AddWithResize((object)selectableUser3);
		}
		return;
		IL_00b9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
		bool flag6 = member == null;
		object obj21 = !flag6;
		if (obj21 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0183;
	}

	private void SelectFirstMember()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0171: Expected O, but got I4
		//IL_0203: Expected O, but got I
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected O, but got Unknown
		//IL_0227: Expected O, but got I
		//IL_0237: Expected O, but got I
		//IL_0259: Expected O, but got I4
		//IL_0052: Expected O, but got I4
		//IL_0138: Expected O, but got I4
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected O, but got Unknown
		//IL_01a9: Expected O, but got I
		//IL_01ba: Expected I, but got O
		//IL_01d8: Expected O, but got I
		//IL_0104: Expected O, but got I
		//IL_0082: Expected O, but got I
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 40;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		object obj4 = (nint)0 + (nint)1184;
		object obj5 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+B8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v7+18]");
		Func<object, bool> predicate = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v7+18]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v13+B8]");
				obj6 = 0;
			}
			object obj10 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3224;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj11 = (nint)0 + (nint)688;
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj6, (IntPtr)obj11);
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v12+B8]");
			object obj13 = (nint)0 + (nint)24;
			obj13 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			predicate = func;
		}
		object obj14 = Enumerable.FirstOrDefault(_spawned, predicate);
		object obj15 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v7+E4]");
		if ((nint)0 != 0)
		{
			if (!((UnityEngine.Object)obj14 != null))
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag4 = (UnityEngine.Object)obj14 != null;
			bool flag5 = !flag4;
			object obj16 = !flag5;
			if (obj16 == null)
			{
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v6 (System.Object)+28]");
		((Toggle)0).isOn = true;
	}

	private void OnUserSelected(SelectableUser item)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_003d: Expected O, but got I
		object obj = this + 112;
		obj = item.<User>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ X19_v3-38]");
		((Selectable)0).interactable = true;
	}

	private void OnTransferClicked()
	{
		if (_selected != null)
		{
			ShowTransferConfirmation();
		}
	}

	private void ShowTransferConfirmation()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e1: Expected O, but got Unknown
		//IL_04eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f0: Expected O, but got Unknown
		//IL_0508: Expected I, but got O
		//IL_0542: Expected O, but got I4
		//IL_0464: Unknown result type (might be due to invalid IL or missing references)
		//IL_0469: Expected O, but got Unknown
		//IL_0471: Unknown result type (might be due to invalid IL or missing references)
		//IL_0476: Expected O, but got Unknown
		//IL_047f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0484: Expected O, but got Unknown
		//IL_049c: Expected O, but got I
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		//IL_00f4: Expected I, but got O
		//IL_011b: Expected I, but got O
		//IL_0146: Expected O, but got I4
		//IL_015c: Expected I, but got O
		//IL_016c: Expected O, but got I
		//IL_0195: Expected O, but got I
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected O, but got Unknown
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected O, but got Unknown
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected O, but got Unknown
		//IL_024f: Expected I, but got O
		//IL_025f: Expected O, but got I
		//IL_02f5: Expected I, but got O
		//IL_029a: Expected O, but got I
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Expected O, but got Unknown
		//IL_0338: Expected I, but got O
		//IL_0348: Expected O, but got I
		//IL_03e6: Expected O, but got I
		//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fd: Expected O, but got Unknown
		//IL_0406: Unknown result type (might be due to invalid IL or missing references)
		//IL_040b: Expected O, but got Unknown
		//IL_0413: Expected I, but got O
		//IL_0437: Expected O, but got I4
		//IL_0383: Expected O, but got I
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Expected O, but got Unknown
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Expected O, but got Unknown
		//IL_0391: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Expected O, but got Unknown
		//IL_039f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Expected O, but got Unknown
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)1960;
		object obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
		object input = "tournament_participate_warning_body_with_tickets_warning_daily" + 360;
		object cancelText = "COORDINATE_TYPE_GCJ_02" + 1864;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v4+E4]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string confirmText = LocalizationUtil.Localize((string)input);
		PopupWindowBuilder popupWindowBuilder = PopupWindowBuilder.CreateNegativeConfirm(action, confirmText, (string)cancelText);
		object obj7 = default(object);
		nint num3;
		object obj12 = default(object);
		object obj13 = default(object);
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		object obj8;
		if (popupWindowBuilder != null)
		{
			object title = "Unsupported map type" + 3592;
			object obj6 = typeof(TypeConverter<ushort, char>) + 3400;
			IPopupWindowBuilderNeedsBody popupWindowBuilderNeedsBody = popupWindowBuilder.Titled((string)title);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			ClanUserModel selected = _selected;
			bool flag2 = _selected == null;
			num = (nint)_selected;
			if (!flag2)
			{
				object[] array = default(object[]);
				bool flag3 = array == null;
				num = (nint)_selected;
				if (!flag3)
				{
					bool flag4 = selected.Name == null;
					obj7 = 1;
					if (!flag4)
					{
						nint num2 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X8_v25 (Il2CppClass<System.Object[]>)+40]");
						obj7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag5 = ex == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X8_v25 (Il2CppClass<System.Object[]>)+40]");
						obj8 = 0;
						if (flag5)
						{
							goto IL_04bc;
						}
					}
					num = array.Length;
					if (array.Length == 0)
					{
						goto IL_04a6;
					}
					object input2 = "tournament_participate_warning_body_with_tickets_warning_daily" + 368;
					object obj9 = array + 32;
					obj9 = selected.Name;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					string text = LocalizationUtil.Localize((string)input2, array);
					if (popupWindowBuilderNeedsBody != null)
					{
						object obj10 = typeof(System.IOAsyncCallback) + 384;
						num3 = (nint)popupWindowBuilderNeedsBody;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X8_v16 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+12E]");
						object obj11 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X8_v16 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_02e3;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X8_v16 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+B0]");
						obj12 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X10_v12-8]");
							if (0 == (nint)obj10)
							{
								break;
							}
							obj13 = obj12 + 16;
							obj11--;
							bool flag6 = (nint)obj11 != 1;
							obj12 = obj13;
							if (flag6)
							{
								continue;
							}
							goto IL_02e3;
						}
						goto IL_03f0;
					}
				}
			}
		}
		goto IL_044d;
		IL_03c4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj15 = default(object);
		object obj14 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ X0_v27+8]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v277 @ X2_v10 (should have been resolved before IL gen)");
		goto IL_03f0;
		IL_04bc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_03f0:
		object obj17 = num3 + obj12;
		object obj18 = obj17 + 312;
		num = (nint)obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v357 @ X0_v33] (should have been resolved before IL gen)");
		NullReferenceException ex2 = default(NullReferenceException);
		bool flag7 = ex2 == null;
		object obj19 = !flag7;
		obj13 = obj12;
		if (obj19 != null)
		{
			goto IL_031c;
		}
		goto IL_044d;
		IL_04a6:
		ex = new IndexOutOfRangeException();
		obj8 = obj7;
		goto IL_04bc;
		IL_02e3:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj20 = default(object);
		num = (nint)obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v342 @ X0_v30] (should have been resolved before IL gen)");
		if (ex2 != null)
		{
			goto IL_031c;
		}
		goto IL_044d;
		IL_044d:
		ex2 = new NullReferenceException();
		goto IL_045b;
		IL_031c:
		object obj21 = typeof(System.IOAsyncCallback) + 368;
		num = (nint)ex2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+12E]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_03c4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+B0]");
		obj13 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X10_v9-8]");
			if (0 == (nint)obj21)
			{
				break;
			}
			obj13 += 16;
			obj22--;
			if ((nint)obj22 != 1)
			{
				continue;
			}
			goto IL_03c4;
		}
		goto IL_045b;
		IL_045b:
		object obj23 = obj13 + 9;
		object obj24 = num + obj23;
		object obj25 = obj24 + 312;
		object obj26 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X8_v6+8]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v232 @ X2_v4 (should have been resolved before IL gen)");
		goto IL_04a6;
	}

	private void ExecuteTransfer()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_003a: Expected O, but got I
		//IL_006f: Expected O, but got I4
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		//IL_00c5: Expected O, but got I
		//IL_00dd: Expected I, but got O
		if (_selected != null)
		{
			transferButton.interactable = false;
			object obj = typeof(Queue<string>) + 728;
			object obj2 = (nint)0 + (nint)1976;
			loader.StartLoading();
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			ClanUserModel selected = _selected;
			object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1568;
			object obj6 = (nint)0 + (nint)1984;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action<ClanResult> action = default(Action<ClanResult>);
			action..ctor((object)this, (IntPtr)obj6);
			ClanServerConnector clanServerConnector = default(ClanServerConnector);
			clanServerConnector.TransferOwnership(selected.UserId, action);
		}
	}

	private void OnTransferResponse(ClanResult result)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00d6: Expected O, but got I4
		//IL_0118: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8615]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v10+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v10+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = this == null;
		bool flag3 = !flag2;
		object obj6 = !flag3;
		if (obj6 != null)
		{
			return;
		}
		goto IL_0126;
		IL_0126:
		transferButton.interactable = true;
		loader.Freeze();
		loader.FinishLoading();
		ClanResult clanResult = default(ClanResult);
		if (clanResult.Succeeded)
		{
			HandleTransferSucceeded();
		}
		else
		{
			ShowFailurePopup();
		}
		return;
		IL_007d:
		if (this == null)
		{
			return;
		}
		goto IL_0126;
	}

	private void HandleTransferSucceeded()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0104: Expected O, but got I4
		//IL_0125: Expected O, but got I4
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0057: Expected O, but got I
		//IL_0081: Expected O, but got I4
		object text = "not" + 2912;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
		LocalizableText text2 = TextMeshProExtensions.Localize((string)text);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Toast.Show(text2, (Vector2)0, 0f);
		if (_onTransferred != null)
		{
			object obj4 = typeof(Queue<string>) + 728;
			object obj5 = (nint)0 + (nint)1976;
			object obj6 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v10+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			ClanServerConnector clanServerConnector = default(ClanServerConnector);
			clanServerConnector.GetMyClan(_onTransferred);
		}
		slideAnim.SlideOut();
	}

	private static void ShowSuccessToast()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_006e: Expected O, but got I4
		//IL_008f: Expected O, but got I4
		object text = "not" + 2912;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
		LocalizableText text2 = TextMeshProExtensions.Localize((string)text);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Toast.Show(text2, (Vector2)0, 0f);
	}

	private void NotifyTransferred()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_004f: Expected O, but got I4
		if (_onTransferred != null)
		{
			object obj = typeof(Queue<string>) + 728;
			object obj2 = (nint)0 + (nint)1976;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			ClanServerConnector clanServerConnector = default(ClanServerConnector);
			clanServerConnector.GetMyClan(_onTransferred);
		}
	}

	private static void ShowFailurePopup()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Expected O, but got Unknown
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Expected O, but got Unknown
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected O, but got Unknown
		//IL_02f9: Expected O, but got I
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_009e: Expected I, but got O
		//IL_00ae: Expected O, but got I
		//IL_0144: Expected I, but got O
		//IL_00e9: Expected O, but got I
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected O, but got Unknown
		//IL_0187: Expected I, but got O
		//IL_0197: Expected O, but got I
		//IL_0235: Expected O, but got I
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Expected O, but got Unknown
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected O, but got Unknown
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected O, but got Unknown
		//IL_0270: Expected I, but got O
		//IL_0294: Expected O, but got I4
		//IL_01d2: Expected O, but got I
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected O, but got Unknown
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8616]");
		nint num = 0;
		object buttonText = "Network Authentication Required" + 3128;
		object text = "tournament_participate_warning_body_with_tickets_warning_daily" + 384;
		object obj3 = default(object);
		object obj4 = default(object);
		NullReferenceException ex = default(NullReferenceException);
		object obj11 = default(object);
		object obj17 = default(object);
		while (true)
		{
			PopupWindowBuilder popupWindowBuilder = PopupWindowBuilder.CreateError(null, (string)buttonText);
			LocalizableText title = TextMeshProExtensions.Localize((string)text);
			nint num2;
			if (popupWindowBuilder != null)
			{
				object text2 = "tournament_participate_warning_body_with_tickets_warning_daily" + 376;
				IPopupWindowBuilderNeedsBody popupWindowBuilderNeedsBody = popupWindowBuilder.Titled(title);
				LocalizableText localizableText = TextMeshProExtensions.Localize((string)text2);
				if (popupWindowBuilderNeedsBody != null)
				{
					object obj = typeof(System.IOAsyncCallback) + 384;
					num2 = (nint)popupWindowBuilderNeedsBody;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X8_v9 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+12E]");
					object obj2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X8_v9 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0132;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X8_v9 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+B0]");
					obj3 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X10_v12-8]");
						if (0 == (nint)obj)
						{
							break;
						}
						obj4 = obj3 + 16;
						obj2--;
						bool flag = (nint)obj2 != 1;
						obj3 = obj4;
						if (flag)
						{
							continue;
						}
						goto IL_0132;
					}
					goto IL_023f;
				}
			}
			goto IL_02aa;
			IL_02aa:
			ex = new NullReferenceException();
			goto IL_02b8;
			IL_02b8:
			object obj5 = obj4 + 9;
			object obj6 = num + obj5;
			object obj7 = obj6 + 312;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v5+8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v184 @ X2_v3 (should have been resolved before IL gen)");
			continue;
			IL_0213:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj10 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X0_v14+8]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v221 @ X2_v8 (should have been resolved before IL gen)");
			goto IL_023f;
			IL_023f:
			object obj13 = obj3 + 1;
			object obj14 = num2 + obj13;
			object obj15 = obj14 + 312;
			num = (nint)obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v274 @ X0_v20] (should have been resolved before IL gen)");
			bool flag2 = ex == null;
			object obj16 = !flag2;
			obj4 = obj3;
			if (obj16 != null)
			{
				goto IL_016b;
			}
			goto IL_02aa;
			IL_0132:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num = (nint)obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v258 @ X0_v17] (should have been resolved before IL gen)");
			if (ex != null)
			{
				goto IL_016b;
			}
			goto IL_02aa;
			IL_016b:
			object obj18 = typeof(System.IOAsyncCallback) + 368;
			num = (nint)ex;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+12E]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+12E]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+B0]");
				obj4 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X10_v9-8]");
					if (0 == (nint)obj18)
					{
						break;
					}
					obj4 += 16;
					obj19--;
					if ((nint)obj19 != 1)
					{
						continue;
					}
					goto IL_0213;
				}
				goto IL_02b8;
			}
			goto IL_0213;
		}
	}

	private void SetLoading(bool isLoading)
	{
		//IL_0037: Expected O, but got I4
		bool flag = (byte)((isLoading ? 1u : 0u) ^ 1u) != 0;
		transferButton.interactable = flag;
		bool flag2 = !flag;
		object obj = !flag2;
		if (obj == null)
		{
			loader.StartLoading();
			return;
		}
		loader.Freeze();
		loader.FinishLoading();
	}

	private void StopLoading()
	{
		loader.Freeze();
		loader.FinishLoading();
	}

	private void ClearSpawned()
	{
		//IL_0013: Expected O, but got I
		//IL_003b: Expected I, but got O
		//IL_004e: Expected O, but got I4
		//IL_0146: Expected I, but got O
		object obj = default(object);
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		nint num = default(nint);
		if (_spawned != null)
		{
			obj = (nint)0 + (nint)1072;
			List<object>.Enumerator enumerator = ((List<object>)(object)_spawned).GetEnumerator();
			while (enumerator2.MoveNext())
			{
				Despawn(null);
			}
			num = (nint)obj;
			enumerator2.Dispose();
			object obj2 = 0;
			goto IL_0054;
		}
		goto IL_00ef;
		IL_00ef:
		NullReferenceException ex = new NullReferenceException();
		bool flag = num != 1;
		NullReferenceException ex2 = ex;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			num = (nint)obj;
			enumerator2.Dispose();
			object obj3 = default(object);
			bool flag2 = obj3 == null;
			object obj2 = obj3;
			if (flag2)
			{
				goto IL_0054;
			}
			OutOfMemoryException ex3 = new OutOfMemoryException();
			obj2 = obj3;
			ex2 = (NullReferenceException)(object)ex3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223D988");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_0054:
		List<SelectableUser> spawned = _spawned;
		if (_spawned != null)
		{
			int version = spawned._version + 1;
			spawned._size = 0;
			spawned._version = version;
			if (spawned._size >= 1)
			{
				Array.Clear(spawned._items, 0, spawned._size);
			}
			return;
		}
		goto IL_00ef;
	}

	private void Despawn(SelectableUser item)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00e7: Expected O, but got I4
		//IL_00a3: Expected O, but got I4
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		//IL_0168: Expected O, but got I
		//IL_0180: Expected I, but got O
		//IL_012c: Expected O, but got I4
		//IL_0135: Expected O, but got I4
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Expected O, but got Unknown
		//IL_0193: Expected O, but got I4
		//IL_01ea: Expected O, but got I4
		//IL_0247: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E86E2]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v25+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v25+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = item == null;
		bool flag3 = !flag2;
		object obj6 = !flag3;
		object obj7 = 0;
		UnityEngine.Object obj8 = null;
		if (obj6 != null)
		{
			return;
		}
		goto IL_0148;
		IL_0148:
		object obj9 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3384;
		object obj10 = (nint)0 + (nint)1992;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj10);
		object obj11 = item + 32;
		Delegate obj12 = (Delegate)obj11;
		object obj15 = default(object);
		bool flag5;
		Delegate obj18 = default(Delegate);
		do
		{
			Delegate obj13 = Delegate.Remove(obj12, action);
			Delegate obj17;
			if ((object)obj13 == null)
			{
				object obj14 = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag4 = obj15 == null;
				object obj16 = !flag4;
				object obj14 = obj15;
				if (obj16 == null)
				{
					obj17 = null;
					throw new InvalidCastException();
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
			flag5 = (object)obj18 == obj12;
			obj12 = obj18;
			obj17 = obj18;
		}
		while (!flag5);
		GameObject gameObject = item.gameObject;
		object obj19 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v5+E4]");
		bool flag6 = (nint)0 == 0;
		object obj20 = !flag6;
		UnityEngine.Object obj21 = gameObject;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj21 = gameObject;
		}
		UnityEngine.Object.Destroy(obj21);
		return;
		IL_007d:
		bool flag7 = item == null;
		bool flag8 = !flag7;
		obj7 = 0;
		obj8 = null;
		if (!flag8)
		{
			return;
		}
		goto IL_0148;
	}

	public TransferOwnershipPanel()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 3224;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj2 = this + 104;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}
}
