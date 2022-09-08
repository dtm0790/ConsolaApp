using System;
using System.Collections.Generic;
using System.Text;


namespace ConsumirWebService.Model
{
    public class Person
    {
        public int idPerson { get; set; }
        public string firstName { get; set; }
       public List<OtherInfo> otherInfos { get; set; }
    }
}
