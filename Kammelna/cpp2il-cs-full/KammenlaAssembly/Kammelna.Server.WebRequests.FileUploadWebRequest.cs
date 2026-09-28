using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Networking;

namespace Kammelna.Server.WebRequests;

public abstract class FileUploadWebRequest<TResponse> : FormDataWebRequest<TResponse>
{
	private const string ContentTypeOctetStream = "application/octet-stream";

	protected abstract string KeyName { get; }

	protected abstract string FileName { get; }

	protected abstract byte[] FileBytes { get; }

	protected override List<IMultipartFormSection> FormData
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Expected O, but got Unknown
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected O, but got Unknown
			//IL_018d: Expected I, but got O
			//IL_019c: Expected I, but got O
			//IL_01ab: Expected I, but got O
			//IL_00e4: Expected O, but got I4
			//IL_0124: Unknown result type (might be due to invalid IL or missing references)
			//IL_0129: Expected O, but got Unknown
			//IL_0132: Unknown result type (might be due to invalid IL or missing references)
			//IL_0137: Expected O, but got Unknown
			object obj = typeof(List<AdaptivePerformanceScaler>) + 1528;
			object obj2 = typeof(MemberAchievementClanFeedData) + 1808;
			object contentType = "alignContent" + 2136;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			List<object> list = default(List<object>);
			list..ctor();
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v69 @ X8_v3 (Il2CppClass<Kammelna.Server.WebRequests.FileUploadWebRequest`1<TResponse>>)+298] (should have been resolved before IL gen)");
			nint num2 = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v75 @ X8_v4 (Il2CppClass<Kammelna.Server.WebRequests.FileUploadWebRequest`1<TResponse>>)+2B8] (should have been resolved before IL gen)");
			nint num3 = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v81 @ X8_v5 (Il2CppClass<Kammelna.Server.WebRequests.FileUploadWebRequest`1<TResponse>>)+2A8] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			MultipartFormFileSection multipartFormFileSection = default(MultipartFormFileSection);
			string name = default(string);
			byte[] data = default(byte[]);
			string fileName = default(string);
			multipartFormFileSection..ctor(name, data, fileName, (string)contentType);
			if (list != null)
			{
				int version = list._version + 1;
				list._version = version;
				object[] items = list._items;
				if (list._items != null)
				{
					bool flag = list._size < items.Length;
					object obj3 = !flag;
					if (obj3 == null)
					{
						int size = list._size + 1;
						list._size = size;
						object obj4 = list._items + list._size;
						object obj5 = obj4 + 32;
						obj5 = multipartFormFileSection;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					}
					else
					{
						list.AddWithResize((object)multipartFormFileSection);
					}
					return (List<IMultipartFormSection>)(object)list;
				}
			}
			return (List<IMultipartFormSection>)(object)new NullReferenceException();
		}
	}

	protected FileUploadWebRequest()
	{
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4ADD4B8");
	}
}
