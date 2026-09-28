using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using Cpp2ILInjected;
using Features.GameReplay;
using Kammelna.Server;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.AdaptivePerformance;

public class GiftBombManager : MonoBehaviour
{
	private sealed class <>c__DisplayClass10_0
	{
		public GiftBombManager <>4__this;

		public GiftBombData giftBombData;

		internal void <TryClaim>b__0(bool success, string errorMessage)
		{
			//IL_003e: Expected O, but got I4
			if (success)
			{
				<>4__this.OnResponseSucceeded(giftBombData);
			}
			else
			{
				<>4__this.OnResponseFail((GiftBombData)success, errorMessage);
			}
		}
	}

	private sealed class <>c__DisplayClass9_0
	{
		public GiftBombManager <>4__this;

		public Room room;

		internal void <OnOnJoinRoom>b__0()
		{
			<>4__this.OnBombReleased(room);
		}
	}

	private GiftBombEventsChannel giftBombEvents;

	private static readonly List<long> ClaimedBombIds;

	private GiftBombData _currentGiftBomb;

	public GiftBombData CurrentGiftBomb => _currentGiftBomb;

	public static void OnLogout()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00f4: Expected O, but got I4
		//IL_0095: Expected O, but got I
		//IL_00b8: Expected O, but got I
		//IL_012c: Expected O, but got I
		//IL_014e: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2856;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8975]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v14+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v14+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			if (obj6 != null)
			{
				goto IL_0085;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v5+B8]");
		object obj8 = 0;
		object obj9 = obj8;
		bool flag3 = obj8 == null;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00a2;
		IL_0085:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v14+B8]");
		object obj11 = 0;
		obj9 = obj11;
		goto IL_00a2;
		IL_00a2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v8+1C]");
		object obj12 = (nint)0 + (nint)1;
		_ = 0;
	}

	private void Start()
	{
		BindBombData();
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_003e: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3344;
		object obj2 = (nint)0 + (nint)3160;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		SFS.OnJoinRoom -= action;
	}

	private void BindBombData()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00d1: Expected O, but got I
		//IL_00fb: Expected O, but got I4
		//IL_00ac: Expected O, but got I4
		//IL_0053: Expected O, but got I
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Expected O, but got Unknown
		//IL_025b: Expected O, but got I
		//IL_0269: Expected I, but got O
		//IL_0191: Expected O, but got I4
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		//IL_01f9: Expected O, but got I
		//IL_0207: Expected I, but got O
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected O, but got Unknown
		object obj = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8977]");
		object obj2 = (nint)0 & (nint)1;
		object obj5;
		object obj3;
		if (obj2 != null)
		{
			obj3 = (nint)0 + (nint)2200;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v19+E4]");
			bool flag = (nint)0 == 0;
			obj5 = obj3;
			if (!flag)
			{
				goto IL_0088;
			}
		}
		else
		{
			_ = 1;
			obj3 = (nint)0 + (nint)2200;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v19+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			obj5 = obj3;
			if (obj6 != null)
			{
				goto IL_0088;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		obj3 = obj5;
		goto IL_0137;
		IL_0137:
		SessionModel sessionModel = default(SessionModel);
		if (sessionModel.IsInLobby)
		{
			GameObject go = base.gameObject;
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X0_v10+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel2 = default(SessionModel);
			Room currentRoom = sessionModel2.CurrentRoom;
			object obj9 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj10 = (nint)0 + (nint)3152;
			Action action = default(Action);
			action..ctor(this, (IntPtr)obj10);
			object varName = "___# Content push apply failed [{0}]: {1}" + 2736;
			VariableBinderExtensions.Bind(go, currentRoom, (string)varName, action);
		}
		else
		{
			object obj11 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3344;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj12 = (nint)0 + (nint)3160;
			Action<object> action2 = default(Action<object>);
			action2..ctor((object)this, (IntPtr)obj12);
			SFS.OnJoinRoom += action2;
		}
		return;
		IL_0088:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag4 = (object)sessionModel == null;
		object obj13 = !flag4;
		if (obj13 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0137;
	}

	private void OnOnJoinRoom(Room room)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00ba: Expected O, but got I
		//IL_00cb: Expected I, but got O
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		//IL_00f7: Expected O, but got I
		object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 24;
		obj4 = room;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if (SFSKammelnaRoomExtensions.IsLobby((Room)obj4))
		{
			GameObject go = base.gameObject;
			object obj5 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj6 = (nint)0 + (nint)2176;
			Action action = default(Action);
			action..ctor(obj2, (IntPtr)obj6);
			object varName = "___# Content push apply failed [{0}]: {1}" + 2736;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3 (System.Object)+18]");
			VariableBinderExtensions.Bind(go, (Room)0, (string)varName, action);
		}
	}

	public void TryClaim(List<Vector2> captchaSolution)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_00ca: Expected O, but got I
		//IL_00e5: Expected I, but got O
		//IL_0107: Expected I8, but got I
		object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Room lobby = SFS.Lobby;
		GiftBombData activeBombInfo = SFSKammelnaRoomExtensions.GetActiveBombInfo(lobby);
		object obj4 = obj2 + 24;
		obj4 = activeBombInfo;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if (obj4 != null)
		{
			GameObject lifecycle = base.gameObject;
			object obj5 = obj4;
			object obj6 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2376;
			object obj7 = (nint)0 + (nint)2168;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			SFS.CurrencyBombClaim currencyBombClaim = default(SFS.CurrencyBombClaim);
			currencyBombClaim..ctor(obj2, (IntPtr)obj7);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v9+10]");
			SFS.SendClaimCurrencyBomb(lifecycle, 0L, captchaSolution, currencyBombClaim);
		}
		else
		{
			GiftBombEventsChannel giftBombEventsChannel = giftBombEvents;
			object obj8 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1176;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			Enum enumeration = default(Enum);
			string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
			Action<string> onClaimFail = giftBombEventsChannel.OnClaimFail;
			if (giftBombEventsChannel.OnClaimFail != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v124 @ X8_v8 (System.Action`1<System.String>)+18] (should have been resolved before IL gen)");
			}
		}
	}

	public void DismissBomb()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00e5: Expected O, but got I4
		//IL_00a2: Expected O, but got I4
		//IL_012c: Expected O, but got I
		//IL_0151: Expected O, but got I
		//IL_0166: Expected O, but got I
		//IL_0194: Expected O, but got I4
		//IL_01b8: Expected O, but got I
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Expected O, but got Unknown
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2856;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E897A]");
		object obj2 = (nint)0 & (nint)1;
		object obj3;
		if (obj2 != null)
		{
			obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3+E4]");
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
			obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			object obj4 = obj3;
			if (obj5 != null)
			{
				goto IL_007c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj3 = obj;
		GiftBombData currentGiftBomb = _currentGiftBomb;
		goto IL_011c;
		IL_011c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3+B8]");
		object obj6 = 0;
		List<long> list = (List<long>)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v4 (System.Collections.Generic.List`1<System.Int64>)+1C]");
		object obj7 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v4 (System.Collections.Generic.List`1<System.Int64>)+10]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v4 (System.Collections.Generic.List`1<System.Int64>)+18]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X9_v7+18]");
		bool flag3 = num < 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v4 (System.Collections.Generic.List`1<System.Int64>)+18]");
			object obj10 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v4 (System.Collections.Generic.List`1<System.Int64>)+18]");
			object obj11 = obj8 + 0;
			_ = currentGiftBomb.<Id>k__BackingField;
		}
		else
		{
			list.AddWithResize(currentGiftBomb.<Id>k__BackingField);
		}
		return;
		IL_007c:
		currentGiftBomb = _currentGiftBomb;
		bool flag4 = _currentGiftBomb == null;
		object obj12 = !flag4;
		if (obj12 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_011c;
	}

	public bool CurrentBombIsAlreadyClaimed()
	{
		//IL_00e3: Expected I4, but got O
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_006b: Expected O, but got I4
		//IL_011c: Expected O, but got I
		GiftBombData currentGiftBomb = _currentGiftBomb;
		if (_currentGiftBomb != null)
		{
			if (currentGiftBomb.<IsClaimed>k__BackingField)
			{
				return true;
			}
			object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2856;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				currentGiftBomb = _currentGiftBomb;
				if (_currentGiftBomb == null)
				{
					goto IL_00d5;
				}
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v5+B8]");
			object obj4 = 0;
			if (obj4 != null)
			{
				return ((List<long>)obj4).Contains(currentGiftBomb.<Id>k__BackingField);
			}
		}
		goto IL_00d5;
		IL_00d5:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private void OnBombReleased(Room lobbyRoom)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_0097: Expected O, but got I4
		//IL_0251: Expected O, but got I
		//IL_00df: Expected I8, but got I
		//IL_0211: Expected O, but got I4
		//IL_01d6: Expected O, but got I4
		if (lobbyRoom == null)
		{
			return;
		}
		GiftBombData activeBombInfo = SFSKammelnaRoomExtensions.GetActiveBombInfo(lobbyRoom);
		object obj = this + 40;
		obj = activeBombInfo;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = obj;
		GiftBombData giftBombData;
		if (obj != null)
		{
			object obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2856;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X0_v13+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
				obj4 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X0_v13+B8]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v10+10]");
			if (!((List<long>)obj6).Contains(0L))
			{
				goto IL_0173;
			}
			giftBombData = (GiftBombData)obj;
		}
		else
		{
			giftBombData = null;
		}
		GiftBombEventsChannel giftBombEventsChannel = giftBombEvents;
		GiftBombEventsChannel.BombEventDel bombEventDel = giftBombEventsChannel.OnBombCleared;
		if (giftBombEventsChannel.OnBombCleared != null)
		{
			goto IL_0142;
		}
		return;
		IL_0142:
		IntPtr invoke_impl = ((Delegate)bombEventDel).invoke_impl;
		IntPtr method_code = ((Delegate)bombEventDel).method_code;
		IntPtr method = ((Delegate)bombEventDel).method;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v91 @ X3_v1 (System.IntPtr) (should have been resolved before IL gen)");
		goto IL_0173;
		IL_0173:
		bool flag2 = CurrentBombIsAlreadyClaimed();
		GiftBombEventsChannel giftBombEventsChannel2 = giftBombEvents;
		giftBombData = _currentGiftBomb;
		if (flag2)
		{
			bombEventDel = giftBombEventsChannel2.OnBombClaimed;
			bool flag3 = giftBombEventsChannel2.OnBombClaimed == null;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				return;
			}
		}
		else
		{
			bombEventDel = giftBombEventsChannel2.OnBombDrop;
			bool flag4 = giftBombEventsChannel2.OnBombDrop == null;
			object obj8 = !flag4;
			if (obj8 == null)
			{
				return;
			}
		}
		goto IL_0142;
	}

	private void OnResponseSucceeded(GiftBombData claimedGiftBomb)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00d9: Expected O, but got I4
		//IL_0096: Expected O, but got I4
		//IL_0116: Expected O, but got I
		//IL_013b: Expected O, but got I
		//IL_0150: Expected O, but got I
		//IL_017e: Expected O, but got I4
		//IL_01a2: Expected O, but got I
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected O, but got Unknown
		//IL_0232: Expected O, but got I
		//IL_0242: Expected O, but got I
		//IL_0252: Expected O, but got I
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2856;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E897D]");
		object obj2 = (nint)0 & (nint)1;
		object obj3;
		if (obj2 != null)
		{
			obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3+E4]");
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
			obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			object obj4 = obj3;
			if (obj5 != null)
			{
				goto IL_007c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj3 = obj;
		goto IL_0106;
		IL_0106:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3+B8]");
		object obj6 = 0;
		List<long> list = (List<long>)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v4 (System.Collections.Generic.List`1<System.Int64>)+1C]");
		object obj7 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v4 (System.Collections.Generic.List`1<System.Int64>)+10]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v4 (System.Collections.Generic.List`1<System.Int64>)+18]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X9_v4+18]");
		bool flag3 = num < 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v4 (System.Collections.Generic.List`1<System.Int64>)+18]");
			object obj10 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v4 (System.Collections.Generic.List`1<System.Int64>)+18]");
			object obj11 = obj8 + 0;
			_ = claimedGiftBomb.<Id>k__BackingField;
		}
		else
		{
			list.AddWithResize(claimedGiftBomb.<Id>k__BackingField);
		}
		GiftBombEventsChannel giftBombEventsChannel = giftBombEvents;
		Action<GiftBombData> onShardClaimed = giftBombEventsChannel.OnShardClaimed;
		if (giftBombEventsChannel.OnShardClaimed != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v10 (System.Action`1<GiftBombData>)+18]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v10 (System.Action`1<GiftBombData>)+40]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v10 (System.Action`1<GiftBombData>)+28]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v123 @ X3_v1 (should have been resolved before IL gen)");
		}
		return;
		IL_007c:
		bool flag4 = claimedGiftBomb == null;
		object obj15 = !flag4;
		if (obj15 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0106;
	}

	private void OnResponseFail(GiftBombData claimedGiftBomb, string errorMessage)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00e5: Expected O, but got I4
		//IL_00a2: Expected O, but got I4
		//IL_012c: Expected O, but got I
		//IL_0151: Expected O, but got I
		//IL_0166: Expected O, but got I
		//IL_0194: Expected O, but got I4
		//IL_01b8: Expected O, but got I
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Expected O, but got Unknown
		//IL_0248: Expected O, but got I
		//IL_0258: Expected O, but got I
		//IL_0268: Expected O, but got I
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2856;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E897E]");
		object obj2 = (nint)0 & (nint)1;
		object obj3;
		if (obj2 != null)
		{
			obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+E4]");
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
			obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			object obj4 = obj3;
			if (obj5 != null)
			{
				goto IL_007c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj3 = obj;
		GiftBombData currentGiftBomb = _currentGiftBomb;
		goto IL_011c;
		IL_011c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+B8]");
		object obj6 = 0;
		List<long> list = (List<long>)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v4 (System.Collections.Generic.List`1<System.Int64>)+1C]");
		object obj7 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v4 (System.Collections.Generic.List`1<System.Int64>)+10]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v4 (System.Collections.Generic.List`1<System.Int64>)+18]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X9_v7+18]");
		bool flag3 = num < 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v4 (System.Collections.Generic.List`1<System.Int64>)+18]");
			object obj10 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v4 (System.Collections.Generic.List`1<System.Int64>)+18]");
			object obj11 = obj8 + 0;
			_ = currentGiftBomb.<Id>k__BackingField;
		}
		else
		{
			list.AddWithResize(currentGiftBomb.<Id>k__BackingField);
		}
		GiftBombEventsChannel giftBombEventsChannel = giftBombEvents;
		Action<string> onClaimFail = giftBombEventsChannel.OnClaimFail;
		if (giftBombEventsChannel.OnClaimFail != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v7 (System.Action`1<System.String>)+18]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v7 (System.Action`1<System.String>)+40]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v7 (System.Action`1<System.String>)+28]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v125 @ X3_v1 (should have been resolved before IL gen)");
		}
		return;
		IL_007c:
		currentGiftBomb = _currentGiftBomb;
		bool flag4 = _currentGiftBomb == null;
		object obj15 = !flag4;
		if (obj15 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_011c;
	}

	static GiftBombManager()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 1808;
		object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2856;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<long> list = default(List<long>);
		list..ctor();
		object obj3 = obj2;
		object obj4 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private void <BindBombData>b__8_0()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00cf: Expected O, but got I
		//IL_00f9: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_0142: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8980]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
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
			object obj4 = (nint)0 + (nint)2200;
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
		OnBombReleased(currentRoom);
	}
}
