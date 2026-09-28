using System;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.IO;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Unity.Properties;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.TextCore;

public class AndroidInterface : MonoBehaviour
{
	private static readonly AndroidJavaObject _plugin;

	private const string ObjectName = "KAndroidHelper";

	private static bool? playServicesAvailable;

	public static event Action<string> OnGalleryPickDone
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0211: Expected O, but got I4
			//IL_022e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0233: Expected O, but got Unknown
			//IL_0243: Expected O, but got I
			//IL_0253: Expected O, but got I
			//IL_0170: Expected O, but got I4
			//IL_0179: Expected O, but got I4
			//IL_0182: Expected O, but got I4
			//IL_0046: Expected O, but got I
			//IL_00fb: Expected O, but got I4
			object obj = typeof(SqlSingle[]) + 3560;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v4+10]");
			Delegate obj6 = (Delegate)0;
			Delegate obj8 = default(Delegate);
			object obj9 = default(object);
			Delegate obj13 = default(Delegate);
			Delegate obj21 = default(Delegate);
			while (true)
			{
				Delegate obj7 = Delegate.Combine(obj6, value);
				object obj14;
				Delegate obj15;
				Delegate obj16;
				object obj10;
				object obj12;
				if ((object)obj7 != null)
				{
					obj8 = (Delegate)obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					if (obj9 == null)
					{
						break;
					}
					obj10 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v15+E4]");
					bool flag2 = (nint)0 == 0;
					object obj11 = !flag2;
					obj12 = obj9;
					obj13 = obj7;
					if (obj11 != null)
					{
						goto IL_0030;
					}
					obj14 = obj9;
					obj15 = obj7;
					obj16 = (Delegate)obj4;
					Delegate obj17 = (Delegate)obj4;
					object obj18 = obj10;
				}
				else
				{
					obj10 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v15+E4]");
					bool flag3 = (nint)0 == 0;
					object obj19 = !flag3;
					obj12 = 0;
					obj14 = 0;
					obj15 = obj13;
					obj16 = obj8;
					Delegate obj17 = value;
					object obj18 = obj10;
					if (obj19 != null)
					{
						goto IL_0030;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj10 = obj;
				obj12 = obj14;
				obj13 = obj15;
				obj8 = obj16;
				goto IL_0030;
				IL_0030:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v15+B8]");
				object obj20 = (nint)0 + (nint)16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj21 == obj6;
				obj6 = obj21;
				if (!flag4)
				{
					continue;
				}
				return;
			}
			throw new InvalidCastException();
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0211: Expected O, but got I4
			//IL_022e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0233: Expected O, but got Unknown
			//IL_0243: Expected O, but got I
			//IL_0253: Expected O, but got I
			//IL_0170: Expected O, but got I4
			//IL_0179: Expected O, but got I4
			//IL_0182: Expected O, but got I4
			//IL_0046: Expected O, but got I
			//IL_00fb: Expected O, but got I4
			object obj = typeof(SqlSingle[]) + 3560;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v4+10]");
			Delegate obj6 = (Delegate)0;
			Delegate obj8 = default(Delegate);
			object obj9 = default(object);
			Delegate obj13 = default(Delegate);
			Delegate obj21 = default(Delegate);
			while (true)
			{
				Delegate obj7 = Delegate.Remove(obj6, value);
				object obj14;
				Delegate obj15;
				Delegate obj16;
				object obj10;
				object obj12;
				if ((object)obj7 != null)
				{
					obj8 = (Delegate)obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					if (obj9 == null)
					{
						break;
					}
					obj10 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v15+E4]");
					bool flag2 = (nint)0 == 0;
					object obj11 = !flag2;
					obj12 = obj9;
					obj13 = obj7;
					if (obj11 != null)
					{
						goto IL_0030;
					}
					obj14 = obj9;
					obj15 = obj7;
					obj16 = (Delegate)obj4;
					Delegate obj17 = (Delegate)obj4;
					object obj18 = obj10;
				}
				else
				{
					obj10 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v15+E4]");
					bool flag3 = (nint)0 == 0;
					object obj19 = !flag3;
					obj12 = 0;
					obj14 = 0;
					obj15 = obj13;
					obj16 = obj8;
					Delegate obj17 = value;
					object obj18 = obj10;
					if (obj19 != null)
					{
						goto IL_0030;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj10 = obj;
				obj12 = obj14;
				obj13 = obj15;
				obj8 = obj16;
				goto IL_0030;
				IL_0030:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v15+B8]");
				object obj20 = (nint)0 + (nint)16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj21 == obj6;
				obj6 = obj21;
				if (!flag4)
				{
					continue;
				}
				return;
			}
			throw new InvalidCastException();
		}
	}

	public static event Action<string> OnCameraTakeDone
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0211: Expected O, but got I4
			//IL_022e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0233: Expected O, but got Unknown
			//IL_0243: Expected O, but got I
			//IL_0253: Expected O, but got I
			//IL_0170: Expected O, but got I4
			//IL_0179: Expected O, but got I4
			//IL_0182: Expected O, but got I4
			//IL_0046: Expected O, but got I
			//IL_00fb: Expected O, but got I4
			object obj = typeof(SqlSingle[]) + 3560;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v4+18]");
			Delegate obj6 = (Delegate)0;
			Delegate obj8 = default(Delegate);
			object obj9 = default(object);
			Delegate obj13 = default(Delegate);
			Delegate obj21 = default(Delegate);
			while (true)
			{
				Delegate obj7 = Delegate.Combine(obj6, value);
				object obj14;
				Delegate obj15;
				Delegate obj16;
				object obj10;
				object obj12;
				if ((object)obj7 != null)
				{
					obj8 = (Delegate)obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					if (obj9 == null)
					{
						break;
					}
					obj10 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v15+E4]");
					bool flag2 = (nint)0 == 0;
					object obj11 = !flag2;
					obj12 = obj9;
					obj13 = obj7;
					if (obj11 != null)
					{
						goto IL_0030;
					}
					obj14 = obj9;
					obj15 = obj7;
					obj16 = (Delegate)obj4;
					Delegate obj17 = (Delegate)obj4;
					object obj18 = obj10;
				}
				else
				{
					obj10 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v15+E4]");
					bool flag3 = (nint)0 == 0;
					object obj19 = !flag3;
					obj12 = 0;
					obj14 = 0;
					obj15 = obj13;
					obj16 = obj8;
					Delegate obj17 = value;
					object obj18 = obj10;
					if (obj19 != null)
					{
						goto IL_0030;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj10 = obj;
				obj12 = obj14;
				obj13 = obj15;
				obj8 = obj16;
				goto IL_0030;
				IL_0030:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v15+B8]");
				object obj20 = (nint)0 + (nint)24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj21 == obj6;
				obj6 = obj21;
				if (!flag4)
				{
					continue;
				}
				return;
			}
			throw new InvalidCastException();
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0211: Expected O, but got I4
			//IL_022e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0233: Expected O, but got Unknown
			//IL_0243: Expected O, but got I
			//IL_0253: Expected O, but got I
			//IL_0170: Expected O, but got I4
			//IL_0179: Expected O, but got I4
			//IL_0182: Expected O, but got I4
			//IL_0046: Expected O, but got I
			//IL_00fb: Expected O, but got I4
			object obj = typeof(SqlSingle[]) + 3560;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v4+18]");
			Delegate obj6 = (Delegate)0;
			Delegate obj8 = default(Delegate);
			object obj9 = default(object);
			Delegate obj13 = default(Delegate);
			Delegate obj21 = default(Delegate);
			while (true)
			{
				Delegate obj7 = Delegate.Remove(obj6, value);
				object obj14;
				Delegate obj15;
				Delegate obj16;
				object obj10;
				object obj12;
				if ((object)obj7 != null)
				{
					obj8 = (Delegate)obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					if (obj9 == null)
					{
						break;
					}
					obj10 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v15+E4]");
					bool flag2 = (nint)0 == 0;
					object obj11 = !flag2;
					obj12 = obj9;
					obj13 = obj7;
					if (obj11 != null)
					{
						goto IL_0030;
					}
					obj14 = obj9;
					obj15 = obj7;
					obj16 = (Delegate)obj4;
					Delegate obj17 = (Delegate)obj4;
					object obj18 = obj10;
				}
				else
				{
					obj10 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v15+E4]");
					bool flag3 = (nint)0 == 0;
					object obj19 = !flag3;
					obj12 = 0;
					obj14 = 0;
					obj15 = obj13;
					obj16 = obj8;
					Delegate obj17 = value;
					object obj18 = obj10;
					if (obj19 != null)
					{
						goto IL_0030;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj10 = obj;
				obj12 = obj14;
				obj13 = obj15;
				obj8 = obj16;
				goto IL_0030;
				IL_0030:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v15+B8]");
				object obj20 = (nint)0 + (nint)24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj21 == obj6;
				obj6 = obj21;
				if (!flag4)
				{
					continue;
				}
				return;
			}
			throw new InvalidCastException();
		}
	}

	public static event Action OnGalleryCancel
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0152: Expected O, but got I4
			//IL_016f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Expected O, but got Unknown
			//IL_0184: Expected O, but got I
			//IL_0194: Expected O, but got I
			//IL_00fb: Expected O, but got I4
			//IL_0046: Expected O, but got I
			object obj = typeof(SqlSingle[]) + 3560;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+20]");
			Delegate obj6 = (Delegate)0;
			Delegate obj12 = default(Delegate);
			while (true)
			{
				Delegate obj7 = Delegate.Combine(obj6, value);
				bool flag2 = (object)obj7 == null;
				Delegate obj8 = value;
				if (!flag2)
				{
					obj8 = (Delegate)obj4;
					if (obj7 != obj4)
					{
						break;
					}
				}
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+B8]");
				object obj11 = (nint)0 + (nint)32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj12 == obj6;
				obj6 = obj12;
				if (!flag4)
				{
					continue;
				}
				return;
			}
			throw new InvalidCastException();
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0152: Expected O, but got I4
			//IL_016f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Expected O, but got Unknown
			//IL_0184: Expected O, but got I
			//IL_0194: Expected O, but got I
			//IL_00fb: Expected O, but got I4
			//IL_0046: Expected O, but got I
			object obj = typeof(SqlSingle[]) + 3560;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+20]");
			Delegate obj6 = (Delegate)0;
			Delegate obj12 = default(Delegate);
			while (true)
			{
				Delegate obj7 = Delegate.Remove(obj6, value);
				bool flag2 = (object)obj7 == null;
				Delegate obj8 = value;
				if (!flag2)
				{
					obj8 = (Delegate)obj4;
					if (obj7 != obj4)
					{
						break;
					}
				}
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+B8]");
				object obj11 = (nint)0 + (nint)32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj12 == obj6;
				obj6 = obj12;
				if (!flag4)
				{
					continue;
				}
				return;
			}
			throw new InvalidCastException();
		}
	}

	public static event Action OnCameraCancel
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0152: Expected O, but got I4
			//IL_016f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Expected O, but got Unknown
			//IL_0184: Expected O, but got I
			//IL_0194: Expected O, but got I
			//IL_00fb: Expected O, but got I4
			//IL_0046: Expected O, but got I
			object obj = typeof(SqlSingle[]) + 3560;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+28]");
			Delegate obj6 = (Delegate)0;
			Delegate obj12 = default(Delegate);
			while (true)
			{
				Delegate obj7 = Delegate.Combine(obj6, value);
				bool flag2 = (object)obj7 == null;
				Delegate obj8 = value;
				if (!flag2)
				{
					obj8 = (Delegate)obj4;
					if (obj7 != obj4)
					{
						break;
					}
				}
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+B8]");
				object obj11 = (nint)0 + (nint)40;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj12 == obj6;
				obj6 = obj12;
				if (!flag4)
				{
					continue;
				}
				return;
			}
			throw new InvalidCastException();
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0152: Expected O, but got I4
			//IL_016f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Expected O, but got Unknown
			//IL_0184: Expected O, but got I
			//IL_0194: Expected O, but got I
			//IL_00fb: Expected O, but got I4
			//IL_0046: Expected O, but got I
			object obj = typeof(SqlSingle[]) + 3560;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+28]");
			Delegate obj6 = (Delegate)0;
			Delegate obj12 = default(Delegate);
			while (true)
			{
				Delegate obj7 = Delegate.Remove(obj6, value);
				bool flag2 = (object)obj7 == null;
				Delegate obj8 = value;
				if (!flag2)
				{
					obj8 = (Delegate)obj4;
					if (obj7 != obj4)
					{
						break;
					}
				}
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+B8]");
				object obj11 = (nint)0 + (nint)40;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj12 == obj6;
				obj6 = obj12;
				if (!flag4)
				{
					continue;
				}
				return;
			}
			throw new InvalidCastException();
		}
	}

	public static event Action OnCameraPermissionDenied
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0152: Expected O, but got I4
			//IL_016f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Expected O, but got Unknown
			//IL_0184: Expected O, but got I
			//IL_0194: Expected O, but got I
			//IL_00fb: Expected O, but got I4
			//IL_0046: Expected O, but got I
			object obj = typeof(SqlSingle[]) + 3560;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+30]");
			Delegate obj6 = (Delegate)0;
			Delegate obj12 = default(Delegate);
			while (true)
			{
				Delegate obj7 = Delegate.Combine(obj6, value);
				bool flag2 = (object)obj7 == null;
				Delegate obj8 = value;
				if (!flag2)
				{
					obj8 = (Delegate)obj4;
					if (obj7 != obj4)
					{
						break;
					}
				}
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+B8]");
				object obj11 = (nint)0 + (nint)48;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj12 == obj6;
				obj6 = obj12;
				if (!flag4)
				{
					continue;
				}
				return;
			}
			throw new InvalidCastException();
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0152: Expected O, but got I4
			//IL_016f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Expected O, but got Unknown
			//IL_0184: Expected O, but got I
			//IL_0194: Expected O, but got I
			//IL_00fb: Expected O, but got I4
			//IL_0046: Expected O, but got I
			object obj = typeof(SqlSingle[]) + 3560;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+30]");
			Delegate obj6 = (Delegate)0;
			Delegate obj12 = default(Delegate);
			while (true)
			{
				Delegate obj7 = Delegate.Remove(obj6, value);
				bool flag2 = (object)obj7 == null;
				Delegate obj8 = value;
				if (!flag2)
				{
					obj8 = (Delegate)obj4;
					if (obj7 != obj4)
					{
						break;
					}
				}
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+B8]");
				object obj11 = (nint)0 + (nint)48;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj12 == obj6;
				obj6 = obj12;
				if (!flag4)
				{
					continue;
				}
				return;
			}
			throw new InvalidCastException();
		}
	}

	static AndroidInterface()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00cb: Expected O, but got I4
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected O, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_0140: Expected O, but got I
		//IL_017c: Expected O, but got I
		//IL_0221: Expected O, but got I
		//IL_0231: Expected O, but got I
		//IL_0247: Expected O, but got I
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected O, but got Unknown
		//IL_026f: Expected O, but got I4
		//IL_027f: Expected O, but got I
		//IL_02be: Expected O, but got I4
		//IL_01b1: Expected O, but got I
		//IL_01c7: Expected O, but got I
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected O, but got Unknown
		//IL_02eb: Expected O, but got I
		//IL_02fb: Expected O, but got I
		//IL_0311: Expected O, but got I
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Expected O, but got Unknown
		//IL_0341: Expected O, but got I4
		//IL_0376: Expected O, but got I4
		//IL_0202: Expected O, but got I
		//IL_0399: Expected O, but got I
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Expected O, but got Unknown
		//IL_03bc: Expected O, but got I
		//IL_03e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ed: Expected O, but got Unknown
		//IL_0424: Expected O, but got I4
		//IL_042d: Expected O, but got I4
		//IL_043e: Expected O, but got I4
		//IL_045f: Expected O, but got I4
		//IL_0478: Expected O, but got I4
		//IL_0481: Expected O, but got I4
		//IL_08e5: Expected O, but got I4
		//IL_049e: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a3: Expected O, but got Unknown
		//IL_04ab: Expected I, but got O
		//IL_04bb: Expected O, but got I
		//IL_0865: Expected O, but got I4
		//IL_0886: Expected O, but got I4
		//IL_05e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ec: Expected O, but got Unknown
		//IL_0616: Expected O, but got I4
		//IL_093f: Expected O, but got I
		//IL_04f6: Expected O, but got I
		//IL_08bd: Expected O, but got I4
		//IL_063f: Expected O, but got I
		//IL_05ca: Expected O, but got I4
		//IL_0903: Expected O, but got I
		//IL_056b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0570: Expected O, but got Unknown
		//IL_0579: Unknown result type (might be due to invalid IL or missing references)
		//IL_057e: Expected O, but got Unknown
		//IL_0504: Unknown result type (might be due to invalid IL or missing references)
		//IL_0509: Expected O, but got Unknown
		//IL_051f: Expected O, but got I
		//IL_0688: Unknown result type (might be due to invalid IL or missing references)
		//IL_068d: Expected O, but got Unknown
		//IL_06e8: Expected O, but got I
		//IL_077a: Unknown result type (might be due to invalid IL or missing references)
		//IL_077f: Expected O, but got Unknown
		//IL_07b6: Expected O, but got I4
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6F90]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v57+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v57+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		RuntimePlatform platform = Application.platform;
		if (platform != RuntimePlatform.Android)
		{
			return;
		}
		goto IL_0111;
		IL_0927:
		object obj6 = default(object);
		object obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X0_v39+8]");
		string text = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v501 @ X0_v39] (should have been resolved before IL gen)");
		object obj8 = default(object);
		object obj7 = obj8;
		object obj10 = default(object);
		object obj9 = obj10;
		object obj12;
		object obj11 = obj12;
		object obj14;
		object obj13 = obj14;
		object obj16;
		object obj15 = obj16;
		goto IL_08cb;
		IL_07fb:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0976;
		IL_08cb:
		bool flag2 = obj15 == null;
		object obj17 = !flag2;
		object[] array;
		if (obj17 == null)
		{
			if ((nint)obj13 != 3)
			{
				bool flag3 = obj13 == null;
				object obj18 = !flag3;
				if (obj18 != null)
				{
					return;
				}
			}
			object obj19 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj20 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ X0_v21+E4]");
			bool flag4 = (nint)0 == 0;
			object obj21 = !flag4;
			if (obj21 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj22 = (nint)0 + (nint)4080;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
			UnityEngine.Object obj23 = default(UnityEngine.Object);
			if (!(obj23 == null))
			{
				return;
			}
			obj5 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2096;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			GameObject gameObject = default(GameObject);
			gameObject..ctor();
			bool flag5 = (object)gameObject == null;
			obj8 = obj7;
			obj10 = obj9;
			array = null;
			text = null;
			if (!flag5)
			{
				obj5 = (nint)0 + (nint)536;
				text = (string)obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32E24");
				UnityEngine.Component component = default(UnityEngine.Component);
				bool flag6 = (object)component == null;
				obj8 = obj7;
				obj10 = obj9;
				array = null;
				if (!flag6)
				{
					GameObject gameObject2 = component.gameObject;
					bool flag7 = (object)gameObject2 == null;
					obj8 = obj7;
					obj10 = obj9;
					array = null;
					text = null;
					if (!flag7)
					{
						object obj24 = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 3368;
						gameObject2.name = (string)obj24;
						object obj25 = obj19;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X0_v31+E4]");
						bool flag8 = (nint)0 == 0;
						object obj26 = !flag8;
						if (obj26 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						UnityEngine.Object.DontDestroyOnLoad(component);
						return;
					}
				}
			}
			goto IL_0976;
		}
		OutOfMemoryException ex2 = new OutOfMemoryException();
		obj8 = obj7;
		obj10 = obj9;
		goto IL_07fb;
		IL_0074:
		RuntimePlatform platform2 = Application.platform;
		if (platform2 != RuntimePlatform.Android)
		{
			return;
		}
		goto IL_0111;
		IL_0111:
		object obj27 = typeof(SqlSingle[]) + 3568;
		object obj28 = "clear_mass_tournaments" + 3984;
		object obj29 = (nint)0 + (nint)3232;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		text = (string)obj28;
		AndroidJavaClass androidJavaClass = default(AndroidJavaClass);
		androidJavaClass..ctor((string)obj28);
		object obj30 = obj29;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X20_v5+38]");
		object obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X20_v5+38]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v6+10]");
			object obj32 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v6+10]");
			object obj33 = (nint)0 + (nint)309;
			object obj34 = obj33 & 1;
			if (obj34 == null)
			{
				goto IL_028d;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v6+10]");
			object obj35 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X20_v5+38]");
			object obj36 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X8_v41+10]");
			object obj32 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X8_v41+10]");
			object obj37 = (nint)0 + (nint)309;
			object obj38 = obj37 & 1;
			bool flag9 = obj38 == null;
			object obj39 = !flag9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X8_v41+10]");
			object obj35 = 0;
			if (obj39 == null)
			{
				goto IL_028d;
			}
		}
		goto IL_029c;
		IL_0547:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		array = null;
		goto IL_0927;
		IL_0976:
		NullReferenceException ex3 = new NullReferenceException();
		object[] array2;
		AndroidJavaClass androidJavaClass2;
		object obj42;
		if ((nint)text == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			object obj40 = default(object);
			obj16 = obj40;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			bool flag10 = androidJavaClass == null;
			object obj41 = !flag10;
			obj12 = obj11;
			obj42 = obj40;
			array2 = array;
			obj14 = 0;
			androidJavaClass2 = androidJavaClass;
			if (obj41 != null)
			{
				goto IL_048f;
			}
			obj7 = obj8;
			obj9 = obj10;
			obj42 = obj40;
			obj13 = 0;
			obj15 = obj40;
			goto IL_08cb;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_028d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		goto IL_029c;
		IL_048f:
		object obj43 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
		nint num = (nint)androidJavaClass2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X8_v28 (Il2CppClass<UnityEngine.AndroidJavaClass>)+12E]");
		object obj44 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X8_v28 (Il2CppClass<UnityEngine.AndroidJavaClass>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0547;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X8_v28 (Il2CppClass<UnityEngine.AndroidJavaClass>)+B0]");
		object obj45 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X10_v9-8]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X10_v9-8]");
			if (0 == (nint)obj43)
			{
				break;
			}
			obj10 = obj45 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X8_v28 (Il2CppClass<UnityEngine.AndroidJavaClass>)+12E]");
			obj44 = -1;
			bool flag11 = (nint)obj44 != 1;
			obj45 = obj10;
			if (flag11)
			{
				continue;
			}
			goto IL_0547;
		}
		obj44 = obj45;
		object obj46 = num + obj45;
		obj6 = obj46 + 312;
		obj10 = obj45;
		array = array2;
		goto IL_0927;
		IL_029c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X0_v4+E4]");
		bool flag12 = (nint)0 == 0;
		object obj47 = !flag12;
		if (obj47 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X20_v5+38]");
		object obj48 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v9+10]");
		object obj49 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v9+10]");
		object obj50 = (nint)0 + (nint)309;
		obj5 = obj50;
		object obj51 = obj50 & 1;
		bool flag13 = obj51 == null;
		object obj52 = !flag13;
		if (obj52 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		bool flag14 = androidJavaClass == null;
		obj42 = 0;
		array = null;
		if (flag14)
		{
			goto IL_07fb;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X0_v7+B8]");
		object obj53 = 0;
		array2 = (object[])obj53;
		object methodName = "https://www.kammelna.com/Home/Terms" + 1544;
		object obj54 = (nint)0 + (nint)920;
		obj12 = obj54;
		object obj55 = androidJavaClass.CallStatic<object>((string)methodName, (object[])obj53);
		object obj56 = typeof(SqlSingle[]) + 3560;
		obj5 = obj56;
		object obj57 = obj55;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool flag15 = androidJavaClass == null;
		obj42 = 0;
		obj14 = 3;
		androidJavaClass2 = androidJavaClass;
		obj16 = 0;
		obj7 = obj8;
		obj9 = obj10;
		obj11 = obj54;
		obj42 = 0;
		array = (object[])obj53;
		text = (string)obj55;
		obj13 = 3;
		obj15 = 0;
		if (!flag15)
		{
			goto IL_048f;
		}
		goto IL_08cb;
	}

	public static Texture2D textureFromFileAtPath(string filePath)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 656;
		string path = default(string);
		byte[] data = File.ReadAllBytes(path);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Texture2D texture2D = default(Texture2D);
		texture2D..ctor(1, 1);
		bool flag = ImageConversion.LoadImage(texture2D, data);
		if ((object)texture2D != null)
		{
			texture2D.Apply();
			return texture2D;
		}
		return (Texture2D)(object)new NullReferenceException();
	}

	public static int GetMicAmplitude()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0286: Expected O, but got I
		//IL_02b0: Expected O, but got I4
		//IL_00a9: Expected O, but got I
		//IL_00c9: Expected O, but got I
		//IL_005c: Expected O, but got I
		//IL_036a: Expected O, but got I
		//IL_037a: Expected O, but got I
		//IL_0390: Expected O, but got I
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Expected O, but got Unknown
		//IL_03b8: Expected O, but got I4
		//IL_03d8: Expected O, but got I
		//IL_02f0: Expected O, but got I
		//IL_0310: Expected O, but got I
		//IL_0332: Expected O, but got I4
		//IL_010e: Expected O, but got I
		//IL_0124: Expected O, but got I
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected O, but got Unknown
		//IL_0151: Expected O, but got I
		//IL_044a: Expected O, but got I
		//IL_045a: Expected O, but got I
		//IL_0470: Expected O, but got I
		//IL_0479: Unknown result type (might be due to invalid IL or missing references)
		//IL_047e: Expected O, but got Unknown
		//IL_0498: Expected O, but got I4
		//IL_04b0: Expected O, but got I
		//IL_0412: Expected O, but got I4
		//IL_01b4: Expected O, but got I
		//IL_01c4: Expected O, but got I
		//IL_01da: Expected O, but got I
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected O, but got Unknown
		//IL_0207: Expected O, but got I
		//IL_0506: Expected I4, but got O
		//IL_04e2: Expected O, but got I4
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Expected O, but got Unknown
		//IL_025a: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(SqlSingle[]) + 3560;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6F92]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object obj7;
		if (obj3 != null)
		{
			obj4 = (nint)0 + (nint)3232;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v39+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj5;
			obj7 = obj4;
			if (!flag)
			{
				goto IL_0099;
			}
		}
		else
		{
			_ = 1;
			obj4 = (nint)0 + (nint)3232;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v39+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			object obj6 = obj5;
			obj7 = obj4;
			if (obj8 != null)
			{
				goto IL_0099;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v16+B8]");
		object obj10 = 0;
		AndroidJavaObject androidJavaObject = (AndroidJavaObject)obj10;
		object obj11 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X20_v14+38]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X20_v14+38]");
		bool flag3 = (nint)0 == 0;
		object obj13 = !flag3;
		AndroidJavaObject androidJavaObject2 = (AndroidJavaObject)obj10;
		object obj14 = obj11;
		if (obj13 != null)
		{
			goto IL_00fe;
		}
		goto IL_0350;
		IL_023a:
		object methodName = "getCreator" + 2176;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X0_v30+B8]");
		object args = 0;
		return androidJavaObject.CallStatic<int>((string)methodName, (object[])args);
		IL_04f8:
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
		IL_021d:
		if (androidJavaObject != null)
		{
			goto IL_023a;
		}
		goto IL_04f8;
		IL_0099:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v39+B8]");
		object obj15 = 0;
		androidJavaObject = (AndroidJavaObject)obj15;
		obj11 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X20_v14+38]");
		obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X20_v14+38]");
		bool flag4 = (nint)0 == 0;
		androidJavaObject2 = (AndroidJavaObject)obj15;
		obj14 = obj11;
		if (!flag4)
		{
			goto IL_00fe;
		}
		goto IL_0350;
		IL_0350:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X20_v4+38]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v11+10]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v11+10]");
		object obj18 = (nint)0 + (nint)309;
		object obj19 = obj18 & 1;
		bool flag5 = obj19 == null;
		object obj20 = !flag5;
		androidJavaObject = androidJavaObject2;
		obj11 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v11+10]");
		object obj21 = 0;
		if (obj20 != null)
		{
			goto IL_016f;
		}
		goto IL_03e6;
		IL_00fe:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v29+10]");
		obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v29+10]");
		object obj22 = (nint)0 + (nint)309;
		object obj23 = obj22 & 1;
		bool flag6 = obj23 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v29+10]");
		obj21 = 0;
		androidJavaObject2 = androidJavaObject;
		obj14 = obj11;
		if (!flag6)
		{
			goto IL_016f;
		}
		goto IL_03e6;
		IL_03e6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v5+E4]");
		bool flag7 = (nint)0 == 0;
		object obj24 = !flag7;
		androidJavaObject = androidJavaObject2;
		obj11 = obj14;
		if (obj24 != null)
		{
			goto IL_01a4;
		}
		goto IL_0430;
		IL_016f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v5+E4]");
		bool flag8 = (nint)0 == 0;
		androidJavaObject2 = androidJavaObject;
		obj14 = obj11;
		if (!flag8)
		{
			goto IL_01a4;
		}
		goto IL_0430;
		IL_0430:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X20_v4+38]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v5+10]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v5+10]");
		object obj27 = (nint)0 + (nint)309;
		object obj28 = obj27 & 1;
		bool flag9 = obj28 == null;
		object obj29 = !flag9;
		androidJavaObject = androidJavaObject2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v5+10]");
		object obj30 = 0;
		if (obj29 != null)
		{
			goto IL_021d;
		}
		goto IL_04be;
		IL_01a4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X20_v14+38]");
		object obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v24+10]");
		obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v24+10]");
		object obj32 = (nint)0 + (nint)309;
		object obj33 = obj32 & 1;
		bool flag10 = obj33 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v24+10]");
		obj30 = 0;
		androidJavaObject2 = androidJavaObject;
		if (!flag10)
		{
			goto IL_021d;
		}
		goto IL_04be;
		IL_04be:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		bool flag11 = androidJavaObject2 == null;
		object obj34 = !flag11;
		androidJavaObject = androidJavaObject2;
		if (obj34 != null)
		{
			goto IL_023a;
		}
		goto IL_04f8;
	}

	public unsafe static bool IsPlayServicesAvailable()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0169: Expected O, but got I4
		//IL_0095: Expected O, but got I
		//IL_00ab: Expected O, but got I
		//IL_01f3: Expected O, but got I
		//IL_01a1: Expected O, but got I
		//IL_01b7: Expected O, but got I
		//IL_01d1: Expected O, but got I4
		//IL_04b9: Expected O, but got I
		//IL_04d9: Expected O, but got I
		//IL_04fb: Expected O, but got I4
		//IL_00dc: Expected O, but got I
		//IL_027d: Expected O, but got I
		//IL_0293: Expected O, but got I
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Expected O, but got Unknown
		//IL_02c8: Expected O, but got I
		//IL_0238: Expected O, but got I
		//IL_05db: Expected O, but got I4
		//IL_0533: Expected O, but got I
		//IL_0543: Expected O, but got I
		//IL_0559: Expected O, but got I
		//IL_0562: Unknown result type (might be due to invalid IL or missing references)
		//IL_0567: Expected O, but got Unknown
		//IL_0581: Expected O, but got I4
		//IL_05a1: Expected O, but got I
		//IL_0127: Expected O, but got I
		//IL_0323: Expected O, but got I
		//IL_0333: Expected O, but got I
		//IL_0349: Expected O, but got I
		//IL_0352: Unknown result type (might be due to invalid IL or missing references)
		//IL_0357: Expected O, but got Unknown
		//IL_0376: Expected O, but got I
		//IL_06ab: Expected O, but got I4
		//IL_0613: Expected O, but got I
		//IL_0623: Expected O, but got I
		//IL_0639: Expected O, but got I
		//IL_0642: Unknown result type (might be due to invalid IL or missing references)
		//IL_0647: Expected O, but got Unknown
		//IL_0661: Expected O, but got I4
		//IL_0679: Expected O, but got I
		//IL_03b9: Expected O, but got I
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Expected O, but got Unknown
		//IL_03d4: Expected O, but got I
		//IL_03f5: Expected O, but got I
		//IL_041f: Expected O, but got I
		//IL_0438: Expected O, but got I
		//IL_045a: Expected O, but got I4
		//IL_06cf: Expected I4, but got O
		object obj = 152985600;
		object obj2 = typeof(SqlSingle[]) + 3560;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6F93]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		if (obj3 != null)
		{
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v55+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj4;
			if (!flag)
			{
				goto IL_0085;
			}
		}
		else
		{
			_ = 1;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v55+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			if (obj6 != null)
			{
				goto IL_0085;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v55+B8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v3+8]");
		object obj8 = (nint)0 & (nint)1;
		bool flag3 = obj8 == null;
		object obj9 = !flag3;
		object obj10 = obj4;
		if (obj9 != null)
		{
			goto IL_00d0;
		}
		goto IL_01e7;
		IL_03a9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X0_v19+B8]");
		object args = 0;
		object methodName = "https://www.kammelna.com/Home/Terms" + 3056;
		object obj11 = (nint)0 + (nint)840;
		AndroidJavaObject androidJavaObject;
		bool value = androidJavaObject.Call<bool>((string)methodName, (object[])args);
		object obj12 = (nint)0 + (nint)2008;
		bool? flag4 = value;
		object obj13 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X8_v27+B8]");
		object obj14 = 0;
		obj4 = obj2;
		object obj15 = (nint)0 + (nint)2032;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v55+E4]");
		bool flag5 = (nint)0 == 0;
		object obj16 = !flag5;
		object obj17 = obj4;
		object obj18 = obj15;
		if (obj16 != null)
		{
			goto IL_0111;
		}
		goto IL_0478;
		IL_06c1:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_038c:
		if (androidJavaObject != null)
		{
			goto IL_03a9;
		}
		goto IL_06c1;
		IL_0085:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v55+B8]");
		obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v3+8]");
		object obj19 = (nint)0 & (nint)1;
		bool flag6 = obj19 == null;
		obj10 = obj4;
		if (!flag6)
		{
			goto IL_00d0;
		}
		goto IL_01e7;
		IL_01e7:
		object obj20 = (nint)0 + (nint)3232;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v4+E4]");
		AndroidJavaObject androidJavaObject2;
		object obj21;
		object obj23;
		if ((nint)0 != 0)
		{
			androidJavaObject = (AndroidJavaObject)obj7;
			obj21 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X20_v12+38]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X20_v12+38]");
			bool flag7 = (nint)0 == 0;
			obj23 = obj21;
			androidJavaObject2 = (AndroidJavaObject)obj7;
			if (!flag7)
			{
				goto IL_026d;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj24 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v16+B8]");
			object obj25 = 0;
			androidJavaObject = (AndroidJavaObject)obj25;
			obj21 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X20_v12+38]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X20_v12+38]");
			bool flag8 = (nint)0 == 0;
			object obj26 = !flag8;
			obj23 = obj21;
			androidJavaObject2 = (AndroidJavaObject)obj25;
			if (obj26 != null)
			{
				goto IL_026d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X20_v6+38]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X8_v13+10]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X8_v13+10]");
		object obj29 = (nint)0 + (nint)309;
		object obj30 = obj29 & 1;
		bool flag9 = obj30 == null;
		object obj31 = !flag9;
		obj21 = obj23;
		androidJavaObject = androidJavaObject2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X8_v13+10]");
		object obj32 = 0;
		if (obj31 != null)
		{
			goto IL_02de;
		}
		goto IL_05af;
		IL_0111:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v55+B8]");
		bool? flag10 = (bool?)(object)((nint)0 + (nint)8);
		return ((bool?*)flag10)->Value;
		IL_0478:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		obj15 = obj18;
		goto IL_0111;
		IL_00d0:
		obj15 = (nint)0 + (nint)2032;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v55+E4]");
		bool flag11 = (nint)0 == 0;
		obj17 = obj4;
		obj18 = obj15;
		if (!flag11)
		{
			goto IL_0111;
		}
		goto IL_0478;
		IL_026d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v37+10]");
		obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v37+10]");
		object obj33 = (nint)0 + (nint)309;
		object obj34 = obj33 & 1;
		bool flag12 = obj34 == null;
		obj23 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v37+10]");
		obj32 = 0;
		androidJavaObject2 = androidJavaObject;
		if (!flag12)
		{
			goto IL_02de;
		}
		goto IL_05af;
		IL_05af:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v9+E4]");
		bool flag13 = (nint)0 == 0;
		object obj35 = !flag13;
		obj21 = obj23;
		androidJavaObject = androidJavaObject2;
		if (obj35 != null)
		{
			goto IL_0313;
		}
		goto IL_05f9;
		IL_02de:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v9+E4]");
		bool flag14 = (nint)0 == 0;
		obj23 = obj21;
		androidJavaObject2 = androidJavaObject;
		if (!flag14)
		{
			goto IL_0313;
		}
		goto IL_05f9;
		IL_05f9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X20_v6+38]");
		object obj36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v7+10]");
		object obj37 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v7+10]");
		object obj38 = (nint)0 + (nint)309;
		object obj39 = obj38 & 1;
		bool flag15 = obj39 == null;
		object obj40 = !flag15;
		androidJavaObject = androidJavaObject2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v7+10]");
		object obj41 = 0;
		if (obj40 != null)
		{
			goto IL_038c;
		}
		goto IL_0687;
		IL_0313:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X20_v12+38]");
		object obj42 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v32+10]");
		obj37 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v32+10]");
		object obj43 = (nint)0 + (nint)309;
		object obj44 = obj43 & 1;
		bool flag16 = obj44 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v32+10]");
		obj41 = 0;
		androidJavaObject2 = androidJavaObject;
		if (!flag16)
		{
			goto IL_038c;
		}
		goto IL_0687;
		IL_0687:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		bool flag17 = androidJavaObject2 == null;
		object obj45 = !flag17;
		androidJavaObject = androidJavaObject2;
		if (obj45 != null)
		{
			goto IL_03a9;
		}
		goto IL_06c1;
	}

	public static void PickPhotoFromGallery()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0260: Expected O, but got I
		//IL_028a: Expected O, but got I4
		//IL_00a9: Expected O, but got I
		//IL_00c9: Expected O, but got I
		//IL_005c: Expected O, but got I
		//IL_0344: Expected O, but got I
		//IL_0354: Expected O, but got I
		//IL_036a: Expected O, but got I
		//IL_0373: Unknown result type (might be due to invalid IL or missing references)
		//IL_0378: Expected O, but got Unknown
		//IL_0392: Expected O, but got I4
		//IL_03b2: Expected O, but got I
		//IL_02ca: Expected O, but got I
		//IL_02ea: Expected O, but got I
		//IL_030c: Expected O, but got I4
		//IL_010e: Expected O, but got I
		//IL_0124: Expected O, but got I
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected O, but got Unknown
		//IL_0151: Expected O, but got I
		//IL_0424: Expected O, but got I
		//IL_0434: Expected O, but got I
		//IL_044a: Expected O, but got I
		//IL_0453: Unknown result type (might be due to invalid IL or missing references)
		//IL_0458: Expected O, but got Unknown
		//IL_0472: Expected O, but got I4
		//IL_048a: Expected O, but got I
		//IL_03ec: Expected O, but got I4
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Expected O, but got Unknown
		//IL_023c: Expected O, but got I
		//IL_01b4: Expected O, but got I
		//IL_01c4: Expected O, but got I
		//IL_01da: Expected O, but got I
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected O, but got Unknown
		//IL_0207: Expected O, but got I
		//IL_04bc: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(SqlSingle[]) + 3560;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6F94]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object obj7;
		if (obj3 != null)
		{
			obj4 = (nint)0 + (nint)3232;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v35+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj5;
			obj7 = obj4;
			if (!flag)
			{
				goto IL_0099;
			}
		}
		else
		{
			_ = 1;
			obj4 = (nint)0 + (nint)3232;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v35+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			object obj6 = obj5;
			obj7 = obj4;
			if (obj8 != null)
			{
				goto IL_0099;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v16+B8]");
		object obj10 = 0;
		AndroidJavaObject androidJavaObject = (AndroidJavaObject)obj10;
		object obj11 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X20_v14+38]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X20_v14+38]");
		bool flag3 = (nint)0 == 0;
		object obj13 = !flag3;
		AndroidJavaObject androidJavaObject2 = (AndroidJavaObject)obj10;
		object obj14 = obj11;
		if (obj13 != null)
		{
			goto IL_00fe;
		}
		goto IL_032a;
		IL_021d:
		object methodName = "java.io.FileOutputStream" + 1288;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X0_v27+B8]");
		object args = 0;
		androidJavaObject.Call((string)methodName, (object[])args);
		return;
		IL_0498:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		bool flag4 = androidJavaObject2 == null;
		object obj15 = !flag4;
		androidJavaObject = androidJavaObject2;
		if (obj15 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_021d;
		IL_01a4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X20_v14+38]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v24+10]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v24+10]");
		object obj18 = (nint)0 + (nint)309;
		object obj19 = obj18 & 1;
		bool flag5 = obj19 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v24+10]");
		object obj20 = 0;
		androidJavaObject2 = androidJavaObject;
		if (!flag5)
		{
			goto IL_021d;
		}
		goto IL_0498;
		IL_0099:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v35+B8]");
		object obj21 = 0;
		androidJavaObject = (AndroidJavaObject)obj21;
		obj11 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X20_v14+38]");
		obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X20_v14+38]");
		bool flag6 = (nint)0 == 0;
		androidJavaObject2 = (AndroidJavaObject)obj21;
		obj14 = obj11;
		if (!flag6)
		{
			goto IL_00fe;
		}
		goto IL_032a;
		IL_032a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X20_v4+38]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v11+10]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v11+10]");
		object obj24 = (nint)0 + (nint)309;
		object obj25 = obj24 & 1;
		bool flag7 = obj25 == null;
		object obj26 = !flag7;
		androidJavaObject = androidJavaObject2;
		obj11 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v11+10]");
		object obj27 = 0;
		if (obj26 != null)
		{
			goto IL_016f;
		}
		goto IL_03c0;
		IL_00fe:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v29+10]");
		obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v29+10]");
		object obj28 = (nint)0 + (nint)309;
		object obj29 = obj28 & 1;
		bool flag8 = obj29 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v29+10]");
		obj27 = 0;
		androidJavaObject2 = androidJavaObject;
		obj14 = obj11;
		if (!flag8)
		{
			goto IL_016f;
		}
		goto IL_03c0;
		IL_03c0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v5+E4]");
		bool flag9 = (nint)0 == 0;
		object obj30 = !flag9;
		androidJavaObject = androidJavaObject2;
		obj11 = obj14;
		if (obj30 != null)
		{
			goto IL_01a4;
		}
		goto IL_040a;
		IL_016f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v5+E4]");
		bool flag10 = (nint)0 == 0;
		androidJavaObject2 = androidJavaObject;
		obj14 = obj11;
		if (!flag10)
		{
			goto IL_01a4;
		}
		goto IL_040a;
		IL_040a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X20_v4+38]");
		object obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v5+10]");
		obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v5+10]");
		object obj32 = (nint)0 + (nint)309;
		object obj33 = obj32 & 1;
		bool flag11 = obj33 == null;
		object obj34 = !flag11;
		androidJavaObject = androidJavaObject2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v5+10]");
		obj20 = 0;
		if (obj34 != null)
		{
			goto IL_021d;
		}
		goto IL_0498;
	}

	public static void TakePhotoFromCamera()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0260: Expected O, but got I
		//IL_028a: Expected O, but got I4
		//IL_00a9: Expected O, but got I
		//IL_00c9: Expected O, but got I
		//IL_005c: Expected O, but got I
		//IL_0344: Expected O, but got I
		//IL_0354: Expected O, but got I
		//IL_036a: Expected O, but got I
		//IL_0373: Unknown result type (might be due to invalid IL or missing references)
		//IL_0378: Expected O, but got Unknown
		//IL_0392: Expected O, but got I4
		//IL_03b2: Expected O, but got I
		//IL_02ca: Expected O, but got I
		//IL_02ea: Expected O, but got I
		//IL_030c: Expected O, but got I4
		//IL_010e: Expected O, but got I
		//IL_0124: Expected O, but got I
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected O, but got Unknown
		//IL_0151: Expected O, but got I
		//IL_0424: Expected O, but got I
		//IL_0434: Expected O, but got I
		//IL_044a: Expected O, but got I
		//IL_0453: Unknown result type (might be due to invalid IL or missing references)
		//IL_0458: Expected O, but got Unknown
		//IL_0472: Expected O, but got I4
		//IL_048a: Expected O, but got I
		//IL_03ec: Expected O, but got I4
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Expected O, but got Unknown
		//IL_023c: Expected O, but got I
		//IL_01b4: Expected O, but got I
		//IL_01c4: Expected O, but got I
		//IL_01da: Expected O, but got I
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected O, but got Unknown
		//IL_0207: Expected O, but got I
		//IL_04bc: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(SqlSingle[]) + 3560;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6F95]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object obj7;
		if (obj3 != null)
		{
			obj4 = (nint)0 + (nint)3232;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v35+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj5;
			obj7 = obj4;
			if (!flag)
			{
				goto IL_0099;
			}
		}
		else
		{
			_ = 1;
			obj4 = (nint)0 + (nint)3232;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v35+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			object obj6 = obj5;
			obj7 = obj4;
			if (obj8 != null)
			{
				goto IL_0099;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v16+B8]");
		object obj10 = 0;
		AndroidJavaObject androidJavaObject = (AndroidJavaObject)obj10;
		object obj11 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X20_v14+38]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X20_v14+38]");
		bool flag3 = (nint)0 == 0;
		object obj13 = !flag3;
		AndroidJavaObject androidJavaObject2 = (AndroidJavaObject)obj10;
		object obj14 = obj11;
		if (obj13 != null)
		{
			goto IL_00fe;
		}
		goto IL_032a;
		IL_021d:
		object methodName = "java.io.FileOutputStream" + 1272;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X0_v27+B8]");
		object args = 0;
		androidJavaObject.Call((string)methodName, (object[])args);
		return;
		IL_0498:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		bool flag4 = androidJavaObject2 == null;
		object obj15 = !flag4;
		androidJavaObject = androidJavaObject2;
		if (obj15 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_021d;
		IL_01a4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X20_v14+38]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v24+10]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v24+10]");
		object obj18 = (nint)0 + (nint)309;
		object obj19 = obj18 & 1;
		bool flag5 = obj19 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v24+10]");
		object obj20 = 0;
		androidJavaObject2 = androidJavaObject;
		if (!flag5)
		{
			goto IL_021d;
		}
		goto IL_0498;
		IL_0099:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v35+B8]");
		object obj21 = 0;
		androidJavaObject = (AndroidJavaObject)obj21;
		obj11 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X20_v14+38]");
		obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X20_v14+38]");
		bool flag6 = (nint)0 == 0;
		androidJavaObject2 = (AndroidJavaObject)obj21;
		obj14 = obj11;
		if (!flag6)
		{
			goto IL_00fe;
		}
		goto IL_032a;
		IL_032a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X20_v4+38]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v11+10]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v11+10]");
		object obj24 = (nint)0 + (nint)309;
		object obj25 = obj24 & 1;
		bool flag7 = obj25 == null;
		object obj26 = !flag7;
		androidJavaObject = androidJavaObject2;
		obj11 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v11+10]");
		object obj27 = 0;
		if (obj26 != null)
		{
			goto IL_016f;
		}
		goto IL_03c0;
		IL_00fe:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v29+10]");
		obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v29+10]");
		object obj28 = (nint)0 + (nint)309;
		object obj29 = obj28 & 1;
		bool flag8 = obj29 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v29+10]");
		obj27 = 0;
		androidJavaObject2 = androidJavaObject;
		obj14 = obj11;
		if (!flag8)
		{
			goto IL_016f;
		}
		goto IL_03c0;
		IL_03c0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v5+E4]");
		bool flag9 = (nint)0 == 0;
		object obj30 = !flag9;
		androidJavaObject = androidJavaObject2;
		obj11 = obj14;
		if (obj30 != null)
		{
			goto IL_01a4;
		}
		goto IL_040a;
		IL_016f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v5+E4]");
		bool flag10 = (nint)0 == 0;
		androidJavaObject2 = androidJavaObject;
		obj14 = obj11;
		if (!flag10)
		{
			goto IL_01a4;
		}
		goto IL_040a;
		IL_040a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X20_v4+38]");
		object obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v5+10]");
		obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v5+10]");
		object obj32 = (nint)0 + (nint)309;
		object obj33 = obj32 & 1;
		bool flag11 = obj33 == null;
		object obj34 = !flag11;
		androidJavaObject = androidJavaObject2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v5+10]");
		obj20 = 0;
		if (obj34 != null)
		{
			goto IL_021d;
		}
		goto IL_0498;
	}

	public static void Share(string message)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected O, but got Unknown
		//IL_0146: Expected O, but got I4
		//IL_00b1: Expected O, but got I
		//IL_00dd: Expected O, but got I4
		//IL_00e6: Expected O, but got I4
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0186: Expected O, but got I
		//IL_00fd: Expected O, but got I4
		//IL_01b5: Expected O, but got I4
		//IL_01be: Expected O, but got I4
		//IL_01f1: Expected I, but got O
		//IL_0201: Expected O, but got I
		//IL_022a: Expected O, but got I
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected O, but got Unknown
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Expected O, but got Unknown
		object obj = 152985600;
		object obj2 = typeof(SqlSingle[]) + 3560;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6F96]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = typeof(TypeConverter<ushort, char>) + 3400;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v31+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj5;
			object obj7 = obj4;
			if (!flag)
			{
				goto IL_00a1;
			}
		}
		else
		{
			_ = 1;
			object obj4 = typeof(TypeConverter<ushort, char>) + 3400;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v31+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			object obj6 = obj5;
			object obj7 = obj4;
			if (obj8 != null)
			{
				goto IL_00a1;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v18+B8]");
		object obj10 = 0;
		AndroidJavaObject androidJavaObject = (AndroidJavaObject)obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object[] array = default(object[]);
		bool flag3 = array == null;
		string text = (string)1;
		string text2 = (string)1;
		if (!flag3)
		{
			goto IL_01cc;
		}
		goto IL_02c5;
		IL_02d3:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_02e1;
		IL_02e1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_02c5:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_02d3;
		IL_00a1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v31+B8]");
		object obj11 = 0;
		androidJavaObject = (AndroidJavaObject)obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		bool flag4 = array == null;
		object obj12 = !flag4;
		text = (string)1;
		if (obj12 != null)
		{
			goto IL_01cc;
		}
		text2 = (string)1;
		goto IL_02c5;
		IL_01cc:
		if (message != null)
		{
			nint num = (nint)array;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v10 (Il2CppClass<System.Object[]>)+40]");
			text = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			bool flag5 = ex == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v10 (Il2CppClass<System.Object[]>)+40]");
			text2 = (string)0;
			if (flag5)
			{
				goto IL_02e1;
			}
		}
		bool flag6 = array.Length == 0;
		text2 = text;
		if (!flag6)
		{
			object obj13 = array + 32;
			obj13 = message;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			bool flag7 = androidJavaObject == null;
			text2 = message;
			if (!flag7)
			{
				object methodName = "setMimeType" + 1992;
				androidJavaObject.Call((string)methodName, array);
				return;
			}
			goto IL_02c5;
		}
		goto IL_02d3;
	}

	public static void ShareImage(string message, string filepath)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected O, but got Unknown
		//IL_0146: Expected O, but got I4
		//IL_00b1: Expected O, but got I
		//IL_00dd: Expected O, but got I4
		//IL_00e6: Expected O, but got I4
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0186: Expected O, but got I
		//IL_00fd: Expected O, but got I4
		//IL_01b5: Expected O, but got I4
		//IL_01be: Expected O, but got I4
		//IL_01f1: Expected I, but got O
		//IL_0201: Expected O, but got I
		//IL_022a: Expected O, but got I
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected O, but got Unknown
		//IL_0307: Expected O, but got I8
		//IL_02ac: Expected I, but got O
		//IL_02bc: Expected O, but got I
		//IL_02e5: Expected O, but got I
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Expected O, but got Unknown
		//IL_037b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Expected O, but got Unknown
		object obj = 152985600;
		object obj2 = typeof(SqlSingle[]) + 3560;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6F97]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = typeof(TypeConverter<ushort, char>) + 3400;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v37+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj5;
			object obj7 = obj4;
			if (!flag)
			{
				goto IL_00a1;
			}
		}
		else
		{
			_ = 1;
			object obj4 = typeof(TypeConverter<ushort, char>) + 3400;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v37+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			object obj6 = obj5;
			object obj7 = obj4;
			if (obj8 != null)
			{
				goto IL_00a1;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v24+B8]");
		object obj10 = 0;
		AndroidJavaObject androidJavaObject = (AndroidJavaObject)obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object[] array = default(object[]);
		bool flag3 = array == null;
		string text = (string)2;
		string text2 = (string)2;
		if (!flag3)
		{
			goto IL_01cc;
		}
		goto IL_0392;
		IL_03ae:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_0392:
		NullReferenceException ex = new NullReferenceException();
		goto IL_03a0;
		IL_03a0:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		goto IL_03ae;
		IL_00a1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v37+B8]");
		object obj11 = 0;
		androidJavaObject = (AndroidJavaObject)obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		bool flag4 = array == null;
		object obj12 = !flag4;
		text = (string)2;
		if (obj12 != null)
		{
			goto IL_01cc;
		}
		text2 = (string)2;
		goto IL_0392;
		IL_01cc:
		if (message != null)
		{
			nint num = (nint)array;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X8_v13 (Il2CppClass<System.Object[]>)+40]");
			text = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			bool flag5 = ex2 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X8_v13 (Il2CppClass<System.Object[]>)+40]");
			text2 = (string)0;
			if (flag5)
			{
				goto IL_03ae;
			}
		}
		bool flag6 = array.Length == 0;
		text2 = text;
		if (!flag6)
		{
			object obj13 = array + 32;
			obj13 = message;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			bool flag7 = filepath == null;
			string text3 = message;
			if (!flag7)
			{
				nint num2 = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v12 (Il2CppClass<System.Object[]>)+40]");
				text3 = (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag8 = ex2 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v12 (Il2CppClass<System.Object[]>)+40]");
				text2 = (string)0;
				if (flag8)
				{
					goto IL_03ae;
				}
			}
			object obj14 = array.Length & 0xFFFFFFFEL;
			bool flag9 = obj14 == null;
			text2 = text3;
			if (!flag9)
			{
				object obj15 = array + 40;
				obj15 = filepath;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				bool flag10 = androidJavaObject == null;
				text2 = filepath;
				if (!flag10)
				{
					object methodName = "setMimeType" + 2000;
					androidJavaObject.Call((string)methodName, array);
					return;
				}
				goto IL_0392;
			}
		}
		goto IL_03a0;
	}

	public static void LaunchUrl(string url)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected O, but got Unknown
		//IL_0146: Expected O, but got I4
		//IL_00b1: Expected O, but got I
		//IL_00dd: Expected O, but got I4
		//IL_00e6: Expected O, but got I4
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0186: Expected O, but got I
		//IL_00fd: Expected O, but got I4
		//IL_01b5: Expected O, but got I4
		//IL_01be: Expected O, but got I4
		//IL_01f1: Expected I, but got O
		//IL_0201: Expected O, but got I
		//IL_022a: Expected O, but got I
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected O, but got Unknown
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Expected O, but got Unknown
		object obj = 152985600;
		object obj2 = typeof(SqlSingle[]) + 3560;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6F98]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = typeof(TypeConverter<ushort, char>) + 3400;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v31+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj5;
			object obj7 = obj4;
			if (!flag)
			{
				goto IL_00a1;
			}
		}
		else
		{
			_ = 1;
			object obj4 = typeof(TypeConverter<ushort, char>) + 3400;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v31+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			object obj6 = obj5;
			object obj7 = obj4;
			if (obj8 != null)
			{
				goto IL_00a1;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v18+B8]");
		object obj10 = 0;
		AndroidJavaObject androidJavaObject = (AndroidJavaObject)obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object[] array = default(object[]);
		bool flag3 = array == null;
		string text = (string)1;
		string text2 = (string)1;
		if (!flag3)
		{
			goto IL_01cc;
		}
		goto IL_02c5;
		IL_02d3:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_02e1;
		IL_02e1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_02c5:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_02d3;
		IL_00a1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v31+B8]");
		object obj11 = 0;
		androidJavaObject = (AndroidJavaObject)obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		bool flag4 = array == null;
		object obj12 = !flag4;
		text = (string)1;
		if (obj12 != null)
		{
			goto IL_01cc;
		}
		text2 = (string)1;
		goto IL_02c5;
		IL_01cc:
		if (url != null)
		{
			nint num = (nint)array;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v10 (Il2CppClass<System.Object[]>)+40]");
			text = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			bool flag5 = ex == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v10 (Il2CppClass<System.Object[]>)+40]");
			text2 = (string)0;
			if (flag5)
			{
				goto IL_02e1;
			}
		}
		bool flag6 = array.Length == 0;
		text2 = text;
		if (!flag6)
		{
			object obj13 = array + 32;
			obj13 = url;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			bool flag7 = androidJavaObject == null;
			text2 = url;
			if (!flag7)
			{
				object methodName = "java.io.FileOutputStream" + 1296;
				androidJavaObject.Call((string)methodName, array);
				return;
			}
			goto IL_02c5;
		}
		goto IL_02d3;
	}

	public static void LaunchUrlWithCallback(string url, string callbackUrl)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00b7: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(SqlSingle[]) + 3560;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6F99]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v1+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		LaunchUrl(url);
		return;
		IL_007d:
		LaunchUrl(url);
	}

	private void CameraTakeDone(string path)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_012b: Expected O, but got I4
		//IL_008c: Expected O, but got I
		//IL_009c: Expected O, but got I
		//IL_0163: Expected O, but got I
		//IL_0173: Expected O, but got I
		//IL_0195: Expected O, but got I4
		//IL_00d1: Expected O, but got I
		//IL_00e1: Expected O, but got I
		//IL_00f1: Expected O, but got I
		object obj = typeof(SqlSingle[]) + 3560;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6F9A]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 == null)
		{
			goto IL_00fb;
		}
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v11+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = obj3;
		if (!flag)
		{
			goto IL_007c;
		}
		goto IL_0141;
		IL_0141:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v4+B8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v4+18]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v4+18]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			return;
		}
		goto IL_00c1;
		IL_007c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v11+B8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v10+18]");
		obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v10+18]");
		if ((nint)0 != 0)
		{
			goto IL_00c1;
		}
		return;
		IL_00c1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v8+18]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v8+40]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v8+28]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v63 @ X3_v1 (should have been resolved before IL gen)");
		goto IL_00fb;
		IL_00fb:
		_ = 1;
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v11+E4]");
		bool flag3 = (nint)0 == 0;
		object obj13 = !flag3;
		obj4 = obj3;
		if (obj13 != null)
		{
			goto IL_007c;
		}
		goto IL_0141;
	}

	private void GalleryPickDone(string path)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_012b: Expected O, but got I4
		//IL_008c: Expected O, but got I
		//IL_009c: Expected O, but got I
		//IL_0163: Expected O, but got I
		//IL_0173: Expected O, but got I
		//IL_0195: Expected O, but got I4
		//IL_00d1: Expected O, but got I
		//IL_00e1: Expected O, but got I
		//IL_00f1: Expected O, but got I
		object obj = typeof(SqlSingle[]) + 3560;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6F9B]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 == null)
		{
			goto IL_00fb;
		}
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v11+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = obj3;
		if (!flag)
		{
			goto IL_007c;
		}
		goto IL_0141;
		IL_0141:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v4+B8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v4+10]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v4+10]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			return;
		}
		goto IL_00c1;
		IL_007c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v11+B8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v10+10]");
		obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v10+10]");
		if ((nint)0 != 0)
		{
			goto IL_00c1;
		}
		return;
		IL_00c1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v8+18]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v8+40]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v8+28]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v63 @ X3_v1 (should have been resolved before IL gen)");
		goto IL_00fb;
		IL_00fb:
		_ = 1;
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v11+E4]");
		bool flag3 = (nint)0 == 0;
		object obj13 = !flag3;
		obj4 = obj3;
		if (obj13 != null)
		{
			goto IL_007c;
		}
		goto IL_0141;
	}

	private void CameraCancel(string param)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0134: Expected O, but got I4
		//IL_0095: Expected O, but got I
		//IL_00a5: Expected O, but got I
		//IL_016c: Expected O, but got I
		//IL_017c: Expected O, but got I
		//IL_019e: Expected O, but got I4
		//IL_00da: Expected O, but got I
		//IL_00ea: Expected O, but got I
		//IL_00fa: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(SqlSingle[]) + 3560;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6F9C]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 == null)
		{
			goto IL_0104;
		}
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v11+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = obj4;
		if (!flag)
		{
			goto IL_0085;
		}
		goto IL_014a;
		IL_014a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v4+B8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v4+28]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v4+28]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			return;
		}
		goto IL_00ca;
		IL_0085:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v11+B8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v10+28]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v10+28]");
		if ((nint)0 != 0)
		{
			goto IL_00ca;
		}
		return;
		IL_00ca:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v8+18]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v8+40]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v8+28]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v58 @ X2_v1 (should have been resolved before IL gen)");
		goto IL_0104;
		IL_0104:
		_ = 1;
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v11+E4]");
		bool flag3 = (nint)0 == 0;
		object obj14 = !flag3;
		obj5 = obj4;
		if (obj14 != null)
		{
			goto IL_0085;
		}
		goto IL_014a;
	}

	private void GalleryCancel(string param)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0134: Expected O, but got I4
		//IL_0095: Expected O, but got I
		//IL_00a5: Expected O, but got I
		//IL_016c: Expected O, but got I
		//IL_017c: Expected O, but got I
		//IL_019e: Expected O, but got I4
		//IL_00da: Expected O, but got I
		//IL_00ea: Expected O, but got I
		//IL_00fa: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(SqlSingle[]) + 3560;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6F9D]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 == null)
		{
			goto IL_0104;
		}
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v11+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = obj4;
		if (!flag)
		{
			goto IL_0085;
		}
		goto IL_014a;
		IL_014a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v4+B8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v4+20]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v4+20]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			return;
		}
		goto IL_00ca;
		IL_0085:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v11+B8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v10+20]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v10+20]");
		if ((nint)0 != 0)
		{
			goto IL_00ca;
		}
		return;
		IL_00ca:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v8+18]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v8+40]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v8+28]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v58 @ X2_v1 (should have been resolved before IL gen)");
		goto IL_0104;
		IL_0104:
		_ = 1;
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v11+E4]");
		bool flag3 = (nint)0 == 0;
		object obj14 = !flag3;
		obj5 = obj4;
		if (obj14 != null)
		{
			goto IL_0085;
		}
		goto IL_014a;
	}

	private void CameraPermissionDenied(string param)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0134: Expected O, but got I4
		//IL_0095: Expected O, but got I
		//IL_00a5: Expected O, but got I
		//IL_016c: Expected O, but got I
		//IL_017c: Expected O, but got I
		//IL_019e: Expected O, but got I4
		//IL_00da: Expected O, but got I
		//IL_00ea: Expected O, but got I
		//IL_00fa: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(SqlSingle[]) + 3560;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6F9E]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 == null)
		{
			goto IL_0104;
		}
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v11+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = obj4;
		if (!flag)
		{
			goto IL_0085;
		}
		goto IL_014a;
		IL_014a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v4+B8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v4+30]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v4+30]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			return;
		}
		goto IL_00ca;
		IL_0085:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v11+B8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v10+30]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v10+30]");
		if ((nint)0 != 0)
		{
			goto IL_00ca;
		}
		return;
		IL_00ca:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v8+18]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v8+40]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v8+28]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v58 @ X2_v1 (should have been resolved before IL gen)");
		goto IL_0104;
		IL_0104:
		_ = 1;
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v11+E4]");
		bool flag3 = (nint)0 == 0;
		object obj14 = !flag3;
		obj5 = obj4;
		if (obj14 != null)
		{
			goto IL_0085;
		}
		goto IL_014a;
	}
}
