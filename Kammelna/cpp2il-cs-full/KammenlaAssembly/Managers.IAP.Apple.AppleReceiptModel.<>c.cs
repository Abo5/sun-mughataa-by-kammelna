using System;
using System.Collections.Generic;
using System.Dynamic.Utils;
using System.Linq;
using System.Linq.Expressions;
using Cpp2ILInjected;
using GoogleMobileAds.Api.AdManager;
using Unity.Services.Authentication.Shared;

namespace Managers.IAP.Apple;

public class AppleReceiptModel
{
	private static class AppleReceiptType
	{
		public const int AppId = 2;

		public const int BundleId = 3;

		public const int OpaqueValue = 4;

		public const int Hash = 5;

		public const int PurchasesReceipt = 17;

		public const int CreationTime = 12;

		public const int OriginalBundleId = 19;

		public const int ExpirationTime = 21;
	}

	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<byte[], ApplePurchaseReceipt> <>9__18_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1752;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal ApplePurchaseReceipt <get_PurchasesReceipt>b__18_0(byte[] bytes)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected O, but got Unknown
			object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 424;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			AppleReceiptReader appleReceiptReader = AppleReceiptReader.FromRawBytes(bytes);
			object obj3 = obj2 + 16;
			obj3 = appleReceiptReader;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return (ApplePurchaseReceipt)obj2;
		}
	}

	private readonly AppleReceiptReader _receipt;

	public string AppId
	{
		get
		{
			if (_receipt != null)
			{
				return _receipt.GetString(2);
			}
			return (string)(object)new NullReferenceException();
		}
	}

	public string BundleId
	{
		get
		{
			if (_receipt != null)
			{
				return _receipt.GetString(3);
			}
			return (string)(object)new NullReferenceException();
		}
	}

	public string OriginalBundleId
	{
		get
		{
			if (_receipt != null)
			{
				return _receipt.GetString(19);
			}
			return (string)(object)new NullReferenceException();
		}
	}

	public byte[] OpaqueValue
	{
		get
		{
			//IL_0035: Expected O, but got I
			AppleReceiptReader receipt = _receipt;
			if (_receipt != null)
			{
				object obj = (nint)0 + (nint)2072;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D233C8");
				byte[] array = default(byte[]);
				if (array != null)
				{
					return (byte[])Enumerable.FirstOrDefault((IEnumerable<object>)(object)array);
				}
				return array;
			}
			return (byte[])(object)new NullReferenceException();
		}
	}

	public byte[] Hash
	{
		get
		{
			//IL_0035: Expected O, but got I
			AppleReceiptReader receipt = _receipt;
			if (_receipt != null)
			{
				object obj = (nint)0 + (nint)2072;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D233C8");
				byte[] array = default(byte[]);
				if (array != null)
				{
					return (byte[])Enumerable.FirstOrDefault((IEnumerable<object>)(object)array);
				}
				return array;
			}
			return (byte[])(object)new NullReferenceException();
		}
	}

	public DateTime CreationTime
	{
		get
		{
			if (_receipt != null)
			{
				return _receipt.GetDateTime(12);
			}
			return (DateTime)new NullReferenceException();
		}
	}

	public DateTime ExpirationTime
	{
		get
		{
			if (_receipt != null)
			{
				return _receipt.GetDateTime(21);
			}
			return (DateTime)new NullReferenceException();
		}
	}

	public IEnumerable<ApplePurchaseReceipt> PurchasesReceipt
	{
		get
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0025: Expected O, but got I
			//IL_00b1: Expected O, but got I
			//IL_00c1: Expected O, but got I
			//IL_00d1: Expected O, but got I
			//IL_00f3: Expected O, but got I4
			//IL_0036: Expected O, but got I
			//IL_0046: Expected O, but got I
			//IL_0056: Expected O, but got I
			//IL_0078: Expected O, but got I4
			//IL_012b: Expected O, but got I4
			//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f8: Expected O, but got Unknown
			//IL_020e: Expected O, but got I
			//IL_021f: Expected I, but got O
			//IL_023d: Expected O, but got I
			//IL_015b: Expected O, but got I
			AppleReceiptReader receipt = _receipt;
			object obj;
			object obj5;
			Func<object, object> selector;
			object obj7;
			object obj4;
			if (_receipt != null)
			{
				obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1752;
				object obj2 = (nint)0 + (nint)2072;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D233C8");
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v10+E4]");
				if ((nint)0 != 0)
				{
					obj4 = (nint)0 + (nint)2880;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v10+B8]");
					obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v8+8]");
					selector = (Func<object, object>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v8+8]");
					bool flag = (nint)0 == 0;
					object obj6 = !flag;
					if (obj6 == null)
					{
						obj7 = obj4;
						goto IL_0109;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj3 = obj;
					obj7 = (nint)0 + (nint)2880;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v10+B8]");
					obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v8+8]");
					selector = (Func<object, object>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v8+8]");
					bool flag2 = (nint)0 == 0;
					object obj8 = !flag2;
					obj4 = obj7;
					if (obj8 == null)
					{
						goto IL_0109;
					}
				}
				goto IL_0160;
			}
			return (IEnumerable<ApplePurchaseReceipt>)new NullReferenceException();
			IL_0160:
			IEnumerable<object> source = default(IEnumerable<object>);
			return (IEnumerable<ApplePurchaseReceipt>)Enumerable.Select(source, selector);
			IL_0109:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v10+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v14+B8]");
				obj5 = 0;
			}
			object obj11 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3968;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj12 = (nint)0 + (nint)88;
			Func<object, object> func = default(Func<object, object>);
			func..ctor(obj5, (IntPtr)obj12);
			object obj13 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v13+B8]");
			object obj14 = (nint)0 + (nint)8;
			obj14 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj4 = obj7;
			selector = func;
			goto IL_0160;
		}
	}

	public AppleReceiptModel(byte[] receiptData)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		AppleReceiptReader appleReceiptReader = AppleReceiptReader.FromSignedCmsBytes(receiptData);
		object obj = this + 16;
		obj = appleReceiptReader;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
