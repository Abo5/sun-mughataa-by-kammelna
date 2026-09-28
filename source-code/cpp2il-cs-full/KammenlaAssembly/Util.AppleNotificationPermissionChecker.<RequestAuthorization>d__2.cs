using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Runtime.Remoting.Messaging;
using System.Xml.Schema;
using Cpp2ILInjected;
using GoogleMobileAds.Api.AdManager;
using Kammelna.Server.Models.Clans;
using Unity.Notifications.iOS;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.TextCore;

namespace Util;

public class AppleNotificationPermissionChecker : INotificationPermissionChecker
{
	private sealed class <RequestAuthorization>d__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public Action<bool> onResult;

		private AuthorizationRequest <req>5__2;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <RequestAuthorization>d__2(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
			//IL_0010: Expected O, but got I4
			//IL_002a: Expected O, but got I4
			//IL_0165: Expected O, but got I4
			//IL_0051: Expected O, but got I4
			//IL_0182: Expected I4, but got I8
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_008c: Expected O, but got Unknown
			//IL_0094: Expected I, but got O
			//IL_00a4: Expected O, but got I
			//IL_00df: Expected O, but got I
			//IL_013d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0142: Expected O, but got Unknown
			//IL_014b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0150: Expected O, but got Unknown
			//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f2: Expected O, but got Unknown
			//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0100: Expected O, but got Unknown
			object obj = <>1__state - 1;
			bool flag = obj == null;
			object obj2 = !flag;
			object obj3 = ~obj2;
			bool flag2;
			if (obj3 == null)
			{
				object obj4 = <>1__state - -3;
				flag2 = obj4 == null;
			}
			else
			{
				flag2 = true;
			}
			while (true)
			{
				object obj5 = !flag2;
				if (obj5 != null)
				{
					break;
				}
				<>1__state = -1;
				AuthorizationRequest authorizationRequest = <req>5__2;
				if (<req>5__2 == null)
				{
					break;
				}
				object obj6 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
				nint num = (nint)authorizationRequest;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v8 (Il2CppClass<Unity.Notifications.iOS.AuthorizationRequest>)+12E]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v8 (Il2CppClass<Unity.Notifications.iOS.AuthorizationRequest>)+12E]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v8 (Il2CppClass<Unity.Notifications.iOS.AuthorizationRequest>)+B0]");
					object obj8 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X10_v4-8]");
						if (0 == (nint)obj6)
						{
							break;
						}
						obj8 += 16;
						obj7--;
						if ((nint)obj7 != 1)
						{
							continue;
						}
						goto IL_0120;
					}
					object obj9 = num + obj8;
					object obj10 = obj9 + 312;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v187 @ X0_v6] (should have been resolved before IL gen)");
					continue;
				}
				goto IL_0120;
				IL_0120:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v174 @ X0_v4] (should have been resolved before IL gen)");
				break;
			}
		}

		private bool MoveNext()
		{
			//IL_06de: Expected I4, but got I8
			//IL_04ee: Expected O, but got I4
			//IL_0021: Expected O, but got I4
			//IL_05c9: Expected O, but got I4
			//IL_0490: Unknown result type (might be due to invalid IL or missing references)
			//IL_0495: Expected O, but got Unknown
			//IL_049e: Expected O, but got I4
			//IL_003e: Expected I4, but got I8
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Expected O, but got Unknown
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0082: Expected O, but got Unknown
			//IL_009d: Expected O, but got I4
			//IL_00a5: Expected I, but got O
			//IL_0505: Expected O, but got I4
			//IL_050a: Expected I, but got O
			//IL_0124: Expected O, but got I4
			//IL_0134: Expected O, but got I
			//IL_0156: Expected O, but got I4
			//IL_018c: Expected O, but got I
			//IL_0198: Expected O, but got I
			//IL_0521: Expected O, but got I4
			//IL_0531: Expected I, but got O
			//IL_0204: Expected O, but got I
			//IL_0548: Expected O, but got I4
			//IL_0558: Expected I, but got O
			//IL_0259: Expected O, but got I
			//IL_056f: Expected O, but got I4
			//IL_057f: Expected I, but got O
			//IL_02b3: Expected O, but got I
			//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e1: Expected O, but got Unknown
			//IL_030b: Expected O, but got I4
			//IL_0712: Expected I4, but got I8
			//IL_0596: Expected O, but got I4
			//IL_05a3: Expected I, but got O
			//IL_03da: Unknown result type (might be due to invalid IL or missing references)
			//IL_03df: Expected O, but got Unknown
			//IL_03e7: Expected I, but got O
			//IL_03f7: Expected O, but got I
			//IL_03b4: Expected O, but got I
			//IL_0432: Expected O, but got I
			//IL_04c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c9: Expected O, but got Unknown
			//IL_04d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d7: Expected O, but got Unknown
			//IL_0440: Unknown result type (might be due to invalid IL or missing references)
			//IL_0445: Expected O, but got Unknown
			//IL_044e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0453: Expected O, but got Unknown
			bool flag = <>1__state == 1;
			<RequestAuthorization>d__2 <RequestAuthorization>d__ = this;
			<RequestAuthorization>d__2 <RequestAuthorization>d__2 = default(<RequestAuthorization>d__2);
			nint num = default(nint);
			if (!flag)
			{
				bool flag2 = <>1__state == 0;
				object obj = !flag2;
				if (obj != null)
				{
					goto IL_066b;
				}
				<>1__state = -1;
				object obj2 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1688;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				AuthorizationRequest authorizationRequest = default(AuthorizationRequest);
				authorizationRequest..ctor((AuthorizationOption)5, registerForRemoteNotifications: true);
				object obj3 = <RequestAuthorization>d__2 + 40;
				obj3 = authorizationRequest;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj4 = 0;
				num = (nint)authorizationRequest;
				<RequestAuthorization>d__ = <RequestAuthorization>d__2;
			}
			<RequestAuthorization>d__.<>1__state = -3;
			NullReferenceException ex;
			string text6;
			if (<RequestAuthorization>d__.<req>5__2 != null)
			{
				if (!<RequestAuthorization>d__.<req>5__2.IsFinished)
				{
					object obj5 = <RequestAuthorization>d__2 + 24;
					obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					<RequestAuthorization>d__2.<>1__state = 1;
					return true;
				}
				if (<RequestAuthorization>d__2.<req>5__2 != null)
				{
					bool isFinished = <RequestAuthorization>d__2.<req>5__2.IsFinished;
					object obj6 = 153100288 + 1024;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X8_v11+28]");
					object obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X0_v27+E4]");
					bool flag3 = (nint)0 == 0;
					object obj8 = !flag3;
					if (obj8 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag4 = default(bool);
					string text = flag4.ToString();
					object obj9 = (nint)0 + (nint)2448;
					object obj10 = (nint)0 + (nint)2472;
					string text2 = (string)obj9 + (string)obj10 + text;
					if (<RequestAuthorization>d__2.<req>5__2 != null)
					{
						bool granted = <RequestAuthorization>d__2.<req>5__2.Granted;
						string text3 = flag4.ToString();
						object obj11 = (nint)0 + (nint)2480;
						string text4 = text2 + (string)obj11 + text3;
						if (<RequestAuthorization>d__2.<req>5__2 != null)
						{
							string error = <RequestAuthorization>d__2.<req>5__2.Error;
							object obj12 = (nint)0 + (nint)2464;
							string text5 = text4 + (string)obj12 + error;
							object obj4;
							string text7;
							if (<RequestAuthorization>d__2.<req>5__2 != null)
							{
								string deviceToken = <RequestAuthorization>d__2.<req>5__2.DeviceToken;
								object obj13 = (nint)0 + (nint)2456;
								string message = text5 + (string)obj13 + deviceToken;
								object obj14 = typeof(DataRelation) + 856;
								object obj15 = obj14;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X0_v50+E4]");
								bool flag5 = (nint)0 == 0;
								object obj16 = !flag5;
								if (obj16 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Debug.Log(message);
								Action<bool> action = <RequestAuthorization>d__2.onResult;
								bool flag6 = <RequestAuthorization>d__2.onResult == null;
								text6 = deviceToken;
								<RequestAuthorization>d__2 <RequestAuthorization>d__3 = <RequestAuthorization>d__2;
								if (!flag6)
								{
									if (<RequestAuthorization>d__2.<req>5__2 == null)
									{
										ex = new NullReferenceException();
										obj4 = 0;
										text7 = deviceToken;
										num = unchecked((nint)null);
										goto IL_05ae;
									}
									bool granted2 = <RequestAuthorization>d__2.<req>5__2.Granted;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X20_v4 (System.Action`1<System.Boolean>)+28]");
									text6 = (string)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v242 @ X20_v4 (System.Action`1<System.Boolean>)+18] (should have been resolved before IL gen)");
									<RequestAuthorization>d__3 = <RequestAuthorization>d__2;
								}
								<RequestAuthorization>d__3.<>1__state = -1;
								AuthorizationRequest authorizationRequest2 = <RequestAuthorization>d__3.<req>5__2;
								if (<RequestAuthorization>d__3.<req>5__2 == null)
								{
									goto IL_066b;
								}
								object obj17 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
								nint num2 = (nint)authorizationRequest2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X8_v35 (Il2CppClass<Unity.Notifications.iOS.AuthorizationRequest>)+12E]");
								object obj18 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X8_v35 (Il2CppClass<Unity.Notifications.iOS.AuthorizationRequest>)+12E]");
								if ((nint)0 == 0)
								{
									goto IL_0473;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X8_v35 (Il2CppClass<Unity.Notifications.iOS.AuthorizationRequest>)+B0]");
								object obj19 = (nint)0 + (nint)8;
								while (true)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X10_v5-8]");
									if (0 == (nint)obj17)
									{
										break;
									}
									obj19 += 16;
									obj18--;
									if ((nint)obj18 != 1)
									{
										continue;
									}
									goto IL_0473;
								}
								object obj20 = num2 + obj19;
								object obj21 = obj20 + 312;
								goto IL_069a;
							}
							ex = new NullReferenceException();
							obj4 = 0;
							text7 = error;
							num = (nint)obj12;
						}
						else
						{
							ex = new NullReferenceException();
							object obj4 = 0;
							string text7 = text3;
							num = (nint)obj11;
						}
					}
					else
					{
						ex = new NullReferenceException();
						object obj4 = 0;
						string text7 = text;
						num = (nint)obj10;
					}
				}
				else
				{
					ex = new NullReferenceException();
					string text7 = (string)1;
					num = unchecked((nint)null);
				}
			}
			else
			{
				ex = new NullReferenceException();
				string text7 = (string)1;
			}
			goto IL_05ae;
			IL_05ae:
			bool flag7 = num != 1;
			object obj22 = 0;
			NullReferenceException ex2 = ex;
			if (!flag7)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				object obj23 = default(object);
				if (obj23 == null)
				{
					goto IL_066b;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223DCD8");
				OutOfMemoryException ex3 = new OutOfMemoryException();
				obj22 = obj23;
				ex2 = (NullReferenceException)(object)ex3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223DC64");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			bool result = default(bool);
			return result;
			IL_0473:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			text6 = null;
			goto IL_069a;
			IL_069a:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v402 @ X0_v55] (should have been resolved before IL gen)");
			goto IL_066b;
			IL_066b:
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void <>m__Finally1()
		{
			//IL_00f6: Expected I4, but got I8
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0021: Expected I, but got O
			//IL_0031: Expected O, but got I
			//IL_006c: Expected O, but got I
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Expected O, but got Unknown
			//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dd: Expected O, but got Unknown
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected O, but got Unknown
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Expected O, but got Unknown
			while (true)
			{
				<>1__state = -1;
				AuthorizationRequest authorizationRequest = <req>5__2;
				if (<req>5__2 == null)
				{
					break;
				}
				object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
				nint num = (nint)authorizationRequest;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v6 (Il2CppClass<Unity.Notifications.iOS.AuthorizationRequest>)+12E]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v6 (Il2CppClass<Unity.Notifications.iOS.AuthorizationRequest>)+12E]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v6 (Il2CppClass<Unity.Notifications.iOS.AuthorizationRequest>)+B0]");
					object obj3 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X10_v4-8]");
						if (0 == (nint)obj)
						{
							break;
						}
						obj3 += 16;
						obj2--;
						if ((nint)obj2 != 1)
						{
							continue;
						}
						goto IL_00ad;
					}
					object obj4 = num + obj3;
					object obj5 = obj4 + 312;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v151 @ X0_v5] (should have been resolved before IL gen)");
					continue;
				}
				goto IL_00ad;
				IL_00ad:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v90 @ X0_v3] (should have been resolved before IL gen)");
				break;
			}
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
			object obj2 = (nint)0 + (nint)56;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}
	}

	public bool IsGranted()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_007d: Expected O, but got I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		object obj = typeof(XmlSchemaInclude) + 1240;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		iOSNotificationSettings notificationSettings = iOSNotificationCenter.GetNotificationSettings();
		object obj5 = default(object);
		object obj4 = obj5 - 2;
		return obj4 == null;
	}

	public void RequestPermission(Action<bool> onResult)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_017f: Expected O, but got I4
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected O, but got Unknown
		//IL_0200: Expected O, but got I4
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected O, but got Unknown
		//IL_00c7: Expected O, but got I4
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Expected O, but got Unknown
		//IL_027c: Expected O, but got I4
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected O, but got Unknown
		object obj = typeof(XmlSchemaInclude) + 1240;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8733]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v19+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v19+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		iOSNotificationSettings notificationSettings = iOSNotificationCenter.GetNotificationSettings();
		object obj5 = default(object);
		if ((nint)obj5 == 1)
		{
			goto IL_009d;
		}
		goto IL_01c2;
		IL_009d:
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v31+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		iOSNotificationCenter.OpenNotificationSettings();
		if (onResult != null)
		{
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X0_v36+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			iOSNotificationSettings notificationSettings2 = iOSNotificationCenter.GetNotificationSettings();
			object obj11 = default(object);
			object obj10 = obj11 - 2;
			bool flag4 = obj10 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [onResult @ X1 (System.Action`1<System.Boolean>)+18] (should have been resolved before IL gen)");
		}
		return;
		IL_01c2:
		object obj12 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v2+E4]");
		bool flag5 = (nint)0 == 0;
		object obj14 = !flag5;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CoroutineDummy instance = CoroutineDummy.Instance;
		object obj15 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1728;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj16 = default(object);
		obj16..ctor();
		_ = 0;
		object obj17 = obj16 + 32;
		obj17 = onResult;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Coroutine coroutine = instance.StartCoroutine((IEnumerator)obj16);
		return;
		IL_0074:
		iOSNotificationSettings notificationSettings3 = iOSNotificationCenter.GetNotificationSettings();
		object obj18 = default(object);
		if ((nint)obj18 == 1)
		{
			goto IL_009d;
		}
		goto IL_01c2;
	}

	private static IEnumerator RequestAuthorization(Action<bool> onResult)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1728;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		object obj3 = obj2 + 32;
		obj3 = onResult;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (IEnumerator)obj2;
	}
}
