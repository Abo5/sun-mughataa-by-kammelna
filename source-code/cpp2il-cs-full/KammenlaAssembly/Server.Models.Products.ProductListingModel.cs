using System;
using System.Buffers.Text;
using System.Collections.Generic;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;

namespace Server.Models.Products;

public class ProductListingModel
{
	private int <id>k__BackingField;

	private string <listingId>k__BackingField;

	private SalesChannel <channelId>k__BackingField;

	private string <description>k__BackingField;

	private float <price>k__BackingField;

	private bool <isRecurring>k__BackingField;

	private bool <isConsumable>k__BackingField;

	private bool <isHidden>k__BackingField;

	private byte <discountPercentage>k__BackingField;

	private float <originalPrice>k__BackingField;

	private List<Offer> <Offers>k__BackingField;

	public int id
	{
		get
		{
			return <id>k__BackingField;
		}
		set
		{
			<id>k__BackingField = value;
		}
	}

	public string listingId
	{
		get
		{
			return <listingId>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 24;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public SalesChannel channelId
	{
		get
		{
			return <channelId>k__BackingField;
		}
		set
		{
			<channelId>k__BackingField = value;
		}
	}

	public string description
	{
		get
		{
			return <description>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 40;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public float price
	{
		get
		{
			return <price>k__BackingField;
		}
		set
		{
			<price>k__BackingField = value;
		}
	}

	public bool isRecurring
	{
		get
		{
			return <isRecurring>k__BackingField;
		}
		set
		{
			<isRecurring>k__BackingField = value;
		}
	}

	public bool isConsumable
	{
		get
		{
			return <isConsumable>k__BackingField;
		}
		set
		{
			<isConsumable>k__BackingField = value;
		}
	}

	public bool isHidden
	{
		get
		{
			return <isHidden>k__BackingField;
		}
		set
		{
			<isHidden>k__BackingField = value;
		}
	}

	public byte discountPercentage
	{
		get
		{
			return <discountPercentage>k__BackingField;
		}
		set
		{
			<discountPercentage>k__BackingField = value;
		}
	}

	public float originalPrice
	{
		get
		{
			return <originalPrice>k__BackingField;
		}
		set
		{
			<originalPrice>k__BackingField = value;
		}
	}

	public List<Offer> Offers
	{
		get
		{
			return <Offers>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 64;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public bool isPromotionActive
	{
		get
		{
			bool flag = <discountPercentage>k__BackingField == 0;
			return !flag;
		}
	}

	public ProductViewModel getProduct()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00f5: Expected O, but got I4
		//IL_008c: Expected O, but got I
		//IL_012d: Expected O, but got I
		//IL_014f: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 2152;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7D6F]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v16+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = obj3;
			if (!flag)
			{
				goto IL_007c;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v16+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			object obj4 = obj3;
			if (obj5 != null)
			{
				goto IL_007c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v5+B8]");
		object obj7 = 0;
		Dictionary<object, object> dictionary = (Dictionary<object, object>)obj7;
		bool flag3 = obj7 == null;
		object obj8 = !flag3;
		if (obj8 != null)
		{
			goto IL_00b1;
		}
		goto IL_015d;
		IL_00b1:
		return (ProductViewModel)dictionary.get_Item((object)this);
		IL_015d:
		return (ProductViewModel)(object)new NullReferenceException();
		IL_007c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v16+B8]");
		object obj9 = 0;
		dictionary = (Dictionary<object, object>)obj9;
		if (obj9 != null)
		{
			goto IL_00b1;
		}
		goto IL_015d;
	}

	public string GetLocalizedShortName()
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_0135: Expected O, but got I
		//IL_014f: Expected O, but got I4
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0066: Expected O, but got I
		//IL_01d5: Expected O, but got I
		//IL_0195: Expected O, but got I4
		//IL_00d0: Expected O, but got I
		//IL_00f2: Expected O, but got I4
		//IL_0206: Expected O, but got I
		//IL_0278: Expected O, but got I4
		//IL_03d4: Expected O, but got I
		//IL_03f9: Expected I8, but got I
		//IL_0409: Unknown result type (might be due to invalid IL or missing references)
		//IL_040e: Expected I8, but got Unknown
		//IL_0452: Expected O, but got I
		//IL_0466: Unknown result type (might be due to invalid IL or missing references)
		//IL_046b: Expected O, but got Unknown
		//IL_0495: Expected O, but got I4
		//IL_04bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c1: Expected O, but got Unknown
		//IL_04d6: Expected I8, but got I
		//IL_04ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f3: Expected O, but got Unknown
		//IL_051d: Expected O, but got I4
		//IL_0544: Unknown result type (might be due to invalid IL or missing references)
		//IL_0549: Expected O, but got Unknown
		//IL_055e: Expected I8, but got I
		//IL_05c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c8: Expected O, but got Unknown
		//IL_05f2: Expected O, but got I4
		//IL_0619: Unknown result type (might be due to invalid IL or missing references)
		//IL_061e: Expected O, but got Unknown
		//IL_0646: Unknown result type (might be due to invalid IL or missing references)
		//IL_064b: Expected O, but got Unknown
		//IL_0675: Expected O, but got I4
		//IL_069c: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a1: Expected O, but got Unknown
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Expected O, but got Unknown
		//IL_0358: Expected O, but got I4
		//IL_037f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0384: Expected O, but got Unknown
		object obj = 152989696;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7D70]");
		object obj2 = (nint)0 & (nint)1;
		object obj3;
		object obj5;
		if (obj2 != null)
		{
			obj3 = typeof(System.Buffers.Text.ParserHelpers) + 2152;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7D6F]");
			object obj4 = (nint)0 & (nint)1;
			bool flag = obj4 == null;
			obj5 = obj3;
			if (!flag)
			{
				goto IL_008b;
			}
		}
		else
		{
			_ = 1;
			obj3 = typeof(System.Buffers.Text.ParserHelpers) + 2152;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7D6F]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			obj5 = obj3;
			if (obj7 != null)
			{
				goto IL_008b;
			}
		}
		_ = 1;
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v65+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		object obj10 = obj8;
		obj3 = obj5;
		if (obj9 != null)
		{
			goto IL_00c0;
		}
		goto IL_01b3;
		IL_06b3:
		return (string)(object)new NullReferenceException();
		IL_0630:
		return <description>k__BackingField;
		IL_01fa:
		object obj11 = (nint)0 + (nint)432;
		Dictionary<object, object> dictionary;
		object obj12 = dictionary.get_Item((object)this);
		if (obj12 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v4 (System.Object)+24]");
			if ((nint)0 >= (nint)1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v4 (System.Object)+20]");
				bool flag4 = (nint)0 == 0;
				object obj13 = !flag4;
				if (obj13 == null)
				{
					if (<isRecurring>k__BackingField)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v4 (System.Object)+24]");
						if ((nint)0 <= (nint)359)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v4 (System.Object)+24]");
							if ((nint)0 != 7)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v4 (System.Object)+24]");
								if ((nint)0 == 30)
								{
									object obj14 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
									object obj15 = obj14;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X0_v27+E4]");
									bool flag5 = (nint)0 == 0;
									object obj16 = !flag5;
									if (obj16 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									object input = "Material with texture name \"" + 2496;
									return LocalizationUtil.Localize((string)input);
								}
								goto IL_0630;
							}
							object obj17 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
							object obj18 = obj17;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X0_v22+E4]");
							bool flag6 = (nint)0 == 0;
							object obj19 = !flag6;
							if (obj19 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							object input2 = "Unsupported map type" + 3896;
							return LocalizationUtil.Localize((string)input2);
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v4 (System.Object)+24]");
						if ((nint)0 != 360)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v4 (System.Object)+24]");
							if ((nint)0 != 365)
							{
								goto IL_0630;
							}
						}
						object obj20 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
						object obj21 = obj20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X0_v17+E4]");
						bool flag7 = (nint)0 == 0;
						object obj22 = !flag7;
						if (obj22 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object input3 = "WhiteSmoke" + 1472;
						return LocalizationUtil.Localize((string)input3);
					}
					object obj23 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
					object obj24 = obj23;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X0_v11+E4]");
					bool flag8 = (nint)0 == 0;
					object obj25 = !flag8;
					if (obj25 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object input4 = "SERVICE_DISABLED" + 1344;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v4 (System.Object)+24]");
					return LocalizationUtil.Localize((string)input4, 0L);
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v4 (System.Object)+24]");
				bool flag9;
				bool flag10;
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v4 (System.Object)+20]");
					object obj26 = -1;
					flag9 = (nint)obj26 < 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v4 (System.Object)+20]");
					long num = (nint)0 ^ (nint)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v4 (System.Object)+20]");
					long num2 = 0 ^ obj26;
					long num3 = num & num2;
					flag10 = num3 < 0;
				}
				else
				{
					flag10 = false;
					flag9 = true;
				}
				if (flag9 == flag10)
				{
					object obj27 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
					object obj28 = obj27;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ X0_v6+E4]");
					bool flag11 = (nint)0 == 0;
					object obj29 = !flag11;
					if (obj29 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object input5 = "AvailableVoices" + 3920;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v4 (System.Object)+20]");
					return LocalizationUtil.Localize((string)input5, 0L);
				}
			}
			return (string)((nint)0 + (nint)2000);
		}
		goto IL_06b3;
		IL_008b:
		obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v65+E4]");
		bool flag12 = (nint)0 == 0;
		obj10 = obj8;
		if (!flag12)
		{
			goto IL_00c0;
		}
		goto IL_01b3;
		IL_01b3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj30 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v34+B8]");
		object obj31 = 0;
		dictionary = (Dictionary<object, object>)obj31;
		if (obj31 != null)
		{
			goto IL_01fa;
		}
		goto IL_06b3;
		IL_00c0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v65+B8]");
		object obj32 = 0;
		dictionary = (Dictionary<object, object>)obj32;
		bool flag13 = obj32 == null;
		object obj33 = !flag13;
		if (obj33 != null)
		{
			goto IL_01fa;
		}
		goto IL_06b3;
	}
}
