using EmployeeManagementSystem.ApplicationServices.Interfaces;
using EmployeeManagementSystem.Repositories.Interfaces;

namespace EmployeeManagementSystem.ApplicationServices
{
    public class TestOService : ITestOService
    {
        #region Private Variables
        private ITestORepository _TestORepo;
        #endregion

        #region Constructors
        public TestOService(ITestORepository testORepo)
        {
            _TestORepo = testORepo;
        }
        #endregion

        #region Public Methods

        public string GetName()
        {
            return _TestORepo.GetName();
        }
        #endregion
    }
}
