using System;
using System.Buffers.Text;
using System.Data;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using DataTracking;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using ListView;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class ChallengeMessageStrip : ChatMessageStrip
{
	private GameObject watchState;

	private GameObject challengeMessageGameObject;

	private Button watchButton;

	private TextMeshProUGUI challengeMessage;

	private ChallengeProgressBar progressBar;

	private ChallengeStateLightSwitch lightSwitch;

	private AvatarInitializer rightAvatar;

	private AvatarInitializer leftAvatar;

	private int _finalResult;

	private FriendlyChallengeData _data;

	private void Awake()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		Button button = watchButton;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)3536;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		button.m_OnClick.AddListener(unityAction);
	}

	public override void Setup(ChatMessageDataHolder datum, bool firstTime)
	{
		//IL_000c: Expected O, but got I
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		object obj = (nint)0 + (nint)1528;
		((ListViewItem<object, int>)(object)this).Setup((object)datum, firstTime);
		ChatMessageData <message>k__BackingField = datum.<message>k__BackingField;
		object obj2 = this + 200;
		obj2 = <message>k__BackingField.<ChallengeData>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if (firstTime)
		{
			GameObject gameObject = base.gameObject;
			object obj3 = "Cannot populate JSON object onto type '{0}'." + 2040;
			gameObject.name = (string)obj3;
		}
		if (obj2 != null)
		{
			Populate();
		}
	}

	public override float GetHeightForText(string text)
	{
		//IL_0006: Expected F4, but got I4
		return 1.1294474E+09f;
	}

	private void Populate()
	{
		FriendlyChallengeData friendlyChallengeData = _data;
		_finalResult = friendlyChallengeData.<ChallengeLevel>k__BackingField;
		progressBar.SetProgress(friendlyChallengeData.<ChallengeLevel>k__BackingField);
		FriendlyChallengeData friendlyChallengeData2 = _data;
		AvatarData avatarData = friendlyChallengeData2.<Challenger>k__BackingField;
		rightAvatar.Initialize(avatarData);
		FriendlyChallengeData friendlyChallengeData3 = _data;
		AvatarData avatarData2 = friendlyChallengeData3.<Defender>k__BackingField;
		leftAvatar.Initialize(avatarData2);
		lightSwitch.ShowLight(_finalResult);
		UpdateWatchState();
		UpdateChallengeMessage();
	}

	private void FirstTimeSetup()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		GameObject gameObject = base.gameObject;
		object obj = "Cannot populate JSON object onto type '{0}'." + 2040;
		gameObject.name = (string)obj;
	}

	private void UpdateWatchState()
	{
		//IL_0075: Expected O, but got I
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_00b2: Expected O, but got I4
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_00d1: Expected I4, but got O
		FriendlyChallengeData friendlyChallengeData = _data;
		bool flag5;
		if (friendlyChallengeData.<State>k__BackingField == ChallengeAnnouncementState.Accepted)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3 (FriendlyChallengeData)+2C]");
			bool flag = (nint)0 < (nint)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3 (FriendlyChallengeData)+2C]");
			bool flag2 = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3 (FriendlyChallengeData)+2C]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3 (FriendlyChallengeData)+2C]");
			object obj = num ^ 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3 (FriendlyChallengeData)+2C]");
			object obj2 = 0 & obj;
			bool flag3 = (nint)obj2 < 0;
			bool flag4 = flag == flag3;
			object obj3 = !flag2;
			object obj4 = flag4 & obj3;
			flag5 = (byte)(obj4 & (object?)friendlyChallengeData.<RoomId>k__BackingField) != 0;
		}
		else
		{
			flag5 = false;
		}
		watchState.SetActive(flag5);
		watchButton.interactable = flag5;
	}

	private void UpdateChallengeMessage()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00ec: Expected I, but got O
		//IL_010e: Expected O, but got I4
		//IL_00bc: Expected O, but got I4
		//IL_0058: Expected I, but got O
		//IL_024a: Expected O, but got I4
		//IL_025a: Expected O, but got I
		//IL_026a: Expected O, but got I
		//IL_02fa: Expected O, but got I4
		//IL_030a: Expected O, but got I
		//IL_031a: Expected O, but got I
		//IL_1087: Expected O, but got I4
		//IL_109a: Expected O, but got I4
		//IL_10dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e2: Expected I4, but got Unknown
		//IL_02d5: Expected O, but got I4
		//IL_021b: Expected O, but got I4
		//IL_0926: Unknown result type (might be due to invalid IL or missing references)
		//IL_092b: Expected O, but got Unknown
		//IL_093f: Expected O, but got I
		//IL_034e: Expected O, but got I4
		//IL_0361: Expected O, but got I4
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a9: Expected I4, but got Unknown
		//IL_0db3: Expected O, but got I
		//IL_0dc9: Expected O, but got I
		//IL_0dd2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd7: Expected O, but got Unknown
		//IL_0df1: Expected O, but got I4
		//IL_0e79: Expected O, but got I
		//IL_065c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0661: Expected O, but got Unknown
		//IL_0678: Unknown result type (might be due to invalid IL or missing references)
		//IL_067d: Expected O, but got Unknown
		//IL_06ab: Expected O, but got I4
		//IL_054d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0552: Expected O, but got Unknown
		//IL_0569: Unknown result type (might be due to invalid IL or missing references)
		//IL_056e: Expected O, but got Unknown
		//IL_0590: Expected O, but got I4
		//IL_0990: Expected O, but got I
		//IL_09a6: Expected O, but got I
		//IL_09af: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b4: Expected O, but got Unknown
		//IL_0a50: Expected O, but got I
		//IL_03f2: Expected O, but got I4
		//IL_0f85: Expected O, but got I
		//IL_0f9b: Expected O, but got I
		//IL_0fa4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa9: Expected O, but got Unknown
		//IL_0ec3: Expected O, but got I4
		//IL_06d8: Expected O, but got I4
		//IL_0743: Expected O, but got I4
		//IL_05a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ac: Expected O, but got Unknown
		//IL_05d8: Expected O, but got I8
		//IL_0b3d: Expected O, but got I
		//IL_0b53: Expected O, but got I
		//IL_0b5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b61: Expected O, but got Unknown
		//IL_0b7b: Expected O, but got I4
		//IL_0c0b: Expected O, but got I
		//IL_117b: Expected O, but got I4
		//IL_1184: Expected O, but got I4
		//IL_0604: Unknown result type (might be due to invalid IL or missing references)
		//IL_0609: Expected O, but got Unknown
		//IL_0623: Expected O, but got I4
		//IL_040a: Unknown result type (might be due to invalid IL or missing references)
		//IL_040f: Expected O, but got Unknown
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_042b: Expected O, but got Unknown
		//IL_044d: Expected O, but got I4
		//IL_0cb8: Expected O, but got I
		//IL_0ce6: Expected O, but got I4
		//IL_104e: Expected O, but got I
		//IL_077c: Expected I4, but got I8
		//IL_0796: Expected O, but got I4
		//IL_113c: Expected O, but got I4
		//IL_07f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f6: Expected O, but got Unknown
		//IL_0818: Expected O, but got I4
		//IL_0464: Unknown result type (might be due to invalid IL or missing references)
		//IL_0469: Expected O, but got Unknown
		//IL_0495: Expected O, but got I8
		//IL_07bb: Expected O, but got I4
		//IL_07cb: Expected O, but got I
		//IL_07db: Expected O, but got I
		//IL_04c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c6: Expected O, but got Unknown
		//IL_04fe: Expected O, but got I4
		//IL_052e: Expected O, but got I4
		object obj = 152993792;
		object[] array = (object[])(typeof(MemberAchievementClanFeedData) + 2976);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8A1B]");
		object obj2 = (nint)0 & (nint)1;
		UnityEngine.Object obj4;
		UnityEngine.Object obj3;
		if (obj2 != null)
		{
			nint num = (nint)array;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X0_v78 (Il2CppClass<System.Object[]>)+E4]");
			bool flag = (nint)0 == 0;
			obj3 = challengeMessageGameObject;
			nint num2 = num;
			obj4 = challengeMessageGameObject;
			if (!flag)
			{
				goto IL_0099;
			}
		}
		else
		{
			_ = 1;
			obj3 = challengeMessageGameObject;
			nint num2 = (nint)array;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v49 (Il2CppClass<System.Object[]>)+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			obj4 = challengeMessageGameObject;
			if (obj5 != null)
			{
				goto IL_0099;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj4;
		bool flag4 = !flag3;
		string text = null;
		obj3 = obj4;
		if (!flag4)
		{
			goto IL_0168;
		}
		return;
		IL_0877:
		UnityEngine.Object obj6;
		bool flag5 = (object)obj6 == null;
		bool active = !flag5;
		GameObject gameObject;
		gameObject.SetActive(active);
		object[] array2;
		if ((object)obj6 != null)
		{
			if (array2 != null && array2.Length != 0)
			{
				TextMeshProExtensions.Localize(challengeMessage, (string)(object)obj6, array2);
			}
			else
			{
				TextMeshProExtensions.Localize(challengeMessage, (string)(object)obj6);
			}
		}
		return;
		IL_0b1b:
		object[] array3;
		object obj7 = array3[3];
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ X8_v20 (System.Object)+10]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ X8_v20 (System.Object)+10]");
		object obj9 = (nint)0 + (nint)309;
		object obj10 = obj9 & 1;
		bool flag6 = obj10 == null;
		object obj11 = !flag6;
		object obj13;
		object obj12 = obj13;
		bool flag8;
		bool flag7 = flag8;
		object obj15;
		object obj14 = obj15;
		bool flag10;
		bool flag9 = flag10;
		int num4;
		int num3 = num4;
		int num6;
		int num5 = num6;
		int num8;
		int num7 = num8;
		bool flag12;
		bool flag11 = flag12;
		bool flag14;
		bool flag13 = flag14;
		object obj17;
		object obj16 = obj17;
		object obj19;
		object obj18 = obj19;
		string text3;
		string text2 = text3;
		string text5;
		string text4 = text5;
		ChallengeAnnouncementState challengeAnnouncementState2;
		ChallengeAnnouncementState challengeAnnouncementState = challengeAnnouncementState2;
		string text6;
		text = text6;
		obj3 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ X8_v20 (System.Object)+10]");
		object obj20 = 0;
		if (obj11 == null)
		{
			goto IL_0c19;
		}
		goto IL_0ca8;
		IL_0c19:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		obj13 = obj12;
		flag8 = flag7;
		obj15 = obj14;
		flag10 = flag9;
		num4 = num3;
		num6 = num5;
		num8 = num7;
		flag12 = flag11;
		flag14 = flag13;
		obj17 = obj16;
		obj19 = obj18;
		text3 = text2;
		text5 = text4;
		challengeAnnouncementState2 = challengeAnnouncementState;
		text6 = text;
		obj6 = obj3;
		goto IL_0ca8;
		IL_0099:
		bool flag15 = obj3;
		bool flag16 = !flag15;
		object obj21 = !flag16;
		text = null;
		if (obj21 == null)
		{
			return;
		}
		goto IL_0168;
		IL_0168:
		FriendlyChallengeData friendlyChallengeData = _data;
		PlayerInfo <Defender>k__BackingField;
		string text7;
		if (_data != null)
		{
			PlayerInfo <Challenger>k__BackingField = friendlyChallengeData.<Challenger>k__BackingField;
			if (friendlyChallengeData.<Challenger>k__BackingField != null)
			{
				text4 = <Challenger>k__BackingField.<Name>k__BackingField;
				if (<Challenger>k__BackingField.<Name>k__BackingField != null)
				{
					<Defender>k__BackingField = friendlyChallengeData.<Defender>k__BackingField;
					bool flag17 = friendlyChallengeData.<Defender>k__BackingField == null;
					object obj22 = !flag17;
					if (obj22 != null)
					{
						goto IL_02a9;
					}
					text7 = <Challenger>k__BackingField.<Name>k__BackingField;
					goto IL_02eb;
				}
			}
			object obj23 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X9_v21+90]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X9_v22+B8]");
			object obj25 = 0;
			text4 = (string)obj25;
			<Defender>k__BackingField = friendlyChallengeData.<Defender>k__BackingField;
			bool flag18 = friendlyChallengeData.<Defender>k__BackingField == null;
			text7 = (string)obj25;
			if (!flag18)
			{
				goto IL_02a9;
			}
			goto IL_02eb;
		}
		goto IL_0d7c;
		IL_0ca8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v555 @ X0_v14+B8]");
		object obj26 = 0;
		array2 = (object[])obj26;
		gameObject = challengeMessageGameObject;
		bool flag19 = (object)challengeMessageGameObject == null;
		object obj27 = !flag19;
		obj12 = obj13;
		flag7 = flag8;
		obj14 = obj15;
		flag9 = flag10;
		num3 = num4;
		num5 = num6;
		num7 = num8;
		flag11 = flag12;
		flag13 = flag14;
		obj16 = obj17;
		obj18 = obj19;
		text2 = text3;
		text4 = text5;
		challengeAnnouncementState = challengeAnnouncementState2;
		text = text6;
		array = (object[])obj26;
		obj3 = obj6;
		if (obj27 != null)
		{
			goto IL_0877;
		}
		goto IL_0d7c;
		IL_0a6e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X0_v3+E4]");
		bool flag20 = (nint)0 == 0;
		obj13 = obj12;
		flag8 = flag7;
		obj15 = obj14;
		flag10 = flag9;
		num4 = num3;
		num6 = num5;
		num8 = num7;
		flag12 = flag11;
		flag14 = flag13;
		obj17 = obj16;
		obj19 = obj18;
		text3 = text2;
		text5 = text4;
		challengeAnnouncementState2 = challengeAnnouncementState;
		text6 = text;
		array3 = array;
		obj6 = obj3;
		if (!flag20)
		{
			goto IL_0b1b;
		}
		goto IL_0f59;
		IL_110c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		gameObject = challengeMessageGameObject;
		bool flag21 = (object)challengeMessageGameObject == null;
		object obj28 = !flag21;
		obj6 = obj3;
		if (obj28 != null)
		{
			goto IL_0877;
		}
		text = text4;
		array = array2;
		goto IL_0d7c;
		IL_0f59:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj29 = array[3];
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ X8_v6 (System.Object)+10]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ X8_v6 (System.Object)+10]");
		object obj30 = (nint)0 + (nint)309;
		object obj31 = obj30 & 1;
		if (obj31 == null)
		{
			goto IL_0c19;
		}
		obj13 = obj12;
		flag8 = flag7;
		obj15 = obj14;
		flag10 = flag9;
		num4 = num3;
		num6 = num5;
		num8 = num7;
		flag12 = flag11;
		flag14 = flag13;
		obj17 = obj16;
		obj19 = obj18;
		text3 = text2;
		text5 = text4;
		challengeAnnouncementState2 = challengeAnnouncementState;
		text6 = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ X8_v6 (System.Object)+10]");
		obj20 = 0;
		obj6 = obj3;
		goto IL_0ca8;
		IL_02a9:
		text2 = <Defender>k__BackingField.<Name>k__BackingField;
		bool flag22 = <Defender>k__BackingField.<Name>k__BackingField == null;
		object obj32 = !flag22;
		text7 = text4;
		if (obj32 == null)
		{
			goto IL_02eb;
		}
		goto IL_105b;
		IL_0d7c:
		throw new NullReferenceException();
		IL_02eb:
		object obj33 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ X9_v16+90]");
		object obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X9_v17+B8]");
		object obj35 = 0;
		text2 = (string)obj35;
		text4 = text7;
		goto IL_105b;
		IL_105b:
		challengeAnnouncementState = friendlyChallengeData.<State>k__BackingField;
		bool flag23 = friendlyChallengeData.<State>k__BackingField < ChallengeAnnouncementState.Ended;
		obj18 = !flag23;
		obj16 = friendlyChallengeData.<State>k__BackingField - 3;
		flag13 = (nint)obj16 < 0;
		flag11 = friendlyChallengeData.<State>k__BackingField == ChallengeAnnouncementState.Ended;
		num7 = (int)(friendlyChallengeData.<State>k__BackingField ^ ChallengeAnnouncementState.Ended);
		num5 = friendlyChallengeData.<State>k__BackingField ^ obj16;
		num3 = num7 & num5;
		flag9 = num3 < 0;
		if (!flag11)
		{
			bool flag24 = friendlyChallengeData.<State>k__BackingField < ChallengeAnnouncementState.Rejected;
			obj18 = !flag24;
			obj16 = friendlyChallengeData.<State>k__BackingField - 1;
			flag13 = (nint)obj16 < 0;
			flag11 = friendlyChallengeData.<State>k__BackingField == ChallengeAnnouncementState.Rejected;
			num7 = (int)(friendlyChallengeData.<State>k__BackingField ^ ChallengeAnnouncementState.Rejected);
			num5 = friendlyChallengeData.<State>k__BackingField ^ obj16;
			num3 = num7 & num5;
			flag9 = num3 < 0;
			if (!flag11)
			{
				bool flag25 = friendlyChallengeData.<State>k__BackingField == ChallengeAnnouncementState.Requested;
				object obj36 = !flag25;
				if (obj36 == null)
				{
					object obj37 = "fetch_products" + 1336;
					obj3 = (UnityEngine.Object)obj37;
					object obj38 = typeof(SqlSingle[]) + 32;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
					object[] array4 = default(object[]);
					bool flag26 = array4 == null;
					text = (string)2;
					if (!flag26)
					{
						obj14 = array4 + 32;
						obj14 = text4;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X24_v14-8]");
						object obj39 = 0 & 0xFFFFFFFEL;
						flag13 = (nint)obj39 < 0;
						flag11 = obj39 == null;
						object obj40 = array4 + 40;
						obj40 = text2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						gameObject = challengeMessageGameObject;
						bool flag27 = (object)challengeMessageGameObject == null;
						object obj41 = !flag27;
						array2 = array4;
						obj6 = (UnityEngine.Object)obj37;
						if (obj41 != null)
						{
							goto IL_0877;
						}
						flag9 = false;
						obj18 = 0;
						text = text2;
						array = array4;
					}
				}
				else
				{
					gameObject = challengeMessageGameObject;
					bool flag28 = (object)challengeMessageGameObject == null;
					array2 = null;
					obj6 = null;
					array = null;
					obj3 = null;
					if (!flag28)
					{
						goto IL_0877;
					}
				}
			}
			else
			{
				object obj42 = "fetch_products" + 1344;
				obj3 = (UnityEngine.Object)obj42;
				object obj43 = typeof(SqlSingle[]) + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
				object[] array5 = default(object[]);
				bool flag29 = array5 == null;
				text = (string)2;
				if (!flag29)
				{
					obj14 = array5 + 32;
					obj14 = text2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X24_v14-8]");
					object obj44 = 0 & 0xFFFFFFFEL;
					flag13 = (nint)obj44 < 0;
					flag11 = obj44 == null;
					object obj45 = array5 + 40;
					obj45 = text4;
					flag9 = false;
					obj18 = 0;
					array2 = array5;
					goto IL_110c;
				}
			}
		}
		else
		{
			if (friendlyChallengeData.<ChallengeLevel>k__BackingField == 0)
			{
				object obj46 = "fetch_products" + 1352;
				obj3 = (UnityEngine.Object)obj46;
				object obj47 = (nint)0 + (nint)3336;
				array = (object[])obj47;
				object obj48 = array[3];
				if (array[3] != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X8_v35 (System.Object)+10]");
					object obj49 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X8_v35 (System.Object)+10]");
					object obj50 = (nint)0 + (nint)309;
					object obj51 = obj50 & 1;
					bool flag30 = obj51 == null;
					obj13 = obj12;
					flag8 = flag7;
					obj15 = obj14;
					flag10 = flag9;
					num4 = num3;
					num6 = num5;
					num8 = num7;
					flag12 = flag11;
					flag14 = flag13;
					obj17 = obj16;
					obj19 = obj18;
					text3 = text2;
					text5 = text4;
					challengeAnnouncementState2 = friendlyChallengeData.<State>k__BackingField;
					text6 = text;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X8_v35 (System.Object)+10]");
					object obj52 = 0;
					array3 = array;
					obj6 = (UnityEngine.Object)obj46;
					if (!flag30)
					{
						goto IL_0a6e;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
					object obj53 = array[3];
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X8_v12 (System.Object)+10]");
					object obj49 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X8_v12 (System.Object)+10]");
					object obj54 = (nint)0 + (nint)309;
					object obj55 = obj54 & 1;
					bool flag31 = obj55 == null;
					object obj56 = !flag31;
					obj13 = obj12;
					flag8 = flag7;
					obj15 = obj14;
					flag10 = flag9;
					num4 = num3;
					num6 = num5;
					num8 = num7;
					flag12 = flag11;
					flag14 = flag13;
					obj17 = obj16;
					obj19 = obj18;
					text3 = text2;
					text5 = text4;
					challengeAnnouncementState2 = challengeAnnouncementState;
					text6 = text;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X8_v12 (System.Object)+10]");
					object obj52 = 0;
					array3 = array;
					obj6 = obj3;
					if (obj56 != null)
					{
						goto IL_0a6e;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X0_v3+E4]");
				bool flag32 = (nint)0 == 0;
				object obj57 = !flag32;
				obj12 = obj13;
				flag7 = flag8;
				obj14 = obj15;
				flag9 = flag10;
				num3 = num4;
				num5 = num6;
				num7 = num8;
				flag11 = flag12;
				flag13 = flag14;
				obj16 = obj17;
				obj18 = obj19;
				text2 = text3;
				text4 = text5;
				challengeAnnouncementState = challengeAnnouncementState2;
				text = text6;
				array = array3;
				obj3 = obj6;
				if (obj57 != null)
				{
					goto IL_0b1b;
				}
				goto IL_0f59;
			}
			object obj58 = "fetch_products" + 1360;
			obj3 = (UnityEngine.Object)obj58;
			object obj59 = typeof(SqlSingle[]) + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			FriendlyChallengeData friendlyChallengeData2 = _data;
			bool flag33 = _data == null;
			text = (string)1;
			if (!flag33)
			{
				bool flag34 = friendlyChallengeData2.<ChallengeLevel>k__BackingField < 0;
				obj18 = !flag34;
				flag13 = friendlyChallengeData2.<ChallengeLevel>k__BackingField < 0;
				flag11 = friendlyChallengeData2.<ChallengeLevel>k__BackingField == 0;
				num5 = friendlyChallengeData2.<ChallengeLevel>k__BackingField ^ friendlyChallengeData2.<ChallengeLevel>k__BackingField;
				num3 = friendlyChallengeData2.<ChallengeLevel>k__BackingField & num5;
				flag9 = num3 < 0;
				obj12 = !flag11;
				if (friendlyChallengeData2.<ChallengeLevel>k__BackingField <= 0)
				{
					int num9 = (int)(friendlyChallengeData2.<ChallengeLevel>k__BackingField & 0x80000000L);
					bool flag35 = num9 == 0;
					object obj60 = !flag35;
					text4 = text2;
					if (obj60 == null)
					{
						object obj61 = 153100288 + 1024;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v617 @ X8_v47+90]");
						object obj62 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v618 @ X8_v48+B8]");
						object obj63 = 0;
						text4 = (string)obj63;
					}
				}
				object[] array6 = default(object[]);
				bool flag36 = array6 == null;
				num7 = friendlyChallengeData2.<ChallengeLevel>k__BackingField;
				obj16 = friendlyChallengeData2.<ChallengeLevel>k__BackingField;
				text = (string)1;
				array = array6;
				if (!flag36)
				{
					object obj45 = array6 + 32;
					obj45 = text4;
					num7 = friendlyChallengeData2.<ChallengeLevel>k__BackingField;
					obj16 = friendlyChallengeData2.<ChallengeLevel>k__BackingField;
					array2 = array6;
					goto IL_110c;
				}
			}
		}
		goto IL_0d7c;
	}

	private string GetWinnerName(string challengerName, string defenderName)
	{
		//IL_006a: Expected I4, but got I8
		//IL_0084: Expected O, but got I4
		//IL_00a1: Expected O, but got I4
		//IL_00b1: Expected O, but got I
		//IL_00c1: Expected O, but got I
		FriendlyChallengeData friendlyChallengeData = _data;
		if (_data != null)
		{
			if (friendlyChallengeData.<ChallengeLevel>k__BackingField <= 0)
			{
				int num = (int)(friendlyChallengeData.<ChallengeLevel>k__BackingField & 0x80000000L);
				bool flag = num == 0;
				object obj = !flag;
				if (obj == null)
				{
					object obj2 = 153100288 + 1024;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v4+90]");
					object obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v5+B8]");
					return (string)0;
				}
			}
			return defenderName;
		}
		return (string)(object)new NullReferenceException();
	}

	private void OnWatchClicked()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_0163: Expected O, but got I4
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_007c: Expected O, but got I4
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected O, but got Unknown
		//IL_0209: Expected O, but got I4
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_00e9: Expected O, but got I4
		//IL_00f9: Expected O, but got I
		//IL_0109: Expected O, but got I
		//IL_011f: Expected I4, but got I8
		FriendlyChallengeData friendlyChallengeData = _data;
		if (_data == null)
		{
			return;
		}
		object obj = (??)friendlyChallengeData.<RoomId>k__BackingField & 1;
		if (obj != null)
		{
			ITrackEvent trackEvent = TrackerLibrary.MenuChallengeRoomWatched();
			object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v13+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Tracker.DesignEvent(trackEvent);
			object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v10+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object msgBody = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 3144;
			PopupWindow.ShowLoading((string)msgBody);
			int? num = default(int?);
			int value = num.Value;
			object obj8 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v24+90]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v25+B8]");
			object password = 0;
			SFS.JoinGameRoom(value, -1, (string)password);
		}
		else
		{
			object obj10 = typeof(DataRelation) + 856;
			object obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v3+E4]");
			bool flag3 = (nint)0 == 0;
			object obj12 = !flag3;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object message = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 1464;
			Debug.LogWarning(message);
		}
	}
}
