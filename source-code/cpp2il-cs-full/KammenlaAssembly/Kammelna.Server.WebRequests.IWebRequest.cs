using System;
using System.Collections;
using UnityEngine.Networking;

namespace Kammelna.Server.WebRequests;

public interface IWebRequest<TResponse> : IDisposable
{
	string RequestUrl { get; }

	IClientContext ClientContext { get; }

	UnityWebRequest UnityRequest { get; }

	KammelnaResponseModel<TResponse> Response { get; set; }

	void Setup();

	IEnumerator Execute();

	IEnumerator Materialize();
}
