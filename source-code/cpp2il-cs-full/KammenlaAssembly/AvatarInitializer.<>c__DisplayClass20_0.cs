using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DataTracking;
using GoogleMobileAds.Api.AdManager;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using ListView;
using Server.Models;
using Sfs2X.Entities;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.UI;

public class AvatarInitializer : ListViewItem<UserWrapper, int>
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<AvatarComponent, bool> <>9__4_0;

		public static Func<AvatarComponent, bool> <>9__18_0;

		public static Action<AvatarComponent> <>9__22_0;

		public static Func<AvatarComponent, bool> <>9__31_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2424;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <get__componentsThatNeedFullProfile>b__4_0(AvatarComponent a)
		{
			//IL_0035: Expected I4, but got O
			if ((object)a != null)
			{
				return a.requiresProfileRequest;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <InitializerRequiresProfileRequest>b__18_0(AvatarComponent a)
		{
			//IL_0035: Expected I4, but got O
			if ((object)a != null)
			{
				return a.requiresProfileRequest;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal void <Clear>b__22_0(AvatarComponent a)
		{
			//IL_0008: Expected I, but got O
			//IL_0018: Expected O, but got I
			//IL_0028: Expected O, but got I
			nint num = (nint)a;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ X8_v1 (Il2CppClass<AvatarComponent>)+198]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ X8_v1 (Il2CppClass<AvatarComponent>)+1A0]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v3 @ X2_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}

		internal bool <SetAvatar>b__31_0(AvatarComponent a)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0029: Expected I, but got O
			//IL_0052: Expected O, but got I4
			//IL_0083: Expected O, but got I
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Expected O, but got Unknown
			if ((object)a != null)
			{
				object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1784;
				object obj2 = obj;
				nint num = (nint)a;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X9_v2 (Il2CppClass<AvatarComponent>)+130]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v6+130]");
				bool flag = num2 < 0;
				object obj3 = !flag;
				if (obj3 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X9_v2 (Il2CppClass<AvatarComponent>)+C8]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v6+130]");
					object obj4 = num3 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X9_v4-8]");
					object obj5 = 0 - obj2;
					return obj5 == null;
				}
			}
			return false;
		}
	}

	private sealed class <>c__DisplayClass16_0
	{
		public User userClient;

		public AvatarInitializer <>4__this;

		internal void <Initialize>b__0(AvatarComponent c)
		{
			//IL_0012: Expected I, but got O
			//IL_0022: Expected O, but got I
			//IL_0032: Expected O, but got I
			User user = userClient;
			nint num = (nint)c;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4 @ X9_v1 (Il2CppClass<AvatarComponent>)+188]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4 @ X9_v1 (Il2CppClass<AvatarComponent>)+190]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v5 @ X3_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}

		internal void <Initialize>b__1(PlayerProfileModel profile)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected O, but got Unknown
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Expected O, but got Unknown
			//IL_005e: Expected O, but got I
			//IL_008e: Expected I, but got O
			object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2440;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj2 + 16;
			obj3 = profile;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1224;
			object obj5 = (nint)0 + (nint)536;
			IEnumerable<AvatarComponent> componentsThatNeedFullProfile = <>4__this._componentsThatNeedFullProfile;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action<object> action = default(Action<object>);
			action..ctor(obj2, (IntPtr)obj5);
			ArraysExtensions.ForEach(componentsThatNeedFullProfile, action);
		}
	}

	private sealed class <>c__DisplayClass16_1
	{
		public PlayerProfileModel profile;

		internal void <Initialize>b__2(AvatarComponent c)
		{
			//IL_001c: Expected I, but got O
			//IL_002c: Expected O, but got I
			//IL_003c: Expected O, but got I
			AvatarData avatarData = profile;
			nint num = (nint)c;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ X8_v1 (Il2CppClass<AvatarComponent>)+178]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ X8_v1 (Il2CppClass<AvatarComponent>)+180]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v18 @ X3_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	private sealed class <>c__DisplayClass20_0
	{
		public AvatarData data;

		internal void <Initialize>b__0(AvatarComponent c)
		{
			//IL_0012: Expected I, but got O
			//IL_0022: Expected O, but got I
			//IL_0032: Expected O, but got I
			AvatarData avatarData = data;
			nint num = (nint)c;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4 @ X9_v1 (Il2CppClass<AvatarComponent>)+178]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4 @ X9_v1 (Il2CppClass<AvatarComponent>)+180]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v5 @ X3_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	private AvatarComponent[] _avatarComponents;

	private bool ShowOnlineIndicator;

	private bool isMyAvatar;

	private int _dbId;

	private TrackingPlacement <TrackingPlacement>k__BackingField;

	private IEnumerable<AvatarComponent> _componentsThatNeedFullProfile
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_014c: Expected O, but got I4
			//IL_00a5: Expected O, but got I
			//IL_00b5: Expected O, but got I
			//IL_00c5: Expected O, but got I
			//IL_00e7: Expected O, but got I4
			//IL_018a: Expected O, but got I
			//IL_019a: Expected O, but got I
			//IL_01aa: Expected O, but got I
			//IL_01cc: Expected O, but got I4
			//IL_0214: Expected O, but got I4
			//IL_026e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0273: Expected O, but got Unknown
			//IL_0289: Expected O, but got I
			//IL_029a: Expected I, but got O
			//IL_02b8: Expected O, but got I
			//IL_0244: Expected O, but got I
			object obj = 152989696;
			object obj2 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2424;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7338]");
			object obj3 = (nint)0 & (nint)1;
			AvatarComponent[] avatarComponents;
			AvatarComponent[] avatarComponents2;
			object obj4;
			if (obj3 != null)
			{
				avatarComponents = _avatarComponents;
				obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = obj4;
				avatarComponents2 = _avatarComponents;
				if (!flag)
				{
					goto IL_0099;
				}
			}
			else
			{
				_ = 1;
				avatarComponents = _avatarComponents;
				obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				object obj5 = obj4;
				avatarComponents2 = _avatarComponents;
				if (obj6 != null)
				{
					goto IL_0099;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj2;
			object obj7 = (nint)0 + (nint)3264;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+B8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+8]");
			Func<object, bool> predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+8]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			IEnumerable<object> enumerable = avatarComponents2;
			object obj10 = obj7;
			IEnumerable<object> source = avatarComponents2;
			if (obj9 == null)
			{
				goto IL_01f2;
			}
			goto IL_0249;
			IL_01f2:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+E4]");
			bool flag4 = (nint)0 == 0;
			object obj11 = !flag4;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj12 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v10+B8]");
				obj8 = 0;
			}
			object obj13 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 248;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj14 = (nint)0 + (nint)512;
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj8, (IntPtr)obj14);
			object obj15 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v9+B8]");
			object obj16 = (nint)0 + (nint)8;
			obj16 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj10 = obj7;
			predicate = func;
			source = enumerable;
			goto IL_0249;
			IL_0249:
			return (IEnumerable<AvatarComponent>)Enumerable.Where(source, predicate);
			IL_0099:
			obj10 = (nint)0 + (nint)3264;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+B8]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+8]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+8]");
			bool flag5 = (nint)0 == 0;
			object obj17 = !flag5;
			source = avatarComponents;
			if (obj17 == null)
			{
				obj7 = obj10;
				enumerable = avatarComponents;
				goto IL_01f2;
			}
			goto IL_0249;
		}
	}

	private int UserDbId
	{
		get
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected O, but got Unknown
			//IL_0040: Expected O, but got I
			//IL_006d: Expected I4, but got O
			object obj = this + 164;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (AvatarInitializer)+50]");
			object obj2 = (nint)0 + (nint)16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (AvatarInitializer)+50]");
			object obj3 = (((nint)0 != 0) ? obj2 : obj);
			return (int)obj3;
		}
	}

	public TrackingPlacement TrackingPlacement
	{
		get
		{
			return <TrackingPlacement>k__BackingField;
		}
		set
		{
			<TrackingPlacement>k__BackingField = value;
		}
	}

	private void AssignComponents()
	{
		//IL_000c: Expected O, but got I
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		object obj = (nint)0 + (nint)768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D31D00");
		object obj2 = this + 152;
		object obj3 = default(object);
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private void Start()
	{
		if (isMyAvatar)
		{
			InitializeMyAvatar();
		}
	}

	public unsafe override void Setup(UserWrapper datum, bool firstTime)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_007d: Expected O, but got Ref
		//IL_009b: Expected O, but got I4
		//IL_0029: Expected O, but got Ref
		//IL_004c: Expected O, but got I
		object obj = typeof(UsageHint) + 152;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		string text = default(string);
		object obj2 = default(object);
		bool flag = ((ValueType)(&text)).Equals(obj2);
		bool flag2 = !flag;
		object obj3 = !flag2;
		if (obj3 == null)
		{
			base.Setup((UserWrapper)(&text), firstTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (AvatarInitializer)+58]");
			<TrackingPlacement>k__BackingField = TrackingPlacement.Background;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (AvatarInitializer)+50]");
			AvatarData avatarData = (PlayerInfo)0;
			Initialize(avatarData);
		}
	}

	public void InitializeMyAvatar()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00cf: Expected O, but got I
		//IL_00f9: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_0142: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E733B]");
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
		Initialize(localUser);
	}

	public void Initialize(User userClient)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_0098: Expected O, but got I
		//IL_00c2: Expected O, but got I4
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_010e: Expected O, but got I
		//IL_011a: Expected O, but got I
		//IL_015e: Expected O, but got I
		//IL_018c: Expected I, but got O
		//IL_01d9: Expected O, but got I
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected O, but got Unknown
		//IL_020c: Expected O, but got I
		//IL_021d: Expected I, but got O
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected O, but got Unknown
		//IL_025b: Expected O, but got I4
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2432;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = userClient;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 24;
		obj4 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if (obj3 == null)
		{
			return;
		}
		object obj5 = typeof(Queue<string>) + 848;
		object obj6 = (nint)0 + (nint)2200;
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v12+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj9 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1224;
		object obj10 = (nint)0 + (nint)520;
		object obj11 = (nint)0 + (nint)2040;
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		object obj12 = obj3 - (object)localUser;
		bool flag2 = obj12 == null;
		isMyAvatar = flag2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3 (System.Object)+10]");
		int intDbId = SFSKammelnaUserExtensions.GetIntDbId((User)0);
		_dbId = intDbId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj10);
		ArraysExtensions.ForEach(_avatarComponents, action);
		if (InitializerRequiresProfileRequest())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3 (System.Object)+10]");
			string dbId = SFSKammelnaUserExtensions.GetDbId((User)0);
			object obj13 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3000;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj14 = (nint)0 + (nint)528;
			Action<object> action2 = default(Action<object>);
			action2..ctor(obj2, (IntPtr)obj14);
			object obj15 = typeof(System.Buffers.Text.ParserHelpers) + 1056;
			object obj16 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X0_v28+E4]");
			bool flag3 = (nint)0 == 0;
			object obj17 = !flag3;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerProfilesHandler.RequestUserProfile(dbId, action2);
		}
	}

	public void Initialize(KPlayer player)
	{
		if (player.IsHuman)
		{
			Initialize(player.<User>k__BackingField);
			return;
		}
		string nickName = player.NickName;
		AvatarData avatarData = ((AvatarInitializer)(object)nickName).AiAvatar(nickName);
		Initialize(avatarData);
	}

	private bool InitializerRequiresProfileRequest()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_00d3: Expected O, but got I
		//IL_00e3: Expected O, but got I
		//IL_00f3: Expected O, but got I
		//IL_0115: Expected O, but got I4
		//IL_0058: Expected O, but got I
		//IL_0068: Expected O, but got I
		//IL_0078: Expected O, but got I
		//IL_009a: Expected O, but got I4
		//IL_014d: Expected O, but got I4
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Expected O, but got Unknown
		//IL_01e3: Expected O, but got I
		//IL_01f4: Expected I, but got O
		//IL_0212: Expected O, but got I
		//IL_017d: Expected O, but got I
		if (isMyAvatar)
		{
			return false;
		}
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2424;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v6+E4]");
		object obj4;
		Func<object, bool> predicate;
		object obj6;
		object obj3;
		if ((nint)0 != 0)
		{
			obj3 = (nint)0 + (nint)2464;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v6+B8]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v7+10]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v7+10]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				obj6 = obj3;
				goto IL_012b;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
			obj6 = (nint)0 + (nint)2464;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v6+B8]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v7+10]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v7+10]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj3 = obj6;
			if (obj7 == null)
			{
				goto IL_012b;
			}
		}
		goto IL_0182;
		IL_0182:
		return Enumerable.Any(_avatarComponents, predicate);
		IL_012b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v6+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v13+B8]");
			obj4 = 0;
		}
		object obj10 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 248;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj11 = (nint)0 + (nint)496;
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj4, (IntPtr)obj11);
		object obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v12+B8]");
		object obj13 = (nint)0 + (nint)16;
		obj13 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj3 = obj6;
		predicate = func;
		goto IL_0182;
	}

	public void InitializeFriendWithDbId(string dbId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_008d: Expected O, but got I4
		//IL_0096: Expected O, but got I4
		//IL_003e: Expected O, but got I4
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_0108: Expected O, but got I
		//IL_0116: Expected I, but got O
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected O, but got Unknown
		//IL_0159: Expected O, but got I4
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		int result;
		bool flag = int.TryParse(dbId, out result);
		User onlineUser = SFS.GetOnlineUser(dbId);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v6+E4]");
		FriendProfile profile;
		if ((nint)0 != 0)
		{
			profile = FriendsManager.GetProfile(result);
			bool flag2 = onlineUser == null;
			object obj3 = 0;
			if (!flag2)
			{
				goto IL_004c;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			profile = FriendsManager.GetProfile(result);
			bool flag3 = onlineUser == null;
			object obj4 = !flag3;
			object obj3 = 0;
			if (obj4 != null)
			{
				goto IL_004c;
			}
		}
		if (profile != null)
		{
			AvatarData avatarData = profile;
			Initialize(avatarData);
			return;
		}
		object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3000;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj6 = (nint)0 + (nint)2112;
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj6);
		object obj7 = typeof(System.Buffers.Text.ParserHelpers) + 1056;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v10+E4]");
		bool flag4 = (nint)0 == 0;
		object obj9 = !flag4;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayerProfilesHandler.RequestUserProfile(dbId, action);
		return;
		IL_004c:
		Initialize(onlineUser);
	}

	public unsafe void Initialize(AvatarData data)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_0066: Expected O, but got I
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected Ref, but got Unknown
		//IL_0087: Expected O, but got I
		//IL_00ab: Expected I, but got O
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2448;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = data;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj3;
		object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1224;
		object obj6 = (nint)0 + (nint)544;
		ref int result = ref *(int*)(this + 164);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v4+10]");
		bool flag = int.TryParse((string)0, out result);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj6);
		ArraysExtensions.ForEach(_avatarComponents, action);
	}

	public void Initialize(IAvatarFeedData avatarData)
	{
		AvatarData avatarData2 = AvatarData.FromFeedData(avatarData);
		Initialize(avatarData2);
	}

	public void Clear()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0179: Expected I4, but got I8
		//IL_00a0: Expected O, but got I
		//IL_00b0: Expected O, but got I
		//IL_00c0: Expected O, but got I
		//IL_00e2: Expected O, but got I4
		//IL_0025: Expected O, but got I
		//IL_0035: Expected O, but got I
		//IL_0045: Expected O, but got I
		//IL_0067: Expected O, but got I4
		//IL_011a: Expected O, but got I4
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected O, but got Unknown
		//IL_01d0: Expected O, but got I
		//IL_01e1: Expected I, but got O
		//IL_01ff: Expected O, but got I
		//IL_014a: Expected O, but got I
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2424;
		isMyAvatar = false;
		_dbId = -1;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v5+E4]");
		object obj4;
		Action<object> action;
		object obj6;
		object obj3;
		if ((nint)0 != 0)
		{
			obj3 = (nint)0 + (nint)2040;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v5+B8]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v7+18]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v7+18]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				obj6 = obj3;
				goto IL_00f8;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
			obj6 = (nint)0 + (nint)2040;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v5+B8]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v7+18]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v7+18]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj3 = obj6;
			if (obj7 == null)
			{
				goto IL_00f8;
			}
		}
		goto IL_014f;
		IL_00f8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v5+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v13+B8]");
			obj4 = 0;
		}
		object obj10 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1224;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj11 = (nint)0 + (nint)488;
		Action<object> action2 = default(Action<object>);
		action2..ctor(obj4, (IntPtr)obj11);
		object obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v12+B8]");
		object obj13 = (nint)0 + (nint)24;
		obj13 = action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj3 = obj6;
		action = action2;
		goto IL_014f;
		IL_014f:
		ArraysExtensions.ForEach(_avatarComponents, action);
	}

	public void InitializeAI(string aiName)
	{
		AvatarData avatarData = AiAvatar(aiName);
		Initialize(avatarData);
	}

	public void InitializeAdmin()
	{
		AvatarData avatarData = AdminAvatar();
		Initialize(avatarData);
	}

	public void InitializeBlockedUser(int points = 0)
	{
		AvatarData avatarData = BlockedUser(points);
		Initialize(avatarData);
	}

	private AvatarData BlockedUser(int points = 0)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0122: Expected O, but got I
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected O, but got Unknown
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected O, but got Unknown
		//IL_0066: Expected O, but got I4
		//IL_0091: Expected O, but got I4
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1776;
		object obj2 = ", stale={0}" + 3424;
		object obj3 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2504;
		object content = (nint)0 + (nint)3240;
		object obj4 = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 2432;
		object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 1064;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		_ = 1;
		object obj6 = default(object);
		obj6..ctor();
		object obj7 = obj6 + 16;
		obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text = StringUtil.Color((string)content, (Color)0);
		string text2 = text + (string)obj4;
		object obj10 = obj6 + 24;
		obj10 = text2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		PlayerRank playerRank = default(PlayerRank);
		playerRank..ctor(points);
		object obj11 = obj6 + 40;
		obj11 = playerRank;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (AvatarData)obj6;
	}

	private AvatarData AdminAvatar()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_0066: Expected O, but got I4
		//IL_00de: Expected O, but got I
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_00fc: Expected O, but got I
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected O, but got Unknown
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1776;
		object obj2 = "Added Tournament Prizes And Features" + 208;
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1064;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		_ = 1;
		object obj4 = default(object);
		obj4..ctor();
		object obj5 = obj4 + 24;
		obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v8+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj6 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v8+B8]");
		object obj8 = 0;
		object obj9 = obj4 + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v5+18]");
		obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Sprite adminPlaceholder = ImageCacher.AdminPlaceholder;
		object obj10 = obj4 + 144;
		obj10 = adminPlaceholder;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (AvatarData)obj4;
	}

	private AvatarData AiAvatar(string aiName)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_009c: Expected O, but got I4
		//IL_00f8: Expected O, but got I
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected O, but got Unknown
		//IL_0116: Expected O, but got I
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1776;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1064;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		_ = 1;
		object obj3 = default(object);
		obj3..ctor();
		Sprite avatarPlaceholder = ImageCacher.AvatarPlaceholder;
		object obj4 = obj3 + 144;
		obj4 = avatarPlaceholder;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj3 + 24;
		obj5 = aiName;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v13+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj6 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v13+B8]");
		object obj8 = 0;
		object obj9 = obj3 + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v5+18]");
		obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = 0;
		return (AvatarData)obj3;
	}

	public void OpenProfile()
	{
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected O, but got Unknown
		//IL_0182: Expected O, but got I
		//IL_00d0: Expected O, but got I4
		//IL_0037: Expected I4, but got O
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_013f: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3016;
		object obj2 = this + 164;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (AvatarInitializer)+50]");
		object obj3 = (nint)0 + (nint)16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (AvatarInitializer)+50]");
		object obj4 = (((nint)0 != 0) ? obj3 : obj2);
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int num = Convert.ToInt32((int)obj4);
		if (num >= 1)
		{
			object obj7 = typeof(MemberAchievementClanFeedData) + 840;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (AvatarInitializer)+50]");
			if ((nint)0 == 0)
			{
			}
			int num2 = default(int);
			string dbId = num2.ToString();
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v14+E4]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			MiniProfilePopup.Show(dbId, <TrackingPlacement>k__BackingField);
		}
	}

	public void OpenAvatarPreview()
	{
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected O, but got Unknown
		//IL_017c: Expected O, but got I
		//IL_00d0: Expected O, but got I4
		//IL_0037: Expected I4, but got O
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_013f: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3016;
		object obj2 = this + 164;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (AvatarInitializer)+50]");
		object obj3 = (nint)0 + (nint)16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (AvatarInitializer)+50]");
		object obj4 = (((nint)0 != 0) ? obj3 : obj2);
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int num = Convert.ToInt32((int)obj4);
		if (num >= 1)
		{
			object obj7 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1792;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (AvatarInitializer)+50]");
			if ((nint)0 == 0)
			{
			}
			int num2 = default(int);
			string dbId = num2.ToString();
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v14+E4]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			AvatarPreviewPopup.Show(dbId);
		}
	}

	public void SetAvatar(Sprite sprite)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_014c: Expected O, but got I4
		//IL_00a5: Expected O, but got I
		//IL_00b5: Expected O, but got I
		//IL_00c5: Expected O, but got I
		//IL_00e7: Expected O, but got I4
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected O, but got Unknown
		//IL_018a: Expected O, but got I
		//IL_019a: Expected O, but got I
		//IL_01aa: Expected O, but got I
		//IL_01cc: Expected O, but got I4
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected O, but got Unknown
		//IL_02af: Expected I, but got O
		//IL_02d8: Expected O, but got I4
		//IL_0214: Expected O, but got I4
		//IL_03e8: Expected O, but got I4
		//IL_0377: Expected O, but got I
		//IL_040e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0413: Expected O, but got Unknown
		//IL_0429: Expected O, but got I
		//IL_043a: Expected I, but got O
		//IL_0458: Expected O, but got I
		//IL_0359: Expected O, but got I
		//IL_0244: Expected O, but got I
		//IL_04b1: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2424;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7344]");
		object obj3 = (nint)0 & (nint)1;
		AvatarComponent[] avatarComponents;
		AvatarComponent[] avatarComponents2;
		object obj4;
		if (obj3 != null)
		{
			avatarComponents = _avatarComponents;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v19+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj4;
			avatarComponents2 = _avatarComponents;
			if (!flag)
			{
				goto IL_0099;
			}
		}
		else
		{
			_ = 1;
			avatarComponents = _avatarComponents;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v19+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			avatarComponents2 = _avatarComponents;
			if (obj6 != null)
			{
				goto IL_0099;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		object obj7 = (nint)0 + (nint)640;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v19+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v15+20]");
		Func<object, bool> predicate = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v15+20]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		IEnumerable<object> enumerable = avatarComponents2;
		object obj10 = obj7;
		IEnumerable<object> source = avatarComponents2;
		if (obj9 == null)
		{
			goto IL_01f2;
		}
		goto IL_0249;
		IL_0249:
		object obj11 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj12 = Enumerable.FirstOrDefault(source, predicate);
		UnityEngine.Object obj21;
		object obj18;
		UnityEngine.Object obj20;
		if (obj12 != null)
		{
			object obj13 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1784;
			object obj14 = obj13;
			nint num = (nint)obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X9_v7 (Il2CppClass<System.Object>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v11+130]");
			bool flag4 = num2 < 0;
			object obj15 = !flag4;
			if (obj15 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X9_v7 (Il2CppClass<System.Object>)+C8]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v11+130]");
				object obj16 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X9_v9-8]");
				object obj17 = ((0 != (nint)obj14) ? null : obj12);
				obj18 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v5+E4]");
				bool flag5 = (nint)0 == 0;
				object obj19 = !flag5;
				obj20 = (UnityEngine.Object)obj17;
				obj21 = (UnityEngine.Object)obj17;
				if (obj19 != null)
				{
					goto IL_031d;
				}
				goto IL_03b5;
			}
		}
		obj18 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v5+E4]");
		bool flag6 = (nint)0 == 0;
		obj20 = null;
		obj21 = null;
		if (!flag6)
		{
			goto IL_031d;
		}
		goto IL_03b5;
		IL_031d:
		if (obj20 != null)
		{
			goto IL_0344;
		}
		return;
		IL_0344:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X20_v6 (UnityEngine.Object)+28]");
		((Image)0).sprite = sprite;
		return;
		IL_0099:
		obj10 = (nint)0 + (nint)640;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v19+B8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v15+20]");
		predicate = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v15+20]");
		bool flag7 = (nint)0 == 0;
		object obj22 = !flag7;
		source = avatarComponents;
		if (obj22 == null)
		{
			obj7 = obj10;
			enumerable = avatarComponents;
			goto IL_01f2;
		}
		goto IL_0249;
		IL_03b5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag8 = obj21 != null;
		bool flag9 = !flag8;
		object obj23 = !flag9;
		obj20 = obj21;
		if (obj23 == null)
		{
			return;
		}
		goto IL_0344;
		IL_01f2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v19+E4]");
		bool flag10 = (nint)0 == 0;
		object obj24 = !flag10;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj25 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X8_v21+B8]");
			obj8 = 0;
		}
		object obj26 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 248;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj27 = (nint)0 + (nint)504;
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj8, (IntPtr)obj27);
		object obj28 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v20+B8]");
		object obj29 = (nint)0 + (nint)32;
		obj29 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj10 = obj7;
		predicate = func;
		source = enumerable;
		goto IL_0249;
	}

	public AvatarInitializer()
	{
		_ = 1;
		_ = 10;
		base..ctor();
	}

	private void <InitializeFriendWithDbId>b__19_0(PlayerProfileModel model)
	{
		AvatarData avatarData = model;
		Initialize(avatarData);
	}
}
