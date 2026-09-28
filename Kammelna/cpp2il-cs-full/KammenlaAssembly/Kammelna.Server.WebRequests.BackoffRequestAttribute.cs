using Cpp2ILInjected;

namespace Kammelna.Server.WebRequests;

public class BackoffRequestAttribute : WebRequestDecoratorAttribute
{
	public override int Priority => 150;

	public override WebRequestDecorator<T> MakeDecoratorInstance<T>(IWebRequest<T> webRequest)
	{
		//IL_0011: Expected O, but got I
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_0039: Expected O, but got I4
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		nint num = 0;
		nint num2 = 0;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		WebRequestDecorator<T> webRequestDecorator = default(WebRequestDecorator<T>);
		((BackoffRequestDecorator<T>)webRequestDecorator)..ctor(webRequest);
		return webRequestDecorator;
	}
}
