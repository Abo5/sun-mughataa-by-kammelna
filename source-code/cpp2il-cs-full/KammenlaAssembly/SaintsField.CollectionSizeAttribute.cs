using System;

namespace SaintsField;

public class CollectionSizeAttribute : Attribute
{
	private readonly int <Min>k__BackingField;

	private readonly int <Max>k__BackingField = 2147483647;

	public int Min
	{
		get
		{
			return <Min>k__BackingField;
		}
		set
		{
			<Min>k__BackingField = value;
		}
	}

	public int Max
	{
		get
		{
			return <Max>k__BackingField;
		}
		set
		{
			<Max>k__BackingField = value;
		}
	}

	public CollectionSizeAttribute()
	{
	}

	public CollectionSizeAttribute(int size)
	{
		<Min>k__BackingField = size;
		<Max>k__BackingField = size;
	}

	public CollectionSizeAttribute(int min, int max)
	{
		<Min>k__BackingField = min;
		<Max>k__BackingField = max;
	}
}
