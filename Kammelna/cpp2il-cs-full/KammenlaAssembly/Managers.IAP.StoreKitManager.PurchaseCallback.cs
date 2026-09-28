using System;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using Spine;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.iOS;

namespace Managers.IAP;

public class StoreKitManager
{
	public delegate void PurchaseCallback(IntPtr productIdPtr, IntPtr receiptPtr);

	public delegate void BoolCallback(int value);

	public delegate void VoidCallback();

	private readonly int systemVersion;

	public static event Action OnProductsLoaded
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b9: Expected O, but got Unknown
			//IL_00d1: Expected O, but got I
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2080;
			object obj2 = typeof(SqlSingle[]) + 2376;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3+B8]");
			object obj4 = 0;
			Delegate obj5 = (Delegate)obj4;
			bool flag;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 == null || obj6 == obj2)
				{
					object obj7 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj8 == obj5;
					obj5 = obj8;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b9: Expected O, but got Unknown
			//IL_00d1: Expected O, but got I
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2080;
			object obj2 = typeof(SqlSingle[]) + 2376;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3+B8]");
			object obj4 = 0;
			Delegate obj5 = (Delegate)obj4;
			bool flag;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 == null || obj6 == obj2)
				{
					object obj7 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj8 == obj5;
					obj5 = obj8;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
	}

	public static event Action<bool> OnEligibilityChecked
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2080;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+8]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2080;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+8]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
	}

	[PreserveSig]
	private static extern void StoreKitPlugin_SetPurchaseCallback(PurchaseCallback callback);

	[PreserveSig]
	private static extern void StoreKitPlugin_FetchProducts(string[] productsIds, VoidCallback callback);

	[PreserveSig]
	private static extern IntPtr StoreKitPlugin_IsEligibleForIntroOffer(BoolCallback callback);

	[PreserveSig]
	private static extern IntPtr StoreKitPlugin_FetchReceipt();

	[PreserveSig]
	private static extern void StoreKitPlugin_Buy(string productId, string userId, string jsonDiscountInfo);

	[PreserveSig]
	private static extern void StoreKitPlugin_FreeCString(IntPtr cString);

	public StoreKitManager(IStoreKitListener listener)
	{
		//IL_00b4: Expected O, but got I4
		//IL_0112: Expected O, but got I4
		string text = Device.systemVersion;
		if (text != null)
		{
			string[] array = text.Split('.');
			if (array != null)
			{
				int result;
				bool flag = int.TryParse(array[0], out result);
				if (this != null)
				{
					bool flag2 = !flag;
					object obj = !flag2;
					object obj2 = ~obj;
					systemVersion = ((obj2 == null) ? result : 0);
					((StoreKitManager)flag).SetListenerEvents(listener);
					return;
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
	}

	private void SetListenerEvents(IStoreKitListener listener)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0035: Expected I, but got O
		//IL_0045: Expected O, but got I
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Expected O, but got Unknown
		//IL_0080: Expected O, but got I
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected O, but got Unknown
		//IL_0304: Expected O, but got I
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected O, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_01aa: Expected I, but got O
		//IL_01ba: Expected O, but got I
		//IL_01f5: Expected O, but got I
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected O, but got Unknown
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Expected O, but got Unknown
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Expected O, but got Unknown
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected O, but got Unknown
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected O, but got Unknown
		object obj = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = typeof(System.IOAsyncCallback) + 1376;
		nint num = (nint)listener;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v3 (Il2CppClass<Managers.IAP.IStoreKitListener>)+12E]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v3 (Il2CppClass<Managers.IAP.IStoreKitListener>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00c1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v3 (Il2CppClass<Managers.IAP.IStoreKitListener>)+B0]");
		object obj4 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X10_v11-8]");
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
			goto IL_00c1;
		}
		object obj5 = num + obj4;
		object obj6 = obj5 + 312;
		goto IL_02a6;
		IL_00c1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_02a6;
		IL_02a6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v5+8]");
		Action action = default(Action);
		action..ctor(listener, (IntPtr)0);
		object obj7 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2080;
		object obj8 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		object obj9 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X8_v7+B8]");
		object obj10 = 0;
		Delegate obj11 = (Delegate)obj10;
		bool flag;
		Delegate obj16 = default(Delegate);
		do
		{
			Delegate obj12 = Delegate.Combine(obj11, action);
			Delegate obj14;
			Delegate obj13;
			if ((object)obj12 != null)
			{
				obj13 = (Delegate)obj;
				if (obj12 != obj)
				{
					obj14 = null;
					throw new InvalidCastException();
				}
			}
			object obj15 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
			flag = (object)obj16 == obj11;
			obj11 = obj16;
			obj14 = obj16;
			obj13 = obj12;
		}
		while (!flag);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num2 = (nint)listener;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X8_v11 (Il2CppClass<Managers.IAP.IStoreKitListener>)+12E]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X8_v11 (Il2CppClass<Managers.IAP.IStoreKitListener>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0236;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X8_v11 (Il2CppClass<Managers.IAP.IStoreKitListener>)+B0]");
		object obj18 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X10_v6-8]");
			if (0 == (nint)obj2)
			{
				break;
			}
			obj18 += 16;
			obj17--;
			if ((nint)obj17 != 1)
			{
				continue;
			}
			goto IL_0236;
		}
		object obj19 = obj18 + 1;
		object obj20 = num2 + obj19;
		object obj21 = obj20 + 312;
		goto IL_0335;
		IL_0335:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X0_v14+8]");
		Action<bool> action2 = default(Action<bool>);
		action2..ctor((object)listener, (IntPtr)0);
		OnEligibilityChecked += action2;
		return;
		IL_0236:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0335;
	}

	private static void SetPurchaseCallback()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_0100: Expected O, but got I4
		//IL_00af: Expected O, but got I4
		//IL_008e: Expected O, but got I
		//IL_0132: Expected O, but got I4
		//IL_0079: Expected O, but got I4
		object obj = typeof(SkeletonBinary.SkeletonInput) + 1480;
		object obj2 = (nint)0 + (nint)32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X20_v3+8]");
		_ = 0;
		object obj5 = default(object);
		object obj4 = obj5 + 32;
		obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18CC");
		object obj6 = default(object);
		if (obj6 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X20_v3+52]");
			if ((nint)0 == 2)
			{
				object obj7 = 35901440 + 1992;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3+10]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3+20]");
				_ = 0;
			}
			object obj8 = 35901440 + 1900;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1FB4");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0244");
			return;
		}
		object obj9 = 134782976 + 1449;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1AB4");
		throw new OutOfMemoryException();
	}

	public void FetchProducts(string[] productsIds)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_00d6: Expected I, but got O
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected O, but got Unknown
		//IL_010f: Expected O, but got I4
		//IL_0126: Expected I, but got O
		//IL_00ae: Expected O, but got I4
		//IL_0086: Expected I, but got O
		object obj = typeof(SkeletonBinary.SkeletonInput) + 1488;
		object obj2 = (nint)0 + (nint)16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint method = (nint)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X21_v3 (System.IntPtr)+8]");
		VoidCallback voidCallback = default(VoidCallback);
		((Delegate)voidCallback).method_ptr = (IntPtr)0;
		((Delegate)voidCallback).method = method;
		object obj3 = voidCallback + 32;
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		((Delegate)voidCallback).method_code = (IntPtr)voidCallback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18CC");
		object obj4 = default(object);
		if (obj4 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X21_v3 (System.IntPtr)+52]");
			nint invoke_impl;
			if ((nint)0 != 0)
			{
				invoke_impl = ((Delegate)voidCallback).method_ptr;
				((Delegate)voidCallback).method_code = (IntPtr)((Delegate)voidCallback).m_target;
			}
			else
			{
				invoke_impl = 35903648;
			}
			((Delegate)voidCallback).invoke_impl = invoke_impl;
			nint extra_arg = 35903580;
			((Delegate)voidCallback).extra_arg = extra_arg;
			StoreKitPlugin_FetchProducts(productsIds, voidCallback);
			return;
		}
		object obj5 = 134782976 + 1449;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1AB4");
		throw new OutOfMemoryException();
	}

	public bool CanUseStoreKit2()
	{
		//IL_0010: Expected O, but got I4
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected I4, but got Unknown
		//IL_0082: Expected O, but got I4
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected I4, but got Unknown
		object obj = systemVersion - 14;
		bool flag = (nint)obj < 0;
		bool flag2 = obj == null;
		int num = systemVersion ^ 0xE;
		int num2 = systemVersion ^ obj;
		int num3 = num & num2;
		bool flag3 = num3 < 0;
		bool flag4 = flag == flag3;
		object obj2 = !flag2;
		return (byte)((flag4 & obj2) ? 1 : 0) != 0;
	}

	public void IsEligibleForIntroOffer()
	{
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected O, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_0060: Expected O, but got I4
		//IL_017b: Expected O, but got I4
		//IL_0141: Expected O, but got I
		//IL_01c7: Expected O, but got I4
		//IL_00d2: Expected O, but got I4
		if (systemVersion > 14)
		{
			object obj = typeof(SkeletonBinary.SkeletonInput) + 1472;
			object obj2 = (nint)0 + (nint)24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X20_v6+8]");
			_ = 0;
			object obj5 = default(object);
			object obj4 = obj5 + 32;
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18CC");
			object obj6 = default(object);
			if (obj6 == null)
			{
				object obj7 = 134782976 + 1449;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1AB4");
				throw new OutOfMemoryException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X20_v6+52]");
			if ((nint)0 == 1)
			{
				object obj8 = 35901440 + 2112;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v7+10]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v7+20]");
				_ = 0;
			}
			object obj9 = 35901440 + 2028;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1FB4");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0238");
		}
		else
		{
			object obj10 = typeof(DataRelation) + 856;
			object message = "Added Tournament Prizes And Features" + 3264;
			object obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v2+E4]");
			if ((nint)0 != 0)
			{
				Debug.LogWarning(message);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Debug.LogWarning(message);
		}
	}

	public string FetchReceipt()
	{
		//IL_00aa: Expected O, but got I
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0043: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0220");
		IntPtr intPtr = default(IntPtr);
		bool flag = intPtr == (IntPtr)0;
		string result = (string)(nint)intPtr;
		if (!flag)
		{
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3680;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v5+E4]");
			bool flag2 = (nint)0 == 0;
			object obj3 = !flag2;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string text = Marshal.PtrToStringAnsi(intPtr);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB022C");
			result = text;
		}
		return result;
	}

	public void BuyProduct(string productId, string userId, string jsonDiscountInfo)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1F9C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1F9C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1F9C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0208");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1FB0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1FB0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1FB0");
	}

	public static void FreeCString(IntPtr cString)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB022C");
	}

	private static void FetchingProductsFinished()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00f6: Expected O, but got I4
		//IL_0049: Expected O, but got I
		//IL_007e: Expected O, but got I
		//IL_008e: Expected O, but got I
		//IL_009e: Expected O, but got I
		object obj = typeof(DataRelation) + 856;
		object message = "Error reading data from socket: " + 3752;
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2080;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Debug.LogWarning(message);
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v4+B8]");
		object obj6 = 0;
		object obj7 = obj6;
		if (obj6 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v6+18]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v6+40]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v6+28]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v65 @ X2_v1 (should have been resolved before IL gen)");
		}
	}

	private static void OnPurchase(IntPtr productIdPtr, IntPtr receiptPtr)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_00ed: Expected O, but got I4
		//IL_0082: Expected O, but got I4
		//IL_010e: Expected O, but got I4
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3680;
		object obj2 = "placementId" + 3744;
		object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text = Marshal.PtrToStringAnsi(productIdPtr);
		string text2 = Marshal.PtrToStringAnsi(receiptPtr);
		string message = (string)obj2 + text;
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Toast.Show(message, (Vector2)0, 0f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB022C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB022C");
	}

	private static void OnEligibilityCheckDidFinish(int value)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_00cd: Expected O, but got I4
		//IL_0052: Expected O, but got I4
		//IL_011c: Expected O, but got I
		//IL_012c: Expected O, but got I
		//IL_0099: Expected O, but got I4
		object format = "October" + 376;
		object obj = typeof(DataRelation) + 856;
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2080;
		object obj3 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		object arg2 = default(object);
		string text = string.Format((string)format, arg, arg2);
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		object message = text;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			message = text;
		}
		Debug.LogWarning(message);
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v4+B8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v5+8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v5+8]");
		if ((nint)0 != 0)
		{
			bool flag2 = value == 0;
			object obj9 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v102 @ X8_v6+18] (should have been resolved before IL gen)");
		}
	}
}
