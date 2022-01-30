using EmployeeManagementSystem.ApplicationServices.Interfaces;
using EmployeeManagementSystem.Repositories.Interfaces;

namespace EmployeeManagementSystem.ApplicationServices
{
    public class TestCService : ITestCService
    {
        #region Private Variables
        private ITestCRepository _TestCRepo;
        #endregion

        #region Constructors
        public TestCService(ITestCRepository testCRepo)
        {
            _TestCRepo = testCRepo;
        }
        #endregion

        #region Public Methods

        public string GetName()
        {
            return _TestCRepo.GetName();
        }
        #endregion
    }
}
