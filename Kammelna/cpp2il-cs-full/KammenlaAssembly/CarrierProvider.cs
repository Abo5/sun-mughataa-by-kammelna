using System;
using System.Data.SqlTypes;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Unity.Properties;
using Unity.Services.Authentication.Shared;
using UnityEngine;

public class CarrierProvider
{
	[PreserveSig]
	private static extern string getCarrierName();

	public static string GetCarrierProviderName()
	{
		//IL_0009: Expected O, but got I4
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0042: Expected O, but got I
		//IL_0342: Expected O, but got I4
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected O, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected O, but got Unknown
		//IL_0174: Expected O, but got I4
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_019d: Expected O, but got I
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected O, but got Unknown
		//IL_01f1: Expected O, but got I4
		//IL_0217: Expected O, but got I4
		//IL_022d: Expected I, but got O
		//IL_023d: Expected O, but got I
		//IL_0266: Expected O, but got I
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Expected O, but got Unknown
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Expected O, but got Unknown
		object obj = 152981504;
		object obj2 = "Network Authentication Required" + 288;
		object obj3 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5F71]");
		object obj4 = (nint)0 & (nint)1;
		string result;
		string text;
		if (obj4 != null)
		{
			result = (string)obj2;
			object obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v7+E4]");
			bool flag = (nint)0 == 0;
			text = (string)obj2;
			if (!flag)
			{
				goto IL_009c;
			}
		}
		else
		{
			_ = 1;
			result = (string)obj2;
			object obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			text = (string)obj2;
			if (obj6 != null)
			{
				goto IL_009c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		RuntimePlatform platform = Application.platform;
		bool flag3 = platform != RuntimePlatform.IPhonePlayer;
		result = text;
		RuntimePlatform runtimePlatform = platform;
		if (flag3)
		{
			goto IL_00ca;
		}
		goto IL_03a0;
		IL_03db:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_03e9;
		IL_03e9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		return (string)(object)new OutOfMemoryException();
		IL_00ca:
		if (platform == RuntimePlatform.Android)
		{
			object obj7 = typeof(SqlSingle[]) + 3568;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object className = "com.unity.services.authentication.profile" + 88;
			AndroidJavaClass androidJavaClass = default(AndroidJavaClass);
			androidJavaClass..ctor((string)className);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj8 = "clear_mass_tournaments" + 3976;
			string text2 = (string)obj8;
			AndroidJavaClass androidJavaClass2 = default(AndroidJavaClass);
			androidJavaClass2..ctor((string)obj8);
			bool flag4 = androidJavaClass == null;
			object obj9 = 0;
			if (!flag4)
			{
				object fieldName = "com.unity.services.authentication.profile" + 2600;
				object obj10 = (nint)0 + (nint)1008;
				obj9 = obj10;
				object obj11 = androidJavaClass.GetStatic<object>((string)fieldName);
				object obj12 = typeof(TypeConverter<ushort, char>) + 3400;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
				object[] array = default(object[]);
				bool flag5 = array == null;
				text2 = (string)1;
				if (!flag5)
				{
					bool flag6 = obj11 == null;
					string text3 = (string)1;
					if (!flag6)
					{
						nint num = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v24 (Il2CppClass<System.Object[]>)+40]");
						text3 = (string)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag7 = ex == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v24 (Il2CppClass<System.Object[]>)+40]");
						text2 = (string)0;
						if (flag7)
						{
							goto IL_03e9;
						}
					}
					bool flag8 = array.Length == 0;
					text2 = text3;
					if (flag8)
					{
						goto IL_03db;
					}
					object obj13 = array + 32;
					obj13 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					bool flag9 = androidJavaClass2 == null;
					text2 = (string)obj11;
					if (!flag9)
					{
						object methodName = "fetch_products" + 3592;
						return (string)androidJavaClass2.CallStatic<object>((string)methodName, array);
					}
				}
			}
			NullReferenceException ex2 = new NullReferenceException();
			goto IL_03db;
		}
		return result;
		IL_009c:
		platform = Application.platform;
		bool flag10 = platform == RuntimePlatform.IPhonePlayer;
		runtimePlatform = platform;
		if (!flag10)
		{
			goto IL_00ca;
		}
		goto IL_03a0;
		IL_03a0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21040");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1FA0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1FB0");
		string result2 = default(string);
		return result2;
	}
}
