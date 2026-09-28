using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using DataTracking;
using Features.GameReplay;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using Util.SystemHelpers;

public class CreateGamePopup : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static InputField.OnValidateInput <>9__50_1;

		public static Func<PopupUI, bool> <>9__73_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(CardUtils.<>c) + 2824;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal char <Start>b__50_1(string text, int index, char addedChar)
		{
			if (addedChar == ',')
			{
				return '\0';
			}
			return addedChar;
		}

		internal bool <HideAllPopups>b__73_0(PopupUI ui)
		{
			//IL_0035: Expected I4, but got O
			if ((object)ui != null)
			{
				return ui.<IsCurrentlyShown>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass72_0
	{
		public PopupUI popupUi;

		public CreateGamePopup <>4__this;

		internal void <HidePopup>b__0()
		{
			PopupUI popupUI = popupUi;
			Transform child = popupUI.blocker.GetChild(0);
			CreateGamePopup createGamePopup = <>4__this;
			child.SetParent(createGamePopup.oldButtonsParent, worldPositionStays: true);
			Transform transform = popupUi.transform;
			transform.SetParent(child);
		}
	}

	public InputField NameInput;

	public InputField PasswordInput;

	public ToggleGroup CheatingRadio;

	public ToggleGroup SpeedRadio;

	private Toggle Spectatorlistening;

	public Button[] RanksButtons;

	public InventoryItemSelection RoomThemSelector;

	public Sprite Locked;

	public Sprite Unlocked;

	public TextMeshProUGUI priceTag;

	public TextMeshProUGUI voiceLabel;

	public GameObject priceTag_GO;

	private GameObject createRoom;

	private GameObject createRoomNotAvailable;

	public SlideAnimationHelper popup;

	public PopupUI PasswordBox;

	public PopupUI RanksContainer;

	public Image LockIcon;

	public Image RankImage;

	private Transform oldButtonsParent;

	private HintsPopup hintsPopup;

	private Action m_OnPopupClosed;

	private Action m_OnRoomCreated;

	private RoomParameters parameters;

	private string roomName
	{
		get
		{
			RoomParameters roomParameters = parameters;
			if (parameters != null)
			{
				return roomParameters.roomName;
			}
			return (string)(object)new NullReferenceException();
		}
	}

	private string password
	{
		get
		{
			RoomParameters roomParameters = parameters;
			if (parameters != null)
			{
				return roomParameters.password;
			}
			return (string)(object)new NullReferenceException();
		}
	}

	private bool isCheating
	{
		get
		{
			//IL_0041: Expected I4, but got O
			RoomParameters roomParameters = parameters;
			if (parameters != null)
			{
				return roomParameters.isCheatingEnabled;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private bool isVoiceChat
	{
		get
		{
			//IL_0041: Expected I4, but got O
			RoomParameters roomParameters = parameters;
			if (parameters != null)
			{
				return roomParameters.isVoiceRoom;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private int playSpeed
	{
		get
		{
			//IL_0041: Expected I4, but got O
			RoomParameters roomParameters = parameters;
			if (parameters != null)
			{
				return roomParameters.playSpeed;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	private int minRank
	{
		get
		{
			//IL_0041: Expected I4, but got O
			RoomParameters roomParameters = parameters;
			if (parameters != null)
			{
				return roomParameters.minRank;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	private bool IsClanRoom
	{
		get
		{
			//IL_00c2: Expected I4, but got O
			//IL_00a2: Expected O, but got I4
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected I4, but got Unknown
			RoomParameters roomParameters = parameters;
			if (parameters != null)
			{
				bool flag = roomParameters.clanId < 0;
				bool flag2 = roomParameters.clanId == 0;
				int num = roomParameters.clanId ^ roomParameters.clanId;
				int num2 = roomParameters.clanId & num;
				bool flag3 = num2 < 0;
				bool flag4 = flag == flag3;
				object obj = !flag2;
				return (byte)((flag4 & obj) ? 1 : 0) != 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public event Action OnPopupClosed
	{
		add
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 200;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
		remove
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 200;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
	}

	public event Action OnRoomCreated
	{
		add
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 208;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
		remove
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 208;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
	}

	public void SetRoomName(string name)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		object obj = parameters + 16;
		obj = name;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public void SetPassword(string password)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		object obj = parameters + 24;
		obj = password;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public void SetCheating(bool isCheating)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_004f: Expected O, but got I4
		//IL_00b9: Expected O, but got I4
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_0156: Expected O, but got I4
		if (isCheating)
		{
			object obj = typeof(Queue<string>) + 848;
			object obj2 = (nint)0 + (nint)2200;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel = default(SessionModel);
			User localUser = sessionModel.LocalUser;
			bool flag2 = SFSKammelnaUserExtensions.IsSubscribed(localUser);
			bool flag3 = !flag2;
			object obj5 = !flag3;
			if (obj5 == null)
			{
				RoomParameters roomParameters = parameters;
				if (roomParameters.clanId <= 0)
				{
					object obj6 = typeof(MemberAchievementClanFeedData) + 3448;
					object obj7 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X0_v11+E4]");
					bool flag4 = (nint)0 == 0;
					object obj8 = !flag4;
					if (obj8 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					OnlyForSubscribersPopup.Show(TrackingFeature.Rooms);
					RoomParameters roomParameters2 = parameters;
					int index = (roomParameters2.isCheatingEnabled ? 1 : 0) ^ 1;
					ToggleGroupExtensions.SetSelectedIndex(CheatingRadio, index);
					return;
				}
			}
		}
		RoomParameters roomParameters3 = parameters;
		roomParameters3.isCheatingEnabled = isCheating;
	}

	public void SetVoiceChat(bool value)
	{
		RoomParameters roomParameters = parameters;
		roomParameters.isVoiceRoom = value;
	}

	public void SetPlaySpeed(int speed)
	{
		RoomParameters roomParameters = parameters;
		roomParameters.playSpeed = speed;
	}

	public void SetMinRank(int rank)
	{
		RoomParameters roomParameters = parameters;
		roomParameters.minRank = rank;
	}

	public void SetTvUserId(int id)
	{
		RoomParameters roomParameters = parameters;
		roomParameters.tvUserId = id;
	}

	private void SetSpectatorListening(bool val)
	{
		RoomParameters roomParameters = parameters;
		roomParameters.isVoiceChatEnabledForSpectators = val;
	}

	private unsafe void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0d7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d84: Expected I4, but got Unknown
		//IL_0d96: Expected I, but got O
		//IL_0da4: Expected I, but got O
		//IL_0dac: Expected I, but got O
		//IL_0dce: Expected O, but got I4
		//IL_0054: Expected O, but got I
		//IL_008c: Expected O, but got I4
		//IL_00cb: Expected O, but got I4
		//IL_0121: Expected O, but got I4
		//IL_0164: Expected O, but got I4
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_01a3: Expected O, but got I
		//IL_01af: Expected O, but got I
		//IL_01bb: Expected O, but got I
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected O, but got Unknown
		//IL_01ee: Expected O, but got I4
		//IL_0201: Expected O, but got I4
		//IL_021b: Expected O, but got I4
		//IL_0dee: Expected O, but got I8
		//IL_0e05: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e0a: Expected O, but got Unknown
		//IL_0e23: Expected O, but got I4
		//IL_0e4d: Expected O, but got I4
		//IL_0e78: Expected O, but got I4
		//IL_0398: Expected O, but got I4
		//IL_0295: Expected O, but got I4
		//IL_02d1: Expected O, but got I
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected O, but got Unknown
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Expected O, but got Unknown
		//IL_0313: Expected O, but got I4
		//IL_031c: Expected O, but got I4
		//IL_0463: Expected I, but got O
		//IL_048f: Expected O, but got I4
		//IL_0494: Expected I4, but got O
		//IL_04b2: Expected I, but got O
		//IL_04c6: Expected I, but got O
		//IL_04e0: Expected O, but got I4
		//IL_0522: Expected O, but got I4
		//IL_0571: Expected O, but got I4
		//IL_0590: Unknown result type (might be due to invalid IL or missing references)
		//IL_0595: Expected O, but got Unknown
		//IL_05b5: Expected O, but got I4
		//IL_05e5: Expected I4, but got O
		//IL_0607: Expected O, but got I4
		//IL_0637: Expected O, but got I4
		//IL_0664: Expected O, but got I
		//IL_0673: Unknown result type (might be due to invalid IL or missing references)
		//IL_0678: Expected O, but got Unknown
		//IL_0692: Expected O, but got I4
		//IL_06e8: Expected O, but got I4
		//IL_0735: Expected O, but got I4
		//IL_0770: Unknown result type (might be due to invalid IL or missing references)
		//IL_0775: Expected O, but got Unknown
		//IL_079b: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a0: Expected O, but got Unknown
		//IL_07ca: Expected O, but got I4
		//IL_07f3: Expected O, but got I
		//IL_0803: Unknown result type (might be due to invalid IL or missing references)
		//IL_0808: Expected O, but got Unknown
		//IL_0810: Expected O, but got I4
		//IL_082f: Expected O, but got I
		//IL_084f: Expected O, but got I4
		//IL_088c: Expected O, but got I
		//IL_089a: Expected I, but got O
		//IL_08b4: Expected O, but got I
		//IL_094d: Expected O, but got I4
		//IL_0955: Expected I4, but got O
		//IL_08dd: Expected I, but got O
		//IL_08f6: Expected O, but got I4
		//IL_0ab0: Expected O, but got I
		//IL_0ac0: Expected O, but got I
		//IL_0ae2: Expected O, but got I4
		//IL_0af2: Expected O, but got I
		//IL_0a1b: Expected O, but got I
		//IL_0a39: Expected O, but got I4
		//IL_0a42: Expected O, but got I4
		//IL_09c1: Expected O, but got I
		//IL_09d1: Expected O, but got I
		//IL_09f8: Expected O, but got I
		//IL_0bdf: Expected I, but got O
		//IL_0bf8: Expected O, but got I4
		//IL_0b32: Expected O, but got I4
		//IL_0a71: Expected O, but got I4
		//IL_0ebc: Expected O, but got I
		//IL_0ecd: Expected I, but got O
		//IL_0eeb: Expected O, but got I
		//IL_0c76: Expected I4, but got O
		//IL_0b7c: Expected O, but got I
		//IL_0b98: Expected O, but got I4
		//IL_0bb1: Expected O, but got I4
		//IL_0b62: Expected O, but got I
		//IL_0cc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc6: Expected O, but got Unknown
		//IL_0cdc: Expected O, but got I
		//IL_0ce4: Expected I, but got O
		//IL_0cf2: Expected I, but got O
		//IL_0d1c: Expected O, but got I4
		//IL_0d21: Expected I4, but got O
		//IL_0d31: Expected I4, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)560;
		InputField.OnValidateInput onValidateInput = (InputField.OnValidateInput)(typeof(RegisteredWaitHandle) + 56);
		bool flag = (byte)(typeof(Queue<string>) + 848) != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num = (nint)obj2;
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		nint num2 = (nint)onValidateInput;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v4 (Il2CppClass<UnityEngine.UI.InputField+OnValidateInput>)+E4]");
		bool flag2 = (nint)0 == 0;
		object obj3 = !flag2;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		InputField.OnValidateInput onValidateInput2 = (InputField.OnValidateInput)((nint)0 + (nint)2200);
		RemoteConfig.OnChanged += action;
		bool value = ((bool*)(flag ? 1 : 0))->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v7 (System.Boolean)+E4]");
		bool flag3 = (nint)0 == 0;
		object obj4 = !flag3;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool flag4 = (object)sessionModel == null;
		object obj5 = 0;
		bool flag5 = false;
		Action action2 = action;
		if (!flag4)
		{
			User localUser = sessionModel.LocalUser;
			PlayerRank rank = SFSKammelnaUserExtensions.GetRank(localUser);
			bool flag6 = rank == null;
			obj5 = 0;
			flag5 = false;
			action2 = action;
			if (!flag6)
			{
				Button[] ranksButtons = RanksButtons;
				bool flag7 = RanksButtons == null;
				obj5 = 0;
				flag5 = false;
				action2 = action;
				if (!flag7)
				{
					onValidateInput = (InputField.OnValidateInput)(typeof(TypeConverter<ushort, char>) + 360);
					object obj6 = (nint)0 + (nint)568;
					object obj7 = (nint)0 + (nint)832;
					object obj8 = (nint)0 + (nint)3872;
					object obj9 = typeof(CardUtils.<>c) + 2824;
					bool flag8 = rank.<Rank>k__BackingField < PlayerRank.Ranks.Beginner;
					object obj10 = !flag8;
					object obj11 = rank.<Rank>k__BackingField - 1;
					bool flag9 = obj11 == null;
					object obj12 = !flag9;
					object obj13 = obj10 & obj12;
					object obj14 = ~obj13;
					PlayerRank.Ranks ranks = ((obj14 != null) ? PlayerRank.Ranks.Beginner : rank.<Rank>k__BackingField);
					object obj15 = (long)ranks & 0xFFFFFFFFL;
					object obj16 = obj15 << 3;
					object obj17 = obj16 + 32;
					bool flag10 = false;
					nint num3 = num;
					Action action3 = (Action)ranks;
					SessionModel sessionModel2 = default(SessionModel);
					bool flag19 = default(bool);
					object obj23 = default(object);
					bool flag30 = default(bool);
					InputField.OnValidateInput onValidateInput3 = default(InputField.OnValidateInput);
					InputField.OnValidateInput onValidateInput5 = default(InputField.OnValidateInput);
					UnityAction<object> unityAction = default(UnityAction<object>);
					while (true)
					{
						nint num4 = ranksButtons.Length;
						bool flag11 = (nint)action3 < ranksButtons.Length;
						object obj18 = !flag11;
						bool flag12 = (nint)action3 >= ranksButtons.Length;
						object obj19 = obj17;
						obj5 = 0;
						flag5 = flag10;
						num = num3;
						action2 = action3;
						Delegate b;
						nint num5;
						InputField.OnValidateInput onValidateInput4;
						object obj42;
						Delegate obj43;
						InputField.OnValidateInput onValidateInput6;
						Delegate obj44;
						if (!flag12)
						{
							if (obj18 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X8_v44 (UnityEngine.UI.Button[])+v117 @ X24_v7]");
								bool flag13 = (nint)0 == 0;
								obj19 = obj17;
								obj5 = 0;
								flag5 = flag10;
								num = num3;
								action2 = action3;
								if (flag13)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X8_v44 (UnityEngine.UI.Button[])+v117 @ X24_v7]");
								((Selectable)0).interactable = false;
								action2 = (Action)(action3 + 1);
								ranksButtons = RanksButtons;
								obj19 = obj17 + 8;
								bool flag14 = RanksButtons == null;
								object obj20 = !flag14;
								obj5 = 0;
								flag5 = false;
								num = 0;
								obj17 = obj19;
								flag10 = false;
								num3 = 0;
								action3 = action2;
								if (obj20 == null)
								{
									break;
								}
								continue;
							}
						}
						else
						{
							bool value2 = ((bool*)(flag ? 1 : 0))->m_value;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X0_v17 (System.Boolean)+E4]");
							bool flag15 = (nint)0 == 0;
							object obj21 = !flag15;
							if (obj21 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
							if ((object)sessionModel2 == null)
							{
								break;
							}
							User localUser2 = sessionModel2.LocalUser;
							bool flag16 = SFSKammelnaUserExtensions.IsSubscribed(localUser2);
							SetCheating(flag16);
							Toggle spectatorlistening = Spectatorlistening;
							bool flag17 = (object)Spectatorlistening == null;
							flag5 = flag16;
							num = 0;
							if (flag17)
							{
								break;
							}
							action2 = (Action)(object)spectatorlistening.onValueChanged;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							num = (nint)obj6;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4027FE0");
							bool flag18 = spectatorlistening.onValueChanged == null;
							obj5 = 0;
							flag5 = (byte)(int)this != 0;
							flag = flag19;
							if (flag18)
							{
								break;
							}
							num = (nint)obj7;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4029444");
							num4 = (nint)parameters;
							bool flag20 = parameters == null;
							obj5 = 0;
							flag5 = flag19;
							flag = flag19;
							if (flag20)
							{
								break;
							}
							Button[] ranksButtons2 = RanksButtons;
							bool flag21 = RanksButtons == null;
							obj5 = 0;
							flag5 = flag19;
							flag = flag19;
							if (flag21)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X9_v7 (Il2CppClass<System.Delegate>)+28]");
							num4 = -1;
							bool flag22 = num4 < ranksButtons2.Length;
							obj18 = !flag22;
							if (obj18 == null)
							{
								object obj22 = RanksButtons + num4;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X8_v11+20]");
								bool flag23 = (nint)0 == 0;
								obj5 = 0;
								flag5 = flag19;
								flag = flag19;
								if (flag23)
								{
									break;
								}
								action2 = (Action)(object)RankImage;
								flag5 = (byte)(int)obj8 != 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
								bool flag24 = obj23 == null;
								obj5 = 0;
								flag = flag19;
								if (flag24)
								{
									break;
								}
								bool flag25 = (object)RankImage == null;
								obj5 = 0;
								flag = flag19;
								if (flag25)
								{
									break;
								}
								Image rankImage = RankImage;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X0_v28+D8]");
								rankImage.sprite = (Sprite)0;
								obj8 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 3456;
								bool flag26 = (object)LockIcon == null;
								obj5 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X0_v28+D8]");
								flag5 = false;
								num = 0;
								flag = flag19;
								if (flag26)
								{
									break;
								}
								Transform transform = LockIcon.transform;
								bool flag27 = (object)transform == null;
								obj5 = 0;
								flag5 = false;
								num = 0;
								flag = flag19;
								if (flag27)
								{
									break;
								}
								Transform parent = transform.parent;
								bool flag28 = (object)parent == null;
								obj5 = 0;
								flag5 = false;
								num = 0;
								flag = flag19;
								if (flag28)
								{
									break;
								}
								Transform parent2 = parent.parent;
								object obj24 = this + 184;
								obj24 = parent2;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								object obj25 = typeof(MemberAchievementClanFeedData) + 2976;
								object obj26 = obj25;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ X0_v37+E4]");
								bool flag29 = (nint)0 == 0;
								object obj27 = !flag29;
								if (obj27 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								object obj28 = (nint)0 + (nint)104;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
								object obj29 = this + 192;
								obj29 = flag30;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X20_v10-A0]");
								action2 = (Action)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X20_v10-A0]");
								bool flag31 = (nint)0 == 0;
								obj5 = 0;
								flag5 = flag30;
								num = 0;
								flag = flag19;
								if (flag31)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
								object obj30 = (nint)0 + (nint)1528;
								onValidateInput3..ctor(null, (IntPtr)obj30);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X20_v6 (System.Action)+150]");
								Delegate obj31 = Delegate.Combine((Delegate)0, onValidateInput3);
								if ((object)obj31 != null)
								{
									num4 = (nint)obj31;
									bool flag32 = obj31 < obj8;
									obj18 = !flag32;
									if (obj31 != obj8)
									{
										goto IL_0d69;
									}
								}
								((InputField)(object)action2).onValidateInput = (InputField.OnValidateInput)obj31;
								action2 = (Action)(object)PasswordInput;
								bool flag33 = (object)PasswordInput == null;
								obj5 = 0;
								flag5 = (byte)(int)obj31 != 0;
								num = 0;
								onValidateInput = onValidateInput3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X20_v6 (System.Action)+150]");
								flag = false;
								if (flag33)
								{
									break;
								}
								object obj32 = obj9;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v579 @ X0_v56+E4]");
								object obj33;
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v579 @ X0_v56+B8]");
									obj33 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v591 @ X8_v31+8]");
									b = (Delegate)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v591 @ X8_v31+8]");
									bool flag34 = (nint)0 == 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v591 @ X8_v31+8]");
									Delegate obj34 = (Delegate)0;
									if (!flag34)
									{
										goto IL_0a06;
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									obj32 = obj9;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v579 @ X0_v56+B8]");
									obj33 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v591 @ X8_v31+8]");
									b = (Delegate)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v591 @ X8_v31+8]");
									bool flag35 = (nint)0 == 0;
									object obj35 = !flag35;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v591 @ X8_v31+8]");
									Delegate obj34 = (Delegate)0;
									if (obj35 != null)
									{
										goto IL_0a06;
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v579 @ X0_v56+E4]");
								num5 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v579 @ X0_v56+E4]");
								bool flag36 = (nint)0 == 0;
								object obj36 = !flag36;
								if (obj36 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									object obj37 = obj9;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v606 @ X8_v36+B8]");
									obj33 = 0;
								}
								onValidateInput4 = (InputField.OnValidateInput)obj33;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
								object obj38 = (nint)0 + (nint)3936;
								onValidateInput5..ctor(obj33, (IntPtr)obj38);
								object obj39 = obj9;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v616 @ X8_v34+B8]");
								object obj40 = (nint)0 + (nint)8;
								obj40 = onValidateInput5;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X20_v6 (System.Action)+150]");
								Delegate obj41 = Delegate.Combine((Delegate)0, onValidateInput5);
								bool flag37 = (object)obj41 == null;
								obj42 = 0;
								onValidateInput2 = onValidateInput5;
								obj43 = obj41;
								obj5 = 0;
								onValidateInput = (InputField.OnValidateInput)obj33;
								onValidateInput6 = onValidateInput5;
								obj44 = obj41;
								if (!flag37)
								{
									goto IL_0bd7;
								}
								goto IL_0c3e;
							}
						}
						throw new IndexOutOfRangeException();
						IL_0c3e:
						((InputField)(object)action2).onValidateInput = (InputField.OnValidateInput)obj44;
						InputField passwordInput = PasswordInput;
						bool flag38 = (object)PasswordInput == null;
						num4 = num5;
						flag5 = (byte)(int)obj44 != 0;
						num = 0;
						onValidateInput2 = onValidateInput6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X20_v6 (System.Action)+150]");
						flag = false;
						if (flag38)
						{
							break;
						}
						action2 = (Action)(object)passwordInput.m_OnValueChanged;
						object obj45 = typeof(TypeConverter<ushort, char>) + 464;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj46 = (nint)0 + (nint)552;
						num = (nint)obj46;
						unityAction..ctor((object)this, (IntPtr)obj46);
						bool flag39 = passwordInput.m_OnValueChanged == null;
						num4 = num5;
						obj5 = 0;
						flag5 = (byte)(int)this != 0;
						onValidateInput2 = onValidateInput6;
						flag = (byte)(int)unityAction != 0;
						if (flag39)
						{
							break;
						}
						((UnityEvent<object>)(object)passwordInput.m_OnValueChanged).AddListener(unityAction);
						Refresh();
						return;
						IL_0a06:
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X20_v6 (System.Action)+150]");
						Delegate obj47 = Delegate.Combine((Delegate)0, b);
						bool flag40 = (object)obj47 == null;
						object obj48 = !flag40;
						obj42 = 0;
						onValidateInput4 = onValidateInput3;
						obj43 = obj47;
						if (obj48 != null)
						{
							goto IL_0bd7;
						}
						num5 = num4;
						obj5 = 0;
						onValidateInput = onValidateInput3;
						onValidateInput6 = onValidateInput2;
						obj44 = obj47;
						goto IL_0c3e;
						IL_0bd7:
						num5 = (nint)obj43;
						bool flag41 = obj43 < obj8;
						obj18 = !flag41;
						flag12 = obj43 != obj8;
						obj5 = obj42;
						onValidateInput = onValidateInput4;
						onValidateInput6 = onValidateInput2;
						obj44 = obj43;
						if (!flag12)
						{
							goto IL_0c3e;
						}
						goto IL_0d69;
						IL_0d69:
						throw new InvalidCastException();
					}
				}
			}
		}
		throw new NullReferenceException();
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_007a: Expected I, but got O
		//IL_00a4: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)560;
		object obj3 = typeof(RegisteredWaitHandle) + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RemoteConfig.OnChanged -= action;
		Actions.SafeInvoke(this.OnPopupClosed);
	}

	private void OnConfigChanged()
	{
		Refresh();
	}

	public void Popup(bool isVoiceChatVersion, int tvUserId = 0, int clanId = 0)
	{
		//IL_0023: Expected O, but got I
		RoomParameters roomParameters = parameters;
		roomParameters.clanId = clanId;
		object text = (nint)0 + (nint)2000;
		PasswordInput.text = (string)text;
		UpdateRoomPrice();
		RoomThemSelector.Refresh();
		RoomParameters roomParameters2 = parameters;
		roomParameters2.isVoiceRoom = isVoiceChatVersion;
		roomParameters2.tvUserId = tvUserId;
		popup.SlideIn();
		Refresh();
	}

	public void Hide()
	{
		popup.SlideOut();
		Actions.SafeInvoke(this.OnPopupClosed);
	}

	public void OnCreateGameClick()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		if (!ValidateOptions())
		{
			return;
		}
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		CreateRoom();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v6+E4]");
		if ((nint)0 != 0)
		{
			Games currentGame = Preferences.CurrentGame;
			if (currentGame != Games.Jackaroo)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Games currentGame2 = Preferences.CurrentGame;
			if (currentGame2 != Games.Jackaroo)
			{
				return;
			}
		}
		object obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 184;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v11+E4]");
		if ((nint)0 != 0)
		{
			JackarooCustomRules.TrackCreateGameCustomRules();
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		JackarooCustomRules.TrackCreateGameCustomRules();
	}

	private bool ValidateOptions()
	{
		//IL_04db: Expected I4, but got O
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_007d: Expected O, but got I4
		//IL_0448: Unknown result type (might be due to invalid IL or missing references)
		//IL_044d: Expected O, but got Unknown
		//IL_0477: Expected O, but got I4
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_018a: Expected O, but got I4
		//IL_01b3: Expected O, but got I
		//IL_02bd: Expected O, but got I4
		//IL_0356: Expected I8, but got I4
		//IL_0375: Expected O, but got I4
		//IL_0556: Unknown result type (might be due to invalid IL or missing references)
		//IL_055b: Expected O, but got Unknown
		//IL_0585: Expected O, but got I4
		RoomParameters roomParameters2;
		if (parameters != null)
		{
			object obj = parameters + 16;
			if (obj != null)
			{
				object obj2 = typeof(System.IOAsyncCallback) + 3096;
				string input = ((string)obj).Trim();
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X8_v4+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				string text = InputSanitizer.SanitizeHtmlTags(input);
				obj = text;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				RoomParameters roomParameters = parameters;
				if (parameters != null && (object)NameInput != null)
				{
					string text2 = roomParameters.roomName;
					NameInput.text = roomParameters.roomName;
					roomParameters2 = parameters;
					if (parameters != null && roomParameters2.roomName != null)
					{
						if (roomParameters2.clanId > 0)
						{
							goto IL_0439;
						}
						object obj5 = typeof(Queue<string>) + 848;
						object obj6 = obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X0_v22+E4]");
						bool flag2 = (nint)0 == 0;
						object obj7 = !flag2;
						if (obj7 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object obj8 = (nint)0 + (nint)2200;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
						SessionModel sessionModel = default(SessionModel);
						if ((object)sessionModel != null)
						{
							User localUser = sessionModel.LocalUser;
							int aces = SFSKammelnaUserExtensions.GetAces(localUser);
							RoomParameters roomParameters3 = parameters;
							if (parameters != null)
							{
								int roomCreationPrice = RoomCreator.GetRoomCreationPrice(roomParameters3.isVoiceRoom);
								roomParameters2 = parameters;
								bool flag3 = aces >= roomCreationPrice;
								text2 = null;
								if (flag3)
								{
									goto IL_0439;
								}
								if (parameters != null)
								{
									int roomCreationPrice2 = RoomCreator.GetRoomCreationPrice(roomParameters2.isVoiceRoom);
									object obj9 = obj5;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X0_v32+E4]");
									bool flag4 = (nint)0 == 0;
									object obj10 = !flag4;
									if (obj10 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
									SessionModel sessionModel2 = default(SessionModel);
									if ((object)sessionModel2 != null)
									{
										User localUser2 = sessionModel2.LocalUser;
										int aces2 = SFSKammelnaUserExtensions.GetAces(localUser2);
										RoomParameters roomParameters4 = parameters;
										if (parameters != null)
										{
											long num = roomCreationPrice2 - aces2;
											bool flag5 = !roomParameters4.isVoiceRoom;
											object obj11 = !flag5;
											object obj12 = ~obj11;
											TrackingFeature feature = ((obj12 != null) ? TrackingFeature.Rooms : TrackingFeature.VoiceChat);
											object obj13 = typeof(MemberAchievementClanFeedData) + 2608;
											object obj14 = obj13;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v27+E4]");
											bool flag6 = (nint)0 == 0;
											object obj15 = !flag6;
											long remaining = num;
											if (obj15 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												remaining = num;
											}
											NotEnoughAcesPopup.ShowNotEnoughAces(remaining, feature);
											return false;
										}
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_04cd;
		IL_04cd:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0439:
		object obj16 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 184;
		object obj17 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X0_v18+E4]");
		bool flag7 = (nint)0 == 0;
		object obj18 = !flag7;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int currentJackarooCustomRule = JackarooCustomRules.CurrentJackarooCustomRule;
		if (roomParameters2 != null)
		{
			roomParameters2.jackarooCustomRules = currentJackarooCustomRule;
			return true;
		}
		goto IL_04cd;
	}

	private void CreateRoom()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0101: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected O, but got Unknown
		//IL_01fe: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E76E4]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v15+E4]");
			bool flag = (nint)0 == 0;
			obj5 = hintsPopup;
			obj6 = hintsPopup;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = hintsPopup;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v15+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = hintsPopup;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		if ((bool)obj6)
		{
			goto IL_014e;
		}
		goto IL_0168;
		IL_0168:
		Actions.SafeInvoke(this.OnRoomCreated);
		SlideAnimationHelper slideAnimationHelper = popup;
		if (slideAnimationHelper.<IsShown>k__BackingField)
		{
			slideAnimationHelper.SlideOut();
			Actions.SafeInvoke(this.OnPopupClosed);
			object obj8 = typeof(RegisteredWaitHandle) + 3136;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X0_v9+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			ScreenManager.AnimateTransitionOut();
		}
		RoomCreator.CreateRoom(parameters);
		return;
		IL_014e:
		hintsPopup.Open();
		goto IL_0168;
		IL_0091:
		bool flag4 = obj5;
		bool flag5 = !flag4;
		object obj11 = !flag5;
		if (obj11 != null)
		{
			goto IL_014e;
		}
		goto IL_0168;
	}

	private void UpdateCheatingRadio()
	{
		RoomParameters roomParameters = parameters;
		int index = (roomParameters.isCheatingEnabled ? 1 : 0) ^ 1;
		ToggleGroupExtensions.SetSelectedIndex(CheatingRadio, index);
	}

	private void UpdateSpeedRadio()
	{
		//IL_0022: Expected O, but got I4
		//IL_003c: Expected O, but got I4
		RoomParameters roomParameters = parameters;
		object obj = roomParameters.playSpeed - 30;
		bool flag = obj == null;
		object obj2 = !flag;
		object obj3 = ~obj2;
		int num = ((obj3 != null) ? 3 : 0);
		int num2 = ((roomParameters.playSpeed != 10) ? num : 2);
		ToggleGroupExtensions.SetSelectedIndex(index: (roomParameters.playSpeed == 5) ? 1 : num2, group: SpeedRadio);
	}

	private void UpdateVoiceChatLabel()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0042: Expected O, but got I4
		RoomParameters roomParameters = parameters;
		object obj = "setMimeType" + 3640;
		object obj2 = "Complete" + 2936;
		bool flag = !roomParameters.isVoiceRoom;
		object obj3 = !flag;
		object obj4 = ~obj3;
		object text = ((obj4 != null) ? obj2 : obj);
		TextMeshProExtensions.Localize(voiceLabel, (string)text);
	}

	private void UpdateSpectatorListening()
	{
		GameObject gameObject = Spectatorlistening.gameObject;
		RoomParameters roomParameters = parameters;
		gameObject.SetActive(roomParameters.isVoiceRoom);
	}

	private void UpdateVoiceChatNotAvailableOnWebGL()
	{
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		createRoom.SetActive(value: true);
		createRoomNotAvailable.SetActive(value: false);
		RoomParameters roomParameters = parameters;
		if (!roomParameters.isVoiceRoom)
		{
			return;
		}
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X0_v7+E4]");
		if ((nint)0 != 0)
		{
			Platform platform = KUtil.GetPlatform();
			if (platform != Platform.Web)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Platform platform2 = KUtil.GetPlatform();
			if (platform2 != Platform.Web)
			{
				return;
			}
		}
		createRoom.SetActive(value: false);
		createRoomNotAvailable.SetActive(value: true);
	}

	private void Refresh()
	{
		//IL_0053: Expected O, but got I4
		//IL_006d: Expected O, but got I4
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_0113: Expected O, but got I4
		RoomParameters roomParameters = parameters;
		int index = (roomParameters.isCheatingEnabled ? 1 : 0) ^ 1;
		ToggleGroupExtensions.SetSelectedIndex(CheatingRadio, index);
		RoomParameters roomParameters2 = parameters;
		object obj = roomParameters2.playSpeed - 30;
		bool flag = obj == null;
		object obj2 = !flag;
		object obj3 = ~obj2;
		int num = ((obj3 != null) ? 3 : 0);
		int num2 = ((roomParameters2.playSpeed != 10) ? num : 2);
		ToggleGroupExtensions.SetSelectedIndex(index: (roomParameters2.playSpeed == 5) ? 1 : num2, group: SpeedRadio);
		UpdateRoomPrice();
		RoomParameters roomParameters3 = parameters;
		object obj4 = "setMimeType" + 3640;
		object obj5 = "Complete" + 2936;
		bool flag2 = !roomParameters3.isVoiceRoom;
		object obj6 = !flag2;
		object obj7 = ~obj6;
		object text = ((obj7 != null) ? obj5 : obj4);
		TextMeshProExtensions.Localize(voiceLabel, (string)text);
		GameObject gameObject = Spectatorlistening.gameObject;
		RoomParameters roomParameters4 = parameters;
		gameObject.SetActive(roomParameters4.isVoiceRoom);
		UpdateVoiceChatNotAvailableOnWebGL();
	}

	public void CancelPassword()
	{
		//IL_0011: Expected O, but got I
		object text = (nint)0 + (nint)2000;
		PasswordInput.text = (string)text;
		PopupUI passwordBox = PasswordBox;
		if (passwordBox.<IsCurrentlyShown>k__BackingField)
		{
			HidePopup(passwordBox);
		}
		else
		{
			((CreateGamePopup)(object)PasswordInput).ShowPopup(passwordBox);
		}
	}

	private void UpdateLockIcon()
	{
		//IL_009a: Expected O, but got I4
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_00d5: Expected O, but got I4
		//IL_00f1: Expected O, but got I
		//IL_00c7: Expected O, but got I4
		InputField passwordInput = PasswordInput;
		string text = passwordInput.m_Text;
		bool flag = text._stringLength < 0;
		bool flag2 = text._stringLength == 0;
		int num = text._stringLength ^ text._stringLength;
		int num2 = text._stringLength & num;
		bool flag3 = num2 < 0;
		bool flag4 = flag == flag3;
		object obj = !flag2;
		object obj2 = flag4 & obj;
		object obj3 = ~obj2;
		if (obj3 == null)
		{
			object obj4 = 88;
		}
		else
		{
			object obj4 = 96;
		}
		Image lockIcon = LockIcon;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (CreateGamePopup)+v82 @ X9_v5]");
		lockIcon.sprite = (Sprite)0;
	}

	private void UpdateRoomPrice()
	{
		//IL_0108: Expected O, but got I4
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected I4, but got Unknown
		//IL_005a: Expected O, but got I4
		RoomParameters roomParameters = parameters;
		GameObject gameObject;
		int num;
		int num2;
		if (roomParameters.clanId > 0)
		{
			gameObject = priceTag_GO;
			bool flag = (object)priceTag_GO == null;
			object obj = !flag;
			num = 0;
			num2 = 0;
			if (obj == null)
			{
				throw new NullReferenceException();
			}
		}
		else
		{
			num2 = RoomCreator.GetRoomCreationPrice(roomParameters.isVoiceRoom);
			gameObject = priceTag_GO;
			num = num2;
		}
		bool flag2 = num2 < 0;
		bool flag3 = num2 == 0;
		int num3 = num2 ^ num2;
		int num4 = num2 & num3;
		bool flag4 = num4 < 0;
		bool flag5 = flag2 == flag4;
		object obj2 = !flag3;
		bool active = (byte)((flag5 & obj2) ? 1 : 0) != 0;
		gameObject.SetActive(active);
		string text = num.ToString();
		priceTag.text = text;
	}

	public void ChangeMinRank(int rank)
	{
		//IL_00b9: Expected O, but got I4
		//IL_00d4: Expected O, but got I4
		//IL_0122: Expected O, but got I
		//IL_017f: Expected O, but got I
		RoomParameters roomParameters = parameters;
		if (parameters != null)
		{
			roomParameters.minRank = rank;
			PopupUI ranksContainer = RanksContainer;
			if ((object)RanksContainer != null)
			{
				if (ranksContainer.<IsCurrentlyShown>k__BackingField)
				{
					HidePopup(RanksContainer);
				}
				else
				{
					ShowPopup(RanksContainer);
				}
				Button[] ranksButtons = RanksButtons;
				if (RanksButtons != null)
				{
					object obj = rank - 1;
					bool flag = (nint)obj < ranksButtons.Length;
					object obj2 = !flag;
					if (obj2 != null)
					{
						goto IL_018e;
					}
					object obj3 = (object)RanksButtons + obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v8+20]");
					if ((nint)0 != 0)
					{
						object obj4 = (nint)0 + (nint)3872;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
						object obj5 = default(object);
						if (obj5 != null && (object)RankImage != null)
						{
							Image rankImage = RankImage;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v8+D8]");
							rankImage.sprite = (Sprite)0;
							return;
						}
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_018e;
		IL_018e:
		throw new IndexOutOfRangeException();
	}

	public void TogglePasswordView()
	{
		PopupUI passwordBox = PasswordBox;
		if (passwordBox.<IsCurrentlyShown>k__BackingField)
		{
			HidePopup(passwordBox);
		}
		else
		{
			ShowPopup(passwordBox);
		}
	}

	public void ToggleRanksView()
	{
		PopupUI ranksContainer = RanksContainer;
		if (ranksContainer.<IsCurrentlyShown>k__BackingField)
		{
			HidePopup(ranksContainer);
		}
		else
		{
			ShowPopup(ranksContainer);
		}
	}

	private void TogglePopup(PopupUI popupUi)
	{
		if (popupUi.<IsCurrentlyShown>k__BackingField)
		{
			HidePopup(popupUi);
		}
		else
		{
			ShowPopup(popupUi);
		}
	}

	private void ShowPopup(PopupUI popupUi)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_00b7: Expected O, but got I4
		UIExtensions.AttachToCanvas(popupUi.blocker, CanvasLayer.SecondaryCanvas);
		Transform transform = popupUi.transform;
		Transform parent = transform.parent;
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		object caller = "SetRoomVariables request error" + 592;
		parent.SetParent(popupUi.blocker, worldPositionStays: true);
		Transform transform2 = popupUi.transform;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X0_v10+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GameObject secondaryCanvas = KUtil.GetSecondaryCanvas((string)caller);
		Transform parent2 = secondaryCanvas.transform;
		transform2.SetParent(parent2);
		Transform transform3 = popupUi.transform;
		transform3.SetAsLastSibling();
		popupUi.PopFromCenter();
	}

	private void HidePopup(PopupUI popupUi)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_0088: Expected O, but got I
		//IL_0099: Expected O, but got I
		//IL_00cf: Expected I, but got O
		//IL_00e9: Expected O, but got I
		object obj = typeof(CardUtils.<>c) + 2832;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = popupUi;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 24;
		obj4 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj3;
		object obj6 = typeof(SqlSingle[]) + 2376;
		object obj7 = (nint)0 + (nint)3944;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v4+28]");
		Transform target = ((Component)0).transform;
		int num = ShortcutExtensions.DOKill(target, complete: true);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj7);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3 (System.Object)+10]");
		((PopupUI)0).ShrinkToParent(action);
	}

	public void HideAllPopups()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0033: Expected O, but got I4
		//IL_0049: Expected I, but got O
		//IL_0059: Expected O, but got I
		//IL_0082: Expected O, but got I
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_0169: Expected O, but got I8
		//IL_0108: Expected I, but got O
		//IL_0118: Expected O, but got I
		//IL_0141: Expected O, but got I
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected O, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected O, but got Unknown
		//IL_01e6: Expected O, but got I4
		//IL_0331: Expected O, but got I
		//IL_0340: Unknown result type (might be due to invalid IL or missing references)
		//IL_0345: Expected O, but got Unknown
		//IL_0355: Expected O, but got I
		//IL_0365: Expected O, but got I
		//IL_0387: Expected O, but got I4
		//IL_022d: Expected O, but got I4
		//IL_02d2: Expected O, but got I4
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a9: Expected O, but got Unknown
		//IL_03bf: Expected O, but got I
		//IL_03d0: Expected I, but got O
		//IL_03ee: Expected O, but got I
		//IL_025d: Expected O, but got I
		object obj = typeof(TypeConverter<ushort, char>) + 3520;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		bool flag = (object)RanksContainer == null;
		PopupUI popupUI = (PopupUI)2;
		IEnumerable<object> enumerable = default(IEnumerable<object>);
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		PopupUI popupUI2;
		if (!flag)
		{
			nint num = (nint)enumerable;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v23 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
			popupUI = (PopupUI)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			bool flag2 = ex == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v23 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
			popupUI2 = (PopupUI)0;
			if (flag2)
			{
				goto IL_02f7;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
		if ((nint)0 != 0)
		{
			object obj2 = enumerable + 32;
			obj2 = RanksContainer;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			bool flag3 = (object)PasswordBox == null;
			popupUI = RanksContainer;
			if (!flag3)
			{
				nint num2 = (nint)enumerable;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v22 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
				popupUI = (PopupUI)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag4 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v22 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
				popupUI2 = (PopupUI)0;
				if (flag4)
				{
					goto IL_02f7;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
			object obj3 = 0 & 0xFFFFFFFEL;
			if (obj3 != null)
			{
				object obj4 = typeof(CardUtils.<>c) + 2824;
				object obj5 = enumerable + 40;
				obj5 = PasswordBox;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj6 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v20+E4]");
				bool flag5 = (nint)0 == 0;
				object obj7 = !flag5;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj6 = obj4;
				}
				object obj8 = (nint)0 + (nint)1048;
				object obj9 = typeof(MemberAchievementClanFeedData) + 2976;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v20+B8]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v14+10]");
				Func<object, bool> predicate = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v14+10]");
				bool flag6 = (nint)0 == 0;
				object obj11 = !flag6;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v20+E4]");
					bool flag7 = (nint)0 == 0;
					object obj12 = !flag7;
					if (obj12 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						object obj13 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X8_v20+B8]");
						obj10 = 0;
					}
					object obj14 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2736;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj15 = (nint)0 + (nint)3928;
					Func<object, bool> func = default(Func<object, bool>);
					func..ctor(obj10, (IntPtr)obj15);
					object obj16 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v19+B8]");
					object obj17 = (nint)0 + (nint)16;
					obj17 = func;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					predicate = func;
				}
				object obj18 = Enumerable.FirstOrDefault(enumerable, predicate);
				object obj19 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X0_v24+E4]");
				if ((nint)0 != 0)
				{
					if (!(UnityEngine.Object)obj18)
					{
						return;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					bool flag8 = (UnityEngine.Object)obj18;
					bool flag9 = !flag8;
					object obj20 = !flag9;
					if (obj20 == null)
					{
						return;
					}
				}
				HidePopup((PopupUI)obj18);
				return;
			}
		}
		ex = new IndexOutOfRangeException();
		popupUI2 = popupUI;
		goto IL_02f7;
		IL_02f7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		OutOfMemoryException ex2 = new OutOfMemoryException();
		throw new NullReferenceException();
	}

	public CreateGamePopup()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 1416;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		RoomParameters roomParameters = default(RoomParameters);
		roomParameters..ctor();
		object obj2 = this + 216;
		obj2 = roomParameters;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}

	private void <Start>b__50_0(string s)
	{
		//IL_009a: Expected O, but got I4
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_00d5: Expected O, but got I4
		//IL_00f1: Expected O, but got I
		//IL_00c7: Expected O, but got I4
		InputField passwordInput = PasswordInput;
		string text = passwordInput.m_Text;
		bool flag = text._stringLength < 0;
		bool flag2 = text._stringLength == 0;
		int num = text._stringLength ^ text._stringLength;
		int num2 = text._stringLength & num;
		bool flag3 = num2 < 0;
		bool flag4 = flag == flag3;
		object obj = !flag2;
		object obj2 = flag4 & obj;
		object obj3 = ~obj2;
		if (obj3 == null)
		{
			object obj4 = 88;
		}
		else
		{
			object obj4 = 96;
		}
		Image lockIcon = LockIcon;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (CreateGamePopup)+v82 @ X9_v5]");
		lockIcon.sprite = (Sprite)0;
	}
}
