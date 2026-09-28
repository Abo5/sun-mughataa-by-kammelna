using System;

namespace Kammelna.Server.WebRequests;

public abstract class WebRequestDecoratorAttribute : Attribute
{
	public virtual int Priority => 0;

	public abstract WebRequestDecorator<T> MakeDecoratorInstance<T>(IWebRequest<T> webRequest);
}
