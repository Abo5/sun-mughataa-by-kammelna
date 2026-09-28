using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using DataTracking;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Mono.Btls;
using Sfs2X.Entities;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public class OnlineUsersListView : UiGridView<UserWrapper, AvatarInitializer>
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<FriendProfile, int> <>9__10_0;

		public static Func<FriendProfile, int> <>9__12_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1656;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal int <OnUserBlocked>b__10_0(FriendProfile profile)
		{
			//IL_0035: Expected I4, but got O
			if (profile != null)
			{
				return profile.UserID;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}

		internal int <UpdateData>b__12_0(FriendProfile profile)
		{
			//IL_0035: Expected I4, but got O
			if (profile != null)
			{
				return profile.UserID;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	private sealed class <>c__DisplayClass10_0
	{
		public List<int> blockedIds;

		internal bool <OnUserBlocked>b__1(UserWrapper user)
		{
			//IL_005e: Expected I4, but got O
			PlayerInfo <User>k__BackingField = user.<User>k__BackingField;
			if (user.<User>k__BackingField != null && blockedIds != null)
			{
				bool flag = blockedIds.Contains(<User>k__BackingField.<DBID>k__BackingField);
				return (byte)((flag ? 1u : 0u) ^ 1u) != 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass12_0
	{
		public List<int> blockedIds;

		public OnlineUsersListView <>4__this;

		internal bool <UpdateData>b__1(PlayerInfo user)
		{
			//IL_005e: Expected I4, but got O
			if (user != null && blockedIds != null)
			{
				bool flag = blockedIds.Contains(user.<DBID>k__BackingField);
				return (byte)((flag ? 1u : 0u) ^ 1u) != 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal unsafe UserWrapper <UpdateData>b__2(PlayerInfo user)
		{
			//IL_0039: Expected O, but got I
			//IL_00b9: Expected O, but got I
			//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d1: Expected O, but got Unknown
			//IL_00e7: Expected O, but got I
			//IL_0283: Expected O, but got I4
			//IL_0147: Expected O, but got I
			//IL_0309: Expected O, but got I4
			//IL_02b1: Expected O, but got I
			//IL_02cb: Expected O, but got I4
			//IL_01a9: Expected O, but got I
			//IL_01b9: Expected O, but got I
			//IL_01c2: Expected native int or pointer, but got O
			//IL_01cc: Expected native int or pointer, but got O
			//IL_01da: Expected native int or pointer, but got O
			//IL_0341: Expected O, but got I
			//IL_0351: Expected O, but got I
			//IL_035a: Expected native int or pointer, but got O
			//IL_0364: Expected native int or pointer, but got O
			//IL_0372: Expected native int or pointer, but got O
			//IL_0391: Expected O, but got I4
			//IL_0233: Expected O, but got I4
			//IL_0225: Expected O, but got I4
			//IL_03e8: Expected native int or pointer, but got O
			//IL_03f5: Expected native int or pointer, but got O
			//IL_040d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0412: Expected O, but got Unknown
			//IL_0241: Expected O, but got I4
			OnlineUsersListView onlineUsersListView = <>4__this;
			string name;
			object obj2;
			if ((object)<>4__this != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X8_v1 (OnlineUsersListView)+38]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X8_v1 (OnlineUsersListView)+38]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ X8_v4+18]");
					if ((nint)0 == 0)
					{
						goto IL_03ad;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ X8_v4+20]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ X8_v4+20]");
						name = ((UnityEngine.Object)0).name;
						obj2 = typeof(RegisteredWaitHandle) + 3136;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6128]");
						object obj3 = (nint)0 & (nint)1;
						if (obj3 != null)
						{
							object obj4 = obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v15+E4]");
							if ((nint)0 != 0)
							{
								goto IL_0131;
							}
						}
						else
						{
							_ = 1;
							object obj4 = obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v15+E4]");
							bool flag = (nint)0 == 0;
							object obj5 = !flag;
							if (obj5 != null)
							{
								goto IL_0131;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4588]");
						object obj6 = (nint)0 & (nint)1;
						bool flag2 = obj6 == null;
						object obj7 = !flag2;
						if (obj7 != null)
						{
							goto IL_0164;
						}
						goto IL_02d9;
					}
				}
			}
			goto IL_039f;
			IL_02d9:
			_ = 1;
			object obj8 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v26+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			object obj10 = obj8;
			if (obj9 != null)
			{
				goto IL_0199;
			}
			goto IL_031f;
			IL_0164:
			obj8 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v26+E4]");
			bool flag4 = (nint)0 == 0;
			obj10 = obj8;
			if (!flag4)
			{
				goto IL_0199;
			}
			goto IL_031f;
			IL_031f:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj11 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v9+B8]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v7+18]");
			object obj13 = 0;
			UserWrapper userWrapper = default(UserWrapper);
			((UserWrapper*)(nint)userWrapper)-><index>k__BackingField = 0;
			System.Runtime.CompilerServices.Unsafe.Write(&((UserWrapper*)(nint)userWrapper)-><User>k__BackingField, null);
			((UserWrapper*)(nint)userWrapper)-><TrackingPlacement>k__BackingField = TrackingPlacement.Background;
			bool flag5 = user == null;
			object obj14 = !flag5;
			if (obj14 != null)
			{
				goto IL_01fc;
			}
			goto IL_039f;
			IL_0199:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v26+B8]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v19+18]");
			obj13 = 0;
			((UserWrapper*)(nint)userWrapper)-><index>k__BackingField = 0;
			System.Runtime.CompilerServices.Unsafe.Write(&((UserWrapper*)(nint)userWrapper)-><User>k__BackingField, null);
			((UserWrapper*)(nint)userWrapper)-><TrackingPlacement>k__BackingField = TrackingPlacement.Background;
			if (user != null)
			{
				goto IL_01fc;
			}
			goto IL_039f;
			IL_01fc:
			object obj16 = (((nint)obj13 != 15) ? ((object)12) : ((object)44));
			if ((nint)obj13 == 14)
			{
				object obj17 = 41;
			}
			else
			{
				object obj17 = obj16;
			}
			((UserWrapper*)(nint)userWrapper)-><index>k__BackingField = user.<DBID>k__BackingField;
			System.Runtime.CompilerServices.Unsafe.Write(&((UserWrapper*)(nint)userWrapper)-><template>k__BackingField, name);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj18 = userWrapper + 16;
			obj18 = user;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			UserWrapper result = default(UserWrapper);
			return result;
			IL_03ad:
			return (UserWrapper)new IndexOutOfRangeException();
			IL_039f:
			NullReferenceException ex = new NullReferenceException();
			goto IL_03ad;
			IL_0131:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4588]");
			object obj19 = (nint)0 & (nint)1;
			if (obj19 != null)
			{
				goto IL_0164;
			}
			goto IL_02d9;
		}
	}

	private sealed class <UpdateTimer>d__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public OnlineUsersListView <>4__this;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <UpdateTimer>d__14(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0142: Expected I4, but got I8
			//IL_020e: Expected I4, but got O
			//IL_0167: Unknown result type (might be due to invalid IL or missing references)
			//IL_016c: Expected O, but got Unknown
			//IL_0036: Expected I4, but got I8
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Expected O, but got Unknown
			//IL_0074: Expected O, but got I4
			//IL_009d: Expected O, but got I
			//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d2: Expected O, but got Unknown
			//IL_0259: Unknown result type (might be due to invalid IL or missing references)
			//IL_025e: Expected O, but got Unknown
			OnlineUsersListView onlineUsersListView = <>4__this;
			if (<>1__state != 0)
			{
				if (<>1__state != 1)
				{
					goto IL_011d;
				}
				<>1__state = -1;
				object obj = typeof(Queue<string>) + 848;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v9+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj4 = (nint)0 + (nint)2200;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				SessionModel sessionModel = default(SessionModel);
				if ((object)sessionModel != null)
				{
					Room currentRoom = sessionModel.CurrentRoom;
					if (currentRoom != null)
					{
						if ((object)<>4__this != null)
						{
							<>4__this.RequestList();
							goto IL_011d;
						}
					}
					else if ((object)<>4__this != null)
					{
						object obj5 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1680;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj6 = default(object);
						obj6..ctor();
						_ = 0;
						object obj7 = obj6 + 32;
						obj7 = <>4__this;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						Coroutine coroutine = <>4__this.StartCoroutine((IEnumerator)obj6);
						return <>1__state == 0;
					}
				}
			}
			else
			{
				<>1__state = -1;
				if ((object)<>4__this != null)
				{
					object obj8 = this + 24;
					obj8 = onlineUsersListView._waitForSeconds;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					_ = 1;
					return <>1__state == 0;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_011d:
			return <>1__state == 0;
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
			object obj2 = (nint)0 + (nint)104;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}
	}

	private float updateDelay;

	private TextMeshProUGUI counter;

	private GameObject loader;

	private WaitForSeconds _waitForSeconds;

	private IUsersListSource _listSource;

	protected override void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0034: Expected O, but got I
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c5: Expected O, but got Unknown
		//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f3: Expected O, but got Unknown
		//IL_0065: Expected I, but got O
		//IL_0094: Expected O, but got I4
		//IL_00bd: Expected O, but got I
		//IL_00f0: Expected O, but got I4
		//IL_0170: Expected O, but got I4
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected O, but got Unknown
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected O, but got Unknown
		//IL_01d9: Expected I, but got O
		//IL_01e9: Expected O, but got I
		//IL_027f: Expected O, but got I
		//IL_0224: Expected O, but got I
		//IL_02d8: Expected O, but got I4
		//IL_0346: Unknown result type (might be due to invalid IL or missing references)
		//IL_034b: Expected O, but got Unknown
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Expected O, but got Unknown
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Expected O, but got Unknown
		//IL_0376: Expected O, but got I
		//IL_039a: Expected O, but got I4
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Expected O, but got Unknown
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected O, but got Unknown
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Expected O, but got Unknown
		object obj = typeof(UsageHint) + 1640;
		object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2416;
		object obj3 = (nint)0 + (nint)2144;
		object obj4 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		object obj5 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		WaitForSeconds waitForSeconds = default(WaitForSeconds);
		waitForSeconds..ctor(updateDelay);
		_waitForSeconds = waitForSeconds;
		object obj6 = this + 392;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<int> action = default(Action<int>);
		action..ctor((object)this, (IntPtr)obj3);
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v8+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj9 = (nint)0 + (nint)2200;
		FriendsManager.OnUserBlocked += action;
		object obj10 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v11+E4]");
		bool flag2 = (nint)0 == 0;
		object obj11 = !flag2;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		Room currentRoom = sessionModel.CurrentRoom;
		if (currentRoom == null)
		{
			return;
		}
		object obj12 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X0_v19+E4]");
		bool flag3 = (nint)0 == 0;
		object obj13 = !flag3;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel2 = default(SessionModel);
		Room currentRoom2 = sessionModel2.CurrentRoom;
		object obj14 = typeof(RegisteredWaitHandle) + 1376;
		object obj15 = "not" + 2704;
		nint num = (nint)currentRoom2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X8_v10 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X8_v10 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0265;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X8_v10 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj17 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X10_v7-8]");
			if (0 == (nint)obj14)
			{
				break;
			}
			obj17 += 16;
			obj16--;
			if ((nint)obj16 != 1)
			{
				continue;
			}
			goto IL_0265;
		}
		object obj18 = obj17 + 35;
		object obj19 = num + obj18;
		object obj20 = obj19 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v17+8]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v237 @ X8_v17] (should have been resolved before IL gen)");
		object obj22 = default(object);
		bool flag4 = obj22 == null;
		object obj23 = !flag4;
		object obj24 = obj15;
		if (obj23 == null)
		{
			return;
		}
		goto IL_02ae;
		IL_0265:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X0_v32+8]");
		obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v319 @ X0_v32] (should have been resolved before IL gen)");
		object obj25 = default(object);
		bool flag5 = obj25 == null;
		obj24 = obj15;
		if (!flag5)
		{
			goto IL_02ae;
		}
		return;
		IL_02ae:
		object obj26 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X0_v25+E4]");
		bool flag6 = (nint)0 == 0;
		object obj27 = !flag6;
		if (obj27 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel3 = default(SessionModel);
		Room currentRoom3 = sessionModel3.CurrentRoom;
		object defaultValue = "Material with texture name \"" + 3392;
		VariableBinderExtensions.Bind(counter, currentRoom3, (string)obj15, (string)defaultValue);
	}

	protected override void Start()
	{
		//IL_006e: Expected I, but got O
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0039: Expected I, but got O
		//IL_0049: Expected O, but got I
		//IL_0059: Expected O, but got I
		List<UserWrapper> list2 = default(List<UserWrapper>);
		while (true)
		{
			Start();
			nint num = (nint)this;
			List<UserWrapper> list = base.data;
			if (list != null)
			{
				break;
			}
			object obj = typeof(List<Tween>) + 208;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			list2..ctor();
			nint num2 = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v8 (Il2CppClass<OnlineUsersListView>)+2A8]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v8 (Il2CppClass<OnlineUsersListView>)+2B0]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v71 @ X3_v1 (should have been resolved before IL gen)");
		}
	}

	private void OnEnable()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0102: Expected O, but got I
		//IL_012c: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_0175: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6123]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v4+E4]");
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
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v4+E4]");
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
		SessionModel sessionModel = default(SessionModel);
		bool flag3 = (object)sessionModel == null;
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
		Room currentRoom = sessionModel.CurrentRoom;
		if (currentRoom != null)
		{
			if (_listSource != null)
			{
				RequestList();
				return;
			}
			InitDataSource();
			RequestList();
		}
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0074: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2416;
		object obj2 = (nint)0 + (nint)2144;
		object obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<int> action = default(Action<int>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
		if ((nint)0 != 0)
		{
			FriendsManager.OnUserBlocked -= action;
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		FriendsManager.OnUserBlocked -= action;
	}

	private void InitDataSource()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_01d5: Expected O, but got I
		//IL_01ff: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_0248: Expected O, but got I4
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Expected O, but got Unknown
		//IL_029e: Expected O, but got I4
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected O, but got Unknown
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected O, but got Unknown
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected O, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_01be: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6125]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v9+E4]");
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
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v9+E4]");
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
		SessionModel sessionModel = default(SessionModel);
		bool flag3 = (object)sessionModel == null;
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
		Room currentRoom = sessionModel.CurrentRoom;
		object obj15;
		if (SFSKammelnaRoomExtensions.IsSuppressUserList(currentRoom))
		{
			GameObject gameObject = base.gameObject;
			object obj9 = typeof(RegisteredWaitHandle) + 784;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj10 = default(object);
			obj10..ctor();
			object obj11 = obj10 + 16;
			obj11 = gameObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_listSource = (IUsersListSource)obj10;
			object obj12 = this + 400;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			if (!((double)updateDelay < 30.0))
			{
				return;
			}
			object obj13 = typeof(UsageHint) + 1640;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			WaitForSeconds waitForSeconds = default(WaitForSeconds);
			waitForSeconds..ctor(30f);
			object obj14 = waitForSeconds;
			obj15 = 392;
		}
		else
		{
			object obj16 = typeof(RegisteredWaitHandle) + 1440;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj17 = default(object);
			obj17..ctor();
			object obj14 = obj17;
			obj15 = 400;
		}
		object obj18 = (object)this + obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private void OnUserBlocked(int _)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Expected O, but got Unknown
		//IL_0257: Expected O, but got I4
		//IL_0087: Expected O, but got I
		//IL_0098: Expected O, but got I
		//IL_00a8: Expected O, but got I
		//IL_00ca: Expected O, but got I4
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected O, but got Unknown
		//IL_0172: Expected O, but got I
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected O, but got Unknown
		//IL_0199: Expected I, but got O
		//IL_00fa: Expected O, but got I4
		//IL_01c3: Expected I, but got O
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Expected O, but got Unknown
		//IL_031a: Expected O, but got I
		//IL_032b: Expected I, but got O
		//IL_0349: Expected O, but got I
		//IL_01eb: Expected I, but got O
		//IL_01fb: Expected O, but got I
		//IL_020b: Expected O, but got I
		//IL_012a: Expected O, but got I
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1664;
		object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		object obj3 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj4 = default(object);
		obj4..ctor();
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v4+E4]");
		if ((nint)0 == 0)
		{
			goto IL_0215;
		}
		IEnumerable<FriendProfile> blockedList = FriendsManager.BlockedList;
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v11+E4]");
		bool flag = (nint)0 == 0;
		IEnumerable<FriendProfile> source = blockedList;
		object obj7 = obj6;
		IEnumerable<FriendProfile> enumerable = blockedList;
		if (!flag)
		{
			goto IL_007b;
		}
		goto IL_027d;
		IL_027d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj6 = obj3;
		source = enumerable;
		goto IL_007b;
		IL_007b:
		object obj8 = (nint)0 + (nint)3272;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v11+B8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v12+8]");
		Func<object, int> selector = (Func<object, int>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v12+8]");
		bool flag2 = (nint)0 == 0;
		object obj10 = !flag2;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v11+E4]");
			bool flag3 = (nint)0 == 0;
			object obj11 = !flag3;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj12 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v18+B8]");
				obj9 = 0;
			}
			object obj13 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1200;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj14 = (nint)0 + (nint)64;
			Func<object, int> func = default(Func<object, int>);
			func..ctor(obj9, (IntPtr)obj14);
			object obj15 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v17+B8]");
			object obj16 = (nint)0 + (nint)8;
			obj16 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			selector = func;
		}
		IEnumerable<int> source2 = Enumerable.Select(source, selector);
		List<int> list = Enumerable.ToList(source2);
		object obj17 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 168;
		object obj18 = (nint)0 + (nint)80;
		object obj19 = obj4 + 16;
		obj19 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		nint num = (nint)this;
		List<UserWrapper> source3 = base.data;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<UserWrapper, bool> func2 = default(Func<UserWrapper, bool>);
		func2..ctor(obj4, (IntPtr)obj18);
		IEnumerable<UserWrapper> source4 = Enumerable.Where(source3, func2);
		List<UserWrapper> list2 = Enumerable.ToList(source4);
		nint num2 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v10 (Il2CppClass<OnlineUsersListView>)+2A8]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v10 (Il2CppClass<OnlineUsersListView>)+2B0]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v196 @ X3_v3 (should have been resolved before IL gen)");
		goto IL_0215;
		IL_0215:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		IEnumerable<FriendProfile> blockedList2 = FriendsManager.BlockedList;
		obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v11+E4]");
		bool flag4 = (nint)0 == 0;
		object obj22 = !flag4;
		source = blockedList2;
		obj7 = obj6;
		enumerable = blockedList2;
		if (obj22 != null)
		{
			goto IL_007b;
		}
		goto IL_027d;
	}

	private void RequestList()
	{
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0090: Expected O, but got I
		//IL_00c6: Expected I, but got O
		//IL_0047: Expected O, but got I4
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected O, but got Unknown
		//IL_00e7: Expected I, but got O
		//IL_00f7: Expected O, but got I
		//IL_020c: Expected O, but got I
		//IL_0132: Expected O, but got I
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected O, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected O, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected O, but got Unknown
		List<UserWrapper> list = base.data;
		bool active;
		if (list != null)
		{
			List<UserWrapper> list2 = base.data;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v16 (System.Collections.Generic.List`1<UserWrapper>)+18]");
			bool flag = (nint)0 == 0;
			bool flag2 = (object)loader == null;
			object obj = !flag2;
			active = flag;
			if (obj == null)
			{
				throw new NullReferenceException();
			}
		}
		else
		{
			active = true;
		}
		object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3976;
		object obj3 = (nint)0 + (nint)2152;
		loader.SetActive(active);
		IUsersListSource listSource = _listSource;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj3);
		object obj4 = typeof(System.IOAsyncCallback) + 1992;
		nint num = (nint)listSource;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v8 (Il2CppClass<IUsersListSource>)+12E]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v8 (Il2CppClass<IUsersListSource>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0173;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v8 (Il2CppClass<IUsersListSource>)+B0]");
		object obj6 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X10_v5-8]");
			if (0 == (nint)obj4)
			{
				break;
			}
			obj6 += 16;
			obj5--;
			if ((nint)obj5 != 1)
			{
				continue;
			}
			goto IL_0173;
		}
		object obj7 = num + obj6;
		object obj8 = obj7 + 312;
		goto IL_01f4;
		IL_0173:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_01f4;
		IL_01f4:
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X0_v10+8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v145 @ X3_v3 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	private void UpdateData(UsersListModel usersListModel)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_00a9: Expected O, but got I4
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_0187: Expected O, but got I
		//IL_0197: Expected O, but got I
		//IL_01b9: Expected O, but got I4
		//IL_022a: Expected O, but got I
		//IL_0120: Expected O, but got I
		//IL_0130: Expected O, but got I
		//IL_0152: Expected O, but got I4
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected O, but got Unknown
		//IL_01e9: Expected O, but got I4
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected O, but got Unknown
		//IL_029d: Expected O, but got I
		//IL_02ae: Expected I, but got O
		//IL_051d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0522: Expected O, but got Unknown
		//IL_0538: Expected O, but got I
		//IL_0549: Expected I, but got O
		//IL_0567: Expected O, but got I
		//IL_02bf: Expected O, but got I
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected O, but got Unknown
		//IL_0219: Expected O, but got I
		//IL_0304: Expected O, but got I
		//IL_0312: Expected I, but got O
		//IL_031e: Expected O, but got I
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Expected O, but got Unknown
		//IL_035e: Expected O, but got I
		//IL_036f: Expected I, but got O
		//IL_039e: Expected I, but got O
		//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bc: Expected O, but got Unknown
		//IL_03e6: Expected O, but got I4
		//IL_040f: Expected O, but got I
		//IL_0446: Unknown result type (might be due to invalid IL or missing references)
		//IL_044b: Expected O, but got Unknown
		//IL_049e: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a3: Expected O, but got Unknown
		//IL_05c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ce: Expected O, but got Unknown
		//IL_04c8: Expected O, but got I
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1672;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 24;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		GameObject gameObject = base.gameObject;
		if (!gameObject.activeInHierarchy)
		{
			return;
		}
		object obj4 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X0_v14+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		IEnumerable<FriendProfile> blockedList = FriendsManager.BlockedList;
		object obj7 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1656;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X0_v66+E4]");
		object obj9;
		Func<object, int> selector;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X0_v66+B8]");
			obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X8_v50+10]");
			selector = (Func<object, int>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X8_v50+10]");
			bool flag2 = (nint)0 == 0;
			object obj10 = !flag2;
			if (obj10 == null)
			{
				goto IL_01c7;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X0_v66+B8]");
			obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X8_v50+10]");
			selector = (Func<object, int>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X8_v50+10]");
			bool flag3 = (nint)0 == 0;
			object obj11 = !flag3;
			if (obj11 == null)
			{
				goto IL_01c7;
			}
		}
		goto IL_021e;
		IL_021e:
		object obj12 = (nint)0 + (nint)3272;
		IEnumerable<int> source = Enumerable.Select(blockedList, selector);
		List<int> list = Enumerable.ToList(source);
		object obj13 = obj2 + 16;
		obj13 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj14 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2672;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj15 = (nint)0 + (nint)88;
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj2, (IntPtr)obj15);
		object obj16 = (nint)0 + (nint)3656;
		IEnumerable<object> source2 = Enumerable.Where(usersListModel.<UsersList>k__BackingField, func);
		object obj17 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2696;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj18 = (nint)0 + (nint)296;
		Func<object, float> func2 = default(Func<object, float>);
		func2..ctor((object)null, (IntPtr)obj18);
		object obj19 = (nint)0 + (nint)2448;
		IOrderedEnumerable<object> source3 = Enumerable.OrderByDescending(source2, func2);
		object obj20 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2712;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj21 = (nint)0 + (nint)96;
		Func<object, UserWrapper> func3 = default(Func<object, UserWrapper>);
		func3..ctor(obj2, (IntPtr)obj21);
		IEnumerable<UserWrapper> source4 = Enumerable.Select(source3, func3);
		List<UserWrapper> list2 = Enumerable.ToList(source4);
		nint num = (nint)this;
		base.data = list2;
		object obj22 = typeof(Queue<string>) + 848;
		object obj23 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X0_v39+E4]");
		bool flag4 = (nint)0 == 0;
		object obj24 = !flag4;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj25 = (nint)0 + (nint)2200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		Room currentRoom = sessionModel.CurrentRoom;
		int? onlineUsersCount = SFSKammelnaRoomExtensions.GetOnlineUsersCount(currentRoom);
		object obj26 = (??)onlineUsersCount & 1;
		if (obj26 != null)
		{
		}
		int num2 = default(int);
		string text = num2.ToString();
		TextMeshProExtensions.FixArabic(counter, text);
		loader.SetActive(value: false);
		StopAllCoroutines();
		object obj27 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1680;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj28 = default(object);
		obj28..ctor();
		_ = 0;
		object obj29 = obj28 + 32;
		obj29 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Coroutine coroutine = StartCoroutine((IEnumerator)obj28);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (OnlineUsersListView)+A8]");
		if (Enumerable.Any((IEnumerable<KeyValuePair<object, object>>)0))
		{
			base.UpdateView();
		}
		return;
		IL_01c7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X0_v66+E4]");
		bool flag5 = (nint)0 == 0;
		object obj30 = !flag5;
		if (obj30 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj31 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X8_v56+B8]");
			obj9 = 0;
		}
		object obj32 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj33 = (nint)0 + (nint)72;
		Func<object, int> func4 = default(Func<object, int>);
		func4..ctor(obj9, (IntPtr)obj33);
		object obj34 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v55+B8]");
		object obj35 = (nint)0 + (nint)16;
		obj35 = func4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		selector = func4;
		goto IL_021e;
	}

	private static TrackingPlacement GetTrackingPlacement()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0184: Expected O, but got I4
		//IL_0093: Expected O, but got I
		//IL_020a: Expected O, but got I4
		//IL_01b2: Expected O, but got I
		//IL_01cc: Expected O, but got I4
		//IL_00f5: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(RegisteredWaitHandle) + 3136;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6128]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v9+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v9+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4588]");
		object obj6 = (nint)0 & (nint)1;
		bool flag2 = obj6 == null;
		object obj7 = !flag2;
		if (obj7 != null)
		{
			goto IL_00b0;
		}
		goto IL_01da;
		IL_00e5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v15+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v11+18]");
		TrackingPlacement result = (((nint)0 != 15) ? TrackingPlacement.CommunityList : TrackingPlacement.MassTournamentView);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v11+18]");
		if ((nint)0 == 14)
		{
			return TrackingPlacement.TournamentView;
		}
		return result;
		IL_0220:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj9 = obj2;
		goto IL_00e5;
		IL_00b0:
		obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v15+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = obj9;
		if (!flag3)
		{
			goto IL_00e5;
		}
		goto IL_0220;
		IL_007d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4588]");
		object obj11 = (nint)0 & (nint)1;
		if (obj11 != null)
		{
			goto IL_00b0;
		}
		goto IL_01da;
		IL_01da:
		_ = 1;
		obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v15+E4]");
		bool flag4 = (nint)0 == 0;
		object obj12 = !flag4;
		obj10 = obj9;
		if (obj12 != null)
		{
			goto IL_00e5;
		}
		goto IL_0220;
	}

	private IEnumerator UpdateTimer()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1680;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		object obj3 = obj2 + 32;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (IEnumerator)obj2;
	}

	public OnlineUsersListView()
	{
		((UiGridView<UserWrapper, object>)(object)this)..ctor();
	}
}
