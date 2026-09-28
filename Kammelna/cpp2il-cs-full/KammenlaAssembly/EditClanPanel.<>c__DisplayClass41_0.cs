using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using DataTracking;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Server.Models;
using Sfs2X.Entities;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class EditClanPanel : MonoBehaviour, IInitializable
{
	[Serializable]
	private struct LevelPreview
	{
		public ClanEmblemLoader previewer;

		public Button button;

		public Button previewProgressButton;
	}

	private sealed class <>c__DisplayClass23_0
	{
		public int tier;

		public EditClanPanel <>4__this;

		internal void <WirePreviewButtons>b__0()
		{
			EditClanPanel editClanPanel = <>4__this;
			editClanPanel.clanUtils.OpenClanLockedLevelPopup(editClanPanel._clan, tier);
		}
	}

	private sealed class <>c__DisplayClass30_0
	{
		public EditClanPanel <>4__this;

		public ClanModel clan;

		internal void <LoadEmblemImages>b__0(List<ClanEmblemTierModel> tiers)
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0110: Expected O, but got I4
			//IL_00b9: Expected O, but got I4
			//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01aa: Expected O, but got Unknown
			//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01be: Expected O, but got Unknown
			//IL_01ca: Expected O, but got I
			//IL_01d4: Expected O, but got I4
			//IL_01dd: Expected O, but got I4
			//IL_0241: Unknown result type (might be due to invalid IL or missing references)
			//IL_0246: Expected O, but got Unknown
			//IL_0283: Expected I, but got O
			//IL_02bf: Expected O, but got I4
			//IL_0338: Unknown result type (might be due to invalid IL or missing references)
			//IL_033d: Expected O, but got Unknown
			//IL_0358: Expected O, but got I4
			//IL_0411: Expected O, but got I
			//IL_03bc: Expected O, but got I
			//IL_03cc: Expected O, but got I
			//IL_03ee: Expected O, but got I4
			//IL_0444: Unknown result type (might be due to invalid IL or missing references)
			//IL_0449: Expected O, but got Unknown
			//IL_0472: Unknown result type (might be due to invalid IL or missing references)
			//IL_0477: Expected O, but got Unknown
			//IL_0493: Expected O, but got I4
			//IL_04a0: Expected O, but got I4
			object obj = 152993792;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E85EB]");
			object obj3 = (nint)0 & (nint)1;
			UnityEngine.Object obj5;
			UnityEngine.Object obj6;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v19+E4]");
				bool flag = (nint)0 == 0;
				obj5 = <>4__this;
				obj6 = <>4__this;
				if (!flag)
				{
					goto IL_0091;
				}
			}
			else
			{
				_ = 1;
				obj5 = <>4__this;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v19+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				obj6 = <>4__this;
				if (obj7 != null)
				{
					goto IL_0091;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = obj6 == null;
			bool flag4 = !flag3;
			FileInfoModel fileInfoModel = null;
			UnityEngine.Object obj8 = null;
			if (!flag4)
			{
				return;
			}
			goto IL_016d;
			IL_016d:
			EditClanPanel editClanPanel = <>4__this;
			if ((object)<>4__this != null)
			{
				object obj9 = typeof(DebugUI.BitField) + 1232;
				object obj10 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 616;
				object obj11 = (nint)0 + (nint)2760;
				object obj12 = 32;
				object obj13 = 0;
				object obj14 = default(object);
				Func<object, bool> func = default(Func<object, bool>);
				while (true)
				{
					LevelPreview[] levelPreviews = editClanPanel.levelPreviews;
					if (editClanPanel.levelPreviews == null)
					{
						break;
					}
					if ((nint)obj13 >= levelPreviews.Length)
					{
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					obj14..ctor();
					if (obj14 == null)
					{
						break;
					}
					object obj15 = obj13 + 1;
					object obj16;
					EditClanPanel editClanPanel2;
					if (tiers != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						func..ctor(obj14, (IntPtr)obj11);
						obj16 = Enumerable.FirstOrDefault(tiers, func);
						editClanPanel2 = <>4__this;
						bool flag5 = (object)<>4__this == null;
						object obj17 = !flag5;
						if (obj17 == null)
						{
							break;
						}
					}
					else
					{
						editClanPanel2 = <>4__this;
						bool flag6 = (object)<>4__this == null;
						obj16 = null;
						if (flag6)
						{
							break;
						}
					}
					LevelPreview[] levelPreviews2 = editClanPanel2.levelPreviews;
					if (editClanPanel2.levelPreviews == null)
					{
						break;
					}
					object obj18 = obj15 - 1;
					bool flag7 = (nint)obj18 < levelPreviews2.Length;
					object obj19 = !flag7;
					if (obj19 == null)
					{
						ClanModel clanModel = clan;
						if (clan == null)
						{
							break;
						}
						ClanEmblemLoader clanEmblemLoader;
						if (obj16 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X0_v9 (System.Object)+18]");
							fileInfoModel = (FileInfoModel)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X8_v10 (LevelPreview[])+v128 @ X23_v4]");
							clanEmblemLoader = (ClanEmblemLoader)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X8_v10 (LevelPreview[])+v128 @ X23_v4]");
							bool flag8 = (nint)0 == 0;
							object obj20 = !flag8;
							if (obj20 == null)
							{
								break;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X8_v10 (LevelPreview[])+v128 @ X23_v4]");
							clanEmblemLoader = (ClanEmblemLoader)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X8_v10 (LevelPreview[])+v128 @ X23_v4]");
							bool flag9 = (nint)0 == 0;
							fileInfoModel = null;
							if (flag9)
							{
								break;
							}
						}
						obj12 += 24;
						clanEmblemLoader.Load(clanModel.ClanId, fileInfoModel);
						editClanPanel = <>4__this;
						obj13 = obj18 + 1;
						bool flag10 = (object)<>4__this == null;
						object obj21 = !flag10;
						obj8 = (UnityEngine.Object)clanModel.ClanId;
						if (obj21 == null)
						{
							break;
						}
						continue;
					}
					goto IL_04bc;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			goto IL_04bc;
			IL_04bc:
			throw new IndexOutOfRangeException();
			IL_0091:
			bool flag11 = obj5 == null;
			bool flag12 = !flag11;
			object obj22 = !flag12;
			if (obj22 == null)
			{
				fileInfoModel = null;
				obj8 = null;
				goto IL_016d;
			}
		}
	}

	private sealed class <>c__DisplayClass30_1
	{
		public int tier;

		internal bool <LoadEmblemImages>b__1(ClanEmblemTierModel t)
		{
			//IL_0053: Expected I4, but got O
			//IL_0031: Expected O, but got I4
			if (t != null)
			{
				object obj = t.Tier - tier;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass40_0
	{
		public EditClanPanel <>4__this;

		public int tier;

		internal void <ActivateTier>b__0(bool succeeded)
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00ed: Expected O, but got I4
			//IL_0146: Expected O, but got I4
			object obj = 152993792;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E85EC]");
			object obj3 = (nint)0 & (nint)1;
			UnityEngine.Object obj5;
			UnityEngine.Object obj6;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v7+E4]");
				bool flag = (nint)0 == 0;
				obj5 = <>4__this;
				obj6 = <>4__this;
				if (!flag)
				{
					goto IL_0091;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v7+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				obj5 = <>4__this;
				obj6 = <>4__this;
				if (obj7 != null)
				{
					goto IL_0091;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = obj6 == null;
			bool flag4 = !flag3;
			object obj8 = !flag4;
			if (obj8 != null)
			{
				return;
			}
			goto IL_0154;
			IL_0154:
			EditClanPanel editClanPanel = <>4__this;
			editClanPanel.activateButton.interactable = true;
			editClanPanel.UnlockButton.interactable = true;
			EditClanPanel editClanPanel2 = <>4__this;
			if (succeeded)
			{
				ClanModel clan = editClanPanel2._clan;
				clan.ActiveEmblemTier = tier;
				<>4__this.RefreshEmblemState();
			}
			else
			{
				<>4__this.RefreshEmblemState();
			}
			return;
			IL_0091:
			if (obj5 == null)
			{
				return;
			}
			goto IL_0154;
		}
	}

	private sealed class <>c__DisplayClass41_0
	{
		public EditClanPanel <>4__this;

		public int targetTier;

		internal void <OnUnlockClicked>b__0(bool succeeded)
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0100: Expected O, but got I4
			//IL_00b7: Expected O, but got I4
			//IL_014f: Expected O, but got I4
			//IL_0158: Expected O, but got I4
			//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a6: Expected O, but got Unknown
			//IL_01d0: Expected O, but got I4
			//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c8: Expected O, but got Unknown
			object obj = 152993792;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E85ED]");
			object obj3 = (nint)0 & (nint)1;
			UnityEngine.Object obj5;
			UnityEngine.Object obj6;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v20+E4]");
				bool flag = (nint)0 == 0;
				obj5 = <>4__this;
				obj6 = <>4__this;
				if (!flag)
				{
					goto IL_0091;
				}
			}
			else
			{
				_ = 1;
				obj5 = <>4__this;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v20+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				obj6 = <>4__this;
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
			if (obj8 != null)
			{
				return;
			}
			goto IL_0166;
			IL_0166:
			if (succeeded)
			{
				ITrackEvent trackEvent = TrackerLibrary.ClanEmblemUpgraded(targetTier);
				object obj10 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
				object obj11 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v9+E4]");
				bool flag5 = (nint)0 == 0;
				object obj12 = !flag5;
				if (obj12 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Tracker.DesignEvent(trackEvent);
				EditClanPanel editClanPanel = <>4__this;
				ClanModel clan = editClanPanel._clan;
				clan.PurchasedEmblemTier = targetTier;
				editClanPanel.RefreshPreviewStates();
				EditClanPanel editClanPanel2 = <>4__this;
				ClanModel clan2 = editClanPanel2._clan;
				editClanPanel2.clanUtils.OpenClanUnlockEmblemPopup(clan2.ClanId, targetTier);
				<>4__this.ActivateTier(targetTier);
			}
			else
			{
				EditClanPanel editClanPanel3 = <>4__this;
				editClanPanel3.activateButton.interactable = true;
				editClanPanel3.UnlockButton.interactable = true;
				ITrackEvent trackEvent2 = TrackerLibrary.ClanEmblemUpgradeError();
				object obj13 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
				object obj14 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v6+E4]");
				if ((nint)0 != 0)
				{
					Tracker.DesignEvent(trackEvent2);
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Tracker.DesignEvent(trackEvent2);
			}
			return;
			IL_0091:
			bool flag6 = obj5 == null;
			bool flag7 = !flag6;
			obj9 = 0;
			if (!flag7)
			{
				return;
			}
			goto IL_0166;
		}
	}

	private const string SAVED_KEY = "saved";

	private const string EDIT_FAILED_TITLE_KEY = "edit_clan_failed_title";

	private const string EDIT_FAILED_CONTENT_KEY = "edit_clan_failed_content";

	private const string DESCRIPTION_TITLE_KEY = "Clan Description";

	private const string RULES_TITLE_KEY = "Clan Rules";

	private InputFieldTMProUGUI nameField;

	private InputFieldTMProUGUI descriptionField;

	private InputFieldTMProUGUI rulesField;

	private LevelPreview[] levelPreviews;

	private ScrollSnapToNearest scrollSnaper;

	private GameObject activeLabel;

	private GameObject LockedLabel;

	private Button activateButton;

	private Button UnlockButton;

	private TextMeshProUGUI buyButtonLabel;

	private GameObject nameEditNotch;

	private ClansSerializedUtils clanUtils;

	private UnityEvent onSaved;

	private ClanModel _clan;

	private ClanConfigsResponse _configs;

	private bool _isSaving;

	private void Awake()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		//IL_006f: Expected O, but got I
		//IL_0087: Expected I, but got O
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00cd: Expected O, but got I
		//IL_00e5: Expected I, but got O
		//IL_00f6: Expected O, but got I
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_0116: Expected O, but got I
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected O, but got Unknown
		//IL_015f: Expected I, but got O
		//IL_018e: Expected O, but got I4
		Button button = activateButton;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)184;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		button.m_OnClick.AddListener(unityAction);
		Button unlockButton = UnlockButton;
		object obj3 = (nint)0 + (nint)216;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction2 = default(UnityAction);
		unityAction2..ctor(this, (IntPtr)obj3);
		unlockButton.m_OnClick.AddListener(unityAction2);
		ScrollSnapToNearest scrollSnapToNearest = scrollSnaper;
		object obj4 = typeof(TypeConverter<ushort, char>) + 408;
		object obj5 = (nint)0 + (nint)208;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<int> unityAction3 = default(UnityAction<int>);
		unityAction3..ctor((object)this, (IntPtr)obj5);
		object obj6 = (nint)0 + (nint)968;
		object obj7 = typeof(SqlSingle[]) + 2376;
		object obj8 = (nint)0 + (nint)192;
		object obj9 = typeof(RegisteredWaitHandle) + 56;
		scrollSnapToNearest.OnIndexChanged.AddListener(unityAction3);
		WirePreviewButtons();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj8);
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X0_v16+E4]");
		bool flag = (nint)0 == 0;
		object obj11 = !flag;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RemoteConfig.OnChanged += action;
	}

	private void OnConfigChanged()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00ef: Expected O, but got I4
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_012f: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(RegisteredWaitHandle) + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E85D8]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		RemoteConfigModel current = RemoteConfig.Current;
		bool flag2 = current == null;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_008b;
		IL_007d:
		current = RemoteConfig.Current;
		goto IL_008b;
		IL_008b:
		object obj7 = this + 144;
		obj7 = current.<Clans>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		RefreshPreviewStates();
		RefreshEmblemState();
	}

	private void WirePreviewButtons()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0031: Expected O, but got I
		//IL_003a: Expected O, but got I4
		//IL_0043: Expected O, but got I4
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00dc: Expected O, but got I4
		//IL_0107: Expected O, but got I
		//IL_011c: Expected O, but got I
		//IL_0137: Expected I, but got O
		//IL_0151: Expected O, but got I
		//IL_016e: Expected I, but got O
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		//IL_0196: Expected O, but got I
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected O, but got Unknown
		//IL_01ca: Expected O, but got I4
		LevelPreview[] array = levelPreviews;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)2744;
		object obj3 = (nint)0 + (nint)176;
		object obj4 = 0;
		object obj5 = 0;
		object obj7 = default(object);
		UnityAction unityAction = default(UnityAction);
		UnityAction unityAction2 = default(UnityAction);
		while (true)
		{
			if ((nint)obj4 < array.Length)
			{
				object obj6 = typeof(DebugUI.BitField) + 1216;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				obj7..ctor();
				object obj8 = obj7 + 24;
				obj8 = this;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj9 = obj4 + 1;
				LevelPreview[] array2 = levelPreviews;
				object obj10 = obj9 - 1;
				bool flag = (nint)obj10 < array2.Length;
				object obj11 = !flag;
				if (obj11 != null)
				{
					break;
				}
				object obj12 = (object)array2 + obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v11+28]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v11+30]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				unityAction..ctor(obj7, (IntPtr)obj2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X9_v5+100]");
				((UnityEvent)0).AddListener(unityAction);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				unityAction2..ctor(this, (IntPtr)obj3);
				obj5 += 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X24_v5+100]");
				((UnityEvent)0).AddListener(unityAction2);
				array = levelPreviews;
				obj4 = obj10 + 1;
				bool flag2 = levelPreviews == null;
				object obj15 = !flag2;
				if (obj15 == null)
				{
					throw new NullReferenceException();
				}
				continue;
			}
			return;
		}
		throw new IndexOutOfRangeException();
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0224: Expected I, but got O
		//IL_024e: Expected O, but got I4
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0080: Expected O, but got I
		//IL_0098: Expected I, but got O
		//IL_00ca: Expected O, but got I
		//IL_00e2: Expected I, but got O
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected O, but got Unknown
		//IL_0128: Expected O, but got I
		//IL_0140: Expected I, but got O
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected O, but got Unknown
		//IL_019d: Expected O, but got I4
		//IL_026c: Expected O, but got I
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		//IL_01c9: Expected O, but got I
		//IL_01df: Expected O, but got I
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected O, but got Unknown
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)192;
		object obj3 = typeof(RegisteredWaitHandle) + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RemoteConfig.OnChanged -= action;
		Button button = activateButton;
		object obj6 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj7 = (nint)0 + (nint)184;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj7);
		button.m_OnClick.RemoveListener(unityAction);
		Button unlockButton = UnlockButton;
		object obj8 = (nint)0 + (nint)216;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction2 = default(UnityAction);
		unityAction2..ctor(this, (IntPtr)obj8);
		unlockButton.m_OnClick.RemoveListener(unityAction2);
		ScrollSnapToNearest scrollSnapToNearest = scrollSnaper;
		object obj9 = typeof(TypeConverter<ushort, char>) + 408;
		object obj10 = (nint)0 + (nint)208;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<int> unityAction3 = default(UnityAction<int>);
		unityAction3..ctor((object)this, (IntPtr)obj10);
		scrollSnapToNearest.OnIndexChanged.RemoveListener(unityAction3);
		LevelPreview[] array = levelPreviews;
		if (array.Length >= 1)
		{
			object obj11 = array + 48;
			object obj12 = 0;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X21_v10-8]");
				object obj13 = 0;
				object obj14 = obj11;
				obj11 += 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v13+100]");
				((UnityEventBase)0).RemoveAllListeners();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X22_v11+100]");
				((UnityEventBase)0).RemoveAllListeners();
				obj12++;
			}
			while ((nint)obj12 < array.Length);
		}
	}

	public void OpenDescriptionEditor()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0043: Expected O, but got I
		//IL_0051: Expected I, but got O
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_008f: Expected O, but got I4
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		if (CanEditClan())
		{
			string text = descriptionField.Text;
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = (nint)0 + (nint)160;
			Action<object> action = default(Action<object>);
			action..ctor((object)this, (IntPtr)obj2);
			object obj3 = typeof(MemberAchievementClanFeedData) + 456;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v8+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj6 = "Cannot populate JSON object onto type '{0}'." + 2872;
			MessageBoxInputPopup.Show((string)obj6, text, action, (string)obj6, emptyTextAllowed: false);
		}
	}

	public void OpenRulesEditor()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0043: Expected O, but got I
		//IL_0051: Expected I, but got O
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_008f: Expected O, but got I4
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		if (CanEditClan())
		{
			string text = rulesField.Text;
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = (nint)0 + (nint)168;
			Action<object> action = default(Action<object>);
			action..ctor((object)this, (IntPtr)obj2);
			object obj3 = typeof(MemberAchievementClanFeedData) + 456;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v8+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj6 = "Cannot populate JSON object onto type '{0}'." + 2896;
			MessageBoxInputPopup.Show((string)obj6, text, action, (string)obj6, emptyTextAllowed: false);
		}
	}

	public void Save()
	{
		//IL_0021: Expected O, but got I4
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_009b: Expected O, but got I4
		//IL_00c4: Expected O, but got I
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		//IL_0107: Expected O, but got I
		//IL_0115: Expected I, but got O
		if (CanEditClan())
		{
			bool flag = !_isSaving;
			object obj = !flag;
			if (obj == null && ValidateFields())
			{
				_isSaving = true;
				object obj2 = typeof(Queue<string>) + 728;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v9+E4]");
				bool flag2 = (nint)0 == 0;
				object obj4 = !flag2;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj5 = (nint)0 + (nint)1976;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				ClanCreationModel model = BuildEditModelFromInputs();
				object obj6 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj7 = (nint)0 + (nint)200;
				Action<bool> action = default(Action<bool>);
				action..ctor((object)this, (IntPtr)obj7);
				ClanServerConnector clanServerConnector = default(ClanServerConnector);
				clanServerConnector.SendEditClan(model, action);
			}
		}
		else
		{
			onSaved.Invoke();
		}
	}

	public void Initialize()
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0070: Expected O, but got I4
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		//IL_00bb: Expected O, but got I
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_00db: Expected O, but got I
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		//IL_0138: Expected O, but got I4
		//IL_017c: Expected I, but got O
		GameObject gameObject = nameEditNotch.gameObject;
		object obj = typeof(RegisteredWaitHandle) + 56;
		gameObject.SetActive(value: false);
		ApplyEditPermission();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RemoteConfigModel current = RemoteConfig.Current;
		object obj4 = typeof(Queue<string>) + 728;
		object obj5 = (nint)0 + (nint)1976;
		object obj6 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1552;
		object obj7 = (nint)0 + (nint)224;
		object obj8 = this + 144;
		obj8 = current.<Clans>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		RefreshPreviewStates();
		RefreshEmblemState();
		object obj9 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v16+E4]");
		bool flag2 = (nint)0 == 0;
		object obj10 = !flag2;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj7);
		ClanServerConnector clanServerConnector = default(ClanServerConnector);
		clanServerConnector.GetMyClan(action);
	}

	private void Prefill(ClanModel clan)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0059: Expected O, but got I
		//IL_00e0: Expected O, but got I4
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected I4, but got Unknown
		//IL_0148: Expected O, but got I4
		//IL_01f2: Expected O, but got I4
		if (clan != null)
		{
			object obj = this + 136;
			obj = clan;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X21_v3-68]");
			((InputFieldTMProUGUI)0).Text = clan.Name;
			descriptionField.Text = clan.Description;
			rulesField.Text = clan.Rules;
			LoadEmblemImages(clan);
			RefreshPreviewStates();
			LevelPreview[] array = levelPreviews;
			ScrollSnapToNearest scrollSnapToNearest = scrollSnaper;
			int num = array.Length - 1;
			object obj2 = clan.PurchasedEmblemTier - num;
			bool flag = (nint)obj2 < 0;
			int num2 = clan.PurchasedEmblemTier ^ num;
			int num3 = clan.PurchasedEmblemTier ^ obj2;
			int num4 = num2 & num3;
			bool flag2 = num4 < 0;
			bool flag3 = flag == flag2;
			object obj3 = !flag3;
			object obj4 = ~obj3;
			if (obj4 == null)
			{
				num = clan.PurchasedEmblemTier;
			}
			bool flag4 = clan.PurchasedEmblemTier < 0;
			int num5 = clan.PurchasedEmblemTier ^ clan.PurchasedEmblemTier;
			int num6 = clan.PurchasedEmblemTier & num5;
			bool flag5 = num6 < 0;
			bool flag6 = flag4 == flag5;
			object obj5 = !flag6;
			object obj6 = ~obj5;
			scrollSnapToNearest.SnapToIndex(scrollSnapToNearest.selectedIndex = ((obj6 != null) ? num : 0));
			RefreshEmblemState();
		}
	}

	private void LoadEmblemImages(ClanModel clan)
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
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_00c5: Expected O, but got I4
		//IL_010c: Expected I, but got O
		object obj = typeof(DebugUI.BitField) + 1224;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(Queue<string>) + 728;
		object obj4 = (nint)0 + (nint)1976;
		object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 728;
		object obj6 = (nint)0 + (nint)2752;
		object obj7 = obj2 + 16;
		obj7 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = obj2 + 24;
		obj8 = clan;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v12+E4]");
		bool flag = (nint)0 == 0;
		object obj10 = !flag;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj6);
		ClanServerConnector clanServerConnector = default(ClanServerConnector);
		clanServerConnector.GetClanEmblemTiers(action);
	}

	private void RefreshPreviewStates()
	{
		//IL_0037: Expected O, but got I4
		//IL_0040: Expected O, but got I4
		//IL_0077: Expected O, but got I
		//IL_00b9: Expected O, but got I4
		//IL_020a: Expected O, but got I4
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected O, but got Unknown
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected I4, but got Unknown
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Expected I4, but got Unknown
		//IL_02b4: Expected O, but got I
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Expected O, but got Unknown
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Expected O, but got Unknown
		//IL_02f6: Expected O, but got I4
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected I4, but got Unknown
		//IL_0352: Expected O, but got I4
		if (_clan == null)
		{
			return;
		}
		LevelPreview[] array = levelPreviews;
		object obj = 0;
		object obj2 = 0;
		while (true)
		{
			if ((nint)obj >= array.Length)
			{
				return;
			}
			ClanModel clan = _clan;
			object obj3 = (object)array + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v6+28]");
			GameObject gameObject = ((Component)0).gameObject;
			bool active;
			if ((nint)obj < clan.PurchasedEmblemTier)
			{
				bool flag = (object)gameObject == null;
				object obj4 = !flag;
				active = false;
				if (obj4 == null)
				{
					goto IL_0325;
				}
			}
			else
			{
				ClanModel clan2 = _clan;
				if (_clan != null && (nint)obj == clan2.PurchasedEmblemTier && _configs != null)
				{
					int tier = obj + 1;
					ClanTierConfig tier2 = _configs.GetTier(tier);
					if (tier2 != null)
					{
						ClanModel clan3 = _clan;
						if (clan3.Points >= tier2.XpThreshold)
						{
							bool flag2 = CanManageVault();
							active = (byte)((flag2 ? 1u : 0u) ^ 1u) != 0;
							goto IL_0338;
						}
					}
					active = true;
					goto IL_0338;
				}
				active = true;
			}
			goto IL_01d3;
			IL_0325:
			throw new NullReferenceException();
			IL_01d3:
			gameObject.SetActive(active);
			LevelPreview[] array2 = levelPreviews;
			bool flag3 = (nint)obj < array2.Length;
			object obj5 = !flag3;
			if (obj5 != null)
			{
				break;
			}
			object obj6 = (object)array2 + obj2;
			object obj7 = obj - clan.PurchasedEmblemTier;
			bool flag4 = (nint)obj7 < 0;
			int num = obj ^ clan.PurchasedEmblemTier;
			object obj8 = obj ^ obj7;
			int num2 = num & obj8;
			bool flag5 = num2 < 0;
			bool flag6 = flag4 == flag5;
			bool flag7 = !flag6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X8_v9+30]");
			((Behaviour)0).enabled = flag7;
			array = levelPreviews;
			obj2 += 24;
			obj++;
			bool flag8 = levelPreviews == null;
			object obj9 = !flag8;
			if (obj9 != null)
			{
				continue;
			}
			goto IL_0325;
			IL_0338:
			bool flag9 = (object)gameObject == null;
			object obj10 = !flag9;
			if (obj10 != null)
			{
				goto IL_01d3;
			}
			goto IL_0325;
		}
		throw new IndexOutOfRangeException();
	}

	private int GetSelectedTier()
	{
		//IL_0304: Expected I4, but got O
		//IL_0088: Expected I4, but got I8
		//IL_00a2: Expected O, but got I4
		//IL_00cc: Expected O, but got I4
		//IL_0253: Expected O, but got I4
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected I4, but got Unknown
		//IL_02b1: Expected O, but got I4
		//IL_03c2: Expected O, but got I4
		//IL_0171: Expected O, but got I4
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected I4, but got Unknown
		//IL_01cf: Expected O, but got I4
		//IL_0355: Expected O, but got I4
		LevelPreview[] array = levelPreviews;
		int num;
		LevelPreview[] array2;
		if (levelPreviews != null)
		{
			if (array.Length == 0)
			{
				return 0;
			}
			if ((object)scrollSnaper != null)
			{
				num = scrollSnaper.CurrentIndex;
				int num2 = (int)(num & 0x80000000L);
				bool flag = num2 == 0;
				object obj = !flag;
				if (obj == null)
				{
					bool flag2 = levelPreviews == null;
					object obj2 = !flag2;
					array2 = levelPreviews;
					if (obj2 != null)
					{
						goto IL_0236;
					}
				}
				else
				{
					ClanModel clan = _clan;
					array2 = levelPreviews;
					if (_clan != null)
					{
						if (levelPreviews != null)
						{
							int num3 = clan.ActiveEmblemTier - 1;
							int num4 = array2.Length - 1;
							object obj3 = num3 - num4;
							bool flag3 = (nint)obj3 < 0;
							int num5 = num3 ^ num4;
							int num6 = num3 ^ obj3;
							int num7 = num5 & num6;
							bool flag4 = num7 < 0;
							bool flag5 = flag3 == flag4;
							object obj4 = !flag5;
							object obj5 = ~obj4;
							if (obj5 == null)
							{
								num4 = num3;
							}
							bool flag6 = num3 < 0;
							int num8 = num3 ^ num3;
							int num9 = num3 & num8;
							bool flag7 = num9 < 0;
							bool flag8 = flag6 == flag7;
							object obj6 = !flag8;
							object obj7 = ~obj6;
							num = ((obj7 != null) ? num4 : 0);
							goto IL_0236;
						}
					}
					else
					{
						bool flag9 = levelPreviews == null;
						num = 0;
						if (!flag9)
						{
							goto IL_0236;
						}
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
		IL_0236:
		int num10 = array2.Length - 1;
		object obj8 = num - num10;
		bool flag10 = (nint)obj8 < 0;
		int num11 = num ^ num10;
		int num12 = num ^ obj8;
		int num13 = num11 & num12;
		bool flag11 = num13 < 0;
		bool flag12 = flag10 == flag11;
		object obj9 = !flag12;
		object obj10 = ~obj9;
		if (obj10 == null)
		{
			num10 = num;
		}
		bool flag13 = num < 0;
		int num14 = num ^ num;
		int num15 = num & num14;
		bool flag14 = num15 < 0;
		bool flag15 = flag13 == flag14;
		object obj11 = !flag15;
		object obj12 = ~obj11;
		if (obj12 == null)
		{
			return 1;
		}
		return num10 + 1;
	}

	private void OnSelectedIndexChanged(int index)
	{
		RefreshEmblemState();
	}

	private void RefreshEmblemState()
	{
		//IL_053e: Expected O, but got I4
		//IL_0576: Unknown result type (might be due to invalid IL or missing references)
		//IL_057b: Expected I4, but got Unknown
		//IL_05b0: Expected O, but got I4
		//IL_05b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bd: Expected O, but got Unknown
		//IL_006d: Expected O, but got I4
		//IL_05df: Expected O, but got I4
		//IL_01ba: Expected O, but got I4
		//IL_051e: Expected O, but got I4
		//IL_01ee: Expected O, but got I4
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected I4, but got Unknown
		//IL_0260: Expected O, but got I4
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected O, but got Unknown
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Expected O, but got Unknown
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected O, but got Unknown
		//IL_0295: Expected I4, but got O
		//IL_02bb: Expected O, but got I4
		//IL_02d8: Expected O, but got I4
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Expected I4, but got Unknown
		//IL_012f: Expected O, but got I4
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected I4, but got Unknown
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Expected I4, but got Unknown
		//IL_0377: Expected O, but got I4
		//IL_0475: Expected O, but got I4
		//IL_0493: Expected O, but got I4
		//IL_04a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ac: Expected O, but got Unknown
		//IL_0607: Expected O, but got I4
		if (_clan == null)
		{
			return;
		}
		int selectedTier = GetSelectedTier();
		if (selectedTier < 1)
		{
			return;
		}
		ClanModel clan = _clan;
		bool flag3;
		bool flag4;
		if (_configs != null)
		{
			object obj = clan.PurchasedEmblemTier + 1;
			ClanTierConfig tier = _configs.GetTier(selectedTier);
			bool flag = tier == null;
			bool flag2 = selectedTier != (nint)obj || tier == null;
			object obj2 = !flag2;
			if (obj2 == null)
			{
				flag3 = false;
				flag4 = flag;
			}
			else
			{
				ClanModel clan2 = _clan;
				object obj3 = clan2.Points - tier.XpThreshold;
				bool flag5 = (nint)obj3 < 0;
				int num = clan2.Points ^ tier.XpThreshold;
				int num2 = clan2.Points ^ obj3;
				int num3 = num & num2;
				bool flag6 = num3 < 0;
				bool flag7 = flag5 == flag6;
				flag3 = flag7;
				flag4 = false;
			}
		}
		else
		{
			flag3 = false;
			flag4 = true;
			ClanTierConfig tier = (ClanTierConfig)(object)_configs;
		}
		object obj4 = selectedTier - clan.PurchasedEmblemTier;
		bool flag8 = (nint)obj4 < 0;
		bool flag9 = obj4 == null;
		int num4 = selectedTier ^ clan.PurchasedEmblemTier;
		int num5 = selectedTier ^ obj4;
		int num6 = num4 & num5;
		bool flag10 = num6 < 0;
		bool flag11 = flag8 == flag10;
		object obj5 = !flag11;
		object obj6 = obj5 | flag9;
		object obj7 = ~obj6;
		bool flag12;
		if (obj7 == null)
		{
			object obj8 = selectedTier - clan.ActiveEmblemTier;
			flag12 = obj8 == null;
		}
		else
		{
			flag12 = true;
		}
		object obj9 = !flag12;
		bool flag13 = CanManageVault();
		object obj10 = selectedTier - clan.PurchasedEmblemTier;
		bool flag14 = (nint)obj10 < 0;
		bool flag15 = obj10 == null;
		int num7 = selectedTier ^ clan.PurchasedEmblemTier;
		int num8 = selectedTier ^ obj10;
		int num9 = num7 & num8;
		bool flag16 = num9 < 0;
		bool flag17 = flag14 == flag16;
		object obj11 = !flag15;
		object obj12 = flag17 & obj11;
		object obj13 = obj9 | flag3;
		object obj14 = obj13 ^ 1;
		bool active = (byte)(obj12 & obj14) != 0;
		LockedLabel.SetActive(active);
		object obj15 = selectedTier - clan.ActiveEmblemTier;
		bool flag18 = obj15 == null;
		object obj16 = (flag3 ? 1 : 0) ^ 1;
		bool active2 = (byte)((flag18 & obj16) ? 1 : 0) != 0;
		activeLabel.SetActive(active2);
		GameObject gameObject = activateButton.gameObject;
		bool active3 = (byte)((flag13 & obj9) ? 1 : 0) != 0;
		gameObject.SetActive(active3);
		GameObject gameObject2 = UnlockButton.gameObject;
		ClanModel clan3 = _clan;
		bool active4;
		if (_clan != null)
		{
			object obj17 = clan3.PurchasedEmblemTier + 1;
			if (selectedTier == (nint)obj17 && _configs != null)
			{
				ClanTierConfig tier2 = _configs.GetTier(selectedTier);
				if (tier2 != null)
				{
					ClanModel clan4 = _clan;
					if (clan4.Points >= tier2.XpThreshold)
					{
						bool flag19 = CanManageVault();
						active4 = flag19;
						goto IL_05ed;
					}
				}
				active4 = false;
				goto IL_05ed;
			}
		}
		active4 = false;
		goto IL_0439;
		IL_04ec:
		throw new NullReferenceException();
		IL_05ed:
		bool flag20 = (object)gameObject2 == null;
		object obj18 = !flag20;
		if (obj18 != null)
		{
			goto IL_0439;
		}
		goto IL_04ec;
		IL_0439:
		gameObject2.SetActive(active4);
		if (flag3)
		{
			bool flag21 = !flag4;
			object obj19 = !flag21;
			if (obj19 == null)
			{
				object obj20 = 153100288 + 1024;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				object format = "utf-32" + 3832;
				object arg = default(object);
				string text = string.Format((string)format, arg);
				buyButtonLabel.text = text;
				return;
			}
			goto IL_04ec;
		}
	}

	private bool IsUnlockButtonActive(int tier)
	{
		//IL_003c: Expected O, but got I4
		//IL_011e: Expected I4, but got O
		ClanModel clan = _clan;
		if (_clan != null)
		{
			object obj = clan.PurchasedEmblemTier + 1;
			if (tier == (nint)obj && _configs != null)
			{
				ClanTierConfig tier2 = _configs.GetTier(tier);
				if (tier2 != null)
				{
					ClanModel clan2 = _clan;
					if (_clan == null)
					{
						NullReferenceException ex = new NullReferenceException();
						return (byte)(int)ex != 0;
					}
					if (clan2.Points >= tier2.XpThreshold)
					{
						return CanManageVault();
					}
				}
			}
		}
		return false;
	}

	private static bool CanManageVault()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_01ac: Expected O, but got I4
		//IL_025c: Expected I4, but got O
		object obj = 152993792;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E85E1]");
		object obj3 = (nint)0 & (nint)1;
		object obj6;
		object obj4;
		if (obj3 != null)
		{
			obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v16+E4]");
			bool flag = (nint)0 == 0;
			obj6 = obj4;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v16+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool flag3 = (object)sessionModel == null;
		obj4 = obj6;
		if (!flag3)
		{
			goto IL_0158;
		}
		goto IL_024e;
		IL_024e:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0158:
		User localUser = sessionModel.LocalUser;
		if (localUser != null)
		{
			object obj8 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v7+E4]");
			bool flag4 = (nint)0 == 0;
			object obj9 = !flag4;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel2 = default(SessionModel);
			if ((object)sessionModel2 == null)
			{
				goto IL_024e;
			}
			User localUser2 = sessionModel2.LocalUser;
			ClanUserModel clanMembership = SFSKammelnaUserExtensions.GetClanMembership(localUser2);
			if (clanMembership != null)
			{
				return ClanPermissionsExtensions.Can(clanMembership.Permissions, ClanPermissions.ManageVault);
			}
		}
		return false;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag5 = (object)sessionModel == null;
		object obj10 = !flag5;
		if (obj10 != null)
		{
			goto IL_0158;
		}
		goto IL_024e;
	}

	private static bool CanEditClan()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_01ac: Expected O, but got I4
		//IL_025c: Expected I4, but got O
		object obj = 152993792;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E85E2]");
		object obj3 = (nint)0 & (nint)1;
		object obj6;
		object obj4;
		if (obj3 != null)
		{
			obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v16+E4]");
			bool flag = (nint)0 == 0;
			obj6 = obj4;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v16+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool flag3 = (object)sessionModel == null;
		obj4 = obj6;
		if (!flag3)
		{
			goto IL_0158;
		}
		goto IL_024e;
		IL_024e:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0158:
		User localUser = sessionModel.LocalUser;
		if (localUser != null)
		{
			object obj8 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v7+E4]");
			bool flag4 = (nint)0 == 0;
			object obj9 = !flag4;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel2 = default(SessionModel);
			if ((object)sessionModel2 == null)
			{
				goto IL_024e;
			}
			User localUser2 = sessionModel2.LocalUser;
			ClanUserModel clanMembership = SFSKammelnaUserExtensions.GetClanMembership(localUser2);
			if (clanMembership != null)
			{
				return ClanPermissionsExtensions.Can(clanMembership.Permissions, ClanPermissions.ManageClan);
			}
		}
		return false;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag5 = (object)sessionModel == null;
		object obj10 = !flag5;
		if (obj10 != null)
		{
			goto IL_0158;
		}
		goto IL_024e;
	}

	private void ApplyEditPermission()
	{
		bool interactable = CanEditClan();
		nameField.Interactable = interactable;
		descriptionField.Interactable = interactable;
		rulesField.Interactable = interactable;
	}

	private void OnActivateClicked()
	{
		if (_clan != null)
		{
			int selectedTier = GetSelectedTier();
			if (selectedTier >= 1)
			{
				activateButton.interactable = false;
				UnlockButton.interactable = false;
				ActivateTier(selectedTier);
			}
		}
	}

	private void ActivateTier(int tier)
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
		//IL_00a5: Expected O, but got I4
		//IL_00ec: Expected I, but got O
		object obj = typeof(DebugUI.BitField) + 1240;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(Queue<string>) + 728;
		object obj4 = (nint)0 + (nint)1976;
		object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		object obj6 = (nint)0 + (nint)2768;
		object obj7 = obj2 + 16;
		obj7 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v8+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<bool> action = default(Action<bool>);
		action..ctor(obj2, (IntPtr)obj6);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Object)+18]");
		ClanServerConnector clanServerConnector = default(ClanServerConnector);
		clanServerConnector.ActivateEmblemTier(0, action);
	}

	private void OnUnlockClicked()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_00f4: Expected O, but got I4
		//IL_017b: Expected O, but got I4
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected O, but got Unknown
		//IL_023d: Expected O, but got I4
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Expected O, but got Unknown
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Expected O, but got Unknown
		//IL_0346: Expected O, but got I4
		//IL_0196: Expected O, but got I
		//IL_0266: Expected O, but got I
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Expected O, but got Unknown
		//IL_038f: Expected O, but got I4
		//IL_029f: Expected O, but got I
		//IL_02b0: Expected I, but got O
		object obj = typeof(DebugUI.BitField) + 1248;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		ClanModel clan = _clan;
		if (_clan == null)
		{
			return;
		}
		object obj4 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		int tier = clan.PurchasedEmblemTier + 1;
		ITrackEvent trackEvent = TrackerLibrary.ClanEmblemUpgradeClicked(tier);
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X8_v7+E4]");
		ClanConfigsResponse configs;
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			configs = _configs;
			bool flag = _configs == null;
			object obj6 = !flag;
			if (obj6 != null)
			{
				goto IL_014a;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Tracker.DesignEvent(trackEvent);
			configs = _configs;
			if (_configs != null)
			{
				goto IL_014a;
			}
		}
		goto IL_02c3;
		IL_02ec:
		object text = "Network Authentication Required" + 1776;
		LocalizableText text2 = TextMeshProExtensions.Localize((string)text);
		object obj7 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v13+E4]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Toast.Show(text2, (Vector2)0, 0f);
		return;
		IL_01da:
		activateButton.interactable = false;
		UnlockButton.interactable = false;
		object obj10 = typeof(Queue<string>) + 728;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X0_v24+E4]");
		bool flag3 = (nint)0 == 0;
		object obj12 = !flag3;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj13 = (nint)0 + (nint)1976;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj14 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj15 = (nint)0 + (nint)2776;
		Action<bool> action = default(Action<bool>);
		action..ctor(obj2, (IntPtr)obj15);
		ClanServerConnector clanServerConnector = default(ClanServerConnector);
		clanServerConnector.BuyEmblemTier(action);
		return;
		IL_02c3:
		long vaultBalance = GetVaultBalance();
		if (vaultBalance >= 0)
		{
			goto IL_01da;
		}
		goto IL_02ec;
		IL_014a:
		ClanConfigsResponse clanConfigsResponse = configs;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3 (System.Object)+18]");
		ClanTierConfig tier2 = clanConfigsResponse.GetTier(0);
		bool flag4 = tier2 == null;
		object obj16 = 0;
		if (flag4)
		{
			goto IL_02c3;
		}
		object obj17 = (nint)0 + (nint)3136;
		obj16 = obj17;
		int? num = tier2.EmblemUpgradeCost;
		long vaultBalance2 = GetVaultBalance();
		object obj18 = default(object);
		if (vaultBalance2 >= (long)obj18)
		{
			goto IL_01da;
		}
		goto IL_02ec;
	}

	private static long GetVaultBalance()
	{
		//IL_0016: Expected O, but got I
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected O, but got Unknown
		//IL_0184: Expected O, but got I
		//IL_019e: Expected O, but got I4
		//IL_009a: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_005d: Expected O, but got I
		//IL_0210: Expected I8, but got O
		//IL_01d2: Expected O, but got I
		//IL_01f4: Expected O, but got I4
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_0122: Expected O, but got I4
		//IL_014f: Expected I8, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E85E5]");
		object obj = (nint)0 & (nint)1;
		object obj2;
		object obj4;
		if (obj != null)
		{
			obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3160;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45B5]");
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
			obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3160;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45B5]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v5+B8]");
		object obj8 = 0;
		CoordinatorVariableBinder coordinatorVariableBinder = (CoordinatorVariableBinder)obj8;
		bool flag3 = obj8 == null;
		object obj9 = !flag3;
		if (obj9 != null)
		{
			goto IL_00bf;
		}
		goto IL_0202;
		IL_00bf:
		object scope = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3440;
		object variableName = "utf-32" + 336;
		string current = coordinatorVariableBinder.GetCurrent((string)scope, (string)variableName);
		long result;
		bool flag4 = long.TryParse(current, out result);
		bool flag5 = !flag4;
		object obj10 = !flag5;
		object obj11 = ~obj10;
		if (obj11 == null)
		{
			return result;
		}
		return 0L;
		IL_0202:
		NullReferenceException ex = new NullReferenceException();
		return (long)ex;
		IL_0082:
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v14+B8]");
		object obj13 = 0;
		coordinatorVariableBinder = (CoordinatorVariableBinder)obj13;
		if (obj13 != null)
		{
			goto IL_00bf;
		}
		goto IL_0202;
	}

	private void SetEmblemButtonsInteractable(bool interactable)
	{
		activateButton.interactable = interactable;
		UnlockButton.interactable = interactable;
	}

	private bool ValidateFields()
	{
		//IL_00b7: Expected I4, but got O
		if ((object)nameField != null)
		{
			string text = nameField.Text;
			if ((object)descriptionField != null)
			{
				string text2 = descriptionField.Text;
				if ((object)rulesField != null)
				{
					string text3 = rulesField.Text;
					return ClanFieldValidator.Validate(text, text2, text3);
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private ClanCreationModel BuildEditModelFromInputs()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ClanCreationModel clanCreationModel = default(ClanCreationModel);
		clanCreationModel..ctor();
		if ((object)nameField != null)
		{
			string text = nameField.Text;
			if (clanCreationModel != null)
			{
				object obj2 = clanCreationModel + 16;
				obj2 = text;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				if ((object)descriptionField != null)
				{
					string text2 = descriptionField.Text;
					object obj3 = clanCreationModel + 24;
					obj3 = text2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					if ((object)rulesField != null)
					{
						string text3 = rulesField.Text;
						object obj4 = clanCreationModel + 32;
						obj4 = text3;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						return clanCreationModel;
					}
				}
			}
		}
		return (ClanCreationModel)(object)new NullReferenceException();
	}

	private void OnEditResponse(bool succeeded)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00cd: Expected O, but got I4
		//IL_010f: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E85E7]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v4+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = this == null;
		bool flag3 = !flag2;
		object obj5 = !flag3;
		if (obj5 != null)
		{
			return;
		}
		goto IL_011d;
		IL_011d:
		_isSaving = false;
		if (succeeded)
		{
			onSaved.Invoke();
		}
		else
		{
			ShowFailurePopup();
		}
		return;
		IL_0074:
		if (this == null)
		{
			return;
		}
		goto IL_011d;
	}

	private static void ShowFailurePopup()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Expected O, but got Unknown
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Expected O, but got Unknown
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected O, but got Unknown
		//IL_02f9: Expected O, but got I
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_009e: Expected I, but got O
		//IL_00ae: Expected O, but got I
		//IL_0144: Expected I, but got O
		//IL_00e9: Expected O, but got I
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected O, but got Unknown
		//IL_0187: Expected I, but got O
		//IL_0197: Expected O, but got I
		//IL_0235: Expected O, but got I
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Expected O, but got Unknown
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected O, but got Unknown
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected O, but got Unknown
		//IL_0270: Expected I, but got O
		//IL_0294: Expected O, but got I4
		//IL_01d2: Expected O, but got I
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected O, but got Unknown
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E85E8]");
		nint num = 0;
		object buttonText = "Network Authentication Required" + 3128;
		object text = "destinationTimeZone" + 1616;
		object obj3 = default(object);
		object obj4 = default(object);
		NullReferenceException ex = default(NullReferenceException);
		object obj11 = default(object);
		object obj17 = default(object);
		while (true)
		{
			PopupWindowBuilder popupWindowBuilder = PopupWindowBuilder.CreateError(null, (string)buttonText);
			LocalizableText title = TextMeshProExtensions.Localize((string)text);
			nint num2;
			if (popupWindowBuilder != null)
			{
				object text2 = "destinationTimeZone" + 1608;
				IPopupWindowBuilderNeedsBody popupWindowBuilderNeedsBody = popupWindowBuilder.Titled(title);
				LocalizableText localizableText = TextMeshProExtensions.Localize((string)text2);
				if (popupWindowBuilderNeedsBody != null)
				{
					object obj = typeof(System.IOAsyncCallback) + 384;
					num2 = (nint)popupWindowBuilderNeedsBody;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X8_v9 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+12E]");
					object obj2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X8_v9 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0132;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X8_v9 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+B0]");
					obj3 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X10_v12-8]");
						if (0 == (nint)obj)
						{
							break;
						}
						obj4 = obj3 + 16;
						obj2--;
						bool flag = (nint)obj2 != 1;
						obj3 = obj4;
						if (flag)
						{
							continue;
						}
						goto IL_0132;
					}
					goto IL_023f;
				}
			}
			goto IL_02aa;
			IL_02aa:
			ex = new NullReferenceException();
			goto IL_02b8;
			IL_02b8:
			object obj5 = obj4 + 9;
			object obj6 = num + obj5;
			object obj7 = obj6 + 312;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v5+8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v184 @ X2_v3 (should have been resolved before IL gen)");
			continue;
			IL_0213:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj10 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X0_v14+8]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v221 @ X2_v8 (should have been resolved before IL gen)");
			goto IL_023f;
			IL_023f:
			object obj13 = obj3 + 1;
			object obj14 = num2 + obj13;
			object obj15 = obj14 + 312;
			num = (nint)obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v274 @ X0_v20] (should have been resolved before IL gen)");
			bool flag2 = ex == null;
			object obj16 = !flag2;
			obj4 = obj3;
			if (obj16 != null)
			{
				goto IL_016b;
			}
			goto IL_02aa;
			IL_0132:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num = (nint)obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v258 @ X0_v17] (should have been resolved before IL gen)");
			if (ex != null)
			{
				goto IL_016b;
			}
			goto IL_02aa;
			IL_016b:
			object obj18 = typeof(System.IOAsyncCallback) + 368;
			num = (nint)ex;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+12E]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+12E]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+B0]");
				obj4 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X10_v9-8]");
					if (0 == (nint)obj18)
					{
						break;
					}
					obj4 += 16;
					obj19--;
					if ((nint)obj19 != 1)
					{
						continue;
					}
					goto IL_0213;
				}
				goto IL_02b8;
			}
			goto IL_0213;
		}
	}

	private void <WirePreviewButtons>b__23_1()
	{
		//IL_001a: Expected I4, but got I8
		clanUtils.OpenClanLockedLevelPopup(_clan, -1);
	}

	private void <OpenDescriptionEditor>b__25_0(string value)
	{
		descriptionField.Text = value;
	}

	private void <OpenRulesEditor>b__26_0(string value)
	{
		rulesField.Text = value;
	}
}
