using System;
using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DataTracking;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Kammelna.Server.WebRequests;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Mono.Btls;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Core;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Rendering;

public class PlayerProfilesHandler : MonoBehaviour
{
	private sealed class <>c__DisplayClass18_0
	{
		public Action<UserAchievementModel> callback;

		public string achievementId;

		public Func<UserAchievementModel, bool> <>9__2;

		internal void <GetUserAchievementModel>b__0(PlayerProfileModel profile)
		{
			//IL_0131: Unknown result type (might be due to invalid IL or missing references)
			//IL_0136: Expected O, but got Unknown
			//IL_0144: Unknown result type (might be due to invalid IL or missing references)
			//IL_0149: Expected O, but got Unknown
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Expected O, but got Unknown
			//IL_005c: Expected O, but got I4
			//IL_00d4: Expected O, but got I
			//IL_0104: Expected O, but got I4
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Expected O, but got Unknown
			//IL_0094: Expected O, but got I
			//IL_00a2: Expected I, but got O
			bool flag = profile == null;
			Func<object, bool> func = (Func<object, bool>)(object)profile;
			UserAchievementModel arg;
			if (!flag)
			{
				bool flag2 = profile.<gameAchievements>k__BackingField == null;
				func = (Func<object, bool>)(object)profile;
				if (!flag2)
				{
					object obj = this + 32;
					Func<object, bool> func2 = (Func<object, bool>)obj;
					bool flag3 = obj == null;
					object obj2 = !flag3;
					if (obj2 == null)
					{
						object obj3 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 80;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj4 = (nint)0 + (nint)1016;
						Func<object, bool> func3 = default(Func<object, bool>);
						func3..ctor((object)this, (IntPtr)obj4);
						<>9__2 = func3;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						func2 = func3;
					}
					object obj5 = (nint)0 + (nint)1376;
					object obj6 = Enumerable.FirstOrDefault(profile.<gameAchievements>k__BackingField, func2);
					bool flag4 = obj6 == null;
					object obj7 = !flag4;
					func = func2;
					arg = (UserAchievementModel)obj6;
					if (obj7 != null)
					{
						goto IL_0195;
					}
				}
			}
			object obj8 = typeof(UsageHint) + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			UserAchievementModel userAchievementModel = default(UserAchievementModel);
			userAchievementModel..ctor();
			object obj9 = userAchievementModel + 16;
			obj9 = achievementId;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = 0;
			arg = userAchievementModel;
			goto IL_0195;
			IL_0195:
			Actions.SafeInvoke((Action<object>)callback, arg);
		}

		internal bool <GetUserAchievementModel>b__2(UserAchievementModel t)
		{
			//IL_0048: Expected I4, but got O
			if (t != null)
			{
				return t.<gameAchievementId>k__BackingField == achievementId;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal UserAchievementModel <GetUserAchievementModel>g__GetDefaultTrophy|1()
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
	}

	private sealed class <>c__DisplayClass22_0
	{
		public string titleId;

		public Action<bool> isSuccess;

		internal void <UpdateMyTitle>b__0(KammelnaResponseModel<bool> response)
		{
			//IL_0011: Expected O, but got I
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Expected O, but got Unknown
			//IL_0075: Expected O, but got I4
			//IL_009e: Expected O, but got I
			//IL_00db: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e0: Expected O, but got Unknown
			//IL_0134: Expected O, but got I4
			//IL_020f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0214: Expected O, but got Unknown
			//IL_023e: Expected O, but got I4
			//IL_0189: Unknown result type (might be due to invalid IL or missing references)
			//IL_018e: Expected O, but got Unknown
			//IL_01cc: Expected O, but got I4
			//IL_02b0: Expected O, but got I
			//IL_02bc: Expected O, but got I
			//IL_02d1: Expected O, but got I
			object obj = (nint)0 + (nint)1048;
			object obj6;
			PlayerProfileModel playerProfileModel;
			if (response.Succeeded)
			{
				object obj2 = typeof(Queue<string>) + 848;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v12+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj5 = (nint)0 + (nint)2200;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				SessionModel sessionModel = default(SessionModel);
				User localUser = sessionModel.LocalUser;
				string dbId = SFSKammelnaUserExtensions.GetDbId(localUser);
				obj6 = typeof(System.Buffers.Text.ParserHelpers) + 1056;
				object obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v12+E4]");
				if ((nint)0 != 0)
				{
					bool flag2 = TryGetCached(dbId, out playerProfileModel);
					bool flag3 = !flag2;
					object obj8 = !flag3;
					if (obj8 != null)
					{
						goto IL_0180;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					if (TryGetCached(dbId, out playerProfileModel))
					{
						goto IL_0180;
					}
				}
				goto IL_01f1;
			}
			goto IL_025b;
			IL_01f1:
			ITrackEvent trackEvent = TrackerLibrary.ProfileTitleActivated(titleId);
			object obj9 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v16+E4]");
			bool flag4 = (nint)0 == 0;
			object obj11 = !flag4;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Tracker.DesignEvent(trackEvent);
			goto IL_025b;
			IL_0180:
			object obj12 = playerProfileModel + 24;
			obj12 = titleId;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj13 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v30+E4]");
			bool flag5 = (nint)0 == 0;
			object obj14 = !flag5;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj13 = obj6;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v30+B8]");
			object obj15 = 0;
			object obj16 = (nint)0 + (nint)2288;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v18+18]");
			Actions.SafeInvoke((Action<object>)0, playerProfileModel);
			goto IL_01f1;
			IL_025b:
			Action<bool> action = isSuccess;
			if (isSuccess != null)
			{
				bool succeeded = response.Succeeded;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v111 @ X20_v2 (System.Action`1<System.Boolean>)+18] (should have been resolved before IL gen)");
			}
		}
	}

	private sealed class <>c__DisplayClass23_0
	{
		public string newBio;

		internal unsafe void <UpdateMyBio>b__0(KammelnaResponseModel<bool> response)
		{
			//IL_0011: Expected O, but got I
			//IL_01d8: Expected O, but got I
			//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f9: Expected O, but got Unknown
			//IL_0223: Expected O, but got I4
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Expected O, but got Unknown
			//IL_0075: Expected O, but got I4
			//IL_009c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a1: Expected O, but got Unknown
			//IL_00b4: Expected O, but got I4
			//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c8: Expected O, but got Unknown
			//IL_00f2: Expected O, but got I4
			//IL_011b: Expected O, but got I
			//IL_0158: Unknown result type (might be due to invalid IL or missing references)
			//IL_015d: Expected O, but got Unknown
			//IL_0273: Expected O, but got Ref
			//IL_01b1: Expected O, but got I4
			//IL_030a: Unknown result type (might be due to invalid IL or missing references)
			//IL_030f: Expected O, but got Unknown
			//IL_0339: Expected O, but got I4
			//IL_028a: Unknown result type (might be due to invalid IL or missing references)
			//IL_028f: Expected O, but got Unknown
			//IL_02cd: Expected O, but got I4
			//IL_0371: Expected O, but got I
			//IL_037d: Expected O, but got I
			//IL_0392: Expected O, but got I
			//IL_01c7: Expected O, but got Ref
			object obj = (nint)0 + (nint)1048;
			object obj9;
			PlayerProfileModel playerProfileModel;
			object obj12;
			if (response.Succeeded)
			{
				object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v12+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object message = "SERVICE_DISABLED" + 3040;
				Toast.Show((string)message, (Vector2)0, 0f);
				object obj5 = typeof(Queue<string>) + 848;
				object obj6 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X0_v15+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj8 = (nint)0 + (nint)2200;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				SessionModel sessionModel = default(SessionModel);
				User localUser = sessionModel.LocalUser;
				string dbId = SFSKammelnaUserExtensions.GetDbId(localUser);
				obj9 = typeof(System.Buffers.Text.ParserHelpers) + 1056;
				object obj10 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v21+E4]");
				if ((nint)0 != 0)
				{
					bool flag3 = TryGetCached(dbId, out playerProfileModel);
					bool flag4 = !flag3;
					object obj11 = !flag4;
					if (obj11 != null)
					{
						goto IL_0281;
					}
					obj12 = (object)(&playerProfileModel);
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					bool flag5 = TryGetCached(dbId, out playerProfileModel);
					bool flag6 = !flag5;
					obj12 = (object)(&playerProfileModel);
					if (!flag6)
					{
						goto IL_0281;
					}
				}
				goto IL_02f2;
			}
			object obj13 = (nint)0 + (nint)1024;
			string errorMessage = response.ErrorMessage;
			object obj14 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			object obj15 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v10+E4]");
			bool flag7 = (nint)0 == 0;
			object obj16 = !flag7;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PopupWindow.ShowError(errorMessage);
			return;
			IL_02f2:
			ITrackEvent trackEvent = TrackerLibrary.ProfileBioUpdated();
			object obj17 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj18 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v25+E4]");
			bool flag8 = (nint)0 == 0;
			object obj19 = !flag8;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Tracker.DesignEvent(trackEvent);
			return;
			IL_0281:
			object obj20 = playerProfileModel + 72;
			obj20 = newBio;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj21 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X0_v33+E4]");
			bool flag9 = (nint)0 == 0;
			object obj22 = !flag9;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj21 = obj9;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X0_v33+B8]");
			object obj23 = 0;
			object obj24 = (nint)0 + (nint)2288;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X8_v27+18]");
			Actions.SafeInvoke((Action<object>)0, playerProfileModel);
			obj12 = playerProfileModel;
			goto IL_02f2;
		}
	}

	private sealed class <SendRequest>d__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public string userId;

		private GetPlayerProfileRequest <profileRequest>5__2;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <SendRequest>d__27(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0008: Expected O, but got Ref
			//IL_014d: Expected I4, but got I8
			//IL_0029: Expected O, but got I4
			//IL_0186: Expected O, but got I
			//IL_0046: Expected I4, but got I8
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Expected O, but got Unknown
			//IL_0084: Expected O, but got I4
			//IL_01b7: Expected O, but got I
			//IL_01bf: Expected I, but got O
			//IL_01d0: Expected O, but got I
			//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c4: Expected O, but got Unknown
			//IL_0433: Unknown result type (might be due to invalid IL or missing references)
			//IL_0438: Expected O, but got Unknown
			//IL_0462: Expected O, but got I4
			//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00eb: Expected O, but got Unknown
			//IL_0976: Expected O, but got I
			//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0201: Expected O, but got Unknown
			//IL_022b: Expected O, but got I4
			//IL_0116: Unknown result type (might be due to invalid IL or missing references)
			//IL_011b: Expected O, but got Unknown
			//IL_0493: Expected O, but got I
			//IL_049b: Expected I4, but got O
			//IL_04b2: Expected O, but got I
			//IL_04cf: Expected I, but got O
			//IL_0260: Expected O, but got I
			//IL_029c: Expected I, but got O
			//IL_04f8: Expected O, but got I
			//IL_02b6: Expected O, but got I
			//IL_02ec: Expected O, but got I
			//IL_02f8: Expected O, but got I
			//IL_0300: Expected I4, but got O
			//IL_031a: Expected O, but got I
			//IL_0528: Expected O, but got I
			//IL_0530: Expected I, but got O
			//IL_0541: Expected O, but got I4
			//IL_0549: Expected O, but got Ref
			//IL_0337: Expected O, but got I
			//IL_035b: Expected I, but got O
			//IL_091a: Unknown result type (might be due to invalid IL or missing references)
			//IL_091f: Expected O, but got Unknown
			//IL_0949: Expected O, but got I4
			//IL_0505: Expected I4, but got O
			//IL_09d5: Expected O, but got I
			//IL_0375: Expected O, but got I
			//IL_037d: Expected I4, but got O
			//IL_0394: Expected O, but got I
			//IL_03b1: Expected I, but got O
			//IL_0571: Expected O, but got I
			//IL_0579: Expected I4, but got O
			//IL_0590: Expected O, but got I
			//IL_05ad: Expected I, but got O
			//IL_05e1: Expected O, but got I
			//IL_060d: Expected I, but got O
			//IL_03fe: Expected O, but got I
			//IL_0406: Expected I, but got O
			//IL_0417: Expected O, but got I4
			//IL_041f: Expected O, but got Ref
			//IL_0668: Expected O, but got I
			//IL_03db: Expected I4, but got O
			//IL_063d: Expected O, but got I
			//IL_0646: Expected O, but got I4
			//IL_064b: Expected I, but got O
			//IL_0699: Expected O, but got I
			//IL_06a1: Expected I4, but got O
			//IL_06b8: Expected O, but got I
			//IL_06d4: Expected O, but got I
			//IL_06f5: Expected I, but got O
			//IL_070f: Expected O, but got I
			//IL_0717: Expected I4, but got O
			//IL_072e: Expected O, but got I
			//IL_074b: Expected I, but got O
			//IL_077f: Expected O, but got I
			//IL_07ab: Expected I, but got O
			//IL_0806: Expected O, but got I
			//IL_07db: Expected O, but got I
			//IL_07e4: Expected O, but got I4
			//IL_07e9: Expected I, but got O
			//IL_0843: Expected O, but got I
			object obj2 = default(object);
			object obj = (object)(&obj2);
			_ = 0;
			if (<>1__state != 1)
			{
				bool flag = <>1__state == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					<>1__state = -1;
					object obj4 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3016;
					object obj5 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v60+E4]");
					bool flag2 = (nint)0 == 0;
					object obj6 = !flag2;
					if (obj6 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					long num = Convert.ToInt64(userId);
					object obj7 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2664;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					GetPlayerProfileRequest getPlayerProfileRequest = default(GetPlayerProfileRequest);
					getPlayerProfileRequest..ctor(num);
					object obj8 = this + 40;
					obj8 = getPlayerProfileRequest;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					Coroutine coroutine = WebRequestExtensions.Send((IWebRequest<object>)obj8);
					object obj9 = this + 24;
					obj9 = coroutine;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					_ = 1;
					return true;
				}
				goto IL_084c;
			}
			<>1__state = -1;
			GetPlayerProfileRequest getPlayerProfileRequest2 = <profileRequest>5__2;
			List<object>.Enumerator enumerator5;
			if (<profileRequest>5__2 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v6 (Kammelna.Server.WebRequests.GetPlayerProfileRequest)+20]");
				KammelnaResponseModel<object> kammelnaResponseModel = (KammelnaResponseModel<object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v6 (Kammelna.Server.WebRequests.GetPlayerProfileRequest)+20]");
				if ((nint)0 != 0)
				{
					object obj10 = (nint)0 + (nint)1328;
					nint num2 = (nint)obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v6 (Kammelna.Server.WebRequests.GetPlayerProfileRequest)+20]");
					Action<System.Int32Enum> action = default(Action<System.Int32Enum>);
					List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
					if (((KammelnaResponseModel<object>)0).Succeeded)
					{
						object obj11 = typeof(System.Buffers.Text.ParserHelpers) + 1056;
						object obj12 = obj11;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X0_v45+E4]");
						bool flag3 = (nint)0 == 0;
						object obj13 = !flag3;
						if (obj13 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj12 = obj11;
						}
						object <Model>k__BackingField = kammelnaResponseModel.<Model>k__BackingField;
						if (kammelnaResponseModel.<Model>k__BackingField != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X0_v45+B8]");
							object obj14 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X8_v43 (System.Object)+68]");
							_ = 0;
							long num3 = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 40));
							string key = ((long*)num3)->ToString();
							bool flag4 = obj14 == null;
							num2 = unchecked((nint)null);
							if (!flag4)
							{
								object obj15 = (nint)0 + (nint)128;
								object obj16 = obj15;
								((Dictionary<object, object>)obj14).set_Item((object)key, kammelnaResponseModel.<Model>k__BackingField);
								object obj17 = obj11;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ X8_v47+B8]");
								object obj18 = 0;
								object obj19 = (nint)0 + (nint)2288;
								int num4 = (int)obj19;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X8_v48+18]");
								Actions.SafeInvoke((Action<object>)0, kammelnaResponseModel.<Model>k__BackingField);
								object obj20 = obj11;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X8_v49+B8]");
								object obj21 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v50+8]");
								bool flag5 = (nint)0 == 0;
								num2 = (nint)kammelnaResponseModel.<Model>k__BackingField;
								if (!flag5)
								{
									object obj22 = (nint)0 + (nint)1408;
									num4 = (int)obj22;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v50+8]");
									object obj23 = ((Dictionary<object, object>)0).get_Item((object)userId);
									bool flag6 = obj23 == null;
									num2 = (nint)userId;
									if (!flag6)
									{
										List<object>.Enumerator enumerator = ((List<object>)obj23).GetEnumerator();
										List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
										while (enumerator2.MoveNext())
										{
											num4 = (int)obj19;
											Actions.SafeInvoke((Action<object>)(object)action, kammelnaResponseModel.<Model>k__BackingField);
										}
										object obj24 = (nint)0 + (nint)2296;
										num2 = (nint)obj24;
										List<object>.Enumerator enumerator3 = enumerator4;
										enumerator4 = (List<object>.Enumerator)0;
										enumerator5 = (List<object>.Enumerator)(&enumerator2);
										goto IL_0902;
									}
								}
							}
						}
					}
					else
					{
						object obj25 = typeof(System.Buffers.Text.ParserHelpers) + 1056;
						object obj26 = obj25;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X0_v33+E4]");
						bool flag7 = (nint)0 == 0;
						object obj27 = !flag7;
						if (obj27 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj26 = obj25;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X0_v33+B8]");
						object obj28 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X8_v32+10]");
						if ((nint)0 != 0)
						{
							object obj29 = (nint)0 + (nint)1368;
							int num4 = (int)obj29;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X8_v32+10]");
							object obj30 = ((Dictionary<object, object>)0).get_Item((object)userId);
							bool flag8 = obj30 == null;
							num2 = (nint)userId;
							if (!flag8)
							{
								List<object>.Enumerator enumerator6 = ((List<object>)obj30).GetEnumerator();
								object obj31 = (nint)0 + (nint)2216;
								List<object>.Enumerator enumerator7 = default(List<object>.Enumerator);
								while (enumerator7.MoveNext())
								{
									num4 = (int)obj31;
									Actions.SafeInvoke(action, (System.Int32Enum)kammelnaResponseModel.<Error>k__BackingField);
								}
								object obj32 = (nint)0 + (nint)2272;
								num2 = (nint)obj32;
								List<object>.Enumerator enumerator3 = enumerator4;
								enumerator4 = (List<object>.Enumerator)0;
								enumerator5 = (List<object>.Enumerator)(&enumerator7);
								goto IL_0902;
							}
						}
					}
				}
			}
			goto IL_0852;
			IL_0852:
			throw new NullReferenceException();
			IL_0902:
			((List<object>.Enumerator*)enumerator5)->Dispose();
			object obj33 = typeof(System.Buffers.Text.ParserHelpers) + 1056;
			object obj34 = obj33;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X0_v17+E4]");
			bool flag9 = (nint)0 == 0;
			object obj35 = !flag9;
			if (obj35 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj34 = obj33;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X0_v17+B8]");
			object obj36 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v12+8]");
			if ((nint)0 != 0)
			{
				object obj37 = (nint)0 + (nint)1408;
				int num4 = (int)obj37;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v12+8]");
				object obj38 = ((Dictionary<object, object>)0).get_Item((object)userId);
				bool flag10 = obj38 == null;
				nint num2 = (nint)userId;
				if (!flag10)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X0_v19 (System.Object)+18]");
					num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X0_v19 (System.Object)+1C]");
					object obj39 = (nint)0 + (nint)1;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X0_v19 (System.Object)+18]");
					bool flag11 = (nint)0 < (nint)1;
					num2 = (nint)userId;
					if (!flag11)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X0_v19 (System.Object)+10]");
						nint num5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X0_v19 (System.Object)+18]");
						Array.Clear((Array)num5, 0, 0);
						object obj16 = 0;
						num2 = unchecked((nint)null);
					}
					object obj40 = obj33;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X8_v17+B8]");
					object obj41 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X8_v18+8]");
					if ((nint)0 != 0)
					{
						object obj42 = (nint)0 + (nint)1400;
						num4 = (int)obj42;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X8_v18+8]");
						bool flag12 = ((Dictionary<object, object>)0).Remove(userId);
						object obj43 = obj33;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X8_v21+B8]");
						object obj44 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v22+10]");
						bool flag13 = (nint)0 == 0;
						num2 = (nint)userId;
						if (!flag13)
						{
							object obj45 = (nint)0 + (nint)1368;
							num4 = (int)obj45;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v22+10]");
							object obj46 = ((Dictionary<object, object>)0).get_Item((object)userId);
							bool flag14 = obj46 == null;
							num2 = (nint)userId;
							if (!flag14)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X0_v24 (System.Object)+18]");
								num4 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X0_v24 (System.Object)+1C]");
								object obj47 = (nint)0 + (nint)1;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X0_v24 (System.Object)+18]");
								bool flag15 = (nint)0 < (nint)1;
								num2 = (nint)userId;
								if (!flag15)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X0_v24 (System.Object)+10]");
									nint num6 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X0_v24 (System.Object)+18]");
									Array.Clear((Array)num6, 0, 0);
									object obj16 = 0;
									num2 = unchecked((nint)null);
								}
								object obj48 = obj33;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X8_v27+B8]");
								object obj49 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v28+10]");
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v28+10]");
									bool flag16 = ((Dictionary<object, object>)0).Remove(userId);
									goto IL_084c;
								}
							}
						}
					}
				}
			}
			goto IL_0852;
			IL_084c:
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0042: Expected O, but got I
			object obj = typeof(MemberAchievementClanFeedData) + 2648;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			NotSupportedException ex = default(NotSupportedException);
			ex..ctor();
			object obj2 = (nint)0 + (nint)1040;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}
	}

	private static readonly Dictionary<string, PlayerProfileModel> ProfileModels;

	private static readonly Dictionary<string, List<Action<PlayerProfileModel>>> OngoingRequests;

	private static readonly Dictionary<string, List<Action<KammelnaError>>> OngoingRequestsErrors;

	public static event Action<PlayerProfileModel> OnPlayerProfileLoaded
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0211: Expected O, but got I4
			//IL_022e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0233: Expected O, but got Unknown
			//IL_0243: Expected O, but got I
			//IL_0253: Expected O, but got I
			//IL_0170: Expected O, but got I4
			//IL_0179: Expected O, but got I4
			//IL_0182: Expected O, but got I4
			//IL_0046: Expected O, but got I
			//IL_00fb: Expected O, but got I4
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1056;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3000;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v4+18]");
			Delegate obj6 = (Delegate)0;
			Delegate obj8 = default(Delegate);
			object obj9 = default(object);
			Delegate obj13 = default(Delegate);
			Delegate obj21 = default(Delegate);
			while (true)
			{
				Delegate obj7 = Delegate.Combine(obj6, value);
				object obj14;
				Delegate obj15;
				Delegate obj16;
				object obj10;
				object obj12;
				if ((object)obj7 != null)
				{
					obj8 = (Delegate)obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					if (obj9 == null)
					{
						break;
					}
					obj10 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v15+E4]");
					bool flag2 = (nint)0 == 0;
					object obj11 = !flag2;
					obj12 = obj9;
					obj13 = obj7;
					if (obj11 != null)
					{
						goto IL_0030;
					}
					obj14 = obj9;
					obj15 = obj7;
					obj16 = (Delegate)obj4;
					Delegate obj17 = (Delegate)obj4;
					object obj18 = obj10;
				}
				else
				{
					obj10 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v15+E4]");
					bool flag3 = (nint)0 == 0;
					object obj19 = !flag3;
					obj12 = 0;
					obj14 = 0;
					obj15 = obj13;
					obj16 = obj8;
					Delegate obj17 = value;
					object obj18 = obj10;
					if (obj19 != null)
					{
						goto IL_0030;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj10 = obj;
				obj12 = obj14;
				obj13 = obj15;
				obj8 = obj16;
				goto IL_0030;
				IL_0030:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v15+B8]");
				object obj20 = (nint)0 + (nint)24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj21 == obj6;
				obj6 = obj21;
				if (!flag4)
				{
					continue;
				}
				return;
			}
			throw new InvalidCastException();
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0211: Expected O, but got I4
			//IL_022e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0233: Expected O, but got Unknown
			//IL_0243: Expected O, but got I
			//IL_0253: Expected O, but got I
			//IL_0170: Expected O, but got I4
			//IL_0179: Expected O, but got I4
			//IL_0182: Expected O, but got I4
			//IL_0046: Expected O, but got I
			//IL_00fb: Expected O, but got I4
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1056;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3000;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v4+18]");
			Delegate obj6 = (Delegate)0;
			Delegate obj8 = default(Delegate);
			object obj9 = default(object);
			Delegate obj13 = default(Delegate);
			Delegate obj21 = default(Delegate);
			while (true)
			{
				Delegate obj7 = Delegate.Remove(obj6, value);
				object obj14;
				Delegate obj15;
				Delegate obj16;
				object obj10;
				object obj12;
				if ((object)obj7 != null)
				{
					obj8 = (Delegate)obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					if (obj9 == null)
					{
						break;
					}
					obj10 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v15+E4]");
					bool flag2 = (nint)0 == 0;
					object obj11 = !flag2;
					obj12 = obj9;
					obj13 = obj7;
					if (obj11 != null)
					{
						goto IL_0030;
					}
					obj14 = obj9;
					obj15 = obj7;
					obj16 = (Delegate)obj4;
					Delegate obj17 = (Delegate)obj4;
					object obj18 = obj10;
				}
				else
				{
					obj10 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v15+E4]");
					bool flag3 = (nint)0 == 0;
					object obj19 = !flag3;
					obj12 = 0;
					obj14 = 0;
					obj15 = obj13;
					obj16 = obj8;
					Delegate obj17 = value;
					object obj18 = obj10;
					if (obj19 != null)
					{
						goto IL_0030;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj10 = obj;
				obj12 = obj14;
				obj13 = obj15;
				obj8 = obj16;
				goto IL_0030;
				IL_0030:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v15+B8]");
				object obj20 = (nint)0 + (nint)24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj21 == obj6;
				obj6 = obj21;
				if (!flag4)
				{
					continue;
				}
				return;
			}
			throw new InvalidCastException();
		}
	}

	public static event Action<int, FeaturedSlotModel> OnFeaturedSlotChanged
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0211: Expected O, but got I4
			//IL_022e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0233: Expected O, but got Unknown
			//IL_0243: Expected O, but got I
			//IL_0253: Expected O, but got I
			//IL_0170: Expected O, but got I4
			//IL_0179: Expected O, but got I4
			//IL_0182: Expected O, but got I4
			//IL_0046: Expected O, but got I
			//IL_00fb: Expected O, but got I4
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1056;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 472;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v4+20]");
			Delegate obj6 = (Delegate)0;
			Delegate obj8 = default(Delegate);
			object obj9 = default(object);
			Delegate obj13 = default(Delegate);
			Delegate obj21 = default(Delegate);
			while (true)
			{
				Delegate obj7 = Delegate.Combine(obj6, value);
				object obj14;
				Delegate obj15;
				Delegate obj16;
				object obj10;
				object obj12;
				if ((object)obj7 != null)
				{
					obj8 = (Delegate)obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					if (obj9 == null)
					{
						break;
					}
					obj10 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v15+E4]");
					bool flag2 = (nint)0 == 0;
					object obj11 = !flag2;
					obj12 = obj9;
					obj13 = obj7;
					if (obj11 != null)
					{
						goto IL_0030;
					}
					obj14 = obj9;
					obj15 = obj7;
					obj16 = (Delegate)obj4;
					Delegate obj17 = (Delegate)obj4;
					object obj18 = obj10;
				}
				else
				{
					obj10 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v15+E4]");
					bool flag3 = (nint)0 == 0;
					object obj19 = !flag3;
					obj12 = 0;
					obj14 = 0;
					obj15 = obj13;
					obj16 = obj8;
					Delegate obj17 = value;
					object obj18 = obj10;
					if (obj19 != null)
					{
						goto IL_0030;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj10 = obj;
				obj12 = obj14;
				obj13 = obj15;
				obj8 = obj16;
				goto IL_0030;
				IL_0030:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v15+B8]");
				object obj20 = (nint)0 + (nint)32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj21 == obj6;
				obj6 = obj21;
				if (!flag4)
				{
					continue;
				}
				return;
			}
			throw new InvalidCastException();
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0211: Expected O, but got I4
			//IL_022e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0233: Expected O, but got Unknown
			//IL_0243: Expected O, but got I
			//IL_0253: Expected O, but got I
			//IL_0170: Expected O, but got I4
			//IL_0179: Expected O, but got I4
			//IL_0182: Expected O, but got I4
			//IL_0046: Expected O, but got I
			//IL_00fb: Expected O, but got I4
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1056;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 472;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v4+20]");
			Delegate obj6 = (Delegate)0;
			Delegate obj8 = default(Delegate);
			object obj9 = default(object);
			Delegate obj13 = default(Delegate);
			Delegate obj21 = default(Delegate);
			while (true)
			{
				Delegate obj7 = Delegate.Remove(obj6, value);
				object obj14;
				Delegate obj15;
				Delegate obj16;
				object obj10;
				object obj12;
				if ((object)obj7 != null)
				{
					obj8 = (Delegate)obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					if (obj9 == null)
					{
						break;
					}
					obj10 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v15+E4]");
					bool flag2 = (nint)0 == 0;
					object obj11 = !flag2;
					obj12 = obj9;
					obj13 = obj7;
					if (obj11 != null)
					{
						goto IL_0030;
					}
					obj14 = obj9;
					obj15 = obj7;
					obj16 = (Delegate)obj4;
					Delegate obj17 = (Delegate)obj4;
					object obj18 = obj10;
				}
				else
				{
					obj10 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v15+E4]");
					bool flag3 = (nint)0 == 0;
					object obj19 = !flag3;
					obj12 = 0;
					obj14 = 0;
					obj15 = obj13;
					obj16 = obj8;
					Delegate obj17 = value;
					object obj18 = obj10;
					if (obj19 != null)
					{
						goto IL_0030;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj10 = obj;
				obj12 = obj14;
				obj13 = obj15;
				obj8 = obj16;
				goto IL_0030;
				IL_0030:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v15+B8]");
				object obj20 = (nint)0 + (nint)32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj21 == obj6;
				obj6 = obj21;
				if (!flag4)
				{
					continue;
				}
				return;
			}
			throw new InvalidCastException();
		}
	}

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0114: Expected O, but got I
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected O, but got Unknown
		//IL_0134: Expected O, but got I
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected O, but got Unknown
		//IL_0160: Expected I, but got O
		//IL_018a: Expected O, but got I4
		//IL_006e: Expected I, but got O
		//IL_0094: Expected I, but got O
		//IL_00db: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)1264;
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		object obj4 = (nint)0 + (nint)1256;
		object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1264;
		object obj6 = (nint)0 + (nint)1288;
		object obj7 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(null, (IntPtr)obj2);
		object obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Preferences.OnGameChanged += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj4);
		SFS.OnPersonalAvatarUpdated += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action3 = default(Action<object>);
		action3..ctor((object)this, (IntPtr)obj6);
		SFS.OnLogin += action3;
		GameObject gameObject = base.gameObject;
		object obj10 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj11 = !flag2;
		UnityEngine.Object target = gameObject;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			target = gameObject;
		}
		UnityEngine.Object.DontDestroyOnLoad(target);
	}

	public static PlayerProfileModel GetMyCachedProfile()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0144: Expected O, but got I
		//IL_016e: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_01b7: Expected O, but got I4
		//IL_0115: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E644D]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3+E4]");
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
		if (obj8 != null)
		{
			goto IL_00b8;
		}
		goto IL_01c5;
		IL_00b8:
		object obj9 = typeof(System.Buffers.Text.ParserHelpers) + 1056;
		User localUser = sessionModel.LocalUser;
		string dbId = SFSKammelnaUserExtensions.GetDbId(localUser);
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v7+E4]");
		bool flag4 = (nint)0 == 0;
		object obj11 = !flag4;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayerProfileModel playerProfileModel;
		bool flag5 = TryGetCached(dbId, out playerProfileModel);
		return playerProfileModel;
		IL_01c5:
		return (PlayerProfileModel)(object)new NullReferenceException();
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		if ((object)sessionModel != null)
		{
			goto IL_00b8;
		}
		goto IL_01c5;
	}

	public static bool TryGetCached(string userId, out PlayerProfileModel playerProfileModel)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00f1: Expected O, but got I4
		//IL_008c: Expected O, but got I
		//IL_00ae: Expected O, but got I4
		//IL_0129: Expected O, but got I
		//IL_01eb: Expected I4, but got O
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1056;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E644E]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v21+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = obj3;
			if (!flag)
			{
				goto IL_007c;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v21+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			object obj4 = obj3;
			if (obj5 != null)
			{
				goto IL_007c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v12+B8]");
		object obj7 = 0;
		Dictionary<object, object> dictionary = (Dictionary<object, object>)obj7;
		if (obj7 != null)
		{
			goto IL_014e;
		}
		goto IL_01dd;
		IL_01dd:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_014e:
		bool flag3 = dictionary.TryGetValue(userId, out System.Runtime.CompilerServices.Unsafe.As<PlayerProfileModel, object>(ref playerProfileModel));
		if (flag3)
		{
			User onlineUser = SFS.GetOnlineUser(userId);
			if (onlineUser != null)
			{
				if (playerProfileModel == null)
				{
					goto IL_01dd;
				}
				playerProfileModel.Update(onlineUser);
			}
		}
		return flag3;
		IL_007c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v21+B8]");
		object obj8 = 0;
		dictionary = (Dictionary<object, object>)obj8;
		bool flag4 = obj8 == null;
		object obj9 = !flag4;
		if (obj9 != null)
		{
			goto IL_014e;
		}
		goto IL_01dd;
	}

	public unsafe static void RaiseFeaturedSlotChanged(int userId, FeaturedSlotModel slot)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0112: Expected O, but got Ref
		//IL_0040: Expected O, but got I4
		//IL_0048: Expected O, but got Ref
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_016a: Expected O, but got I4
		//IL_01b1: Expected O, but got I
		//IL_01c1: Expected O, but got I
		//IL_01e3: Expected O, but got I4
		//IL_0241: Expected O, but got I
		//IL_024d: Expected O, but got I
		//IL_0262: Expected O, but got I
		//IL_028c: Expected O, but got I4
		//IL_009b: Expected O, but got I
		//IL_00ab: Expected O, but got I
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1056;
		int num = default(int);
		string userId2 = num.ToString();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v3+E4]");
		PlayerProfileModel playerProfileModel;
		object obj4;
		if ((nint)0 != 0)
		{
			bool flag = TryGetCached(userId2, out playerProfileModel);
			bool flag2 = !flag;
			object obj3 = !flag2;
			obj4 = (object)(&playerProfileModel);
			if (obj3 == null)
			{
				goto IL_0056;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = TryGetCached(userId2, out playerProfileModel);
			bool flag4 = !flag3;
			obj4 = (object)(&playerProfileModel);
			if (flag4)
			{
				goto IL_0056;
			}
		}
		object obj5 = playerProfileModel + 48;
		obj5 = slot;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X0_v14+E4]");
		bool flag5 = (nint)0 == 0;
		object obj7 = !flag5;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj6 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X0_v14+B8]");
		object obj8 = 0;
		object obj9 = (nint)0 + (nint)2288;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v9+18]");
		Actions.SafeInvoke((Action<object>)0, playerProfileModel);
		object obj10 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v26+E4]");
		bool flag6 = (nint)0 == 0;
		object obj11 = !flag6;
		obj4 = playerProfileModel;
		object obj12 = obj10;
		if (obj11 != null)
		{
			goto IL_008b;
		}
		goto IL_018f;
		IL_018f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj13 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v7+B8]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v6+20]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v6+20]");
		bool flag7 = (nint)0 == 0;
		object obj16 = !flag7;
		if (obj16 == null)
		{
			return;
		}
		goto IL_00d0;
		IL_0056:
		obj10 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v26+E4]");
		bool flag8 = (nint)0 == 0;
		obj12 = obj10;
		if (!flag8)
		{
			goto IL_008b;
		}
		goto IL_018f;
		IL_008b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v26+B8]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v15+20]");
		obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v15+20]");
		if ((nint)0 != 0)
		{
			goto IL_00d0;
		}
		return;
		IL_00d0:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v118 @ X8_v13+18] (should have been resolved before IL gen)");
	}

	public static void SetFeaturedSlotLocal(int userId, string achievementId, int levelId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_008f: Expected O, but got I4
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 296;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1056;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		FeaturedSlotModel featuredSlotModel = default(FeaturedSlotModel);
		featuredSlotModel..ctor(achievementId, levelId);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RaiseFeaturedSlotChanged(userId, featuredSlotModel);
	}

	public static void ResetFeaturedSlotLocal(int userId)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00b8: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1056;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6451]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v1+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		RaiseFeaturedSlotChanged(userId, null);
		return;
		IL_007d:
		RaiseFeaturedSlotChanged(userId, null);
	}

	public static void RequestMyProfile(Action<PlayerProfileModel> callback, Action<KammelnaError> errorCallback = null)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0169: Expected O, but got I
		//IL_0181: Expected O, but got I
		//IL_01a3: Expected O, but got I4
		//IL_01b3: Expected O, but got I
		//IL_005c: Expected O, but got I
		//IL_0074: Expected O, but got I
		//IL_009b: Expected O, but got I
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_01fc: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6452]");
		object obj3 = (nint)0 & (nint)1;
		object obj7;
		object obj6;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v7+E4]");
			obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v7+E4]");
			bool flag = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v7+E4]");
			obj7 = 0;
			object obj8 = obj4;
			if (!flag)
			{
				goto IL_00b1;
			}
		}
		else
		{
			_ = 1;
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v7+E4]");
			obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v7+E4]");
			obj7 = 0;
			object obj8 = obj4;
			if (obj9 != null)
			{
				goto IL_00b1;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool flag3 = (object)sessionModel == null;
		object obj10 = !flag3;
		obj6 = obj7;
		if (obj10 != null)
		{
			goto IL_00d8;
		}
		goto IL_0212;
		IL_0228:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		NullReferenceException userId;
		RequestUserProfile((string)(object)userId, callback, errorCallback);
		return;
		IL_00d8:
		object obj11 = typeof(System.Buffers.Text.ParserHelpers) + 1056;
		User localUser = sessionModel.LocalUser;
		string dbId = SFSKammelnaUserExtensions.GetDbId(localUser);
		obj6 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v2+E4]");
		bool flag4 = (nint)0 == 0;
		Action<KammelnaError> action = null;
		userId = (NullReferenceException)(object)dbId;
		if (!flag4)
		{
			RequestUserProfile(dbId, callback, errorCallback);
			return;
		}
		goto IL_0228;
		IL_0212:
		userId = new NullReferenceException();
		action = errorCallback;
		goto IL_0228;
		IL_00b1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		if ((object)sessionModel != null)
		{
			goto IL_00d8;
		}
		goto IL_0212;
	}

	public unsafe static void RequestUserProfile(string userId, Action<PlayerProfileModel> callback, Action<KammelnaError> errorCallback = null)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00ee: Expected O, but got I4
		//IL_00a1: Expected O, but got Ref
		//IL_0172: Expected O, but got I4
		//IL_06ba: Expected O, but got I
		//IL_0132: Expected O, but got I4
		//IL_013a: Expected O, but got Ref
		//IL_01a3: Expected O, but got I
		//IL_01b8: Expected O, but got I
		//IL_032e: Expected O, but got I4
		//IL_06e4: Expected O, but got I
		//IL_06f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f8: Expected O, but got Unknown
		//IL_01ff: Expected O, but got I4
		//IL_06cf: Expected O, but got I
		//IL_03a7: Expected O, but got I4
		//IL_0230: Expected O, but got I
		//IL_0245: Expected O, but got I
		//IL_0266: Expected O, but got I
		//IL_027b: Expected O, but got I
		//IL_042c: Expected O, but got I
		//IL_0445: Expected O, but got I
		//IL_045d: Expected O, but got I
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0471: Expected O, but got Unknown
		//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e7: Expected O, but got Unknown
		//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f5: Expected O, but got Unknown
		//IL_02a9: Expected O, but got I4
		//IL_0574: Expected O, but got I
		//IL_02cd: Expected O, but got I
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Expected O, but got Unknown
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Expected O, but got Unknown
		//IL_04e3: Expected O, but got I4
		//IL_0585: Expected O, but got I
		//IL_059a: Expected O, but got I
		//IL_05bb: Expected O, but got I
		//IL_05d0: Expected O, but got I
		//IL_068b: Expected O, but got I
		//IL_051e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0523: Expected O, but got Unknown
		//IL_052c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0531: Expected O, but got Unknown
		//IL_05fe: Expected O, but got I4
		//IL_0622: Expected O, but got I
		//IL_0637: Unknown result type (might be due to invalid IL or missing references)
		//IL_063c: Expected O, but got Unknown
		//IL_0645: Unknown result type (might be due to invalid IL or missing references)
		//IL_064a: Expected O, but got Unknown
		object obj = 152985600;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1056;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6453]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v45+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v45+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		PlayerProfileModel playerProfileModel;
		bool flag2 = TryGetCached(userId, out playerProfileModel);
		bool flag3 = !flag2;
		object obj6 = !flag3;
		object obj7 = (object)(&playerProfileModel);
		if (obj6 != null)
		{
			goto IL_00af;
		}
		goto IL_0148;
		IL_00af:
		Actions.SafeInvoke((Action<object>)callback, playerProfileModel);
		return;
		IL_0148:
		object obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v3+E4]");
		bool flag4 = (nint)0 == 0;
		object obj9 = !flag4;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v3+B8]");
		object obj10 = 0;
		object obj11 = (nint)0 + (nint)1392;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X8_v4+8]");
		bool flag5 = ((Dictionary<object, object>)0).ContainsKey(userId);
		object obj12 = obj2;
		if (flag5)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X0_v9+E4]");
			bool flag6 = (nint)0 == 0;
			object obj13 = !flag6;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj12 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X0_v9+B8]");
			object obj14 = 0;
			object obj15 = (nint)0 + (nint)1408;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X8_v38+8]");
			object obj16 = ((Dictionary<object, object>)0).get_Item((object)userId);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X0_v31 (System.Object)+1C]");
			object obj17 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X0_v31 (System.Object)+10]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X0_v31 (System.Object)+18]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X9_v11+18]");
			bool flag7 = num < 0;
			object obj19 = !flag7;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X0_v31 (System.Object)+18]");
				object obj20 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X0_v31 (System.Object)+18]");
				object obj21 = obj18 + 0;
				object obj22 = obj21 + 32;
				obj22 = callback;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
			else
			{
				((List<object>)obj16).AddWithResize((object)callback);
			}
			object obj23 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ X8_v45+B8]");
			object obj24 = 0;
			object obj25 = (nint)0 + (nint)1368;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X8_v46+10]");
			object obj26 = ((Dictionary<object, object>)0).get_Item((object)userId);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X0_v34 (System.Object)+1C]");
			object obj27 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X0_v34 (System.Object)+10]");
			object obj28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X0_v34 (System.Object)+18]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X9_v14+18]");
			bool flag8 = num2 < 0;
			object obj29 = !flag8;
			if (obj29 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X0_v34 (System.Object)+18]");
				object obj30 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X0_v34 (System.Object)+18]");
				object obj31 = obj28 + 0;
				object obj32 = obj31 + 32;
				obj32 = errorCallback;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
			else
			{
				((List<object>)obj26).AddWithResize((object)errorCallback);
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X0_v9+E4]");
			bool flag9 = (nint)0 == 0;
			object obj33 = !flag9;
			if (obj33 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj12 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X0_v9+B8]");
			object obj34 = 0;
			object obj35 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 3544;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			List<object> list = default(List<object>);
			list..ctor();
			int version = list._version + 1;
			list._version = version;
			object[] items = list._items;
			bool flag10 = list._size < items.Length;
			object obj36 = !flag10;
			if (obj36 == null)
			{
				int size = list._size + 1;
				list._size = size;
				object obj37 = items + list._size;
				object obj38 = obj37 + 32;
				obj38 = callback;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
			else
			{
				list.AddWithResize((object)callback);
			}
			object obj39 = (nint)0 + (nint)1416;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X8_v9+8]");
			((Dictionary<object, object>)0).set_Item((object)userId, (object)list);
			object obj40 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X8_v20+B8]");
			object obj41 = 0;
			object obj42 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 3536;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			List<object> list2 = default(List<object>);
			list2..ctor();
			int version2 = list2._version + 1;
			list2._version = version2;
			object[] items2 = list2._items;
			bool flag11 = list2._size < items2.Length;
			object obj43 = !flag11;
			if (obj43 == null)
			{
				int size2 = list2._size + 1;
				list2._size = size2;
				object obj44 = items2 + list2._size;
				object obj45 = obj44 + 32;
				obj45 = errorCallback;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
			else
			{
				list2.AddWithResize((object)errorCallback);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X8_v21+10]");
			((Dictionary<object, object>)0).set_Item((object)userId, (object)list2);
			RequestProfile(userId);
		}
		return;
		IL_007d:
		bool flag12 = TryGetCached(userId, out playerProfileModel);
		bool flag13 = !flag12;
		obj7 = (object)(&playerProfileModel);
		if (!flag13)
		{
			goto IL_00af;
		}
		goto IL_0148;
	}

	public static PlayerProfileModel AiProfileModel(int index)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected O, but got Unknown
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_014d: Expected O, but got I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_006c: Expected O, but got I4
		//IL_00ba: Expected O, but got I4
		//IL_016b: Expected O, but got I
		//IL_0197: Expected O, but got I
		//IL_0197: Expected I4, but got I8
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
		object input = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 2448;
		object format = "{0} color encoding is currently unsupported for outputting to HDR." + 416;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1064;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 936;
		object obj6 = typeof(System.Buffers.Text.ParserHelpers) + 1048;
		string arg = LocalizationUtil.Localize((string)input);
		object obj7 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg2 = default(object);
		string text = string.Format((string)format, arg, arg2);
		object obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v11+E4]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v11+B8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v7+18]");
		PlayerInfo playerInfo = default(PlayerInfo);
		playerInfo..ctor(-1, text, (PlayerRank)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		PlayerProfileModel playerProfileModel = default(PlayerProfileModel);
		playerProfileModel..ctor(playerInfo);
		return playerProfileModel;
	}

	public static void GetUserAchievementModel(int userId, string achievementId, Action<UserAchievementModel> callback)
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
		//IL_00bf: Expected I, but got O
		//IL_00e9: Expected O, but got I4
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2592;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3000;
		object obj4 = (nint)0 + (nint)1008;
		object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 1056;
		object obj6 = obj2 + 16;
		obj6 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = obj2 + 24;
		obj7 = achievementId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		int num = default(int);
		string userId2 = num.ToString();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v15+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RequestUserProfile(userId2, action);
	}

	public static void RemoveUserFromCache(string user)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0043: Expected O, but got I4
		//IL_00a9: Expected O, but got I
		if (user != null)
		{
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1056;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3+B8]");
			object obj4 = 0;
			bool flag2 = ((Dictionary<object, object>)obj4).Remove((object)user);
		}
	}

	public static void RemoveMyselfFromCache()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_00be: Expected O, but got I4
		//IL_00d8: Expected O, but got I
		//IL_00e8: Expected O, but got I
		//IL_0112: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1056;
		object obj2 = typeof(Queue<string>) + 848;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj;
		}
		object obj5 = (nint)0 + (nint)2200;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+B8]");
		object obj6 = 0;
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		string dbId = SFSKammelnaUserExtensions.GetDbId(localUser);
		bool flag3 = ((Dictionary<object, object>)obj6).Remove((object)dbId);
	}

	public static void ResetModels()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00dd: Expected O, but got I4
		//IL_0095: Expected O, but got I
		//IL_0115: Expected O, but got I
		//IL_0137: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1056;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6458]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v15+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj4;
			if (!flag)
			{
				goto IL_0085;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v15+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			if (obj6 != null)
			{
				goto IL_0085;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v5+B8]");
		object obj8 = 0;
		Dictionary<object, object> dictionary = (Dictionary<object, object>)obj8;
		bool flag3 = obj8 == null;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00a2;
		IL_0085:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v15+B8]");
		object obj10 = 0;
		dictionary = (Dictionary<object, object>)obj10;
		goto IL_00a2;
		IL_00a2:
		dictionary.Clear();
	}

	public static void UpdateMyTitle(string titleId, Action<bool> isSuccess = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_0099: Expected I, but got O
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2600;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
		object obj4 = (nint)0 + (nint)1024;
		object obj5 = obj2 + 16;
		obj5 = titleId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj2 + 24;
		obj6 = isSuccess;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		KammelnaRequests.ActivateTitle((string)obj5, action);
	}

	public static void UpdateMyBio(string newBio)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0079: Expected I, but got O
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2608;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
		object obj4 = (nint)0 + (nint)1032;
		object obj5 = obj2 + 16;
		obj5 = newBio;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		KammelnaRequests.ChangeBio((string)obj5, action);
	}

	private void UpdateMyProfileLikes(BaseEvent _)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0193: Expected O, but got I
		//IL_01ab: Expected I, but got O
		//IL_006d: Expected O, but got I4
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_00b9: Expected O, but got I
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		//IL_00f2: Expected I, but got O
		//IL_0132: Expected O, but got I
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected O, but got Unknown
		//IL_016b: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1264;
		object obj2 = (nint)0 + (nint)1288;
		object obj3 = typeof(Queue<string>) + 848;
		object obj4 = (nint)0 + (nint)2200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		SFS.OnLogin -= action;
		GameObject go = base.gameObject;
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj7 = typeof(SqlSingle[]) + 2376;
		object obj8 = (nint)0 + (nint)1280;
		object varName = "java.io.FileOutputStream" + 2864;
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj8);
		VariableBinderExtensions.Bind(go, localUser, (string)varName, action2);
		GameObject go2 = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj9 = (nint)0 + (nint)1272;
		object varName2 = "___# Content push apply failed [{0}]: {1}" + 2960;
		SessionModel sessionModel2 = default(SessionModel);
		User localUser2 = sessionModel2.LocalUser;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj9);
		VariableBinderExtensions.Bind(go2, localUser2, (string)varName2, action3);
	}

	private unsafe void OnPersonalAvatarUpdated()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected O, but got Unknown
		//IL_0159: Expected O, but got I4
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_01fa: Expected O, but got Ref
		//IL_00fe: Expected O, but got I4
		//IL_0106: Expected O, but got Ref
		//IL_01b1: Expected O, but got I4
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected O, but got Unknown
		//IL_0247: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(UsageHint) + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E645C]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object obj6;
		if (obj3 != null)
		{
			obj4 = typeof(System.Buffers.Text.ParserHelpers) + 1056;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v14+E4]");
			bool flag = (nint)0 == 0;
			obj6 = obj4;
			if (!flag)
			{
				goto IL_0099;
			}
		}
		else
		{
			_ = 1;
			obj4 = typeof(System.Buffers.Text.ParserHelpers) + 1056;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v14+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0099;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		string userDbId = UserInfo.UserDbId;
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v6+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		string userId = userDbId;
		if (obj9 != null)
		{
			goto IL_00d7;
		}
		goto IL_01c7;
		IL_0208:
		object obj10 = typeof(DataRelation) + 712;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v2+E4]");
		bool flag4 = (nint)0 == 0;
		object obj12 = !flag4;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime now = DateTime.Now;
		DateTime? <avatarDate>k__BackingField = now;
		PlayerProfileModel playerProfileModel;
		playerProfileModel.<avatarDate>k__BackingField = <avatarDate>k__BackingField;
		return;
		IL_00d7:
		bool flag5 = TryGetCached(userDbId, out playerProfileModel);
		bool flag6 = !flag5;
		object obj13 = !flag6;
		object obj14 = (object)(&playerProfileModel);
		if (obj13 == null)
		{
			return;
		}
		goto IL_0208;
		IL_01c7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag7 = TryGetCached(userId, out playerProfileModel);
		bool flag8 = !flag7;
		obj14 = (object)(&playerProfileModel);
		if (flag8)
		{
			return;
		}
		goto IL_0208;
		IL_0099:
		userDbId = UserInfo.UserDbId;
		obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v6+E4]");
		bool flag9 = (nint)0 == 0;
		userId = userDbId;
		if (!flag9)
		{
			goto IL_00d7;
		}
		goto IL_01c7;
	}

	private static void RequestProfile(string userId)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected O, but got Unknown
		//IL_01b2: Expected O, but got I4
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected O, but got Unknown
		//IL_025c: Expected O, but got I
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_0109: Expected O, but got I
		//IL_0123: Expected O, but got I4
		//IL_020a: Expected O, but got I4
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected O, but got Unknown
		object obj = 152985600;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E64D1]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object obj6;
		if (obj3 != null)
		{
			obj4 = typeof(System.Buffers.Text.ParserHelpers) + 1056;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v13+E4]");
			bool flag = (nint)0 == 0;
			obj6 = obj4;
			if (!flag)
			{
				goto IL_0099;
			}
		}
		else
		{
			_ = 1;
			obj4 = typeof(System.Buffers.Text.ParserHelpers) + 1056;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v13+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0099;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		CoroutineDummy permanentInstance = CoroutineDummy.PermanentInstance;
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v11+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		CoroutineDummy coroutineDummy = permanentInstance;
		CoroutineDummy coroutineDummy2 = permanentInstance;
		if (obj9 != null)
		{
			goto IL_00df;
		}
		goto IL_0228;
		IL_0141:
		_ = 1;
		object obj11;
		object obj10 = obj11;
		coroutineDummy2 = coroutineDummy;
		goto IL_028e;
		IL_00df:
		obj11 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2616;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E64D2]");
		object obj12 = (nint)0 & (nint)1;
		bool flag4 = obj12 == null;
		object obj13 = !flag4;
		obj10 = obj11;
		coroutineDummy2 = coroutineDummy;
		if (obj13 == null)
		{
			goto IL_0141;
		}
		goto IL_028e;
		IL_028e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj14 = default(object);
		obj14..ctor();
		_ = 0;
		object obj15 = obj14 + 32;
		obj15 = userId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Coroutine coroutine = coroutineDummy2.StartCoroutine((IEnumerator)obj14);
		return;
		IL_0099:
		CoroutineDummy permanentInstance2 = CoroutineDummy.PermanentInstance;
		obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v11+E4]");
		bool flag5 = (nint)0 == 0;
		coroutineDummy = permanentInstance2;
		coroutineDummy2 = permanentInstance2;
		if (!flag5)
		{
			goto IL_00df;
		}
		goto IL_0228;
		IL_0228:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj11 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2616;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E64D2]");
		object obj16 = (nint)0 & (nint)1;
		bool flag6 = obj16 == null;
		coroutineDummy = coroutineDummy2;
		if (flag6)
		{
			goto IL_0141;
		}
		obj10 = obj11;
		goto IL_028e;
	}

	private static IEnumerator SendRequest(string userId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2616;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		object obj3 = obj2 + 32;
		obj3 = userId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (IEnumerator)obj2;
	}

	private unsafe void UpdateMyLikes()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected O, but got Unknown
		//IL_0211: Expected O, but got Ref
		//IL_01c7: Expected O, but got I4
		//IL_01cf: Expected O, but got Ref
		//IL_0249: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E645D]");
		object obj3 = (nint)0 & (nint)1;
		object obj6;
		object obj4;
		if (obj3 != null)
		{
			obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v20+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v20+E4]");
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
		obj4 = obj6;
		goto IL_0140;
		IL_0140:
		object obj8 = typeof(System.Buffers.Text.ParserHelpers) + 1056;
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		string dbId = SFSKammelnaUserExtensions.GetDbId(localUser);
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v4+E4]");
		PlayerProfileModel playerProfileModel;
		if ((nint)0 != 0)
		{
			bool flag3 = TryGetCached(dbId, out playerProfileModel);
			bool flag4 = !flag3;
			object obj10 = !flag4;
			object obj11 = (object)(&playerProfileModel);
			if (obj10 == null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag5 = TryGetCached(dbId, out playerProfileModel);
			bool flag6 = !flag5;
			object obj11 = (object)(&playerProfileModel);
			if (flag6)
			{
				return;
			}
		}
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X0_v7+E4]");
		bool flag7 = (nint)0 == 0;
		object obj13 = !flag7;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel2 = default(SessionModel);
		User localUser2 = sessionModel2.LocalUser;
		int likes = SFSKammelnaUserExtensions.GetLikes(localUser2);
		if (likes >= 1)
		{
			playerProfileModel.<likes>k__BackingField = likes;
		}
		return;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag8 = (object)sessionModel == null;
		object obj14 = !flag8;
		if (obj14 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0140;
	}

	private unsafe void UpdateMyAchievements()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00d1: Expected O, but got I
		//IL_00fb: Expected O, but got I4
		//IL_00ac: Expected O, but got I4
		//IL_0053: Expected O, but got I
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		//IL_0208: Expected O, but got Ref
		//IL_01be: Expected O, but got I4
		//IL_01c6: Expected O, but got Ref
		//IL_0240: Expected O, but got I4
		object obj = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E645E]");
		object obj2 = (nint)0 & (nint)1;
		object obj5;
		object obj3;
		if (obj2 != null)
		{
			obj3 = (nint)0 + (nint)2200;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v24+E4]");
			bool flag = (nint)0 == 0;
			obj5 = obj3;
			if (!flag)
			{
				goto IL_0088;
			}
		}
		else
		{
			_ = 1;
			obj3 = (nint)0 + (nint)2200;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v24+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			obj5 = obj3;
			if (obj6 != null)
			{
				goto IL_0088;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		obj3 = obj5;
		goto IL_0137;
		IL_0137:
		object obj7 = typeof(System.Buffers.Text.ParserHelpers) + 1056;
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		string dbId = SFSKammelnaUserExtensions.GetDbId(localUser);
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v4+E4]");
		PlayerProfileModel playerProfileModel;
		if ((nint)0 != 0)
		{
			bool flag3 = TryGetCached(dbId, out playerProfileModel);
			bool flag4 = !flag3;
			object obj9 = !flag4;
			object obj10 = (object)(&playerProfileModel);
			if (obj9 == null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag5 = TryGetCached(dbId, out playerProfileModel);
			bool flag6 = !flag5;
			object obj10 = (object)(&playerProfileModel);
			if (flag6)
			{
				return;
			}
		}
		object obj11 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X0_v7+E4]");
		bool flag7 = (nint)0 == 0;
		object obj12 = !flag7;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel2 = default(SessionModel);
		User localUser2 = sessionModel2.LocalUser;
		int achievementCount = SFSKammelnaUserExtensions.GetAchievementCount(localUser2);
		int num = playerProfileModel.AchievementsCount();
		if (achievementCount != num)
		{
			object obj13 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X0_v15+E4]");
			if ((nint)0 != 0)
			{
				RemoveMyselfFromCache();
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			RemoveMyselfFromCache();
		}
		return;
		IL_0088:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag8 = (object)sessionModel == null;
		object obj14 = !flag8;
		if (obj14 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0137;
	}

	static PlayerProfilesHandler()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_008e: Expected O, but got I
		//IL_00d6: Expected O, but got I
		object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 2672;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1056;
		object obj3 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 2088;
		object obj4 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 2080;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<object, object> dictionary = default(Dictionary<object, object>);
		dictionary..ctor();
		object obj5 = obj2;
		object obj6 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<object, object> dictionary2 = default(Dictionary<object, object>);
		dictionary2..ctor();
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v4+B8]");
		object obj8 = (nint)0 + (nint)8;
		obj8 = dictionary2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<object, object> dictionary3 = default(Dictionary<object, object>);
		dictionary3..ctor();
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v5+B8]");
		object obj10 = (nint)0 + (nint)16;
		obj10 = dictionary3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
