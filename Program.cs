using System;
using ConsumirWebService.Model;
using System.Collections.Generic;
using ConsumirWebService.enums;
using HelloWS;


namespace ConsumirWebService
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>()
            {
              new Person(){idPerson =1, firstName = "Daniel"},
              new Person(){idPerson =2, firstName = "Kaleb"},
              new Person(){idPerson =3, firstName = "Anielka"},
              new Person(){idPerson =4, firstName = "Winston"}
            };

            List<OtherInfo> infos = new List<OtherInfo>()
            {
                new OtherInfo(){idPerson=1, fieldName="telefono", fieldDataType="String", fieldValue="83253696"},
                new OtherInfo(){idPerson=1, fieldName="correo1", fieldDataType="String", fieldValue="dtm07"},
                new OtherInfo(){idPerson=1, fieldName="corredo2", fieldDataType="String", fieldValue="dtm08"},
                new OtherInfo(){idPerson=2, fieldName="telsefono", fieldDataType="String", fieldValue="83253696"},
                new OtherInfo(){idPerson=2, fieldName="corsreo1", fieldDataType="String", fieldValue="dtm07"},
                new OtherInfo(){idPerson=2, fieldName="corfdreo2", fieldDataType="String", fieldValue="dtm08"},
                new OtherInfo(){idPerson=3, fieldName="telgfefono", fieldDataType="String", fieldValue="83253696"},
                new OtherInfo(){idPerson=3, fieldName="corgfreo1", fieldDataType="String", fieldValue="dtm07"},
                new OtherInfo(){idPerson=3, fieldName="corrgfeo2", fieldDataType="String", fieldValue="dtm08"}
            };

            List<OtherInfo> newdatainfo = new List<OtherInfo>();
            foreach (Person person in persons)
            {
              
                foreach (OtherInfo info in infos)
                {
                    if (person.idPerson == info.idPerson)
                        {
                        newdatainfo.Add(new OtherInfo()
                        {
                            idPerson=info.idPerson,
                            fieldName=info.fieldName,
                            fieldDataType=info.fieldDataType,
                            fieldValue=info.fieldValue
                        });
                        person.otherInfos=newdatainfo;
                        }
                }
            }
            
            ConsumirWS(persons, newdatainfo);



        }
        private static void ConsumirWS(List<Person> people, List<OtherInfo> others)
        {


            foreach(Person person in people)
            {
                Console.WriteLine(person.firstName);
                Console.WriteLine("*************");

                foreach (OtherInfo other in others)
                {
                    if (person.idPerson == other.idPerson){
                        Console.WriteLine(other.fieldName);
                        Console.WriteLine(other.fieldDataType);
                        Console.WriteLine(other.fieldValue);
                    }
                }

                Console.WriteLine("*************");


                //HelloEndpointClient client = new HelloEndpointClient();
                //helloRequest request = new helloRequest { Name = person.firstName };
                //SayHello sayHello = new SayHello(request);
                //SayHelloResponse response = client.SayHello(sayHello);
                // Console.WriteLine(response.HelloResponse.Message);
            }


        }
    }
}
