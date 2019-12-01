using UnityEngine;

namespace General.Typescript
{
	public class SystemNetHttpStatusCode
	{
		static public void Bind(Namespace space)
		{
			Enum<System.Net.HttpStatusCode> instance = space.DeclareEnum<System.Net.HttpStatusCode>();
			instance.SetValue("Continue", (long)System.Net.HttpStatusCode.Continue);
			instance.SetValue("SwitchingProtocols", (long)System.Net.HttpStatusCode.SwitchingProtocols);
			instance.SetValue("OK", (long)System.Net.HttpStatusCode.OK);
			instance.SetValue("Created", (long)System.Net.HttpStatusCode.Created);
			instance.SetValue("Accepted", (long)System.Net.HttpStatusCode.Accepted);
			instance.SetValue("NonAuthoritativeInformation", (long)System.Net.HttpStatusCode.NonAuthoritativeInformation);
			instance.SetValue("NoContent", (long)System.Net.HttpStatusCode.NoContent);
			instance.SetValue("ResetContent", (long)System.Net.HttpStatusCode.ResetContent);
			instance.SetValue("PartialContent", (long)System.Net.HttpStatusCode.PartialContent);
			instance.SetValue("MultipleChoices", (long)System.Net.HttpStatusCode.MultipleChoices);
			instance.SetValue("Ambiguous", (long)System.Net.HttpStatusCode.Ambiguous);
			instance.SetValue("MovedPermanently", (long)System.Net.HttpStatusCode.MovedPermanently);
			instance.SetValue("Moved", (long)System.Net.HttpStatusCode.Moved);
			instance.SetValue("Found", (long)System.Net.HttpStatusCode.Found);
			instance.SetValue("Redirect", (long)System.Net.HttpStatusCode.Redirect);
			instance.SetValue("SeeOther", (long)System.Net.HttpStatusCode.SeeOther);
			instance.SetValue("RedirectMethod", (long)System.Net.HttpStatusCode.RedirectMethod);
			instance.SetValue("NotModified", (long)System.Net.HttpStatusCode.NotModified);
			instance.SetValue("UseProxy", (long)System.Net.HttpStatusCode.UseProxy);
			instance.SetValue("Unused", (long)System.Net.HttpStatusCode.Unused);
			instance.SetValue("TemporaryRedirect", (long)System.Net.HttpStatusCode.TemporaryRedirect);
			instance.SetValue("RedirectKeepVerb", (long)System.Net.HttpStatusCode.RedirectKeepVerb);
			instance.SetValue("BadRequest", (long)System.Net.HttpStatusCode.BadRequest);
			instance.SetValue("Unauthorized", (long)System.Net.HttpStatusCode.Unauthorized);
			instance.SetValue("PaymentRequired", (long)System.Net.HttpStatusCode.PaymentRequired);
			instance.SetValue("Forbidden", (long)System.Net.HttpStatusCode.Forbidden);
			instance.SetValue("NotFound", (long)System.Net.HttpStatusCode.NotFound);
			instance.SetValue("MethodNotAllowed", (long)System.Net.HttpStatusCode.MethodNotAllowed);
			instance.SetValue("NotAcceptable", (long)System.Net.HttpStatusCode.NotAcceptable);
			instance.SetValue("ProxyAuthenticationRequired", (long)System.Net.HttpStatusCode.ProxyAuthenticationRequired);
			instance.SetValue("RequestTimeout", (long)System.Net.HttpStatusCode.RequestTimeout);
			instance.SetValue("Conflict", (long)System.Net.HttpStatusCode.Conflict);
			instance.SetValue("Gone", (long)System.Net.HttpStatusCode.Gone);
			instance.SetValue("LengthRequired", (long)System.Net.HttpStatusCode.LengthRequired);
			instance.SetValue("PreconditionFailed", (long)System.Net.HttpStatusCode.PreconditionFailed);
			instance.SetValue("RequestEntityTooLarge", (long)System.Net.HttpStatusCode.RequestEntityTooLarge);
			instance.SetValue("RequestUriTooLong", (long)System.Net.HttpStatusCode.RequestUriTooLong);
			instance.SetValue("UnsupportedMediaType", (long)System.Net.HttpStatusCode.UnsupportedMediaType);
			instance.SetValue("RequestedRangeNotSatisfiable", (long)System.Net.HttpStatusCode.RequestedRangeNotSatisfiable);
			instance.SetValue("ExpectationFailed", (long)System.Net.HttpStatusCode.ExpectationFailed);
			instance.SetValue("UpgradeRequired", (long)System.Net.HttpStatusCode.UpgradeRequired);
			instance.SetValue("InternalServerError", (long)System.Net.HttpStatusCode.InternalServerError);
			instance.SetValue("NotImplemented", (long)System.Net.HttpStatusCode.NotImplemented);
			instance.SetValue("BadGateway", (long)System.Net.HttpStatusCode.BadGateway);
			instance.SetValue("ServiceUnavailable", (long)System.Net.HttpStatusCode.ServiceUnavailable);
			instance.SetValue("GatewayTimeout", (long)System.Net.HttpStatusCode.GatewayTimeout);
			instance.SetValue("HttpVersionNotSupported", (long)System.Net.HttpStatusCode.HttpVersionNotSupported);
		}
	}
}
