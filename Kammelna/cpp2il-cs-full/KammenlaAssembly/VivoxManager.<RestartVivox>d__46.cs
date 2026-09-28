using System;
using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using DataTracking;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities;
using Unity.Services.Authentication.Shared;
using Unity.Services.Vivox;
using UnityEngine;
using UnityEngine.InputSystem.UI;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using Util;

public class VivoxManager : MonoBehaviour
{
	private class VivoxParticipantListener
	{
		private readonly VivoxManager <_manager>k__BackingField;

		private VivoxParticipant _participant;

		private VivoxManager _manager => <_manager>k__BackingField;

		public VivoxParticipantListener(VivoxManager manager, VivoxParticipant participant)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0020: Expected O, but got I
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Expected O, but got Unknown
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Expected O, but got Unknown
			//IL_003d: Expected I, but got O
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = (nint)0 + (nint)3152;
			base..ctor();
			object obj3 = this + 16;
			obj3 = manager;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj4 = this + 24;
			obj4 = participant;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action action = default(Action);
			action..ctor(this, (IntPtr)obj2);
			participant.ParticipantAudioEnergyChanged += action;
		}

		public void Destroy()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0020: Expected O, but got I
			//IL_004d: Expected I, but got O
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = (nint)0 + (nint)3152;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action action = default(Action);
			action..ctor(this, (IntPtr)obj2);
			_participant.ParticipantAudioEnergyChanged -= action;
		}

		private void OnParticipantAudioEnergyChanged()
		{
			VivoxManager vivoxManager = <_manager>k__BackingField;
			string displayName = _participant.DisplayName;
			double audioEnergy = _participant.AudioEnergy;
			Action<string, float?> onSpeakingInChat = vivoxManager.OnSpeakingInChat;
			if (vivoxManager.OnSpeakingInChat != null)
			{
				float? num = (float)audioEnergy;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v99 @ X20_v3 (System.Action`2<System.String, System.Nullable`1<System.Single>>)+18] (should have been resolved before IL gen)");
			}
		}
	}

	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<VivoxParticipantListener> <>9__47_0;

		public static Action<Task> <>9__47_1;

		public static Action<Task> <>9__47_2;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(TrackedDeviceRaycaster.<>c) + 2200;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <DestroyVivox>b__47_0(VivoxParticipantListener listener)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0020: Expected O, but got I
			//IL_0053: Expected I, but got O
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = (nint)0 + (nint)3152;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action action = default(Action);
			action..ctor(listener, (IntPtr)obj2);
			listener._participant.ParticipantAudioEnergyChanged -= action;
		}

		internal void <DestroyVivox>b__47_1(Task task)
		{
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Expected O, but got Unknown
			if (task.IsFaulted)
			{
				AggregateException exception = task.Exception;
				object obj = typeof(DataRelation) + 856;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v5+E4]");
				if ((nint)0 != 0)
				{
					Debug.LogException(exception);
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Debug.LogException(exception);
			}
		}

		internal void <DestroyVivox>b__47_2(Task task)
		{
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Expected O, but got Unknown
			if (task.IsFaulted)
			{
				AggregateException exception = task.Exception;
				object obj = typeof(DataRelation) + 856;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v5+E4]");
				if ((nint)0 != 0)
				{
					Debug.LogException(exception);
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Debug.LogException(exception);
			}
		}
	}

	private sealed class <>c__DisplayClass48_0
	{
		public VivoxManager <>4__this;

		public VivoxParticipant vivoxParticipant;

		internal VivoxParticipantListener <ParticipantAddedToChannel>b__0(string _)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(TrackedDeviceRaycaster.<>c) + 2224;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			VivoxParticipantListener vivoxParticipantListener = default(VivoxParticipantListener);
			vivoxParticipantListener..ctor(<>4__this, vivoxParticipant);
			return vivoxParticipantListener;
		}
	}

	private sealed class <RestartVivox>d__46 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public VivoxManager <>4__this;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <RestartVivox>d__46(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_008a: Expected I4, but got I8
			//IL_013a: Expected I4, but got O
			//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cd: Expected O, but got Unknown
			//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f9: Expected O, but got Unknown
			//IL_0036: Expected I4, but got I8
			if (<>1__state != 0)
			{
				if (<>1__state == 1)
				{
					<>1__state = -1;
					if ((object)<>4__this == null)
					{
						goto IL_012c;
					}
					<>4__this.RefreshConnection();
				}
				return <>1__state == 0;
			}
			<>1__state = -1;
			if ((object)<>4__this != null)
			{
				<>4__this.DestroyVivox(fireEvent: true);
				object obj = typeof(UsageHint) + 1640;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				WaitForSeconds waitForSeconds = default(WaitForSeconds);
				waitForSeconds..ctor(1f);
				object obj2 = this + 24;
				obj2 = waitForSeconds;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				_ = 1;
				return <>1__state == 0;
			}
			goto IL_012c;
			IL_012c:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
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
			object obj2 = (nint)0 + (nint)3144;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}
	}

	private bool _isConnected;

	private bool isApplicationPaused;

	private bool <AmIMuted>k__BackingField;

	private Action<string, float?> m_OnSpeakingInChat;

	private Action<string> m_OnMuteUpdate;

	private Action<bool> m_OnConnectionUpdate;

	private const int MaxSignalingAddressLength = 256;

	private bool isMakingAConnection;

	private bool isMakingAChannelConnection;

	private Dictionary<string, VivoxParticipantListener> _listeners;

	private KGame game;

	public bool isConnected
	{
		get
		{
			return _isConnected;
		}
		private set
		{
			bool arg = default(bool);
			_isConnected = arg;
			Actions.SafeInvoke(this.OnConnectionUpdate, arg);
		}
	}

	public bool AmIMuted
	{
		get
		{
			return <AmIMuted>k__BackingField;
		}
		private set
		{
			<AmIMuted>k__BackingField = value;
		}
	}

	private static bool IsSupportedPlatform
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00d3: Expected O, but got I4
			//IL_0125: Unknown result type (might be due to invalid IL or missing references)
			//IL_012a: Expected O, but got Unknown
			//IL_0154: Expected O, but got I4
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7389]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v8+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v8+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Platform platform = KUtil.GetPlatform();
			if (platform == Platform.Web)
			{
				goto IL_009d;
			}
			goto IL_0116;
			IL_009d:
			return false;
			IL_0116:
			object obj5 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			RuntimePlatform platform2 = Application.platform;
			bool flag3 = platform2 == RuntimePlatform.OSXEditor;
			return !flag3;
			IL_0074:
			Platform platform3 = KUtil.GetPlatform();
			if (platform3 == Platform.Web)
			{
				goto IL_009d;
			}
			goto IL_0116;
		}
	}

	private bool isVoiceChatEnabled
	{
		get
		{
			//IL_01f6: Expected I4, but got O
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected O, but got Unknown
			//IL_0071: Expected O, but got I
			//IL_0122: Expected O, but got I4
			//IL_0174: Unknown result type (might be due to invalid IL or missing references)
			//IL_0179: Expected O, but got Unknown
			//IL_01a3: Expected O, but got I4
			bool flag;
			if ((object)game != null)
			{
				flag = game.IsVoiceChatEnabled;
				if (flag)
				{
					object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7389]");
					object obj2 = (nint)0 & (nint)1;
					if (obj2 != null)
					{
						object obj3 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v12+E4]");
						if ((nint)0 != 0)
						{
							goto IL_00bb;
						}
					}
					else
					{
						_ = 1;
						object obj3 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v12+E4]");
						bool flag2 = (nint)0 == 0;
						object obj4 = !flag2;
						if (obj4 != null)
						{
							goto IL_00bb;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					Platform platform = KUtil.GetPlatform();
					if (platform == Platform.Web)
					{
						goto IL_00e4;
					}
					goto IL_0165;
				}
				goto IL_01f6;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0165:
			object obj5 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v6+E4]");
			bool flag3 = (nint)0 == 0;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			RuntimePlatform platform2 = Application.platform;
			bool flag4 = platform2 == RuntimePlatform.OSXEditor;
			return !flag4;
			IL_01f6:
			return flag;
			IL_00bb:
			Platform platform3 = KUtil.GetPlatform();
			if (platform3 == Platform.Web)
			{
				goto IL_00e4;
			}
			goto IL_0165;
			IL_00e4:
			flag = false;
			goto IL_01f6;
		}
	}

	private static string myDBId
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00ee: Expected O, but got I
			//IL_0118: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_0161: Expected O, but got I4
			object obj = 152989696;
			object obj2 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E72C2]");
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
			User localUser = sessionModel.LocalUser;
			return SFSKammelnaUserExtensions.GetDbId(localUser);
			IL_016f:
			return (string)(object)new NullReferenceException();
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			if ((object)sessionModel != null)
			{
				goto IL_00b8;
			}
			goto IL_016f;
		}
	}

	public event Action<string, float?> OnSpeakingInChat
	{
		add
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 696;
			object obj2 = this + 40;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
		remove
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 696;
			object obj2 = this + 40;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
	}

	public event Action<string> OnMuteUpdate
	{
		add
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
			object obj2 = this + 48;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
		remove
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
			object obj2 = this + 48;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
	}

	public event Action<bool> OnConnectionUpdate
	{
		add
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
			object obj2 = this + 56;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
		remove
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
			object obj2 = this + 56;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
	}

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0995: Expected O, but got I
		//IL_09bf: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_0097: Expected O, but got I
		//IL_00af: Expected I, but got O
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00f2: Expected O, but got I
		//IL_0100: Expected I, but got O
		//IL_012f: Expected O, but got I
		//IL_013d: Expected I, but got O
		//IL_015a: Expected O, but got I4
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected O, but got Unknown
		//IL_09e5: Expected O, but got I
		//IL_0a03: Expected O, but got I
		//IL_0a11: Expected I, but got O
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected O, but got Unknown
		//IL_019f: Expected O, but got I
		//IL_0235: Expected O, but got I
		//IL_0255: Expected O, but got I
		//IL_026f: Expected O, but got I4
		//IL_0287: Expected O, but got I
		//IL_0a52: Expected O, but got I
		//IL_0a69: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6e: Expected O, but got Unknown
		//IL_0a84: Expected O, but got I
		//IL_0a92: Expected I, but got O
		//IL_01da: Expected O, but got I
		//IL_02d0: Expected O, but got I
		//IL_0366: Expected O, but got I
		//IL_0386: Expected O, but got I
		//IL_03a0: Expected O, but got I4
		//IL_03b8: Expected O, but got I
		//IL_06f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fd: Expected O, but got Unknown
		//IL_0713: Unknown result type (might be due to invalid IL or missing references)
		//IL_0718: Expected O, but got Unknown
		//IL_0728: Expected O, but got I
		//IL_0748: Expected O, but got I
		//IL_0ad3: Expected O, but got I
		//IL_0af1: Expected O, but got I
		//IL_0aff: Expected I, but got O
		//IL_030b: Expected O, but got I
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected O, but got Unknown
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected O, but got Unknown
		//IL_0401: Expected O, but got I
		//IL_077d: Expected O, but got I
		//IL_0497: Expected O, but got I
		//IL_04b7: Expected O, but got I
		//IL_04d1: Expected O, but got I4
		//IL_04e9: Expected O, but got I
		//IL_0793: Unknown result type (might be due to invalid IL or missing references)
		//IL_0798: Expected O, but got Unknown
		//IL_07ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b3: Expected O, but got Unknown
		//IL_07c3: Expected O, but got I
		//IL_07e3: Expected O, but got I
		//IL_0b40: Expected O, but got I
		//IL_0b57: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b5c: Expected O, but got Unknown
		//IL_0b72: Expected O, but got I
		//IL_0b80: Expected I, but got O
		//IL_043c: Expected O, but got I
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Expected O, but got Unknown
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Expected O, but got Unknown
		//IL_0532: Expected O, but got I
		//IL_0818: Expected O, but got I
		//IL_05c8: Expected O, but got I
		//IL_05e8: Expected O, but got I
		//IL_0602: Expected O, but got I4
		//IL_061a: Expected O, but got I
		//IL_082e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0833: Expected O, but got Unknown
		//IL_0849: Unknown result type (might be due to invalid IL or missing references)
		//IL_084e: Expected O, but got Unknown
		//IL_085e: Expected O, but got I
		//IL_087e: Expected O, but got I
		//IL_0bc1: Expected O, but got I
		//IL_0bdf: Expected O, but got I
		//IL_0bed: Expected I, but got O
		//IL_056d: Expected O, but got I
		//IL_044a: Unknown result type (might be due to invalid IL or missing references)
		//IL_044f: Expected O, but got Unknown
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_045d: Expected O, but got Unknown
		//IL_0663: Expected O, but got I
		//IL_08b3: Expected O, but got I
		//IL_08c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ce: Expected O, but got Unknown
		//IL_08e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e9: Expected O, but got Unknown
		//IL_08f9: Expected O, but got I
		//IL_0919: Expected O, but got I
		//IL_0c2e: Expected O, but got I
		//IL_069e: Expected O, but got I
		//IL_057b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0580: Expected O, but got Unknown
		//IL_0589: Unknown result type (might be due to invalid IL or missing references)
		//IL_058e: Expected O, but got Unknown
		//IL_094e: Expected O, but got I
		//IL_0964: Unknown result type (might be due to invalid IL or missing references)
		//IL_0969: Expected O, but got Unknown
		//IL_097f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0984: Expected O, but got Unknown
		//IL_06ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b1: Expected O, but got Unknown
		//IL_06ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bf: Expected O, but got Unknown
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)136;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj5 = this + 80;
		object obj6 = default(object);
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if (!isVoiceChatEnabled)
		{
			return;
		}
		object obj7 = typeof(SqlSingle[]) + 2376;
		object obj8 = (nint)0 + (nint)3096;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj8);
		game.OnRoundStart += action;
		object obj9 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj10 = (nint)0 + (nint)3088;
		KGame.PlayerSwitchSeatDelegate playerSwitchSeatDelegate = default(KGame.PlayerSwitchSeatDelegate);
		playerSwitchSeatDelegate..ctor(this, (IntPtr)obj10);
		game.OnPlayerSwitchSeat += playerSwitchSeatDelegate;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj11 = (nint)0 + (nint)3080;
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj11);
		game.OnGameInitialized += action2;
		object obj12 = 146685952;
		object obj13 = typeof(UsageHint) + 1440;
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X8_v13+B8]");
		object obj15 = 0;
		object obj16 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj17 = (nint)0 + (nint)3104;
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj17);
		object obj18 = typeof(System.IOAsyncCallback) + 2104;
		object obj19 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X8_v17+12E]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X8_v17+12E]");
		if ((nint)0 == 0)
		{
			goto IL_021b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X8_v17+B0]");
		object obj21 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X10_v34-8]");
			if (0 == (nint)obj18)
			{
				break;
			}
			obj21 += 16;
			obj20--;
			if ((nint)obj20 != 1)
			{
				continue;
			}
			goto IL_021b;
		}
		object obj22 = obj21 + 4;
		object obj23 = obj19 + obj22;
		object obj24 = obj23 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ X0_v83+8]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v433 @ X0_v83] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X22_v5+5D3]");
		object obj26 = (nint)0 & (nint)1;
		bool flag2 = obj26 == null;
		Action action4 = action3;
		if (flag2)
		{
			goto IL_029d;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ X0_v83+8]");
		object obj27 = 0;
		Action action5 = action3;
		goto IL_0a3a;
		IL_0630:
		_ = 1;
		object obj29;
		object obj28 = obj29;
		Action<object> action7;
		Action<object> action6 = action7;
		goto IL_0ba9;
		IL_047d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v611 @ X0_v58+8]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v611 @ X0_v58] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45D3]");
		object obj31 = (nint)0 & (nint)1;
		bool flag3 = obj31 == null;
		object obj32 = !flag3;
		Action<object> action9 = default(Action<object>);
		Action<object> action8 = action9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v611 @ X0_v58+8]");
		object obj33 = 0;
		Action<object> action10 = action9;
		if (obj32 == null)
		{
			goto IL_04ff;
		}
		goto IL_0b28;
		IL_034c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ X0_v69+8]");
		object obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v505 @ X0_v69] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45D3]");
		object obj35 = (nint)0 & (nint)1;
		bool flag4 = obj35 == null;
		object obj36 = !flag4;
		Action<object> action12 = default(Action<object>);
		Action<object> action11 = action12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ X0_v69+8]");
		object obj37 = 0;
		Action<object> action13 = action12;
		if (obj36 == null)
		{
			goto IL_03ce;
		}
		goto IL_0abb;
		IL_03ce:
		_ = 1;
		obj37 = obj34;
		action13 = action11;
		goto IL_0abb;
		IL_0abb:
		object obj38 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ X8_v25+B8]");
		object obj39 = 0;
		object obj40 = obj39;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj41 = (nint)0 + (nint)3072;
		action9..ctor((object)this, (IntPtr)obj41);
		object obj42 = obj40;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X8_v29+12E]");
		object obj43 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X8_v29+12E]");
		if ((nint)0 == 0)
		{
			goto IL_047d;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X8_v29+B0]");
		object obj44 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ X10_v22-8]");
			if (0 == (nint)obj18)
			{
				break;
			}
			obj44 += 16;
			obj43--;
			if ((nint)obj43 != 1)
			{
				continue;
			}
			goto IL_047d;
		}
		object obj45 = obj44 + 24;
		object obj46 = obj42 + obj45;
		object obj47 = obj46 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v646 @ X0_v61+8]");
		obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v646 @ X0_v61] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X22_v5+5D3]");
		object obj48 = (nint)0 & (nint)1;
		bool flag5 = obj48 == null;
		action8 = action9;
		if (flag5)
		{
			goto IL_04ff;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v646 @ X0_v61+8]");
		obj33 = 0;
		action10 = action9;
		goto IL_0b28;
		IL_04ff:
		_ = 1;
		obj33 = obj30;
		action10 = action8;
		goto IL_0b28;
		IL_0b28:
		object obj49 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v681 @ X8_v31+B8]");
		object obj50 = 0;
		object obj51 = obj50;
		object obj52 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 4016;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj53 = (nint)0 + (nint)3112;
		Action<object> action14 = default(Action<object>);
		action14..ctor((object)this, (IntPtr)obj53);
		object obj54 = obj51;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v687 @ X8_v35+12E]");
		object obj55 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v687 @ X8_v35+12E]");
		if ((nint)0 == 0)
		{
			goto IL_05ae;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v687 @ X8_v35+B0]");
		object obj56 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v729 @ X10_v16-8]");
			if (0 == (nint)obj18)
			{
				break;
			}
			obj56 += 16;
			obj55--;
			if ((nint)obj55 != 1)
			{
				continue;
			}
			goto IL_05ae;
		}
		object obj57 = obj56 + 26;
		object obj58 = obj54 + obj57;
		object obj59 = obj58 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v753 @ X0_v50+8]");
		obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v753 @ X0_v50] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X22_v5+5D3]");
		object obj60 = (nint)0 & (nint)1;
		bool flag6 = obj60 == null;
		action7 = action14;
		if (flag6)
		{
			goto IL_0630;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v753 @ X0_v50+8]");
		obj28 = 0;
		action6 = action14;
		goto IL_0ba9;
		IL_0ba9:
		object obj61 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v788 @ X8_v37+B8]");
		object obj62 = 0;
		object obj63 = obj62;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj64 = (nint)0 + (nint)3120;
		Action<object> action15 = default(Action<object>);
		action15..ctor((object)this, (IntPtr)obj64);
		object obj65 = obj63;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v793 @ X8_v41+12E]");
		object obj66 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v793 @ X8_v41+12E]");
		if ((nint)0 == 0)
		{
			goto IL_06df;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v793 @ X8_v41+B0]");
		object obj67 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v834 @ X10_v10-8]");
			if (0 == (nint)obj18)
			{
				break;
			}
			obj67 += 16;
			obj66--;
			if ((nint)obj66 != 1)
			{
				continue;
			}
			goto IL_06df;
		}
		object obj68 = obj67 + 28;
		object obj69 = obj65 + obj68;
		object obj70 = obj69 + 312;
		goto IL_0c16;
		IL_021b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X0_v80+8]");
		obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v398 @ X0_v80] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45D3]");
		object obj71 = (nint)0 & (nint)1;
		bool flag7 = obj71 == null;
		object obj72 = !flag7;
		action4 = action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X0_v80+8]");
		obj27 = 0;
		action5 = action3;
		if (obj72 == null)
		{
			goto IL_029d;
		}
		goto IL_0a3a;
		IL_029d:
		_ = 1;
		obj27 = obj25;
		action5 = action4;
		goto IL_0a3a;
		IL_0a3a:
		object obj73 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ X8_v19+B8]");
		object obj74 = 0;
		object obj75 = obj74;
		object obj76 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj77 = (nint)0 + (nint)3064;
		action12..ctor((object)this, (IntPtr)obj77);
		object obj78 = obj75;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ X8_v23+12E]");
		object obj79 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ X8_v23+12E]");
		if ((nint)0 == 0)
		{
			goto IL_034c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ X8_v23+B0]");
		object obj80 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ X10_v28-8]");
			if (0 == (nint)obj18)
			{
				break;
			}
			obj80 += 16;
			obj79--;
			if ((nint)obj79 != 1)
			{
				continue;
			}
			goto IL_034c;
		}
		object obj81 = obj80 + 22;
		object obj82 = obj78 + obj81;
		object obj83 = obj82 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X0_v72+8]");
		obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v540 @ X0_v72] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X22_v5+5D3]");
		object obj84 = (nint)0 & (nint)1;
		bool flag8 = obj84 == null;
		action11 = action12;
		if (flag8)
		{
			goto IL_03ce;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X0_v72+8]");
		obj37 = 0;
		action13 = action12;
		goto IL_0abb;
		IL_06df:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0c16;
		IL_05ae:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v718 @ X0_v47+8]");
		obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v718 @ X0_v47] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45D3]");
		object obj85 = (nint)0 & (nint)1;
		bool flag9 = obj85 == null;
		object obj86 = !flag9;
		action7 = action14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v718 @ X0_v47+8]");
		obj28 = 0;
		action6 = action14;
		if (obj86 == null)
		{
			goto IL_0630;
		}
		goto IL_0ba9;
		IL_0c16:
		object obj87 = obj70;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v851 @ X0_v37+8]");
		object obj88 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v168 @ X3_v10 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0623: Expected I, but got O
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0045: Expected O, but got I
		//IL_0071: Expected I, but got O
		//IL_0082: Expected O, but got I
		//IL_00ae: Expected I, but got O
		//IL_00bf: Expected O, but got I
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_0640: Expected O, but got I
		//IL_0660: Expected I, but got O
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected O, but got Unknown
		//IL_0113: Expected O, but got I
		//IL_0698: Unknown result type (might be due to invalid IL or missing references)
		//IL_069d: Expected O, but got Unknown
		//IL_06a9: Expected O, but got I
		//IL_014e: Expected O, but got I
		//IL_07fd: Expected O, but got I
		//IL_081d: Expected I, but got O
		//IL_01e4: Expected O, but got I
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected O, but got Unknown
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected O, but got Unknown
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected O, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected O, but got Unknown
		//IL_06e8: Expected O, but got I
		//IL_021f: Expected O, but got I
		//IL_083a: Expected O, but got I
		//IL_085a: Expected I, but got O
		//IL_02b5: Expected O, but got I
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Expected O, but got Unknown
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Expected O, but got Unknown
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected O, but got Unknown
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected O, but got Unknown
		//IL_072a: Unknown result type (might be due to invalid IL or missing references)
		//IL_072f: Expected O, but got Unknown
		//IL_073b: Expected O, but got I
		//IL_02f0: Expected O, but got I
		//IL_0877: Expected O, but got I
		//IL_0897: Expected I, but got O
		//IL_0386: Expected O, but got I
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Expected O, but got Unknown
		//IL_0364: Unknown result type (might be due to invalid IL or missing references)
		//IL_0369: Expected O, but got Unknown
		//IL_041c: Expected O, but got I
		//IL_043c: Expected O, but got I
		//IL_0456: Expected O, but got I4
		//IL_0476: Expected O, but got I
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Expected O, but got Unknown
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Expected O, but got Unknown
		//IL_0786: Expected O, but got I
		//IL_07a6: Expected I, but got O
		//IL_03c1: Expected O, but got I
		//IL_04b7: Expected O, but got I
		//IL_054b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0550: Expected O, but got Unknown
		//IL_0566: Unknown result type (might be due to invalid IL or missing references)
		//IL_056b: Expected O, but got Unknown
		//IL_057b: Expected O, but got I
		//IL_059b: Expected O, but got I
		//IL_04f2: Expected O, but got I
		//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d4: Expected O, but got Unknown
		//IL_03dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e2: Expected O, but got Unknown
		//IL_05d8: Expected O, but got I
		//IL_05e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05eb: Expected O, but got Unknown
		//IL_0601: Unknown result type (might be due to invalid IL or missing references)
		//IL_0606: Expected O, but got Unknown
		//IL_0500: Unknown result type (might be due to invalid IL or missing references)
		//IL_0505: Expected O, but got Unknown
		//IL_050e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0513: Expected O, but got Unknown
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)3096;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj3 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1200;
		object obj4 = (nint)0 + (nint)3088;
		game.OnRoundStart -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		KGame.PlayerSwitchSeatDelegate playerSwitchSeatDelegate = default(KGame.PlayerSwitchSeatDelegate);
		playerSwitchSeatDelegate..ctor(this, (IntPtr)obj4);
		object obj5 = (nint)0 + (nint)3080;
		game.OnPlayerSwitchSeat -= playerSwitchSeatDelegate;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj5);
		object obj6 = (nint)0 + (nint)3104;
		game.OnGameInitialized -= action2;
		object obj7 = typeof(UsageHint) + 1440;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X8_v6+B8]");
		object obj9 = 0;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj6);
		object obj11 = typeof(System.IOAsyncCallback) + 2104;
		object obj12 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X8_v8+12E]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X8_v8+12E]");
		if ((nint)0 == 0)
		{
			goto IL_018f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X8_v8+B0]");
		object obj14 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X10_v31-8]");
			if (0 == (nint)obj11)
			{
				break;
			}
			obj14 += 16;
			obj13--;
			if ((nint)obj13 != 1)
			{
				continue;
			}
			goto IL_018f;
		}
		object obj15 = obj14 + 5;
		object obj16 = obj12 + obj15;
		object obj17 = obj16 + 312;
		goto IL_0689;
		IL_06dc:
		object obj18 = (nint)0 + (nint)3072;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v472 @ X0_v22] (should have been resolved before IL gen)");
		object obj19 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ X8_v20+B8]");
		object obj20 = 0;
		object obj21 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action4 = default(Action<object>);
		action4..ctor((object)this, (IntPtr)obj18);
		object obj22 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X8_v22+12E]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X8_v22+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0331;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X8_v22+B0]");
		object obj24 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ X10_v21-8]");
			if (0 == (nint)obj11)
			{
				break;
			}
			obj24 += 16;
			obj23--;
			if ((nint)obj23 != 1)
			{
				continue;
			}
			goto IL_0331;
		}
		object obj25 = obj24 + 25;
		object obj26 = obj22 + obj25;
		object obj27 = obj26 + 312;
		goto IL_071b;
		IL_071b:
		object obj28 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 4016;
		object obj29 = (nint)0 + (nint)3112;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v552 @ X0_v28] (should have been resolved before IL gen)");
		object obj30 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X8_v27+B8]");
		object obj31 = 0;
		object obj32 = obj31;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action5 = default(Action<object>);
		action5..ctor((object)this, (IntPtr)obj29);
		object obj33 = obj32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ X8_v29+12E]");
		object obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ X8_v29+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0402;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ X8_v29+B0]");
		object obj35 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v616 @ X10_v16-8]");
			if (0 == (nint)obj11)
			{
				break;
			}
			obj35 += 16;
			obj34--;
			if ((nint)obj34 != 1)
			{
				continue;
			}
			goto IL_0402;
		}
		object obj36 = obj35 + 27;
		object obj37 = obj33 + obj36;
		object obj38 = obj37 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X0_v52+8]");
		object obj39 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v640 @ X0_v52] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45D3]");
		object obj40 = (nint)0 & (nint)1;
		bool flag = obj40 == null;
		Action<object> action6 = action5;
		if (flag)
		{
			goto IL_0484;
		}
		Action<object> action7 = action5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X0_v52+8]");
		object obj41 = 0;
		goto IL_076e;
		IL_0533:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_07cf;
		IL_076e:
		object obj42 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v675 @ X8_v31+B8]");
		object obj43 = 0;
		object obj44 = obj43;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action8 = default(Action<object>);
		action8..ctor((object)this, (IntPtr)obj29);
		object obj45 = obj44;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v678 @ X8_v33+12E]");
		object obj46 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v678 @ X8_v33+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0533;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v678 @ X8_v33+B0]");
		object obj47 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v719 @ X10_v10-8]");
			if (0 == (nint)obj11)
			{
				break;
			}
			obj47 += 16;
			obj46--;
			if ((nint)obj46 != 1)
			{
				continue;
			}
			goto IL_0533;
		}
		object obj48 = obj47 + 29;
		object obj49 = obj45 + obj48;
		object obj50 = obj49 + 312;
		goto IL_07cf;
		IL_018f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0689;
		IL_0689:
		object obj51 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj52 = (nint)0 + (nint)3064;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v391 @ X0_v16] (should have been resolved before IL gen)");
		object obj53 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X8_v13+B8]");
		object obj54 = 0;
		object obj55 = obj54;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action9 = default(Action<object>);
		action9..ctor((object)this, (IntPtr)obj52);
		object obj56 = obj55;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X8_v15+12E]");
		object obj57 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X8_v15+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0260;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X8_v15+B0]");
		object obj58 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ X10_v26-8]");
			if (0 == (nint)obj11)
			{
				break;
			}
			obj58 += 16;
			obj57--;
			if ((nint)obj57 != 1)
			{
				continue;
			}
			goto IL_0260;
		}
		object obj59 = obj58 + 23;
		object obj60 = obj56 + obj59;
		object obj61 = obj60 + 312;
		goto IL_06dc;
		IL_0402:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ X0_v49+8]");
		obj39 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v605 @ X0_v49] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45D3]");
		object obj62 = (nint)0 & (nint)1;
		bool flag2 = obj62 == null;
		object obj63 = !flag2;
		action6 = action5;
		action7 = action5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ X0_v49+8]");
		obj41 = 0;
		if (obj63 == null)
		{
			goto IL_0484;
		}
		goto IL_076e;
		IL_07cf:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v736 @ X0_v37] (should have been resolved before IL gen)");
		DestroyVivox(fireEvent: false);
		return;
		IL_0331:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_071b;
		IL_0484:
		_ = 1;
		action7 = action6;
		obj41 = obj39;
		goto IL_076e;
		IL_0260:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_06dc;
	}

	private void OnApplicationPause(bool pauseStatus)
	{
		isApplicationPaused = pauseStatus;
		MuteMyself(<AmIMuted>k__BackingField);
	}

	private void OnRoundStart()
	{
		RefreshConnection();
	}

	private void OnPlayerSwitchSeat(int userID, string error)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_004f: Expected O, but got I4
		if (isVoiceChatEnabled)
		{
			object obj = typeof(Queue<string>) + 848;
			object obj2 = (nint)0 + (nint)2200;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel = default(SessionModel);
			User localUser = sessionModel.LocalUser;
			int intDbId = SFSKammelnaUserExtensions.GetIntDbId(localUser);
			int num = default(int);
			bool flag2 = num != intDbId;
			num = 0;
			if (!flag2)
			{
				bool isSpectator = game.IsSpectator;
				<AmIMuted>k__BackingField = isSpectator;
				num = 0;
			}
		}
		RefreshConnection();
	}

	private void OnGameInitialized()
	{
		RefreshConnection();
	}

	private void StartNewCall()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_00b7: Expected O, but got I
		//IL_00c5: Expected I, but got O
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		if (isMakingAConnection)
		{
			object obj = typeof(DataRelation) + 856;
			object message = "_InputUv1BufferOffset" + 3992;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v10+E4]");
			if ((nint)0 != 0)
			{
				Debug.Log(message);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Debug.Log(message);
		}
		else if (isVoiceChatEnabled)
		{
			isMakingAConnection = true;
			object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj4 = (nint)0 + (nint)3048;
			Action<bool> action = default(Action<bool>);
			action..ctor((object)this, (IntPtr)obj4);
			object obj5 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v6+E4]");
			if ((nint)0 != 0)
			{
				KUtil.RequestPermission(AppPermission.Microphone, action);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			KUtil.RequestPermission(AppPermission.Microphone, action);
		}
	}

	private void BroadcastMuteStatusUpdate()
	{
		SFS.SetVivoxMicStatus(<AmIMuted>k__BackingField);
		string arg = myDBId;
		Actions.SafeInvoke((Action<object>)this.OnMuteUpdate, arg);
	}

	public void ToggleMuteMyself()
	{
		//IL_000b: Expected O, but got I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected I4, but got Unknown
		object obj = ~(<AmIMuted>k__BackingField ? 1 : 0);
		bool isMute = (byte)(1 & obj) != 0;
		MuteMyself(isMute);
	}

	private void RefreshConnection()
	{
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_00d0: Expected O, but got I4
		if (isVoiceChatEnabled)
		{
			if (!game.IsSpectator || game.IsVoiceChatEnabledForSpectators)
			{
				if (_isConnected)
				{
					MuteMyself(<AmIMuted>k__BackingField);
				}
				else
				{
					StartNewCall();
				}
				return;
			}
		}
		else
		{
			object obj = typeof(DataRelation) + 856;
			object message = "___# Content push apply failed [{0}]: {1}" + 864;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Debug.LogError(message);
		}
		DestroyVivox(fireEvent: true);
	}

	private static string SanitizeAddress(string address)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00ce: Expected O, but got I4
		string text = default(string);
		if (text != null)
		{
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2504;
			string input;
			if (text._stringLength < 257)
			{
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v4+E4]");
				bool flag = (nint)0 == 0;
				IntPtr intPtr = default(IntPtr);
				int num = (int)(nint)intPtr;
				input = text;
				if (!flag)
				{
					goto IL_007b;
				}
			}
			else
			{
				text = text.Substring(0, 256);
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v4+E4]");
				bool flag2 = (nint)0 == 0;
				object obj3 = !flag2;
				int num = 0;
				input = text;
				if (obj3 != null)
				{
					goto IL_007b;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			return StringUtil.SanitizeChatMessage(input);
		}
		return (string)(object)new NullReferenceException();
		IL_007b:
		return StringUtil.SanitizeChatMessage(text);
	}

	private void MuteMyself(bool isMute)
	{
		//IL_0029: Expected O, but got I4
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected O, but got Unknown
		//IL_02a9: Expected O, but got I
		//IL_0053: Expected O, but got I4
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_00c2: Expected O, but got I
		//IL_00fd: Expected O, but got I
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected O, but got Unknown
		//IL_0302: Expected O, but got I
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected O, but got Unknown
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected O, but got Unknown
		//IL_01b6: Expected O, but got I
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Expected O, but got Unknown
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_01f1: Expected O, but got I
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Expected O, but got Unknown
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected O, but got Unknown
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected O, but got Unknown
		if (!_isConnected)
		{
			return;
		}
		<AmIMuted>k__BackingField = isMute;
		bool flag = !isMute;
		object obj = !flag;
		object obj9;
		object obj12;
		object obj6;
		object obj8;
		if (obj == null)
		{
			bool flag2 = !isApplicationPaused;
			object obj2 = !flag2;
			if (obj2 == null && !game.IsSpectator)
			{
				object obj3 = typeof(UsageHint) + 1440;
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X8_v27+B8]");
				object obj5 = 0;
				obj6 = obj5;
				object obj7 = typeof(System.IOAsyncCallback) + 2104;
				obj8 = obj7;
				obj9 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X8_v4+12E]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X8_v4+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0232;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X8_v4+B0]");
				object obj11 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X10_v12-8]");
					if (0 == (nint)obj8)
					{
						break;
					}
					obj11 += 16;
					obj10--;
					if ((nint)obj10 != 1)
					{
						continue;
					}
					goto IL_0232;
				}
				obj12 = obj11 + 87;
				goto IL_0342;
			}
		}
		object obj13 = typeof(UsageHint) + 1440;
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v18+B8]");
		object obj15 = 0;
		obj6 = obj15;
		object obj16 = typeof(System.IOAsyncCallback) + 2104;
		obj8 = obj16;
		obj9 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X8_v4+12E]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X8_v4+12E]");
		if ((nint)0 == 0)
		{
			goto IL_013e;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X8_v4+B0]");
		object obj18 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X10_v7-8]");
			if (0 == (nint)obj8)
			{
				break;
			}
			obj18 += 16;
			obj17--;
			if ((nint)obj17 != 1)
			{
				continue;
			}
			goto IL_013e;
		}
		obj12 = obj18 + 86;
		goto IL_0342;
		IL_02da:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v298 @ X0_v6] (should have been resolved before IL gen)");
		SFS.SetVivoxMicStatus(<AmIMuted>k__BackingField);
		string arg = myDBId;
		Actions.SafeInvoke((Action<object>)this.OnMuteUpdate, arg);
		return;
		IL_0333:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_02da;
		IL_0232:
		nint num = 87;
		object obj19 = obj6;
		goto IL_0333;
		IL_013e:
		num = 86;
		obj19 = obj6;
		goto IL_0333;
		IL_0342:
		object obj20 = obj9 + obj12;
		object obj21 = obj20 + 312;
		goto IL_02da;
	}

	private void RefreshMyMuteStatus()
	{
		MuteMyself(<AmIMuted>k__BackingField);
	}

	private void InitVivox()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_01cb: Expected I, but got O
		//IL_00ec: Expected O, but got I
		//IL_0106: Expected O, but got I4
		//IL_004f: Expected O, but got I
		//IL_017c: Expected O, but got I
		//IL_019e: Expected O, but got I4
		//IL_0144: Expected O, but got I4
		//IL_00b1: Expected O, but got I
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)3032;
		object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3552;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7383]");
			object obj5 = (nint)0 & (nint)1;
			if (obj5 != null)
			{
				goto IL_006c;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7383]");
			object obj6 = (nint)0 & (nint)1;
			bool flag = obj6 == null;
			object obj7 = !flag;
			if (obj7 != null)
			{
				goto IL_006c;
			}
		}
		_ = 1;
		object obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v18+E4]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		object obj10 = obj8;
		if (obj9 != null)
		{
			goto IL_00a1;
		}
		goto IL_015a;
		IL_00a1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v18+B8]");
		object obj11 = 0;
		OneShotEvent oneShotEvent = (OneShotEvent)obj11;
		goto IL_00be;
		IL_00be:
		oneShotEvent.CallWhenReady(action);
		return;
		IL_015a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj12 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v9+B8]");
		object obj13 = 0;
		oneShotEvent = (OneShotEvent)obj13;
		bool flag3 = obj13 == null;
		object obj14 = !flag3;
		if (obj14 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00be;
		IL_006c:
		obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v18+E4]");
		bool flag4 = (nint)0 == 0;
		obj10 = obj8;
		if (!flag4)
		{
			goto IL_00a1;
		}
		goto IL_015a;
	}

	private void LoginToVivox(Task initTask)
	{
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected O, but got Unknown
		//IL_014b: Expected O, but got I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_0069: Expected O, but got I4
		//IL_0174: Expected O, but got I
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected O, but got Unknown
		//IL_035c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0361: Expected O, but got Unknown
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected O, but got Unknown
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected O, but got Unknown
		//IL_038d: Expected O, but got I
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected O, but got Unknown
		//IL_025b: Expected O, but got I
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dc: Expected O, but got Unknown
		//IL_03f2: Expected O, but got I
		//IL_0400: Expected I, but got O
		//IL_040f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0414: Expected O, but got Unknown
		//IL_043e: Expected O, but got I4
		//IL_0296: Expected O, but got I
		//IL_032f: Expected O, but got I
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Expected O, but got Unknown
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Expected O, but got Unknown
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Expected O, but got Unknown
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Expected O, but got Unknown
		if (initTask.IsFaulted)
		{
			object obj = typeof(DataRelation) + 856;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v40+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object message = "Unsupported map type" + 3080;
			Debug.LogError(message);
			AggregateException exception = initTask.Exception;
			Debug.LogException(exception);
			object obj4 = typeof(TrackedDeviceRaycaster.<>c) + 2216;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj5 = default(object);
			obj5..ctor();
			_ = 0;
			object obj6 = obj5 + 32;
			obj6 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Coroutine coroutine = StartCoroutine((IEnumerator)obj5);
			return;
		}
		object obj7 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3096;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		LoginOptions loginOptions = default(LoginOptions);
		loginOptions..ctor();
		object obj8 = typeof(Queue<string>) + 848;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X0_v8+E4]");
		bool flag2 = (nint)0 == 0;
		object obj10 = !flag2;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj11 = (nint)0 + (nint)2200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		string dbId = SFSKammelnaUserExtensions.GetDbId(localUser);
		object obj12 = loginOptions + 16;
		obj12 = dbId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel2 = default(SessionModel);
		User localUser2 = sessionModel2.LocalUser;
		string dbId2 = SFSKammelnaUserExtensions.GetDbId(localUser2);
		object obj13 = loginOptions + 24;
		obj13 = dbId2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = 5;
		object obj14 = typeof(UsageHint) + 1440;
		object obj15 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X8_v12+B8]");
		object obj16 = 0;
		object obj17 = obj16;
		object obj18 = typeof(System.IOAsyncCallback) + 2104;
		object obj19 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X8_v16+12E]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X8_v16+12E]");
		if ((nint)0 == 0)
		{
			goto IL_02d7;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X8_v16+B0]");
		object obj21 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X10_v5-8]");
			if (0 == (nint)obj18)
			{
				break;
			}
			obj21 += 16;
			obj20--;
			if ((nint)obj20 != 1)
			{
				continue;
			}
			goto IL_02d7;
		}
		object obj22 = obj21 + 66;
		object obj23 = obj19 + obj22;
		object obj24 = obj23 + 312;
		goto IL_03be;
		IL_03be:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v310 @ X0_v24] (should have been resolved before IL gen)");
		object obj25 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3648;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj26 = (nint)0 + (nint)3040;
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj26);
		object obj27 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		object obj28 = obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X0_v29+E4]");
		bool flag3 = (nint)0 == 0;
		object obj29 = !flag3;
		if (obj29 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj30 = (nint)0 + (nint)3408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FD04");
		return;
		IL_02d7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_03be;
	}

	private void JoinChannel(string channelName)
	{
		//IL_0250: Expected O, but got I4
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0276: Expected O, but got I
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0055: Expected O, but got I
		//IL_0090: Expected O, but got I
		//IL_02bf: Expected O, but got I
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		//IL_01f7: Expected O, but got I4
		//IL_011f: Expected O, but got I
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_0308: Expected O, but got I
		//IL_015a: Expected O, but got I
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected O, but got Unknown
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected O, but got Unknown
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected O, but got Unknown
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected O, but got Unknown
		bool flag = !isMakingAChannelConnection;
		object obj = !flag;
		if (obj != null)
		{
			return;
		}
		isMakingAChannelConnection = true;
		object obj2 = typeof(UsageHint) + 1440;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v6+B8]");
		object obj4 = 0;
		object obj5 = obj4;
		object obj6 = typeof(System.IOAsyncCallback) + 2104;
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v9+12E]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v9+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00d1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v9+B0]");
		object obj9 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X10_v13-8]");
			if (0 == (nint)obj6)
			{
				break;
			}
			obj9 += 16;
			obj8--;
			if ((nint)obj8 != 1)
			{
				continue;
			}
			goto IL_00d1;
		}
		object obj10 = obj9 + 44;
		object obj11 = obj7 + obj10;
		object obj12 = obj11 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v271 @ X0_v20] (should have been resolved before IL gen)");
		object obj13 = default(object);
		bool flag2 = obj13 == null;
		object obj14 = !flag2;
		if (obj14 != null)
		{
			goto IL_02a7;
		}
		return;
		IL_019b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_02f0;
		IL_00d1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v255 @ X0_v17] (should have been resolved before IL gen)");
		object obj15 = default(object);
		if (obj15 != null)
		{
			goto IL_02a7;
		}
		return;
		IL_02a7:
		object obj16 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X8_v13+B8]");
		object obj17 = 0;
		object obj18 = obj17;
		object obj19 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X8_v15+12E]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X8_v15+12E]");
		if ((nint)0 == 0)
		{
			goto IL_019b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X8_v15+B0]");
		object obj21 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X10_v8-8]");
			if (0 == (nint)obj6)
			{
				break;
			}
			obj21 += 16;
			obj20--;
			if ((nint)obj20 != 1)
			{
				continue;
			}
			goto IL_019b;
		}
		object obj22 = obj21 + 68;
		object obj23 = obj19 + obj22;
		object obj24 = obj23 + 312;
		goto IL_02f0;
		IL_02f0:
		object obj25 = obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X0_v8+8]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v147 @ X5_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public void DestroySelf()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00e1: Expected O, but got I4
		//IL_00f2: Expected O, but got I4
		//IL_008a: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E72C9]");
		object obj3 = (nint)0 & (nint)1;
		GameObject gameObject;
		UnityEngine.Object obj5;
		if (obj3 != null)
		{
			gameObject = base.gameObject;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = gameObject;
			object obj6 = 0;
			if (!flag)
			{
				goto IL_0098;
			}
		}
		else
		{
			_ = 1;
			gameObject = base.gameObject;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = gameObject;
			object obj6 = 0;
			if (obj7 != null)
			{
				goto IL_0098;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object.Destroy(gameObject);
		return;
		IL_0098:
		UnityEngine.Object.Destroy(obj5);
	}

	private IEnumerator RestartVivox()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 2216;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		object obj3 = obj2 + 32;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (IEnumerator)obj2;
	}

	private void DestroyVivox(bool fireEvent)
	{
		//IL_0016: Expected O, but got I
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		//IL_0115: Expected O, but got I
		//IL_012f: Expected O, but got I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_005d: Expected O, but got I
		//IL_0175: Expected O, but got I4
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected O, but got Unknown
		//IL_022c: Expected O, but got I4
		//IL_0280: Expected O, but got I
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected O, but got Unknown
		//IL_03a9: Expected O, but got I
		//IL_03b9: Expected O, but got I
		//IL_03db: Expected O, but got I4
		//IL_03f3: Expected O, but got I
		//IL_0339: Expected O, but got I
		//IL_0341: Expected I, but got O
		//IL_0374: Expected O, but got I4
		//IL_02e0: Expected O, but got I
		//IL_02f0: Expected O, but got I
		//IL_031f: Expected O, but got I
		//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_04af: Expected O, but got Unknown
		//IL_0423: Expected O, but got I4
		//IL_0d09: Expected O, but got I
		//IL_0c90: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c95: Expected O, but got Unknown
		//IL_0cab: Expected O, but got I
		//IL_0cbc: Expected I, but got O
		//IL_0cda: Expected O, but got I
		//IL_04c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c8: Expected O, but got Unknown
		//IL_04e0: Expected O, but got I
		//IL_0464: Expected O, but got I
		//IL_046c: Expected I, but got O
		//IL_048c: Expected O, but got I4
		//IL_0453: Expected O, but got I
		//IL_051b: Expected O, but got I
		//IL_0e13: Expected O, but got I
		//IL_057d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0582: Expected O, but got Unknown
		//IL_0598: Unknown result type (might be due to invalid IL or missing references)
		//IL_059d: Expected O, but got Unknown
		//IL_0743: Expected O, but got I
		//IL_0d83: Expected O, but got I
		//IL_0529: Unknown result type (might be due to invalid IL or missing references)
		//IL_052e: Expected O, but got Unknown
		//IL_0537: Unknown result type (might be due to invalid IL or missing references)
		//IL_053c: Expected O, but got Unknown
		//IL_07ed: Expected O, but got I4
		//IL_05bf: Expected O, but got I
		//IL_077e: Expected O, but got I
		//IL_0e8c: Expected O, but got I
		//IL_0dc4: Expected O, but got I
		//IL_05fa: Expected O, but got I
		//IL_0890: Expected O, but got I
		//IL_082c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0831: Expected O, but got Unknown
		//IL_0847: Unknown result type (might be due to invalid IL or missing references)
		//IL_084c: Expected O, but got Unknown
		//IL_0946: Expected O, but got I
		//IL_0956: Expected O, but got I
		//IL_0978: Expected O, but got I4
		//IL_078c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0791: Expected O, but got Unknown
		//IL_079a: Unknown result type (might be due to invalid IL or missing references)
		//IL_079f: Expected O, but got Unknown
		//IL_0691: Expected O, but got I
		//IL_06a1: Expected O, but got I
		//IL_065c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0661: Expected O, but got Unknown
		//IL_0677: Unknown result type (might be due to invalid IL or missing references)
		//IL_067c: Expected O, but got Unknown
		//IL_0ecd: Expected O, but got I
		//IL_08cb: Expected O, but got I
		//IL_09a8: Expected O, but got I4
		//IL_0608: Unknown result type (might be due to invalid IL or missing references)
		//IL_060d: Expected O, but got Unknown
		//IL_0616: Unknown result type (might be due to invalid IL or missing references)
		//IL_061b: Expected O, but got Unknown
		//IL_0b72: Expected O, but got I
		//IL_0b82: Expected O, but got I
		//IL_0ba4: Expected O, but got I4
		//IL_070f: Expected O, but got I
		//IL_0717: Expected I, but got O
		//IL_0f13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f18: Expected O, but got Unknown
		//IL_0f2e: Expected O, but got I
		//IL_0f36: Expected I, but got O
		//IL_0f47: Expected I, but got O
		//IL_0f65: Expected O, but got I
		//IL_0a9c: Expected O, but got I
		//IL_0aac: Expected O, but got I
		//IL_0a67: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6c: Expected O, but got Unknown
		//IL_0a82: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a87: Expected O, but got Unknown
		//IL_0a07: Expected O, but got I4
		//IL_0a10: Expected O, but got I4
		//IL_0a21: Expected O, but got I4
		//IL_09d8: Expected O, but got I
		//IL_0bd4: Expected O, but got I4
		//IL_08d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08de: Expected O, but got Unknown
		//IL_08e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ec: Expected O, but got Unknown
		//IL_0b12: Expected O, but got I
		//IL_0b32: Expected O, but got I4
		//IL_0f8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f90: Expected O, but got Unknown
		//IL_0fa6: Expected O, but got I
		//IL_0fae: Expected I, but got O
		//IL_0fbf: Expected I, but got O
		//IL_0fdd: Expected O, but got I
		//IL_0c33: Expected O, but got I4
		//IL_0c44: Expected O, but got I4
		//IL_0c04: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7390]");
		object obj = (nint)0 & (nint)1;
		object obj2;
		object obj4;
		if (obj != null)
		{
			obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7389]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			obj4 = obj2;
			if (!flag)
			{
				goto IL_0082;
			}
		}
		else
		{
			_ = 1;
			obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7389]");
			object obj5 = (nint)0 & (nint)1;
			bool flag2 = obj5 == null;
			object obj6 = !flag2;
			obj4 = obj2;
			if (obj6 != null)
			{
				goto IL_0082;
			}
		}
		_ = 1;
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v120+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		obj2 = obj4;
		if (obj8 != null)
		{
			goto IL_00b7;
		}
		goto IL_018b;
		IL_0e44:
		_isConnected = false;
		Actions.SafeInvoke(this.OnConnectionUpdate, arg: false);
		goto IL_0e64;
		IL_07bf:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v653 @ X0_v56] (should have been resolved before IL gen)");
		object obj9 = default(object);
		bool flag4 = obj9 == null;
		object obj10 = !flag4;
		nint num = 44;
		if (obj10 == null)
		{
			goto IL_0804;
		}
		goto IL_0e74;
		IL_0e64:
		isMakingAConnection = false;
		return;
		IL_0082:
		obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v120+E4]");
		bool flag5 = (nint)0 == 0;
		obj4 = obj2;
		if (!flag5)
		{
			goto IL_00b7;
		}
		goto IL_018b;
		IL_018b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Platform platform = KUtil.GetPlatform();
		bool flag6 = platform == Platform.Web;
		obj2 = obj4;
		if (!flag6)
		{
			goto IL_01c8;
		}
		return;
		IL_00b7:
		Platform platform2 = KUtil.GetPlatform();
		if (platform2 == Platform.Web)
		{
			return;
		}
		goto IL_01c8;
		IL_01c8:
		object obj11 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v3+E4]");
		if ((nint)0 != 0)
		{
			RuntimePlatform platform3 = Application.platform;
			bool flag7 = platform3 == RuntimePlatform.OSXEditor;
			object obj13 = !flag7;
			if (obj13 == null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (Application.platform == RuntimePlatform.OSXEditor)
			{
				return;
			}
		}
		object obj14 = (nint)0 + (nint)1784;
		Dictionary<object, object>.ValueCollection values = ((Dictionary<object, object>)(object)_listeners).Values;
		object obj15 = typeof(TrackedDeviceRaycaster.<>c) + 2200;
		object obj16 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X8_v99+E4]");
		object obj17;
		Action<object> action;
		IEnumerable<object> enumeration;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X8_v99+B8]");
			obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X9_v45+8]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X9_v45+8]");
			bool flag8 = (nint)0 == 0;
			enumeration = values;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X9_v45+8]");
			Action<object> action2 = (Action<object>)0;
			if (!flag8)
			{
				goto IL_032d;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj16 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X8_v99+B8]");
			obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X9_v45+8]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X9_v45+8]");
			bool flag9 = (nint)0 == 0;
			object obj18 = !flag9;
			enumeration = values;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X9_v45+8]");
			Action<object> action2 = (Action<object>)0;
			if (obj18 != null)
			{
				goto IL_032d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X8_v99+E4]");
		bool flag10 = (nint)0 == 0;
		object obj19 = !flag10;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj20 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ X8_v108+B8]");
			obj17 = 0;
		}
		object obj21 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj22 = (nint)0 + (nint)3112;
		Action<object> action3 = default(Action<object>);
		action3..ctor(obj17, (IntPtr)obj22);
		object obj23 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X8_v105+B8]");
		object obj24 = (nint)0 + (nint)8;
		obj24 = action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj25 = (nint)0 + (nint)2440;
		num = (nint)obj25;
		ArraysExtensions.ForEach(values, action3);
		Dictionary<object, object> listeners = (Dictionary<object, object>)(object)_listeners;
		object obj26 = 0;
		goto IL_0491;
		IL_0b06:
		object obj27 = (nint)0 + (nint)3408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FD04");
		bool flag11 = !fireEvent;
		object obj28 = !flag11;
		if (obj28 != null)
		{
			goto IL_0e44;
		}
		goto IL_0b40;
		IL_0db4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v709 @ X0_v66+8]");
		Action<object> action4 = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v709 @ X0_v66] (should have been resolved before IL gen)");
		object obj29 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v845 @ X0_v72+E4]");
		object obj30;
		Action<object> action5;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v845 @ X0_v72+B8]");
			obj30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v890 @ X8_v79+10]");
			action5 = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v890 @ X8_v79+10]");
			if ((nint)0 != 0)
			{
				goto IL_06c6;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj29 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v845 @ X0_v72+B8]");
			obj30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v890 @ X8_v79+10]");
			action5 = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v890 @ X8_v79+10]");
			bool flag12 = (nint)0 == 0;
			object obj31 = !flag12;
			if (obj31 != null)
			{
				goto IL_06c6;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v845 @ X0_v72+E4]");
		bool flag13 = (nint)0 == 0;
		object obj32 = !flag13;
		if (obj32 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj33 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X8_v86+B8]");
			obj30 = 0;
		}
		object obj34 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3648;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj35 = (nint)0 + (nint)3120;
		num = (nint)obj35;
		Action<object> action6 = default(Action<object>);
		action6..ctor(obj30, (IntPtr)obj35);
		object obj36 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v950 @ X8_v84+B8]");
		object obj37 = (nint)0 + (nint)16;
		obj37 = action6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj38 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v887 @ X0_v70+E4]");
		bool flag14 = (nint)0 == 0;
		object obj39 = !flag14;
		obj26 = 0;
		action5 = action6;
		object obj40 = 0;
		Action<object> action7 = action6;
		action4 = action6;
		if (obj39 != null)
		{
			goto IL_0703;
		}
		goto IL_0a3f;
		IL_063b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num = 71;
		goto IL_0db4;
		IL_0a3f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj26 = obj40;
		action5 = action7;
		goto IL_0703;
		IL_0e74:
		object obj42;
		object obj41 = obj42;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v832 @ X8_v34+B8]");
		object obj43 = 0;
		object obj44 = obj43;
		object obj45 = obj44;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v862 @ X8_v36+12E]");
		object obj46 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v862 @ X8_v36+12E]");
		if ((nint)0 == 0)
		{
			goto IL_090c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v862 @ X8_v36+B0]");
		object obj47 = (nint)0 + (nint)8;
		object obj48;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v930 @ X10_v13-8]");
			if (0 == (nint)obj48)
			{
				break;
			}
			obj47 += 16;
			obj46--;
			if ((nint)obj46 != 1)
			{
				continue;
			}
			goto IL_090c;
		}
		object obj49 = obj47 + 67;
		object obj50 = obj45 + obj49;
		object obj51 = obj50 + 312;
		goto IL_0ebd;
		IL_0ad1:
		object obj52 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1017 @ X0_v25+E4]");
		bool flag15 = (nint)0 == 0;
		Action<object> action9;
		Action<object> action8 = action9;
		if (!flag15)
		{
			goto IL_0b06;
		}
		goto IL_0c62;
		IL_06c6:
		obj38 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v887 @ X0_v70+E4]");
		bool flag16 = (nint)0 == 0;
		obj40 = obj26;
		action7 = action5;
		if (!flag16)
		{
			goto IL_0703;
		}
		goto IL_0a3f;
		IL_0804:
		if (!fireEvent)
		{
			goto IL_0b40;
		}
		goto IL_0e44;
		IL_032d:
		object obj53 = (nint)0 + (nint)2440;
		num = (nint)obj53;
		ArraysExtensions.ForEach(enumeration, action);
		listeners = (Dictionary<object, object>)(object)_listeners;
		bool flag17 = _listeners == null;
		object obj54 = !flag17;
		if (obj54 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0491;
		IL_0491:
		listeners.Clear();
		obj42 = typeof(UsageHint) + 1440;
		object obj55 = obj42;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X8_v16+B8]");
		object obj56 = 0;
		object obj57 = obj56;
		obj48 = typeof(System.IOAsyncCallback) + 2104;
		object obj58 = obj57;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ X8_v18+12E]");
		object obj59 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ X8_v18+12E]");
		if ((nint)0 == 0)
		{
			goto IL_055c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ X8_v18+B0]");
		object obj60 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X10_v31-8]");
			if (0 == (nint)obj48)
			{
				break;
			}
			obj60 += 16;
			obj59--;
			if ((nint)obj59 != 1)
			{
				continue;
			}
			goto IL_055c;
		}
		object obj61 = obj60 + 50;
		object obj62 = obj58 + obj61;
		object obj63 = obj62 + 312;
		goto IL_0d3a;
		IL_0703:
		object obj64 = (nint)0 + (nint)3408;
		num = (nint)obj64;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FD04");
		goto IL_0dfb;
		IL_0dfb:
		object obj65 = obj42;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X8_v26+B8]");
		object obj66 = 0;
		object obj67 = obj66;
		object obj68 = obj67;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v593 @ X8_v28+12E]");
		object obj69 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v593 @ X8_v28+12E]");
		if ((nint)0 == 0)
		{
			goto IL_07bf;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v593 @ X8_v28+B0]");
		object obj70 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v676 @ X10_v20-8]");
			if (0 == (nint)obj48)
			{
				break;
			}
			obj70 += 16;
			obj69--;
			if ((nint)obj69 != 1)
			{
				continue;
			}
			goto IL_07bf;
		}
		object obj71 = obj70 + 44;
		object obj72 = obj68 + obj71;
		object obj73 = obj72 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v722 @ X0_v59] (should have been resolved before IL gen)");
		object obj74 = default(object);
		if (obj74 == null)
		{
			goto IL_0804;
		}
		goto IL_0e74;
		IL_090c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num = 67;
		goto IL_0ebd;
		IL_0b40:
		_isConnected = false;
		goto IL_0e64;
		IL_055c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num = 50;
		goto IL_0d3a;
		IL_0d3a:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v533 @ X0_v11] (should have been resolved before IL gen)");
		IEnumerable<KeyValuePair<object, object>> source = default(IEnumerable<KeyValuePair<object, object>>);
		if (Enumerable.Any(source))
		{
			object obj75 = obj42;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ X8_v71+B8]");
			object obj76 = 0;
			object obj77 = obj76;
			object obj78 = obj77;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X8_v73+12E]");
			object obj79 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X8_v73+12E]");
			if ((nint)0 == 0)
			{
				goto IL_063b;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X8_v73+B0]");
			object obj80 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v655 @ X10_v26-8]");
				if (0 == (nint)obj48)
				{
					break;
				}
				obj80 += 16;
				obj79--;
				if ((nint)obj79 != 1)
				{
					continue;
				}
				goto IL_063b;
			}
			object obj81 = obj80 + 71;
			object obj82 = obj78 + obj81;
			object obj83 = obj82 + 312;
			goto IL_0db4;
		}
		goto IL_0dfb;
		IL_0ebd:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v961 @ X0_v21+8]");
		Action<object> action10 = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v961 @ X0_v21] (should have been resolved before IL gen)");
		object obj84 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v987 @ X0_v27+E4]");
		object obj85;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v987 @ X0_v27+B8]");
			obj85 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1020 @ X8_v42+18]");
			action9 = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1020 @ X8_v42+18]");
			if ((nint)0 != 0)
			{
				goto IL_0ad1;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj84 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v987 @ X0_v27+B8]");
			obj85 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1020 @ X8_v42+18]");
			action9 = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1020 @ X8_v42+18]");
			bool flag18 = (nint)0 == 0;
			object obj86 = !flag18;
			if (obj86 != null)
			{
				goto IL_0ad1;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v987 @ X0_v27+E4]");
		bool flag19 = (nint)0 == 0;
		object obj87 = !flag19;
		if (obj87 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj88 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1027 @ X8_v49+B8]");
			obj85 = 0;
		}
		object obj89 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3648;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj90 = (nint)0 + (nint)3128;
		num = (nint)obj90;
		Action<object> action11 = default(Action<object>);
		action11..ctor(obj85, (IntPtr)obj90);
		object obj91 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1031 @ X8_v47+B8]");
		object obj92 = (nint)0 + (nint)24;
		obj92 = action11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj52 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1017 @ X0_v25+E4]");
		bool flag20 = (nint)0 == 0;
		object obj93 = !flag20;
		action9 = action11;
		obj26 = 0;
		action8 = action11;
		action10 = action11;
		if (obj93 != null)
		{
			goto IL_0b06;
		}
		goto IL_0c62;
		IL_0c62:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		action9 = action8;
		goto IL_0b06;
	}

	private void ParticipantAddedToChannel(VivoxParticipant vivoxParticipant)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_007b: Expected O, but got I
		//IL_00a9: Expected I, but got O
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 2208;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 24;
		obj4 = vivoxParticipant;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3672;
		object obj6 = (nint)0 + (nint)3136;
		string displayName = ((VivoxParticipant)obj4).DisplayName;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, object> func = default(Func<object, object>);
		func..ctor(obj2, (IntPtr)obj6);
		object orPut = DictionaryExtensions.GetOrPut((IDictionary<object, object>)_listeners, displayName, func);
	}

	private void ParticipantRemovedFromChannel(VivoxParticipant vivoxParticipant)
	{
		//IL_0023: Expected O, but got I
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0090: Expected O, but got I
		//IL_00e4: Expected I, but got O
		//IL_00aa: Expected O, but got I
		string displayName = vivoxParticipant.DisplayName;
		object obj = (nint)0 + (nint)1776;
		if (((Dictionary<object, object>)(object)_listeners).TryGetValue((object)displayName, out object value))
		{
			if (value != null)
			{
				object obj2 = typeof(SqlSingle[]) + 2376;
				object obj3 = (nint)0 + (nint)3152;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				Action action = default(Action);
				action..ctor(value, (IntPtr)obj3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ stack_-48_v3 (System.Object)+18]");
				((VivoxParticipant)0).ParticipantAudioEnergyChanged -= action;
			}
			bool flag = ((Dictionary<object, object>)(object)_listeners).Remove((object)displayName);
		}
	}

	private void TriggerSpeakingInChat(string displayName, double audioEnergy)
	{
		Action<string, float?> onSpeakingInChat = this.OnSpeakingInChat;
		if (this.OnSpeakingInChat != null)
		{
			float? num = (float)audioEnergy;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v48 @ X20_v2 (System.Action`2<System.String, System.Nullable`1<System.Single>>)+18] (should have been resolved before IL gen)");
		}
	}

	private void OnChannelJoined(string channelName)
	{
		//IL_02bc: Expected O, but got I
		//IL_0018: Expected O, but got I4
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected I4, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_02d9: Expected O, but got I
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_00d0: Expected O, but got I
		//IL_0171: Expected O, but got I
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected O, but got Unknown
		//IL_0191: Expected O, but got I
		//IL_019d: Expected O, but got I
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected O, but got Unknown
		//IL_010b: Expected O, but got I
		//IL_01d8: Expected I, but got O
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected O, but got Unknown
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Expected O, but got Unknown
		//IL_0290: Expected O, but got I4
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		isMakingAChannelConnection = false;
		object obj = (nint)0 + (nint)2056;
		_isConnected = true;
		Actions.SafeInvoke(this.OnConnectionUpdate, arg: true);
		KGame kGame = game;
		object obj2 = kGame.<MySeatIndex>k__BackingField - 1;
		bool flag = (nint)obj2 < 0;
		int num = kGame.<MySeatIndex>k__BackingField ^ 1;
		int num2 = kGame.<MySeatIndex>k__BackingField ^ obj2;
		int num3 = num & num2;
		bool flag2 = num3 < 0;
		bool flag3 = flag == flag2;
		bool isMute = !flag3;
		MuteMyself(isMute);
		object obj3 = typeof(UsageHint) + 1440;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v11+B8]");
		object obj5 = 0;
		object obj6 = obj5;
		object obj7 = typeof(System.IOAsyncCallback) + 2104;
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v15+12E]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v15+12E]");
		if ((nint)0 == 0)
		{
			goto IL_014c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v15+B0]");
		object obj10 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X10_v6-8]");
			if (0 == (nint)obj7)
			{
				break;
			}
			obj10 += 16;
			obj9--;
			if ((nint)obj9 != 1)
			{
				continue;
			}
			goto IL_014c;
		}
		object obj11 = obj10 + 50;
		object obj12 = obj8 + obj11;
		object obj13 = obj12 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v275 @ X0_v22] (should have been resolved before IL gen)");
		object obj14 = default(object);
		bool flag4 = obj14 == null;
		object obj15 = !flag4;
		if (obj15 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0165;
		IL_0165:
		object obj16 = (nint)0 + (nint)3336;
		object obj17 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 4016;
		object obj18 = (nint)0 + (nint)3112;
		object obj19 = (nint)0 + (nint)2424;
		object obj20 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3C13630");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj18);
		IEnumerable<object> enumeration = default(IEnumerable<object>);
		ArraysExtensions.ForEach(enumeration, action);
		ITrackEvent trackEvent = TrackerLibrary.GameVoiceJoined();
		object obj21 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X8_v19+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
		return;
		IL_014c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v259 @ X0_v19] (should have been resolved before IL gen)");
		goto IL_0165;
	}

	private void OnChannelLeft(string channelName)
	{
		DestroyVivox(fireEvent: true);
	}

	private void OnUserLoggedIn()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Expected O, but got Unknown
		//IL_0256: Expected O, but got I4
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_008d: Expected I, but got O
		//IL_009d: Expected O, but got I
		//IL_02a1: Expected O, but got I4
		//IL_00d8: Expected O, but got I
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected O, but got Unknown
		//IL_0188: Expected I4, but got O
		//IL_0190: Expected I4, but got O
		//IL_01fb: Expected O, but got I4
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected O, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		object obj2 = typeof(RegisteredWaitHandle) + 3776;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ServerEnvironment environment = Config.Environment;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		string serverID = Config.ServerID;
		Room room = game.Room;
		object obj5 = typeof(RegisteredWaitHandle) + 1376;
		object format = "{0} color encoding is currently unsupported for outputting to HDR." + 1296;
		nint num = (nint)room;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0119;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj7 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X10_v6-8]");
			if (0 == (nint)obj5)
			{
				break;
			}
			obj7 += 16;
			obj6--;
			if ((nint)obj6 != 1)
			{
				continue;
			}
			goto IL_0119;
		}
		object obj8 = num + obj7;
		object obj9 = obj8 + 312;
		goto IL_0288;
		IL_0288:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v260 @ X8_v8] (should have been resolved before IL gen)");
		object obj10 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj11 = default(object);
		object obj12 = default(object);
		string text = string.Format((string)format, obj11, serverID, obj12);
		object obj13 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2504;
		bool flag2 = text._stringLength < 257;
		object obj14 = obj12;
		int num2 = (int)serverID;
		int num3 = (int)obj11;
		if (!flag2)
		{
			text = text.Substring(0, 256);
			obj14 = null;
			num2 = 256;
			num3 = 0;
		}
		object obj15 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v14+E4]");
		bool flag3 = (nint)0 == 0;
		object obj16 = !flag3;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string channelName = StringUtil.SanitizeChatMessage(text);
		JoinChannel(channelName);
		return;
		IL_0119:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj17 = default(object);
		obj9 = obj17;
		goto IL_0288;
	}

	public VivoxManager()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 2992;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<object, object> dictionary = default(Dictionary<object, object>);
		dictionary..ctor();
		object obj2 = this + 72;
		obj2 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}

	private void <StartNewCall>b__35_0(bool isMicrophonePermissionGranted)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0082: Expected O, but got I4
		if (isMicrophonePermissionGranted)
		{
			InitVivox();
			return;
		}
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object title = "October" + 3800;
		object body = "COORDINATE_TYPE_GCJ_02" + 2040;
		object buttonText = "Network Authentication Required" + 3128;
		DestroyVivox(fireEvent: true);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.ShowInfo((string)title, (string)body, (string)buttonText);
	}

	private void <InitVivox>b__42_0()
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected O, but got Unknown
		//IL_01eb: Expected O, but got I
		//IL_0205: Expected O, but got I4
		//IL_00a3: Expected O, but got I
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0066: Expected O, but got I
		//IL_0239: Expected O, but got I
		//IL_025b: Expected O, but got I4
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_0104: Expected O, but got I
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_0130: Expected O, but got I
		//IL_030c: Expected O, but got I
		//IL_032e: Expected I, but got O
		//IL_0358: Expected O, but got I4
		//IL_016b: Expected O, but got I
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Expected O, but got Unknown
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Expected O, but got Unknown
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected O, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		object obj = 152989696;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E72CE]");
		object obj2 = (nint)0 & (nint)1;
		object obj5;
		object obj3;
		if (obj2 != null)
		{
			obj3 = typeof(UsageHint) + 1440;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45D3]");
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
			obj3 = typeof(UsageHint) + 1440;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45D3]");
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
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v10+B8]");
		object obj9 = 0;
		object obj10 = obj9;
		bool flag3 = obj9 == null;
		object obj11 = !flag3;
		obj3 = obj5;
		object obj12 = obj9;
		if (obj11 != null)
		{
			goto IL_00d0;
		}
		goto IL_0279;
		IL_0300:
		object obj13 = (nint)0 + (nint)3408;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v196 @ X0_v1] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		object obj14;
		action..ctor((object)this, (IntPtr)obj14);
		object obj16;
		object obj15 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X0_v6+E4]");
		bool flag4 = (nint)0 == 0;
		object obj17 = !flag4;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FD04");
		return;
		IL_01ac:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0300;
		IL_00d0:
		object obj18 = typeof(System.IOAsyncCallback) + 2104;
		obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3648;
		obj14 = (nint)0 + (nint)3056;
		obj16 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		obj9 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v5+12E]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v5+12E]");
		if ((nint)0 == 0)
		{
			goto IL_01ac;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v5+B0]");
		object obj20 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X10_v2-8]");
			bool flag5 = 0 == (nint)obj18;
			obj12 = obj10;
			if (flag5)
			{
				break;
			}
			obj20 += 16;
			obj19--;
			if ((nint)obj19 != 1)
			{
				continue;
			}
			goto IL_01ac;
		}
		object obj21 = obj20 + 65;
		object obj22 = obj9 + obj21;
		object obj23 = obj22 + 312;
		obj10 = obj12;
		goto IL_0300;
		IL_008b:
		object obj24 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v19+B8]");
		obj9 = 0;
		obj10 = obj9;
		bool flag6 = obj9 == null;
		obj12 = obj9;
		if (!flag6)
		{
			goto IL_00d0;
		}
		goto IL_0279;
		IL_0279:
		throw new NullReferenceException();
	}

	private void <LoginToVivox>b__43_0(Task loginTask)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_0069: Expected O, but got I4
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		if (loginTask.IsFaulted)
		{
			object obj = typeof(DataRelation) + 856;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object message = "Unsupported map type" + 3104;
			Debug.LogError(message);
			AggregateException exception = loginTask.Exception;
			Debug.LogException(exception);
			object obj4 = typeof(TrackedDeviceRaycaster.<>c) + 2216;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj5 = default(object);
			obj5..ctor();
			_ = 0;
			object obj6 = obj5 + 32;
			obj6 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Coroutine coroutine = StartCoroutine((IEnumerator)obj5);
		}
	}
}
