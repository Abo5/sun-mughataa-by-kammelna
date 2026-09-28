using Cpp2ILInjected;

namespace Kammelna.Server.WebRequests.Cache;

public class CachedRequestAttribute : WebRequestDecoratorAttribute
{
	private readonly string _cachedModelKey;

	public override int Priority => 200;

	public CachedRequestAttribute(string cachedModelKey)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		object obj = this + 16;
		obj = cachedModelKey;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public override WebRequestDecorator<T> MakeDecoratorInstance<T>(IWebRequest<T> webRequest)
	{
		//IL_001b: Expected O, but got I
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0043: Expected O, but got I4
		string cachedModelKey = _cachedModelKey;
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		nint num2 = 0;
		string cachedModelKey2 = _cachedModelKey;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			cachedModelKey2 = cachedModelKey;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		WebRequestDecorator<T> webRequestDecorator = default(WebRequestDecorator<T>);
		((CachedRequestDecorator<T>)webRequestDecorator)..ctor(cachedModelKey2, webRequest);
		return webRequestDecorator;
	}
}
