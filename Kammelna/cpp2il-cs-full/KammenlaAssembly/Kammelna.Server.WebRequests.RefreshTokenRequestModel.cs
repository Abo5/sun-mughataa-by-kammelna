using System;
using Cpp2ILInjected;

namespace Kammelna.Server.WebRequests;

[Serializable]
public class RefreshTokenRequestModel
{
	private readonly string <RefreshToken>k__BackingField;

	private string <DeviceId>k__BackingField;

	private AppIntegrityRequestModel <IntegrityModel>k__BackingField;

	public string RefreshToken => <RefreshToken>k__BackingField;

	public string DeviceId
	{
		get
		{
			return <DeviceId>k__BackingField;
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

	public AppIntegrityRequestModel IntegrityModel
	{
		get
		{
			return <IntegrityModel>k__BackingField;
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

	public RefreshTokenRequestModel(string refreshToken, string deviceId, AppIntegrityRequestModel integrityModel)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		object obj = this + 16;
		obj = refreshToken;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = this + 24;
		obj2 = deviceId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj3 = this + 32;
		obj3 = integrityModel;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
