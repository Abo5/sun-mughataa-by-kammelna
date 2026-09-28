using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq.JsonPath;
using UnityEngine;

namespace Util.JsonConvertors;

public class ColorConverter : JsonConverter
{
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
	{
		//IL_0064: Expected I, but got O
		//IL_0074: Expected O, but got I
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		//IL_00ad: Expected O, but got I4
		//IL_00bd: Expected O, but got I
		JsonReader jsonReader = default(JsonReader);
		if (jsonReader != null)
		{
			JsonToken tokenType = jsonReader.TokenType;
			if (tokenType != JsonToken.Null)
			{
				JsonToken tokenType2 = jsonReader.TokenType;
				if (tokenType2 == JsonToken.String)
				{
					nint num = (nint)jsonReader;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v7 (Il2CppClass<Newtonsoft.Json.JsonReader>)+250]");
					JsonReader jsonReader2 = (JsonReader)0;
					string value = (string)jsonReader.Value;
					if (value != null)
					{
						object obj = 153100288 + 1024;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v14+90]");
						jsonReader2 = (JsonReader)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v14+90]");
						if (value != null)
						{
							goto IL_0127;
						}
					}
					Color? color = FromHtmlColor(value);
					object obj2 = typeof(List<Tween>) + 2352;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
					object result = default(object);
					return result;
				}
			}
			return null;
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_0127;
		IL_0127:
		InvalidCastException ex2 = new InvalidCastException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		object result2 = default(object);
		return result2;
	}

	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0029: Expected I, but got O
		//IL_0113: Expected I, but got O
		//IL_0123: Expected O, but got I
		//IL_0133: Expected O, but got I
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected O, but got Unknown
		//IL_01ac: Expected O, but got I
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		object obj = default(object);
		if (obj != null)
		{
			object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1784;
			string text = (string)obj2;
			nint num = (nint)obj;
			if (obj != obj2)
			{
				object obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 960;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj4 = "Error reading data from socket: " + 1176;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
				JsonSerializationException ex = default(JsonSerializationException);
				string message = default(string);
				ex..ctor(message);
				object obj5 = (nint)0 + (nint)2624;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
				throw new OutOfMemoryException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v9 (Il2CppClass<System.Object>)+40]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X1_v2 (System.String)+40]");
			if (num2 != 0)
			{
				throw new InvalidCastException();
			}
			object obj6 = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 2912;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1960");
			Color color = default(Color);
			string text2 = ColorUtility.ToHtmlStringRGB(ref color);
			string value2 = (string)obj6 + text2;
			bool flag = writer == null;
			text = text2;
			if (!flag)
			{
				writer.WriteValue(value2);
				return;
			}
		}
		else
		{
			bool flag2 = writer == null;
			string text = (string)(object)writer;
			if (!flag2)
			{
				nint num3 = (nint)writer;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v6 (Il2CppClass<Newtonsoft.Json.JsonWriter>)+658]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v6 (Il2CppClass<Newtonsoft.Json.JsonWriter>)+660]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v116 @ X2_v5 (should have been resolved before IL gen)");
			}
		}
		throw new NullReferenceException();
	}

	public override bool CanConvert(Type objectType)
	{
		//IL_000f: Expected O, but got I4
		//IL_00fe: Expected O, but got I4
		//IL_010e: Expected O, but got I
		//IL_0130: Expected O, but got I4
		//IL_0078: Expected O, but got I4
		//IL_0088: Expected O, but got I
		//IL_00aa: Expected O, but got I4
		object handle = 147423232 + 2056;
		object obj = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X21_v4+E0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)handle);
		if (objectType == typeFromHandle)
		{
			return true;
		}
		object handle2 = 147423232 + 232;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X21_v4+E0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v8+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)handle2);
		return objectType == typeFromHandle2;
	}

	public unsafe static Color? FromHtmlColor(string htmlColor)
	{
		//IL_0160: Expected O, but got I4
		//IL_000e: Expected O, but got I4
		//IL_0057: Expected O, but got I4
		//IL_006f: Expected O, but got I
		//IL_0077: Expected native int or pointer, but got O
		//IL_00c7: Expected O, but got I4
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_011e: Expected O, but got I4
		bool flag = string.IsNullOrEmpty(htmlColor);
		bool flag2 = !flag;
		Color? result = (Color?)(object)flag;
		if (flag2)
		{
			if (ColorUtility.TryParseHtmlString(htmlColor, out var color))
			{
				goto IL_004e;
			}
			if (htmlColor == null)
			{
				return (Color?)new NullReferenceException();
			}
			char c = htmlColor.get_Chars(0);
			bool flag3 = c == '#';
			result = (Color?)(object)c;
			if (!flag3)
			{
				object obj = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 2912;
				string htmlString = (string)obj + htmlColor;
				bool flag4 = ColorUtility.TryParseHtmlString(htmlString, out color);
				bool flag5 = !flag4;
				result = (Color?)(object)flag4;
				if (!flag5)
				{
					goto IL_004e;
				}
			}
		}
		Color? color2 = (Color?)(object)0;
		_ = 0;
		_ = 0;
		return result;
		IL_004e:
		color2 = (Color?)(object)0;
		_ = 0;
		_ = 0;
		object value = (nint)0 + (nint)2112;
		*(Color?*)(nint)color2 = (Color)value;
		return color2;
	}
}
