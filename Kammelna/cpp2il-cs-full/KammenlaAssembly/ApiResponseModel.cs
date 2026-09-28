using System;
using System.Collections.Generic;
using System.Data;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models;
using UnityEngine.Networking;

public class ApiResponseModel<T> : ApiResponseModel
{
	private T <Model>k__BackingField;

	private readonly CachedModel<T> <CachedModel>k__BackingField;

	public T Model
	{
		get
		{
			//IL_000d: Expected O, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApiResponseModel`1<T>)+40]");
			return (T)0;
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

	private CachedModel<T> CachedModel
	{
		get
		{
			//IL_000d: Expected O, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApiResponseModel`1<T>)+48]");
			return (CachedModel<T>)0;
		}
	}

	public ApiResponseModel(KammelnaError error)
		: base(error)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_001e: Expected O, but got I4
		object obj = this + 64;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public ApiResponseModel(T model)
		: base(KammelnaError.NoError)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		object obj = this + 64;
		obj = model;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public ApiResponseModel(UnityWebRequest request, CachedModel<T> cachedModel)
		: base(request)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		object obj = this + 72;
		obj = cachedModel;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public override void ParseResponse()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0099: Expected O, but got I4
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected O, but got Unknown
		//IL_01a7: Expected O, but got I4
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_01e8: Expected O, but got I
		//IL_01ff: Expected O, but got I
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected O, but got Unknown
		//IL_0143: Expected O, but got I
		//IL_0143: Expected O, but got I
		//IL_0143: Expected O, but got I
		//IL_0143: Expected O, but got I
		base.ParseResponse();
		if (!base.Succeeded)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApiResponseModel`1<T>)+20]");
		if ((nint)0 == 1)
		{
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 728;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X0_v18+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E949E4");
			object obj4 = this + 64;
			object obj5 = default(object);
			obj4 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X21_v9+8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X21_v9+8]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApiResponseModel`1<T>)+40]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApiResponseModel`1<T>)+30]");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApiResponseModel`1<T>)+38]");
				((CachedModel<object>)num2).Update(num3, (Dictionary<string, string>)num4, (string)0);
			}
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApiResponseModel`1<T>)+48]");
		if ((nint)0 != 0)
		{
			object obj6 = typeof(DataRelation) + 712;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v8+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime now = DateTime.Now;
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApiResponseModel`1<T>)+48]");
			((CachedModel<object>)0).LastUpdate = now;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ApiResponseModel`1<T>)+48]");
			object model = ((CachedModel<object>)0).Model;
			object obj9 = this + 64;
			obj9 = model;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}
}
