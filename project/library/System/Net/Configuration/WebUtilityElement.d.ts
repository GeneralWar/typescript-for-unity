declare namespace System
{
	declare namespace Net
	{
		declare namespace Configuration
		{
			export class WebUtilityElement extends System.Configuration.ConfigurationElement
			{
				public constructor();
				public get UnicodeDecodingConformance(): System.Net.Configuration.UnicodeDecodingConformance;
				public set UnicodeDecodingConformance(): System.Net.Configuration.UnicodeDecodingConformance;
				public get UnicodeEncodingConformance(): System.Net.Configuration.UnicodeEncodingConformance;
				public set UnicodeEncodingConformance(): System.Net.Configuration.UnicodeEncodingConformance;
			}
		}
	}
}
