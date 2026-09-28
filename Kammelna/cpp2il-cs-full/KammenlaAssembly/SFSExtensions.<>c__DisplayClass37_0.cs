using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Dynamic.Utils;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Newtonsoft.Json.Linq.JsonPath;
using SFSLitJson;
using Sfs2X.Core;
using Sfs2X.Entities;
using Sfs2X.Entities.Data;
using Sfs2X.Entities.Variables;
using Unity.Properties;
using UnityEngine.AdaptivePerformance;
using UnityEngine.InputSystem.XR;
using UnityEngine.TextCore;
using Util;

public static class SFSExtensions
{
	private sealed class <>c__DisplayClass35_0
	{
		public ISFSObject obj;

		public string varName;

		public int[] defaultValue;

		internal int[] <Get>b__0()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0021: Expected I, but got O
			//IL_0031: Expected O, but got I
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Expected O, but got Unknown
			//IL_006c: Expected O, but got I
			//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c6: Expected O, but got Unknown
			//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d3: Expected O, but got Unknown
			//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e1: Expected O, but got Unknown
			//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f9: Expected O, but got Unknown
			//IL_0213: Expected O, but got I4
			//IL_011d: Expected I, but got O
			//IL_012d: Expected O, but got I
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected O, but got Unknown
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Expected O, but got Unknown
			//IL_0168: Expected O, but got I
			//IL_0231: Unknown result type (might be due to invalid IL or missing references)
			//IL_0236: Expected O, but got Unknown
			//IL_023e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0243: Expected O, but got Unknown
			//IL_024c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0251: Expected O, but got Unknown
			//IL_0176: Unknown result type (might be due to invalid IL or missing references)
			//IL_017b: Expected O, but got Unknown
			//IL_0184: Unknown result type (might be due to invalid IL or missing references)
			//IL_0189: Expected O, but got Unknown
			ISFSObject iSFSObject = this.obj;
			object obj;
			if (this.obj != null)
			{
				obj = typeof(System.IOAsyncCallback) + 976;
				nint num = (nint)iSFSObject;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00ad;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
				object obj3 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X10_v13-8]");
					if (0 == (nint)obj)
					{
						break;
					}
					obj3 += 16;
					obj2--;
					if ((nint)obj2 != 1)
					{
						continue;
					}
					goto IL_00ad;
				}
				object obj4 = obj3 + 1;
				object obj5 = num + obj4;
				object obj6 = obj5 + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v234 @ X0_v16] (should have been resolved before IL gen)");
				object obj8 = default(object);
				object obj7 = obj8 & 1;
				bool flag = obj7 == null;
				object obj9 = !flag;
				if (obj9 != null)
				{
					goto IL_00ec;
				}
				goto IL_0221;
			}
			goto IL_0256;
			IL_0221:
			return defaultValue;
			IL_00ec:
			ISFSObject iSFSObject2 = this.obj;
			if (this.obj == null)
			{
				goto IL_0256;
			}
			nint num2 = (nint)iSFSObject2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_01a9;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
			object obj11 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X10_v8-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj11 += 16;
				obj10--;
				if ((nint)obj10 != 1)
				{
					continue;
				}
				goto IL_01a9;
			}
			object obj12 = obj11 + 23;
			object obj13 = num2 + obj12;
			object obj14 = obj13 + 312;
			goto IL_02d5;
			IL_0256:
			return (int[])(object)new NullReferenceException();
			IL_02d5:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v305 @ X0_v7] (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
			IL_01a9:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_02d5;
			IL_00ad:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v130 @ X0_v13] (should have been resolved before IL gen)");
			object obj16 = default(object);
			object obj15 = obj16 & 1;
			if (obj15 != null)
			{
				goto IL_00ec;
			}
			goto IL_0221;
		}
	}

	private sealed class <>c__DisplayClass36_0
	{
		public ISFSObject obj;

		public string varName;

		public string[] defaultValue;

		internal string[] <Get>b__0()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0021: Expected I, but got O
			//IL_0031: Expected O, but got I
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Expected O, but got Unknown
			//IL_006c: Expected O, but got I
			//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c6: Expected O, but got Unknown
			//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d3: Expected O, but got Unknown
			//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e1: Expected O, but got Unknown
			//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f9: Expected O, but got Unknown
			//IL_0213: Expected O, but got I4
			//IL_011d: Expected I, but got O
			//IL_012d: Expected O, but got I
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected O, but got Unknown
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Expected O, but got Unknown
			//IL_0168: Expected O, but got I
			//IL_0231: Unknown result type (might be due to invalid IL or missing references)
			//IL_0236: Expected O, but got Unknown
			//IL_023e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0243: Expected O, but got Unknown
			//IL_024c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0251: Expected O, but got Unknown
			//IL_0176: Unknown result type (might be due to invalid IL or missing references)
			//IL_017b: Expected O, but got Unknown
			//IL_0184: Unknown result type (might be due to invalid IL or missing references)
			//IL_0189: Expected O, but got Unknown
			ISFSObject iSFSObject = this.obj;
			object obj;
			if (this.obj != null)
			{
				obj = typeof(System.IOAsyncCallback) + 976;
				nint num = (nint)iSFSObject;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00ad;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
				object obj3 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X10_v13-8]");
					if (0 == (nint)obj)
					{
						break;
					}
					obj3 += 16;
					obj2--;
					if ((nint)obj2 != 1)
					{
						continue;
					}
					goto IL_00ad;
				}
				object obj4 = obj3 + 1;
				object obj5 = num + obj4;
				object obj6 = obj5 + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v234 @ X0_v16] (should have been resolved before IL gen)");
				object obj8 = default(object);
				object obj7 = obj8 & 1;
				bool flag = obj7 == null;
				object obj9 = !flag;
				if (obj9 != null)
				{
					goto IL_00ec;
				}
				goto IL_0221;
			}
			goto IL_0256;
			IL_0221:
			return defaultValue;
			IL_00ec:
			ISFSObject iSFSObject2 = this.obj;
			if (this.obj == null)
			{
				goto IL_0256;
			}
			nint num2 = (nint)iSFSObject2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_01a9;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
			object obj11 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X10_v8-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj11 += 16;
				obj10--;
				if ((nint)obj10 != 1)
				{
					continue;
				}
				goto IL_01a9;
			}
			object obj12 = obj11 + 27;
			object obj13 = num2 + obj12;
			object obj14 = obj13 + 312;
			goto IL_02d5;
			IL_0256:
			return (string[])(object)new NullReferenceException();
			IL_02d5:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v305 @ X0_v7] (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
			IL_01a9:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_02d5;
			IL_00ad:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v130 @ X0_v13] (should have been resolved before IL gen)");
			object obj16 = default(object);
			object obj15 = obj16 & 1;
			if (obj15 != null)
			{
				goto IL_00ec;
			}
			goto IL_0221;
		}
	}

	private sealed class <>c__DisplayClass37_0
	{
		public ISFSObject obj;

		public string varName;

		public DateTime? defaultValue;

		internal DateTime? <Get>b__0()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0021: Expected I, but got O
			//IL_0031: Expected O, but got I
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Expected O, but got Unknown
			//IL_006c: Expected O, but got I
			//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c6: Expected O, but got Unknown
			//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d3: Expected O, but got Unknown
			//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e1: Expected O, but got Unknown
			//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f9: Expected O, but got Unknown
			//IL_0213: Expected O, but got I4
			//IL_011d: Expected I, but got O
			//IL_012d: Expected O, but got I
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected O, but got Unknown
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Expected O, but got Unknown
			//IL_0322: Unknown result type (might be due to invalid IL or missing references)
			//IL_0327: Expected O, but got Unknown
			//IL_0351: Expected O, but got I4
			//IL_0168: Expected O, but got I
			//IL_0231: Unknown result type (might be due to invalid IL or missing references)
			//IL_0236: Expected O, but got Unknown
			//IL_023e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0243: Expected O, but got Unknown
			//IL_024c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0251: Expected O, but got Unknown
			//IL_0176: Unknown result type (might be due to invalid IL or missing references)
			//IL_017b: Expected O, but got Unknown
			//IL_0184: Unknown result type (might be due to invalid IL or missing references)
			//IL_0189: Expected O, but got Unknown
			ISFSObject iSFSObject = this.obj;
			object obj;
			if (this.obj != null)
			{
				obj = typeof(System.IOAsyncCallback) + 976;
				nint num = (nint)iSFSObject;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00ad;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
				object obj3 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X10_v13-8]");
					if (0 == (nint)obj)
					{
						break;
					}
					obj3 += 16;
					obj2--;
					if ((nint)obj2 != 1)
					{
						continue;
					}
					goto IL_00ad;
				}
				object obj4 = obj3 + 1;
				object obj5 = num + obj4;
				object obj6 = obj5 + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v248 @ X0_v24] (should have been resolved before IL gen)");
				object obj8 = default(object);
				object obj7 = obj8 & 1;
				bool flag = obj7 == null;
				object obj9 = !flag;
				if (obj9 != null)
				{
					goto IL_00ec;
				}
				goto IL_0221;
			}
			goto IL_028a;
			IL_0221:
			return defaultValue;
			IL_00ec:
			ISFSObject iSFSObject2 = this.obj;
			if (this.obj == null)
			{
				goto IL_028a;
			}
			nint num2 = (nint)iSFSObject2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_01a9;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
			object obj11 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X10_v8-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj11 += 16;
				obj10--;
				if ((nint)obj10 != 1)
				{
					continue;
				}
				goto IL_01a9;
			}
			object obj12 = obj11 + 15;
			object obj13 = num2 + obj12;
			object obj14 = obj13 + 312;
			goto IL_0309;
			IL_028a:
			return (DateTime?)new NullReferenceException();
			IL_01a9:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_0309;
			IL_0309:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v321 @ X0_v7] (should have been resolved before IL gen)");
			object obj15 = typeof(DataRelation) + 824;
			object obj16 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X0_v10+E4]");
			bool flag2 = (nint)0 == 0;
			object obj17 = !flag2;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			double unixTimeStamp = default(double);
			return DateTimeUtil.FromTimeStamp(unixTimeStamp);
			IL_00ad:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v136 @ X0_v21] (should have been resolved before IL gen)");
			object obj19 = default(object);
			object obj18 = obj19 & 1;
			if (obj18 != null)
			{
				goto IL_00ec;
			}
			goto IL_0221;
		}
	}

	private sealed class <>c__DisplayClass39_0<T> where T : Enum
	{
		public T defaultValue;

		internal T <GetEnumList>b__0(int i)
		{
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D712E8");
			T result = default(T);
			return result;
		}
	}

	public static string GetVariable(User user, string varName, string defaultValue)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_006c: Expected O, but got I
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		if (user != null)
		{
			object obj = typeof(UsageHint) + 8;
			nint num = (nint)user;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00ad;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+B0]");
			object obj3 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X10_v5-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj3 += 16;
				obj2--;
				if ((nint)obj2 != 1)
				{
					continue;
				}
				goto IL_00ad;
			}
			object obj4 = obj3 + 21;
			object obj5 = num + obj4;
			object obj6 = obj5 + 312;
			goto IL_0139;
		}
		return (string)(object)new NullReferenceException();
		IL_0139:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v165 @ X0_v3] (should have been resolved before IL gen)");
		Variable variable = default(Variable);
		return Get(variable, defaultValue);
		IL_00ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0139;
	}

	public static bool GetVariable(User user, string varName, bool defaultValue)
	{
		//IL_00f8: Expected I4, but got O
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_006c: Expected O, but got I
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		if (user != null)
		{
			object obj = typeof(UsageHint) + 8;
			nint num = (nint)user;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00ad;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+B0]");
			object obj3 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X10_v5-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj3 += 16;
				obj2--;
				if ((nint)obj2 != 1)
				{
					continue;
				}
				goto IL_00ad;
			}
			object obj4 = obj3 + 21;
			object obj5 = num + obj4;
			object obj6 = obj5 + 312;
			goto IL_0139;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0139:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v165 @ X0_v3] (should have been resolved before IL gen)");
		Variable variable = default(Variable);
		return Get(variable, defaultValue);
		IL_00ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0139;
	}

	public static int GetVariable(User user, string varName, int defaultValue)
	{
		//IL_00f8: Expected I4, but got O
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_006c: Expected O, but got I
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		if (user != null)
		{
			object obj = typeof(UsageHint) + 8;
			nint num = (nint)user;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00ad;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+B0]");
			object obj3 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X10_v5-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj3 += 16;
				obj2--;
				if ((nint)obj2 != 1)
				{
					continue;
				}
				goto IL_00ad;
			}
			object obj4 = obj3 + 21;
			object obj5 = num + obj4;
			object obj6 = obj5 + 312;
			goto IL_0139;
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
		IL_0139:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v165 @ X0_v3] (should have been resolved before IL gen)");
		Variable variable = default(Variable);
		return Get(variable, defaultValue);
		IL_00ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0139;
	}

	public static double GetVariable(User user, string varName, double defaultValue)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_006c: Expected O, but got I
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		object obj = typeof(UsageHint) + 8;
		nint num = (nint)user;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00ad;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+B0]");
		object obj3 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X10_v5-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj3 += 16;
			obj2--;
			if ((nint)obj2 != 1)
			{
				continue;
			}
			goto IL_00ad;
		}
		object obj4 = obj3 + 21;
		object obj5 = num + obj4;
		object obj6 = obj5 + 312;
		goto IL_010e;
		IL_00ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_010e;
		IL_010e:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v175 @ X0_v3] (should have been resolved before IL gen)");
		Variable variable = default(Variable);
		return Get(variable, defaultValue);
	}

	public static DateTime? GetVariable(User user, string varName, DateTime? defaultValue)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_006c: Expected O, but got I
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		if (user != null)
		{
			object obj = typeof(UsageHint) + 8;
			nint num = (nint)user;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00ad;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+B0]");
			object obj3 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X10_v5-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj3 += 16;
				obj2--;
				if ((nint)obj2 != 1)
				{
					continue;
				}
				goto IL_00ad;
			}
			object obj4 = obj3 + 21;
			object obj5 = num + obj4;
			object obj6 = obj5 + 312;
			goto IL_0139;
		}
		return (DateTime?)new NullReferenceException();
		IL_0139:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v174 @ X0_v3] (should have been resolved before IL gen)");
		Variable variable = default(Variable);
		return Get(variable, defaultValue);
		IL_00ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0139;
	}

	public static T GetVariable<T>(User user, string varName, Func<UserVariable, T> modeler) where T : class
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_0052: Expected I, but got O
		//IL_0062: Expected O, but got I
		//IL_009d: Expected O, but got I
		//IL_011f: Expected O, but got I
		//IL_012f: Expected O, but got I
		//IL_013f: Expected O, but got I
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected O, but got Unknown
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected O, but got Unknown
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected O, but got Unknown
		//IL_0196: Expected O, but got I4
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		nint num;
		object obj3 = default(object);
		if (user != null)
		{
			object obj = typeof(UsageHint) + 8;
			num = (nint)user;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v6 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v6 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00de;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v6 (Il2CppClass<Sfs2X.Entities.User>)+B0]");
			obj3 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X10_v6-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj3 += 16;
				obj2--;
				if ((nint)obj2 != 1)
				{
					continue;
				}
				goto IL_00de;
			}
			goto IL_0149;
		}
		goto IL_01a4;
		IL_00de:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v135 @ X0_v7] (should have been resolved before IL gen)");
		if (modeler != null)
		{
			goto IL_010f;
		}
		goto IL_01a4;
		IL_010f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [modeler @ X2 (System.Func`2<Sfs2X.Entities.Variables.UserVariable, T>)+18]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [modeler @ X2 (System.Func`2<Sfs2X.Entities.Variables.UserVariable, T>)+40]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [modeler @ X2 (System.Func`2<Sfs2X.Entities.Variables.UserVariable, T>)+28]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v153 @ X3_v1 (should have been resolved before IL gen)");
		goto IL_0149;
		IL_0149:
		object obj7 = obj3 + 21;
		object obj8 = num + obj7;
		object obj9 = obj8 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v199 @ X0_v10] (should have been resolved before IL gen)");
		bool flag = modeler == null;
		object obj10 = !flag;
		if (obj10 != null)
		{
			goto IL_010f;
		}
		goto IL_01a4;
		IL_01a4:
		return (T)(object)new NullReferenceException();
	}

	public static T GetVariable<T>(User user, string varName, T defaultValue) where T : Enum
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_0052: Expected I, but got O
		//IL_0062: Expected O, but got I
		//IL_009d: Expected O, but got I
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		if (user != null)
		{
			object obj = typeof(UsageHint) + 8;
			nint num = (nint)user;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00de;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+B0]");
			object obj3 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X10_v5-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj3 += 16;
				obj2--;
				if ((nint)obj2 != 1)
				{
					continue;
				}
				goto IL_00de;
			}
			object obj4 = obj3 + 21;
			object obj5 = num + obj4;
			object obj6 = obj5 + 312;
			goto IL_014d;
		}
		return (T)new NullReferenceException();
		IL_014d:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v169 @ X0_v3] (should have been resolved before IL gen)");
		Variable variable = default(Variable);
		return Get(variable, defaultValue);
		IL_00de:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_014d;
	}

	public static string GetVariableDump(Room room)
	{
		//IL_085f: Expected O, but got I4
		//IL_0867: Expected O, but got I
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_00c8: Expected O, but got I4
		//IL_08ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b1: Expected O, but got Unknown
		//IL_08bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c0: Expected O, but got Unknown
		//IL_08d2: Expected I, but got O
		//IL_08e2: Expected O, but got I
		//IL_006c: Expected O, but got I
		//IL_07db: Expected O, but got I
		//IL_0175: Expected O, but got I4
		//IL_096b: Expected O, but got I4
		//IL_0974: Expected O, but got I4
		//IL_0119: Expected O, but got I
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected O, but got Unknown
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected O, but got Unknown
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected O, but got Unknown
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected O, but got Unknown
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected O, but got Unknown
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected O, but got Unknown
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected O, but got Unknown
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected O, but got Unknown
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected O, but got Unknown
		//IL_0729: Expected O, but got I4
		//IL_0778: Expected O, but got I4
		//IL_0789: Expected O, but got I4
		//IL_0740: Expected O, but got I4
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Expected O, but got Unknown
		//IL_02be: Expected O, but got I8
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Expected O, but got Unknown
		//IL_0338: Expected O, but got I
		//IL_09eb: Expected O, but got I4
		//IL_09fb: Expected O, but got I4
		//IL_0a1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a20: Expected O, but got Unknown
		//IL_0373: Expected O, but got I
		//IL_0401: Unknown result type (might be due to invalid IL or missing references)
		//IL_0406: Expected O, but got Unknown
		//IL_042c: Expected O, but got I8
		//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Expected O, but got Unknown
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Expected O, but got Unknown
		//IL_038f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Expected O, but got Unknown
		//IL_0452: Unknown result type (might be due to invalid IL or missing references)
		//IL_0457: Expected O, but got Unknown
		//IL_0481: Expected O, but got I
		//IL_0518: Expected O, but got I4
		//IL_0a8a: Expected O, but got I4
		//IL_0a9a: Expected O, but got I4
		//IL_0aba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0abf: Expected O, but got Unknown
		//IL_04bc: Expected O, but got I
		//IL_055c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0561: Expected O, but got Unknown
		//IL_058b: Expected O, but got I
		//IL_0526: Unknown result type (might be due to invalid IL or missing references)
		//IL_052b: Expected O, but got Unknown
		//IL_0541: Unknown result type (might be due to invalid IL or missing references)
		//IL_0546: Expected O, but got Unknown
		//IL_0622: Expected O, but got I4
		//IL_04ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cf: Expected O, but got Unknown
		//IL_04d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dd: Expected O, but got Unknown
		//IL_0b32: Expected O, but got I4
		//IL_0b42: Expected O, but got I4
		//IL_0b62: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b67: Expected O, but got Unknown
		//IL_05c6: Expected O, but got I
		//IL_066b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0670: Expected O, but got Unknown
		//IL_0630: Unknown result type (might be due to invalid IL or missing references)
		//IL_0635: Expected O, but got Unknown
		//IL_064b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0650: Expected O, but got Unknown
		//IL_05d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d9: Expected O, but got Unknown
		//IL_05e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e7: Expected O, but got Unknown
		bool flag = room == null;
		List<object>.Enumerator enumerator = (List<object>.Enumerator)0;
		IntPtr intPtr = default(IntPtr);
		string text = (string)(nint)intPtr;
		Room room2 = room;
		object obj;
		object obj4;
		if (!flag)
		{
			obj = typeof(RegisteredWaitHandle) + 1376;
			nint num = (nint)room;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00b5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
			object obj3 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X10_v33-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj4 = obj3 + 16;
				obj2--;
				bool flag2 = (nint)obj2 != 1;
				obj3 = obj4;
				if (flag2)
				{
					continue;
				}
				goto IL_00b5;
			}
			object obj5 = obj3 + 32;
			object obj6 = num + obj5;
			object obj7 = obj6 + 312;
			obj4 = obj3;
			goto IL_08a2;
		}
		goto IL_0992;
		IL_08a2:
		object obj8 = "Read object reference Id '{0}' for {1}." + 3336;
		object obj9 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 992;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v259 @ X0_v17] (should have been resolved before IL gen)");
		nint num2 = (nint)room;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v11 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v11 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0162;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v11 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj11 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X10_v28-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj4 = obj11 + 16;
			obj10--;
			bool flag3 = (nint)obj10 != 1;
			obj11 = obj4;
			if (flag3)
			{
				continue;
			}
			goto IL_0162;
		}
		object obj12 = obj11 + 1;
		object obj13 = num2 + obj12;
		object obj14 = obj13 + 312;
		obj4 = obj11;
		goto IL_092c;
		IL_0992:
		NullReferenceException ex = new NullReferenceException();
		bool flag4 = (nint)text != 1;
		OutOfMemoryException ex2 = (OutOfMemoryException)(object)ex;
		if (!flag4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj15 = (nint)0 + (nint)784;
			text = (string)obj15;
			enumerator.Dispose();
			object obj16 = default(object);
			if (obj16 == null)
			{
				goto IL_06b5;
			}
			ex2 = new OutOfMemoryException();
			List<object>.Enumerator enumerator2 = (List<object>.Enumerator)obj16;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2236FC4");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		string result = default(string);
		return result;
		IL_0162:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		string text2 = (string)1;
		goto IL_092c;
		IL_092c:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v358 @ X0_v20] (should have been resolved before IL gen)");
		text2 = (string)obj9;
		string text4 = default(string);
		string text3 = (string)obj8 + text4 + (string)obj9;
		List<object> list = default(List<object>);
		bool flag5 = list == null;
		object obj17 = 0;
		enumerator = (List<object>.Enumerator)0;
		text = text4;
		room2 = room;
		if (!flag5)
		{
			object obj18 = "rightCtrl" + 432;
			object obj19 = typeof(UsageHint) + 664;
			object obj20 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 1056;
			object format = "rightCtrl" + 448;
			object obj21 = typeof(UsageHint) + 680;
			object format2 = "rightCtrl" + 440;
			List<object>.Enumerator enumerator3 = list.GetEnumerator();
			room2 = (Room)(object)text3;
			List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
			string[] array = default(string[]);
			object obj26 = default(object);
			List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
			string text5 = default(string);
			object arg = default(object);
			object arg2 = default(object);
			while (enumerator4.MoveNext())
			{
				object obj22 = typeof(SqlSingle[]) + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
				if (array != null)
				{
					if (array.Length != 0)
					{
						object obj23 = array + 32;
						obj23 = room2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						object obj24 = array.Length & 0xFFFFFFFEL;
						if (obj24 != null)
						{
							text = (string)obj18;
							object obj25 = array + 40;
							obj25 = obj18;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							if (obj26 != null)
							{
								object obj27 = obj26;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v602 @ X8_v27+12E]");
								object obj28 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v602 @ X8_v27+12E]");
								if ((nint)0 == 0)
								{
									goto IL_03bc;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v602 @ X8_v27+B0]");
								object obj29 = (nint)0 + (nint)8;
								while (true)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v643 @ X10_v23-8]");
									if (0 == (nint)obj19)
									{
										break;
									}
									obj4 = obj29 + 16;
									obj28--;
									bool flag6 = (nint)obj28 != 1;
									obj29 = obj4;
									if (flag6)
									{
										continue;
									}
									goto IL_03bc;
								}
								object obj30 = obj27 + obj29;
								object obj31 = obj30 + 312;
								obj4 = obj29;
								goto IL_09c5;
							}
							NullReferenceException ex3 = new NullReferenceException();
						}
						else
						{
							IndexOutOfRangeException ex4 = new IndexOutOfRangeException();
							text = (string)(object)room2;
						}
					}
					else
					{
						IndexOutOfRangeException ex5 = new IndexOutOfRangeException();
						text = (string)6;
					}
				}
				else
				{
					NullReferenceException ex6 = new NullReferenceException();
					text = (string)6;
				}
				goto IL_076e;
				IL_0505:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				text2 = (string)2;
				goto IL_0a53;
				IL_03bc:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				text2 = null;
				goto IL_09c5;
				IL_076e:
				obj17 = 0;
				enumerator = enumerator2;
				enumerator2 = (List<object>.Enumerator)0;
				goto IL_0992;
				IL_09c5:
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v667 @ X0_v44] (should have been resolved before IL gen)");
				bool flag7 = array.Length < 2;
				object obj32 = !flag7;
				object obj33 = array.Length - 2;
				bool flag8 = obj33 == null;
				object obj34 = ~obj32;
				object obj35 = obj34 | flag8;
				if (obj35 == null)
				{
					object obj36 = array + 48;
					obj36 = text5;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object obj37 = array.Length & 0xFFFFFFFCL;
					if (obj37 != null)
					{
						object obj38 = array + 56;
						obj38 = obj20;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						object obj39 = obj26;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ X8_v32+12E]");
						object obj40 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ X8_v32+12E]");
						if ((nint)0 == 0)
						{
							goto IL_0505;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ X8_v32+B0]");
						object obj41 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v724 @ X10_v18-8]");
							if (0 == (nint)obj19)
							{
								break;
							}
							obj4 = obj41 + 16;
							obj40--;
							bool flag9 = (nint)obj40 != 1;
							obj41 = obj4;
							if (flag9)
							{
								continue;
							}
							goto IL_0505;
						}
						object obj42 = obj41 + 2;
						object obj43 = obj39 + obj42;
						object obj44 = obj43 + 312;
						obj4 = obj41;
						goto IL_0a53;
					}
					IndexOutOfRangeException ex7 = new IndexOutOfRangeException();
					text = text5;
				}
				else
				{
					IndexOutOfRangeException ex8 = new IndexOutOfRangeException();
					text = text5;
				}
				goto IL_076e;
				IL_060f:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				string text6 = (string)1;
				goto IL_0af1;
				IL_0a53:
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v750 @ X0_v55] (should have been resolved before IL gen)");
				string text7 = string.Format((string)format, arg);
				bool flag10 = array.Length < 4;
				object obj45 = !flag10;
				object obj46 = array.Length - 4;
				bool flag11 = obj46 == null;
				object obj47 = ~obj45;
				object obj48 = obj47 | flag11;
				if (obj48 == null)
				{
					object obj49 = array + 64;
					obj49 = text7;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object obj50 = obj26;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v765 @ X8_v36+12E]");
					object obj51 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v765 @ X8_v36+12E]");
					if ((nint)0 == 0)
					{
						goto IL_060f;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v765 @ X8_v36+B0]");
					object obj52 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v806 @ X10_v13-8]");
						if (0 == (nint)obj19)
						{
							break;
						}
						obj4 = obj52 + 16;
						obj51--;
						bool flag12 = (nint)obj51 != 1;
						obj52 = obj4;
						if (flag12)
						{
							continue;
						}
						goto IL_060f;
					}
					object obj53 = obj52 + 1;
					object obj54 = obj50 + obj53;
					object obj55 = obj54 + 312;
					text6 = null;
					obj4 = obj52;
					goto IL_0af1;
				}
				IndexOutOfRangeException ex9 = new IndexOutOfRangeException();
				text2 = null;
				text = text7;
				goto IL_076e;
				IL_0af1:
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v832 @ X0_v64] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				string text8 = string.Format((string)format2, arg2);
				bool flag13 = array.Length < 5;
				object obj56 = !flag13;
				object obj57 = array.Length - 5;
				bool flag14 = obj57 == null;
				object obj58 = ~obj56;
				object obj59 = obj58 | flag14;
				if (obj59 == null)
				{
					object obj60 = array + 72;
					obj60 = text8;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					string text9 = string.Concat(array);
					text2 = null;
					room2 = (Room)(object)text9;
					continue;
				}
				IndexOutOfRangeException ex10 = new IndexOutOfRangeException();
				text2 = null;
				text = text8;
				goto IL_076e;
			}
			enumerator4.Dispose();
			goto IL_06b5;
		}
		goto IL_0992;
		IL_06b5:
		return (string)(object)room2;
		IL_00b5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		text2 = (string)32;
		goto IL_08a2;
	}

	public static string GetVariable(Room room, string varName, string defaultValue)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_006c: Expected O, but got I
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		if (room != null)
		{
			object obj = typeof(RegisteredWaitHandle) + 1376;
			nint num = (nint)room;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00ad;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
			object obj3 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X10_v5-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj3 += 16;
				obj2--;
				if ((nint)obj2 != 1)
				{
					continue;
				}
				goto IL_00ad;
			}
			object obj4 = obj3 + 31;
			object obj5 = num + obj4;
			object obj6 = obj5 + 312;
			goto IL_0139;
		}
		return (string)(object)new NullReferenceException();
		IL_0139:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v165 @ X0_v3] (should have been resolved before IL gen)");
		Variable variable = default(Variable);
		return Get(variable, defaultValue);
		IL_00ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0139;
	}

	public static bool GetVariable(Room room, string varName, bool defaultValue)
	{
		//IL_00f8: Expected I4, but got O
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_006c: Expected O, but got I
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		if (room != null)
		{
			object obj = typeof(RegisteredWaitHandle) + 1376;
			nint num = (nint)room;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00ad;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
			object obj3 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X10_v5-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj3 += 16;
				obj2--;
				if ((nint)obj2 != 1)
				{
					continue;
				}
				goto IL_00ad;
			}
			object obj4 = obj3 + 31;
			object obj5 = num + obj4;
			object obj6 = obj5 + 312;
			goto IL_0139;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0139:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v165 @ X0_v3] (should have been resolved before IL gen)");
		Variable variable = default(Variable);
		return Get(variable, defaultValue);
		IL_00ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0139;
	}

	public static int GetVariable(Room room, string varName, int defaultValue)
	{
		//IL_00f8: Expected I4, but got O
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_006c: Expected O, but got I
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		if (room != null)
		{
			object obj = typeof(RegisteredWaitHandle) + 1376;
			nint num = (nint)room;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00ad;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
			object obj3 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X10_v5-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj3 += 16;
				obj2--;
				if ((nint)obj2 != 1)
				{
					continue;
				}
				goto IL_00ad;
			}
			object obj4 = obj3 + 31;
			object obj5 = num + obj4;
			object obj6 = obj5 + 312;
			goto IL_0139;
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
		IL_0139:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v165 @ X0_v3] (should have been resolved before IL gen)");
		Variable variable = default(Variable);
		return Get(variable, defaultValue);
		IL_00ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0139;
	}

	public static long GetVariable(Room room, string varName, long defaultValue)
	{
		//IL_00f8: Expected I8, but got O
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_006c: Expected O, but got I
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		if (room != null)
		{
			object obj = typeof(RegisteredWaitHandle) + 1376;
			nint num = (nint)room;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00ad;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
			object obj3 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X10_v5-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj3 += 16;
				obj2--;
				if ((nint)obj2 != 1)
				{
					continue;
				}
				goto IL_00ad;
			}
			object obj4 = obj3 + 31;
			object obj5 = num + obj4;
			object obj6 = obj5 + 312;
			goto IL_0139;
		}
		NullReferenceException ex = new NullReferenceException();
		return (long)ex;
		IL_0139:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v165 @ X0_v3] (should have been resolved before IL gen)");
		Variable variable = default(Variable);
		return Get(variable, defaultValue);
		IL_00ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0139;
	}

	public static T GetVariable<T>(Room room, string varName, T defaultValue) where T : Enum
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_0052: Expected I, but got O
		//IL_0062: Expected O, but got I
		//IL_009d: Expected O, but got I
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		if (room != null)
		{
			object obj = typeof(RegisteredWaitHandle) + 1376;
			nint num = (nint)room;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00de;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
			object obj3 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X10_v5-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj3 += 16;
				obj2--;
				if ((nint)obj2 != 1)
				{
					continue;
				}
				goto IL_00de;
			}
			object obj4 = obj3 + 31;
			object obj5 = num + obj4;
			object obj6 = obj5 + 312;
			goto IL_014d;
		}
		return (T)new NullReferenceException();
		IL_014d:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v169 @ X0_v3] (should have been resolved before IL gen)");
		Variable variable = default(Variable);
		return Get(variable, defaultValue);
		IL_00de:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_014d;
	}

	public static double GetVariable(Room room, string varName, double defaultValue)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_006c: Expected O, but got I
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 1376;
		nint num = (nint)room;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00ad;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj3 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X10_v5-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj3 += 16;
			obj2--;
			if ((nint)obj2 != 1)
			{
				continue;
			}
			goto IL_00ad;
		}
		object obj4 = obj3 + 31;
		object obj5 = num + obj4;
		object obj6 = obj5 + 312;
		goto IL_010e;
		IL_00ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_010e;
		IL_010e:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v175 @ X0_v3] (should have been resolved before IL gen)");
		Variable variable = default(Variable);
		return Get(variable, defaultValue);
	}

	public static DateTime? GetVariable(Room room, string varName, DateTime? defaultValue)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_006c: Expected O, but got I
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		if (room != null)
		{
			object obj = typeof(RegisteredWaitHandle) + 1376;
			nint num = (nint)room;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00ad;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
			object obj3 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X10_v5-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj3 += 16;
				obj2--;
				if ((nint)obj2 != 1)
				{
					continue;
				}
				goto IL_00ad;
			}
			object obj4 = obj3 + 31;
			object obj5 = num + obj4;
			object obj6 = obj5 + 312;
			goto IL_0139;
		}
		return (DateTime?)new NullReferenceException();
		IL_0139:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v174 @ X0_v3] (should have been resolved before IL gen)");
		Variable variable = default(Variable);
		return Get(variable, defaultValue);
		IL_00ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0139;
	}

	private static string Get(Variable variable, string defaultValue)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_002d: Expected I, but got O
		//IL_003d: Expected O, but got I
		//IL_05e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e5: Expected O, but got Unknown
		//IL_0078: Expected O, but got I
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_03b7: Expected I, but got O
		//IL_03c7: Expected O, but got I
		//IL_0456: Expected O, but got I4
		//IL_030b: Expected I, but got O
		//IL_031b: Expected O, but got I
		//IL_073c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0741: Expected O, but got Unknown
		//IL_076b: Expected O, but got I4
		//IL_0402: Expected O, but got I
		//IL_03aa: Expected O, but got I4
		//IL_025f: Expected I, but got O
		//IL_026f: Expected O, but got I
		//IL_06bf: Expected O, but got I4
		//IL_06cf: Expected O, but got I
		//IL_06f1: Expected O, but got I4
		//IL_0356: Expected O, but got I
		//IL_050f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0514: Expected O, but got Unknown
		//IL_051c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Expected O, but got Unknown
		//IL_052a: Unknown result type (might be due to invalid IL or missing references)
		//IL_052f: Expected O, but got Unknown
		//IL_02fe: Expected O, but got I4
		//IL_016e: Expected I, but got O
		//IL_017e: Expected O, but got I
		//IL_0410: Unknown result type (might be due to invalid IL or missing references)
		//IL_0415: Expected O, but got Unknown
		//IL_041e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0423: Expected O, but got Unknown
		//IL_02aa: Expected O, but got I
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c5: Expected O, but got Unknown
		//IL_04cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d2: Expected O, but got Unknown
		//IL_04db: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e0: Expected O, but got Unknown
		//IL_020d: Expected O, but got I4
		//IL_0364: Unknown result type (might be due to invalid IL or missing references)
		//IL_0369: Expected O, but got Unknown
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_0377: Expected O, but got Unknown
		//IL_01b9: Expected O, but got I
		//IL_0492: Unknown result type (might be due to invalid IL or missing references)
		//IL_0497: Expected O, but got Unknown
		//IL_049f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a4: Expected O, but got Unknown
		//IL_04ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b2: Expected O, but got Unknown
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Expected O, but got Unknown
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected O, but got Unknown
		//IL_0464: Unknown result type (might be due to invalid IL or missing references)
		//IL_0469: Expected O, but got Unknown
		//IL_0471: Unknown result type (might be due to invalid IL or missing references)
		//IL_0476: Expected O, but got Unknown
		//IL_047f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0484: Expected O, but got Unknown
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected O, but got Unknown
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected O, but got Unknown
		bool flag = variable == null;
		string result = defaultValue;
		object obj;
		object obj2;
		if (!flag)
		{
			obj = typeof(UsageHint) + 664;
			obj2 = (nint)0 + (nint)720;
			nint num = (nint)variable;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Variables.Variable>)+12E]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Variables.Variable>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00b9;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Variables.Variable>)+B0]");
			object obj4 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X10_v31-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj4 += 16;
				obj3--;
				if ((nint)obj3 != 1)
				{
					continue;
				}
				goto IL_00b9;
			}
			object obj5 = obj4 + 1;
			object obj6 = num + obj5;
			object obj7 = obj6 + 312;
			goto IL_05b8;
		}
		goto IL_060a;
		IL_0673:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v588 @ X0_v22] (should have been resolved before IL gen)");
		goto IL_0562;
		IL_060a:
		return result;
		IL_0443:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj8 = 5;
		goto IL_0723;
		IL_0723:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v524 @ X0_v9] (should have been resolved before IL gen)");
		object obj9 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3632;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ X0_v12+E4]");
		bool flag2 = (nint)0 == 0;
		object obj11 = !flag2;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CultureInfo invariantCulture = CultureInfo.InvariantCulture;
		double num2 = default(double);
		string text = num2.ToString(invariantCulture);
		goto IL_0562;
		IL_01fa:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj8 = 4;
		goto IL_0633;
		IL_00b9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_05b8;
		IL_05b8:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v220 @ X0_v4] (should have been resolved before IL gen)");
		obj8 = obj2;
		System.Int32Enum value = default(System.Int32Enum);
		System.Int32Enum? int32Enum = value;
		object obj12 = (??)int32Enum & 1;
		bool flag3 = obj12 == null;
		result = defaultValue;
		if (!flag3)
		{
			object obj13 = (object?)int32Enum >> 32;
			if ((nint)obj13 <= 2)
			{
				if ((nint)obj13 == 1)
				{
					nint num3 = (nint)variable;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X8_v21 (Il2CppClass<Sfs2X.Entities.Variables.Variable>)+12E]");
					object obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X8_v21 (Il2CppClass<Sfs2X.Entities.Variables.Variable>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0397;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X8_v21 (Il2CppClass<Sfs2X.Entities.Variables.Variable>)+B0]");
					object obj15 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X10_v20-8]");
						if (0 == (nint)obj)
						{
							break;
						}
						obj15 += 16;
						obj14--;
						if ((nint)obj14 != 1)
						{
							continue;
						}
						goto IL_0397;
					}
					object obj16 = obj15 + 3;
					object obj17 = num3 + obj16;
					object obj18 = obj17 + 312;
					goto IL_06a6;
				}
				bool flag4 = (nint)obj13 != 2;
				result = defaultValue;
				if (!flag4)
				{
					nint num4 = (nint)variable;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v28 (Il2CppClass<Sfs2X.Entities.Variables.Variable>)+12E]");
					object obj19 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v28 (Il2CppClass<Sfs2X.Entities.Variables.Variable>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_01fa;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v28 (Il2CppClass<Sfs2X.Entities.Variables.Variable>)+B0]");
					object obj20 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ X10_v26-8]");
						if (0 == (nint)obj)
						{
							break;
						}
						obj20 += 16;
						obj19--;
						if ((nint)obj19 != 1)
						{
							continue;
						}
						goto IL_01fa;
					}
					object obj21 = obj20 + 4;
					object obj22 = num4 + obj21;
					object obj23 = obj22 + 312;
					goto IL_0633;
				}
			}
			else
			{
				if ((nint)obj13 == 3)
				{
					nint num5 = (nint)variable;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v10 (Il2CppClass<Sfs2X.Entities.Variables.Variable>)+12E]");
					object obj24 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v10 (Il2CppClass<Sfs2X.Entities.Variables.Variable>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0443;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v10 (Il2CppClass<Sfs2X.Entities.Variables.Variable>)+B0]");
					object obj25 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X10_v8-8]");
						if (0 == (nint)obj)
						{
							break;
						}
						obj25 += 16;
						obj24--;
						if ((nint)obj24 != 1)
						{
							continue;
						}
						goto IL_0443;
					}
					object obj26 = obj25 + 5;
					object obj27 = num5 + obj26;
					object obj28 = obj27 + 312;
					goto IL_0723;
				}
				bool flag5 = (nint)obj13 != 4;
				result = defaultValue;
				if (!flag5)
				{
					nint num6 = (nint)variable;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X8_v17 (Il2CppClass<Sfs2X.Entities.Variables.Variable>)+12E]");
					object obj29 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X8_v17 (Il2CppClass<Sfs2X.Entities.Variables.Variable>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_02eb;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X8_v17 (Il2CppClass<Sfs2X.Entities.Variables.Variable>)+B0]");
					object obj30 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X10_v14-8]");
						if (0 == (nint)obj)
						{
							break;
						}
						obj30 += 16;
						obj29--;
						if ((nint)obj29 != 1)
						{
							continue;
						}
						goto IL_02eb;
					}
					object obj31 = obj30 + 6;
					object obj32 = num6 + obj31;
					object obj33 = obj32 + 312;
					goto IL_0673;
				}
			}
		}
		goto IL_060a;
		IL_02eb:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj8 = 6;
		goto IL_0673;
		IL_06a6:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v472 @ X0_v28] (should have been resolved before IL gen)");
		object obj34 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ X8_v25+28]");
		object obj35 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ X0_v31+E4]");
		bool flag6 = (nint)0 == 0;
		object obj36 = !flag6;
		if (obj36 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag7 = default(bool);
		text = flag7.ToString();
		goto IL_0562;
		IL_0633:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v555 @ X0_v39] (should have been resolved before IL gen)");
		int num7 = default(int);
		text = num7.ToString();
		goto IL_0562;
		IL_0397:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj8 = 3;
		goto IL_06a6;
		IL_0562:
		result = text;
		goto IL_060a;
	}

	private static bool Get(Variable variable, bool defaultValue)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_006c: Expected O, but got I
		//IL_00e9: Expected I, but got O
		//IL_00f9: Expected O, but got I
		//IL_0197: Expected O, but got I
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected O, but got Unknown
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected O, but got Unknown
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected O, but got Unknown
		//IL_0134: Expected O, but got I
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected O, but got Unknown
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Expected O, but got Unknown
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Expected O, but got Unknown
		//IL_0237: Expected O, but got I
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected O, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		object obj3 = default(object);
		object obj14 = default(object);
		object obj16 = default(object);
		object obj18 = default(object);
		while (variable != null)
		{
			object obj = typeof(UsageHint) + 664;
			nint num = (nint)variable;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Variables.Variable>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Variables.Variable>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00ad;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Variables.Variable>)+B0]");
			obj3 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X10_v11-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj3 += 16;
				obj2--;
				if ((nint)obj2 != 1)
				{
					continue;
				}
				goto IL_00ad;
			}
			goto IL_01a1;
			IL_00e1:
			nint num2 = (nint)variable;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Variables.Variable>)+12E]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Variables.Variable>)+12E]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Variables.Variable>)+B0]");
				object obj5 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X10_v6-8]");
					if (0 == (nint)obj)
					{
						break;
					}
					obj5 += 16;
					obj4--;
					if ((nint)obj4 != 1)
					{
						continue;
					}
					goto IL_0175;
				}
				object obj6 = obj5 + 3;
				object obj7 = num2 + obj6;
				object obj8 = obj7 + 312;
				object obj9 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X0_v8+8]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v153 @ X2_v5 (should have been resolved before IL gen)");
				continue;
			}
			goto IL_0175;
			IL_01a1:
			object obj11 = obj3 + 1;
			object obj12 = num + obj11;
			object obj13 = obj12 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v234 @ X0_v14] (should have been resolved before IL gen)");
			if ((nint)obj14 != 1)
			{
				break;
			}
			goto IL_00e1;
			IL_0175:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj15 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X0_v6+8]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v152 @ X2_v4 (should have been resolved before IL gen)");
			goto IL_01a1;
			IL_00ad:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v141 @ X0_v11] (should have been resolved before IL gen)");
			if ((nint)obj18 != 1)
			{
				break;
			}
			goto IL_00e1;
		}
		return defaultValue;
	}

	private static int Get(Variable variable, int defaultValue)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_002d: Expected I, but got O
		//IL_003d: Expected O, but got I
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Expected O, but got Unknown
		//IL_0078: Expected O, but got I
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		//IL_01fd: Expected I, but got O
		//IL_020d: Expected O, but got I
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_029c: Expected O, but got I4
		//IL_0248: Expected O, but got I
		//IL_0151: Expected I, but got O
		//IL_0161: Expected O, but got I
		//IL_030a: Expected I4, but got I8
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Expected O, but got Unknown
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Expected O, but got Unknown
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Expected O, but got Unknown
		//IL_01f0: Expected O, but got I4
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Expected O, but got Unknown
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Expected O, but got Unknown
		//IL_019c: Expected O, but got I
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected O, but got Unknown
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Expected O, but got Unknown
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Expected O, but got Unknown
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected O, but got Unknown
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected O, but got Unknown
		bool flag = variable == null;
		int result = defaultValue;
		object obj;
		object obj2;
		if (!flag)
		{
			obj = typeof(UsageHint) + 664;
			obj2 = (nint)0 + (nint)720;
			nint num = (nint)variable;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Variables.Variable>)+12E]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Variables.Variable>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00b9;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Variables.Variable>)+B0]");
			object obj4 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X10_v18-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj4 += 16;
				obj3--;
				if ((nint)obj3 != 1)
				{
					continue;
				}
				goto IL_00b9;
			}
			object obj5 = obj4 + 1;
			object obj6 = num + obj5;
			object obj7 = obj6 + 312;
			goto IL_0365;
		}
		goto IL_03b7;
		IL_03b7:
		return result;
		IL_0289:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj8 = 5;
		goto IL_041b;
		IL_041b:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v394 @ X0_v8] (should have been resolved before IL gen)");
		int num2 = default(int);
		if (num2 == 9218868437227405312L)
		{
			return -2147483648;
		}
		return num2;
		IL_03e0:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v406 @ X0_v15] (should have been resolved before IL gen)");
		int num3 = default(int);
		result = num3;
		goto IL_03b7;
		IL_01dd:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj8 = 4;
		goto IL_03e0;
		IL_00b9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0365;
		IL_0365:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v256 @ X0_v4] (should have been resolved before IL gen)");
		obj8 = obj2;
		System.Int32Enum value = default(System.Int32Enum);
		System.Int32Enum? int32Enum = value;
		object obj9 = (??)int32Enum & 1;
		bool flag2 = obj9 == null;
		result = defaultValue;
		if (!flag2)
		{
			object obj10 = (object?)int32Enum >> 32;
			if ((nint)obj10 == 3)
			{
				nint num4 = (nint)variable;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Variables.Variable>)+12E]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Variables.Variable>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0289;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Variables.Variable>)+B0]");
				object obj12 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X10_v7-8]");
					if (0 == (nint)obj)
					{
						break;
					}
					obj12 += 16;
					obj11--;
					if ((nint)obj11 != 1)
					{
						continue;
					}
					goto IL_0289;
				}
				object obj13 = obj12 + 5;
				object obj14 = num4 + obj13;
				object obj15 = obj14 + 312;
				goto IL_041b;
			}
			bool flag3 = (nint)obj10 != 2;
			result = defaultValue;
			if (!flag3)
			{
				nint num5 = (nint)variable;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X8_v14 (Il2CppClass<Sfs2X.Entities.Variables.Variable>)+12E]");
				object obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X8_v14 (Il2CppClass<Sfs2X.Entities.Variables.Variable>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_01dd;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X8_v14 (Il2CppClass<Sfs2X.Entities.Variables.Variable>)+B0]");
				object obj17 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X10_v13-8]");
					if (0 == (nint)obj)
					{
						break;
					}
					obj17 += 16;
					obj16--;
					if ((nint)obj16 != 1)
					{
						continue;
					}
					goto IL_01dd;
				}
				object obj18 = obj17 + 4;
				object obj19 = num5 + obj18;
				object obj20 = obj19 + 312;
				goto IL_03e0;
			}
		}
		goto IL_03b7;
	}

	private static long Get(Variable variable, long defaultValue)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_002d: Expected I, but got O
		//IL_003d: Expected O, but got I
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Expected O, but got Unknown
		//IL_0078: Expected O, but got I
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		//IL_01fd: Expected I, but got O
		//IL_020d: Expected O, but got I
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_029c: Expected O, but got I4
		//IL_0248: Expected O, but got I
		//IL_0151: Expected I, but got O
		//IL_0161: Expected O, but got I
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Expected O, but got Unknown
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Expected O, but got Unknown
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Expected O, but got Unknown
		//IL_01f0: Expected O, but got I4
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Expected O, but got Unknown
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Expected O, but got Unknown
		//IL_019c: Expected O, but got I
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected O, but got Unknown
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Expected O, but got Unknown
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Expected O, but got Unknown
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected O, but got Unknown
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected O, but got Unknown
		bool flag = variable == null;
		long result = defaultValue;
		object obj;
		object obj2;
		if (!flag)
		{
			obj = typeof(UsageHint) + 664;
			obj2 = (nint)0 + (nint)720;
			nint num = (nint)variable;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Variables.Variable>)+12E]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Variables.Variable>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00b9;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Variables.Variable>)+B0]");
			object obj4 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X10_v18-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj4 += 16;
				obj3--;
				if ((nint)obj3 != 1)
				{
					continue;
				}
				goto IL_00b9;
			}
			object obj5 = obj4 + 1;
			object obj6 = num + obj5;
			object obj7 = obj6 + 312;
			goto IL_0365;
		}
		goto IL_03b7;
		IL_03b7:
		return result;
		IL_0289:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj8 = 5;
		goto IL_041b;
		IL_041b:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v394 @ X0_v8] (should have been resolved before IL gen)");
		long num2 = default(long);
		if (num2 == 9218868437227405312L)
		{
			return -9223372036854775808L;
		}
		return num2;
		IL_03e0:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v406 @ X0_v15] (should have been resolved before IL gen)");
		long num3 = default(long);
		result = num3;
		goto IL_03b7;
		IL_01dd:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj8 = 4;
		goto IL_03e0;
		IL_00b9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0365;
		IL_0365:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v256 @ X0_v4] (should have been resolved before IL gen)");
		obj8 = obj2;
		System.Int32Enum value = default(System.Int32Enum);
		System.Int32Enum? int32Enum = value;
		object obj9 = (??)int32Enum & 1;
		bool flag2 = obj9 == null;
		result = defaultValue;
		if (!flag2)
		{
			object obj10 = (object?)int32Enum >> 32;
			if ((nint)obj10 == 3)
			{
				nint num4 = (nint)variable;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Variables.Variable>)+12E]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Variables.Variable>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0289;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Variables.Variable>)+B0]");
				object obj12 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X10_v7-8]");
					if (0 == (nint)obj)
					{
						break;
					}
					obj12 += 16;
					obj11--;
					if ((nint)obj11 != 1)
					{
						continue;
					}
					goto IL_0289;
				}
				object obj13 = obj12 + 5;
				object obj14 = num4 + obj13;
				object obj15 = obj14 + 312;
				goto IL_041b;
			}
			bool flag3 = (nint)obj10 != 2;
			result = defaultValue;
			if (!flag3)
			{
				nint num5 = (nint)variable;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X8_v14 (Il2CppClass<Sfs2X.Entities.Variables.Variable>)+12E]");
				object obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X8_v14 (Il2CppClass<Sfs2X.Entities.Variables.Variable>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_01dd;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X8_v14 (Il2CppClass<Sfs2X.Entities.Variables.Variable>)+B0]");
				object obj17 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X10_v13-8]");
					if (0 == (nint)obj)
					{
						break;
					}
					obj17 += 16;
					obj16--;
					if ((nint)obj16 != 1)
					{
						continue;
					}
					goto IL_01dd;
				}
				object obj18 = obj17 + 4;
				object obj19 = num5 + obj18;
				object obj20 = obj19 + 312;
				goto IL_03e0;
			}
		}
		goto IL_03b7;
	}

	private static double Get(Variable variable, double defaultValue)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_002d: Expected I, but got O
		//IL_003d: Expected O, but got I
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Expected O, but got Unknown
		//IL_0078: Expected O, but got I
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		//IL_01fd: Expected I, but got O
		//IL_020d: Expected O, but got I
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_029c: Expected O, but got I4
		//IL_0248: Expected O, but got I
		//IL_0151: Expected I, but got O
		//IL_0161: Expected O, but got I
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Expected O, but got Unknown
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Expected O, but got Unknown
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Expected O, but got Unknown
		//IL_01f0: Expected O, but got I4
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Expected O, but got Unknown
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Expected O, but got Unknown
		//IL_019c: Expected O, but got I
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected O, but got Unknown
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Expected O, but got Unknown
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Expected O, but got Unknown
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected O, but got Unknown
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected O, but got Unknown
		bool flag = variable == null;
		double result = defaultValue;
		object obj;
		object obj2;
		if (!flag)
		{
			obj = typeof(UsageHint) + 664;
			obj2 = (nint)0 + (nint)720;
			nint num = (nint)variable;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Variables.Variable>)+12E]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Variables.Variable>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00b9;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Variables.Variable>)+B0]");
			object obj4 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X10_v18-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj4 += 16;
				obj3--;
				if ((nint)obj3 != 1)
				{
					continue;
				}
				goto IL_00b9;
			}
			object obj5 = obj4 + 1;
			object obj6 = num + obj5;
			object obj7 = obj6 + 312;
			goto IL_0346;
		}
		goto IL_0398;
		IL_03c1:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v365 @ X0_v13] (should have been resolved before IL gen)");
		double num2 = default(double);
		result = num2;
		goto IL_0398;
		IL_0289:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj8 = 5;
		goto IL_03fc;
		IL_03fc:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v357 @ X0_v7] (should have been resolved before IL gen)");
		result = defaultValue;
		goto IL_0398;
		IL_0398:
		return result;
		IL_01dd:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj8 = 4;
		goto IL_03c1;
		IL_00b9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0346;
		IL_0346:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v228 @ X0_v3] (should have been resolved before IL gen)");
		obj8 = obj2;
		System.Int32Enum value = default(System.Int32Enum);
		System.Int32Enum? int32Enum = value;
		object obj9 = (??)int32Enum & 1;
		bool flag2 = obj9 == null;
		result = defaultValue;
		if (!flag2)
		{
			object obj10 = (object?)int32Enum >> 32;
			if ((nint)obj10 == 3)
			{
				nint num3 = (nint)variable;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Variables.Variable>)+12E]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Variables.Variable>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0289;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Variables.Variable>)+B0]");
				object obj12 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X10_v7-8]");
					if (0 == (nint)obj)
					{
						break;
					}
					obj12 += 16;
					obj11--;
					if ((nint)obj11 != 1)
					{
						continue;
					}
					goto IL_0289;
				}
				object obj13 = obj12 + 5;
				object obj14 = num3 + obj13;
				object obj15 = obj14 + 312;
				goto IL_03fc;
			}
			bool flag3 = (nint)obj10 != 2;
			result = defaultValue;
			if (!flag3)
			{
				nint num4 = (nint)variable;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X8_v13 (Il2CppClass<Sfs2X.Entities.Variables.Variable>)+12E]");
				object obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X8_v13 (Il2CppClass<Sfs2X.Entities.Variables.Variable>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_01dd;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X8_v13 (Il2CppClass<Sfs2X.Entities.Variables.Variable>)+B0]");
				object obj17 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X10_v13-8]");
					if (0 == (nint)obj)
					{
						break;
					}
					obj17 += 16;
					obj16--;
					if ((nint)obj16 != 1)
					{
						continue;
					}
					goto IL_01dd;
				}
				object obj18 = obj17 + 4;
				object obj19 = num4 + obj18;
				object obj20 = obj19 + 312;
				goto IL_03c1;
			}
		}
		goto IL_0398;
	}

	private static DateTime? Get(Variable variable, DateTime? defaultValue)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_002d: Expected I, but got O
		//IL_003d: Expected O, but got I
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Expected O, but got Unknown
		//IL_0078: Expected O, but got I
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		//IL_01fa: Expected I, but got O
		//IL_020a: Expected O, but got I
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_0299: Expected O, but got I4
		//IL_0491: Unknown result type (might be due to invalid IL or missing references)
		//IL_0496: Expected O, but got Unknown
		//IL_04c0: Expected O, but got I4
		//IL_0245: Expected O, but got I
		//IL_0149: Expected I, but got O
		//IL_0159: Expected O, but got I
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Expected O, but got Unknown
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Expected O, but got Unknown
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Expected O, but got Unknown
		//IL_01e8: Expected O, but got I4
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected O, but got Unknown
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Expected O, but got Unknown
		//IL_0417: Unknown result type (might be due to invalid IL or missing references)
		//IL_041c: Expected O, but got Unknown
		//IL_0446: Expected O, but got I4
		//IL_0194: Expected O, but got I
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected O, but got Unknown
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Expected O, but got Unknown
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Expected O, but got Unknown
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected O, but got Unknown
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected O, but got Unknown
		object obj;
		object obj2;
		if (variable != null)
		{
			obj = typeof(UsageHint) + 664;
			obj2 = (nint)0 + (nint)720;
			nint num = (nint)variable;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Variables.Variable>)+12E]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Variables.Variable>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00b9;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Variables.Variable>)+B0]");
			object obj4 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X10_v20-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj4 += 16;
				obj3--;
				if ((nint)obj3 != 1)
				{
					continue;
				}
				goto IL_00b9;
			}
			object obj5 = obj4 + 1;
			object obj6 = num + obj5;
			object obj7 = obj6 + 312;
			goto IL_0390;
		}
		goto IL_034a;
		IL_0478:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v400 @ X0_v13] (should have been resolved before IL gen)");
		object obj8 = typeof(DataRelation) + 824;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X0_v16+E4]");
		bool flag = (nint)0 == 0;
		object obj10 = !flag;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj11 = default(object);
		double unixTimeStamp = (double)obj11 / 4.652007308841189E+18;
		goto IL_04ce;
		IL_0286:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj12 = 5;
		goto IL_0478;
		IL_04ce:
		DateTime value = DateTimeUtil.FromTimeStamp(unixTimeStamp);
		DateTime? dateTime = value;
		goto IL_034a;
		IL_01d5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj12 = 4;
		goto IL_03fe;
		IL_03fe:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v431 @ X0_v22] (should have been resolved before IL gen)");
		object obj13 = typeof(DataRelation) + 824;
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X0_v25+E4]");
		bool flag2 = (nint)0 == 0;
		object obj15 = !flag2;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj16 = default(object);
		unixTimeStamp = (double)obj16 / 4.652007308841189E+18;
		goto IL_04ce;
		IL_00b9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0390;
		IL_0390:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v254 @ X0_v5] (should have been resolved before IL gen)");
		obj12 = obj2;
		System.Int32Enum value2 = default(System.Int32Enum);
		System.Int32Enum? int32Enum = value2;
		object obj17 = (??)int32Enum & 1;
		if (obj17 != null)
		{
			object obj18 = (object?)int32Enum >> 32;
			if ((nint)obj18 == 3)
			{
				nint num2 = (nint)variable;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X8_v13 (Il2CppClass<Sfs2X.Entities.Variables.Variable>)+12E]");
				object obj19 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X8_v13 (Il2CppClass<Sfs2X.Entities.Variables.Variable>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0286;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X8_v13 (Il2CppClass<Sfs2X.Entities.Variables.Variable>)+B0]");
				object obj20 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X10_v9-8]");
					if (0 == (nint)obj)
					{
						break;
					}
					obj20 += 16;
					obj19--;
					if ((nint)obj19 != 1)
					{
						continue;
					}
					goto IL_0286;
				}
				object obj21 = obj20 + 5;
				object obj22 = num2 + obj21;
				object obj23 = obj22 + 312;
				goto IL_0478;
			}
			if ((nint)obj18 == 2)
			{
				nint num3 = (nint)variable;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v22 (Il2CppClass<Sfs2X.Entities.Variables.Variable>)+12E]");
				object obj24 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v22 (Il2CppClass<Sfs2X.Entities.Variables.Variable>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_01d5;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v22 (Il2CppClass<Sfs2X.Entities.Variables.Variable>)+B0]");
				object obj25 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X10_v15-8]");
					if (0 == (nint)obj)
					{
						break;
					}
					obj25 += 16;
					obj24--;
					if ((nint)obj24 != 1)
					{
						continue;
					}
					goto IL_01d5;
				}
				object obj26 = obj25 + 4;
				object obj27 = num3 + obj26;
				object obj28 = obj27 + 312;
				goto IL_03fe;
			}
		}
		goto IL_034a;
		IL_034a:
		return defaultValue;
	}

	private static T Get<T>(Variable variable, T defaultValue) where T : Enum
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0075: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3016;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object value = default(object);
		int defaultValue2 = Convert.ToInt32(value);
		int index = Get(variable, defaultValue2);
		return EnumExtensions.ToEnum(index, defaultValue);
	}

	public static string GetCommand(BaseEvent evt)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_005a: Expected I, but got O
		//IL_006a: Expected O, but got I
		//IL_0114: Expected O, but got I4
		//IL_0188: Expected O, but got I4
		//IL_00a5: Expected O, but got I
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected O, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		BaseEvent baseEvent = default(BaseEvent);
		string text = default(string);
		string result;
		if (baseEvent != null)
		{
			IDictionary<string, object> dictionary = baseEvent.Params;
			if (dictionary != null)
			{
				object obj = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2496;
				object obj2 = "clear_mass_tournaments" + 264;
				nint num = (nint)dictionary;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v6 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+12E]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v6 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00e6;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v6 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+B0]");
				object obj4 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X10_v7-8]");
					if (0 == (nint)obj)
					{
						break;
					}
					obj4 += 16;
					obj3--;
					if ((nint)obj3 != 1)
					{
						continue;
					}
					goto IL_00e6;
				}
				object obj5 = num + obj4;
				object obj6 = obj5 + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v214 @ X8_v14] (should have been resolved before IL gen)");
				bool flag = text == null;
				result = text;
				if (!flag)
				{
					goto IL_0179;
				}
				goto IL_01b7;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_01ca;
		IL_01ca:
		return (string)(object)new InvalidCastException();
		IL_0179:
		object obj7 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v10+90]");
		bool flag2 = text != null;
		result = text;
		if (!flag2)
		{
			goto IL_01b7;
		}
		goto IL_01ca;
		IL_01b7:
		return result;
		IL_00e6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v139 @ X0_v9] (should have been resolved before IL gen)");
		bool flag3 = text == null;
		object obj8 = !flag3;
		if (obj8 != null)
		{
			goto IL_0179;
		}
		result = text;
		goto IL_01b7;
	}

	public static ISFSObject GetResponseParams(BaseEvent evt)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0042: Expected I, but got O
		//IL_0052: Expected O, but got I
		//IL_00e8: Expected O, but got I
		//IL_010c: Expected O, but got I4
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected O, but got Unknown
		//IL_008d: Expected O, but got I
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected O, but got Unknown
		//IL_0152: Expected O, but got I
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		BaseEvent baseEvent = default(BaseEvent);
		IDictionary<string, object> dictionary = baseEvent.Params;
		object obj = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2496;
		object obj2 = "not" + 3352;
		nint num = (nint)dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v6 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+12E]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v6 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00ce;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v6 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+B0]");
		object obj4 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X10_v7-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj4 += 16;
			obj3--;
			if ((nint)obj3 != 1)
			{
				continue;
			}
			goto IL_00ce;
		}
		object obj5 = num + obj4;
		object obj6 = obj5 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v13+8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v220 @ X8_v13] (should have been resolved before IL gen)");
		ISFSObject iSFSObject = default(ISFSObject);
		bool flag = iSFSObject == null;
		ISFSObject iSFSObject2 = iSFSObject;
		if (!flag)
		{
			goto IL_0181;
		}
		goto IL_01bc;
		IL_01bc:
		return iSFSObject2;
		IL_00ce:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v11+8]");
		obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v145 @ X0_v11] (should have been resolved before IL gen)");
		bool flag2 = iSFSObject == null;
		object obj8 = !flag2;
		if (obj8 != null)
		{
			goto IL_0181;
		}
		iSFSObject2 = iSFSObject;
		goto IL_01bc;
		IL_0181:
		object obj9 = typeof(System.IOAsyncCallback) + 976;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
		if (iSFSObject2 != null)
		{
			goto IL_01bc;
		}
		return (ISFSObject)new InvalidCastException();
	}

	public static ISFSObject GetData(BaseEvent evt)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0042: Expected I, but got O
		//IL_0052: Expected O, but got I
		//IL_00e8: Expected O, but got I
		//IL_010c: Expected O, but got I4
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected O, but got Unknown
		//IL_008d: Expected O, but got I
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected O, but got Unknown
		//IL_0152: Expected O, but got I
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		BaseEvent baseEvent = default(BaseEvent);
		IDictionary<string, object> dictionary = baseEvent.Params;
		object obj = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2496;
		object obj2 = "com.unity.services.authentication.profile" + 3040;
		nint num = (nint)dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v6 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+12E]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v6 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00ce;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v6 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+B0]");
		object obj4 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X10_v7-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj4 += 16;
			obj3--;
			if ((nint)obj3 != 1)
			{
				continue;
			}
			goto IL_00ce;
		}
		object obj5 = num + obj4;
		object obj6 = obj5 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v13+8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v220 @ X8_v13] (should have been resolved before IL gen)");
		ISFSObject iSFSObject = default(ISFSObject);
		bool flag = iSFSObject == null;
		ISFSObject iSFSObject2 = iSFSObject;
		if (!flag)
		{
			goto IL_0181;
		}
		goto IL_01bc;
		IL_01bc:
		return iSFSObject2;
		IL_00ce:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v11+8]");
		obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v145 @ X0_v11] (should have been resolved before IL gen)");
		bool flag2 = iSFSObject == null;
		object obj8 = !flag2;
		if (obj8 != null)
		{
			goto IL_0181;
		}
		iSFSObject2 = iSFSObject;
		goto IL_01bc;
		IL_0181:
		object obj9 = typeof(System.IOAsyncCallback) + 976;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
		if (iSFSObject2 != null)
		{
			goto IL_01bc;
		}
		return (ISFSObject)new InvalidCastException();
	}

	public static void PutResponseParams(BaseEvent evt, ISFSObject par)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_004a: Expected I, but got O
		//IL_005a: Expected O, but got I
		//IL_0157: Expected O, but got I
		//IL_0095: Expected O, but got I
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected O, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		BaseEvent baseEvent = default(BaseEvent);
		IDictionary<string, object> dictionary = baseEvent.Params;
		object obj = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2496;
		object obj2 = "not" + 3352;
		object obj3 = obj2;
		nint num = (nint)dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v5 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+12E]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v5 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00d6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v5 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+B0]");
		object obj5 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X10_v5-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj5 += 16;
			obj4--;
			if ((nint)obj4 != 1)
			{
				continue;
			}
			goto IL_00d6;
		}
		object obj6 = obj5 + 5;
		object obj7 = num + obj6;
		object obj8 = obj7 + 312;
		goto IL_013f;
		IL_00d6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj9 = default(object);
		obj8 = obj9;
		goto IL_013f;
		IL_013f:
		object obj10 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v6+8]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v73 @ X4_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public static void PutCommand(BaseEvent evt, string cmd)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_004a: Expected I, but got O
		//IL_005a: Expected O, but got I
		//IL_0157: Expected O, but got I
		//IL_0095: Expected O, but got I
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected O, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		BaseEvent baseEvent = default(BaseEvent);
		IDictionary<string, object> dictionary = baseEvent.Params;
		object obj = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2496;
		object obj2 = "clear_mass_tournaments" + 264;
		object obj3 = obj2;
		nint num = (nint)dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v5 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+12E]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v5 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00d6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v5 (Il2CppClass<System.Collections.Generic.IDictionary`2<System.String, System.Object>>)+B0]");
		object obj5 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X10_v5-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj5 += 16;
			obj4--;
			if ((nint)obj4 != 1)
			{
				continue;
			}
			goto IL_00d6;
		}
		object obj6 = obj5 + 5;
		object obj7 = num + obj6;
		object obj8 = obj7 + 312;
		goto IL_013f;
		IL_00d6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj9 = default(object);
		obj8 = obj9;
		goto IL_013f;
		IL_013f:
		object obj10 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v6+8]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v73 @ X4_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	private static SFSDataWrapper Get(ISFSObject obj, string varName)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_006c: Expected O, but got I
		//IL_00e6: Expected I, but got O
		//IL_00f6: Expected O, but got I
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected O, but got Unknown
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected O, but got Unknown
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Expected O, but got Unknown
		//IL_01ce: Expected O, but got I4
		//IL_0297: Expected O, but got I
		//IL_0131: Expected O, but got I
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected O, but got Unknown
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Expected O, but got Unknown
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected O, but got Unknown
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected O, but got Unknown
		object obj2;
		if (obj != null)
		{
			obj2 = typeof(System.IOAsyncCallback) + 976;
			nint num = (nint)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00ad;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
			object obj4 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X10_v12-8]");
				if (0 == (nint)obj2)
				{
					break;
				}
				obj4 += 16;
				obj3--;
				if ((nint)obj3 != 1)
				{
					continue;
				}
				goto IL_00ad;
			}
			object obj5 = obj4 + 1;
			object obj6 = num + obj5;
			object obj7 = obj6 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v194 @ X0_v15] (should have been resolved before IL gen)");
			object obj8 = default(object);
			bool flag = obj8 == null;
			object obj9 = !flag;
			if (obj9 != null)
			{
				goto IL_00de;
			}
			goto IL_01dc;
		}
		return (SFSDataWrapper)(object)new NullReferenceException();
		IL_00ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v90 @ X0_v12] (should have been resolved before IL gen)");
		object obj10 = default(object);
		if (obj10 != null)
		{
			goto IL_00de;
		}
		goto IL_01dc;
		IL_0172:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_027f;
		IL_01dc:
		return null;
		IL_00de:
		nint num2 = (nint)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0172;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj12 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X10_v7-8]");
			if (0 == (nint)obj2)
			{
				break;
			}
			obj12 += 16;
			obj11--;
			if ((nint)obj11 != 1)
			{
				continue;
			}
			goto IL_0172;
		}
		object obj13 = obj12 + 10;
		object obj14 = num2 + obj13;
		object obj15 = obj14 + 312;
		goto IL_027f;
		IL_027f:
		object obj16 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X0_v6+8]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v119 @ X3_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public static string Get(ISFSObject obj, string varName, string defaultValue)
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00e4: Expected I, but got O
		//IL_00f4: Expected O, but got I
		//IL_012f: Expected O, but got I
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected O, but got Unknown
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected O, but got Unknown
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected O, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		SFSDataWrapper sFSDataWrapper = Get(obj, varName);
		bool flag = sFSDataWrapper == null;
		string result = defaultValue;
		string text = default(string);
		if (!flag)
		{
			int type = sFSDataWrapper.Type;
			int? num = type;
			object obj2 = (object?)num >> 32;
			bool flag2 = obj2 == null;
			result = defaultValue;
			if (!flag2)
			{
				object obj3 = (??)num & 1;
				bool flag3 = obj3 == null;
				result = defaultValue;
				if (!flag3)
				{
					if ((nint)obj2 == 8)
					{
						if (obj != null)
						{
							object obj4 = typeof(System.IOAsyncCallback) + 976;
							nint num2 = (nint)obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
							object obj5 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
							if ((nint)0 == 0)
							{
								goto IL_0170;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
							object obj6 = (nint)0 + (nint)8;
							while (true)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X10_v7-8]");
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
								goto IL_0170;
							}
							object obj7 = obj6 + 18;
							object obj8 = num2 + obj7;
							object obj9 = obj8 + 312;
							goto IL_0256;
						}
					}
					else
					{
						object data = sFSDataWrapper.Data;
						if (data != null)
						{
							text = data.ToString();
							goto IL_0265;
						}
					}
					return (string)(object)new NullReferenceException();
				}
			}
		}
		goto IL_022d;
		IL_0265:
		result = text;
		goto IL_022d;
		IL_022d:
		return result;
		IL_0256:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v264 @ X0_v14] (should have been resolved before IL gen)");
		goto IL_0265;
		IL_0170:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0256;
	}

	public static bool Get(ISFSObject obj, string varName, bool defaultValue)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_02bd: Expected I4, but got O
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected O, but got Unknown
		//IL_01b8: Expected I, but got O
		//IL_01c8: Expected O, but got I
		//IL_03c1: Expected O, but got I4
		//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Expected I4, but got Unknown
		//IL_0203: Expected O, but got I
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00e4: Expected I, but got O
		//IL_00f4: Expected O, but got I
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Expected O, but got Unknown
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected O, but got Unknown
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected O, but got Unknown
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected O, but got Unknown
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected O, but got Unknown
		//IL_012f: Expected O, but got I
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Expected O, but got Unknown
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected O, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected O, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		SFSDataWrapper sFSDataWrapper = Get(obj, varName);
		bool flag = sFSDataWrapper == null;
		bool result = defaultValue;
		if (!flag)
		{
			int type = sFSDataWrapper.Type;
			int? num = type;
			object obj2 = (??)num & 1;
			bool flag2 = obj2 == null;
			result = defaultValue;
			if (!flag2)
			{
				object obj3 = (object?)num >> 32;
				if ((nint)obj3 != 4)
				{
					bool flag3 = (nint)obj3 != 1;
					result = defaultValue;
					if (flag3)
					{
						goto IL_02f3;
					}
					if (obj != null)
					{
						object obj4 = typeof(System.IOAsyncCallback) + 976;
						nint num2 = (nint)obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v14 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
						object obj5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v14 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_0170;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v14 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
						object obj6 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X10_v12-8]");
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
							goto IL_0170;
						}
						object obj7 = obj6 + 11;
						object obj8 = num2 + obj7;
						object obj9 = obj8 + 312;
						goto IL_031c;
					}
				}
				else if (obj != null)
				{
					object obj10 = typeof(System.IOAsyncCallback) + 976;
					nint num3 = (nint)obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
					object obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0244;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
					object obj12 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X10_v6-8]");
						if (0 == (nint)obj10)
						{
							break;
						}
						obj12 += 16;
						obj11--;
						if ((nint)obj11 != 1)
						{
							continue;
						}
						goto IL_0244;
					}
					object obj13 = obj12 + 14;
					object obj14 = num3 + obj13;
					object obj15 = obj14 + 312;
					goto IL_0357;
				}
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
		}
		goto IL_02f3;
		IL_031c:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v348 @ X0_v16] (should have been resolved before IL gen)");
		bool flag4 = default(bool);
		result = flag4;
		goto IL_02f3;
		IL_0170:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_031c;
		IL_0357:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v335 @ X0_v9] (should have been resolved before IL gen)");
		object obj16 = default(object);
		bool flag5 = (nint)obj16 < 0;
		bool flag6 = obj16 == null;
		object obj17 = obj16 ^ obj16;
		object obj18 = obj16 & obj17;
		bool flag7 = (nint)obj18 < 0;
		bool flag8 = flag5 == flag7;
		object obj19 = !flag6;
		return (byte)((flag8 & obj19) ? 1 : 0) != 0;
		IL_0244:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0357;
		IL_02f3:
		return result;
	}

	public static int? GetIntOrNull(ISFSObject obj, string varName)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_016d: Expected O, but got I4
		//IL_006c: Expected O, but got I
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected O, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected O, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected O, but got Unknown
		//IL_0159: Expected O, but got I4
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		if (obj != null)
		{
			object obj2 = typeof(System.IOAsyncCallback) + 976;
			nint num = (nint)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00ad;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
			object obj4 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X10_v6-8]");
				if (0 == (nint)obj2)
				{
					break;
				}
				obj4 += 16;
				obj3--;
				if ((nint)obj3 != 1)
				{
					continue;
				}
				goto IL_00ad;
			}
			object obj5 = obj4 + 1;
			object obj6 = num + obj5;
			object obj7 = obj6 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v198 @ X0_v14] (should have been resolved before IL gen)");
			object obj8 = default(object);
			bool flag = obj8 == null;
			object obj9 = !flag;
			if (obj9 != null)
			{
				goto IL_00de;
			}
			goto IL_0167;
		}
		return (int?)new NullReferenceException();
		IL_0167:
		return (int?)(object)0;
		IL_00ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v93 @ X0_v11] (should have been resolved before IL gen)");
		object obj10 = default(object);
		if (obj10 != null)
		{
			goto IL_00de;
		}
		goto IL_0167;
		IL_00de:
		return Get(obj, varName, 0);
	}

	public static int Get(ISFSObject obj, string varName, int defaultValue)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_0542: Expected I4, but got O
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Expected O, but got Unknown
		//IL_03c2: Expected I, but got O
		//IL_03d2: Expected O, but got I
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Expected O, but got Unknown
		//IL_02ee: Expected I, but got O
		//IL_02fe: Expected O, but got I
		//IL_0683: Expected O, but got I4
		//IL_040d: Expected O, but got I
		//IL_06af: Expected O, but got I4
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected O, but got Unknown
		//IL_021a: Expected I, but got O
		//IL_022a: Expected O, but got I
		//IL_0339: Expected O, but got I
		//IL_04f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f5: Expected O, but got Unknown
		//IL_04fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0502: Expected O, but got Unknown
		//IL_050b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0510: Expected O, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		//IL_0101: Expected I, but got O
		//IL_0111: Expected O, but got I
		//IL_0522: Expected I4, but got I8
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0420: Expected O, but got Unknown
		//IL_0429: Unknown result type (might be due to invalid IL or missing references)
		//IL_042e: Expected O, but got Unknown
		//IL_05f8: Expected O, but got I8
		//IL_0265: Expected O, but got I
		//IL_04c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c7: Expected O, but got Unknown
		//IL_04cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d4: Expected O, but got Unknown
		//IL_04dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e2: Expected O, but got Unknown
		//IL_0347: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Expected O, but got Unknown
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected O, but got Unknown
		//IL_014c: Expected O, but got I
		//IL_0494: Unknown result type (might be due to invalid IL or missing references)
		//IL_0499: Expected O, but got Unknown
		//IL_04a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a6: Expected O, but got Unknown
		//IL_04af: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b4: Expected O, but got Unknown
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected O, but got Unknown
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected O, but got Unknown
		//IL_0466: Unknown result type (might be due to invalid IL or missing references)
		//IL_046b: Expected O, but got Unknown
		//IL_0473: Unknown result type (might be due to invalid IL or missing references)
		//IL_0478: Expected O, but got Unknown
		//IL_0481: Unknown result type (might be due to invalid IL or missing references)
		//IL_0486: Expected O, but got Unknown
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected O, but got Unknown
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected O, but got Unknown
		SFSDataWrapper sFSDataWrapper = Get(obj, varName);
		bool flag = sFSDataWrapper == null;
		int result = defaultValue;
		if (!flag)
		{
			int type = sFSDataWrapper.Type;
			int? num = type;
			object obj2 = (??)num & 1;
			bool flag2 = obj2 == null;
			result = defaultValue;
			if (!flag2)
			{
				object obj3 = (object?)num >> 32;
				if ((nint)obj3 <= 5)
				{
					if ((nint)obj3 != 4)
					{
						bool flag3 = (nint)obj3 != 5;
						result = defaultValue;
						if (flag3)
						{
							goto IL_0578;
						}
						if (obj != null)
						{
							object obj4 = typeof(System.IOAsyncCallback) + 976;
							nint num2 = (nint)obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X8_v29 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
							object obj5 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X8_v29 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
							if ((nint)0 == 0)
							{
								goto IL_018d;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X8_v29 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
							object obj6 = (nint)0 + (nint)8;
							while (true)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ X10_v25-8]");
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
								goto IL_018d;
							}
							object obj7 = obj6 + 15;
							object obj8 = num2 + obj7;
							object obj9 = obj8 + 312;
							goto IL_05a1;
						}
					}
					else if (obj != null)
					{
						object obj10 = typeof(System.IOAsyncCallback) + 976;
						nint num3 = (nint)obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v23 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
						object obj11 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v23 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_037a;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v23 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
						object obj12 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X10_v19-8]");
							if (0 == (nint)obj10)
							{
								break;
							}
							obj12 += 16;
							obj11--;
							if ((nint)obj11 != 1)
							{
								continue;
							}
							goto IL_037a;
						}
						object obj13 = obj12 + 14;
						object obj14 = num3 + obj13;
						object obj15 = obj14 + 312;
						goto IL_0638;
					}
				}
				else if ((nint)obj3 != 6)
				{
					bool flag4 = (nint)obj3 != 7;
					result = defaultValue;
					if (flag4)
					{
						goto IL_0578;
					}
					if (obj != null)
					{
						object obj16 = typeof(System.IOAsyncCallback) + 976;
						nint num4 = (nint)obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X8_v16 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
						object obj17 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X8_v16 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_02a6;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X8_v16 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
						object obj18 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v482 @ X10_v13-8]");
							if (0 == (nint)obj16)
							{
								break;
							}
							obj18 += 16;
							obj17--;
							if ((nint)obj17 != 1)
							{
								continue;
							}
							goto IL_02a6;
						}
						object obj19 = obj18 + 17;
						object obj20 = num4 + obj19;
						object obj21 = obj20 + 312;
						goto IL_05dc;
					}
				}
				else if (obj != null)
				{
					object obj22 = typeof(System.IOAsyncCallback) + 976;
					nint num5 = (nint)obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
					object obj23 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_044e;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
					object obj24 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X10_v7-8]");
						if (0 == (nint)obj22)
						{
							break;
						}
						obj24 += 16;
						obj23--;
						if ((nint)obj23 != 1)
						{
							continue;
						}
						goto IL_044e;
					}
					object obj25 = obj24 + 16;
					object obj26 = num5 + obj25;
					object obj27 = obj26 + 312;
					goto IL_066b;
				}
				NullReferenceException ex = new NullReferenceException();
				return (int)ex;
			}
		}
		goto IL_0578;
		IL_066b:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v520 @ X0_v11] (should have been resolved before IL gen)");
		int num6 = default(int);
		object obj28 = num6 - 2139095040;
		bool flag5 = obj28 == null;
		int result2 = num6;
		goto IL_06a4;
		IL_018d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_05a1;
		IL_037a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0638;
		IL_0638:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v478 @ X0_v23] (should have been resolved before IL gen)");
		int result3 = default(int);
		return result3;
		IL_05a1:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v545 @ X0_v29] (should have been resolved before IL gen)");
		int num7 = default(int);
		result = num7;
		goto IL_0578;
		IL_06a4:
		object obj29 = !flag5;
		if (obj29 == null)
		{
			return -2147483648;
		}
		return result2;
		IL_02a6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_05dc;
		IL_05dc:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v566 @ X0_v17] (should have been resolved before IL gen)");
		object obj30 = num6 - 9218868437227405312L;
		flag5 = obj30 == null;
		result2 = num6;
		goto IL_06a4;
		IL_0578:
		return result;
		IL_044e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_066b;
	}

	public static long Get(ISFSObject obj, string varName, long defaultValue)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_0542: Expected I8, but got O
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Expected O, but got Unknown
		//IL_03c2: Expected I, but got O
		//IL_03d2: Expected O, but got I
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Expected O, but got Unknown
		//IL_02ee: Expected I, but got O
		//IL_02fe: Expected O, but got I
		//IL_0683: Expected O, but got I8
		//IL_040d: Expected O, but got I
		//IL_06af: Expected O, but got I4
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected O, but got Unknown
		//IL_021a: Expected I, but got O
		//IL_022a: Expected O, but got I
		//IL_0339: Expected O, but got I
		//IL_04f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f5: Expected O, but got Unknown
		//IL_04fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0502: Expected O, but got Unknown
		//IL_050b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0510: Expected O, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		//IL_0101: Expected I, but got O
		//IL_0111: Expected O, but got I
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0420: Expected O, but got Unknown
		//IL_0429: Unknown result type (might be due to invalid IL or missing references)
		//IL_042e: Expected O, but got Unknown
		//IL_05f8: Expected O, but got I8
		//IL_0265: Expected O, but got I
		//IL_04c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c7: Expected O, but got Unknown
		//IL_04cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d4: Expected O, but got Unknown
		//IL_04dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e2: Expected O, but got Unknown
		//IL_0347: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Expected O, but got Unknown
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected O, but got Unknown
		//IL_014c: Expected O, but got I
		//IL_0494: Unknown result type (might be due to invalid IL or missing references)
		//IL_0499: Expected O, but got Unknown
		//IL_04a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a6: Expected O, but got Unknown
		//IL_04af: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b4: Expected O, but got Unknown
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected O, but got Unknown
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected O, but got Unknown
		//IL_0466: Unknown result type (might be due to invalid IL or missing references)
		//IL_046b: Expected O, but got Unknown
		//IL_0473: Unknown result type (might be due to invalid IL or missing references)
		//IL_0478: Expected O, but got Unknown
		//IL_0481: Unknown result type (might be due to invalid IL or missing references)
		//IL_0486: Expected O, but got Unknown
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected O, but got Unknown
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected O, but got Unknown
		SFSDataWrapper sFSDataWrapper = Get(obj, varName);
		bool flag = sFSDataWrapper == null;
		long result = defaultValue;
		if (!flag)
		{
			int type = sFSDataWrapper.Type;
			int? num = type;
			object obj2 = (??)num & 1;
			bool flag2 = obj2 == null;
			result = defaultValue;
			if (!flag2)
			{
				object obj3 = (object?)num >> 32;
				if ((nint)obj3 <= 5)
				{
					if ((nint)obj3 != 4)
					{
						bool flag3 = (nint)obj3 != 5;
						result = defaultValue;
						if (flag3)
						{
							goto IL_0578;
						}
						if (obj != null)
						{
							object obj4 = typeof(System.IOAsyncCallback) + 976;
							nint num2 = (nint)obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X8_v29 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
							object obj5 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X8_v29 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
							if ((nint)0 == 0)
							{
								goto IL_018d;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X8_v29 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
							object obj6 = (nint)0 + (nint)8;
							while (true)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ X10_v25-8]");
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
								goto IL_018d;
							}
							object obj7 = obj6 + 15;
							object obj8 = num2 + obj7;
							object obj9 = obj8 + 312;
							goto IL_05a1;
						}
					}
					else if (obj != null)
					{
						object obj10 = typeof(System.IOAsyncCallback) + 976;
						nint num3 = (nint)obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v23 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
						object obj11 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v23 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_037a;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v23 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
						object obj12 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X10_v19-8]");
							if (0 == (nint)obj10)
							{
								break;
							}
							obj12 += 16;
							obj11--;
							if ((nint)obj11 != 1)
							{
								continue;
							}
							goto IL_037a;
						}
						object obj13 = obj12 + 14;
						object obj14 = num3 + obj13;
						object obj15 = obj14 + 312;
						goto IL_0638;
					}
				}
				else if ((nint)obj3 != 6)
				{
					bool flag4 = (nint)obj3 != 7;
					result = defaultValue;
					if (flag4)
					{
						goto IL_0578;
					}
					if (obj != null)
					{
						object obj16 = typeof(System.IOAsyncCallback) + 976;
						nint num4 = (nint)obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X8_v16 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
						object obj17 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X8_v16 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_02a6;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X8_v16 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
						object obj18 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ X10_v13-8]");
							if (0 == (nint)obj16)
							{
								break;
							}
							obj18 += 16;
							obj17--;
							if ((nint)obj17 != 1)
							{
								continue;
							}
							goto IL_02a6;
						}
						object obj19 = obj18 + 17;
						object obj20 = num4 + obj19;
						object obj21 = obj20 + 312;
						goto IL_05dc;
					}
				}
				else if (obj != null)
				{
					object obj22 = typeof(System.IOAsyncCallback) + 976;
					nint num5 = (nint)obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
					object obj23 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_044e;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
					object obj24 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X10_v7-8]");
						if (0 == (nint)obj22)
						{
							break;
						}
						obj24 += 16;
						obj23--;
						if ((nint)obj23 != 1)
						{
							continue;
						}
						goto IL_044e;
					}
					object obj25 = obj24 + 16;
					object obj26 = num5 + obj25;
					object obj27 = obj26 + 312;
					goto IL_066b;
				}
				NullReferenceException ex = new NullReferenceException();
				return (long)ex;
			}
		}
		goto IL_0578;
		IL_066b:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v522 @ X0_v11] (should have been resolved before IL gen)");
		long num6 = default(long);
		object obj28 = num6 - 2139095040;
		bool flag5 = obj28 == null;
		long result2 = num6;
		goto IL_06a4;
		IL_018d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_05a1;
		IL_037a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0638;
		IL_0638:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v478 @ X0_v23] (should have been resolved before IL gen)");
		long result3 = default(long);
		return result3;
		IL_05a1:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v547 @ X0_v30] (should have been resolved before IL gen)");
		long num7 = default(long);
		result = num7;
		goto IL_0578;
		IL_06a4:
		object obj29 = !flag5;
		if (obj29 == null)
		{
			return -9223372036854775808L;
		}
		return result2;
		IL_02a6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_05dc;
		IL_05dc:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v568 @ X0_v17] (should have been resolved before IL gen)");
		object obj30 = num6 - 9218868437227405312L;
		flag5 = obj30 == null;
		result2 = num6;
		goto IL_06a4;
		IL_0578:
		return result;
		IL_044e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_066b;
	}

	public static float Get(ISFSObject obj, string varName, float defaultValue)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Expected O, but got Unknown
		//IL_034e: Expected I, but got O
		//IL_035e: Expected O, but got I
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Expected O, but got Unknown
		//IL_0297: Expected I, but got O
		//IL_02a7: Expected O, but got I
		//IL_0399: Expected O, but got I
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected O, but got Unknown
		//IL_01e0: Expected I, but got O
		//IL_01f0: Expected O, but got I
		//IL_02e2: Expected O, but got I
		//IL_047c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0481: Expected O, but got Unknown
		//IL_0489: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Expected O, but got Unknown
		//IL_0497: Unknown result type (might be due to invalid IL or missing references)
		//IL_049c: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00e4: Expected I, but got O
		//IL_00f4: Expected O, but got I
		//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ac: Expected O, but got Unknown
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Expected O, but got Unknown
		//IL_022b: Expected O, but got I
		//IL_044e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Expected O, but got Unknown
		//IL_045b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0460: Expected O, but got Unknown
		//IL_0469: Unknown result type (might be due to invalid IL or missing references)
		//IL_046e: Expected O, but got Unknown
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Expected O, but got Unknown
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Expected O, but got Unknown
		//IL_012f: Expected O, but got I
		//IL_0420: Unknown result type (might be due to invalid IL or missing references)
		//IL_0425: Expected O, but got Unknown
		//IL_042d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0432: Expected O, but got Unknown
		//IL_043b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0440: Expected O, but got Unknown
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Expected O, but got Unknown
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected O, but got Unknown
		//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f7: Expected O, but got Unknown
		//IL_03ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0404: Expected O, but got Unknown
		//IL_040d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0412: Expected O, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected O, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		SFSDataWrapper sFSDataWrapper = Get(obj, varName);
		bool flag = sFSDataWrapper == null;
		float result = defaultValue;
		if (!flag)
		{
			int type = sFSDataWrapper.Type;
			int? num = type;
			object obj2 = (??)num & 1;
			bool flag2 = obj2 == null;
			result = defaultValue;
			if (!flag2)
			{
				object obj3 = (object?)num >> 32;
				if ((nint)obj3 <= 5)
				{
					if ((nint)obj3 == 4)
					{
						object obj4 = typeof(System.IOAsyncCallback) + 976;
						nint num2 = (nint)obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X8_v20 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
						object obj5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X8_v20 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_0323;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X8_v20 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
						object obj6 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X10_v18-8]");
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
							goto IL_0323;
						}
						object obj7 = obj6 + 14;
						object obj8 = num2 + obj7;
						object obj9 = obj8 + 312;
						goto IL_0576;
					}
					bool flag3 = (nint)obj3 != 5;
					result = defaultValue;
					if (!flag3)
					{
						object obj10 = typeof(System.IOAsyncCallback) + 976;
						nint num3 = (nint)obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X8_v26 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
						object obj11 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X8_v26 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_0170;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X8_v26 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
						object obj12 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ X10_v24-8]");
							if (0 == (nint)obj10)
							{
								break;
							}
							obj12 += 16;
							obj11--;
							if ((nint)obj11 != 1)
							{
								continue;
							}
							goto IL_0170;
						}
						object obj13 = obj12 + 15;
						object obj14 = num3 + obj13;
						object obj15 = obj14 + 312;
						goto IL_0500;
					}
				}
				else
				{
					if ((nint)obj3 == 6)
					{
						object obj16 = typeof(System.IOAsyncCallback) + 976;
						nint num4 = (nint)obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
						object obj17 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_03da;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
						object obj18 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X10_v6-8]");
							if (0 == (nint)obj16)
							{
								break;
							}
							obj18 += 16;
							obj17--;
							if ((nint)obj17 != 1)
							{
								continue;
							}
							goto IL_03da;
						}
						object obj19 = obj18 + 16;
						object obj20 = num4 + obj19;
						object obj21 = obj20 + 312;
						goto IL_05b1;
					}
					bool flag4 = (nint)obj3 != 7;
					result = defaultValue;
					if (!flag4)
					{
						object obj22 = typeof(System.IOAsyncCallback) + 976;
						nint num5 = (nint)obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X8_v14 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
						object obj23 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X8_v14 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_026c;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X8_v14 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
						object obj24 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X10_v12-8]");
							if (0 == (nint)obj22)
							{
								break;
							}
							obj24 += 16;
							obj23--;
							if ((nint)obj23 != 1)
							{
								continue;
							}
							goto IL_026c;
						}
						object obj25 = obj24 + 17;
						object obj26 = num5 + obj25;
						object obj27 = obj26 + 312;
						goto IL_053b;
					}
				}
			}
		}
		goto IL_04d7;
		IL_05b1:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v518 @ X0_v8] (should have been resolved before IL gen)");
		result = defaultValue;
		goto IL_04d7;
		IL_0500:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v527 @ X0_v26] (should have been resolved before IL gen)");
		float num6 = default(float);
		result = num6;
		goto IL_04d7;
		IL_0576:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v488 @ X0_v20] (should have been resolved before IL gen)");
		float num7 = default(float);
		result = num7;
		goto IL_04d7;
		IL_0170:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0500;
		IL_026c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_053b;
		IL_053b:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v536 @ X0_v14] (should have been resolved before IL gen)");
		result = defaultValue;
		goto IL_04d7;
		IL_0323:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0576;
		IL_04d7:
		return result;
		IL_03da:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_05b1;
	}

	public static double Get(ISFSObject obj, string varName, double defaultValue)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Expected O, but got Unknown
		//IL_034e: Expected I, but got O
		//IL_035e: Expected O, but got I
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Expected O, but got Unknown
		//IL_0297: Expected I, but got O
		//IL_02a7: Expected O, but got I
		//IL_0399: Expected O, but got I
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected O, but got Unknown
		//IL_01e0: Expected I, but got O
		//IL_01f0: Expected O, but got I
		//IL_02e2: Expected O, but got I
		//IL_047c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0481: Expected O, but got Unknown
		//IL_0489: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Expected O, but got Unknown
		//IL_0497: Unknown result type (might be due to invalid IL or missing references)
		//IL_049c: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00e4: Expected I, but got O
		//IL_00f4: Expected O, but got I
		//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ac: Expected O, but got Unknown
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Expected O, but got Unknown
		//IL_022b: Expected O, but got I
		//IL_044e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Expected O, but got Unknown
		//IL_045b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0460: Expected O, but got Unknown
		//IL_0469: Unknown result type (might be due to invalid IL or missing references)
		//IL_046e: Expected O, but got Unknown
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Expected O, but got Unknown
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Expected O, but got Unknown
		//IL_012f: Expected O, but got I
		//IL_0420: Unknown result type (might be due to invalid IL or missing references)
		//IL_0425: Expected O, but got Unknown
		//IL_042d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0432: Expected O, but got Unknown
		//IL_043b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0440: Expected O, but got Unknown
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Expected O, but got Unknown
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected O, but got Unknown
		//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f7: Expected O, but got Unknown
		//IL_03ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0404: Expected O, but got Unknown
		//IL_040d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0412: Expected O, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected O, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		SFSDataWrapper sFSDataWrapper = Get(obj, varName);
		bool flag = sFSDataWrapper == null;
		double result = defaultValue;
		if (!flag)
		{
			int type = sFSDataWrapper.Type;
			int? num = type;
			object obj2 = (??)num & 1;
			bool flag2 = obj2 == null;
			result = defaultValue;
			if (!flag2)
			{
				object obj3 = (object?)num >> 32;
				if ((nint)obj3 <= 5)
				{
					if ((nint)obj3 == 4)
					{
						object obj4 = typeof(System.IOAsyncCallback) + 976;
						nint num2 = (nint)obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X8_v20 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
						object obj5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X8_v20 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_0323;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X8_v20 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
						object obj6 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X10_v18-8]");
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
							goto IL_0323;
						}
						object obj7 = obj6 + 14;
						object obj8 = num2 + obj7;
						object obj9 = obj8 + 312;
						goto IL_0576;
					}
					bool flag3 = (nint)obj3 != 5;
					result = defaultValue;
					if (!flag3)
					{
						object obj10 = typeof(System.IOAsyncCallback) + 976;
						nint num3 = (nint)obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X8_v26 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
						object obj11 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X8_v26 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_0170;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X8_v26 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
						object obj12 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ X10_v24-8]");
							if (0 == (nint)obj10)
							{
								break;
							}
							obj12 += 16;
							obj11--;
							if ((nint)obj11 != 1)
							{
								continue;
							}
							goto IL_0170;
						}
						object obj13 = obj12 + 15;
						object obj14 = num3 + obj13;
						object obj15 = obj14 + 312;
						goto IL_0500;
					}
				}
				else
				{
					if ((nint)obj3 == 6)
					{
						object obj16 = typeof(System.IOAsyncCallback) + 976;
						nint num4 = (nint)obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
						object obj17 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_03da;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
						object obj18 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X10_v6-8]");
							if (0 == (nint)obj16)
							{
								break;
							}
							obj18 += 16;
							obj17--;
							if ((nint)obj17 != 1)
							{
								continue;
							}
							goto IL_03da;
						}
						object obj19 = obj18 + 16;
						object obj20 = num4 + obj19;
						object obj21 = obj20 + 312;
						goto IL_05b1;
					}
					bool flag4 = (nint)obj3 != 7;
					result = defaultValue;
					if (!flag4)
					{
						object obj22 = typeof(System.IOAsyncCallback) + 976;
						nint num5 = (nint)obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X8_v14 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
						object obj23 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X8_v14 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_026c;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X8_v14 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
						object obj24 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X10_v12-8]");
							if (0 == (nint)obj22)
							{
								break;
							}
							obj24 += 16;
							obj23--;
							if ((nint)obj23 != 1)
							{
								continue;
							}
							goto IL_026c;
						}
						object obj25 = obj24 + 17;
						object obj26 = num5 + obj25;
						object obj27 = obj26 + 312;
						goto IL_053b;
					}
				}
			}
		}
		goto IL_04d7;
		IL_05b1:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v518 @ X0_v8] (should have been resolved before IL gen)");
		result = defaultValue;
		goto IL_04d7;
		IL_0500:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v527 @ X0_v26] (should have been resolved before IL gen)");
		double num6 = default(double);
		result = num6;
		goto IL_04d7;
		IL_0576:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v488 @ X0_v20] (should have been resolved before IL gen)");
		double num7 = default(double);
		result = num7;
		goto IL_04d7;
		IL_0170:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0500;
		IL_026c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_053b;
		IL_053b:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v536 @ X0_v14] (should have been resolved before IL gen)");
		result = defaultValue;
		goto IL_04d7;
		IL_0323:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0576;
		IL_04d7:
		return result;
		IL_03da:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_05b1;
	}

	public static int[] Get(ISFSObject obj, string varName, int[] defaultValue)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_00bf: Expected I, but got O
		object obj2 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2448;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj3 = default(object);
		obj3..ctor();
		if (obj3 != null)
		{
			object obj4 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 2056;
			object obj5 = (nint)0 + (nint)1280;
			object obj6 = obj3 + 16;
			obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj7 = obj3 + 24;
			obj7 = varName;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj8 = obj3 + 32;
			obj8 = defaultValue;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object> func = default(Func<object>);
			func..ctor(obj3, (IntPtr)obj5);
			return (int[])GetSafely(func, obj8);
		}
		return (int[])(object)new NullReferenceException();
	}

	public static string[] Get(ISFSObject obj, string varName, string[] defaultValue)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_00bf: Expected I, but got O
		object obj2 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2456;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj3 = default(object);
		obj3..ctor();
		if (obj3 != null)
		{
			object obj4 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 2064;
			object obj5 = (nint)0 + (nint)1288;
			object obj6 = obj3 + 16;
			obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj7 = obj3 + 24;
			obj7 = varName;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj8 = obj3 + 32;
			obj8 = defaultValue;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object> func = default(Func<object>);
			func..ctor(obj3, (IntPtr)obj5);
			return (string[])GetSafely(func, obj8);
		}
		return (string[])(object)new NullReferenceException();
	}

	public static DateTime? Get(ISFSObject obj, string varName, DateTime? defaultValue)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_00a3: Expected I, but got O
		object obj2 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2464;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj3 = default(object);
		obj3..ctor();
		if (obj3 != null)
		{
			object obj4 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 1960;
			object obj5 = (nint)0 + (nint)1296;
			object obj6 = obj3 + 16;
			obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj7 = obj3 + 24;
			obj7 = varName;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<DateTime?> func = default(Func<DateTime?>);
			func..ctor(obj3, (IntPtr)obj5);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @301F200");
			DateTime? result = default(DateTime?);
			return result;
		}
		return (DateTime?)new NullReferenceException();
	}

	public static T Get<T>(ISFSObject obj, string varName, T defaultValue) where T : Enum
	{
		//IL_002a: Expected I4, but got I8
		ISFSObject obj2 = default(ISFSObject);
		string varName2 = default(string);
		int index = Get(obj2, varName2, -1);
		return EnumExtensions.ToEnum(index, defaultValue);
	}

	public unsafe static List<T> GetEnumList<T>(ISFSObject obj, string varName, T defaultValue) where T : Enum
	{
		//IL_0016: Expected O, but got I
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_003e: Expected O, but got I4
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_00da: Expected I, but got O
		//IL_00ea: Expected O, but got I
		//IL_0180: Expected O, but got I
		//IL_0125: Expected O, but got I
		//IL_01bb: Expected O, but got I
		//IL_01d4: Expected O, but got I
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Expected O, but got Unknown
		//IL_01fc: Expected O, but got I4
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Expected O, but got Unknown
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Expected O, but got Unknown
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Expected O, but got Unknown
		//IL_02a2: Expected O, but got I
		//IL_02c6: Expected O, but got I4
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected O, but got Unknown
		object obj2 = (nint)0 + (nint)309;
		object obj3 = obj2 & 1;
		bool flag = obj3 == null;
		object obj4 = !flag;
		nint num = 0;
		nint num2 = 0;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj5 = default(object);
		((<>c__DisplayClass39_0<T>)obj5)..ctor();
		IEnumerable<int> enumerable = default(IEnumerable<int>);
		List<T> result;
		object obj12;
		if (obj5 != null && obj != null)
		{
			object obj6 = typeof(System.IOAsyncCallback) + 976;
			nint num3 = (nint)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0166;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
			object obj8 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X10_v6-8]");
				if (0 == (nint)obj6)
				{
					break;
				}
				obj8 += 16;
				obj7--;
				if ((nint)obj7 != 1)
				{
					continue;
				}
				goto IL_0166;
			}
			object obj9 = obj8 + 23;
			object obj10 = num3 + obj9;
			object obj11 = obj10 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X0_v18+8]");
			obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v236 @ X0_v18] (should have been resolved before IL gen)");
			bool flag2 = enumerable == null;
			object obj13 = !flag2;
			result = (List<T>)enumerable;
			if (obj13 != null)
			{
				goto IL_01af;
			}
			goto IL_02dc;
		}
		return (List<T>)(object)new NullReferenceException();
		IL_02dc:
		return result;
		IL_01af:
		object obj14 = (nint)0 + (nint)2200;
		List<int> source = Enumerable.ToList(enumerable);
		object obj15 = (nint)0 + (nint)309;
		object obj16 = obj15 & 1;
		bool flag3 = obj16 == null;
		object obj17 = !flag3;
		nint num4 = 0;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<int, System.Int32Enum> func = default(Func<int, System.Int32Enum>);
		func..ctor(obj5, (IntPtr)(nint)__ldftn(<>c__DisplayClass39_0<T>.<GetEnumList>b__0));
		IEnumerable<System.Int32Enum> source2 = Enumerable.Select(source, func);
		return (List<T>)(object)Enumerable.ToList(source2);
		IL_0166:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v15+8]");
		obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v126 @ X0_v15] (should have been resolved before IL gen)");
		bool flag4 = enumerable == null;
		result = (List<T>)enumerable;
		if (!flag4)
		{
			goto IL_01af;
		}
		goto IL_02dc;
	}

	public static void Put(ISFSObject obj, string key, string val)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_0126: Expected O, but got I
		//IL_006c: Expected O, but got I
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		object obj2 = typeof(System.IOAsyncCallback) + 976;
		nint num = (nint)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00ad;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj4 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X10_v5-8]");
			if (0 == (nint)obj2)
			{
				break;
			}
			obj4 += 16;
			obj3--;
			if ((nint)obj3 != 1)
			{
				continue;
			}
			goto IL_00ad;
		}
		object obj5 = obj4 + 39;
		object obj6 = num + obj5;
		object obj7 = obj6 + 312;
		goto IL_010e;
		IL_00ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_010e;
		IL_010e:
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v3+8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v118 @ X4_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public static void Put(ISFSObject obj, string key, int val)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_0126: Expected O, but got I
		//IL_006c: Expected O, but got I
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		object obj2 = typeof(System.IOAsyncCallback) + 976;
		nint num = (nint)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00ad;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj4 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X10_v5-8]");
			if (0 == (nint)obj2)
			{
				break;
			}
			obj4 += 16;
			obj3--;
			if ((nint)obj3 != 1)
			{
				continue;
			}
			goto IL_00ad;
		}
		object obj5 = obj4 + 35;
		object obj6 = num + obj5;
		object obj7 = obj6 + 312;
		goto IL_010e;
		IL_00ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_010e;
		IL_010e:
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v3+8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v118 @ X4_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public static void Put(ISFSObject obj, string key, float val)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_0126: Expected O, but got I
		//IL_006c: Expected O, but got I
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		object obj2 = typeof(System.IOAsyncCallback) + 976;
		nint num = (nint)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00ad;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj4 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X10_v5-8]");
			if (0 == (nint)obj2)
			{
				break;
			}
			obj4 += 16;
			obj3--;
			if ((nint)obj3 != 1)
			{
				continue;
			}
			goto IL_00ad;
		}
		object obj5 = obj4 + 37;
		object obj6 = num + obj5;
		object obj7 = obj6 + 312;
		goto IL_010e;
		IL_00ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_010e;
		IL_010e:
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X0_v3+8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v126 @ X3_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public static void Put(ISFSObject obj, string key, long val)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_0126: Expected O, but got I
		//IL_006c: Expected O, but got I
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		object obj2 = typeof(System.IOAsyncCallback) + 976;
		nint num = (nint)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00ad;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj4 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X10_v5-8]");
			if (0 == (nint)obj2)
			{
				break;
			}
			obj4 += 16;
			obj3--;
			if ((nint)obj3 != 1)
			{
				continue;
			}
			goto IL_00ad;
		}
		object obj5 = obj4 + 36;
		object obj6 = num + obj5;
		object obj7 = obj6 + 312;
		goto IL_010e;
		IL_00ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_010e;
		IL_010e:
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v3+8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v118 @ X4_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public static void Put(ISFSObject obj, string key, double val)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_0126: Expected O, but got I
		//IL_006c: Expected O, but got I
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		object obj2 = typeof(System.IOAsyncCallback) + 976;
		nint num = (nint)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00ad;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj4 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X10_v5-8]");
			if (0 == (nint)obj2)
			{
				break;
			}
			obj4 += 16;
			obj3--;
			if ((nint)obj3 != 1)
			{
				continue;
			}
			goto IL_00ad;
		}
		object obj5 = obj4 + 38;
		object obj6 = num + obj5;
		object obj7 = obj6 + 312;
		goto IL_010e;
		IL_00ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_010e;
		IL_010e:
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X0_v3+8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v126 @ X3_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public static void Put(ISFSObject obj, string key, bool val)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_0126: Expected O, but got I
		//IL_006c: Expected O, but got I
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		object obj2 = typeof(System.IOAsyncCallback) + 976;
		nint num = (nint)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00ad;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj4 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X10_v5-8]");
			if (0 == (nint)obj2)
			{
				break;
			}
			obj4 += 16;
			obj3--;
			if ((nint)obj3 != 1)
			{
				continue;
			}
			goto IL_00ad;
		}
		object obj5 = obj4 + 32;
		object obj6 = num + obj5;
		object obj7 = obj6 + 312;
		goto IL_010e;
		IL_00ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_010e;
		IL_010e:
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v3+8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v118 @ X4_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public static void PutDate(ISFSObject obj, string key, DateTime date)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_01b5: Expected O, but got I4
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_00da: Expected I, but got O
		//IL_00ea: Expected O, but got I
		//IL_0209: Expected O, but got I4
		//IL_0294: Expected O, but got I
		//IL_0125: Expected O, but got I
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Expected O, but got Unknown
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected O, but got Unknown
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected O, but got Unknown
		object obj2 = typeof(DataRelation) + 824;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5DBA]");
		object obj3 = (nint)0 & (nint)1;
		nint num2;
		nint num;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v7+E4]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v7+E4]");
			bool flag = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v7+E4]");
			num2 = 0;
			if (!flag)
			{
				goto IL_0094;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v7+E4]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v7+E4]");
			num2 = 0;
			if (obj5 != null)
			{
				goto IL_0094;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		long num3 = DateTimeUtil.ToUniversalTimestamp(date);
		bool flag3 = obj == null;
		object obj6 = !flag3;
		num = num2;
		if (obj6 != null)
		{
			goto IL_00be;
		}
		goto IL_021f;
		IL_027c:
		object obj8 = default(object);
		object obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X0_v1+8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v190 @ X4_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
		IL_0166:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_027c;
		IL_00be:
		object obj10 = typeof(System.IOAsyncCallback) + 976;
		num = (nint)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v3 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v3 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0166;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v3 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj12 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X10_v2-8]");
			if (0 == (nint)obj10)
			{
				break;
			}
			obj12 += 16;
			obj11--;
			if ((nint)obj11 != 1)
			{
				continue;
			}
			goto IL_0166;
		}
		object obj13 = obj12 + 36;
		object obj14 = num + obj13;
		obj8 = obj14 + 312;
		goto IL_027c;
		IL_0094:
		num3 = DateTimeUtil.ToUniversalTimestamp(date);
		if (obj != null)
		{
			goto IL_00be;
		}
		goto IL_021f;
		IL_021f:
		throw new NullReferenceException();
	}

	public static void Put(ISFSObject obj, string key, List<string> val)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0034: Expected I, but got O
		//IL_0044: Expected O, but got I
		//IL_0139: Expected O, but got I
		//IL_007f: Expected O, but got I
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		object[] array = ((List<object>)(object)val).ToArray();
		object obj2 = typeof(System.IOAsyncCallback) + 976;
		nint num = (nint)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00c0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj4 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X10_v5-8]");
			if (0 == (nint)obj2)
			{
				break;
			}
			obj4 += 16;
			obj3--;
			if ((nint)obj3 != 1)
			{
				continue;
			}
			goto IL_00c0;
		}
		object obj5 = obj4 + 48;
		object obj6 = num + obj5;
		object obj7 = obj6 + 312;
		goto IL_0121;
		IL_00c0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0121;
		IL_0121:
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X0_v6+8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v71 @ X4_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public static void Put(ISFSObject obj, string key, List<int> val)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0034: Expected I, but got O
		//IL_0044: Expected O, but got I
		//IL_0139: Expected O, but got I
		//IL_007f: Expected O, but got I
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		int[] array = val.ToArray();
		object obj2 = typeof(System.IOAsyncCallback) + 976;
		nint num = (nint)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00c0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj4 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X10_v5-8]");
			if (0 == (nint)obj2)
			{
				break;
			}
			obj4 += 16;
			obj3--;
			if ((nint)obj3 != 1)
			{
				continue;
			}
			goto IL_00c0;
		}
		object obj5 = obj4 + 44;
		object obj6 = num + obj5;
		object obj7 = obj6 + 312;
		goto IL_0121;
		IL_00c0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0121;
		IL_0121:
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X0_v6+8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v71 @ X4_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public static void Put<T>(ISFSObject obj, string key, T val) where T : Enum
	{
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected O, but got Unknown
		//IL_0155: Expected O, but got I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0044: Expected I, but got O
		//IL_0054: Expected O, but got I
		//IL_008f: Expected O, but got I
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3016;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object value = default(object);
		int num = Convert.ToInt32(value);
		object obj5 = typeof(System.IOAsyncCallback) + 976;
		nint num2 = (nint)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00d0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj7 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X10_v5-8]");
			if (0 == (nint)obj5)
			{
				break;
			}
			obj7 += 16;
			obj6--;
			if ((nint)obj6 != 1)
			{
				continue;
			}
			goto IL_00d0;
		}
		object obj8 = obj7 + 35;
		object obj9 = num2 + obj8;
		object obj10 = obj9 + 312;
		goto IL_0199;
		IL_0199:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v194 @ X0_v7] (should have been resolved before IL gen)");
		return;
		IL_00d0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0199;
	}

	public static bool IsNullOrEmpty(ISFSArray array)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_006c: Expected O, but got I
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		if (array != null)
		{
			object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 1616;
			nint num = (nint)array;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00ad;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+B0]");
			object obj3 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X10_v5-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj3 += 16;
				obj2--;
				if ((nint)obj2 != 1)
				{
					continue;
				}
				goto IL_00ad;
			}
			object obj4 = obj3 + 1;
			object obj5 = num + obj4;
			object obj6 = obj5 + 312;
			goto IL_0131;
		}
		return true;
		IL_0131:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v166 @ X0_v3] (should have been resolved before IL gen)");
		object obj7 = default(object);
		return obj7 == null;
		IL_00ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0131;
	}

	public static List<int> ToIntList(ISFSArray sfsArray)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_004e: Expected O, but got I
		//IL_0057: Expected O, but got I4
		//IL_03f0: Expected I, but got O
		//IL_0400: Expected O, but got I
		//IL_0197: Expected I, but got O
		//IL_01a7: Expected O, but got I
		//IL_00c7: Expected O, but got I
		//IL_023d: Expected O, but got I
		//IL_0261: Expected O, but got I4
		//IL_02f2: Expected O, but got I
		//IL_0307: Expected O, but got I
		//IL_01e2: Expected O, but got I
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected O, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected O, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_0355: Expected O, but got I4
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Expected O, but got Unknown
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Expected O, but got Unknown
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Expected O, but got Unknown
		//IL_02ad: Expected O, but got I
		//IL_006c: Expected O, but got I
		//IL_007c: Expected O, but got I
		//IL_008c: Expected O, but got I
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected O, but got Unknown
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_0379: Expected O, but got I
		//IL_039b: Expected O, but got I
		object obj = typeof(List<AdaptivePerformanceScaler>) + 1800;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<int> list = default(List<int>);
		list..ctor();
		if (sfsArray != null)
		{
			object obj2 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 1616;
			object obj3 = typeof(System.IOAsyncCallback) + 960;
			object obj4 = (nint)0 + (nint)1336;
			object obj5 = 0;
			object obj11 = default(object);
			int item = default(int);
			object obj27 = default(object);
			while (true)
			{
				nint num = (nint)sfsArray;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+12E]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0108;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+B0]");
				object obj7 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X10_v15-8]");
					if (0 == (nint)obj2)
					{
						break;
					}
					obj7 += 16;
					obj6--;
					if ((nint)obj6 != 1)
					{
						continue;
					}
					goto IL_0108;
				}
				object obj8 = obj7 + 1;
				object obj9 = num + obj8;
				object obj10 = obj9 + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v314 @ X0_v24] (should have been resolved before IL gen)");
				if (obj5 < obj11)
				{
					goto IL_018f;
				}
				goto IL_03a5;
				IL_018f:
				nint num2 = (nint)sfsArray;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+12E]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0223;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+B0]");
				object obj13 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X10_v10-8]");
					if (0 == (nint)obj3)
					{
						break;
					}
					obj13 += 16;
					obj12--;
					if ((nint)obj12 != 1)
					{
						continue;
					}
					goto IL_0223;
				}
				object obj14 = obj13 + 36;
				object obj15 = num2 + obj14;
				object obj16 = obj15 + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X0_v17+8]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v382 @ X0_v17] (should have been resolved before IL gen)");
				if (list == null)
				{
					break;
				}
				goto IL_02d4;
				IL_02d4:
				object obj18 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+1C]");
				object obj19 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
				object obj20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
				if ((nint)0 == 0)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X9_v10+18]");
				bool flag = num3 < 0;
				object obj21 = !flag;
				if (obj21 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v10+20]");
					object obj22 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X8_v14+C0]");
					object obj23 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ X8_v15+70]");
					obj17 = 0;
					list.AddWithResize(item);
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
					object obj24 = (nint)0 + (nint)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
					nint num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
					object obj25 = num4 + 0;
				}
				obj5++;
				continue;
				IL_0223:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X0_v14+8]");
				obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v365 @ X0_v14] (should have been resolved before IL gen)");
				bool flag2 = list == null;
				object obj26 = !flag2;
				if (obj26 == null)
				{
					break;
				}
				goto IL_02d4;
				IL_0108:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v224 @ X0_v21] (should have been resolved before IL gen)");
				if (obj5 < obj27)
				{
					goto IL_018f;
				}
				goto IL_03a5;
				IL_03a5:
				return list;
			}
		}
		return (List<int>)(object)new NullReferenceException();
	}

	public static List<long> ToLongList(ISFSArray sfsArray)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_004e: Expected O, but got I
		//IL_0057: Expected O, but got I4
		//IL_03f0: Expected I, but got O
		//IL_0400: Expected O, but got I
		//IL_0197: Expected I, but got O
		//IL_01a7: Expected O, but got I
		//IL_00c7: Expected O, but got I
		//IL_023d: Expected O, but got I
		//IL_0261: Expected O, but got I4
		//IL_02f2: Expected O, but got I
		//IL_0307: Expected O, but got I
		//IL_01e2: Expected O, but got I
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected O, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected O, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_0355: Expected O, but got I4
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Expected O, but got Unknown
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Expected O, but got Unknown
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Expected O, but got Unknown
		//IL_02ad: Expected O, but got I
		//IL_006c: Expected O, but got I
		//IL_007c: Expected O, but got I
		//IL_008c: Expected O, but got I
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected O, but got Unknown
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_0379: Expected O, but got I
		//IL_039b: Expected O, but got I
		object obj = typeof(List<AdaptivePerformanceScaler>) + 1808;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<long> list = default(List<long>);
		list..ctor();
		if (sfsArray != null)
		{
			object obj2 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 1616;
			object obj3 = typeof(System.IOAsyncCallback) + 960;
			object obj4 = (nint)0 + (nint)1528;
			object obj5 = 0;
			object obj11 = default(object);
			long item = default(long);
			object obj27 = default(object);
			while (true)
			{
				nint num = (nint)sfsArray;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+12E]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0108;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+B0]");
				object obj7 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X10_v15-8]");
					if (0 == (nint)obj2)
					{
						break;
					}
					obj7 += 16;
					obj6--;
					if ((nint)obj6 != 1)
					{
						continue;
					}
					goto IL_0108;
				}
				object obj8 = obj7 + 1;
				object obj9 = num + obj8;
				object obj10 = obj9 + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v314 @ X0_v24] (should have been resolved before IL gen)");
				if (obj5 < obj11)
				{
					goto IL_018f;
				}
				goto IL_03a5;
				IL_018f:
				nint num2 = (nint)sfsArray;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+12E]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0223;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+B0]");
				object obj13 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X10_v10-8]");
					if (0 == (nint)obj3)
					{
						break;
					}
					obj13 += 16;
					obj12--;
					if ((nint)obj12 != 1)
					{
						continue;
					}
					goto IL_0223;
				}
				object obj14 = obj13 + 37;
				object obj15 = num2 + obj14;
				object obj16 = obj15 + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X0_v17+8]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v382 @ X0_v17] (should have been resolved before IL gen)");
				if (list == null)
				{
					break;
				}
				goto IL_02d4;
				IL_02d4:
				object obj18 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3 (System.Collections.Generic.List`1<System.Int64>)+1C]");
				object obj19 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3 (System.Collections.Generic.List`1<System.Int64>)+10]");
				object obj20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3 (System.Collections.Generic.List`1<System.Int64>)+10]");
				if ((nint)0 == 0)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3 (System.Collections.Generic.List`1<System.Int64>)+18]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X9_v10+18]");
				bool flag = num3 < 0;
				object obj21 = !flag;
				if (obj21 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v10+20]");
					object obj22 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X8_v14+C0]");
					object obj23 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ X8_v15+70]");
					obj17 = 0;
					list.AddWithResize(item);
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3 (System.Collections.Generic.List`1<System.Int64>)+18]");
					object obj24 = (nint)0 + (nint)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3 (System.Collections.Generic.List`1<System.Int64>)+10]");
					nint num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3 (System.Collections.Generic.List`1<System.Int64>)+18]");
					object obj25 = num4 + 0;
				}
				obj5++;
				continue;
				IL_0223:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X0_v14+8]");
				obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v365 @ X0_v14] (should have been resolved before IL gen)");
				bool flag2 = list == null;
				object obj26 = !flag2;
				if (obj26 == null)
				{
					break;
				}
				goto IL_02d4;
				IL_0108:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v224 @ X0_v21] (should have been resolved before IL gen)");
				if (obj5 < obj27)
				{
					goto IL_018f;
				}
				goto IL_03a5;
				IL_03a5:
				return list;
			}
		}
		return (List<long>)(object)new NullReferenceException();
	}

	public static double[] ToDoubleArray(ISFSArray sfsArray)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0035: Expected I, but got O
		//IL_0045: Expected O, but got I
		//IL_00dc: Expected O, but got I4
		//IL_0485: Unknown result type (might be due to invalid IL or missing references)
		//IL_048a: Expected O, but got Unknown
		//IL_04a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ac: Expected O, but got Unknown
		//IL_04bc: Expected I, but got O
		//IL_04cc: Expected O, but got I
		//IL_04ec: Expected O, but got I4
		//IL_04f5: Expected O, but got I4
		//IL_0080: Expected O, but got I
		//IL_0225: Expected I, but got O
		//IL_0235: Expected O, but got I
		//IL_012d: Expected O, but got I
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_02d3: Expected O, but got I
		//IL_02f7: Expected O, but got I4
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_038d: Expected O, but got I4
		//IL_0270: Expected O, but got I
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected O, but got Unknown
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected O, but got Unknown
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected O, but got Unknown
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected O, but got Unknown
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ae: Expected O, but got Unknown
		//IL_03be: Expected I, but got O
		//IL_03ce: Expected O, but got I
		//IL_03f0: Expected O, but got I4
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Expected O, but got Unknown
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Expected O, but got Unknown
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Expected O, but got Unknown
		//IL_0343: Expected O, but got I
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Expected O, but got Unknown
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected O, but got Unknown
		if (sfsArray == null)
		{
			goto IL_0418;
		}
		object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 1616;
		object obj2 = typeof(TypeConverter<ushort, char>) + 2280;
		nint num = (nint)sfsArray;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+12E]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00c9;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+B0]");
		object obj4 = (nint)0 + (nint)8;
		object obj5;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X10_v21-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj5 = obj4 + 16;
			obj3--;
			bool flag = (nint)obj3 != 1;
			obj4 = obj5;
			if (flag)
			{
				continue;
			}
			goto IL_00c9;
		}
		object obj6 = obj4 + 1;
		object obj7 = num + obj6;
		object obj8 = obj7 + 312;
		obj5 = obj4;
		goto IL_0476;
		IL_0413:
		double[] array = default(double[]);
		return array;
		IL_0186:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v364 @ X0_v24] (should have been resolved before IL gen)");
		object obj9;
		object obj10 = default(object);
		if (obj9 < obj10)
		{
			goto IL_021d;
		}
		goto IL_0413;
		IL_021d:
		nint num2 = (nint)sfsArray;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X8_v11 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+12E]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X8_v11 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_02b9;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X8_v11 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+B0]");
		object obj12 = (nint)0 + (nint)8;
		object obj13;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X10_v10-8]");
			if (0 == (nint)obj13)
			{
				break;
			}
			obj5 = obj12 + 16;
			obj11--;
			bool flag2 = (nint)obj11 != 1;
			obj12 = obj5;
			if (flag2)
			{
				continue;
			}
			goto IL_02b9;
		}
		object obj14 = obj12 + 39;
		object obj15 = num2 + obj14;
		object obj16 = obj15 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ X0_v19+8]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v475 @ X0_v19] (should have been resolved before IL gen)");
		bool flag3 = array == null;
		obj5 = obj12;
		if (!flag3)
		{
			goto IL_0372;
		}
		goto IL_0418;
		IL_0426:
		return (double[])(object)new IndexOutOfRangeException();
		IL_0418:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0426;
		IL_00c9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj17 = 1;
		goto IL_0476;
		IL_0476:
		obj13 = typeof(System.IOAsyncCallback) + 960;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v242 @ X0_v6] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj18 = array + 32;
		object obj19 = obj;
		nint num3 = (nint)sfsArray;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X8_v20 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+12E]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X8_v20 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+12E]");
		bool flag4 = (nint)0 == 0;
		object obj21 = 0;
		obj9 = 0;
		object obj22 = obj;
		if (!flag4)
		{
			goto IL_0117;
		}
		goto IL_0186;
		IL_0117:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X8_v20 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+B0]");
		object obj23 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X10_v16-8]");
			if (0 == (nint)obj19)
			{
				break;
			}
			obj5 = obj23 + 16;
			obj20--;
			bool flag5 = (nint)obj20 != 1;
			obj9 = obj21;
			obj22 = obj19;
			obj23 = obj5;
			if (flag5)
			{
				continue;
			}
			goto IL_0186;
		}
		object obj24 = obj23 + 1;
		object obj25 = num3 + obj24;
		object obj26 = obj25 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v405 @ X0_v28] (should have been resolved before IL gen)");
		object obj27 = default(object);
		bool flag6 = obj21 >= obj27;
		obj9 = obj21;
		obj5 = obj23;
		if (!flag6)
		{
			goto IL_021d;
		}
		goto IL_0413;
		IL_02b9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ X0_v16+8]");
		obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v458 @ X0_v16] (should have been resolved before IL gen)");
		bool flag7 = array == null;
		object obj28 = !flag7;
		if (obj28 != null)
		{
			goto IL_0372;
		}
		goto IL_0418;
		IL_0372:
		bool flag8 = (nint)obj9 < array.Length;
		object obj29 = !flag8;
		if (obj29 == null)
		{
			obj21 = obj9 + 1;
			obj19 = obj;
			num3 = (nint)sfsArray;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X8_v20 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+12E]");
			obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X8_v20 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+12E]");
			bool flag9 = (nint)0 == 0;
			object obj30 = !flag9;
			if (obj30 != null)
			{
				goto IL_0117;
			}
			obj9 = obj21;
			obj22 = obj;
			goto IL_0186;
		}
		goto IL_0426;
	}

	public static List<string> ToStringList(ISFSArray sfsArray)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_004e: Expected O, but got I
		//IL_0057: Expected O, but got I4
		//IL_0400: Expected I, but got O
		//IL_0410: Expected O, but got I
		//IL_0197: Expected I, but got O
		//IL_01a7: Expected O, but got I
		//IL_00c7: Expected O, but got I
		//IL_023d: Expected O, but got I
		//IL_0261: Expected O, but got I4
		//IL_01e2: Expected O, but got I
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected O, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected O, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_034b: Expected O, but got I4
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Expected O, but got Unknown
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Expected O, but got Unknown
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Expected O, but got Unknown
		//IL_02ad: Expected O, but got I
		//IL_006c: Expected O, but got I
		//IL_007c: Expected O, but got I
		//IL_008c: Expected O, but got I
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected O, but got Unknown
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0390: Expected O, but got Unknown
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 3624;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		if (sfsArray != null)
		{
			object obj2 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 1616;
			object obj3 = typeof(System.IOAsyncCallback) + 960;
			object obj4 = (nint)0 + (nint)3072;
			object obj5 = 0;
			object obj11 = default(object);
			object obj18 = default(object);
			object obj21 = default(object);
			while (true)
			{
				nint num = (nint)sfsArray;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+12E]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0108;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+B0]");
				object obj7 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X10_v15-8]");
					if (0 == (nint)obj2)
					{
						break;
					}
					obj7 += 16;
					obj6--;
					if ((nint)obj6 != 1)
					{
						continue;
					}
					goto IL_0108;
				}
				object obj8 = obj7 + 1;
				object obj9 = num + obj8;
				object obj10 = obj9 + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v279 @ X0_v27] (should have been resolved before IL gen)");
				if (obj5 >= obj11)
				{
					break;
				}
				goto IL_018f;
				IL_0223:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X0_v17+8]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v330 @ X0_v17] (should have been resolved before IL gen)");
				bool flag = list == null;
				object obj13 = !flag;
				if (obj13 != null)
				{
					goto IL_02d4;
				}
				goto IL_03ba;
				IL_02d4:
				object obj14 = obj4;
				int version = list._version + 1;
				list._version = version;
				object[] items = list._items;
				if (list._items != null)
				{
					bool flag2 = list._size < items.Length;
					object obj15 = !flag2;
					if (obj15 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X8_v10+20]");
						object obj16 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X8_v13+C0]");
						object obj17 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X8_v14+70]");
						obj12 = 0;
						list.AddWithResize(obj18);
					}
					else
					{
						int size = list._size + 1;
						list._size = size;
						object obj19 = list._items + list._size;
						object obj20 = obj19 + 32;
						obj20 = obj18;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					}
					obj5++;
					continue;
				}
				goto IL_03ba;
				IL_03ba:
				return (List<string>)(object)new NullReferenceException();
				IL_0108:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v252 @ X0_v24] (should have been resolved before IL gen)");
				if (obj5 >= obj21)
				{
					break;
				}
				goto IL_018f;
				IL_018f:
				nint num2 = (nint)sfsArray;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+12E]");
				object obj22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0223;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+B0]");
				object obj23 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X10_v10-8]");
					if (0 == (nint)obj3)
					{
						break;
					}
					obj23 += 16;
					obj22--;
					if ((nint)obj22 != 1)
					{
						continue;
					}
					goto IL_0223;
				}
				object obj24 = obj23 + 40;
				object obj25 = num2 + obj24;
				object obj26 = obj25 + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X0_v20+8]");
				obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v363 @ X0_v20] (should have been resolved before IL gen)");
				if (list != null)
				{
					goto IL_02d4;
				}
				goto IL_03ba;
			}
		}
		return (List<string>)(object)list;
	}

	public static List<T> ToModelList<T>(ISFSArray sfsArray, Func<ISFSObject, T> modeler)
	{
		//IL_0016: Expected O, but got I
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_003e: Expected O, but got I4
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b9: Expected O, but got I4
		//IL_0469: Expected I, but got O
		//IL_0479: Expected O, but got I
		//IL_01cf: Expected I, but got O
		//IL_01df: Expected O, but got I
		//IL_00ff: Expected O, but got I
		//IL_0289: Expected O, but got I4
		//IL_021a: Expected O, but got I
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected O, but got Unknown
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected O, but got Unknown
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected O, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected O, but got Unknown
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected O, but got Unknown
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Expected O, but got Unknown
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Expected O, but got Unknown
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected O, but got Unknown
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Expected O, but got Unknown
		//IL_0392: Expected O, but got I4
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_03d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Expected O, but got Unknown
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e5: Expected O, but got Unknown
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		nint num2 = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		if (sfsArray != null)
		{
			object obj4 = typeof(System.IOAsyncCallback) + 960;
			object obj5 = 0;
			object obj11 = default(object);
			object obj18 = default(object);
			object obj22 = default(object);
			while (true)
			{
				nint num3 = (nint)sfsArray;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+12E]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0140;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+B0]");
				object obj7 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X10_v15-8]");
					if (0 == (nint)obj4)
					{
						break;
					}
					obj7 += 16;
					obj6--;
					if ((nint)obj6 != 1)
					{
						continue;
					}
					goto IL_0140;
				}
				object obj8 = obj7 + 4;
				object obj9 = num3 + obj8;
				object obj10 = obj9 + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v318 @ X0_v28] (should have been resolved before IL gen)");
				if (obj5 < obj11)
				{
					goto IL_01c7;
				}
				goto IL_03fc;
				IL_01c7:
				nint num4 = (nint)sfsArray;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+12E]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_025b;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+B0]");
				object obj13 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X10_v10-8]");
					if (0 == (nint)obj4)
					{
						break;
					}
					obj13 += 16;
					obj12--;
					if ((nint)obj12 != 1)
					{
						continue;
					}
					goto IL_025b;
				}
				object obj14 = obj13 + 51;
				object obj15 = num4 + obj14;
				object obj16 = obj15 + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v386 @ X0_v21] (should have been resolved before IL gen)");
				if (modeler == null)
				{
					break;
				}
				goto IL_02ec;
				IL_02ec:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [modeler @ X1 (System.Func`2<Sfs2X.Entities.Data.ISFSObject, T>)+28]");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [modeler @ X1 (System.Func`2<Sfs2X.Entities.Data.ISFSObject, T>)+18] (should have been resolved before IL gen)");
				if (list == null)
				{
					break;
				}
				int version = list._version + 1;
				list._version = version;
				object[] items = list._items;
				if (list._items == null)
				{
					break;
				}
				bool flag2 = list._size < items.Length;
				object obj17 = !flag2;
				if (obj17 != null)
				{
					list.AddWithResize(obj18);
					num5 = 0;
				}
				else
				{
					int size = list._size + 1;
					list._size = size;
					object obj19 = list._items + list._size;
					object obj20 = obj19 + 32;
					obj20 = obj18;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				}
				obj5++;
				continue;
				IL_025b:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v369 @ X0_v18] (should have been resolved before IL gen)");
				bool flag3 = modeler == null;
				object obj21 = !flag3;
				if (obj21 == null)
				{
					break;
				}
				goto IL_02ec;
				IL_0140:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v228 @ X0_v25] (should have been resolved before IL gen)");
				if (obj5 < obj22)
				{
					goto IL_01c7;
				}
				goto IL_03fc;
				IL_03fc:
				return (List<T>)(object)list;
			}
		}
		return (List<T>)(object)new NullReferenceException();
	}

	public static T[] ToModelArray<T>(ISFSArray sfsArray, Func<ISFSObject, T> modeler)
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_0052: Expected I, but got O
		//IL_0062: Expected O, but got I
		//IL_0543: Expected O, but got I
		//IL_054c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0551: Expected O, but got Unknown
		//IL_056b: Expected O, but got I4
		//IL_009d: Expected O, but got I
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected O, but got Unknown
		//IL_016b: Expected I, but got O
		//IL_017b: Expected O, but got I
		//IL_019b: Expected O, but got I4
		//IL_01a4: Expected O, but got I4
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected O, but got Unknown
		//IL_02c8: Expected I, but got O
		//IL_02d8: Expected O, but got I
		//IL_01d0: Expected O, but got I
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_038a: Expected O, but got I4
		//IL_0313: Expected O, but got I
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Expected O, but got Unknown
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Expected O, but got Unknown
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected O, but got Unknown
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected O, but got Unknown
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected O, but got Unknown
		//IL_0447: Expected O, but got I4
		//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Expected O, but got Unknown
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Expected O, but got Unknown
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c6: Expected O, but got Unknown
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Expected O, but got Unknown
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected O, but got Unknown
		//IL_047d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0482: Expected O, but got Unknown
		//IL_0492: Expected I, but got O
		//IL_04a2: Expected O, but got I
		//IL_04c4: Expected O, but got I4
		if (sfsArray == null)
		{
			goto IL_04ec;
		}
		object obj = typeof(System.IOAsyncCallback) + 960;
		nint num = (nint)sfsArray;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+12E]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00e6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+B0]");
		object obj3 = (nint)0 + (nint)8;
		object obj4;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X10_v21-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj4 = obj3 + 16;
			obj2--;
			bool flag = (nint)obj2 != 1;
			obj3 = obj4;
			if (flag)
			{
				continue;
			}
			goto IL_00e6;
		}
		object obj5 = obj3 + 4;
		object obj6 = num + obj5;
		object obj7 = obj6 + 312;
		obj4 = obj3;
		goto IL_052d;
		IL_03f5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [modeler @ X1 (System.Func`2<Sfs2X.Entities.Data.ISFSObject, T>)+28]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [modeler @ X1 (System.Func`2<Sfs2X.Entities.Data.ISFSObject, T>)+18] (should have been resolved before IL gen)");
		T[] array = default(T[]);
		if (array == null)
		{
			goto IL_04ec;
		}
		object obj8;
		bool flag2 = (nint)obj8 < array.Length;
		object obj9 = !flag2;
		object obj11;
		object obj13;
		object obj14;
		nint num3;
		object obj15;
		object obj17;
		if (obj9 == null)
		{
			object obj10 = obj11 + obj8;
			object obj12 = default(object);
			obj10 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj13 = obj8 + 1;
			obj14 = obj;
			num3 = (nint)sfsArray;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X8_v24 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+12E]");
			obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X8_v24 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+12E]");
			bool flag3 = (nint)0 == 0;
			object obj16 = !flag3;
			if (obj16 != null)
			{
				goto IL_01ba;
			}
			obj8 = obj13;
			obj17 = obj;
			goto IL_0229;
		}
		goto IL_04fa;
		IL_035c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v470 @ X0_v21] (should have been resolved before IL gen)");
		bool flag4 = modeler == null;
		object obj18 = !flag4;
		if (obj18 != null)
		{
			goto IL_03f5;
		}
		goto IL_04ec;
		IL_04e7:
		return array;
		IL_0229:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v376 @ X0_v29] (should have been resolved before IL gen)");
		object obj19 = default(object);
		if (obj8 < obj19)
		{
			goto IL_02c0;
		}
		goto IL_04e7;
		IL_04ec:
		NullReferenceException ex = new NullReferenceException();
		goto IL_04fa;
		IL_00e6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num2 = 4;
		goto IL_052d;
		IL_052d:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v245 @ X0_v6] (should have been resolved before IL gen)");
		object obj20 = (nint)0 + (nint)309;
		object obj21 = obj20 & 1;
		bool flag5 = obj21 == null;
		object obj22 = !flag5;
		nint num4 = 0;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		obj11 = array + 32;
		obj14 = obj;
		num3 = (nint)sfsArray;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X8_v24 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+12E]");
		obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X8_v24 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+12E]");
		bool flag6 = (nint)0 == 0;
		obj13 = 0;
		obj8 = 0;
		obj17 = obj;
		if (!flag6)
		{
			goto IL_01ba;
		}
		goto IL_0229;
		IL_04fa:
		return (T[])(object)new IndexOutOfRangeException();
		IL_02c0:
		nint num5 = (nint)sfsArray;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ X8_v14 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+12E]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ X8_v14 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_035c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ X8_v14 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+B0]");
		object obj24 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X10_v10-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj4 = obj24 + 16;
			obj23--;
			bool flag7 = (nint)obj23 != 1;
			obj24 = obj4;
			if (flag7)
			{
				continue;
			}
			goto IL_035c;
		}
		object obj25 = obj24 + 51;
		object obj26 = num5 + obj25;
		object obj27 = obj26 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v487 @ X0_v24] (should have been resolved before IL gen)");
		bool flag8 = modeler == null;
		obj4 = obj24;
		if (!flag8)
		{
			goto IL_03f5;
		}
		goto IL_04ec;
		IL_01ba:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X8_v24 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+B0]");
		object obj28 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X10_v16-8]");
			if (0 == (nint)obj14)
			{
				break;
			}
			obj4 = obj28 + 16;
			obj15--;
			bool flag9 = (nint)obj15 != 1;
			obj8 = obj13;
			obj17 = obj14;
			obj28 = obj4;
			if (flag9)
			{
				continue;
			}
			goto IL_0229;
		}
		object obj29 = obj28 + 4;
		object obj30 = num3 + obj29;
		object obj31 = obj30 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v417 @ X0_v33] (should have been resolved before IL gen)");
		object obj32 = default(object);
		bool flag10 = obj13 >= obj32;
		obj8 = obj13;
		obj4 = obj28;
		if (!flag10)
		{
			goto IL_02c0;
		}
		goto IL_04e7;
	}

	private static T GetSafely<T>(Func<T> action, T defaultValue)
	{
		//IL_0022: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ X3+38]");
		bool flag = (nint)0 == 0;
		object obj = !flag;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
		}
		if (action != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [action @ X0 (System.Func`1<T>)+18] (should have been resolved before IL gen)");
			T result = default(T);
			return result;
		}
		NullReferenceException ex = new NullReferenceException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		T result2 = default(T);
		return result2;
	}

	public static string ToPrettyJson(ISFSObject obj)
	{
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_009f: Expected I, but got O
		//IL_00af: Expected O, but got I
		//IL_0145: Expected O, but got I
		//IL_0179: Expected O, but got I4
		//IL_0182: Expected O, but got I4
		//IL_02c5: Expected I, but got O
		//IL_02d5: Expected O, but got I
		//IL_02e5: Expected O, but got I
		//IL_00ea: Expected O, but got I
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected O, but got Unknown
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected O, but got Unknown
		//IL_01fc: Expected O, but got I
		//IL_0230: Expected O, but got I4
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		//IL_0247: Expected O, but got I4
		JsonWriter jsonWriter = default(JsonWriter);
		object obj4;
		string text = default(string);
		string text2 = default(string);
		object obj10;
		object obj11;
		object obj13;
		if (obj != null)
		{
			object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1104;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			jsonWriter..ctor();
			if (jsonWriter != null)
			{
				object obj3 = typeof(System.IOAsyncCallback) + 976;
				obj4 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 728;
				jsonWriter.PrettyPrint = true;
				jsonWriter.IndentValue = 2;
				nint num = (nint)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_012b;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
				object obj6 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X10_v6-8]");
					if (0 == (nint)obj3)
					{
						break;
					}
					obj6 += 16;
					obj5--;
					if ((nint)obj5 != 1)
					{
						continue;
					}
					goto IL_012b;
				}
				object obj7 = obj6 + 6;
				object obj8 = num + obj7;
				object obj9 = obj8 + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X0_v19+8]");
				obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v203 @ X0_v19] (should have been resolved before IL gen)");
				obj11 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X8_v10+E4]");
				bool flag = (nint)0 == 0;
				object obj12 = !flag;
				if (obj12 == null)
				{
					obj13 = 0;
					text = text2;
					goto IL_0198;
				}
				goto IL_02a3;
			}
			return (string)(object)new NullReferenceException();
		}
		return "WhiteSmoke" + 3264;
		IL_0198:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		text2 = text;
		goto IL_02a3;
		IL_02a3:
		JsonData obj14 = JsonMapper.ToObject(text2);
		JsonMapper.ToJson(obj14, jsonWriter);
		nint num2 = (nint)jsonWriter;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v9 (Il2CppClass<SFSLitJson.JsonWriter>)+168]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v9 (Il2CppClass<SFSLitJson.JsonWriter>)+170]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v104 @ X2_v5 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
		IL_012b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v16+8]");
		obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v169 @ X0_v16] (should have been resolved before IL gen)");
		obj11 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X8_v10+E4]");
		bool flag2 = (nint)0 == 0;
		object obj17 = !flag2;
		obj13 = 6;
		text2 = text;
		if (obj17 == null)
		{
			goto IL_0198;
		}
		goto IL_02a3;
	}
}
