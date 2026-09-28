using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Dynamic.Utils;
using System.Formats.Asn1;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using DataTracking;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models;
using Sfs2X.Entities;
using Sfs2X.Entities.Data;
using Unity.Properties;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;
using Util;

public class MassTournamentServerConnector : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<bool> <>9__28_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3128;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <ShowLoading>b__28_0()
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_010e: Expected O, but got I
			//IL_0138: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_01a0: Expected I4, but got O
			//IL_00dc: Expected I4, but got O
			//IL_0181: Expected O, but got I4
			object obj = 152985600;
			object obj2 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E60A2]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = (nint)0 + (nint)2200;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v4+E4]");
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v4+E4]");
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
			if (obj8 != null)
			{
				goto IL_00b8;
			}
			goto IL_018f;
			IL_01a5:
			bool result;
			return result;
			IL_00b8:
			Room currentRoom = sessionModel.CurrentRoom;
			bool flag4 = currentRoom == null;
			result = (byte)(int)currentRoom != 0;
			if (!flag4)
			{
				return SFSKammelnaRoomExtensions.IsMassTournament(currentRoom);
			}
			goto IL_01a5;
			IL_018f:
			NullReferenceException ex = new NullReferenceException();
			result = (byte)(int)ex != 0;
			goto IL_01a5;
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			if ((object)sessionModel != null)
			{
				goto IL_00b8;
			}
			goto IL_018f;
		}
	}

	private sealed class <>c__DisplayClass18_0
	{
		public MassTournamentServerConnector <>4__this;

		public string payload;

		internal void <Init>b__0(MassTournamentPlayerState _)
		{
			//IL_0048: Expected O, but got I4
			MassTournamentServerConnector massTournamentServerConnector = <>4__this;
			OneShotEvent<MassTournamentPlayerState> playerStateCache = massTournamentServerConnector.PlayerStateCache;
			MassTournamentPlayerState <Data>k__BackingField = playerStateCache.<Data>k__BackingField;
			bool flag = !<Data>k__BackingField.<IsRegistered>k__BackingField;
			object obj = !flag;
			if (obj == null)
			{
				MassTournamentInfo tournamentLiveData = GetTournamentLiveData();
				MassEventModel cachedMassEvent = MassTournamentManager.GetCachedMassEvent(tournamentLiveData.<Id>k__BackingField);
				if (cachedMassEvent.IsRegistrationOpen)
				{
					<>4__this.HandleRegistrationCode(payload);
				}
			}
		}
	}

	private sealed class <>c__DisplayClass20_0
	{
		public string registrationCode;

		internal void <HandleRegistrationCode>b__0(MassTournamentRegistrationSheet sheet)
		{
			sheet.popup.SlideFromBottom();
			sheet.ResetForm();
			sheet.FillRegistrationCode(registrationCode);
		}
	}

	private sealed class <>c__DisplayClass23_0
	{
		public Action<List<TournamentRoomModel>> callback;

		public MassTournamentServerConnector <>4__this;

		internal void <RequestRoomsList>b__0(ISFSObject data)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			//IL_0030: Expected I, but got O
			//IL_0040: Expected O, but got I
			//IL_00ea: Expected O, but got I4
			//IL_0155: Expected I, but got O
			//IL_0165: Expected O, but got I
			//IL_007b: Expected O, but got I
			//IL_01fb: Expected O, but got I
			//IL_0307: Unknown result type (might be due to invalid IL or missing references)
			//IL_030c: Expected O, but got Unknown
			//IL_0314: Expected I, but got O
			//IL_0324: Expected O, but got I
			//IL_01a0: Expected O, but got I
			//IL_0106: Unknown result type (might be due to invalid IL or missing references)
			//IL_010b: Expected O, but got Unknown
			//IL_0113: Unknown result type (might be due to invalid IL or missing references)
			//IL_0118: Expected O, but got Unknown
			//IL_0121: Unknown result type (might be due to invalid IL or missing references)
			//IL_0126: Expected O, but got Unknown
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_008e: Expected O, but got Unknown
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Expected O, but got Unknown
			//IL_035f: Expected O, but got I
			//IL_025d: Expected O, but got I4
			//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ab: Expected O, but got Unknown
			//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b8: Expected O, but got Unknown
			//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c6: Expected O, but got Unknown
			//IL_02d6: Expected O, but got I
			//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ec: Expected O, but got Unknown
			//IL_03f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_03fc: Expected O, but got Unknown
			//IL_042e: Expected I4, but got I8
			//IL_04dd: Expected O, but got I4
			//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b3: Expected O, but got Unknown
			//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c1: Expected O, but got Unknown
			//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_03bd: Expected O, but got Unknown
			//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ca: Expected O, but got Unknown
			//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d8: Expected O, but got Unknown
			//IL_053b: Expected O, but got I
			//IL_054b: Expected O, but got I
			//IL_055b: Expected O, but got I
			//IL_027a: Unknown result type (might be due to invalid IL or missing references)
			//IL_027f: Expected O, but got Unknown
			//IL_036d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0372: Expected O, but got Unknown
			//IL_037b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0380: Expected O, but got Unknown
			object obj = typeof(System.IOAsyncCallback) + 976;
			object obj2 = "setMimeType" + 3816;
			nint num = (nint)data;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00bc;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
			object obj4 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X10_v20-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj4 += 16;
				obj3--;
				if ((nint)obj3 != 1)
				{
					continue;
				}
				goto IL_00bc;
			}
			object obj5 = obj4 + 1;
			object obj6 = num + obj5;
			object obj7 = obj6 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v273 @ X0_v34] (should have been resolved before IL gen)");
			object obj8 = default(object);
			if (obj8 != null)
			{
				goto IL_014d;
			}
			goto IL_02fd;
			IL_052b:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X20_v3 (System.Action`1<System.Collections.Generic.List`1<TournamentRoomModel>>)+18]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X20_v3 (System.Action`1<System.Collections.Generic.List`1<TournamentRoomModel>>)+40]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X20_v3 (System.Action`1<System.Collections.Generic.List`1<TournamentRoomModel>>)+28]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v221 @ X3_v3 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
			IL_050f:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v468 @ X0_v7] (should have been resolved before IL gen)");
			ISFSArray array = default(ISFSArray);
			List<TournamentRoomModel> list = TournamentRoomModel.FromArray(array);
			object varName = "java.io.FileOutputStream" + 3592;
			object obj12 = <>4__this + 72;
			obj12 = list;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			MassTournamentServerConnector massTournamentServerConnector = <>4__this;
			int lastRoomUpdate = SFSExtensions.Get(data, (string)varName, -1);
			massTournamentServerConnector._lastRoomUpdate = lastRoomUpdate;
			MassTournamentServerConnector massTournamentServerConnector2 = <>4__this;
			Action<List<TournamentRoomModel>> action = callback;
			List<object> cachedRooms = (List<object>)(object)massTournamentServerConnector2._cachedRooms;
			goto IL_052b;
			IL_01e1:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X0_v24+8]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v383 @ X0_v24] (should have been resolved before IL gen)");
			object obj14 = default(object);
			if ((nint)obj14 == 304)
			{
				goto IL_0225;
			}
			goto IL_02fd;
			IL_03a0:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_050f;
			IL_00bc:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v182 @ X0_v31] (should have been resolved before IL gen)");
			object obj15 = default(object);
			bool flag = obj15 == null;
			object obj16 = !flag;
			if (obj16 != null)
			{
				goto IL_014d;
			}
			goto IL_02fd;
			IL_014d:
			nint num2 = (nint)data;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X8_v15 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X8_v15 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_01e1;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X8_v15 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
			object obj18 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X10_v15-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj18 += 16;
				obj17--;
				if ((nint)obj17 != 1)
				{
					continue;
				}
				goto IL_01e1;
			}
			object obj19 = obj18 + 14;
			object obj20 = num2 + obj19;
			object obj21 = obj20 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ X0_v27+8]");
			obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v458 @ X0_v27] (should have been resolved before IL gen)");
			object obj22 = default(object);
			if ((nint)obj22 == 304)
			{
				goto IL_0225;
			}
			goto IL_02fd;
			IL_0225:
			MassTournamentServerConnector massTournamentServerConnector3 = <>4__this;
			action = callback;
			bool flag2 = massTournamentServerConnector3._cachedRooms == null;
			object obj23 = !flag2;
			if (obj23 == null)
			{
				object obj24 = typeof(List<AdaptivePerformanceScaler>) + 4016;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				List<object> list2 = default(List<object>);
				list2..ctor();
			}
			bool flag3 = action == null;
			object obj25 = !flag3;
			if (obj25 == null)
			{
				throw new NullReferenceException();
			}
			goto IL_052b;
			IL_02fd:
			object obj26 = "com.unity.services.authentication.profile" + 2776;
			nint num3 = (nint)data;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			object obj27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_03a0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
			object obj28 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ X10_v8-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj28 += 16;
				obj27--;
				if ((nint)obj27 != 1)
				{
					continue;
				}
				goto IL_03a0;
			}
			object obj29 = obj28 + 28;
			object obj30 = num3 + obj29;
			object obj31 = obj30 + 312;
			goto IL_050f;
		}
	}

	private sealed class <>c__DisplayClass43_0
	{
		public Action<int> onSuccess;

		public Action<string> onError;

		internal void <RegisterInTournament>g__OnSuccess|0(int seat)
		{
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Expected O, but got Unknown
			//IL_0094: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 3136;
			Action<int> action = onSuccess;
			if (onSuccess != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v48 @ X8_v3 (System.Action`1<System.Int32>)+18] (should have been resolved before IL gen)");
			}
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			AsyncOperationHandle<SceneInstance> asyncOperationHandle = ScreenManager.ReloadScene();
		}

		internal void <RegisterInTournament>g__OnError|1(string error, int _, string __, DateTime ___)
		{
			//IL_0039: Expected O, but got I
			//IL_0049: Expected O, but got I
			//IL_0059: Expected O, but got I
			Action<string> action = onError;
			if (onError != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`1<System.String>)+18]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`1<System.String>)+40]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`1<System.String>)+28]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v3 @ X3_v1 (should have been resolved before IL gen)");
			}
		}
	}

	private const string ROOMS_LIST_COMMAND = "mrl";

	private const string ROOMS_LIST_LAST_UPDATE_KEY = "lup";

	private const string ROOMS_LIST_DATA_KEY = "d";

	private MassTournamentEventChannel eventChannel;

	private ComponentReference<MassTournamentRegistrationSheet> registrationSheet;

	private Sprite massTournamentIcon;

	private OneShotEvent<MassTournamentPlayerState> PlayerStateCache;

	private bool recoveringConnection;

	private int _lastRoomUpdate = -1;

	private List<TournamentRoomModel> _cachedRooms;

	private Room Room
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00dc: Expected O, but got I
			//IL_0106: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_014f: Expected O, but got I4
			object obj = 152985600;
			object obj2 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E60F3]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = (nint)0 + (nint)2200;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
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
			if (obj8 != null)
			{
				goto IL_00b8;
			}
			goto IL_015d;
			IL_00b8:
			return sessionModel.CurrentRoom;
			IL_015d:
			return (Room)new NullReferenceException();
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			if ((object)sessionModel != null)
			{
				goto IL_00b8;
			}
			goto IL_015d;
		}
	}

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0040: Expected O, but got I
		//IL_008a: Expected I, but got O
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)3512;
		object obj3 = typeof(List<Tween>) + 2920;
		object obj4 = (nint)0 + (nint)2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @399769C");
		object obj5 = this + 56;
		object obj6 = default(object);
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private void Start()
	{
		Init();
		RegisterEvents();
	}

	private void OnDestroy()
	{
		UnregisterEvents();
		eventChannel.Clear();
	}

	private void RegisterEvents()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002c: Expected O, but got I
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_004c: Expected O, but got I
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected O, but got Unknown
		//IL_01d1: Expected I, but got O
		//IL_007d: Expected I, but got O
		//IL_00a8: Expected I, but got O
		//IL_00d2: Expected O, but got I4
		//IL_00fb: Expected O, but got I
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected O, but got Unknown
		//IL_011b: Expected O, but got I
		//IL_014e: Expected O, but got I4
		//IL_0192: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3344;
		object obj2 = (nint)0 + (nint)3528;
		object obj3 = (nint)0 + (nint)3536;
		object obj4 = typeof(List<Tween>) + 3424;
		object obj5 = (nint)0 + (nint)3504;
		object obj6 = typeof(RegisteredWaitHandle) + 1552;
		object obj7 = typeof(Queue<string>) + 840;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		SFS.OnJoinRoom += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj3);
		SFS.OnRoomRemoved += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Predicate<object> predicate = default(Predicate<object>);
		predicate..ctor((object)this, (IntPtr)obj5);
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v10+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj10 = (nint)0 + (nint)2184;
		object obj11 = typeof(SqlSingle[]) + 2376;
		object obj12 = (nint)0 + (nint)3568;
		RoutingManager.OnValidateRouting += predicate;
		object obj13 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v13+E4]");
		bool flag2 = (nint)0 == 0;
		object obj14 = !flag2;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj12);
		ScreenManager screenManager = default(ScreenManager);
		screenManager.OnDisableSceneRequested += action3;
	}

	private void UnregisterEvents()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002c: Expected O, but got I
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_004c: Expected O, but got I
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0111: Expected I, but got O
		//IL_007d: Expected I, but got O
		//IL_00a8: Expected I, but got O
		//IL_00d2: Expected O, but got I4
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3344;
		object obj2 = (nint)0 + (nint)3528;
		object obj3 = (nint)0 + (nint)3536;
		object obj4 = typeof(List<Tween>) + 3424;
		object obj5 = (nint)0 + (nint)3504;
		object obj6 = typeof(RegisteredWaitHandle) + 1552;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		SFS.OnJoinRoom -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj3);
		SFS.OnRoomRemoved -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Predicate<object> predicate = default(Predicate<object>);
		predicate..ctor((object)this, (IntPtr)obj5);
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v10+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RoutingManager.OnValidateRouting -= predicate;
	}

	private void ListenToRoomVariables()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_01fb: Expected O, but got I
		//IL_022f: Expected O, but got I4
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0057: Expected O, but got I
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_0090: Expected I, but got O
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_00fc: Expected I, but got O
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected O, but got Unknown
		//IL_0168: Expected I, but got O
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Expected O, but got Unknown
		//IL_01d4: Expected I, but got O
		object obj = typeof(Queue<string>) + 848;
		object obj2 = (nint)0 + (nint)2200;
		GameObject go = base.gameObject;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj5 = typeof(SqlSingle[]) + 2376;
		object obj6 = (nint)0 + (nint)3552;
		object varName = "alignContent" + 2944;
		SessionModel sessionModel = default(SessionModel);
		Room currentRoom = sessionModel.CurrentRoom;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj6);
		VariableBinderExtensions.Bind(go, currentRoom, (string)varName, action);
		GameObject go2 = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object varName2 = "alignContent" + 2336;
		SessionModel sessionModel2 = default(SessionModel);
		Room currentRoom2 = sessionModel2.CurrentRoom;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj6);
		VariableBinderExtensions.Bind(go2, currentRoom2, (string)varName2, action2);
		GameObject go3 = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object varName3 = "startPosition" + 104;
		SessionModel sessionModel3 = default(SessionModel);
		Room currentRoom3 = sessionModel3.CurrentRoom;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj6);
		VariableBinderExtensions.Bind(go3, currentRoom3, (string)varName3, action3);
		GameObject go4 = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object varName4 = "___# Content push apply failed [{0}]: {1}" + 3960;
		SessionModel sessionModel4 = default(SessionModel);
		Room currentRoom4 = sessionModel4.CurrentRoom;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action4 = default(Action);
		action4..ctor(this, (IntPtr)obj6);
		VariableBinderExtensions.Bind(go4, currentRoom4, (string)varName4, action4);
	}

	public void Init()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0080: Expected O, but got I4
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_0161: Expected O, but got I
		//IL_010a: Expected O, but got I
		//IL_012c: Expected O, but got I4
		//IL_0192: Expected O, but got I
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected O, but got Unknown
		//IL_0207: Expected O, but got I4
		//IL_0426: Expected O, but got I
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected O, but got Unknown
		//IL_024a: Expected O, but got I
		//IL_0287: Expected O, but got I4
		//IL_0395: Unknown result type (might be due to invalid IL or missing references)
		//IL_039a: Expected O, but got Unknown
		//IL_03b0: Expected O, but got I
		//IL_03be: Expected I, but got O
		//IL_03d9: Expected O, but got I
		//IL_03e7: Expected I, but got O
		//IL_02c6: Expected O, but got I4
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Expected O, but got Unknown
		//IL_0309: Expected O, but got I
		//IL_031a: Expected I, but got O
		//IL_032b: Expected O, but got I
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3136;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(Queue<string>) + 848;
		object obj4 = (nint)0 + (nint)2200;
		object obj5 = obj2 + 16;
		obj5 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v9+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj8 = typeof(RegisteredWaitHandle) + 1552;
		SessionModel sessionModel = default(SessionModel);
		Room currentRoom = sessionModel.CurrentRoom;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X0_v14+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X0_v14+B8]");
			object obj10 = 0;
			object obj11 = obj10;
			bool flag2 = obj10 == null;
			object obj12 = !flag2;
			if (obj12 != null)
			{
				goto IL_0186;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj13 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X0_v50+B8]");
			object obj14 = 0;
			object obj11 = obj14;
			if (obj14 != null)
			{
				goto IL_0186;
			}
		}
		goto IL_0336;
		IL_0186:
		object obj15 = (nint)0 + (nint)4056;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X8_v7+10]");
		System.Int32Enum? int32Enum = (System.Int32Enum)0;
		object obj16 = (??)int32Enum & -8589934591L;
		if ((long)obj16 == 55834574848001L)
		{
			object obj17 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v24+E4]");
			bool flag3 = (nint)0 == 0;
			object obj18 = !flag3;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj17 = obj8;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v24+B8]");
			object obj19 = 0;
			object obj20 = obj19;
			object obj21 = obj2 + 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X8_v12+18]");
			obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			long num = ExtractMassId((string)obj21);
			bool flag4 = SFSKammelnaRoomExtensions.IsMassTournament(currentRoom);
			bool flag5 = !flag4;
			object obj22 = 0;
			if (!flag5)
			{
				MassTournamentInfo massTournamentInfo = SFSKammelnaRoomExtensions.GetMassTournamentInfo(currentRoom);
				bool flag6 = massTournamentInfo.<Id>k__BackingField != num;
				obj22 = 0;
				if (!flag6)
				{
					SetReady();
					object obj23 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2640;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj24 = (nint)0 + (nint)984;
					Action<object> action = default(Action<object>);
					action..ctor(obj2, (IntPtr)obj24);
					object obj25 = (nint)0 + (nint)2368;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39978C8");
					return;
				}
			}
			object obj26 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj27 = (nint)0 + (nint)3560;
			Action action2 = default(Action);
			action2..ctor(this, (IntPtr)obj27);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj28 = (nint)0 + (nint)1192;
			Action action3 = default(Action);
			action3..ctor(null, (IntPtr)obj28);
			MassTournamentManager.JoinRoom(num, action2, action3);
			return;
		}
		goto IL_0336;
		IL_0336:
		if (currentRoom != null && SFSKammelnaRoomExtensions.IsMassTournament(currentRoom))
		{
			SetReady();
		}
		else
		{
			TournamentPopupUtil.ShowTournamentHubError();
		}
	}

	private static long ExtractMassId(string payload)
	{
		//IL_0023: Expected O, but got I4
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected O, but got Unknown
		//IL_0129: Expected O, but got I
		//IL_014f: Expected I8, but got O
		//IL_0072: Expected I4, but got I8
		//IL_008c: Expected O, but got I4
		bool flag = string.IsNullOrEmpty(payload);
		bool flag2 = !flag;
		object obj = !flag2;
		if (obj == null)
		{
			if (payload != null)
			{
				int num = payload.IndexOf('|');
				int num2 = (int)(num & 0x80000000L);
				bool flag3 = num2 == 0;
				object obj2 = !flag3;
				string s = payload;
				if (obj2 == null)
				{
					string text = payload.Substring(0, num);
					s = text;
				}
				return long.Parse(s);
			}
		}
		else
		{
			object obj3 = typeof(System.IOAsyncCallback) + 3768;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj4 = "LAK" + 3920;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			InvalidOperationException ex = default(InvalidOperationException);
			string message = default(string);
			ex..ctor(message);
			object obj5 = (nint)0 + (nint)3496;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			OutOfMemoryException ex2 = new OutOfMemoryException();
		}
		NullReferenceException ex3 = new NullReferenceException();
		return (long)ex3;
	}

	private void HandleRegistrationCode(string payload)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00f1: Expected O, but got I4
		//IL_008c: Expected O, but got I
		//IL_00ae: Expected O, but got I4
		//IL_0129: Expected O, but got I
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected O, but got Unknown
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Expected O, but got Unknown
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected O, but got Unknown
		//IL_0288: Expected O, but got I
		//IL_0299: Expected I, but got O
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Expected O, but got Unknown
		//IL_02d7: Expected O, but got I4
		//IL_0300: Expected O, but got I
		object obj = typeof(RegisteredWaitHandle) + 1552;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6091]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v42+E4]");
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
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v42+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			object obj4 = obj3;
			if (obj5 != null)
			{
				goto IL_007c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v22+B8]");
		object obj7 = 0;
		object obj8 = obj7;
		if (obj7 != null)
		{
			goto IL_014e;
		}
		return;
		IL_014e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v3+10]");
		if ((nint)0 != 13001)
		{
			return;
		}
		if (payload != null)
		{
			string[] array = payload.Split('|');
			if (array != null)
			{
				if (array.Length < 2)
				{
					return;
				}
				object obj9 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3144;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj10 = default(object);
				obj10..ctor();
				if (obj10 != null)
				{
					object obj11 = obj10 + 16;
					obj11 = array[1];
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object obj12 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2656;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj13 = (nint)0 + (nint)992;
					Action<object> action = default(Action<object>);
					action..ctor(obj10, (IntPtr)obj13);
					object obj14 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
					object obj15 = obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X0_v16+E4]");
					bool flag3 = (nint)0 == 0;
					object obj16 = !flag3;
					if (obj16 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj17 = (nint)0 + (nint)2136;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80CF4");
					return;
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
		IL_007c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v42+B8]");
		object obj18 = 0;
		obj8 = obj18;
		bool flag4 = obj18 == null;
		object obj19 = !flag4;
		if (obj19 == null)
		{
			return;
		}
		goto IL_014e;
	}

	public List<TournamentRoomModel> GetActiveTournaments()
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Expected O, but got Unknown
		//IL_02a6: Expected O, but got I
		//IL_02c0: Expected O, but got I4
		//IL_0097: Expected O, but got I
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0066: Expected O, but got I
		//IL_02e8: Expected O, but got I
		//IL_0322: Expected O, but got I4
		//IL_0383: Expected O, but got I4
		//IL_0140: Expected O, but got I4
		//IL_05ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b2: Expected O, but got Unknown
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Expected O, but got Unknown
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Expected O, but got Unknown
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d8: Expected O, but got Unknown
		//IL_03e8: Expected O, but got I
		//IL_0411: Expected O, but got I
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected O, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected O, but got Unknown
		//IL_0181: Expected I, but got O
		//IL_0191: Expected O, but got I
		//IL_0227: Expected O, but got I
		//IL_024b: Expected O, but got I4
		//IL_0436: Unknown result type (might be due to invalid IL or missing references)
		//IL_043b: Expected O, but got Unknown
		//IL_0453: Expected O, but got I
		//IL_01cc: Expected O, but got I
		//IL_04e9: Expected O, but got I
		//IL_050b: Expected O, but got I4
		//IL_0269: Expected O, but got I
		//IL_048e: Expected O, but got I
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected O, but got Unknown
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected O, but got Unknown
		//IL_0534: Unknown result type (might be due to invalid IL or missing references)
		//IL_0539: Expected O, but got Unknown
		//IL_054f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0554: Expected O, but got Unknown
		//IL_0564: Expected O, but got I
		//IL_0588: Expected O, but got I4
		//IL_049c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a1: Expected O, but got Unknown
		//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_04af: Expected O, but got Unknown
		object obj = 152985600;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E60F5]");
		object obj2 = (nint)0 & (nint)1;
		object obj3;
		object obj5;
		if (obj2 != null)
		{
			obj3 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E60F3]");
			object obj4 = (nint)0 & (nint)1;
			bool flag = obj4 == null;
			obj5 = obj3;
			if (!flag)
			{
				goto IL_008b;
			}
		}
		else
		{
			_ = 1;
			obj3 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E60F3]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			obj5 = obj3;
			if (obj7 != null)
			{
				goto IL_008b;
			}
		}
		_ = 1;
		object obj8 = (nint)0 + (nint)2200;
		object obj9 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v16+E4]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v16+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		obj3 = obj5;
		object obj11 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v16+E4]");
		nint num2 = 0;
		if (obj10 != null)
		{
			goto IL_00f4;
		}
		goto IL_0350;
		IL_020d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X0_v45+8]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v296 @ X0_v45] (should have been resolved before IL gen)");
		object obj13 = default(object);
		bool flag4 = obj13 == null;
		object obj14 = !flag4;
		if (obj14 != null)
		{
			goto IL_0427;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X0_v45+8]");
		object obj15 = 0;
		object obj16 = obj3;
		goto IL_059e;
		IL_0519:
		ISFSArray iSFSArray = default(ISFSArray);
		return TournamentRoomModel.FromArray(iSFSArray);
		IL_03af:
		object obj18 = default(object);
		object obj17 = obj18 + 31;
		object obj19 = num + obj17;
		object obj20 = obj19 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v15+8]");
		obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v164 @ X8_v15] (should have been resolved before IL gen)");
		bool flag5 = obj13 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v15+8]");
		obj15 = 0;
		obj16 = obj3;
		if (!flag5)
		{
			goto IL_0427;
		}
		goto IL_059e;
		IL_008b:
		obj8 = (nint)0 + (nint)2200;
		obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v16+E4]");
		num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v16+E4]");
		bool flag6 = (nint)0 == 0;
		obj11 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v16+E4]");
		num2 = 0;
		obj5 = obj3;
		if (!flag6)
		{
			goto IL_00f4;
		}
		goto IL_0350;
		IL_0350:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool flag7 = (object)sessionModel == null;
		object obj21 = !flag7;
		num = num2;
		obj3 = obj5;
		if (obj21 != null)
		{
			goto IL_011b;
		}
		goto IL_03a1;
		IL_00f4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		if ((object)sessionModel != null)
		{
			goto IL_011b;
		}
		goto IL_03a1;
		IL_03a1:
		NullReferenceException ex = new NullReferenceException();
		goto IL_03af;
		IL_011b:
		Room currentRoom = sessionModel.CurrentRoom;
		bool flag8 = currentRoom == null;
		obj16 = 0;
		if (!flag8)
		{
			object obj22 = typeof(RegisteredWaitHandle) + 1376;
			object obj23 = "alignContent" + 2640;
			obj3 = obj23;
			num = (nint)currentRoom;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v13 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v13 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_020d;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v13 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
			obj18 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X10_v9-8]");
				bool flag9 = 0 == (nint)obj22;
				ex = (NullReferenceException)currentRoom;
				if (flag9)
				{
					break;
				}
				obj18 += 16;
				obj24--;
				if ((nint)obj24 != 1)
				{
					continue;
				}
				goto IL_020d;
			}
			goto IL_03af;
		}
		goto IL_059e;
		IL_0427:
		object obj25 = typeof(UsageHint) + 664;
		object obj26 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X8_v8+12E]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X8_v8+12E]");
		if ((nint)0 == 0)
		{
			goto IL_04cf;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X8_v8+B0]");
		object obj28 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X10_v7-8]");
			if (0 == (nint)obj25)
			{
				break;
			}
			obj28 += 16;
			obj27--;
			if ((nint)obj27 != 1)
			{
				continue;
			}
			goto IL_04cf;
		}
		object obj29 = obj28 + 8;
		object obj30 = obj26 + obj29;
		object obj31 = obj30 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X8_v12+8]");
		obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v247 @ X8_v12] (should have been resolved before IL gen)");
		bool flag10 = iSFSArray == null;
		object obj32 = !flag10;
		obj15 = obj12;
		if (obj32 != null)
		{
			goto IL_0519;
		}
		goto IL_059e;
		IL_059e:
		object obj33 = typeof(List<AdaptivePerformanceScaler>) + 4016;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		return (List<TournamentRoomModel>)(object)list;
		IL_04cf:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X0_v8+8]");
		obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v313 @ X0_v8] (should have been resolved before IL gen)");
		bool flag11 = iSFSArray == null;
		obj15 = 8;
		if (!flag11)
		{
			goto IL_0519;
		}
		goto IL_059e;
	}

	public unsafe int GetActiveRoomsCount()
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Expected O, but got Unknown
		//IL_0295: Expected O, but got I
		//IL_02af: Expected O, but got I4
		//IL_0097: Expected O, but got I
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0066: Expected O, but got I
		//IL_02d7: Expected O, but got I
		//IL_0311: Expected O, but got I4
		//IL_0372: Expected O, but got I4
		//IL_013f: Expected I4, but got O
		//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ac: Expected O, but got Unknown
		//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b9: Expected O, but got Unknown
		//IL_03c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c7: Expected O, but got Unknown
		//IL_03d7: Expected O, but got I
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected O, but got Unknown
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_0180: Expected I, but got O
		//IL_0190: Expected O, but got I
		//IL_0226: Expected O, but got I
		//IL_024a: Expected O, but got I4
		//IL_0415: Unknown result type (might be due to invalid IL or missing references)
		//IL_041a: Expected O, but got Unknown
		//IL_0437: Expected O, but got I
		//IL_01cb: Expected O, but got I
		//IL_04c6: Expected O, but got I4
		//IL_0472: Expected O, but got I
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected O, but got Unknown
		//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e1: Expected O, but got Unknown
		//IL_04e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ee: Expected O, but got Unknown
		//IL_04f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fc: Expected O, but got Unknown
		//IL_0480: Unknown result type (might be due to invalid IL or missing references)
		//IL_0485: Expected O, but got Unknown
		//IL_048e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0493: Expected O, but got Unknown
		object obj = 152985600;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E60F6]");
		object obj2 = (nint)0 & (nint)1;
		object obj5;
		object obj3;
		if (obj2 != null)
		{
			obj3 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E60F3]");
			object obj4 = (nint)0 & (nint)1;
			bool flag = obj4 == null;
			obj5 = obj3;
			if (!flag)
			{
				goto IL_008b;
			}
		}
		else
		{
			_ = 1;
			obj3 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E60F3]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			obj5 = obj3;
			if (obj7 != null)
			{
				goto IL_008b;
			}
		}
		_ = 1;
		object obj8 = (nint)0 + (nint)2200;
		object obj9 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v12+E4]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v12+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		obj3 = obj5;
		object obj11 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v12+E4]");
		nint num2 = 0;
		if (obj10 != null)
		{
			goto IL_00f4;
		}
		goto IL_033f;
		IL_020c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X0_v42+8]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v260 @ X0_v42] (should have been resolved before IL gen)");
		int num3 = default(int);
		bool flag4 = num3 == 0;
		object obj13 = !flag4;
		int num4 = num3;
		if (obj13 == null)
		{
			goto IL_0260;
		}
		goto IL_0406;
		IL_0551:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v378 @ X8_v6] (should have been resolved before IL gen)");
		int value = default(int);
		int? num5 = value;
		int result = default(int);
		return result;
		IL_039e:
		object obj15 = default(object);
		object obj14 = obj15 + 31;
		object obj16 = num + obj14;
		object obj17 = obj16 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v14+8]");
		obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v164 @ X8_v14] (should have been resolved before IL gen)");
		bool flag5 = num3 == 0;
		num4 = num3;
		if (flag5)
		{
			goto IL_0260;
		}
		goto IL_0406;
		IL_008b:
		obj8 = (nint)0 + (nint)2200;
		obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v12+E4]");
		num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v12+E4]");
		bool flag6 = (nint)0 == 0;
		obj11 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v12+E4]");
		num2 = 0;
		obj5 = obj3;
		if (!flag6)
		{
			goto IL_00f4;
		}
		goto IL_033f;
		IL_033f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool flag7 = (object)sessionModel == null;
		object obj18 = !flag7;
		num = num2;
		obj3 = obj5;
		if (obj18 != null)
		{
			goto IL_011b;
		}
		goto IL_0390;
		IL_00f4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		if ((object)sessionModel != null)
		{
			goto IL_011b;
		}
		goto IL_0390;
		IL_0390:
		NullReferenceException ex = new NullReferenceException();
		goto IL_039e;
		IL_011b:
		Room currentRoom = sessionModel.CurrentRoom;
		bool flag8 = currentRoom == null;
		num3 = (int)currentRoom;
		if (flag8)
		{
			goto IL_0260;
		}
		object obj19 = typeof(RegisteredWaitHandle) + 1376;
		object obj20 = "alignContent" + 2504;
		obj3 = obj20;
		num = (nint)currentRoom;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v12 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v12 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_020c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v12 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		obj15 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X10_v8-8]");
			bool flag9 = 0 == (nint)obj19;
			ex = (NullReferenceException)currentRoom;
			if (flag9)
			{
				break;
			}
			obj15 += 16;
			obj21--;
			if ((nint)obj21 != 1)
			{
				continue;
			}
			goto IL_020c;
		}
		goto IL_039e;
		IL_0406:
		object obj22 = typeof(UsageHint) + 664;
		int value2 = ((int*)num4)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v5 (System.Int32)+12E]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v5 (System.Int32)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_04b3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v5 (System.Int32)+B0]");
		object obj24 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X10_v6-8]");
			if (0 == (nint)obj22)
			{
				break;
			}
			obj24 += 16;
			obj23--;
			if ((nint)obj23 != 1)
			{
				continue;
			}
			goto IL_04b3;
		}
		object obj25 = obj24 + 4;
		object obj26 = value2 + obj25;
		object obj27 = obj26 + 312;
		goto IL_0551;
		IL_04b3:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj12 = 4;
		object obj28 = default(object);
		obj27 = obj28;
		goto IL_0551;
		IL_0260:
		return num3;
	}

	public void RequestRoomsList(Action<List<TournamentRoomModel>> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_00ca: Expected O, but got I
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		//IL_00e6: Expected I, but got O
		//IL_00f6: Expected O, but got I
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected O, but got Unknown
		//IL_028b: Expected I, but got O
		//IL_0131: Expected O, but got I
		//IL_01d9: Expected O, but got I4
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected O, but got Unknown
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected O, but got Unknown
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Expected O, but got Unknown
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected O, but got Unknown
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3152;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(RegisteredWaitHandle) + 2040;
		object obj4 = obj2 + 16;
		obj4 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj2 + 24;
		obj5 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		object obj6 = typeof(System.IOAsyncCallback) + 976;
		object obj7 = "java.io.FileOutputStream" + 3592;
		object obj8 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2360;
		object obj9 = (nint)0 + (nint)1000;
		object obj10 = typeof(System.Formats.Asn1.SetOfValueComparer) + 72;
		nint num = (nint)sFSObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0172;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
		object obj12 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X10_v5-8]");
			if (0 == (nint)obj6)
			{
				break;
			}
			obj12 += 16;
			obj11--;
			if ((nint)obj11 != 1)
			{
				continue;
			}
			goto IL_0172;
		}
		object obj13 = obj12 + 36;
		object obj14 = num + obj13;
		object obj15 = obj14 + 312;
		goto IL_024d;
		IL_0172:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_024d;
		IL_024d:
		object command = "m_StencilDeferredPS" + 2512;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v252 @ X0_v14] (should have been resolved before IL gen)");
		GameObject go = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj9);
		object obj16 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X0_v21+E4]");
		bool flag = (nint)0 == 0;
		object obj17 = !flag;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		SfsRequestListener.SendRoomRequest(go, (string)command, sFSObject, keepListening: false, action);
	}

	private void SetReady()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		MassTournamentInfo tournamentLiveData = GetTournamentLiveData();
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2616;
		object obj2 = (nint)0 + (nint)3488;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		MassTournamentManager.GetMassEvent(tournamentLiveData.<Id>k__BackingField, action);
	}

	private void OnRoomChanged(Room room)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_0303: Expected O, but got I
		//IL_030f: Expected O, but got I
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Expected O, but got Unknown
		//IL_0341: Expected O, but got I4
		//IL_006c: Expected O, but got I
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected O, but got Unknown
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Expected O, but got Unknown
		//IL_0275: Expected O, but got I4
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 1376;
		nint num = (nint)room;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00ad;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj3 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X10_v6-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj3 += 16;
			obj2--;
			if ((nint)obj2 != 1)
			{
				continue;
			}
			goto IL_00ad;
		}
		object obj4 = obj3 + 6;
		object obj5 = num + obj4;
		object obj6 = obj5 + 312;
		goto IL_02f7;
		IL_00ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_02f7;
		IL_02f7:
		object obj7 = (nint)0 + (nint)2432;
		object obj8 = (nint)0 + (nint)2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v258 @ X0_v4] (should have been resolved before IL gen)");
		object obj10 = default(object);
		object obj9 = obj10 & 1;
		bool flag = obj9 == null;
		object obj11 = !flag;
		if (obj11 != null || SFSKammelnaRoomExtensions.IsTournamentHub(room))
		{
			MassTournamentEventChannel massTournamentEventChannel = eventChannel;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3997898");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3997898");
			GameObject go = base.gameObject;
			VariableBinderExtensions.Unbind(go);
			return;
		}
		if (SFSKammelnaRoomExtensions.IsMassTournament(room))
		{
			recoveringConnection = false;
			SetReady();
			object obj12 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			object obj13 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X0_v35+E4]");
			if ((nint)0 != 0)
			{
				PopupWindow.DismissMessage();
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			PopupWindow.DismissMessage();
			return;
		}
		if (recoveringConnection)
		{
			TournamentPopupUtil.ShowTournamentHubError();
			return;
		}
		MassTournamentEventChannel massTournamentEventChannel2 = eventChannel;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3997898");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3997898");
		GameObject go2 = base.gameObject;
		VariableBinderExtensions.Unbind(go2);
		object obj14 = typeof(UsageHint) + 72;
		object obj15 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X0_v20+E4]");
		bool flag2 = (nint)0 == 0;
		object obj16 = !flag2;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int lastJoinedMassTournamentRoomId = UserInfo.LastJoinedMassTournamentRoomId;
		object obj17 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3808;
		ShowLoading();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		MassTournamentInfo massTournamentInfo = default(MassTournamentInfo);
		massTournamentInfo..ctor(lastJoinedMassTournamentRoomId);
		SFS.JoinMassTournamentRoom(massTournamentInfo);
	}

	private void OnRoomRemoved(Room room)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00dd: Expected O, but got I
		//IL_0107: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected O, but got Unknown
		//IL_01a7: Expected O, but got I4
		//IL_0150: Expected O, but got I4
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Expected O, but got Unknown
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E60F8]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v17+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v17+E4]");
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
		if (currentRoom == null)
		{
			object obj9 = typeof(UsageHint) + 72;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v2+E4]");
			bool flag4 = (nint)0 == 0;
			object obj11 = !flag4;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int lastJoinedMassTournamentRoomId = UserInfo.LastJoinedMassTournamentRoomId;
			object obj12 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3808;
			ShowLoading();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			MassTournamentInfo massTournamentInfo = default(MassTournamentInfo);
			massTournamentInfo..ctor(lastJoinedMassTournamentRoomId);
			SFS.JoinMassTournamentRoom(massTournamentInfo);
		}
	}

	private void JoinTournamentRoom(int roomId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3808;
		ShowLoading();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		MassTournamentInfo massTournamentInfo = default(MassTournamentInfo);
		massTournamentInfo..ctor(roomId);
		SFS.JoinMassTournamentRoom(massTournamentInfo);
	}

	private void ShowLoading()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		//IL_016d: Expected O, but got I4
		//IL_0060: Expected O, but got I4
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected O, but got Unknown
		//IL_019b: Expected O, but got I
		//IL_01ab: Expected O, but got I
		//IL_01bb: Expected O, but got I
		//IL_01dd: Expected O, but got I4
		//IL_00f4: Expected I, but got O
		//IL_00a7: Expected O, but got I4
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Expected O, but got Unknown
		//IL_0227: Expected O, but got I
		//IL_022f: Expected I, but got O
		//IL_0240: Expected I, but got O
		//IL_025e: Expected O, but got I
		//IL_0278: Expected I4, but got O
		//IL_00d7: Expected O, but got I
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object msgBody = "LAK" + 2136;
		object obj2 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3128;
		recoveringConnection = true;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.ShowLoading((string)msgBody, dismissible: false);
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj2;
		}
		object obj7 = typeof(SqlSingle[]) + 2376;
		object obj8 = (nint)0 + (nint)1192;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v6+B8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v8+8]");
		Func<bool> cancelCondition = (Func<bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v8+8]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		nint num = 0;
		bool flag4 = false;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v6+E4]");
			bool flag5 = (nint)0 == 0;
			object obj11 = !flag5;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj12 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v14+B8]");
				obj9 = 0;
			}
			object obj13 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 2128;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj14 = (nint)0 + (nint)976;
			num = (nint)obj14;
			Func<bool> func = default(Func<bool>);
			func..ctor(obj9, (IntPtr)obj14);
			object obj15 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v13+B8]");
			object obj16 = (nint)0 + (nint)8;
			obj16 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			flag4 = (byte)(int)func != 0;
			cancelCondition = func;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(null, (IntPtr)obj8);
		Coroutine coroutine = UIExtensions.SetTimeout(this, 5f, cancelCondition, action);
	}

	public MassEventModel GetMassTournamentInfo()
	{
		MassTournamentInfo tournamentLiveData = GetTournamentLiveData();
		if (tournamentLiveData != null)
		{
			return MassTournamentManager.GetCachedMassEvent(tournamentLiveData.<Id>k__BackingField);
		}
		return (MassEventModel)(object)new NullReferenceException();
	}

	public int GetActiveStageId()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00ee: Expected O, but got I
		//IL_0118: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_017d: Expected I4, but got O
		//IL_0161: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E60F3]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
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
		if (obj8 != null)
		{
			goto IL_00b8;
		}
		goto IL_016f;
		IL_00b8:
		Room currentRoom = sessionModel.CurrentRoom;
		return SFSKammelnaRoomExtensions.GetMassActiveStage(currentRoom);
		IL_016f:
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		if ((object)sessionModel != null)
		{
			goto IL_00b8;
		}
		goto IL_016f;
	}

	public int GetMassTournamentPointsToPass()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00ee: Expected O, but got I
		//IL_0118: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_017d: Expected I4, but got O
		//IL_0161: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E60F3]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
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
		if (obj8 != null)
		{
			goto IL_00b8;
		}
		goto IL_016f;
		IL_00b8:
		Room currentRoom = sessionModel.CurrentRoom;
		return SFSKammelnaRoomExtensions.GetMassActiveStagePointsToPass(currentRoom);
		IL_016f:
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		if ((object)sessionModel != null)
		{
			goto IL_00b8;
		}
		goto IL_016f;
	}

	public int? GetActivePlayWindowId()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00ee: Expected O, but got I
		//IL_0118: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_0161: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E60F3]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
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
		if (obj8 != null)
		{
			goto IL_00b8;
		}
		goto IL_016f;
		IL_00b8:
		Room currentRoom = sessionModel.CurrentRoom;
		return SFSKammelnaRoomExtensions.GetMassActivePlayWindow(currentRoom);
		IL_016f:
		return (int?)new NullReferenceException();
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		if ((object)sessionModel != null)
		{
			goto IL_00b8;
		}
		goto IL_016f;
	}

	public bool IsWaitingToStart()
	{
		//IL_00c4: Expected I4, but got O
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_0070: Expected O, but got I4
		if (GetActiveStageId() != 0)
		{
			return false;
		}
		MassEventStageViewModel activeStage = GetActiveStage();
		if (activeStage != null)
		{
			object obj = typeof(DataRelation) + 712;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime now = DateTime.Now;
			return activeStage.<StartingDate>k__BackingField > now;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public MassTournamentInfo GetTournamentLiveData()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00ee: Expected O, but got I
		//IL_0118: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_0161: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E60F3]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
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
		if (obj8 != null)
		{
			goto IL_00b8;
		}
		goto IL_016f;
		IL_00b8:
		Room currentRoom = sessionModel.CurrentRoom;
		return SFSKammelnaRoomExtensions.GetMassTournamentInfo(currentRoom);
		IL_016f:
		return (MassTournamentInfo)(object)new NullReferenceException();
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		if ((object)sessionModel != null)
		{
			goto IL_00b8;
		}
		goto IL_016f;
	}

	public void ReloadPlayerState()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_007d: Expected I, but got O
		//IL_0056: Expected O, but got I
		//IL_0093: Expected O, but got I
		OneShotEvent<MassTournamentPlayerState> playerStateCache = PlayerStateCache;
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2640;
		object obj2 = (nint)0 + (nint)3520;
		if (playerStateCache.<IsReady>k__BackingField)
		{
			object obj3 = (nint)0 + (nint)2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3997898");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj4 = (nint)0 + (nint)2368;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39978C8");
	}

	private void OnPlayerStateLoaded(MassTournamentPlayerState player)
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_008b: Expected O, but got I4
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		//IL_010a: Expected O, but got I4
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected O, but got Unknown
		//IL_0163: Expected O, but got I
		//IL_0171: Expected I, but got O
		StopAllCoroutines();
		eventChannel.TriggerPlayerStateChanged(player);
		MassEventStageViewModel activeStage = GetActiveStage();
		if (player.ShouldRefreshTickets(activeStage))
		{
			object obj = typeof(DataRelation) + 712;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime now = DateTime.Now;
			TimeSpan timeSpan = player.<NextTicketTime>k__BackingField - now;
			object obj4 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v17+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			TimeSpan timeSpan2 = default(TimeSpan);
			double totalSeconds = timeSpan2.TotalSeconds;
			object obj7 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj8 = (nint)0 + (nint)3552;
			Action action = default(Action);
			action..ctor(this, (IntPtr)obj8);
			Coroutine coroutine = UIExtensions.WaitForSeconds(this, (float)totalSeconds, action);
		}
	}

	public void GetPlayerTournamentState(Action<MassTournamentPlayerState> callback)
	{
		//IL_0011: Expected O, but got I
		object obj = (nint)0 + (nint)2368;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39978C8");
	}

	private void LoadPlayerState()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_00c9: Expected I, but got O
		//IL_0063: Expected O, but got I4
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2360;
		object obj2 = (nint)0 + (nint)3472;
		object obj3 = typeof(System.Formats.Asn1.SetOfValueComparer) + 72;
		object command = "m_StencilDeferredPS" + 2472;
		GameObject go = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		SfsRequestListener.SendRoomRequest(go, (string)command, null, keepListening: false, action);
	}

	public MassEventStageViewModel GetActiveStage()
	{
		MassTournamentInfo tournamentLiveData = GetTournamentLiveData();
		if (tournamentLiveData != null)
		{
			MassEventModel cachedMassEvent = MassTournamentManager.GetCachedMassEvent(tournamentLiveData.<Id>k__BackingField);
			if (cachedMassEvent != null)
			{
				int activeStageId = ((MassTournamentServerConnector)(object)cachedMassEvent).GetActiveStageId();
				if (cachedMassEvent.<Stages>k__BackingField != null)
				{
					return (MassEventStageViewModel)((List<object>)(object)cachedMassEvent.<Stages>k__BackingField).get_Item(activeStageId);
				}
			}
		}
		return (MassEventStageViewModel)(object)new NullReferenceException();
	}

	public MassEventStageViewModel GetUpcomingStage()
	{
		//IL_007e: Expected O, but got I4
		//IL_00ab: Expected O, but got I4
		MassTournamentInfo tournamentLiveData = GetTournamentLiveData();
		if (tournamentLiveData != null)
		{
			MassEventModel cachedMassEvent = MassTournamentManager.GetCachedMassEvent(tournamentLiveData.<Id>k__BackingField);
			if (cachedMassEvent != null)
			{
				List<MassEventStageViewModel> <Stages>k__BackingField = cachedMassEvent.<Stages>k__BackingField;
				int activeStageId = ((MassTournamentServerConnector)(object)cachedMassEvent).GetActiveStageId();
				if (cachedMassEvent.<Stages>k__BackingField != null)
				{
					object obj = activeStageId + 1;
					if ((nint)obj < <Stages>k__BackingField._size)
					{
						int activeStageId2 = ((MassTournamentServerConnector)activeStageId).GetActiveStageId();
						int index = activeStageId2 + 1;
						return (MassEventStageViewModel)((List<object>)(object)cachedMassEvent.<Stages>k__BackingField).get_Item(index);
					}
					return null;
				}
			}
		}
		return (MassEventStageViewModel)(object)new NullReferenceException();
	}

	public bool IsFinalStage()
	{
		MassEventStageViewModel upcomingStage = GetUpcomingStage();
		return upcomingStage == null;
	}

	public MassEventPlayWindowViewModel GetActivePlayWindow()
	{
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		MassEventStageViewModel activeStage = GetActiveStage();
		int? activePlayWindowId = ((MassTournamentServerConnector)(object)activeStage).GetActivePlayWindowId();
		object obj = (??)activePlayWindowId & 1;
		if (obj != null)
		{
			if (activeStage != null)
			{
				int? num = default(int?);
				int value = num.Value;
				if (activeStage.<PlayWindows>k__BackingField != null)
				{
					return (MassEventPlayWindowViewModel)((List<object>)(object)activeStage.<PlayWindows>k__BackingField).get_Item(value);
				}
			}
			return (MassEventPlayWindowViewModel)(object)new NullReferenceException();
		}
		return null;
	}

	public void RegisterInTournament(string code, Action<int> onSuccess, Action<string> onError)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0059: Expected O, but got I
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_00d5: Expected I, but got O
		//IL_00f5: Expected I, but got O
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3160;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2416;
		object obj4 = (nint)0 + (nint)1008;
		object obj5 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2424;
		object obj6 = (nint)0 + (nint)1016;
		object obj7 = obj2 + 16;
		obj7 = onSuccess;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = obj2 + 24;
		obj8 = onError;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		GameObject gameObject = base.gameObject;
		MassTournamentInfo tournamentLiveData = ((MassTournamentServerConnector)(object)gameObject).GetTournamentLiveData();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFS.TournamentParticipateError tournamentParticipateError = default(SFS.TournamentParticipateError);
		tournamentParticipateError..ctor(obj2, (IntPtr)obj4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFS.TournamentParticipateSuccess tournamentParticipateSuccess = default(SFS.TournamentParticipateSuccess);
		tournamentParticipateSuccess..ctor(obj2, (IntPtr)obj6);
		SFS.ParticipateMassTournament(gameObject, tournamentLiveData, code, tournamentParticipateError, tournamentParticipateSuccess);
	}

	public void PlayNow(GameObject lifecycle)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0087: Expected I, but got O
		//IL_00b1: Expected O, but got I4
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2360;
		object obj2 = (nint)0 + (nint)3480;
		object obj3 = typeof(System.Formats.Asn1.SetOfValueComparer) + 72;
		object command = "placementId" + 272;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		SfsRequestListener.SendRoomRequest(lifecycle, (string)command, null, keepListening: true, action);
	}

	public MassTournamentStageLeaderboardSource GetStageLeaderboardSource(int stageId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3832;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		MassTournamentStageLeaderboardSource massTournamentStageLeaderboardSource = default(MassTournamentStageLeaderboardSource);
		massTournamentStageLeaderboardSource..ctor(this, stageId);
		return massTournamentStageLeaderboardSource;
	}

	public void GetTopPlayers(int stageId, Action<LeaderboardModel> callback)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_002f: Expected O, but got I4
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1688;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3832;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		MassTournamentStageLeaderboardSource massTournamentStageLeaderboardSource = default(MassTournamentStageLeaderboardSource);
		massTournamentStageLeaderboardSource..ctor(this, stageId);
		GameObject lifecycle = base.gameObject;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		LeaderBoardManager.GetLeaderBoard(lifecycle, massTournamentStageLeaderboardSource, callback);
	}

	private bool IsRoutingNeeded(RoutingParams routingParams)
	{
		//IL_0269: Expected I4, but got O
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_0068: Expected O, but got I4
		//IL_0091: Expected O, but got I
		//IL_010c: Expected O, but got I4
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected O, but got Unknown
		//IL_01c6: Expected O, but got I4
		//IL_01fe: Expected O, but got I4
		//IL_0236: Expected O, but got I8
		if (routingParams != null)
		{
			if (routingParams.Command != RoutingCommand.MassTournament)
			{
				goto IL_0255;
			}
			object obj = typeof(Queue<string>) + 848;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v6+E4]");
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
				if (currentRoom == null)
				{
					goto IL_0255;
				}
				object obj5 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X0_v11+E4]");
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
					Room currentRoom2 = sessionModel2.CurrentRoom;
					if (!SFSKammelnaRoomExtensions.IsMassTournament(currentRoom2))
					{
						goto IL_0255;
					}
					object obj7 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3016;
					object obj8 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X0_v17+E4]");
					bool flag3 = (nint)0 == 0;
					object obj9 = !flag3;
					if (obj9 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					int num = Convert.ToInt32(routingParams.Payload);
					MassTournamentInfo tournamentLiveData = ((MassTournamentServerConnector)num).GetTournamentLiveData();
					if (tournamentLiveData != null)
					{
						object obj10 = tournamentLiveData.<Id>k__BackingField - num;
						bool flag4 = obj10 == null;
						return !flag4;
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0255:
		return true;
	}

	private void <SetReady>b__24_0(MassEventModel model)
	{
		//IL_0011: Expected O, but got I
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		MassTournamentEventChannel massTournamentEventChannel = eventChannel;
		object obj = (nint)0 + (nint)2440;
		object obj2 = typeof(RegisteredWaitHandle) + 3136;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3997724");
		ListenToRoomVariables();
		SFS.SendTournamentRoomLoaded();
		SplashAnimation.EndAnimation();
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v8+E4]");
		if ((nint)0 != 0)
		{
			ScreenManager.AnimateTransitionIn();
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		ScreenManager.AnimateTransitionIn();
	}

	private void <LoadPlayerState>b__38_0(ISFSObject data)
	{
		//IL_0011: Expected O, but got I
		MassTournamentPlayerState massTournamentPlayerState = MassTournamentPlayerState.FromSfsObject(data);
		object obj = (nint)0 + (nint)2384;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3997724");
	}

	private void <PlayNow>b__44_0(ISFSObject response)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0030: Expected I, but got O
		//IL_0040: Expected O, but got I
		//IL_00ea: Expected O, but got I4
		//IL_0159: Expected O, but got I
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected O, but got Unknown
		//IL_007b: Expected O, but got I
		//IL_05ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0604: Expected O, but got Unknown
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		//IL_06ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b0: Expected O, but got Unknown
		//IL_01dc: Expected O, but got I4
		//IL_01e1: Expected I, but got O
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_0913: Unknown result type (might be due to invalid IL or missing references)
		//IL_0918: Expected O, but got Unknown
		//IL_0641: Unknown result type (might be due to invalid IL or missing references)
		//IL_0646: Expected O, but got Unknown
		//IL_0670: Expected O, but got I4
		//IL_0c93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c98: Expected O, but got Unknown
		//IL_06ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f2: Expected O, but got Unknown
		//IL_071c: Expected O, but got I4
		//IL_0697: Unknown result type (might be due to invalid IL or missing references)
		//IL_069c: Expected O, but got Unknown
		//IL_0219: Expected O, but got I4
		//IL_021e: Expected I, but got O
		//IL_0d3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d44: Expected O, but got Unknown
		//IL_0955: Unknown result type (might be due to invalid IL or missing references)
		//IL_095a: Expected O, but got Unknown
		//IL_0984: Expected O, but got I4
		//IL_0743: Unknown result type (might be due to invalid IL or missing references)
		//IL_0748: Expected O, but got Unknown
		//IL_0cd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cda: Expected O, but got Unknown
		//IL_0d04: Expected O, but got I4
		//IL_09ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b0: Expected O, but got Unknown
		//IL_0d81: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d86: Expected O, but got Unknown
		//IL_0db0: Expected O, but got I4
		//IL_0d2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d30: Expected O, but got Unknown
		//IL_0dd7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ddc: Expected O, but got Unknown
		//IL_0757: Unknown result type (might be due to invalid IL or missing references)
		//IL_075c: Expected O, but got Unknown
		//IL_078a: Expected O, but got I4
		//IL_078f: Expected I, but got O
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected O, but got Unknown
		//IL_02a8: Expected O, but got I4
		//IL_07a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ac: Expected O, but got Unknown
		//IL_07dd: Expected O, but got I4
		//IL_07e2: Expected I, but got O
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Expected O, but got Unknown
		//IL_0327: Expected O, but got I4
		//IL_07ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0804: Expected O, but got Unknown
		//IL_080e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0813: Expected O, but got Unknown
		//IL_081b: Expected I, but got O
		//IL_082b: Expected O, but got I
		//IL_0e91: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e96: Expected O, but got Unknown
		//IL_0ec4: Expected O, but got I4
		//IL_0ec9: Expected I, but got O
		//IL_08e5: Expected O, but got I4
		//IL_0a27: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2c: Expected O, but got Unknown
		//IL_0a4c: Expected O, but got I
		//IL_0a6c: Expected O, but got I4
		//IL_0866: Expected O, but got I
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Expected O, but got Unknown
		//IL_0373: Unknown result type (might be due to invalid IL or missing references)
		//IL_0378: Expected O, but got Unknown
		//IL_0c34: Expected O, but got I
		//IL_08fc: Expected O, but got I4
		//IL_039f: Expected O, but got I4
		//IL_03a4: Expected I, but got O
		//IL_03ad: Expected O, but got I4
		//IL_0c47: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4c: Expected O, but got Unknown
		//IL_0c62: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c67: Expected O, but got Unknown
		//IL_0c7f: Expected O, but got I
		//IL_0a90: Expected O, but got I
		//IL_09bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c2: Expected O, but got Unknown
		//IL_09cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d0: Expected O, but got Unknown
		//IL_0a02: Expected O, but got I4
		//IL_0f49: Expected O, but got I4
		//IL_0874: Unknown result type (might be due to invalid IL or missing references)
		//IL_0879: Expected O, but got Unknown
		//IL_0882: Unknown result type (might be due to invalid IL or missing references)
		//IL_0887: Expected O, but got Unknown
		//IL_03d3: Expected O, but got I4
		//IL_0458: Expected O, but got I4
		//IL_045d: Expected I, but got O
		//IL_0a9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa3: Expected O, but got Unknown
		//IL_0aac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab1: Expected O, but got Unknown
		//IL_03e9: Expected I, but got O
		//IL_03f9: Expected O, but got I
		//IL_041b: Expected O, but got I4
		//IL_0420: Expected I, but got O
		//IL_0430: Expected O, but got I
		//IL_047c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0481: Expected O, but got Unknown
		//IL_049d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a2: Expected O, but got Unknown
		//IL_0ada: Expected O, but got I4
		//IL_04d0: Expected O, but got I4
		//IL_04d5: Expected I, but got O
		//IL_04fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ff: Expected O, but got Unknown
		//IL_0507: Expected I, but got O
		//IL_0517: Expected O, but got I
		//IL_05d1: Expected O, but got I4
		//IL_0b5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b64: Expected O, but got Unknown
		//IL_0b84: Expected O, but got I
		//IL_0ba4: Expected O, but got I4
		//IL_0552: Expected O, but got I
		//IL_05e8: Expected O, but got I4
		//IL_0bc8: Expected O, but got I
		//IL_0ae8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aed: Expected O, but got Unknown
		//IL_0af5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afa: Expected O, but got Unknown
		//IL_0b03: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b08: Expected O, but got Unknown
		//IL_0b3a: Expected O, but got I4
		//IL_0f76: Expected O, but got I4
		//IL_0560: Unknown result type (might be due to invalid IL or missing references)
		//IL_0565: Expected O, but got Unknown
		//IL_056e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0573: Expected O, but got Unknown
		//IL_0bd6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bdb: Expected O, but got Unknown
		//IL_0be4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be9: Expected O, but got Unknown
		//IL_0c04: Expected O, but got I4
		bool flag = response == null;
		string text = (string)(object)response;
		object varName;
		if (!flag)
		{
			object obj = typeof(System.IOAsyncCallback) + 976;
			varName = "destinationTimeZone" + 2696;
			nint num = (nint)response;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00bc;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
			object obj3 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X10_v31-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj3 += 16;
				obj2--;
				if ((nint)obj2 != 1)
				{
					continue;
				}
				goto IL_00bc;
			}
			object obj4 = obj3 + 1;
			object obj5 = num + obj4;
			object obj6 = obj5 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v340 @ X0_v95] (should have been resolved before IL gen)");
			object obj7 = default(object);
			if (obj7 != null)
			{
				goto IL_014d;
			}
			return;
		}
		goto IL_0df5;
		IL_0df5:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0e03;
		IL_0a18:
		object obj8 = typeof(System.IOAsyncCallback) + 368;
		object obj9 = obj8;
		object obj11 = default(object);
		object obj10 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v834 @ X8_v52+12E]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v834 @ X8_v52+12E]");
		bool flag2 = (nint)0 == 0;
		object obj13 = 0;
		if (flag2)
		{
			goto IL_0c12;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v834 @ X8_v52+B0]");
		object obj14 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ X10_v6-8]");
			bool flag3 = 0 == (nint)obj9;
			object obj15 = 0;
			if (flag3)
			{
				break;
			}
			obj14 += 16;
			obj12--;
			if ((nint)obj12 != 1)
			{
				continue;
			}
			goto IL_0ad1;
		}
		goto IL_0c3e;
		IL_0ad1:
		obj13 = 0;
		goto IL_0c12;
		IL_0593:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v878 @ X0_v79+8]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v878 @ X0_v79] (should have been resolved before IL gen)");
		bool flag4 = obj11 == null;
		object obj16 = !flag4;
		if (obj16 != null)
		{
			goto IL_0b50;
		}
		object obj17 = 0;
		LocalizableText localizableText;
		text = (string)(object)localizableText;
		goto IL_0df5;
		IL_0efb:
		object message;
		PopupWindow.ShowError((string)message);
		return;
		IL_00bc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v247 @ X0_v92] (should have been resolved before IL gen)");
		object obj18 = default(object);
		bool flag5 = obj18 == null;
		object obj19 = !flag5;
		if (obj19 == null)
		{
			return;
		}
		goto IL_014d;
		IL_014d:
		object defaultValue = (nint)0 + (nint)2000;
		string text2 = SFSExtensions.Get(response, (string)varName, (string)defaultValue);
		object obj20 = "m_StencilDeferredPS" + 3840;
		text = (string)obj20;
		object obj39;
		IndexOutOfRangeException ex2 = default(IndexOutOfRangeException);
		if (text2 == (string)obj20)
		{
			OneShotEvent<MassTournamentPlayerState> playerStateCache = PlayerStateCache;
			bool flag6 = PlayerStateCache == null;
			obj17 = 0;
			num2 = unchecked((nint)null);
			if (!flag6)
			{
				MassTournamentPlayerState <Data>k__BackingField = playerStateCache.<Data>k__BackingField;
				bool flag7 = playerStateCache.<Data>k__BackingField == null;
				obj17 = 0;
				num2 = unchecked((nint)null);
				if (!flag7)
				{
					MassEventStageViewModel activeStage = GetActiveStage();
					if (playerStateCache.<Data>k__BackingField.ShouldRefreshTickets(activeStage))
					{
						object obj21 = typeof(DataRelation) + 712;
						object obj22 = obj21;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v578 @ X0_v58+E4]");
						bool flag8 = (nint)0 == 0;
						object obj23 = !flag8;
						if (obj23 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						DateTime now = DateTime.Now;
						TimeSpan timeSpan = <Data>k__BackingField.<NextTicketTime>k__BackingField - now;
						object obj24 = typeof(DataRelation) + 824;
						object obj25 = obj24;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v621 @ X8_v78+E4]");
						bool flag9 = (nint)0 == 0;
						object obj26 = !flag9;
						if (obj26 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						string durationText = DateTimeUtil.GetDurationText(timeSpan);
						object obj27 = "Network Authentication Required" + 3128;
						text = (string)obj27;
						PopupWindowBuilder popupWindowBuilder = PopupWindowBuilder.CreateError(null, (string)obj27);
						bool flag10 = popupWindowBuilder == null;
						obj17 = 0;
						num2 = unchecked((nint)null);
						if (!flag10)
						{
							object title = "Drop Menu Toggle" + 3600;
							IPopupWindowBuilderNeedsBody popupWindowBuilderNeedsBody = popupWindowBuilder.Titled((string)title);
							object obj28 = typeof(TypeConverter<ushort, char>) + 3400;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
							object[] array = default(object[]);
							bool flag11 = array == null;
							obj17 = 0;
							num2 = unchecked((nint)null);
							text = (string)1;
							if (!flag11)
							{
								bool flag12 = durationText == null;
								string text3 = (string)1;
								if (!flag12)
								{
									nint num3 = (nint)array;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X8_v99 (Il2CppClass<System.Object[]>)+40]");
									text3 = (string)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
									bool flag13 = ex2 == null;
									obj17 = 0;
									num2 = unchecked((nint)null);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X8_v99 (Il2CppClass<System.Object[]>)+40]");
									text = (string)0;
									if (flag13)
									{
										goto IL_0e11;
									}
								}
								bool flag14 = array.Length == 0;
								obj17 = 0;
								num2 = unchecked((nint)null);
								text = text3;
								if (flag14)
								{
									goto IL_0e03;
								}
								object obj29 = array + 32;
								obj29 = durationText;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								object text4 = "startPosition" + 4064;
								localizableText = TextMeshProExtensions.LocalizeWith((string)text4, array);
								bool flag15 = popupWindowBuilderNeedsBody == null;
								obj17 = 0;
								num2 = unchecked((nint)null);
								text = (string)(object)array;
								if (!flag15)
								{
									object obj30 = typeof(System.IOAsyncCallback) + 384;
									nint num4 = (nint)popupWindowBuilderNeedsBody;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v860 @ X8_v91 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+12E]");
									object obj31 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v860 @ X8_v91 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+12E]");
									if ((nint)0 == 0)
									{
										goto IL_0593;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v860 @ X8_v91 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+B0]");
									object obj32 = (nint)0 + (nint)8;
									while (true)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X10_v26-8]");
										if (0 == (nint)obj30)
										{
											break;
										}
										obj32 += 16;
										obj31--;
										if ((nint)obj31 != 1)
										{
											continue;
										}
										goto IL_0593;
									}
									object obj33 = obj32 + 1;
									object obj34 = num4 + obj33;
									object obj35 = obj34 + 312;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v895 @ X0_v82+8]");
									num2 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v895 @ X0_v82] (should have been resolved before IL gen)");
									bool flag16 = obj11 == null;
									obj17 = 0;
									text = (string)(object)localizableText;
									if (!flag16)
									{
										goto IL_0b50;
									}
								}
							}
						}
					}
					else
					{
						object obj36 = "Network Authentication Required" + 3128;
						text = (string)obj36;
						PopupWindowBuilder popupWindowBuilder2 = PopupWindowBuilder.CreateError(null, (string)obj36);
						bool flag17 = popupWindowBuilder2 == null;
						obj17 = 0;
						num2 = unchecked((nint)null);
						if (!flag17)
						{
							object obj37 = "Drop Menu Toggle" + 3600;
							text = (string)obj37;
							IPopupWindowBuilderNeedsBody popupWindowBuilderNeedsBody2 = popupWindowBuilder2.Titled((string)obj37);
							bool flag18 = popupWindowBuilderNeedsBody2 == null;
							obj17 = 0;
							num2 = unchecked((nint)null);
							if (!flag18)
							{
								object obj38 = typeof(System.IOAsyncCallback) + 384;
								obj39 = "Network Authentication Required" + 920;
								nint num5 = (nint)popupWindowBuilderNeedsBody2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v647 @ X8_v65 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+12E]");
								object obj40 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v647 @ X8_v65 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+12E]");
								if ((nint)0 == 0)
								{
									goto IL_08a7;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v647 @ X8_v65 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+B0]");
								object obj41 = (nint)0 + (nint)8;
								while (true)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X10_v16-8]");
									if (0 == (nint)obj38)
									{
										break;
									}
									obj41 += 16;
									obj40--;
									if ((nint)obj40 != 1)
									{
										continue;
									}
									goto IL_08a7;
								}
								object obj42 = num5 + obj41;
								object obj43 = obj42 + 312;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v72+8]");
								num2 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v200 @ X8_v72] (should have been resolved before IL gen)");
								bool flag19 = obj11 == null;
								obj17 = 0;
								text = (string)obj39;
								if (!flag19)
								{
									goto IL_0a18;
								}
							}
						}
					}
				}
			}
			goto IL_0df5;
		}
		object obj44 = "not" + 152;
		if (text2 == (string)obj44)
		{
			object obj45 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			object obj46 = obj45;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ X0_v39+E4]");
			bool flag20 = (nint)0 == 0;
			object obj47 = !flag20;
			if (obj47 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			message = "WhiteSmoke" + 1664;
		}
		else
		{
			object obj48 = "not" + 144;
			if (text2 == (string)obj48)
			{
				object obj49 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
				object obj50 = obj49;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v566 @ X0_v36+E4]");
				bool flag21 = (nint)0 == 0;
				object obj51 = !flag21;
				if (obj51 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				message = "The operation is not allowed on non-connected sockets." + 3680;
			}
			else
			{
				object obj52 = "setMimeType" + 3864;
				if (!(text2 == (string)obj52))
				{
					goto IL_0c89;
				}
				object obj53 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
				object obj54 = obj53;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ X0_v33+E4]");
				bool flag22 = (nint)0 == 0;
				object obj55 = !flag22;
				if (obj55 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				message = "WhiteSmoke" + 2088;
			}
		}
		goto IL_0efb;
		IL_08a7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v673 @ X0_v54+8]");
		num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v673 @ X0_v54] (should have been resolved before IL gen)");
		bool flag23 = obj11 == null;
		object obj56 = !flag23;
		if (obj56 != null)
		{
			goto IL_0a18;
		}
		obj17 = 0;
		text = (string)obj39;
		goto IL_0df5;
		IL_0e11:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_0e03:
		ex2 = new IndexOutOfRangeException();
		goto IL_0e11;
		IL_0c12:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj58 = default(object);
		object obj57 = obj58;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v790 @ X0_v48+8]");
		object obj59 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v417 @ X2_v20 (should have been resolved before IL gen)");
		goto IL_0c3e;
		IL_0c89:
		object obj60 = "not" + 160;
		if (text2 == (string)obj60)
		{
			object obj61 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			object obj62 = obj61;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v626 @ X0_v30+E4]");
			bool flag24 = (nint)0 == 0;
			object obj63 = !flag24;
			if (obj63 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			message = "WhiteSmoke" + 1672;
			goto IL_0efb;
		}
		object obj64 = "startPosition" + 1152;
		if (text2 == (string)obj64)
		{
			object obj65 = typeof(MemberAchievementClanFeedData) + 3448;
			object obj66 = obj65;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v677 @ X0_v26+E4]");
			bool flag25 = (nint)0 == 0;
			object obj67 = !flag25;
			if (obj67 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object text5 = "The operation is not allowed on non-connected sockets." + 3696;
			OnlyForSubscribersPopup.Show(TrackingFeature.MassEvents, massTournamentIcon, (string)text5);
		}
		return;
		IL_0c3e:
		object obj68 = obj14 + 9;
		object obj69 = obj10 + obj68;
		object obj70 = obj69 + 312;
		object obj71 = obj70;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ X8_v54+8]");
		object obj72 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v418 @ X2_v17 (should have been resolved before IL gen)");
		goto IL_0c89;
		IL_0b50:
		object obj73 = typeof(System.IOAsyncCallback) + 368;
		obj9 = obj73;
		obj10 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v834 @ X8_v52+12E]");
		object obj74 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v834 @ X8_v52+12E]");
		bool flag26 = (nint)0 == 0;
		obj13 = 0;
		if (flag26)
		{
			goto IL_0c12;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v834 @ X8_v52+B0]");
		obj14 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ X10_v6-8]");
			bool flag27 = 0 == (nint)obj9;
			object obj15 = 0;
			if (flag27)
			{
				break;
			}
			obj14 += 16;
			obj74--;
			bool flag28 = (nint)obj74 != 1;
			obj13 = 0;
			if (flag28)
			{
				continue;
			}
			goto IL_0c12;
		}
		goto IL_0c3e;
	}
}
