using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using ListView;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.AdaptivePerformance;

public class MassTournamentListView : UiListView<MassTournamentDataHolder, ListViewItem<MassTournamentDataHolder, int>>
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<Room, MassTournamentInfo> <>9__8_0;

		public static Func<Room, int, MassTournamentDataHolder> <>9__9_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3056;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal MassTournamentInfo <AllTournamentsHaveModels>b__8_0(Room room)
		{
			return SFSKammelnaRoomExtensions.GetMassTournamentInfo(room);
		}

		internal MassTournamentDataHolder <AssignData>b__9_0(Room room, int i)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Expected O, but got Unknown
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3800;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj2 + 24;
			obj3 = room;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return (MassTournamentDataHolder)obj2;
		}
	}

	private sealed class <>c__DisplayClass6_0
	{
		public MassTournamentListView <>4__this;

		public int retires;

		public Action <>9__1;

		internal void <RefreshHelper>b__0(List<MassEventModel> list)
		{
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Expected O, but got Unknown
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Expected O, but got Unknown
			//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d6: Expected O, but got Unknown
			//IL_00ec: Expected O, but got I
			//IL_00f4: Expected I, but got O
			//IL_0102: Expected I, but got O
			//IL_0145: Expected O, but got I4
			if (AllTournamentsHaveModels(list))
			{
				<>4__this.AssignData();
				return;
			}
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
			MassTournamentManager.Clear();
			float retryDelay = GetRetryDelay(retires);
			object obj2 = this + 32;
			Action action = (Action)obj2;
			Action action3;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v6+E4]");
				bool flag = (nint)0 == 0;
				IntPtr intPtr = default(IntPtr);
				nint num = intPtr;
				Action action2 = null;
				action3 = action;
				if (!flag)
				{
					goto IL_00b0;
				}
			}
			else
			{
				object obj4 = typeof(SqlSingle[]) + 2376;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj5 = (nint)0 + (nint)904;
				nint num = (nint)obj5;
				Action action4 = default(Action);
				action4..ctor(this, (IntPtr)obj5);
				<>9__1 = action4;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v6+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				action = action4;
				Action action2 = action4;
				action3 = action4;
				if (obj6 != null)
				{
					goto IL_00b0;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			action = action3;
			goto IL_00b0;
			IL_00b0:
			Coroutine coroutine = CoroutineDummy.WaitForSeconds(retryDelay, action);
		}

		internal void <RefreshHelper>b__1()
		{
			int num = retires - 1;
			<>4__this.RefreshHelper(num);
		}
	}

	private sealed class <>c__DisplayClass8_0
	{
		public List<MassEventModel> list;

		internal bool <AllTournamentsHaveModels>b__1(MassTournamentInfo mass)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00a5: Expected I4, but got O
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			//IL_0039: Expected O, but got I
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Expected O, but got Unknown
			//IL_007a: Expected I, but got O
			object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3080;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			if (obj2 != null)
			{
				object obj3 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2336;
				object obj4 = (nint)0 + (nint)920;
				object obj5 = obj2 + 16;
				obj5 = mass;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				Func<object, bool> func = default(Func<object, bool>);
				func..ctor(obj2, (IntPtr)obj4);
				return Enumerable.Any(list, func);
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass8_1
	{
		public MassTournamentInfo mass;

		internal bool <AllTournamentsHaveModels>b__2(MassEventModel m)
		{
			//IL_007f: Expected I4, but got O
			//IL_005d: Expected O, but got I8
			if (m != null)
			{
				MassTournamentInfo massTournamentInfo = mass;
				if (mass != null)
				{
					object obj = m.<Id>k__BackingField - massTournamentInfo.<Id>k__BackingField;
					return obj == null;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private MassTournamentsListEventsChannel eventsChannels;

	private ElegantLoadingIndicator indicator;

	protected override void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_00a8: Expected I, but got O
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0066: Expected I, but got O
		//IL_0076: Expected O, but got I
		//IL_0086: Expected O, but got I
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)3376;
		Action action = default(Action);
		List<object> list = default(List<object>);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			action..ctor(this, (IntPtr)obj2);
			object obj3 = typeof(List<AdaptivePerformanceScaler>) + 2232;
			eventsChannels.OnTournamentsChanged += action;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			list..ctor();
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v3 (Il2CppClass<MassTournamentListView>)+2A8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v3 (Il2CppClass<MassTournamentListView>)+2B0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v86 @ X3_v2 (should have been resolved before IL gen)");
		}
	}

	private void OnEnable()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0040: Expected O, but got I
		//IL_004e: Expected I, but got O
		IEnumerable<Room> massTournamentRooms = SFS.MassTournamentRooms;
		if (Enumerable.Any((IEnumerable<object>)massTournamentRooms))
		{
			indicator.StartLoading();
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 824;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = (nint)0 + (nint)3368;
			Action<object> action = default(Action<object>);
			action..ctor((object)this, (IntPtr)obj2);
			MassTournamentManager.GetMassEvents(action);
		}
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_004d: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)3376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		eventsChannels.OnTournamentsChanged -= action;
	}

	private void Refresh()
	{
		RefreshHelper();
	}

	private void RefreshHelper(int retires = 3)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_0078: Expected O, but got I
		//IL_0093: Expected I, but got O
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3064;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass6_0 <>c__DisplayClass6_ = default(<>c__DisplayClass6_0);
		<>c__DisplayClass6_..ctor();
		object obj2 = <>c__DisplayClass6_ + 16;
		obj2 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if (retires != 0)
		{
			object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 824;
			object obj4 = (nint)0 + (nint)896;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action<object> action = default(Action<object>);
			action..ctor((object)<>c__DisplayClass6_, (IntPtr)obj4);
			MassTournamentManager.GetMassEvents(action);
		}
	}

	private static float GetRetryDelay(int retires)
	{
		//IL_000e: Expected O, but got I4
		//IL_0028: Expected O, but got I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_0050: Expected O, but got I4
		//IL_0087: Expected O, but got I4
		//IL_0097: Expected F4, but got I
		object obj = retires - 1;
		bool flag = (nint)obj < 2;
		object obj2 = !flag;
		object obj3 = obj - 2;
		bool flag2 = obj3 == null;
		object obj4 = !flag2;
		object obj5 = obj2 & obj4;
		float result = 10f;
		if (obj5 == null)
		{
			object obj6 = 119873536 + 3584;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ X9_v3+v0 @ X8_v1*4]");
			result = 0f;
		}
		return result;
	}

	private static bool AllTournamentsHaveModels(List<MassEventModel> list)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_015b: Expected I4, but got O
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0085: Expected O, but got I4
		//IL_0197: Expected O, but got I
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected O, but got Unknown
		//IL_01b7: Expected O, but got I
		//IL_01c8: Expected O, but got I
		//IL_01d8: Expected O, but got I
		//IL_01fa: Expected O, but got I4
		//IL_0132: Expected I, but got O
		//IL_00cc: Expected O, but got I4
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected O, but got Unknown
		//IL_0232: Expected O, but got I
		//IL_0243: Expected I, but got O
		//IL_0261: Expected O, but got I
		//IL_00fc: Expected O, but got I
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3072;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass8_0 <>c__DisplayClass8_ = default(<>c__DisplayClass8_0);
		<>c__DisplayClass8_..ctor();
		if (<>c__DisplayClass8_ != null)
		{
			object obj2 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3056;
			object obj3 = <>c__DisplayClass8_ + 16;
			obj3 = list;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			IEnumerable<Room> massTournamentRooms = SFS.MassTournamentRooms;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj4 = obj2;
			}
			object obj6 = (nint)0 + (nint)3976;
			object obj7 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2376;
			object obj8 = (nint)0 + (nint)912;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v11+B8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v6+8]");
			Func<object, object> selector = (Func<object, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v6+8]");
			bool flag2 = (nint)0 == 0;
			object obj10 = !flag2;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v11+E4]");
				bool flag3 = (nint)0 == 0;
				object obj11 = !flag3;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj12 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v12+B8]");
					obj9 = 0;
				}
				object obj13 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3184;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj14 = (nint)0 + (nint)880;
				Func<object, object> func = default(Func<object, object>);
				func..ctor(obj9, (IntPtr)obj14);
				object obj15 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v11+B8]");
				object obj16 = (nint)0 + (nint)8;
				obj16 = func;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				selector = func;
			}
			IEnumerable<object> source = Enumerable.Select(massTournamentRooms, selector);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func2 = default(Func<object, bool>);
			func2..ctor((object)<>c__DisplayClass8_, (IntPtr)obj8);
			return Enumerable.All(source, func2);
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private void AssignData()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_010f: Expected O, but got I4
		//IL_012f: Expected O, but got I
		//IL_013f: Expected O, but got I
		//IL_0161: Expected O, but got I4
		//IL_0052: Expected O, but got I4
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected O, but got Unknown
		//IL_0199: Expected O, but got I
		//IL_01aa: Expected I, but got O
		//IL_01c8: Expected O, but got I
		//IL_0082: Expected O, but got I
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3056;
		IEnumerable<Room> massTournamentRooms = SFS.MassTournamentRooms;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v5+B8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v9+10]");
		Func<object, int, object> selector = (Func<object, int, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v9+10]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v5+E4]");
			bool flag3 = (nint)0 == 0;
			object obj6 = !flag3;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj7 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v15+B8]");
				obj4 = 0;
			}
			object obj8 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 888;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj9 = (nint)0 + (nint)888;
			Func<object, int, object> func = default(Func<object, int, object>);
			func..ctor(obj4, (IntPtr)obj9);
			object obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v14+B8]");
			object obj11 = (nint)0 + (nint)16;
			obj11 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			selector = func;
		}
		IEnumerable<object> source = Enumerable.Select(massTournamentRooms, selector);
		List<object> list = Enumerable.ToList(source);
		base.data = (List<MassTournamentDataHolder>)(object)list;
		GameObject gameObject = indicator.gameObject;
		gameObject.SetActive(value: false);
	}

	public MassTournamentListView()
	{
		((UiListView<object, object>)(object)this)..ctor();
	}

	private void <OnEnable>b__3_0(List<MassEventModel> _)
	{
		RefreshHelper();
	}
}
