using System;
using System.Collections.Generic;
using contract_newtonsoft.Model;
using Newtonsoft.Json;

namespace contract_newtonsoft
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			const string jsonConfig = @"[
											{
												'product': 'LiveJSONgenerator',
												'version': 3.1,
												'releaseDate': '2014-06-25T00: 00: 00.000Z',
												'demo': true,
												'serviceId' : 'marketing'    
											}
										]";

			var deserializeObject = ReadFromConfig(jsonConfig);

			DisplayOnController(deserializeObject);

			Console.Read();
		}

		private static IList<Service> ReadFromConfig(string jsonPayload)
		{
			var deserializeObject = JsonConvert.DeserializeObject<IList<Service>>(jsonPayload);
			Console.WriteLine("Deserialized Product ::: " + deserializeObject[0].Product);
			Console.WriteLine("Deserialized Version ::: " + deserializeObject[0].Version);
			Console.WriteLine("Deserialized ReleaseDate ::: " + deserializeObject[0].ReleaseDate);
			Console.WriteLine("Deserialized Demo ::: " + deserializeObject[0].Demo);
			Console.WriteLine("Deserialized Service id ::: " + deserializeObject[0].ServiceId);
			return deserializeObject;
		}

		private static void DisplayOnController(IList<Service> services)
		{
			// Serialize
			var serializeObject = JsonConvert.SerializeObject(services, Formatting.Indented);
			Console.WriteLine(serializeObject);
		}
	}
}