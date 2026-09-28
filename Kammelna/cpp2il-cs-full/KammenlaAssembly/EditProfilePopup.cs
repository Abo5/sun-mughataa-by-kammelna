using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Linq;
using Cpp2ILInjected;
using DG.Tweening;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class EditProfilePopup : MonoBehaviour, IInitializable
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<PopupUI> <>9__22_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(DebugUI.BitField) + 1256;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <OpenAvatarEditor>b__22_0(PopupUI instance)
		{
			instance.PopFromCenter();
		}
	}

	private SlideAnimationHelper popup;

	private PasswordEditor passwordEditor;

	private TabsUI tabsUI;

	private AchievementsSelection titleSelection;

	private InventoryItemSelection CardbackSelection;

	private InventoryItemSelection RoomThemeSelection;

	private StorePatternsGroup storePatternsGroup;

	private ComponentReference<PopupUI> avatarEditor;

	private ScrollRect badgePreviewScroll;

	private readonly string interactedWithBadgePreviewKey;

	private AnimationCurve scrollAnimationCurve;

	private float animDuration;

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_006a: Expected I, but got O
		//IL_0094: Expected O, but got I4
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3000;
		object obj2 = (nint)0 + (nint)248;
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1056;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayerProfilesHandler.OnPlayerProfileLoaded += action;
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
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3000;
		object obj2 = (nint)0 + (nint)248;
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1056;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayerProfilesHandler.OnPlayerProfileLoaded -= action;
	}

	private void OnEnable()
	{
		if (!Prefs.GetBool(interactedWithBadgePreviewKey))
		{
			AnimateBadgePreview();
		}
	}

	private void SetupUi()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_010a: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		//IL_0174: Expected O, but got I4
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected O, but got Unknown
		//IL_0199: Expected O, but got I
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected O, but got Unknown
		//IL_01c5: Expected I, but got O
		//IL_00cb: Expected O, but got I4
		//IL_0152: Expected O, but got I4
		//IL_01f4: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7702]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			obj5 = passwordEditor;
			obj6 = passwordEditor;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = passwordEditor;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v11+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = passwordEditor;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		object obj8 = 0;
		if (!flag4)
		{
			goto IL_0160;
		}
		goto IL_0179;
		IL_0179:
		object obj9 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3000;
		object obj10 = (nint)0 + (nint)256;
		object obj11 = typeof(System.Buffers.Text.ParserHelpers) + 1056;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj10);
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X0_v4+E4]");
		bool flag5 = (nint)0 == 0;
		object obj13 = !flag5;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayerProfilesHandler.RequestMyProfile(action);
		return;
		IL_0160:
		passwordEditor.SetupUi();
		obj8 = 0;
		goto IL_0179;
		IL_0091:
		bool flag6 = obj5;
		bool flag7 = !flag6;
		object obj14 = !flag7;
		if (obj14 != null)
		{
			goto IL_0160;
		}
		obj8 = 0;
		goto IL_0179;
	}

	private void OnPlayerProfileLoaded(PlayerProfileModel model)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_004f: Expected O, but got I4
		object obj = typeof(Queue<string>) + 848;
		object obj2 = (nint)0 + (nint)2200;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v4+E4]");
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
		if (model.<userDbId>k__BackingField == intDbId)
		{
			Populate(model);
		}
	}

	private void Populate(PlayerProfileModel model)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0343: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		//IL_03ef: Expected O, but got I4
		//IL_03f8: Expected O, but got I4
		//IL_040a: Expected O, but got I4
		//IL_013b: Expected O, but got I4
		//IL_0144: Expected O, but got I4
		//IL_04b8: Expected O, but got I4
		//IL_04d1: Expected O, but got I4
		//IL_01d6: Expected O, but got I4
		//IL_01df: Expected O, but got I4
		//IL_046b: Expected O, but got I4
		//IL_0576: Expected O, but got I4
		//IL_058f: Expected O, but got I4
		//IL_026f: Expected O, but got I4
		//IL_0529: Expected O, but got I4
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected O, but got Unknown
		//IL_02bb: Expected O, but got I4
		//IL_05d9: Expected O, but got I4
		//IL_05f2: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7704]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v27+E4]");
			bool flag = (nint)0 == 0;
			obj5 = titleSelection;
			obj6 = titleSelection;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = titleSelection;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v27+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = titleSelection;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		List<UserAchievementModel> list = null;
		if (flag4)
		{
			goto IL_00c7;
		}
		goto IL_0395;
		IL_027d:
		object obj8 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X0_v42+E4]");
		bool flag5 = (nint)0 == 0;
		object obj10 = !flag5;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		IEnumerable<StoreItem> categoryItems = Store.GetCategoryItems(ItemCategory.Patterns);
		List<object> patterns = Enumerable.ToList((IEnumerable<object>)categoryItems);
		storePatternsGroup.Populate((List<StoreItem>)(object)patterns);
		return;
		IL_024e:
		UnityEngine.Object obj11;
		bool flag6 = obj11;
		bool flag7 = !flag6;
		object obj12 = 0;
		if (!flag7)
		{
			goto IL_027d;
		}
		return;
		IL_05a7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object obj13;
		bool flag8 = obj13;
		bool flag9 = !flag8;
		object obj14 = !flag9;
		object obj16;
		object obj15 = obj16;
		bool flag10;
		nint num = (flag10 ? 1 : 0);
		obj12 = 0;
		if (obj14 == null)
		{
			return;
		}
		goto IL_027d;
		IL_0091:
		bool flag11 = obj5;
		bool flag12 = !flag11;
		object obj17 = !flag12;
		list = null;
		if (obj17 == null)
		{
			goto IL_00c7;
		}
		goto IL_0395;
		IL_0395:
		list = model.<gameAchievements>k__BackingField;
		titleSelection.Populate(model.<gameAchievements>k__BackingField, isMyProfile: true);
		UnityEngine.Object cardbackSelection = CardbackSelection;
		object obj18 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v20+E4]");
		bool flag13 = (nint)0 == 0;
		object obj19 = !flag13;
		obj15 = 0;
		num = 1;
		obj16 = 0;
		flag10 = true;
		UnityEngine.Object cardbackSelection2 = CardbackSelection;
		if (obj19 != null)
		{
			goto IL_0118;
		}
		goto IL_042b;
		IL_00c7:
		obj18 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v20+E4]");
		bool flag14 = (nint)0 == 0;
		cardbackSelection = CardbackSelection;
		obj16 = obj15;
		flag10 = (byte)num != 0;
		cardbackSelection2 = CardbackSelection;
		if (!flag14)
		{
			goto IL_0118;
		}
		goto IL_042b;
		IL_042b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag15 = cardbackSelection2;
		bool flag16 = !flag15;
		obj15 = obj16;
		num = (flag10 ? 1 : 0);
		object obj20 = 0;
		if (flag16)
		{
			goto IL_0162;
		}
		goto IL_0479;
		IL_0118:
		bool flag17 = cardbackSelection;
		bool flag18 = !flag17;
		object obj21 = !flag18;
		obj20 = 0;
		obj16 = obj15;
		flag10 = (byte)num != 0;
		if (obj21 == null)
		{
			goto IL_0162;
		}
		goto IL_0479;
		IL_0479:
		CardbackSelection.Refresh();
		UnityEngine.Object roomThemeSelection = RoomThemeSelection;
		object obj22 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v7+E4]");
		bool flag19 = (nint)0 == 0;
		object obj23 = !flag19;
		obj15 = obj16;
		num = (flag10 ? 1 : 0);
		obj20 = 0;
		UnityEngine.Object roomThemeSelection2 = RoomThemeSelection;
		if (obj23 != null)
		{
			goto IL_01b3;
		}
		goto IL_04e9;
		IL_0162:
		roomThemeSelection = RoomThemeSelection;
		obj22 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v7+E4]");
		bool flag20 = (nint)0 == 0;
		obj16 = obj15;
		flag10 = (byte)num != 0;
		roomThemeSelection2 = RoomThemeSelection;
		if (!flag20)
		{
			goto IL_01b3;
		}
		goto IL_04e9;
		IL_04e9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag21 = roomThemeSelection2;
		bool flag22 = !flag21;
		obj15 = obj16;
		num = (flag10 ? 1 : 0);
		object obj24 = 0;
		if (flag22)
		{
			goto IL_01fd;
		}
		goto IL_0537;
		IL_01b3:
		bool flag23 = roomThemeSelection;
		bool flag24 = !flag23;
		object obj25 = !flag24;
		obj24 = 0;
		obj16 = obj15;
		flag10 = (byte)num != 0;
		if (obj25 == null)
		{
			goto IL_01fd;
		}
		goto IL_0537;
		IL_0537:
		RoomThemeSelection.Refresh();
		obj11 = storePatternsGroup;
		object obj26 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X8_v4+E4]");
		bool flag25 = (nint)0 == 0;
		object obj27 = !flag25;
		obj15 = obj16;
		num = (flag10 ? 1 : 0);
		obj24 = 0;
		obj13 = storePatternsGroup;
		if (obj27 != null)
		{
			goto IL_024e;
		}
		goto IL_05a7;
		IL_01fd:
		obj11 = storePatternsGroup;
		obj26 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X8_v4+E4]");
		bool flag26 = (nint)0 == 0;
		obj16 = obj15;
		flag10 = (byte)num != 0;
		obj13 = storePatternsGroup;
		if (!flag26)
		{
			goto IL_024e;
		}
		goto IL_05a7;
	}

	public void Initialize()
	{
		SetupUi();
		popup.SlideIn();
	}

	public void Popup()
	{
		SetupUi();
		popup.SlideIn();
	}

	public void Close()
	{
		popup.SlideOut();
	}

	public void OnRoute(RoutingCommand command, string commandParam)
	{
		switch (command)
		{
		case RoutingCommand.EditProfile_FeaturedSlot:
			tabsUI.Activate(4);
			break;
		case RoutingCommand.EditProfile_RoomThemes:
			tabsUI.Activate(1);
			break;
		case RoutingCommand.EditProfile_Titles:
			tabsUI.Activate(2);
			break;
		case RoutingCommand.EditProfile_Cardbacks:
			tabsUI.Activate(3);
			break;
		case RoutingCommand.EditProfile_Patterns:
			tabsUI.Activate(0);
			break;
		}
	}

	public void OpenAvatarEditor()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0198: Expected O, but got I4
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_00bd: Expected O, but got I
		//IL_00cd: Expected O, but got I
		//IL_0260: Expected O, but got I4
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		//IL_01ee: Expected O, but got I
		//IL_01fe: Expected O, but got I
		//IL_0220: Expected O, but got I4
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected O, but got Unknown
		//IL_034a: Expected O, but got I
		//IL_035b: Expected I, but got O
		//IL_0379: Expected O, but got I
		//IL_010e: Expected O, but got I
		//IL_02a1: Expected O, but got I
		//IL_02cb: Expected O, but got I4
		//IL_0290: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(DebugUI.BitField) + 1256;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7705]");
		object obj3 = (nint)0 & (nint)1;
		ComponentReference<PopupUI> componentReference2;
		object obj4;
		ComponentReference<PopupUI> componentReference;
		if (obj3 != null)
		{
			componentReference = avatarEditor;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj4;
			componentReference2 = avatarEditor;
			if (!flag)
			{
				goto IL_0099;
			}
		}
		else
		{
			_ = 1;
			componentReference = avatarEditor;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			componentReference2 = avatarEditor;
			if (obj6 != null)
			{
				goto IL_0099;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		object obj7 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v3+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v4+8]");
		Action<object> action = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v4+8]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		componentReference = componentReference2;
		object obj10 = obj7;
		if (obj9 != null)
		{
			goto IL_0102;
		}
		goto IL_023e;
		IL_0102:
		object obj11 = (nint)0 + (nint)2240;
		object obj12 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v1+E4]");
		bool flag4 = (nint)0 == 0;
		object obj13 = obj11;
		Action<object> action2 = action;
		componentReference2 = componentReference;
		if (!flag4)
		{
			goto IL_0153;
		}
		goto IL_02f9;
		IL_02f9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj11 = obj13;
		action = action2;
		componentReference = componentReference2;
		goto IL_0153;
		IL_0153:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80CF4");
		return;
		IL_0099:
		obj7 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v3+B8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v4+8]");
		action = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v4+8]");
		bool flag5 = (nint)0 == 0;
		obj10 = obj7;
		componentReference2 = componentReference;
		if (!flag5)
		{
			goto IL_0102;
		}
		goto IL_023e;
		IL_023e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v3+E4]");
		bool flag6 = (nint)0 == 0;
		object obj14 = !flag6;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj15 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v11+B8]");
			obj8 = 0;
		}
		object obj16 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3040;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj17 = (nint)0 + (nint)2784;
		Action<object> action3 = default(Action<object>);
		action3..ctor(obj8, (IntPtr)obj17);
		object obj18 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v9+B8]");
		object obj19 = (nint)0 + (nint)8;
		obj19 = action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj11 = (nint)0 + (nint)2240;
		obj12 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v1+E4]");
		bool flag7 = (nint)0 == 0;
		object obj20 = !flag7;
		action = action3;
		componentReference = componentReference2;
		obj13 = obj11;
		action2 = action3;
		if (obj20 != null)
		{
			goto IL_0153;
		}
		goto IL_02f9;
	}

	private void AnimateBadgePreview()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0142: Expected O, but got I4
		//IL_00c3: Expected O, but got I
		//IL_00cf: Expected O, but got I
		//IL_018c: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7706]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = badgePreviewScroll;
			obj6 = badgePreviewScroll;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = badgePreviewScroll;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = badgePreviewScroll;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			return;
		}
		goto IL_00b7;
		IL_00b7:
		object obj9 = (nint)0 + (nint)2936;
		object obj10 = (nint)0 + (nint)3016;
		Tweener tweener = DOTweenModuleUI.DOHorizontalNormalizedPos(badgePreviewScroll, 0.8f, animDuration);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058E14");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3059384");
		return;
		IL_0091:
		if ((bool)obj5)
		{
			goto IL_00b7;
		}
	}

	public void InterruptScrollAnimation()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0111: Expected O, but got I4
		//IL_0165: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7707]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = badgePreviewScroll;
			obj6 = badgePreviewScroll;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = badgePreviewScroll;
			obj6 = badgePreviewScroll;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			return;
		}
		goto IL_00b7;
		IL_00b7:
		int num = ShortcutExtensions.DOKill(badgePreviewScroll);
		Prefs.SetBool(interactedWithBadgePreviewKey, value: true);
		return;
		IL_0091:
		if ((bool)obj5)
		{
			goto IL_00b7;
		}
	}

	public EditProfilePopup()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		object obj = "https://www.kammelna.com/Home/Terms" + 1744;
		object obj2 = this + 104;
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		animDuration = 3f;
		base..ctor();
	}
}
