using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Formats.Asn1;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using Cpp2ILInjected;
using UnityEngine.InputSystem.XR;

public sealed class HttpQSCollection : NameValueCollection
{
	public HttpQSCollection()
	{
	}

	public HttpQSCollection(string str)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_004f: Expected O, but got I4
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected O, but got Unknown
		//IL_0184: Expected O, but got I4
		//IL_0195: Expected O, but got I4
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_009c: Expected O, but got I4
		//IL_00a4: Expected I4, but got O
		//IL_00f5: Expected O, but got I4
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected O, but got Unknown
		//IL_0380: Expected O, but got I4
		//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ac: Expected O, but got Unknown
		//IL_03de: Expected O, but got I4
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Expected O, but got Unknown
		//IL_024a: Expected O, but got I4
		//IL_0253: Expected O, but got I4
		//IL_0295: Expected O, but got I4
		//IL_02c7: Expected O, but got I
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Expected O, but got Unknown
		//IL_042b: Expected I, but got O
		//IL_044c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0451: Expected O, but got Unknown
		//IL_031e: Expected O, but got I
		//IL_032e: Expected O, but got I
		object obj = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 1120;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 3920;
		object obj3;
		string input;
		object obj6;
		string input2;
		if ((object)str.Contains((string)obj) == null)
		{
			obj3 = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 4016;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X0_v24+E4]");
			bool flag = (nint)0 == 0;
			input = str;
			object obj5 = 0;
			int num = (int)obj;
			obj6 = obj3;
			input2 = str;
			if (!flag)
			{
				goto IL_00c2;
			}
		}
		else
		{
			string text = str.Substring(str.IndexOf('?') + 1);
			obj3 = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 4016;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X0_v24+E4]");
			object obj7 = (nint)0 != 0;
			input = text;
			object obj5 = 0;
			obj6 = obj3;
			input2 = text;
			if (obj7 != null)
			{
				goto IL_00c2;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		string text2 = (string)obj6;
		string[] array = Regex.Split(input2, (string)obj6);
		string text3 = null;
		goto IL_01e5;
		IL_03fa:
		throw new NullReferenceException();
		IL_01e5:
		object input3 = array + 32;
		if (this != null)
		{
			if (array.Length < 1)
			{
				return;
			}
			object pattern = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 800;
			object obj8 = 153100288 + 1024;
			object obj9 = 0;
			while (true)
			{
				object obj10 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X0_v17+E4]");
				if ((object)((nint)0 != 0) == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X23_v2+v84 @ X24_v6*8]");
				string[] array2 = Regex.Split((string)0, (string)pattern);
				if (array2.Length == 0)
				{
					break;
				}
				object obj11;
				if (array2.Length == 2)
				{
					obj11 = array2 + 40;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X26_v6+90]");
					object obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X8_v20+B8]");
					obj11 = 0;
				}
				text2 = array2[0];
				text3 = (string)obj11;
				nint num2 = (nint)this;
				base.Add(array2[0], (string)obj11);
				obj9++;
				if ((nint)obj9 >= array.Length)
				{
					return;
				}
			}
		}
		else
		{
			if (array.Length < 1)
			{
				return;
			}
			object obj13 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X0_v11+E4]");
			if ((object)((nint)0 != 0) == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			if ((object)(Regex.Split((string)input3, "<ds.DataTable.OnColumnChanging|INFO> {0}" + 800).Length != 0) != null)
			{
				goto IL_03fa;
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_03fa;
		IL_00c2:
		text2 = (string)obj3;
		string[] array3 = Regex.Split(input, (string)obj3);
		object obj14 = array3 != null;
		text3 = null;
		array = array3;
		if (obj14 != null)
		{
			goto IL_01e5;
		}
		goto IL_03fa;
	}

	public Dictionary<string, string> ToDictionary()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_006e: Expected O, but got I4
		//IL_00f4: Expected O, but got I
		//IL_0111: Expected O, but got I
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		object obj = typeof(ConditionalWeakTable<HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 2808;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<object, object> dictionary = default(Dictionary<object, object>);
		dictionary..ctor();
		string[] allKeys = base.AllKeys;
		object obj2 = allKeys + 32;
		if (dictionary != null)
		{
			if (allKeys.Length >= 1)
			{
				object obj3 = 0;
				do
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X23_v2+v164 @ X24_v4*8]");
					string value = base.get_Item((string)0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X23_v2+v164 @ X24_v4*8]");
					dictionary.set_Item((object)0, (object)value);
					obj3++;
				}
				while ((nint)obj3 < allKeys.Length);
			}
		}
		else if (allKeys.Length >= 1)
		{
			object name = default(object);
			string text = base.get_Item((string)name);
			return (Dictionary<string, string>)(object)new NullReferenceException();
		}
		return (Dictionary<string, string>)(object)dictionary;
	}

	public override string ToString()
	{
		//IL_03be: Expected I, but got O
		//IL_0212: Expected O, but got I
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_02e7: Expected O, but got I4
		//IL_034d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Expected O, but got Unknown
		//IL_037c: Expected O, but got I4
		//IL_0293: Expected I, but got O
		//IL_02a3: Expected O, but got I
		//IL_02b3: Expected O, but got I
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		//IL_00ec: Expected O, but got I4
		//IL_018b: Expected O, but got I4
		//IL_01bb: Expected O, but got I
		//IL_01e9: Expected O, but got I4
		//IL_011b: Expected O, but got I
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected O, but got Unknown
		//IL_0149: Expected O, but got I4
		//IL_015a: Expected O, but got I4
		nint num = (nint)this;
		int count = base.Count;
		StringBuilder stringBuilder = default(StringBuilder);
		string[] array = default(string[]);
		object obj2 = default(object);
		object obj5 = default(object);
		object obj7 = default(object);
		if (count != 0)
		{
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2344;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			stringBuilder..ctor();
			string[] allKeys = base.AllKeys;
			if (count >= 1)
			{
				bool flag = allKeys == null;
				array = allKeys;
				if (!flag)
				{
					obj2 = allKeys + 32;
					bool flag2 = stringBuilder == null;
					array = allKeys;
					if (flag2)
					{
						goto IL_02cb;
					}
					object obj3 = typeof(UsageHint) + 2104;
					object format = "{0} color encoding is currently unsupported for outputting to HDR." + 1152;
					object obj4 = obj5;
					object obj6 = obj7;
					object obj8 = 0;
					while (true)
					{
						bool flag3 = (nint)obj8 < allKeys.Length;
						object obj9 = !flag3;
						obj5 = obj4;
						obj7 = obj6;
						if (obj9 != null)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X23_v3+v268 @ X24_v7*8]");
						string value = base.get_Item((string)0);
						object obj10 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v19+E4]");
						bool flag4 = (nint)0 == 0;
						object obj11 = !flag4;
						if (obj11 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						string text = WebUtility.UrlEncode(value);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X23_v3+v268 @ X24_v7*8]");
						StringBuilder stringBuilder2 = stringBuilder.AppendFormat((string)format, 0, text);
						obj8++;
						bool flag5 = count == (nint)obj8;
						obj4 = 0;
						obj6 = text;
						obj5 = 0;
						obj7 = text;
						if (!flag5)
						{
							continue;
						}
						goto IL_0234;
					}
					goto IL_030d;
				}
			}
			else if (stringBuilder != null)
			{
				goto IL_0234;
			}
			goto IL_02bd;
		}
		return (string)((nint)0 + (nint)2000);
		IL_02bd:
		NullReferenceException ex = new NullReferenceException();
		goto IL_02cb;
		IL_02cb:
		bool flag6 = array.Length == 0;
		object obj12 = !flag6;
		object obj13 = obj5;
		object obj14 = obj7;
		object name = obj2;
		if (obj12 == null)
		{
			goto IL_030d;
		}
		string value2 = base.get_Item((string)name);
		object obj15 = typeof(UsageHint) + 2104;
		object obj16 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X0_v12+E4]");
		bool flag7 = (nint)0 == 0;
		object obj17 = !flag7;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text2 = WebUtility.UrlEncode(value2);
		return (string)(object)new NullReferenceException();
		IL_030d:
		obj13 = obj5;
		obj14 = obj7;
		name = obj2;
		throw new IndexOutOfRangeException();
		IL_0234:
		int length = stringBuilder.Length;
		if (length >= 1)
		{
			int length2 = stringBuilder.Length;
			int length3 = length2 - 1;
			stringBuilder.Length = length3;
		}
		nint num2 = (nint)stringBuilder;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v16 (Il2CppClass<System.Text.StringBuilder>)+168]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v16 (Il2CppClass<System.Text.StringBuilder>)+170]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v98 @ X2_v6 (should have been resolved before IL gen)");
		goto IL_02bd;
	}
}
