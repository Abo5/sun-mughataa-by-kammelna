using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data;
using System.Dynamic.Utils;
using System.Formats.Asn1;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Rendering;

[Serializable]
public class EmoteSaveData
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<int, int> <>9__12_1;

		public static Func<IGrouping<int, int>, int> <>9__12_2;

		public static Func<IGrouping<int, int>, int> <>9__12_3;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(DebugUI.BitField) + 1360;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal int <GetMostUsedEmotes_NotSetManually_Ordered>b__12_1(int id)
		{
			return id;
		}

		internal int <GetMostUsedEmotes_NotSetManually_Ordered>b__12_2(IGrouping<int, int> g)
		{
			return Enumerable.Count(g);
		}

		internal int <GetMostUsedEmotes_NotSetManually_Ordered>b__12_3(IGrouping<int, int> g)
		{
			//IL_0124: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0021: Expected I, but got O
			//IL_0031: Expected O, but got I
			//IL_00cf: Expected O, but got I
			//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e6: Expected O, but got Unknown
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f4: Expected O, but got Unknown
			//IL_010c: Expected O, but got I
			//IL_006c: Expected O, but got I
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected O, but got Unknown
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Expected O, but got Unknown
			nint num;
			object obj3 = default(object);
			if (g != null)
			{
				object obj = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 1520;
				num = (nint)g;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<System.Linq.IGrouping`2<System.Int32, System.Int32>>)+12E]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<System.Linq.IGrouping`2<System.Int32, System.Int32>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00ad;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<System.Linq.IGrouping`2<System.Int32, System.Int32>>)+B0]");
				obj3 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X10_v4-8]");
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
				goto IL_00d9;
			}
			goto IL_0116;
			IL_0116:
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
			IL_00ad:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj5 = default(object);
			object obj4 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v4+8]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v107 @ X2_v2 (should have been resolved before IL gen)");
			goto IL_00d9;
			IL_00d9:
			object obj7 = num + obj3;
			object obj8 = obj7 + 312;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v6+8]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v118 @ X2_v3 (should have been resolved before IL gen)");
			goto IL_0116;
		}
	}

	private sealed class <>c__DisplayClass12_0
	{
		public EmoteSaveData savedData;

		internal bool <GetMostUsedEmotes_NotSetManually_Ordered>b__0(int id)
		{
			//IL_005f: Expected I4, but got O
			EmoteSaveData emoteSaveData = savedData;
			if (savedData != null && emoteSaveData.manuallyOrderedEmotes != null)
			{
				int item = default(int);
				bool flag = emoteSaveData.manuallyOrderedEmotes.Contains(item);
				return (byte)((flag ? 1u : 0u) ^ 1u) != 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private const string EmoteFolderName = "EmoteSorting";

	private const string EmotesFileFormat = "emotes_{0}.json";

	private const int LatestUsedEmotesThreshold = 20;

	public const int FeaturedSlotsCount = 6;

	private List<int> manuallyOrderedEmotes;

	private List<int> latestUsedEmotes;

	public unsafe static List<int> GetPersonalizedEmotes(int userId)
	{
		//IL_0010: Expected O, but got I
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0030: Expected O, but got I
		//IL_0680: Expected I4, but got O
		//IL_004e: Expected O, but got I4
		//IL_007a: Expected O, but got I4
		//IL_0095: Expected O, but got I
		//IL_05f7: Expected I4, but got O
		//IL_0238: Expected O, but got I
		//IL_0240: Expected I4, but got O
		//IL_0263: Expected O, but got I4
		//IL_0573: Expected O, but got I4
		//IL_00d1: Expected O, but got I
		//IL_00d9: Expected O, but got Ref
		//IL_0291: Expected I4, but got O
		//IL_02d5: Expected O, but got I4
		//IL_014e: Expected O, but got I
		//IL_0163: Expected O, but got I
		//IL_045f: Expected O, but got I
		//IL_0467: Expected I4, but got O
		//IL_048a: Expected O, but got I4
		//IL_01c3: Expected O, but got I4
		//IL_059b: Expected O, but got I4
		//IL_031a: Expected O, but got I
		//IL_0322: Expected O, but got Ref
		//IL_00f4: Expected O, but got I
		//IL_0116: Expected O, but got I
		//IL_012b: Expected O, but got I
		//IL_04a8: Expected I4, but got O
		//IL_04cb: Expected O, but got I4
		//IL_01ea: Expected O, but got I
		//IL_01fa: Expected O, but got I
		//IL_020a: Expected O, but got I
		//IL_0227: Expected O, but got I
		//IL_0387: Expected O, but got I
		//IL_039c: Expected O, but got I
		//IL_03fa: Expected O, but got I4
		//IL_033d: Expected O, but got I
		//IL_035f: Expected O, but got I
		//IL_0421: Expected O, but got I
		//IL_0431: Expected O, but got I
		//IL_0441: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6883]");
		object obj = 0;
		object obj2 = typeof(List<AdaptivePerformanceScaler>) + 1800;
		object obj3 = (nint)0 + (nint)1312;
		int userId2 = default(int);
		EmoteSaveData emoteSaveData = LoadEmoteSaveData(userId2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		int num = (int)obj3;
		List<int> list = default(List<int>);
		list..ctor();
		bool flag = emoteSaveData == null;
		List<int>.Enumerator enumerator = (List<int>.Enumerator)0;
		object obj4 = default(object);
		object obj9;
		object obj10 = default(object);
		List<int>.Enumerator enumerator5;
		List<int>.Enumerator enumerator4 = default(List<int>.Enumerator);
		if (!flag)
		{
			bool flag2 = emoteSaveData.manuallyOrderedEmotes == null;
			enumerator = (List<int>.Enumerator)0;
			if (!flag2)
			{
				obj4 = (nint)0 + (nint)2384;
				List<int>.Enumerator enumerator2 = emoteSaveData.manuallyOrderedEmotes.GetEnumerator();
				List<int>.Enumerator enumerator3 = default(List<int>.Enumerator);
				int num2 = default(int);
				if (list != null)
				{
					object obj5 = (nint)0 + (nint)1336;
					obj = (object)(&enumerator3);
					while (enumerator3.MoveNext())
					{
						object obj6 = obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v4 (System.Collections.Generic.List`1<System.Int32>)+1C]");
						object obj7 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v4 (System.Collections.Generic.List`1<System.Int32>)+10]");
						object obj8 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v4 (System.Collections.Generic.List`1<System.Int32>)+10]");
						bool flag3 = (nint)0 == 0;
						obj9 = obj10;
						num = num2;
						if (!flag3)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v4 (System.Collections.Generic.List`1<System.Int32>)+18]");
							nint num3 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X9_v3+18]");
							bool flag4 = num3 < 0;
							object obj11 = !flag4;
							object obj12 = ~obj11;
							if (obj12 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v4 (System.Collections.Generic.List`1<System.Int32>)+18]");
								object obj13 = (nint)0 + (nint)1;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v4 (System.Collections.Generic.List`1<System.Int32>)+10]");
								nint num4 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v4 (System.Collections.Generic.List`1<System.Int32>)+18]");
								obj = num4 + 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v4 (System.Collections.Generic.List`1<System.Int32>)+10]");
								object obj14 = 0;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v14+20]");
								object obj15 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X8_v34+C0]");
								obj = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v4+70]");
								obj10 = 0;
								list.AddWithResize(num2);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v4 (System.Collections.Generic.List`1<System.Int32>)+10]");
								object obj14 = 0;
							}
							continue;
						}
						goto IL_0550;
					}
				}
				else
				{
					obj = (nint)0 + (nint)2392;
					num = (int)obj;
					bool flag5 = enumerator3.MoveNext();
					bool flag6 = !flag5;
					object obj16 = !flag6;
					obj9 = obj10;
					object obj14 = default(object);
					object obj8 = obj14;
					object obj6 = obj;
					if (obj16 != null)
					{
						goto IL_0550;
					}
				}
				num = (int)obj4;
				enumerator3.Dispose();
				List<int> mostUsedEmotes_NotSetManually_Ordered = GetMostUsedEmotes_NotSetManually_Ordered(emoteSaveData);
				bool flag7 = mostUsedEmotes_NotSetManually_Ordered == null;
				enumerator = enumerator4;
				enumerator5 = enumerator4;
				enumerator4 = (List<int>.Enumerator)0;
				if (!flag7)
				{
					List<int>.Enumerator enumerator6 = mostUsedEmotes_NotSetManually_Ordered.GetEnumerator();
					List<int>.Enumerator enumerator7 = default(List<int>.Enumerator);
					if (list != null)
					{
						object obj17 = (nint)0 + (nint)1336;
						obj = (object)(&enumerator7);
						while (enumerator7.MoveNext())
						{
							object obj6 = obj17;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v4 (System.Collections.Generic.List`1<System.Int32>)+1C]");
							object obj18 = (nint)0 + (nint)1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v4 (System.Collections.Generic.List`1<System.Int32>)+10]");
							object obj8 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v4 (System.Collections.Generic.List`1<System.Int32>)+10]");
							bool flag8 = (nint)0 == 0;
							obj9 = obj10;
							num = num2;
							if (!flag8)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v4 (System.Collections.Generic.List`1<System.Int32>)+18]");
								nint num5 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X9_v3+18]");
								bool flag9 = num5 < 0;
								object obj19 = !flag9;
								object obj20 = ~obj19;
								if (obj20 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v4 (System.Collections.Generic.List`1<System.Int32>)+18]");
									object obj21 = (nint)0 + (nint)1;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v4 (System.Collections.Generic.List`1<System.Int32>)+10]");
									nint num6 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v4 (System.Collections.Generic.List`1<System.Int32>)+18]");
									obj = num6 + 0;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v14+20]");
									object obj22 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X8_v26+C0]");
									obj = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v4+70]");
									obj10 = 0;
									list.AddWithResize(num2);
								}
								continue;
							}
							goto IL_0578;
						}
					}
					else
					{
						obj = (nint)0 + (nint)2392;
						num = (int)obj;
						bool flag10 = enumerator7.MoveNext();
						bool flag11 = !flag10;
						object obj23 = !flag11;
						obj9 = obj10;
						if (obj23 != null)
						{
							goto IL_0578;
						}
					}
					num = (int)obj4;
					enumerator7.Dispose();
					enumerator = enumerator4;
					enumerator5 = enumerator4;
					enumerator4 = (List<int>.Enumerator)0;
					goto IL_04d0;
				}
			}
		}
		goto IL_068e;
		IL_05a0:
		obj10 = obj9;
		goto IL_068e;
		IL_04d0:
		if (list != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v4 (System.Collections.Generic.List`1<System.Int32>)+18]");
			bool flag12 = (nint)0 <= (nint)6;
			List<int> result = list;
			if (!flag12)
			{
				IEnumerable<int> source = Enumerable.Take(list, 6);
				List<int> list2 = Enumerable.ToList(source);
				result = list2;
			}
			return result;
		}
		goto IL_068e;
		IL_0550:
		NullReferenceException ex = new NullReferenceException();
		enumerator = enumerator4;
		enumerator5 = enumerator4;
		enumerator4 = (List<int>.Enumerator)0;
		goto IL_05a0;
		IL_068e:
		NullReferenceException ex2 = new NullReferenceException();
		bool flag13 = num != 1;
		NullReferenceException ex3 = ex2;
		if (!flag13)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			num = (int)obj4;
			enumerator.Dispose();
			object obj24 = default(object);
			bool flag14 = obj24 == null;
			enumerator4 = (List<int>.Enumerator)obj24;
			if (flag14)
			{
				goto IL_04d0;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			enumerator4 = (List<int>.Enumerator)obj24;
			ex3 = (NullReferenceException)(object)ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1CBC9E0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		List<int> result2 = default(List<int>);
		return result2;
		IL_0578:
		NullReferenceException ex5 = new NullReferenceException();
		enumerator = enumerator4;
		enumerator5 = enumerator4;
		enumerator4 = (List<int>.Enumerator)0;
		goto IL_05a0;
	}

	public static List<int> GetManuallyOrderedEmotes(int userId)
	{
		EmoteSaveData emoteSaveData = LoadEmoteSaveData(userId);
		if (emoteSaveData != null)
		{
			return emoteSaveData.manuallyOrderedEmotes;
		}
		return (List<int>)(object)new NullReferenceException();
	}

	public static void SetManuallyOrderedEmotes(List<int> newManuallyOrderedEmotes, int userId)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		EmoteSaveData emoteSaveData = LoadEmoteSaveData(userId);
		object obj = emoteSaveData + 16;
		obj = newManuallyOrderedEmotes;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		string contents = JsonUtility.ToJson(emoteSaveData);
		string userEmotesPath = GetUserEmotesPath(userId);
		File.WriteAllText(userEmotesPath, contents);
	}

	public static void IncrementEmoteUsage(int emoteId, int userId)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_0024: Expected O, but got I
		//IL_0074: Expected O, but got I
		EmoteSaveData emoteSaveData = LoadEmoteSaveData(userId);
		object obj = emoteSaveData + 24;
		object obj2 = (nint)0 + (nint)1416;
		((List<int>)obj).Insert(0, emoteId);
		IEnumerable<int> source = (IEnumerable<int>)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v7 (System.Collections.Generic.IEnumerable`1<System.Int32>)+18]");
		if ((nint)0 >= (nint)21)
		{
			object obj3 = (nint)0 + (nint)824;
			IEnumerable<int> source2 = Enumerable.Take(source, 20);
			List<int> list = Enumerable.ToList(source2);
			obj = list;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		string contents = JsonUtility.ToJson(emoteSaveData);
		string userEmotesPath = GetUserEmotesPath(userId);
		File.WriteAllText(userEmotesPath, contents);
	}

	private static EmoteSaveData LoadEmoteSaveData(int userId)
	{
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected O, but got Unknown
		//IL_01a7: Expected O, but got I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0117: Expected O, but got I4
		//IL_0120: Expected O, but got I4
		//IL_0074: Expected O, but got I4
		//IL_00a3: Expected O, but got I4
		//IL_0152: Expected O, but got I
		//IL_00c3: Expected O, but got I4
		object obj = typeof(DataRelation) + 3024;
		int userId2 = default(int);
		string userEmotesPath = GetUserEmotesPath(userId2);
		bool flag = File.Exists(userEmotesPath);
		bool flag2 = !flag;
		object obj2 = 0;
		if (!flag2)
		{
			object obj3 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
			string value = File.ReadAllText(userEmotesPath);
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v10+E4]");
			if ((nint)0 != 0)
			{
				bool flag3 = StringsExtensions.IsNullOrEmpty(value);
				bool flag4 = !flag3;
				object obj5 = 0;
				if (!flag4)
				{
					goto IL_0082;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag5 = StringsExtensions.IsNullOrEmpty(value);
				bool flag6 = !flag5;
				object obj6 = !flag6;
				object obj5 = 0;
				if (obj6 != null)
				{
					goto IL_0082;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			EmoteSaveData emoteSaveData = default(EmoteSaveData);
			emoteSaveData..ctor();
			object obj7 = (nint)0 + (nint)2696;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9D69C");
			EmoteSaveData result = default(EmoteSaveData);
			return result;
		}
		goto IL_00c8;
		IL_0082:
		bool flag7 = File.Exists(userEmotesPath);
		bool flag8 = !flag7;
		obj2 = 0;
		if (!flag8)
		{
			File.Delete(userEmotesPath);
			obj2 = 0;
		}
		goto IL_00c8;
		IL_00c8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		EmoteSaveData emoteSaveData2 = default(EmoteSaveData);
		emoteSaveData2..ctor();
		return emoteSaveData2;
	}

	private static string GetUserEmotesPath(int userId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_0163: Expected O, but got I4
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_006a: Expected O, but got I4
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected O, but got Unknown
		//IL_01b8: Expected O, but got I4
		//IL_00a8: Expected O, but got I4
		//IL_00f2: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 72;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object path = "Drop Menu Toggle" + 2256;
		string cachePath = Config.CachePath;
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object format = "destinationTimeZone" + 1936;
		string text = Path.Combine(cachePath, (string)path);
		bool flag3 = Directory.Exists(text);
		bool flag4 = !flag3;
		object obj7 = !flag4;
		if (obj7 == null)
		{
			DirectoryInfo directoryInfo = Directory.CreateDirectory(text);
		}
		object obj8 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		string path2 = string.Format((string)format, arg);
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v14+E4]");
		bool flag5 = (nint)0 == 0;
		object obj10 = !flag5;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		return Path.Combine(text, path2);
	}

	private static List<int> GetMostUsedEmotes_NotSetManually_Ordered(EmoteSaveData savedData)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		//IL_007e: Expected O, but got I
		//IL_008a: Expected O, but got I
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_00b9: Expected I, but got O
		//IL_00d3: Expected O, but got I
		//IL_0194: Expected O, but got I
		//IL_01a4: Expected O, but got I
		//IL_01b4: Expected O, but got I
		//IL_01d6: Expected O, but got I4
		//IL_01df: Expected O, but got I4
		//IL_0110: Expected O, but got I
		//IL_0120: Expected O, but got I
		//IL_0130: Expected O, but got I
		//IL_0152: Expected O, but got I4
		//IL_015b: Expected O, but got I4
		//IL_030a: Expected O, but got I
		//IL_031a: Expected O, but got I
		//IL_032a: Expected O, but got I
		//IL_034c: Expected O, but got I4
		//IL_0217: Expected O, but got I4
		//IL_03f4: Expected O, but got I4
		//IL_028f: Expected O, but got I
		//IL_029f: Expected O, but got I
		//IL_02af: Expected O, but got I
		//IL_02d1: Expected O, but got I4
		//IL_04e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Expected O, but got Unknown
		//IL_0500: Expected O, but got I
		//IL_0511: Expected I, but got O
		//IL_052f: Expected O, but got I
		//IL_054a: Expected O, but got I4
		//IL_05fa: Expected O, but got I
		//IL_060a: Expected O, but got I
		//IL_062c: Expected O, but got I4
		//IL_0384: Expected O, but got I4
		//IL_0247: Expected O, but got I
		//IL_056e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0573: Expected O, but got Unknown
		//IL_0589: Expected O, but got I
		//IL_059a: Expected I, but got O
		//IL_05b8: Expected O, but got I
		//IL_05d3: Expected O, but got I4
		//IL_043b: Expected O, but got I4
		//IL_03b4: Expected O, but got I
		//IL_0649: Unknown result type (might be due to invalid IL or missing references)
		//IL_064e: Expected O, but got Unknown
		//IL_0664: Expected O, but got I
		//IL_0675: Expected I, but got O
		//IL_0693: Expected O, but got I
		//IL_046b: Expected O, but got I
		object obj = typeof(DebugUI.BitField) + 1368;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj8;
		object obj11;
		object obj14;
		object obj10;
		Func<int, int> func2;
		object obj13;
		if (obj2 != null)
		{
			object obj3 = obj2 + 16;
			obj3 = savedData;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj4 = obj3;
			if (obj3 != null)
			{
				object obj5 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1832;
				object obj6 = (nint)0 + (nint)2928;
				object obj7 = (nint)0 + (nint)3520;
				obj8 = typeof(DebugUI.BitField) + 1360;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				Func<int, bool> func = default(Func<int, bool>);
				func..ctor(obj2, (IntPtr)obj6);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v4+18]");
				IEnumerable<int> enumerable = Enumerable.Where((IEnumerable<int>)0, func);
				object obj9 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X0_v45+E4]");
				if ((nint)0 != 0)
				{
					obj10 = (nint)0 + (nint)1528;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X0_v45+B8]");
					obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v32+8]");
					func2 = (Func<int, int>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v32+8]");
					bool flag = (nint)0 == 0;
					object obj12 = !flag;
					obj13 = 0;
					if (obj12 == null)
					{
						obj14 = obj10;
						goto IL_01f5;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj8;
					obj14 = (nint)0 + (nint)1528;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X0_v45+B8]");
					obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v32+8]");
					func2 = (Func<int, int>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v32+8]");
					bool flag2 = (nint)0 == 0;
					object obj15 = !flag2;
					obj13 = 0;
					obj10 = obj14;
					if (obj15 == null)
					{
						goto IL_01f5;
					}
				}
				goto IL_024c;
			}
		}
		return (List<int>)(object)new NullReferenceException();
		IL_024c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DC5FAC");
		object obj16 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X0_v35+E4]");
		object obj18;
		Func<object, int> keySelector;
		object obj20;
		object obj17;
		if ((nint)0 != 0)
		{
			obj17 = (nint)0 + (nint)2336;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X0_v35+B8]");
			obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v21+10]");
			keySelector = (Func<object, int>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v21+10]");
			bool flag3 = (nint)0 == 0;
			object obj19 = !flag3;
			if (obj19 == null)
			{
				obj20 = obj17;
				goto IL_0362;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj16 = obj8;
			obj20 = (nint)0 + (nint)2336;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X0_v35+B8]");
			obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v21+10]");
			keySelector = (Func<object, int>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v21+10]");
			bool flag4 = (nint)0 == 0;
			object obj21 = !flag4;
			obj17 = obj20;
			if (obj21 == null)
			{
				goto IL_0362;
			}
		}
		goto IL_03b9;
		IL_03b9:
		IEnumerable<object> source2 = default(IEnumerable<object>);
		IOrderedEnumerable<object> source = Enumerable.OrderByDescending(source2, keySelector);
		object obj22 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X0_v21+E4]");
		bool flag5 = (nint)0 == 0;
		object obj23 = !flag5;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj22 = obj8;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X0_v21+B8]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X8_v12+18]");
		Func<object, int> selector = (Func<object, int>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X8_v12+18]");
		bool flag6 = (nint)0 == 0;
		object obj25 = !flag6;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X0_v21+E4]");
			bool flag7 = (nint)0 == 0;
			object obj26 = !flag7;
			if (obj26 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj27 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X8_v18+B8]");
				obj24 = 0;
			}
			object obj28 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3280;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj29 = (nint)0 + (nint)2920;
			Func<object, int> func3 = default(Func<object, int>);
			func3..ctor(obj24, (IntPtr)obj29);
			object obj30 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X8_v17+B8]");
			object obj31 = (nint)0 + (nint)24;
			obj31 = func3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			selector = func3;
		}
		IEnumerable<int> source3 = Enumerable.Select(source, selector);
		return Enumerable.ToList(source3);
		IL_01f5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X0_v45+E4]");
		bool flag8 = (nint)0 == 0;
		object obj32 = !flag8;
		if (obj32 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj33 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v38+B8]");
			obj11 = 0;
		}
		object obj34 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1872;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj35 = (nint)0 + (nint)2904;
		Func<int, int> func4 = default(Func<int, int>);
		func4..ctor(obj11, (IntPtr)obj35);
		object obj36 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v37+B8]");
		object obj37 = (nint)0 + (nint)8;
		obj37 = func4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj13 = 0;
		obj10 = obj14;
		func2 = func4;
		goto IL_024c;
		IL_0362:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X0_v35+E4]");
		bool flag9 = (nint)0 == 0;
		object obj38 = !flag9;
		if (obj38 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj39 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X8_v27+B8]");
			obj18 = 0;
		}
		object obj40 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3280;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj41 = (nint)0 + (nint)2912;
		Func<object, int> func5 = default(Func<object, int>);
		func5..ctor(obj18, (IntPtr)obj41);
		object obj42 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v26+B8]");
		object obj43 = (nint)0 + (nint)16;
		obj43 = func5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj13 = 0;
		obj17 = obj20;
		keySelector = func5;
		goto IL_03b9;
	}

	private static void SaveEmoteUsage(EmoteSaveData saveData, int userId)
	{
		string contents = JsonUtility.ToJson(saveData);
		string userEmotesPath = GetUserEmotesPath(userId);
		File.WriteAllText(userEmotesPath, contents);
	}

	public EmoteSaveData()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 1800;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<int> list = default(List<int>);
		list..ctor();
		object obj2 = this + 16;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<int> list2 = default(List<int>);
		list2..ctor();
		object obj3 = this + 24;
		obj3 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}
}
