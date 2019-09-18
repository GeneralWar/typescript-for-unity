declare namespace UnityEngine
{
	export class LocationInfo extends System.ValueType
	{
		public get latitude(): number;
		public get longitude(): number;
		public get altitude(): number;
		public get horizontalAccuracy(): number;
		public get verticalAccuracy(): number;
		public get timestamp(): number;
	}
}
