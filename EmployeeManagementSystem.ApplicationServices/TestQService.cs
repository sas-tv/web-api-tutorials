using EmployeeManagementSystem.ApplicationServices.Interfaces;
using EmployeeManagementSystem.Repositories.Interfaces;

namespace EmployeeManagementSystem.ApplicationServices
{
    public class TestQService : ITestQService
    {
        #region Private Variables
        private ITestQRepository _TestQRepo;
        #endregion

        #region Constructors
        public TestQService(ITestQRepository testQRepo)
        {
            _TestQRepo = testQRepo;
        }
        #endregion

        #region Public Methods

        public string GetName()
        {
            return _TestQRepo.GetName();
        }
        #endregion
    }
}
