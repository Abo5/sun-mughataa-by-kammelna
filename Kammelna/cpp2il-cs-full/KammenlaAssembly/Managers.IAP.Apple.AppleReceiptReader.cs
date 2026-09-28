using System;
using System.Collections.Generic;
using System.Data;
using System.Formats.Asn1;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using Unity.Services.Authentication.Shared;
using UnityEngine.Rendering;

namespace Managers.IAP.Apple;

public class AppleReceiptReader
{
	private readonly Dictionary<int, List<byte[]>> _attributes;

	public AppleReceiptReader(AsnReader reader)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected O, but got Unknown
		//IL_0033: Expected O, but got I4
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_0082: Expected O, but got I
		//IL_00d5: Expected O, but got I4
		//IL_00ec: Expected O, but got I4
		//IL_011a: Expected O, but got I4
		//IL_03a2: Expected O, but got I4
		//IL_03b4: Expected O, but got I4
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Expected O, but got Unknown
		//IL_016f: Expected O, but got I
		//IL_02c2: Expected O, but got I4
		//IL_019c: Expected O, but got I
		//IL_01b1: Expected O, but got I
		//IL_01df: Expected O, but got I4
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Expected O, but got Unknown
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Expected O, but got Unknown
		//IL_0203: Expected O, but got I
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Expected O, but got Unknown
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected O, but got Unknown
		object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 832;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<int, object> dictionary = default(Dictionary<int, object>);
		dictionary..ctor();
		object obj2 = this + 16;
		obj2 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
		AsnReader asnReader = reader.ReadSetOf((Asn1Tag?)(object)0);
		if (!asnReader.HasData)
		{
			return;
		}
		object obj3 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 2520;
		object obj4 = (nint)0 + (nint)3608;
		List<object> list = default(List<object>);
		do
		{
			AsnReader asnReader2 = asnReader.ReadSequence((Asn1Tag?)(object)0);
			BigInteger bigInteger = asnReader2.ReadInteger((Asn1Tag?)(object)0);
			object obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v6+E4]");
			if ((object)((nint)0 != 0) == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int key = (int)bigInteger;
			BigInteger bigInteger2 = asnReader2.ReadInteger((Asn1Tag?)(object)0);
			byte[] array = asnReader2.ReadOctetString((Asn1Tag?)(object)0);
			if (((Dictionary<int, object>)obj2).ContainsKey(key))
			{
				object obj6 = (nint)0 + (nint)3624;
				object obj7 = ((Dictionary<int, object>)obj2).get_Item(key);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v34 (System.Object)+1C]");
				object obj8 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v34 (System.Object)+10]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v34 (System.Object)+18]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X9_v10+18]");
				if ((object)(num >= 0) != null)
				{
					((List<object>)obj7).AddWithResize((object)array);
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v34 (System.Object)+18]");
				object obj10 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v34 (System.Object)+18]");
				object obj11 = (object)(obj9 + 0) + 32;
				obj11 = array;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
			else
			{
				object obj12 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 4000;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				list..ctor();
				list._version++;
				object[] items = list._items;
				if ((object)(list._size >= items.Length) == null)
				{
					list._size++;
					object obj13 = (object)(items + list._size) + 32;
					obj13 = array;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				}
				else
				{
					list.AddWithResize((object)array);
				}
				((Dictionary<int, object>)obj2).Add(key, (object)list);
			}
		}
		while (asnReader.HasData);
	}

	public static AppleReceiptReader FromSignedCmsBytes(byte[] receiptData)
	{
		//IL_000c: Expected O, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0222: Expected O, but got I4
		//IL_0222: Expected I4, but got O
		//IL_0050: Expected O, but got I4
		//IL_0080: Expected O, but got I4
		//IL_00e4: Expected O, but got I4
		//IL_0113: Expected O, but got I4
		//IL_0125: Expected O, but got I4
		//IL_013c: Expected O, but got I4
		//IL_016b: Expected O, but got I4
		//IL_01cf: Expected O, but got I4
		object obj = (nint)0 + (nint)3440;
		object obj2 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 800;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3C170B0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		AsnReader asnReader = default(AsnReader);
		ReadOnlyMemory<byte> data = default(ReadOnlyMemory<byte>);
		asnReader..ctor(data, (AsnEncodingRules)obj, (AsnReaderOptions)0);
		if (asnReader != null)
		{
			AsnReader asnReader2 = asnReader.ReadSequence((Asn1Tag?)(object)0);
			if (asnReader2 != null)
			{
				string text = asnReader2.ReadObjectIdentifier((Asn1Tag?)(object)0);
				Asn1Tag value = asnReader2.PeekTag();
				Asn1Tag? expectedTag = value;
				AsnReader asnReader3 = asnReader2.ReadSequence(expectedTag);
				if (asnReader3 != null)
				{
					AsnReader asnReader4 = asnReader3.ReadSequence((Asn1Tag?)(object)0);
					if (asnReader4 != null)
					{
						BigInteger bigInteger = asnReader4.ReadInteger((Asn1Tag?)(object)0);
						AsnReader asnReader5 = asnReader4.ReadSetOf((Asn1Tag?)(object)0);
						AsnReader asnReader6 = asnReader4.ReadSequence((Asn1Tag?)(object)0);
						if (asnReader6 != null)
						{
							string text2 = asnReader6.ReadObjectIdentifier((Asn1Tag?)(object)0);
							Asn1Tag value2 = asnReader6.PeekTag();
							Asn1Tag? expectedTag2 = value2;
							AsnReader asnReader7 = asnReader6.ReadSequence(expectedTag2);
							if (asnReader7 != null)
							{
								byte[] rawBytes = asnReader7.ReadOctetString((Asn1Tag?)(object)0);
								return FromRawBytes(rawBytes);
							}
						}
					}
				}
			}
		}
		return (AppleReceiptReader)(object)new NullReferenceException();
	}

	public static AppleReceiptReader FromRawBytes(byte[] rawBytes)
	{
		//IL_000c: Expected O, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0084: Expected O, but got I4
		//IL_0084: Expected I4, but got O
		object obj = (nint)0 + (nint)3440;
		object obj2 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 800;
		object obj3 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 448;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3C170B0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		AsnReader asnReader = default(AsnReader);
		ReadOnlyMemory<byte> data = default(ReadOnlyMemory<byte>);
		asnReader..ctor(data, (AsnEncodingRules)obj, (AsnReaderOptions)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		AppleReceiptReader appleReceiptReader = default(AppleReceiptReader);
		appleReceiptReader..ctor(asnReader);
		return appleReceiptReader;
	}

	public byte[] Get(int type)
	{
		//IL_000c: Expected O, but got I
		object obj = (nint)0 + (nint)2072;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D233C8");
		byte[] array = default(byte[]);
		if (array != null)
		{
			return (byte[])Enumerable.FirstOrDefault((IEnumerable<object>)(object)array);
		}
		return array;
	}

	public List<byte[]> GetList(int type)
	{
		//IL_000c: Expected O, but got I
		object obj = (nint)0 + (nint)2072;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D233C8");
		List<byte[]> result = default(List<byte[]>);
		return result;
	}

	public string GetString(int type)
	{
		//IL_00a5: Expected O, but got I
		if (_attributes != null)
		{
			int key = default(int);
			if (!((Dictionary<int, object>)(object)_attributes).TryGetValue(key, out object value) || !Enumerable.Any((IEnumerable<object>)value))
			{
				return null;
			}
			Encoding uTF = Encoding.UTF8;
			object obj = Enumerable.First((IEnumerable<object>)value);
			Index start = 2;
			Range range = start..;
			object obj2 = (nint)0 + (nint)3296;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2FF9190");
			byte[] bytes = default(byte[]);
			if (uTF != null)
			{
				return uTF.GetString(bytes);
			}
		}
		return (string)(object)new NullReferenceException();
	}

	public long GetParsedInt(int type)
	{
		//IL_00e4: Expected O, but got I
		//IL_0074: Expected O, but got I4
		//IL_0050: Expected I8, but got I4
		//IL_0093: Expected O, but got I
		object obj = (nint)0 + (nint)2072;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D233C8");
		IEnumerable<object> enumerable = default(IEnumerable<object>);
		if (enumerable != null)
		{
			object obj2 = Enumerable.FirstOrDefault(enumerable);
			bool flag = ArraysExtensions.IsNullOrEmpty((IEnumerable<byte>)obj2);
			bool flag2 = !flag;
			IEnumerable<byte> enumerable2 = (IEnumerable<byte>)obj2;
			if (!flag2)
			{
				goto IL_004a;
			}
		}
		else
		{
			bool flag3 = ArraysExtensions.IsNullOrEmpty<byte>(null);
			bool flag4 = !flag3;
			object obj3 = !flag4;
			IEnumerable<byte> enumerable2 = null;
			if (obj3 != null)
			{
				goto IL_004a;
			}
		}
		object obj4 = (nint)0 + (nint)3296;
		Index start = 2;
		Range range = start..;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2FF9190");
		AppleReceiptReader appleReceiptReader = default(AppleReceiptReader);
		return appleReceiptReader.ParseIntBytes((byte[])(object)appleReceiptReader);
		IL_004a:
		return 0L;
	}

	private long ParseIntBytes(byte[] bytes)
	{
		//IL_042c: Expected I8, but got O
		//IL_000f: Expected I8, but got I4
		//IL_003d: Expected O, but got I
		//IL_0066: Expected O, but got I4
		//IL_018c: Expected O, but got I
		//IL_0223: Expected O, but got I
		//IL_0246: Expected O, but got I
		//IL_035c: Expected O, but got I
		//IL_0376: Expected O, but got I4
		//IL_007d: Expected O, but got I4
		//IL_0093: Expected O, but got I
		//IL_03cb: Expected O, but got I
		//IL_03e5: Expected O, but got I4
		//IL_0176: Expected I8, but got I4
		//IL_01bf: Expected O, but got I
		//IL_02ed: Expected O, but got I
		//IL_0307: Expected O, but got I4
		//IL_0279: Expected O, but got I
		//IL_0217: Expected I8, but got O
		//IL_00c6: Expected O, but got I
		//IL_02d1: Expected I8, but got O
		//IL_0121: Expected I8, but got O
		long result;
		object obj;
		object obj12;
		if (bytes != null)
		{
			result = bytes.Length;
			if (bytes.Length > 4)
			{
				obj = (nint)0 + (nint)3864;
				ReadOnlySpan<byte> readOnlySpan = bytes;
				bool flag = bytes.Length < 9;
				object obj2 = !flag;
				if (obj2 == null)
				{
					object obj3 = 146685952;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45F9]");
					object obj4 = (nint)0 & (nint)1;
					if (obj4 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45FA]");
						object obj5 = (nint)0 & (nint)1;
						if (obj5 != null)
						{
							goto IL_00e3;
						}
					}
					else
					{
						_ = 1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45FA]");
						object obj6 = (nint)0 & (nint)1;
						bool flag2 = obj6 == null;
						object obj7 = !flag2;
						if (obj7 != null)
						{
							goto IL_00e3;
						}
					}
					_ = 1;
					if ((nint)obj <= 3)
					{
						goto IL_0100;
					}
					goto IL_010f;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45FB]");
				object obj8 = (nint)0 & (nint)1;
				if (obj8 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45FC]");
					object obj9 = (nint)0 & (nint)1;
					if (obj9 != null)
					{
						goto IL_01dc;
					}
				}
				else
				{
					_ = 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45FC]");
					object obj10 = (nint)0 & (nint)1;
					bool flag3 = obj10 == null;
					object obj11 = !flag3;
					if (obj11 != null)
					{
						goto IL_01dc;
					}
				}
				_ = 1;
				if ((nint)obj <= 7)
				{
					goto IL_01f9;
				}
				goto IL_0208;
			}
			if (bytes.Length != 0)
			{
				if (bytes.Length == 1)
				{
					return (int)bytes[0];
				}
				obj12 = (nint)0 + (nint)3864;
				ReadOnlySpan<byte> readOnlySpan2 = bytes;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45F7]");
				object obj13 = (nint)0 & (nint)1;
				if (obj13 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45F8]");
					object obj14 = (nint)0 & (nint)1;
					if (obj14 != null)
					{
						goto IL_0296;
					}
				}
				else
				{
					_ = 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45F8]");
					object obj15 = (nint)0 & (nint)1;
					bool flag4 = obj15 == null;
					object obj16 = !flag4;
					if (obj16 != null)
					{
						goto IL_0296;
					}
				}
				_ = 1;
				if ((nint)obj12 <= 1)
				{
					goto IL_02b3;
				}
				goto IL_02c2;
			}
			goto IL_0449;
		}
		NullReferenceException ex = new NullReferenceException();
		return (long)ex;
		IL_0208:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EC4DA4");
		object obj17 = default(object);
		return (long)obj17;
		IL_02c2:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EC4DA4");
		object obj18 = default(object);
		return (long)obj18;
		IL_01f9:
		System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument.length);
		goto IL_0208;
		IL_01dc:
		if ((nint)obj <= 7)
		{
			goto IL_01f9;
		}
		goto IL_0208;
		IL_00e3:
		if ((nint)obj <= 3)
		{
			goto IL_0100;
		}
		goto IL_010f;
		IL_0449:
		return result;
		IL_010f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EC4DA4");
		object obj19 = default(object);
		result = (long)obj19;
		goto IL_0449;
		IL_0100:
		System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument.length);
		goto IL_010f;
		IL_0296:
		if ((nint)obj12 <= 1)
		{
			goto IL_02b3;
		}
		goto IL_02c2;
		IL_02b3:
		System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument.length);
		goto IL_02c2;
	}

	public DateTime GetDateTime(int type)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0112: Expected O, but got I4
		//IL_00c0: Expected O, but got I4
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected O, but got Unknown
		//IL_00d4: Expected O, but got I4
		//IL_0166: Expected O, but got I4
		//IL_016f: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8560]");
		object obj3 = (nint)0 & (nint)1;
		int type2 = default(int);
		string text2;
		string text3;
		if (obj3 != null)
		{
			string text = GetString(type2);
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v8+E4]");
			bool flag = (nint)0 == 0;
			text2 = text;
			text3 = text;
			if (!flag)
			{
				goto IL_009b;
			}
		}
		else
		{
			_ = 1;
			string text4 = GetString(type2);
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v8+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			text2 = text4;
			text3 = text4;
			if (obj5 != null)
			{
				goto IL_009b;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = StringsExtensions.IsNullOrEmpty(text3);
		bool flag4 = !flag3;
		object obj6 = !flag4;
		object obj7 = 0;
		text2 = text3;
		if (obj6 != null)
		{
			goto IL_00ce;
		}
		goto IL_0185;
		IL_00ce:
		return (DateTime)0;
		IL_0185:
		object obj8 = typeof(DataRelation) + 712;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v2+E4]");
		if ((nint)0 != 0)
		{
			return DateTime.Parse(text2);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		return DateTime.Parse(text2);
		IL_009b:
		bool flag5 = StringsExtensions.IsNullOrEmpty(text2);
		bool flag6 = !flag5;
		obj7 = 0;
		if (!flag6)
		{
			goto IL_00ce;
		}
		goto IL_0185;
	}

	public DateTime? GetDateTimeOrNull(int type)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0117: Expected O, but got I4
		//IL_00c0: Expected O, but got I4
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected O, but got Unknown
		//IL_01c9: Expected O, but got I4
		//IL_016b: Expected O, but got I4
		//IL_0174: Expected O, but got I4
		//IL_00d4: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8561]");
		object obj3 = (nint)0 & (nint)1;
		int type2 = default(int);
		string text2;
		string text3;
		if (obj3 != null)
		{
			string text = GetString(type2);
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v9+E4]");
			bool flag = (nint)0 == 0;
			text2 = text;
			text3 = text;
			if (!flag)
			{
				goto IL_009b;
			}
		}
		else
		{
			_ = 1;
			string text4 = GetString(type2);
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v9+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			text2 = text4;
			text3 = text4;
			if (obj5 != null)
			{
				goto IL_009b;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = StringsExtensions.IsNullOrEmpty(text3);
		bool flag4 = !flag3;
		object obj6 = !flag4;
		object obj7 = 0;
		text2 = text3;
		if (obj6 != null)
		{
			goto IL_00ce;
		}
		goto IL_018a;
		IL_00ce:
		return (DateTime?)(object)0;
		IL_018a:
		object obj8 = typeof(DataRelation) + 712;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X0_v2+E4]");
		bool flag5 = (nint)0 == 0;
		object obj10 = !flag5;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		return DateTime.Parse(text2);
		IL_009b:
		bool flag6 = StringsExtensions.IsNullOrEmpty(text2);
		bool flag7 = !flag6;
		obj7 = 0;
		if (!flag7)
		{
			goto IL_00ce;
		}
		goto IL_018a;
	}
}
