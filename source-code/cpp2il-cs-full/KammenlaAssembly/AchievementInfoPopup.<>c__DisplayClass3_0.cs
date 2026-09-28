using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Xml.Schema;
using Cpp2ILInjected;
using GoogleMobileAds.Ump.Api;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using UnityEngine;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.XR;

public class AchievementInfoPopup : MonoBehaviour
{
	private sealed class <>c__DisplayClass3_0
	{
		public GameAchievementViewModel achievementModel;

		public UserAchievementModel userModel;

		internal void <ShowPreview>b__0(AchievementInfoPopup popup)
		{
			Action<bool> onSuccess = default(Action<bool>);
			popup.achievementUi.Initialize(achievementModel, userModel, onSuccess);
			popup.popup.PopFromCenter();
		}
	}

	private sealed class <>c__DisplayClass4_0
	{
		public string achievementId;

		public AchievementInfoPopup <>4__this;

		public Func<UserAchievementModel, bool> <>9__1;

		internal void <ShowAchievementPreview>b__0(PlayerProfileModel profile)
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_01bb: Expected O, but got I4
			//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a5: Expected O, but got Unknown
			//IL_0233: Expected O, but got I
			//IL_025d: Expected O, but got I4
			//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f1: Expected O, but got Unknown
			//IL_020b: Expected O, but got I4
			//IL_0133: Expected O, but got I
			//IL_0166: Expected O, but got I4
			//IL_00d6: Expected O, but got I
			//IL_02e4: Expected O, but got I
			//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ef: Expected O, but got Unknown
			//IL_02ad: Expected O, but got I
			//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ac: Expected O, but got Unknown
			//IL_03c2: Expected O, but got I
			//IL_03d0: Expected I, but got O
			//IL_0426: Expected O, but got I4
			//IL_045d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0462: Expected O, but got Unknown
			//IL_0385: Expected O, but got I4
			//IL_0544: Unknown result type (might be due to invalid IL or missing references)
			//IL_0549: Expected O, but got Unknown
			//IL_055f: Expected O, but got I
			//IL_0579: Expected O, but got I4
			//IL_049e: Unknown result type (might be due to invalid IL or missing references)
			//IL_04a3: Expected O, but got Unknown
			//IL_04b9: Expected O, but got I
			//IL_0510: Expected O, but got I4
			//IL_05c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_05c8: Expected O, but got Unknown
			object obj = 152985600;
			object obj2 = typeof(SqlSingle[]) + 2360;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6BBB]");
			object obj3 = (nint)0 & (nint)1;
			string text;
			string text2;
			if (obj3 != null)
			{
				text = achievementId;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v44+E4]");
				bool flag = (nint)0 == 0;
				text2 = achievementId;
				if (!flag)
				{
					goto IL_0091;
				}
			}
			else
			{
				_ = 1;
				text = achievementId;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v44+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				text2 = achievementId;
				if (obj5 != null)
				{
					goto IL_0091;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj6 = typeof(DeviceRemoveEvent) & 1;
			bool flag3 = obj6 == null;
			object obj7 = !flag3;
			text = text2;
			if (obj7 != null)
			{
				goto IL_00ca;
			}
			goto IL_0221;
			IL_05f9:
			AchievementInfoPopup achievementInfoPopup;
			object valueOrDefault;
			object obj8;
			Action<bool> action = default(Action<bool>);
			achievementInfoPopup.achievementUi.Initialize((GameAchievementViewModel)valueOrDefault, (UserAchievementModel)obj8, action);
			achievementInfoPopup.popup.PopFromCenter();
			return;
			IL_0627:
			throw new NullReferenceException();
			IL_035f:
			achievementInfoPopup = <>4__this;
			bool flag4 = (object)<>4__this == null;
			object obj9 = !flag4;
			if (obj9 != null)
			{
				goto IL_05f9;
			}
			goto IL_0627;
			IL_0091:
			object obj10 = typeof(DeviceRemoveEvent) & 1;
			bool flag5 = obj10 == null;
			text2 = text;
			if (!flag5)
			{
				goto IL_00ca;
			}
			goto IL_0221;
			IL_0221:
			_ = 1;
			object obj11 = (nint)0 + (nint)2080;
			object obj12 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v62+E4]");
			bool flag6 = (nint)0 == 0;
			object obj13 = !flag6;
			object obj14 = text2;
			object obj15 = obj11;
			object obj16 = obj12;
			object obj17 = text2;
			if (obj13 != null)
			{
				goto IL_0123;
			}
			goto IL_028b;
			IL_00ca:
			obj11 = (nint)0 + (nint)2080;
			obj12 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v62+E4]");
			bool flag7 = (nint)0 == 0;
			obj14 = text;
			obj15 = obj11;
			obj16 = obj12;
			obj17 = text;
			if (!flag7)
			{
				goto IL_0123;
			}
			goto IL_028b;
			IL_028b:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj18 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v33+B8]");
			object dictionary = 0;
			object obj19 = obj15;
			valueOrDefault = CollectionExtensions.GetValueOrDefault((IReadOnlyDictionary<object, object>)dictionary, obj17);
			object obj20 = obj17;
			goto IL_02d8;
			IL_0123:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v62+B8]");
			object dictionary2 = 0;
			obj19 = obj11;
			valueOrDefault = CollectionExtensions.GetValueOrDefault((IReadOnlyDictionary<object, object>)dictionary2, obj14);
			bool flag8 = profile == null;
			object obj21 = !flag8;
			obj20 = obj14;
			if (obj21 != null)
			{
				goto IL_02d8;
			}
			goto IL_0627;
			IL_02d8:
			object obj22 = (nint)0 + (nint)1376;
			object obj23 = this + 32;
			Action<bool> action2;
			if (obj23 != null)
			{
				object obj24 = obj22;
				object obj25 = Enumerable.FirstOrDefault(profile.<gameAchievements>k__BackingField, (Func<object, bool>)obj23);
				bool flag9 = obj25 == null;
				obj8 = obj25;
				action2 = action;
				Func<object, bool> func = (Func<object, bool>)obj23;
				if (!flag9)
				{
					goto IL_035f;
				}
			}
			else
			{
				object obj26 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 80;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj27 = (nint)0 + (nint)2008;
				Func<object, bool> func2 = default(Func<object, bool>);
				func2..ctor((object)this, (IntPtr)obj27);
				<>9__1 = func2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj24 = obj22;
				object obj28 = Enumerable.FirstOrDefault(profile.<gameAchievements>k__BackingField, func2);
				bool flag10 = obj28 == null;
				object obj29 = !flag10;
				action = null;
				obj8 = obj28;
				action2 = null;
				Func<object, bool> func = func2;
				if (obj29 != null)
				{
					goto IL_035f;
				}
			}
			object obj30 = typeof(SqlSingle[]) + 2328;
			object obj31 = obj30;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X0_v8+E4]");
			if ((nint)0 != 0)
			{
				object obj32 = typeof(UsageHint) + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6BBA]");
				object obj33 = (nint)0 & (nint)1;
				bool flag11 = obj33 == null;
				object obj34 = obj32;
				if (!flag11)
				{
					goto IL_04de;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj32 = typeof(UsageHint) + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6BBA]");
				object obj35 = (nint)0 & (nint)1;
				bool flag12 = obj35 == null;
				object obj36 = !flag12;
				object obj34 = obj32;
				if (obj36 != null)
				{
					goto IL_04de;
				}
			}
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			UserAchievementModel userAchievementModel = default(UserAchievementModel);
			userAchievementModel..ctor();
			obj8 = userAchievementModel;
			goto IL_05ba;
			IL_05ba:
			object obj37 = obj8 + 16;
			obj37 = achievementId;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = 0;
			achievementInfoPopup = <>4__this;
			action = action2;
			goto IL_05f9;
			IL_04de:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			UserAchievementModel userAchievementModel2 = default(UserAchievementModel);
			userAchievementModel2..ctor();
			bool flag13 = userAchievementModel2 == null;
			object obj38 = !flag13;
			obj8 = userAchievementModel2;
			if (obj38 != null)
			{
				goto IL_05ba;
			}
			goto IL_0627;
		}

		internal bool <ShowAchievementPreview>b__1(UserAchievementModel ua)
		{
			//IL_0048: Expected I4, but got O
			if (ua != null)
			{
				return ua.<gameAchievementId>k__BackingField == achievementId;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private static readonly AddressReference<AchievementInfoPopup> Address;

	private Achievement achievementUi;

	private PopupUI popup;

	public static void ShowPreview(GameAchievementViewModel achievementModel, UserAchievementModel userModel)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004d: Expected O, but got I
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_00d0: Expected O, but got I4
		//IL_0133: Expected O, but got I
		//IL_0143: Expected O, but got I
		//IL_015e: Expected I, but got O
		//IL_0188: Expected O, but got I4
		object obj = typeof(XmlSchemaInclude) + 3688;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(SqlSingle[]) + 2328;
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1024;
		object obj5 = (nint)0 + (nint)1992;
		object obj6 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj7 = obj2 + 16;
		obj7 = achievementModel;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = obj2 + 24;
		obj8 = userModel;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v12+E4]");
		bool flag = (nint)0 == 0;
		object obj10 = !flag;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj9 = obj3;
		}
		object obj11 = (nint)0 + (nint)1800;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v12+B8]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj5);
		object obj13 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v15+E4]");
		bool flag2 = (nint)0 == 0;
		object obj14 = !flag2;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80C64");
	}

	public void ShowAchievementPreview(string achievementId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_00aa: Expected I, but got O
		//IL_00d9: Expected O, but got I4
		object obj = typeof(XmlSchemaInclude) + 3696;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3000;
		object obj4 = (nint)0 + (nint)2000;
		object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 1056;
		object obj6 = obj2 + 16;
		obj6 = achievementId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = obj2 + 24;
		obj7 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v13+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayerProfilesHandler.RequestMyProfile(action);
	}

	public void ShowAchievementPreview(GameAchievementViewModel model, UserAchievementModel userModel)
	{
		//IL_0017: Expected O, but got I
		IntPtr intPtr = default(IntPtr);
		achievementUi.Initialize(model, userModel, (Action<bool>)(nint)intPtr);
		popup.PopFromCenter();
	}

	public static UserAchievementModel GetDefaultUserAchievementModel(string achievementId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		object obj = typeof(UsageHint) + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UserAchievementModel userAchievementModel = default(UserAchievementModel);
		userAchievementModel..ctor();
		if (userAchievementModel != null)
		{
			object obj2 = userAchievementModel + 16;
			obj2 = achievementId;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			userAchievementModel.<value>k__BackingField = 0;
			return userAchievementModel;
		}
		return (UserAchievementModel)(object)new NullReferenceException();
	}

	static AchievementInfoPopup()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		object obj = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 3344;
		object obj2 = typeof(ConsentForm.<Show>c__AnonStorey2.<Show>c__AnonStorey3) + 2992;
		object obj3 = typeof(SqlSingle[]) + 2328;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4933C3C");
		object obj4 = obj3;
		object obj6 = default(object);
		object obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
