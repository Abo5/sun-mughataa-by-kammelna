using System;
using System.ComponentModel;
using System.IO;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Unity.Services.Authentication.Shared;
using UnityEngine.TextCore;

public static class CompressUtil
{
	public enum CompressionAlgorithm
	{
		Brotli,
		GZip
	}

	public static string Compress(string data, CompressionAlgorithm compressionAlgorithm = CompressionAlgorithm.Brotli)
	{
		//IL_002e: Expected I, but got O
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0069: Expected O, but got I
		//IL_012c: Expected O, but got I4
		Encoding uTF = Encoding.UTF8;
		byte[] inArray;
		if (uTF != null)
		{
			nint num = (nint)uTF;
			byte[] bytes = uTF.GetBytes(data);
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3016;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5D69]");
			object obj2 = (nint)0 & (nint)1;
			CompressionAlgorithm compressionAlgorithm2 = default(CompressionAlgorithm);
			byte[] array2;
			if (obj2 != null)
			{
				byte[] array = Compress(bytes, compressionAlgorithm2);
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v3+E4]");
				bool flag = (nint)0 == 0;
				inArray = array;
				array2 = array;
				if (!flag)
				{
					goto IL_00d4;
				}
			}
			else
			{
				_ = 1;
				array2 = Compress(bytes, compressionAlgorithm2);
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v3+E4]");
				bool flag2 = (nint)0 == 0;
				object obj4 = !flag2;
				inArray = array2;
				if (obj4 != null)
				{
					goto IL_00d4;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			return Convert.ToBase64String(array2);
		}
		return (string)(object)new NullReferenceException();
		IL_00d4:
		return Convert.ToBase64String(inArray);
	}

	public static string CompressToString(byte[] data, CompressionAlgorithm compressionAlgorithm = CompressionAlgorithm.Brotli)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00f6: Expected O, but got I4
		object obj = 152981504;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3016;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5D69]");
		object obj3 = (nint)0 & (nint)1;
		CompressionAlgorithm compressionAlgorithm2 = default(CompressionAlgorithm);
		byte[] inArray;
		byte[] array2;
		if (obj3 != null)
		{
			byte[] array = Compress(data, compressionAlgorithm2);
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v2+E4]");
			bool flag = (nint)0 == 0;
			inArray = array;
			array2 = array;
			if (!flag)
			{
				goto IL_009e;
			}
		}
		else
		{
			_ = 1;
			array2 = Compress(data, compressionAlgorithm2);
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			inArray = array2;
			if (obj5 != null)
			{
				goto IL_009e;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		return Convert.ToBase64String(array2);
		IL_009e:
		return Convert.ToBase64String(inArray);
	}

	public static byte[] CompressToBytes(string data, CompressionAlgorithm compressionAlgorithm = CompressionAlgorithm.Brotli)
	{
		Encoding uTF = Encoding.UTF8;
		if (uTF != null)
		{
			byte[] bytes = uTF.GetBytes(data);
			return Compress(bytes, compressionAlgorithm);
		}
		return (byte[])(object)new NullReferenceException();
	}

	public unsafe static byte[] Compress(byte[] data, CompressionAlgorithm compressionAlgorithm = CompressionAlgorithm.Brotli)
	{
		//IL_0008: Expected O, but got Ref
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_084d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0852: Expected O, but got Unknown
		//IL_087c: Expected O, but got Ref
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_00e9: Expected O, but got I4
		//IL_08c8: Expected O, but got I4
		//IL_08d1: Expected O, but got I4
		//IL_08da: Expected O, but got I4
		//IL_08e2: Expected O, but got Ref
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0134: Expected O, but got I
		//IL_008d: Expected O, but got I4
		//IL_060a: Expected O, but got I4
		//IL_0613: Expected O, but got I4
		//IL_061c: Expected O, but got I4
		//IL_063d: Expected O, but got Ref
		//IL_0169: Expected O, but got I
		//IL_0179: Expected O, but got I
		//IL_066a: Expected O, but got I4
		//IL_0673: Expected O, but got I4
		//IL_067c: Expected O, but got I4
		//IL_0711: Expected O, but got I4
		//IL_01b8: Expected O, but got I
		//IL_01c8: Expected O, but got I
		//IL_01ea: Expected O, but got I4
		//IL_01f3: Expected O, but got I4
		//IL_01fc: Expected O, but got I4
		//IL_0216: Expected O, but got I4
		//IL_022f: Expected O, but got I4
		//IL_0240: Expected O, but got I4
		//IL_0249: Expected O, but got I4
		//IL_025b: Expected O, but got I4
		//IL_0289: Expected O, but got I
		//IL_090a: Expected O, but got I4
		//IL_078f: Expected O, but got Ref
		//IL_07b1: Expected O, but got I4
		//IL_03da: Expected O, but got I
		//IL_0964: Expected O, but got I
		//IL_02c4: Expected O, but got I
		//IL_036d: Expected O, but got Ref
		//IL_03a4: Expected O, but got Ref
		//IL_07f4: Expected O, but got Ref
		//IL_0928: Expected O, but got I
		//IL_09ad: Expected O, but got I4
		//IL_0a50: Expected O, but got I4
		//IL_0a07: Expected O, but got I
		//IL_0415: Expected O, but got I
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Expected O, but got Unknown
		//IL_04f3: Expected O, but got I
		//IL_09cb: Expected O, but got I
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Expected O, but got Unknown
		//IL_02ed: Expected O, but got I
		//IL_049c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a1: Expected O, but got Unknown
		//IL_0aa2: Expected O, but got I
		//IL_052e: Expected O, but got I
		//IL_0423: Unknown result type (might be due to invalid IL or missing references)
		//IL_0428: Expected O, but got Unknown
		//IL_043e: Expected O, but got I
		//IL_0a6e: Expected O, but got I
		//IL_05b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ba: Expected O, but got Unknown
		//IL_053c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0541: Expected O, but got Unknown
		//IL_0557: Expected O, but got I
		object obj2 = default(object);
		object obj = (object)(&obj2);
		object obj3 = typeof(MemberAchievementClanFeedData) + 192;
		object obj4 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		MemoryStream memoryStream = default(MemoryStream);
		memoryStream..ctor(data);
		object obj5 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 56));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		MemoryStream memoryStream2 = default(MemoryStream);
		memoryStream2..ctor();
		CompressionLevel compressionLevel;
		Stream stream;
		GZipStream gZipStream;
		switch (compressionAlgorithm)
		{
		case CompressionAlgorithm.GZip:
		{
			object obj8 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1992;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			GZipStream gZipStream2 = default(GZipStream);
			gZipStream2..ctor(memoryStream2, CompressionLevel.Optimal);
			object obj7 = 0;
			compressionLevel = CompressionLevel.Optimal;
			stream = memoryStream2;
			gZipStream = gZipStream2;
			break;
		}
		case CompressionAlgorithm.Brotli:
		{
			object obj6 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 3408;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			BrotliStream brotliStream = default(BrotliStream);
			brotliStream..ctor(memoryStream2, CompressionLevel.Optimal);
			object obj7 = 0;
			compressionLevel = CompressionLevel.Optimal;
			stream = memoryStream2;
			gZipStream = (GZipStream)(object)brotliStream;
			break;
		}
		default:
			compressionLevel = CompressionLevel.Optimal;
			stream = null;
			gZipStream = null;
			break;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-38]");
		bool flag = (nint)0 == 0;
		object obj9 = 0;
		object obj10 = 0;
		object obj11 = 0;
		object obj13 = default(object);
		object obj12 = (object)(&obj13);
		if (flag)
		{
			goto IL_05e2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-38]");
		((Stream)0).CopyTo(gZipStream);
		object obj15 = default(object);
		CompressionLevel compressionLevel2;
		object obj16;
		object obj17;
		byte[] array;
		object obj18;
		object obj19 = default(object);
		object obj20;
		object obj21 = default(object);
		object obj22;
		byte[] array3;
		object obj14;
		OutOfMemoryException ex2;
		if (obj13 != null)
		{
			obj12 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X8_v12+278]");
			obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X8_v12+280]");
			stream = (Stream)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v265 @ X8_v12+278] (should have been resolved before IL gen)");
			if (obj15 != null)
			{
				obj12 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X8_v12+3E8]");
				obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X8_v12+3F0]");
				stream = (Stream)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v265 @ X8_v12+3E8] (should have been resolved before IL gen)");
				bool flag2 = obj13 == null;
				obj9 = 0;
				obj10 = 0;
				obj11 = 0;
				compressionLevel2 = CompressionLevel.Optimal;
				obj16 = obj13;
				obj17 = 0;
				byte[] array2 = default(byte[]);
				array = array2;
				obj18 = obj19;
				obj9 = 0;
				obj20 = obj21;
				obj10 = 0;
				obj11 = 0;
				compressionLevel = CompressionLevel.Optimal;
				obj22 = 0;
				array3 = array2;
				if (!flag2)
				{
					goto IL_0271;
				}
				goto IL_08f0;
			}
			NullReferenceException ex = new NullReferenceException();
			obj9 = 0;
			obj10 = 0;
			obj11 = 0;
			compressionLevel = CompressionLevel.Optimal;
			ex2 = (OutOfMemoryException)(object)ex;
		}
		else
		{
			NullReferenceException ex3 = new NullReferenceException();
			obj9 = 0;
			obj10 = 0;
			obj11 = 0;
			compressionLevel = CompressionLevel.Optimal;
			stream = gZipStream;
			ex2 = (OutOfMemoryException)(object)ex3;
			obj12 = (object)(&obj13);
		}
		goto IL_06b6;
		IL_0a92:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v694 @ X0_v41+8]");
		stream = (Stream)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v694 @ X0_v41] (should have been resolved before IL gen)");
		goto IL_0a36;
		IL_09ef:
		object obj23 = default(object);
		obj12 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v593 @ X0_v48+8]");
		stream = (Stream)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v593 @ X0_v48] (should have been resolved before IL gen)");
		obj19 = obj18;
		obj21 = obj20;
		object obj24 = obj22;
		byte[] result = array3;
		goto IL_0993;
		IL_0993:
		bool flag3 = obj24 == null;
		object obj25 = !flag3;
		CompressionLevel compressionLevel3;
		if (obj25 != null)
		{
			ex2 = new OutOfMemoryException();
			compressionLevel = compressionLevel3;
			goto IL_06b6;
		}
		goto IL_04b6;
		IL_0315:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		compressionLevel = CompressionLevel.Optimal;
		goto IL_094c;
		IL_094c:
		object obj26 = default(object);
		obj12 = obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ X0_v55+8]");
		stream = (Stream)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v474 @ X0_v55] (should have been resolved before IL gen)");
		obj18 = obj19;
		obj20 = obj21;
		obj22 = obj17;
		array3 = array;
		goto IL_08f0;
		IL_057f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		compressionLevel3 = CompressionLevel.Optimal;
		goto IL_0a92;
		IL_08f0:
		bool flag4 = obj22 == null;
		object obj27 = !flag4;
		object obj29;
		if (obj27 == null)
		{
			object obj28 = (object)(&obj15);
			obj29 = obj28;
			bool flag5 = obj28 == null;
			obj19 = obj18;
			obj21 = obj20;
			compressionLevel3 = compressionLevel;
			obj12 = (object)(&obj15);
			obj24 = obj22;
			result = array3;
			if (!flag5)
			{
				goto IL_03c2;
			}
			goto IL_0993;
		}
		ex2 = new OutOfMemoryException();
		obj19 = obj18;
		obj21 = obj20;
		goto IL_06b6;
		IL_03c2:
		object obj30 = obj29;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ X8_v24+12E]");
		obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ X8_v24+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0466;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ X8_v24+B0]");
		object obj31 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X10_v18-8]");
			obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X10_v18-8]");
			if (0 == (nint)obj4)
			{
				break;
			}
			obj20 = obj31 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ X8_v24+12E]");
			obj14 = -1;
			bool flag6 = (nint)obj14 != 1;
			obj31 = obj20;
			if (flag6)
			{
				continue;
			}
			goto IL_0466;
		}
		obj14 = obj31;
		object obj32 = obj30 + obj31;
		obj23 = obj32 + 312;
		obj20 = obj31;
		compressionLevel3 = compressionLevel;
		goto IL_09ef;
		IL_06b6:
		if ((nint)stream == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			object obj33 = default(object);
			obj17 = obj33;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			bool flag7 = obj13 == null;
			object obj34 = !flag7;
			obj9 = obj33;
			compressionLevel2 = compressionLevel;
			obj16 = obj13;
			array = null;
			if (obj34 != null)
			{
				goto IL_0271;
			}
			obj18 = obj19;
			obj9 = obj33;
			obj20 = obj21;
			obj22 = obj33;
			array3 = null;
			goto IL_08f0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
		if ((nint)stream == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			object obj35 = default(object);
			obj22 = obj35;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj36 = (object)(&obj15);
			obj29 = obj36;
			bool flag8 = obj36 == null;
			object obj37 = !flag8;
			obj18 = obj19;
			obj20 = obj21;
			obj10 = obj35;
			array3 = null;
			if (obj37 != null)
			{
				goto IL_03c2;
			}
			obj10 = obj35;
			compressionLevel3 = compressionLevel;
			obj12 = (object)(&obj15);
			obj24 = obj35;
			result = null;
			goto IL_0993;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
		if ((nint)stream == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj38 = default(object);
			obj11 = obj38;
			compressionLevel3 = compressionLevel;
			result = null;
			goto IL_04b6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		byte[] result2 = default(byte[]);
		return result2;
		IL_0271:
		object obj39 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v29+12E]");
		obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v29+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0315;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v29+B0]");
		object obj40 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X10_v25-8]");
			obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X10_v25-8]");
			if (0 == (nint)obj4)
			{
				break;
			}
			obj21 = obj40 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v29+12E]");
			obj14 = -1;
			bool flag9 = (nint)obj14 != 1;
			obj40 = obj21;
			if (flag9)
			{
				continue;
			}
			goto IL_0315;
		}
		obj14 = obj40;
		object obj41 = obj39 + obj40;
		obj26 = obj41 + 312;
		obj21 = obj40;
		compressionLevel = compressionLevel2;
		goto IL_094c;
		IL_04b6:
		object obj42 = obj5;
		if (obj5 == null)
		{
			goto IL_0a36;
		}
		object obj43 = obj42;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X8_v19+12E]");
		obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X8_v19+12E]");
		if ((nint)0 == 0)
		{
			goto IL_057f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X8_v19+B0]");
		object obj44 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v636 @ X10_v11-8]");
			obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v636 @ X10_v11-8]");
			if (0 == (nint)obj4)
			{
				break;
			}
			obj21 = obj44 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X8_v19+12E]");
			obj14 = -1;
			bool flag10 = (nint)obj14 != 1;
			obj44 = obj21;
			if (flag10)
			{
				continue;
			}
			goto IL_057f;
		}
		obj14 = obj44;
		object obj45 = obj43 + obj44;
		object obj46 = obj45 + 312;
		obj21 = obj44;
		goto IL_0a92;
		IL_0a36:
		bool flag11 = obj11 == null;
		object obj47 = !flag11;
		if (obj47 == null)
		{
			return result;
		}
		OutOfMemoryException ex4 = new OutOfMemoryException();
		compressionLevel = compressionLevel3;
		goto IL_05e2;
		IL_05e2:
		NullReferenceException ex5 = new NullReferenceException();
		ex2 = (OutOfMemoryException)(object)ex5;
		goto IL_06b6;
		IL_0466:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		compressionLevel3 = CompressionLevel.Optimal;
		goto IL_09ef;
	}

	private static Stream GetCompressStream(Stream outputStream, CompressionAlgorithm compressionAlgorithm = CompressionAlgorithm.Brotli)
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		switch (compressionAlgorithm)
		{
		case CompressionAlgorithm.GZip:
		{
			object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1992;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			GZipStream gZipStream = default(GZipStream);
			gZipStream..ctor(outputStream, CompressionLevel.Optimal);
			return gZipStream;
		}
		case CompressionAlgorithm.Brotli:
		{
			object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 3408;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			BrotliStream brotliStream = default(BrotliStream);
			brotliStream..ctor(outputStream, CompressionLevel.Optimal);
			return brotliStream;
		}
		default:
			return null;
		}
	}

	public static string Decompress(string data, CompressionAlgorithm compressionAlgorithm = CompressionAlgorithm.Brotli)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00db: Expected O, but got I4
		//IL_0079: Expected I, but got O
		//IL_0089: Expected O, but got I
		//IL_0099: Expected O, but got I
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3016;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		byte[] data2 = Convert.FromBase64String(data);
		byte[] array = Decompress(data2, compressionAlgorithm);
		Encoding uTF = Encoding.UTF8;
		if (uTF != null)
		{
			nint num = (nint)uTF;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4 (Il2CppClass<System.Text.Encoding>)+378]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4 (Il2CppClass<System.Text.Encoding>)+380]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v61 @ X3_v1 (should have been resolved before IL gen)");
		}
		return (string)(object)new NullReferenceException();
	}

	public static string DecompressToString(byte[] data, CompressionAlgorithm compressionAlgorithm = CompressionAlgorithm.Brotli)
	{
		//IL_0044: Expected I, but got O
		//IL_0054: Expected O, but got I
		//IL_0064: Expected O, but got I
		byte[] array = Decompress(data, compressionAlgorithm);
		Encoding uTF = Encoding.UTF8;
		if (uTF != null)
		{
			nint num = (nint)uTF;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X8_v1 (Il2CppClass<System.Text.Encoding>)+378]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X8_v1 (Il2CppClass<System.Text.Encoding>)+380]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v19 @ X3_v1 (should have been resolved before IL gen)");
		}
		return (string)(object)new NullReferenceException();
	}

	public static byte[] DecompressToBytes(string data, CompressionAlgorithm compressionAlgorithm = CompressionAlgorithm.Brotli)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_007a: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3016;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		byte[] data2 = Convert.FromBase64String(data);
		return Decompress(data2, compressionAlgorithm);
	}

	public unsafe static byte[] Decompress(byte[] data, CompressionAlgorithm compressionAlgorithm = CompressionAlgorithm.Brotli)
	{
		//IL_0008: Expected O, but got Ref
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_08cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d2: Expected O, but got Unknown
		//IL_08fc: Expected O, but got Ref
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_00f3: Expected O, but got I
		//IL_00fc: Expected O, but got I4
		//IL_0115: Expected O, but got I
		//IL_0139: Expected O, but got Ref
		//IL_0142: Expected O, but got I4
		//IL_093a: Expected O, but got I4
		//IL_0943: Expected O, but got I4
		//IL_06bf: Expected O, but got Ref
		//IL_06c8: Expected O, but got I4
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0087: Expected O, but got I
		//IL_0658: Expected O, but got Ref
		//IL_0661: Expected O, but got I4
		//IL_066a: Expected O, but got I4
		//IL_0673: Expected O, but got I4
		//IL_0095: Expected O, but got I4
		//IL_00ae: Expected O, but got I
		//IL_018a: Expected I, but got O
		//IL_019a: Expected O, but got I
		//IL_01aa: Expected O, but got I
		//IL_01bc: Expected O, but got Ref
		//IL_01db: Expected O, but got Ref
		//IL_01e4: Expected O, but got I4
		//IL_01f5: Expected O, but got I4
		//IL_01fe: Expected O, but got I4
		//IL_0210: Expected O, but got I4
		//IL_0230: Expected O, but got Ref
		//IL_0239: Expected O, but got I4
		//IL_024a: Expected O, but got I4
		//IL_0253: Expected O, but got I4
		//IL_0265: Expected O, but got I4
		//IL_0962: Expected O, but got I4
		//IL_0749: Expected O, but got I4
		//IL_0293: Expected O, but got I
		//IL_0377: Expected O, but got Ref
		//IL_07cf: Expected O, but got Ref
		//IL_07f1: Expected O, but got I4
		//IL_0a0d: Expected O, but got I4
		//IL_09b4: Expected O, but got I
		//IL_02ce: Expected O, but got I
		//IL_03ec: Expected O, but got I
		//IL_0980: Expected O, but got I
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected O, but got Unknown
		//IL_0af0: Expected O, but got I4
		//IL_0a97: Expected O, but got I
		//IL_0427: Expected O, but got I
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected O, but got Unknown
		//IL_02f7: Expected O, but got I
		//IL_0505: Expected O, but got I
		//IL_0a63: Expected O, but got I
		//IL_04ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b3: Expected O, but got Unknown
		//IL_0b42: Expected O, but got I
		//IL_0540: Expected O, but got I
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		//IL_043a: Expected O, but got Unknown
		//IL_0450: Expected O, but got I
		//IL_0b0e: Expected O, but got I
		//IL_05c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cc: Expected O, but got Unknown
		//IL_054e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0553: Expected O, but got Unknown
		//IL_0569: Expected O, but got I
		object obj2 = default(object);
		object obj = (object)(&obj2);
		object obj3 = typeof(MemberAchievementClanFeedData) + 192;
		object obj4 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		MemoryStream memoryStream = default(MemoryStream);
		memoryStream..ctor(data);
		object obj5 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 56));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		MemoryStream memoryStream2 = default(MemoryStream);
		memoryStream2..ctor();
		BrotliStream brotliStream = default(BrotliStream);
		Stream stream;
		BrotliStream brotliStream2;
		object obj7;
		object obj6;
		object obj9 = default(object);
		CompressionMode compressionMode;
		if (compressionAlgorithm != CompressionAlgorithm.Brotli)
		{
			if (compressionAlgorithm != CompressionAlgorithm.GZip)
			{
				obj6 = (object)(&brotliStream);
				obj7 = 0;
				brotliStream = null;
				compressionMode = CompressionMode.Decompress;
				stream = null;
				goto IL_0928;
			}
			object obj8 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1992;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-38]");
			GZipStream gZipStream = default(GZipStream);
			gZipStream..ctor((Stream)0, CompressionMode.Decompress);
			obj9 = 0;
			compressionMode = CompressionMode.Decompress;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-38]");
			stream = (Stream)0;
			brotliStream2 = (BrotliStream)(object)gZipStream;
		}
		else
		{
			object obj10 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 3408;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-38]");
			BrotliStream brotliStream3 = default(BrotliStream);
			brotliStream3..ctor((Stream)0, CompressionMode.Decompress);
			obj9 = 0;
			compressionMode = CompressionMode.Decompress;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-38]");
			stream = (Stream)0;
			brotliStream2 = brotliStream3;
		}
		bool flag = brotliStream2 == null;
		obj6 = (object)(&brotliStream);
		obj7 = 0;
		brotliStream = brotliStream2;
		if (flag)
		{
			goto IL_0928;
		}
		Stream stream2 = default(Stream);
		brotliStream2.CopyTo(stream2);
		object obj11 = default(object);
		object obj13;
		object obj14;
		CompressionMode compressionMode2;
		object obj17;
		byte[] array;
		object obj18;
		object obj20;
		object obj22;
		object obj16;
		object obj23;
		byte[] array3;
		object obj15;
		object obj19 = default(object);
		object obj21 = default(object);
		if (stream2 != null)
		{
			nint num = (nint)stream2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X8_v35 (Il2CppClass<System.IO.Stream>)+3E8]");
			obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X8_v35 (Il2CppClass<System.IO.Stream>)+3F0]");
			stream = (Stream)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v271 @ X8_v35 (Il2CppClass<System.IO.Stream>)+3E8] (should have been resolved before IL gen)");
			object obj12 = (object)(&brotliStream);
			obj13 = obj12;
			bool flag2 = obj12 == null;
			obj14 = (object)(&brotliStream);
			obj7 = 0;
			brotliStream = brotliStream2;
			obj15 = 0;
			obj16 = 0;
			compressionMode2 = CompressionMode.Decompress;
			obj17 = 0;
			byte[] array2 = default(byte[]);
			array = array2;
			obj18 = obj19;
			obj20 = obj21;
			obj6 = (object)(&brotliStream);
			obj7 = 0;
			obj22 = obj9;
			obj15 = 0;
			obj16 = 0;
			compressionMode = CompressionMode.Decompress;
			obj23 = 0;
			array3 = array2;
			if (!flag2)
			{
				goto IL_027b;
			}
			goto IL_0948;
		}
		NullReferenceException ex = new NullReferenceException();
		obj6 = (object)(&brotliStream);
		obj7 = 0;
		obj15 = 0;
		obj16 = 0;
		compressionMode = CompressionMode.Decompress;
		stream = stream2;
		goto IL_06e6;
		IL_0948:
		bool flag3 = obj23 == null;
		object obj24 = !flag3;
		object obj26;
		object obj27;
		object obj28;
		object obj29;
		object obj30;
		CompressionMode compressionMode3;
		object obj31;
		byte[] result;
		if (obj24 == null)
		{
			object obj25 = (object)(&stream2);
			obj26 = obj25;
			bool flag4 = obj25 == null;
			obj27 = obj18;
			obj28 = obj20;
			obj29 = obj6;
			obj30 = obj22;
			compressionMode3 = compressionMode;
			obj31 = obj23;
			result = array3;
			if (!flag4)
			{
				goto IL_03d4;
			}
			goto IL_09f3;
		}
		OutOfMemoryException ex2 = new OutOfMemoryException();
		obj19 = obj18;
		obj21 = obj20;
		obj9 = obj22;
		ex = (NullReferenceException)(object)ex2;
		goto IL_06e6;
		IL_09a4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ X0_v54+8]");
		stream = (Stream)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v490 @ X0_v54] (should have been resolved before IL gen)");
		obj18 = obj19;
		obj20 = obj21;
		obj6 = obj14;
		obj22 = obj9;
		obj23 = obj17;
		array3 = array;
		goto IL_0948;
		IL_0a87:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ X0_v47+8]");
		stream = (Stream)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v637 @ X0_v47] (should have been resolved before IL gen)");
		obj27 = obj18;
		obj28 = obj20;
		obj29 = obj6;
		obj30 = obj22;
		obj31 = obj23;
		result = array3;
		goto IL_09f3;
		IL_0591:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		compressionMode3 = CompressionMode.Decompress;
		goto IL_0b32;
		IL_031f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		compressionMode = CompressionMode.Decompress;
		goto IL_09a4;
		IL_0928:
		ex = new NullReferenceException();
		obj15 = 0;
		obj16 = 0;
		goto IL_06e6;
		IL_03d4:
		object obj32 = obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X8_v24+12E]");
		obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X8_v24+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0478;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X8_v24+B0]");
		object obj33 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ X10_v18-8]");
			obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ X10_v18-8]");
			if (0 == (nint)obj4)
			{
				break;
			}
			obj20 = obj33 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X8_v24+12E]");
			obj11 = -1;
			bool flag5 = (nint)obj11 != 1;
			obj33 = obj20;
			if (flag5)
			{
				continue;
			}
			goto IL_0478;
		}
		obj11 = obj33;
		object obj34 = obj32 + obj33;
		object obj35 = obj34 + 312;
		obj20 = obj33;
		compressionMode3 = compressionMode;
		goto IL_0a87;
		IL_0478:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		compressionMode3 = CompressionMode.Decompress;
		goto IL_0a87;
		IL_04c8:
		object obj36 = obj5;
		if (obj5 == null)
		{
			goto IL_0ad6;
		}
		object obj37 = obj36;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ X8_v19+12E]");
		obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ X8_v19+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0591;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ X8_v19+B0]");
		object obj38 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v681 @ X10_v11-8]");
			obj27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v681 @ X10_v11-8]");
			if (0 == (nint)obj4)
			{
				break;
			}
			obj28 = obj38 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ X8_v19+12E]");
			obj11 = -1;
			bool flag6 = (nint)obj11 != 1;
			obj38 = obj28;
			if (flag6)
			{
				continue;
			}
			goto IL_0591;
		}
		obj11 = obj38;
		object obj39 = obj37 + obj38;
		object obj40 = obj39 + 312;
		obj28 = obj38;
		goto IL_0b32;
		IL_027b:
		object obj41 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X8_v29+12E]");
		obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X8_v29+12E]");
		if ((nint)0 == 0)
		{
			goto IL_031f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X8_v29+B0]");
		object obj42 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X10_v25-8]");
			obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X10_v25-8]");
			if (0 == (nint)obj4)
			{
				break;
			}
			obj21 = obj42 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X8_v29+12E]");
			obj11 = -1;
			bool flag7 = (nint)obj11 != 1;
			obj42 = obj21;
			if (flag7)
			{
				continue;
			}
			goto IL_031f;
		}
		obj11 = obj42;
		object obj43 = obj41 + obj42;
		object obj44 = obj43 + 312;
		obj21 = obj42;
		compressionMode = compressionMode2;
		goto IL_09a4;
		IL_09f3:
		bool flag8 = obj31 == null;
		object obj45 = !flag8;
		obj19 = obj27;
		obj21 = obj28;
		object obj46 = obj11;
		obj6 = obj29;
		obj9 = obj30;
		compressionMode = compressionMode3;
		Stream stream3 = stream;
		if (obj45 != null)
		{
			OutOfMemoryException ex3 = new OutOfMemoryException();
			obj11 = obj46;
			stream = stream3;
			ex = (NullReferenceException)(object)ex3;
			goto IL_06e6;
		}
		goto IL_04c8;
		IL_0b32:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v737 @ X0_v40+8]");
		stream = (Stream)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v737 @ X0_v40] (should have been resolved before IL gen)");
		goto IL_0ad6;
		IL_06e6:
		if ((nint)stream == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			object obj47 = default(object);
			obj17 = obj47;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			obj13 = obj6;
			bool flag9 = obj6 == null;
			object obj48 = !flag9;
			obj14 = obj6;
			obj7 = obj47;
			compressionMode2 = compressionMode;
			array = null;
			if (obj48 != null)
			{
				goto IL_027b;
			}
			obj18 = obj19;
			obj20 = obj21;
			obj7 = obj47;
			obj22 = obj9;
			obj23 = obj47;
			array3 = null;
			goto IL_0948;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
		if ((nint)stream == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			object obj49 = default(object);
			obj23 = obj49;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj50 = (object)(&stream2);
			obj26 = obj50;
			bool flag10 = obj50 == null;
			object obj51 = !flag10;
			obj18 = obj19;
			obj20 = obj21;
			obj22 = obj9;
			obj15 = obj49;
			array3 = null;
			if (obj51 != null)
			{
				goto IL_03d4;
			}
			obj27 = obj19;
			obj28 = obj21;
			obj29 = obj6;
			obj30 = obj9;
			obj15 = obj49;
			compressionMode3 = compressionMode;
			obj31 = obj49;
			result = null;
			goto IL_09f3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
		if ((nint)stream == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			obj27 = obj19;
			obj28 = obj21;
			obj29 = obj6;
			obj30 = obj9;
			object obj52 = default(object);
			obj16 = obj52;
			compressionMode3 = compressionMode;
			result = null;
			goto IL_04c8;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		byte[] result2 = default(byte[]);
		return result2;
		IL_0ad6:
		bool flag11 = obj16 == null;
		object obj53 = !flag11;
		if (obj53 == null)
		{
			return result;
		}
		obj19 = obj27;
		obj21 = obj28;
		obj46 = obj11;
		obj6 = obj29;
		obj9 = obj30;
		compressionMode = compressionMode3;
		stream3 = stream;
		throw new OutOfMemoryException();
	}

	private static Stream GetDecompressStream(Stream sourceStream, CompressionAlgorithm compressionAlgorithm = CompressionAlgorithm.Brotli)
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		switch (compressionAlgorithm)
		{
		case CompressionAlgorithm.GZip:
		{
			object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1992;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			GZipStream gZipStream = default(GZipStream);
			gZipStream..ctor(sourceStream, CompressionMode.Decompress);
			return gZipStream;
		}
		case CompressionAlgorithm.Brotli:
		{
			object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 3408;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			BrotliStream brotliStream = default(BrotliStream);
			brotliStream..ctor(sourceStream, CompressionMode.Decompress);
			return brotliStream;
		}
		default:
			return null;
		}
	}
}
