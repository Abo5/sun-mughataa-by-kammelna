using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Unity.Services.Authentication.Shared;
using UnityEngine.TextCore;

public static class EnumMethods
{
	public unsafe static T FromFriendlyName<T>(string friendlyName, T defaultValue, bool dontDefault = false) where T : Enum
	{
		//IL_0d01: Expected O, but got I4
		//IL_0d11: Expected O, but got I
		//IL_0d33: Expected O, but got I4
		//IL_002f: Expected O, but got I
		//IL_0043: Expected O, but got I
		//IL_0065: Expected O, but got I4
		//IL_0089: Expected O, but got I
		//IL_009d: Expected O, but got I
		//IL_00bf: Expected O, but got I4
		//IL_0aa2: Expected O, but got I
		//IL_0124: Expected O, but got I
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected O, but got Unknown
		//IL_014c: Expected O, but got I4
		//IL_0d49: Expected I, but got O
		//IL_0d59: Expected O, but got I
		//IL_0db3: Expected O, but got I
		//IL_0dcc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd1: Expected O, but got Unknown
		//IL_0de0: Expected O, but got I4
		//IL_0def: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df4: Expected O, but got Unknown
		//IL_018d: Expected O, but got I
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected O, but got Unknown
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected O, but got Unknown
		//IL_0226: Expected O, but got I
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected O, but got Unknown
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected O, but got Unknown
		//IL_0e36: Expected O, but got I
		//IL_0e49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e4e: Expected O, but got Unknown
		//IL_0261: Expected O, but got I
		//IL_0764: Expected O, but got I4
		//IL_0772: Expected O, but got I4
		//IL_0783: Expected O, but got I4
		//IL_0799: Expected O, but got I4
		//IL_0f50: Expected O, but got I4
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Expected O, but got Unknown
		//IL_07b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bb: Expected O, but got Unknown
		//IL_07d3: Expected O, but got I
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Expected O, but got Unknown
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Expected O, but got Unknown
		//IL_0303: Expected O, but got I
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Expected O, but got Unknown
		//IL_032b: Expected O, but got I4
		//IL_08ee: Expected O, but got I4
		//IL_0f92: Expected O, but got I
		//IL_080e: Expected O, but got I
		//IL_0e83: Expected O, but got I
		//IL_0ae4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae9: Expected O, but got Unknown
		//IL_08c6: Expected O, but got I4
		//IL_0b1c: Expected O, but got I4
		//IL_087d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0882: Expected O, but got Unknown
		//IL_0ee2: Expected O, but got I
		//IL_0eeb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef0: Expected O, but got Unknown
		//IL_0f0a: Expected O, but got I4
		//IL_036c: Expected O, but got I
		//IL_0b63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b68: Expected O, but got Unknown
		//IL_081c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0821: Expected O, but got Unknown
		//IL_082a: Unknown result type (might be due to invalid IL or missing references)
		//IL_082f: Expected O, but got Unknown
		//IL_03fd: Expected O, but got Ref
		//IL_0b95: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9a: Expected O, but got Unknown
		//IL_0b4c: Expected O, but got I4
		//IL_03db: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Expected O, but got Unknown
		//IL_0bcd: Expected O, but got I4
		//IL_037a: Unknown result type (might be due to invalid IL or missing references)
		//IL_037f: Expected O, but got Unknown
		//IL_0388: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Expected O, but got Unknown
		//IL_0c2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c30: Expected O, but got Unknown
		//IL_0bfd: Expected O, but got I4
		//IL_0c6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6f: Expected O, but got Unknown
		//IL_048d: Expected O, but got I
		//IL_04af: Expected O, but got I4
		//IL_0cbc: Expected O, but got I
		//IL_0508: Expected I, but got O
		//IL_05bd: Expected I, but got O
		//IL_05e6: Expected O, but got I4
		//IL_061a: Expected O, but got I
		//IL_0680: Expected O, but got I
		//IL_0698: Expected I, but got O
		//IL_06d1: Expected O, but got I4
		//IL_06d6: Expected I, but got O
		//IL_06e7: Expected O, but got I4
		//IL_0701: Expected O, but got I4
		//IL_0714: Expected I, but got O
		//IL_071d: Expected O, but got I4
		//IL_073f: Expected O, but got I4
		object obj = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X27_v2+E0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X27_v2+E0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X27_v2+98]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v10+E4]");
		bool flag3 = (nint)0 == 0;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Array values = Enum.GetValues(typeFromHandle2);
		IEnumerable<System.Int32Enum> enumerable = Enumerable.Cast<System.Int32Enum>(values);
		bool flag5;
		bool flag6 = default(bool);
		if (enumerable != null)
		{
			object obj8 = (nint)0 + (nint)309;
			object obj9 = obj8 & 1;
			bool flag4 = obj9 == null;
			object obj10 = !flag4;
			nint num = 0;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				IntPtr intPtr = default(IntPtr);
				num = intPtr;
			}
			nint num2 = (nint)enumerable;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v12 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Int32Enum>>)+12E]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v12 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Int32Enum>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_01ce;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v12 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Int32Enum>>)+B0]");
			object obj12 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X10_v28-8]");
				if (0 == num)
				{
					break;
				}
				obj12 += 16;
				obj11--;
				if ((nint)obj11 != 1)
				{
					continue;
				}
				goto IL_01ce;
			}
			object obj13 = num2 + obj12;
			object obj14 = obj13 + 312;
			flag5 = flag6;
			goto IL_0da3;
		}
		NullReferenceException ex = new NullReferenceException();
		IntPtr intPtr2 = default(IntPtr);
		nint num3 = intPtr2;
		string text = (string)0;
		InvalidCastException ex2 = (InvalidCastException)(object)ex;
		goto IL_0cc9;
		IL_0da3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X0_v22+8]");
		text = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v415 @ X0_v22] (should have been resolved before IL gen)");
		object obj15 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
		object handle = 147423232 + 3472;
		object obj16 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1520;
		num3 = intPtr2;
		object obj17 = default(object);
		string[] array = default(string[]);
		bool flag13 = default(bool);
		ArgumentException ex6 = default(ArgumentException);
		object obj45 = default(object);
		IntPtr intPtr3 = default(IntPtr);
		IntPtr intPtr4 = default(IntPtr);
		T val2 = default(T);
		while (true)
		{
			if (obj17 != null)
			{
				object obj18 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X8_v17+12E]");
				object obj19 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X8_v17+12E]");
				if ((nint)0 == 0)
				{
					goto IL_02a2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X8_v17+B0]");
				object obj20 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v530 @ X10_v23-8]");
					if (0 == (nint)obj15)
					{
						break;
					}
					obj20 += 16;
					obj19--;
					if ((nint)obj19 != 1)
					{
						continue;
					}
					goto IL_02a2;
				}
				object obj21 = obj18 + obj20;
				object obj22 = obj21 + 312;
				goto IL_0e26;
			}
			NullReferenceException ex3 = new NullReferenceException();
			flag6 = flag5;
			ex2 = (InvalidCastException)(object)ex3;
			break;
			IL_0f36:
			object obj23;
			bool flag7 = obj23 == null;
			object obj24 = !flag7;
			object obj25;
			T result;
			nint num4;
			bool flag11;
			if (obj24 == null)
			{
				if ((nint)obj25 != 5)
				{
					bool flag8 = obj25 == null;
					object obj26 = !flag8;
					if (obj26 != null)
					{
						goto IL_0fc1;
					}
				}
				bool flag9 = !flag6;
				object obj27 = !flag9;
				if (obj27 == null)
				{
					result = defaultValue;
					goto IL_0fc1;
				}
				object obj28 = typeof(SqlSingle[]) + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
				bool flag10 = array == null;
				object obj29 = !flag10;
				if (obj29 == null)
				{
					NullReferenceException ex4 = new NullReferenceException();
					num3 = num4;
					flag6 = flag11;
					text = (string)5;
					ex2 = (InvalidCastException)(object)ex4;
					break;
				}
				object obj30 = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 1472;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C9AC34");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C9AC34");
				object obj31 = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 2608;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C9AC34");
				bool flag12 = (object)typeFromHandle == null;
				object obj32 = !flag12;
				if (obj32 == null)
				{
					NullReferenceException ex5 = new NullReferenceException();
					num3 = num4;
					flag6 = flag13;
					text = (string)2;
					ex2 = (InvalidCastException)(object)ex5;
					break;
				}
				string name = typeFromHandle.Name;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C9AC34");
				object obj33 = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 2544;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C9AC34");
				string message = string.Concat(array);
				object obj34 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 640;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				ex6..ctor(message);
				OutOfMemoryException ex7 = new OutOfMemoryException();
				num3 = num4;
				flag6 = false;
				text = (string)(nint)intPtr2;
				ex2 = (InvalidCastException)(object)ex7;
				break;
			}
			OutOfMemoryException ex8 = new OutOfMemoryException();
			num3 = num4;
			flag6 = flag11;
			ex2 = (InvalidCastException)(object)ex8;
			break;
			IL_0f82:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v736 @ X0_v70+8]");
			text = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v736 @ X0_v70] (should have been resolved before IL gen)");
			num4 = num3;
			object obj35;
			obj23 = obj35;
			T val;
			result = val;
			object obj36;
			obj25 = obj36;
			goto IL_0f36;
			IL_07a7:
			object obj37 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
			object obj39;
			object obj38 = obj39;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v594 @ X8_v27+12E]");
			object obj40 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v594 @ X8_v27+12E]");
			if ((nint)0 == 0)
			{
				goto IL_084f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v594 @ X8_v27+B0]");
			object obj41 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v695 @ X10_v11-8]");
				if (0 == (nint)obj37)
				{
					break;
				}
				obj41 += 16;
				obj40--;
				if ((nint)obj40 != 1)
				{
					continue;
				}
				goto IL_084f;
			}
			object obj42 = obj38 + obj41;
			object obj43 = obj42 + 312;
			flag11 = flag5;
			goto IL_0f82;
			IL_03ad:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			flag5 = false;
			goto IL_0ecc;
			IL_02a2:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			flag5 = false;
			goto IL_0e26;
			IL_0e26:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ X0_v27+8]");
			text = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v544 @ X0_v27] (should have been resolved before IL gen)");
			object obj44 = obj45 & 1;
			if (obj44 != null)
			{
				if (obj17 != null)
				{
					object obj46 = (nint)0 + (nint)309;
					object obj47 = obj46 & 1;
					bool flag14 = obj47 == null;
					object obj48 = !flag14;
					nint num5 = 0;
					if (obj48 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
						num5 = intPtr3;
					}
					object obj49 = obj17;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v621 @ X8_v34+12E]");
					object obj50 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v621 @ X8_v34+12E]");
					if ((nint)0 == 0)
					{
						goto IL_03ad;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v621 @ X8_v34+B0]");
					object obj51 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v722 @ X10_v18-8]");
						if (0 == num5)
						{
							break;
						}
						obj51 += 16;
						obj50--;
						if ((nint)obj50 != 1)
						{
							continue;
						}
						goto IL_03ad;
					}
					object obj52 = obj49 + obj51;
					object obj53 = obj52 + 312;
					goto IL_0ecc;
				}
				NullReferenceException ex9 = new NullReferenceException();
				flag6 = flag5;
				ex2 = (InvalidCastException)(object)ex9;
				break;
			}
			bool flag15 = obj17 == null;
			obj39 = obj17;
			obj35 = 0;
			val = (T)null;
			obj36 = 5;
			num4 = num3;
			obj23 = 0;
			flag11 = flag5;
			result = (T)null;
			obj25 = 5;
			if (!flag15)
			{
				goto IL_07a7;
			}
			goto IL_0f36;
			IL_0ecc:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v748 @ X0_v78] (should have been resolved before IL gen)");
			object obj54 = (nint)0 + (nint)309;
			object obj55 = obj54 & 1;
			bool flag16 = obj55 == null;
			object obj56 = !flag16;
			if (obj56 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			}
			string text2 = ((Enum)(&intPtr4)).ToString();
			if ((object)typeFromHandle != null)
			{
				MemberInfo[] member = typeFromHandle.GetMember(text2);
				if (member != null)
				{
					if (member.Length != 0)
					{
						MemberInfo memberInfo = member[0];
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X27_v2+E0]");
						object obj57 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v783 @ X0_v90+E4]");
						bool flag17 = (nint)0 == 0;
						object obj58 = !flag17;
						if (obj58 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Type typeFromHandle3 = Type.GetTypeFromHandle((RuntimeTypeHandle)handle);
						if ((object)member[0] != null)
						{
							nint num6 = (nint)memberInfo;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X8_v42 (Il2CppClass<System.Reflection.MemberInfo>)+220]");
							num3 = 0;
							object[] customAttributes = member[0].GetCustomAttributes(typeFromHandle3, inherit: false);
							if (customAttributes != null)
							{
								if (customAttributes.Length != 0)
								{
									object obj59 = customAttributes[0];
									if (customAttributes[0] != null)
									{
										text = (string)obj16;
										nint num7 = (nint)obj59;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X8_v44 (Il2CppClass<System.Object>)+130]");
										nint num8 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X1_v5 (System.String)+130]");
										bool flag18 = num8 < 0;
										object obj60 = !flag18;
										object obj61 = ~obj60;
										if (obj61 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X8_v44 (Il2CppClass<System.Object>)+C8]");
											nint num9 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X1_v5 (System.String)+130]");
											object obj62 = num9 + 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v829 @ X8_v47-8]");
											if (0 == (nint)text)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v810 @ X0_v99 (System.Object)+10]");
												if ((nint)0 != 0)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v810 @ X0_v99 (System.Object)+10]");
													bool flag19 = ((string)0).Equals(friendlyName, StringComparison.InvariantCultureIgnoreCase);
													bool flag20 = !flag19;
													num3 = unchecked((nint)null);
													flag5 = true;
													text = friendlyName;
													if (flag20)
													{
														continue;
													}
													bool flag21 = obj17 == null;
													object obj63 = !flag21;
													num3 = unchecked((nint)null);
													obj39 = obj17;
													obj35 = 0;
													flag5 = true;
													val = val2;
													obj36 = 4;
													if (obj63 != null)
													{
														goto IL_07a7;
													}
													num4 = unchecked((nint)null);
													obj23 = 0;
													flag11 = true;
													result = val2;
													text = friendlyName;
													obj25 = 4;
													goto IL_0f36;
												}
												NullReferenceException ex10 = new NullReferenceException();
												flag6 = false;
												ex2 = (InvalidCastException)(object)ex10;
												break;
											}
										}
										ex2 = new InvalidCastException();
										flag6 = false;
									}
									else
									{
										NullReferenceException ex11 = new NullReferenceException();
										flag6 = false;
										text = (string)(object)typeFromHandle3;
										ex2 = (InvalidCastException)(object)ex11;
									}
								}
								else
								{
									IndexOutOfRangeException ex12 = new IndexOutOfRangeException();
									flag6 = false;
									text = (string)(object)typeFromHandle3;
									ex2 = (InvalidCastException)(object)ex12;
								}
							}
							else
							{
								NullReferenceException ex13 = new NullReferenceException();
								flag6 = false;
								text = (string)(object)typeFromHandle3;
								ex2 = (InvalidCastException)(object)ex13;
							}
						}
						else
						{
							NullReferenceException ex14 = new NullReferenceException();
							flag6 = false;
							text = (string)(object)typeFromHandle3;
							ex2 = (InvalidCastException)(object)ex14;
						}
					}
					else
					{
						IndexOutOfRangeException ex15 = new IndexOutOfRangeException();
						flag6 = false;
						text = text2;
						ex2 = (InvalidCastException)(object)ex15;
					}
				}
				else
				{
					NullReferenceException ex16 = new NullReferenceException();
					flag6 = false;
					text = text2;
					ex2 = (InvalidCastException)(object)ex16;
				}
			}
			else
			{
				NullReferenceException ex17 = new NullReferenceException();
				flag6 = flag5;
				text = text2;
				ex2 = (InvalidCastException)(object)ex17;
			}
			break;
			IL_0fc1:
			return result;
			IL_084f:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			flag11 = false;
			goto IL_0f82;
		}
		goto IL_0cc9;
		IL_01ce:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		flag5 = false;
		goto IL_0da3;
		IL_0cc9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		T result2 = default(T);
		return result2;
	}

	public unsafe static bool TryFromFriendlyName<T>(string friendlyName, out T t) where T : Enum
	{
		//IL_0031: Expected O, but got I4
		//IL_0041: Expected O, but got I
		//IL_0063: Expected O, but got I4
		//IL_0087: Expected O, but got I
		//IL_0092: Expected O, but got I
		//IL_00ab: Expected O, but got I
		//IL_00bb: Expected O, but got I
		//IL_00dd: Expected O, but got I4
		//IL_0c8d: Expected O, but got I
		//IL_0c96: Expected O, but got I4
		//IL_0106: Expected O, but got I
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_012e: Expected O, but got I4
		//IL_0cc5: Expected I, but got O
		//IL_0cd5: Expected O, but got I
		//IL_01cf: Expected I, but got O
		//IL_0d3e: Expected O, but got I
		//IL_0d57: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5c: Expected O, but got Unknown
		//IL_0d6b: Expected O, but got I4
		//IL_0d7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d7f: Expected O, but got Unknown
		//IL_016f: Expected O, but got I
		//IL_0d0a: Expected O, but got I
		//IL_09fa: Expected O, but got I4
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected O, but got Unknown
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Expected O, but got Unknown
		//IL_0bd5: Expected O, but got I4
		//IL_021c: Expected O, but got I
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected O, but got Unknown
		//IL_0198: Expected O, but got I
		//IL_02b7: Expected I, but got O
		//IL_0dd0: Expected I, but got O
		//IL_0de0: Expected O, but got I
		//IL_0df3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df8: Expected O, but got Unknown
		//IL_0257: Expected O, but got I
		//IL_089c: Expected O, but got I4
		//IL_08a5: Expected O, but got I4
		//IL_08ae: Expected O, but got I4
		//IL_0da4: Expected O, but got I
		//IL_106b: Expected O, but got I4
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected O, but got Unknown
		//IL_0f10: Expected O, but got I4
		//IL_0a4e: Expected O, but got I4
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected O, but got Unknown
		//IL_0280: Expected O, but got I
		//IL_08c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c7: Expected O, but got Unknown
		//IL_08df: Expected O, but got I
		//IL_0316: Expected O, but got I
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Expected O, but got Unknown
		//IL_033e: Expected O, but got I4
		//IL_097a: Expected I, but got O
		//IL_0e2d: Expected O, but got I
		//IL_0fca: Expected O, but got I
		//IL_091a: Expected O, but got I
		//IL_03df: Expected I, but got O
		//IL_0f96: Expected O, but got I
		//IL_0e9c: Expected O, but got I
		//IL_0ea5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eaa: Expected O, but got Unknown
		//IL_0ec4: Expected O, but got I4
		//IL_037f: Expected O, but got I
		//IL_099d: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a2: Expected O, but got Unknown
		//IL_042c: Expected O, but got Ref
		//IL_0e62: Expected O, but got I
		//IL_0928: Unknown result type (might be due to invalid IL or missing references)
		//IL_092d: Expected O, but got Unknown
		//IL_0943: Expected O, but got I
		//IL_0402: Unknown result type (might be due to invalid IL or missing references)
		//IL_0407: Expected O, but got Unknown
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Expected O, but got Unknown
		//IL_03a8: Expected O, but got I
		//IL_0a1e: Expected I, but got O
		//IL_0b46: Expected I, but got O
		//IL_04ce: Expected O, but got I
		//IL_0500: Expected O, but got I4
		//IL_0a72: Expected I, but got O
		//IL_0560: Expected O, but got I
		//IL_0570: Expected O, but got I
		//IL_0b12: Expected I, but got O
		//IL_0aa6: Expected I, but got O
		//IL_05dc: Expected O, but got I
		//IL_0b7a: Expected I, but got O
		//IL_0611: Expected I, but got O
		//IL_0621: Expected O, but got I
		//IL_0631: Expected O, but got I
		//IL_065a: Expected O, but got I4
		//IL_09db: Expected I, but got O
		//IL_068e: Expected O, but got I
		//IL_0bae: Expected I, but got O
		//IL_0704: Expected O, but got I
		//IL_0720: Expected O, but got I4
		//IL_077b: Expected O, but got I4
		//IL_0794: Expected O, but got I4
		//IL_079d: Expected O, but got I4
		//IL_07d1: Expected O, but got I4
		//IL_07da: Expected O, but got I4
		//IL_0809: Expected O, but got I4
		//IL_0822: Expected O, but got I4
		//IL_0854: Expected O, but got I
		//IL_087e: Expected O, but got I4
		ref T reference = ref *(T*)null;
		object obj = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X28_v2+E0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
		Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X28_v2+98]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v6+E4]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Array values = Enum.GetValues(typeFromHandle2);
		IEnumerable<System.Int32Enum> enumerable = Enumerable.Cast<System.Int32Enum>(values);
		bool flag3 = enumerable == null;
		string text = (string)0;
		object obj7 = 0;
		nint num = 0;
		ref T reference2 = ref t;
		if (flag3)
		{
			goto IL_0cb2;
		}
		object obj8 = (nint)0 + (nint)309;
		object obj9 = obj8 & 1;
		bool flag4 = obj9 == null;
		object obj10 = !flag4;
		nint num2 = 0;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			IntPtr intPtr = default(IntPtr);
			num2 = intPtr;
		}
		nint num3 = (nint)enumerable;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X8_v22 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Int32Enum>>)+12E]");
		obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X8_v22 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Int32Enum>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_01c0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X8_v22 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Int32Enum>>)+B0]");
		object obj11 = (nint)0 + (nint)8;
		object obj12 = default(object);
		object obj13 = default(object);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X10_v31-8]");
			obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X10_v31-8]");
			if (0 == num2)
			{
				break;
			}
			obj13 = obj11 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X8_v22 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Int32Enum>>)+12E]");
			obj5 = -1;
			bool flag5 = (nint)obj5 != 1;
			obj11 = obj13;
			if (flag5)
			{
				continue;
			}
			goto IL_01c0;
		}
		obj5 = obj11;
		object obj14 = num3 + obj11;
		object obj15 = obj14 + 312;
		obj13 = obj11;
		goto IL_0d2e;
		IL_0cb2:
		throw new NullReferenceException();
		IL_0d2e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X0_v34+8]");
		text = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v344 @ X0_v34] (should have been resolved before IL gen)");
		object obj16 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
		object obj17 = 147423232 + 3472;
		object obj18 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1520;
		num = (nint)(&obj7);
		reference2 = ref t;
		object obj22 = default(object);
		RuntimeTypeHandle runtimeTypeHandle = default(RuntimeTypeHandle);
		object obj42 = default(object);
		bool result2 = default(bool);
		object obj45 = default(object);
		IntPtr intPtr2 = default(IntPtr);
		nint num12 = default(nint);
		object obj35 = default(object);
		object obj58 = default(object);
		object obj63 = default(object);
		nint num5 = default(nint);
		object obj37 = default(object);
		nint num8 = default(nint);
		nint num6;
		ref T reference3;
		object obj43;
		while (true)
		{
			if (false)
			{
				object obj19 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X8_v28+12E]");
				obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X8_v28+12E]");
				if ((nint)0 == 0)
				{
					goto IL_02a8;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X8_v28+B0]");
				object obj20 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ X10_v26-8]");
					obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ X10_v26-8]");
					if (0 == (nint)obj16)
					{
						break;
					}
					obj13 = obj20 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X8_v28+12E]");
					obj5 = -1;
					bool flag6 = (nint)obj5 != 1;
					obj20 = obj13;
					if (flag6)
					{
						continue;
					}
					goto IL_02a8;
				}
				obj5 = obj20;
				object obj21 = obj19 + obj20;
				obj22 = obj21 + 312;
				obj13 = obj20;
				goto IL_0dc8;
			}
			NullReferenceException ex = new NullReferenceException();
			object obj23 = 0;
			break;
			IL_08b3:
			object obj24 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
			object obj26;
			object obj25 = obj26;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v619 @ X8_v15+12E]");
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v619 @ X8_v15+12E]");
			if ((nint)0 == 0)
			{
				goto IL_096b;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v619 @ X8_v15+B0]");
			object obj27 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v737 @ X10_v10-8]");
				obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v737 @ X10_v10-8]");
				if (0 == (nint)obj24)
				{
					break;
				}
				obj13 = obj27 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v619 @ X8_v15+12E]");
				obj5 = -1;
				bool flag7 = (nint)obj5 != 1;
				obj27 = obj13;
				if (flag7)
				{
					continue;
				}
				goto IL_096b;
			}
			obj5 = obj27;
			object obj28 = obj25 + obj27;
			object obj29 = obj28 + 312;
			nint num4 = num5;
			obj13 = obj27;
			goto IL_0fba;
			IL_0ef6:
			object obj30;
			bool flag8 = obj30 == null;
			object obj31 = !flag8;
			nint num7;
			num6 = num7;
			object obj32;
			obj12 = obj32;
			ref T reference4;
			reference3 = ref reference4;
			object obj33;
			obj16 = obj33;
			object obj34;
			obj18 = obj34;
			object obj36;
			obj35 = obj36;
			RuntimeTypeHandle runtimeTypeHandle2;
			runtimeTypeHandle = runtimeTypeHandle2;
			object obj38;
			obj37 = obj38;
			nint num9;
			num8 = num9;
			num5 = num4;
			object obj39;
			obj13 = obj39;
			object obj40;
			obj23 = obj40;
			ref T reference5;
			reference2 = ref reference5;
			bool result;
			if (obj31 == null)
			{
				return result;
			}
			OutOfMemoryException ex2 = new OutOfMemoryException();
			object obj41;
			if ((nint)text == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				obj41 = obj42;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				obj43 = obj42;
				goto IL_1049;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return result2;
			IL_1049:
			bool flag9 = 0 == 0;
			bool flag10 = false;
			obj26 = 0;
			num7 = num6;
			obj32 = obj12;
			reference4 = ref reference3;
			obj33 = obj16;
			obj34 = obj18;
			obj36 = obj35;
			runtimeTypeHandle2 = runtimeTypeHandle;
			obj38 = obj37;
			num9 = num8;
			num4 = num5;
			obj39 = obj13;
			obj40 = obj23;
			result = false;
			reference5 = ref reference2;
			obj30 = obj41;
			if (!flag9)
			{
				goto IL_08b3;
			}
			goto IL_0ef6;
			IL_03d0:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num5 = unchecked((nint)null);
			goto IL_0e86;
			IL_02a8:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num5 = unchecked((nint)null);
			goto IL_0dc8;
			IL_0dc8:
			num = (nint)obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v694 @ X0_v40+8]");
			text = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v694 @ X0_v40] (should have been resolved before IL gen)");
			object obj44 = obj45 & 1;
			if (obj44 != null)
			{
				if (false)
				{
					object obj46 = (nint)0 + (nint)309;
					object obj47 = obj46 & 1;
					bool flag11 = obj47 == null;
					object obj48 = !flag11;
					nint num10 = 0;
					if (obj48 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
						num10 = intPtr2;
					}
					object obj49 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v767 @ X8_v34+12E]");
					obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v767 @ X8_v34+12E]");
					if ((nint)0 == 0)
					{
						goto IL_03d0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v767 @ X8_v34+B0]");
					object obj50 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v809 @ X10_v21-8]");
						obj12 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v809 @ X10_v21-8]");
						if (0 == num10)
						{
							break;
						}
						obj13 = obj50 + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v767 @ X8_v34+12E]");
						obj5 = -1;
						bool flag12 = (nint)obj5 != 1;
						obj50 = obj13;
						if (flag12)
						{
							continue;
						}
						goto IL_03d0;
					}
					obj5 = obj50;
					object obj51 = obj49 + obj50;
					object obj52 = obj51 + 312;
					obj13 = obj50;
					goto IL_0e86;
				}
				NullReferenceException ex3 = new NullReferenceException();
				obj23 = 0;
				break;
			}
			num6 = (nint)(&obj7);
			reference3 = ref t;
			obj43 = 0;
			obj23 = 0;
			obj41 = 0;
			goto IL_1049;
			IL_0e86:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v824 @ X0_v45] (should have been resolved before IL gen)");
			object obj53 = (nint)0 + (nint)309;
			object obj54 = obj53 & 1;
			bool flag13 = obj54 == null;
			object obj55 = !flag13;
			nint num11 = 0;
			if (obj55 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			}
			string text2 = ((Enum)(&num12)).ToString();
			if ((object)typeFromHandle != null)
			{
				MemberInfo[] member = typeFromHandle.GetMember(text2);
				if (member != null)
				{
					num = member.Length;
					if (member.Length != 0)
					{
						reference2 = ref *(T*)member[0];
						runtimeTypeHandle = (RuntimeTypeHandle)obj17;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X28_v2+E0]");
						object obj56 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v844 @ X0_v57+E4]");
						num = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v844 @ X0_v57+E4]");
						bool flag14 = (nint)0 == 0;
						object obj57 = !flag14;
						if (obj57 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Type typeFromHandle3 = Type.GetTypeFromHandle(runtimeTypeHandle);
						if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2) != null)
						{
							T val = (T)System.Runtime.CompilerServices.Unsafe.As<T, object>(ref reference2);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v576 @ X8_v43 (T)+218]");
							obj5 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v576 @ X8_v43 (T)+220]");
							obj35 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v576 @ X8_v43 (T)+218] (should have been resolved before IL gen)");
							if (obj58 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v853 @ X0_v63+18]");
								num = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v853 @ X0_v63+18]");
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v853 @ X0_v63+20]");
									object obj59 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v853 @ X0_v63+20]");
									if ((nint)0 != 0)
									{
										text = (string)obj18;
										num = (nint)obj59;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X8_v9 (Il2CppMethodRgctx<EnumMethods::TryFromFriendlyName>)+130]");
										obj13 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X1_v6 (System.String)+130]");
										obj5 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X8_v9 (Il2CppMethodRgctx<EnumMethods::TryFromFriendlyName>)+130]");
										nint num13 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X1_v6 (System.String)+130]");
										bool flag15 = num13 < 0;
										object obj60 = !flag15;
										object obj61 = ~obj60;
										if (obj61 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X8_v9 (Il2CppMethodRgctx<EnumMethods::TryFromFriendlyName>)+C8]");
											nint num14 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X1_v6 (System.String)+130]");
											object obj62 = num14 + 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v867 @ X8_v48-8]");
											num = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v867 @ X8_v48-8]");
											if (0 == (nint)text)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v854 @ X0_v66+10]");
												if ((nint)0 != 0)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v854 @ X0_v66+10]");
													bool flag16 = ((string)0).Equals(friendlyName, StringComparison.InvariantCultureIgnoreCase);
													bool flag17 = !flag16;
													obj35 = 0;
													obj37 = obj63;
													num8 = -1;
													num12 = num11;
													num5 = 3;
													text = friendlyName;
													if (flag17)
													{
														continue;
													}
													reference = ref *(T*)obj63;
													bool flag18 = 0 == 0;
													object obj64 = !flag18;
													num6 = (nint)(&obj7);
													reference3 = ref t;
													obj43 = 0;
													obj35 = 0;
													obj37 = obj63;
													num8 = -1;
													num5 = 3;
													obj23 = obj63;
													flag10 = true;
													obj26 = 0;
													obj41 = 0;
													if (obj64 != null)
													{
														goto IL_08b3;
													}
													num7 = (nint)(&obj7);
													obj32 = obj12;
													reference4 = ref t;
													obj43 = 0;
													obj33 = obj16;
													obj34 = obj18;
													obj36 = 0;
													runtimeTypeHandle2 = runtimeTypeHandle;
													obj38 = obj63;
													num9 = -1;
													num4 = 3;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X8_v9 (Il2CppMethodRgctx<EnumMethods::TryFromFriendlyName>)+130]");
													obj39 = 0;
													obj40 = obj63;
													result = true;
													text = friendlyName;
													reference5 = ref reference2;
													obj30 = 0;
													goto IL_0ef6;
												}
												NullReferenceException ex4 = new NullReferenceException();
												obj37 = obj63;
												num8 = -1;
												num5 = unchecked((nint)null);
												obj23 = obj63;
												break;
											}
										}
										InvalidCastException ex5 = new InvalidCastException();
										obj37 = obj63;
										num8 = -1;
										num5 = unchecked((nint)null);
										obj23 = obj63;
									}
									else
									{
										NullReferenceException ex6 = new NullReferenceException();
										obj37 = obj63;
										num8 = -1;
										num5 = unchecked((nint)null);
										obj23 = obj63;
										text = (string)(object)typeFromHandle3;
									}
								}
								else
								{
									IndexOutOfRangeException ex7 = new IndexOutOfRangeException();
									obj37 = obj63;
									num8 = -1;
									num5 = unchecked((nint)null);
									obj23 = obj63;
									text = (string)(object)typeFromHandle3;
								}
							}
							else
							{
								NullReferenceException ex8 = new NullReferenceException();
								obj37 = obj63;
								num8 = -1;
								num5 = unchecked((nint)null);
								obj23 = obj63;
								text = (string)(object)typeFromHandle3;
							}
						}
						else
						{
							NullReferenceException ex9 = new NullReferenceException();
							obj37 = obj63;
							num8 = -1;
							num5 = unchecked((nint)null);
							obj23 = obj63;
							text = (string)(object)typeFromHandle3;
						}
					}
					else
					{
						IndexOutOfRangeException ex10 = new IndexOutOfRangeException();
						obj37 = obj63;
						num8 = -1;
						num5 = unchecked((nint)null);
						obj23 = obj63;
						text = text2;
					}
				}
				else
				{
					NullReferenceException ex11 = new NullReferenceException();
					obj37 = obj63;
					num8 = -1;
					num5 = unchecked((nint)null);
					obj23 = obj63;
					text = text2;
					num = -1;
				}
			}
			else
			{
				NullReferenceException ex12 = new NullReferenceException();
				obj37 = obj63;
				num8 = -1;
				obj23 = obj63;
				text = text2;
				num = -1;
			}
			break;
			IL_0fba:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v759 @ X0_v27+8]");
			text = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v759 @ X0_v27] (should have been resolved before IL gen)");
			num7 = num6;
			obj32 = obj12;
			reference4 = ref reference3;
			obj33 = obj16;
			obj34 = obj18;
			obj36 = obj35;
			runtimeTypeHandle2 = runtimeTypeHandle;
			obj38 = obj37;
			num9 = num8;
			obj39 = obj13;
			obj40 = obj23;
			result = flag10;
			reference5 = ref reference2;
			obj30 = obj41;
			goto IL_0ef6;
			IL_096b:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num4 = unchecked((nint)null);
			goto IL_0fba;
		}
		num6 = (nint)(&obj7);
		reference3 = ref t;
		obj43 = 0;
		goto IL_0cb2;
		IL_01c0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num5 = unchecked((nint)null);
		goto IL_0d2e;
	}
}
