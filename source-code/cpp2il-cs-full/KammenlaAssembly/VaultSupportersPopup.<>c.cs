using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2ILInjected;
using DG.Tweening;
using Kammelna.Server.Models.Clans;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using UnityEngine;
using UnityEngine.InputSystem.UI;
using UnityEngine.InputSystem.XR;

public class VaultSupportersPopup : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<ClanVaultSupporterModel, int, VaultTransactionDataHolder> <>9__4_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(TrackedDeviceRaycaster.<>c) + 1736;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal VaultTransactionDataHolder <OnSupportersLoaded>b__4_0(ClanVaultSupporterModel supporter, int i)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Expected O, but got Unknown
			object obj = typeof(UsageHint) + 720;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj2 + 32;
			obj3 = supporter;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return (VaultTransactionDataHolder)obj2;
		}
	}

	private VaultTransactionListView listView;

	private GameObject loadingState;

	private GameObject emptyState;

	public void Initialize(long feedId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0072: Expected O, but got I
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_0092: Expected O, but got I
		//IL_00cc: Expected O, but got I4
		//IL_004f: Expected I, but got O
		object obj = typeof(Queue<string>) + 728;
		object obj2 = (nint)0 + (nint)1976;
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 760;
		object obj4 = (nint)0 + (nint)2176;
		SetState(loading: true, empty: false);
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj4);
		ClanServerConnector clanServerConnector = default(ClanServerConnector);
		clanServerConnector.GetClanVaultSupportRequestSupporters(feedId, action);
	}

	private void OnSupportersLoaded(List<ClanVaultSupporterModel> supporters)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00cd: Expected O, but got I4
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Expected O, but got Unknown
		//IL_010f: Expected O, but got I4
		//IL_014d: Expected O, but got I4
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected I4, but got Unknown
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected O, but got Unknown
		//IL_0397: Expected I, but got O
		//IL_03a7: Expected O, but got I
		//IL_03b7: Expected O, but got I
		//IL_02d3: Expected O, but got I
		//IL_02e3: Expected O, but got I
		//IL_0305: Expected O, but got I4
		//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d5: Expected O, but got Unknown
		//IL_03eb: Expected O, but got I
		//IL_03fc: Expected I, but got O
		//IL_041a: Expected O, but got I
		//IL_0220: Expected O, but got I
		//IL_0230: Expected O, but got I
		//IL_0252: Expected O, but got I4
		//IL_0335: Expected O, but got I4
		//IL_0365: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8645]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v24+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v24+E4]");
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
		if (obj5 != null)
		{
			return;
		}
		goto IL_011d;
		IL_03c1:
		object obj6 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 712;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj7 = (nint)0 + (nint)2552;
		Func<object, int, object> func = default(Func<object, int, object>);
		object obj8 = default(object);
		func..ctor(obj8, (IntPtr)obj7);
		object obj10 = default(object);
		object obj9 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X8_v22+B8]");
		object obj11 = (nint)0 + (nint)8;
		obj11 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Func<object, int, object> selector = func;
		goto IL_036a;
		IL_036a:
		IEnumerable<object> source = Enumerable.Select(supporters, selector);
		List<object> list = Enumerable.ToList(source);
		goto IL_038f;
		IL_0313:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X0_v14+E4]");
		bool flag4 = (nint)0 == 0;
		object obj12 = !flag4;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj13 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X8_v23+B8]");
			obj8 = 0;
		}
		goto IL_03c1;
		IL_0074:
		if (this == null)
		{
			return;
		}
		goto IL_011d;
		IL_011d:
		VaultTransactionListView vaultTransactionListView;
		if (supporters != null)
		{
			object obj14 = supporters._size - 1;
			bool flag5 = (nint)obj14 < 0;
			int num = supporters._size ^ 1;
			int num2 = supporters._size ^ obj14;
			int num3 = num & num2;
			bool flag6 = num3 < 0;
			bool flag7 = flag5 == flag6;
			bool empty = !flag7;
			SetState(loading: false, empty);
			vaultTransactionListView = listView;
			obj10 = typeof(TrackedDeviceRaycaster.<>c) + 1736;
			object obj15 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X0_v14+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X0_v14+B8]");
				obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v17+8]");
				selector = (Func<object, int, object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v17+8]");
				bool flag8 = (nint)0 == 0;
				object obj16 = !flag8;
				if (obj16 == null)
				{
					goto IL_0313;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj15 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X0_v14+B8]");
				obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v17+8]");
				selector = (Func<object, int, object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v17+8]");
				bool flag9 = (nint)0 == 0;
				object obj17 = !flag9;
				if (obj17 == null)
				{
					goto IL_0313;
				}
			}
			goto IL_036a;
		}
		SetState(loading: false, empty: true);
		vaultTransactionListView = listView;
		object obj18 = typeof(List<Tween>) + 256;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list2 = default(List<object>);
		list2..ctor();
		goto IL_038f;
		IL_038f:
		nint num4 = (nint)vaultTransactionListView;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<VaultTransactionListView>)+2A8]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4 (Il2CppClass<VaultTransactionListView>)+2B0]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v100 @ X3_v2 (should have been resolved before IL gen)");
		goto IL_03c1;
	}

	private void SetState(bool loading, bool empty)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_017a: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		//IL_021d: Expected O, but got I4
		//IL_0278: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8646]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			obj5 = loadingState;
			obj6 = loadingState;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v11+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = loadingState;
			obj6 = loadingState;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		bool flag5 = false;
		if (flag4)
		{
			goto IL_00cb;
		}
		goto IL_01da;
		IL_013a:
		emptyState.SetActive(empty);
		return;
		IL_0114:
		UnityEngine.Object obj8;
		if ((bool)obj8)
		{
			goto IL_013a;
		}
		return;
		IL_0246:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object obj9;
		bool flag6 = obj9;
		bool flag7 = !flag6;
		object obj10 = !flag7;
		if (obj10 == null)
		{
			return;
		}
		goto IL_013a;
		IL_0091:
		bool flag8 = obj5;
		bool flag9 = !flag8;
		object obj11 = !flag9;
		flag5 = false;
		if (obj11 == null)
		{
			goto IL_00cb;
		}
		goto IL_01da;
		IL_01da:
		loadingState.SetActive(loading);
		obj8 = emptyState;
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v4+E4]");
		bool flag10 = (nint)0 == 0;
		object obj13 = !flag10;
		bool flag11 = false;
		flag5 = loading;
		obj9 = emptyState;
		if (obj13 != null)
		{
			goto IL_0114;
		}
		goto IL_0246;
		IL_00cb:
		obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v4+E4]");
		bool flag12 = (nint)0 == 0;
		obj8 = emptyState;
		flag11 = empty;
		obj9 = emptyState;
		if (!flag12)
		{
			goto IL_0114;
		}
		goto IL_0246;
	}
}
