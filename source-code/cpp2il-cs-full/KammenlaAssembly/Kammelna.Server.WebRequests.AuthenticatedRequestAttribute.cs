using Cpp2ILInjected;

namespace Kammelna.Server.WebRequests;

public class AuthenticatedRequestAttribute : WebRequestDecoratorAttribute
{
	private readonly bool <IsOptional>k__BackingField;

	public override int Priority => 100;

	public bool IsOptional
	{
		get
		{
			return <IsOptional>k__BackingField;
		}
		set
		{
			<IsOptional>k__BackingField = value;
		}
	}

	public override WebRequestDecorator<T> MakeDecoratorInstance<T>(IWebRequest<T> webRequest)
	{
		//IL_001b: Expected O, but got I
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0043: Expected O, but got I4
		bool flag = <IsOptional>k__BackingField;
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		bool flag2 = obj2 == null;
		object obj3 = !flag2;
		nint num = 0;
		nint num2 = 0;
		bool isOptional = <IsOptional>k__BackingField;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			isOptional = flag;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		WebRequestDecorator<T> webRequestDecorator = default(WebRequestDecorator<T>);
		((TokenAuthenticatedRequestDecorator<T>)webRequestDecorator)..ctor(webRequest, isOptional);
		return webRequestDecorator;
	}
}
