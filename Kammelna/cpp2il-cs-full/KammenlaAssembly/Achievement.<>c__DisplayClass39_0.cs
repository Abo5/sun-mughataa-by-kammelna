using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Net;
using System.Xml.Schema;
using Cpp2ILInjected;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using ListView;
using Managers.Achievemenets;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class Achievement : ListViewItem<AchievementHolder, int>, ISelectable
{
	private sealed class <>c__DisplayClass39_0
	{
		public Achievement <>4__this;

		public GameAchievementViewModel model;

		public int selectedLevel;

		public Action<bool> onSuccess;

		internal void <UpdateIcon>b__0(bool success)
		{
			//IL_0246: Unknown result type (might be due to invalid IL or missing references)
			//IL_024b: Expected O, but got Unknown
			//IL_009b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a0: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dd: Expected O, but got Unknown
			//IL_0107: Expected O, but got I4
			//IL_02a0: Expected O, but got I4
			//IL_0186: Unknown result type (might be due to invalid IL or missing references)
			//IL_018b: Expected O, but got Unknown
			//IL_01e1: Expected O, but got I4
			Achievement achievement = <>4__this;
			if ((object)achievement.loading != null)
			{
				achievement.loading.FinishLoading();
			}
			if (success)
			{
				GameAchievementViewModel gameAchievementViewModel = model;
				FileInfoModel <image>k__BackingField = gameAchievementViewModel.<image>k__BackingField;
				if (gameAchievementViewModel.<image>k__BackingField != null)
				{
					object obj = "WhiteSmoke" + 3384;
					object obj2 = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 1032;
					string text = (string)obj + <image>k__BackingField.<url>k__BackingField + (string)obj2;
					object obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
					object obj4 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v30+E4]");
					bool flag = (nint)0 == 0;
					object obj5 = !flag;
					object obj6 = text;
					if (obj5 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj6 = text;
					}
					KLogger.Log(obj6);
				}
				Achievement achievement2 = <>4__this;
				GameObject gameObject = achievement2.Icon.gameObject;
				gameObject.SetActive(value: true);
				Achievement achievement3 = <>4__this;
				object obj7 = typeof(MemberAchievementClanFeedData) + 2976;
				object obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v21+E4]");
				if ((nint)0 != 0)
				{
					bool flag2 = achievement3.iconDisplayHandler != null;
					bool flag3 = !flag2;
					object obj9 = !flag3;
					if (obj9 != null)
					{
						goto IL_034f;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					if (achievement3.iconDisplayHandler != null)
					{
						goto IL_034f;
					}
				}
			}
			else
			{
				Achievement achievement4 = <>4__this;
				GameObject gameObject2 = achievement4.Icon.gameObject;
				gameObject2.SetActive(value: false);
				Achievement achievement5 = <>4__this;
				object obj10 = typeof(MemberAchievementClanFeedData) + 2976;
				object obj11 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v12+E4]");
				if ((nint)0 != 0)
				{
					bool flag4 = achievement5.emptyIcon;
					bool flag5 = !flag4;
					object obj12 = !flag5;
					if (obj12 != null)
					{
						goto IL_02ed;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					if ((bool)achievement5.emptyIcon)
					{
						goto IL_02ed;
					}
				}
			}
			goto IL_03c0;
			IL_034f:
			Achievement achievement6 = <>4__this;
			RectTransform rectTransform = achievement6.Icon.rectTransform;
			GameAchievementViewModel gameAchievementViewModel2 = model;
			List<AchievementLevelModel> <achievementLevels>k__BackingField = gameAchievementViewModel2.<achievementLevels>k__BackingField;
			achievement6.iconDisplayHandler.ApplyTierDisplay(rectTransform, <achievementLevels>k__BackingField._size, selectedLevel, gameAchievementViewModel2.<type>k__BackingField);
			goto IL_03c0;
			IL_03c0:
			Actions.SafeInvoke(onSuccess, success);
			return;
			IL_02ed:
			Achievement achievement7 = <>4__this;
			achievement7.emptyIcon.SetActive(value: false);
			goto IL_03c0;
		}
	}

	public TextMeshProUGUI Name;

	public Image Icon;

	public Image ActiveMark;

	public GameObject emptyIcon;

	public RotatingLoadingIndicator loading;

	public Button ShowDescriptionButton;

	public Button ApplyTitle;

	public Button ResetTitle;

	public Button InvokeCallbackButton;

	public ElegantLoadingIndicator ApplyLoading;

	private AchievementLevelsStrip levelsStrip;

	private AchievementLevelDescription descriptionPanel;

	private TextMeshProUGUI levelName;

	private AchievementIconDisplayHandler iconDisplayHandler;

	public ProgressBar progressBar;

	public UnityEvent<GameAchievementViewModel> callback;

	private GameAchievementViewModel Model
	{
		get
		{
			//IL_0012: Expected O, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Achievement)+50]");
			return (GameAchievementViewModel)0;
		}
	}

	private UserAchievementModel UserModel
	{
		get
		{
			//IL_0012: Expected O, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Achievement)+58]");
			return (UserAchievementModel)0;
		}
	}

	private bool isMyAchievement
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Achievement)+60]");
			return false;
		}
	}

	private bool isActiveTitle
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_001f: Expected O, but got I
			//IL_019d: Expected O, but got I
			//IL_01b7: Expected O, but got I4
			//IL_0052: Expected O, but got I
			//IL_01ed: Expected O, but got I4
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			//IL_00b4: Expected O, but got I
			//IL_00de: Expected O, but got I4
			//IL_020f: Expected I4, but got O
			//IL_021f: Expected O, but got I
			//IL_0178: Expected O, but got I
			object obj = 152985600;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6BA4]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6BA2]");
				object obj3 = (nint)0 & (nint)1;
				if (obj3 != null)
				{
					goto IL_006f;
				}
			}
			else
			{
				_ = 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6BA2]");
				object obj4 = (nint)0 & (nint)1;
				bool flag = obj4 == null;
				object obj5 = !flag;
				if (obj5 != null)
				{
					goto IL_006f;
				}
			}
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Achievement)+58]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 != null)
			{
				goto IL_0094;
			}
			goto IL_01fb;
			IL_0094:
			object obj7 = typeof(Queue<string>) + 848;
			object obj8 = (nint)0 + (nint)2200;
			object obj9 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v14+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel = default(SessionModel);
			if ((object)sessionModel != null)
			{
				User localUser = sessionModel.LocalUser;
				string title = SFSKammelnaUserExtensions.GetTitle(localUser);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Achievement)+58]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Achievement)+58]");
				if ((nint)0 != 0 && title != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v15+10]");
					return title.Equals((string)0);
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_01fb:
			return false;
			IL_006f:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Achievement)+58]");
			if ((nint)0 != 0)
			{
				goto IL_0094;
			}
			goto IL_01fb;
		}
	}

	private void Awake()
	{
		SetupButtons();
	}

	private void Reset()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_002c: Expected O, but got I
		//IL_007f: Expected O, but got I4
		//IL_00dc: Expected I4, but got O
		//IL_01c1: Expected O, but got I4
		//IL_01ca: Expected O, but got I4
		//IL_01dc: Expected O, but got I4
		//IL_0117: Expected O, but got I4
		//IL_034f: Expected O, but got I4
		Image icon = Icon;
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		nint num = (nint)icon;
		icon.color = (Color)0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v6+E4]");
		UnityEngine.Object obj4;
		int num2;
		if ((nint)0 != 0)
		{
			bool flag = progressBar != null;
			bool flag2 = !flag;
			object obj3 = !flag2;
			num2 = 0;
			obj4 = null;
			if (obj3 == null)
			{
				goto IL_009b;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = progressBar != null;
			bool flag4 = !flag3;
			num2 = 0;
			obj4 = null;
			if (flag4)
			{
				goto IL_009b;
			}
		}
		progressBar.Initialize(1, 0);
		UnityEngine.Object resetTitle = ResetTitle;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X0_v23+E4]");
		bool flag5 = (nint)0 == 0;
		object obj6 = !flag5;
		object obj7 = 0;
		num2 = 0;
		object obj8 = 0;
		int num3 = 0;
		int num4 = 1;
		UnityEngine.Object resetTitle2 = ResetTitle;
		if (obj6 != null)
		{
			goto IL_00f4;
		}
		goto IL_0206;
		IL_0283:
		UpdateActiveMark(active: false);
		object obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v15+E4]");
		if ((nint)0 != 0)
		{
			if (!ApplyTitle)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag6 = ApplyTitle;
			bool flag7 = !flag6;
			object obj10 = !flag7;
			if (obj10 == null)
			{
				return;
			}
		}
		ApplyTitle.interactable = false;
		GameObject gameObject = ApplyTitle.gameObject;
		gameObject.SetActive(value: true);
		return;
		IL_024b:
		GameObject gameObject2 = ResetTitle.gameObject;
		gameObject2.SetActive(value: false);
		obj8 = obj7;
		num2 = 0;
		goto IL_0283;
		IL_00f4:
		bool flag8 = resetTitle;
		bool flag9 = !flag8;
		object obj11 = !flag9;
		if (obj11 != null)
		{
			goto IL_024b;
		}
		obj8 = obj7;
		goto IL_0283;
		IL_009b:
		obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X0_v23+E4]");
		bool flag10 = (nint)0 == 0;
		resetTitle = ResetTitle;
		obj8 = obj7;
		num3 = num2;
		num4 = (int)obj4;
		resetTitle2 = ResetTitle;
		if (!flag10)
		{
			goto IL_00f4;
		}
		goto IL_0206;
		IL_0206:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag11 = resetTitle2;
		bool flag12 = !flag11;
		obj7 = obj8;
		num2 = num3;
		if (!flag12)
		{
			goto IL_024b;
		}
		goto IL_0283;
	}

	public unsafe override void Setup(AchievementHolder datum, bool firstTime)
	{
		//IL_000c: Expected O, but got I
		//IL_012d: Expected O, but got Ref
		//IL_014a: Expected O, but got I
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_004a: Expected O, but got I
		//IL_007e: Expected O, but got I4
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00e6: Expected O, but got I
		//IL_00f4: Expected I, but got O
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		object obj = (nint)0 + (nint)1496;
		int num = default(int);
		base.Setup((AchievementHolder)(&num), firstTime);
		Reset();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Achievement)+50]");
		UpdateName((GameAchievementViewModel)0);
		RefreshTitle();
		UpdateProgress();
		if (firstTime)
		{
			object obj2 = typeof(Queue<string>) + 848;
			object obj3 = (nint)0 + (nint)2200;
			GameObject go = base.gameObject;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel = default(SessionModel);
			User localUser = sessionModel.LocalUser;
			object obj6 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj7 = (nint)0 + (nint)1616;
			Action action = default(Action);
			action..ctor(this, (IntPtr)obj7);
			object varName = "___# Content push apply failed [{0}]: {1}" + 3976;
			VariableBinderExtensions.Bind(go, localUser, (string)varName, action);
		}
	}

	public void Initialize(GameAchievementViewModel model, UserAchievementModel userModel, Action<bool> onSuccess = null)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_006e: Expected O, but got I
		GameAchievementViewModel model2 = default(GameAchievementViewModel);
		UserAchievementModel userModel2 = default(UserAchievementModel);
		AchievementHolder achievementHolder = new AchievementHolder(model2, userModel2, isItMine: false);
		_ = 0;
		_ = 0;
		object obj = this + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Reset();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Achievement)+50]");
		UpdateName((GameAchievementViewModel)0);
		RefreshTitle();
		UpdateProgress();
	}

	public void Initialize(UserAchievementModel userModel)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected O, but got Unknown
		//IL_0136: Expected O, but got I4
		//IL_0083: Expected O, but got I
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_0156: Expected O, but got I
		//IL_0180: Expected O, but got I4
		//IL_00d0: Expected O, but got I
		object obj = typeof(SqlSingle[]) + 2360;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3+E4]");
		if ((nint)0 != 0)
		{
			object obj3 = typeof(DeviceRemoveEvent) & 1;
			if (obj3 != null)
			{
				goto IL_0077;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj4 = typeof(DeviceRemoveEvent) & 1;
			bool flag = obj4 == null;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_0077;
			}
		}
		_ = 1;
		object obj6 = (nint)0 + (nint)2080;
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v16+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		object obj9 = obj6;
		object obj10 = obj7;
		if (obj8 != null)
		{
			goto IL_00c0;
		}
		goto IL_019e;
		IL_00c0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v16+B8]");
		object dictionary = 0;
		object valueOrDefault = CollectionExtensions.GetValueOrDefault((IReadOnlyDictionary<object, object>)dictionary, userModel.<gameAchievementId>k__BackingField);
		Action<bool> onSuccess = default(Action<bool>);
		Initialize((GameAchievementViewModel)valueOrDefault, userModel, onSuccess);
		return;
		IL_019e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj7 = obj;
		obj6 = obj9;
		goto IL_00c0;
		IL_0077:
		obj6 = (nint)0 + (nint)2080;
		obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v16+E4]");
		bool flag3 = (nint)0 == 0;
		obj9 = obj6;
		obj10 = obj7;
		if (!flag3)
		{
			goto IL_00c0;
		}
		goto IL_019e;
	}

	public void Initialize()
	{
		//IL_001e: Expected O, but got I
		Reset();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Achievement)+50]");
		UpdateName((GameAchievementViewModel)0);
		RefreshTitle();
		UpdateProgress();
	}

	public void DisableProgerssBar()
	{
		progressBar.Initialize(1, 0);
	}

	public GameAchievementViewModel GetAchievementModel()
	{
		//IL_0012: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Achievement)+50]");
		return (GameAchievementViewModel)0;
	}

	public void Select()
	{
		UpdateActiveMark(active: true);
	}

	public void Deselect()
	{
		UpdateActiveMark(active: false);
	}

	private void RefreshAchievement(Action<bool> onSuccess = null)
	{
		//IL_0018: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Achievement)+50]");
		UpdateName((GameAchievementViewModel)0);
		RefreshTitle();
		UpdateProgress();
	}

	private void RefreshTitle()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_01f6: Expected O, but got I4
		//IL_00b3: Expected O, but got I4
		//IL_00c1: Expected O, but got I4
		//IL_029c: Expected I4, but got O
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_00f1: Expected O, but got I4
		//IL_0107: Expected O, but got I
		//IL_0241: Expected O, but got I4
		//IL_024a: Expected O, but got I4
		//IL_0258: Expected O, but got I4
		//IL_07b7: Expected O, but got I4
		//IL_07c0: Expected O, but got I4
		//IL_02d6: Expected O, but got I4
		//IL_041f: Expected O, but got I
		//IL_042f: Expected O, but got I
		//IL_0459: Expected O, but got I4
		//IL_0469: Expected O, but got I
		//IL_07e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e7: Expected O, but got Unknown
		//IL_07fe: Expected I4, but got O
		//IL_01a9: Expected O, but got I4
		//IL_0130: Expected O, but got I
		//IL_0140: Expected O, but got I
		//IL_016f: Expected O, but got I
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Expected O, but got Unknown
		//IL_0342: Expected O, but got I4
		//IL_034b: Expected O, but got I4
		//IL_035c: Expected O, but got I4
		//IL_0364: Expected O, but got I4
		//IL_03ac: Expected O, but got I4
		//IL_0845: Expected I4, but got O
		//IL_04db: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e0: Expected O, but got Unknown
		//IL_03fe: Expected O, but got I4
		//IL_0584: Expected O, but got I4
		//IL_058d: Expected O, but got I4
		//IL_0532: Expected O, but got I4
		//IL_05c5: Expected O, but got I4
		//IL_08b2: Expected O, but got I4
		//IL_061a: Unknown result type (might be due to invalid IL or missing references)
		//IL_061f: Expected O, but got Unknown
		//IL_06b7: Expected O, but got I4
		//IL_075b: Expected O, but got I4
		//IL_0764: Expected O, but got I4
		//IL_06db: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6BA8]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object applyTitle;
		UnityEngine.Object applyTitle2;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v36+E4]");
			bool flag = (nint)0 == 0;
			applyTitle = ApplyTitle;
			applyTitle2 = ApplyTitle;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			applyTitle = ApplyTitle;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v36+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			applyTitle2 = ApplyTitle;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = applyTitle2 != null;
		bool flag4 = !flag3;
		object obj6 = !flag4;
		object obj7 = 0;
		UnityEngine.Object obj8 = null;
		object obj9 = 0;
		UnityEngine.Object obj10 = null;
		if (obj6 != null)
		{
			goto IL_00d4;
		}
		goto IL_026b;
		IL_088f:
		throw new NullReferenceException();
		IL_085d:
		UnityEngine.Object applyLoading;
		if (!applyLoading)
		{
			return;
		}
		goto IL_0883;
		IL_0883:
		ApplyLoading.FinishLoading();
		return;
		IL_0091:
		bool flag5 = applyTitle != null;
		bool flag6 = !flag5;
		obj7 = 0;
		obj8 = null;
		obj9 = 0;
		obj10 = null;
		if (!flag6)
		{
			goto IL_00d4;
		}
		goto IL_026b;
		IL_026b:
		UnityEngine.Object resetTitle = ResetTitle;
		object obj11 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v9+E4]");
		bool flag7 = (nint)0 == 0;
		bool flag8 = (byte)(int)obj10 != 0;
		UnityEngine.Object resetTitle2 = ResetTitle;
		if (!flag7)
		{
			goto IL_02b4;
		}
		goto IL_0784;
		IL_00d4:
		object obj12 = typeof(Queue<string>) + 848;
		object obj13 = 152985600;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6BA1]");
		object obj14 = (nint)0 & (nint)1;
		object obj16;
		object obj18;
		object obj19;
		object obj15;
		if (obj14 != null)
		{
			obj15 = (nint)0 + (nint)2200;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Achievement)+50]");
			obj16 = 0;
			object obj17 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X0_v97+E4]");
			bool flag9 = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Achievement)+50]");
			obj18 = 0;
			obj19 = obj15;
			if (!flag9)
			{
				goto IL_0185;
			}
		}
		else
		{
			_ = 1;
			obj15 = (nint)0 + (nint)2200;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Achievement)+50]");
			obj16 = 0;
			object obj17 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X0_v97+E4]");
			bool flag10 = (nint)0 == 0;
			object obj20 = !flag10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Achievement)+50]");
			obj18 = 0;
			obj19 = obj15;
			if (obj20 != null)
			{
				goto IL_0185;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		obj16 = obj18;
		obj15 = obj19;
		goto IL_04ad;
		IL_02b4:
		bool flag11 = resetTitle != null;
		bool flag12 = !flag11;
		object obj21 = 0;
		UnityEngine.Object obj22 = null;
		if (!flag12)
		{
			goto IL_02e9;
		}
		goto IL_07d3;
		IL_06ff:
		bool interactable;
		ApplyTitle.interactable = interactable;
		bool flag13 = isActiveTitle;
		UpdateActiveMark(flag13);
		resetTitle = ResetTitle;
		obj11 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v9+E4]");
		bool flag14 = (nint)0 == 0;
		object obj23 = !flag14;
		obj9 = 0;
		flag8 = flag13;
		resetTitle2 = ResetTitle;
		if (obj23 != null)
		{
			goto IL_02b4;
		}
		goto IL_0784;
		IL_0896:
		bool flag15 = (object)ApplyTitle == null;
		object obj24 = !flag15;
		if (obj24 != null)
		{
			goto IL_06ff;
		}
		goto IL_088f;
		IL_0185:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool flag16 = (object)sessionModel == null;
		object obj25 = !flag16;
		if (obj25 != null)
		{
			goto IL_04ad;
		}
		goto IL_088f;
		IL_04ad:
		User localUser = sessionModel.LocalUser;
		string title = SFSKammelnaUserExtensions.GetTitle(localUser);
		object obj26 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		object obj27 = obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X8_v28+E4]");
		if ((nint)0 != 0)
		{
			bool flag17 = StringsExtensions.IsNullOrEmpty(title);
			bool flag18 = !flag17;
			object obj28 = 0;
			if (!flag18)
			{
				goto IL_0540;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag19 = StringsExtensions.IsNullOrEmpty(title);
			bool flag20 = !flag19;
			object obj29 = !flag20;
			object obj28 = 0;
			if (obj29 != null)
			{
				goto IL_0540;
			}
		}
		object obj30 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X0_v83+E4]");
		bool flag21 = (nint)0 == 0;
		object obj31 = !flag21;
		if (obj31 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel2 = default(SessionModel);
		User localUser2 = sessionModel2.LocalUser;
		string title2 = SFSKammelnaUserExtensions.GetTitle(localUser2);
		object obj32 = "Material with texture name \"" + 3544;
		bool flag22 = title2 != (string)obj32;
		interactable = flag22;
		goto IL_063d;
		IL_07d3:
		object obj33 = typeof(IPAddress) & 1;
		bool flag23 = obj33 == null;
		bool flag24 = (byte)(int)obj22 != 0;
		object obj34 = obj21;
		if (flag23)
		{
			goto IL_0372;
		}
		goto IL_0814;
		IL_02e9:
		GameObject gameObject = ResetTitle.gameObject;
		bool flag25 = isActiveTitle;
		gameObject.SetActive(flag25);
		object obj35 = typeof(IPAddress) & 1;
		bool flag26 = obj35 == null;
		object obj36 = !flag26;
		obj21 = 0;
		flag24 = flag25;
		obj34 = 0;
		obj22 = (UnityEngine.Object)flag25;
		if (obj36 == null)
		{
			goto IL_0372;
		}
		goto IL_0814;
		IL_0784:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag27 = resetTitle2 != null;
		bool flag28 = !flag27;
		object obj37 = !flag28;
		obj21 = 0;
		obj22 = null;
		if (obj37 != null)
		{
			goto IL_02e9;
		}
		goto IL_07d3;
		IL_0814:
		UnityEngine.Object applyLoading2 = ApplyLoading;
		object obj38 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X8_v11+E4]");
		bool flag29 = (nint)0 == 0;
		flag24 = (byte)(int)obj22 != 0;
		applyLoading = ApplyLoading;
		if (flag29)
		{
			goto IL_03cc;
		}
		goto IL_085d;
		IL_0372:
		_ = 1;
		applyLoading2 = ApplyLoading;
		obj38 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X8_v11+E4]");
		bool flag30 = (nint)0 == 0;
		object obj39 = !flag30;
		obj34 = obj21;
		applyLoading = ApplyLoading;
		if (obj39 == null)
		{
			goto IL_03cc;
		}
		goto IL_085d;
		IL_0540:
		interactable = false;
		goto IL_063d;
		IL_063d:
		GameObject gameObject2 = ApplyTitle.gameObject;
		bool flag31 = isActiveTitle;
		bool active = (byte)((flag31 ? 1u : 0u) ^ 1u) != 0;
		gameObject2.SetActive(active);
		if (obj16 != null)
		{
			bool flag32 = isActiveTitle;
			bool flag33 = !flag32;
			object obj40 = !flag33;
			if (obj40 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Achievement)+58]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Achievement)+58]");
					bool isUnlocked = ((UserAchievementModel)0).isUnlocked;
					interactable = isUnlocked;
					goto IL_0896;
				}
			}
			interactable = false;
			goto IL_06ff;
		}
		goto IL_0896;
		IL_03cc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag34 = applyLoading2;
		bool flag35 = !flag34;
		object obj41 = !flag35;
		if (obj41 == null)
		{
			return;
		}
		goto IL_0883;
	}

	private void UpdateProgress()
	{
		//IL_0016: Expected O, but got I
		//IL_00d9: Expected O, but got I
		//IL_00f3: Expected O, but got I4
		//IL_00fc: Expected O, but got I4
		//IL_0105: Expected O, but got I4
		//IL_0088: Expected O, but got I
		//IL_00aa: Expected O, but got I4
		//IL_0049: Expected O, but got I
		//IL_0061: Expected O, but got I4
		//IL_006a: Expected O, but got I4
		//IL_0166: Expected O, but got I
		//IL_0129: Expected O, but got I
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected O, but got Unknown
		//IL_02ac: Expected O, but got I4
		//IL_07a2: Expected O, but got I
		//IL_01e1: Expected O, but got I4
		//IL_0863: Unknown result type (might be due to invalid IL or missing references)
		//IL_0868: Expected O, but got Unknown
		//IL_0892: Expected O, but got I4
		//IL_032f: Expected I4, but got I8
		//IL_0838: Expected O, but got I4
		//IL_0374: Expected O, but got I4
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Expected I4, but got Unknown
		//IL_03e2: Expected O, but got I4
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ef: Expected O, but got Unknown
		//IL_0900: Expected O, but got I4
		//IL_0908: Unknown result type (might be due to invalid IL or missing references)
		//IL_090d: Expected O, but got Unknown
		//IL_093e: Expected O, but got I4
		//IL_04d1: Expected O, but got I4
		//IL_047a: Expected O, but got I4
		//IL_0483: Expected O, but got I4
		//IL_04fe: Expected O, but got I
		//IL_0518: Expected O, but got I4
		//IL_09c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cd: Expected O, but got Unknown
		//IL_09e3: Expected O, but got I
		//IL_09f1: Expected I, but got O
		//IL_0587: Expected O, but got I4
		//IL_0554: Expected O, but got I
		//IL_0a0c: Expected O, but got I
		//IL_063c: Expected O, but got I
		//IL_0656: Expected O, but got I4
		//IL_0a39: Expected O, but got I
		//IL_0685: Expected O, but got I
		//IL_0a4f: Expected O, but got I
		//IL_0a5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a64: Expected I4, but got Unknown
		//IL_0a74: Expected O, but got I
		//IL_06b4: Expected O, but got I4
		//IL_0b0a: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6BA9]");
		object obj = (nint)0 & (nint)1;
		object obj4;
		object obj3;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6BA1]");
			object obj2 = (nint)0 & (nint)1;
			bool flag = obj2 == null;
			obj3 = 152985600;
			obj4 = 152985600;
			if (!flag)
			{
				goto IL_0078;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6BA1]");
			object obj5 = (nint)0 & (nint)1;
			bool flag2 = obj5 == null;
			object obj6 = !flag2;
			obj3 = 152985600;
			obj4 = 152985600;
			if (obj6 != null)
			{
				goto IL_0078;
			}
		}
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Achievement)+50]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Achievement)+50]");
		bool flag3 = (nint)0 == 0;
		obj3 = obj4;
		if (!flag3)
		{
			goto IL_0156;
		}
		goto IL_0246;
		IL_0308:
		OnLevelTabSelected(1);
		return;
		IL_0982:
		int num;
		OnLevelTabSelected(num);
		object obj9;
		object obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X0_v23+E4]");
		if ((nint)0 != 0)
		{
			bool flag4 = progressBar != null;
			bool flag5 = !flag4;
			object obj10 = !flag5;
			if (obj10 == null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (!(progressBar != null))
			{
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Achievement)+60]");
		object obj11 = (nint)0 & (nint)1;
		int num2;
		if (obj11 != null)
		{
			int index = num2 - 1;
			if (num2 >= 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v8+18]");
				if ((nint)num2 <= (nint)0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X26_v4+BA1]");
					object obj12 = (nint)0 & (nint)1;
					bool flag6 = obj12 == null;
					object obj13 = !flag6;
					if (obj13 == null)
					{
						_ = 1;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Achievement)+50]");
					object obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X8_v25+38]");
					object obj15 = ((List<object>)0).get_Item(index);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X0_v30 (System.Object)+14]");
					object obj16 = ~(nint)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X0_v30 (System.Object)+14]");
					int num3 = 0 & obj16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Achievement)+58]");
					object obj17 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Achievement)+58]");
					int num8;
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v618 @ X8_v30+18]");
						bool flag7 = (nint)0 < (nint)num3;
						object obj18 = !flag7;
						object obj19 = ~obj18;
						object obj20 = ~obj19;
						int num4;
						if (obj20 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v618 @ X8_v30+18]");
							num4 = 0;
						}
						else
						{
							num4 = num3;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v618 @ X8_v30+18]");
						bool flag8 = (nint)0 < (nint)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v618 @ X8_v30+18]");
						nint num5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v618 @ X8_v30+18]");
						int num6 = (int)(num5 ^ 0);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v618 @ X8_v30+18]");
						int num7 = (int)((nint)0 & (nint)num6);
						bool flag9 = num7 < 0;
						bool flag10 = flag8 == flag9;
						object obj21 = !flag10;
						object obj22 = ~obj21;
						num8 = ((obj22 != null) ? num4 : 0);
					}
					else
					{
						num8 = 0;
					}
					progressBar.Initialize(num3, num8);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X0_v30 (System.Object)+14]");
					if ((nint)0 <= (nint)0 && num8 <= 0)
					{
						DisableProgerssBar();
					}
					return;
				}
			}
		}
		progressBar.Initialize(1, 0);
		return;
		IL_0246:
		object obj23 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj24 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v4+E4]");
		if ((nint)0 != 0)
		{
			bool flag11 = levelsStrip;
			bool flag12 = !flag11;
			object obj25 = !flag12;
			if (obj25 != null)
			{
				goto IL_02f8;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if ((bool)levelsStrip)
			{
				goto IL_02f8;
			}
		}
		goto IL_0308;
		IL_0078:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Achievement)+50]");
		obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Achievement)+50]");
		bool flag13 = (nint)0 == 0;
		object obj26 = !flag13;
		if (obj26 != null)
		{
			goto IL_0156;
		}
		goto IL_0246;
		IL_0156:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v7+38]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v7+38]");
		int num14;
		int num23;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v8+18]");
			if ((nint)0 > (nint)1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Achievement)+58]");
				object obj28 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Achievement)+58]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v11+1C]");
					nint num9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v8+18]");
					bool flag14 = num9 < 0;
					object obj29 = !flag14;
					object obj30 = ~obj29;
					object obj31 = ~obj30;
					int num10;
					if (obj31 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v11+1C]");
						num10 = 0;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v8+18]");
						num10 = 0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v11+1C]");
					bool flag15 = (nint)0 < (nint)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v11+1C]");
					nint num11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v11+1C]");
					int num12 = (int)(num11 ^ 0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v11+1C]");
					int num13 = (int)((nint)0 & (nint)num12);
					bool flag16 = num13 < 0;
					bool flag17 = flag15 == flag16;
					object obj32 = !flag17;
					object obj33 = ~obj32;
					num14 = ((obj33 != null) ? num10 : 0);
				}
				else
				{
					num14 = 0;
				}
				int num15 = num14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v8+18]");
				num2 = (int)(((nint)num15 < (nint)0) ? (num14 + 1) : 4294967295L);
				obj9 = typeof(MemberAchievementClanFeedData) + 2976;
				object obj34 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ X0_v16+E4]");
				bool flag18 = (nint)0 == 0;
				object obj35 = !flag18;
				if (obj35 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag19 = levelsStrip == null;
				object obj36 = num14 - 1;
				bool flag20 = (nint)obj36 < 0;
				bool flag21 = obj36 == null;
				int num16 = num14 ^ 1;
				int num17 = num14 ^ obj36;
				int num18 = num16 & num17;
				bool flag22 = num18 < 0;
				bool flag23 = flag20 == flag22;
				object obj37 = !flag21;
				object obj38 = flag23 & obj37;
				object obj39 = ~obj38;
				int num19 = ((obj39 != null) ? 1 : num14);
				bool flag24 = num2 < 0;
				bool flag25 = num2 == 0;
				int num20 = num2 ^ num2;
				int num21 = num2 & num20;
				bool flag26 = num21 < 0;
				bool flag27 = flag24 == flag26;
				object obj40 = !flag25;
				object obj41 = flag27 & obj40;
				object obj42 = ~obj41;
				int num22 = ((obj42 != null) ? num19 : num2);
				bool flag28 = !flag19;
				object obj43 = !flag28;
				object obj44 = ~obj43;
				num = ((obj44 != null) ? num22 : num19);
				object obj45 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X0_v20+E4]");
				if ((nint)0 != 0)
				{
					bool flag29 = levelsStrip;
					bool flag30 = !flag29;
					object obj46 = !flag30;
					object obj47 = 0;
					if (obj46 != null)
					{
						goto IL_04e8;
					}
					num23 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					bool flag31 = levelsStrip;
					bool flag32 = !flag31;
					object obj47 = 0;
					num23 = 0;
					if (!flag32)
					{
						goto IL_04e8;
					}
				}
				goto IL_0982;
			}
		}
		goto IL_0246;
		IL_02f8:
		levelsStrip.Clear();
		goto IL_0308;
		IL_04e8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X26_v4+BA1]");
		object obj48 = (nint)0 & (nint)1;
		bool flag33 = obj48 == null;
		object obj49 = !flag33;
		if (obj49 == null)
		{
			_ = 1;
		}
		object obj50 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2416;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj51 = (nint)0 + (nint)1608;
		Action<int> action = default(Action<int>);
		action..ctor((object)this, (IntPtr)obj51);
		AchievementLevelsStrip achievementLevelsStrip = levelsStrip;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Achievement)+50]");
		achievementLevelsStrip.BuildTabs((GameAchievementViewModel)0, num, num14, action);
		num23 = num;
		goto IL_0982;
	}

	private void SetupButtons()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_034c: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_00be: Expected O, but got I4
		//IL_00cc: Expected O, but got I4
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d9: Expected O, but got Unknown
		//IL_03ef: Expected O, but got I
		//IL_03fd: Expected I, but got O
		//IL_0395: Expected O, but got I4
		//IL_03a3: Expected O, but got I4
		//IL_0448: Expected O, but got I4
		//IL_0451: Expected O, but got I4
		//IL_045a: Expected O, but got I4
		//IL_0463: Expected O, but got I4
		//IL_0154: Expected O, but got I4
		//IL_015d: Expected O, but got I4
		//IL_0173: Expected O, but got I4
		//IL_04bc: Expected O, but got I4
		//IL_04ca: Expected O, but got I4
		//IL_04fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0500: Expected O, but got Unknown
		//IL_0516: Expected O, but got I
		//IL_0524: Expected I, but got O
		//IL_056f: Expected O, but got I4
		//IL_0578: Expected O, but got I4
		//IL_0581: Expected O, but got I4
		//IL_058a: Expected O, but got I4
		//IL_05e3: Expected O, but got I4
		//IL_05f1: Expected O, but got I4
		//IL_01fb: Expected O, but got I4
		//IL_0204: Expected O, but got I4
		//IL_021a: Expected O, but got I4
		//IL_0622: Unknown result type (might be due to invalid IL or missing references)
		//IL_0627: Expected O, but got Unknown
		//IL_063d: Expected O, but got I
		//IL_064b: Expected I, but got O
		//IL_0704: Expected O, but got I4
		//IL_0715: Expected O, but got I4
		//IL_02a0: Expected O, but got I4
		//IL_0696: Expected O, but got I4
		//IL_069f: Expected O, but got I4
		//IL_06a8: Expected O, but got I4
		//IL_06b1: Expected O, but got I4
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected O, but got Unknown
		//IL_02ec: Expected O, but got I
		//IL_02fa: Expected I, but got O
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6B08]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object showDescriptionButton;
		UnityEngine.Object showDescriptionButton2;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v33+E4]");
			bool flag = (nint)0 == 0;
			showDescriptionButton = ShowDescriptionButton;
			showDescriptionButton2 = ShowDescriptionButton;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			showDescriptionButton = ShowDescriptionButton;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v33+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			showDescriptionButton2 = ShowDescriptionButton;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = showDescriptionButton2 != null;
		bool flag4 = !flag3;
		object obj6 = 0;
		UnityEngine.Object obj7 = null;
		object obj8 = 0;
		UnityEngine.Object obj9 = null;
		if (flag4)
		{
			goto IL_00df;
		}
		goto IL_03b6;
		IL_02b3:
		Button invokeCallbackButton = InvokeCallbackButton;
		object obj10 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj11 = (nint)0 + (nint)1600;
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj11);
		invokeCallbackButton.m_OnClick.AddListener(unityAction);
		return;
		IL_027e:
		UnityEngine.Object invokeCallbackButton2;
		bool flag5 = invokeCallbackButton2 != null;
		bool flag6 = !flag5;
		object obj12 = 0;
		UnityEngine.Object obj13 = null;
		if (!flag6)
		{
			goto IL_02b3;
		}
		return;
		IL_06d1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object invokeCallbackButton3;
		bool flag7 = invokeCallbackButton3 != null;
		bool flag8 = !flag7;
		object obj14 = !flag8;
		object obj16;
		object obj15 = obj16;
		obj12 = 0;
		obj13 = null;
		if (obj14 == null)
		{
			return;
		}
		goto IL_02b3;
		IL_0091:
		bool flag9 = showDescriptionButton != null;
		bool flag10 = !flag9;
		object obj17 = !flag10;
		obj6 = 0;
		obj7 = null;
		obj8 = 0;
		obj9 = null;
		if (obj17 == null)
		{
			goto IL_00df;
		}
		goto IL_03b6;
		IL_03b6:
		Button showDescriptionButton3 = ShowDescriptionButton;
		object obj18 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj19 = (nint)0 + (nint)1632;
		UnityAction unityAction2 = default(UnityAction);
		unityAction2..ctor(this, (IntPtr)obj19);
		showDescriptionButton3.m_OnClick.AddListener(unityAction2);
		UnityEngine.Object applyTitle = ApplyTitle;
		object obj20 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v24+E4]");
		bool flag11 = (nint)0 == 0;
		object obj21 = !flag11;
		obj15 = 0;
		object obj22 = 0;
		obj6 = 0;
		UnityAction unityAction3 = unityAction2;
		UnityEngine.Object applyTitle2 = ApplyTitle;
		if (obj21 != null)
		{
			goto IL_0130;
		}
		goto IL_0483;
		IL_00df:
		obj20 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v24+E4]");
		bool flag12 = (nint)0 == 0;
		applyTitle = ApplyTitle;
		obj22 = obj15;
		unityAction3 = (UnityAction)(object)obj7;
		applyTitle2 = ApplyTitle;
		if (!flag12)
		{
			goto IL_0130;
		}
		goto IL_0483;
		IL_0483:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag13 = applyTitle2 != null;
		bool flag14 = !flag13;
		obj15 = obj22;
		object obj23 = 0;
		UnityEngine.Object obj24 = null;
		object obj25 = 0;
		UnityEngine.Object obj26 = null;
		if (flag14)
		{
			goto IL_0186;
		}
		goto IL_04dd;
		IL_0130:
		bool flag15 = applyTitle != null;
		bool flag16 = !flag15;
		object obj27 = !flag16;
		obj23 = 0;
		obj24 = null;
		obj22 = obj15;
		obj25 = 0;
		obj26 = null;
		if (obj27 == null)
		{
			goto IL_0186;
		}
		goto IL_04dd;
		IL_04dd:
		Button applyTitle3 = ApplyTitle;
		object obj28 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj29 = (nint)0 + (nint)1592;
		UnityAction unityAction4 = default(UnityAction);
		unityAction4..ctor(this, (IntPtr)obj29);
		applyTitle3.m_OnClick.AddListener(unityAction4);
		UnityEngine.Object resetTitle = ResetTitle;
		object obj30 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X8_v12+E4]");
		bool flag17 = (nint)0 == 0;
		object obj31 = !flag17;
		obj15 = 0;
		object obj32 = 0;
		obj23 = 0;
		UnityAction unityAction5 = unityAction4;
		UnityEngine.Object resetTitle2 = ResetTitle;
		if (obj31 != null)
		{
			goto IL_01d7;
		}
		goto IL_05aa;
		IL_0186:
		resetTitle = ResetTitle;
		obj30 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X8_v12+E4]");
		bool flag18 = (nint)0 == 0;
		obj32 = obj15;
		unityAction5 = (UnityAction)(object)obj24;
		resetTitle2 = ResetTitle;
		if (!flag18)
		{
			goto IL_01d7;
		}
		goto IL_05aa;
		IL_05aa:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag19 = resetTitle2 != null;
		bool flag20 = !flag19;
		obj15 = obj32;
		object obj33 = 0;
		UnityEngine.Object obj34 = null;
		object obj35 = 0;
		UnityEngine.Object obj36 = null;
		if (flag20)
		{
			goto IL_022d;
		}
		goto IL_0604;
		IL_01d7:
		bool flag21 = resetTitle != null;
		bool flag22 = !flag21;
		object obj37 = !flag22;
		obj33 = 0;
		obj34 = null;
		obj32 = obj15;
		obj35 = 0;
		obj36 = null;
		if (obj37 == null)
		{
			goto IL_022d;
		}
		goto IL_0604;
		IL_0604:
		Button resetTitle3 = ResetTitle;
		object obj38 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj39 = (nint)0 + (nint)1624;
		UnityAction unityAction6 = default(UnityAction);
		unityAction6..ctor(this, (IntPtr)obj39);
		resetTitle3.m_OnClick.AddListener(unityAction6);
		invokeCallbackButton2 = InvokeCallbackButton;
		object obj40 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X8_v4+E4]");
		bool flag23 = (nint)0 == 0;
		object obj41 = !flag23;
		obj15 = 0;
		obj16 = 0;
		obj33 = 0;
		UnityAction unityAction7 = unityAction6;
		invokeCallbackButton3 = InvokeCallbackButton;
		if (obj41 != null)
		{
			goto IL_027e;
		}
		goto IL_06d1;
		IL_022d:
		invokeCallbackButton2 = InvokeCallbackButton;
		obj40 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X8_v4+E4]");
		bool flag24 = (nint)0 == 0;
		obj16 = obj15;
		unityAction7 = (UnityAction)(object)obj34;
		invokeCallbackButton3 = InvokeCallbackButton;
		if (!flag24)
		{
			goto IL_027e;
		}
		goto IL_06d1;
	}

	private void UpdateActiveMark(bool active)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_010a: Expected O, but got I4
		//IL_015f: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6B09]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object activeMark;
		UnityEngine.Object activeMark2;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			activeMark = ActiveMark;
			activeMark2 = ActiveMark;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			activeMark = ActiveMark;
			activeMark2 = ActiveMark;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = activeMark2 != null;
		bool flag4 = !flag3;
		object obj6 = !flag4;
		if (obj6 == null)
		{
			return;
		}
		goto IL_00b8;
		IL_00b8:
		GameObject gameObject = ActiveMark.gameObject;
		gameObject.SetActive(active);
		return;
		IL_0091:
		if (activeMark != null)
		{
			goto IL_00b8;
		}
	}

	private void UpdateIcon(GameAchievementViewModel model, int selectedLevel, Action<bool> onSuccess = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_010d: Expected O, but got I4
		//IL_013d: Expected O, but got I4
		//IL_01da: Expected O, but got I
		//IL_0406: Expected O, but got I
		//IL_020f: Expected O, but got I
		//IL_0251: Expected O, but got I
		//IL_027d: Expected O, but got I
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Expected O, but got Unknown
		//IL_02c7: Expected O, but got I4
		//IL_0301: Expected O, but got I4
		//IL_02ee: Expected O, but got I
		//IL_0364: Expected O, but got I4
		//IL_057a: Expected O, but got I4
		//IL_05e7: Expected O, but got I
		//IL_03c1: Expected O, but got I
		//IL_0619: Expected O, but got I
		//IL_03cf: Expected F8, but got I4
		//IL_03d8: Expected F8, but got I4
		//IL_03e1: Expected F8, but got I4
		//IL_03ea: Expected F8, but got I4
		//IL_0487: Expected O, but got I
		//IL_049c: Expected O, but got I
		//IL_04b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b9: Expected O, but got Unknown
		//IL_04cf: Expected O, but got I
		//IL_04e0: Expected I, but got O
		//IL_050c: Expected O, but got I
		object obj = typeof(XmlSchemaInclude) + 3632;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 24;
		obj4 = model;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj2 + 40;
		obj5 = onSuccess;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		GameObject gameObject = Icon.gameObject;
		object obj6 = typeof(MemberAchievementClanFeedData) + 2976;
		gameObject.SetActive(value: false);
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v4+E4]");
		if ((nint)0 != 0)
		{
			bool flag = emptyIcon;
			bool flag2 = !flag;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				goto IL_011b;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (!emptyIcon)
			{
				goto IL_011b;
			}
		}
		bool active = obj4 == null;
		emptyIcon.SetActive(active);
		object obj9 = obj4;
		if (obj4 != null)
		{
			goto IL_01ca;
		}
		goto IL_03ef;
		IL_03ef:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6000]");
		Actions.SafeInvoke((Action<bool>)0, arg: false);
		return;
		IL_05d7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Achievement)+58]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Achievement)+58]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v17+1C]");
			obj10 = 0;
		}
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3 (System.Object)+20]");
		if ((nint)obj11 < 0)
		{
			double num = 1059366053.0;
			double num2 = 1057918607.0;
			double num3 = 1055188197.0;
			double num4 = 1050714273.0;
		}
		else
		{
			double num = 1.0;
			double num2 = 1.0;
			double num3 = 1.0;
			double num4 = 1.0;
		}
		Icon.color = (Color)0;
		object obj12 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X8_v20+38]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3 (System.Object)+20]");
			int index = (int)(-1);
			object obj13 = (nint)0 + (nint)296;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X8_v20+38]");
			object obj14 = ((List<object>)0).get_Item(index);
			object obj15 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj16 = (nint)0 + (nint)1944;
			Action<bool> action = default(Action<bool>);
			action..ctor(obj2, (IntPtr)obj16);
			Image icon = Icon;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X8_v20+10]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v33 (System.Object)+10]");
			UIExtensions.LoadAchievementImage(icon, (string)num5, 0, action);
		}
		return;
		IL_039d:
		RotatingLoadingIndicator rotatingLoadingIndicator;
		rotatingLoadingIndicator.StartLoading();
		goto IL_05d7;
		IL_011b:
		obj9 = obj4;
		bool flag3 = obj4 == null;
		object obj17 = !flag3;
		if (obj17 != null)
		{
			goto IL_01ca;
		}
		goto IL_03ef;
		IL_01ca:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X8_v8+38]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X8_v8+38]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X8_v9+18]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X8_v9+18]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3 (System.Object)+20]");
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X8_v9+18]");
				object obj20 = num6 - 0;
				bool flag4 = (nint)obj20 < 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3 (System.Object)+20]");
				nint num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X8_v9+18]");
				object obj21 = num7 ^ 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3 (System.Object)+20]");
				object obj22 = 0 ^ obj20;
				object obj23 = obj21 & obj22;
				bool flag5 = (nint)obj23 < 0;
				bool flag6 = flag4 == flag5;
				object obj24 = !flag6;
				object obj25 = ~obj24;
				if (obj25 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3 (System.Object)+20]");
					obj19 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3 (System.Object)+20]");
				if ((nint)0 < (nint)1)
				{
					obj19 = 1;
				}
				Icon.sprite = null;
				object obj26 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v13+E4]");
				if ((nint)0 != 0)
				{
					bool flag7 = emptyIcon;
					bool flag8 = !flag7;
					object obj27 = !flag8;
					if (obj27 == null)
					{
						goto IL_0372;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					if (!emptyIcon)
					{
						goto IL_0372;
					}
				}
				emptyIcon.SetActive(value: false);
				rotatingLoadingIndicator = loading;
				bool flag9 = (object)loading == null;
				object obj28 = !flag9;
				if (obj28 != null)
				{
					goto IL_039d;
				}
				goto IL_05d7;
			}
		}
		goto IL_03ef;
		IL_0372:
		rotatingLoadingIndicator = loading;
		if ((object)loading != null)
		{
			goto IL_039d;
		}
		goto IL_05d7;
	}

	private void UpdateName(GameAchievementViewModel model)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0110: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_00be: Expected O, but got I4
		//IL_0159: Expected O, but got I4
		//IL_0204: Expected O, but got I4
		//IL_037c: Expected O, but got I
		//IL_0227: Expected O, but got I
		//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cf: Expected O, but got Unknown
		//IL_026b: Expected O, but got I
		//IL_0409: Expected O, but got I4
		//IL_0298: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6BAB]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v18+E4]");
			bool flag = (nint)0 == 0;
			obj5 = Name;
			obj6 = Name;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = Name;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v18+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = Name;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6 == null;
		bool flag4 = !flag3;
		object obj8 = 0;
		UnityEngine.Object obj9 = null;
		if (!flag4)
		{
			goto IL_016c;
		}
		goto IL_036c;
		IL_036c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Achievement)+58]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Achievement)+58]");
		string text;
		string text2;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v6+20]");
			text = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v6+20]");
			if ((nint)0 != 0)
			{
				bool flag5 = model == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v6+20]");
				text2 = (string)0;
				if (!flag5)
				{
					goto IL_0279;
				}
				goto IL_033c;
			}
		}
		string text3 = model?.<name>k__BackingField;
		object obj11 = "Drop Menu Toggle" + 2272;
		text = (string)((text3 != null) ? text3 : obj11);
		bool flag6 = model == null;
		object obj12 = !flag6;
		text2 = text;
		if (obj12 != null)
		{
			goto IL_0279;
		}
		goto IL_033c;
		IL_033c:
		if ((object)Name != null)
		{
			TextMeshProExtensions.Localize(Name, text2);
		}
		return;
		IL_0279:
		bool flag7 = model.<type>k__BackingField == AchievementType.Achievement;
		object obj13 = !flag7;
		if (obj13 == null && (object)progressBar != null)
		{
			progressBar.SetBarText(text);
		}
		if ((object)Name != null)
		{
			TextMeshProExtensions.FixArabic(Name, text);
		}
		return;
		IL_0091:
		bool flag8 = obj5 == null;
		bool flag9 = !flag8;
		object obj14 = !flag9;
		obj8 = 0;
		obj9 = null;
		if (obj14 != null)
		{
			goto IL_016c;
		}
		goto IL_036c;
		IL_016c:
		object obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v12+E4]");
		if ((nint)0 != 0)
		{
			if (progressBar == null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag10 = progressBar == null;
			bool flag11 = !flag10;
			object obj16 = !flag11;
			if (obj16 != null)
			{
				return;
			}
		}
		goto IL_036c;
	}

	private void DimIcon()
	{
		//IL_0017: Expected I, but got O
		//IL_0027: Expected O, but got I
		//IL_0037: Expected O, but got I
		Image icon = Icon;
		nint num = (nint)icon;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X8_v1 (Il2CppClass<UnityEngine.UI.Image>)+2A8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X8_v1 (Il2CppClass<UnityEngine.UI.Image>)+2B0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v4 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	private void UndimIcon()
	{
		//IL_0017: Expected I, but got O
		//IL_0027: Expected O, but got I
		//IL_0037: Expected O, but got I
		Image icon = Icon;
		nint num = (nint)icon;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X8_v1 (Il2CppClass<UnityEngine.UI.Image>)+2A8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X8_v1 (Il2CppClass<UnityEngine.UI.Image>)+2B0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v4 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	private void ShowAchievementsDescription()
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_015d: Expected O, but got I
		//IL_0177: Expected O, but got I4
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		//IL_0093: Expected O, but got I
		//IL_00a9: Expected O, but got I
		//IL_00d0: Expected O, but got I
		//IL_0052: Expected O, but got I
		//IL_021b: Expected O, but got I
		//IL_0245: Expected O, but got I4
		//IL_025d: Expected O, but got I
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected O, but got Unknown
		//IL_01af: Expected O, but got I
		//IL_01c5: Expected O, but got I
		//IL_01df: Expected O, but got I4
		//IL_01f7: Expected O, but got I
		//IL_00ee: Expected O, but got I
		//IL_0125: Expected O, but got I
		object obj = 152985600;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6BAC]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6BA1]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				goto IL_006f;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6BA1]");
			object obj4 = (nint)0 & (nint)1;
			bool flag = obj4 == null;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_006f;
			}
		}
		_ = 1;
		object obj6 = typeof(SqlSingle[]) + 2328;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Achievement)+50]");
		GameAchievementViewModel gameAchievementViewModel = (GameAchievementViewModel)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6BA2]");
		object obj7 = (nint)0 & (nint)1;
		bool flag2 = obj7 == null;
		object obj8 = !flag2;
		object obj9 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Achievement)+50]");
		GameAchievementViewModel gameAchievementViewModel2 = (GameAchievementViewModel)0;
		if (obj8 != null)
		{
			goto IL_00de;
		}
		goto IL_0205;
		IL_0133:
		UserAchievementModel userModel;
		AchievementInfoPopup.ShowPreview(gameAchievementViewModel, userModel);
		return;
		IL_026b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UserAchievementModel userModel2;
		AchievementInfoPopup.ShowPreview(gameAchievementViewModel2, userModel2);
		return;
		IL_00de:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Achievement)+58]");
		userModel = (UserAchievementModel)0;
		object obj10 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X0_v1+E4]");
		bool flag3 = (nint)0 == 0;
		gameAchievementViewModel2 = gameAchievementViewModel;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Achievement)+58]");
		userModel2 = (UserAchievementModel)0;
		if (!flag3)
		{
			goto IL_0133;
		}
		goto IL_026b;
		IL_006f:
		obj6 = typeof(SqlSingle[]) + 2328;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Achievement)+50]");
		gameAchievementViewModel = (GameAchievementViewModel)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6BA2]");
		object obj11 = (nint)0 & (nint)1;
		bool flag4 = obj11 == null;
		obj9 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Achievement)+50]");
		gameAchievementViewModel2 = (GameAchievementViewModel)0;
		if (!flag4)
		{
			goto IL_00de;
		}
		goto IL_0205;
		IL_0205:
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Achievement)+58]");
		userModel = (UserAchievementModel)0;
		obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X0_v1+E4]");
		bool flag5 = (nint)0 == 0;
		object obj12 = !flag5;
		gameAchievementViewModel = gameAchievementViewModel2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Achievement)+58]");
		userModel2 = (UserAchievementModel)0;
		if (obj12 != null)
		{
			goto IL_0133;
		}
		goto IL_026b;
	}

	private void ApplyTitleAction()
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_01b4: Expected O, but got I
		//IL_01ce: Expected O, but got I4
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_00a2: Expected O, but got I
		//IL_0052: Expected O, but got I
		//IL_0287: Expected O, but got I4
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected O, but got Unknown
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected O, but got Unknown
		//IL_0215: Expected O, but got I
		//IL_0237: Expected O, but got I4
		//IL_00e7: Expected O, but got I
		//IL_0119: Expected O, but got I4
		//IL_0131: Expected O, but got I
		object obj = 152985600;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6BAD]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6BA1]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				goto IL_006f;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6BA1]");
			object obj4 = (nint)0 & (nint)1;
			bool flag = obj4 == null;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_006f;
			}
		}
		_ = 1;
		object obj6 = "Material with texture name \"" + 3544;
		object obj7 = typeof(System.Buffers.Text.ParserHelpers) + 1056;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Achievement)+50]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Achievement)+50]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		object obj10 = obj7;
		object obj11 = obj6;
		if (obj9 != null)
		{
			goto IL_00d7;
		}
		goto IL_0255;
		IL_013f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		string text2;
		string text = text2;
		string text4;
		string text3 = text4;
		goto IL_015e;
		IL_00d7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X10_v5+10]");
		text4 = (string)0;
		text2 = (string)obj6;
		object obj12 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v17+E4]");
		bool flag3 = (nint)0 == 0;
		object obj13 = !flag3;
		text = (string)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X10_v5+10]");
		text3 = (string)0;
		if (obj13 == null)
		{
			goto IL_013f;
		}
		goto IL_015e;
		IL_015e:
		string titleId = ((text3 != null) ? text3 : text);
		PlayerProfilesHandler.UpdateMyTitle(titleId);
		return;
		IL_006f:
		obj6 = "Material with texture name \"" + 3544;
		obj7 = typeof(System.Buffers.Text.ParserHelpers) + 1056;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Achievement)+50]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Achievement)+50]");
		bool flag4 = (nint)0 == 0;
		obj10 = obj7;
		obj11 = obj6;
		if (!flag4)
		{
			goto IL_00d7;
		}
		goto IL_0255;
		IL_0255:
		text = (string)obj11;
		obj12 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v17+E4]");
		bool flag5 = (nint)0 == 0;
		object obj14 = !flag5;
		text3 = null;
		if (obj14 == null)
		{
			text2 = (string)obj11;
			text4 = null;
			goto IL_013f;
		}
		goto IL_015e;
	}

	private void ResetTitleAction()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00de: Expected O, but got I4
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		object obj = 152985600;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1056;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6B0A]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object titleId;
		if (obj3 != null)
		{
			obj4 = "Material with texture name \"" + 3544;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			titleId = obj4;
			if (!flag)
			{
				goto IL_0094;
			}
		}
		else
		{
			_ = 1;
			obj4 = "Material with texture name \"" + 3544;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v1+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			titleId = obj4;
			if (obj6 != null)
			{
				goto IL_0094;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		PlayerProfilesHandler.UpdateMyTitle((string)titleId);
		return;
		IL_0094:
		PlayerProfilesHandler.UpdateMyTitle((string)obj4);
	}

	private void InvokeCallback()
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_00cd: Expected O, but got I
		//IL_00e7: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_00a6: Expected O, but got I
		//IL_011f: Expected O, but got I4
		object obj = 152985600;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6BAE]");
		object obj2 = (nint)0 & (nint)1;
		UnityEvent<GameAchievementViewModel> unityEvent;
		UnityEvent<GameAchievementViewModel> unityEvent2;
		if (obj2 != null)
		{
			unityEvent = callback;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6BA1]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			unityEvent2 = callback;
			if (!flag)
			{
				goto IL_0083;
			}
		}
		else
		{
			_ = 1;
			unityEvent = callback;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6BA1]");
			object obj4 = (nint)0 & (nint)1;
			bool flag2 = obj4 == null;
			object obj5 = !flag2;
			unityEvent2 = callback;
			if (obj5 != null)
			{
				goto IL_0083;
			}
		}
		_ = 1;
		bool flag3 = unityEvent2 == null;
		object obj6 = !flag3;
		UnityEvent<object> unityEvent3 = (UnityEvent<object>)(object)unityEvent2;
		if (obj6 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0090;
		IL_0083:
		unityEvent3 = (UnityEvent<object>)(object)unityEvent;
		goto IL_0090;
		IL_0090:
		UnityEvent<object> unityEvent4 = unityEvent3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Achievement)+50]");
		unityEvent4.Invoke(0);
	}

	private void HideApplyLoading()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_00f1: Expected O, but got I4
		//IL_0145: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj3 = typeof(IPAddress) & 1;
		UnityEngine.Object applyLoading;
		UnityEngine.Object applyLoading2;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			applyLoading = ApplyLoading;
			applyLoading2 = ApplyLoading;
			if (!flag)
			{
				goto IL_008f;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			applyLoading = ApplyLoading;
			applyLoading2 = ApplyLoading;
			if (obj5 != null)
			{
				goto IL_008f;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = applyLoading2;
		bool flag4 = !flag3;
		object obj6 = !flag4;
		if (obj6 == null)
		{
			return;
		}
		goto IL_00b5;
		IL_00b5:
		ApplyLoading.FinishLoading();
		return;
		IL_008f:
		if ((bool)applyLoading)
		{
			goto IL_00b5;
		}
	}

	private void OnLevelTabSelected(int selectedLevel)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00fa: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_033d: Expected O, but got I
		//IL_0301: Expected O, but got I
		//IL_01ea: Expected O, but got I
		//IL_02b7: Expected O, but got I
		//IL_025b: Expected O, but got I4
		//IL_0264: Expected O, but got I4
		//IL_0274: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6BB0]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v26+E4]");
			bool flag = (nint)0 == 0;
			obj5 = descriptionPanel;
			obj6 = descriptionPanel;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v26+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = descriptionPanel;
			obj6 = descriptionPanel;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		if (!(obj6 != null))
		{
			goto IL_02bc;
		}
		goto IL_02cb;
		IL_0291:
		AchievementLevelDescription achievementLevelDescription2;
		AchievementLevelDescription achievementLevelDescription = achievementLevelDescription2;
		GameAchievementViewModel gameAchievementViewModel;
		GameAchievementViewModel model = gameAchievementViewModel;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Achievement)+58]");
		int unlockedLevel;
		int userValue;
		achievementLevelDescription.RefreshSelection(model, (UserAchievementModel)0, selectedLevel, unlockedLevel, userValue);
		goto IL_02bc;
		IL_02bc:
		UpdateLevelName(selectedLevel);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Achievement)+50]");
		UpdateIcon((GameAchievementViewModel)0, selectedLevel);
		return;
		IL_01da:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Achievement)+50]");
		gameAchievementViewModel = (GameAchievementViewModel)0;
		goto IL_0291;
		IL_0091:
		bool flag3 = obj5 != null;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			goto IL_02bc;
		}
		goto IL_02cb;
		IL_02cb:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Achievement)+50]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Achievement)+58]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Achievement)+58]");
			AchievementLevelDescription achievementLevelDescription3;
			int num;
			int num2;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v12+18]");
				userValue = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v12+1C]");
				unlockedLevel = 0;
				achievementLevelDescription2 = descriptionPanel;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6BA1]");
				bool flag5 = (nint)0 != 1;
				achievementLevelDescription3 = descriptionPanel;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v12+18]");
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v12+1C]");
				num2 = 0;
				if (!flag5)
				{
					goto IL_01da;
				}
			}
			else
			{
				achievementLevelDescription2 = descriptionPanel;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6BA1]");
				bool flag6 = (nint)0 == 1;
				userValue = 0;
				unlockedLevel = 0;
				achievementLevelDescription3 = descriptionPanel;
				num = 0;
				num2 = 0;
				if (flag6)
				{
					goto IL_01da;
				}
			}
			object obj10 = 152985600 + 2977;
			obj10 = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Achievement)+50]");
			gameAchievementViewModel = (GameAchievementViewModel)0;
			achievementLevelDescription2 = achievementLevelDescription3;
			userValue = num;
			unlockedLevel = num2;
			goto IL_0291;
		}
		goto IL_02bc;
	}

	private void UpdateLevelName(int selectedLevel)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00fb: Expected O, but got I4
		//IL_033a: Expected O, but got I
		//IL_014a: Expected O, but got I4
		//IL_01fc: Expected O, but got I4
		//IL_016d: Expected O, but got I
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected O, but got Unknown
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Expected O, but got Unknown
		//IL_028f: Expected O, but got I4
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected I4, but got Unknown
		//IL_01ce: Expected O, but got I4
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Expected O, but got Unknown
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6BB1]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v15+E4]");
			bool flag = (nint)0 == 0;
			obj5 = levelName;
			obj6 = levelName;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = levelName;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v15+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = levelName;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6 == null;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			goto IL_032a;
		}
		return;
		IL_0201:
		Component component;
		GameObject gameObject = component.gameObject;
		object obj10;
		object obj9 = obj10 - 1;
		bool flag5 = (nint)obj9 < 0;
		bool flag6 = obj9 == null;
		object obj11 = obj10 ^ 1;
		object obj12 = obj10 ^ obj9;
		object obj13 = obj11 & obj12;
		bool flag7 = (nint)obj13 < 0;
		bool flag8 = flag5 == flag7;
		object obj14 = !flag6;
		bool active = (byte)((flag8 & obj14) ? 1 : 0) != 0;
		gameObject.SetActive(active);
		if (selectedLevel >= 1 && selectedLevel <= (nint)obj10 && (nint)obj10 >= 2)
		{
			object text = "Network Authentication Required" + 3280;
			TextMeshProExtensions.LocalizeOrdinal(levelName, (string)text, selectedLevel);
		}
		return;
		IL_032a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Achievement)+50]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Achievement)+50]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X8_v6+38]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X8_v6+38]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v12+18]");
				int? num = 0;
				component = levelName;
				bool flag9 = (object)levelName == null;
				object obj17 = !flag9;
				object obj18 = default(object);
				obj10 = obj18;
				if (obj17 == null)
				{
					throw new NullReferenceException();
				}
				goto IL_0201;
			}
		}
		component = levelName;
		obj10 = 0;
		goto IL_0201;
		IL_0091:
		if (obj5 == null)
		{
			return;
		}
		goto IL_032a;
	}
}
