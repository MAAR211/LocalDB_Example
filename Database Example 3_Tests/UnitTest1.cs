using Database_Example_3.HelloWorldDB;
using Database_Example_3.Models;
using DependencyInjectionExample;

using FakeItEasy;
using FakeItEasy.Sdk;
using Microsoft.EntityFrameworkCore;
using System;

namespace Depencency_Injection_1_Tests

{




    public class Tests

    {

        [SetUp]

        public void Setup()

        {

        }



        [TestFixture]

        public class JobseekerBLTests

        {

            [Test]

            public void GetAllJobseeker_Test()

            {


                //iqmneba fake object romelic daaimplementirebs IJobseekerDAL interfeiss
                //fake-it vanacvleb radgan namdvili baza ar mchirdeba aq
                //idea - daitestos kodis siswore gareshe monacemebisgan damoukideblad

                var jobseekerDAL = A.Fake<IJobseekerDAL>();

                //JobseekerBL klass gadavcem jobseekerDAL fake obieqts rom JobseekerBL klasis metodebma fake bazas uyuros
                // Dependency Injection - constructor injection

                var jobseekerBL = new JobseekerBL(jobseekerDAL);


                // fake jobseekerebis sia 
                var fakeJobseekers = new List<Jobseeker>
        {
            new Jobseeker { Name = "John Doe" },
            new Jobseeker { Name = "Jane Smith" },
            new Jobseeker { Name = "Bob Johnson" }
                };


                //  A.CallTo is a method provided by the FakeItEasy library that creates a fake call to a method or property on an object.

                // SelectAllJobseeker metodit fake jobseekerebi unda dabrundes

                A.CallTo(() => jobseekerDAL.SelectAllJobseekers()).Returns(fakeJobseekers);

                //GetAllJobseekerNames metodis gamodzaxeba jobseekerBL-dan romelic fake bazas iyenebs  
                var result = jobseekerBL.GetAllJobseekerNames();

                //expected bazas qmnis fakeJobseekerebis saxelebit
                var expected = fakeJobseekers.Select(j => j.Name).ToList();

                //amowmebs monacemis tipi sworad brundeba tu ara
                //tu implementacia metodis sworia mashin jobseekerebis saxelebis list unda daabrunos
                Assert.IsInstanceOf<List<string>>(result);


                //amowmebs rom GetAllJobseekerNames metodi jobseekerebis saxelebis swor raodenobas abrunebs
                Assert.AreEqual(expected.Count, result.Count);





                //amowmebs rom GetAllJobseekerNames metodi jobseekerebebis swor saxelebs abrunebs swori mimdevrobit
                Assert.AreEqual(expected[0], result[0]);
                Assert.AreEqual(expected[1], result[1]);
                Assert.AreEqual(expected[2], result[2]);
            }




            [Test]
            public void GetAllJobseekerNames_ReturnsEmptyList_WhenSelectAllJobseekersReturnsEmptyList()
            {
                var jobseekerDAL = A.Fake<IJobseekerDAL>();
                var jobseekerBL = new JobseekerBL(jobseekerDAL);

                //SelectAllJobseeker metodi cariel empty lists daabrunebs
                A.CallTo(() => jobseekerDAL.SelectAllJobseekers()).Returns(new List<Jobseeker>());

                //radgan SelectAllJobseeker empty dabrunda GetAllJobseekerNames metodis gamodzaxebis shedegic carieli iqneba
                var result = jobseekerBL.GetAllJobseekerNames();
               
           
                Assert.IsEmpty(result);
            }


            [Test]
            public void GetAllJobseekerNames_ThrowsException_WhenSelectAllJobseekersThrowsException()
            {
                var jobseekerDAL = A.Fake<IJobseekerDAL>();
                var jobseekerBL = new JobseekerBL(jobseekerDAL);

                // SelectAllJobseekers - database error exception
                A.CallTo(() => jobseekerDAL.SelectAllJobseekers()).Throws(new Exception("Database error"));

                //shemowmeba rom GetAllJobseekerNames throws an exception roca bazis eroria
                Assert.Throws<Exception>(() => jobseekerBL.GetAllJobseekerNames());
            }


            [Test]
            public void CountJobseekersWithName_ReturnsCorrectCount_ForGivenName()
            {
                var jobseekerDAL = A.Fake<IJobseekerDAL>();
                var jobseekerBL = new JobseekerBL(jobseekerDAL);

                var fakeJobseekers = new List<Jobseeker>
                  {
                      new Jobseeker { Name = "John Doe" },
                      new Jobseeker { Name = "Jane Smith" },
                      new Jobseeker { Name = "Bob Johnson" },
                      new Jobseeker { Name = "John Doe" },
                      new Jobseeker { Name = "John Doe" }
                  };

                A.CallTo(() => jobseekerDAL.SelectAllJobseekers()).Returns(fakeJobseekers);

                var result = jobseekerBL.CountJobseekersWithName("John Doe");
                var expected = 3;

                Assert.AreEqual(expected, result);
            }

        }





        [TestFixture]
        public class HelloWorldBLTests
        {
            [Test]
            public void AddJobseeker_ValidPerson_SuccessfullyAdds()
            {


                var jobseeker = new Persons
                {
                    FirstName = "Lika",
                    LastName = "Gelovani",
                    Address = "123 Qavtaradze st",
                    City = "Tbilisi"
                };


                //IHelloWorldDAL - interfeisis fake -is sheqmna
                //HelloWorldBL  damokidebulia IHelloWorldDAL interfeisze, amitom amis fake-is sheqmnaa sachiro
                var hwDAL = A.Fake<IHelloWorldDAL>();



                //GetMaxPersonID- metodis fake iqmneba da vutiteb rom 0 daabrunos -MaxPersonID
                A.CallTo(() => hwDAL.GetMaxPersonID()).Returns(0);


                //GetJobseekerByID -  metodis fake iqmneba da null unda daabrunos 
                //igulisxmeba rom shesamabisi jobseeker ar unda moidzebnos rom axali chaweros
                //  A<int>._ an  A<int>.Ignored -   aq igulisxmeba rom nebismieri parametri sheidzleba hqondes GetJobseekerByID metods da null unda daabrunos mainc
                A.CallTo(() => hwDAL.GetJobseekerByID(A<int>._)).Returns(null);


                // AddJobseeker metodis fake implementacia
                //igive jobseeker unda daabrunos rac gadaeca
                //amowmebs rom AddJobseeker metodi sworad mushaobs da swor mnishvnelobas abrunebs
                A.CallTo(() => hwDAL.AddJobseeker(jobseeker)).Returns(jobseeker);


                //HelloWorldBL klasis obieqts vqmni romelsac fake hwDAL cvlads gadavcem
                //HelloWorldBL klasis shemowmeba minda IHelloWorldDAL interfeisisgan damoukideblad
                var hwBL = new HelloWorldBL(hwDAL);

                //HelloWorldBL klasis AddJobseeker metodis gamodzaxeba jobseeker parametrit
                var result = hwBL.AddJobseeker(jobseeker);


                //amowmebs rom GetMaxPersonID metodis gamodzaxeba ertxel mainc moxda hwDAL fake obieqtistvis
                //AddJobseeker metodi rom sworad mushaobs amas amowmebs da aseve unikaluri ID rom hqondes jobseekers
                A.CallTo(() => hwDAL.GetMaxPersonID()).MustHaveHappened();


                //amowmebs rom GetJobseekerByID metodis gamodzaxeba ertxel mainc moxda hwDAL fake obieqtistvis - swori argumentit
                //AddJobseeker metodi rom ar mushaobdes sworad GetJobseekerByID metodi ar daabrunebs mosalodnel jobseeker -is obieqts
                A.CallTo(() => hwDAL.GetJobseekerByID(jobseeker.PersonID)).MustHaveHappened();


                //amowmebs rom AddJobseeker metodis gamodzaxeba ertxel mainc moxda hwDAL fake obieqtistvis
                A.CallTo(() => hwDAL.AddJobseeker(jobseeker)).MustHaveHappened();

                //amowmebs rom AddJobseekeris metodis mier dabrunebuli jobseeker obieqti igivea rac result
                Assert.AreEqual(jobseeker, result);
            }





            //ar mushaobs es :((((((

            [Test]
            public void AddJobseeker_ShouldThrowException_WhenPersonIDIsNotUnique()
            {

                var jobseeker = new Persons
                {
                    PersonID = 1,
                    FirstName = "Lika",
                    LastName = "Gelovani",
                    Address = "123 Qavtaradze st",
                    City = "Tbilisi"
                };

                var hwDAL = A.Fake<IHelloWorldDAL>();

               
                //  1 unda daabrunos GetMaxPersonID metodma
                A.CallTo(() => hwDAL.GetMaxPersonID()).Returns(1);

                // hwDAL fake - tvis gamodzaxebit, GetJobseekerByID metodi abrunebs jobseeker obieqts roca gamodzaxeba xdeba jobseeker.PersonID parametrit

               A.CallTo(() => hwDAL.GetJobseekerByID(jobseeker.PersonID)).Returns(jobseeker);


                var hwBL = new HelloWorldBL(hwDAL);

                //hwBL klasis AddJobseeker metodis gamodzaxeba xdeba jobseeker obieqtistvis romelic ukve arsebobs bazashi
                //amitom Exception unda iyos
                Assert.Throws<ArgumentException>(() => hwBL.AddJobseeker(jobseeker));

            }



        }


    }
}








