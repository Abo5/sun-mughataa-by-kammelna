using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class RecieveInvitePanel : MonoBehaviour
{
	public enum Skin
	{
		Normal = 1,
		Challenge
	}

	public Skin skin;

	private AvatarInitializer _avatarInitializer;

	private Button acceptButton;

	private Button denyButton;

	private Toggle ignoreInvitationToggle;

	private TextMeshProUGUI messageText;

	private ChallengeProgressBar progressBar;

	private AvatarInitializer rightChallenger;

	private RoomInfoIcons infoIcons;

	private Timer timer;

	private ChallengeEventsChannel eventsChannel;

	private SingleSound challengeCreatedSFX;

	private GameObject challengePrizeSection;

	private TextMeshProUGUI challengePrizeText;

	private RecieveInvitePopup _popup;

	public bool IgnoreToggleIsOn
	{
		get
		{
			//IL_0041: Expected I4, but got O
			Toggle toggle = ignoreInvitationToggle;
			if ((object)ignoreInvitationToggle != null)
			{
				return toggle.m_IsOn;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private void Awake()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		//IL_006f: Expected O, but got I
		//IL_0087: Expected I, but got O
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_0104: Expected O, but got I4
		//IL_014e: Expected O, but got I4
		//IL_0157: Expected O, but got I4
		//IL_0160: Expected O, but got I4
		//IL_0169: Expected O, but got I4
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected O, but got Unknown
		//IL_0268: Expected O, but got I
		//IL_0276: Expected I, but got O
		//IL_02be: Expected O, but got I4
		//IL_02c7: Expected O, but got I4
		//IL_02d0: Expected O, but got I4
		//IL_02d9: Expected O, but got I4
		//IL_02ea: Expected O, but got I4
		//IL_0334: Expected O, but got I4
		//IL_0345: Expected O, but got I4
		//IL_01a2: Expected O, but got I4
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected O, but got Unknown
		//IL_01da: Expected O, but got I
		//IL_01e8: Expected I, but got O
		Button button = acceptButton;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)1920;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		button.m_OnClick.AddListener(unityAction);
		Button button2 = denyButton;
		object obj3 = (nint)0 + (nint)1952;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction2 = default(UnityAction);
		unityAction2..ctor(this, (IntPtr)obj3);
		object obj4 = typeof(MemberAchievementClanFeedData) + 2976;
		button2.m_OnClick.AddListener(unityAction2);
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X8_v6+E4]");
		Action action;
		if ((nint)0 != 0)
		{
			bool flag = eventsChannel;
			bool flag2 = !flag;
			object obj6 = !flag2;
			action = null;
			Action action2 = null;
			if (obj6 == null)
			{
				goto IL_011c;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = eventsChannel;
			bool flag4 = !flag3;
			action = null;
			Action action2 = null;
			if (flag4)
			{
				goto IL_011c;
			}
		}
		object obj7 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj8 = (nint)0 + (nint)1928;
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj8);
		eventsChannel.OnChallengeWithdrawn += action3;
		UnityEngine.Object obj9 = timer;
		object obj10 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X8_v8+E4]");
		bool flag5 = (nint)0 == 0;
		object obj11 = !flag5;
		object obj12 = 0;
		object obj13 = 0;
		object obj14 = 0;
		action = action3;
		object obj15 = 0;
		UnityEngine.Object obj16 = timer;
		if (obj11 != null)
		{
			goto IL_0181;
		}
		goto IL_0302;
		IL_01b0:
		object obj17 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj18 = (nint)0 + (nint)1936;
		Action action4 = default(Action);
		action4..ctor(this, (IntPtr)obj18);
		timer.onTimeIsUp += action4;
		return;
		IL_0181:
		bool flag6 = obj9;
		bool flag7 = !flag6;
		object obj19 = 0;
		if (!flag7)
		{
			goto IL_01b0;
		}
		return;
		IL_0302:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag8 = obj16;
		bool flag9 = !flag8;
		object obj20 = !flag9;
		obj12 = obj14;
		obj19 = 0;
		obj13 = obj15;
		if (obj20 == null)
		{
			return;
		}
		goto IL_01b0;
		IL_011c:
		obj9 = timer;
		obj10 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X8_v8+E4]");
		bool flag10 = (nint)0 == 0;
		obj12 = 0;
		obj13 = 0;
		obj14 = 0;
		obj15 = 0;
		obj16 = timer;
		if (!flag10)
		{
			goto IL_0181;
		}
		goto IL_0302;
	}

	private void OnDestroy()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0147: Expected O, but got I4
		//IL_00b2: Expected O, but got I4
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_00e0: Expected O, but got I
		//IL_00f8: Expected I, but got O
		//IL_0191: Expected O, but got I4
		//IL_019a: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8C4A]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = eventsChannel;
			obj6 = eventsChannel;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = eventsChannel;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = eventsChannel;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		object obj9 = 0;
		if (obj8 == null)
		{
			return;
		}
		goto IL_00c0;
		IL_00c0:
		object obj10 = typeof(SqlSingle[]) + 2376;
		object obj11 = (nint)0 + (nint)1928;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj11);
		eventsChannel.OnChallengeWithdrawn -= action;
		return;
		IL_0091:
		bool flag5 = obj5;
		bool flag6 = !flag5;
		obj9 = 0;
		if (!flag6)
		{
			goto IL_00c0;
		}
	}

	public void Open(FriendProfile user, string message)
	{
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: true);
		Populate(user, message);
	}

	public void OpenChallenge(FriendlyChallengeInviteModel challenge, string msg)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00cf: Expected O, but got I4
		GameObject gameObject = base.gameObject;
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		gameObject.SetActive(value: true);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v5+E4]");
		if ((nint)0 != 0)
		{
			if ((bool)challengeCreatedSFX)
			{
				goto IL_007c;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag = challengeCreatedSFX;
			bool flag2 = !flag;
			object obj3 = !flag2;
			if (obj3 != null)
			{
				goto IL_007c;
			}
		}
		goto IL_008c;
		IL_008c:
		PopulateChallenge(challenge, msg);
		return;
		IL_007c:
		SoundChannel.PlaySFXSound(challengeCreatedSFX);
		goto IL_008c;
	}

	public void Close()
	{
		RecieveInvitePopup popup = _popup;
		popup.popupUi.ShrinkToParent();
	}

	public void HideContent()
	{
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: false);
	}

	private void Populate(FriendProfile u, string msg)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00d5: Expected O, but got I4
		TextMeshProExtensions.Localize(messageText, msg);
		AvatarData data = u;
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		_avatarInitializer.Initialize(data);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v8+E4]");
		if ((nint)0 != 0)
		{
			if (!(rightChallenger != null))
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag = rightChallenger != null;
			bool flag2 = !flag;
			object obj3 = !flag2;
			if (obj3 == null)
			{
				return;
			}
		}
		AvatarData data2 = u;
		rightChallenger.Initialize(data2);
	}

	private unsafe void PopulateChallenge(FriendlyChallengeInviteModel challenge, string msg)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_08c7: Expected O, but got I4
		//IL_0043: Expected O, but got I4
		//IL_0069: Expected O, but got I4
		//IL_0094: Expected O, but got I4
		//IL_00aa: Expected I, but got O
		//IL_00ba: Expected O, but got I
		//IL_00e3: Expected O, but got I
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		//IL_017d: Expected I, but got O
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected O, but got Unknown
		//IL_020e: Expected O, but got I4
		//IL_02e9: Expected I, but got O
		//IL_029f: Expected I, but got O
		//IL_0378: Expected O, but got I4
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_0385: Expected I4, but got Unknown
		//IL_03b3: Expected O, but got I4
		//IL_03d1: Expected I, but got O
		//IL_03de: Expected O, but got Ref
		//IL_0403: Expected O, but got Ref
		//IL_0480: Expected I, but got O
		//IL_0419: Expected I, but got O
		//IL_0429: Expected O, but got I
		//IL_0447: Expected I, but got O
		//IL_045c: Expected O, but got I
		//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04aa: Expected O, but got Unknown
		//IL_04b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b8: Expected O, but got Unknown
		//IL_0500: Expected I, but got O
		//IL_058a: Expected O, but got I4
		//IL_0683: Expected I, but got O
		//IL_073b: Expected O, but got I4
		//IL_0610: Expected O, but got I4
		//IL_0619: Expected O, but got I4
		//IL_06d9: Expected O, but got I4
		//IL_0758: Unknown result type (might be due to invalid IL or missing references)
		//IL_075d: Expected O, but got Unknown
		//IL_0787: Expected O, but got I4
		//IL_07d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07dc: Expected O, but got Unknown
		//IL_0806: Expected O, but got I4
		//IL_0846: Expected I, but got O
		object obj = typeof(TypeConverter<ushort, char>) + 3400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		bool flag = challenge == null;
		string text = (string)1;
		object obj3;
		string text4;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		nint num2;
		string text3 = default(string);
		if (!flag)
		{
			PlayerInfo <Challenger>k__BackingField = challenge.<Challenger>k__BackingField;
			bool flag2 = challenge.<Challenger>k__BackingField == null;
			text = (string)1;
			if (!flag2)
			{
				object[] array = default(object[]);
				bool flag3 = array == null;
				text = (string)1;
				if (!flag3)
				{
					bool flag4 = <Challenger>k__BackingField.<Name>k__BackingField == null;
					string text2 = (string)1;
					if (!flag4)
					{
						nint num = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v31 (Il2CppClass<System.Object[]>)+40]");
						text2 = (string)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag5 = ex == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v31 (Il2CppClass<System.Object[]>)+40]");
						text = (string)0;
						if (flag5)
						{
							goto IL_088f;
						}
					}
					bool flag6 = array.Length == 0;
					text = text2;
					if (flag6)
					{
						goto IL_0881;
					}
					object obj2 = array + 32;
					obj2 = <Challenger>k__BackingField.<Name>k__BackingField;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					TextMeshProExtensions.Localize(messageText, text3, array);
					AvatarData data = challenge.<Challenger>k__BackingField;
					bool flag7 = (object)_avatarInitializer == null;
					num2 = unchecked((nint)null);
					text3 = (string)(object)array;
					text = null;
					if (!flag7)
					{
						obj3 = typeof(MemberAchievementClanFeedData) + 2976;
						_avatarInitializer.Initialize(data);
						object obj4 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v9+E4]");
						if ((nint)0 != 0)
						{
							bool flag8 = rightChallenger != null;
							bool flag9 = !flag8;
							object obj5 = !flag9;
							text3 = null;
							if (obj5 != null)
							{
								goto IL_0277;
							}
							text4 = null;
							text = null;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							bool flag10 = rightChallenger != null;
							bool flag11 = !flag10;
							text3 = null;
							text4 = null;
							text = null;
							if (!flag11)
							{
								goto IL_0277;
							}
						}
						goto IL_02d3;
					}
				}
			}
		}
		goto IL_0873;
		IL_0277:
		AvatarData avatarData = challenge.<Challenger>k__BackingField;
		bool flag12 = (object)rightChallenger == null;
		num2 = unchecked((nint)null);
		text = null;
		if (!flag12)
		{
			rightChallenger.Initialize(avatarData);
			text4 = null;
			text = (string)(object)avatarData;
			goto IL_02d3;
		}
		goto IL_0873;
		IL_0881:
		ex = new IndexOutOfRangeException();
		goto IL_088f;
		IL_05ed:
		UnityEngine.Object obj6;
		bool flag13 = obj6;
		bool flag14 = !flag13;
		object obj7 = !flag14;
		object obj8 = 0;
		if (obj7 == null)
		{
			return;
		}
		goto IL_0749;
		IL_0873:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0881;
		IL_02d3:
		bool flag15 = (object)challengePrizeSection == null;
		num2 = unchecked((nint)null);
		text3 = text4;
		string text7;
		UnityEngine.Object obj18;
		object obj16;
		string text6;
		if (!flag15)
		{
			bool flag16 = challenge.<PrizeAmount>k__BackingField < 0;
			bool flag17 = challenge.<PrizeAmount>k__BackingField == 0;
			int num3 = challenge.<PrizeAmount>k__BackingField ^ challenge.<PrizeAmount>k__BackingField;
			int num4 = challenge.<PrizeAmount>k__BackingField & num3;
			bool flag18 = num4 < 0;
			bool flag19 = flag16 == flag18;
			object obj9 = !flag17;
			bool active = (byte)((flag19 & obj9) ? 1 : 0) != 0;
			challengePrizeSection.SetActive(active);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			object obj10 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object[] array2 = default(object[]);
			bool flag20 = array2 == null;
			num2 = unchecked((nint)null);
			text3 = null;
			int num5 = default(int);
			text = (string)(&num5);
			if (!flag20)
			{
				object obj11 = default(object);
				bool flag21 = obj11 == null;
				string text5 = (string)(&num5);
				if (!flag21)
				{
					nint num6 = (nint)array2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v30 (Il2CppClass<System.Object[]>)+40]");
					text5 = (string)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag22 = ex == null;
					num2 = unchecked((nint)null);
					text3 = null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v30 (Il2CppClass<System.Object[]>)+40]");
					text = (string)0;
					if (flag22)
					{
						goto IL_088f;
					}
				}
				bool flag23 = array2.Length == 0;
				num2 = unchecked((nint)null);
				text3 = null;
				text = text5;
				if (flag23)
				{
					goto IL_0881;
				}
				object obj12 = "AvailableVoices" + 3920;
				object obj13 = array2 + 32;
				obj13 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				text = (string)obj12;
				TextMeshProExtensions.Localize(challengePrizeText, (string)obj12, array2);
				bool flag24 = (object)progressBar == null;
				num2 = unchecked((nint)null);
				text3 = (string)(object)array2;
				if (!flag24)
				{
					int progress = -challenge.<ChallengeLevel>k__BackingField;
					progressBar.SetProgress(progress);
					object obj14 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X0_v32+E4]");
					if ((nint)0 != 0)
					{
						bool flag25 = infoIcons;
						bool flag26 = !flag25;
						object obj15 = !flag26;
						FriendlyChallengeInviteModel friendlyChallengeInviteModel = null;
						text = null;
						if (obj15 == null)
						{
							goto IL_05a2;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						bool flag27 = infoIcons;
						bool flag28 = !flag27;
						FriendlyChallengeInviteModel friendlyChallengeInviteModel = null;
						text = null;
						if (flag28)
						{
							goto IL_05a2;
						}
					}
					bool flag29 = (object)infoIcons == null;
					num2 = unchecked((nint)null);
					text3 = null;
					if (!flag29)
					{
						infoIcons.UpdateIcons(challenge);
						obj6 = timer;
						obj16 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X8_v26+E4]");
						bool flag30 = (nint)0 == 0;
						object obj17 = !flag30;
						text6 = null;
						text7 = null;
						FriendlyChallengeInviteModel friendlyChallengeInviteModel = challenge;
						obj18 = timer;
						if (obj17 != null)
						{
							goto IL_05ed;
						}
						goto IL_0703;
					}
				}
			}
		}
		goto IL_0873;
		IL_0749:
		object obj19 = typeof(DataRelation) + 712;
		object obj20 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X0_v35+E4]");
		bool flag31 = (nint)0 == 0;
		object obj21 = !flag31;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime now = DateTime.Now;
		TimeSpan timeSpan = challenge.<ExpiryTime>k__BackingField - now;
		object obj22 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
		object obj23 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X0_v41+E4]");
		bool flag32 = (nint)0 == 0;
		object obj24 = !flag32;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		TimeSpan timeSpan2 = default(TimeSpan);
		double totalSeconds = timeSpan2.TotalSeconds;
		bool flag33 = (object)timer == null;
		num2 = unchecked((nint)null);
		text3 = null;
		text = null;
		if (!flag33)
		{
			timer.StartTimer((float)totalSeconds);
			return;
		}
		goto IL_0873;
		IL_05a2:
		obj6 = timer;
		obj16 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X8_v26+E4]");
		bool flag34 = (nint)0 == 0;
		text6 = null;
		text7 = null;
		obj18 = timer;
		if (!flag34)
		{
			goto IL_05ed;
		}
		goto IL_0703;
		IL_0703:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag35 = obj18;
		bool flag36 = !flag35;
		text6 = text7;
		obj8 = 0;
		if (!flag36)
		{
			goto IL_0749;
		}
		return;
		IL_088f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
	}

	private void AcceptClicked()
	{
		_popup.SendAccept();
		RecieveInvitePopup popup = _popup;
		popup.popupUi.ShrinkToParent();
	}

	private void RejectClicked()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_006f: Expected I, but got O
		//IL_009e: Expected O, but got I4
		if (skin == Skin.Challenge)
		{
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = (nint)0 + (nint)1944;
			object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			object msgTitle = "Complete" + 256;
			object msgBody = "Added Tournament Prizes And Features" + 2144;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action action = default(Action);
			action..ctor(this, (IntPtr)obj2);
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v8+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PopupWindow.ShowNegativeConfirm((string)msgTitle, (string)msgBody, action);
		}
		else
		{
			_popup.SendReject();
			RecieveInvitePopup popup = _popup;
			popup.popupUi.ShrinkToParent();
		}
	}

	private void Reject()
	{
		_popup.SendReject();
		RecieveInvitePopup popup = _popup;
		popup.popupUi.ShrinkToParent();
	}

	private void OnChallengeWithdrawn()
	{
		RecieveInvitePopup popup = _popup;
		InvitationsNotifier notifier = popup.notifier;
		((List<object>)(object)notifier.pendingInvitations).RemoveAt(0);
		notifier.ReadNextInvite();
		RecieveInvitePopup popup2 = _popup;
		popup2.popupUi.ShrinkToParent();
	}

	private void OnTimeIsUp()
	{
		RecieveInvitePopup popup = _popup;
		InvitationsNotifier notifier = popup.notifier;
		((List<object>)(object)notifier.pendingInvitations).RemoveAt(0);
		notifier.ReadNextInvite();
		RecieveInvitePopup popup2 = _popup;
		popup2.popupUi.ShrinkToParent();
	}

	public void SetInvitePopup(RecieveInvitePopup ip)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		object obj = this + 144;
		obj = ip;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
