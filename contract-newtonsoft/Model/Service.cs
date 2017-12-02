using System;
using contract;

namespace contract_newtonsoft.Model
{
    public class Service : IService
    {
        public string Product { get; set; }
        public string Version { get; set; }
        public DateTime ReleaseDate { get; set; }
        public bool Demo { get; set; }
        public ServiceId ServiceId { get; set; }
    }
}