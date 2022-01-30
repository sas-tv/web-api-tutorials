using EmployeeManagementSystem.ApplicationServices.Interfaces;
using EmployeeManagementSystem.Repositories.Interfaces;

namespace EmployeeManagementSystem.ApplicationServices
{
    public class TestNService : ITestNService
    {
        #region Private Variables
        private ITestNRepository _TestNRepo;
        #endregion

        #region Constructors
        public TestNService(ITestNRepository testNRepo)
        {
            _TestNRepo = testNRepo;
        }
        #endregion

        #region Public Methods

        public string GetName()
        {
            return _TestNRepo.GetName();
        }
        #endregion
    }
}
