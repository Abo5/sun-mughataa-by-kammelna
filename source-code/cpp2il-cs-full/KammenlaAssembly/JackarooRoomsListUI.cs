using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using Cpp2ILInjected;
using DataTracking;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;

public class JackarooRoomsListUI : MonoBehaviour
{
	private sealed class <SendRequestThrottled>d__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public JackarooRoomsListUI <>4__this;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <SendRequestThrottled>d__14(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_02eb: Expected I4, but got I8
			//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ff: Expected O, but got Unknown
			//IL_0329: Expected O, but got I4
			//IL_0021: Expected O, but got I4
			//IL_0280: Unknown result type (might be due to invalid IL or missing references)
			//IL_0285: Expected O, but got Unknown
			//IL_039b: Expected O, but got I4
			//IL_003e: Expected I4, but got I8
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Expected O, but got Unknown
			//IL_007c: Expected O, but got I4
			//IL_041b: Expected O, but got I4
			//IL_0423: Expected I, but got O
			//IL_0444: Expected O, but got I4
			//IL_02a0: Expected O, but got I
			//IL_02b3: Expected I, but got O
			//IL_02bf: Expected O, but got I
			//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d0: Expected O, but got Unknown
			//IL_0484: Expected O, but got I4
			//IL_00de: Expected O, but got I
			//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f6: Expected O, but got Unknown
			//IL_0120: Expected O, but got I4
			//IL_05ef: Expected O, but got I
			//IL_0619: Expected O, but got I4
			//IL_0575: Expected O, but got I
			//IL_058c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0591: Expected O, but got Unknown
			//IL_05c1: Expected O, but got I4
			//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ef: Expected O, but got Unknown
			//IL_016c: Expected O, but got I4
			//IL_017d: Expected O, but got I4
			//IL_0185: Expected I, but got O
			//IL_01a6: Expected O, but got I4
			//IL_0511: Unknown result type (might be due to invalid IL or missing references)
			//IL_0516: Expected O, but got Unknown
			Component component = <>4__this;
			object obj7 = default(object);
			TimeSpan timeSpan2 = default(TimeSpan);
			object obj11 = default(object);
			TimeSpan timeSpan3 = default(TimeSpan);
			object obj13;
			object obj14;
			TimeSpan timeSpan4;
			object obj6 = default(object);
			nint num = default(nint);
			NullReferenceException ex;
			object obj5;
			object obj15;
			TimeSpan timeSpan5;
			if (<>1__state != 1)
			{
				bool flag = <>1__state == 0;
				object obj = !flag;
				if (obj != null)
				{
					goto IL_02ce;
				}
				<>1__state = -1;
				object obj2 = typeof(DataRelation) + 712;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v43+E4]");
				bool flag2 = (nint)0 == 0;
				object obj4 = !flag2;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				DateTime now = DateTime.Now;
				bool flag3 = (object)<>4__this == null;
				obj5 = obj6;
				if (flag3)
				{
					goto IL_03d9;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X20_v2 (UnityEngine.Component)+38]");
				TimeSpan timeSpan = now - (DateTime)0;
				obj7 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 288;
				object obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X0_v49+E4]");
				bool flag4 = (nint)0 == 0;
				object obj9 = !flag4;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj8 = obj7;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X0_v49+B8]");
				object obj10 = 0;
				timeSpan2 = (TimeSpan)obj10;
				obj11 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
				ex = (NullReferenceException)obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X0_v19 (System.NullReferenceException)+E4]");
				bool flag5 = (nint)0 == 0;
				timeSpan3 = timeSpan;
				obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X20_v2 (UnityEngine.Component)+38]");
				num = 0;
				if (flag5)
				{
					goto IL_03e7;
				}
				bool flag6 = timeSpan < (TimeSpan)obj10;
				bool flag7 = !flag6;
				object obj12 = !flag7;
				timeSpan3 = timeSpan;
				obj6 = 0;
				num = (nint)obj10;
				obj13 = obj11;
				obj14 = obj7;
				timeSpan4 = timeSpan;
				obj15 = 0;
				timeSpan5 = (TimeSpan)obj10;
				if (obj12 == null)
				{
					goto IL_01bc;
				}
				goto IL_045a;
			}
			<>1__state = -1;
			object obj16 = typeof(DataRelation) + 712;
			object obj17 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v25+E4]");
			bool flag8 = (nint)0 == 0;
			object obj18 = !flag8;
			object obj19 = obj11;
			TimeSpan timeSpan6 = timeSpan2;
			object obj20 = obj7;
			TimeSpan timeSpan7 = timeSpan3;
			obj5 = obj6;
			nint num2 = num;
			if (obj18 != null)
			{
				goto IL_022d;
			}
			goto IL_0367;
			IL_01bc:
			object obj21 = typeof(DataRelation) + 712;
			obj17 = obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v25+E4]");
			bool flag9 = (nint)0 == 0;
			obj19 = obj11;
			timeSpan6 = timeSpan2;
			obj20 = obj7;
			timeSpan7 = timeSpan3;
			obj5 = obj6;
			num2 = num;
			if (!flag9)
			{
				goto IL_022d;
			}
			goto IL_0367;
			IL_02ce:
			return false;
			IL_0367:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			DateTime now2 = DateTime.Now;
			bool flag10 = (object)<>4__this == null;
			object obj22 = !flag10;
			obj6 = obj5;
			obj11 = obj19;
			timeSpan2 = timeSpan6;
			obj7 = obj20;
			timeSpan3 = timeSpan7;
			num = num2;
			if (obj22 != null)
			{
				goto IL_025d;
			}
			goto IL_03d9;
			IL_03d9:
			ex = new NullReferenceException();
			goto IL_03e7;
			IL_022d:
			now2 = DateTime.Now;
			bool flag11 = (object)<>4__this == null;
			obj5 = obj6;
			if (!flag11)
			{
				goto IL_025d;
			}
			goto IL_03d9;
			IL_03e7:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag12 = timeSpan3 < timeSpan2;
			bool flag13 = !flag12;
			obj6 = 0;
			num = (nint)timeSpan2;
			obj13 = obj11;
			obj14 = obj7;
			timeSpan4 = timeSpan3;
			obj15 = 0;
			timeSpan5 = timeSpan2;
			if (flag13)
			{
				goto IL_01bc;
			}
			goto IL_045a;
			IL_025d:
			GameObject gameObject = <>4__this.gameObject;
			object obj23 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 128;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj24 = (nint)0 + (nint)872;
			Action<object, object> action = default(Action<object, object>);
			action..ctor((object)<>4__this, (IntPtr)obj24);
			object obj25 = (nint)0 + (nint)3816;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @301E1A4");
			goto IL_02ce;
			IL_045a:
			object obj26 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X0_v5+E4]");
			bool flag14 = (nint)0 == 0;
			object obj27 = !flag14;
			if (obj27 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj26 = obj14;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X0_v5+B8]");
			object obj28 = 0;
			object obj29 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X0_v6+E4]");
			bool flag15 = (nint)0 == 0;
			object obj30 = !flag15;
			if (obj30 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			TimeSpan timeSpan8 = (TimeSpan)obj28 - timeSpan4;
			TimeSpan timeSpan9 = default(TimeSpan);
			double totalSeconds = timeSpan9.TotalSeconds;
			object obj31 = typeof(UsageHint) + 1640;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			WaitForSeconds waitForSeconds = default(WaitForSeconds);
			waitForSeconds..ctor((float)totalSeconds);
			object obj32 = this + 24;
			obj32 = waitForSeconds;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = 1;
			return true;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0042: Expected O, but got I
			object obj = typeof(MemberAchievementClanFeedData) + 2648;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			NotSupportedException ex = default(NotSupportedException);
			ex..ctor();
			object obj2 = (nint)0 + (nint)2368;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}
	}

	private static readonly TimeSpan ThrottleInterval;

	private JackarooRoomListView listView;

	protected ElegantLoadingIndicator loading;

	protected GameObject emptyState;

	private DateTime _lastRequestTime;

	private RoomsFilterModel _lastFilter;

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_003e: Expected I, but got O
		object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 648;
		object obj2 = (nint)0 + (nint)880;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object, object> action = default(Action<object, object>);
		action..ctor((object)this, (IntPtr)obj2);
		SFS.OnJoinRoomFailed += action;
	}

	private void OnEnable()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		FilteredRoomListUpdated(_lastFilter);
		ITrackEvent trackEvent = TrackerLibrary.MenuRoomListViewed();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v3+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
	}

	public void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_003e: Expected I, but got O
		object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 648;
		object obj2 = (nint)0 + (nint)880;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object, object> action = default(Action<object, object>);
		action..ctor((object)this, (IntPtr)obj2);
		SFS.OnJoinRoomFailed -= action;
	}

	private void OnJoinRoomFailed(Room room, string error)
	{
		FilteredRoomListUpdated(_lastFilter);
	}

	private void ListUpdated(List<JackarooGameRoomData> list, string error)
	{
		//IL_0060: Expected O, but got I
		GameObject gameObject = loading.gameObject;
		gameObject.SetActive(value: false);
		bool active = list._size == 0;
		emptyState.SetActive(active);
		object obj = (nint)0 + (nint)864;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E8F19C");
	}

	private void SetListView(List<JackarooGameRoomData> list)
	{
		//IL_0011: Expected O, but got I
		object obj = (nint)0 + (nint)864;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E8F19C");
	}

	public void FilteredRoomListUpdated(RoomsFilterModel filterModel)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		object obj = this + 64;
		obj = filterModel;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		StopAllCoroutines();
		SetNewListView();
		loading.StartLoading();
		emptyState.SetActive(value: false);
		object obj2 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 872;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj3 = default(object);
		obj3..ctor();
		_ = 0;
		object obj4 = obj3 + 32;
		obj4 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Coroutine coroutine = StartCoroutine((IEnumerator)obj3);
	}

	private void SetNewListView()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0026: Expected O, but got I
		object obj = typeof(List<AdaptivePerformanceScaler>) + 1936;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj2 = (nint)0 + (nint)864;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E8F19C");
	}

	private IEnumerator SendRequestThrottled()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 872;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		object obj3 = obj2 + 32;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (IEnumerator)obj2;
	}

	static JackarooRoomsListUI()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0099: Expected O, but got I4
		//IL_0052: Expected O, but got I
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 288;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		TimeSpan timeSpan = TimeSpan.FromSeconds(4.000000000232831);
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v4+B8]");
		object obj6 = 0;
		obj6 = timeSpan;
	}
}
