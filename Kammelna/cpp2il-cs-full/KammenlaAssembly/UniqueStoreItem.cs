using System;
using UnityEngine;

[Serializable]
public class UniqueStoreItem
{
	private DateTime <ExpirationDate>k__BackingField;

	private long <ItemId>k__BackingField;

	private int <Count>k__BackingField;

	private Color <Color>k__BackingField = (Color)0;

	private bool <IsSoldOut>k__BackingField;

	public DateTime ExpirationDate
	{
		get
		{
			return <ExpirationDate>k__BackingField;
		}
		set
		{
			<ExpirationDate>k__BackingField = value;
		}
	}

	public long ItemId
	{
		get
		{
			return <ItemId>k__BackingField;
		}
		set
		{
			<ItemId>k__BackingField = value;
		}
	}

	public int Count
	{
		get
		{
			return <Count>k__BackingField;
		}
		set
		{
			<Count>k__BackingField = value;
		}
	}

	public Color Color
	{
		get
		{
			return (Color)this;
		}
		set
		{
			Color color = default(Color);
			<Color>k__BackingField = color;
		}
	}

	public bool IsSoldOut
	{
		get
		{
			return <IsSoldOut>k__BackingField;
		}
		set
		{
			<IsSoldOut>k__BackingField = value;
		}
	}
}
