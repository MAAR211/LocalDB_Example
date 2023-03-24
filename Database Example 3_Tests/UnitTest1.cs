using Database_Example_3.Models;
using DependencyInjectionExample;

using FakeItEasy;
using FakeItEasy.Sdk;

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
    }
}








