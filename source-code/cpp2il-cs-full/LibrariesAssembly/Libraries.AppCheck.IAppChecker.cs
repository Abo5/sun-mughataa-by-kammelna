namespace Libraries.AppCheck;

internal interface IAppChecker
{
	AppCheckerStrategy AppChecker { get; }

	bool IsSupported { get; }

	bool RequireSignature { get; }

	void Initialize();

	void GetToken(string userKey, string requestHash, AppCheckResult callback);

	void Clear();
}
