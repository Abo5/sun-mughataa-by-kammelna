using System;
using System.Buffers.Text;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using DataTracking;
using Kammelna.Server.Models.Clans;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class GameSoundButton : MonoBehaviour
{
	private Image soundIcon;

	private SpritesStore spriteStore;

	private BackgroundMusic backgroundMusic;

	private AnimatedRoomThemesController _animatedRoomController;

	private bool isBackgroundMusicAudible
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_010a: Expected O, but got I4
			//IL_0146: Expected O, but got I4
			object obj = 152985600;
			object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E66F4]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
				if ((nint)0 != 0)
				{
					goto IL_007d;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 != null)
				{
					goto IL_007d;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool gameSound = Preferences.GameSound;
			bool flag2 = !gameSound;
			object obj6 = !flag2;
			if (obj6 != null)
			{
				goto IL_009f;
			}
			goto IL_0154;
			IL_009f:
			object obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v11+E4]");
			if ((nint)0 != 0)
			{
				return Preferences.BackgroundMusic;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			return Preferences.BackgroundMusic;
			IL_0154:
			return gameSound;
			IL_007d:
			gameSound = Preferences.GameSound;
			if (gameSound)
			{
				goto IL_009f;
			}
			goto IL_0154;
		}
	}

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0191: Expected O, but got I
		//IL_019d: Expected O, but got I
		//IL_01c7: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_0104: Expected O, but got I
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00c7: Expected O, but got I
		//IL_00df: Expected I, but got O
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected O, but got Unknown
		//IL_0156: Expected O, but got I
		//IL_0164: Expected I, but got O
		//IL_017e: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = 0;
		object obj3 = (nint)0 + (nint)4088;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj6 = this + 48;
		object obj7 = default(object);
		obj6 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj8 = this + 56;
		object obj9 = default(object);
		obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if ((UnityEngine.Object)obj8 != null)
		{
			object obj10 = typeof(SqlSingle[]) + 2376;
			object obj11 = (nint)0 + (nint)2416;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action action = default(Action);
			action..ctor(this, (IntPtr)obj11);
			_animatedRoomController.OnElementsUpdated += action;
		}
		object obj12 = (nint)0 + (nint)944;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D321D8");
		object obj13 = default(object);
		if (obj13 != null)
		{
			object obj14 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj15 = (nint)0 + (nint)2424;
			UnityAction unityAction = default(UnityAction);
			unityAction..ctor(this, (IntPtr)obj15);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ stack_-38_v3+100]");
			((UnityEvent)0).AddListener(unityAction);
		}
		UpdateSoundIcon();
	}

	private void OnElementsUpdated()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0061: Expected O, but got I
		//IL_008b: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = 0;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj5 = this + 48;
		object obj6 = default(object);
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		ApplyBackgroundMusic();
	}

	private void ApplyBackgroundMusic()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00fb: Expected O, but got I4
		//IL_00b7: Expected O, but got I4
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected O, but got Unknown
		//IL_019a: Expected O, but got I
		//IL_0246: Expected O, but got I4
		//IL_0154: Expected O, but got I4
		//IL_015d: Expected O, but got I4
		//IL_0203: Expected O, but got I4
		//IL_030e: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E66F5]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v27+E4]");
			bool flag = (nint)0 == 0;
			obj5 = backgroundMusic;
			obj6 = backgroundMusic;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v27+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = backgroundMusic;
			obj6 = backgroundMusic;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6 == null;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		object obj9 = 0;
		UnityEngine.Object obj10 = null;
		if (obj8 != null)
		{
			return;
		}
		goto IL_0170;
		IL_01e4:
		bool gameSound = Preferences.GameSound;
		bool flag5 = !gameSound;
		object obj11 = !flag5;
		if (obj11 != null)
		{
			goto IL_0285;
		}
		goto IL_031c;
		IL_0285:
		object obj13;
		object obj12 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X0_v7+E4]");
		if ((nint)0 != 0)
		{
			if (Preferences.BackgroundMusic)
			{
				goto IL_02d4;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag6 = Preferences.BackgroundMusic;
			bool flag7 = !flag6;
			object obj14 = !flag7;
			if (obj14 != null)
			{
				goto IL_02d4;
			}
		}
		goto IL_031c;
		IL_031c:
		backgroundMusic.Pause();
		return;
		IL_0091:
		bool flag8 = obj5 == null;
		bool flag9 = !flag8;
		obj9 = 0;
		obj10 = null;
		if (!flag9)
		{
			return;
		}
		goto IL_0170;
		IL_0170:
		obj13 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E66F4]");
		object obj15 = (nint)0 & (nint)1;
		if (obj15 != null)
		{
			object obj16 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v15+E4]");
			if ((nint)0 != 0)
			{
				goto IL_01e4;
			}
		}
		else
		{
			_ = 1;
			object obj16 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v15+E4]");
			bool flag10 = (nint)0 == 0;
			object obj17 = !flag10;
			if (obj17 != null)
			{
				goto IL_01e4;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		if (Preferences.GameSound)
		{
			goto IL_0285;
		}
		goto IL_031c;
		IL_02d4:
		backgroundMusic.Play();
	}

	private void ToggleSound()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_083a: Unknown result type (might be due to invalid IL or missing references)
		//IL_083f: Expected O, but got Unknown
		//IL_0869: Expected O, but got I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_016b: Expected O, but got I4
		//IL_01b6: Expected O, but got I4
		//IL_07a3: Expected O, but got I4
		//IL_01ee: Expected O, but got I4
		//IL_00de: Expected O, but got I4
		//IL_012e: Expected O, but got I4
		//IL_02b9: Expected O, but got I4
		//IL_0268: Expected O, but got I4
		//IL_0271: Expected O, but got I4
		//IL_0357: Expected O, but got I4
		//IL_0493: Expected O, but got I4
		//IL_04a1: Expected O, but got I4
		//IL_0393: Expected O, but got I4
		//IL_039c: Expected O, but got I4
		//IL_03f4: Expected O, but got I4
		//IL_0441: Expected O, but got I4
		//IL_044a: Expected O, but got I4
		//IL_03b8: Expected O, but got I4
		//IL_050b: Expected O, but got I
		//IL_05b7: Expected O, but got I4
		//IL_0574: Expected O, but got I4
		//IL_0620: Expected O, but got I4
		//IL_073d: Expected O, but got I4
		//IL_0746: Expected O, but got I4
		//IL_06bc: Expected O, but got I4
		//IL_06d3: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		bool flag2 = backgroundMusic != null;
		object obj6 = obj2;
		bool flag5;
		bool gameSound2;
		object obj8;
		if (flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v6+E4]");
			if ((nint)0 != 0)
			{
				if (Preferences.GameSound)
				{
					goto IL_00b4;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool gameSound = Preferences.GameSound;
				bool flag3 = !gameSound;
				object obj7 = !flag3;
				if (obj7 != null)
				{
					goto IL_00b4;
				}
			}
			obj8 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v36+E4]");
			bool flag4 = (nint)0 == 0;
			flag5 = true;
			gameSound2 = true;
			if (!flag4)
			{
				goto IL_023b;
			}
			goto IL_0284;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v6+E4]");
		bool flag6 = (nint)0 == 0;
		object obj9 = !flag6;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool gameSound3 = Preferences.GameSound;
		bool gameSound4 = (byte)((gameSound3 ? 1u : 0u) ^ 1u) != 0;
		Preferences.GameSound = gameSound4;
		object obj10 = 0;
		UnityEngine.Object obj11 = null;
		goto IL_0773;
		IL_02c7:
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X0_v65+E4]");
		if ((nint)0 != 0)
		{
			if (Preferences.BackgroundMusic)
			{
				goto IL_031a;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag7 = Preferences.BackgroundMusic;
			bool flag8 = !flag7;
			object obj13 = !flag8;
			if (obj13 != null)
			{
				goto IL_031a;
			}
		}
		backgroundMusic.Play();
		UnityEngine.Object animatedRoomController = _animatedRoomController;
		object obj14 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X0_v54+E4]");
		bool flag9 = (nint)0 == 0;
		object obj15 = !flag9;
		object obj16 = 0;
		UnityEngine.Object animatedRoomController2 = _animatedRoomController;
		if (obj15 != null)
		{
			goto IL_036f;
		}
		goto IL_0462;
		IL_0284:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Preferences.GameSound = gameSound2;
		bool gameSound5 = Preferences.GameSound;
		bool flag10 = !gameSound5;
		object obj17 = 0;
		if (!flag10)
		{
			goto IL_02c7;
		}
		goto IL_031a;
		IL_0877:
		ITrackEvent trackEvent;
		Tracker.DesignEvent(trackEvent);
		object obj18;
		obj10 = obj18;
		obj11 = null;
		goto IL_0773;
		IL_0773:
		UpdateSoundIcon();
		object obj19 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X0_v9+E4]");
		bool flag11 = (nint)0 == 0;
		object obj20 = !flag11;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Preferences.GameSoundState soundState = Preferences.SoundState;
		ITrackEvent trackEvent2 = TrackerLibrary.GameSoundToggled(soundState);
		object obj21 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v7+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent2);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent2);
		return;
		IL_0555:
		bool gameSound6 = Preferences.GameSound;
		bool flag12 = !gameSound6;
		object obj22 = !flag12;
		if (obj22 != null)
		{
			goto IL_05f6;
		}
		goto IL_06e0;
		IL_06e0:
		AnimatedRoomThemesController animatedRoomController3 = _animatedRoomController;
		StoreItem activeItem = animatedRoomController3.activeItem;
		ITrackEvent trackEvent3 = TrackerLibrary.AnimatedRoomSoundToggledOff(activeItem.<name>k__BackingField);
		object obj23 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X8_v14+E4]");
		bool flag13 = (nint)0 == 0;
		object obj24 = !flag13;
		object obj25 = 0;
		trackEvent = trackEvent3;
		if (obj24 == null)
		{
			goto IL_075c;
		}
		goto IL_0877;
		IL_0462:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag14 = animatedRoomController2 != null;
		bool flag15 = !flag14;
		obj18 = 0;
		UnityEngine.Object obj26 = null;
		obj10 = 0;
		obj11 = null;
		if (!flag15)
		{
			goto IL_04b4;
		}
		goto IL_0773;
		IL_031a:
		backgroundMusic.Pause();
		obj14 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X0_v54+E4]");
		bool flag16 = (nint)0 == 0;
		animatedRoomController = _animatedRoomController;
		obj16 = 0;
		animatedRoomController2 = _animatedRoomController;
		if (!flag16)
		{
			goto IL_036f;
		}
		goto IL_0462;
		IL_075c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		trackEvent = trackEvent3;
		goto IL_0877;
		IL_00b4:
		object obj27 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v89+E4]");
		bool flag17 = (nint)0 == 0;
		object obj28 = !flag17;
		if (obj28 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		flag5 = Preferences.BackgroundMusic;
		obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v36+E4]");
		bool flag18 = (nint)0 == 0;
		object obj29 = !flag18;
		if (obj29 != null)
		{
			goto IL_023b;
		}
		gameSound2 = flag5;
		goto IL_0284;
		IL_04b4:
		AnimatedRoomThemesController animatedRoomController4 = _animatedRoomController;
		bool flag19 = animatedRoomController4.activeItem == null;
		obj10 = obj18;
		obj11 = obj26;
		if (!flag19)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E66F4]");
			object obj30 = (nint)0 & (nint)1;
			if (obj30 != null)
			{
				object obj31 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X0_v42+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0555;
				}
			}
			else
			{
				_ = 1;
				object obj31 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X0_v42+E4]");
				bool flag20 = (nint)0 == 0;
				object obj32 = !flag20;
				if (obj32 != null)
				{
					goto IL_0555;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (Preferences.GameSound)
			{
				goto IL_05f6;
			}
			goto IL_06e0;
		}
		goto IL_0773;
		IL_036f:
		bool flag21 = animatedRoomController != null;
		bool flag22 = !flag21;
		object obj33 = !flag22;
		obj18 = 0;
		obj26 = null;
		if (obj33 != null)
		{
			goto IL_04b4;
		}
		obj10 = 0;
		obj11 = null;
		goto IL_0773;
		IL_023b:
		Preferences.GameSound = flag5;
		bool gameSound7 = Preferences.GameSound;
		bool flag23 = !gameSound7;
		object obj34 = !flag23;
		obj17 = 0;
		if (obj34 != null)
		{
			goto IL_02c7;
		}
		goto IL_031a;
		IL_05f6:
		object obj35 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X0_v35+E4]");
		bool flag24 = (nint)0 == 0;
		object obj36 = !flag24;
		if (obj36 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!Preferences.BackgroundMusic)
		{
			goto IL_06e0;
		}
		AnimatedRoomThemesController animatedRoomController5 = _animatedRoomController;
		StoreItem activeItem2 = animatedRoomController5.activeItem;
		trackEvent = TrackerLibrary.AnimatedRoomSoundToggledOn(activeItem2.<name>k__BackingField);
		obj23 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X8_v14+E4]");
		bool flag25 = (nint)0 == 0;
		object obj37 = !flag25;
		if (obj37 == null)
		{
			obj25 = 0;
			trackEvent3 = trackEvent;
			goto IL_075c;
		}
		goto IL_0877;
	}

	private void UpdateSoundIcon()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0282: Expected O, but got I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0148: Expected O, but got I4
		//IL_01ac: Expected O, but got I4
		//IL_0203: Expected O, but got I4
		//IL_00d5: Expected O, but got I4
		//IL_00e5: Expected O, but got I
		//IL_010b: Expected O, but got I4
		//IL_0224: Expected O, but got I4
		//IL_0234: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		Sprite sprite;
		Image image;
		if (backgroundMusic == null)
		{
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v17+E4]");
			if ((nint)0 != 0)
			{
				bool gameSound = Preferences.GameSound;
				SpritesStore spritesStore = spriteStore;
				bool flag2 = !gameSound;
				SpritesStore spritesStore2 = spriteStore;
				if (!flag2)
				{
					goto IL_00cc;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool gameSound2 = Preferences.GameSound;
				SpritesStore spritesStore = spriteStore;
				bool flag3 = !gameSound2;
				object obj6 = !flag3;
				SpritesStore spritesStore2 = spriteStore;
				if (obj6 != null)
				{
					goto IL_00cc;
				}
			}
			object obj7 = 64;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v8 (SpritesStore)+v101 @ X9_v3]");
			sprite = (Sprite)0;
			image = soundIcon;
		}
		else
		{
			object obj8 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v9+E4]");
			bool flag4 = (nint)0 == 0;
			object obj9 = !flag4;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Preferences.GameSoundState soundState = Preferences.SoundState;
			Sprite gameSoundSprite = spriteStore.GetGameSoundSprite(soundState);
			image = soundIcon;
			bool flag5 = (object)soundIcon == null;
			object obj10 = !flag5;
			sprite = gameSoundSprite;
			if (obj10 == null)
			{
				goto IL_0251;
			}
		}
		goto IL_0243;
		IL_0243:
		image.sprite = sprite;
		return;
		IL_0251:
		throw new NullReferenceException();
		IL_00cc:
		object obj11 = 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v10 (SpritesStore)+v100 @ X9_v4]");
		sprite = (Sprite)0;
		image = soundIcon;
		bool flag6 = (object)soundIcon == null;
		object obj12 = !flag6;
		if (obj12 != null)
		{
			goto IL_0243;
		}
		goto IL_0251;
	}
}
