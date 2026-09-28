using System;
using System.Diagnostics;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class VivoxMuteButton : MonoBehaviour
{
	private Image icon;

	private Sprite connectedIcon;

	private Sprite disconnectedIcon;

	private Sprite listeningIcon;

	private Sprite notListeningIcon;

	private TextMeshProUGUI text;

	private const string MuteYourVoice = "Silence Your Voice";

	private const string NotConnected = "Not connected";

	private const string YouAreListener = "Your are a listener";

	private Button button;

	private VivoxManager manager;

	private KGame game;

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00b9: Expected O, but got I
		//IL_00c5: Expected O, but got I
		//IL_00d1: Expected O, but got I
		//IL_00fb: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)136;
		object obj3 = (nint)0 + (nint)248;
		object obj4 = (nint)0 + (nint)3640;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj7 = this + 96;
		object obj8 = default(object);
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj9 = this + 88;
		object obj10 = default(object);
		obj9 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj11 = this + 80;
		object obj12 = default(object);
		obj11 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private void Start()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		RefreshUI();
		Button button = this.button;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)3152;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		button.m_OnClick.AddListener(unityAction);
		RegisterEventsListener();
	}

	private void OnDestroy()
	{
		UnRegisterEventsListener();
	}

	private void RegisterEventsListener()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_01dd: Expected I, but got O
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected O, but got Unknown
		//IL_0202: Expected O, but got I
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected O, but got Unknown
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected O, but got Unknown
		//IL_0033: Expected O, but got I4
		//IL_0092: Expected O, but got I4
		//IL_00d3: Expected I, but got O
		//IL_00b1: Expected O, but got I4
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Expected O, but got Unknown
		//IL_00ee: Expected O, but got I4
		//IL_02af: Expected O, but got I4
		//IL_014d: Expected O, but got I4
		//IL_0156: Expected O, but got I4
		//IL_01a2: Expected O, but got I
		//IL_01b0: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj2 = (nint)0 + (nint)3136;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		object obj4 = (nint)0 + (nint)3128;
		object obj5 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1200;
		object obj6 = manager + 48;
		Delegate obj7 = (Delegate)obj6;
		object obj10 = default(object);
		object obj11 = default(object);
		Delegate obj15 = default(Delegate);
		Action<bool> action2 = default(Action<bool>);
		object obj21 = default(object);
		Delegate obj23 = default(Delegate);
		KGame.PlayerSwitchSeatDelegate playerSwitchSeatDelegate = default(KGame.PlayerSwitchSeatDelegate);
		object obj20;
		while (true)
		{
			Delegate obj8 = Delegate.Combine(obj7, action);
			if ((object)obj8 == null)
			{
				object obj9 = 0;
			}
			else
			{
				obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag = obj11 == null;
				object obj12 = !flag;
				object obj9 = obj11;
				if (obj12 == null)
				{
					object obj13 = 0;
					Delegate obj14 = null;
					break;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
			bool flag2 = (object)obj15 == obj7;
			obj7 = obj15;
			if (!flag2)
			{
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			action2..ctor((object)this, (IntPtr)obj4);
			object obj16 = manager + 56;
			Delegate obj17 = (Delegate)obj16;
			while (true)
			{
				Delegate obj18 = Delegate.Combine(obj17, action2);
				object obj19;
				object obj13;
				Delegate obj14;
				if ((object)obj18 == null)
				{
					obj19 = obj10;
					obj20 = 0;
				}
				else
				{
					obj10 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag3 = obj21 == null;
					object obj22 = !flag3;
					obj13 = 0;
					obj14 = null;
					obj19 = obj3;
					obj20 = obj21;
					if (obj22 == null)
					{
						break;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj23 == obj17;
				obj10 = obj19;
				obj17 = obj23;
				obj13 = 0;
				obj14 = obj23;
				if (flag4)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj24 = (nint)0 + (nint)3144;
					playerSwitchSeatDelegate..ctor(this, (IntPtr)obj24);
					game.OnPlayerSwitchSeat += playerSwitchSeatDelegate;
					return;
				}
			}
			break;
		}
		obj20 = obj10;
		throw new InvalidCastException();
	}

	private void UnRegisterEventsListener()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_01dd: Expected I, but got O
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected O, but got Unknown
		//IL_0202: Expected O, but got I
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected O, but got Unknown
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected O, but got Unknown
		//IL_0033: Expected O, but got I4
		//IL_0092: Expected O, but got I4
		//IL_00d3: Expected I, but got O
		//IL_00b1: Expected O, but got I4
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Expected O, but got Unknown
		//IL_00ee: Expected O, but got I4
		//IL_02af: Expected O, but got I4
		//IL_014d: Expected O, but got I4
		//IL_0156: Expected O, but got I4
		//IL_01a2: Expected O, but got I
		//IL_01b0: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj2 = (nint)0 + (nint)3136;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		object obj4 = (nint)0 + (nint)3128;
		object obj5 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1200;
		object obj6 = manager + 48;
		Delegate obj7 = (Delegate)obj6;
		object obj10 = default(object);
		object obj11 = default(object);
		Delegate obj15 = default(Delegate);
		Action<bool> action2 = default(Action<bool>);
		object obj21 = default(object);
		Delegate obj23 = default(Delegate);
		KGame.PlayerSwitchSeatDelegate playerSwitchSeatDelegate = default(KGame.PlayerSwitchSeatDelegate);
		object obj20;
		while (true)
		{
			Delegate obj8 = Delegate.Remove(obj7, action);
			if ((object)obj8 == null)
			{
				object obj9 = 0;
			}
			else
			{
				obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag = obj11 == null;
				object obj12 = !flag;
				object obj9 = obj11;
				if (obj12 == null)
				{
					object obj13 = 0;
					Delegate obj14 = null;
					break;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
			bool flag2 = (object)obj15 == obj7;
			obj7 = obj15;
			if (!flag2)
			{
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			action2..ctor((object)this, (IntPtr)obj4);
			object obj16 = manager + 56;
			Delegate obj17 = (Delegate)obj16;
			while (true)
			{
				Delegate obj18 = Delegate.Remove(obj17, action2);
				object obj19;
				object obj13;
				Delegate obj14;
				if ((object)obj18 == null)
				{
					obj19 = obj10;
					obj20 = 0;
				}
				else
				{
					obj10 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag3 = obj21 == null;
					object obj22 = !flag3;
					obj13 = 0;
					obj14 = null;
					obj19 = obj3;
					obj20 = obj21;
					if (obj22 == null)
					{
						break;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj23 == obj17;
				obj10 = obj19;
				obj17 = obj23;
				obj13 = 0;
				obj14 = obj23;
				if (flag4)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj24 = (nint)0 + (nint)3144;
					playerSwitchSeatDelegate..ctor(this, (IntPtr)obj24);
					game.OnPlayerSwitchSeat -= playerSwitchSeatDelegate;
					return;
				}
			}
			break;
		}
		obj20 = obj10;
		throw new InvalidCastException();
	}

	private void ToggleMuteMyself()
	{
		//IL_001d: Expected O, but got I4
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected I4, but got Unknown
		VivoxManager vivoxManager = manager;
		object obj = ~(vivoxManager.<AmIMuted>k__BackingField ? 1 : 0);
		bool isMute = (byte)(1 & obj) != 0;
		vivoxManager.MuteMyself(isMute);
	}

	private void RefreshUI(int i, string s)
	{
		RefreshUI();
	}

	private void RefreshUI(string s)
	{
		RefreshUI();
	}

	private void RefreshUI(bool isConnected)
	{
		RefreshUI();
	}

	private void RefreshUI()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00d6: Expected O, but got I4
		//IL_0118: Expected O, but got I4
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected O, but got Unknown
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected O, but got Unknown
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected O, but got Unknown
		//IL_0214: Expected O, but got I4
		//IL_02ee: Expected O, but got I4
		//IL_0305: Expected O, but got I
		//IL_0364: Expected O, but got I4
		//IL_037b: Expected O, but got I
		//IL_02a5: Expected O, but got I4
		//IL_02bc: Expected O, but got I
		//IL_0343: Expected O, but got I4
		//IL_035a: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E72D7]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v22+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v22+E4]");
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
		VivoxManager vivoxManager = manager;
		bool interactable;
		if (vivoxManager._isConnected)
		{
			bool isSpectator = game.IsSpectator;
			interactable = (byte)((isSpectator ? 1u : 0u) ^ 1u) != 0;
		}
		else
		{
			interactable = false;
		}
		button.interactable = interactable;
		VivoxManager vivoxManager2 = manager;
		object obj7;
		if (vivoxManager2._isConnected)
		{
			bool isSpectator2 = game.IsSpectator;
			obj7 = "SetRoomVariables request error" + 776;
			object obj8 = "WhiteSmoke" + 2152;
			bool flag4 = !isSpectator2;
			object obj9 = !flag4;
			object obj10 = ~obj9;
			if (obj10 == null)
			{
				obj7 = obj8;
			}
		}
		else
		{
			obj7 = "Network Authentication Required" + 2112;
		}
		TextMeshProExtensions.Localize(text, (string)obj7);
		if (game.IsSpectator && game.IsVoiceChatEnabledForSpectators)
		{
			object obj11 = 56;
			Image image = icon;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (VivoxMuteButton)+v185 @ X8_v14]");
			image.sprite = (Sprite)0;
			return;
		}
		if (game.IsSpectator)
		{
			object obj12 = 64;
			Image image2 = icon;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (VivoxMuteButton)+v186 @ X8_v13]");
			image2.sprite = (Sprite)0;
			return;
		}
		VivoxManager vivoxManager3 = manager;
		if (vivoxManager3.<AmIMuted>k__BackingField)
		{
			object obj13 = 48;
			Image image3 = icon;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (VivoxMuteButton)+v187 @ X8_v12]");
			image3.sprite = (Sprite)0;
		}
		else
		{
			object obj14 = 40;
			Image image4 = icon;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (VivoxMuteButton)+v188 @ X8_v11]");
			image4.sprite = (Sprite)0;
		}
		return;
		IL_007d:
		if (this == null)
		{
			return;
		}
		goto IL_0126;
	}
}
