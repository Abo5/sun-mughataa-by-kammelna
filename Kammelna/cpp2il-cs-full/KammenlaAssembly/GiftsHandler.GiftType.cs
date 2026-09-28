using System;
using System.Collections.Generic;
using System.ComponentModel;
using Cpp2ILInjected;
using Kammelna.Server;
using Server.Models;
using Server.Models.Products;
using Sfs2X.Entities;
using UnityEngine;

public class GiftsHandler : MonoBehaviour
{
	public enum GiftType
	{
		Coins,
		Subscription
	}

	public static void ShowGiftReceivedPopup(ReceivedGiftFeedData giftData)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_00be: Expected O, but got I4
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2896;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		long num = default(long);
		string text = num.ToString();
		object obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2904;
		object obj4 = obj2 + 16;
		obj4 = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj2 + 40;
		obj5 = giftData.<Message>k__BackingField;
		_ = giftData.<GiftType>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X0_v14+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GiftSuccessPopup.PopupReceived((GiftNotificationData)obj2);
	}

	public static void ShowGiftSentPopup(GiftInfo giftInfo, ProductViewModel product)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_006d: Expected O, but got I4
		//IL_0099: Expected O, but got I4
		//IL_00c7: Expected O, but got I4
		//IL_00b9: Expected O, but got I4
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2896;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = product.<id>k__BackingField;
		object obj3 = obj2 + 40;
		obj3 = giftInfo.<Message>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool isCoins = product.IsCoins;
		object obj4 = (isCoins ? 1 : 0) ^ 1;
		bool isCoins2 = product.IsCoins;
		bool flag = !isCoins2;
		object obj5 = !flag;
		object obj6 = ~obj5;
		if (obj6 == null)
		{
			object obj7 = 32;
		}
		else
		{
			object obj7 = 36;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [product @ X1 (Server.Models.Products.ProductViewModel)+v123 @ X8_v7]");
		_ = 0;
		ShowGiftSentPopup(giftInfo.<RecipientId>k__BackingField, (GiftNotificationData)obj2);
	}

	public static void ShowGiftSentPopup(GiftInfo giftInfo, GiftType type, int amount)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2896;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 40;
		obj3 = giftInfo.<Message>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		ShowGiftSentPopup(giftInfo.<RecipientId>k__BackingField, (GiftNotificationData)obj2);
	}

	private static void ShowGiftSentPopup(int recipientId, GiftNotificationData gift)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected O, but got Unknown
		//IL_01e6: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8CCB]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v19+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj4;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v19+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_0133;
		IL_0133:
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		string dbId = SFSKammelnaUserExtensions.GetDbId(localUser);
		object obj8 = gift + 16;
		obj8 = dbId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj9 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2904;
		int num = default(int);
		string recipientId2 = num.ToString();
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v12+E4]");
		bool flag3 = (nint)0 == 0;
		object obj11 = !flag3;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GiftSuccessPopup.PopupSent(gift, recipientId2);
		return;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag4 = (object)sessionModel == null;
		object obj12 = !flag4;
		if (obj12 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0133;
	}

	private static void ShowGiftSentPopup(GiftNotificationData giftData, int recipientId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_006d: Expected O, but got I4
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2904;
		int num = default(int);
		string recipientId2 = num.ToString();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		GiftSuccessPopup.PopupSent(giftData, recipientId2);
	}
}
