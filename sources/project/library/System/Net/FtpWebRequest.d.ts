declare namespace System
{
	declare namespace Net
	{
		export class FtpWebRequest extends System.Net.WebRequest
		{
			static public get DefaultCachePolicy(): System.Net.Cache.RequestCachePolicy;
			static public set DefaultCachePolicy(): System.Net.Cache.RequestCachePolicy;
			public Abort(): void;
			public EndGetRequestStream(asyncResult: any): System.IO.Stream;
			public EndGetResponse(asyncResult: any): System.Net.WebResponse;
			public GetRequestStream(): System.IO.Stream;
			public GetResponse(): System.Net.WebResponse;
			public get ClientCertificates(): System.Security.Cryptography.X509Certificates.X509CertificateCollection;
			public set ClientCertificates(): System.Security.Cryptography.X509Certificates.X509CertificateCollection;
			public get UseDefaultCredentials(): number;
			public set UseDefaultCredentials(): number;
			public get UsePassive(): number;
			public set UsePassive(): number;
			public get ServicePoint(): System.Net.ServicePoint;
			public get RequestUri(): System.Uri;
			public get RenameTo(): string;
			public set RenameTo(): string;
			public get ReadWriteTimeout(): number;
			public set ReadWriteTimeout(): number;
			public get Proxy(): any;
			public set Proxy(): any;
			public get PreAuthenticate(): number;
			public set PreAuthenticate(): number;
			public get Method(): string;
			public set Method(): string;
			public get KeepAlive(): number;
			public set KeepAlive(): number;
			public get Headers(): System.Net.WebHeaderCollection;
			public set Headers(): System.Net.WebHeaderCollection;
			public get EnableSsl(): number;
			public set EnableSsl(): number;
			public get Credentials(): any;
			public set Credentials(): any;
			public get ContentOffset(): number;
			public set ContentOffset(): number;
			public get ContentLength(): number;
			public set ContentLength(): number;
			public get ContentType(): string;
			public set ContentType(): string;
			public get ConnectionGroupName(): string;
			public set ConnectionGroupName(): string;
			public get UseBinary(): number;
			public set UseBinary(): number;
			public get Timeout(): number;
			public set Timeout(): number;
		}
	}
}
