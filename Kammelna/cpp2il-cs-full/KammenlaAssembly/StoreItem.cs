using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using UnityEngine;

[Serializable]
public class StoreItem
{
	private int <id>k__BackingField;

	private ItemCategory <category>k__BackingField;

	private string <name>k__BackingField;

	private string <description>k__BackingField;

	private int <virtualPrice>k__BackingField;

	private List<ImageInfoModel<ImageCacher.ItemImageType>> <images>k__BackingField;

	private FileInfoModel <audio>k__BackingField;

	private FileInfoModel <animationData>k__BackingField;

	private List<AnimatedRoomFileInfoGroup> <animatedRoomFileInfoGroups>k__BackingField;

	private long <duration>k__BackingField;

	private bool <isAdvertisement>k__BackingField;

	private string <group>k__BackingField;

	private int <pack>k__BackingField;

	private int <tier>k__BackingField;

	private Color? <Color>k__BackingField;

	private GameAction <GameAction>k__BackingField = GameAction.None;

	private bool <isActive>k__BackingField;

	private bool <isUnique>k__BackingField;

	private int? <maxCopies>k__BackingField;

	private int <Order>k__BackingField;

	private GamesFlag <targetGames>k__BackingField;

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

	public ItemCategory category
	{
		get
		{
			return <category>k__BackingField;
		}
		set
		{
			<category>k__BackingField = value;
		}
	}

	public string name
	{
		get
		{
			return <name>k__BackingField;
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
			object obj = this + 32;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public int virtualPrice
	{
		get
		{
			return <virtualPrice>k__BackingField;
		}
		set
		{
			<virtualPrice>k__BackingField = value;
		}
	}

	public List<ImageInfoModel<ImageCacher.ItemImageType>> images
	{
		get
		{
			return <images>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 48;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public FileInfoModel audio
	{
		get
		{
			return <audio>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 56;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public FileInfoModel animationData
	{
		get
		{
			return <animationData>k__BackingField;
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

	public List<AnimatedRoomFileInfoGroup> animatedRoomFileInfoGroups
	{
		get
		{
			return <animatedRoomFileInfoGroups>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 72;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public long duration
	{
		get
		{
			return <duration>k__BackingField;
		}
		set
		{
			<duration>k__BackingField = value;
		}
	}

	public bool isAdvertisement
	{
		get
		{
			return <isAdvertisement>k__BackingField;
		}
		set
		{
			<isAdvertisement>k__BackingField = value;
		}
	}

	public string group
	{
		get
		{
			return <group>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 96;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public int pack
	{
		get
		{
			return <pack>k__BackingField;
		}
		set
		{
			<pack>k__BackingField = value;
		}
	}

	public int tier
	{
		get
		{
			return <tier>k__BackingField;
		}
		set
		{
			<tier>k__BackingField = value;
		}
	}

	public Color? Color
	{
		get
		{
			object obj = <Color>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (StoreItem)+80]");
			_ = 0;
			return (Color?)this;
		}
		set
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ X1 (System.Nullable`1<UnityEngine.Color>)+10]");
			_ = 0;
			<Color>k__BackingField = value;
		}
	}

	public GameAction GameAction
	{
		get
		{
			return <GameAction>k__BackingField;
		}
		set
		{
			<GameAction>k__BackingField = value;
		}
	}

	public bool isActive
	{
		get
		{
			return <isActive>k__BackingField;
		}
		set
		{
			<isActive>k__BackingField = value;
		}
	}

	public bool isUnique
	{
		get
		{
			return <isUnique>k__BackingField;
		}
		set
		{
			<isUnique>k__BackingField = value;
		}
	}

	public int? maxCopies
	{
		get
		{
			return <maxCopies>k__BackingField;
		}
		set
		{
			<maxCopies>k__BackingField = value;
		}
	}

	public int Order
	{
		get
		{
			return <Order>k__BackingField;
		}
		set
		{
			<Order>k__BackingField = value;
		}
	}

	public GamesFlag targetGames
	{
		get
		{
			return <targetGames>k__BackingField;
		}
		set
		{
			<targetGames>k__BackingField = value;
		}
	}

	public bool IsActiveAndNotAd
	{
		get
		{
			//IL_0032: Expected O, but got I4
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Expected I4, but got Unknown
			if (<isActive>k__BackingField)
			{
				object obj = (<isAdvertisement>k__BackingField ? 1 : 0) ^ 1;
				return (byte)(obj & 1) != 0;
			}
			return false;
		}
	}

	public bool HasGameAction
	{
		get
		{
			//IL_0010: Expected O, but got I4
			object obj = <GameAction>k__BackingField + 100;
			bool flag = obj == null;
			return !flag;
		}
	}

	private int? GameActionValue
	{
		get
		{
			//IL_0030: Expected O, but got I4
			//IL_004a: Expected O, but got I4
			//IL_000b: Expected O, but got I4
			object obj = <GameAction>k__BackingField + 100;
			bool flag = obj == null;
			object obj2 = !flag;
			if (obj2 == null)
			{
				return (int?)(object)0;
			}
			return (int)<GameAction>k__BackingField;
		}
		set
		{
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Expected O, but got Unknown
			//IL_0025: Expected I4, but got I8
			object obj = (??)value & 1;
			int? num2 = default(int?);
			int num = (int)((obj == null) ? 4294967196L : num2.Value);
			<GameAction>k__BackingField = (GameAction)num;
		}
	}

	public ItemCategory GetCategory()
	{
		return <category>k__BackingField;
	}

	public override string ToString()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0081: Expected O, but got I8
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00e2: Expected O, but got I4
		//IL_00f8: Expected O, but got I
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected O, but got Unknown
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected O, but got Unknown
		//IL_0179: Expected O, but got I4
		//IL_01b3: Expected O, but got I8
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected O, but got Unknown
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected O, but got Unknown
		//IL_0242: Expected O, but got I4
		//IL_0258: Expected O, but got I
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Expected O, but got Unknown
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected O, but got Unknown
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Expected O, but got Unknown
		//IL_0303: Expected O, but got I4
		//IL_0319: Expected O, but got I
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Expected O, but got Unknown
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected O, but got Unknown
		object obj = typeof(SqlSingle[]) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		string[] array = default(string[]);
		if (array != null)
		{
			if (array.Length != 0)
			{
				object obj2 = "_InputUv1BufferOffset" + 3952;
				object obj3 = array + 32;
				obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X21_v6-8]");
				object obj4 = 0 & 0xFFFFFFFEL;
				if (obj4 != null)
				{
					object obj5 = array + 40;
					obj5 = <name>k__BackingField;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X21_v8-10]");
					bool flag = (nint)0 < (nint)2;
					object obj6 = !flag;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X21_v8-10]");
					object obj7 = -2;
					bool flag2 = obj7 == null;
					object obj8 = ~obj6;
					object obj9 = obj8 | flag2;
					if (obj9 == null)
					{
						object obj10 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 896;
						object format = "_InputUv1BufferOffset" + 3760;
						object obj11 = array + 48;
						obj11 = obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						object obj12 = 153100288 + 1024;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
						object arg = default(object);
						string text = string.Format((string)format, arg);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X21_v10-18]");
						object obj13 = 0 & 0xFFFFFFFCL;
						if (obj13 != null)
						{
							object format2 = "_InputUv1BufferOffset" + 3768;
							object obj14 = array + 56;
							obj14 = text;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
							object arg2 = default(object);
							string text2 = string.Format((string)format2, arg2);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X21_v12-20]");
							bool flag3 = (nint)0 < (nint)4;
							object obj15 = !flag3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X21_v12-20]");
							object obj16 = -4;
							bool flag4 = obj16 == null;
							object obj17 = ~obj15;
							object obj18 = obj17 | flag4;
							if (obj18 == null)
							{
								object format3 = "_InputUv1BufferOffset" + 3776;
								object obj19 = array + 64;
								obj19 = text2;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
								object arg3 = default(object);
								string text3 = string.Format((string)format3, arg3, <group>k__BackingField);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X21_v14-28]");
								bool flag5 = (nint)0 < (nint)5;
								object obj20 = !flag5;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X21_v14-28]");
								object obj21 = -5;
								bool flag6 = obj21 == null;
								object obj22 = ~obj20;
								object obj23 = obj22 | flag6;
								if (obj23 == null)
								{
									object obj24 = array + 72;
									obj24 = text3;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									return string.Concat(array);
								}
							}
						}
					}
				}
			}
			IndexOutOfRangeException ex = new IndexOutOfRangeException();
		}
		return (string)(object)new NullReferenceException();
	}
}
