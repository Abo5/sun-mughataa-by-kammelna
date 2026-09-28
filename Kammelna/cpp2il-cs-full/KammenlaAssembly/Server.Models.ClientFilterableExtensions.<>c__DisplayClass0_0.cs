using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using UnityEngine;
using UnityEngine.TextCore;

namespace Server.Models;

public static class ClientFilterableExtensions
{
	private sealed class <>c__DisplayClass0_0
	{
		public FilterableClientModel client;

		internal bool <PassesFilters>b__0(ClientFilter filter)
		{
			//IL_0043: Expected I4, but got O
			if (filter != null)
			{
				return filter.Check(client);
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public static bool PassesFilters(IClientFilterable item, FilterableClientModel client)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0283: Expected I4, but got O
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_0072: Expected I, but got O
		//IL_0082: Expected O, but got I
		//IL_0126: Expected I, but got O
		//IL_00bd: Expected O, but got I
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected O, but got Unknown
		//IL_0154: Expected O, but got I
		//IL_015d: Expected I, but got O
		//IL_016d: Expected O, but got I
		//IL_01f8: Expected I, but got O
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected O, but got Unknown
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected O, but got Unknown
		//IL_023c: Expected O, but got I4
		//IL_0320: Expected I, but got O
		//IL_01a8: Expected O, but got I
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected O, but got Unknown
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Expected O, but got Unknown
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected O, but got Unknown
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected O, but got Unknown
		object obj = typeof(CardUtils.<>c) + 1776;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj4;
		if (obj2 != null)
		{
			object obj3 = obj2 + 16;
			obj3 = client;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			if (item != null)
			{
				obj4 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 1568;
				nint num = (nint)item;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v3 (Il2CppClass<Server.Models.IClientFilterable>)+12E]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v3 (Il2CppClass<Server.Models.IClientFilterable>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00fe;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v3 (Il2CppClass<Server.Models.IClientFilterable>)+B0]");
				object obj6 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X10_v12-8]");
					if (0 == (nint)obj4)
					{
						break;
					}
					obj6 += 16;
					obj5--;
					if ((nint)obj5 != 1)
					{
						continue;
					}
					goto IL_00fe;
				}
				object obj7 = num + obj6;
				object obj8 = obj7 + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v228 @ X0_v26] (should have been resolved before IL gen)");
				object obj9 = default(object);
				bool flag = obj9 == null;
				object obj10 = !flag;
				if (obj10 != null)
				{
					goto IL_0134;
				}
				goto IL_024a;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_01e9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		nint num2 = unchecked((nint)null);
		goto IL_02fb;
		IL_02fb:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v317 @ X0_v12] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, bool> func = default(Func<object, bool>);
		object obj11;
		func..ctor(obj2, (IntPtr)obj11);
		IEnumerable<object> source = default(IEnumerable<object>);
		return Enumerable.All(source, func);
		IL_00fe:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v198 @ X0_v23] (should have been resolved before IL gen)");
		object obj12 = default(object);
		bool flag2 = obj12 == null;
		num2 = unchecked((nint)null);
		if (!flag2)
		{
			goto IL_0134;
		}
		goto IL_024a;
		IL_024a:
		return true;
		IL_0134:
		object obj13 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 792;
		obj11 = (nint)0 + (nint)1120;
		nint num3 = (nint)item;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X8_v6 (Il2CppClass<Server.Models.IClientFilterable>)+12E]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X8_v6 (Il2CppClass<Server.Models.IClientFilterable>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_01e9;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X8_v6 (Il2CppClass<Server.Models.IClientFilterable>)+B0]");
		object obj15 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X10_v7-8]");
			if (0 == (nint)obj4)
			{
				break;
			}
			obj15 += 16;
			obj14--;
			if ((nint)obj14 != 1)
			{
				continue;
			}
			goto IL_01e9;
		}
		object obj16 = num3 + obj15;
		object obj17 = obj16 + 312;
		goto IL_02fb;
	}
}
