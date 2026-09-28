using System;
using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq.JsonPath;
using Unity.Services.Authentication.Shared;

public static class SaveLoadUtils
{
	private sealed class <>c__DisplayClass1_0<T>
	{
		public string savingPath;

		public string fileExtension;

		public CancellationToken cancellationToken;

		public bool useCompression;

		public JsonSerializerSettings serializerSettings;

		public List<T> itemsToReturn;

		internal void <LoadItems>b__0()
		{
			//IL_0009: Expected O, but got I4
			//IL_001f: Expected O, but got I
			//IL_00fa: Expected O, but got I
			//IL_0103: Unknown result type (might be due to invalid IL or missing references)
			//IL_0108: Expected O, but got Unknown
			//IL_0122: Expected O, but got I4
			//IL_0058: Expected O, but got I
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Expected O, but got Unknown
			//IL_00bd: Expected O, but got I4
			//IL_0176: Unknown result type (might be due to invalid IL or missing references)
			//IL_017b: Expected O, but got Unknown
			//IL_0184: Unknown result type (might be due to invalid IL or missing references)
			//IL_0189: Expected O, but got Unknown
			//IL_0265: Expected O, but got I4
			//IL_01f9: Expected O, but got I4
			//IL_0202: Expected O, but got I4
			//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_02bc: Expected O, but got Unknown
			//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e2: Expected O, but got Unknown
			//IL_02f2: Expected O, but got I
			//IL_030b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0310: Expected O, but got Unknown
			//IL_0331: Unknown result type (might be due to invalid IL or missing references)
			//IL_0336: Expected O, but got Unknown
			//IL_035c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0361: Expected O, but got Unknown
			//IL_039e: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a3: Expected O, but got Unknown
			//IL_03cd: Expected O, but got I4
			//IL_03f6: Expected O, but got I
			object obj = 152961024;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E0CB8]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				nint num = 0;
				IntPtr intPtr = num;
				object obj3 = num + 309;
				object obj4 = obj3 & 1;
				bool flag = obj4 == null;
				IntPtr intPtr2 = num;
				if (!flag)
				{
					goto IL_008b;
				}
			}
			else
			{
				_ = 1;
				nint num2 = 0;
				IntPtr intPtr = num2;
				object obj5 = num2 + 309;
				object obj6 = obj5 & 1;
				bool flag2 = obj6 == null;
				object obj7 = !flag2;
				IntPtr intPtr2 = num2;
				if (obj7 != null)
				{
					goto IL_008b;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj8 = default(object);
			obj8..ctor();
			object obj9 = obj8;
			goto IL_0167;
			IL_0167:
			object obj10 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 488;
			object obj11 = obj9 + 24;
			obj11 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj12 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X0_v7+E4]");
			List<string> list;
			if ((nint)0 != 0)
			{
				list = FileUtils.ReadFiles(savingPath, fileExtension);
				bool flag3 = list == null;
				object obj13 = !flag3;
				object obj14 = 0;
				bool flag4 = false;
				string text = fileExtension;
				if (obj13 == null)
				{
					return;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				list = FileUtils.ReadFiles(savingPath, fileExtension);
				bool flag5 = list == null;
				object obj14 = 0;
				bool flag4 = false;
				string text = fileExtension;
				if (flag5)
				{
					return;
				}
			}
			if (list._size != 0)
			{
				object obj15 = typeof(MemberAchievementClanFeedData) + 3968;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				ParallelOptions parallelOptions = default(ParallelOptions);
				parallelOptions..ctor();
				object obj16 = parallelOptions + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SaveLoadUtils+<>c__DisplayClass1_0`1<T>)+20]");
				obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj17 = typeof(MemberAchievementClanFeedData) + 2968;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj18 = default(object);
				obj18..ctor();
				object obj19 = obj9 + 16;
				obj19 = obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj20 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				nint num3 = 0;
				object obj21 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v14 (Il2CppRgctx<SaveLoadUtils+<>c__DisplayClass1_0`1>)+18]");
				Action<object> action = default(Action<object>);
				action..ctor(obj21, (IntPtr)0);
				object obj22 = typeof(MemberAchievementClanFeedData) + 3920;
				object obj23 = obj22;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X0_v21+E4]");
				bool flag6 = (nint)0 == 0;
				object obj24 = !flag6;
				if (obj24 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj25 = (nint)0 + (nint)2608;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EEE3E8");
			}
			return;
			IL_008b:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj26 = default(object);
			obj26..ctor();
			bool flag7 = obj26 == null;
			object obj27 = !flag7;
			obj9 = obj26;
			if (obj27 == null)
			{
				throw new NullReferenceException();
			}
			goto IL_0167;
		}
	}

	private sealed class <>c__DisplayClass1_1<T>
	{
		public object lockObj;

		public <>c__DisplayClass1_0<T> CS$<>8__locals1;

		internal unsafe void <LoadItems>b__1(string file)
		{
			//IL_001b: Expected O, but got I
			//IL_0032: Expected I4, but got O
			//IL_0353: Unknown result type (might be due to invalid IL or missing references)
			//IL_0358: Expected O, but got Unknown
			//IL_0382: Expected O, but got I4
			//IL_00c3: Expected O, but got I
			//IL_0300: Expected I, but got O
			//IL_02d7: Expected I, but got O
			//IL_02df: Expected O, but got Ref
			//IL_0088: Expected I, but got O
			//IL_0114: Expected O, but got I
			//IL_02ae: Expected I, but got O
			//IL_02b6: Expected O, but got Ref
			//IL_014f: Expected O, but got I
			//IL_01be: Expected O, but got I4
			//IL_0245: Expected O, but got I
			//IL_0255: Expected O, but got I
			//IL_027a: Expected O, but got I
			//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0203: Expected O, but got Unknown
			//IL_020c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0211: Expected O, but got Unknown
			//IL_0228: Expected I, but got O
			<>c__DisplayClass1_0<T> cS$<>8__locals = CS$<>8__locals1;
			if (CS$<>8__locals1 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v5 (SaveLoadUtils+<>c__DisplayClass1_0`1<T>)+28]");
				object obj = (nint)0 & (nint)1;
				bool flag = obj == null;
				string text = default(string);
				CompressUtil.CompressionAlgorithm compressionAlgorithm = (CompressUtil.CompressionAlgorithm)text;
				string text2 = text;
				if (!flag)
				{
					string text3 = CompressUtil.Decompress(text);
					cS$<>8__locals = CS$<>8__locals1;
					nint num;
					if (CS$<>8__locals1 == null)
					{
						NullReferenceException ex = new NullReferenceException();
						num = unchecked((nint)null);
						text = null;
						goto IL_03b8;
					}
					num = unchecked((nint)null);
					compressionAlgorithm = CompressUtil.CompressionAlgorithm.Brotli;
					text2 = text3;
				}
				object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 520;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v10+E4]");
				bool flag2 = (nint)0 == 0;
				object obj4 = !flag2;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				string value = text2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v5 (SaveLoadUtils+<>c__DisplayClass1_0`1<T>)+30]");
				object obj5 = JsonConvert.DeserializeObject<object>(value, (JsonSerializerSettings)0);
				bool lockTaken = default(bool);
				Monitor.Enter(lockObj, ref lockTaken);
				<>c__DisplayClass1_0<T> cS$<>8__locals2 = CS$<>8__locals1;
				if (CS$<>8__locals1 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v11 (SaveLoadUtils+<>c__DisplayClass1_0`1<T>)+38]");
					List<object> list = (List<object>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v11 (SaveLoadUtils+<>c__DisplayClass1_0`1<T>)+38]");
					nint num;
					if ((nint)0 != 0)
					{
						nint num2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v14 (Il2CppRgctx<SaveLoadUtils+<>c__DisplayClass1_1`1>)+28]");
						object obj6 = 0;
						int version = list._version + 1;
						list._version = version;
						object[] items = list._items;
						if (list._items != null)
						{
							bool flag3 = list._size < items.Length;
							object obj7 = !flag3;
							object obj10;
							if (obj7 == null)
							{
								int size = list._size + 1;
								list._size = size;
								object obj8 = list._items + list._size;
								object obj9 = obj8 + 32;
								obj9 = obj5;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								num = unchecked((nint)null);
								obj10 = obj5;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X8_v15+20]");
								object obj11 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v18+C0]");
								object obj12 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v19+70]");
								num = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v11 (SaveLoadUtils+<>c__DisplayClass1_0`1<T>)+38]");
								((List<object>)0).AddWithResize(obj5);
								obj10 = obj5;
							}
							bool flag4 = !lockTaken;
							text = (string)obj10;
							if (!flag4)
							{
								object obj13 = default(object);
								Monitor.Exit(obj13);
								text = null;
							}
							OutOfMemoryException ex2 = new OutOfMemoryException();
							goto IL_03b8;
						}
					}
					NullReferenceException ex3 = new NullReferenceException();
					num = unchecked((nint)null);
					text = (string)(&lockTaken);
				}
				else
				{
					NullReferenceException ex4 = new NullReferenceException();
					nint num = unchecked((nint)null);
					text = (string)(&lockTaken);
				}
			}
			else
			{
				NullReferenceException ex5 = new NullReferenceException();
			}
			goto IL_03b8;
			IL_03b8:
			NullReferenceException ex6 = new NullReferenceException();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		}
	}

	[StructLayout((LayoutKind)3)]
	private struct <LoadItems>d__1<T> : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder <>t__builder;

		public string savingPath;

		public string fileExtension;

		public CancellationToken cancellationToken;

		public bool useCompression;

		public JsonSerializerSettings serializerSettings;

		public List<T> itemsToReturn;

		public Comparison<T> comparison;

		private <>c__DisplayClass1_0<T> <>8__1;

		private TaskAwaiter <>u__1;

		private unsafe void MoveNext()
		{
			//IL_0927: Unknown result type (might be due to invalid IL or missing references)
			//IL_092c: Expected O, but got Unknown
			//IL_05a1: Expected O, but got I8
			//IL_05b1: Expected O, but got I
			//IL_0011: Expected O, but got I
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Expected O, but got Unknown
			//IL_0039: Expected O, but got I4
			//IL_0786: Expected O, but got I8
			//IL_0791: Expected O, but got Ref
			//IL_079c: Expected O, but got Ref
			//IL_07a5: Expected O, but got I4
			//IL_07d9: Expected O, but got I4
			//IL_006c: Expected O, but got I
			//IL_0082: Expected O, but got I
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Expected O, but got Unknown
			//IL_00aa: Expected O, but got I4
			//IL_05c6: Expected O, but got I
			//IL_00dd: Expected O, but got I
			//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00eb: Expected O, but got Unknown
			//IL_0105: Expected O, but got I4
			//IL_013d: Expected O, but got Ref
			//IL_05fb: Expected O, but got I
			//IL_062c: Expected O, but got I
			//IL_0635: Unknown result type (might be due to invalid IL or missing references)
			//IL_063a: Expected O, but got Unknown
			//IL_0654: Expected O, but got I4
			//IL_0181: Expected O, but got I
			//IL_018a: Unknown result type (might be due to invalid IL or missing references)
			//IL_018f: Expected O, but got Unknown
			//IL_019f: Expected O, but got I
			//IL_01d6: Expected O, but got I
			//IL_01df: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e4: Expected O, but got Unknown
			//IL_01f4: Expected O, but got I
			//IL_06a6: Expected O, but got I
			//IL_0224: Unknown result type (might be due to invalid IL or missing references)
			//IL_0229: Expected O, but got Unknown
			//IL_0239: Expected O, but got I
			//IL_0270: Expected O, but got I
			//IL_0279: Unknown result type (might be due to invalid IL or missing references)
			//IL_027e: Expected O, but got Unknown
			//IL_028e: Expected O, but got I
			//IL_06fc: Expected O, but got I
			//IL_0705: Unknown result type (might be due to invalid IL or missing references)
			//IL_070a: Expected O, but got Unknown
			//IL_0724: Expected O, but got I4
			//IL_0774: Expected O, but got I
			//IL_0774: Expected O, but got I
			//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d0: Expected O, but got Unknown
			//IL_02e0: Expected O, but got I
			//IL_0313: Unknown result type (might be due to invalid IL or missing references)
			//IL_0318: Expected O, but got Unknown
			//IL_032e: Expected O, but got I
			//IL_0337: Unknown result type (might be due to invalid IL or missing references)
			//IL_033c: Expected O, but got Unknown
			//IL_0356: Expected O, but got I4
			//IL_0890: Expected O, but got I4
			//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_03db: Expected O, but got Unknown
			//IL_0405: Expected O, but got I4
			//IL_0437: Expected O, but got I
			//IL_08af: Expected O, but got I4
			//IL_08c8: Expected O, but got I
			//IL_0491: Expected O, but got I4
			//IL_049a: Expected O, but got I4
			//IL_04ba: Expected O, but got I4
			//IL_04c5: Expected O, but got Ref
			//IL_0501: Expected O, but got I4
			//IL_052a: Expected O, but got I
			//IL_0533: Unknown result type (might be due to invalid IL or missing references)
			//IL_0538: Expected O, but got Unknown
			//IL_0552: Expected O, but got I4
			//IL_057b: Expected O, but got Ref
			object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1192;
			if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref this) == null)
			{
				goto IL_058e;
			}
			object obj2 = (nint)0 + (nint)309;
			object obj3 = obj2 & 1;
			bool flag = obj3 == null;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			}
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v24 (Il2CppRgctx<SaveLoadUtils+<LoadItems>d__1`1>)+8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v24 (Il2CppRgctx<SaveLoadUtils+<LoadItems>d__1`1>)+8]");
			object obj6 = (nint)0 + (nint)309;
			object obj7 = obj6 & 1;
			bool flag2 = obj7 == null;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj9 = (nint)0 + (nint)309;
			object obj10 = obj9 & 1;
			bool flag3 = obj10 == null;
			object obj11 = !flag3;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			}
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @31DB2DC");
			object obj12 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 88));
			object obj13 = default(object);
			obj12 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			TaskAwaiter awaiter2 = default(TaskAwaiter);
			<LoadItems>d__1<T> <LoadItems>d__;
			if (obj12 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SaveLoadUtils+<LoadItems>d__1`1<T>)+20]");
				object obj14 = 0;
				object obj15 = obj12 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SaveLoadUtils+<LoadItems>d__1`1<T>)+20]");
				obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				if (obj12 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SaveLoadUtils+<LoadItems>d__1`1<T>)+28]");
					obj14 = 0;
					object obj16 = obj12 + 24;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SaveLoadUtils+<LoadItems>d__1`1<T>)+28]");
					obj16 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					if (obj12 != null)
					{
						object obj17 = obj12 + 32;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SaveLoadUtils+<LoadItems>d__1`1<T>)+30]");
						obj17 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						if (obj12 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SaveLoadUtils+<LoadItems>d__1`1<T>)+40]");
							obj14 = 0;
							object obj18 = obj12 + 48;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SaveLoadUtils+<LoadItems>d__1`1<T>)+40]");
							obj18 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SaveLoadUtils+<LoadItems>d__1`1<T>)+38]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							if (obj12 != null)
							{
								object obj19 = obj12 + 56;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SaveLoadUtils+<LoadItems>d__1`1<T>)+48]");
								obj19 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref this) == null)
								{
									goto IL_058e;
								}
								object obj20 = typeof(SqlSingle[]) + 2376;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
								object obj21 = (nint)0 + (nint)309;
								object obj22 = obj21 & 1;
								bool flag4 = obj22 == null;
								object obj23 = !flag4;
								if (obj23 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
								}
								nint num3 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X8_v37 (Il2CppRgctx<SaveLoadUtils+<LoadItems>d__1`1>)+20]");
								nint num4 = 0;
								object obj24 = obj12;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X8_v37 (Il2CppRgctx<SaveLoadUtils+<LoadItems>d__1`1>)+20]");
								Action action = default(Action);
								action..ctor(obj24, (IntPtr)0);
								object obj25 = obj12;
								if (obj12 != null)
								{
									object obj26 = typeof(System.Formats.Asn1.SetOfValueComparer) + 3912;
									object obj27 = obj26;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X0_v65+E4]");
									bool flag5 = (nint)0 == 0;
									object obj28 = !flag5;
									if (obj28 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X8_v38+20]");
									Task task = Task.Run(action, (CancellationToken)0);
									object obj30;
									if (task != null)
									{
										TaskAwaiter awaiter = task.GetAwaiter();
										bool isCompleted = awaiter2.IsCompleted;
										bool flag6 = !isCompleted;
										object obj29 = !flag6;
										obj30 = 0;
										num4 = 0;
										if (obj29 == null)
										{
											<LoadItems>d__ = (<LoadItems>d__1<T>)0;
											object obj31 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 96));
											obj31 = awaiter2;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
											object obj32 = obj;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X0_v76+E4]");
											bool flag7 = (nint)0 == 0;
											object obj33 = !flag7;
											if (obj33 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											object obj34 = (nint)0 + (nint)309;
											object obj35 = obj34 & 1;
											bool flag8 = obj35 == null;
											object obj36 = !flag8;
											if (obj36 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
											}
											AsyncTaskMethodBuilder asyncTaskMethodBuilder = (AsyncTaskMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
											((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder)->AwaitUnsafeOnCompleted(ref awaiter2, ref System.Runtime.CompilerServices.Unsafe.As<<LoadItems>d__1<T>, <LoadItems>d__1<object>>(ref this));
											return;
										}
										goto IL_0946;
									}
									NullReferenceException ex = new NullReferenceException();
									obj30 = 0;
									num4 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X8_v38+20]");
									obj14 = 0;
								}
								else
								{
									NullReferenceException ex = new NullReferenceException();
									object obj30 = 0;
									obj14 = obj12;
								}
							}
							else
							{
								NullReferenceException ex = new NullReferenceException();
							}
						}
						else
						{
							NullReferenceException ex = new NullReferenceException();
							obj14 = null;
						}
					}
					else
					{
						NullReferenceException ex = new NullReferenceException();
					}
				}
				else
				{
					NullReferenceException ex = new NullReferenceException();
				}
			}
			else
			{
				NullReferenceException ex = new NullReferenceException();
				object obj14 = obj13;
			}
			goto IL_08f3;
			IL_08f3:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return;
			IL_058e:
			_ = 0;
			<LoadItems>d__ = (<LoadItems>d__1<T>)4294967295L;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SaveLoadUtils+<LoadItems>d__1`1<T>)+60]");
			awaiter2 = (TaskAwaiter)0;
			goto IL_0946;
			IL_0779:
			<LoadItems>d__ = (<LoadItems>d__1<T>)4294967294L;
			AsyncTaskMethodBuilder asyncTaskMethodBuilder2 = (AsyncTaskMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
			object obj37 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 88));
			obj37 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj38 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X0_v7+E4]");
			bool flag9 = (nint)0 == 0;
			object obj39 = !flag9;
			if (obj39 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder2)->SetResult();
			return;
			IL_0946:
			awaiter2.GetResult();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SaveLoadUtils+<LoadItems>d__1`1<T>)+50]");
			if ((nint)0 == 0)
			{
				goto IL_0779;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SaveLoadUtils+<LoadItems>d__1`1<T>)+58]");
			object obj40 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SaveLoadUtils+<LoadItems>d__1`1<T>)+58]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v9+38]");
				object obj41 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v9+38]");
				if ((nint)0 != 0)
				{
					object obj42 = (nint)0 + (nint)309;
					object obj43 = obj42 & 1;
					bool flag10 = obj43 == null;
					object obj44 = !flag10;
					if (obj44 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X21_v4+18]");
					if ((nint)0 < (nint)2)
					{
						goto IL_0779;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SaveLoadUtils+<LoadItems>d__1`1<T>)+58]");
					object obj45 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SaveLoadUtils+<LoadItems>d__1`1<T>)+58]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X8_v13+38]");
						if ((nint)0 != 0)
						{
							object obj46 = (nint)0 + (nint)309;
							object obj47 = obj46 & 1;
							bool flag11 = obj47 == null;
							object obj48 = !flag11;
							if (obj48 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
							}
							nint num5 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X8_v16 (Il2CppRgctx<SaveLoadUtils+<LoadItems>d__1`1>)+48]");
							nint num4 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X8_v13+38]");
							nint num6 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SaveLoadUtils+<LoadItems>d__1`1<T>)+50]");
							((List<object>)num6).Sort((Comparison<object>)0);
							goto IL_0779;
						}
						NullReferenceException ex = new NullReferenceException();
						object obj14 = null;
					}
					else
					{
						NullReferenceException ex = new NullReferenceException();
						object obj14 = null;
					}
				}
				else
				{
					NullReferenceException ex = new NullReferenceException();
					object obj14 = null;
				}
			}
			else
			{
				NullReferenceException ex = new NullReferenceException();
				object obj14 = null;
			}
			goto IL_08f3;
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		private unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_006b: Expected O, but got I4
			//IL_0033: Expected O, but got Ref
			object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1192;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			AsyncTaskMethodBuilder asyncTaskMethodBuilder = (AsyncTaskMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
			((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder)->SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	private sealed class <LoadItemsWeb>d__0<T> : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public string savingPath;

		public string fileExtension;

		public bool useCompression;

		public JsonSerializerSettings serializerSettings;

		public List<T> itemsToReturn;

		public Comparison<T> comparison;

		private List<string>.Enumerator <>7__wrap1;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <LoadItemsWeb>d__0(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		unsafe void IDisposable.Dispose()
		{
			//IL_0010: Expected O, but got I4
			//IL_002a: Expected O, but got I4
			//IL_0085: Expected O, but got I4
			//IL_0051: Expected O, but got I4
			//IL_00a2: Expected I4, but got I8
			//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ad: Expected O, but got Unknown
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
			object obj5 = !flag2;
			if (obj5 == null)
			{
				<>1__state = -1;
				List<object>.Enumerator enumerator = (List<object>.Enumerator)(this + 80);
				((List<object>.Enumerator*)enumerator)->Dispose();
			}
		}

		private unsafe bool MoveNext()
		{
			//IL_0008: Expected O, but got Ref
			//IL_0820: Expected I4, but got I8
			//IL_082c: Expected O, but got I
			//IL_0834: Expected I4, but got O
			//IL_083d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0842: Expected O, but got Unknown
			//IL_085f: Expected O, but got I
			//IL_0030: Expected O, but got I4
			//IL_0038: Expected O, but got I
			//IL_0779: Unknown result type (might be due to invalid IL or missing references)
			//IL_077e: Expected O, but got Unknown
			//IL_07b9: Expected O, but got I
			//IL_07dd: Expected O, but got I8
			//IL_0217: Expected O, but got I
			//IL_0728: Unknown result type (might be due to invalid IL or missing references)
			//IL_072d: Expected O, but got Unknown
			//IL_0757: Expected O, but got I4
			//IL_0055: Expected I4, but got I8
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Expected O, but got Unknown
			//IL_00a3: Expected O, but got I4
			//IL_0449: Expected O, but got I
			//IL_028d: Expected O, but got I
			//IL_029d: Expected O, but got I
			//IL_02ad: Expected O, but got I
			//IL_02d2: Expected O, but got I
			//IL_02f6: Expected O, but got I
			//IL_023b: Expected O, but got I
			//IL_024f: Expected O, but got I
			//IL_00f2: Expected O, but got I4
			//IL_010d: Expected I4, but got O
			//IL_0608: Expected O, but got I8
			//IL_0618: Expected O, but got I
			//IL_049c: Expected O, but got I8
			//IL_032b: Expected O, but got I
			//IL_033b: Expected O, but got I
			//IL_034b: Expected O, but got I
			//IL_0145: Expected O, but got I4
			//IL_04ba: Expected O, but got I
			//IL_04ca: Expected O, but got I
			//IL_0507: Expected O, but got I
			//IL_0507: Expected O, but got I
			//IL_0514: Expected O, but got I8
			//IL_03ca: Expected O, but got I4
			//IL_0184: Expected O, but got I
			//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b6: Expected O, but got Unknown
			//IL_054b: Expected O, but got I
			//IL_055b: Expected O, but got I
			//IL_0580: Expected O, but got I
			//IL_01d5: Expected O, but got I
			//IL_01de: Expected O, but got I4
			//IL_059b: Expected O, but got I
			//IL_05a4: Expected O, but got I4
			//IL_040a: Unknown result type (might be due to invalid IL or missing references)
			//IL_040f: Expected O, but got Unknown
			//IL_0418: Unknown result type (might be due to invalid IL or missing references)
			//IL_041d: Expected O, but got Unknown
			object obj2 = default(object);
			object obj = (object)(&obj2);
			int num = <>1__state;
			bool flag = <>1__state == 1;
			<LoadItemsWeb>d__0<T> <LoadItemsWeb>d__ = this;
			string text;
			bool flag6;
			Comparison<object> comparison;
			object[] array;
			if (!flag)
			{
				bool flag2 = <>1__state == 0;
				object obj3 = !flag2;
				IntPtr intPtr = default(IntPtr);
				comparison = (Comparison<object>)(nint)intPtr;
				if (obj3 == null)
				{
					<>1__state = -1;
					object obj4 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 488;
					object obj5 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v51+E4]");
					num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v51+E4]");
					bool flag3 = (nint)0 == 0;
					object obj6 = !flag3;
					if (obj6 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					List<string> list = FileUtils.ReadFiles(savingPath, fileExtension);
					bool flag4 = list == null;
					object obj7 = 0;
					bool flag5 = false;
					text = fileExtension;
					flag6 = (byte)(int)list != 0;
					if (flag4)
					{
						goto IL_06fd;
					}
					num = list._size;
					bool flag7 = list._size == 0;
					obj7 = 0;
					flag5 = false;
					comparison = (Comparison<object>)(object)fileExtension;
					if (!flag7)
					{
						List<object>.Enumerator enumerator = ((List<object>)(object)list).GetEnumerator();
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X29_v1-28]");
						array = (object[])0;
						object obj8 = default(object);
						array[6] = obj8;
						object obj9 = default(object);
						array[8] = obj9;
						object obj10 = array + 80;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X29_v1-28]");
						<LoadItemsWeb>d__ = (<LoadItemsWeb>d__0<T>)0;
						obj7 = 0;
						flag5 = false;
						goto IL_080e;
					}
				}
				goto IL_0519;
			}
			goto IL_080e;
			IL_06a5:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1DF0E08");
			OutOfMemoryException ex = new OutOfMemoryException();
			OutOfMemoryException ex2 = ex;
			goto IL_07eb;
			IL_0636:
			bool flag8 = (nint)comparison != 1;
			NullReferenceException ex3 = default(NullReferenceException);
			ex2 = (OutOfMemoryException)(object)ex3;
			bool flag9;
			string text2;
			if (!flag8)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				object obj11 = default(object);
				flag9 = obj11 == null;
				flag6 = false;
				text2 = (string)obj11;
				if (flag9)
				{
					goto IL_05d7;
				}
				goto IL_06a5;
			}
			goto IL_07eb;
			IL_05d7:
			return flag6;
			IL_07eb:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1DEF8E8");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			goto IL_0636;
			IL_0519:
			flag6 = false;
			goto IL_05d7;
			IL_06fd:
			text2 = null;
			comparison = (Comparison<object>)(object)text;
			flag9 = true;
			goto IL_06a5;
			IL_080e:
			<LoadItemsWeb>d__.<>1__state = -3;
			object obj12 = (nint)0 + (nint)1872;
			CompressUtil.CompressionAlgorithm compressionAlgorithm = (CompressUtil.CompressionAlgorithm)obj12;
			List<object>.Enumerator enumerator2 = (List<object>.Enumerator)(<LoadItemsWeb>d__ + 80);
			bool flag10 = ((List<object>.Enumerator*)enumerator2)->MoveNext();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X29_v1-28]");
			object obj13 = 0;
			object obj30;
			if (flag10)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X21_v3+30]");
				bool flag11 = (nint)0 != 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X21_v3+60]");
				string text3 = (string)0;
				bool flag5;
				if (!flag11)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X21_v3+60]");
					string text4 = CompressUtil.Decompress((string)0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X29_v1-28]");
					obj13 = 0;
					flag5 = false;
					compressionAlgorithm = CompressUtil.CompressionAlgorithm.Brotli;
					text3 = text4;
				}
				object obj14 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 520;
				object obj15 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X0_v14+E4]");
				bool flag12 = (nint)0 == 0;
				object obj16 = !flag12;
				if (obj16 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X29_v1-30]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X8_v25+20]");
				object obj18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v26+C0]");
				object obj19 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X8_v27+10]");
				flag5 = false;
				string value = text3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X21_v3+38]");
				object obj20 = JsonConvert.DeserializeObject<object>(value, (JsonSerializerSettings)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X29_v1-28]");
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v42 (System.Int32)+40]");
				List<object> list2 = (List<object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v42 (System.Int32)+40]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X29_v1-30]");
					object obj21 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X8_v30+20]");
					object obj22 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X8_v31+C0]");
					object obj23 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X8_v32+28]");
					num = 0;
					int version = list2._version + 1;
					list2._version = version;
					array = list2._items;
					if (list2._items != null)
					{
						bool flag13 = list2._size < array.Length;
						object obj24 = !flag13;
						if (obj24 == null)
						{
							int size = list2._size + 1;
							list2._size = size;
							object obj25 = list2._items + list2._size;
							object obj26 = obj25 + 32;
							obj26 = obj20;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v42 (System.Int32)+20]");
							object obj27 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X8_v36+C0]");
							object obj28 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X8_v37+70]");
							flag5 = false;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v42 (System.Int32)+40]");
							((List<object>)0).AddWithResize(obj20);
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X29_v1-28]");
						object obj29 = (nint)0 + (nint)24;
						obj29 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X29_v1-28]");
						num = 0;
						_ = 1;
						text = null;
						flag6 = true;
						goto IL_06fd;
					}
				}
				ex3 = new NullReferenceException();
				obj30 = obj20;
				goto IL_0623;
			}
			_ = 4294967295L;
			List<object>.Enumerator enumerator3 = (List<object>.Enumerator)(obj13 + 80);
			((List<object>.Enumerator*)enumerator3)->Dispose();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X29_v1-28]");
			num = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v42 (System.Int32)+48]");
			comparison = (Comparison<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v42 (System.Int32)+48]");
			bool flag14 = (nint)0 == 0;
			array = (object[])4294967295L;
			if (!flag14)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v42 (System.Int32)+40]");
				List<object> list3 = (List<object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v42 (System.Int32)+40]");
				if ((nint)0 == 0)
				{
					ex3 = new NullReferenceException();
					array = (object[])4294967295L;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v42 (System.Int32)+48]");
					obj30 = 0;
					goto IL_0623;
				}
				num = list3._size;
				bool flag15 = list3._size < 2;
				array = (object[])4294967295L;
				if (!flag15)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X29_v1-30]");
					object obj31 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X8_v17+20]");
					object obj32 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X8_v18+C0]");
					num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v42 (System.Int32)+40]");
					bool flag5 = false;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v42 (System.Int32)+40]");
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v42 (System.Int32)+48]");
					((List<object>)num2).Sort((Comparison<object>)0);
					array = (object[])4294967295L;
				}
			}
			goto IL_0519;
			IL_0623:
			text2 = null;
			comparison = (Comparison<object>)obj30;
			goto IL_0636;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private unsafe void <>m__Finally1()
		{
			//IL_0015: Expected I4, but got I8
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected O, but got Unknown
			<>1__state = -1;
			List<object>.Enumerator enumerator = (List<object>.Enumerator)(this + 80);
			((List<object>.Enumerator*)enumerator)->Dispose();
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

	public static IEnumerator LoadItemsWeb<T>(List<T> itemsToReturn, string savingPath, string fileExtension, JsonSerializerSettings serializerSettings, Comparison<T> comparison = null, bool useCompression = false)
	{
		//IL_0011: Expected O, but got I
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_0039: Expected O, but got I4
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected O, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
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
		((<LoadItemsWeb>d__0<T>)enumerator)..ctor(0);
		if (enumerator != null)
		{
			object obj4 = enumerator + 64;
			obj4 = itemsToReturn;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj5 = enumerator + 32;
			obj5 = savingPath;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj6 = enumerator + 40;
			obj6 = fileExtension;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj7 = enumerator + 56;
			obj7 = serializerSettings;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj8 = enumerator + 72;
			obj8 = comparison;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return enumerator;
		}
		return (IEnumerator)new NullReferenceException();
	}

	public unsafe static Task LoadItems<T>(List<T> itemsToReturn, CancellationToken cancellationToken, string savingPath, string fileExtension, JsonSerializerSettings serializerSettings, Comparison<T> comparison = null, bool useCompression = false)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0057: Expected O, but got I4
		//IL_008b: Expected O, but got I
		//IL_00a8: Expected O, but got Ref
		//IL_00c0: Expected O, but got Ref
		//IL_00dd: Expected O, but got Ref
		//IL_00f5: Expected O, but got Ref
		//IL_0112: Expected O, but got Ref
		//IL_012a: Expected O, but got Ref
		//IL_0147: Expected O, but got I
		//IL_0162: Expected O, but got I
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1192;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		AsyncTaskMethodBuilder asyncTaskMethodBuilder = AsyncTaskMethodBuilder.Create();
		<LoadItems>d__1<object> stateMachine = default(<LoadItems>d__1<object>);
		object obj4 = (nint)(&stateMachine) | (nint)8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref stateMachine, 72));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref stateMachine, 48));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref stateMachine, 32));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref stateMachine, 40));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj9 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref stateMachine, 64));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj10 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref stateMachine, 80));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		AsyncTaskMethodBuilder asyncTaskMethodBuilder2 = (AsyncTaskMethodBuilder)((nint)(&stateMachine) | (nint)8);
		((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder2)->Start(ref stateMachine);
		AsyncTaskMethodBuilder asyncTaskMethodBuilder3 = (AsyncTaskMethodBuilder)((nint)(&stateMachine) | (nint)8);
		return ((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder3)->Task;
	}

	public static void Save<T>(T item, string fileName, string extension, string savingPath, JsonSerializerSettings serializerSettings, string separator = "_", bool useCompression = false)
	{
		//IL_03ab: Expected O, but got I4
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0192: Expected O, but got I4
		//IL_0098: Expected O, but got I4
		//IL_00a1: Expected O, but got I4
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected O, but got Unknown
		//IL_0102: Expected I4, but got O
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		//IL_0208: Expected O, but got I4
		//IL_0219: Expected O, but got I4
		//IL_0143: Expected O, but got I4
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected O, but got Unknown
		//IL_02ce: Expected O, but got I4
		//IL_03f4: Expected O, but got I4
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Expected O, but got Unknown
		//IL_0360: Expected O, but got I4
		bool flag = string.IsNullOrWhiteSpace(fileName);
		bool flag2 = !flag;
		object obj = !flag2;
		if (obj != null || string.IsNullOrWhiteSpace(savingPath))
		{
			return;
		}
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 520;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v7+E4]");
		JsonSerializerSettings jsonSerializerSettings;
		string text2;
		string data;
		object obj5;
		if ((nint)0 != 0)
		{
			string text = JsonConvert.SerializeObject(item, serializerSettings);
			bool flag3 = !useCompression;
			object obj4 = !flag3;
			obj5 = 0;
			jsonSerializerSettings = serializerSettings;
			text2 = text;
			data = text;
			if (obj4 == null)
			{
				goto IL_00c7;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			string text3 = JsonConvert.SerializeObject(item, serializerSettings);
			bool flag4 = !useCompression;
			obj5 = 0;
			jsonSerializerSettings = serializerSettings;
			text2 = text3;
			data = text3;
			if (flag4)
			{
				goto IL_00c7;
			}
		}
		string text4 = CompressUtil.Compress(data);
		object obj6 = typeof(System.Buffers.Text.ParserHelpers) + 72;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X0_v31+E4]");
		bool flag5 = (nint)0 == 0;
		object obj8 = !flag5;
		text2 = text4;
		obj5 = 0;
		CompressUtil.CompressionAlgorithm compressionAlgorithm = CompressUtil.CompressionAlgorithm.Brotli;
		string text5 = text4;
		object obj9 = obj6;
		if (obj8 != null)
		{
			goto IL_0120;
		}
		goto IL_0240;
		IL_0240:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		char[] separator2 = Path.GetInvalidFileNameChars();
		text2 = text5;
		obj6 = obj9;
		goto IL_026d;
		IL_00c7:
		obj6 = typeof(System.Buffers.Text.ParserHelpers) + 72;
		obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X0_v31+E4]");
		bool flag6 = (nint)0 == 0;
		compressionAlgorithm = (CompressUtil.CompressionAlgorithm)jsonSerializerSettings;
		text5 = text2;
		obj9 = obj6;
		if (!flag6)
		{
			goto IL_0120;
		}
		goto IL_0240;
		IL_026d:
		string[] value = fileName.Split(separator2);
		string text6 = string.Join(separator, value);
		object obj10 = ", stale={0}" + 1352;
		bool flag7 = extension.StartsWith((string)obj10);
		bool flag8 = !flag7;
		object obj11 = !flag8;
		string text7 = extension;
		if (obj11 == null)
		{
			string text8 = (string)obj10 + extension;
			text7 = text8;
		}
		string path = text6 + text7;
		object obj12 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X0_v20+E4]");
		bool flag9 = (nint)0 == 0;
		object obj13 = !flag9;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string path2 = Path.Combine(savingPath, path);
		object obj14 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 488;
		object obj15 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v11+E4]");
		bool flag10 = (nint)0 == 0;
		object obj16 = !flag10;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		FileUtils.SaveObject(path2, text2);
		return;
		IL_0120:
		char[] invalidFileNameChars = Path.GetInvalidFileNameChars();
		bool flag11 = fileName == null;
		object obj17 = !flag11;
		separator2 = invalidFileNameChars;
		if (obj17 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_026d;
	}

	public static void Delete(string fileName, string extension, string savingPath, string separator = "_")
	{
		//IL_0231: Expected O, but got I4
		//IL_002c: Expected O, but got I4
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_0078: Expected O, but got I4
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		//IL_0104: Expected O, but got I4
		//IL_027a: Expected O, but got I4
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected O, but got Unknown
		//IL_01fb: Expected O, but got I4
		bool flag = string.IsNullOrWhiteSpace(fileName);
		bool flag2 = !flag;
		object obj = !flag2;
		if (obj != null)
		{
			return;
		}
		bool flag3 = string.IsNullOrWhiteSpace(savingPath);
		bool flag4 = !flag3;
		object obj2 = !flag4;
		if (obj2 != null)
		{
			return;
		}
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 72;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X0_v7+E4]");
		bool flag5 = (nint)0 == 0;
		object obj5 = !flag5;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		char[] invalidFileNameChars = Path.GetInvalidFileNameChars();
		string[] value = fileName.Split(invalidFileNameChars);
		string text = string.Join(separator, value);
		object obj6 = ", stale={0}" + 1352;
		bool flag6 = extension.StartsWith((string)obj6);
		bool flag7 = !flag6;
		object obj7 = !flag7;
		string text2 = extension;
		if (obj7 == null)
		{
			string text3 = (string)obj6 + extension;
			text2 = text3;
		}
		string path = text + text2;
		object obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X0_v22+E4]");
		bool flag8 = (nint)0 == 0;
		object obj9 = !flag8;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string path2 = Path.Combine(savingPath, path);
		object obj10 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 488;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v26+E4]");
		if ((nint)0 != 0)
		{
			if (!File.Exists(path2))
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag9 = File.Exists(path2);
			bool flag10 = !flag9;
			object obj12 = !flag10;
			if (obj12 == null)
			{
				return;
			}
		}
		File.Delete(path2);
	}
}
