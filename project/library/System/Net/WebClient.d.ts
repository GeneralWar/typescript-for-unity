declare namespace System
{
	declare namespace Net
	{
		export class WebClient extends System.ComponentModel.Component
		{
			public constructor();
			public CancelAsync(): void;
			public DownloadData(address: string): number[];
			public DownloadData(address: System.Uri): number[];
			public DownloadDataAsync(address: System.Uri): void;
			public DownloadDataAsync(address: System.Uri, userToken: any): void;
			public DownloadFile(address: string, fileName: string): void;
			public DownloadFile(address: System.Uri, fileName: string): void;
			public DownloadFileAsync(address: System.Uri, fileName: string): void;
			public DownloadFileAsync(address: System.Uri, fileName: string, userToken: any): void;
			public DownloadFileTaskAsync(address: string, fileName: string): System.Threading.Tasks.Task;
			public DownloadFileTaskAsync(address: System.Uri, fileName: string): System.Threading.Tasks.Task;
			public DownloadString(address: string): string;
			public DownloadString(address: System.Uri): string;
			public DownloadStringAsync(address: System.Uri): void;
			public DownloadStringAsync(address: System.Uri, userToken: any): void;
			public OpenRead(address: string): System.IO.Stream;
			public OpenRead(address: System.Uri): System.IO.Stream;
			public OpenReadAsync(address: System.Uri): void;
			public OpenReadAsync(address: System.Uri, userToken: any): void;
			public OpenWrite(address: string): System.IO.Stream;
			public OpenWrite(address: System.Uri): System.IO.Stream;
			public OpenWrite(address: string, method: string): System.IO.Stream;
			public OpenWrite(address: System.Uri, method: string): System.IO.Stream;
			public OpenWriteAsync(address: System.Uri): void;
			public OpenWriteAsync(address: System.Uri, method: string): void;
			public OpenWriteAsync(address: System.Uri, method: string, userToken: any): void;
			public UploadData(address: string, data: number[]): number[];
			public UploadData(address: System.Uri, data: number[]): number[];
			public UploadData(address: string, method: string, data: number[]): number[];
			public UploadData(address: System.Uri, method: string, data: number[]): number[];
			public UploadDataAsync(address: System.Uri, data: number[]): void;
			public UploadDataAsync(address: System.Uri, method: string, data: number[]): void;
			public UploadDataAsync(address: System.Uri, method: string, data: number[], userToken: any): void;
			public UploadFile(address: string, fileName: string): number[];
			public UploadFile(address: System.Uri, fileName: string): number[];
			public UploadFile(address: string, method: string, fileName: string): number[];
			public UploadFile(address: System.Uri, method: string, fileName: string): number[];
			public UploadFileAsync(address: System.Uri, fileName: string): void;
			public UploadFileAsync(address: System.Uri, method: string, fileName: string): void;
			public UploadFileAsync(address: System.Uri, method: string, fileName: string, userToken: any): void;
			public UploadString(address: string, data: string): string;
			public UploadString(address: System.Uri, data: string): string;
			public UploadString(address: string, method: string, data: string): string;
			public UploadString(address: System.Uri, method: string, data: string): string;
			public UploadStringAsync(address: System.Uri, data: string): void;
			public UploadStringAsync(address: System.Uri, method: string, data: string): void;
			public UploadStringAsync(address: System.Uri, method: string, data: string, userToken: any): void;
			public UploadValues(address: string, data: System.Collections.Specialized.NameValueCollection): number[];
			public UploadValues(address: System.Uri, data: System.Collections.Specialized.NameValueCollection): number[];
			public UploadValues(address: string, method: string, data: System.Collections.Specialized.NameValueCollection): number[];
			public UploadValues(address: System.Uri, method: string, data: System.Collections.Specialized.NameValueCollection): number[];
			public UploadValuesAsync(address: System.Uri, data: System.Collections.Specialized.NameValueCollection): void;
			public UploadValuesAsync(address: System.Uri, method: string, data: System.Collections.Specialized.NameValueCollection): void;
			public UploadValuesAsync(address: System.Uri, method: string, data: System.Collections.Specialized.NameValueCollection, userToken: any): void;
			public get Encoding(): System.Text.Encoding;
			public set Encoding(): System.Text.Encoding;
			public get BaseAddress(): string;
			public set BaseAddress(): string;
			public get Credentials(): any;
			public set Credentials(): any;
			public get UseDefaultCredentials(): boolean;
			public set UseDefaultCredentials(): boolean;
			public get Headers(): System.Net.WebHeaderCollection;
			public set Headers(): System.Net.WebHeaderCollection;
			public get QueryString(): System.Collections.Specialized.NameValueCollection;
			public set QueryString(): System.Collections.Specialized.NameValueCollection;
			public get ResponseHeaders(): System.Net.WebHeaderCollection;
			public get Proxy(): any;
			public set Proxy(): any;
			public get CachePolicy(): System.Net.Cache.RequestCachePolicy;
			public set CachePolicy(): System.Net.Cache.RequestCachePolicy;
			public get IsBusy(): boolean;
		}
	}
}
