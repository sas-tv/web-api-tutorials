using EmployeeManagementSystem.ApplicationServices.Interfaces;
using EmployeeManagementSystem.Repositories.Interfaces;

namespace EmployeeManagementSystem.ApplicationServices
{
    public class TestJService : ITestJService
    {
        #region Private Variables
        private ITestJRepository _TestJRepo;
        #endregion

        #region Constructors
        public TestJService(ITestJRepository testJRepo)
        {
            _TestJRepo = testJRepo;
        }
        #endregion

        #region Public Methods

        public string GetName()
        {
            return _TestJRepo.GetName();
        }
        #endregion
    }
}
