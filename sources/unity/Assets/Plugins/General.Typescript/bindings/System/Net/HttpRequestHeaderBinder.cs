using UnityEngine;

namespace General.Typescript
{
	public class SystemNetHttpRequestHeader
	{
		static public void Bind(Namespace space)
		{
			Enum<System.Net.HttpRequestHeader> instance = space.DeclareEnum<System.Net.HttpRequestHeader>();
			instance.SetValue("CacheControl", (long)System.Net.HttpRequestHeader.CacheControl);
			instance.SetValue("Connection", (long)System.Net.HttpRequestHeader.Connection);
			instance.SetValue("Date", (long)System.Net.HttpRequestHeader.Date);
			instance.SetValue("KeepAlive", (long)System.Net.HttpRequestHeader.KeepAlive);
			instance.SetValue("Pragma", (long)System.Net.HttpRequestHeader.Pragma);
			instance.SetValue("Trailer", (long)System.Net.HttpRequestHeader.Trailer);
			instance.SetValue("TransferEncoding", (long)System.Net.HttpRequestHeader.TransferEncoding);
			instance.SetValue("Upgrade", (long)System.Net.HttpRequestHeader.Upgrade);
			instance.SetValue("Via", (long)System.Net.HttpRequestHeader.Via);
			instance.SetValue("Warning", (long)System.Net.HttpRequestHeader.Warning);
			instance.SetValue("Allow", (long)System.Net.HttpRequestHeader.Allow);
			instance.SetValue("ContentLength", (long)System.Net.HttpRequestHeader.ContentLength);
			instance.SetValue("ContentType", (long)System.Net.HttpRequestHeader.ContentType);
			instance.SetValue("ContentEncoding", (long)System.Net.HttpRequestHeader.ContentEncoding);
			instance.SetValue("ContentLanguage", (long)System.Net.HttpRequestHeader.ContentLanguage);
			instance.SetValue("ContentLocation", (long)System.Net.HttpRequestHeader.ContentLocation);
			instance.SetValue("ContentMd5", (long)System.Net.HttpRequestHeader.ContentMd5);
			instance.SetValue("ContentRange", (long)System.Net.HttpRequestHeader.ContentRange);
			instance.SetValue("Expires", (long)System.Net.HttpRequestHeader.Expires);
			instance.SetValue("LastModified", (long)System.Net.HttpRequestHeader.LastModified);
			instance.SetValue("Accept", (long)System.Net.HttpRequestHeader.Accept);
			instance.SetValue("AcceptCharset", (long)System.Net.HttpRequestHeader.AcceptCharset);
			instance.SetValue("AcceptEncoding", (long)System.Net.HttpRequestHeader.AcceptEncoding);
			instance.SetValue("AcceptLanguage", (long)System.Net.HttpRequestHeader.AcceptLanguage);
			instance.SetValue("Authorization", (long)System.Net.HttpRequestHeader.Authorization);
			instance.SetValue("Cookie", (long)System.Net.HttpRequestHeader.Cookie);
			instance.SetValue("Expect", (long)System.Net.HttpRequestHeader.Expect);
			instance.SetValue("From", (long)System.Net.HttpRequestHeader.From);
			instance.SetValue("Host", (long)System.Net.HttpRequestHeader.Host);
			instance.SetValue("IfMatch", (long)System.Net.HttpRequestHeader.IfMatch);
			instance.SetValue("IfModifiedSince", (long)System.Net.HttpRequestHeader.IfModifiedSince);
			instance.SetValue("IfNoneMatch", (long)System.Net.HttpRequestHeader.IfNoneMatch);
			instance.SetValue("IfRange", (long)System.Net.HttpRequestHeader.IfRange);
			instance.SetValue("IfUnmodifiedSince", (long)System.Net.HttpRequestHeader.IfUnmodifiedSince);
			instance.SetValue("MaxForwards", (long)System.Net.HttpRequestHeader.MaxForwards);
			instance.SetValue("ProxyAuthorization", (long)System.Net.HttpRequestHeader.ProxyAuthorization);
			instance.SetValue("Referer", (long)System.Net.HttpRequestHeader.Referer);
			instance.SetValue("Range", (long)System.Net.HttpRequestHeader.Range);
			instance.SetValue("Te", (long)System.Net.HttpRequestHeader.Te);
			instance.SetValue("Translate", (long)System.Net.HttpRequestHeader.Translate);
			instance.SetValue("UserAgent", (long)System.Net.HttpRequestHeader.UserAgent);
		}
	}
}
