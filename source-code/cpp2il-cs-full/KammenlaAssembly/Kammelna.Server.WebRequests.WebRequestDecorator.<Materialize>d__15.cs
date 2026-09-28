using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using UnityEngine.Networking;
using UnityEngine.TextCore;

namespace Kammelna.Server.WebRequests;

public abstract class WebRequestDecorator<TResponse> : IWebRequest<TResponse>, IDisposable
{
	private sealed class <Execute>d__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public WebRequestDecorator<TResponse> <>4__this;

		private IEnumerator <requestSteps>5__2;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <Execute>d__14(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_018d: Expected I4, but got I8
			//IL_0021: Expected O, but got I4
			//IL_044b: Expected I4, but got O
			//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fd: Expected O, but got Unknown
			//IL_0205: Expected I, but got O
			//IL_0215: Expected O, but got I
			//IL_0048: Expected I4, but got I8
			//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b3: Expected O, but got Unknown
			//IL_02cb: Expected O, but got I4
			//IL_0250: Expected O, but got I
			//IL_03b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_03bb: Expected O, but got Unknown
			//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c9: Expected O, but got Unknown
			//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e1: Expected O, but got Unknown
			//IL_03fb: Expected O, but got I4
			//IL_00ac: Expected O, but got I
			//IL_00c2: Expected O, but got I
			//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d0: Expected O, but got Unknown
			//IL_00ea: Expected O, but got I4
			//IL_030a: Expected I, but got O
			//IL_031a: Expected O, but got I
			//IL_025e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0263: Expected O, but got Unknown
			//IL_026c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0271: Expected O, but got Unknown
			//IL_0472: Expected I, but got O
			//IL_0482: Expected O, but got I
			//IL_03a9: Expected O, but got I4
			//IL_0179: Expected O, but got I4
			//IL_054f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0554: Expected O, but got Unknown
			//IL_0355: Expected O, but got I
			//IL_04db: Unknown result type (might be due to invalid IL or missing references)
			//IL_04e0: Expected O, but got Unknown
			//IL_0125: Expected O, but got I
			//IL_0418: Unknown result type (might be due to invalid IL or missing references)
			//IL_041d: Expected O, but got Unknown
			//IL_0425: Unknown result type (might be due to invalid IL or missing references)
			//IL_042a: Expected O, but got Unknown
			//IL_0433: Unknown result type (might be due to invalid IL or missing references)
			//IL_0438: Expected O, but got Unknown
			//IL_019b: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a0: Expected O, but got Unknown
			//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ad: Expected O, but got Unknown
			//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bb: Expected O, but got Unknown
			//IL_0363: Unknown result type (might be due to invalid IL or missing references)
			//IL_0368: Expected O, but got Unknown
			//IL_0371: Unknown result type (might be due to invalid IL or missing references)
			//IL_0376: Expected O, but got Unknown
			//IL_0133: Unknown result type (might be due to invalid IL or missing references)
			//IL_0138: Expected O, but got Unknown
			//IL_0141: Unknown result type (might be due to invalid IL or missing references)
			//IL_0146: Expected O, but got Unknown
			if (<>1__state != 1)
			{
				bool flag = <>1__state == 0;
				object obj = !flag;
				if (obj != null)
				{
					goto IL_0409;
				}
				WebRequestDecorator<TResponse> webRequestDecorator = <>4__this;
				<>1__state = -1;
				if (<>4__this != null)
				{
					IWebRequest<TResponse> <Request>k__BackingField = webRequestDecorator.<Request>k__BackingField;
					if (webRequestDecorator.<Request>k__BackingField != null)
					{
						nint num = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v19 (Il2CppRgctx<Kammelna.Server.WebRequests.WebRequestDecorator`1+<Execute>d__14>)+18]");
						object obj2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v19 (Il2CppRgctx<Kammelna.Server.WebRequests.WebRequestDecorator`1+<Execute>d__14>)+18]");
						object obj3 = (nint)0 + (nint)309;
						object obj4 = obj3 & 1;
						bool flag2 = obj4 == null;
						object obj5 = !flag2;
						if (obj5 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
							object obj6 = default(object);
							obj2 = obj6;
						}
						nint num2 = (nint)<Request>k__BackingField;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v22 (Il2CppClass<Kammelna.Server.WebRequests.IWebRequest`1<TResponse>>)+12E]");
						object obj7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v22 (Il2CppClass<Kammelna.Server.WebRequests.IWebRequest`1<TResponse>>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_0166;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v22 (Il2CppClass<Kammelna.Server.WebRequests.IWebRequest`1<TResponse>>)+B0]");
						object obj8 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X10_v20-8]");
							if (0 == (nint)obj2)
							{
								break;
							}
							obj8 += 16;
							obj7--;
							if ((nint)obj7 != 1)
							{
								continue;
							}
							goto IL_0166;
						}
						object obj9 = obj8 + 6;
						object obj10 = num2 + obj9;
						object obj11 = obj10 + 312;
						goto IL_04cb;
					}
				}
				goto IL_043d;
			}
			<>1__state = -1;
			goto IL_01c0;
			IL_053f:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v421 @ X0_v8] (should have been resolved before IL gen)");
			object obj12 = this + 24;
			object obj13 = default(object);
			obj12 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = 1;
			return true;
			IL_0396:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj14 = 1;
			goto IL_053f;
			IL_0166:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj14 = 6;
			goto IL_04cb;
			IL_04cb:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v359 @ X0_v25] (should have been resolved before IL gen)");
			object obj15 = this + 40;
			object obj16 = default(object);
			obj15 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			goto IL_01c0;
			IL_01c0:
			IEnumerator enumerator = <requestSteps>5__2;
			object obj17;
			if (<requestSteps>5__2 != null)
			{
				obj17 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
				nint num3 = (nint)enumerator;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v7 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
				object obj18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v7 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0291;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v7 (Il2CppClass<System.Collections.IEnumerator>)+B0]");
				object obj19 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X10_v14-8]");
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
					goto IL_0291;
				}
				object obj20 = num3 + obj19;
				object obj21 = obj20 + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v325 @ X0_v21] (should have been resolved before IL gen)");
				object obj23 = default(object);
				object obj22 = obj23 & 1;
				bool flag3 = obj22 == null;
				object obj24 = !flag3;
				if (obj24 != null)
				{
					goto IL_02d9;
				}
				goto IL_0409;
			}
			goto IL_043d;
			IL_0409:
			return false;
			IL_0291:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v273 @ X0_v18] (should have been resolved before IL gen)");
			object obj26 = default(object);
			object obj25 = obj26 & 1;
			bool flag4 = obj25 == null;
			obj14 = 0;
			if (!flag4)
			{
				goto IL_02d9;
			}
			goto IL_0409;
			IL_02d9:
			IEnumerator enumerator2 = <requestSteps>5__2;
			if (<requestSteps>5__2 == null)
			{
				goto IL_043d;
			}
			nint num4 = (nint)enumerator2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X8_v9 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
			object obj27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X8_v9 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0396;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X8_v9 (Il2CppClass<System.Collections.IEnumerator>)+B0]");
			object obj28 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X10_v9-8]");
				if (0 == (nint)obj17)
				{
					break;
				}
				obj28 += 16;
				obj27--;
				if ((nint)obj27 != 1)
				{
					continue;
				}
				goto IL_0396;
			}
			object obj29 = obj28 + 1;
			object obj30 = num4 + obj29;
			object obj31 = obj30 + 312;
			goto IL_053f;
			IL_043d:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
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

	private sealed class <Materialize>d__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public WebRequestDecorator<TResponse> <>4__this;

		private IEnumerator <requestSteps>5__2;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <Materialize>d__15(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_018d: Expected I4, but got I8
			//IL_0021: Expected O, but got I4
			//IL_044b: Expected I4, but got O
			//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fd: Expected O, but got Unknown
			//IL_0205: Expected I, but got O
			//IL_0215: Expected O, but got I
			//IL_0048: Expected I4, but got I8
			//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b3: Expected O, but got Unknown
			//IL_02cb: Expected O, but got I4
			//IL_0250: Expected O, but got I
			//IL_03b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_03bb: Expected O, but got Unknown
			//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c9: Expected O, but got Unknown
			//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e1: Expected O, but got Unknown
			//IL_03fb: Expected O, but got I4
			//IL_00ac: Expected O, but got I
			//IL_00c2: Expected O, but got I
			//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d0: Expected O, but got Unknown
			//IL_00ea: Expected O, but got I4
			//IL_030a: Expected I, but got O
			//IL_031a: Expected O, but got I
			//IL_025e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0263: Expected O, but got Unknown
			//IL_026c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0271: Expected O, but got Unknown
			//IL_0472: Expected I, but got O
			//IL_0482: Expected O, but got I
			//IL_03a9: Expected O, but got I4
			//IL_0179: Expected O, but got I4
			//IL_054f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0554: Expected O, but got Unknown
			//IL_0355: Expected O, but got I
			//IL_04db: Unknown result type (might be due to invalid IL or missing references)
			//IL_04e0: Expected O, but got Unknown
			//IL_0125: Expected O, but got I
			//IL_0418: Unknown result type (might be due to invalid IL or missing references)
			//IL_041d: Expected O, but got Unknown
			//IL_0425: Unknown result type (might be due to invalid IL or missing references)
			//IL_042a: Expected O, but got Unknown
			//IL_0433: Unknown result type (might be due to invalid IL or missing references)
			//IL_0438: Expected O, but got Unknown
			//IL_019b: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a0: Expected O, but got Unknown
			//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ad: Expected O, but got Unknown
			//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bb: Expected O, but got Unknown
			//IL_0363: Unknown result type (might be due to invalid IL or missing references)
			//IL_0368: Expected O, but got Unknown
			//IL_0371: Unknown result type (might be due to invalid IL or missing references)
			//IL_0376: Expected O, but got Unknown
			//IL_0133: Unknown result type (might be due to invalid IL or missing references)
			//IL_0138: Expected O, but got Unknown
			//IL_0141: Unknown result type (might be due to invalid IL or missing references)
			//IL_0146: Expected O, but got Unknown
			if (<>1__state != 1)
			{
				bool flag = <>1__state == 0;
				object obj = !flag;
				if (obj != null)
				{
					goto IL_0409;
				}
				WebRequestDecorator<TResponse> webRequestDecorator = <>4__this;
				<>1__state = -1;
				if (<>4__this != null)
				{
					IWebRequest<TResponse> <Request>k__BackingField = webRequestDecorator.<Request>k__BackingField;
					if (webRequestDecorator.<Request>k__BackingField != null)
					{
						nint num = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v19 (Il2CppRgctx<Kammelna.Server.WebRequests.WebRequestDecorator`1+<Materialize>d__15>)+18]");
						object obj2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v19 (Il2CppRgctx<Kammelna.Server.WebRequests.WebRequestDecorator`1+<Materialize>d__15>)+18]");
						object obj3 = (nint)0 + (nint)309;
						object obj4 = obj3 & 1;
						bool flag2 = obj4 == null;
						object obj5 = !flag2;
						if (obj5 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
							object obj6 = default(object);
							obj2 = obj6;
						}
						nint num2 = (nint)<Request>k__BackingField;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v22 (Il2CppClass<Kammelna.Server.WebRequests.IWebRequest`1<TResponse>>)+12E]");
						object obj7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v22 (Il2CppClass<Kammelna.Server.WebRequests.IWebRequest`1<TResponse>>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_0166;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v22 (Il2CppClass<Kammelna.Server.WebRequests.IWebRequest`1<TResponse>>)+B0]");
						object obj8 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X10_v20-8]");
							if (0 == (nint)obj2)
							{
								break;
							}
							obj8 += 16;
							obj7--;
							if ((nint)obj7 != 1)
							{
								continue;
							}
							goto IL_0166;
						}
						object obj9 = obj8 + 7;
						object obj10 = num2 + obj9;
						object obj11 = obj10 + 312;
						goto IL_04cb;
					}
				}
				goto IL_043d;
			}
			<>1__state = -1;
			goto IL_01c0;
			IL_053f:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v421 @ X0_v8] (should have been resolved before IL gen)");
			object obj12 = this + 24;
			object obj13 = default(object);
			obj12 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = 1;
			return true;
			IL_0396:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj14 = 1;
			goto IL_053f;
			IL_0166:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj14 = 7;
			goto IL_04cb;
			IL_04cb:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v359 @ X0_v25] (should have been resolved before IL gen)");
			object obj15 = this + 40;
			object obj16 = default(object);
			obj15 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			goto IL_01c0;
			IL_01c0:
			IEnumerator enumerator = <requestSteps>5__2;
			object obj17;
			if (<requestSteps>5__2 != null)
			{
				obj17 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
				nint num3 = (nint)enumerator;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v7 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
				object obj18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v7 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0291;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v7 (Il2CppClass<System.Collections.IEnumerator>)+B0]");
				object obj19 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X10_v14-8]");
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
					goto IL_0291;
				}
				object obj20 = num3 + obj19;
				object obj21 = obj20 + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v325 @ X0_v21] (should have been resolved before IL gen)");
				object obj23 = default(object);
				object obj22 = obj23 & 1;
				bool flag3 = obj22 == null;
				object obj24 = !flag3;
				if (obj24 != null)
				{
					goto IL_02d9;
				}
				goto IL_0409;
			}
			goto IL_043d;
			IL_0409:
			return false;
			IL_0291:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v273 @ X0_v18] (should have been resolved before IL gen)");
			object obj26 = default(object);
			object obj25 = obj26 & 1;
			bool flag4 = obj25 == null;
			obj14 = 0;
			if (!flag4)
			{
				goto IL_02d9;
			}
			goto IL_0409;
			IL_02d9:
			IEnumerator enumerator2 = <requestSteps>5__2;
			if (<requestSteps>5__2 == null)
			{
				goto IL_043d;
			}
			nint num4 = (nint)enumerator2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X8_v9 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
			object obj27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X8_v9 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0396;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X8_v9 (Il2CppClass<System.Collections.IEnumerator>)+B0]");
			object obj28 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X10_v9-8]");
				if (0 == (nint)obj17)
				{
					break;
				}
				obj28 += 16;
				obj27--;
				if ((nint)obj27 != 1)
				{
					continue;
				}
				goto IL_0396;
			}
			object obj29 = obj28 + 1;
			object obj30 = num4 + obj29;
			object obj31 = obj30 + 312;
			goto IL_053f;
			IL_043d:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
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

	private readonly IWebRequest<TResponse> <Request>k__BackingField;

	private IWebRequest<TResponse> Request => <Request>k__BackingField;

	public string RequestUrl
	{
		get
		{
			//IL_003f: Expected O, but got I
			//IL_0055: Expected O, but got I
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Expected O, but got Unknown
			//IL_007d: Expected O, but got I4
			//IL_0148: Expected I, but got O
			//IL_0158: Expected O, but got I
			//IL_0115: Unknown result type (might be due to invalid IL or missing references)
			//IL_011a: Expected O, but got Unknown
			//IL_0123: Unknown result type (might be due to invalid IL or missing references)
			//IL_0128: Expected O, but got Unknown
			//IL_00b8: Expected O, but got I
			//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cb: Expected O, but got Unknown
			//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d9: Expected O, but got Unknown
			IWebRequest<TResponse> webRequest = <Request>k__BackingField;
			nint num2;
			object obj7 = default(object);
			if (<Request>k__BackingField != null)
			{
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ X8_v2 (Il2CppRgctx<Kammelna.Server.WebRequests.WebRequestDecorator`1>)+8]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ X8_v2 (Il2CppRgctx<Kammelna.Server.WebRequests.WebRequestDecorator`1>)+8]");
				object obj2 = (nint)0 + (nint)309;
				object obj3 = obj2 & 1;
				bool flag = obj3 == null;
				object obj4 = !flag;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
					object obj5 = default(object);
					obj = obj5;
				}
				num2 = (nint)webRequest;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<Kammelna.Server.WebRequests.IWebRequest`1<TResponse>>)+12E]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<Kammelna.Server.WebRequests.IWebRequest`1<TResponse>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00f9;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<Kammelna.Server.WebRequests.IWebRequest`1<TResponse>>)+B0]");
				obj7 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X10_v4-8]");
					if (0 == (nint)obj)
					{
						break;
					}
					obj7 += 16;
					obj6--;
					if ((nint)obj6 != 1)
					{
						continue;
					}
					goto IL_00f9;
				}
				goto IL_010d;
			}
			goto IL_0132;
			IL_00f9:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v84 @ X0_v4] (should have been resolved before IL gen)");
			goto IL_010d;
			IL_0132:
			return (string)(object)new NullReferenceException();
			IL_010d:
			object obj8 = num2 + obj7;
			object obj9 = obj8 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v146 @ X0_v6] (should have been resolved before IL gen)");
			goto IL_0132;
		}
	}

	public IClientContext ClientContext
	{
		get
		{
			//IL_003f: Expected O, but got I
			//IL_0055: Expected O, but got I
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Expected O, but got Unknown
			//IL_007d: Expected O, but got I4
			//IL_0156: Expected I, but got O
			//IL_0166: Expected O, but got I
			//IL_0116: Unknown result type (might be due to invalid IL or missing references)
			//IL_011b: Expected O, but got Unknown
			//IL_0123: Unknown result type (might be due to invalid IL or missing references)
			//IL_0128: Expected O, but got Unknown
			//IL_0131: Unknown result type (might be due to invalid IL or missing references)
			//IL_0136: Expected O, but got Unknown
			//IL_00b8: Expected O, but got I
			//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cb: Expected O, but got Unknown
			//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d9: Expected O, but got Unknown
			IWebRequest<TResponse> webRequest = <Request>k__BackingField;
			nint num2;
			object obj7 = default(object);
			if (<Request>k__BackingField != null)
			{
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ X8_v2 (Il2CppRgctx<Kammelna.Server.WebRequests.WebRequestDecorator`1>)+8]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ X8_v2 (Il2CppRgctx<Kammelna.Server.WebRequests.WebRequestDecorator`1>)+8]");
				object obj2 = (nint)0 + (nint)309;
				object obj3 = obj2 & 1;
				bool flag = obj3 == null;
				object obj4 = !flag;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
					object obj5 = default(object);
					obj = obj5;
				}
				num2 = (nint)webRequest;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<Kammelna.Server.WebRequests.IWebRequest`1<TResponse>>)+12E]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<Kammelna.Server.WebRequests.IWebRequest`1<TResponse>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00f9;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<Kammelna.Server.WebRequests.IWebRequest`1<TResponse>>)+B0]");
				obj7 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X10_v4-8]");
					if (0 == (nint)obj)
					{
						break;
					}
					obj7 += 16;
					obj6--;
					if ((nint)obj6 != 1)
					{
						continue;
					}
					goto IL_00f9;
				}
				goto IL_010d;
			}
			goto IL_0140;
			IL_00f9:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v84 @ X0_v4] (should have been resolved before IL gen)");
			goto IL_010d;
			IL_0140:
			return (IClientContext)new NullReferenceException();
			IL_010d:
			object obj8 = obj7 + 1;
			object obj9 = num2 + obj8;
			object obj10 = obj9 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v147 @ X0_v6] (should have been resolved before IL gen)");
			goto IL_0140;
		}
	}

	public UnityWebRequest UnityRequest
	{
		get
		{
			//IL_003f: Expected O, but got I
			//IL_0055: Expected O, but got I
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Expected O, but got Unknown
			//IL_007d: Expected O, but got I4
			//IL_0156: Expected I, but got O
			//IL_0166: Expected O, but got I
			//IL_0116: Unknown result type (might be due to invalid IL or missing references)
			//IL_011b: Expected O, but got Unknown
			//IL_0123: Unknown result type (might be due to invalid IL or missing references)
			//IL_0128: Expected O, but got Unknown
			//IL_0131: Unknown result type (might be due to invalid IL or missing references)
			//IL_0136: Expected O, but got Unknown
			//IL_00b8: Expected O, but got I
			//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cb: Expected O, but got Unknown
			//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d9: Expected O, but got Unknown
			IWebRequest<TResponse> webRequest = <Request>k__BackingField;
			nint num2;
			object obj7 = default(object);
			if (<Request>k__BackingField != null)
			{
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ X8_v2 (Il2CppRgctx<Kammelna.Server.WebRequests.WebRequestDecorator`1>)+8]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ X8_v2 (Il2CppRgctx<Kammelna.Server.WebRequests.WebRequestDecorator`1>)+8]");
				object obj2 = (nint)0 + (nint)309;
				object obj3 = obj2 & 1;
				bool flag = obj3 == null;
				object obj4 = !flag;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
					object obj5 = default(object);
					obj = obj5;
				}
				num2 = (nint)webRequest;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<Kammelna.Server.WebRequests.IWebRequest`1<TResponse>>)+12E]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<Kammelna.Server.WebRequests.IWebRequest`1<TResponse>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00f9;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<Kammelna.Server.WebRequests.IWebRequest`1<TResponse>>)+B0]");
				obj7 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X10_v4-8]");
					if (0 == (nint)obj)
					{
						break;
					}
					obj7 += 16;
					obj6--;
					if ((nint)obj6 != 1)
					{
						continue;
					}
					goto IL_00f9;
				}
				goto IL_010d;
			}
			goto IL_0140;
			IL_00f9:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v84 @ X0_v4] (should have been resolved before IL gen)");
			goto IL_010d;
			IL_0140:
			return (UnityWebRequest)(object)new NullReferenceException();
			IL_010d:
			object obj8 = obj7 + 2;
			object obj9 = num2 + obj8;
			object obj10 = obj9 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v147 @ X0_v6] (should have been resolved before IL gen)");
			goto IL_0140;
		}
	}

	public KammelnaResponseModel<TResponse> Response
	{
		get
		{
			//IL_003f: Expected O, but got I
			//IL_0055: Expected O, but got I
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Expected O, but got Unknown
			//IL_007d: Expected O, but got I4
			//IL_0156: Expected I, but got O
			//IL_0166: Expected O, but got I
			//IL_0116: Unknown result type (might be due to invalid IL or missing references)
			//IL_011b: Expected O, but got Unknown
			//IL_0123: Unknown result type (might be due to invalid IL or missing references)
			//IL_0128: Expected O, but got Unknown
			//IL_0131: Unknown result type (might be due to invalid IL or missing references)
			//IL_0136: Expected O, but got Unknown
			//IL_00b8: Expected O, but got I
			//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cb: Expected O, but got Unknown
			//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d9: Expected O, but got Unknown
			IWebRequest<TResponse> webRequest = <Request>k__BackingField;
			nint num2;
			object obj7 = default(object);
			if (<Request>k__BackingField != null)
			{
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ X8_v2 (Il2CppRgctx<Kammelna.Server.WebRequests.WebRequestDecorator`1>)+8]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ X8_v2 (Il2CppRgctx<Kammelna.Server.WebRequests.WebRequestDecorator`1>)+8]");
				object obj2 = (nint)0 + (nint)309;
				object obj3 = obj2 & 1;
				bool flag = obj3 == null;
				object obj4 = !flag;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
					object obj5 = default(object);
					obj = obj5;
				}
				num2 = (nint)webRequest;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<Kammelna.Server.WebRequests.IWebRequest`1<TResponse>>)+12E]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<Kammelna.Server.WebRequests.IWebRequest`1<TResponse>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00f9;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<Kammelna.Server.WebRequests.IWebRequest`1<TResponse>>)+B0]");
				obj7 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X10_v4-8]");
					if (0 == (nint)obj)
					{
						break;
					}
					obj7 += 16;
					obj6--;
					if ((nint)obj6 != 1)
					{
						continue;
					}
					goto IL_00f9;
				}
				goto IL_010d;
			}
			goto IL_0140;
			IL_00f9:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v84 @ X0_v4] (should have been resolved before IL gen)");
			goto IL_010d;
			IL_0140:
			return (KammelnaResponseModel<TResponse>)(object)new NullReferenceException();
			IL_010d:
			object obj8 = obj7 + 3;
			object obj9 = num2 + obj8;
			object obj10 = obj9 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v147 @ X0_v6] (should have been resolved before IL gen)");
			goto IL_0140;
		}
		set
		{
			//IL_0025: Expected O, but got I
			//IL_003b: Expected O, but got I
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Expected O, but got Unknown
			//IL_0063: Expected O, but got I4
			//IL_015e: Expected I, but got O
			//IL_016e: Expected O, but got I
			//IL_0101: Expected O, but got I
			//IL_0114: Unknown result type (might be due to invalid IL or missing references)
			//IL_0119: Expected O, but got Unknown
			//IL_0121: Unknown result type (might be due to invalid IL or missing references)
			//IL_0126: Expected O, but got Unknown
			//IL_012f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0134: Expected O, but got Unknown
			//IL_014c: Expected O, but got I
			//IL_009e: Expected O, but got I
			//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Expected O, but got Unknown
			//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bf: Expected O, but got Unknown
			IWebRequest<TResponse> webRequest = <Request>k__BackingField;
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ X8_v2 (Il2CppRgctx<Kammelna.Server.WebRequests.WebRequestDecorator`1>)+8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ X8_v2 (Il2CppRgctx<Kammelna.Server.WebRequests.WebRequestDecorator`1>)+8]");
			object obj2 = (nint)0 + (nint)309;
			object obj3 = obj2 & 1;
			bool flag = obj3 == null;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				object obj5 = default(object);
				obj = obj5;
			}
			object obj7 = default(object);
			object obj9 = default(object);
			while (true)
			{
				nint num2 = (nint)webRequest;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v5 (Il2CppClass<Kammelna.Server.WebRequests.IWebRequest`1<TResponse>>)+12E]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v5 (Il2CppClass<Kammelna.Server.WebRequests.IWebRequest`1<TResponse>>)+12E]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v5 (Il2CppClass<Kammelna.Server.WebRequests.IWebRequest`1<TResponse>>)+B0]");
					obj7 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X10_v4-8]");
						if (0 == (nint)obj)
						{
							break;
						}
						obj7 += 16;
						obj6--;
						if ((nint)obj6 != 1)
						{
							continue;
						}
						goto IL_00df;
					}
					goto IL_010b;
				}
				goto IL_00df;
				IL_00df:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				object obj8 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v4+8]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v91 @ X3_v1 (should have been resolved before IL gen)");
				goto IL_010b;
				IL_010b:
				object obj11 = obj7 + 4;
				object obj12 = num2 + obj11;
				object obj13 = obj12 + 312;
				object obj14 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X0_v6+8]");
				object obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v92 @ X3_v2 (should have been resolved before IL gen)");
			}
		}
	}

	protected WebRequestDecorator(IWebRequest<TResponse> request)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		object obj = this + 16;
		obj = request;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public virtual void Setup()
	{
		//IL_0025: Expected O, but got I
		//IL_003b: Expected O, but got I
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_0063: Expected O, but got I4
		//IL_015e: Expected I, but got O
		//IL_016e: Expected O, but got I
		//IL_0101: Expected O, but got I
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_014c: Expected O, but got I
		//IL_009e: Expected O, but got I
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		IWebRequest<TResponse> webRequest = <Request>k__BackingField;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ X8_v2 (Il2CppRgctx<Kammelna.Server.WebRequests.WebRequestDecorator`1>)+8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ X8_v2 (Il2CppRgctx<Kammelna.Server.WebRequests.WebRequestDecorator`1>)+8]");
		object obj2 = (nint)0 + (nint)309;
		object obj3 = obj2 & 1;
		bool flag = obj3 == null;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			object obj5 = default(object);
			obj = obj5;
		}
		object obj7 = default(object);
		object obj9 = default(object);
		while (true)
		{
			nint num2 = (nint)webRequest;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<Kammelna.Server.WebRequests.IWebRequest`1<TResponse>>)+12E]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<Kammelna.Server.WebRequests.IWebRequest`1<TResponse>>)+12E]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<Kammelna.Server.WebRequests.IWebRequest`1<TResponse>>)+B0]");
				obj7 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X10_v4-8]");
					if (0 == (nint)obj)
					{
						break;
					}
					obj7 += 16;
					obj6--;
					if ((nint)obj6 != 1)
					{
						continue;
					}
					goto IL_00df;
				}
				goto IL_010b;
			}
			goto IL_00df;
			IL_00df:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj8 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v4+8]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v93 @ X2_v2 (should have been resolved before IL gen)");
			goto IL_010b;
			IL_010b:
			object obj11 = obj7 + 5;
			object obj12 = num2 + obj11;
			object obj13 = obj12 + 312;
			object obj14 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v6+8]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v94 @ X2_v3 (should have been resolved before IL gen)");
		}
	}

	public virtual IEnumerator Execute()
	{
		//IL_0016: Expected O, but got I
		//IL_002c: Expected O, but got I
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0054: Expected O, but got I4
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ X8_v2 (Il2CppRgctx<Kammelna.Server.WebRequests.WebRequestDecorator`1>)+50]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ X8_v2 (Il2CppRgctx<Kammelna.Server.WebRequests.WebRequestDecorator`1>)+50]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4499914");
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

	public virtual IEnumerator Materialize()
	{
		//IL_0016: Expected O, but got I
		//IL_002c: Expected O, but got I
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0054: Expected O, but got I4
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ X8_v2 (Il2CppRgctx<Kammelna.Server.WebRequests.WebRequestDecorator`1>)+60]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ X8_v2 (Il2CppRgctx<Kammelna.Server.WebRequests.WebRequestDecorator`1>)+60]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @45A6898");
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

	public virtual void Dispose()
	{
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
			IWebRequest<TResponse> webRequest = <Request>k__BackingField;
			if (<Request>k__BackingField == null)
			{
				break;
			}
			object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
			nint num = (nint)webRequest;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v5 (Il2CppClass<Kammelna.Server.WebRequests.IWebRequest`1<TResponse>>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v5 (Il2CppClass<Kammelna.Server.WebRequests.IWebRequest`1<TResponse>>)+12E]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v5 (Il2CppClass<Kammelna.Server.WebRequests.IWebRequest`1<TResponse>>)+B0]");
				object obj3 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X10_v4-8]");
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
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v150 @ X0_v5] (should have been resolved before IL gen)");
				continue;
			}
			goto IL_00ad;
			IL_00ad:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v89 @ X0_v3] (should have been resolved before IL gen)");
			break;
		}
	}
}
