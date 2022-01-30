using EmployeeManagementSystem.ApplicationServices.Interfaces;
using EmployeeManagementSystem.Repositories.Interfaces;

namespace EmployeeManagementSystem.ApplicationServices
{
    public class TestAService : ITestAService
    {
        #region Private Variables
        private ITestARepository _TestARepo;
        #endregion

        #region Constructors
        public TestAService(ITestARepository testARepo)
        {
            _TestARepo = testARepo;
        }
        #endregion

        #region Public Methods

        public string GetName()
        {
            return _TestARepo.GetName();
        }
        #endregion
    }
}
