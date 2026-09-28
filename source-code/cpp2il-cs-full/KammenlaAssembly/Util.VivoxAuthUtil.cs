using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using Cpp2ILInjected;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq.JsonPath;
using UnityEngine.AdaptivePerformance;
using UnityEngine.InputSystem.UI;
using UnityEngine.InputSystem.XR;
using UnityEngine.TextCore;

namespace Util;

public class VivoxAuthUtil
{
	private class Claims
	{
		private string <iss>k__BackingField;

		private int <exp>k__BackingField;

		private string <vxa>k__BackingField;

		private int <vxi>k__BackingField;

		private string <f>k__BackingField;

		private string <t>k__BackingField;

		private string <sub>k__BackingField;

		public string iss
		{
			get
			{
				return <iss>k__BackingField;
			}
			set
			{
				//IL_0006: Unknown result type (might be due to invalid IL or missing references)
				//IL_000b: Expected O, but got Unknown
				object obj = this + 16;
				obj = value;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
		}

		public int exp
		{
			get
			{
				return <exp>k__BackingField;
			}
			set
			{
				<exp>k__BackingField = value;
			}
		}

		public string vxa
		{
			get
			{
				return <vxa>k__BackingField;
			}
			set
			{
				//IL_0006: Unknown result type (might be due to invalid IL or missing references)
				//IL_000b: Expected O, but got Unknown
				object obj = this + 32;
				obj = value;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
		}

		public int vxi
		{
			get
			{
				return <vxi>k__BackingField;
			}
			set
			{
				<vxi>k__BackingField = value;
			}
		}

		public string f
		{
			get
			{
				return <f>k__BackingField;
			}
			set
			{
				//IL_0006: Unknown result type (might be due to invalid IL or missing references)
				//IL_000b: Expected O, but got Unknown
				object obj = this + 48;
				obj = value;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
		}

		public string t
		{
			get
			{
				return <t>k__BackingField;
			}
			set
			{
				//IL_0006: Unknown result type (might be due to invalid IL or missing references)
				//IL_000b: Expected O, but got Unknown
				object obj = this + 56;
				obj = value;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
		}

		public string sub
		{
			get
			{
				return <sub>k__BackingField;
			}
			set
			{
				//IL_0006: Unknown result type (might be due to invalid IL or missing references)
				//IL_000b: Expected O, but got Unknown
				object obj = this + 64;
				obj = value;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
		}
	}

	private const string VX_CLAIM_LOGIN = "login";

	private const string VX_CLAIM_JOIN = "join";

	public const string VivoxIssuer = "73983-___-44677-udash";

	public const string VivoxDomain = "mtu1xp.vivox.com";

	public const string VivoxKey = "4G5lXtoR7R6l1zNFHEV6H8ylGMwSjqhg";

	private static readonly long TOKEN_LIFETIME_SECONDS;

	public static string vxGenerateLoginToken(string username)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_005d: Expected O, but got I
		//IL_0087: Expected O, but got I4
		object obj = typeof(UsageHint) + 1344;
		object claimType = "java.io.FileOutputStream" + 3192;
		object to = (nint)0 + (nint)2000;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		return vxGenerateToken((string)claimType, username, (string)to);
	}

	public static string vxGenerateJoinToken(string username, string channel)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_007b: Expected O, but got I4
		object obj = typeof(UsageHint) + 1344;
		object claimType = "java.io.FileOutputStream" + 312;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		return vxGenerateToken((string)claimType, username, channel);
	}

	private static string vxGenerateToken(string claimType, string from, string to)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_061e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0623: Expected O, but got Unknown
		//IL_064d: Expected O, but got I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0081: Expected O, but got I4
		//IL_066b: Expected O, but got I
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected O, but got Unknown
		//IL_01da: Expected O, but got I
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Expected O, but got Unknown
		//IL_0265: Expected O, but got I4
		//IL_031f: Expected O, but got I
		//IL_032f: Expected O, but got I
		//IL_033f: Expected O, but got I
		//IL_0376: Expected O, but got I4
		//IL_0386: Expected O, but got I
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected O, but got Unknown
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected O, but got Unknown
		//IL_02f4: Expected O, but got I4
		//IL_0424: Unknown result type (might be due to invalid IL or missing references)
		//IL_0429: Expected O, but got Unknown
		//IL_0433: Unknown result type (might be due to invalid IL or missing references)
		//IL_0438: Expected O, but got Unknown
		//IL_0458: Expected O, but got I4
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_049d: Expected O, but got Unknown
		//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ab: Expected O, but got Unknown
		//IL_056d: Expected O, but got I4
		//IL_05ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b2: Expected O, but got Unknown
		//IL_05bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c0: Expected O, but got Unknown
		object obj = typeof(DataRelation) + 768;
		object obj2 = typeof(UsageHint) + 1344;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5 = typeof(TrackedDeviceRaycaster.<>c) + 2160;
		DateTimeOffset now = DateTimeOffset.Now;
		DateTimeOffset dateTimeOffset = default(DateTimeOffset);
		long num = dateTimeOffset.ToUnixTimeSeconds();
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v9+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj6 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v9+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj9 = default(object);
		obj9..ctor();
		List<object> list = default(List<object>);
		string text3;
		string text = default(string);
		if (obj9 != null)
		{
			object obj10 = "1.2.840.113549.1.12.1.5" + 1432;
			object obj11 = typeof(List<AdaptivePerformanceScaler>) + 3624;
			object plainText = "{0} color encoding is currently unsupported for outputting to HDR." + 1768;
			object obj12 = obj8 + num;
			object obj13 = obj9 + 16;
			obj13 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj14 = obj9 + 32;
			obj14 = claimType;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			int serial = getSerial(from);
			object obj15 = obj9 + 48;
			obj15 = from;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj16 = obj9 + 56;
			obj16 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			list..ctor();
			string text2 = Base64URLEncode((string)plainText);
			if (list != null)
			{
				object obj17 = (nint)0 + (nint)3072;
				object obj18 = obj17;
				int version = list._version + 1;
				list._version = version;
				object[] items = list._items;
				if (list._items != null)
				{
					object obj19 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 520;
					bool flag3 = list._size < items.Length;
					object obj20 = !flag3;
					if (obj20 == null)
					{
						int size = list._size + 1;
						list._size = size;
						object obj21 = list._items + list._size;
						object obj22 = obj21 + 32;
						obj22 = text2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						object obj23 = obj19;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X0_v52+E4]");
						bool flag4 = (nint)0 == 0;
						object obj24 = !flag4;
						if (obj24 == null)
						{
							text3 = text;
							goto IL_0394;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v9+20]");
						object obj25 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X8_v22+C0]");
						object obj26 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X8_v23+70]");
						text3 = (string)0;
						list.AddWithResize((object)text2);
						object obj23 = obj19;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X0_v52+E4]");
						bool flag5 = (nint)0 == 0;
						object obj27 = !flag5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X8_v23+70]");
						text = (string)0;
						if (obj27 == null)
						{
							goto IL_0394;
						}
					}
					goto IL_03ab;
				}
			}
		}
		goto IL_0601;
		IL_03ab:
		string plainText2 = JsonConvert.SerializeObject(obj9);
		string text4 = Base64URLEncode(plainText2);
		int version2 = list._version + 1;
		list._version = version2;
		object[] items2 = list._items;
		if (list._items != null)
		{
			object separator = ", stale={0}" + 1352;
			object secret = "1.2.840.113549.1.12.1.5" + 1344;
			bool flag6 = list._size < items2.Length;
			object obj28 = !flag6;
			if (obj28 == null)
			{
				int size2 = list._size + 1;
				list._size = size2;
				object obj29 = list._items + list._size;
				object obj30 = obj29 + 32;
				obj30 = text4;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
			else
			{
				list.AddWithResize((object)text4);
			}
			string message = string.Join((string)separator, (IEnumerable<string>)list);
			string text5 = SHA256Hash((string)secret, message);
			int version3 = list._version + 1;
			list._version = version3;
			object[] items3 = list._items;
			if (list._items != null)
			{
				bool flag7 = list._size < items3.Length;
				object obj31 = !flag7;
				if (obj31 == null)
				{
					int size3 = list._size + 1;
					list._size = size3;
					object obj32 = list._items + list._size;
					object obj33 = obj32 + 32;
					obj33 = text5;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				}
				else
				{
					list.AddWithResize((object)text5);
				}
				return string.Join((string)separator, (IEnumerable<string>)list);
			}
		}
		goto IL_0601;
		IL_0394:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		text = text3;
		goto IL_03ab;
		IL_0601:
		return (string)(object)new NullReferenceException();
	}

	private static string Base64URLEncode(string plainText)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_005c: Expected O, but got I4
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected O, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected O, but got Unknown
		Encoding uTF = Encoding.UTF8;
		if (uTF != null)
		{
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3016;
			nint num = (nint)uTF;
			byte[] bytes = uTF.GetBytes(plainText);
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string text = Convert.ToBase64String(bytes);
			if (text != null)
			{
				string text2 = text.TrimEnd('=');
				if (text2 != null)
				{
					object oldValue = "&action=sign-up" + 3352;
					object newValue = ", stale={0}" + 120;
					string text3 = text2.Replace((string)oldValue, (string)newValue);
					if (text3 != null)
					{
						object oldValue2 = ", stale={0}" + 2920;
						object newValue2 = "[{0}]:{1}" + 912;
						return text3.Replace((string)oldValue2, (string)newValue2);
					}
				}
			}
		}
		return (string)(object)new NullReferenceException();
	}

	private unsafe static string SHA256Hash(string secret, string message)
	{
		//IL_0010: Expected O, but got I
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_046c: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0056: Expected I, but got O
		//IL_0066: Expected O, but got I
		//IL_00b2: Expected O, but got Ref
		//IL_00bb: Expected O, but got I4
		//IL_00d3: Expected O, but got Ref
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected O, but got Unknown
		//IL_011e: Expected O, but got I
		//IL_0140: Expected O, but got I4
		//IL_0189: Expected O, but got Ref
		//IL_0192: Expected O, but got I4
		//IL_05b6: Expected O, but got I4
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Expected O, but got Unknown
		//IL_034b: Expected I, but got O
		//IL_035b: Expected O, but got I
		//IL_04f9: Expected O, but got Ref
		//IL_0502: Expected O, but got I4
		//IL_0510: Expected O, but got I4
		//IL_06c4: Expected O, but got I
		//IL_0396: Expected O, but got I
		//IL_0672: Expected O, but got I4
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected O, but got Unknown
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected O, but got Unknown
		//IL_0690: Expected O, but got I
		//IL_052f: Expected O, but got I4
		//IL_053f: Expected O, but got Ref
		//IL_0548: Expected O, but got I4
		//IL_0413: Unknown result type (might be due to invalid IL or missing references)
		//IL_0418: Expected O, but got Unknown
		//IL_0421: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Expected O, but got Unknown
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected O, but got Unknown
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Expected O, but got Unknown
		//IL_029c: Expected O, but got I4
		//IL_02ac: Expected O, but got Ref
		//IL_02b5: Expected O, but got I4
		//IL_02c6: Expected O, but got I4
		//IL_02df: Expected O, but got I4
		//IL_02ef: Expected O, but got Ref
		//IL_02f8: Expected O, but got I4
		//IL_0321: Expected O, but got I4
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a9: Expected O, but got Unknown
		//IL_03bf: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8710]");
		object obj = 0;
		object obj2 = typeof(SqlSingle[]) + 2080;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ASCIIEncoding aSCIIEncoding = default(ASCIIEncoding);
		aSCIIEncoding..ctor();
		object obj3;
		HMACSHA256 hMACSHA2;
		object obj5 = default(object);
		byte[] array;
		ASCIIEncoding aSCIIEncoding2;
		string text2;
		string text3;
		string text6;
		object obj10 = default(object);
		HMACSHA256 hMACSHA4;
		object obj11;
		object obj12;
		object obj13 = default(object);
		object obj14;
		object obj15 = default(object);
		object obj16;
		object obj17;
		string text7;
		string result;
		object obj18;
		object obj19;
		NullReferenceException ex;
		HMACSHA256 hMACSHA3;
		object obj4;
		if (aSCIIEncoding != null)
		{
			obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 3584;
			byte[] bytes = aSCIIEncoding.GetBytes(secret);
			nint num = (nint)aSCIIEncoding;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v15 (Il2CppClass<System.Text.ASCIIEncoding>)+258]");
			obj4 = 0;
			byte[] bytes2 = aSCIIEncoding.GetBytes(message);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			HMACSHA256 hMACSHA = default(HMACSHA256);
			hMACSHA..ctor(bytes);
			bool flag = hMACSHA == null;
			hMACSHA2 = hMACSHA;
			obj5 = (object)(&hMACSHA2);
			object obj6 = 0;
			array = bytes;
			aSCIIEncoding2 = (ASCIIEncoding)(object)hMACSHA;
			obj = (object)(&hMACSHA2);
			if (!flag)
			{
				byte[] inArray = hMACSHA.ComputeHash(bytes2);
				object obj7 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3016;
				object obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X0_v38+E4]");
				obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X0_v38+E4]");
				bool flag2 = (nint)0 == 0;
				object obj9 = !flag2;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				string text = Convert.ToBase64String(inArray);
				bool flag3 = text == null;
				hMACSHA2 = hMACSHA;
				obj5 = (object)(&hMACSHA2);
				obj6 = 0;
				text2 = null;
				text3 = null;
				hMACSHA3 = hMACSHA;
				if (flag3)
				{
					goto IL_04d2;
				}
				string text4 = text.TrimEnd('=');
				if (text4 != null)
				{
					obj = "&action=sign-up" + 3352;
					obj4 = ", stale={0}" + 120;
					text3 = (string)obj;
					text2 = (string)obj4;
					string text5 = text4.Replace((string)obj, (string)obj4);
					if (text5 != null)
					{
						obj = ", stale={0}" + 2920;
						obj4 = "[{0}]:{1}" + 912;
						text3 = (string)obj;
						text2 = (string)obj4;
						text6 = text5.Replace((string)obj, (string)obj4);
						bool flag4 = hMACSHA == null;
						obj10 = 0;
						hMACSHA2 = hMACSHA;
						obj5 = (object)(&hMACSHA2);
						obj6 = 0;
						hMACSHA4 = hMACSHA;
						obj11 = 0;
						obj12 = obj13;
						obj14 = obj15;
						obj16 = 0;
						hMACSHA2 = hMACSHA;
						obj17 = (object)(&hMACSHA2);
						obj6 = 0;
						text7 = (string)obj4;
						result = text6;
						hMACSHA3 = hMACSHA;
						obj18 = obj3;
						obj19 = 0;
						if (!flag4)
						{
							goto IL_032f;
						}
						goto IL_0658;
					}
					ex = new NullReferenceException();
					obj10 = 0;
					hMACSHA2 = hMACSHA;
					obj5 = (object)(&hMACSHA2);
					obj6 = 0;
					hMACSHA3 = hMACSHA;
				}
				else
				{
					ex = new NullReferenceException();
					hMACSHA2 = hMACSHA;
					obj5 = (object)(&hMACSHA2);
					obj6 = 0;
					text2 = null;
					text3 = (string)61;
					hMACSHA3 = hMACSHA;
				}
				goto IL_055b;
			}
		}
		else
		{
			NullReferenceException ex2 = new NullReferenceException();
			hMACSHA2 = null;
			array = null;
			aSCIIEncoding2 = aSCIIEncoding;
			obj3 = 152993792;
		}
		ex = new NullReferenceException();
		text2 = null;
		text3 = (string)(object)array;
		hMACSHA3 = (HMACSHA256)(object)aSCIIEncoding2;
		goto IL_055b;
		IL_055b:
		if ((nint)text3 == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			object obj20 = default(object);
			obj11 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			bool flag5 = hMACSHA2 == null;
			object obj21 = !flag5;
			object obj6 = obj20;
			text6 = null;
			hMACSHA4 = hMACSHA2;
			if (obj21 != null)
			{
				goto IL_032f;
			}
			obj12 = obj13;
			obj14 = obj15;
			obj16 = obj10;
			obj17 = obj5;
			obj6 = obj20;
			text7 = text2;
			result = null;
			obj18 = obj3;
			obj19 = obj20;
			goto IL_0658;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		string result2 = default(string);
		return result2;
		IL_0658:
		bool flag6 = obj19 == null;
		object obj22 = !flag6;
		if (obj22 == null)
		{
			return result;
		}
		OutOfMemoryException ex3 = new OutOfMemoryException();
		obj13 = obj12;
		obj15 = obj14;
		obj10 = obj16;
		obj5 = obj17;
		text2 = text7;
		obj3 = obj18;
		goto IL_04d2;
		IL_04d2:
		ex = new NullReferenceException();
		goto IL_055b;
		IL_03e7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		text7 = null;
		hMACSHA3 = (HMACSHA256)(object)text6;
		goto IL_06b4;
		IL_032f:
		object obj23 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
		nint num2 = (nint)hMACSHA4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X8_v10 (Il2CppClass<System.Security.Cryptography.HMACSHA256>)+12E]");
		obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X8_v10 (Il2CppClass<System.Security.Cryptography.HMACSHA256>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_03e7;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X8_v10 (Il2CppClass<System.Security.Cryptography.HMACSHA256>)+B0]");
		object obj24 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X10_v9-8]");
			obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X10_v9-8]");
			if (0 == (nint)obj23)
			{
				break;
			}
			obj15 = obj24 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X8_v10 (Il2CppClass<System.Security.Cryptography.HMACSHA256>)+12E]");
			obj4 = -1;
			bool flag7 = (nint)obj4 != 1;
			obj24 = obj15;
			if (flag7)
			{
				continue;
			}
			goto IL_03e7;
		}
		obj4 = obj24;
		object obj25 = num2 + obj24;
		object obj26 = obj25 + 312;
		obj15 = obj24;
		text7 = text2;
		hMACSHA3 = (HMACSHA256)(object)text6;
		goto IL_06b4;
		IL_06b4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X0_v23+8]");
		text3 = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v412 @ X0_v23] (should have been resolved before IL gen)");
		obj12 = obj13;
		obj14 = obj15;
		obj16 = obj10;
		obj17 = obj5;
		result = (string)(object)hMACSHA3;
		obj18 = obj3;
		obj19 = obj11;
		goto IL_0658;
	}

	private static int getSerial(string name)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0128: Expected O, but got I4
		//IL_00ec: Expected I4, but got O
		object obj = typeof(DataRelation) + 768;
		MD5 mD = MD5.Create();
		Encoding uTF = Encoding.UTF8;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTimeOffset now = DateTimeOffset.Now;
		DateTimeOffset dateTimeOffset = default(DateTimeOffset);
		long num = dateTimeOffset.ToUnixTimeMilliseconds();
		long num2 = default(long);
		string text = num2.ToString();
		string s = name + text;
		if (uTF != null)
		{
			byte[] bytes = uTF.GetBytes(s);
			if (mD != null)
			{
				byte[] value = mD.ComputeHash(bytes);
				return BitConverter.ToInt32(value, 0);
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	static VivoxAuthUtil()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0031: Expected O, but got I
		//IL_003a: Expected O, but got I4
		object obj = typeof(UsageHint) + 1344;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+B8]");
		object obj3 = 0;
		obj3 = 1800;
	}
}
