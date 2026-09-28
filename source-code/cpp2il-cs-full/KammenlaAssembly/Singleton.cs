using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Formats.Asn1;
using System.Linq;
using System.Threading;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Unity.Services.Authentication.Shared;
using UnityEngine;

public abstract class Singleton<T> : SingletonBase where T : Singleton<T>
{
	private static T _instance;

	private static readonly object _lock;

	public static T Instance
	{
		get
		{
			//IL_0016: Expected O, but got I
			//IL_01f5: Expected O, but got I
			//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0203: Expected O, but got Unknown
			//IL_0095: Expected O, but got I
			//IL_00a5: Expected O, but got I
			//IL_00bb: Expected O, but got I
			//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c9: Expected O, but got Unknown
			//IL_00e8: Expected O, but got I
			//IL_003f: Expected O, but got I
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Expected O, but got Unknown
			//IL_0067: Expected O, but got I4
			//IL_02c4: Expected O, but got I4
			//IL_023c: Expected O, but got I
			//IL_0252: Expected O, but got I
			//IL_025b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0260: Expected O, but got Unknown
			//IL_027a: Expected O, but got I4
			//IL_028a: Expected O, but got I
			//IL_0127: Expected O, but got I
			//IL_0130: Unknown result type (might be due to invalid IL or missing references)
			//IL_0135: Expected O, but got Unknown
			//IL_014f: Expected O, but got I4
			//IL_032f: Expected O, but got I
			//IL_0345: Expected O, but got I
			//IL_034e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0353: Expected O, but got Unknown
			//IL_036d: Expected O, but got I4
			//IL_037d: Expected O, but got I
			//IL_02e8: Expected O, but got I
			//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f6: Expected O, but got Unknown
			//IL_03aa: Expected O, but got I
			//IL_03bf: Expected O, but got I
			//IL_03cb: Expected O, but got I
			//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d9: Expected O, but got Unknown
			//IL_03f3: Expected O, but got I4
			//IL_017d: Expected O, but got I
			//IL_018d: Expected O, but got I
			//IL_01a3: Expected O, but got I
			//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b1: Expected O, but got Unknown
			//IL_0426: Expected O, but got I
			//IL_043c: Expected O, but got I
			//IL_0445: Unknown result type (might be due to invalid IL or missing references)
			//IL_044a: Expected O, but got Unknown
			//IL_0464: Expected O, but got I4
			//IL_04a3: Expected O, but got I4
			//IL_01de: Expected O, but got I
			//IL_04cc: Expected O, but got I
			//IL_04d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_04da: Expected O, but got Unknown
			//IL_04f4: Expected O, but got I4
			//IL_0527: Expected O, but got I
			//IL_053d: Expected O, but got I
			//IL_0546: Unknown result type (might be due to invalid IL or missing references)
			//IL_054b: Expected O, but got Unknown
			//IL_0565: Expected O, but got I4
			//IL_0591: Unknown result type (might be due to invalid IL or missing references)
			//IL_0596: Expected O, but got Unknown
			//IL_05a6: Expected O, but got I
			//IL_05ae: Expected I, but got O
			//IL_05d0: Expected O, but got I4
			//IL_090b: Expected I, but got O
			//IL_092d: Expected O, but got I4
			//IL_0956: Expected O, but got I
			//IL_095f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0964: Expected O, but got Unknown
			//IL_097e: Expected O, but got I4
			//IL_0624: Expected O, but got I
			//IL_062d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0632: Expected O, but got Unknown
			//IL_064c: Expected O, but got I4
			//IL_09a9: Expected O, but got I
			//IL_09cf: Expected O, but got I
			//IL_09d8: Expected O, but got I4
			//IL_067f: Expected O, but got I
			//IL_0695: Expected O, but got I
			//IL_069e: Unknown result type (might be due to invalid IL or missing references)
			//IL_06a3: Expected O, but got Unknown
			//IL_06bd: Expected O, but got I4
			//IL_06fc: Expected O, but got I4
			//IL_0725: Expected O, but got I
			//IL_072e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0733: Expected O, but got Unknown
			//IL_074d: Expected O, but got I4
			//IL_0780: Expected O, but got I
			//IL_0796: Expected O, but got I
			//IL_079f: Unknown result type (might be due to invalid IL or missing references)
			//IL_07a4: Expected O, but got Unknown
			//IL_07be: Expected O, but got I4
			//IL_1c98: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c9d: Expected O, but got Unknown
			//IL_1cb5: Expected O, but got I
			//IL_1cbe: Unknown result type (might be due to invalid IL or missing references)
			//IL_1cc3: Expected O, but got Unknown
			//IL_07ff: Expected O, but got I
			//IL_0822: Expected O, but got I4
			//IL_082b: Expected O, but got I4
			//IL_0864: Expected O, but got I4
			//IL_0875: Expected O, but got I4
			//IL_148d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1492: Expected O, but got Unknown
			//IL_0e10: Expected O, but got I
			//IL_0e19: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e1e: Expected O, but got Unknown
			//IL_0e38: Expected O, but got I4
			//IL_08f0: Expected O, but got I4
			//IL_14b6: Expected O, but got I
			//IL_14bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_14c4: Expected O, but got Unknown
			//IL_14de: Expected O, but got I4
			//IL_1135: Expected O, but got I
			//IL_113e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1143: Expected O, but got Unknown
			//IL_115d: Expected O, but got I4
			//IL_0e74: Expected O, but got I
			//IL_0e7d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e82: Expected O, but got Unknown
			//IL_0e9c: Expected O, but got I4
			//IL_0a41: Expected O, but got I
			//IL_0a4a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a4f: Expected O, but got Unknown
			//IL_0a69: Expected O, but got I4
			//IL_1510: Expected O, but got I4
			//IL_1520: Expected O, but got I
			//IL_1542: Expected O, but got I4
			//IL_118f: Expected O, but got I4
			//IL_119f: Expected O, but got I
			//IL_11c1: Expected O, but got I4
			//IL_0ecf: Expected O, but got I
			//IL_0ee5: Expected O, but got I
			//IL_0eee: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ef3: Expected O, but got Unknown
			//IL_0f0d: Expected O, but got I4
			//IL_0a9b: Expected O, but got I4
			//IL_0aab: Expected O, but got I
			//IL_0acd: Expected O, but got I4
			//IL_1570: Expected O, but got I
			//IL_11ef: Expected O, but got I
			//IL_11fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_1202: Expected O, but got Unknown
			//IL_120c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1211: Expected O, but got Unknown
			//IL_0f4c: Expected O, but got I4
			//IL_0afb: Expected O, but got I
			//IL_0b0b: Expected O, but got I
			//IL_1b7d: Expected O, but got I
			//IL_1b90: Expected O, but got I4
			//IL_123a: Unknown result type (might be due to invalid IL or missing references)
			//IL_123f: Expected O, but got Unknown
			//IL_1269: Expected O, but got I4
			//IL_0f75: Expected O, but got I
			//IL_0f7e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f83: Expected O, but got Unknown
			//IL_0f9d: Expected O, but got I4
			//IL_0b2b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b30: Expected O, but got Unknown
			//IL_0b3c: Expected O, but got I
			//IL_0b60: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b65: Expected O, but got Unknown
			//IL_0b8f: Expected O, but got I4
			//IL_1599: Expected I, but got O
			//IL_15a9: Expected O, but got I
			//IL_15c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_15ca: Expected O, but got Unknown
			//IL_15f4: Expected O, but got I4
			//IL_129b: Expected O, but got I
			//IL_12a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_12a9: Expected O, but got Unknown
			//IL_12c3: Expected O, but got I4
			//IL_0fd0: Expected O, but got I
			//IL_0fe6: Expected O, but got I
			//IL_0fef: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ff4: Expected O, but got Unknown
			//IL_100e: Expected O, but got I4
			//IL_0bc1: Expected O, but got I
			//IL_0bca: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bcf: Expected O, but got Unknown
			//IL_0be9: Expected O, but got I4
			//IL_1628: Unknown result type (might be due to invalid IL or missing references)
			//IL_162d: Expected O, but got Unknown
			//IL_12f6: Expected O, but got I
			//IL_130c: Expected O, but got I
			//IL_1315: Unknown result type (might be due to invalid IL or missing references)
			//IL_131a: Expected O, but got Unknown
			//IL_1334: Expected O, but got I4
			//IL_103b: Expected O, but got I
			//IL_104f: Expected O, but got I
			//IL_1058: Unknown result type (might be due to invalid IL or missing references)
			//IL_105d: Expected O, but got Unknown
			//IL_1077: Expected O, but got I4
			//IL_0c2a: Expected O, but got I
			//IL_0c33: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c38: Expected O, but got Unknown
			//IL_0c52: Expected O, but got I4
			//IL_1373: Expected O, but got I4
			//IL_10aa: Expected O, but got I
			//IL_10c0: Expected O, but got I
			//IL_10c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_10ce: Expected O, but got Unknown
			//IL_10e8: Expected O, but got I4
			//IL_0c85: Expected O, but got I
			//IL_0c9b: Expected O, but got I
			//IL_0ca4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ca9: Expected O, but got Unknown
			//IL_0cc3: Expected O, but got I4
			//IL_1bbc: Expected O, but got I4
			//IL_139c: Expected O, but got I
			//IL_13a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_13aa: Expected O, but got Unknown
			//IL_13c4: Expected O, but got I4
			//IL_0cf6: Expected O, but got I
			//IL_0cfe: Expected I, but got O
			//IL_0d0a: Expected O, but got I
			//IL_0d13: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d18: Expected O, but got Unknown
			//IL_0d32: Expected O, but got I4
			//IL_167c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1681: Expected O, but got Unknown
			//IL_16ab: Expected O, but got I4
			//IL_13f7: Expected O, but got I
			//IL_140d: Expected O, but got I
			//IL_1416: Unknown result type (might be due to invalid IL or missing references)
			//IL_141b: Expected O, but got Unknown
			//IL_1435: Expected O, but got I4
			//IL_143e: Expected O, but got I4
			//IL_1ada: Expected O, but got I4
			//IL_1aeb: Expected O, but got I4
			//IL_0d65: Expected O, but got I
			//IL_0d7f: Expected O, but got I
			//IL_0d88: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d8d: Expected O, but got Unknown
			//IL_0da7: Expected O, but got I4
			//IL_0dda: Expected O, but got I
			//IL_146c: Expected O, but got I4
			//IL_1b0a: Expected O, but got I4
			//IL_1b13: Expected O, but got I4
			//IL_177e: Expected O, but got I
			//IL_1787: Unknown result type (might be due to invalid IL or missing references)
			//IL_178c: Expected O, but got Unknown
			//IL_17a6: Expected O, but got I4
			//IL_16f6: Expected I, but got O
			//IL_1718: Expected O, but got I4
			//IL_17df: Expected O, but got I
			//IL_17e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_17ed: Expected O, but got Unknown
			//IL_1807: Expected O, but got I4
			//IL_183a: Expected O, but got I
			//IL_1850: Expected O, but got I
			//IL_1859: Unknown result type (might be due to invalid IL or missing references)
			//IL_185e: Expected O, but got Unknown
			//IL_1878: Expected O, but got I4
			//IL_18b7: Expected O, but got I4
			//IL_18e0: Expected O, but got I
			//IL_18e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_18ee: Expected O, but got Unknown
			//IL_1908: Expected O, but got I4
			//IL_193b: Expected O, but got I
			//IL_1951: Expected O, but got I
			//IL_195a: Unknown result type (might be due to invalid IL or missing references)
			//IL_195f: Expected O, but got Unknown
			//IL_1979: Expected O, but got I4
			//IL_19a6: Expected O, but got I
			//IL_19ba: Expected O, but got I
			//IL_19c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_19c8: Expected O, but got Unknown
			//IL_19e2: Expected O, but got I4
			//IL_1a15: Expected O, but got I
			//IL_1a2b: Expected O, but got I
			//IL_1a34: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a39: Expected O, but got Unknown
			//IL_1a53: Expected O, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E1DB7]");
			object obj = (nint)0 & (nint)1;
			if (obj != null)
			{
				object obj2 = (nint)0 + (nint)309;
				object obj3 = obj2 & 1;
				bool flag = obj3 == null;
				object obj4 = !flag;
				nint num = 0;
				if (obj4 == null)
				{
					goto IL_007b;
				}
			}
			else
			{
				_ = 1;
				object obj5 = (nint)0 + (nint)309;
				object obj6 = obj5 & 1;
				bool flag2 = obj6 == null;
				nint num = 0;
				if (flag2)
				{
					goto IL_007b;
				}
			}
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v180 (Il2CppRgctx<Singleton`1>)+28]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v180 (Il2CppRgctx<Singleton`1>)+28]");
			object obj8 = (nint)0 + (nint)309;
			object obj9 = obj8 & 1;
			bool flag3 = obj9 == null;
			object obj10 = !flag3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v180 (Il2CppRgctx<Singleton`1>)+28]");
			object obj11 = 0;
			if (obj10 != null)
			{
				goto IL_00f6;
			}
			goto IL_0298;
			IL_1b56:
			NullReferenceException ex = new NullReferenceException();
			goto IL_1bc7;
			IL_1a97:
			bool lockTaken = default(bool);
			bool flag4 = !lockTaken;
			object obj13 = default(object);
			object obj12 = obj13;
			object obj15 = default(object);
			object obj14 = obj15;
			nint num3 = default(nint);
			IntPtr intPtr = num3;
			string text2 = default(string);
			string text = text2;
			Action<object> action2;
			Action<object> action = action2;
			object obj16 = 0;
			object obj17;
			T result = (T)obj17;
			object obj18 = 0;
			object obj19;
			object obj20;
			object obj21;
			if (!flag4)
			{
				obj19 = obj20;
				obj16 = 0;
				obj21 = 0;
				goto IL_0883;
			}
			goto IL_08d6;
			IL_08d6:
			bool flag5 = obj18 == null;
			object obj22 = !flag5;
			if (obj22 == null)
			{
				return result;
			}
			OutOfMemoryException ex2 = new OutOfMemoryException();
			obj13 = obj12;
			obj15 = obj14;
			num3 = intPtr;
			text2 = text;
			action2 = action;
			UnityEngine.Object obj23;
			string text3 = (string)(object)obj23;
			goto IL_1b56;
			IL_007b:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v272+C0]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v196+28]");
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v196+28]");
			object obj25 = (nint)0 + (nint)309;
			object obj26 = obj25 & 1;
			bool flag6 = obj26 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v196+28]");
			obj11 = 0;
			if (!flag6)
			{
				goto IL_00f6;
			}
			goto IL_0298;
			IL_0298:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v221+E4]");
			bool flag7 = (nint)0 == 0;
			object obj27 = !flag7;
			if (obj27 != null)
			{
				goto IL_011b;
			}
			goto IL_02d2;
			IL_00f6:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v221+E4]");
			if ((nint)0 != 0)
			{
				goto IL_011b;
			}
			goto IL_02d2;
			IL_02d2:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj28 = (nint)0 + (nint)309;
			object obj29 = obj28 & 1;
			bool flag8 = obj29 == null;
			nint num4 = 0;
			if (flag8)
			{
				goto IL_0163;
			}
			goto IL_0319;
			IL_011b:
			object obj30 = (nint)0 + (nint)309;
			object obj31 = obj30 & 1;
			bool flag9 = obj31 == null;
			object obj32 = !flag9;
			num4 = 0;
			if (obj32 == null)
			{
				goto IL_0163;
			}
			goto IL_0319;
			IL_0319:
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v171 (Il2CppRgctx<Singleton`1>)+28]");
			object obj33 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v171 (Il2CppRgctx<Singleton`1>)+28]");
			object obj34 = (nint)0 + (nint)309;
			object obj35 = obj34 & 1;
			bool flag10 = obj35 == null;
			object obj36 = !flag10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v171 (Il2CppRgctx<Singleton`1>)+28]");
			object obj37 = 0;
			if (obj36 == null)
			{
				goto IL_038b;
			}
			goto IL_039a;
			IL_0163:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X0_v266+C0]");
			object obj38 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v187+28]");
			obj33 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v187+28]");
			object obj39 = (nint)0 + (nint)309;
			object obj40 = obj39 & 1;
			if (obj40 == null)
			{
				goto IL_038b;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v187+28]");
			obj37 = 0;
			goto IL_039a;
			IL_038b:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			goto IL_039a;
			IL_0883:
			object obj41 = default(object);
			Monitor.Exit(obj41);
			obj12 = obj13;
			obj14 = obj15;
			intPtr = num3;
			text = text2;
			action = action2;
			obj20 = obj19;
			obj23 = null;
			result = (T)obj17;
			obj18 = obj21;
			goto IL_08d6;
			IL_039a:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X0_v1+B8]");
			object obj42 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v3+8]");
			Monitor.Enter(0, ref lockTaken);
			object obj43 = (nint)0 + (nint)309;
			object obj44 = obj43 & 1;
			bool flag11 = obj44 == null;
			object obj45 = !flag11;
			if (obj45 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			}
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X8_v8 (Il2CppRgctx<Singleton`1>)+28]");
			object obj46 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X8_v8 (Il2CppRgctx<Singleton`1>)+28]");
			object obj47 = (nint)0 + (nint)309;
			object obj48 = obj47 & 1;
			bool flag12 = obj48 == null;
			object obj49 = !flag12;
			if (obj49 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X0_v6+E4]");
			bool flag13 = (nint)0 == 0;
			object obj50 = !flag13;
			if (obj50 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj51 = (nint)0 + (nint)309;
			object obj52 = obj51 & 1;
			bool flag14 = obj52 == null;
			object obj53 = !flag14;
			if (obj53 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			}
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X8_v14 (Il2CppRgctx<Singleton`1>)+28]");
			object obj54 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X8_v14 (Il2CppRgctx<Singleton`1>)+28]");
			object obj55 = (nint)0 + (nint)309;
			object obj56 = obj55 & 1;
			bool flag15 = obj56 == null;
			object obj57 = !flag15;
			if (obj57 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			}
			action2 = (Action<object>)(typeof(MemberAchievementClanFeedData) + 2976);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X0_v11+B8]");
			object obj58 = 0;
			nint num8 = (nint)action2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X0_v12 (Il2CppClass<System.Action`1<System.Object>>)+E4]");
			bool flag16 = (nint)0 == 0;
			object obj59 = !flag16;
			if (obj59 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if ((UnityEngine.Object)obj58 != null)
			{
				object obj60 = (nint)0 + (nint)309;
				object obj61 = obj60 & 1;
				bool flag17 = obj61 == null;
				object obj62 = !flag17;
				if (obj62 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				}
				nint num9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X8_v159 (Il2CppRgctx<Singleton`1>)+28]");
				object obj63 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X8_v159 (Il2CppRgctx<Singleton`1>)+28]");
				object obj64 = (nint)0 + (nint)309;
				object obj65 = obj64 & 1;
				bool flag18 = obj65 == null;
				object obj66 = !flag18;
				if (obj66 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X0_v200+E4]");
				bool flag19 = (nint)0 == 0;
				object obj67 = !flag19;
				if (obj67 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj68 = (nint)0 + (nint)309;
				object obj69 = obj68 & 1;
				bool flag20 = obj69 == null;
				object obj70 = !flag20;
				if (obj70 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				}
				nint num10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X8_v165 (Il2CppRgctx<Singleton`1>)+28]");
				object obj71 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X8_v165 (Il2CppRgctx<Singleton`1>)+28]");
				object obj72 = (nint)0 + (nint)309;
				object obj73 = obj72 & 1;
				bool flag21 = obj73 == null;
				object obj74 = !flag21;
				obj19 = null;
				obj23 = null;
				if (obj74 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
					obj19 = null;
					obj23 = null;
				}
			}
			else
			{
				nint num11 = (nint)action2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X0_v27 (Il2CppClass<System.Action`1<System.Object>>)+E4]");
				bool flag22 = (nint)0 == 0;
				object obj75 = !flag22;
				if (obj75 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj76 = (nint)0 + (nint)309;
				object obj77 = obj76 & 1;
				bool flag23 = obj77 == null;
				object obj78 = !flag23;
				if (obj78 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				}
				nint num12 = 0;
				Action<object> action3 = (Action<object>)num12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9750");
				IEnumerable<object> enumerable = default(IEnumerable<object>);
				bool flag24 = enumerable == null;
				obj20 = null;
				text3 = (string)num12;
				obj16 = 0;
				if (flag24)
				{
					goto IL_1b56;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X0_v32 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X0_v32 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
					bool flag25 = (nint)0 < (nint)2;
					obj20 = null;
					if (!flag25)
					{
						object obj79 = (nint)0 + (nint)309;
						object obj80 = obj79 & 1;
						bool flag26 = obj80 == null;
						object obj81 = !flag26;
						if (obj81 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
						}
						nint num13 = 0;
						object obj82 = 153100288 + 1024;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ X8_v125+E0]");
						object obj83 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v561 @ X0_v154+E4]");
						bool flag27 = (nint)0 == 0;
						object obj84 = !flag27;
						if (obj84 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v557 @ X8_v123 (Il2CppRgctx<Singleton`1>)+10]");
						Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
						object format = (nint)0 + (nint)3584;
						string text4 = string.Format((string)format, typeFromHandle);
						object obj85 = "WhiteSmoke" + 3552;
						object obj86 = (nint)0 + (nint)4072;
						string message = (string)obj85 + text4 + (string)obj86;
						object obj87 = typeof(DataRelation) + 856;
						object obj88 = obj87;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ X0_v162+E4]");
						bool flag28 = (nint)0 == 0;
						object obj89 = !flag28;
						if (obj89 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Debug.LogError(message);
						object obj90 = (nint)0 + (nint)309;
						object obj91 = obj90 & 1;
						bool flag29 = obj91 == null;
						object obj92 = !flag29;
						if (obj92 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
						}
						nint num14 = 0;
						IEnumerable<object> enumerable2 = Enumerable.Skip(enumerable, 1);
						object obj93 = (nint)0 + (nint)309;
						object obj94 = obj93 & 1;
						bool flag30 = obj94 == null;
						object obj95 = !flag30;
						if (obj95 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
						}
						nint num15 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v825 @ X8_v141 (Il2CppRgctx<Singleton`1>)+48]");
						object obj96 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v825 @ X8_v141 (Il2CppRgctx<Singleton`1>)+48]");
						object obj97 = (nint)0 + (nint)309;
						object obj98 = obj97 & 1;
						bool flag31 = obj98 == null;
						object obj99 = !flag31;
						if (obj99 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj100 = (nint)0 + (nint)1120;
						num3 = (nint)obj100;
						object obj101 = (nint)0 + (nint)309;
						object obj102 = obj101 & 1;
						bool flag32 = obj102 == null;
						object obj103 = !flag32;
						if (obj103 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
						}
						nint num16 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v884 @ X8_v148 (Il2CppRgctx<Singleton`1>)+50]");
						obj15 = 0;
						Action<object> action4 = default(Action<object>);
						action4..ctor((object)null, (IntPtr)num3);
						object obj104 = (nint)0 + (nint)309;
						object obj105 = obj104 & 1;
						bool flag33 = obj105 == null;
						object obj106 = !flag33;
						if (obj106 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
						}
						nint num17 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X8_v151 (Il2CppRgctx<Singleton`1>)+58]");
						obj20 = 0;
						ArraysExtensions.ForEach(enumerable2, action4);
						text2 = (string)(object)enumerable2;
						action2 = action4;
						action3 = action4;
					}
					object obj107 = (nint)0 + (nint)309;
					object obj108 = obj107 & 1;
					bool flag34 = obj108 == null;
					object obj109 = !flag34;
					if (obj109 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
					}
					nint num18 = 0;
					object obj110 = Enumerable.First(enumerable);
					object obj111 = (nint)0 + (nint)309;
					object obj112 = obj111 & 1;
					bool flag35 = obj112 == null;
					object obj113 = !flag35;
					if (obj113 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
					}
					nint num19 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X8_v106 (Il2CppRgctx<Singleton`1>)+28]");
					object obj114 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X8_v106 (Il2CppRgctx<Singleton`1>)+28]");
					object obj115 = (nint)0 + (nint)309;
					object obj116 = obj115 & 1;
					bool flag36 = obj116 == null;
					object obj117 = !flag36;
					if (obj117 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v682 @ X0_v132+E4]");
					bool flag37 = (nint)0 == 0;
					object obj118 = !flag37;
					if (obj118 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj119 = (nint)0 + (nint)309;
					object obj120 = obj119 & 1;
					bool flag38 = obj120 == null;
					object obj121 = !flag38;
					if (obj121 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
					}
					nint num20 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v733 @ X8_v112 (Il2CppRgctx<Singleton`1>)+28]");
					object obj122 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v733 @ X8_v112 (Il2CppRgctx<Singleton`1>)+28]");
					object obj123 = (nint)0 + (nint)309;
					object obj124 = obj123 & 1;
					bool flag39 = obj124 == null;
					object obj125 = !flag39;
					if (obj125 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v750 @ X0_v137+B8]");
					object obj126 = 0;
					obj126 = obj110;
					object obj127 = (nint)0 + (nint)309;
					object obj128 = obj127 & 1;
					bool flag40 = obj128 == null;
					object obj129 = !flag40;
					if (obj129 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
					}
					nint num21 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v782 @ X8_v118 (Il2CppRgctx<Singleton`1>)+28]");
					object obj130 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v782 @ X8_v118 (Il2CppRgctx<Singleton`1>)+28]");
					object obj131 = (nint)0 + (nint)309;
					object obj132 = obj131 & 1;
					bool flag41 = obj132 == null;
					object obj133 = !flag41;
					if (obj133 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					obj23 = (UnityEngine.Object)obj110;
					obj17 = obj110;
					goto IL_1a97;
				}
				object obj134 = typeof(System.Formats.Asn1.SetOfValueComparer) + 536;
				object obj135 = obj134;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ X8_v33+B8]");
				object obj136 = 0;
				object obj137 = obj136 & 1;
				if (obj137 == null)
				{
					object obj138 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2096;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					GameObject gameObject = default(GameObject);
					gameObject..ctor();
					object obj139 = (nint)0 + (nint)309;
					object obj140 = obj139 & 1;
					bool flag42 = obj140 == null;
					object obj141 = !flag42;
					if (obj141 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
					}
					nint num22 = 0;
					object obj142 = 153100288 + 1024;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v697 @ X8_v42+E0]");
					object obj143 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v698 @ X0_v39+E4]");
					bool flag43 = (nint)0 == 0;
					object obj144 = !flag43;
					if (obj144 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v695 @ X8_v40 (Il2CppRgctx<Singleton`1>)+10]");
					Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
					if ((object)typeFromHandle2 != null)
					{
						nint num23 = (nint)typeFromHandle2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v764 @ X8_v44 (Il2CppClass<System.Type>)+1B8]");
						obj13 = 0;
						string text5 = typeFromHandle2.Name;
						object obj145 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
						object obj146 = obj145;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v769 @ X0_v45+E4]");
						bool flag44 = (nint)0 == 0;
						object obj147 = !flag44;
						if (obj147 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						string text6 = StringsExtensions.ToSentenceCase(text5);
						object obj148 = "&action=sign-up" + 2544;
						string text7 = (string)obj148 + text6;
						if ((object)gameObject != null)
						{
							gameObject.name = text7;
							object obj149 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
							object obj150 = obj149;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v878 @ X0_v53+E4]");
							bool flag45 = (nint)0 == 0;
							object obj151 = !flag45;
							if (obj151 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							if (Application.isPlaying)
							{
								nint num24 = (nint)action2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v901 @ X0_v86 (Il2CppClass<System.Action`1<System.Object>>)+E4]");
								bool flag46 = (nint)0 == 0;
								object obj152 = !flag46;
								if (obj152 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								UnityEngine.Object.DontDestroyOnLoad(gameObject);
								obj20 = null;
								HideFlags hideFlags = HideFlags.None;
							}
							else
							{
								gameObject.hideFlags = HideFlags.HideAndDontSave;
								obj20 = null;
								HideFlags hideFlags = HideFlags.HideAndDontSave;
							}
							object obj153 = (nint)0 + (nint)309;
							object obj154 = obj153 & 1;
							bool flag47 = obj154 == null;
							object obj155 = !flag47;
							if (obj155 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
							}
							nint num25 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32E24");
							object obj156 = (nint)0 + (nint)309;
							object obj157 = obj156 & 1;
							bool flag48 = obj157 == null;
							object obj158 = !flag48;
							if (obj158 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
							}
							nint num26 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v936 @ X8_v59 (Il2CppRgctx<Singleton`1>)+28]");
							object obj159 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v936 @ X8_v59 (Il2CppRgctx<Singleton`1>)+28]");
							object obj160 = (nint)0 + (nint)309;
							object obj161 = obj160 & 1;
							bool flag49 = obj161 == null;
							object obj162 = !flag49;
							if (obj162 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v944 @ X0_v65+E4]");
							bool flag50 = (nint)0 == 0;
							object obj163 = !flag50;
							if (obj163 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							object obj164 = (nint)0 + (nint)309;
							object obj165 = obj164 & 1;
							bool flag51 = obj165 == null;
							object obj166 = !flag51;
							if (obj166 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
							}
							nint num27 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v958 @ X8_v65 (Il2CppRgctx<Singleton`1>)+28]");
							object obj167 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v958 @ X8_v65 (Il2CppRgctx<Singleton`1>)+28]");
							object obj168 = (nint)0 + (nint)309;
							object obj169 = obj168 & 1;
							bool flag52 = obj169 == null;
							object obj170 = !flag52;
							if (obj170 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v966 @ X0_v70+B8]");
							object obj171 = 0;
							object obj172 = default(object);
							obj171 = obj172;
							object obj173 = (nint)0 + (nint)309;
							object obj174 = obj173 & 1;
							bool flag53 = obj174 == null;
							object obj175 = !flag53;
							if (obj175 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
							}
							nint num28 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v976 @ X8_v71 (Il2CppRgctx<Singleton`1>)+28]");
							object obj176 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v976 @ X8_v71 (Il2CppRgctx<Singleton`1>)+28]");
							object obj177 = (nint)0 + (nint)309;
							object obj178 = obj177 & 1;
							bool flag54 = obj178 == null;
							object obj179 = !flag54;
							if (obj179 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							text2 = text5;
							obj23 = (UnityEngine.Object)obj172;
							obj17 = obj172;
							goto IL_1a97;
						}
						ex = new NullReferenceException();
						text2 = text5;
						obj20 = null;
						text3 = text7;
						obj16 = 0;
					}
					else
					{
						ex = new NullReferenceException();
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v695 @ X8_v40 (Il2CppRgctx<Singleton`1>)+10]");
						text2 = (string)0;
						obj20 = null;
						text3 = null;
						obj16 = 0;
					}
					goto IL_1bc7;
				}
				object obj180 = (nint)0 + (nint)309;
				object obj181 = obj180 & 1;
				bool flag55 = obj181 == null;
				object obj182 = !flag55;
				if (obj182 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				}
				nint num29 = 0;
				object obj183 = 153100288 + 1024;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v634 @ X8_v79+E0]");
				object obj184 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v635 @ X0_v96+E4]");
				bool flag56 = (nint)0 == 0;
				object obj185 = !flag56;
				if (obj185 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v631 @ X8_v77 (Il2CppRgctx<Singleton`1>)+10]");
				Type typeFromHandle3 = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
				object format2 = "WhiteSmoke" + 4064;
				object arg = "SetRoomVariables request error" + 928;
				string message2 = string.Format((string)format2, arg, typeFromHandle3);
				object obj186 = typeof(DataRelation) + 856;
				object obj187 = obj186;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v719 @ X0_v102+E4]");
				bool flag57 = (nint)0 == 0;
				object obj188 = !flag57;
				if (obj188 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Debug.LogWarning(message2);
				object obj189 = (nint)0 + (nint)309;
				object obj190 = obj189 & 1;
				bool flag58 = obj190 == null;
				object obj191 = !flag58;
				if (obj191 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				}
				nint num30 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v791 @ X8_v90 (Il2CppRgctx<Singleton`1>)+28]");
				object obj192 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v791 @ X8_v90 (Il2CppRgctx<Singleton`1>)+28]");
				object obj193 = (nint)0 + (nint)309;
				object obj194 = obj193 & 1;
				bool flag59 = obj194 == null;
				object obj195 = !flag59;
				if (obj195 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v815 @ X0_v108+E4]");
				bool flag60 = (nint)0 == 0;
				object obj196 = !flag60;
				if (obj196 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj197 = (nint)0 + (nint)309;
				object obj198 = obj197 & 1;
				bool flag61 = obj198 == null;
				object obj199 = !flag61;
				if (obj199 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				}
				nint num31 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v862 @ X8_v96 (Il2CppRgctx<Singleton`1>)+28]");
				object obj71 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v862 @ X8_v96 (Il2CppRgctx<Singleton`1>)+28]");
				object obj200 = (nint)0 + (nint)309;
				object obj201 = obj200 & 1;
				bool flag62 = obj201 == null;
				object obj202 = !flag62;
				obj15 = 0;
				obj19 = typeFromHandle3;
				obj23 = null;
				if (obj202 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
					obj15 = 0;
					obj19 = typeFromHandle3;
					obj23 = null;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X0_v196+B8]");
			object obj203 = 0;
			obj17 = obj203;
			bool flag63 = !lockTaken;
			obj16 = 0;
			obj21 = 0;
			obj12 = obj13;
			obj14 = obj15;
			intPtr = num3;
			text = text2;
			action = action2;
			obj20 = obj19;
			obj16 = 0;
			result = (T)obj203;
			obj18 = 0;
			if (!flag63)
			{
				goto IL_0883;
			}
			goto IL_08d6;
			IL_1bc7:
			if ((nint)text3 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				object obj204 = default(object);
				obj21 = obj204;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				bool flag64 = lockTaken;
				obj19 = obj20;
				obj16 = obj204;
				obj17 = null;
				if (flag64)
				{
					goto IL_0883;
				}
				obj12 = obj13;
				obj14 = obj15;
				intPtr = num3;
				text = text2;
				action = action2;
				obj23 = (UnityEngine.Object)(object)text3;
				obj16 = obj204;
				result = null;
				obj18 = obj204;
				goto IL_08d6;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C982FC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			T result2 = default(T);
			return result2;
		}
	}

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_024b: Expected O, but got I4
		//IL_01f1: Expected I, but got O
		//IL_0201: Expected O, but got I
		//IL_0211: Expected O, but got I
		//IL_0292: Expected O, but got I4
		//IL_00cb: Expected O, but got I4
		//IL_00db: Expected O, but got I
		//IL_00fd: Expected O, but got I4
		//IL_012b: Expected O, but got I
		//IL_013b: Expected O, but got I
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_016c: Expected O, but got I
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected O, but got Unknown
		//IL_01bf: Expected O, but got I4
		//IL_02c1: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E1DB6]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 == null)
		{
			goto IL_021b;
		}
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+E4]");
		if ((nint)0 != 0)
		{
			goto IL_0074;
		}
		goto IL_0259;
		IL_021b:
		_ = 1;
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 != null)
		{
			goto IL_0074;
		}
		goto IL_0259;
		IL_0074:
		nint num = 0;
		IntPtr intPtr = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9750");
		goto IL_0091;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v23+18]");
		if ((nint)0 >= (nint)2)
		{
			nint num2 = 0;
			object obj5 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v15+E0]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v26+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v13 (Il2CppRgctx<Singleton`1>)+10]");
			Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
			object format = (nint)0 + (nint)3584;
			string text = string.Format((string)format, typeFromHandle);
			object obj8 = "WhiteSmoke" + 3552;
			object obj9 = (nint)0 + (nint)4072;
			string text2 = (string)obj8 + text + (string)obj9;
			object obj10 = typeof(DataRelation) + 856;
			object obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v25+E4]");
			bool flag3 = (nint)0 == 0;
			object obj12 = !flag3;
			object message = text2;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				message = text2;
			}
			Debug.LogError(message);
			object obj13 = 0;
		}
		nint num3 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v11 (Il2CppClass<Singleton`1<T>>)+178]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v11 (Il2CppClass<Singleton`1<T>>)+180]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v124 @ X2_v2 (should have been resolved before IL gen)");
		goto IL_021b;
		IL_0259:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9750");
		object obj16 = default(object);
		bool flag4 = obj16 == null;
		object obj17 = !flag4;
		intPtr = num4;
		if (obj17 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0091;
	}

	protected virtual void OnAwake()
	{
	}

	static Singleton()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0300: Expected O, but got I
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Expected O, but got Unknown
		//IL_018e: Expected O, but got I
		//IL_019e: Expected O, but got I
		//IL_01b4: Expected O, but got I
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected O, but got Unknown
		//IL_01dc: Expected O, but got I4
		//IL_01ec: Expected O, but got I
		//IL_0090: Expected O, but got I
		//IL_00a1: Expected O, but got I
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		//IL_002f: Expected O, but got I
		//IL_0045: Expected O, but got I
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0072: Expected O, but got I
		//IL_027b: Expected O, but got I
		//IL_028b: Expected O, but got I
		//IL_02a1: Expected O, but got I
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected O, but got Unknown
		//IL_0214: Expected O, but got I
		//IL_0225: Expected O, but got I
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected O, but got Unknown
		//IL_024d: Expected O, but got I4
		//IL_00e8: Expected O, but got I
		//IL_00fe: Expected O, but got I
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected O, but got Unknown
		//IL_0126: Expected O, but got I4
		//IL_0136: Expected O, but got I
		//IL_0169: Expected O, but got I
		//IL_02dc: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 2968;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = (nint)0 + (nint)309;
		object obj4 = obj3 & 1;
		if (obj4 != null)
		{
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v27 (Il2CppRgctx<Singleton`1>)+28]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v27 (Il2CppRgctx<Singleton`1>)+28]");
			object obj6 = (nint)0 + (nint)309;
			object obj7 = obj6 & 1;
			bool flag = obj7 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v27 (Il2CppRgctx<Singleton`1>)+28]");
			object obj8 = 0;
			if (!flag)
			{
				goto IL_0080;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v11+C0]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v13+28]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v13+28]");
			object obj10 = (nint)0 + (nint)309;
			object obj11 = obj10 & 1;
			bool flag2 = obj11 == null;
			object obj12 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v13+28]");
			object obj8 = 0;
			if (obj12 != null)
			{
				goto IL_0080;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v9+B8]");
		object obj13 = 0;
		object obj14 = (nint)0 + (nint)309;
		object obj15 = obj14 & 1;
		bool flag3 = obj15 == null;
		object obj16 = !flag3;
		nint num2 = 0;
		if (obj16 != null)
		{
			goto IL_00d2;
		}
		goto IL_0261;
		IL_0144:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		goto IL_0153;
		IL_00d2:
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v20 (Il2CppRgctx<Singleton`1>)+28]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v20 (Il2CppRgctx<Singleton`1>)+28]");
		object obj18 = (nint)0 + (nint)309;
		object obj19 = obj18 & 1;
		bool flag4 = obj19 == null;
		object obj20 = !flag4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v20 (Il2CppRgctx<Singleton`1>)+28]");
		object obj21 = 0;
		if (obj20 == null)
		{
			goto IL_0144;
		}
		goto IL_0153;
		IL_0153:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v13+B8]");
		object obj22 = (nint)0 + (nint)8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return;
		IL_0080:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v20+B8]");
		object obj23 = 0;
		object obj24 = (nint)0 + (nint)309;
		object obj25 = obj24 & 1;
		bool flag5 = obj25 == null;
		num2 = 0;
		if (!flag5)
		{
			goto IL_00d2;
		}
		goto IL_0261;
		IL_0261:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v6+C0]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v6+28]");
		obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v6+28]");
		object obj27 = (nint)0 + (nint)309;
		object obj28 = obj27 & 1;
		if (obj28 == null)
		{
			goto IL_0144;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v6+28]");
		obj21 = 0;
		goto IL_0153;
	}
}
