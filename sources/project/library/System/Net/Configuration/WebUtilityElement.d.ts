declare namespace System
{
	declare namespace Net
	{
		declare namespace Configuration
		{
			export class WebUtilityElement extends System.Configuration.ConfigurationElement
			{
				public constructor();
				public get UnicodeDecodingConformance(): number;
				public set UnicodeDecodingConformance(): number;
				public get UnicodeEncodingConformance(): number;
				public set UnicodeEncodingConformance(): number;
			}
		}
	}
}
