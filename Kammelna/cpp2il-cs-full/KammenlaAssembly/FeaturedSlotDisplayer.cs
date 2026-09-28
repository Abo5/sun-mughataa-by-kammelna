using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using Cpp2ILInjected;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.Rendering;

public class FeaturedSlotDisplayer : AvatarComponent
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<EditProfilePopup> <>9__17_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(DebugUI.BitField) + 2256;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <EditFeaturedSlot>b__17_0(EditProfilePopup p)
		{
			p.Popup();
			p.OnRoute(RoutingCommand.EditProfile_FeaturedSlot, null);
		}
	}

	private sealed class <>c__DisplayClass16_0
	{
		public int token;

		public FeaturedSlotDisplayer <>4__this;

		internal void <Populate>b__0(UserAchievementModel model)
		{
			//IL_006d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0072: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I4
			//IL_023d: Expected O, but got I4
			FeaturedSlotDisplayer featuredSlotDisplayer = <>4__this;
			if (token != featuredSlotDisplayer._token)
			{
				return;
			}
			UserAchievementModel userModel = default(UserAchievementModel);
			featuredSlotDisplayer._ui.Initialize(userModel);
			FeaturedSlotDisplayer featuredSlotDisplayer2 = <>4__this;
			Achievement ui = featuredSlotDisplayer2._ui;
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v8+E4]");
			if ((nint)0 != 0)
			{
				bool flag = ui.loading;
				bool flag2 = !flag;
				object obj3 = !flag2;
				if (obj3 != null)
				{
					goto IL_0114;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				if ((bool)ui.loading)
				{
					goto IL_0114;
				}
			}
			goto IL_0148;
			IL_0114:
			FeaturedSlotDisplayer featuredSlotDisplayer3 = <>4__this;
			Achievement ui2 = featuredSlotDisplayer3._ui;
			ui2.loading.FinishLoading();
			goto IL_0148;
			IL_0148:
			FeaturedSlotDisplayer featuredSlotDisplayer4 = <>4__this;
			GameObject gameObject = featuredSlotDisplayer4._ui.gameObject;
			gameObject.SetActive(value: true);
			FeaturedSlotDisplayer featuredSlotDisplayer5 = <>4__this;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v12+E4]");
			if ((nint)0 != 0)
			{
				if (!featuredSlotDisplayer5.placeholder)
				{
					return;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag3 = featuredSlotDisplayer5.placeholder;
				bool flag4 = !flag3;
				object obj5 = !flag4;
				if (obj5 == null)
				{
					return;
				}
			}
			FeaturedSlotDisplayer featuredSlotDisplayer6 = <>4__this;
			featuredSlotDisplayer6.placeholder.SetActive(value: false);
		}
	}

	private Achievement achievementPrefab;

	private GameObject customizeButton;

	private GameObject placeholder;

	private RectTransform anchor;

	private ComponentReference<EditProfilePopup> customizePopup;

	private ComponentReference<EditProfilePopup> customizePopupTablet;

	private Achievement _ui;

	private int _targetUserId;

	private string _currentId;

	private int _token;

	private void OnEnable()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_009e: Expected O, but got I4
		//IL_00da: Expected I, but got O
		//IL_0063: Expected O, but got I4
		object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 472;
		object obj2 = (nint)0 + (nint)2576;
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1056;
		object obj4 = this + 104;
		obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		int token = _token + 1;
		_token = token;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<int, object> action = default(Action<int, object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayerProfilesHandler.OnFeaturedSlotChanged += action;
	}

	private void OnDisable()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0082: Expected I, but got O
		//IL_00ac: Expected O, but got I4
		object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 472;
		object obj2 = (nint)0 + (nint)2576;
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1056;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<int, object> action = default(Action<int, object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayerProfilesHandler.OnFeaturedSlotChanged -= action;
		GameObject go = base.gameObject;
		VariableBinderExtensions.Unbind(go);
	}

	private void HandleLocalFeaturedSlotChanged(int userId, FeaturedSlotModel slot)
	{
		if (userId == _targetUserId)
		{
			Populate(slot, userId);
		}
	}

	private void ResetState()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0014: Expected O, but got I4
		//IL_0034: Expected O, but got I
		object obj = this + 104;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X19_v2+8]");
		object obj2 = (nint)0 + (nint)1;
	}

	public override void Initialize(User user)
	{
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0400: Expected O, but got Unknown
		//IL_0409: Expected O, but got I4
		//IL_001b: Expected O, but got I
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0053: Expected I, but got O
		//IL_0063: Expected O, but got I
		//IL_00f9: Expected O, but got I
		//IL_009e: Expected O, but got I
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected O, but got Unknown
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected O, but got Unknown
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected O, but got Unknown
		//IL_01d0: Expected O, but got I
		//IL_01f4: Expected O, but got I4
		//IL_0184: Expected O, but got I4
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected O, but got Unknown
		//IL_02df: Expected O, but got I4
		//IL_0286: Expected O, but got I4
		//IL_0308: Expected O, but got I
		//IL_0465: Unknown result type (might be due to invalid IL or missing references)
		//IL_046a: Expected O, but got Unknown
		//IL_0494: Expected O, but got I4
		//IL_035e: Expected O, but got I
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Expected O, but got Unknown
		//IL_03a9: Expected O, but got I
		//IL_03b7: Expected I, but got O
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c6: Expected O, but got Unknown
		GameObject go = base.gameObject;
		VariableBinderExtensions.Unbind(go);
		object obj = this + 104;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X21_v3+8]");
		object obj2 = (nint)0 + (nint)1;
		int intDbId = SFSKammelnaUserExtensions.GetIntDbId(user);
		object obj3 = typeof(UsageHint) + 8;
		nint num = (nint)user;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v8 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v8 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00df;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v8 (Il2CppClass<Sfs2X.Entities.User>)+B0]");
		object obj5 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X10_v7-8]");
			if (0 == (nint)obj3)
			{
				break;
			}
			obj5 += 16;
			obj4--;
			if ((nint)obj4 != 1)
			{
				continue;
			}
			goto IL_00df;
		}
		object obj6 = obj5 + 19;
		object obj7 = num + obj6;
		object obj8 = obj7 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X0_v47+8]");
		FeaturedSlotModel featuredSlotModel = (FeaturedSlotModel)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v257 @ X0_v47] (should have been resolved before IL gen)");
		object obj9 = default(object);
		bool flag = obj9 == null;
		object obj10 = !flag;
		if (obj10 != null)
		{
			goto IL_0120;
		}
		goto IL_0202;
		IL_0120:
		object obj11 = typeof(System.Buffers.Text.ParserHelpers) + 1056;
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X0_v15+E4]");
		PlayerProfileModel myCachedProfile;
		if ((nint)0 != 0)
		{
			myCachedProfile = PlayerProfilesHandler.GetMyCachedProfile();
			bool flag2 = myCachedProfile == null;
			object obj13 = !flag2;
			if (obj13 != null)
			{
				goto IL_025a;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			myCachedProfile = PlayerProfilesHandler.GetMyCachedProfile();
			if (myCachedProfile != null)
			{
				goto IL_025a;
			}
		}
		goto IL_02a1;
		IL_02a1:
		object obj14 = typeof(Queue<string>) + 848;
		object obj15 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X0_v30+E4]");
		bool flag3 = (nint)0 == 0;
		object obj16 = !flag3;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj17 = (nint)0 + (nint)2200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		FeaturedSlotModel featuredSlot = SFSKammelnaUserExtensions.GetFeaturedSlot(localUser);
		FeaturedSlotModel slot = featuredSlot;
		goto IL_043c;
		IL_025a:
		featuredSlotModel = myCachedProfile.<featuredSlot>k__BackingField;
		bool flag4 = (object)myCachedProfile.<featuredSlot>k__BackingField == null;
		object obj18 = !flag4;
		slot = myCachedProfile.<featuredSlot>k__BackingField;
		if (obj18 == null)
		{
			goto IL_02a1;
		}
		goto IL_043c;
		IL_043c:
		Populate(slot, _targetUserId);
		GameObject go2 = base.gameObject;
		object obj19 = typeof(Queue<string>) + 848;
		object obj20 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X0_v20+E4]");
		bool flag5 = (nint)0 == 0;
		object obj21 = !flag5;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj22 = (nint)0 + (nint)2200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel2 = default(SessionModel);
		User localUser2 = sessionModel2.LocalUser;
		object obj23 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj24 = (nint)0 + (nint)2568;
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj24);
		object varName = "fetch_products" + 1544;
		VariableBinderExtensions.Bind(go2, localUser2, (string)varName, action);
		return;
		IL_00df:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X0_v44+8]");
		featuredSlotModel = (FeaturedSlotModel)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v164 @ X0_v44] (should have been resolved before IL gen)");
		object obj25 = default(object);
		if (obj25 != null)
		{
			goto IL_0120;
		}
		goto IL_0202;
		IL_0202:
		FeaturedSlotModel featuredSlot2 = SFSKammelnaUserExtensions.GetFeaturedSlot(user);
		Populate(featuredSlot2, _targetUserId);
	}

	public override void Clear()
	{
		Populate(null, 0);
	}

	public void Populate(FeaturedSlotModel slot, int userId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_008a: Expected O, but got I4
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_013b: Expected O, but got I4
		//IL_0257: Expected O, but got I4
		//IL_02a9: Expected O, but got I4
		//IL_01c6: Expected O, but got I4
		//IL_01f7: Expected O, but got I4
		//IL_03ea: Expected I, but got O
		//IL_0396: Expected O, but got I4
		//IL_03b0: Expected O, but got I4
		//IL_0368: Expected O, but got I4
		//IL_0495: Unknown result type (might be due to invalid IL or missing references)
		//IL_049a: Expected O, but got Unknown
		//IL_0671: Expected O, but got I4
		//IL_067a: Expected O, but got I4
		//IL_04e9: Expected O, but got I4
		//IL_0521: Expected O, but got I4
		//IL_047c: Expected O, but got I4
		//IL_09c7: Expected O, but got I
		//IL_0625: Unknown result type (might be due to invalid IL or missing references)
		//IL_062a: Expected O, but got Unknown
		//IL_0633: Expected O, but got I4
		//IL_06d9: Expected O, but got I4
		//IL_06e2: Expected O, but got I4
		//IL_070b: Expected O, but got I4
		//IL_0a86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8b: Expected O, but got Unknown
		//IL_0ab2: Expected O, but got I4
		//IL_0570: Expected O, but got I4
		//IL_073b: Expected O, but got I
		//IL_0743: Expected I, but got O
		//IL_0753: Expected O, but got I
		//IL_09f6: Expected O, but got I4
		//IL_0791: Expected O, but got I4
		//IL_0a09: Expected O, but got I4
		//IL_0a18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1d: Expected O, but got Unknown
		//IL_0a3a: Expected O, but got I
		//IL_0a48: Expected O, but got I4
		//IL_0a72: Expected O, but got I4
		//IL_0833: Expected O, but got I4
		//IL_08c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c9: Expected O, but got Unknown
		//IL_0585: Expected O, but got I
		//IL_058d: Expected I, but got O
		//IL_059d: Expected O, but got I
		//IL_05ae: Expected O, but got I4
		//IL_08e4: Expected O, but got I
		//IL_08f5: Expected I, but got O
		//IL_0904: Unknown result type (might be due to invalid IL or missing references)
		//IL_0909: Expected O, but got Unknown
		//IL_0933: Expected O, but got I4
		//IL_089e: Expected O, but got I
		object obj = typeof(DebugUI.BitField) + 2264;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass16_0 <>c__DisplayClass16_ = default(<>c__DisplayClass16_0);
		<>c__DisplayClass16_..ctor();
		object obj2 = typeof(Queue<string>) + 848;
		object obj3 = (nint)0 + (nint)2200;
		object obj4 = <>c__DisplayClass16_ + 24;
		obj4 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_targetUserId = userId;
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X0_v9+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj7 = typeof(MemberAchievementClanFeedData) + 2976;
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		int intDbId = SFSKammelnaUserExtensions.GetIntDbId(localUser);
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X0_v15+E4]");
		bool flag4;
		if ((nint)0 != 0)
		{
			bool flag2 = customizeButton;
			bool flag3 = !flag2;
			object obj9 = !flag3;
			flag4 = false;
			if (obj9 == null)
			{
				goto IL_0152;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag5 = customizeButton;
			bool flag6 = !flag5;
			flag4 = false;
			if (flag6)
			{
				goto IL_0152;
			}
		}
		object obj10 = intDbId - userId;
		bool flag7 = obj10 == null;
		customizeButton.SetActive(flag7);
		UnityEngine.Object obj11 = placeholder;
		object obj12 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v52+E4]");
		bool flag8 = (nint)0 == 0;
		object obj13 = !flag8;
		int num = 0;
		int num2 = 0;
		flag4 = flag7;
		UnityEngine.Object obj14 = placeholder;
		if (obj13 != null)
		{
			goto IL_01a3;
		}
		goto IL_02db;
		IL_04f7:
		object obj15 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X8_v26+E4]");
		bool flag9 = (nint)0 == 0;
		object obj16 = !flag9;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj17 = (nint)0 + (nint)864;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9DE4");
		object obj19 = default(object);
		object obj18 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Transform go = ((Component)obj18).transform;
		RectTransform rectTransform = UIExtensions.rectTransform(go);
		rectTransform.anchorMin = (Vector2)0;
		rectTransform.anchorMax = (Vector2)0;
		rectTransform.sizeDelta = (Vector2)0;
		object obj20 = typeof(UsageHint) + 816;
		object obj21 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v677 @ X8_v43+B8]");
		object obj22 = 0;
		rectTransform.localPosition = (Vector3)0;
		bool flag10 = string.IsNullOrEmpty(slot.<id>k__BackingField);
		bool flag11 = !flag10;
		object obj23 = 0;
		if (flag11)
		{
			goto IL_071e;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v579 @ X8_v44+8]");
		object obj24 = 0;
		nint num3 = (nint)obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v579 @ X8_v44+4]");
		object obj25 = 0;
		object obj26 = obj22;
		object obj27 = 0;
		string text = null;
		goto IL_0a80;
		IL_061f:
		object obj28 = this + 104;
		obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return;
		IL_0880:
		object obj29 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v24+C0]");
		((RotatingLoadingIndicator)0).StartLoading();
		goto IL_08a3;
		IL_03e2:
		nint num4 = (nint)slot;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X8_v9 (Il2CppClass<FeaturedSlotModel>)+1B0]");
		num = 0;
		bool flag12 = slot.Equals(null);
		bool flag13 = !flag12;
		bool flag14 = false;
		if (!flag13)
		{
			goto IL_042a;
		}
		obj18 = this + 88;
		object obj30 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v10+E4]");
		if ((nint)0 != 0)
		{
			bool flag15 = (UnityEngine.Object)obj18 == null;
			bool flag16 = !flag15;
			object obj31 = 0;
			if (!flag16)
			{
				goto IL_04f7;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag17 = (UnityEngine.Object)obj18 == null;
			bool flag18 = !flag17;
			object obj32 = !flag18;
			object obj31 = 0;
			if (obj32 != null)
			{
				goto IL_04f7;
			}
		}
		GameObject gameObject = ((Component)obj18).gameObject;
		gameObject.SetActive(value: true);
		bool flag19 = string.IsNullOrEmpty(slot.<id>k__BackingField);
		bool flag20 = !flag19;
		object obj33 = !flag20;
		obj23 = 0;
		object obj34 = default(object);
		obj24 = obj34;
		IntPtr intPtr = default(IntPtr);
		num3 = intPtr;
		object obj35 = default(object);
		obj25 = obj35;
		object obj36 = default(object);
		obj26 = obj36;
		obj27 = 0;
		text = null;
		if (obj33 == null)
		{
			goto IL_071e;
		}
		goto IL_0a80;
		IL_01dd:
		bool flag21 = (object)slot == null;
		object obj37 = !flag21;
		if (obj37 != null)
		{
			goto IL_03e2;
		}
		goto IL_042a;
		IL_0152:
		obj11 = placeholder;
		obj12 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X8_v52+E4]");
		bool flag22 = (nint)0 == 0;
		num = userId;
		num2 = userId;
		obj14 = placeholder;
		if (!flag22)
		{
			goto IL_01a3;
		}
		goto IL_02db;
		IL_02db:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag23 = obj14;
		bool flag24 = !flag23;
		num = num2;
		flag14 = false;
		if (flag24)
		{
			goto IL_01dd;
		}
		goto IL_0321;
		IL_01a3:
		bool flag25 = obj11;
		bool flag26 = !flag25;
		object obj38 = !flag26;
		flag14 = false;
		if (obj38 == null)
		{
			goto IL_01dd;
		}
		goto IL_0321;
		IL_0321:
		bool flag27;
		if ((object)slot != null)
		{
			flag27 = slot.Equals(null);
			bool flag28 = (object)placeholder == null;
			object obj39 = !flag28;
			if (obj39 == null)
			{
				throw new NullReferenceException();
			}
		}
		else
		{
			flag27 = true;
		}
		object obj40 = intDbId - userId;
		bool flag29 = obj40 == null;
		object obj41 = !flag29;
		object obj42 = ~obj41;
		flag14 = obj42 != null && flag27;
		placeholder.SetActive(flag14);
		bool flag30 = (object)slot == null;
		num = 0;
		if (!flag30)
		{
			goto IL_03e2;
		}
		goto IL_042a;
		IL_0a80:
		object obj43 = this + 104;
		bool flag31 = string.IsNullOrEmpty((string)obj43);
		bool flag32 = !flag31;
		object obj44 = !flag32;
		string text2 = null;
		if (obj44 == null)
		{
			bool flag33 = (string)obj43 == text;
			bool flag34 = !flag33;
			obj27 = 0;
			text2 = text;
			if (!flag34)
			{
				return;
			}
		}
		<>c__DisplayClass16_.token = ++_token;
		Achievement ui = _ui;
		object obj45 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v615 @ X8_v15+E4]");
		if ((nint)0 != 0)
		{
			bool flag35 = ui.loading;
			bool flag36 = !flag35;
			object obj46 = !flag36;
			if (obj46 != null)
			{
				goto IL_0880;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if ((bool)ui.loading)
			{
				goto IL_0880;
			}
		}
		goto IL_08a3;
		IL_05ef:
		GameObject gameObject2 = _ui.gameObject;
		gameObject2.SetActive(value: false);
		num = 0;
		goto IL_061f;
		IL_08a3:
		obj43 = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj47 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3944;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj48 = (nint)0 + (nint)3736;
		Action<object> action = default(Action<object>);
		action..ctor((object)<>c__DisplayClass16_, (IntPtr)obj48);
		object obj49 = typeof(System.Buffers.Text.ParserHelpers) + 1056;
		object obj50 = obj49;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v695 @ X0_v43+E4]");
		bool flag37 = (nint)0 == 0;
		object obj51 = !flag37;
		if (obj51 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayerProfilesHandler.GetUserAchievementModel(userId, slot.<id>k__BackingField, action);
		return;
		IL_071e:
		text = slot.<id>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v579 @ X8_v44+8]");
		obj24 = 0;
		num3 = (nint)obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v579 @ X8_v44+4]");
		obj25 = 0;
		obj26 = obj22;
		obj27 = obj23;
		goto IL_0a80;
		IL_042a:
		object obj52 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v7+E4]");
		if ((nint)0 != 0)
		{
			bool flag38 = _ui;
			bool flag39 = !flag38;
			object obj53 = !flag39;
			if (obj53 != null)
			{
				goto IL_05ef;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if ((bool)_ui)
			{
				goto IL_05ef;
			}
		}
		goto IL_061f;
	}

	public void EditFeaturedSlot()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_025d: Expected O, but got I4
		//IL_0030: Expected O, but got I4
		//IL_0022: Expected O, but got I4
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected O, but got Unknown
		//IL_0120: Expected O, but got I
		//IL_0130: Expected O, but got I
		//IL_0152: Expected O, but got I4
		//IL_00a2: Expected O, but got I
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_0059: Expected O, but got I
		//IL_0069: Expected O, but got I
		//IL_018a: Expected O, but got I4
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected O, but got Unknown
		//IL_02cb: Expected O, but got I
		//IL_02dc: Expected I, but got O
		//IL_02fa: Expected O, but got I
		//IL_01cb: Expected O, but got I
		//IL_01f5: Expected O, but got I4
		//IL_01ba: Expected O, but got I
		object obj = typeof(DebugUI.BitField) + 2256;
		bool isTablet = ScreenUtility.IsTablet;
		bool flag = !isTablet;
		object obj2 = !flag;
		object obj3 = ~obj2;
		if (obj3 == null)
		{
			object obj4 = 80;
		}
		else
		{
			object obj4 = 72;
		}
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v7+E4]");
		object obj6;
		object obj7;
		object obj8;
		Action<object> action;
		if ((nint)0 != 0)
		{
			obj6 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v7+B8]");
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v8+8]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v8+8]");
			bool flag2 = (nint)0 == 0;
			obj8 = obj6;
			if (!flag2)
			{
				goto IL_0096;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj;
			obj6 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v7+B8]");
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v8+8]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v8+8]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			obj8 = obj6;
			if (obj9 != null)
			{
				goto IL_0096;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v7+E4]");
		bool flag4 = (nint)0 == 0;
		object obj10 = !flag4;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj11 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v15+B8]");
			obj7 = 0;
		}
		object obj12 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1872;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj13 = (nint)0 + (nint)3728;
		Action<object> action2 = default(Action<object>);
		action2..ctor(obj7, (IntPtr)obj13);
		object obj14 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X8_v13+B8]");
		object obj15 = (nint)0 + (nint)8;
		obj15 = action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj16 = (nint)0 + (nint)2040;
		object obj17 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X0_v5+E4]");
		bool flag5 = (nint)0 == 0;
		object obj18 = !flag5;
		action = action2;
		object obj19 = obj16;
		Action<object> action3 = action2;
		if (obj18 != null)
		{
			goto IL_00df;
		}
		goto IL_021b;
		IL_00df:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80CF4");
		return;
		IL_021b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj16 = obj19;
		action = action3;
		goto IL_00df;
		IL_0096:
		obj16 = (nint)0 + (nint)2040;
		obj17 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X0_v5+E4]");
		bool flag6 = (nint)0 == 0;
		obj19 = obj16;
		action3 = action;
		if (!flag6)
		{
			goto IL_00df;
		}
		goto IL_021b;
	}

	public override void Initialize(AvatarData avatarData)
	{
		int result;
		bool flag = int.TryParse(avatarData.<Dbid>k__BackingField, out result);
		Populate(avatarData.<FeaturedSlot>k__BackingField, result);
	}

	private void <Initialize>b__14_0()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00e2: Expected O, but got I
		//IL_010c: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_0155: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E736D]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj4;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool flag3 = (object)sessionModel == null;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00a0;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_00a0;
		IL_00a0:
		User localUser = sessionModel.LocalUser;
		FeaturedSlotModel featuredSlot = SFSKammelnaUserExtensions.GetFeaturedSlot(localUser);
		Populate(featuredSlot, _targetUserId);
	}
}
