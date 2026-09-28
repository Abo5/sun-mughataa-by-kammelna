using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using DataTracking;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models;
using Sfs2X.Entities;
using TMPro;
using Unity.Properties;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class CreateChallengePopup : MonoBehaviour
{
	private const string CurrencyLocalization = "COINS";

	private const string PrizeOptionalLocalization = "Prize is optional";

	private const string MinAllowedPrizeLocalization = "Min allowed prize is {0}";

	private ToggleGroup CheatingRadio;

	private ToggleGroup SpeedRadio;

	private GameObject prizeInputContainer;

	private InputFieldTMProUGUI prizeInput;

	private GameObject feesContainer;

	private TextMeshProUGUI feesText;

	private GameObject prizeContainer;

	private TextMeshProUGUI prizeText;

	private TextMeshProUGUI totalPriceText;

	private AvatarInitializer computer1Avatar;

	private AvatarInitializer computer2Avatar;

	private AvatarInitializer yourOpponentAvatar;

	private ChallengeProgressBar challengeProgressBar;

	private Button createChallengeButton;

	private WaitingForChallengeePopup waitingForChallengeePopup;

	private SingleSound challengeCreatedSFX;

	public SlideAnimationHelper popup;

	private int _challengedId;

	private ChallengeStatusData challengeStatusData;

	private ChallengeConnector _connector;

	private FriendlyChallengeRoomConfig _roomConfig;

	private FriendlyChallengeConfig _config
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00d4: Expected O, but got I4
			//IL_0114: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E776E]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v3+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			RemoteConfigModel current = RemoteConfig.Current;
			bool flag2 = current == null;
			object obj5 = !flag2;
			if (obj5 != null)
			{
				goto IL_009a;
			}
			goto IL_0122;
			IL_009a:
			return current.<FriendlyChallenge>k__BackingField;
			IL_0122:
			return (FriendlyChallengeConfig)(object)new NullReferenceException();
			IL_0074:
			current = RemoteConfig.Current;
			if (current != null)
			{
				goto IL_009a;
			}
			goto IL_0122;
		}
	}

	private ChallengeConnector Connector
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fe: Expected O, but got Unknown
			//IL_0130: Expected O, but got I4
			//IL_00c4: Expected O, but got I4
			//IL_00cd: Expected O, but got I4
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected O, but got Unknown
			//IL_01a6: Expected O, but got I
			//IL_01d0: Expected O, but got I4
			//IL_0187: Expected O, but got I4
			object obj = 152989696;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E76D0]");
			object obj3 = (nint)0 & (nint)1;
			object obj4;
			UnityEngine.Object obj5;
			UnityEngine.Object obj7;
			object obj8;
			if (obj3 != null)
			{
				obj4 = this + 184;
				obj5 = (UnityEngine.Object)obj4;
				object obj6 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v10+E4]");
				bool flag = (nint)0 == 0;
				obj7 = (UnityEngine.Object)obj4;
				obj8 = obj4;
				if (!flag)
				{
					goto IL_00a0;
				}
			}
			else
			{
				_ = 1;
				obj4 = this + 184;
				obj5 = (UnityEngine.Object)obj4;
				object obj6 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v10+E4]");
				bool flag2 = (nint)0 == 0;
				object obj9 = !flag2;
				obj7 = (UnityEngine.Object)obj4;
				obj8 = obj4;
				if (obj9 != null)
				{
					goto IL_00a0;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = obj7 == null;
			bool flag4 = !flag3;
			obj4 = obj8;
			object obj10 = 0;
			UnityEngine.Object obj11 = null;
			if (flag4)
			{
				goto IL_00e8;
			}
			goto IL_019a;
			IL_00e8:
			return (ChallengeConnector)obj4;
			IL_019a:
			object obj12 = (nint)0 + (nint)40;
			object obj13 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v2+E4]");
			bool flag5 = (nint)0 == 0;
			object obj14 = !flag5;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
			object obj15 = default(object);
			obj8 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return (ChallengeConnector)obj8;
			IL_00a0:
			bool flag6 = obj5 == null;
			bool flag7 = !flag6;
			object obj16 = !flag7;
			obj10 = 0;
			obj11 = null;
			obj8 = obj4;
			if (obj16 == null)
			{
				goto IL_00e8;
			}
			goto IL_019a;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 184;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	private int prizeAmount
	{
		get
		{
			//IL_0041: Expected I4, but got O
			FriendlyChallengeRoomConfig roomConfig = _roomConfig;
			if (_roomConfig != null)
			{
				return roomConfig.<PrizeAmount>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	private bool isCheating
	{
		get
		{
			//IL_0041: Expected I4, but got O
			FriendlyChallengeRoomConfig roomConfig = _roomConfig;
			if (_roomConfig != null)
			{
				return roomConfig.<CheatingAllowed>k__BackingField;
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
			FriendlyChallengeRoomConfig roomConfig = _roomConfig;
			if (_roomConfig != null)
			{
				return roomConfig.<PlayingSpeed>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	public void SetCheating(bool cheating)
	{
		FriendlyChallengeRoomConfig roomConfig = _roomConfig;
		roomConfig.<CheatingAllowed>k__BackingField = cheating;
	}

	public void SetPlaySpeed(int speed)
	{
		FriendlyChallengeRoomConfig roomConfig = _roomConfig;
		roomConfig.<PlayingSpeed>k__BackingField = speed;
	}

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_006a: Expected I, but got O
		//IL_0094: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)488;
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
		RemoteConfig.OnChanged += action;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_006a: Expected I, but got O
		//IL_0094: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)488;
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
	}

	private void UpdateUI()
	{
		//IL_00ba: Expected O, but got I4
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected I4, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		//IL_013c: Expected O, but got I
		//IL_01fa: Expected O, but got I4
		//IL_01a9: Expected O, but got I4
		//IL_027a: Expected I, but got O
		//IL_01c5: Expected I, but got O
		//IL_023d: Expected I, but got O
		//IL_02a7: Expected I, but got O
		//IL_02c8: Expected O, but got I4
		//IL_0334: Expected O, but got I4
		//IL_03a0: Expected O, but got I4
		//IL_0401: Expected O, but got I
		//IL_04ce: Expected O, but got I
		//IL_04ee: Expected I, but got O
		//IL_0523: Expected O, but got I4
		//IL_046e: Expected O, but got I4
		//IL_0a32: Expected O, but got I4
		//IL_0ac1: Expected O, but got I4
		//IL_05ef: Expected O, but got I
		//IL_06ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bf: Expected O, but got Unknown
		//IL_06df: Expected I, but got O
		//IL_0714: Expected O, but got I4
		//IL_065c: Expected O, but got I4
		//IL_07b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bc: Expected O, but got Unknown
		//IL_07e6: Expected O, but got I4
		//IL_080d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0812: Expected O, but got Unknown
		//IL_0824: Expected I8, but got I4
		//IL_0837: Unknown result type (might be due to invalid IL or missing references)
		//IL_083c: Expected O, but got Unknown
		//IL_08a8: Expected I, but got O
		//IL_0931: Unknown result type (might be due to invalid IL or missing references)
		//IL_0936: Expected O, but got Unknown
		//IL_0952: Unknown result type (might be due to invalid IL or missing references)
		//IL_0957: Expected O, but got Unknown
		//IL_098f: Expected I, but got O
		//IL_09bd: Expected I, but got O
		ChallengeStatusData challengeStatusData = this.challengeStatusData;
		object obj2;
		RemoteConfigModel current;
		bool flag2;
		nint num;
		if (this.challengeStatusData != null && (object)challengeProgressBar != null)
		{
			challengeProgressBar.SetProgress(challengeStatusData.<ChallengeLevel>k__BackingField);
			ChallengeStatusData challengeStatusData2 = this.challengeStatusData;
			bool flag = this.challengeStatusData == null;
			flag2 = false;
			num = challengeStatusData.<ChallengeLevel>k__BackingField;
			if (!flag)
			{
				bool flag3 = (object)createChallengeButton == null;
				flag2 = false;
				num = challengeStatusData.<ChallengeLevel>k__BackingField;
				if (!flag3)
				{
					object obj = ~(challengeStatusData2.<IsLocked>k__BackingField ? 1 : 0);
					bool flag4 = (byte)(1 & obj) != 0;
					createChallengeButton.interactable = flag4;
					bool flag5 = (object)popup == null;
					flag2 = false;
					num = (flag4 ? 1 : 0);
					if (!flag5)
					{
						popup.SlideIn();
						obj2 = typeof(RegisteredWaitHandle) + 56;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E776E]");
						object obj3 = (nint)0 & (nint)1;
						if (obj3 != null)
						{
							object obj4 = obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X0_v68+E4]");
							if ((nint)0 != 0)
							{
								goto IL_0186;
							}
						}
						else
						{
							_ = 1;
							object obj4 = obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X0_v68+E4]");
							bool flag6 = (nint)0 == 0;
							object obj5 = !flag6;
							if (obj5 != null)
							{
								goto IL_0186;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						current = RemoteConfig.Current;
						bool flag7 = current == null;
						flag2 = false;
						num = unchecked((nint)null);
						if (!flag7)
						{
							goto IL_024b;
						}
					}
				}
			}
		}
		goto IL_0b28;
		IL_0768:
		RemoteConfigModel current2;
		FriendlyChallengeConfig <FriendlyChallenge>k__BackingField = current2.<FriendlyChallenge>k__BackingField;
		bool flag8 = current2.<FriendlyChallenge>k__BackingField == null;
		flag2 = false;
		bool flag9;
		num = (flag9 ? 1 : 0);
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		if (!flag8)
		{
			object obj6 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X0_v28+E4]");
			bool flag10 = (nint)0 == 0;
			object obj8 = !flag10;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object input = "AvailableVoices" + 3920;
			string text = LocalizationUtil.Localize((string)input, <FriendlyChallenge>k__BackingField.<MinimumPrize>k__BackingField);
			object obj9 = typeof(TypeConverter<ushort, char>) + 3400;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			object[] array = default(object[]);
			bool flag11 = array == null;
			flag2 = false;
			num = 1;
			if (!flag11)
			{
				bool flag12 = text == null;
				nint num2 = 1;
				if (!flag12)
				{
					nint num3 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v38 (Il2CppClass<System.Object[]>)+40]");
					num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag13 = ex == null;
					flag2 = false;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v38 (Il2CppClass<System.Object[]>)+40]");
					num = 0;
					if (flag13)
					{
						goto IL_0b44;
					}
				}
				bool flag14 = array.Length == 0;
				flag2 = false;
				num = num2;
				if (flag14)
				{
					goto IL_0b36;
				}
				object obj10 = array + 32;
				obj10 = text;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object text2 = "Material with texture name \"" + 1576;
				LocalizableText localizableText = TextMeshProExtensions.LocalizeWith((string)text2, array);
				bool flag15 = (object)prizeInput == null;
				flag2 = false;
				num = (nint)array;
				if (!flag15)
				{
					prizeInput.SetPlaceholder(localizableText);
					flag2 = false;
					num = (nint)localizableText;
					goto IL_09c2;
				}
			}
		}
		goto IL_0b28;
		IL_044b:
		RemoteConfigModel current3 = RemoteConfig.Current;
		bool flag16 = current3 == null;
		object obj11 = !flag16;
		if (obj11 != null)
		{
			goto IL_0577;
		}
		flag2 = false;
		num = (flag9 ? 1 : 0);
		goto IL_0b28;
		IL_0577:
		FriendlyChallengeConfig <FriendlyChallenge>k__BackingField2 = current3.<FriendlyChallenge>k__BackingField;
		bool flag17 = current3.<FriendlyChallenge>k__BackingField == null;
		flag2 = false;
		num = (flag9 ? 1 : 0);
		if (!flag17)
		{
			if (<FriendlyChallenge>k__BackingField2.<MinimumPrize>k__BackingField >= 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E776E]");
				object obj12 = (nint)0 & (nint)1;
				if (obj12 != null)
				{
					object obj13 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X0_v44+E4]");
					if ((nint)0 != 0)
					{
						goto IL_0639;
					}
				}
				else
				{
					_ = 1;
					object obj13 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X0_v44+E4]");
					bool flag18 = (nint)0 == 0;
					object obj14 = !flag18;
					if (obj14 != null)
					{
						goto IL_0639;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				current2 = RemoteConfig.Current;
				bool flag19 = current2 == null;
				flag2 = false;
				num = (flag9 ? 1 : 0);
				if (!flag19)
				{
					goto IL_0768;
				}
			}
			else
			{
				bool flag20 = (object)prizeInput == null;
				flag2 = false;
				num = (flag9 ? 1 : 0);
				if (!flag20)
				{
					object obj15 = "Picking audio files is not supported on iOS" + 1912;
					prizeInput.SetPlaceholder((string)obj15);
					flag2 = false;
					num = (nint)obj15;
					goto IL_09c2;
				}
			}
		}
		goto IL_0b28;
		IL_0639:
		current2 = RemoteConfig.Current;
		bool flag21 = current2 == null;
		object obj16 = !flag21;
		if (obj16 != null)
		{
			goto IL_0768;
		}
		flag2 = false;
		num = (flag9 ? 1 : 0);
		goto IL_0b28;
		IL_0b36:
		ex = new IndexOutOfRangeException();
		goto IL_0b44;
		IL_0b44:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_0b28:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0b36;
		IL_09c2:
		FriendlyChallengeRoomConfig roomConfig = _roomConfig;
		if (_roomConfig != null)
		{
			TextMeshProExtensions.SetNumber(prizeText, roomConfig.<PrizeAmount>k__BackingField, useCommas: true);
			FriendlyChallengeRoomConfig roomConfig2 = _roomConfig;
			bool flag22 = _roomConfig == null;
			object obj17 = 0;
			bool flag23 = false;
			bool flag24 = false;
			flag2 = true;
			num = roomConfig.<PrizeAmount>k__BackingField;
			if (!flag22)
			{
				int challengeCreationFees = RoomCreator.GetChallengeCreationFees(roomConfig2.<PrizeAmount>k__BackingField);
				TextMeshProExtensions.SetNumber(feesText, challengeCreationFees, useCommas: true);
				FriendlyChallengeRoomConfig roomConfig3 = _roomConfig;
				bool flag25 = _roomConfig == null;
				obj17 = 0;
				flag23 = false;
				flag24 = false;
				flag2 = true;
				num = challengeCreationFees;
				if (!flag25)
				{
					int challengeCreationPrice = RoomCreator.GetChallengeCreationPrice(roomConfig3.<PrizeAmount>k__BackingField);
					TextMeshProExtensions.SetNumber(totalPriceText, challengeCreationPrice, useCommas: true);
					return;
				}
			}
		}
		goto IL_0b28;
		IL_0186:
		current = RemoteConfig.Current;
		bool flag26 = current == null;
		object obj18 = !flag26;
		if (obj18 != null)
		{
			goto IL_024b;
		}
		flag2 = false;
		num = unchecked((nint)null);
		goto IL_0b28;
		IL_024b:
		FriendlyChallengeConfig <FriendlyChallenge>k__BackingField3 = current.<FriendlyChallenge>k__BackingField;
		bool flag27 = current.<FriendlyChallenge>k__BackingField == null;
		flag2 = false;
		num = unchecked((nint)null);
		if (!flag27)
		{
			bool flag28 = (object)prizeInputContainer == null;
			flag2 = false;
			num = unchecked((nint)null);
			if (!flag28)
			{
				object obj19 = <FriendlyChallenge>k__BackingField3.<PrizeCondition>k__BackingField - 2;
				bool flag29 = obj19 == null;
				bool flag30 = !flag29;
				prizeInputContainer.SetActive(flag30);
				bool flag31 = (object)prizeContainer == null;
				flag2 = false;
				num = (flag30 ? 1 : 0);
				if (!flag31)
				{
					object obj20 = <FriendlyChallenge>k__BackingField3.<PrizeCondition>k__BackingField - 2;
					bool flag32 = obj20 == null;
					bool flag33 = !flag32;
					prizeContainer.SetActive(flag33);
					bool flag34 = (object)feesContainer == null;
					flag2 = false;
					num = (flag33 ? 1 : 0);
					if (!flag34)
					{
						object obj21 = <FriendlyChallenge>k__BackingField3.<PrizeCondition>k__BackingField - 2;
						bool flag35 = obj21 == null;
						flag9 = !flag35;
						feesContainer.SetActive(flag9);
						if (<FriendlyChallenge>k__BackingField3.<PrizeCondition>k__BackingField != TournamentConfig.PrizeCondition.Disallowed)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E776E]");
							object obj22 = (nint)0 & (nint)1;
							if (obj22 != null)
							{
								object obj23 = obj2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X0_v56+E4]");
								if ((nint)0 != 0)
								{
									goto IL_044b;
								}
							}
							else
							{
								_ = 1;
								object obj23 = obj2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X0_v56+E4]");
								bool flag36 = (nint)0 == 0;
								object obj24 = !flag36;
								if (obj24 != null)
								{
									goto IL_044b;
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							current3 = RemoteConfig.Current;
							bool flag37 = current3 == null;
							flag2 = false;
							num = (flag9 ? 1 : 0);
							if (!flag37)
							{
								goto IL_0577;
							}
						}
						else
						{
							bool flag38 = (object)prizeInput == null;
							flag2 = false;
							num = (flag9 ? 1 : 0);
							if (!flag38)
							{
								object obj25 = (nint)0 + (nint)2000;
								prizeInput.Text = (string)obj25;
								flag2 = false;
								num = (nint)obj25;
								goto IL_09c2;
							}
						}
					}
				}
			}
		}
		goto IL_0b28;
	}

	public void Popup(int challengedId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0051: Expected O, but got I4
		//IL_0073: Expected I, but got O
		object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 304;
		object obj2 = (nint)0 + (nint)480;
		_challengedId = challengedId;
		object obj3 = this + 176;
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object, System.Int32Enum?> action = default(Action<object, System.Int32Enum?>);
		action..ctor((object)this, (IntPtr)obj2);
		FriendlyChallengeInvitesManager.SendCheckChallengeStatus(challengedId, (Action<ChallengeStatusData, FriendlyChallengeInviteError?>)(object)action);
	}

	private void UpdateChallengeStatus(ChallengeStatusData challenge, FriendlyChallengeInviteError? error)
	{
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_00be: Expected O, but got I
		//IL_00d3: Expected O, but got I
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0073: Expected O, but got I4
		object obj = (??)error & -4294967295L;
		if ((long)obj == 4294967297L)
		{
			object obj2 = typeof(List<Tween>) + 2400;
			object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			Enum enumeration = default(Enum);
			string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v8+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PopupWindow.ShowError(friendlyName);
		}
		else
		{
			object obj6 = this + 176;
			ChallengeStatusData challengeStatusData = default(ChallengeStatusData);
			obj6 = challengeStatusData;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object text = (nint)0 + (nint)2000;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X20_v3-78]");
			((InputFieldTMProUGUI)0).Text = (string)text;
			UpdateUI();
			Refresh();
		}
	}

	public void Hide()
	{
		popup.SlideOut();
	}

	public void OnCreateRoomClick()
	{
		//IL_0178: Expected O, but got I4
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_01a2: Expected O, but got I
		//IL_02a6: Expected O, but got I4
		//IL_020f: Expected O, but got I4
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_0073: Expected O, but got I4
		//IL_0641: Expected I, but got O
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Expected O, but got Unknown
		//IL_0356: Expected O, but got I4
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Expected O, but got Unknown
		//IL_0394: Expected I8, but got I4
		//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ac: Expected O, but got Unknown
		//IL_00ac: Expected I, but got O
		//IL_0414: Expected I, but got O
		//IL_0495: Unknown result type (might be due to invalid IL or missing references)
		//IL_049a: Expected O, but got Unknown
		//IL_04b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bb: Expected O, but got Unknown
		//IL_04e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e5: Expected O, but got Unknown
		//IL_050f: Expected O, but got I4
		//IL_0662: Expected O, but got I4
		//IL_0678: Expected I, but got O
		//IL_055c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0561: Expected O, but got Unknown
		//IL_058b: Expected O, but got I4
		RemoteConfigModel current;
		if (PrizeIsValid())
		{
			if (!HaveEnoughAces())
			{
				ITrackEvent trackEvent = TrackerLibrary.ChallengeCreateClickedNotEnoughAces();
				object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v34+E4]");
				if ((nint)0 != 0)
				{
					Tracker.DesignEvent(trackEvent);
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Tracker.DesignEvent(trackEvent);
				return;
			}
			ITrackEvent trackEvent2 = TrackerLibrary.ChallengeCreated();
			object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v37+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Tracker.DesignEvent(trackEvent2);
			ChallengeConnector connector = Connector;
			bool flag2 = (object)connector == null;
			nint num = unchecked((nint)null);
			if (!flag2)
			{
				FriendlyChallengeRoomConfig roomConfig = _roomConfig;
				num = _challengedId;
				nint num2 = (nint)connector;
				connector.SendChallengeInvite(_challengedId, _roomConfig);
				ChallengeStatusData challengeStatusData = this.challengeStatusData;
				if (this.challengeStatusData != null)
				{
					FriendlyChallengeRoomConfig roomConfig2 = _roomConfig;
					if (_roomConfig != null && (object)waitingForChallengeePopup != null)
					{
						waitingForChallengeePopup.OpenChallenge(_challengedId, challengeStatusData.<ChallengeLevel>k__BackingField, roomConfig2.<CheatingAllowed>k__BackingField, roomConfig2.<PlayingSpeed>k__BackingField);
						SoundChannel.PlaySFXSound(challengeCreatedSFX);
						return;
					}
				}
			}
		}
		else
		{
			object obj6 = 152989696;
			object obj7 = typeof(RegisteredWaitHandle) + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E776E]");
			object obj8 = (nint)0 & (nint)1;
			if (obj8 != null)
			{
				object obj9 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v38+E4]");
				if ((nint)0 != 0)
				{
					goto IL_01ec;
				}
			}
			else
			{
				_ = 1;
				object obj9 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v38+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 != null)
				{
					goto IL_01ec;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			current = RemoteConfig.Current;
			if (current != null)
			{
				goto IL_02e9;
			}
		}
		goto IL_05c1;
		IL_05c1:
		NullReferenceException ex = new NullReferenceException();
		goto IL_05cf;
		IL_05cf:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		goto IL_05dd;
		IL_02e9:
		FriendlyChallengeConfig <FriendlyChallenge>k__BackingField = current.<FriendlyChallenge>k__BackingField;
		if (current.<FriendlyChallenge>k__BackingField != null)
		{
			object obj11 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
			object obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X0_v12+E4]");
			bool flag4 = (nint)0 == 0;
			object obj13 = !flag4;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object input = "AvailableVoices" + 3920;
			string text = LocalizationUtil.Localize((string)input, <FriendlyChallenge>k__BackingField.<MinimumPrize>k__BackingField);
			object obj14 = typeof(TypeConverter<ushort, char>) + 3400;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			object[] array = default(object[]);
			bool flag5 = array == null;
			nint num = 1;
			FriendlyChallengeRoomConfig roomConfig = null;
			if (!flag5)
			{
				bool flag6 = text == null;
				nint num3 = 1;
				if (!flag6)
				{
					nint num4 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v26 (Il2CppClass<System.Object[]>)+40]");
					num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag7 = ex2 == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v26 (Il2CppClass<System.Object[]>)+40]");
					num = 0;
					roomConfig = null;
					if (flag7)
					{
						goto IL_05dd;
					}
				}
				bool flag8 = array.Length == 0;
				num = num3;
				roomConfig = null;
				if (flag8)
				{
					goto IL_05cf;
				}
				object obj15 = array + 32;
				obj15 = text;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object text2 = "Material with texture name \"" + 1576;
				LocalizableText text3 = TextMeshProExtensions.LocalizeWith((string)text2, array);
				object obj16 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
				object obj17 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v22+E4]");
				bool flag9 = (nint)0 == 0;
				object obj18 = !flag9;
				if (obj18 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Toast.Show(text3, (Vector2)0, 0f);
				bool flag10 = (object)prizeInputContainer == null;
				num = unchecked((nint)null);
				roomConfig = null;
				if (!flag10)
				{
					Transform go = prizeInputContainer.transform;
					RectTransform rect = UIExtensions.rectTransform(go);
					object obj19 = typeof(SqlSingle[]) + 3912;
					object obj20 = obj19;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v25+E4]");
					bool flag11 = (nint)0 == 0;
					object obj21 = !flag11;
					if (obj21 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					AnimationExtensions.ErrorFeedback(rect);
					return;
				}
			}
		}
		goto IL_05c1;
		IL_05dd:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_01ec:
		current = RemoteConfig.Current;
		bool flag12 = current == null;
		object obj22 = !flag12;
		if (obj22 != null)
		{
			goto IL_02e9;
		}
		goto IL_05c1;
	}

	private void UpdatePrize()
	{
		//IL_005d: Expected O, but got I
		//IL_0081: Expected O, but got I4
		FriendlyChallengeRoomConfig roomConfig = _roomConfig;
		string text2;
		if (roomConfig.<PrizeAmount>k__BackingField != 0)
		{
			int num = default(int);
			string text = num.ToString();
			text2 = text;
		}
		else
		{
			object obj = (nint)0 + (nint)2000;
			text2 = (string)obj;
			bool flag = (object)prizeInput == null;
			object obj2 = !flag;
			if (obj2 == null)
			{
				throw new NullReferenceException();
			}
		}
		prizeInput.Text = text2;
	}

	public void SetPrizeAmount(string _)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0072: Expected O, but got I4
		UIExtensions.EnsureNumeric(prizeInput);
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
		string text = prizeInput.Text;
		int result;
		bool flag = int.TryParse(text, out result);
		FriendlyChallengeRoomConfig roomConfig = _roomConfig;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v8+E4]");
		bool flag2 = (nint)0 == 0;
		object obj3 = !flag2;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int <PrizeAmount>k__BackingField = Math.Max(0, result);
		roomConfig.<PrizeAmount>k__BackingField = <PrizeAmount>k__BackingField;
		FriendlyChallengeRoomConfig roomConfig2 = _roomConfig;
		TextMeshProExtensions.SetNumber(prizeText, roomConfig2.<PrizeAmount>k__BackingField, useCommas: true);
		FriendlyChallengeRoomConfig roomConfig3 = _roomConfig;
		int challengeCreationFees = RoomCreator.GetChallengeCreationFees(roomConfig3.<PrizeAmount>k__BackingField);
		TextMeshProExtensions.SetNumber(feesText, challengeCreationFees, useCommas: true);
		FriendlyChallengeRoomConfig roomConfig4 = _roomConfig;
		int challengeCreationPrice = RoomCreator.GetChallengeCreationPrice(roomConfig4.<PrizeAmount>k__BackingField);
		TextMeshProExtensions.SetNumber(totalPriceText, challengeCreationPrice, useCommas: true);
	}

	private void UpdateCheatingRadio()
	{
		FriendlyChallengeRoomConfig roomConfig = _roomConfig;
		int index = (roomConfig.<CheatingAllowed>k__BackingField ? 1 : 0) ^ 1;
		ToggleGroupExtensions.SetSelectedIndex(CheatingRadio, index);
	}

	private void UpdateSpeedRadio()
	{
		//IL_0022: Expected O, but got I4
		//IL_003c: Expected O, but got I4
		FriendlyChallengeRoomConfig roomConfig = _roomConfig;
		object obj = roomConfig.<PlayingSpeed>k__BackingField - 30;
		bool flag = obj == null;
		object obj2 = !flag;
		object obj3 = ~obj2;
		int num = ((obj3 != null) ? 3 : 0);
		int num2 = ((roomConfig.<PlayingSpeed>k__BackingField != 10) ? num : 2);
		ToggleGroupExtensions.SetSelectedIndex(index: (roomConfig.<PlayingSpeed>k__BackingField == 5) ? 1 : num2, group: SpeedRadio);
	}

	private void Refresh()
	{
		//IL_0077: Expected O, but got I
		//IL_0050: Expected O, but got I4
		//IL_00e6: Expected O, but got I4
		//IL_0100: Expected O, but got I4
		FriendlyChallengeRoomConfig roomConfig = _roomConfig;
		string text2;
		if (roomConfig.<PrizeAmount>k__BackingField != 0)
		{
			int num = default(int);
			string text = num.ToString();
			bool flag = (object)prizeInput == null;
			object obj = !flag;
			text2 = text;
			if (obj == null)
			{
				throw new NullReferenceException();
			}
		}
		else
		{
			object obj2 = (nint)0 + (nint)2000;
			text2 = (string)obj2;
		}
		prizeInput.Text = text2;
		FriendlyChallengeRoomConfig roomConfig2 = _roomConfig;
		int index = (roomConfig2.<CheatingAllowed>k__BackingField ? 1 : 0) ^ 1;
		ToggleGroupExtensions.SetSelectedIndex(CheatingRadio, index);
		FriendlyChallengeRoomConfig roomConfig3 = _roomConfig;
		object obj3 = roomConfig3.<PlayingSpeed>k__BackingField - 30;
		bool flag2 = obj3 == null;
		object obj4 = !flag2;
		object obj5 = ~obj4;
		int num2 = ((obj5 != null) ? 3 : 0);
		int num3 = ((roomConfig3.<PlayingSpeed>k__BackingField != 10) ? num2 : 2);
		ToggleGroupExtensions.SetSelectedIndex(index: (roomConfig3.<PlayingSpeed>k__BackingField == 5) ? 1 : num3, group: SpeedRadio);
		UpdateAvatar();
	}

	private unsafe void UpdateAvatar()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected I4, but got Unknown
		object aiName = "{0} color encoding is currently unsupported for outputting to HDR." + 2392;
		computer1Avatar.InitializeAI((string)aiName);
		object aiName2 = "{0} color encoding is currently unsupported for outputting to HDR." + 2400;
		computer2Avatar.InitializeAI((string)aiName2);
		int num = this + 168;
		string dbId = ((int*)num)->ToString();
		yourOpponentAvatar.InitializeFriendWithDbId(dbId);
	}

	private bool HaveEnoughAces()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00d1: Expected O, but got I
		//IL_00fb: Expected O, but got I4
		//IL_00ac: Expected O, but got I4
		//IL_0053: Expected O, but got I
		//IL_035e: Expected I4, but got O
		//IL_02f8: Expected O, but got I4
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Expected I4, but got Unknown
		//IL_022d: Expected O, but got I4
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected O, but got Unknown
		//IL_02ce: Expected O, but got I4
		//IL_036b: Expected I8, but got I4
		object obj = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E76D8]");
		object obj2 = (nint)0 & (nint)1;
		object obj5;
		object obj3;
		if (obj2 != null)
		{
			obj3 = (nint)0 + (nint)2200;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v24+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v24+E4]");
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
		SessionModel sessionModel = default(SessionModel);
		bool flag3 = (object)sessionModel == null;
		obj3 = obj5;
		if (!flag3)
		{
			goto IL_014f;
		}
		goto IL_0350;
		IL_0350:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_02eb:
		int aces;
		int challengeCreationPrice;
		object obj7 = aces - challengeCreationPrice;
		bool flag4 = (nint)obj7 < 0;
		int num = aces ^ challengeCreationPrice;
		int num2 = aces ^ obj7;
		int num3 = num & num2;
		bool flag5 = num3 < 0;
		return flag4 == flag5;
		IL_014f:
		User localUser = sessionModel.LocalUser;
		aces = SFSKammelnaUserExtensions.GetAces(localUser);
		FriendlyChallengeRoomConfig roomConfig = _roomConfig;
		if (_roomConfig != null)
		{
			challengeCreationPrice = RoomCreator.GetChallengeCreationPrice(roomConfig.<PrizeAmount>k__BackingField);
			if (aces >= challengeCreationPrice)
			{
				goto IL_02eb;
			}
			FriendlyChallengeRoomConfig roomConfig2 = _roomConfig;
			if (_roomConfig != null)
			{
				int challengeCreationPrice2 = RoomCreator.GetChallengeCreationPrice(roomConfig2.<PrizeAmount>k__BackingField);
				object obj8 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X0_v12+E4]");
				bool flag6 = (nint)0 == 0;
				object obj9 = !flag6;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				SessionModel sessionModel2 = default(SessionModel);
				if ((object)sessionModel2 != null)
				{
					User localUser2 = sessionModel2.LocalUser;
					int aces2 = SFSKammelnaUserExtensions.GetAces(localUser2);
					object obj10 = typeof(MemberAchievementClanFeedData) + 2608;
					object obj11 = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X8_v10+E4]");
					bool flag7 = (nint)0 == 0;
					object obj12 = !flag7;
					if (obj12 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					long remaining = challengeCreationPrice2 - aces2;
					NotEnoughAcesPopup.ShowNotEnoughAces(remaining, TrackingFeature.FriendlyChallenge);
					goto IL_02eb;
				}
			}
		}
		goto IL_0350;
		IL_0088:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag8 = (object)sessionModel == null;
		object obj13 = !flag8;
		if (obj13 != null)
		{
			goto IL_014f;
		}
		goto IL_0350;
	}

	private bool PrizeIsValid()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00da: Expected O, but got I4
		//IL_0097: Expected O, but got I4
		//IL_0175: Expected O, but got I4
		//IL_0397: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Expected O, but got Unknown
		//IL_01f8: Expected O, but got I
		//IL_03ca: Expected O, but got I
		//IL_02d0: Expected O, but got I4
		//IL_03e7: Expected I4, but got O
		//IL_0265: Expected O, but got I4
		//IL_031a: Expected O, but got I4
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Expected I4, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E776E]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v30+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v30+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		RemoteConfigModel current = RemoteConfig.Current;
		goto IL_0100;
		IL_02f6:
		RemoteConfigModel current2;
		FriendlyChallengeConfig <FriendlyChallenge>k__BackingField = current2.<FriendlyChallenge>k__BackingField;
		int <PrizeAmount>k__BackingField;
		object obj5 = <PrizeAmount>k__BackingField - <FriendlyChallenge>k__BackingField.<MinimumPrize>k__BackingField;
		bool flag2 = (nint)obj5 < 0;
		int num = <PrizeAmount>k__BackingField ^ <FriendlyChallenge>k__BackingField.<MinimumPrize>k__BackingField;
		int num2 = <PrizeAmount>k__BackingField ^ obj5;
		int num3 = num & num2;
		bool flag3 = num3 < 0;
		return flag2 == flag3;
		IL_0242:
		current2 = RemoteConfig.Current;
		bool flag4 = current2 == null;
		object obj6 = !flag4;
		if (obj6 != null)
		{
			goto IL_02f6;
		}
		goto IL_037d;
		IL_037d:
		throw new NullReferenceException();
		IL_0074:
		current = RemoteConfig.Current;
		bool flag5 = current == null;
		object obj7 = !flag5;
		if (obj7 != null)
		{
			goto IL_0100;
		}
		goto IL_037d;
		IL_0100:
		FriendlyChallengeConfig <FriendlyChallenge>k__BackingField2 = current.<FriendlyChallenge>k__BackingField;
		if (<FriendlyChallenge>k__BackingField2.<PrizeCondition>k__BackingField != TournamentConfig.PrizeCondition.Disallowed)
		{
			if (<FriendlyChallenge>k__BackingField2.<PrizeCondition>k__BackingField != TournamentConfig.PrizeCondition.Optional)
			{
				bool flag6 = <FriendlyChallenge>k__BackingField2.<PrizeCondition>k__BackingField == TournamentConfig.PrizeCondition.Required;
				object obj8 = !flag6;
				if (obj8 != null)
				{
					object obj9 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
					ex..ctor();
					object obj10 = (nint)0 + (nint)472;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
					OutOfMemoryException ex2 = new OutOfMemoryException();
					return (byte)(int)ex2 != 0;
				}
				FriendlyChallengeRoomConfig roomConfig = _roomConfig;
				<PrizeAmount>k__BackingField = roomConfig.<PrizeAmount>k__BackingField;
			}
			else
			{
				FriendlyChallengeRoomConfig roomConfig2 = _roomConfig;
				<PrizeAmount>k__BackingField = roomConfig2.<PrizeAmount>k__BackingField;
				if (roomConfig2.<PrizeAmount>k__BackingField == 0)
				{
					return true;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E776E]");
			object obj11 = (nint)0 & (nint)1;
			if (obj11 != null)
			{
				object obj12 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X0_v17+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0242;
				}
			}
			else
			{
				_ = 1;
				object obj12 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X0_v17+E4]");
				bool flag7 = (nint)0 == 0;
				object obj13 = !flag7;
				if (obj13 != null)
				{
					goto IL_0242;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			current2 = RemoteConfig.Current;
			goto IL_02f6;
		}
		FriendlyChallengeRoomConfig roomConfig3 = _roomConfig;
		return roomConfig3.<PrizeAmount>k__BackingField == 0;
	}

	public CreateChallengePopup()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1512;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		FriendlyChallengeRoomConfig friendlyChallengeRoomConfig = default(FriendlyChallengeRoomConfig);
		friendlyChallengeRoomConfig..ctor(0, cheatingAllowed: true, 5);
		object obj2 = this + 192;
		obj2 = friendlyChallengeRoomConfig;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}
}
