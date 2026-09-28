using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Formats.Asn1;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Unity.Services.Authentication.Shared;
using UnityEngine.AdaptivePerformance;

public static class SuitMethods
{
	public static IEnumerable<Suit> GetAll()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		object obj = typeof(SqlSingle[]) + 56;
		object fldHandle = (nint)0 + (nint)1864;
		object obj2 = typeof(List<AdaptivePerformanceScaler>) + 3760;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		Array array = default(Array);
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)fldHandle);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<System.Int32Enum> list = default(List<System.Int32Enum>);
		list..ctor((IEnumerable<System.Int32Enum>)array);
		return (IEnumerable<Suit>)list;
	}

	public static string GetSuitLocalizationString(string suitFriendlyName)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_013a: Expected O, but got I4
		//IL_00e9: Expected O, but got I
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_004e: Expected O, but got I4
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_0096: Expected O, but got I4
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		object obj = "rightCtrl" + 768;
		bool flag = suitFriendlyName == (string)obj;
		bool flag2 = !flag;
		object obj2 = !flag2;
		if (obj2 == null)
		{
			object obj3 = "getSecondRescanTask" + 2152;
			bool flag3 = suitFriendlyName == (string)obj3;
			bool flag4 = !flag3;
			object obj4 = !flag4;
			if (obj4 == null)
			{
				object obj5 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 1976;
				bool flag5 = suitFriendlyName == (string)obj5;
				bool flag6 = !flag5;
				object obj6 = !flag6;
				if (obj6 == null)
				{
					object obj7 = "com.unity.services.authentication.profile" + 2776;
					if (!(suitFriendlyName == (string)obj7))
					{
						return suitFriendlyName;
					}
				}
			}
		}
		object obj8 = (nint)0 + (nint)1704;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D71ADC");
		Suit suit = default(Suit);
		return GetSuitLocalizationString(suit);
	}

	public static string GetSuitLocalizationString(Suit suit)
	{
		//IL_00f6: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_0014: Expected O, but got I4
		//IL_0024: Expected O, but got I
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_00bf: Expected O, but got I
		bool flag = suit < (Suit)5;
		object obj = !flag;
		if (obj == null)
		{
			object obj2 = 139821056 + 3536;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+suit @ X0 (Suit)*8]");
			return (string)0;
		}
		object obj3 = typeof(System.Formats.Asn1.SetOfValueComparer) + 3136;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj4 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj5 = "startPosition" + 1344;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
		string paramName = default(string);
		object actualValue = default(object);
		ex..ctor(paramName, actualValue, null);
		object obj6 = (nint)0 + (nint)2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		return (string)(object)new OutOfMemoryException();
	}

	public static string GetSuitIconUnicode(Suit suit)
	{
		//IL_0057: Expected O, but got I4
		//IL_0065: Expected O, but got I4
		//IL_007f: Expected O, but got I4
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0014: Expected O, but got I4
		//IL_0024: Expected O, but got I
		bool flag = suit < Suit.DIAMONDS;
		object obj = !flag;
		object obj2 = suit - 3;
		bool flag2 = obj2 == null;
		object obj3 = !flag2;
		object obj4 = obj & obj3;
		if (obj4 == null)
		{
			object obj5 = 139821056 + 3576;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v6+suit @ X0 (Suit)*8]");
			return (string)0;
		}
		return "Network Authentication Required" + 408;
	}
}
