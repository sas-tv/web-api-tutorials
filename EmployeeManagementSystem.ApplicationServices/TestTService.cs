using EmployeeManagementSystem.ApplicationServices.Interfaces;
using EmployeeManagementSystem.Repositories.Interfaces;

namespace EmployeeManagementSystem.ApplicationServices
{
    public class TestTService : ITestTService
    {
        #region Private Variables
        private ITestTRepository _TestTRepo;
        #endregion

        #region Constructors
        public TestTService(ITestTRepository testTRepo)
        {
            _TestTRepo = testTRepo;
        }
        #endregion

        #region Public Methods

        public string GetName()
        {
            return _TestTRepo.GetName();
        }
        #endregion
    }
}
