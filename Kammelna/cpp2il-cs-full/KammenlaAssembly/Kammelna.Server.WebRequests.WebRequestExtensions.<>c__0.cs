using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using UnityEngine;
using UnityEngine.TextCore;

namespace Kammelna.Server.WebRequests;

public static class WebRequestExtensions
{
	[Serializable]
	private sealed class <>c__0<T>
	{
		public static readonly <>c__0<T> <>9;

		public static Func<WebRequestDecoratorAttribute, int> <>9__0_0;

		public static Func<IWebRequest<T>, WebRequestDecoratorAttribute, IWebRequest<T>> <>9__0_1;

		static <>c__0()
		{
			//IL_000c: Expected O, but got I
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			//IL_0287: Expected O, but got I
			//IL_028f: Expected I, but got O
			//IL_0298: Unknown result type (might be due to invalid IL or missing references)
			//IL_029d: Expected O, but got Unknown
			//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ab: Expected O, but got Unknown
			//IL_02c5: Expected O, but got I4
			//IL_02cd: Expected I, but got O
			//IL_009c: Expected O, but got I
			//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00aa: Expected O, but got Unknown
			//IL_00c4: Expected O, but got I4
			//IL_0053: Expected O, but got I
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Expected O, but got Unknown
			//IL_0114: Expected O, but got I
			//IL_011d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0122: Expected O, but got Unknown
			//IL_0360: Expected O, but got I
			//IL_0370: Expected O, but got I
			//IL_0386: Expected O, but got I
			//IL_038f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0394: Expected O, but got Unknown
			//IL_03ae: Expected O, but got I4
			//IL_03be: Expected O, but got I
			//IL_0300: Expected O, but got I
			//IL_0309: Unknown result type (might be due to invalid IL or missing references)
			//IL_030e: Expected O, but got Unknown
			//IL_01b6: Expected O, but got I
			//IL_01ca: Expected O, but got I
			//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d8: Expected O, but got Unknown
			//IL_0155: Expected O, but got I
			//IL_016b: Expected O, but got I
			//IL_0174: Unknown result type (might be due to invalid IL or missing references)
			//IL_0179: Expected O, but got Unknown
			//IL_0198: Expected O, but got I
			//IL_0450: Expected O, but got I
			//IL_0460: Expected O, but got I
			//IL_0476: Expected O, but got I
			//IL_047f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0484: Expected O, but got Unknown
			//IL_049e: Expected O, but got I4
			//IL_04ae: Expected O, but got I
			//IL_03e6: Expected O, but got I
			//IL_03fa: Expected O, but got I
			//IL_0403: Unknown result type (might be due to invalid IL or missing references)
			//IL_0408: Expected O, but got Unknown
			//IL_0422: Expected O, but got I4
			//IL_0211: Expected O, but got I
			//IL_0227: Expected O, but got I
			//IL_0230: Unknown result type (might be due to invalid IL or missing references)
			//IL_0235: Expected O, but got Unknown
			//IL_0254: Expected O, but got I
			object obj = (nint)0 + (nint)309;
			object obj2 = obj & 1;
			if (obj2 != null)
			{
				nint num = 0;
				nint num2 = num;
				object obj3 = num + 309;
				object obj4 = obj3 & 1;
				bool flag = obj4 == null;
				nint num3 = num;
				if (!flag)
				{
					goto IL_0086;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ X0_v6+C0]");
				object obj5 = 0;
				nint num2 = (nint)obj5;
				object obj6 = obj5 + 309;
				object obj7 = obj6 & 1;
				bool flag2 = obj7 == null;
				object obj8 = !flag2;
				nint num3 = (nint)obj5;
				if (obj8 != null)
				{
					goto IL_0086;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj9 = (nint)0 + (nint)309;
			object obj10 = obj9 & 1;
			bool flag3 = obj10 == null;
			object obj12 = default(object);
			object obj11 = obj12;
			nint num4 = 0;
			if (flag3)
			{
				goto IL_00e8;
			}
			object obj13 = obj12;
			goto IL_00ff;
			IL_01a6:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v28+B8]");
			object obj14 = 0;
			obj14 = obj13;
			object obj15 = (nint)0 + (nint)309;
			object obj16 = obj15 & 1;
			bool flag4 = obj16 == null;
			nint num5 = 0;
			if (!flag4)
			{
				goto IL_01fb;
			}
			goto IL_0436;
			IL_01fb:
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v26 (Il2CppRgctx<Kammelna.Server.WebRequests.WebRequestExtensions+<>c__0`1>)+10]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v26 (Il2CppRgctx<Kammelna.Server.WebRequests.WebRequestExtensions+<>c__0`1>)+10]");
			object obj18 = (nint)0 + (nint)309;
			object obj19 = obj18 & 1;
			bool flag5 = obj19 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v26 (Il2CppRgctx<Kammelna.Server.WebRequests.WebRequestExtensions+<>c__0`1>)+10]");
			object obj20 = 0;
			if (!flag5)
			{
				goto IL_0262;
			}
			goto IL_04bc;
			IL_04bc:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return;
			IL_0436:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v16+C0]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v14+10]");
			obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v14+10]");
			object obj22 = (nint)0 + (nint)309;
			object obj23 = obj22 & 1;
			bool flag6 = obj23 == null;
			object obj24 = !flag6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v14+10]");
			obj20 = 0;
			if (obj24 != null)
			{
				goto IL_0262;
			}
			goto IL_04bc;
			IL_0086:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj25 = (nint)0 + (nint)309;
			object obj26 = obj25 & 1;
			bool flag7 = obj26 == null;
			object obj27 = !flag7;
			object obj28 = default(object);
			obj11 = obj28;
			num4 = 0;
			obj13 = obj28;
			if (obj27 == null)
			{
				goto IL_00e8;
			}
			goto IL_00ff;
			IL_00e8:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			obj13 = obj11;
			goto IL_00ff;
			IL_00ff:
			obj13..ctor();
			object obj29 = (nint)0 + (nint)309;
			object obj30 = obj29 & 1;
			if (obj30 != null)
			{
				nint num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v33 (Il2CppRgctx<Kammelna.Server.WebRequests.WebRequestExtensions+<>c__0`1>)+10]");
				object obj31 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v33 (Il2CppRgctx<Kammelna.Server.WebRequests.WebRequestExtensions+<>c__0`1>)+10]");
				object obj32 = (nint)0 + (nint)309;
				object obj33 = obj32 & 1;
				bool flag8 = obj33 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v33 (Il2CppRgctx<Kammelna.Server.WebRequests.WebRequestExtensions+<>c__0`1>)+10]");
				object obj34 = 0;
				if (!flag8)
				{
					goto IL_01a6;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v21+C0]");
				object obj35 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v21+10]");
				object obj31 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v21+10]");
				object obj36 = (nint)0 + (nint)309;
				object obj37 = obj36 & 1;
				bool flag9 = obj37 == null;
				object obj38 = !flag9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v21+10]");
				object obj34 = 0;
				if (obj38 != null)
				{
					goto IL_01a6;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v19+B8]");
			object obj39 = 0;
			obj39 = obj13;
			object obj40 = (nint)0 + (nint)309;
			object obj41 = obj40 & 1;
			bool flag10 = obj41 == null;
			object obj42 = !flag10;
			num5 = 0;
			if (obj42 != null)
			{
				goto IL_01fb;
			}
			goto IL_0436;
			IL_0262:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal int <ApplyDecorators>b__0_0(WebRequestDecoratorAttribute d)
		{
			//IL_005d: Expected I4, but got O
			//IL_0025: Expected I, but got O
			//IL_0035: Expected O, but got I
			//IL_0045: Expected O, but got I
			if (d != null)
			{
				nint num = (nint)d;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ X8_v1 (Il2CppClass<Kammelna.Server.WebRequests.WebRequestDecoratorAttribute>)+1A8]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ X8_v1 (Il2CppClass<Kammelna.Server.WebRequests.WebRequestDecoratorAttribute>)+1B0]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v3 @ X2_v1 (should have been resolved before IL gen)");
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}

		internal IWebRequest<T> <ApplyDecorators>b__0_1(IWebRequest<T> request, WebRequestDecoratorAttribute decorator)
		{
			//IL_0033: Expected O, but got I
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Expected O, but got Unknown
			//IL_0062: Expected O, but got I
			if (decorator != null)
			{
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ X8_v2 (Il2CppRgctx<Kammelna.Server.WebRequests.WebRequestExtensions+<>c__0`1>)+20]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X1_v1+50]");
				object obj2 = decorator + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1950");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ X0_v3+8]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v39 @ X3_v1 (should have been resolved before IL gen)");
			}
			return (IWebRequest<T>)new NullReferenceException();
		}
	}

	private sealed class <SendWebRequest>d__2<T> : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public IWebRequest<T> request;

		private IWebRequest<T> <>7__wrap1;

		private IEnumerator <requestSteps>5__3;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <SendWebRequest>d__2(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
			//IL_0010: Expected O, but got I4
			//IL_002a: Expected O, but got I4
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected O, but got Unknown
			//IL_0055: Expected O, but got I4
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Expected O, but got Unknown
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Expected O, but got Unknown
			//IL_01b6: Expected I4, but got I8
			//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cb: Expected O, but got Unknown
			//IL_00d3: Expected I, but got O
			//IL_00e3: Expected O, but got I
			//IL_011e: Expected O, but got I
			//IL_017c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0181: Expected O, but got Unknown
			//IL_018a: Unknown result type (might be due to invalid IL or missing references)
			//IL_018f: Expected O, but got Unknown
			//IL_012c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0131: Expected O, but got Unknown
			//IL_013a: Unknown result type (might be due to invalid IL or missing references)
			//IL_013f: Expected O, but got Unknown
			object obj = <>1__state + 3;
			bool flag = (nint)obj < 5;
			object obj2 = !flag;
			object obj3 = obj - 5;
			bool flag2 = obj3 == null;
			object obj4 = 1 << (int)obj;
			object obj5 = obj4 & 0x31;
			object obj6 = ~obj2;
			object obj7 = obj6 | flag2;
			object obj8 = ~obj7;
			bool flag3 = obj8 != null || obj5 == null;
			while (!flag3)
			{
				<>1__state = -1;
				IWebRequest<T> webRequest = <>7__wrap1;
				if (<>7__wrap1 == null)
				{
					break;
				}
				object obj9 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
				nint num = (nint)webRequest;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v11 (Il2CppClass<Kammelna.Server.WebRequests.IWebRequest`1<T>>)+12E]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v11 (Il2CppClass<Kammelna.Server.WebRequests.IWebRequest`1<T>>)+12E]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v11 (Il2CppClass<Kammelna.Server.WebRequests.IWebRequest`1<T>>)+B0]");
					object obj11 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X10_v4-8]");
						if (0 == (nint)obj9)
						{
							break;
						}
						obj11 += 16;
						obj10--;
						if ((nint)obj10 != 1)
						{
							continue;
						}
						goto IL_015f;
					}
					object obj12 = num + obj11;
					object obj13 = obj12 + 312;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v186 @ X0_v6] (should have been resolved before IL gen)");
					continue;
				}
				goto IL_015f;
				IL_015f:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v173 @ X0_v4] (should have been resolved before IL gen)");
				break;
			}
		}

		private bool MoveNext()
		{
			//IL_022f: Expected I4, but got I8
			//IL_0216: Expected I4, but got I8
			//IL_06ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_06f3: Expected O, but got Unknown
			//IL_06fb: Expected I, but got O
			//IL_070b: Expected O, but got I
			//IL_0040: Expected O, but got I4
			//IL_0a58: Expected O, but got I4
			//IL_079a: Expected O, but got I4
			//IL_0e5c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e61: Expected O, but got Unknown
			//IL_0746: Expected O, but got I
			//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ab: Expected O, but got Unknown
			//IL_03b3: Expected I, but got O
			//IL_03c3: Expected O, but got I
			//IL_005d: Expected I4, but got I8
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Expected O, but got Unknown
			//IL_08ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_08b2: Expected O, but got Unknown
			//IL_0452: Expected O, but got I4
			//IL_009f: Expected I, but got O
			//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ad: Expected O, but got Unknown
			//IL_00d6: Expected I4, but got I8
			//IL_0eec: Expected I4, but got I8
			//IL_07a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_07ac: Expected O, but got Unknown
			//IL_07b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_07ba: Expected O, but got Unknown
			//IL_0ce4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ce9: Expected O, but got Unknown
			//IL_03fe: Expected O, but got I
			//IL_0f7a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f7f: Expected O, but got Unknown
			//IL_0f88: Expected O, but got I4
			//IL_0754: Unknown result type (might be due to invalid IL or missing references)
			//IL_0759: Expected O, but got Unknown
			//IL_0762: Unknown result type (might be due to invalid IL or missing references)
			//IL_0767: Expected O, but got Unknown
			//IL_0115: Expected O, but got I
			//IL_0125: Expected O, but got I
			//IL_0135: Expected O, but got I
			//IL_014b: Expected O, but got I
			//IL_0154: Unknown result type (might be due to invalid IL or missing references)
			//IL_0159: Expected O, but got Unknown
			//IL_0173: Expected O, but got I4
			//IL_08d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_08d5: Expected O, but got Unknown
			//IL_08dd: Expected I, but got O
			//IL_08ed: Expected O, but got I
			//IL_07f6: Expected I, but got O
			//IL_0806: Expected O, but got I
			//IL_045f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0464: Expected O, but got Unknown
			//IL_046d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0472: Expected O, but got Unknown
			//IL_0afd: Expected I, but got O
			//IL_0b0d: Expected O, but got I
			//IL_097c: Expected O, but got I4
			//IL_0895: Expected O, but got I4
			//IL_0591: Expected O, but got I
			//IL_05a1: Expected O, but got I
			//IL_05b1: Expected O, but got I
			//IL_05c7: Expected O, but got I
			//IL_05d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d5: Expected O, but got Unknown
			//IL_05ef: Expected O, but got I4
			//IL_040c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0411: Expected O, but got Unknown
			//IL_041a: Unknown result type (might be due to invalid IL or missing references)
			//IL_041f: Expected O, but got Unknown
			//IL_0202: Expected O, but got I4
			//IL_0928: Expected O, but got I
			//IL_0eb5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0eba: Expected O, but got Unknown
			//IL_0841: Expected O, but got I
			//IL_0d6a: Expected I, but got O
			//IL_0d7a: Expected O, but got I
			//IL_04ae: Expected I, but got O
			//IL_04be: Expected O, but got I
			//IL_01ae: Expected O, but got I
			//IL_067e: Expected O, but got I4
			//IL_054d: Expected O, but got I4
			//IL_09b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_09bc: Expected O, but got Unknown
			//IL_09c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_09ca: Expected O, but got Unknown
			//IL_098a: Unknown result type (might be due to invalid IL or missing references)
			//IL_098f: Expected O, but got Unknown
			//IL_0997: Unknown result type (might be due to invalid IL or missing references)
			//IL_099c: Expected O, but got Unknown
			//IL_09a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_09aa: Expected O, but got Unknown
			//IL_0dd6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ddb: Expected O, but got Unknown
			//IL_0de3: Expected O, but got I
			//IL_062a: Expected O, but got I
			//IL_0d3d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d42: Expected O, but got Unknown
			//IL_04f9: Expected O, but got I
			//IL_0277: Expected O, but got I
			//IL_0287: Expected O, but got I
			//IL_0297: Expected O, but got I
			//IL_02ad: Expected O, but got I
			//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_02bb: Expected O, but got Unknown
			//IL_02d5: Expected O, but got I4
			//IL_0242: Unknown result type (might be due to invalid IL or missing references)
			//IL_0247: Expected O, but got Unknown
			//IL_024f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0254: Expected O, but got Unknown
			//IL_025d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0262: Expected O, but got Unknown
			//IL_0936: Unknown result type (might be due to invalid IL or missing references)
			//IL_093b: Expected O, but got Unknown
			//IL_0944: Unknown result type (might be due to invalid IL or missing references)
			//IL_0949: Expected O, but got Unknown
			//IL_084f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0854: Expected O, but got Unknown
			//IL_085d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0862: Expected O, but got Unknown
			//IL_0c05: Expected I, but got O
			//IL_0c15: Expected O, but got I
			//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c1: Expected O, but got Unknown
			//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cf: Expected O, but got Unknown
			//IL_06ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_06bf: Expected O, but got Unknown
			//IL_06c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_06cc: Expected O, but got Unknown
			//IL_06d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_06da: Expected O, but got Unknown
			//IL_068c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0691: Expected O, but got Unknown
			//IL_0699: Unknown result type (might be due to invalid IL or missing references)
			//IL_069e: Expected O, but got Unknown
			//IL_06a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_06ac: Expected O, but got Unknown
			//IL_0364: Expected O, but got I4
			//IL_0638: Unknown result type (might be due to invalid IL or missing references)
			//IL_063d: Expected O, but got Unknown
			//IL_0646: Unknown result type (might be due to invalid IL or missing references)
			//IL_064b: Expected O, but got Unknown
			//IL_0507: Unknown result type (might be due to invalid IL or missing references)
			//IL_050c: Expected O, but got Unknown
			//IL_0515: Unknown result type (might be due to invalid IL or missing references)
			//IL_051a: Expected O, but got Unknown
			//IL_0c71: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c76: Expected O, but got Unknown
			//IL_0c7e: Expected O, but got I
			//IL_0310: Expected O, but got I
			//IL_0372: Unknown result type (might be due to invalid IL or missing references)
			//IL_0377: Expected O, but got Unknown
			//IL_037f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0384: Expected O, but got Unknown
			//IL_038d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0392: Expected O, but got Unknown
			//IL_031e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0323: Expected O, but got Unknown
			//IL_032c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0331: Expected O, but got Unknown
			<SendWebRequest>d__2<T> <SendWebRequest>d__ = default(<SendWebRequest>d__2<T>);
			nint num2 = default(nint);
			NullReferenceException ex;
			<SendWebRequest>d__2<T> <SendWebRequest>d__2;
			if (<>1__state != 2)
			{
				if (<>1__state != 1)
				{
					bool flag = <>1__state == 0;
					object obj = !flag;
					if (obj != null)
					{
						goto IL_09cf;
					}
					<>1__state = -1;
					nint num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3106BDC");
					object obj2 = <SendWebRequest>d__ + 32;
					object obj3 = default(object);
					obj2 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					num2 = (nint)<SendWebRequest>d__.request;
					object obj4 = <SendWebRequest>d__ + 40;
					obj4 = <SendWebRequest>d__.request;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					<SendWebRequest>d__.<>1__state = -3;
					IWebRequest<T> webRequest = <SendWebRequest>d__.request;
					if (<SendWebRequest>d__.request != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ stack_-40_v2+20]");
						object obj5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ X8_v58+C0]");
						object obj6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ X8_v59+10]");
						object obj7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ X8_v59+10]");
						object obj8 = (nint)0 + (nint)309;
						object obj9 = obj8 & 1;
						bool flag2 = obj9 == null;
						object obj10 = !flag2;
						if (obj10 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
							object obj11 = default(object);
							obj7 = obj11;
						}
						nint num3 = (nint)webRequest;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ X8_v62 (Il2CppClass<Kammelna.Server.WebRequests.IWebRequest`1<T>>)+12E]");
						object obj12 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ X8_v62 (Il2CppClass<Kammelna.Server.WebRequests.IWebRequest`1<T>>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_01ef;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ X8_v62 (Il2CppClass<Kammelna.Server.WebRequests.IWebRequest`1<T>>)+B0]");
						object obj13 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v618 @ X10_v53-8]");
							if (0 == (nint)obj7)
							{
								break;
							}
							obj13 += 16;
							obj12--;
							if ((nint)obj12 != 1)
							{
								continue;
							}
							goto IL_01ef;
						}
						object obj14 = obj13 + 5;
						object obj15 = num3 + obj14;
						object obj16 = obj15 + 312;
						goto IL_0b56;
					}
					ex = new NullReferenceException();
					goto IL_0a3d;
				}
				<>1__state = -3;
				<SendWebRequest>d__2 = this;
				goto IL_0b9f;
			}
			<>1__state = -3;
			<SendWebRequest>d__2<T> <SendWebRequest>d__3 = this;
			goto IL_0bce;
			IL_0351:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj17 = 6;
			goto IL_0c5e;
			IL_0ea2:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v800 @ X0_v26] (should have been resolved before IL gen)");
			object obj18 = <SendWebRequest>d__ + 24;
			object obj19 = default(object);
			obj18 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			int num4 = 2;
			goto IL_0e02;
			IL_0b9f:
			IEnumerator enumerator = <SendWebRequest>d__2.<requestSteps>5__3;
			object obj20;
			if (<SendWebRequest>d__2.<requestSteps>5__3 != null)
			{
				obj20 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
				nint num5 = (nint)enumerator;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X8_v33 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
				object obj21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X8_v33 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_043f;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X8_v33 (Il2CppClass<System.Collections.IEnumerator>)+B0]");
				object obj22 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X10_v41-8]");
					if (0 == (nint)obj20)
					{
						break;
					}
					obj22 += 16;
					obj21--;
					if ((nint)obj21 != 1)
					{
						continue;
					}
					goto IL_043f;
				}
				object obj23 = num5 + obj22;
				object obj24 = obj23 + 312;
				goto IL_0cc1;
			}
			ex = new NullReferenceException();
			goto IL_0a3d;
			IL_0c5e:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1006 @ X0_v100] (should have been resolved before IL gen)");
			object obj25 = <SendWebRequest>d__ + 48;
			IntPtr intPtr = default(IntPtr);
			obj25 = (nint)intPtr;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			num2 = intPtr;
			<SendWebRequest>d__2 = <SendWebRequest>d__;
			goto IL_0b9f;
			IL_0787:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj17 = 0;
			goto IL_0e39;
			IL_066b:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj17 = 7;
			goto IL_0dc3;
			IL_0e02:
			<SendWebRequest>d__.<>1__state = num4;
			return true;
			IL_0bce:
			IEnumerator enumerator2 = <SendWebRequest>d__3.<requestSteps>5__3;
			object obj26;
			if (<SendWebRequest>d__3.<requestSteps>5__3 != null)
			{
				obj26 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
				nint num6 = (nint)enumerator2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v8 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
				object obj27 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v8 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0787;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v8 (Il2CppClass<System.Collections.IEnumerator>)+B0]");
				object obj28 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X10_v20-8]");
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
					goto IL_0787;
				}
				object obj29 = num6 + obj28;
				object obj30 = obj29 + 312;
				goto IL_0e39;
			}
			ex = new NullReferenceException();
			goto IL_0a3d;
			IL_0dc3:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v933 @ X0_v61] (should have been resolved before IL gen)");
			object obj31 = <SendWebRequest>d__ + 48;
			IntPtr intPtr2 = default(IntPtr);
			obj31 = (nint)intPtr2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			num2 = intPtr2;
			<SendWebRequest>d__3 = <SendWebRequest>d__;
			goto IL_0bce;
			IL_053a:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj17 = 1;
			goto IL_0d2a;
			IL_043f:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj17 = 0;
			goto IL_0cc1;
			IL_0cc1:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X0_v56+8]");
			num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v501 @ X0_v56] (should have been resolved before IL gen)");
			object obj33 = default(object);
			object obj32 = obj33 & 1;
			if (obj32 != null)
			{
				IEnumerator enumerator3 = <SendWebRequest>d__.<requestSteps>5__3;
				if (<SendWebRequest>d__.<requestSteps>5__3 != null)
				{
					nint num7 = (nint)enumerator3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v567 @ X8_v46 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
					object obj34 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v567 @ X8_v46 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_053a;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v567 @ X8_v46 (Il2CppClass<System.Collections.IEnumerator>)+B0]");
					object obj35 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v734 @ X10_v36-8]");
						if (0 == (nint)obj20)
						{
							break;
						}
						obj35 += 16;
						obj34--;
						if ((nint)obj34 != 1)
						{
							continue;
						}
						goto IL_053a;
					}
					object obj36 = obj35 + 1;
					object obj37 = num7 + obj36;
					object obj38 = obj37 + 312;
					goto IL_0d2a;
				}
				ex = new NullReferenceException();
			}
			else
			{
				IWebRequest<T> webRequest2 = <SendWebRequest>d__.request;
				if (<SendWebRequest>d__.request != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ stack_-40_v2+20]");
					object obj39 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X8_v38+C0]");
					object obj40 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v572 @ X8_v39+10]");
					object obj41 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v572 @ X8_v39+10]");
					object obj42 = (nint)0 + (nint)309;
					object obj43 = obj42 & 1;
					bool flag3 = obj43 == null;
					object obj44 = !flag3;
					if (obj44 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
						object obj45 = default(object);
						obj41 = obj45;
					}
					nint num8 = (nint)webRequest2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v671 @ X8_v42 (Il2CppClass<Kammelna.Server.WebRequests.IWebRequest`1<T>>)+12E]");
					object obj46 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v671 @ X8_v42 (Il2CppClass<Kammelna.Server.WebRequests.IWebRequest`1<T>>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_066b;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v671 @ X8_v42 (Il2CppClass<Kammelna.Server.WebRequests.IWebRequest`1<T>>)+B0]");
					object obj47 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v879 @ X10_v30-8]");
						if (0 == (nint)obj41)
						{
							break;
						}
						obj47 += 16;
						obj46--;
						if ((nint)obj46 != 1)
						{
							continue;
						}
						goto IL_066b;
					}
					object obj48 = obj47 + 7;
					object obj49 = num8 + obj48;
					object obj50 = obj49 + 312;
					goto IL_0dc3;
				}
				ex = new NullReferenceException();
			}
			goto IL_0a3d;
			IL_0f71:
			object obj51 = <SendWebRequest>d__ + 40;
			obj51 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			goto IL_09cf;
			IL_01ef:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj17 = 5;
			goto IL_0b56;
			IL_0b56:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v727 @ X0_v95+8]");
			num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v727 @ X0_v95] (should have been resolved before IL gen)");
			IWebRequest<T> webRequest3 = <SendWebRequest>d__.request;
			if (<SendWebRequest>d__.request != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ stack_-40_v2+20]");
				object obj52 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v841 @ X8_v67+C0]");
				object obj53 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v842 @ X8_v68+10]");
				object obj54 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v842 @ X8_v68+10]");
				object obj55 = (nint)0 + (nint)309;
				object obj56 = obj55 & 1;
				bool flag4 = obj56 == null;
				object obj57 = !flag4;
				if (obj57 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
					object obj58 = default(object);
					obj54 = obj58;
				}
				nint num9 = (nint)webRequest3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X8_v71 (Il2CppClass<Kammelna.Server.WebRequests.IWebRequest`1<T>>)+12E]");
				object obj59 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X8_v71 (Il2CppClass<Kammelna.Server.WebRequests.IWebRequest`1<T>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0351;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X8_v71 (Il2CppClass<Kammelna.Server.WebRequests.IWebRequest`1<T>>)+B0]");
				object obj60 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v982 @ X10_v48-8]");
					if (0 == (nint)obj54)
					{
						break;
					}
					obj60 += 16;
					obj59--;
					if ((nint)obj59 != 1)
					{
						continue;
					}
					goto IL_0351;
				}
				object obj61 = obj60 + 6;
				object obj62 = num9 + obj61;
				object obj63 = obj62 + 312;
				goto IL_0c5e;
			}
			ex = new NullReferenceException();
			goto IL_0a3d;
			IL_0d2a:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v867 @ X0_v73] (should have been resolved before IL gen)");
			object obj64 = <SendWebRequest>d__ + 24;
			object obj65 = default(object);
			obj64 = obj65;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			num4 = 1;
			goto IL_0e02;
			IL_0969:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj17 = 0;
			goto IL_0f3f;
			IL_0882:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj17 = 1;
			goto IL_0ea2;
			IL_0e39:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ X0_v6+8]");
			num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v479 @ X0_v6] (should have been resolved before IL gen)");
			object obj67 = default(object);
			object obj66 = obj67 & 1;
			if (obj66 != null)
			{
				IEnumerator enumerator4 = <SendWebRequest>d__.<requestSteps>5__3;
				if (<SendWebRequest>d__.<requestSteps>5__3 != null)
				{
					nint num10 = (nint)enumerator4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ X8_v23 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
					object obj68 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ X8_v23 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0882;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ X8_v23 (Il2CppClass<System.Collections.IEnumerator>)+B0]");
					object obj69 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v675 @ X10_v15-8]");
						if (0 == (nint)obj26)
						{
							break;
						}
						obj69 += 16;
						obj68--;
						if ((nint)obj68 != 1)
						{
							continue;
						}
						goto IL_0882;
					}
					object obj70 = obj69 + 1;
					object obj71 = num10 + obj70;
					object obj72 = obj71 + 312;
					goto IL_0ea2;
				}
				ex = new NullReferenceException();
				goto IL_0a3d;
			}
			<SendWebRequest>d__.<requestSteps>5__3 = null;
			object obj73 = <SendWebRequest>d__ + 48;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			<SendWebRequest>d__.<>1__state = -1;
			IWebRequest<T> webRequest4 = <SendWebRequest>d__.<>7__wrap1;
			if (<SendWebRequest>d__.<>7__wrap1 != null)
			{
				object obj74 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
				nint num11 = (nint)webRequest4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v697 @ X8_v18 (Il2CppClass<Kammelna.Server.WebRequests.IWebRequest`1<T>>)+12E]");
				object obj75 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v697 @ X8_v18 (Il2CppClass<Kammelna.Server.WebRequests.IWebRequest`1<T>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0969;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v697 @ X8_v18 (Il2CppClass<Kammelna.Server.WebRequests.IWebRequest`1<T>>)+B0]");
				object obj76 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v901 @ X10_v9-8]");
					if (0 == (nint)obj74)
					{
						break;
					}
					obj76 += 16;
					obj75--;
					if ((nint)obj75 != 1)
					{
						continue;
					}
					goto IL_0969;
				}
				object obj77 = num11 + obj76;
				object obj78 = obj77 + 312;
				goto IL_0f3f;
			}
			goto IL_0f71;
			IL_0f3f:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v948 @ X0_v16] (should have been resolved before IL gen)");
			goto IL_0f71;
			IL_0a3d:
			bool flag5 = num2 != 1;
			object obj79 = 0;
			NullReferenceException ex2 = ex;
			if (!flag5)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				object obj80 = default(object);
				if (obj80 == null)
				{
					goto IL_09cf;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1DF43EC");
				OutOfMemoryException ex3 = new OutOfMemoryException();
				obj79 = obj80;
				ex2 = (NullReferenceException)(object)ex3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1DF1BBC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			bool result = default(bool);
			return result;
			IL_09cf:
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
				IWebRequest<T> webRequest = <>7__wrap1;
				if (<>7__wrap1 == null)
				{
					break;
				}
				object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
				nint num = (nint)webRequest;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v6 (Il2CppClass<Kammelna.Server.WebRequests.IWebRequest`1<T>>)+12E]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v6 (Il2CppClass<Kammelna.Server.WebRequests.IWebRequest`1<T>>)+12E]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v6 (Il2CppClass<Kammelna.Server.WebRequests.IWebRequest`1<T>>)+B0]");
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
			object obj = typeof(MemberAchievementClanFeedData) + 2648;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			NotSupportedException ex = default(NotSupportedException);
			ex..ctor();
			throw new OutOfMemoryException();
		}
	}

	public unsafe static IWebRequest<T> ApplyDecorators<T>(IWebRequest<T> webRequest)
	{
		//IL_004f: Expected O, but got I
		//IL_0070: Expected O, but got I
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_018a: Expected O, but got I4
		//IL_00d2: Expected O, but got I
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		//IL_020a: Expected O, but got I
		//IL_021a: Expected O, but got I
		//IL_023c: Expected O, but got I4
		//IL_01ae: Expected O, but got I
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected O, but got Unknown
		//IL_01d6: Expected O, but got I4
		//IL_044f: Expected O, but got I
		//IL_0472: Expected O, but got I
		//IL_047b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0480: Expected O, but got Unknown
		//IL_0129: Expected O, but got I
		//IL_014b: Expected O, but got I4
		//IL_058c: Expected O, but got I4
		//IL_025c: Expected O, but got I
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected O, but got Unknown
		//IL_04d4: Expected O, but got I
		//IL_04dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e2: Expected O, but got Unknown
		//IL_08bd: Expected O, but got I4
		//IL_060c: Expected O, but got I
		//IL_061c: Expected O, but got I
		//IL_063e: Expected O, but got I4
		//IL_05b0: Expected O, but got I
		//IL_05b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05be: Expected O, but got Unknown
		//IL_05d8: Expected O, but got I4
		//IL_02be: Expected O, but got I
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Expected O, but got Unknown
		//IL_02e6: Expected O, but got I4
		//IL_052b: Expected O, but got I
		//IL_054d: Expected O, but got I4
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Expected O, but got Unknown
		//IL_08e1: Expected O, but got I
		//IL_08ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ef: Expected O, but got Unknown
		//IL_065e: Expected O, but got I
		//IL_0667: Unknown result type (might be due to invalid IL or missing references)
		//IL_066c: Expected O, but got Unknown
		//IL_034c: Expected O, but got I
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected O, but got Unknown
		//IL_0374: Expected O, but got I4
		//IL_0943: Expected O, but got I4
		//IL_03be: Expected O, but got I
		//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cc: Expected O, but got Unknown
		//IL_03e6: Expected O, but got I4
		//IL_06c0: Expected O, but got I
		//IL_06c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ce: Expected O, but got Unknown
		//IL_0425: Expected O, but got I
		//IL_0394: Expected O, but got I
		//IL_09bd: Expected O, but got I
		//IL_09d1: Expected O, but got I
		//IL_09da: Unknown result type (might be due to invalid IL or missing references)
		//IL_09df: Expected O, but got Unknown
		//IL_0967: Expected O, but got I
		//IL_0970: Unknown result type (might be due to invalid IL or missing references)
		//IL_0975: Expected O, but got Unknown
		//IL_098f: Expected O, but got I4
		//IL_0406: Expected O, but got I
		//IL_0706: Expected O, but got I
		//IL_070f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0714: Expected O, but got Unknown
		//IL_072e: Expected O, but got I4
		//IL_0796: Expected O, but got I
		//IL_079f: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a4: Expected O, but got Unknown
		//IL_07be: Expected O, but got I4
		//IL_0809: Expected O, but got I
		//IL_0812: Unknown result type (might be due to invalid IL or missing references)
		//IL_0817: Expected O, but got Unknown
		//IL_0831: Expected O, but got I4
		//IL_0871: Expected O, but got I
		//IL_07e3: Expected O, but got I
		//IL_0856: Expected O, but got I
		nint num3;
		nint num4;
		if (webRequest != null)
		{
			Type type = webRequest.GetType();
			object obj = (nint)0 + (nint)1512;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D50A40");
			nint num = 0;
			object obj2 = (nint)0 + (nint)309;
			object obj3 = obj2 & 1;
			if (obj3 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v6 (Il2CppClass<Kammelna.Server.WebRequests.WebRequestExtensions+<>c__0`1<T>>)+E4]");
				bool flag = (nint)0 == 0;
				nint num2 = 0;
				if (!flag)
				{
					goto IL_00c6;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v71 (Il2CppClass<Kammelna.Server.WebRequests.WebRequestExtensions+<>c__0`1<T>>)+E4]");
				bool flag2 = (nint)0 == 0;
				object obj4 = !flag2;
				if (obj4 != null)
				{
					goto IL_00c6;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj5 = (nint)0 + (nint)309;
			object obj6 = obj5 & 1;
			bool flag3 = obj6 == null;
			object obj7 = !flag3;
			num3 = 0;
			num4 = 0;
			if (obj7 != null)
			{
				goto IL_0109;
			}
			goto IL_01f0;
		}
		return (IWebRequest<T>)new NullReferenceException();
		IL_0443:
		object obj8 = (nint)0 + (nint)2304;
		IEnumerable<object> source2 = default(IEnumerable<object>);
		Func<object, int> keySelector;
		IOrderedEnumerable<object> source = Enumerable.OrderBy(source2, keySelector);
		nint num5 = 0;
		object obj9 = (nint)0 + (nint)309;
		object obj10 = obj9 & 1;
		if (obj10 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X0_v10 (Il2CppClass<Kammelna.Server.WebRequests.WebRequestExtensions+<>c__0`1<T>>)+E4]");
			bool flag4 = (nint)0 == 0;
			nint num6 = 0;
			if (!flag4)
			{
				goto IL_04c8;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X0_v41 (Il2CppClass<Kammelna.Server.WebRequests.WebRequestExtensions+<>c__0`1<T>>)+E4]");
			bool flag5 = (nint)0 == 0;
			object obj11 = !flag5;
			if (obj11 != null)
			{
				goto IL_04c8;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj12 = (nint)0 + (nint)309;
		object obj13 = obj12 & 1;
		bool flag6 = obj13 == null;
		object obj14 = !flag6;
		nint num7 = 0;
		nint num8 = 0;
		if (obj14 != null)
		{
			goto IL_050b;
		}
		goto IL_05f2;
		IL_0751:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		object obj16;
		object obj15 = obj16;
		goto IL_0768;
		IL_06b4:
		object obj17 = (nint)0 + (nint)309;
		object obj18 = obj17 & 1;
		bool flag7 = obj18 == null;
		nint num9 = 0;
		if (!flag7)
		{
			goto IL_06f1;
		}
		goto IL_09a3;
		IL_09a3:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X0_v17+B8]");
		object obj19 = 0;
		obj16 = obj19;
		object obj20 = (nint)0 + (nint)309;
		object obj21 = obj20 & 1;
		bool flag8 = obj21 == null;
		nint num10 = 0;
		if (flag8)
		{
			goto IL_0751;
		}
		obj15 = obj19;
		nint num11 = 0;
		goto IL_0768;
		IL_0a23:
		Func<object, object, object> func;
		return (IWebRequest<T>)Enumerable.Aggregate(source, webRequest, func);
		IL_00c6:
		object obj22 = (nint)0 + (nint)309;
		object obj23 = obj22 & 1;
		bool flag9 = obj23 == null;
		num3 = 0;
		num4 = 0;
		if (!flag9)
		{
			goto IL_0109;
		}
		goto IL_01f0;
		IL_01f0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v70+B8]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v81+8]");
		keySelector = (Func<object, int>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v81+8]");
		bool flag10 = (nint)0 == 0;
		object obj25 = !flag10;
		if (obj25 == null)
		{
			goto IL_024a;
		}
		goto IL_0443;
		IL_0109:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v75 (Il2CppClass<Kammelna.Server.WebRequests.WebRequestExtensions+<>c__0`1<T>>)+B8]");
		nint num12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v88 (Il2CppStaticFields<Kammelna.Server.WebRequests.WebRequestExtensions+<>c__0`1<T>>)+8]");
		keySelector = (Func<object, int>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v88 (Il2CppStaticFields<Kammelna.Server.WebRequests.WebRequestExtensions+<>c__0`1<T>>)+8]");
		bool flag11 = (nint)0 == 0;
		object obj26 = !flag11;
		if (obj26 == null)
		{
			goto IL_024a;
		}
		goto IL_0443;
		IL_024a:
		nint num13 = 0;
		object obj27 = (nint)0 + (nint)309;
		object obj28 = obj27 & 1;
		if (obj28 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v49 (Il2CppClass<Kammelna.Server.WebRequests.WebRequestExtensions+<>c__0`1<T>>)+E4]");
			bool flag12 = (nint)0 == 0;
			nint num14 = 0;
			if (!flag12)
			{
				goto IL_02b2;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X0_v50 (Il2CppClass<Kammelna.Server.WebRequests.WebRequestExtensions+<>c__0`1<T>>)+E4]");
			bool flag13 = (nint)0 == 0;
			object obj29 = !flag13;
			if (obj29 != null)
			{
				goto IL_02b2;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj30 = (nint)0 + (nint)309;
		object obj31 = obj30 & 1;
		bool flag14 = obj31 == null;
		nint num15 = 0;
		if (flag14)
		{
			goto IL_02fa;
		}
		goto IL_0309;
		IL_050b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X0_v45 (Il2CppClass<Kammelna.Server.WebRequests.WebRequestExtensions+<>c__0`1<T>>)+B8]");
		nint num16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X9_v18 (Il2CppStaticFields<Kammelna.Server.WebRequests.WebRequestExtensions+<>c__0`1<T>>)+10]");
		func = (Func<object, object, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X9_v18 (Il2CppStaticFields<Kammelna.Server.WebRequests.WebRequestExtensions+<>c__0`1<T>>)+10]");
		bool flag15 = (nint)0 == 0;
		object obj32 = !flag15;
		if (obj32 == null)
		{
			goto IL_064c;
		}
		goto IL_0a23;
		IL_05f2:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X0_v40+B8]");
		object obj33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X9_v14+10]");
		func = (Func<object, object, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X9_v14+10]");
		bool flag16 = (nint)0 == 0;
		object obj34 = !flag16;
		if (obj34 == null)
		{
			goto IL_064c;
		}
		goto IL_0a23;
		IL_04c8:
		object obj35 = (nint)0 + (nint)309;
		object obj36 = obj35 & 1;
		bool flag17 = obj36 == null;
		num7 = 0;
		num8 = 0;
		if (!flag17)
		{
			goto IL_050b;
		}
		goto IL_05f2;
		IL_02b2:
		object obj37 = (nint)0 + (nint)309;
		object obj38 = obj37 & 1;
		bool flag18 = obj38 == null;
		object obj39 = !flag18;
		num15 = 0;
		if (obj39 == null)
		{
			goto IL_02fa;
		}
		goto IL_0309;
		IL_02fa:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		goto IL_0309;
		IL_0309:
		object obj40 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 280;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, int> func2 = default(Func<object, int>);
		func2..ctor((object)<>c__0<T>.<>9, (IntPtr)(nint)__ldftn(<>c__0<T>.<ApplyDecorators>b__0_0));
		object obj41 = (nint)0 + (nint)309;
		object obj42 = obj41 & 1;
		bool flag19 = obj42 == null;
		object obj43 = !flag19;
		nint num17 = 0;
		if (obj43 == null)
		{
			num17 = ((<>c__0<T>)0).<ApplyDecorators>b__0_0((WebRequestDecoratorAttribute)(object)<>c__0<T>.<>9);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X0_v58 (Il2CppClass<Kammelna.Server.WebRequests.WebRequestExtensions+<>c__0`1<T>>)+B8]");
		nint num18 = 0;
		object obj44 = (nint)0 + (nint)309;
		object obj45 = obj44 & 1;
		bool flag20 = obj45 == null;
		object obj46 = !flag20;
		nint num19 = 0;
		if (obj46 == null)
		{
			num19 = ((<>c__0<T>)0).<ApplyDecorators>b__0_0((WebRequestDecoratorAttribute)(object)<>c__0<T>.<>9);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X0_v60 (Il2CppClass<Kammelna.Server.WebRequests.WebRequestExtensions+<>c__0`1<T>>)+B8]");
		<>c__0<T> <>c__ = (<>c__0<T>)((nint)0 + (nint)8);
		int num20 = <>c__.<ApplyDecorators>b__0_0((WebRequestDecoratorAttribute)(object)func2);
		keySelector = func2;
		goto IL_0443;
		IL_0768:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, object, object> func3 = default(Func<object, object, object>);
		func3..ctor(obj15, (IntPtr)(nint)__ldftn(<>c__0<T>.<ApplyDecorators>b__0_1));
		object obj47 = (nint)0 + (nint)309;
		object obj48 = obj47 & 1;
		bool flag21 = obj48 == null;
		object obj49 = !flag21;
		nint num21 = 0;
		if (obj49 == null)
		{
			((Func<IWebRequest<T>, WebRequestDecoratorAttribute, IWebRequest<T>>)0)..ctor(obj15, (IntPtr)(nint)__ldftn(<>c__0<T>.<ApplyDecorators>b__0_1));
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X0_v26 (Il2CppClass<Kammelna.Server.WebRequests.WebRequestExtensions+<>c__0`1<T>>)+B8]");
		nint num22 = 0;
		object obj50 = (nint)0 + (nint)309;
		object obj51 = obj50 & 1;
		bool flag22 = obj51 == null;
		object obj52 = !flag22;
		nint num23 = 0;
		if (obj52 == null)
		{
			((Func<IWebRequest<T>, WebRequestDecoratorAttribute, IWebRequest<T>>)0)..ctor(obj15, (IntPtr)(nint)__ldftn(<>c__0<T>.<ApplyDecorators>b__0_1));
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ X0_v28 (Il2CppClass<Kammelna.Server.WebRequests.WebRequestExtensions+<>c__0`1<T>>)+B8]");
		Func<IWebRequest<T>, WebRequestDecoratorAttribute, IWebRequest<T>> func4 = (Func<IWebRequest<T>, WebRequestDecoratorAttribute, IWebRequest<T>>)((nint)0 + (nint)16);
		func4..ctor((object)func3, (IntPtr)(nint)__ldftn(<>c__0<T>.<ApplyDecorators>b__0_1));
		func = func3;
		goto IL_0a23;
		IL_064c:
		nint num24 = 0;
		object obj53 = (nint)0 + (nint)309;
		object obj54 = obj53 & 1;
		if (obj54 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X0_v15 (Il2CppClass<Kammelna.Server.WebRequests.WebRequestExtensions+<>c__0`1<T>>)+E4]");
			bool flag23 = (nint)0 == 0;
			nint num25 = 0;
			if (!flag23)
			{
				goto IL_06b4;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X0_v19 (Il2CppClass<Kammelna.Server.WebRequests.WebRequestExtensions+<>c__0`1<T>>)+E4]");
			bool flag24 = (nint)0 == 0;
			object obj55 = !flag24;
			if (obj55 != null)
			{
				goto IL_06b4;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj56 = (nint)0 + (nint)309;
		object obj57 = obj56 & 1;
		bool flag25 = obj57 == null;
		object obj58 = !flag25;
		num9 = 0;
		if (obj58 != null)
		{
			goto IL_06f1;
		}
		goto IL_09a3;
		IL_06f1:
		obj16 = <>c__0<T>.<>9;
		object obj59 = (nint)0 + (nint)309;
		object obj60 = obj59 & 1;
		bool flag26 = obj60 == null;
		object obj61 = !flag26;
		num10 = 0;
		obj15 = <>c__0<T>.<>9;
		num11 = 0;
		if (obj61 == null)
		{
			goto IL_0751;
		}
		goto IL_0768;
	}

	public static Coroutine Send<T>(IWebRequest<T> webRequest)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0048: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v10+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CoroutineDummy permanentInstance = CoroutineDummy.PermanentInstance;
		IEnumerator routine = SendWebRequest(webRequest);
		if ((object)permanentInstance != null)
		{
			return permanentInstance.StartCoroutine(routine);
		}
		return (Coroutine)(object)new NullReferenceException();
	}

	private static IEnumerator SendWebRequest<T>(IWebRequest<T> request)
	{
		//IL_0011: Expected O, but got I
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_0039: Expected O, but got I4
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00bf: Expected I4, but got O
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		nint num2 = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		IEnumerator enumerator = default(IEnumerator);
		((<SendWebRequest>d__2<T>)enumerator)..ctor(0);
		if (enumerator != null)
		{
			<SendWebRequest>d__2<T> <SendWebRequest>d__ = (<SendWebRequest>d__2<T>)(enumerator + 32);
			<SendWebRequest>d__ = (<SendWebRequest>d__2<T>)(object)request;
			<SendWebRequest>d__..ctor((int)request);
			return enumerator;
		}
		return (IEnumerator)new NullReferenceException();
	}
}
