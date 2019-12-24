using UnityEngine;

namespace General.Typescript
{
	public class SystemNetFtpStatusCode
	{
		static public void Bind(Namespace space)
		{
			Enum<System.Net.FtpStatusCode> instance = space.DeclareEnum<System.Net.FtpStatusCode>();
			instance.SetValue("Undefined", (long)System.Net.FtpStatusCode.Undefined);
			instance.SetValue("RestartMarker", (long)System.Net.FtpStatusCode.RestartMarker);
			instance.SetValue("ServiceTemporarilyNotAvailable", (long)System.Net.FtpStatusCode.ServiceTemporarilyNotAvailable);
			instance.SetValue("DataAlreadyOpen", (long)System.Net.FtpStatusCode.DataAlreadyOpen);
			instance.SetValue("OpeningData", (long)System.Net.FtpStatusCode.OpeningData);
			instance.SetValue("CommandOK", (long)System.Net.FtpStatusCode.CommandOK);
			instance.SetValue("CommandExtraneous", (long)System.Net.FtpStatusCode.CommandExtraneous);
			instance.SetValue("DirectoryStatus", (long)System.Net.FtpStatusCode.DirectoryStatus);
			instance.SetValue("FileStatus", (long)System.Net.FtpStatusCode.FileStatus);
			instance.SetValue("SystemType", (long)System.Net.FtpStatusCode.SystemType);
			instance.SetValue("SendUserCommand", (long)System.Net.FtpStatusCode.SendUserCommand);
			instance.SetValue("ClosingControl", (long)System.Net.FtpStatusCode.ClosingControl);
			instance.SetValue("ClosingData", (long)System.Net.FtpStatusCode.ClosingData);
			instance.SetValue("EnteringPassive", (long)System.Net.FtpStatusCode.EnteringPassive);
			instance.SetValue("LoggedInProceed", (long)System.Net.FtpStatusCode.LoggedInProceed);
			instance.SetValue("ServerWantsSecureSession", (long)System.Net.FtpStatusCode.ServerWantsSecureSession);
			instance.SetValue("FileActionOK", (long)System.Net.FtpStatusCode.FileActionOK);
			instance.SetValue("PathnameCreated", (long)System.Net.FtpStatusCode.PathnameCreated);
			instance.SetValue("SendPasswordCommand", (long)System.Net.FtpStatusCode.SendPasswordCommand);
			instance.SetValue("NeedLoginAccount", (long)System.Net.FtpStatusCode.NeedLoginAccount);
			instance.SetValue("FileCommandPending", (long)System.Net.FtpStatusCode.FileCommandPending);
			instance.SetValue("ServiceNotAvailable", (long)System.Net.FtpStatusCode.ServiceNotAvailable);
			instance.SetValue("CantOpenData", (long)System.Net.FtpStatusCode.CantOpenData);
			instance.SetValue("ConnectionClosed", (long)System.Net.FtpStatusCode.ConnectionClosed);
			instance.SetValue("ActionNotTakenFileUnavailableOrBusy", (long)System.Net.FtpStatusCode.ActionNotTakenFileUnavailableOrBusy);
			instance.SetValue("ActionAbortedLocalProcessingError", (long)System.Net.FtpStatusCode.ActionAbortedLocalProcessingError);
			instance.SetValue("ActionNotTakenInsufficientSpace", (long)System.Net.FtpStatusCode.ActionNotTakenInsufficientSpace);
			instance.SetValue("CommandSyntaxError", (long)System.Net.FtpStatusCode.CommandSyntaxError);
			instance.SetValue("ArgumentSyntaxError", (long)System.Net.FtpStatusCode.ArgumentSyntaxError);
			instance.SetValue("CommandNotImplemented", (long)System.Net.FtpStatusCode.CommandNotImplemented);
			instance.SetValue("BadCommandSequence", (long)System.Net.FtpStatusCode.BadCommandSequence);
			instance.SetValue("NotLoggedIn", (long)System.Net.FtpStatusCode.NotLoggedIn);
			instance.SetValue("AccountNeeded", (long)System.Net.FtpStatusCode.AccountNeeded);
			instance.SetValue("ActionNotTakenFileUnavailable", (long)System.Net.FtpStatusCode.ActionNotTakenFileUnavailable);
			instance.SetValue("ActionAbortedUnknownPageType", (long)System.Net.FtpStatusCode.ActionAbortedUnknownPageType);
			instance.SetValue("FileActionAborted", (long)System.Net.FtpStatusCode.FileActionAborted);
			instance.SetValue("ActionNotTakenFilenameNotAllowed", (long)System.Net.FtpStatusCode.ActionNotTakenFilenameNotAllowed);
		}
	}
}
