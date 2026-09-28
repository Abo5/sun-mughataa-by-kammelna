using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq.JsonPath;
using Newtonsoft.Json.Serialization;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.Rendering;

public class FileUtils
{
	private class WritablePropertiesOnlyResolver : DefaultContractResolver
	{
		protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
		{
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Expected O, but got Unknown
			//IL_006d: Expected I, but got O
			//IL_0096: Expected O, but got I4
			//IL_00ca: Expected O, but got I
			MemberSerialization memberSerialization2 = default(MemberSerialization);
			JsonProperty jsonProperty = base.CreateProperty(member, memberSerialization2);
			if (jsonProperty != null)
			{
				if (!jsonProperty.<Writable>k__BackingField && (object)member != null)
				{
					object obj = typeof(System.Buffers.Text.ParserHelpers) + 2360;
					object obj2 = obj;
					nint num = (nint)member;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X9_v1 (Il2CppClass<System.Reflection.MemberInfo>)+130]");
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v6+130]");
					bool flag = num2 < 0;
					object obj3 = !flag;
					object obj4 = ~obj3;
					if (obj4 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X9_v1 (Il2CppClass<System.Reflection.MemberInfo>)+C8]");
						nint num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v6+130]");
						object obj5 = num3 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X9_v3-8]");
						if (0 == (nint)obj2)
						{
							jsonProperty.<Ignored>k__BackingField = true;
							return jsonProperty;
						}
					}
				}
				return jsonProperty;
			}
			return (JsonProperty)(object)new NullReferenceException();
		}

		public WritablePropertiesOnlyResolver()
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00b4: Expected O, but got I4
			object obj = 152981504;
			object obj2 = typeof(DataRelation) + 1488;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5FA7]");
			if ((object)((nint)0 & (nint)1) != null)
			{
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v1+E4]");
				if ((nint)0 != 0)
				{
					goto IL_007d;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v1+E4]");
				if ((object)((nint)0 != 0) != null)
				{
					goto IL_007d;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			base..ctor();
			return;
			IL_007d:
			base..ctor();
		}
	}

	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<FileInfo, string> <>9__5_0;

		public static Func<FileInfo, byte[]> <>9__7_0;

		public static Func<FileInfo, long> <>9__16_0;

		public static Func<FileInfo, DateTime> <>9__17_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(DebugUI.BitField) + 2472;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal string <ReadFiles>b__5_0(FileInfo file)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0021: Expected I, but got O
			if (file != null)
			{
				object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 488;
				nint num = (nint)file;
				string fullName = file.FullName;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v4+E4]");
				if ((nint)0 != 0)
				{
					return File.ReadAllText(fullName);
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				return File.ReadAllText(fullName);
			}
			return (string)(object)new NullReferenceException();
		}

		internal byte[] <ReadFilesAsByteArray>b__7_0(FileInfo file)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0021: Expected I, but got O
			if (file != null)
			{
				object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 488;
				nint num = (nint)file;
				string fullName = file.FullName;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v4+E4]");
				if ((nint)0 != 0)
				{
					return File.ReadAllBytes(fullName);
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				return File.ReadAllBytes(fullName);
			}
			return (byte[])(object)new NullReferenceException();
		}

		internal long <GetDirectorySize>b__16_0(FileInfo file)
		{
			//IL_003d: Expected I8, but got O
			if (file != null)
			{
				return file.Length;
			}
			NullReferenceException ex = new NullReferenceException();
			return (long)ex;
		}

		internal DateTime <CleanFolder>b__17_0(FileInfo fileInfo)
		{
			return (DateTime)(((object?)fileInfo?.LastAccessTime) ?? ((object)new NullReferenceException()));
		}
	}

	private sealed class <>c__DisplayClass17_0
	{
		public long directorySize;

		public long maxSize;

		internal bool <CleanFolder>b__1(FileInfo file)
		{
			//IL_0011: Expected O, but got I8
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Expected I8, but got Unknown
			//IL_0084: Expected O, but got I4
			//IL_008c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0091: Expected I4, but got Unknown
			object obj = directorySize - maxSize;
			bool flag = (nint)obj < 0;
			bool flag2 = obj == null;
			long num = directorySize ^ maxSize;
			long num2 = directorySize ^ obj;
			long num3 = num & num2;
			bool flag3 = num3 < 0;
			bool flag4 = flag == flag3;
			object obj2 = !flag2;
			return (byte)((flag4 & obj2) ? 1 : 0) != 0;
		}

		internal void <CleanFolder>b__2(FileInfo fileInfo)
		{
			//IL_002e: Expected I, but got O
			//IL_003e: Expected O, but got I
			//IL_004e: Expected O, but got I
			long length = fileInfo.Length;
			long num = directorySize - length;
			directorySize = num;
			nint num2 = (nint)fileInfo;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v2 (Il2CppClass<System.IO.FileInfo>)+1E8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v2 (Il2CppClass<System.IO.FileInfo>)+1F0]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v40 @ X2_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	private static readonly JsonSerializerSettings OBJECT_SETTINGS;

	public static void SaveFile(string path, byte[] content, Action storageFullCallback = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_014b: Expected O, but got I4
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0092: Expected O, but got I4
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected O, but got Unknown
		//IL_0197: Expected O, but got I4
		//IL_00f6: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 72;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string directoryName = Path.GetDirectoryName(path);
		DirectoryInfo directoryInfo = Directory.CreateDirectory(directoryName);
		File.WriteAllBytes(path, content);
		object obj4 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 488;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v8+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj7 = typeof(DataRelation) + 712;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v11+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime now = DateTime.Now;
		object obj10 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v15+E4]");
		bool flag4 = (nint)0 == 0;
		object obj11 = !flag4;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		SetLastAccessTime(path, now);
	}

	public static void SaveObject<T>(string path, T obj)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0048: Expected O, but got I4
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected O, but got Unknown
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected O, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_00e9: Expected O, but got I4
		//IL_021d: Expected O, but got I4
		//IL_03c1: Expected O, but got I
		//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d5: Expected O, but got Unknown
		//IL_03ff: Expected O, but got I4
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected O, but got Unknown
		//IL_038a: Expected O, but got I4
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Expected O, but got Unknown
		//IL_042d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0432: Expected O, but got Unknown
		//IL_045e: Expected O, but got I4
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 72;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v60+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string directoryName = Path.GetDirectoryName(path);
		if (directoryName != null)
		{
			DirectoryInfo directoryInfo = Directory.CreateDirectory(directoryName);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object obj5 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 488;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v50+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj6 = obj5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v50+B8]");
			object settings = 0;
			object obj8 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 520;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v51+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object value = default(object);
			string contents = JsonConvert.SerializeObject(value, (JsonSerializerSettings)settings);
			File.WriteAllText(path, contents);
			return;
		}
		object obj11 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 648;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj12 = "not" + 3576;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		ArgumentNullException ex = default(ArgumentNullException);
		string paramName = default(string);
		ex..ctor(paramName);
		OutOfMemoryException ex2 = new OutOfMemoryException();
		IntPtr intPtr = default(IntPtr);
		bool flag4 = intPtr != (IntPtr)1;
		object obj13 = 0;
		nint num = intPtr;
		OutOfMemoryException ex3 = ex2;
		if (!flag4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			object obj14 = typeof(DataRelation) + 3808;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			object obj16 = default(object);
			object obj15 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1F90");
			object obj17 = default(object);
			if (obj17 != null)
			{
				object obj18 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				object obj19 = "Error reading data from socket: " + 3472;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
				string format = default(string);
				object arg = default(object);
				string text = string.Format(format, arg);
				string text2;
				if (obj16 != null)
				{
					object obj20 = obj18;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v241 @ X8_v9+168] (should have been resolved before IL gen)");
					string text3 = default(string);
					text2 = text3;
				}
				else
				{
					text2 = null;
				}
				string message = text + text2;
				object obj21 = typeof(DataRelation) + 856;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X0_v40+E4]");
				bool flag5 = (nint)0 == 0;
				object obj22 = !flag5;
				if (obj22 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Debug.LogError(message);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B68");
			object obj23 = obj16;
			num = 139030496;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0C04");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			obj13 = 0;
			OutOfMemoryException ex4 = default(OutOfMemoryException);
			ex3 = ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	public static void SaveObject(string path, string objectAsString)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00f7: Expected O, but got I4
		//IL_0099: Expected O, but got I4
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected O, but got Unknown
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected O, but got Unknown
		//IL_013b: Expected O, but got I4
		//IL_0144: Expected O, but got I4
		//IL_01b6: Expected O, but got I
		//IL_01e9: Expected O, but got I4
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected O, but got Unknown
		//IL_035f: Expected O, but got I4
		//IL_0378: Expected O, but got I4
		//IL_0295: Expected O, but got I4
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Expected O, but got Unknown
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dc: Expected O, but got Unknown
		//IL_0408: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5EEA]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v49+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v49+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		string directoryName = Path.GetDirectoryName(path);
		bool flag2 = directoryName == null;
		object obj5 = !flag2;
		object obj6 = 0;
		if (obj5 != null)
		{
			goto IL_00a7;
		}
		goto IL_0152;
		IL_00a7:
		DirectoryInfo directoryInfo = Directory.CreateDirectory(directoryName);
		File.WriteAllText(path, objectAsString);
		return;
		IL_0152:
		object obj7 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 648;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj8 = "not" + 3576;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		ArgumentNullException ex = default(ArgumentNullException);
		string paramName = default(string);
		ex..ctor(paramName);
		object obj9 = (nint)0 + (nint)3384;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		OutOfMemoryException ex2 = new OutOfMemoryException();
		object obj10 = default(object);
		bool flag3 = (nint)obj10 != 1;
		object obj11 = 0;
		object obj12 = obj10;
		OutOfMemoryException ex3 = ex2;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			object obj13 = typeof(DataRelation) + 3808;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			object obj15 = default(object);
			object obj14 = obj15;
			obj12 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1F90");
			object obj16 = default(object);
			if (obj16 != null)
			{
				object obj17 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				bool flag4 = ex == null;
				obj11 = 0;
				if (!flag4)
				{
					Type type = ((object)ex).GetType();
					object obj18 = "Error reading data from socket: " + 3472;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
					string format = default(string);
					string text = string.Format(format, type);
					string text2;
					if (obj15 != null)
					{
						object obj19 = obj17;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v205 @ X8_v9+168] (should have been resolved before IL gen)");
						string text3 = default(string);
						text2 = text3;
					}
					else
					{
						text2 = null;
					}
					string message = text + text2;
					object obj20 = typeof(DataRelation) + 856;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X0_v43+E4]");
					bool flag5 = (nint)0 == 0;
					object obj21 = !flag5;
					if (obj21 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Debug.LogError(message);
					return;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B68");
				object obj22 = obj15;
				obj12 = 139026432 + 4064;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0C04");
				obj11 = 0;
			}
			NullReferenceException ex4 = new NullReferenceException();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			ex3 = (OutOfMemoryException)(object)ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_0074:
		directoryName = Path.GetDirectoryName(path);
		bool flag6 = directoryName == null;
		obj6 = 0;
		if (!flag6)
		{
			goto IL_00a7;
		}
		goto IL_0152;
	}

	public static List<string> ReadFiles(string path, string fileTypeExtension, bool searchInSubDirectories = false)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_0133: Expected O, but got I
		//IL_0143: Expected O, but got I
		//IL_0165: Expected O, but got I4
		//IL_00ca: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_00fc: Expected O, but got I4
		//IL_0195: Expected O, but got I4
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Expected O, but got Unknown
		//IL_0260: Expected O, but got I
		//IL_0271: Expected I, but got O
		//IL_028f: Expected O, but got I
		//IL_01c5: Expected O, but got I
		object obj = typeof(DataRelation) + 2280;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		DirectoryInfo directoryInfo = default(DirectoryInfo);
		directoryInfo..ctor(path);
		FileInfo[] files;
		object obj3;
		object obj5;
		Func<object, object> selector;
		if (directoryInfo != null)
		{
			if (directoryInfo.Exists)
			{
				object obj2 = "&action=sign-up" + 3008;
				string searchPattern = (string)obj2 + fileTypeExtension;
				files = directoryInfo.GetFiles(searchPattern, searchInSubDirectories ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
				obj3 = typeof(DebugUI.BitField) + 2472;
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v17+E4]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v17+B8]");
					obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v13+8]");
					selector = (Func<object, object>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v13+8]");
					bool flag = (nint)0 == 0;
					object obj6 = !flag;
					if (obj6 == null)
					{
						goto IL_0173;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj4 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v17+B8]");
					obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v13+8]");
					selector = (Func<object, object>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v13+8]");
					bool flag2 = (nint)0 == 0;
					object obj7 = !flag2;
					if (obj7 == null)
					{
						goto IL_0173;
					}
				}
				goto IL_01ca;
			}
			return null;
		}
		return (List<string>)(object)new NullReferenceException();
		IL_01ca:
		IEnumerable<object> source = Enumerable.Select(files, selector);
		return (List<string>)(object)Enumerable.ToList(source);
		IL_0173:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v17+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj9 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v19+B8]");
			obj5 = 0;
		}
		object obj10 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1120;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj11 = (nint)0 + (nint)4000;
		Func<object, object> func = default(Func<object, object>);
		func..ctor(obj5, (IntPtr)obj11);
		object obj12 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v18+B8]");
		object obj13 = (nint)0 + (nint)8;
		obj13 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		selector = func;
		goto IL_01ca;
	}

	private static string ReadFile(string path)
	{
		return File.ReadAllText(path);
	}

	public static List<byte[]> ReadFilesAsByteArray(string path, string fileTypeExtension, bool searchInSubDirectories = false)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_0098: Expected O, but got I4
		//IL_0189: Expected O, but got I
		//IL_0199: Expected O, but got I
		//IL_01bb: Expected O, but got I4
		//IL_00df: Expected O, but got I4
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Expected O, but got Unknown
		//IL_01f3: Expected O, but got I
		//IL_0204: Expected I, but got O
		//IL_0222: Expected O, but got I
		//IL_010f: Expected O, but got I
		object obj = typeof(DataRelation) + 2280;
		object obj2 = "&action=sign-up" + 3008;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		DirectoryInfo directoryInfo = default(DirectoryInfo);
		directoryInfo..ctor(path);
		string searchPattern = (string)obj2 + fileTypeExtension;
		if (directoryInfo != null)
		{
			object obj3 = typeof(DebugUI.BitField) + 2472;
			FileInfo[] files = directoryInfo.GetFiles(searchPattern, searchInSubDirectories ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v10+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj4 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v10+B8]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v6+10]");
			Func<object, object> selector = (Func<object, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v6+10]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v10+E4]");
				bool flag3 = (nint)0 == 0;
				object obj8 = !flag3;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj9 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v12+B8]");
					obj6 = 0;
				}
				object obj10 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1088;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj11 = (nint)0 + (nint)4008;
				Func<object, object> func = default(Func<object, object>);
				func..ctor(obj6, (IntPtr)obj11);
				object obj12 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v11+B8]");
				object obj13 = (nint)0 + (nint)16;
				obj13 = func;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				selector = func;
			}
			IEnumerable<object> source = Enumerable.Select(files, selector);
			return (List<byte[]>)(object)Enumerable.ToList(source);
		}
		return (List<byte[]>)(object)new NullReferenceException();
	}

	private static byte[] ReadFileAsByteArray(string path)
	{
		return File.ReadAllBytes(path);
	}

	public static T LoadObject<T>(string path, T defaultValue = default(T))
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0048: Expected O, but got I4
		//IL_0090: Expected O, but got I4
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected O, but got Unknown
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 488;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		T obj4;
		bool flag2 = TryLoadObject<T>(path, out obj4);
		bool flag3 = !flag2;
		object obj5 = !flag3;
		object obj6 = ~obj5;
		T val = ((obj6 != null) ? defaultValue : obj4);
		return (T)(val & 1);
	}

	public unsafe static bool TryLoadObject<T>(string path, out T obj)
	{
		//IL_002b: Expected O, but got I4
		//IL_012f: Expected O, but got I4
		//IL_013f: Expected O, but got I
		//IL_0161: Expected O, but got I4
		//IL_0185: Expected O, but got I
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_0084: Expected O, but got I4
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected O, but got Unknown
		//IL_01f0: Expected O, but got I4
		//IL_022d: Expected O, but got I
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected O, but got Unknown
		//IL_026b: Expected O, but got I4
		bool flag = File.Exists(path);
		bool flag2 = !flag;
		object obj2 = 0;
		ref T reference;
		if (!flag2)
		{
			string value = File.ReadAllText(path);
			object obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 488;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v19+E4]");
			bool flag3 = (nint)0 == 0;
			object obj5 = !flag3;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj4 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v19+B8]");
			object settings = 0;
			object obj6 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 520;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X0_v20+E4]");
			bool flag4 = (nint)0 == 0;
			object obj8 = !flag4;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			T val = JsonConvert.DeserializeObject<T>(value, (JsonSerializerSettings)settings);
			reference = ref *(T*)val;
			return true;
		}
		object obj9 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v5+E0]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v2+E4]");
		bool flag5 = (nint)0 == 0;
		object obj11 = !flag5;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
		object format = "Complete" + 2752;
		string text = string.Format((string)format, typeFromHandle, path);
		object obj12 = typeof(DataRelation) + 856;
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v11+E4]");
		bool flag6 = (nint)0 == 0;
		object obj14 = !flag6;
		object message = text;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			message = text;
		}
		Debug.Log(message);
		reference = ref *(T*)null;
		return false;
	}

	public static void Delete(string path)
	{
		if (File.Exists(path))
		{
			File.Delete(path);
		}
	}

	public static void UpdateLastAccessTime(string imagePath)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected O, but got Unknown
		//IL_0131: Expected O, but got I4
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0189: Expected O, but got I4
		object obj = 152981504;
		object obj2 = typeof(DataRelation) + 712;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5FA5]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object obj6;
		if (obj3 != null)
		{
			obj4 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 488;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v4+E4]");
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
			obj4 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 488;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v4+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0099;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		DateTime now = DateTime.Now;
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v1+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		DateTime lastAccessTime = now;
		DateTime lastAccessTime2 = now;
		if (obj9 != null)
		{
			goto IL_00df;
		}
		goto IL_01a7;
		IL_00df:
		SetLastAccessTime(imagePath, lastAccessTime);
		return;
		IL_01a7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		SetLastAccessTime(imagePath, lastAccessTime2);
		return;
		IL_0099:
		DateTime now2 = DateTime.Now;
		obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v1+E4]");
		bool flag4 = (nint)0 == 0;
		lastAccessTime = now2;
		lastAccessTime2 = now2;
		if (!flag4)
		{
			goto IL_00df;
		}
		goto IL_01a7;
	}

	public static void SetLastAccessTime(string imagePath, DateTime lastAccessTime)
	{
		File.SetLastAccessTime(imagePath, lastAccessTime);
	}

	public static void UpdateLastWriteTime(string imagePath)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected O, but got Unknown
		//IL_0131: Expected O, but got I4
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0189: Expected O, but got I4
		object obj = 152981504;
		object obj2 = typeof(DataRelation) + 712;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5EED]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object obj6;
		if (obj3 != null)
		{
			obj4 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 488;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v4+E4]");
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
			obj4 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 488;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v4+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0099;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		DateTime now = DateTime.Now;
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v1+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		DateTime lastWriteTime = now;
		DateTime lastWriteTime2 = now;
		if (obj9 != null)
		{
			goto IL_00df;
		}
		goto IL_01a7;
		IL_00df:
		SetLastWriteTime(imagePath, lastWriteTime);
		return;
		IL_01a7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		SetLastWriteTime(imagePath, lastWriteTime2);
		return;
		IL_0099:
		DateTime now2 = DateTime.Now;
		obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v1+E4]");
		bool flag4 = (nint)0 == 0;
		lastWriteTime = now2;
		lastWriteTime2 = now2;
		if (!flag4)
		{
			goto IL_00df;
		}
		goto IL_01a7;
	}

	public static void SetLastWriteTime(string imagePath, DateTime lastWriteTime)
	{
		File.SetLastWriteTime(imagePath, lastWriteTime);
	}

	public static long GetDirectorySize(string path)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_01ba: Expected I8, but got O
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_00ee: Expected O, but got I
		//IL_00fe: Expected O, but got I
		//IL_010e: Expected O, but got I
		//IL_0130: Expected O, but got I4
		//IL_0073: Expected O, but got I
		//IL_0083: Expected O, but got I
		//IL_0093: Expected O, but got I
		//IL_00b5: Expected O, but got I4
		//IL_0168: Expected O, but got I4
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected O, but got Unknown
		//IL_0218: Expected O, but got I
		//IL_0229: Expected I, but got O
		//IL_0247: Expected O, but got I
		//IL_0198: Expected O, but got I
		object obj = typeof(DataRelation) + 2280;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		DirectoryInfo directoryInfo = default(DirectoryInfo);
		directoryInfo..ctor(path);
		object obj2;
		object obj5;
		object obj7;
		object obj4;
		Func<object, long> func;
		if (directoryInfo != null)
		{
			obj2 = typeof(DebugUI.BitField) + 2472;
			IEnumerable<FileInfo> enumerable = directoryInfo.EnumerateFiles();
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v11+E4]");
			if ((nint)0 != 0)
			{
				obj4 = (nint)0 + (nint)704;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v11+B8]");
				obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v6+18]");
				func = (Func<object, long>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v6+18]");
				bool flag = (nint)0 == 0;
				object obj6 = !flag;
				if (obj6 == null)
				{
					obj7 = obj4;
					goto IL_0146;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj3 = obj2;
				obj7 = (nint)0 + (nint)704;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v11+B8]");
				obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v6+18]");
				func = (Func<object, long>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v6+18]");
				bool flag2 = (nint)0 == 0;
				object obj8 = !flag2;
				obj4 = obj7;
				if (obj8 == null)
				{
					goto IL_0146;
				}
			}
			goto IL_019d;
		}
		NullReferenceException ex = new NullReferenceException();
		return (long)ex;
		IL_019d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DE3A00");
		long result = default(long);
		return result;
		IL_0146:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v11+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj10 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v12+B8]");
			obj5 = 0;
		}
		object obj11 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1112;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj12 = (nint)0 + (nint)3992;
		Func<object, long> func2 = default(Func<object, long>);
		func2..ctor(obj5, (IntPtr)obj12);
		object obj13 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v11+B8]");
		object obj14 = (nint)0 + (nint)24;
		obj14 = func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj4 = obj7;
		func = func2;
		goto IL_019d;
	}

	public static void CleanFolder(string path, long maxSize)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_0127: Expected O, but got I
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected O, but got Unknown
		//IL_01f1: Expected O, but got I
		//IL_0201: Expected O, but got I
		//IL_0223: Expected O, but got I4
		//IL_0294: Expected O, but got I
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Expected O, but got Unknown
		//IL_018a: Expected O, but got I
		//IL_019a: Expected O, but got I
		//IL_01bc: Expected O, but got I4
		//IL_02d4: Expected O, but got I
		//IL_02e5: Expected I, but got O
		//IL_02f1: Expected O, but got I
		//IL_0253: Expected O, but got I4
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Expected O, but got Unknown
		//IL_032a: Expected O, but got I
		//IL_033b: Expected I, but got O
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Expected O, but got Unknown
		//IL_0391: Expected O, but got I
		//IL_03a2: Expected I, but got O
		//IL_03c0: Expected O, but got I
		//IL_0283: Expected O, but got I
		object obj = typeof(DebugUI.BitField) + 2480;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 488;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v6+E4]");
		if ((nint)0 != 0)
		{
			long directorySize = GetDirectorySize(path);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3 (System.Object)+18]");
			if (directorySize < 0)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			long directorySize2 = GetDirectorySize(path);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3 (System.Object)+18]");
			if (directorySize2 < 0)
			{
				return;
			}
		}
		object obj5 = typeof(DataRelation) + 2280;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		DirectoryInfo directoryInfo = default(DirectoryInfo);
		directoryInfo..ctor(path);
		IEnumerable<FileInfo> source = directoryInfo.EnumerateFiles();
		object obj6 = (nint)0 + (nint)2064;
		List<object> source2 = Enumerable.ToList((IEnumerable<object>)source);
		object obj7 = typeof(DebugUI.BitField) + 2472;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X0_v24+E4]");
		object obj9;
		Func<object, DateTime> keySelector;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X0_v24+B8]");
			obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X8_v29+20]");
			keySelector = (Func<object, DateTime>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X8_v29+20]");
			bool flag = (nint)0 == 0;
			object obj10 = !flag;
			if (obj10 == null)
			{
				goto IL_0231;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X0_v24+B8]");
			obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X8_v29+20]");
			keySelector = (Func<object, DateTime>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X8_v29+20]");
			bool flag2 = (nint)0 == 0;
			object obj11 = !flag2;
			if (obj11 == null)
			{
				goto IL_0231;
			}
		}
		goto IL_0288;
		IL_0231:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X0_v24+E4]");
		bool flag3 = (nint)0 == 0;
		object obj12 = !flag3;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj13 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X8_v35+B8]");
			obj9 = 0;
		}
		object obj14 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1104;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj15 = (nint)0 + (nint)3984;
		Func<object, DateTime> func = default(Func<object, DateTime>);
		func..ctor(obj9, (IntPtr)obj15);
		object obj16 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X8_v34+B8]");
		object obj17 = (nint)0 + (nint)32;
		obj17 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		keySelector = func;
		goto IL_0288;
		IL_0288:
		object obj18 = (nint)0 + (nint)2088;
		IOrderedEnumerable<object> orderedEnumerable = Enumerable.OrderBy(source2, keySelector);
		object obj19 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1096;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj20 = (nint)0 + (nint)4016;
		Func<object, bool> func2 = default(Func<object, bool>);
		func2..ctor(obj2, (IntPtr)obj20);
		object obj21 = (nint)0 + (nint)928;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DE4200");
		object obj22 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1968;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj23 = (nint)0 + (nint)4024;
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj23);
		IEnumerable<object> enumeration = default(IEnumerable<object>);
		ArraysExtensions.ForEach(enumeration, action);
	}

	public static long MegabytesToBytes(int bytes)
	{
		//IL_0013: Expected I8, but got I4
		int num = bytes << 20;
		return num;
	}

	public static long BytesToMegabytes(int megabytes)
	{
		//IL_005f: Expected O, but got I4
		//IL_00a4: Expected I8, but got I4
		int num = megabytes + 1048575;
		bool flag = megabytes < 0;
		int num2 = megabytes ^ megabytes;
		int num3 = megabytes & num2;
		bool flag2 = num3 < 0;
		bool flag3 = flag == flag2;
		object obj = !flag3;
		object obj2 = ~obj;
		if (obj2 != null)
		{
			num = megabytes;
		}
		int num4 = num >> 20;
		return num4 & 0xFFF;
	}

	static FileUtils()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0036: Expected O, but got I4
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_0060: Expected O, but got I
		//IL_013c: Expected O, but got I4
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		//IL_017c: Expected O, but got I4
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1024;
		object obj2 = typeof(DebugUI.BitField) + 2488;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		JsonSerializerSettings jsonSerializerSettings = default(JsonSerializerSettings);
		jsonSerializerSettings..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj3 = 152981504;
		object obj4 = typeof(DataRelation) + 1488;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5FA7]");
		object obj5 = (nint)0 & (nint)1;
		if (obj5 != null)
		{
			object obj6 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v8+E4]");
			if ((nint)0 != 0)
			{
				goto IL_00aa;
			}
		}
		else
		{
			_ = 1;
			object obj6 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v8+E4]");
			bool flag = (nint)0 == 0;
			object obj7 = !flag;
			if (obj7 != null)
			{
				goto IL_00aa;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		DefaultContractResolver defaultContractResolver = default(DefaultContractResolver);
		defaultContractResolver..ctor();
		bool flag2 = jsonSerializerSettings == null;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00b8;
		IL_00aa:
		defaultContractResolver..ctor();
		goto IL_00b8;
		IL_00b8:
		object obj9 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 488;
		object obj10 = jsonSerializerSettings + 224;
		obj10 = defaultContractResolver;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj11 = obj9;
		object obj12 = jsonSerializerSettings;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
