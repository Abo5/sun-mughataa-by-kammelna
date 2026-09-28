using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Server.Models;
using Unity.Properties;
using UnityEngine;
using UnityEngine.UI;

public class MenuWinSection : MonoBehaviour
{
	private sealed class <>c__DisplayClass18_0
	{
		public SpriteToggler toggler;

		internal void <ApplyTogglerAlternative>b__0(bool ok)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_00bf: Expected O, but got I4
			//IL_00c8: Expected O, but got I4
			//IL_006e: Expected O, but got I4
			//IL_0184: Expected O, but got I4
			if (!ok)
			{
				return;
			}
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3+E4]");
			if ((nint)0 != 0)
			{
				bool flag = toggler == null;
				bool flag2 = !flag;
				object obj3 = 0;
				UnityEngine.Object obj4 = null;
				if (!flag2)
				{
					return;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag3 = toggler == null;
				bool flag4 = !flag3;
				object obj5 = !flag4;
				object obj3 = 0;
				UnityEngine.Object obj4 = null;
				if (obj5 != null)
				{
					return;
				}
			}
			SpriteToggler spriteToggler = toggler;
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v7+E4]");
			if ((nint)0 != 0)
			{
				if (spriteToggler.imageReference == null)
				{
					return;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag5 = spriteToggler.imageReference == null;
				bool flag6 = !flag5;
				object obj7 = !flag6;
				if (obj7 != null)
				{
					return;
				}
			}
			SpriteToggler spriteToggler2 = toggler;
			Image imageReference = spriteToggler2.imageReference;
			spriteToggler2.SetAlternativeSprite(imageReference.m_Sprite);
		}
	}

	private sealed class <>c__DisplayClass19_0
	{
		public bool active;

		internal void <Toggle>b__0(BaseToggler toggle)
		{
			toggle.ToggleManual(active);
		}
	}

	private List<BaseToggler> miniGameButton;

	private List<BaseToggler> predictAndWinButton;

	private SpriteToggler predictAndWinButtonToggler;

	private Image predictAndWinButtonIconImage;

	private Image predictAndWinButtonTextImage;

	private SpriteToggler predictAndWinButtonTogglerTablet;

	private Image predictAndWinButtonIconImageTablet;

	private Image predictAndWinButtonTextImageTablet;

	private Sprite _defaultPwIconSprite;

	private Sprite _defaultPwTextSprite;

	private Sprite _defaultPwIconSpriteTablet;

	private Sprite _defaultPwTextSpriteTablet;

	private void Awake()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_027e: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Expected O, but got Unknown
		//IL_034c: Expected O, but got I4
		//IL_012b: Expected O, but got I4
		//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c5: Expected O, but got Unknown
		//IL_0410: Expected O, but got I4
		//IL_01a2: Expected O, but got I4
		//IL_0484: Unknown result type (might be due to invalid IL or missing references)
		//IL_0489: Expected O, but got Unknown
		//IL_04d4: Expected O, but got I4
		//IL_051e: Expected O, but got I4
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Expected O, but got Unknown
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6305]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v32+E4]");
			bool flag = (nint)0 == 0;
			obj5 = predictAndWinButtonIconImage;
			obj6 = predictAndWinButtonIconImage;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v32+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = predictAndWinButtonIconImage;
			obj6 = predictAndWinButtonIconImage;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		Sprite sprite = null;
		if (flag4)
		{
			goto IL_00c7;
		}
		goto IL_02da;
		IL_021c:
		Image image = predictAndWinButtonTextImageTablet;
		object obj8 = this + 120;
		obj8 = image.m_Sprite;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return;
		IL_01f6:
		UnityEngine.Object obj9;
		if ((bool)obj9)
		{
			goto IL_021c;
		}
		return;
		IL_04ec:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object obj10;
		bool flag5 = obj10;
		bool flag6 = !flag5;
		object obj11 = !flag6;
		if (obj11 == null)
		{
			return;
		}
		goto IL_021c;
		IL_0091:
		bool flag7 = obj5;
		bool flag8 = !flag7;
		object obj12 = !flag8;
		sprite = null;
		if (obj12 == null)
		{
			goto IL_00c7;
		}
		goto IL_02da;
		IL_02da:
		Image image2 = predictAndWinButtonIconImage;
		sprite = image2.m_Sprite;
		object obj13 = this + 96;
		obj13 = image2.m_Sprite;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		UnityEngine.Object obj14 = predictAndWinButtonTextImage;
		object obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X0_v23+E4]");
		bool flag9 = (nint)0 == 0;
		object obj16 = !flag9;
		UnityEngine.Object obj17 = predictAndWinButtonTextImage;
		if (obj16 != null)
		{
			goto IL_0108;
		}
		goto IL_0364;
		IL_00c7:
		obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X0_v23+E4]");
		bool flag10 = (nint)0 == 0;
		obj14 = predictAndWinButtonTextImage;
		obj17 = predictAndWinButtonTextImage;
		if (!flag10)
		{
			goto IL_0108;
		}
		goto IL_0364;
		IL_0364:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag11 = obj17;
		bool flag12 = !flag11;
		Sprite sprite2 = null;
		if (flag12)
		{
			goto IL_013e;
		}
		goto IL_039e;
		IL_0108:
		bool flag13 = obj14;
		bool flag14 = !flag13;
		object obj18 = !flag14;
		sprite2 = null;
		if (obj18 == null)
		{
			goto IL_013e;
		}
		goto IL_039e;
		IL_039e:
		Image image3 = predictAndWinButtonTextImage;
		sprite2 = image3.m_Sprite;
		object obj19 = this + 104;
		obj19 = image3.m_Sprite;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		UnityEngine.Object obj20 = predictAndWinButtonIconImageTablet;
		object obj21 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X0_v14+E4]");
		bool flag15 = (nint)0 == 0;
		object obj22 = !flag15;
		UnityEngine.Object obj23 = predictAndWinButtonIconImageTablet;
		if (obj22 != null)
		{
			goto IL_017f;
		}
		goto IL_0428;
		IL_013e:
		obj21 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X0_v14+E4]");
		bool flag16 = (nint)0 == 0;
		obj20 = predictAndWinButtonIconImageTablet;
		obj23 = predictAndWinButtonIconImageTablet;
		if (!flag16)
		{
			goto IL_017f;
		}
		goto IL_0428;
		IL_0428:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag17 = obj23;
		bool flag18 = !flag17;
		Sprite sprite3 = null;
		if (flag18)
		{
			goto IL_01b5;
		}
		goto IL_0462;
		IL_017f:
		bool flag19 = obj20;
		bool flag20 = !flag19;
		object obj24 = !flag20;
		sprite3 = null;
		if (obj24 == null)
		{
			goto IL_01b5;
		}
		goto IL_0462;
		IL_0462:
		Image image4 = predictAndWinButtonIconImageTablet;
		sprite3 = image4.m_Sprite;
		object obj25 = this + 112;
		obj25 = image4.m_Sprite;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj9 = predictAndWinButtonTextImageTablet;
		object obj26 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v4+E4]");
		bool flag21 = (nint)0 == 0;
		object obj27 = !flag21;
		obj10 = predictAndWinButtonTextImageTablet;
		if (obj27 != null)
		{
			goto IL_01f6;
		}
		goto IL_04ec;
		IL_01b5:
		obj9 = predictAndWinButtonTextImageTablet;
		obj26 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v4+E4]");
		bool flag22 = (nint)0 == 0;
		obj10 = predictAndWinButtonTextImageTablet;
		if (!flag22)
		{
			goto IL_01f6;
		}
		goto IL_04ec;
	}

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		//IL_0129: Expected I, but got O
		//IL_0063: Expected O, but got I4
		//IL_00a6: Expected I, but got O
		//IL_00d0: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)1264;
		object obj3 = typeof(RegisteredWaitHandle) + 56;
		object obj4 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2856;
		OnConfigChanged();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RemoteConfig.OnChanged += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj2);
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v10+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ContentPushService.OnUpcomingPredictionsApplied += action2;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		//IL_00eb: Expected I, but got O
		//IL_0115: Expected O, but got I4
		//IL_006e: Expected I, but got O
		//IL_0098: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)1264;
		object obj3 = typeof(RegisteredWaitHandle) + 56;
		object obj4 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2856;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RemoteConfig.OnChanged -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj2);
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v9+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ContentPushService.OnUpcomingPredictionsApplied -= action2;
	}

	private void OnConfigChanged()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00c3: Expected O, but got I4
		//IL_0044: Expected O, but got I4
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_00fb: Expected O, but got I4
		//IL_008d: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 784;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool canPlayMiniGameNow = MiniGameInfo.CanPlayMiniGameNow;
		((MenuWinSection)canPlayMiniGameNow).Toggle(miniGameButton, canPlayMiniGameNow);
		object obj4 = typeof(System.Buffers.Text.ParserHelpers) + 1544;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool isGlowInMainMenu = PredictAndWinManager.IsGlowInMainMenu;
		((MenuWinSection)isGlowInMainMenu).Toggle(predictAndWinButton, isGlowInMainMenu);
		ApplyConfigImages();
	}

	private void ApplyConfigImages()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_02c7: Expected O, but got I4
		//IL_0307: Expected O, but got I4
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_00f3: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6308]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v2+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		SFSConfig currentSFS = Config.CurrentSFS;
		bool flag2 = currentSFS == null;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			return;
		}
		goto IL_00a3;
		IL_00a3:
		LastRequestUpdateModel <LastRequestUpdates>k__BackingField = currentSFS.<LastRequestUpdates>k__BackingField;
		object obj7 = typeof(RegisteredWaitHandle) + 56;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v16+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RemoteConfigModel current = RemoteConfig.Current;
		PredictionsConfig <Predictions>k__BackingField = current.<Predictions>k__BackingField;
		ApplyTogglerAlternative(predictAndWinButtonToggler, <Predictions>k__BackingField.<PredictAndWinButtonImage>k__BackingField, <LastRequestUpdates>k__BackingField.<ClientVisualsRequestUpdate>k__BackingField);
		RemoteConfigModel current2 = RemoteConfig.Current;
		PredictionsConfig <Predictions>k__BackingField2 = current2.<Predictions>k__BackingField;
		ApplyTogglerAlternative(predictAndWinButtonTogglerTablet, <Predictions>k__BackingField2.<PredictAndWinButtonImageTablet>k__BackingField, <LastRequestUpdates>k__BackingField.<ClientVisualsRequestUpdate>k__BackingField);
		RemoteConfigModel current3 = RemoteConfig.Current;
		PredictionsConfig <Predictions>k__BackingField3 = current3.<Predictions>k__BackingField;
		ApplyImage(predictAndWinButtonIconImage, <Predictions>k__BackingField3.<PredictAndWinButtonIconImage>k__BackingField, _defaultPwIconSprite, <LastRequestUpdates>k__BackingField.<ClientVisualsRequestUpdate>k__BackingField);
		RemoteConfigModel current4 = RemoteConfig.Current;
		PredictionsConfig <Predictions>k__BackingField4 = current4.<Predictions>k__BackingField;
		ApplyImage(predictAndWinButtonTextImage, <Predictions>k__BackingField4.<PredictAndWinButtonTextImage>k__BackingField, _defaultPwTextSprite, <LastRequestUpdates>k__BackingField.<ClientVisualsRequestUpdate>k__BackingField);
		RemoteConfigModel current5 = RemoteConfig.Current;
		PredictionsConfig <Predictions>k__BackingField5 = current5.<Predictions>k__BackingField;
		ApplyImage(predictAndWinButtonIconImageTablet, <Predictions>k__BackingField5.<PredictAndWinButtonIconImageTablet>k__BackingField, _defaultPwIconSpriteTablet, <LastRequestUpdates>k__BackingField.<ClientVisualsRequestUpdate>k__BackingField);
		RemoteConfigModel current6 = RemoteConfig.Current;
		PredictionsConfig <Predictions>k__BackingField6 = current6.<Predictions>k__BackingField;
		ApplyImage(predictAndWinButtonTextImageTablet, <Predictions>k__BackingField6.<PredictAndWinButtonTextImageTablet>k__BackingField, _defaultPwTextSpriteTablet, <LastRequestUpdates>k__BackingField.<ClientVisualsRequestUpdate>k__BackingField);
		return;
		IL_007d:
		currentSFS = Config.CurrentSFS;
		if (currentSFS != null)
		{
			goto IL_00a3;
		}
	}

	private static void ApplyImage(Image image, string url, Sprite defaultSprite, DateTime timestamp)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00e7: Expected O, but got I4
		//IL_00a3: Expected O, but got I4
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		//IL_012c: Expected O, but got I4
		//IL_0135: Expected O, but got I4
		//IL_0266: Expected O, but got I4
		//IL_026f: Expected O, but got I4
		//IL_01aa: Expected O, but got I4
		//IL_01e2: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6309]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v19+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v19+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = image == null;
		bool flag3 = !flag2;
		object obj6 = !flag3;
		object obj7 = 0;
		UnityEngine.Object obj8 = null;
		if (obj6 != null)
		{
			return;
		}
		goto IL_0148;
		IL_01b8:
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X0_v10+E4]");
		bool flag4 = (nint)0 == 0;
		object obj10 = !flag4;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (defaultSprite != null)
		{
			image.sprite = defaultSprite;
		}
		return;
		IL_0148:
		object obj11 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v2+E4]");
		if ((nint)0 != 0)
		{
			bool flag5 = StringsExtensions.IsNullOrEmpty(url);
			bool flag6 = !flag5;
			object obj13 = 0;
			if (!flag6)
			{
				goto IL_01b8;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag7 = StringsExtensions.IsNullOrEmpty(url);
			bool flag8 = !flag7;
			object obj14 = !flag8;
			object obj13 = 0;
			if (obj14 != null)
			{
				goto IL_01b8;
			}
		}
		DateTime? timestamp2 = timestamp;
		UIExtensions.LoadImage(image, url, url, setNative: false, storeLocally: true, timestamp2);
		return;
		IL_007d:
		bool flag9 = image == null;
		bool flag10 = !flag9;
		obj7 = 0;
		obj8 = null;
		if (!flag10)
		{
			return;
		}
		goto IL_0148;
	}

	private static void ApplyTogglerAlternative(SpriteToggler toggler, string url, DateTime timestamp)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_00eb: Expected O, but got I4
		//IL_00f4: Expected O, but got I4
		//IL_00a0: Expected O, but got I4
		//IL_01ae: Expected O, but got I
		//IL_01d1: Expected O, but got I4
		//IL_01da: Expected O, but got I4
		//IL_0153: Expected O, but got I
		//IL_0171: Expected O, but got I4
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected O, but got Unknown
		//IL_0188: Expected O, but got I4
		//IL_02a8: Expected O, but got I4
		//IL_02ca: Expected O, but got I
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Expected O, but got Unknown
		//IL_0306: Expected O, but got I
		//IL_0317: Expected I, but got O
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3416;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj4 = obj2 + 16;
		obj4 = toggler;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v8+E4]");
		if ((nint)0 != 0)
		{
			bool flag = (UnityEngine.Object)obj4 == null;
			bool flag2 = !flag;
			object obj6 = 0;
			UnityEngine.Object obj7 = null;
			if (!flag2)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = (UnityEngine.Object)obj4 == null;
			bool flag4 = !flag3;
			object obj8 = !flag4;
			object obj6 = 0;
			UnityEngine.Object obj7 = null;
			if (obj8 != null)
			{
				return;
			}
		}
		object obj9 = obj4;
		object obj10 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X0_v10+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v5+30]");
			bool flag5 = (UnityEngine.Object)0 == null;
			bool flag6 = !flag5;
			object obj11 = !flag6;
			if (obj11 != null)
			{
				return;
			}
			object obj12 = 0;
			UnityEngine.Object obj13 = null;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v5+30]");
			bool flag7 = (UnityEngine.Object)0 == null;
			bool flag8 = !flag7;
			object obj14 = !flag8;
			object obj12 = 0;
			UnityEngine.Object obj13 = null;
			if (obj14 != null)
			{
				return;
			}
		}
		object obj15 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		object obj16 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X0_v12+E4]");
		SpriteToggler spriteToggler;
		SpriteToggler spriteToggler2;
		if ((nint)0 != 0)
		{
			bool flag9 = StringsExtensions.IsNullOrEmpty(url);
			spriteToggler = (SpriteToggler)obj4;
			bool flag10 = !flag9;
			spriteToggler2 = (SpriteToggler)obj4;
			if (!flag10)
			{
				goto IL_0264;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag11 = StringsExtensions.IsNullOrEmpty(url);
			spriteToggler = (SpriteToggler)obj4;
			bool flag12 = !flag11;
			object obj17 = !flag12;
			spriteToggler2 = (SpriteToggler)obj4;
			if (obj17 != null)
			{
				goto IL_0264;
			}
		}
		object obj18 = (nint)0 + (nint)2264;
		DateTime? timestamp2 = timestamp;
		object obj19 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj20 = (nint)0 + (nint)1440;
		Action<bool> action = default(Action<bool>);
		action..ctor(obj2, (IntPtr)obj20);
		UIExtensions.LoadImage(spriteToggler2.imageReference, url, url, setNative: false, storeLocally: true, timestamp2);
		return;
		IL_0264:
		spriteToggler.RestoreAlternativeSpriteToPrefab();
	}

	private void Toggle(List<BaseToggler> buttonComponents, bool active)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0059: Expected I, but got O
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3424;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1280;
		object obj4 = (nint)0 + (nint)1448;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		((List<object>)(object)buttonComponents).ForEach(action);
	}

	private static bool MiniGameActive()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00b2: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 784;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E63B4]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v1+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		return MiniGameInfo.CanPlayMiniGameNow;
		IL_0074:
		return MiniGameInfo.CanPlayMiniGameNow;
	}

	private static bool PredictAndWinActive()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00b2: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1544;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E63B5]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v1+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		return PredictAndWinManager.IsGlowInMainMenu;
		IL_0074:
		return PredictAndWinManager.IsGlowInMainMenu;
	}

	public static void UpdateCounter()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_006b: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3312;
		int newCount = ActivePrizesCount();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CounterBubbleManager.UpdateCounter(CounterBubbleType.Prizes, newCount);
	}

	private static void UpdatePrizeCounter()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_006b: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3312;
		int newCount = ActivePrizesCount();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CounterBubbleManager.UpdateCounter(CounterBubbleType.Prizes, newCount);
	}

	private static int ActivePrizesCount()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_02e3: Expected O, but got I4
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Expected O, but got Unknown
		//IL_030d: Expected O, but got I
		//IL_01c8: Expected O, but got I4
		//IL_02d0: Expected I4, but got O
		//IL_0208: Expected O, but got I4
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_00a8: Expected O, but got I
		//IL_00c0: Expected O, but got I4
		//IL_025a: Expected O, but got I4
		//IL_021f: Expected O, but got I4
		//IL_011e: Expected O, but got I8
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_015b: Expected O, but got I
		//IL_0167: Expected O, but got I
		//IL_0184: Expected I, but got O
		//IL_029a: Expected O, but got I8
		//IL_02b4: Expected O, but got I4
		object obj = typeof(TypeConverter<ushort, char>) + 1832;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj2 = 152985600;
		object obj3 = typeof(MemberAchievementClanFeedData) + 784;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E63B4]");
		object obj4 = (nint)0 & (nint)1;
		if (obj4 != null)
		{
			object obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v17+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0046;
			}
		}
		else
		{
			_ = 1;
			object obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v17+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			if (obj6 != null)
			{
				goto IL_0046;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool canPlayMiniGameNow = MiniGameInfo.CanPlayMiniGameNow;
		object obj7 = default(object);
		bool flag2 = obj7 == null;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			object obj9 = 152985600;
			throw new NullReferenceException();
		}
		goto IL_0054;
		IL_013b:
		object obj10 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 336;
		object obj11 = (nint)0 + (nint)3248;
		object obj12 = (nint)0 + (nint)3488;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<bool, bool> func = default(Func<bool, bool>);
		func..ctor((object)null, (IntPtr)obj11);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DBC554");
		int result = default(int);
		return result;
		IL_00fb:
		bool isGlowInMainMenu = PredictAndWinManager.IsGlowInMainMenu;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+18]");
		object obj13 = 0 & 0xFFFFFFFEL;
		if (obj13 != null)
		{
			goto IL_013b;
		}
		goto IL_02c2;
		IL_0054:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+18]");
		if ((nint)0 != 0)
		{
			object obj9 = typeof(System.Buffers.Text.ParserHelpers) + 1544;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E63B5]");
			object obj14 = (nint)0 & (nint)1;
			bool flag3 = obj14 == null;
			obj3 = 152985600;
			if (!flag3)
			{
				object obj15 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X0_v6+E4]");
				if ((nint)0 != 0)
				{
					goto IL_00fb;
				}
			}
			else
			{
				_ = 1;
				object obj15 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X0_v6+E4]");
				bool flag4 = (nint)0 == 0;
				object obj16 = !flag4;
				if (obj16 != null)
				{
					goto IL_00fb;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			isGlowInMainMenu = PredictAndWinManager.IsGlowInMainMenu;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+18]");
			object obj17 = 0 & 0xFFFFFFFEL;
			bool flag5 = obj17 == null;
			object obj18 = !flag5;
			if (obj18 != null)
			{
				goto IL_013b;
			}
		}
		goto IL_02c2;
		IL_02c2:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		return (int)ex;
		IL_0046:
		canPlayMiniGameNow = MiniGameInfo.CanPlayMiniGameNow;
		goto IL_0054;
	}
}
