using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Libraries.Utils;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.Networking;
using UnityEngine.TextCore;

namespace Kammelna.Server.WebRequests;

public class BackoffRequestDecorator<TResponse> : WebRequestDecorator<TResponse>
{
	private sealed class <Execute>d__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public BackoffRequestDecorator<TResponse> <>4__this;

		private int <attempt>5__2;

		private IEnumerator <enumerator>5__3;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <Execute>d__3(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_00ba: Expected I4, but got I8
			//IL_0504: Expected I4, but got O
			//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fa: Expected O, but got Unknown
			//IL_0103: Expected O, but got I4
			//IL_0123: Expected O, but got I
			//IL_00a6: Expected I4, but got I8
			//IL_0539: Unknown result type (might be due to invalid IL or missing references)
			//IL_053e: Expected O, but got Unknown
			//IL_0040: Expected O, but got I4
			//IL_0165: Unknown result type (might be due to invalid IL or missing references)
			//IL_016a: Expected O, but got Unknown
			//IL_0172: Expected I, but got O
			//IL_0182: Expected O, but got I
			//IL_005d: Expected I4, but got I8
			//IL_0084: Expected O, but got I4
			//IL_021b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0220: Expected O, but got Unknown
			//IL_0238: Expected O, but got I4
			//IL_01bd: Expected O, but got I
			//IL_0323: Unknown result type (might be due to invalid IL or missing references)
			//IL_0328: Expected O, but got Unknown
			//IL_0331: Unknown result type (might be due to invalid IL or missing references)
			//IL_0336: Expected O, but got Unknown
			//IL_0349: Unknown result type (might be due to invalid IL or missing references)
			//IL_034e: Expected O, but got Unknown
			//IL_0368: Expected O, but got I4
			//IL_0277: Expected I, but got O
			//IL_0287: Expected O, but got I
			//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d0: Expected O, but got Unknown
			//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01de: Expected O, but got Unknown
			//IL_0316: Expected O, but got I4
			//IL_05b0: Expected O, but got I4
			//IL_02c2: Expected O, but got I
			//IL_05c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_05c8: Expected O, but got Unknown
			//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d6: Expected O, but got Unknown
			//IL_04de: Unknown result type (might be due to invalid IL or missing references)
			//IL_04e3: Expected O, but got Unknown
			//IL_04ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f1: Expected O, but got Unknown
			//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d5: Expected O, but got Unknown
			//IL_02de: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e3: Expected O, but got Unknown
			//IL_0445: Unknown result type (might be due to invalid IL or missing references)
			//IL_044a: Expected O, but got Unknown
			//IL_0482: Unknown result type (might be due to invalid IL or missing references)
			//IL_0487: Expected O, but got Unknown
			//IL_04ac: Expected O, but got I4
			//IL_04b5: Expected O, but got I4
			if (<>1__state != 2)
			{
				if (<>1__state == 1)
				{
					<>1__state = -1;
					goto IL_012d;
				}
				bool flag = <>1__state == 0;
				object obj = !flag;
				if (obj != null)
				{
					goto IL_04c2;
				}
				<>1__state = -1;
				<attempt>5__2 = 0;
				bool flag2 = <>4__this == null;
				object obj2 = !flag2;
				if (obj2 == null)
				{
					goto IL_04f6;
				}
			}
			else
			{
				<>1__state = -1;
				if (<>4__this == null)
				{
					goto IL_04f6;
				}
				<>4__this.Dispose();
				<>4__this.Setup();
				object obj3 = this + 48;
				obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X22_v11-8]");
				object obj4 = (nint)0 + (nint)1;
			}
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3E13AF0");
			object obj5 = this + 48;
			object obj6 = default(object);
			obj5 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			goto IL_012d;
			IL_0303:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj7 = 1;
			goto IL_059d;
			IL_059d:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v471 @ X0_v28] (should have been resolved before IL gen)");
			object obj8 = 1;
			WaitForSeconds waitForSeconds2 = default(WaitForSeconds);
			WaitForSeconds waitForSeconds = waitForSeconds2;
			goto IL_05bd;
			IL_04c2:
			return false;
			IL_01fe:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v356 @ X0_v35] (should have been resolved before IL gen)");
			object obj10 = default(object);
			object obj9 = obj10 & 1;
			bool flag3 = obj9 == null;
			obj7 = 0;
			if (!flag3)
			{
				goto IL_0246;
			}
			goto IL_0376;
			IL_05bd:
			object obj11 = this + 24;
			obj11 = waitForSeconds;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return true;
			IL_0376:
			if (<>4__this != null)
			{
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @424F2AC");
				UnityWebRequest unityWebRequest = default(UnityWebRequest);
				if (unityWebRequest != null)
				{
					long responseCode = unityWebRequest.responseCode;
					if (responseCode != 429 || <attempt>5__2 > 2)
					{
						goto IL_04c2;
					}
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @424F2AC");
					UnityWebRequest unityWebRequest2 = default(UnityWebRequest);
					if (unityWebRequest2 != null)
					{
						object name = "Read object reference Id '{0}' for {1}." + 3016;
						string responseHeader = unityWebRequest2.GetResponseHeader((string)name);
						float seconds = Backoff.ResolveDelay(<attempt>5__2, responseHeader);
						object obj12 = typeof(UsageHint) + 1640;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						WaitForSeconds waitForSeconds3 = default(WaitForSeconds);
						waitForSeconds3..ctor(seconds);
						obj7 = 0;
						obj8 = 2;
						waitForSeconds = waitForSeconds3;
						goto IL_05bd;
					}
				}
			}
			goto IL_04f6;
			IL_04f6:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_012d:
			IEnumerator enumerator = <enumerator>5__3;
			object obj13;
			if (<enumerator>5__3 != null)
			{
				obj13 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
				nint num4 = (nint)enumerator;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X8_v10 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X8_v10 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_01fe;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X8_v10 (Il2CppClass<System.Collections.IEnumerator>)+B0]");
				object obj15 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ X10_v15-8]");
					if (0 == (nint)obj13)
					{
						break;
					}
					obj15 += 16;
					obj14--;
					if ((nint)obj14 != 1)
					{
						continue;
					}
					goto IL_01fe;
				}
				object obj16 = num4 + obj15;
				object obj17 = obj16 + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v387 @ X0_v38] (should have been resolved before IL gen)");
				object obj19 = default(object);
				object obj18 = obj19 & 1;
				bool flag4 = obj18 == null;
				object obj20 = !flag4;
				if (obj20 != null)
				{
					goto IL_0246;
				}
				goto IL_0376;
			}
			goto IL_04f6;
			IL_0246:
			IEnumerator enumerator2 = <enumerator>5__3;
			if (<enumerator>5__3 == null)
			{
				goto IL_04f6;
			}
			nint num5 = (nint)enumerator2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X8_v22 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X8_v22 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0303;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X8_v22 (Il2CppClass<System.Collections.IEnumerator>)+B0]");
			object obj22 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X10_v10-8]");
				if (0 == (nint)obj13)
				{
					break;
				}
				obj22 += 16;
				obj21--;
				if ((nint)obj21 != 1)
				{
					continue;
				}
				goto IL_0303;
			}
			object obj23 = obj22 + 1;
			object obj24 = num5 + obj23;
			object obj25 = obj24 + 312;
			goto IL_059d;
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
			object obj = typeof(MemberAchievementClanFeedData) + 2648;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			NotSupportedException ex = default(NotSupportedException);
			ex..ctor();
			throw new OutOfMemoryException();
		}
	}

	private const string RETRY_AFTER_HEADER = "Retry-After";

	private const int MAX_ATTEMPTS = 3;

	public BackoffRequestDecorator(IWebRequest<TResponse> request)
	{
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @424F4BC");
	}

	public override IEnumerator Execute()
	{
		//IL_0016: Expected O, but got I
		//IL_002c: Expected O, but got I
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0054: Expected O, but got I4
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ X8_v2 (Il2CppRgctx<Kammelna.Server.WebRequests.BackoffRequestDecorator`1>)+18]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ X8_v2 (Il2CppRgctx<Kammelna.Server.WebRequests.BackoffRequestDecorator`1>)+18]");
		object obj2 = (nint)0 + (nint)309;
		object obj3 = obj2 & 1;
		bool flag = obj3 == null;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @449AAA4");
		IEnumerator enumerator = default(IEnumerator);
		if (enumerator != null)
		{
			object obj5 = enumerator + 32;
			obj5 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return enumerator;
		}
		return (IEnumerator)new NullReferenceException();
	}

	private IEnumerator <>n__0()
	{
		if (this != null)
		{
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @424F59C");
			IEnumerator result = default(IEnumerator);
			return result;
		}
		return (IEnumerator)new NullReferenceException();
	}
}
