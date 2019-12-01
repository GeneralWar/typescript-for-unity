using UnityEngine;

namespace General.Typescript
{
	public class SystemNetHttpResponseHeader
	{
		static public void Bind(Namespace space)
		{
			Enum<System.Net.HttpResponseHeader> instance = space.DeclareEnum<System.Net.HttpResponseHeader>();
			instance.SetValue("CacheControl", (long)System.Net.HttpResponseHeader.CacheControl);
			instance.SetValue("Connection", (long)System.Net.HttpResponseHeader.Connection);
			instance.SetValue("Date", (long)System.Net.HttpResponseHeader.Date);
			instance.SetValue("KeepAlive", (long)System.Net.HttpResponseHeader.KeepAlive);
			instance.SetValue("Pragma", (long)System.Net.HttpResponseHeader.Pragma);
			instance.SetValue("Trailer", (long)System.Net.HttpResponseHeader.Trailer);
			instance.SetValue("TransferEncoding", (long)System.Net.HttpResponseHeader.TransferEncoding);
			instance.SetValue("Upgrade", (long)System.Net.HttpResponseHeader.Upgrade);
			instance.SetValue("Via", (long)System.Net.HttpResponseHeader.Via);
			instance.SetValue("Warning", (long)System.Net.HttpResponseHeader.Warning);
			instance.SetValue("Allow", (long)System.Net.HttpResponseHeader.Allow);
			instance.SetValue("ContentLength", (long)System.Net.HttpResponseHeader.ContentLength);
			instance.SetValue("ContentType", (long)System.Net.HttpResponseHeader.ContentType);
			instance.SetValue("ContentEncoding", (long)System.Net.HttpResponseHeader.ContentEncoding);
			instance.SetValue("ContentLanguage", (long)System.Net.HttpResponseHeader.ContentLanguage);
			instance.SetValue("ContentLocation", (long)System.Net.HttpResponseHeader.ContentLocation);
			instance.SetValue("ContentMd5", (long)System.Net.HttpResponseHeader.ContentMd5);
			instance.SetValue("ContentRange", (long)System.Net.HttpResponseHeader.ContentRange);
			instance.SetValue("Expires", (long)System.Net.HttpResponseHeader.Expires);
			instance.SetValue("LastModified", (long)System.Net.HttpResponseHeader.LastModified);
			instance.SetValue("AcceptRanges", (long)System.Net.HttpResponseHeader.AcceptRanges);
			instance.SetValue("Age", (long)System.Net.HttpResponseHeader.Age);
			instance.SetValue("ETag", (long)System.Net.HttpResponseHeader.ETag);
			instance.SetValue("Location", (long)System.Net.HttpResponseHeader.Location);
			instance.SetValue("ProxyAuthenticate", (long)System.Net.HttpResponseHeader.ProxyAuthenticate);
			instance.SetValue("RetryAfter", (long)System.Net.HttpResponseHeader.RetryAfter);
			instance.SetValue("Server", (long)System.Net.HttpResponseHeader.Server);
			instance.SetValue("SetCookie", (long)System.Net.HttpResponseHeader.SetCookie);
			instance.SetValue("Vary", (long)System.Net.HttpResponseHeader.Vary);
			instance.SetValue("WwwAuthenticate", (long)System.Net.HttpResponseHeader.WwwAuthenticate);
		}
	}
}
