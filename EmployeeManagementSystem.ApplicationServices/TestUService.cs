using EmployeeManagementSystem.ApplicationServices.Interfaces;
using EmployeeManagementSystem.Repositories.Interfaces;

namespace EmployeeManagementSystem.ApplicationServices
{
    public class TestUService : ITestUService
    {
        #region Private Variables
        private ITestURepository _TestURepo;
        #endregion

        #region Constructors
        public TestUService(ITestURepository testURepo)
        {
            _TestURepo = testURepo;
        }
        #endregion

        #region Public Methods

        public string GetName()
        {
            return _TestURepo.GetName();
        }
        #endregion
    }
}
