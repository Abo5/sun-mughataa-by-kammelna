using System;
using Cpp2ILInjected;

namespace Managers.IAP.Apple;

public class ApplePurchaseReceipt
{
	private static class AppleReceiptType
	{
		public const int Quantity = 1701;

		public const int ProductId = 1702;

		public const int TransactionId = 1703;

		public const int OriginalTransactionId = 1705;

		public const int WebOrderLineItemId = 1711;

		public const int PurchaseTime = 1704;

		public const int OriginalPurchaseTime = 1706;

		public const int ExpirationTime = 1708;

		public const int CancellationTime = 1712;

		public const int IntroductoryPricePeriod = 1719;
	}

	private readonly AppleReceiptReader _receipt;

	public long Quantity
	{
		get
		{
			//IL_0046: Expected I8, but got O
			if (_receipt != null)
			{
				return _receipt.GetParsedInt(1701);
			}
			NullReferenceException ex = new NullReferenceException();
			return (long)ex;
		}
	}

	public string ProductId
	{
		get
		{
			if (_receipt != null)
			{
				return _receipt.GetString(1702);
			}
			return (string)(object)new NullReferenceException();
		}
	}

	public string TransactionId
	{
		get
		{
			if (_receipt != null)
			{
				return _receipt.GetString(1703);
			}
			return (string)(object)new NullReferenceException();
		}
	}

	public string OriginalTransactionId
	{
		get
		{
			if (_receipt != null)
			{
				return _receipt.GetString(1705);
			}
			return (string)(object)new NullReferenceException();
		}
	}

	public long WebOrderLineItemId
	{
		get
		{
			//IL_0046: Expected I8, but got O
			if (_receipt != null)
			{
				return _receipt.GetParsedInt(1711);
			}
			NullReferenceException ex = new NullReferenceException();
			return (long)ex;
		}
	}

	public DateTime PurchaseTime
	{
		get
		{
			if (_receipt != null)
			{
				return _receipt.GetDateTime(1704);
			}
			return (DateTime)new NullReferenceException();
		}
	}

	public DateTime OriginalPurchaseTime
	{
		get
		{
			if (_receipt != null)
			{
				return _receipt.GetDateTime(1706);
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
				return _receipt.GetDateTime(1708);
			}
			return (DateTime)new NullReferenceException();
		}
	}

	public DateTime? CancellationTime
	{
		get
		{
			if (_receipt != null)
			{
				return _receipt.GetDateTimeOrNull(1712);
			}
			return (DateTime?)new NullReferenceException();
		}
	}

	public bool IsIntroductoryPricePeriod
	{
		get
		{
			//IL_0051: Expected I4, but got O
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			if (_receipt != null)
			{
				object obj = "tournament_participate_warning_body_with_tickets_warning_daily" + 680;
				string text = _receipt.GetString(1719);
				return text == (string)obj;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public ApplePurchaseReceipt(byte[] receiptData)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		AppleReceiptReader appleReceiptReader = AppleReceiptReader.FromRawBytes(receiptData);
		object obj = this + 16;
		obj = appleReceiptReader;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
