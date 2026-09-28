using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Net;
using Cpp2ILInjected;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq.JsonPath;
using UnityEngine;
using UnityEngine.Networking;

public class KammelnaResponseModel<T>
{
	[Serializable]
	private class ErrorModel
	{
		private KammelnaError <ErrorCode>k__BackingField;

		public KammelnaError ErrorCode
		{
			get
			{
				return <ErrorCode>k__BackingField;
			}
			set
			{
				<ErrorCode>k__BackingField = value;
			}
		}
	}

	[Serializable]
	private class ResponseModel : ErrorModel
	{
		private T <Response>k__BackingField;

		private string <RefreshedJwt>k__BackingField;

		public T Response
		{
			get
			{
				//IL_000d: Expected O, but got I
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (KammelnaResponseModel`1<T>+ResponseModel<T>)+14]");
				return (T)0;
			}
			set
			{
			}
		}

		public string RefreshedJwt
		{
			get
			{
				return <RefreshedJwt>k__BackingField;
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

		public ResponseModel()
		{
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4A15298");
		}
	}

	private readonly HttpStatusCode <StatusCode>k__BackingField;

	private KammelnaError <Error>k__BackingField = KammelnaError.NoError;

	private readonly string <PlainTextResponse>k__BackingField;

	private readonly Dictionary<string, string> <ResponseHeaders>k__BackingField;

	private readonly string <RequestPath>k__BackingField;

	private T <Model>k__BackingField;

	private string <RefreshedJwt>k__BackingField;

	private ResponseModel <ParsedModel>k__BackingField;

	public string ErrorMessage
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1176;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			Enum enumeration = default(Enum);
			return EnumExtensions.GetFriendlyName(enumeration);
		}
	}

	public HttpStatusCode StatusCode => <StatusCode>k__BackingField;

	public KammelnaError Error
	{
		get
		{
			return <Error>k__BackingField;
		}
		set
		{
			<Error>k__BackingField = value;
		}
	}

	public string PlainTextResponse => <PlainTextResponse>k__BackingField;

	public bool Succeeded
	{
		get
		{
			//IL_0010: Expected O, but got I4
			object obj = <Error>k__BackingField - 1000;
			return obj == null;
		}
	}

	public bool CachedModelUpdated
	{
		get
		{
			//IL_0032: Expected O, but got I4
			if (<Error>k__BackingField == KammelnaError.NoError)
			{
				object obj = <StatusCode>k__BackingField - 304;
				bool flag = obj == null;
				return !flag;
			}
			return false;
		}
	}

	public Dictionary<string, string> ResponseHeaders => <ResponseHeaders>k__BackingField;

	public string RequestPath => <RequestPath>k__BackingField;

	public T Model
	{
		get
		{
			return <Model>k__BackingField;
		}
		set
		{
			<Model>k__BackingField = value;
		}
	}

	public string RefreshedJwt
	{
		get
		{
			return <RefreshedJwt>k__BackingField;
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

	private ResponseModel ParsedModel
	{
		get
		{
			return <ParsedModel>k__BackingField;
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

	public KammelnaResponseModel()
	{
	}

	public KammelnaResponseModel(KammelnaError error)
	{
		<Error>k__BackingField = error;
	}

	public KammelnaResponseModel(UnityWebRequest request)
	{
		//IL_001c: Expected I4, but got I8
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected O, but got Unknown
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected O, but got Unknown
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected O, but got Unknown
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected O, but got Unknown
		//IL_022f: Expected O, but got I4
		//IL_0245: Expected O, but got I
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected O, but got Unknown
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected O, but got Unknown
		//IL_02a9: Expected O, but got I
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Expected O, but got Unknown
		//IL_02eb: Expected O, but got I4
		//IL_0301: Expected O, but got I
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Expected O, but got Unknown
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Expected O, but got Unknown
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_037a: Expected O, but got Unknown
		//IL_0486: Unknown result type (might be due to invalid IL or missing references)
		//IL_048b: Expected O, but got Unknown
		string text2;
		HttpStatusCode httpStatusCode;
		if (request != null)
		{
			<StatusCode>k__BackingField = (HttpStatusCode)request.responseCode;
			Uri uri = request.uri;
			if ((object)uri != null)
			{
				string pathAndQuery = uri.PathAndQuery;
				object obj = this + 40;
				obj = pathAndQuery;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				if (request.result == UnityWebRequest.Result.Success)
				{
					Dictionary<string, string> responseHeaders = request.GetResponseHeaders();
					object obj2 = this + 32;
					obj2 = responseHeaders;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					DownloadHandler downloadHandler = request.downloadHandler;
					if (downloadHandler != null)
					{
						string text = downloadHandler.text;
						object obj3 = this + 24;
						obj3 = text;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						return;
					}
				}
				else
				{
					DownloadHandler downloadHandler2 = request.downloadHandler;
					if (downloadHandler2 != null)
					{
						text2 = downloadHandler2.text;
						object obj4 = typeof(SqlSingle[]) + 32;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
						string[] array = default(string[]);
						if (array != null)
						{
							object obj5 = array + 32;
							obj5 = obj;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							object obj6 = "1.2.840.113549.1.12.1.5" + 1504;
							object obj7 = array + 40;
							obj7 = obj6;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							string error = request.error;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X23_v8-10]");
							object obj8 = (nint)0 >= (nint)2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X23_v8-10]");
							if ((object)(~obj8 | ((object)(-2) == null)) == null)
							{
								object obj9 = array + 48;
								obj9 = error;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								object obj10 = (nint)0 + (nint)3688;
								object obj11 = array + 56;
								obj11 = obj10;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X20_v6-20]");
								object obj12 = (nint)0 >= (nint)4;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X20_v6-20]");
								if ((object)(~obj12 | ((object)(-4) == null)) == null)
								{
									object obj13 = array + 64;
									obj13 = text2;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									string message = string.Concat(array);
									object obj14 = typeof(DataRelation) + 856;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X8_v19+E4]");
									if ((nint)0 != 0)
									{
										Debug.LogError(message);
										httpStatusCode = <StatusCode>k__BackingField;
										if (<StatusCode>k__BackingField != HttpStatusCode.Unauthorized)
										{
											goto IL_0422;
										}
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										Debug.LogError(message);
										httpStatusCode = <StatusCode>k__BackingField;
										if (<StatusCode>k__BackingField != HttpStatusCode.Unauthorized)
										{
											goto IL_0422;
										}
									}
									goto IL_0474;
								}
							}
							goto IL_04ac;
						}
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_04ac;
		IL_04ac:
		throw new IndexOutOfRangeException();
		IL_0474:
		<Error>k__BackingField = KammelnaError.UnknownError;
		return;
		IL_0422:
		if (httpStatusCode == HttpStatusCode.TooManyRequests)
		{
			<Error>k__BackingField = KammelnaError.RateLimited;
			return;
		}
		if (string.IsNullOrEmpty(text2))
		{
			goto IL_0474;
		}
		object obj15 = this + 24;
		obj15 = text2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public void ParseResponse()
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0062: Expected O, but got I4
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_010a: Expected O, but got I4
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected O, but got Unknown
		//IL_01d8: Expected O, but got I
		if (<Error>k__BackingField != KammelnaError.NoError || <StatusCode>k__BackingField == HttpStatusCode.NotModified)
		{
			return;
		}
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 520;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E906D8");
		object obj4 = this + 64;
		object obj5 = default(object);
		obj4 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj4;
		if (obj4 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v11+10]");
			<Error>k__BackingField = (KammelnaError)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v11+10]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				KammelnaError kammelnaError = ((<StatusCode>k__BackingField < HttpStatusCode.BadRequest) ? KammelnaError.NoError : KammelnaError.UnknownError);
				<Error>k__BackingField = kammelnaError;
			}
			object obj8 = this + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v11+18]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v11+14]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			KammelnaError kammelnaError2 = ((<StatusCode>k__BackingField < HttpStatusCode.BadRequest) ? KammelnaError.NoError : KammelnaError.UnknownError);
			<Error>k__BackingField = kammelnaError2;
		}
	}

	public TNew ReParse<TNew>()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0052: Expected O, but got I4
		string text = <PlainTextResponse>k__BackingField;
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 520;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		string value = <PlainTextResponse>k__BackingField;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			value = text;
		}
		KammelnaResponseModel<TNew>.ResponseModel responseModel = JsonConvert.DeserializeObject<KammelnaResponseModel<TNew>.ResponseModel>(value);
		if (responseModel != null)
		{
			return (TNew)responseModel.<RefreshedJwt>k__BackingField;
		}
		return (TNew)new NullReferenceException();
	}
}
