using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.Remoting.Messaging;
using System.Text;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Linq.JsonPath;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Networking;
using UnityEngine.Rendering;
using UnityEngine.TextCore;

namespace Kammelna.Server.WebRequests;

public static class MultipartFormFlattener
{
	public static List<IMultipartFormSection> Flatten(object model)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0063: Expected O, but got I4
		//IL_009c: Expected O, but got I4
		//IL_00ac: Expected O, but got I
		//IL_00bc: Expected O, but got I
		object obj = typeof(List<AdaptivePerformanceScaler>) + 1528;
		object obj2 = (nint)0 + (nint)64;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		if (model != null)
		{
			object obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 80;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			JToken token = JToken.FromObject(model);
			object obj6 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v8+90]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v9+B8]");
			object prefix = 0;
			Walk(token, (string)prefix, (List<IMultipartFormSection>)(object)list);
		}
		return (List<IMultipartFormSection>)(object)list;
	}

	public static void AppendFile(List<IMultipartFormSection> sections, string fieldName, byte[] fileBytes, string fileName, string contentType)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0095: Expected O, but got I4
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected O, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		if (fileBytes != null)
		{
			object obj = typeof(MemberAchievementClanFeedData) + 1808;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			MultipartFormFileSection multipartFormFileSection = default(MultipartFormFileSection);
			multipartFormFileSection..ctor(fieldName, fileBytes, fileName, contentType);
			int version = sections._version + 1;
			sections._version = version;
			IMultipartFormSection[] items = sections._items;
			bool flag = sections._size < items.Length;
			object obj2 = !flag;
			if (obj2 == null)
			{
				int size = sections._size + 1;
				sections._size = size;
				object obj3 = items + sections._size;
				object obj4 = obj3 + 32;
				obj4 = multipartFormFileSection;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
			else
			{
				((List<object>)(object)sections).AddWithResize((object)multipartFormFileSection);
			}
		}
	}

	private unsafe static void Walk(JToken token, string prefix, List<IMultipartFormSection> sections)
	{
		//IL_0dfd: Expected F8, but got I4
		//IL_0e0e: Expected O, but got I4
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0039: Expected I, but got O
		//IL_0049: Expected O, but got I
		//IL_0072: Expected O, but got I4
		//IL_007b: Expected I4, but got O
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected O, but got Unknown
		//IL_0132: Expected O, but got I
		//IL_0153: Expected O, but got I4
		//IL_01bb: Expected O, but got I
		//IL_0099: Expected O, but got I
		//IL_00b6: Expected O, but got I
		//IL_00c6: Expected O, but got I
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_02f4: Expected I, but got O
		//IL_0304: Expected O, but got I
		//IL_0314: Expected O, but got I
		//IL_0332: Expected F8, but got I4
		//IL_0187: Expected O, but got I
		//IL_0538: Expected O, but got I4
		//IL_0e42: Expected O, but got I4
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected O, but got Unknown
		//IL_0226: Expected O, but got I4
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected O, but got Unknown
		//IL_029e: Expected O, but got I4
		//IL_0cc3: Expected O, but got I4
		//IL_0ccc: Expected F8, but got I4
		//IL_0555: Unknown result type (might be due to invalid IL or missing references)
		//IL_055a: Expected O, but got Unknown
		//IL_0569: Unknown result type (might be due to invalid IL or missing references)
		//IL_056e: Expected O, but got Unknown
		//IL_0578: Unknown result type (might be due to invalid IL or missing references)
		//IL_057d: Expected O, but got Unknown
		//IL_059d: Expected O, but got I
		//IL_05ae: Expected O, but got I4
		//IL_0346: Unknown result type (might be due to invalid IL or missing references)
		//IL_034b: Expected O, but got Unknown
		//IL_0353: Expected I, but got O
		//IL_0363: Expected O, but got I
		//IL_0b2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2f: Expected O, but got Unknown
		//IL_0b39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3e: Expected O, but got Unknown
		//IL_0622: Expected I, but got O
		//IL_0632: Expected O, but got I
		//IL_03ad: Expected I, but got O
		//IL_0eb3: Expected I, but got O
		//IL_0ec3: Expected O, but got I
		//IL_0ed6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0edb: Expected O, but got Unknown
		//IL_066d: Expected O, but got I
		//IL_03e7: Expected O, but got I
		//IL_03ef: Expected I, but got O
		//IL_043a: Expected I, but got O
		//IL_097d: Expected O, but got I4
		//IL_098e: Expected F8, but got I4
		//IL_09af: Expected O, but got I4
		//IL_09c0: Expected O, but got I4
		//IL_09e1: Expected O, but got I4
		//IL_09fa: Expected F8, but got I4
		//IL_0a13: Expected O, but got I4
		//IL_0a1c: Expected O, but got I4
		//IL_0e6b: Expected O, but got I
		//IL_0e7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e82: Expected O, but got Unknown
		//IL_0ff7: Expected O, but got I4
		//IL_0716: Unknown result type (might be due to invalid IL or missing references)
		//IL_071b: Expected O, but got Unknown
		//IL_0724: Unknown result type (might be due to invalid IL or missing references)
		//IL_0729: Expected O, but got Unknown
		//IL_0480: Expected O, but got I4
		//IL_0a39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3e: Expected O, but got Unknown
		//IL_0a46: Expected I, but got O
		//IL_0a56: Expected O, but got I
		//IL_0683: Unknown result type (might be due to invalid IL or missing references)
		//IL_0688: Expected O, but got Unknown
		//IL_069e: Expected O, but got I
		//IL_06a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ae: Expected O, but got Unknown
		//IL_0be7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bec: Expected O, but got Unknown
		//IL_0c06: Expected O, but got I4
		//IL_076b: Expected I, but got O
		//IL_077b: Expected O, but got I
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c5: Expected O, but got Unknown
		//IL_04ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d3: Expected O, but got Unknown
		//IL_10a1: Expected O, but got I
		//IL_0a91: Expected O, but got I
		//IL_106d: Expected O, but got I
		//IL_0f50: Expected I, but got O
		//IL_0f60: Expected O, but got I
		//IL_0f99: Expected O, but got I
		//IL_07b6: Expected O, but got I
		//IL_0d3a: Expected O, but got I4
		//IL_0d4b: Expected O, but got I4
		//IL_0bb6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bbb: Expected O, but got Unknown
		//IL_0bc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc9: Expected O, but got Unknown
		//IL_0f08: Expected O, but got I
		//IL_0f1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f1f: Expected O, but got Unknown
		//IL_0a9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa4: Expected O, but got Unknown
		//IL_0aba: Expected O, but got I
		//IL_088f: Expected I, but got O
		//IL_089f: Expected O, but got I
		//IL_08af: Expected O, but got I
		//IL_08c0: Expected O, but got I
		//IL_08d4: Expected O, but got I4
		//IL_085f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0864: Expected O, but got Unknown
		//IL_086d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0872: Expected O, but got Unknown
		//IL_0dca: Expected O, but got I4
		//IL_07cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d1: Expected O, but got Unknown
		//IL_07e7: Expected O, but got I
		//IL_07f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f7: Expected O, but got Unknown
		//IL_092d: Expected O, but got I4
		//IL_0fc0: Expected O, but got I
		//IL_05c0: Expected I, but got O
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E84D6]");
		nint num = 0;
		bool flag = token == null;
		IEnumerator<KeyValuePair<string, JToken>> enumerator = null;
		byte[] array = (byte[])(object)sections;
		double num2 = 0.0;
		string text = prefix;
		byte[] array2 = (byte[])152993792;
		List<IMultipartFormSection> list;
		nint num6;
		object obj11;
		object obj12;
		byte[] array4;
		object obj23;
		IEnumerator<KeyValuePair<string, JToken>> enumerator4;
		object obj24;
		object obj25;
		object obj26;
		nint num12;
		object obj27;
		byte[] array5;
		double num13;
		object obj28;
		object obj29;
		object obj30;
		IMultipartFormSection[] array3;
		object obj22;
		object obj10;
		object obj9;
		nint num11;
		nint num7 = default(nint);
		object obj8;
		double num14 = default(double);
		object obj4;
		object obj6;
		object obj2;
		if (!flag)
		{
			object obj = typeof(System.IOAsyncCallback) + 4088;
			obj2 = obj;
			nint num3 = (nint)token;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v16 (Il2CppClass<Newtonsoft.Json.Linq.JToken>)+130]");
			array3 = (IMultipartFormSection[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v16 (Il2CppClass<Newtonsoft.Json.Linq.JToken>)+130]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v770 @ X10_v6+130]");
			bool flag2 = num4 < 0;
			object obj3 = !flag2;
			bool flag3 = (byte)(int)(~obj3) != 0;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v16 (Il2CppClass<Newtonsoft.Json.Linq.JToken>)+C8]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v16 (Il2CppClass<Newtonsoft.Json.Linq.JToken>)+C8]");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v770 @ X10_v6+130]");
				object obj5 = num5 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X11_v14-8]");
				obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X11_v14-8]");
				object obj7 = 0 - obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X11_v14-8]");
				if (0 == (nint)obj2)
				{
					IEnumerator<KeyValuePair<string, JToken>> enumerator2 = ((JObject)token).GetEnumerator();
					bool flag4 = enumerator2 == null;
					list = sections;
					text = null;
					num = (nint)(&enumerator);
					array2 = (byte[])152993792;
					if (flag4)
					{
						goto IL_0c6d;
					}
					obj8 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
					obj9 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 88;
					obj10 = ", stale={0}" + 1352;
					num6 = num7;
					List<IMultipartFormSection> list2 = sections;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X11_v14-8]");
					obj11 = 0;
					obj12 = obj2;
					array4 = (byte[])152993792;
					IEnumerator<KeyValuePair<string, JToken>> enumerator3 = enumerator2;
					object obj15 = default(object);
					object obj17 = default(object);
					object obj20 = default(object);
					string text3 = default(string);
					while (true)
					{
						nint num8 = (nint)enumerator3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ X8_v38 (Il2CppClass<System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<System.String, Newtonsoft.Json.Linq.JToken>>>)+12E]");
						array3 = (IMultipartFormSection[])0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ X8_v38 (Il2CppClass<System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<System.String, Newtonsoft.Json.Linq.JToken>>>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_06f2;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ X8_v38 (Il2CppClass<System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<System.String, Newtonsoft.Json.Linq.JToken>>>)+B0]");
						object obj13 = (nint)0 + (nint)8;
						bool flag5 = flag3;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ X10_v30-8]");
							obj11 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ X10_v30-8]");
							obj7 = 0 - obj8;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ X10_v30-8]");
							if (0 == (nint)obj8)
							{
								break;
							}
							obj12 = obj13 + 16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ X8_v38 (Il2CppClass<System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<System.String, Newtonsoft.Json.Linq.JToken>>>)+12E]");
							array3 = (IMultipartFormSection[])(-1);
							obj7 = array3 - 1;
							bool flag6 = obj7 == null;
							flag3 = (nint)array3 != 1;
							flag5 = flag3;
							obj13 = obj12;
							if (flag3)
							{
								continue;
							}
							goto IL_06f2;
						}
						array3 = (IMultipartFormSection[])obj13;
						object obj14 = num8 + obj13;
						obj15 = obj14 + 312;
						array = (byte[])(object)list2;
						flag3 = flag5;
						obj12 = obj13;
						goto IL_0eab;
						IL_0eab:
						num = (nint)obj15;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v748 @ X0_v67+8]");
						text = (string)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v748 @ X0_v67] (should have been resolved before IL gen)");
						object obj16 = obj17 & 1;
						if (obj16 == null)
						{
							break;
						}
						if (enumerator == null)
						{
							goto IL_0c83;
						}
						nint num9 = (nint)enumerator;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v840 @ X8_v41 (Il2CppClass<System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<System.String, Newtonsoft.Json.Linq.JToken>>>)+12E]");
						array3 = (IMultipartFormSection[])0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v840 @ X8_v41 (Il2CppClass<System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<System.String, Newtonsoft.Json.Linq.JToken>>>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_083b;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v840 @ X8_v41 (Il2CppClass<System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<System.String, Newtonsoft.Json.Linq.JToken>>>)+B0]");
						object obj18 = (nint)0 + (nint)8;
						bool flag7 = flag3;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v902 @ X10_v25-8]");
							obj11 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v902 @ X10_v25-8]");
							obj7 = 0 - obj9;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v902 @ X10_v25-8]");
							if (0 == (nint)obj9)
							{
								break;
							}
							obj12 = obj18 + 16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v840 @ X8_v41 (Il2CppClass<System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<System.String, Newtonsoft.Json.Linq.JToken>>>)+12E]");
							array3 = (IMultipartFormSection[])(-1);
							obj7 = array3 - 1;
							bool flag6 = obj7 == null;
							flag3 = (nint)array3 != 1;
							flag7 = flag3;
							obj18 = obj12;
							if (flag3)
							{
								continue;
							}
							goto IL_083b;
						}
						array3 = (IMultipartFormSection[])obj18;
						object obj19 = num9 + obj18;
						obj20 = obj19 + 312;
						flag3 = flag7;
						obj12 = obj18;
						goto IL_0f48;
						IL_0f48:
						nint num10 = (nint)obj20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v926 @ X0_v71+8]");
						string text2 = (string)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v926 @ X0_v71] (should have been resolved before IL gen)");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v926 @ X0_v71+8]");
						bool flag8 = (nint)0 == 0;
						list2 = (List<IMultipartFormSection>)(object)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v926 @ X0_v71+8]");
						text = (string)0;
						if (!flag8)
						{
							num10 = (nint)text2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X8_v45 (Il2CppClass<Newtonsoft.Json.Linq.JToken>)+228]");
							array3 = (IMultipartFormSection[])0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X8_v45 (Il2CppClass<Newtonsoft.Json.Linq.JToken>)+230]");
							text = (string)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v926 @ X0_v71+8]");
							JTokenType type = ((JToken)0).Type;
							obj7 = type - 10;
							bool flag6 = type == JTokenType.Null;
							list2 = (List<IMultipartFormSection>)(object)array;
							array4 = (byte[])(object)text3;
							if (!flag6)
							{
								bool flag9 = string.IsNullOrEmpty(prefix);
								bool flag10 = !flag9;
								object obj21 = !flag10;
								string text4 = text3;
								if (obj21 == null)
								{
									string text5 = prefix + (string)obj10 + text3;
									num6 = unchecked((nint)null);
									text4 = text5;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v926 @ X0_v71+8]");
								Walk((JToken)0, text4, sections);
								list2 = sections;
								text = text4;
								array4 = (byte[])(object)text4;
							}
						}
						bool flag11 = enumerator == null;
						enumerator3 = enumerator;
						num7 = num6;
						list = list2;
						obj6 = obj11;
						obj2 = obj12;
						array2 = array4;
						if (!flag11)
						{
							continue;
						}
						goto IL_0c6d;
						IL_083b:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
						array = null;
						goto IL_0f48;
						IL_06f2:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
						array = null;
						goto IL_0eab;
					}
					bool flag12 = enumerator == null;
					num11 = (nint)(&enumerator);
					obj22 = 0;
					num7 = num6;
					num2 = 0.0;
					obj6 = obj11;
					obj2 = obj12;
					array2 = array4;
					obj23 = 0;
					enumerator4 = enumerator;
					obj24 = 0;
					obj25 = obj10;
					obj26 = obj9;
					num12 = (nint)(&enumerator);
					obj22 = 0;
					obj27 = obj8;
					array5 = array;
					num2 = 0.0;
					num13 = num14;
					obj28 = obj4;
					obj29 = 0;
					obj30 = 0;
					if (!flag12)
					{
						goto IL_0a2a;
					}
					goto IL_0fdd;
				}
			}
			object obj31 = typeof(System.IOAsyncCallback) + 4064;
			obj2 = obj31;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v770 @ X10_v6+130]");
			obj6 = 0;
			IMultipartFormSection[] array6 = array3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v770 @ X10_v6+130]");
			bool flag13 = (nint)array6 < 0;
			object obj32 = !flag13;
			object obj33 = ~obj32;
			if (obj33 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v16 (Il2CppClass<Newtonsoft.Json.Linq.JToken>)+C8]");
				nint num15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v770 @ X10_v6+130]");
				object obj34 = num15 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X9_v22-8]");
				if (0 == (nint)obj2)
				{
					int count = ((JContainer)token).Count;
					if (count >= 1)
					{
						object obj35 = "WhiteSmoke" + 2416;
						object obj36 = "[{0}]:{1}" + 352;
						int num16 = 0;
						bool flag14;
						do
						{
							JToken token2 = ((JArray)token).get_Item(num16);
							string text6 = num16.ToString();
							string prefix2 = prefix + (string)obj35 + text6 + (string)obj36;
							Walk(token2, prefix2, sections);
							int num17 = num16 + 1;
							int count2 = ((JContainer)token).Count;
							flag14 = num17 < count2;
							num16 = num17;
						}
						while (flag14);
					}
					return;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v16 (Il2CppClass<Newtonsoft.Json.Linq.JToken>)+228]");
			array3 = (IMultipartFormSection[])0;
			JTokenType type2 = token.Type;
			string s;
			if (type2 == JTokenType.Float)
			{
				object obj37 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 80;
				object obj38 = obj37;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X0_v38+E4]");
				bool flag15 = (nint)0 == 0;
				object obj39 = !flag15;
				if (obj39 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				num14 = (double)token;
				object obj40 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3632;
				object obj41 = obj40;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X0_v41+E4]");
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X0_v41+E4]");
				bool flag16 = (nint)0 == 0;
				object obj42 = !flag16;
				if (obj42 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				CultureInfo invariantCulture = CultureInfo.InvariantCulture;
				s = num2.ToString(invariantCulture);
				array = null;
				text = (string)(object)invariantCulture;
			}
			else
			{
				num = (nint)token;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v3 (Il2CppClass<Newtonsoft.Json.Linq.JToken>)+168]");
				array3 = (IMultipartFormSection[])0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v3 (Il2CppClass<Newtonsoft.Json.Linq.JToken>)+170]");
				text = (string)0;
				s = token.ToString();
				array = (byte[])(object)sections;
				num2 = 0.0;
			}
			Encoding uTF = Encoding.UTF8;
			bool flag17 = uTF == null;
			enumerator = null;
			array2 = (byte[])152993792;
			if (!flag17)
			{
				obj8 = typeof(MemberAchievementClanFeedData) + 1800;
				nint num18 = (nint)uTF;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v18 (Il2CppClass<System.Text.Encoding>)+258]");
				array3 = (IMultipartFormSection[])0;
				byte[] bytes = uTF.GetBytes(s);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				MultipartFormDataSection multipartFormDataSection = default(MultipartFormDataSection);
				multipartFormDataSection..ctor(prefix, bytes);
				bool flag18 = sections == null;
				enumerator = null;
				num7 = unchecked((nint)null);
				array = bytes;
				text = prefix;
				num = num18;
				array2 = bytes;
				if (!flag18)
				{
					object obj43 = (nint)0 + (nint)72;
					num = (nint)obj43;
					int version = sections._version + 1;
					sections._version = version;
					array3 = sections._items;
					bool flag19 = sections._items == null;
					enumerator = null;
					num7 = unchecked((nint)null);
					array = bytes;
					text = prefix;
					array2 = bytes;
					if (!flag19)
					{
						bool flag20 = sections._size < array3.Length;
						object obj44 = !flag20;
						if (obj44 == null)
						{
							int size = sections._size + 1;
							sections._size = size;
							object obj45 = sections._items + sections._size;
							object obj46 = obj45 + 32;
							obj46 = multipartFormDataSection;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						}
						else
						{
							((List<object>)(object)sections).AddWithResize((object)multipartFormDataSection);
						}
						return;
					}
				}
			}
		}
		goto IL_0e50;
		IL_1091:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v849 @ X0_v18+8]");
		text = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v849 @ X0_v18] (should have been resolved before IL gen)");
		obj25 = obj10;
		obj26 = obj9;
		num12 = num11;
		num6 = num7;
		obj27 = obj8;
		num13 = num14;
		obj28 = obj4;
		obj11 = obj6;
		obj12 = obj2;
		array4 = array2;
		obj29 = obj23;
		obj30 = obj24;
		goto IL_0fdd;
		IL_0c83:
		NullReferenceException ex = new NullReferenceException();
		num7 = num6;
		obj6 = obj11;
		obj2 = obj12;
		array2 = array4;
		goto IL_0cb1;
		IL_0ae2:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		array5 = null;
		goto IL_1091;
		IL_0a2a:
		object obj47 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
		nint num19 = (nint)enumerator4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v738 @ X8_v10 (Il2CppClass<System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<System.String, Newtonsoft.Json.Linq.JToken>>>)+12E]");
		array3 = (IMultipartFormSection[])0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v738 @ X8_v10 (Il2CppClass<System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<System.String, Newtonsoft.Json.Linq.JToken>>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0ae2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v738 @ X8_v10 (Il2CppClass<System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<System.String, Newtonsoft.Json.Linq.JToken>>>)+B0]");
		object obj48 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v826 @ X10_v10-8]");
			obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v826 @ X10_v10-8]");
			if (0 == (nint)obj47)
			{
				break;
			}
			obj2 = obj48 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v738 @ X8_v10 (Il2CppClass<System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<System.String, Newtonsoft.Json.Linq.JToken>>>)+12E]");
			array3 = (IMultipartFormSection[])(-1);
			bool flag21 = (nint)array3 != 1;
			obj48 = obj2;
			if (flag21)
			{
				continue;
			}
			goto IL_0ae2;
		}
		array3 = (IMultipartFormSection[])obj48;
		object obj49 = num19 + obj48;
		object obj50 = obj49 + 312;
		array5 = array;
		obj2 = obj48;
		goto IL_1091;
		IL_0cb1:
		num11 = (nint)(&enumerator);
		obj22 = 0;
		num2 = 0.0;
		goto IL_0e50;
		IL_0e50:
		throw new NullReferenceException();
		IL_0c6d:
		NullReferenceException ex2 = new NullReferenceException();
		array = (byte[])(object)list;
		goto IL_0cb1;
		IL_0fdd:
		object obj52 = default(object);
		while (true)
		{
			bool flag22 = obj30 == null;
			object obj51 = !flag22;
			obj10 = obj25;
			obj9 = obj26;
			num11 = num12;
			num7 = num6;
			obj8 = obj27;
			array = array5;
			num14 = num13;
			obj4 = obj28;
			obj6 = obj11;
			obj2 = obj12;
			array2 = array4;
			if (obj51 != null)
			{
				OutOfMemoryException ex3 = new OutOfMemoryException();
				if ((nint)text == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
					obj24 = obj52;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
					bool flag23 = enumerator == null;
					object obj53 = !flag23;
					obj22 = obj52;
					obj23 = 1;
					enumerator4 = enumerator;
					if (obj53 == null)
					{
						obj25 = obj10;
						obj26 = obj9;
						num12 = num11;
						obj22 = obj52;
						num6 = num7;
						obj27 = obj8;
						array5 = array;
						num13 = num14;
						obj28 = obj4;
						obj11 = obj6;
						obj12 = obj2;
						array4 = array2;
						obj29 = 1;
						obj30 = obj52;
						continue;
					}
					goto IL_0a2a;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
				return;
			}
			break;
		}
		object obj54 = obj29 & 1;
		bool flag24 = obj54 == null;
		object obj55 = !flag24;
		obj10 = obj25;
		obj9 = obj26;
		num11 = num12;
		num7 = num6;
		obj8 = obj27;
		array = array5;
		num14 = num13;
		obj4 = obj28;
		obj6 = obj11;
		obj2 = obj12;
		array2 = array4;
		if (obj55 == null)
		{
			return;
		}
		goto IL_0e50;
	}
}
