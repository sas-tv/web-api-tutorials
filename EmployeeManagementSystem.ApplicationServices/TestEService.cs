using EmployeeManagementSystem.ApplicationServices.Interfaces;
using EmployeeManagementSystem.Repositories.Interfaces;

namespace EmployeeManagementSystem.ApplicationServices
{
    public class TestEService : ITestEService
    {
        #region Private Variables
        private ITestERepository _TestERepo;
        #endregion

        #region Constructors
        public TestEService(ITestERepository testERepo)
        {
            _TestERepo = testERepo;
        }
        #endregion

        #region Public Methods

        public string GetName()
        {
            return _TestERepo.GetName();
        }
        #endregion
    }
}
