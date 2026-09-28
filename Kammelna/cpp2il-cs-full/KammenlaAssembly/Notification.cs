using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using Cpp2ILInjected;
using Server.Models;

public class Notification : IClientFilterable
{
	private int <id>k__BackingField;

	private string <title>k__BackingField;

	private string <subtitle>k__BackingField;

	private string <details>k__BackingField;

	private bool <isAdvertisement>k__BackingField;

	private bool <appendLinkParams>k__BackingField;

	private bool <forceDisplay>k__BackingField;

	private int <timesToAppear>k__BackingField;

	private long <gapTicks>k__BackingField;

	private DateTime? <startDate>k__BackingField;

	private DateTime? <endDate>k__BackingField;

	private RoutingCommand <routingCommand>k__BackingField;

	private string <routingParam>k__BackingField;

	private Games? <routingGame>k__BackingField;

	private string <buttonText>k__BackingField;

	private ImageInfoModel<ImageCacher.NotificationImageType> <largeImage>k__BackingField;

	private ImageInfoModel<ImageCacher.NotificationImageType> <smallImage>k__BackingField;

	private List<ClientFilter> <Filters>k__BackingField;

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

	public string title
	{
		get
		{
			return <title>k__BackingField;
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

	public string subtitle
	{
		get
		{
			return <subtitle>k__BackingField;
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

	public string details
	{
		get
		{
			return <details>k__BackingField;
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

	public bool appendLinkParams
	{
		get
		{
			return <appendLinkParams>k__BackingField;
		}
		set
		{
			<appendLinkParams>k__BackingField = value;
		}
	}

	public bool forceDisplay
	{
		get
		{
			return <forceDisplay>k__BackingField;
		}
		set
		{
			<forceDisplay>k__BackingField = value;
		}
	}

	public int timesToAppear
	{
		get
		{
			return <timesToAppear>k__BackingField;
		}
		set
		{
			<timesToAppear>k__BackingField = value;
		}
	}

	public long gapTicks
	{
		get
		{
			return <gapTicks>k__BackingField;
		}
		set
		{
			<gapTicks>k__BackingField = value;
		}
	}

	public DateTime? startDate
	{
		get
		{
			return <startDate>k__BackingField;
		}
		set
		{
			<startDate>k__BackingField = value;
		}
	}

	public DateTime? endDate
	{
		get
		{
			return <endDate>k__BackingField;
		}
		set
		{
			<endDate>k__BackingField = value;
		}
	}

	public RoutingCommand routingCommand
	{
		get
		{
			return <routingCommand>k__BackingField;
		}
		set
		{
			<routingCommand>k__BackingField = value;
		}
	}

	public string routingParam
	{
		get
		{
			return <routingParam>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 104;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public Games? routingGame
	{
		get
		{
			return <routingGame>k__BackingField;
		}
		set
		{
			<routingGame>k__BackingField = value;
		}
	}

	public string buttonText
	{
		get
		{
			return <buttonText>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 120;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public ImageInfoModel<ImageCacher.NotificationImageType> largeImage
	{
		get
		{
			return <largeImage>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 128;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public ImageInfoModel<ImageCacher.NotificationImageType> smallImage
	{
		get
		{
			return <smallImage>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 136;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public List<ClientFilter> Filters
	{
		get
		{
			return <Filters>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 144;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public bool HasRouting()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0043: Expected O, but got I4
		if (<routingCommand>k__BackingField != RoutingCommand.NO_MESSAGE)
		{
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag2 = StringsExtensions.IsNullOrEmpty(<buttonText>k__BackingField);
			return (byte)((flag2 ? 1u : 0u) ^ 1u) != 0;
		}
		return false;
	}

	public string ComputeRoutingParam()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		if (<routingCommand>k__BackingField == RoutingCommand.OpenCustomURL && <appendLinkParams>k__BackingField)
		{
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2504;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v3+E4]");
			if ((nint)0 != 0)
			{
				return StringUtil.AppendUserParamsWithObfuscation(<routingParam>k__BackingField);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			return StringUtil.AppendUserParamsWithObfuscation(<routingParam>k__BackingField);
		}
		return <routingParam>k__BackingField;
	}
}
