using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering;

public class SportTeam
{
	private int <id>k__BackingField;

	private string <name>k__BackingField;

	private int? <cardBackID>k__BackingField;

	private string <colorOne>k__BackingField;

	private string <colorTwo>k__BackingField;

	private List<ImageInfoModel<ImageCacher.SportTeamImageType>> <images>k__BackingField;

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

	public int? cardBackID
	{
		get
		{
			return <cardBackID>k__BackingField;
		}
		set
		{
			<cardBackID>k__BackingField = value;
		}
	}

	public string colorOne
	{
		get
		{
			return <colorOne>k__BackingField;
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

	public string colorTwo
	{
		get
		{
			return <colorTwo>k__BackingField;
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

	public List<ImageInfoModel<ImageCacher.SportTeamImageType>> images
	{
		get
		{
			return <images>k__BackingField;
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

	public Color ColorOne()
	{
		//IL_0013: Expected O, but got I4
		Color color2;
		Color color = (Color)ColorUtility.TryParseHtmlString(<colorOne>k__BackingField, out color2);
		if ((object)color != null)
		{
		}
		return color;
	}

	public Color ColorTwo()
	{
		//IL_0013: Expected O, but got I4
		Color color2;
		Color color = (Color)ColorUtility.TryParseHtmlString(<colorTwo>k__BackingField, out color2);
		if ((object)color != null)
		{
		}
		return color;
	}

	public SportTeam()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		object obj = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 3656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj2 = this + 56;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}
}
