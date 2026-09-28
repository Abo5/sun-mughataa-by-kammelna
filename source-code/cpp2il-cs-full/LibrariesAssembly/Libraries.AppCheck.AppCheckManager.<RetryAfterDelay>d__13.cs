using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using GoogleMobileAds.Api.AdManager;
using Kammelna.Server.Models.Clans;
using Libraries.Utils;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.TextCore;

namespace Libraries.AppCheck;

public class AppCheckManager : MonoBehaviour
{
	private sealed class <>c__DisplayClass12_0
	{
		public int attempt;

		public AppCheckManager <>4__this;

		public string userKey;

		public string requestHash;

		public Action <>9__1;

		internal void <RequestToken>b__0(AppIntegrityRequestModel model)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Expected O, but got Unknown
			//IL_020e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0213: Expected O, but got Unknown
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_008e: Expected O, but got Unknown
			//IL_0245: Expected O, but got I
			//IL_0260: Expected I, but got O
			//IL_01ab: Expected O, but got I
			//IL_01ca: Expected O, but got I4
			//IL_00cc: Expected O, but got I
			//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0103: Expected O, but got Unknown
			//IL_0125: Expected O, but got I4
			//IL_0149: Expected O, but got I
			//IL_0157: Expected I, but got O
			object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1424;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = typeof(SqlSingle[]) + 2376;
			object obj4 = obj2 + 24;
			obj4 = model;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			if (attempt <= 1)
			{
				object obj5 = obj4;
				object obj6 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 56;
				object obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X0_v17+E4]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v8+38]");
					if (AppCheckErrors.IsRetryable((string)0))
					{
						goto IL_00e9;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v8+38]");
					bool flag = AppCheckErrors.IsRetryable((string)0);
					bool flag2 = !flag;
					object obj8 = !flag2;
					if (obj8 != null)
					{
						goto IL_00e9;
					}
				}
			}
			AppCheckManager appCheckManager = <>4__this;
			AppCheckResult[] array = appCheckManager._coalescer.Complete(userKey, requestHash);
			object obj9 = obj2 + 16;
			obj9 = array;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			AppCheckManager appCheckManager2 = <>4__this;
			object obj10 = (nint)0 + (nint)3840;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action action = default(Action);
			action..ctor(obj2, (IntPtr)obj10);
			((ConcurrentQueue<object>)(object)appCheckManager2.mainThreadCallBackQueue).Enqueue((object)action);
			return;
			IL_00e9:
			AppCheckManager appCheckManager3 = <>4__this;
			object obj11 = this + 48;
			Action item = (Action)obj11;
			bool flag3 = obj11 == null;
			object obj12 = !flag3;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj13 = (nint)0 + (nint)3832;
				Action action2 = default(Action);
				action2..ctor(this, (IntPtr)obj13);
				<>9__1 = action2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				item = action2;
			}
			((ConcurrentQueue<object>)(object)appCheckManager3.mainThreadCallBackQueue).Enqueue((object)item);
		}

		internal void <RequestToken>b__1()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_009f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a4: Expected O, but got Unknown
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected O, but got Unknown
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Expected O, but got Unknown
			object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1432;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			_ = 0;
			object obj3 = obj2 + 40;
			obj3 = <>4__this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj4 = obj2 + 48;
			obj4 = userKey;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj5 = obj2 + 56;
			obj5 = requestHash;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = attempt;
			Coroutine coroutine = <>4__this.StartCoroutine((IEnumerator)obj2);
		}
	}

	private sealed class <>c__DisplayClass12_1
	{
		public AppCheckResult[] waiters;

		public AppIntegrityRequestModel model;

		internal void <RequestToken>b__2()
		{
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Expected O, but got Unknown
			//IL_0045: Expected O, but got I4
			//IL_0091: Expected O, but got I
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Expected O, but got Unknown
			AppCheckResult[] array = waiters;
			if (array.Length >= 1)
			{
				object obj = array + 32;
				object obj2 = 0;
				do
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X22_v4+v43 @ X21_v5*8]");
					object obj3 = 0;
					obj2++;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v75 @ X8_v5+18] (should have been resolved before IL gen)");
				}
				while ((nint)obj2 < array.Length);
			}
		}
	}

	private sealed class <RetryAfterDelay>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public int attempt;

		public AppCheckManager <>4__this;

		public string userKey;

		public string requestHash;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <RetryAfterDelay>d__13(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0094: Expected I4, but got I8
			//IL_0191: Unknown result type (might be due to invalid IL or missing references)
			//IL_0196: Expected O, but got Unknown
			//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b8: Expected O, but got Unknown
			//IL_0036: Expected I4, but got I8
			//IL_014d: Expected I4, but got O
			if (<>1__state != 0)
			{
				if (<>1__state == 1)
				{
					<>1__state = -1;
					if ((object)<>4__this == null)
					{
						NullReferenceException ex = new NullReferenceException();
						return (byte)(int)ex != 0;
					}
					int num = attempt + 1;
					<>4__this.RequestToken(userKey, requestHash, num);
				}
			}
			else
			{
				<>1__state = -1;
				float num4 = default(float);
				if (Backoff.TryParseRetryAfter(null, out var seconds))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMINNM not yet implemented.\"");
					double num2 = 30.0;
					float num3 = seconds;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB16B4");
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMINNM not yet implemented.\"");
					float num3 = UnityEngine.Random.Range(0.5f, 1.5f);
					num4 *= num3;
					double num2 = 1.5;
				}
				object obj = typeof(UsageHint) + 1640;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				WaitForSeconds waitForSeconds = default(WaitForSeconds);
				waitForSeconds..ctor(num4);
				object obj2 = this + 24;
				obj2 = waitForSeconds;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				_ = 1;
			}
			return <>1__state == 0;
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
			object obj2 = (nint)0 + (nint)3848;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}
	}

	private const int MAX_ATTEMPTS = 3;

	private static AppCheckManager _instance;

	private IAppChecker _appChecker;

	private readonly TokenRequestCoalescer _coalescer;

	private readonly ConcurrentQueue<Action> mainThreadCallBackQueue;

	public static bool IsSupported
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0163: Expected O, but got I
			//IL_014b: Expected I4, but got O
			//IL_0029: Expected O, but got I
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Expected O, but got Unknown
			//IL_007a: Expected O, but got I
			//IL_0113: Unknown result type (might be due to invalid IL or missing references)
			//IL_0118: Expected O, but got Unknown
			//IL_012e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0133: Expected O, but got Unknown
			//IL_00b5: Expected O, but got I
			//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c8: Expected O, but got Unknown
			//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d6: Expected O, but got Unknown
			object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 64;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v3+B8]");
			object obj3 = 0;
			object obj4 = obj3;
			object obj7;
			object obj9 = default(object);
			if (obj3 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5+20]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5+20]");
				if ((nint)0 != 0)
				{
					object obj6 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 824;
					obj7 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v8+12E]");
					object obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v8+12E]");
					if ((nint)0 == 0)
					{
						goto IL_00f6;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v8+B0]");
					obj9 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X10_v4-8]");
						if (0 == (nint)obj6)
						{
							break;
						}
						obj9 += 16;
						obj8--;
						if ((nint)obj8 != 1)
						{
							continue;
						}
						goto IL_00f6;
					}
					goto IL_010a;
				}
			}
			goto IL_013d;
			IL_010a:
			object obj10 = obj9 + 1;
			object obj11 = obj7 + obj10;
			object obj12 = obj11 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v158 @ X0_v6] (should have been resolved before IL gen)");
			goto IL_013d;
			IL_013d:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_00f6:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v96 @ X0_v4] (should have been resolved before IL gen)");
			goto IL_010a;
		}
	}

	public static bool RequireSignature
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0163: Expected O, but got I
			//IL_014b: Expected I4, but got O
			//IL_0029: Expected O, but got I
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Expected O, but got Unknown
			//IL_007a: Expected O, but got I
			//IL_0113: Unknown result type (might be due to invalid IL or missing references)
			//IL_0118: Expected O, but got Unknown
			//IL_012e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0133: Expected O, but got Unknown
			//IL_00b5: Expected O, but got I
			//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c8: Expected O, but got Unknown
			//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d6: Expected O, but got Unknown
			object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 64;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v3+B8]");
			object obj3 = 0;
			object obj4 = obj3;
			object obj7;
			object obj9 = default(object);
			if (obj3 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5+20]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5+20]");
				if ((nint)0 != 0)
				{
					object obj6 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 824;
					obj7 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v8+12E]");
					object obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v8+12E]");
					if ((nint)0 == 0)
					{
						goto IL_00f6;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v8+B0]");
					obj9 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X10_v4-8]");
						if (0 == (nint)obj6)
						{
							break;
						}
						obj9 += 16;
						obj8--;
						if ((nint)obj8 != 1)
						{
							continue;
						}
						goto IL_00f6;
					}
					goto IL_010a;
				}
			}
			goto IL_013d;
			IL_010a:
			object obj10 = obj9 + 2;
			object obj11 = obj7 + obj10;
			object obj12 = obj11 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v158 @ X0_v6] (should have been resolved before IL gen)");
			goto IL_013d;
			IL_013d:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_00f6:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v96 @ X0_v4] (should have been resolved before IL gen)");
			goto IL_010a;
		}
	}

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Expected O, but got Unknown
		//IL_02d2: Expected O, but got I4
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Expected O, but got Unknown
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Expected O, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_0069: Expected O, but got I
		//IL_00a4: Expected O, but got I
		//IL_013b: Expected O, but got I
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected O, but got Unknown
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected O, but got Unknown
		//IL_0230: Expected O, but got I4
		//IL_01d9: Expected O, but got I
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		//IL_0176: Expected O, but got I
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Expected O, but got Unknown
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected O, but got Unknown
		//IL_0280: Expected O, but got I
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected O, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj7 = default(object);
		object obj13 = default(object);
		object obj23 = default(object);
		object obj27 = default(object);
		object obj30 = default(object);
		while (true)
		{
			object obj2 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 64;
			GameObject gameObject = base.gameObject;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			UnityEngine.Object target = gameObject;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				target = gameObject;
			}
			UnityEngine.Object.DontDestroyOnLoad(target);
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj6 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 304;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			obj7..ctor();
			object obj8 = this + 32;
			obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj9 = obj8;
			object obj10 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 824;
			object obj11 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v8+12E]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v8+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00e5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v8+B0]");
			obj13 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X10_v12-8]");
				if (0 == (nint)obj10)
				{
					break;
				}
				obj13 += 16;
				obj12--;
				if ((nint)obj12 != 1)
				{
					continue;
				}
				goto IL_00e5;
			}
			goto IL_01e3;
			IL_0116:
			object obj14 = obj8;
			object obj15 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v11+12E]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v11+12E]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v11+B0]");
				object obj17 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X10_v7-8]");
					if (0 == (nint)obj10)
					{
						break;
					}
					obj17 += 16;
					obj16--;
					if ((nint)obj16 != 1)
					{
						continue;
					}
					goto IL_01b7;
				}
				object obj18 = obj17 + 3;
				object obj19 = obj15 + obj18;
				object obj20 = obj19 + 312;
				object obj21 = obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X0_v19+8]");
				object obj22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v218 @ X2_v6 (should have been resolved before IL gen)");
				continue;
			}
			goto IL_01b7;
			IL_00e5:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v176 @ X0_v22] (should have been resolved before IL gen)");
			if (obj23 != null)
			{
				goto IL_0116;
			}
			break;
			IL_01e3:
			object obj24 = obj13 + 1;
			object obj25 = obj11 + obj24;
			object obj26 = obj25 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v298 @ X0_v25] (should have been resolved before IL gen)");
			bool flag2 = obj27 == null;
			object obj28 = !flag2;
			if (obj28 == null)
			{
				break;
			}
			goto IL_0116;
			IL_01b7:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj29 = obj30;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X0_v17+8]");
			object obj31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v216 @ X2_v5 (should have been resolved before IL gen)");
			goto IL_01e3;
		}
	}

	public static void GetToken(string userKey, string requestHash, AppCheckResult callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00a0: Expected O, but got I
		//IL_0036: Expected O, but got I
		//IL_006b: Expected O, but got I
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 64;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v3+B8]");
		object obj3 = 0;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v5+28]");
		if (((TokenRequestCoalescer)0).Join(userKey, requestHash, callback))
		{
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v7+B8]");
			object obj6 = 0;
			((AppCheckManager)obj6).RequestToken(userKey, requestHash, 0);
		}
	}

	public static void Clear()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0165: Expected O, but got I
		//IL_0029: Expected O, but got I
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_005a: Expected O, but got I
		//IL_00f8: Expected O, but got I
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected O, but got Unknown
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected O, but got Unknown
		//IL_0143: Expected O, but got I
		//IL_0095: Expected O, but got I
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 64;
		object obj9 = default(object);
		object obj11 = default(object);
		while (true)
		{
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v3+B8]");
			object obj3 = 0;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5+20]");
			object obj5 = 0;
			object obj6 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 824;
			object obj7 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v8+12E]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v8+12E]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v8+B0]");
				obj9 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X10_v4-8]");
					if (0 == (nint)obj6)
					{
						break;
					}
					obj9 += 16;
					obj8--;
					if ((nint)obj8 != 1)
					{
						continue;
					}
					goto IL_00d6;
				}
				goto IL_0102;
			}
			goto IL_00d6;
			IL_00d6:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj10 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v4+8]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v102 @ X2_v2 (should have been resolved before IL gen)");
			goto IL_0102;
			IL_0102:
			object obj13 = obj9 + 5;
			object obj14 = obj7 + obj13;
			object obj15 = obj14 + 312;
			object obj16 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X0_v6+8]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v103 @ X2_v3 (should have been resolved before IL gen)");
		}
	}

	private void RequestToken(string userKey, string requestHash, int attempt)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_00da: Expected I, but got O
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_00fb: Expected I, but got O
		//IL_010b: Expected O, but got I
		//IL_0218: Expected O, but got I
		//IL_0146: Expected O, but got I
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected O, but got Unknown
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected O, but got Unknown
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected O, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected O, but got Unknown
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected O, but got Unknown
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1416;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 72;
		object obj4 = (nint)0 + (nint)3824;
		object obj5 = obj2 + 24;
		obj5 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj2 + 32;
		obj6 = userKey;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = obj2 + 40;
		obj7 = requestHash;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		IAppChecker appChecker = _appChecker;
		object obj8 = obj6;
		object obj9 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		AppCheckResult appCheckResult = default(AppCheckResult);
		appCheckResult..ctor(obj2, (IntPtr)obj4);
		object obj10 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 824;
		nint num = (nint)appChecker;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v5 (Il2CppClass<Libraries.AppCheck.IAppChecker>)+12E]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v5 (Il2CppClass<Libraries.AppCheck.IAppChecker>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0187;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v5 (Il2CppClass<Libraries.AppCheck.IAppChecker>)+B0]");
		object obj12 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X10_v5-8]");
			if (0 == (nint)obj10)
			{
				break;
			}
			obj12 += 16;
			obj11--;
			if ((nint)obj11 != 1)
			{
				continue;
			}
			goto IL_0187;
		}
		object obj13 = obj12 + 4;
		object obj14 = num + obj13;
		object obj15 = obj14 + 312;
		goto IL_0200;
		IL_0187:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0200;
		IL_0200:
		object obj16 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X0_v15+8]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v115 @ X5_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	private IEnumerator RetryAfterDelay(string userKey, string requestHash, int attempt)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1432;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		object obj3 = obj2 + 40;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 48;
		obj4 = userKey;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj2 + 56;
		obj5 = requestHash;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (IEnumerator)obj2;
	}

	private IAppChecker GetAppChecker()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		return (IAppChecker)obj2;
	}

	private void Update()
	{
		//IL_0011: Expected O, but got I
		if (mainThreadCallBackQueue != null)
		{
			object obj = (nint)0 + (nint)3160;
			if (!((ConcurrentQueue<object>)(object)mainThreadCallBackQueue).TryDequeue(out object result))
			{
				return;
			}
			if (result != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v45 @ stack_-28_v3 (System.Object)+18] (should have been resolved before IL gen)");
				return;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		NullReferenceException ex2 = new NullReferenceException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	public AppCheckManager()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1296;
		object obj2 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TokenRequestCoalescer tokenRequestCoalescer = default(TokenRequestCoalescer);
		tokenRequestCoalescer..ctor();
		object obj3 = this + 40;
		obj3 = tokenRequestCoalescer;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ConcurrentQueue<object> concurrentQueue = default(ConcurrentQueue<object>);
		concurrentQueue..ctor();
		object obj4 = this + 48;
		obj4 = concurrentQueue;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}
}
