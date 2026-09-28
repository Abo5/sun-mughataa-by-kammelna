using System;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using GoogleMobileAds.Api.AdManager;
using Unity.Properties;
using Unity.Services.Authentication.Shared;
using UnityEngine;

namespace Libraries.Utils;

public static class BuildBlobSigner
{
	[Serializable]
	private class Payload
	{
		public string Version;

		public string Platform;
	}

	private const int FIELD_SIZE = 32;

	public static string BuildPayload(string version, string platform)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3424;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = obj2 + 16;
			obj3 = version;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj4 = obj2 + 24;
			obj4 = platform;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return JsonUtility.ToJson(obj2);
		}
		return (string)(object)new NullReferenceException();
	}

	public static string AssembleBlob(byte[] payload, byte[] fixedFieldSignature)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_009a: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3016;
		object obj2 = ", stale={0}" + 1352;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text = Convert.ToBase64String(payload);
		string text2 = Convert.ToBase64String(fixedFieldSignature);
		return text + (string)obj2 + text2;
	}

	public static byte[] DerToFixedField(byte[] der)
	{
		//IL_0020: Expected O, but got I4
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0055: Expected O, but got I8
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Expected O, but got Unknown
		//IL_0090: Expected O, but got I
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_00d2: Expected O, but got I4
		//IL_00ed: Expected O, but got I4
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Expected O, but got Unknown
		//IL_037b: Expected O, but got I4
		//IL_03b5: Expected O, but got I4
		//IL_0116: Expected O, but got I4
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected O, but got Unknown
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected O, but got Unknown
		//IL_0174: Expected O, but got I4
		//IL_0437: Expected O, but got I4
		//IL_0139: Expected O, but got I4
		//IL_04a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a9: Expected O, but got Unknown
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c5: Expected O, but got Unknown
		//IL_04df: Expected O, but got I4
		//IL_018b: Expected O, but got I4
		//IL_03eb: Expected O, but got I4
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected I4, but got Unknown
		//IL_0465: Unknown result type (might be due to invalid IL or missing references)
		//IL_046a: Expected O, but got Unknown
		//IL_0474: Unknown result type (might be due to invalid IL or missing references)
		//IL_0479: Expected O, but got Unknown
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected O, but got Unknown
		int offset = default(int);
		Expect(der, ref offset, 48);
		int num = offset + 1;
		if (der == null)
		{
			goto IL_02c4;
		}
		bool flag = offset < der.Length;
		object obj = !flag;
		if (obj != null)
		{
			goto IL_02b6;
		}
		object obj2 = der + offset;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X10_v4+20]");
		object obj3 = 0 & 0x80000000L;
		bool flag2 = obj3 == null;
		offset = num;
		int num2;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X10_v4+20]");
			object obj4 = (nint)0 & (nint)0xFF;
			object obj5 = obj4 & 0x7F;
			bool flag3 = obj5 == null;
			offset = num;
			if (!flag3)
			{
				object obj6 = der.Length - num;
				bool flag4 = der.Length < num;
				object obj7 = !flag4;
				object obj8 = ~obj7;
				object obj9 = ~obj8;
				if (obj9 == null)
				{
					obj6 = 0;
				}
				object obj10 = obj5 - 1;
				bool flag5 = obj6 < obj10;
				object obj11 = !flag5;
				object obj12 = ~obj11;
				object obj13 = ~obj12;
				if (obj13 == null)
				{
					obj10 = obj6;
				}
				bool flag6 = (nint)obj10 < 8;
				object obj14 = !flag6;
				object obj15;
				if (obj14 == null)
				{
					num2 = num;
					obj15 = 0;
				}
				else
				{
					object obj16 = obj10 + 1;
					object obj17 = obj16 & 7;
					bool flag7 = obj17 == null;
					object obj18 = !flag7;
					if (obj18 == null)
					{
						obj17 = 8;
					}
					obj15 = obj16 - obj17;
					object obj19 = ~obj10;
					object obj20 = obj19 + obj17;
					object obj21 = 0;
					int num3 = 0;
					object obj22 = default(object);
					obj21 = obj22;
					int num4 = default(int);
					num3 = num4;
					object obj23 = default(object);
					obj20 = obj23;
					object obj24;
					do
					{
						obj21++;
						num3++;
						obj20 += 8;
						bool flag8 = obj20 == null;
						obj24 = !flag8;
					}
					while (obj24 != null);
					num4 = num3 + obj21;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
					num2 = num4;
				}
				object obj25 = obj5 - obj15;
				bool flag9 = num < der.Length;
				object obj26 = !flag9;
				object obj27 = ~obj26;
				object obj28 = ~obj27;
				if (obj28 != null)
				{
					num = der.Length;
				}
				object obj29 = obj15 + num;
				object obj30 = obj29 - der.Length;
				while (obj30 != null)
				{
					num2++;
					obj30++;
					obj25--;
					if ((nint)obj25 != 1)
					{
						continue;
					}
					goto IL_0212;
				}
				goto IL_02b6;
			}
		}
		goto IL_030f;
		IL_02c4:
		return (byte[])(object)new NullReferenceException();
		IL_02b6:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_02c4;
		IL_030f:
		object obj31 = typeof(TypeConverter<ushort, char>) + 1880;
		byte[] array = ReadInteger(der, ref offset);
		byte[] array2 = ReadInteger(der, ref offset);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		if (array != null)
		{
			int destinationIndex = 32 - array.Length;
			Array array3 = default(Array);
			Array.Copy(array, 0, array3, destinationIndex, array.Length);
			if (array2 != null)
			{
				int destinationIndex2 = 64 - array2.Length;
				Array.Copy(array2, 0, array3, destinationIndex2, array2.Length);
				return (byte[])array3;
			}
		}
		goto IL_02c4;
		IL_0212:
		offset = num2;
		goto IL_030f;
	}

	private unsafe static byte[] ReadInteger(byte[] der, ref int offset)
	{
		//IL_0420: Expected O, but got I4
		//IL_002f: Expected O, but got I4
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_007b: Expected O, but got I8
		//IL_0095: Expected O, but got I4
		//IL_04c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c8: Expected O, but got Unknown
		//IL_00fb: Expected O, but got I4
		//IL_0116: Expected O, but got I4
		//IL_013f: Expected O, but got I4
		//IL_01fa: Expected O, but got I4
		//IL_0207: Expected O, but got I4
		//IL_0221: Expected O, but got I4
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected O, but got Unknown
		//IL_0274: Expected O, but got I4
		//IL_0325: Expected O, but got I4
		//IL_035c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0361: Expected O, but got Unknown
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		//IL_0389: Expected O, but got Unknown
		//IL_03b1: Expected O, but got I
		Expect(der, ref offset, 2);
		object obj = offset;
		int num = offset + 1;
		ref int reference = ref *(int*)num;
		int num2;
		int num3;
		int num4;
		byte[] sourceArray;
		byte b;
		if (der != null)
		{
			num2 = der.Length;
			bool flag = offset < der.Length;
			object obj2 = !flag;
			if (obj2 == null)
			{
				object obj3 = der + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v5+v46 @ X10_v1]");
				num3 = (int)((nint)0 & (nint)0xFF);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v5+v46 @ X10_v1]");
				object obj4 = 0 & 0x80000000L;
				bool flag2 = obj4 == null;
				object obj5 = !flag2;
				if (obj5 == null)
				{
					num4 = num;
					goto IL_01af;
				}
				int num5 = num3 & 0x7F;
				bool flag3 = num5 == 0;
				b = 2;
				sourceArray = der;
				if (flag3)
				{
					num3 = 0;
					goto IL_04b4;
				}
				object obj6 = der.Length - num;
				bool flag4 = der.Length < num;
				object obj7 = !flag4;
				object obj8 = ~obj7;
				object obj9 = ~obj8;
				object obj10;
				int num6;
				if (obj9 == null)
				{
					obj10 = 0;
					num6 = 0;
				}
				else
				{
					obj10 = obj6;
					num6 = 0;
				}
				while (true)
				{
					num4 = num + 1;
					reference = ref *(int*)num4;
					if (obj10 == null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v5+v147 @ X21_v13 (System.Int32)]");
					num3 = (int)((nint)0 | (nint)num6);
					obj10--;
					bool flag5 = num5 != 1;
					num = num4;
					if (flag5)
					{
						continue;
					}
					goto IL_01af;
				}
			}
			goto IL_03e5;
		}
		goto IL_03f3;
		IL_04b4:
		object obj11 = typeof(TypeConverter<ushort, char>) + 1880;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		Array array = default(Array);
		Array.Copy(sourceArray, num, array, 0, num3);
		return (byte[])array;
		IL_030b:
		bool flag6 = num3 < 33;
		object obj12 = !flag6;
		object obj13 = ~obj12;
		b = 2;
		sourceArray = der;
		if (obj13 == null)
		{
			object obj14 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 640;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj15 = "https://www.kammelna.com/Home/Terms" + 1728;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			byte[] array2 = default(byte[]);
			string message = default(string);
			((ArgumentException)(object)array2)..ctor(message);
			object obj16 = (nint)0 + (nint)1296;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			b = 0;
			sourceArray = array2;
			throw new OutOfMemoryException();
		}
		goto IL_04b4;
		IL_02c6:
		b = 2;
		int num7;
		num = num7;
		num3 = 0;
		sourceArray = der;
		goto IL_04b4;
		IL_03e5:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_03f3;
		IL_01af:
		num7 = num4 + num3;
		reference = ref *(int*)num7;
		if (num3 >= 1)
		{
			bool flag7 = num4 < num2;
			object obj17 = !flag7;
			object obj18 = num4 - num2;
			bool flag8 = obj18 == null;
			object obj19 = !flag8;
			object obj20 = obj17 & obj19;
			object obj21 = ~obj20;
			if (obj21 == null)
			{
				num2 = num4;
			}
			num = num4;
			while (num2 != num)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v5+v147 @ X21_v13 (System.Int32)]");
				bool flag9 = (nint)0 == 0;
				object obj22 = !flag9;
				if (obj22 == null)
				{
					num++;
					int num8 = num3 - 1;
					bool flag10 = num3 >= 2;
					num3 = num8;
					if (flag10)
					{
						continue;
					}
					goto IL_02c6;
				}
				goto IL_030b;
			}
			goto IL_03e5;
		}
		b = 2;
		num = num4;
		sourceArray = der;
		goto IL_04b4;
		IL_03f3:
		return (byte[])(object)new NullReferenceException();
	}

	private unsafe static int ReadLength(byte[] der, ref int offset)
	{
		//IL_000d: Expected O, but got I4
		//IL_0020: Expected O, but got I4
		//IL_01e6: Expected I4, but got O
		//IL_0065: Expected O, but got I4
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_00b1: Expected O, but got I8
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0121: Expected O, but got I4
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected O, but got Unknown
		//IL_0153: Expected O, but got I4
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected O, but got Unknown
		object obj = offset;
		object obj2 = offset + 1;
		ref int reference = ref *(int*)obj2;
		int num;
		if (der != null)
		{
			bool flag = offset < der.Length;
			object obj3 = !flag;
			if (obj3 == null)
			{
				object obj4 = der + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X9_v3+v6 @ X10_v1]");
				num = (int)((nint)0 & (nint)0xFF);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X9_v3+v6 @ X10_v1]");
				object obj5 = 0 & 0x80000000L;
				if (obj5 == null)
				{
					goto IL_01bf;
				}
				int num2 = num & 0x7F;
				if (num2 == 0)
				{
					return 0;
				}
				object obj6 = der.Length - obj2;
				bool flag2 = obj6 < obj2;
				object obj7 = !flag2;
				object obj8 = ~obj7;
				object obj9 = ~obj8;
				int num3;
				if (obj9 == null)
				{
					num3 = 0;
					obj6 = 0;
				}
				else
				{
					num3 = 0;
				}
				while (true)
				{
					object obj10 = obj2 + 1;
					reference = ref *(int*)obj10;
					if (obj6 == null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X9_v3+v103 @ X8_v5]");
					num = (int)((nint)0 | (nint)num3);
					obj6--;
					num2--;
					bool flag3 = num2 != 1;
					obj2 = obj10;
					if (flag3)
					{
						continue;
					}
					goto IL_01bf;
				}
			}
			IndexOutOfRangeException ex = new IndexOutOfRangeException();
		}
		NullReferenceException ex2 = new NullReferenceException();
		return (int)ex2;
		IL_01bf:
		return num;
	}

	private unsafe static void Expect(byte[] der, ref int offset, byte tag)
	{
		//IL_0013: Expected O, but got I4
		//IL_0058: Expected O, but got I4
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected O, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		//IL_0140: Expected O, but got I
		object obj = offset + 1;
		ref int reference = ref *(int*)obj;
		if (der != null)
		{
			bool flag = offset < der.Length;
			object obj2 = !flag;
			if (obj2 == null)
			{
				object obj3 = der + offset;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X9_v6+20]");
				if ((nint)0 == (int)tag)
				{
					return;
				}
				int num = default(int);
				string text = num.ToString();
				object obj4 = "tournament_participate_warning_body_with_tickets_warning_daily" + 1600;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
				string text2 = default(string);
				string message = text2 + text;
				object obj5 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 640;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				ArgumentException ex = default(ArgumentException);
				ex..ctor(message);
				object obj6 = (nint)0 + (nint)1288;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
				throw new OutOfMemoryException();
			}
		}
		else
		{
			NullReferenceException ex2 = new NullReferenceException();
		}
		throw new IndexOutOfRangeException();
	}
}
