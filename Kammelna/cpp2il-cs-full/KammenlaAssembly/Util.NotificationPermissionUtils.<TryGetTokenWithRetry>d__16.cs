using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Dynamic.Utils;
using System.Formats.Asn1;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using DataTracking;
using Firebase;
using Firebase.Messaging;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Mono.Btls;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Core;
using Sfs2X.Entities;
using Unity.Properties;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.TextCore;

namespace Util;

public static class NotificationPermissionUtils
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<bool> <>9__14_0;

		public static Action<Task<DependencyStatus>> <>9__15_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1120;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <RequestPermission>b__14_0(bool granted)
		{
			if (granted)
			{
				InitializeNotifications();
			}
		}

		internal void <InitializeNotifications>b__15_0(Task<DependencyStatus> depsTask)
		{
			//IL_0011: Expected O, but got I
			//IL_0105: Unknown result type (might be due to invalid IL or missing references)
			//IL_010a: Expected O, but got Unknown
			//IL_0120: Expected O, but got I
			//IL_012e: Expected I, but got O
			//IL_014b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0150: Expected O, but got Unknown
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Expected O, but got Unknown
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Expected O, but got Unknown
			//IL_006d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0072: Expected O, but got Unknown
			//IL_016b: Expected O, but got I
			//IL_0179: Expected I, but got O
			//IL_00c9: Expected O, but got I4
			//IL_0196: Unknown result type (might be due to invalid IL or missing references)
			//IL_019b: Expected O, but got Unknown
			//IL_01b1: Expected O, but got I
			//IL_01bf: Expected I, but got O
			//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e1: Expected O, but got Unknown
			//IL_020b: Expected O, but got I4
			//IL_0240: Unknown result type (might be due to invalid IL or missing references)
			//IL_0245: Expected O, but got Unknown
			object obj = (nint)0 + (nint)1392;
			if (((Task<System.Int32Enum>)(object)depsTask).Result != 0)
			{
				object obj2 = typeof(DataRelation) + 1968;
				object format = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 208;
				object obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
				System.Int32Enum result = ((Task<System.Int32Enum>)(object)depsTask).Result;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				object arg = default(object);
				string text = string.Format((string)format, arg);
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v22+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				object obj6 = text;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj6 = text;
				}
				KLogger.Log(obj6);
				return;
			}
			object obj7 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 1216;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj8 = (nint)0 + (nint)3528;
			EventHandler<object> eventHandler = default(EventHandler<object>);
			eventHandler..ctor((object)null, (IntPtr)obj8);
			FirebaseMessaging.TokenReceived += (EventHandler<TokenReceivedEventArgs>)(object)eventHandler;
			object obj9 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 1192;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj10 = (nint)0 + (nint)3520;
			EventHandler<object> eventHandler2 = default(EventHandler<object>);
			eventHandler2..ctor((object)null, (IntPtr)obj10);
			FirebaseMessaging.MessageReceived += (EventHandler<MessageReceivedEventArgs>)(object)eventHandler2;
			object obj11 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1264;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj12 = (nint)0 + (nint)3536;
			Action<object> action = default(Action<object>);
			action..ctor((object)null, (IntPtr)obj12);
			SFS.OnLogin += action;
			object obj13 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
			object obj14 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X0_v15+E4]");
			bool flag2 = (nint)0 == 0;
			object obj15 = !flag2;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			CoroutineDummy instance = CoroutineDummy.Instance;
			object obj16 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1136;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj17 = default(object);
			obj17..ctor();
			_ = 0;
			Coroutine coroutine = instance.StartCoroutine((IEnumerator)obj17);
		}
	}

	private sealed class <>c__DisplayClass20_0
	{
		public string token;

		internal void <RegisterToken>g__UpdateToken|0()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0020: Expected O, but got I
			//IL_003e: Expected I, but got O
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
			object obj2 = (nint)0 + (nint)2656;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action<object> action = default(Action<object>);
			action..ctor((object)this, (IntPtr)obj2);
			KammelnaRequests.RegisterFirebaseNotifications(token, action);
		}

		internal void <RegisterToken>b__1(KammelnaResponseModel<bool> request)
		{
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Expected O, but got Unknown
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Expected O, but got Unknown
			//IL_00ba: Expected O, but got I4
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Expected O, but got Unknown
			if (request.Succeeded)
			{
				object key = "Error reading data from socket: " + 2424;
				Prefs.SetString((string)key, token);
				object obj = typeof(DataRelation) + 712;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v7+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				DateTime now = DateTime.Now;
				object key2 = "Error reading data from socket: " + 2432;
				Prefs.SetDate((string)key2, now);
			}
		}
	}

	[StructLayout((LayoutKind)3)]
	private struct <>c__DisplayClass21_0
	{
		public MessageReceivedEventArgs e;
	}

	private sealed class <TryGetTokenWithRetry>d__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		private int <attempt>5__2;

		private Task<string> <task>5__3;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <TryGetTokenWithRetry>d__16(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_010d: Expected I4, but got I8
			//IL_00d0: Expected I4, but got I8
			//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a5: Expected O, but got Unknown
			//IL_00bc: Expected I4, but got I8
			//IL_02c4: Expected I, but got O
			//IL_023a: Unknown result type (might be due to invalid IL or missing references)
			//IL_023f: Expected O, but got Unknown
			//IL_0248: Expected O, but got I4
			//IL_005e: Expected I4, but got I8
			//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d4: Expected O, but got Unknown
			//IL_02dd: Expected O, but got I4
			//IL_09b9: Expected I4, but got O
			//IL_016f: Expected I, but got O
			//IL_01a2: Expected O, but got I4
			//IL_0311: Expected I, but got O
			//IL_01c6: Expected I, but got O
			//IL_09e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_09ed: Expected O, but got Unknown
			//IL_0464: Expected I, but got O
			//IL_0504: Unknown result type (might be due to invalid IL or missing references)
			//IL_0509: Expected O, but got Unknown
			//IL_0523: Expected O, but got I4
			//IL_03b0: Expected O, but got I4
			//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c9: Expected O, but got Unknown
			//IL_04a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_04a9: Expected O, but got Unknown
			//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f7: Expected O, but got Unknown
			//IL_0421: Expected O, but got I4
			//IL_04d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d5: Expected O, but got Unknown
			//IL_04f0: Expected O, but got I4
			//IL_0584: Expected I, but got O
			//IL_05fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0600: Expected O, but got Unknown
			//IL_06a9: Expected O, but got I8
			//IL_064e: Expected I, but got O
			//IL_06d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_06dc: Expected O, but got Unknown
			//IL_06e4: Expected O, but got I
			//IL_077e: Expected O, but got I4
			//IL_078e: Expected O, but got I4
			//IL_07ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_07b3: Expected O, but got Unknown
			//IL_071b: Expected I, but got O
			//IL_07d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_07d7: Expected O, but got Unknown
			//IL_0880: Expected O, but got I8
			//IL_0825: Expected I, but got O
			//IL_08ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_08b3: Expected O, but got Unknown
			//IL_08cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_08d4: Expected O, but got Unknown
			//IL_08f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_08fe: Expected O, but got Unknown
			//IL_0928: Expected O, but got I4
			//IL_0a60: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a65: Expected O, but got Unknown
			//IL_095b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0960: Expected O, but got Unknown
			//IL_097b: Expected O, but got I4
			bool result;
			if (<>1__state <= 1)
			{
				if (<>1__state == 0)
				{
					<>1__state = -1;
					<attempt>5__2 = 1;
					if (1 < 6)
					{
						goto IL_0291;
					}
					goto IL_048f;
				}
				bool flag = <>1__state != 1;
				result = false;
				if (!flag)
				{
					<>1__state = -1;
					goto IL_0112;
				}
			}
			else
			{
				if (<>1__state == 2)
				{
					<>1__state = -1;
					goto IL_0257;
				}
				bool flag2 = <>1__state != 3;
				result = false;
				if (!flag2)
				{
					<>1__state = -1;
					goto IL_0234;
				}
			}
			goto IL_09d9;
			IL_0a3d:
			return true;
			IL_099c:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
			OutOfMemoryException ex = new OutOfMemoryException();
			return (byte)(int)ex != 0;
			IL_0291:
			Task<string> tokenAsync = FirebaseMessaging.GetTokenAsync();
			object obj = this + 40;
			obj = tokenAsync;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			nint num = (nint)tokenAsync;
			goto IL_0112;
			IL_098e:
			IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
			goto IL_099c;
			IL_048f:
			return false;
			IL_0257:
			if (++<attempt>5__2 < 6)
			{
				goto IL_0291;
			}
			goto IL_048f;
			IL_09d9:
			return result;
			IL_0234:
			object obj2 = this + 40;
			obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			goto IL_0257;
			IL_0112:
			if (<task>5__3 != null)
			{
				if (!<task>5__3.IsCompleted)
				{
					object obj3 = this + 24;
					obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					_ = 1;
					result = true;
					goto IL_09d9;
				}
				bool flag3 = <task>5__3 == null;
				num = unchecked((nint)null);
				if (!flag3)
				{
					bool isFaulted = <task>5__3.IsFaulted;
					bool flag4 = !isFaulted;
					object obj4 = !flag4;
					if (obj4 == null)
					{
						bool flag5 = <task>5__3 == null;
						num = unchecked((nint)null);
						if (!flag5)
						{
							object result2 = ((Task<object>)(object)<task>5__3).Result;
							if (string.IsNullOrEmpty((string)result2))
							{
								if (<attempt>5__2 > 4)
								{
									goto IL_0234;
								}
								object obj5 = typeof(UsageHint) + 1640;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
								WaitForSeconds waitForSeconds = default(WaitForSeconds);
								waitForSeconds..ctor(3f);
								object obj6 = this + 24;
								obj6 = waitForSeconds;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								object obj7 = 3;
								goto IL_0a3d;
							}
							bool flag6 = <task>5__3 == null;
							num = unchecked((nint)null);
							if (!flag6)
							{
								object result3 = ((Task<object>)(object)<task>5__3).Result;
								HandleNewToken((string)result3);
								goto IL_048f;
							}
						}
					}
					else
					{
						bool flag7 = <task>5__3 == null;
						num = unchecked((nint)null);
						if (!flag7)
						{
							AggregateException ex3 = <task>5__3.Exception;
							if (ex3 != null)
							{
								ex3 = (AggregateException)ex3.GetBaseException();
								if (ex3 != null)
								{
									ex3 = (AggregateException)(object)ex3.Message;
								}
							}
							object obj8 = "tournament_participate_warning_body_with_tickets_warning_daily" + 3112;
							AggregateException ex4 = (AggregateException)((ex3 != null) ? ex3 : obj8);
							if (<attempt>5__2 > 4)
							{
								object obj9 = 153100288 + 1024;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
								object format = "Error reading data from socket: " + 2400;
								object arg = default(object);
								string text = string.Format((string)format, arg, ex4);
								object obj10 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
								object obj11 = obj10;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v54+E4]");
								bool flag8 = (nint)0 == 0;
								object obj12 = !flag8;
								object obj13 = text;
								if (obj12 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									obj13 = text;
								}
								KLogger.Log(obj13);
								goto IL_048f;
							}
							object obj14 = typeof(TypeConverter<ushort, char>) + 3400;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
							object obj15 = 153100288 + 1024;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
							object[] array = default(object[]);
							bool flag9 = array == null;
							int num2 = default(int);
							num = (nint)(&num2);
							if (!flag9)
							{
								object obj16 = default(object);
								bool flag10 = obj16 == null;
								nint num3 = (nint)(&num2);
								if (!flag10)
								{
									nint num4 = (nint)array;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X8_v46 (Il2CppClass<System.Object[]>)+40]");
									num3 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
									bool flag11 = ex2 == null;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X8_v46 (Il2CppClass<System.Object[]>)+40]");
									num = 0;
									if (flag11)
									{
										goto IL_099c;
									}
								}
								bool flag12 = array.Length == 0;
								num = num3;
								if (!flag12)
								{
									object obj17 = array + 32;
									obj17 = obj16;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
									IntPtr intPtr = default(IntPtr);
									bool flag13 = intPtr == (IntPtr)0;
									object obj18 = default(object);
									nint num5 = (nint)(&obj18);
									if (!flag13)
									{
										nint num6 = (nint)array;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X8_v45 (Il2CppClass<System.Object[]>)+40]");
										num5 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
										bool flag14 = ex2 == null;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X8_v45 (Il2CppClass<System.Object[]>)+40]");
										num = 0;
										if (flag14)
										{
											goto IL_099c;
										}
									}
									object obj19 = array.Length & 0xFFFFFFFEL;
									bool flag15 = obj19 == null;
									num = num5;
									if (!flag15)
									{
										object obj20 = array + 40;
										obj20 = (nint)intPtr;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
										bool flag16 = ex4 == null;
										nint num7 = intPtr;
										if (!flag16)
										{
											nint num8 = (nint)array;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v494 @ X8_v44 (Il2CppClass<System.Object[]>)+40]");
											num7 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
											bool flag17 = ex2 == null;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v494 @ X8_v44 (Il2CppClass<System.Object[]>)+40]");
											num = 0;
											if (flag17)
											{
												goto IL_099c;
											}
										}
										bool flag18 = array.Length < 2;
										object obj21 = !flag18;
										object obj22 = array.Length - 2;
										bool flag19 = obj22 == null;
										object obj23 = ~obj21;
										object obj24 = obj23 | flag19;
										num = num7;
										if (obj24 == null)
										{
											object obj25 = array + 48;
											obj25 = ex4;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
											object obj26 = default(object);
											bool flag20 = obj26 == null;
											object obj27 = default(object);
											nint num9 = (nint)(&obj27);
											if (!flag20)
											{
												nint num10 = (nint)array;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X8_v43 (Il2CppClass<System.Object[]>)+40]");
												num9 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
												bool flag21 = ex2 == null;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X8_v43 (Il2CppClass<System.Object[]>)+40]");
												num = 0;
												if (flag21)
												{
													goto IL_099c;
												}
											}
											object obj28 = array.Length & 0xFFFFFFFCL;
											bool flag22 = obj28 == null;
											num = num9;
											if (!flag22)
											{
												object obj29 = array + 56;
												obj29 = obj26;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
												object format2 = "Error reading data from socket: " + 2392;
												string text2 = string.Format((string)format2, array);
												object obj30 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
												object obj31 = obj30;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X8_v39+E4]");
												bool flag23 = (nint)0 == 0;
												object obj32 = !flag23;
												object obj33 = text2;
												if (obj32 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
													obj33 = text2;
												}
												KLogger.Log(obj33);
												object obj34 = typeof(UsageHint) + 1640;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
												WaitForSeconds waitForSeconds2 = default(WaitForSeconds);
												waitForSeconds2..ctor(3f);
												object obj6 = this + 24;
												obj6 = waitForSeconds2;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
												object obj7 = 2;
												goto IL_0a3d;
											}
										}
									}
								}
								goto IL_098e;
							}
						}
					}
				}
			}
			NullReferenceException ex5 = new NullReferenceException();
			goto IL_098e;
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
			object obj2 = (nint)0 + (nint)2672;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}
	}

	private const string FCM_TOKEN_KEY = "FCMToken";

	private const string FCM_TOKEN_LAST_SYNC_KEY = "FCMTokenLastSync";

	private const int GET_TOKEN_MAX_ATTEMPTS = 5;

	private const float GET_TOKEN_RETRY_DELAY_SECONDS = 3f;

	private const int TOKEN_SYNC_INTERVAL_DAYS = 7;

	private static INotificationPermissionChecker Checker;

	public static string FcmToken
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			//IL_001b: Expected O, but got I
			object key = "Error reading data from socket: " + 2424;
			object defaultValue = (nint)0 + (nint)2000;
			return Prefs.GetString((string)key, (string)defaultValue);
		}
		private set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "Error reading data from socket: " + 2424;
			Prefs.SetString((string)key, value);
		}
	}

	private static DateTime LastTokenSync
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Expected O, but got Unknown
			//IL_0069: Expected O, but got I4
			//IL_0087: Expected O, but got I
			//IL_009c: Expected O, but got I
			object obj = typeof(DataRelation) + 712;
			object key = "Error reading data from socket: " + 2432;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v4+10]");
			return Prefs.GetDate((string)key, (DateTime)0);
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object key = "Error reading data from socket: " + 2432;
			Prefs.SetDate((string)key, value);
		}
	}

	public static void Initialize()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0045: Expected O, but got I
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_007e: Expected O, but got I
		//IL_00b9: Expected O, but got I
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected O, but got Unknown
		//IL_0170: Expected O, but got I4
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 384;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2688;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj3 = default(object);
		obj3..ctor();
		object obj4 = obj2;
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v4+B8]");
		object obj7 = 0;
		object obj8 = obj7;
		object obj9 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 4056;
		object obj10 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v8+12E]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v8+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00fa;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v8+B0]");
		object obj12 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X10_v6-8]");
			if (0 == (nint)obj9)
			{
				break;
			}
			obj12 += 16;
			obj11--;
			if ((nint)obj11 != 1)
			{
				continue;
			}
			goto IL_00fa;
		}
		object obj13 = obj10 + obj12;
		object obj14 = obj13 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v209 @ X0_v13] (should have been resolved before IL gen)");
		object obj15 = default(object);
		bool flag = obj15 == null;
		object obj16 = !flag;
		if (obj16 == null)
		{
			return;
		}
		goto IL_012b;
		IL_00fa:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v109 @ X0_v10] (should have been resolved before IL gen)");
		if (obj15 != null)
		{
			goto IL_012b;
		}
		return;
		IL_012b:
		InitializeNotifications();
	}

	public static bool IsGranted()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0120: Expected O, but got I
		//IL_0108: Expected I4, but got O
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0045: Expected O, but got I
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_0080: Expected O, but got I
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		object obj = typeof(MemberAchievementClanFeedData) + 2688;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v3+B8]");
		object obj3 = 0;
		object obj4 = obj3;
		object obj6;
		object obj8 = default(object);
		if (obj3 != null)
		{
			object obj5 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 4056;
			obj6 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v7+12E]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v7+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00c1;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v7+B0]");
			obj8 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X10_v4-8]");
				if (0 == (nint)obj5)
				{
					break;
				}
				obj8 += 16;
				obj7--;
				if ((nint)obj7 != 1)
				{
					continue;
				}
				goto IL_00c1;
			}
			goto IL_00d5;
		}
		goto IL_00fa;
		IL_00fa:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_00c1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v92 @ X0_v4] (should have been resolved before IL gen)");
		goto IL_00d5;
		IL_00d5:
		object obj9 = obj6 + obj8;
		object obj10 = obj9 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v153 @ X0_v6] (should have been resolved before IL gen)");
		goto IL_00fa;
	}

	public static void RequestPermission()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0047: Expected O, but got I
		//IL_0208: Expected O, but got I
		//IL_023a: Expected O, but got I4
		//IL_00d1: Expected O, but got I
		//IL_00e1: Expected O, but got I
		//IL_007c: Expected O, but got I
		//IL_02ec: Expected O, but got I4
		//IL_027a: Expected O, but got I
		//IL_028a: Expected O, but got I
		//IL_02ac: Expected O, but got I4
		//IL_03df: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Expected O, but got Unknown
		//IL_03fa: Expected O, but got I
		//IL_040b: Expected I, but got O
		//IL_0429: Expected O, but got I
		//IL_033b: Expected O, but got I4
		//IL_031c: Expected O, but got I
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected O, but got Unknown
		//IL_015f: Expected O, but got I
		//IL_03c6: Expected O, but got I
		//IL_019a: Expected O, but got I
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Expected O, but got Unknown
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_0385: Expected O, but got Unknown
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected O, but got Unknown
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected O, but got Unknown
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2688;
		object obj3 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1120;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E86F7]");
		object obj4 = (nint)0 & (nint)1;
		object obj7;
		object obj10;
		object obj8;
		if (obj4 != null)
		{
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X8_v28+B8]");
			object obj6 = 0;
			obj7 = obj6;
			obj8 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v7+E4]");
			bool flag = (nint)0 == 0;
			object obj9 = obj8;
			obj10 = obj6;
			if (!flag)
			{
				goto IL_00c1;
			}
		}
		else
		{
			_ = 1;
			object obj11 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X8_v18+B8]");
			object obj12 = 0;
			obj7 = obj12;
			obj8 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj13 = !flag2;
			object obj9 = obj8;
			obj10 = obj12;
			if (obj13 != null)
			{
				goto IL_00c1;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v7+B8]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v3+8]");
		Action<bool> action = (Action<bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v3+8]");
		bool flag3 = (nint)0 == 0;
		object obj15 = !flag3;
		obj7 = obj10;
		object obj16 = obj14;
		if (obj15 != null)
		{
			goto IL_0116;
		}
		goto IL_02ca;
		IL_03d0:
		object obj17 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj18 = (nint)0 + (nint)2648;
		Action<bool> action2 = default(Action<bool>);
		action2..ctor(obj16, (IntPtr)obj18);
		obj14 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v3+B8]");
		object obj19 = (nint)0 + (nint)8;
		obj19 = action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool flag4 = obj10 == null;
		object obj20 = !flag4;
		obj7 = obj10;
		if (obj20 != null)
		{
			goto IL_0133;
		}
		goto IL_0351;
		IL_03ae:
		object obj22 = default(object);
		object obj21 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X0_v1+8]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v248 @ X3_v2 (should have been resolved before IL gen)");
		goto IL_03d0;
		IL_01db:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_03ae;
		IL_00c1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v7+B8]");
		obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v3+8]");
		action = (Action<bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v3+8]");
		bool flag5 = (nint)0 == 0;
		obj16 = obj14;
		obj10 = obj7;
		if (!flag5)
		{
			goto IL_0116;
		}
		goto IL_02ca;
		IL_02ca:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v7+E4]");
		bool flag6 = (nint)0 == 0;
		object obj24 = !flag6;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj25 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v13+B8]");
			obj16 = 0;
		}
		goto IL_03d0;
		IL_0351:
		throw new NullReferenceException();
		IL_0116:
		if (obj7 != null)
		{
			goto IL_0133;
		}
		goto IL_0351;
		IL_0133:
		object obj26 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 4056;
		obj14 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v3+12E]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v3+12E]");
		if ((nint)0 == 0)
		{
			goto IL_01db;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v3+B0]");
		object obj28 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X10_v2-8]");
			if (0 == (nint)obj26)
			{
				break;
			}
			obj28 += 16;
			obj27--;
			if ((nint)obj27 != 1)
			{
				continue;
			}
			goto IL_01db;
		}
		object obj29 = obj28 + 1;
		object obj30 = obj14 + obj29;
		obj22 = obj30 + 312;
		goto IL_03ae;
	}

	private static void InitializeNotifications()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00cf: Expected O, but got I4
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected O, but got Unknown
		//IL_010f: Expected O, but got I4
		//IL_01b7: Expected O, but got I4
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected O, but got Unknown
		//IL_0203: Expected O, but got I4
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Expected O, but got Unknown
		//IL_031d: Expected O, but got I
		//IL_032d: Expected O, but got I
		//IL_034f: Expected O, but got I4
		//IL_027a: Expected O, but got I
		//IL_028a: Expected O, but got I
		//IL_037f: Expected O, but got I4
		//IL_02f0: Expected O, but got I
		//IL_0422: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Expected O, but got Unknown
		//IL_043d: Expected O, but got I
		//IL_044e: Expected I, but got O
		//IL_046c: Expected O, but got I
		//IL_03de: Expected O, but got I4
		//IL_03af: Expected O, but got I
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E86F8]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v33+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v33+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool noPlayServices = KUtil.NoPlayServices;
		bool flag2 = !noPlayServices;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			goto IL_011d;
		}
		return;
		IL_02e4:
		object obj6 = (nint)0 + (nint)3400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9FD04");
		return;
		IL_03fc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Action<object> action2;
		Action<object> action = action2;
		goto IL_02e4;
		IL_02af:
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X0_v10+E4]");
		bool flag3 = (nint)0 == 0;
		action2 = action;
		if (!flag3)
		{
			goto IL_02e4;
		}
		goto IL_03fc;
		IL_0074:
		if (KUtil.NoPlayServices)
		{
			return;
		}
		goto IL_011d;
		IL_011d:
		object obj8 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v3+E4]");
		if ((nint)0 != 0)
		{
			if (Application.isEditor)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool isEditor = Application.isEditor;
			bool flag4 = !isEditor;
			object obj10 = !flag4;
			if (obj10 != null)
			{
				return;
			}
		}
		object obj11 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 736;
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X0_v5+E4]");
		bool flag5 = (nint)0 == 0;
		object obj13 = !flag5;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Task<DependencyStatus> task = FirebaseApp.CheckAndFixDependenciesAsync();
		object obj14 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1120;
		object obj15 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v12+E4]");
		object obj16;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v12+B8]");
			obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v13+10]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v13+10]");
			if ((nint)0 != 0)
			{
				goto IL_02af;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj15 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v12+B8]");
			obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v13+10]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v13+10]");
			bool flag6 = (nint)0 == 0;
			object obj17 = !flag6;
			if (obj17 != null)
			{
				goto IL_02af;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v12+E4]");
		bool flag7 = (nint)0 == 0;
		object obj18 = !flag7;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj19 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v20+B8]");
			obj16 = 0;
		}
		object obj20 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 912;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj21 = (nint)0 + (nint)2640;
		Action<object> action3 = default(Action<object>);
		action3..ctor(obj16, (IntPtr)obj21);
		object obj22 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v18+B8]");
		object obj23 = (nint)0 + (nint)16;
		obj23 = action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X0_v10+E4]");
		bool flag8 = (nint)0 == 0;
		object obj24 = !flag8;
		action = action3;
		action2 = action3;
		if (obj24 != null)
		{
			goto IL_02e4;
		}
		goto IL_03fc;
	}

	private static IEnumerator TryGetTokenWithRetry()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1136;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		return (IEnumerator)obj2;
	}

	private static void OnTokenReceived(object sender, TokenReceivedEventArgs token)
	{
		HandleNewToken(token.<Token>k__BackingField);
	}

	private static void OnUserLoggedIn(BaseEvent evt)
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_00a8: Expected O, but got I
		//IL_0066: Expected O, but got I4
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		object key = "Error reading data from socket: " + 2424;
		object defaultValue = (nint)0 + (nint)2000;
		string value = Prefs.GetString((string)key, (string)defaultValue);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v5+E4]");
		if ((nint)0 != 0)
		{
			if (StringsExtensions.IsNullOrEmpty(value))
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag = StringsExtensions.IsNullOrEmpty(value);
			bool flag2 = !flag;
			object obj3 = !flag2;
			if (obj3 != null)
			{
				return;
			}
		}
		string newToken = Prefs.GetString((string)key, (string)defaultValue);
		HandleNewToken(newToken);
	}

	private static void HandleNewToken(string newToken)
	{
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected O, but got Unknown
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected O, but got Unknown
		//IL_0228: Expected O, but got I
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected O, but got Unknown
		//IL_010b: Expected O, but got I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_007a: Expected O, but got I4
		//IL_0083: Expected O, but got I4
		//IL_008c: Expected O, but got I4
		//IL_025d: Expected O, but got I4
		//IL_0287: Expected O, but got I4
		//IL_0290: Expected O, but got I4
		//IL_02a1: Expected O, but got I4
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Expected O, but got Unknown
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Expected O, but got Unknown
		//IL_0314: Expected O, but got I4
		//IL_00a3: Expected O, but got I4
		//IL_00ac: Expected O, but got I4
		//IL_0370: Expected O, but got I
		//IL_0385: Expected O, but got I
		//IL_03c4: Expected O, but got I4
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected O, but got Unknown
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected O, but got Unknown
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		object key = "Error reading data from socket: " + 2424;
		object defaultValue = (nint)0 + (nint)2000;
		string value = Prefs.GetString((string)key, (string)defaultValue);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v5+E4]");
		object obj3;
		object obj4;
		string text;
		if ((nint)0 != 0)
		{
			obj3 = typeof(DataRelation) + 712;
			bool flag = StringsExtensions.IsNullOrEmpty(value);
			bool flag2 = !flag;
			text = null;
			obj4 = obj3;
			if (!flag2)
			{
				goto IL_0050;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = typeof(DataRelation) + 712;
			bool flag3 = StringsExtensions.IsNullOrEmpty(value);
			bool flag4 = !flag3;
			object obj5 = !flag4;
			text = null;
			obj4 = obj3;
			if (obj5 != null)
			{
				goto IL_0050;
			}
		}
		string text2 = Prefs.GetString((string)key, (string)defaultValue);
		bool flag5 = text2 == newToken;
		object obj6 = (flag5 ? 1 : 0) ^ 1;
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v32+E4]");
		bool flag6 = (nint)0 == 0;
		object obj8 = !flag6;
		object obj9 = 0;
		string text3 = newToken;
		object obj10 = 0;
		object obj11 = obj6;
		text = newToken;
		obj3 = obj4;
		if (obj8 == null)
		{
			goto IL_012b;
		}
		goto IL_015a;
		IL_012b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj10 = obj9;
		obj11 = obj6;
		text = text3;
		obj3 = obj4;
		goto IL_015a;
		IL_015a:
		DateTime now = DateTime.Now;
		object obj12 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
		object key2 = "Error reading data from socket: " + 2432;
		object obj13 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X0_v10+E4]");
		bool flag7 = (nint)0 == 0;
		object obj14 = !flag7;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj13 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X0_v10+B8]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v10+10]");
		DateTime date = Prefs.GetDate((string)key2, (DateTime)0);
		TimeSpan timeSpan = now - date;
		object obj16 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X0_v15+E4]");
		bool flag8 = (nint)0 == 0;
		object obj17 = !flag8;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		TimeSpan timeSpan2 = TimeSpan.FromDays(4.000000000698492);
		bool flag9 = timeSpan >= timeSpan2;
		object obj18 = obj11 | flag9;
		object obj19 = obj18 & 1;
		if (obj19 != null)
		{
			RegisterToken(newToken);
		}
		return;
		IL_0050:
		obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v32+E4]");
		bool flag10 = (nint)0 == 0;
		object obj20 = !flag10;
		obj10 = 0;
		obj11 = 1;
		if (obj20 == null)
		{
			obj9 = 0;
			obj6 = 1;
			text3 = text;
			obj4 = obj3;
			goto IL_012b;
		}
		goto IL_015a;
	}

	private static void RegisterToken(string token)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0083: Expected O, but got I4
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_0129: Expected O, but got I
		//IL_013a: Expected I, but got O
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected O, but got Unknown
		//IL_017d: Expected O, but got I4
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		//IL_00f9: Expected O, but got I
		//IL_01dc: Expected I, but got O
		//IL_01f1: Expected O, but got I
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1128;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(Queue<string>) + 848;
		object obj4 = (nint)0 + (nint)2200;
		object obj5 = obj2 + 16;
		obj5 = token;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v9+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		if (localUser != null)
		{
			object obj8 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
			object obj9 = (nint)0 + (nint)2656;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action<object> action = default(Action<object>);
			action..ctor(obj2, (IntPtr)obj9);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3 (System.Object)+10]");
			KammelnaRequests.RegisterFirebaseNotifications((string)0, action);
			return;
		}
		object obj10 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj11 = (nint)0 + (nint)2664;
		Action action2 = default(Action);
		action2..ctor(obj2, (IntPtr)obj11);
		object obj12 = typeof(RegisteredWaitHandle) + 3136;
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X0_v16+E4]");
		bool flag2 = (nint)0 == 0;
		object obj14 = !flag2;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ScreenManager.WaitForScene(Scenes.Menu, action2);
	}

	private static void OnMessageReceived(object sender, MessageReceivedEventArgs e)
	{
		//IL_0015: Expected O, but got I
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_00ad: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ stack_-38_v2 (Util.NotificationPermissionUtils+<>c__DisplayClass21_0)+10]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v4+18]");
		<>c__DisplayClass21_0 e2 = default(<>c__DisplayClass21_0);
		if ((nint)0 != 0)
		{
			object obj2 = typeof(RegisteredWaitHandle) + 1560;
			object obj3 = typeof(RegisteredWaitHandle) + 1552;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			RoutingParams routingParams = default(RoutingParams);
			routingParams..ctor((MessageReceivedEventArgs)e2);
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v9+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			RoutingManager.Route(routingParams);
		}
		<OnMessageReceived>g__TrackNotificationOpened|21_0(ref e2);
	}

	internal static void <OnMessageReceived>g__TrackNotificationOpened|21_0(ref <>c__DisplayClass21_0 P_0)
	{
		//IL_0015: Expected O, but got I
		//IL_003c: Expected O, but got I4
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		//IL_006c: Expected O, but got I4
		object obj = P_0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v3+10]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v5+58]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v5+50]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v5+58]");
		ITrackEvent trackEvent = TrackerLibrary.PushNotificationOpened(isNotificationClicked: false);
		object obj5 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v9+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
	}
}
