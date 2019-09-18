declare namespace System
{
	declare namespace Net
	{
		declare namespace Configuration
		{
			export class HttpWebRequestElement extends System.Configuration.ConfigurationElement
			{
				public constructor();
				public get MaximumErrorResponseLength(): number;
				public set MaximumErrorResponseLength(): number;
				public get MaximumResponseHeadersLength(): number;
				public set MaximumResponseHeadersLength(): number;
				public get MaximumUnauthorizedUploadLength(): number;
				public set MaximumUnauthorizedUploadLength(): number;
				public get UseUnsafeHeaderParsing(): number;
				public set UseUnsafeHeaderParsing(): number;
			}
		}
	}
}
